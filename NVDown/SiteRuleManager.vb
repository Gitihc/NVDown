Imports Newtonsoft.Json

Public Class SiteRuleManager

    Private Shared _listSiteRule As List(Of SiteMatchRule) = New List(Of SiteMatchRule)

    Private Shared SavePath As String = IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SiteMatchRule.config")

    Public Shared ReadOnly Property ListSiteRule As List(Of SiteMatchRule)
        Get
            If _listSiteRule.Count = 0 Then
                InitSiteMatchRule()
            End If
            Return _listSiteRule
        End Get
    End Property

    Public Shared Sub InitSiteMatchRule()
        If IO.File.Exists(SavePath) Then
            Dim jsonStr = IO.File.ReadAllText(SavePath)
            _listSiteRule = JsonConvert.DeserializeObject(Of List(Of SiteMatchRule))(jsonStr)
            If IsNothing(_listSiteRule) Then
                _listSiteRule = New List(Of SiteMatchRule)
            End If
        End If
    End Sub

    Public Shared Sub SaveToLocation()
        Dim jsonStr = JsonConvert.SerializeObject(_listSiteRule)
        IO.File.WriteAllText(SavePath, jsonStr)
    End Sub

    Public Shared Sub AddItem(obj As SiteMatchRule)
        _listSiteRule.Add(obj)
        SaveToLocation()
    End Sub

    Public Shared Sub DeleteItem(obj As SiteMatchRule)
        Dim count = _listSiteRule.Count
        For i = 0 To count - 1
            Dim item = _listSiteRule(i)
            If item.Key = item.Key Then
                _listSiteRule.RemoveAt(i)
                Exit For
            End If
        Next
        SaveToLocation()
    End Sub

End Class
