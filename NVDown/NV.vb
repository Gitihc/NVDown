Imports System.Text
Imports HtmlAgilityPack
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Threading

Public Class NV

    Public Shared BaseDir As String = AppDomain.CurrentDomain.BaseDirectory
    Public Shared StopDownFlag As Boolean = False
    Private Shared lockObj = New Object
    Private Shared _doneCount As Integer = 0
   
    Public Shared Property DoneCount() As Integer
        Get
            Return _doneCount
        End Get
        Set(value As Integer)
            SyncLock (lockObj)
                _doneCount = value
            End SyncLock
        End Set
    End Property

    Public Shared Event ShowInfo(ByVal msg As String)

    Public Shared Sub DoTask(link As String, rule As SiteMatchRule)
        '获取目录列表
        Dim pageHtml As String = HttpHelper.GetString(link)
        Dim nvName As String = getNVName(pageHtml, rule.NVNameRule)

        Dim nvDir As String = IO.Path.Combine(BaseDir, nvName)
        Call CreateIfNotExitst(nvDir)

        Dim listHtml = GetCharpterListHtml(pageHtml, rule.CharpterListRule)

        Dim listHref = GetCharpterList(listHtml, rule.CharpterLinkRule)

        Dim count = listHref.Count

        Dim index As Integer = 1
        '获取章节
        For Each href In listHref
            If StopDownFlag Then
                Exit For
            End If
            Dim tempHref As String = href
            Dim idx As Integer = index
            ThreadPool.QueueUserWorkItem(Sub()
                                             If Not tempHref.StartsWith("http") Then
                                                 tempHref = String.Format("{0}{1}", rule.Link, tempHref)
                                             End If
                                             Dim contentHtml = String.Empty
                                             If Not String.IsNullOrEmpty(rule.CharptEncoding) Then
                                                 contentHtml = HttpHelper.GetString(tempHref, Encoding.GetEncoding(rule.CharptEncoding))
                                             Else
                                                 contentHtml = HttpHelper.GetString(tempHref)
                                             End If

                                             Dim title = GetCharpterTitle(contentHtml, rule.CharpterTitleRule)
                                             Dim content = GetCharpterTitle(contentHtml, rule.CharpterContentRule)
                                             content = RemoveSpecKey(content)
                                             Dim sb = New StringBuilder
                                             With sb
                                                 .Append(title).AppendLine.AppendLine()
                                                 .Append(content)
                                             End With
                                             Dim savePath As String = IO.Path.Combine(nvDir, idx & ".txt")
                                             IO.File.WriteAllText(savePath, sb.ToString)
                                             If StopDownFlag Then Return
                                             RaiseEvent ShowInfo(String.Format("第{0}/{1}完成", idx, count))
                                             DoneCount += 1
                                         End Sub)
            index += 1
        Next

        ThreadPool.QueueUserWorkItem(Sub()
                                         While True
                                             Thread.Sleep(1000)
                                             If DoneCount = count Then
                                                 Dim filePath As String = IO.Path.Combine(nvDir, nvName & ".txt")
                                                 combinFile(nvDir, filePath)
                                                 Exit While
                                             End If
                                         End While
                                     End Sub)

    End Sub

    Shared Sub CreateIfNotExitst(dir As String)
        If Not IO.Directory.Exists(dir) Then
            IO.Directory.CreateDirectory(dir)
        End If
    End Sub

    Shared Function getNVName(html As String, rule As String) As String
        Return GetInnerText(html, rule)
    End Function

    Shared Function GetCharpterListHtml(html As String, rule As String) As String
        Return GetInnerHtml(html, rule)
    End Function

    Shared Function GetCharpterList(html As String, rule As String) As List(Of String)
        Dim doc = New HtmlDocument()
        doc.LoadHtml(html)
        Dim nodes = doc.DocumentNode.SelectNodes(rule)
        Dim listLink = New List(Of String)
        For Each node In nodes
            Dim href = node.Attributes("href")
            listLink.Add(href.Value)
        Next
        Return listLink
    End Function

    Shared Function GetCharpterTitle(html As String, rule As String) As String
        Return GetInnerText(html, rule)
    End Function

    Shared Function GetCharpterContent(html As String, rule As String) As String
        Return GetInnerText(html, rule)
    End Function

    Shared Function GetInnerText(html As String, rule As String) As String
        Dim doc = New HtmlDocument()
        doc.LoadHtml(html)
        Dim node As HtmlNode = doc.DocumentNode.SelectSingleNode(rule)
        Return node.InnerText
    End Function

    Shared Function GetInnerHtml(html As String, rule As String) As String
        Dim doc = New HtmlDocument()
        doc.LoadHtml(html)
        Dim node As HtmlNode = doc.DocumentNode.SelectSingleNode(rule)
        Return node.InnerHtml
    End Function

    Shared Sub combinFile(folder As String, filePath As String)
        Dim files = IO.Directory.GetFiles(folder)
        If Not IO.File.Exists(filePath) Then
            File.Create(filePath).Close()
        End If
        Dim total As Integer = files.Count + 1 '总数量
        Dim idx As Integer = 0 '计数器
        RaiseEvent ShowInfo("开始合并文件！")
        Using fs = New FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite)
            Using sw = New StreamWriter(fs)
                For Each f In files
                    Dim fname = IO.Path.GetFileNameWithoutExtension(f)
                    If RegexMatch("\d*", fname).Success Then
                        Dim t = IO.File.ReadAllText(f)
                        IO.File.Delete(f)
                        sw.Write(vbNewLine & t)
                        idx += 1
                        RaiseEvent ShowInfo(String.Format("第{0}/{1}合并完成！", idx, total))
                    End If
                Next
            End Using
        End Using
        Call Process.Start(folder)
        RaiseEvent ShowInfo("合并完成！")
    End Sub

    Shared Function RemoveSpecKey(sourceStr As String) As String
        Dim result = Regex.Replace(sourceStr, "[&nbsp;,<br>]", String.Empty)
        Return result
    End Function

    Shared Function RegexMatch(rule As String, matchStr As String) As Match
        Dim reg = New Regex(rule)
        Dim m = reg.Match(matchStr)
        Return m
    End Function

    Shared Function RegexMatchs(rule As String, matchStr As String) As MatchCollection
        Dim reg = New Regex(rule)
        Dim mc = reg.Matches(matchStr)
        Return mc
    End Function
End Class
