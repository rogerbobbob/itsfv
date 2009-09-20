using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTunesLib;

namespace iTSfvLib
{
    public class XmlTrack
    {
        #region "Read/Write Properties"

        public string Album { get; set; }
        public string Artist { get; set; }
        public int BPM { get; set; }
        public string Comment { get; set; }
        public bool Compilation { get; set; }
        public string Composer { get; set; }
        public int DiscCount { get; set; }
        public int DiscNumber { get; set; }
        public string EQ { get; set; }
        public bool Enabled { get; set; }
        public int Finish { get; set; }
        public string Genre { get; set; }
        public string Grouping { get; set; }
        public string Name { get; set; }
        public int PlayedCount { get; set; }
        public DateTime PlayedDate { get; set; }
        public int Rating { get; set; }
        public int Start { get; set; }
        public int TrackCount { get; set; }
        public int TrackNumber { get; set; }
        public int VolumeAdjustment { get; set; }
        public int Year { get; set; }
        public int BookmarkTime { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string EpisodeID { get; set; }
        public int EpisodeNumber { get; set; }
        public bool ExcludeFromShuffle { get; set; }
        public string Location { get; set; }
        public string LongDescription { get; set; }
        public string Lyrics { get; set; }
        public bool PartOfGaplessAlbum { get; set; }
        public int SkippedCount { get; set; }
        public DateTime SkippedDate { get; set; }
        public string SortAlbum { get; set; }
        public string SortAlbumArtist { get; set; }
        public string SortArtist { get; set; }
        public string SortComposer { get; set; }
        public string SortName { get; set; }
        public string SortShow { get; set; }
        public bool Unplayed { get; set; }
        public ITVideoKind VideoKind { get; set; }
        public string AlbumArtist { get; set; }
        public int AlbumRating { get; set; }
        public string URL { get; set; }
        public bool RememberBookmark { get; set; }
        public int SeasonNumber { get; set; }
        public string Show { get; set; }

        #endregion

        #region "Read Only Properties"

        public ITRatingKind AlbumRatingKind { get; private set; }
        public IITPlaylistCollection Playlists { get; private set; }
        public bool Podcast { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public IITArtworkCollection Artwork { get; private set; }
        public int BitRate { get; private set; }
        public DateTime DateAdded { get; private set; }
        public int Duration { get; private set; }
        public int Index { get; private set; }
        public ITTrackKind Kind { get; private set; }
        public string KindAsString { get; private set; }
        public DateTime ModificationDate { get; private set; }
        public IITPlaylist Playlist { get; private set; }
        public int PlayOrderIndex { get; private set; }
        public int SampleRate { get; private set; }
        public int Size { get; private set; }
        public string Time { get; private set; }
        public int TrackDatabaseID { get; private set; }
        public int playlistID { get; private set; }
        public int sourceID { get; private set; }
        public int trackID { get; private set; }
        public int Size64High { get; private set; }
        public int Size64Low { get; private set; }

        #endregion

        #region "Methods"

        public IITArtwork AddArtworkFromFile(string filePath)
        {
            return this.AddArtworkFromFile(filePath);
        }

        public void Delete()
        {
            this.Delete();
        }

        public void GetITObjectIDs(out int sourceID, out int playlistID, out int trackID, out int databaseID)
        {
            this.GetITObjectIDs(out sourceID, out playlistID, out trackID, out databaseID);
        }

        public void Play()
        {
            this.Play();
        }

        #endregion


        public void Reveal()
        {
            throw new NotImplementedException();
        }




        public void UpdateInfoFromFile()
        {
            throw new NotImplementedException();
        }

        public void UpdatePodcastFeed()
        {
            throw new NotImplementedException();
        }

        public ITRatingKind ratingKind
        {
            get { throw new NotImplementedException(); }
        }

        public XmlTrack(IITTrack track)
        {

        }

        public XmlTrack(IITURLTrack track)
        {

        }

        public XmlTrack(IITFileOrCDTrack track)
        {

        }

    }
}
