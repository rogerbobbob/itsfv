using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace iTSfvLib
{
    public class XmlTrack
    {
        #region "Read/Write Properties"

        public DateTime PlayedDate { get; set; }

        public DateTime SkippedDate { get; set; }

        public bool Compilation { get; set; }

        public bool Enabled { get; set; }

        public bool ExcludeFromShuffle { get; set; }

        public bool PartOfGaplessAlbum { get; set; }

        public bool RememberBookmark { get; set; }

        public bool Unplayed { get; set; }

        public int AlbumRating { get; set; }

        public int BPM { get; set; }

        public int BookmarkTime { get; set; }

        public uint DiscCount { get; set; }

        public uint DiscNumber { get; set; }

        public int EpisodeNumber { get; set; }

        public int Finish { get; set; }

        public int PlayedCount { get; set; }

        public int Rating { get; set; }

        public int SeasonNumber { get; set; }

        public int SkippedCount { get; set; }

        public int Start { get; set; }

        public int VolumeAdjustment { get; set; }

        public int Year { get; set; }

        public string Album { get; set; }

        public string Band { get; set; }

        public string Artist { get; set; }

        public string Category { get; set; }

        public string Comment { get; set; }

        public string Composer { get; set; }

        public string Description { get; set; }

        public string EQ { get; set; }

        public string EpisodeID { get; set; }

        public string Genre { get; set; }

        public string Grouping { get; set; }

        public string Location { get; set; }

        public string LongDescription { get; set; }

        public string Lyrics { get; set; }

        public string Name { get; set; }

        public string Show { get; set; }

        public string SortAlbum { get; set; }

        public string SortAlbumArtist { get; set; }

        public string SortArtist { get; set; }

        public string SortComposer { get; set; }

        public string SortName { get; set; }

        public string SortShow { get; set; }

        public string URL { get; set; }

        public uint TrackCount { get; set; }

        public uint TrackNumber { get; set; }

        #endregion "Read/Write Properties"

        #region "Read Only Properties"

        public string ID { get; private set; }

        public DateTime DateAdded { get; private set; }

        public DateTime ModificationDate { get; private set; }

        public DateTime ReleaseDate { get; private set; }

        public List<XmlArtwork> Artwork { get; private set; }

        public bool Podcast { get; private set; }

        public int BitRate { get; private set; }

        public int Duration { get; private set; }

        public int Index { get; private set; }

        public int PlayOrderIndex { get; private set; }

        public int SampleRate { get; private set; }

        public int Size { get; private set; }

        public int Size64High { get; private set; }

        public int Size64Low { get; private set; }

        public int TrackDatabaseID { get; private set; }

        public int playlistID { get; private set; }

        public int sourceID { get; private set; }

        public int trackID { get; private set; }

        public string KindAsString { get; private set; }

        public string Time { get; private set; }

        public string FileName
        {
            get
            {
                return !string.IsNullOrEmpty(Location) ? Path.GetFileName(Location) : string.Empty;
            }
        }

        public string[] AlbumArtists { get; private set; }

        public string[] Artists { get; private set; }

        public string[] Genres { get; private set; }

        #endregion "Read Only Properties"

        public XmlTrack(string fp)
        {
            Artwork = new List<XmlArtwork>();
            Location = fp;
            UpdateInfoFromFile(fp);
        }

        public void Play()
        {
            try
            {
                Process.Start(this.Location);
            }
            catch (Exception ex)
            {
                FileSystem.AppendDebug("Error playing track", ex);
            }
        }

        public void UpdateInfoFromFile(string fp)
        {
            try
            {
                TagLib.File f = TagLib.File.Create(Location);
                // Update Properties
                this.TrackNumber = f.Tag.Track;
                this.TrackCount = f.Tag.TrackCount;
                this.Name = f.Tag.Title;
                this.Album = f.Tag.Album;
                this.AlbumArtists = f.Tag.AlbumArtists;
                this.Artists = f.Tag.Performers;
                this.Genres = f.Tag.Genres;
                this.ID = this.Name + this.Album;
            }
            catch (Exception ex)
            {
                FileSystem.AppendDebug("Error updating info from file", ex);
            }
        }
    }
}