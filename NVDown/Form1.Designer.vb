<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tab = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rtb_info = New System.Windows.Forms.RichTextBox()
        Me.txt_url = New System.Windows.Forms.TextBox()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.listBox_Setting = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_CharpterListRule = New System.Windows.Forms.TextBox()
        Me.txt_NVNameRule = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_CharpterLinkRule = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Link = New System.Windows.Forms.TextBox()
        Me.txt_Name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_CharptEncoding = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_CharpterTitleRule = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_CharpterContentRule = New System.Windows.Forms.TextBox()
        Me.txt_PreCharpterRule = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_NextCharpterRule = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_DeleteSiteMatch = New System.Windows.Forms.Button()
        Me.btn_AddSiteMatch = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btn_save2set = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_result_name = New System.Windows.Forms.TextBox()
        Me.txt_test_Name = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_test_url = New System.Windows.Forms.TextBox()
        Me.rhb_test_info = New System.Windows.Forms.RichTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_test_link = New System.Windows.Forms.TextBox()
        Me.txt_test_list = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rtb_result_content = New System.Windows.Forms.RichTextBox()
        Me.txt_result_title = New System.Windows.Forms.TextBox()
        Me.txt_content_url = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_test_content = New System.Windows.Forms.TextBox()
        Me.txt_test_title = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tab.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab
        '
        Me.tab.Controls.Add(Me.TabPage1)
        Me.tab.Controls.Add(Me.TabPage2)
        Me.tab.Controls.Add(Me.TabPage3)
        Me.tab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab.Location = New System.Drawing.Point(0, 0)
        Me.tab.Name = "tab"
        Me.tab.SelectedIndex = 0
        Me.tab.Size = New System.Drawing.Size(864, 731)
        Me.tab.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.rtb_info)
        Me.TabPage1.Controls.Add(Me.txt_url)
        Me.TabPage1.Controls.Add(Me.btn_start)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(856, 705)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "下载"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 12)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "目录地址："
        '
        'rtb_info
        '
        Me.rtb_info.Location = New System.Drawing.Point(24, 52)
        Me.rtb_info.Name = "rtb_info"
        Me.rtb_info.Size = New System.Drawing.Size(520, 154)
        Me.rtb_info.TabIndex = 2
        Me.rtb_info.Text = ""
        '
        'txt_url
        '
        Me.txt_url.Location = New System.Drawing.Point(93, 17)
        Me.txt_url.Name = "txt_url"
        Me.txt_url.Size = New System.Drawing.Size(352, 21)
        Me.txt_url.TabIndex = 1
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(460, 16)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(84, 23)
        Me.btn_start.TabIndex = 0
        Me.btn_start.Text = "start"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(856, 705)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "设置"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.listBox_Setting)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_DeleteSiteMatch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_AddSiteMatch)
        Me.SplitContainer1.Size = New System.Drawing.Size(850, 699)
        Me.SplitContainer1.SplitterDistance = 185
        Me.SplitContainer1.TabIndex = 16
        '
        'listBox_Setting
        '
        Me.listBox_Setting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listBox_Setting.FormattingEnabled = True
        Me.listBox_Setting.ItemHeight = 12
        Me.listBox_Setting.Location = New System.Drawing.Point(0, 0)
        Me.listBox_Setting.Name = "listBox_Setting"
        Me.listBox_Setting.Size = New System.Drawing.Size(185, 699)
        Me.listBox_Setting.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_CharpterListRule)
        Me.GroupBox3.Controls.Add(Me.txt_NVNameRule)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txt_CharpterLinkRule)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 204)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(502, 162)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "书籍"
        '
        'txt_CharpterListRule
        '
        Me.txt_CharpterListRule.Location = New System.Drawing.Point(79, 71)
        Me.txt_CharpterListRule.Name = "txt_CharpterListRule"
        Me.txt_CharpterListRule.Size = New System.Drawing.Size(392, 21)
        Me.txt_CharpterListRule.TabIndex = 12
        '
        'txt_NVNameRule
        '
        Me.txt_NVNameRule.Location = New System.Drawing.Point(79, 25)
        Me.txt_NVNameRule.Name = "txt_NVNameRule"
        Me.txt_NVNameRule.Size = New System.Drawing.Size(392, 21)
        Me.txt_NVNameRule.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "目录匹配"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "链接匹配"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "名称匹配"
        '
        'txt_CharpterLinkRule
        '
        Me.txt_CharpterLinkRule.Location = New System.Drawing.Point(79, 117)
        Me.txt_CharpterLinkRule.Name = "txt_CharpterLinkRule"
        Me.txt_CharpterLinkRule.Size = New System.Drawing.Size(392, 21)
        Me.txt_CharpterLinkRule.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_Link)
        Me.GroupBox2.Controls.Add(Me.txt_Name)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(502, 121)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "站点"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "站点地址"
        '
        'txt_Link
        '
        Me.txt_Link.Location = New System.Drawing.Point(79, 71)
        Me.txt_Link.Name = "txt_Link"
        Me.txt_Link.Size = New System.Drawing.Size(392, 21)
        Me.txt_Link.TabIndex = 9
        '
        'txt_Name
        '
        Me.txt_Name.Location = New System.Drawing.Point(79, 29)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(392, 21)
        Me.txt_Name.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "站点名称"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_CharptEncoding)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txt_CharpterTitleRule)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_CharpterContentRule)
        Me.GroupBox1.Controls.Add(Me.txt_PreCharpterRule)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_NextCharpterRule)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 389)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(502, 208)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "章节"
        '
        'txt_CharptEncoding
        '
        Me.txt_CharptEncoding.Location = New System.Drawing.Point(79, 166)
        Me.txt_CharptEncoding.Name = "txt_CharptEncoding"
        Me.txt_CharptEncoding.Size = New System.Drawing.Size(392, 21)
        Me.txt_CharptEncoding.TabIndex = 17
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label16.Location = New System.Drawing.Point(17, 170)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 17)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "正文编码"
        '
        'txt_CharpterTitleRule
        '
        Me.txt_CharpterTitleRule.Location = New System.Drawing.Point(79, 20)
        Me.txt_CharpterTitleRule.Name = "txt_CharpterTitleRule"
        Me.txt_CharpterTitleRule.Size = New System.Drawing.Size(392, 21)
        Me.txt_CharpterTitleRule.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "章节匹配"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "正文匹配"
        '
        'txt_CharpterContentRule
        '
        Me.txt_CharpterContentRule.Location = New System.Drawing.Point(79, 56)
        Me.txt_CharpterContentRule.Name = "txt_CharpterContentRule"
        Me.txt_CharpterContentRule.Size = New System.Drawing.Size(392, 21)
        Me.txt_CharpterContentRule.TabIndex = 13
        '
        'txt_PreCharpterRule
        '
        Me.txt_PreCharpterRule.Location = New System.Drawing.Point(79, 92)
        Me.txt_PreCharpterRule.Name = "txt_PreCharpterRule"
        Me.txt_PreCharpterRule.Size = New System.Drawing.Size(392, 21)
        Me.txt_PreCharpterRule.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "前页匹配"
        '
        'txt_NextCharpterRule
        '
        Me.txt_NextCharpterRule.Location = New System.Drawing.Point(79, 128)
        Me.txt_NextCharpterRule.Name = "txt_NextCharpterRule"
        Me.txt_NextCharpterRule.Size = New System.Drawing.Size(392, 21)
        Me.txt_NextCharpterRule.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "后页匹配"
        '
        'btn_DeleteSiteMatch
        '
        Me.btn_DeleteSiteMatch.Location = New System.Drawing.Point(126, 13)
        Me.btn_DeleteSiteMatch.Name = "btn_DeleteSiteMatch"
        Me.btn_DeleteSiteMatch.Size = New System.Drawing.Size(75, 23)
        Me.btn_DeleteSiteMatch.TabIndex = 17
        Me.btn_DeleteSiteMatch.Text = "删除"
        Me.btn_DeleteSiteMatch.UseVisualStyleBackColor = True
        '
        'btn_AddSiteMatch
        '
        Me.btn_AddSiteMatch.Location = New System.Drawing.Point(26, 13)
        Me.btn_AddSiteMatch.Name = "btn_AddSiteMatch"
        Me.btn_AddSiteMatch.Size = New System.Drawing.Size(75, 23)
        Me.btn_AddSiteMatch.TabIndex = 16
        Me.btn_AddSiteMatch.Text = "添加"
        Me.btn_AddSiteMatch.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btn_save2set)
        Me.TabPage3.Controls.Add(Me.TabControl1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(856, 705)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "测试"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btn_save2set
        '
        Me.btn_save2set.Location = New System.Drawing.Point(771, 6)
        Me.btn_save2set.Name = "btn_save2set"
        Me.btn_save2set.Size = New System.Drawing.Size(75, 23)
        Me.btn_save2set.TabIndex = 29
        Me.btn_save2set.Text = "保存到设置"
        Me.btn_save2set.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(9, 33)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(841, 664)
        Me.TabControl1.TabIndex = 28
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(833, 638)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "目录"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_result_name)
        Me.GroupBox4.Controls.Add(Me.txt_test_Name)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txt_test_url)
        Me.GroupBox4.Controls.Add(Me.rhb_test_info)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txt_test_link)
        Me.GroupBox4.Controls.Add(Me.txt_test_list)
        Me.GroupBox4.Location = New System.Drawing.Point(24, 35)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(803, 590)
        Me.GroupBox4.TabIndex = 26
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "目录"
        '
        'txt_result_name
        '
        Me.txt_result_name.Location = New System.Drawing.Point(356, 65)
        Me.txt_result_name.Name = "txt_result_name"
        Me.txt_result_name.Size = New System.Drawing.Size(261, 21)
        Me.txt_result_name.TabIndex = 22
        '
        'txt_test_Name
        '
        Me.txt_test_Name.Location = New System.Drawing.Point(72, 65)
        Me.txt_test_Name.Name = "txt_test_Name"
        Me.txt_test_Name.Size = New System.Drawing.Size(259, 21)
        Me.txt_test_Name.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 17)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "名称匹配"
        '
        'txt_test_url
        '
        Me.txt_test_url.Location = New System.Drawing.Point(72, 20)
        Me.txt_test_url.Name = "txt_test_url"
        Me.txt_test_url.Size = New System.Drawing.Size(545, 21)
        Me.txt_test_url.TabIndex = 0
        '
        'rhb_test_info
        '
        Me.rhb_test_info.Location = New System.Drawing.Point(13, 207)
        Me.rhb_test_info.Name = "rhb_test_info"
        Me.rhb_test_info.Size = New System.Drawing.Size(784, 365)
        Me.rhb_test_info.TabIndex = 1
        Me.rhb_test_info.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label13.Location = New System.Drawing.Point(10, 111)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 17)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "链接匹配"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.Location = New System.Drawing.Point(10, 159)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 17)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "目录匹配"
        '
        'txt_test_link
        '
        Me.txt_test_link.Location = New System.Drawing.Point(72, 109)
        Me.txt_test_link.Name = "txt_test_link"
        Me.txt_test_link.Size = New System.Drawing.Size(259, 21)
        Me.txt_test_link.TabIndex = 4
        '
        'txt_test_list
        '
        Me.txt_test_list.Location = New System.Drawing.Point(72, 159)
        Me.txt_test_list.Name = "txt_test_list"
        Me.txt_test_list.Size = New System.Drawing.Size(259, 21)
        Me.txt_test_list.TabIndex = 3
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(833, 638)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "正文"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rtb_result_content)
        Me.GroupBox5.Controls.Add(Me.txt_result_title)
        Me.GroupBox5.Controls.Add(Me.txt_content_url)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.txt_test_content)
        Me.GroupBox5.Controls.Add(Me.txt_test_title)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(812, 623)
        Me.GroupBox5.TabIndex = 27
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "正文"
        '
        'rtb_result_content
        '
        Me.rtb_result_content.Location = New System.Drawing.Point(22, 183)
        Me.rtb_result_content.Name = "rtb_result_content"
        Me.rtb_result_content.Size = New System.Drawing.Size(784, 421)
        Me.rtb_result_content.TabIndex = 31
        Me.rtb_result_content.Text = ""
        '
        'txt_result_title
        '
        Me.txt_result_title.Location = New System.Drawing.Point(350, 81)
        Me.txt_result_title.Name = "txt_result_title"
        Me.txt_result_title.Size = New System.Drawing.Size(246, 21)
        Me.txt_result_title.TabIndex = 30
        '
        'txt_content_url
        '
        Me.txt_content_url.Location = New System.Drawing.Point(72, 29)
        Me.txt_content_url.Name = "txt_content_url"
        Me.txt_content_url.Size = New System.Drawing.Size(524, 21)
        Me.txt_content_url.TabIndex = 23
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label15.Location = New System.Drawing.Point(10, 125)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 17)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "正文匹配"
        '
        'txt_test_content
        '
        Me.txt_test_content.Location = New System.Drawing.Point(72, 123)
        Me.txt_test_content.Name = "txt_test_content"
        Me.txt_test_content.Size = New System.Drawing.Size(259, 21)
        Me.txt_test_content.TabIndex = 28
        '
        'txt_test_title
        '
        Me.txt_test_title.Location = New System.Drawing.Point(72, 80)
        Me.txt_test_title.Name = "txt_test_title"
        Me.txt_test_title.Size = New System.Drawing.Size(259, 21)
        Me.txt_test_title.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label14.Location = New System.Drawing.Point(10, 81)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 17)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "标题匹配"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 731)
        Me.Controls.Add(Me.tab)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NVDown"
        Me.tab.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents rtb_info As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_url As System.Windows.Forms.TextBox
    Friend WithEvents btn_start As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_CharpterTitleRule As System.Windows.Forms.TextBox
    Friend WithEvents txt_NextCharpterRule As System.Windows.Forms.TextBox
    Friend WithEvents txt_CharpterContentRule As System.Windows.Forms.TextBox
    Friend WithEvents txt_CharpterListRule As System.Windows.Forms.TextBox
    Friend WithEvents txt_PreCharpterRule As System.Windows.Forms.TextBox
    Friend WithEvents txt_CharpterLinkRule As System.Windows.Forms.TextBox
    Friend WithEvents txt_Link As System.Windows.Forms.TextBox
    Friend WithEvents txt_Name As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents listBox_Setting As System.Windows.Forms.ListBox
    Friend WithEvents btn_DeleteSiteMatch As System.Windows.Forms.Button
    Friend WithEvents btn_AddSiteMatch As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_NVNameRule As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents rhb_test_info As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_test_url As System.Windows.Forms.TextBox
    Friend WithEvents txt_test_link As System.Windows.Forms.TextBox
    Friend WithEvents txt_test_list As System.Windows.Forms.TextBox
    Friend WithEvents txt_test_Name As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents txt_result_name As System.Windows.Forms.TextBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rtb_result_content As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_result_title As System.Windows.Forms.TextBox
    Friend WithEvents txt_content_url As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_test_content As System.Windows.Forms.TextBox
    Friend WithEvents txt_test_title As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btn_save2set As System.Windows.Forms.Button
    Friend WithEvents txt_CharptEncoding As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label

End Class
