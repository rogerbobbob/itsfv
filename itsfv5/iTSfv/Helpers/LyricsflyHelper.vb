Imports System.Net
Imports System.IO
Imports System.Web

Public Class LyricsflyHelper

    Private Const APIKey As String = "94c52725fa11dd067-temporary.API.access"
    Private SearchString As String = "http://lyricsfly.com/api/api.php?i=" + APIKey + "&a=[ARTIST]&t=[TITLE]"

    Public Sub New(ByVal artist As String, ByVal title As String)

        Dim url As String = SearchString.Replace("[ARTIST]", HttpUtility.UrlEncode(artist)).Replace("[TITLE]", HttpUtility.UrlEncode(title))
        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        request.Method = "GET"

        Dim response As HttpWebResponse = CType(request.GetResponse, HttpWebResponse)
        Dim sr As StreamReader = New StreamReader(response.GetResponseStream)
        Dim responseString As String = sr.ReadToEnd
       
    End Sub

    Public Function checkSongExist() As Boolean

        Return True

    End Function

End Class
