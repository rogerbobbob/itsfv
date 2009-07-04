using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTunesLib;

namespace iTSfvLib
{
    class Track : IITTrack
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
    }
}
