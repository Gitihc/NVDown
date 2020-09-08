Imports System.Reflection
Imports System.Text.RegularExpressions
Imports HtmlAgilityPack
Imports System.Text
Imports System.Threading
Imports System.IO
Imports System.Threading.Tasks

Public Class Form1

    Public Const WIDTH_MIN As Integer = 600
    Public Const HEIGHT_MIN As Integer = 290

    '893, 818
    Public Const WIDTH_MAX As Integer = 880
    Public Const HEIGHT_MAX As Integer = 770

    Public BaseDir As String = AppDomain.CurrentDomain.BaseDirectory

    Private Sub TabControl1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles tab.SelectedIndexChanged
        Dim index = tab.SelectedIndex
        If index = 0 Then
            Me.Height = HEIGHT_MIN
            Me.Width = WIDTH_MIN
        ElseIf index = 1 OrElse index = 2 Then
            Me.Height = HEIGHT_MAX
            Me.Width = WIDTH_MAX
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Height = HEIGHT_MIN
        Me.Width = WIDTH_MIN

        InitListBoxSetting()

        AddHandler NV.ShowInfo, AddressOf ShowInfo
        'Dim str = "&nbsp;&nbsp;&nbsp;&nbsp;<br>大周王朝，吴州，东宁府。"
        'Dim k = Regex.Replace(str, "[&nbsp;,<br>]", "")
    End Sub

#Region "下载"
    Private Sub btn_start_Click(sender As System.Object, e As System.EventArgs) Handles btn_start.Click

        If btn_start.Text = "start" Then
            Dim link = txt_url.Text.Trim
            If String.IsNullOrEmpty(link) Then
                ShowInfo("请输入地址！")
                Return
            End If

            Dim r = GetMatchRule(link)
            If Not IsNothing(r) Then
                btn_start.Text = IIf(btn_start.Text = "start", "stop", "start")
                NV.StopDownFlag = False
                Task.Factory.StartNew(New Action(Sub()
                                                     NV.DoTask(link, r)
                                                 End Sub))
            Else
                ShowInfo("未找到匹配规则！")
            End If
        ElseIf btn_start.Text = "stop" Then
            NV.StopDownFlag = True
        End If
    End Sub

    Private Function GetMatchRule(link As String) As SiteMatchRule
        Dim rules = SiteRuleManager.ListSiteRule()
        For Each r In rules
            If link.Contains(r.Link) Then
                Return r
                Exit For
            End If
        Next
        Return Nothing
    End Function

    Sub ShowInfo(msg As String)
        If Me.InvokeRequired Then
            Me.Invoke(Sub()
                          rtb_info.Text += vbNewLine
                          rtb_info.Text += msg
                          rtb_info.SelectionStart = rtb_info.TextLength
                          rtb_info.ScrollToCaret()
                      End Sub)

        Else
            rtb_info.Text += msg
            rtb_info.SelectionStart = rtb_info.TextLength
            rtb_info.ScrollToCaret()
        End If
    End Sub

#End Region

