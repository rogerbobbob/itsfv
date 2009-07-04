using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTunesLib;

namespace iTSfvLib
{
    class FileOrCDTrack : IITFileOrCDTrack
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

        #endregion

        #region "Read Only Properties"

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


        public string AlbumArtist
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int AlbumRating
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public ITRatingKind AlbumRatingKind
        {
            get { throw new NotImplementedException(); }
        }

        public int BookmarkTime
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Category
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Description
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string EpisodeID
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int EpisodeNumber
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool ExcludeFromShuffle
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Location
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string LongDescription
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Lyrics
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool PartOfGaplessAlbum
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IITPlaylistCollection Playlists
        {
            get { throw new NotImplementedException(); }
        }

        public bool Podcast
        {
            get { throw new NotImplementedException(); }
        }

        public DateTime ReleaseDate
        {
            get { throw new NotImplementedException(); }
        }

        public bool RememberBookmark
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Reveal()
        {
            throw new NotImplementedException();
        }

        public int SeasonNumber
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Show
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Size64High
        {
            get { throw new NotImplementedException(); }
        }

        public int Size64Low
        {
            get { throw new NotImplementedException(); }
        }

        public int SkippedCount
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public DateTime SkippedDate
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string SortAlbum
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string SortAlbumArtist
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string SortArtist
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string SortComposer
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string SortName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string SortShow
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool Unplayed
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void UpdateInfoFromFile()
        {
            throw new NotImplementedException();
        }

        public void UpdatePodcastFeed()
        {
            throw new NotImplementedException();
        }

        public ITVideoKind VideoKind
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public ITRatingKind ratingKind
        {
            get { throw new NotImplementedException(); }
        }
    }
}
