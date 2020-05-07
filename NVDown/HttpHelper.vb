Imports System.Text
Imports System.Net
Imports System.IO
Imports System.IO.Compression
Imports System.Text.RegularExpressions

Public Class HttpHelper
    Public Shared Function GetString(ByVal url As String, Optional defaultEncode As Encoding = Nothing) As String
        Try
            Dim encode = defaultEncode
            If IsNothing(encode) Then
                encode = GetEncoding(url)
            End If
            System.Net.ServicePointManager.SecurityProtocol = &HC00

            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            request.ReadWriteTimeout = 30 * 1000
            Dim response = CType(request.GetResponse(), HttpWebResponse)
            Dim html As String = String.Empty
            If response.ContentEncoding IsNot Nothing AndAlso response.ContentEncoding.ToLower().Contains("gzip") Then
                Using GzipSteam As GZipStream = New GZipStream(response.GetResponseStream(), CompressionMode.Decompress)
                    html = New StreamReader(GzipSteam, encode).ReadToEnd
                End Using
            Else
                html = New StreamReader(response.GetResponseStream(), encode).ReadToEnd
            End If
            Return html
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function PostString(ByVal url As String, ByVal _encoding As Encoding, ByVal PostData As String) As String
        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        Dim bt As Byte() = Encoding.UTF8.GetBytes(PostData)

        Using sw As Stream = request.GetRequestStream()
            sw.Write(bt, 0, bt.Count())
        End Using

        Dim reponse As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
        Dim html As String = New StreamReader(reponse.GetResponseStream(), _encoding).ReadToEnd().ToString()
        Return html
    End Function

    Private Shared Function GetEncoding(url As String) As Encoding
        System.Net.ServicePointManager.SecurityProtocol = &HC00
        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        Dim response = CType(request.GetResponse(), HttpWebResponse)
        Dim html As String = String.Empty

        If response.ContentEncoding IsNot Nothing AndAlso response.ContentEncoding.ToLower().Contains("gzip") Then
            Using GzipSteam As GZipStream = New GZipStream(response.GetResponseStream(), CompressionMode.Decompress)
                html = New StreamReader(GzipSteam, Encoding.Default).ReadToEnd
            End Using
        Else
            html = New StreamReader(response.GetResponseStream(), Encoding.Default).ReadToEnd
        End If
        Dim strCharSet = Regex.Match(html, "<meta.*?charset=""?([a-z0-9-]+)\b", RegexOptions.IgnoreCase).Groups(1).Value
        Try
            Return Encoding.GetEncoding(strCharSet)
        Catch ex As Exception
            Return Encoding.GetEncoding("UTF-8")
        End Try
    End Function
End Class
