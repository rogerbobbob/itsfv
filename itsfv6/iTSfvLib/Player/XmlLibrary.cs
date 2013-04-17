using HelpersLib;
using iTSfvLib.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace iTSfvLib
{
    /// <summary>
    /// Class that holds a List of AlbumArtist - highest in the hierachy
    /// </summary>
    public class XmlLibrary
    {
        public BackgroundWorker Worker = new BackgroundWorker() { WorkerReportsProgress = true, WorkerSupportsCancellation = true };
        public Dictionary<string, XmlAlbumArtist> Library = new Dictionary<string, XmlAlbumArtist>();
        public ReportWriter Report { get; set; }

        public List<XmlAlbumArtist> AlbumArtists { get; private set; }
        public List<XmlAlbum> Albums { get; private set; }  // provides a faster way to iterate through albums
        public List<XmlDisc> Discs { get; private set; }    // provides a faster way to iterate through discs
        public List<XmlTrack> Tracks { get; private set; }    // provides a faster way to iterate through tracks

        private XMLSettings Config = null;

        public double TrackProgress = 0;

        public XmlLibrary(XMLSettings config)
        {
            Report = new ReportWriter();
            AlbumArtists = new List<XmlAlbumArtist>();
            Albums = new List<XmlAlbum>();
            Discs = new List<XmlDisc>();
            Tracks = new List<XmlTrack>();

            Config = config;

            Worker.DoWork += Worker_DoWork;
        }

        public void AddFilesOrFolders(string[] filesOrFolders)
        {
            List<XmlTrack> tracks = new List<XmlTrack>();

            foreach (string pfd in filesOrFolders)
            {
                if (Directory.Exists(pfd))
                {
                    // todo: respect windows explorer folder structure
                    foreach (string ext in Config.SupportedAudioTypes)
                    {
                        foreach (string fp in Directory.GetFiles(pfd, string.Format("*.{0}", ext), SearchOption.AllDirectories))
                        {
                            tracks.Add(new XmlTrack(fp));
                        }
                    }
                }
                else if (File.Exists(pfd))
                {
                    tracks.Add(new XmlTrack(pfd));
                }
            }

            tracks.ForEach(x => AddTrack(x));
        }

        public void AddTracks(List<XmlTrack> tracks)
        {
            tracks.ForEach(x => AddTrack(x));
        }

        /// <summary>
        /// Method to add a track to Player
        /// </summary>
        /// <param name="track"></param>
        public void AddTrack(XmlTrack track)
        {
            XmlAlbumArtist tempBand = GetBand(track.AlbumArtist);
            if (tempBand == null)
            {
                tempBand = new XmlAlbumArtist(track.AlbumArtist);
                Library.Add(tempBand.Name, tempBand);
                AlbumArtists.Add(tempBand);
            }

            XmlAlbum tempAlbum = tempBand.GetAlbum(track.GetAlbumKey());
            if (tempAlbum == null)
            {
                tempAlbum = new XmlAlbum(track.GetAlbumKey());
                Library[track.AlbumArtist].AddAlbum(tempAlbum);
                Albums.Add(tempAlbum);
            }

            XmlDisc tempDisc = tempAlbum.GetDisc(track.GetDiscKey());
            if (tempDisc == null)
            {
                tempDisc = new XmlDisc(track.GetDiscKey());
                Library[track.AlbumArtist].GetAlbum(track.GetAlbumKey()).AddDisc(tempDisc);
                Discs.Add(tempDisc);
            }

            if (Library[track.AlbumArtist].GetAlbum(track.GetAlbumKey()).GetDisc(track.GetDiscKey()).AddTrack(track))
            {
                Tracks.Add(track);
            }
        }

        public void AddBand(XmlAlbumArtist o)
        {
            if (!Library.ContainsKey(o.Name))
                Library.Add(o.Name, o);
        }

        public XmlAlbumArtist GetBand(string key)
        {
            if (Library.ContainsKey(key))
                return Library[key];

            return null;
        }

        public void RemoveBand(XmlAlbumArtist o)
        {
            if (Library.ContainsKey(o.Name))
                Library.Remove(o.Name);
        }

        private int Progress
        {
            get
            {
                if (this.Tracks.Count > 0)
                    return (int)(++TrackProgress / this.Tracks.Count * 100);

                return 0;
            }
        }

        public void RunTasks()
        {
            Worker.RunWorkerAsync();
        }

        void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Validate();
            e.Result = this.Report;
        }

        /// <summary>
        /// This method validates the entire library or selected album artists
        /// </summary>
        private void Validate()
        {
            if (Config.CopyMusicToLibrary && Directory.Exists(Config.MusicLibraryFolder))
            {
                foreach (XmlTrack track in this.Tracks)
                {
                    if (File.Exists(track.Location) && !track.Location.Contains(Config.MusicLibraryFolder))
                    {
                        string dp = Path.Combine(Config.MusicLibraryFolder, track.AlbumArtistPathFriendly, track.Tags.Album);
                        if (!Directory.Exists(dp))
                            Directory.CreateDirectory(dp);
                        string fp = Path.Combine(dp, Path.GetFileName(track.Location));
                        DebugHelper.WriteLine(string.Format("Copying {0} to {1}", track.Location, fp));
                        File.Copy(track.Location, fp);
                        track.Location = fp;
                        Worker.ReportProgress(this.Progress, track);
                    }
                }
                TrackProgress = 0;
            }

            IEnumerator e = Library.GetEnumerator();
            KeyValuePair<string, XmlAlbumArtist> currBand = new KeyValuePair<string, XmlAlbumArtist>();

            while (e.MoveNext())
            {
                currBand = (KeyValuePair<string, XmlAlbumArtist>)e.Current;
                ValidateBand(currBand.Value);
            }
        }

        public void ValidateBand(XmlAlbumArtist band)
        {
            IEnumerator e = band.Albums.GetEnumerator();
            KeyValuePair<string, XmlAlbum> currAlbum = new KeyValuePair<string, XmlAlbum>();

            while (e.MoveNext())
            {
                currAlbum = (KeyValuePair<string, XmlAlbum>)e.Current;
                ValidateAlbum(currAlbum.Value);
            }
        }

        public void ValidateAlbum(XmlAlbum album)
        {
            IEnumerator e = album.Discs.GetEnumerator();
            while (e.MoveNext())
            {
                ValidateDisc(((KeyValuePair<string, XmlDisc>)e.Current).Value);
            }

            if (this.Config.UI.FileSystem_ArtworkJpgExport)
            {
                foreach (XmlTrack track in album.GetTracks())
                {
                    if (track.ExportArtwork(Config))
                    {
                        break;
                    }
                }
            }
        }

        public void ValidateDisc(XmlDisc disc)
        {
            foreach (XmlTrack track in disc.Tracks)
            {
                ValidateTrack(track);
            }
        }

        public void ValidateTrack(XmlTrack track)
        {
            if (this.Config.UI.Tracks_ArtworkFill)
                track.EmbedArtwork(this.Config, this.Report);

            if (this.Config.UI.Tracks_AlbumArtistFill)
                track.FillAlbumArtist(Albums, this.Report);

            if (this.Config.UI.Tracks_GenreFill)
                track.FillGenre(Discs, this.Report);

            if (this.Config.UI.Tracks_TrackCountFill)
                track.FillTrackCount(Albums, Discs, this.Report);

            // do checks after updating tracks

            if (this.Config.UI.Checks_MissingTags) 
                track.CheckMissingTags(this.Report);

            if (this.Config.UI.Checks_ArtworkLowRes)
                track.CheckLowResArtwork(this.Config, this.Report);

            // write tags if modified

            if (track.IsModified)
                track.WriteTagsToFile();

            Worker.ReportProgress(this.Progress, track);
        }
    }
}