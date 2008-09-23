
Public Class cBwJob

    Public Sub New(ByVal myJob As JobType)
        mJobType = myJob
    End Sub

    Enum JobType

        NEW_TASK
        ADD_NEW_TRACKS
        ADJUST_RATINGS
        COMMAND_LINE
        COPY_TAGS_TO_CLIPBOARD
        DELETE_DEAD_FOREIGN_TRACKS
        DELETE_EMPTY_FOLDERS
        EDIT_SELECTED_TRACKS
        EXPORT_ARTWORK_MANUAL
        EXPORT_ARTWORK_BATCH
        EXPORT_TRACKS
        FIND_NEW_TRACKS_FROM_HDD
        IMPORT_PLAYEDCOUNT_LASTFM
        IMPORT_POPM_PCNT
        INITIALIZE_PLAYER
        RELOAD_DISCS_TO_ALBUM_BROWSER
        OFFSET_TRACKNUMBER
        OVERRIDE_TAGS
        RATINGS_BACKUP
        RATINGS_RESTORE
        RECOVER_TAGS
        REMOVE_DUPLICATE_TRACKS
        REPLACE_WORD
        REPLACE_TRACKS
        SCHEDULE_DO        
        STATISTICS_DO
        SYNCHROCLEAN
        SYNC_MEDIA_CENTER_CACHE
        TRACKNUMBER_RENUMBER
        TRIM_CHAR
        UPDATE_PROGRESS_BAR
        UPDATE_STATUS_BAR
        VALIDATE_TRACKS_SELECTED
        VALIDATE_DISC
        VALIDATE_DISC_ADVANCED
        VALIDATE_LIBRARY
        WRITE_POPM_PCNT

    End Enum

    Public Enum ProgressType

        ADD_TRACKS_TO_LISTBOX_TRACKS
        APPEND_PREPEND_CHAR
        READ_TRACKS_FROM_DISCS
        ADJUSTING_RATING
        ADD_TRACKS_TO_LIBRARY
        ANALYSING_ALBUM
        BACKINGUP_RATINGS
        CAPITALIZE_FIRST_LETTER
        CLEANING_TEMP_DIR
        CLEAR_TRACKS_LISTBOX
        CLEAR_DISCS_LISTBOX
        DELETE_ARTWORK
        DELETE_TRACKS_DEAD_ALIEN
        DELETE_TRACKS_DEAD
        DETERINE_WHERE_MOST_MUSIC_IS
        DECOMPILE_TRACKS
        EDITING_SELECTED_TRACKS
        EMBEDDING_LYRICS
        EXPORT_TRACKS
        GETTING_TRACK_INFO
        IMPORTING_ARTWORK
        IMPORTING_POPM_PCNT
        INCREMENT_DISC_PROGRESS
        INCREMENT_TRACK_PROGRESS
        INITIALIZE_PLAYER_LIBRARY_START
        INITIALIZE_ITUNES_XML_DATABASE_START
        INITIALIZE_ITUNES_ERROR
        INITIALIZE_PLAYER_FINISH
        LOAD_ARTWORK_DIMENSIONS
        OFFSET_TRACKNUMBER
        OVERRIDE_TAGS
        PARSING_ITUNES_LIBRARY
        PARSING_ITUNES_XML_DATABASE
        READY
        ADD_DISC_TO_LISTBOX_DISCS
        RECOVERING_TRACKS
        REMOVE_TRACK_FROM_LISTBOX
        REMOVING_TAGS
        REPLACING_TAGS
        REPLACING_TRACKS
        RESTORING_RATINGS
        RESTORE_STATUS_BAR_MESSAGE
        SCANNING_FILE_IN_HDD
        SCANNING_TRACK_IN_PLAYER_LIBRARY
        SCANNING_TRACK_IN_ITUNES_XML_DATABASE
        SEARCHING_ITMS_ARTWORK
        SEND_APP_TO_TRAY
        EMAIL_SENDING
        FOUND_LYRICS_FOR
        SHOW_STATISTICS_WINDOW
        SAVE_PLAYLIST
        SET_PROGRESS_BAR_MARQUEE
        SET_PROGRESS_BAR_CONTINUOUS
        SET_ACTIVE_TAB
        TRIMMING_CHAR
        UPDATE_APP_TITLE
        UPDATE_THUMBNAIL_IN_ARTIST_FOLDER
        UPDATE_TRACKS_PROGRESS_BAR_MAX
        UPDATE_DISCS_PROGRESS_BAR_MAX
        VALIDATING_DISC_IN_ITUNES_LIBRARY
        WRITE_APPLICATION_SETTINGS
        WRITE_ARTWORK_CACHE
        WRITING_TAGS_TO_TRACKS
        UPDATING_TRACK
        ZIPPING_FILES

    End Enum

    Private mJobType As JobType = JobType.UPDATE_PROGRESS_BAR
    Public mMessage As String

    Public Property Job() As JobType
        Get
            Return mJobType
        End Get
        Set(ByVal value As JobType)
            mJobType = value
        End Set
    End Property

    Private mJobCancelled As Boolean = False
    Public Property JobCancelled() As Boolean
        Get
            Return mJobCancelled
        End Get
        Set(ByVal value As Boolean)
            mJobCancelled = value
        End Set
    End Property

    Private mData As New Object
    Public Property TaskData() As Object
        Get
            Return mData
        End Get
        Set(ByVal value As Object)
            mData = value
        End Set
    End Property

End Class

