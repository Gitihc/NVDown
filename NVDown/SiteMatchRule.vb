Public Class SiteMatchRule
    Property Key As String
    ''' <summary>
    ''' 名称
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property Name As String
    ''' <summary>
    ''' link
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property Link As String
    ''' <summary>
    ''' 名称匹配规则
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property NVNameRule As String
    ''' <summary>
    ''' 目录匹配规则
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property CharpterListRule As String
    ''' <summary>
    ''' 章节link匹配规则
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property CharpterLinkRule As String
    ''' <summary>
    ''' 标题匹配规则
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property CharpterTitleRule As String
    ''' <summary>
    ''' 内容匹配规则
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property CharpterContentRule As String
    ''' <summary>
    ''' 前页匹配规则
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property PreCharpterRule As String
    ''' <summary>
    ''' 后页匹配规则
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property NextCharpterRule As String

    Property CharptEncoding As String

    Public Sub New()
        Me.Key = New Guid().ToString
        Me.Name = "新的站点规"
        Me.Link = String.Empty
        Me.CharpterListRule = String.Empty
        Me.CharpterLinkRule = String.Empty
        Me.CharpterTitleRule = String.Empty
        Me.CharpterContentRule = String.Empty
        Me.PreCharpterRule = String.Empty
        Me.NextCharpterRule = String.Empty
        Me.CharptEncoding = String.Empty
    End Sub
End Class