#Region "设置"

    Private Sub btn_AddSiteMatch_Click(sender As System.Object, e As System.EventArgs) Handles btn_AddSiteMatch.Click
        SiteRuleManager.AddItem(New SiteMatchRule)
        InitListBoxSetting()
    End Sub

    Private Sub btn_DeleteSiteMatch_Click(sender As System.Object, e As System.EventArgs) Handles btn_DeleteSiteMatch.Click
        Dim site = CType(listBox_Setting.SelectedItem, SiteMatchRule)
        If MessageBox.Show("真的要删除" & site.Name & "吗", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            SiteRuleManager.DeleteItem(site)
            InitListBoxSetting()
        End If
    End Sub

    Private Sub InitListBoxSetting()
        Dim selectIndex = listBox_Setting.SelectedIndex
        With listBox_Setting
            .Items.Clear()
            .DisplayMember = "Name"
            .ValueMember = "Key"
            For Each itm In SiteRuleManager.ListSiteRule
                .Items.Add(itm)
            Next
            If selectIndex < listBox_Setting.Items.Count Then
                .SelectedIndex = selectIndex
            End If
        End With
    End Sub

    Private Sub Form1_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        SiteRuleManager.SaveToLocation()
    End Sub

    Private Sub listBox_Setting_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles listBox_Setting.SelectedIndexChanged
        Dim site = CType(listBox_Setting.SelectedItem, SiteMatchRule)
        If Not IsNothing(site) Then
            ShowSiteMathSetting(site)
        End If
    End Sub

    Private autoSetFlag As Boolean = False
    Private Sub ShowSiteMathSetting(obj As SiteMatchRule)
        autoSetFlag = True
        With obj
            txt_Name.Text = obj.Name
            txt_Link.Text = obj.Link
            txt_CharpterListRule.Text = obj.CharpterListRule
            txt_CharpterLinkRule.Text = obj.CharpterLinkRule
            txt_CharpterContentRule.Text = obj.CharpterContentRule
            txt_PreCharpterRule.Text = obj.PreCharpterRule
            txt_NextCharpterRule.Text = obj.NextCharpterRule
            txt_CharpterTitleRule.Text = obj.CharpterTitleRule
            txt_NVNameRule.Text = obj.NVNameRule
        End With
        autoSetFlag = False
    End Sub

    Private Sub txt_WebSiteName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_Link.TextChanged, txt_Name.TextChanged, txt_PreCharpterRule.TextChanged, txt_NextCharpterRule.TextChanged, txt_CharpterTitleRule.TextChanged, txt_CharpterListRule.TextChanged, txt_CharpterLinkRule.TextChanged, txt_CharpterContentRule.TextChanged, txt_NVNameRule.TextChanged, txt_CharptEncoding.TextChanged
        If Not autoSetFlag Then
            Dim btn = CType(sender, TextBox)
            Dim site = CType(listBox_Setting.SelectedItem, SiteMatchRule)
            Dim t = site.GetType()
            Dim field = btn.Name.Substring(4)
            Dim fieldValue = btn.Text.Trim
            Dim pinfo As PropertyInfo = t.GetProperty(field)
            If Not IsNothing(pinfo) Then
                Call handValue(field, fieldValue)
                pinfo.SetValue(site, fieldValue, Nothing)
                InitListBoxSetting()
            End If
        End If
    End Sub

    Private Sub handValue(field As String, ByRef value As String)
        Select Case field
            Case "Link"
                If value.EndsWith("/") Then
                    value = value.Substring(0, value.Length - 1)
                End If
        End Select
    End Sub

#End Region

#Region "测试"
#Region "目录"

    Sub ShowTestResult(msg As String)
        rhb_test_info.Text = msg
    End Sub

    Private Sub txt_test_url_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_test_url.KeyUp
        If e.KeyCode = Keys.Enter Then
            Dim url = txt_test_url.Text.Trim
            If Not String.IsNullOrEmpty(url) Then
                CalcRule()
            End If
        End If

    End Sub

    Sub CalcRule()
        Dim url = txt_test_url.Text.Trim

        Dim nameRule = txt_test_Name.Text

        Dim listRule = txt_test_list.Text

        Dim linkRule = txt_test_link.Text



        Dim pageHtml = HttpHelper.GetString(url)

        If Not String.IsNullOrEmpty(nameRule) Then
            txt_result_name.Text = NV.GetInnerHtml(pageHtml, nameRule)
        End If

        If Not String.IsNullOrEmpty(listRule) Then
            pageHtml = NV.GetInnerHtml(pageHtml, listRule)
        End If

        If Not String.IsNullOrEmpty(linkRule) Then
            pageHtml = NV.GetInnerHtml(pageHtml, linkRule)
        End If

        Call ShowTestResult(pageHtml)
    End Sub

    Private Sub txt_test_content_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_test_Name.KeyUp, txt_test_list.KeyUp, txt_test_link.KeyUp
        If e.KeyCode = Keys.Enter Then
            CalcRule()
        End If
    End Sub
#End Region

#Region "正文"

    Sub CalcContent()
        Dim url = txt_content_url.Text.Trim

        Dim titleRule = txt_test_title.Text

        Dim contentRule = txt_test_content.Text

        Dim pageHtml = HttpHelper.GetString(url)

        If Not String.IsNullOrEmpty(titleRule) Then
            txt_result_title.Text = NV.GetInnerHtml(pageHtml, titleRule)
        End If

        If Not String.IsNullOrEmpty(contentRule) Then
            pageHtml = NV.GetInnerHtml(pageHtml, contentRule)
        End If

        Call ShowContentResult(pageHtml)
    End Sub

    Private Sub txt_content_url_TextChanged(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_content_url.KeyUp
        If e.KeyCode = Keys.Enter Then
            Dim url = txt_content_url.Text.Trim
            If Not String.IsNullOrEmpty(url) Then
                CalcContent()
            End If
        End If
    End Sub

    Sub ShowContentResult(msg As String)
        rtb_result_content.Text = msg
    End Sub

    Private Sub txt_test_content_KeyUp_1(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_test_title.KeyUp, txt_test_content.KeyUp
        If e.KeyCode = Keys.Enter Then
            CalcContent()
        End If
    End Sub

#End Region

    ''' <summary>
    ''' 保存到设置
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_save2set_Click(sender As System.Object, e As System.EventArgs) Handles btn_save2set.Click
        btn_save2set.Enabled = False
        Try
            Dim rule = New SiteMatchRule
            With rule
                .Name = "新的站点规"
                .Link = txt_test_url.Text
                .NVNameRule = txt_test_Name.Text
                .CharpterListRule = txt_test_list.Text
                .CharpterLinkRule = txt_test_link.Text

                .CharpterTitleRule = txt_test_title.Text
                .CharpterContentRule = txt_test_content.Text

                .PreCharpterRule = String.Empty
                .NextCharpterRule = String.Empty
            End With
            If SiteRuleManager.IsExist(rule.Link) Then
                MsgBox("已存在相同匹配规则！")
                Return
            End If

            SiteRuleManager.AddItem(rule)
            InitListBoxSetting()
            MsgBox("添加成功！")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        btn_save2set.Enabled = True
    End Sub
#End Region

End Class
