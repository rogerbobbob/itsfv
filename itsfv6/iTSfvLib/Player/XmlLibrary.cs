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

        private XMLSettings CoreConfig = null;

        public double TracksCount = 0;
        public double TrackCurrent = 0;

        public XmlLibrary(XMLSettings coreConfig)
        {
            Report = new ReportWriter();
            AlbumArtists = new List<XmlAlbumArtist>();
            Albums = new List<XmlAlbum>();
            Discs = new List<XmlDisc>();

            CoreConfig = coreConfig;

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
                    foreach (string ext in CoreConfig.SupportedAudioTypes)
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

            foreach (XmlTrack track in tracks)
            {
                AddTrack(track);
            }
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
                TracksCount++;
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

        public List<XmlTrack> GetTracksFromAlbum(XmlAlbum album)
        {
            List<XmlTrack> tracks = new List<XmlTrack>();
            IEnumerator iDisc = album.Discs.GetEnumerator();
            KeyValuePair<string, XmlDisc> kvpDisc = new KeyValuePair<string, XmlDisc>();

            while (iDisc.MoveNext())
            {
                kvpDisc = (KeyValuePair<string, XmlDisc>)iDisc.Current;
                XmlDisc disc = kvpDisc.Value;
                foreach (XmlTrack track in disc.Tracks)
                {
                    tracks.Add(track);
                }
            }

            return tracks;
        }

        public int Progress
        {
            get
            {
                if (TracksCount > 0)
                    return (int)(TrackCurrent / TracksCount * 100);

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
            IEnumerator iPlayer = Library.GetEnumerator();
            KeyValuePair<string, XmlAlbumArtist> currBand = new KeyValuePair<string, XmlAlbumArtist>();

            while (iPlayer.MoveNext())
            {
                currBand = (KeyValuePair<string, XmlAlbumArtist>)iPlayer.Current;
                ValidateBand(currBand.Value);
            }
        }

        public void ValidateBand(XmlAlbumArtist band)
        {
            IEnumerator iBand = band.Albums.GetEnumerator();
            KeyValuePair<string, XmlAlbum> currAlbum = new KeyValuePair<string, XmlAlbum>();

            while (iBand.MoveNext())
            {
                currAlbum = (KeyValuePair<string, XmlAlbum>)iBand.Current;
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

            if (this.CoreConfig.UI.FileSystem_ArtworkJpgExport)
            {
                foreach (XmlTrack track in album.GetTracks())
                {
                    if (track.ExportArtwork(CoreConfig))
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
            if (this.CoreConfig.UI.Checks_MissingTags)
                track.CheckMissingTags(this.Report);

            if (this.CoreConfig.UI.Tracks_AlbumArtistFill)
                track.FillAlbumArtist(Albums, this.Report);

            if (this.CoreConfig.UI.Tracks_GenreFill)
                track.FillGenre(Discs, this.Report);

            if (this.CoreConfig.UI.Tracks_TrackCountFill)
                track.FillTrackCount(Albums, Discs, this.Report);

            if (track.IsModified)
                track.WriteTagsToFile();

            TrackCurrent++;
            Worker.ReportProgress(this.Progress, track);
        }
    }
}