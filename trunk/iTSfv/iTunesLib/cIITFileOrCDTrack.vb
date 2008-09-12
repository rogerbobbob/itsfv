Imports iTunesLib

Public Class cIITFileOrCDTrack
    Implements IITFileOrCDTrack

    Private mTrack As IITFileOrCDTrack

    Public Sub New(ByVal track As IITFileOrCDTrack)
        mTrack = track
    End Sub

    Public Function AddArtworkFromFile(ByVal filePath As String) As iTunesLib.IITArtwork Implements iTunesLib.IITFileOrCDTrack.AddArtworkFromFile
        mTrack.AddArtworkFromFile(filePath)
        Return mTrack.Artwork.Item(1)
    End Function

    Public Property Album() As String Implements iTunesLib.IITFileOrCDTrack.Album
        Get
            Return mTrack.Album
        End Get
        Set(ByVal value As String)
            mTrack.Album = value
        End Set
    End Property

    Public Property AlbumArtist() As String Implements iTunesLib.IITFileOrCDTrack.AlbumArtist
        Get
            Return mGetAlbumArtist(mTrack)
        End Get
        Set(ByVal value As String)
            mTrack.AlbumArtist = value
        End Set
    End Property

    Public Property AlbumRating() As Integer Implements iTunesLib.IITFileOrCDTrack.AlbumRating
        Get
            Return mTrack.AlbumRating
        End Get
        Set(ByVal value As Integer)
            mTrack.AlbumRating = value
        End Set
    End Property

    Public ReadOnly Property AlbumRatingKind() As iTunesLib.ITRatingKind Implements iTunesLib.IITFileOrCDTrack.AlbumRatingKind
        Get
            Return mTrack.AlbumRatingKind
        End Get
    End Property

    Public Property Artist() As String Implements iTunesLib.IITFileOrCDTrack.Artist
        Get
            Return fGetArtist(mTrack)
        End Get
        Set(ByVal value As String)
            mTrack.Artist = value
        End Set
    End Property

    Public ReadOnly Property Artwork() As iTunesLib.IITArtworkCollection Implements iTunesLib.IITFileOrCDTrack.Artwork
        Get
            Return mTrack.Artwork
        End Get
    End Property

    Public ReadOnly Property BitRate() As Integer Implements iTunesLib.IITFileOrCDTrack.BitRate
        Get
            Return mTrack.BitRate
        End Get
    End Property

    Public Property BookmarkTime() As Integer Implements iTunesLib.IITFileOrCDTrack.BookmarkTime
        Get
            Return mTrack.BookmarkTime
        End Get
        Set(ByVal value As Integer)
            mTrack.BookmarkTime = value
        End Set
    End Property

    Public Property BPM() As Integer Implements iTunesLib.IITFileOrCDTrack.BPM
        Get
            Return mTrack.BPM
        End Get
        Set(ByVal value As Integer)
            mTrack.BPM = value
        End Set
    End Property

    Public Property Category() As String Implements iTunesLib.IITFileOrCDTrack.Category
        Get
            Return mTrack.Category
        End Get
        Set(ByVal value As String)
            mTrack.Category = value
        End Set
    End Property

    Public Property Comment() As String Implements iTunesLib.IITFileOrCDTrack.Comment
        Get
            Return mTrack.Comment
        End Get
        Set(ByVal value As String)
            mTrack.Comment = value
        End Set
    End Property

    Public Property Compilation() As Boolean Implements iTunesLib.IITFileOrCDTrack.Compilation
        Get

        End Get
        Set(ByVal value As Boolean)

        End Set
    End Property

    Public Property Composer() As String Implements iTunesLib.IITFileOrCDTrack.Composer
        Get
            Return mTrack.Composer
        End Get
        Set(ByVal value As String)
            mTrack.Composer = value
        End Set
    End Property

    Public ReadOnly Property DateAdded() As Date Implements iTunesLib.IITFileOrCDTrack.DateAdded
        Get
            Return mTrack.DateAdded
        End Get
    End Property

    Public Sub Delete() Implements iTunesLib.IITFileOrCDTrack.Delete
        mTrack.Delete()
    End Sub

    Public Property Description() As String Implements iTunesLib.IITFileOrCDTrack.Description
        Get
            Return mTrack.Description
        End Get
        Set(ByVal value As String)
            mTrack.Description = value
        End Set
    End Property

    Public Property DiscCount() As Integer Implements iTunesLib.IITFileOrCDTrack.DiscCount
        Get

        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public Property DiscNumber() As Integer Implements iTunesLib.IITFileOrCDTrack.DiscNumber
        Get

        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public ReadOnly Property Duration() As Integer Implements iTunesLib.IITFileOrCDTrack.Duration
        Get

        End Get
    End Property

    Public Property Enabled() As Boolean Implements iTunesLib.IITFileOrCDTrack.Enabled
        Get

        End Get
        Set(ByVal value As Boolean)

        End Set
    End Property

    Public Property EpisodeID() As String Implements iTunesLib.IITFileOrCDTrack.EpisodeID
        Get
            Return mTrack.EpisodeID
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Property EpisodeNumber() As Integer Implements iTunesLib.IITFileOrCDTrack.EpisodeNumber
        Get

        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public Property EQ() As String Implements iTunesLib.IITFileOrCDTrack.EQ
        Get
            Return mTrack.EQ
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Property ExcludeFromShuffle() As Boolean Implements iTunesLib.IITFileOrCDTrack.ExcludeFromShuffle
        Get

        End Get
        Set(ByVal value As Boolean)

        End Set
    End Property

    Public Property Finish() As Integer Implements iTunesLib.IITFileOrCDTrack.Finish
        Get

        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public Property Genre() As String Implements iTunesLib.IITFileOrCDTrack.Genre
        Get
            Return mTrack.Genre
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Sub GetITObjectIDs(ByRef sourceID As Integer, ByRef playlistID As Integer, ByRef trackID As Integer, ByRef databaseID As Integer) Implements iTunesLib.IITFileOrCDTrack.GetITObjectIDs

    End Sub

    Public Property Grouping() As String Implements iTunesLib.IITFileOrCDTrack.Grouping
        Get
            Return mTrack.Grouping
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public ReadOnly Property Index() As Integer Implements iTunesLib.IITFileOrCDTrack.Index
        Get

        End Get
    End Property

    Public ReadOnly Property Kind() As iTunesLib.ITTrackKind Implements iTunesLib.IITFileOrCDTrack.Kind
        Get

        End Get
    End Property

    Public ReadOnly Property KindAsString() As String Implements iTunesLib.IITFileOrCDTrack.KindAsString
        Get
            Return mTrack.KindAsString
        End Get
    End Property

    Public ReadOnly Property Location() As String Implements iTunesLib.IITFileOrCDTrack.Location
        Get
            Try
                Return mTrack.Location
            Catch ex As Exception
                Return String.Empty
            End Try
        End Get
    End Property

    Public Property LongDescription() As String Implements iTunesLib.IITFileOrCDTrack.LongDescription
        Get
            Return mTrack.LongDescription
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Property Lyrics() As String Implements iTunesLib.IITFileOrCDTrack.Lyrics
        Get
            Return mTrack.Lyrics
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public ReadOnly Property ModificationDate() As Date Implements iTunesLib.IITFileOrCDTrack.ModificationDate
        Get

        End Get
    End Property

    Public Property Name() As String Implements iTunesLib.IITFileOrCDTrack.Name
        Get
            Return mTrack.Name
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Property PartOfGaplessAlbum() As Boolean Implements iTunesLib.IITFileOrCDTrack.PartOfGaplessAlbum
        Get

        End Get
        Set(ByVal value As Boolean)

        End Set
    End Property

    Public Sub Play() Implements iTunesLib.IITFileOrCDTrack.Play

    End Sub

    Public Property PlayedCount() As Integer Implements iTunesLib.IITFileOrCDTrack.PlayedCount
        Get

        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public Property PlayedDate() As Date Implements iTunesLib.IITFileOrCDTrack.PlayedDate
        Get

        End Get
        Set(ByVal value As Date)

        End Set
    End Property

    Public ReadOnly Property Playlist() As iTunesLib.IITPlaylist Implements iTunesLib.IITFileOrCDTrack.Playlist
        Get
            Return mTrack.Playlist
        End Get
    End Property

    Public ReadOnly Property playlistID() As Integer Implements iTunesLib.IITFileOrCDTrack.playlistID
        Get

        End Get
    End Property

    Public ReadOnly Property PlayOrderIndex() As Integer Implements iTunesLib.IITFileOrCDTrack.PlayOrderIndex
        Get

        End Get
    End Property

    Public ReadOnly Property Podcast() As Boolean Implements iTunesLib.IITFileOrCDTrack.Podcast
        Get

        End Get
    End Property

    Public Property Rating() As Integer Implements iTunesLib.IITFileOrCDTrack.Rating
        Get

        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public ReadOnly Property ratingKind() As iTunesLib.ITRatingKind Implements iTunesLib.IITFileOrCDTrack.ratingKind
        Get

        End Get
    End Property

    Public Property RememberBookmark() As Boolean Implements iTunesLib.IITFileOrCDTrack.RememberBookmark
        Get

        End Get
        Set(ByVal value As Boolean)

        End Set
    End Property

    Public Sub Reveal() Implements iTunesLib.IITFileOrCDTrack.Reveal

    End Sub

    Public ReadOnly Property SampleRate() As Integer Implements iTunesLib.IITFileOrCDTrack.SampleRate
        Get

        End Get
    End Property

    Public Property SeasonNumber() As Integer Implements iTunesLib.IITFileOrCDTrack.SeasonNumber
        Get

        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public Property Show() As String Implements iTunesLib.IITFileOrCDTrack.Show
        Get
            Return mTrack.Show
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public ReadOnly Property Size() As Integer Implements iTunesLib.IITFileOrCDTrack.Size
        Get

        End Get
    End Property

    Public ReadOnly Property Size64High() As Integer Implements iTunesLib.IITFileOrCDTrack.Size64High
        Get

        End Get
    End Property

    Public ReadOnly Property Size64Low() As Integer Implements iTunesLib.IITFileOrCDTrack.Size64Low
        Get

        End Get
    End Property

    Public Property SkippedCount() As Integer Implements iTunesLib.IITFileOrCDTrack.SkippedCount
        Get

        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public Property SkippedDate() As Date Implements iTunesLib.IITFileOrCDTrack.SkippedDate
        Get

        End Get
        Set(ByVal value As Date)

        End Set
    End Property

    Public Property SortAlbum() As String Implements iTunesLib.IITFileOrCDTrack.SortAlbum
        Get
            Return mTrack.SortAlbum
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Property SortAlbumArtist() As String Implements iTunesLib.IITFileOrCDTrack.SortAlbumArtist
        Get
            Return mTrack.SortAlbumArtist
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Property SortArtist() As String Implements iTunesLib.IITFileOrCDTrack.SortArtist
        Get
            Return mTrack.SortArtist
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Property SortComposer() As String Implements iTunesLib.IITFileOrCDTrack.SortComposer
        Get
            Return mTrack.SortComposer
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Property SortName() As String Implements iTunesLib.IITFileOrCDTrack.SortName
        Get
            Return mTrack.SortName
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Property SortShow() As String Implements iTunesLib.IITFileOrCDTrack.SortShow
        Get
            Return mTrack.SortShow
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public ReadOnly Property sourceID() As Integer Implements iTunesLib.IITFileOrCDTrack.sourceID
        Get

        End Get
    End Property

    Public Property Start() As Integer Implements iTunesLib.IITFileOrCDTrack.Start
        Get

        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public ReadOnly Property Time() As String Implements iTunesLib.IITFileOrCDTrack.Time
        Get
            Return mTrack.Time
        End Get
    End Property

    Public Property TrackCount() As Integer Implements iTunesLib.IITFileOrCDTrack.TrackCount
        Get

        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public ReadOnly Property TrackDatabaseID() As Integer Implements iTunesLib.IITFileOrCDTrack.TrackDatabaseID
        Get

        End Get
    End Property

    Public ReadOnly Property trackID() As Integer Implements iTunesLib.IITFileOrCDTrack.trackID
        Get

        End Get
    End Property

    Public Property TrackNumber() As Integer Implements iTunesLib.IITFileOrCDTrack.TrackNumber
        Get

        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public Property Unplayed() As Boolean Implements iTunesLib.IITFileOrCDTrack.Unplayed
        Get

        End Get
        Set(ByVal value As Boolean)

        End Set
    End Property

    Public Sub UpdateInfoFromFile() Implements iTunesLib.IITFileOrCDTrack.UpdateInfoFromFile

    End Sub

    Public Sub UpdatePodcastFeed() Implements iTunesLib.IITFileOrCDTrack.UpdatePodcastFeed

    End Sub

    Public Property VideoKind() As iTunesLib.ITVideoKind Implements iTunesLib.IITFileOrCDTrack.VideoKind
        Get

        End Get
        Set(ByVal value As iTunesLib.ITVideoKind)

        End Set
    End Property

    Public Property VolumeAdjustment() As Integer Implements iTunesLib.IITFileOrCDTrack.VolumeAdjustment
        Get

        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public Property Year() As Integer Implements iTunesLib.IITFileOrCDTrack.Year
        Get

        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public Sub GetITObjectIDs1(ByRef sourceID As Integer, ByRef playlistID As Integer, ByRef trackID As Integer, ByRef databaseID As Integer) Implements iTunesLib.IITObject.GetITObjectIDs

    End Sub

    Public ReadOnly Property Index1() As Integer Implements iTunesLib.IITObject.Index
        Get

        End Get
    End Property

    Public Property Name1() As String Implements iTunesLib.IITObject.Name
        Get
            Return mTrack.Name
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public ReadOnly Property playlistID1() As Integer Implements iTunesLib.IITObject.playlistID
        Get

        End Get
    End Property

    Public ReadOnly Property sourceID1() As Integer Implements iTunesLib.IITObject.sourceID
        Get

        End Get
    End Property

    Public ReadOnly Property TrackDatabaseID1() As Integer Implements iTunesLib.IITObject.TrackDatabaseID
        Get

        End Get
    End Property

    Public ReadOnly Property trackID1() As Integer Implements iTunesLib.IITObject.trackID
        Get

        End Get
    End Property

    Public Function AddArtworkFromFile1(ByVal filePath As String) As iTunesLib.IITArtwork Implements iTunesLib.IITTrack.AddArtworkFromFile
        Return mTrack.AddArtworkFromFile(filePath)
    End Function

    Public Property Album1() As String Implements iTunesLib.IITTrack.Album
        Get
            Return mTrack.Album
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Property Artist1() As String Implements iTunesLib.IITTrack.Artist
        Get
            Return mTrack.Artist
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public ReadOnly Property Artwork1() As iTunesLib.IITArtworkCollection Implements iTunesLib.IITTrack.Artwork
        Get
            Return mTrack.Artwork
        End Get
    End Property

    Public ReadOnly Property BitRate1() As Integer Implements iTunesLib.IITTrack.BitRate
        Get

        End Get
    End Property

    Public Property BPM1() As Integer Implements iTunesLib.IITTrack.BPM
        Get

        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public Property Comment1() As String Implements iTunesLib.IITTrack.Comment
        Get
            Return mTrack.Comment
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Property Compilation1() As Boolean Implements iTunesLib.IITTrack.Compilation
        Get

        End Get
        Set(ByVal value As Boolean)

        End Set
    End Property

    Public Property Composer1() As String Implements iTunesLib.IITTrack.Composer
        Get
            Return mTrack.Composer
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public ReadOnly Property DateAdded1() As Date Implements iTunesLib.IITTrack.DateAdded
        Get

        End Get
    End Property

    Public Sub Delete1() Implements iTunesLib.IITTrack.Delete

    End Sub

    Public Property DiscCount1() As Integer Implements iTunesLib.IITTrack.DiscCount
        Get

        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public Property DiscNumber1() As Integer Implements iTunesLib.IITTrack.DiscNumber
        Get

        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public ReadOnly Property Duration1() As Integer Implements iTunesLib.IITTrack.Duration
        Get

        End Get
    End Property

    Public Property Enabled1() As Boolean Implements iTunesLib.IITTrack.Enabled
        Get

        End Get
        Set(ByVal value As Boolean)

        End Set
    End Property

    Public Property EQ1() As String Implements iTunesLib.IITTrack.EQ
        Get
            Return mTrack.EQ
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Property Finish1() As Integer Implements iTunesLib.IITTrack.Finish
        Get

        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public Property Genre1() As String Implements iTunesLib.IITTrack.Genre
        Get
            Return mTrack.Genre
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Sub GetITObjectIDs2(ByRef sourceID As Integer, ByRef playlistID As Integer, ByRef trackID As Integer, ByRef databaseID As Integer) Implements iTunesLib.IITTrack.GetITObjectIDs

    End Sub

    Public Property Grouping1() As String Implements iTunesLib.IITTrack.Grouping
        Get
            Return mTrack.Grouping
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public ReadOnly Property Index2() As Integer Implements iTunesLib.IITTrack.Index
        Get

        End Get
    End Property

    Public ReadOnly Property Kind1() As iTunesLib.ITTrackKind Implements iTunesLib.IITTrack.Kind
        Get

        End Get
    End Property

    Public ReadOnly Property KindAsString1() As String Implements iTunesLib.IITTrack.KindAsString
        Get
            Return mTrack.KindAsString
        End Get
    End Property

    Public ReadOnly Property ModificationDate1() As Date Implements iTunesLib.IITTrack.ModificationDate
        Get

        End Get
    End Property

    Public Property Name2() As String Implements iTunesLib.IITTrack.Name
        Get
            Return mTrack.Name
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Sub Play1() Implements iTunesLib.IITTrack.Play

    End Sub

    Public Property PlayedCount1() As Integer Implements iTunesLib.IITTrack.PlayedCount
        Get

        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public Property PlayedDate1() As Date Implements iTunesLib.IITTrack.PlayedDate
        Get

        End Get
        Set(ByVal value As Date)

        End Set
    End Property

    Public ReadOnly Property Playlist1() As iTunesLib.IITPlaylist Implements iTunesLib.IITTrack.Playlist
        Get
            Return mTrack.Playlist
        End Get
    End Property

    Public ReadOnly Property playlistID2() As Integer Implements iTunesLib.IITTrack.playlistID
        Get

        End Get
    End Property

    Public ReadOnly Property PlayOrderIndex1() As Integer Implements iTunesLib.IITTrack.PlayOrderIndex
        Get

        End Get
    End Property

    Public Property Rating1() As Integer Implements iTunesLib.IITTrack.Rating
        Get

        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public ReadOnly Property SampleRate1() As Integer Implements iTunesLib.IITTrack.SampleRate
        Get

        End Get
    End Property

    Public ReadOnly Property Size1() As Integer Implements iTunesLib.IITTrack.Size
        Get

        End Get
    End Property

    Public ReadOnly Property sourceID2() As Integer Implements iTunesLib.IITTrack.sourceID
        Get

        End Get
    End Property

    Public Property Start1() As Integer Implements iTunesLib.IITTrack.Start
        Get

        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public ReadOnly Property Time1() As String Implements iTunesLib.IITTrack.Time
        Get
            Return mTrack.Time
        End Get
    End Property

    Public Property TrackCount1() As Integer Implements iTunesLib.IITTrack.TrackCount
        Get

        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public ReadOnly Property TrackDatabaseID2() As Integer Implements iTunesLib.IITTrack.TrackDatabaseID
        Get

        End Get
    End Property

    Public ReadOnly Property trackID2() As Integer Implements iTunesLib.IITTrack.trackID
        Get

        End Get
    End Property

    Public Property TrackNumber1() As Integer Implements iTunesLib.IITTrack.TrackNumber
        Get

        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public Property VolumeAdjustment1() As Integer Implements iTunesLib.IITTrack.VolumeAdjustment
        Get

        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public Property Year1() As Integer Implements iTunesLib.IITTrack.Year
        Get

        End Get
        Set(ByVal value As Integer)

        End Set
    End Property


    Public ReadOnly Property Playlists() As iTunesLib.IITPlaylistCollection Implements iTunesLib.IITFileOrCDTrack.Playlists
        Get
            Return Nothing
        End Get
    End Property
End Class
