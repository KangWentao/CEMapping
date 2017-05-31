<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form12
    Inherits System.Windows.Forms.Form

    '窗体重写释放，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer
    Private mainMenu1 As System.Windows.Forms.MainMenu

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form12))
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.Image1 = New System.Windows.Forms.PictureBox
        Me.txtdY2 = New System.Windows.Forms.TextBox
        Me.txtdX2 = New System.Windows.Forms.TextBox
        Me.txtE2 = New System.Windows.Forms.TextBox
        Me.txtK2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtYy2 = New System.Windows.Forms.TextBox
        Me.txtXx2 = New System.Windows.Forms.TextBox
        Me.txtY2 = New System.Windows.Forms.TextBox
        Me.txtX2 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmdClear2 = New System.Windows.Forms.Button
        Me.cmdconCalc2 = New System.Windows.Forms.Button
        Me.cmdCalc2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        Me.mainMenu1.MenuItems.Add(Me.MenuItem2)
        '
        'MenuItem1
        '
        Me.MenuItem1.Text = ""
        '
        'MenuItem2
        '
        Me.MenuItem2.Text = "返回"
        '
        'Image1
        '
        Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
        Me.Image1.Location = New System.Drawing.Point(-5, 3)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(245, 78)
        '
        'txtdY2
        '
        Me.txtdY2.AcceptsReturn = True
        Me.txtdY2.Location = New System.Drawing.Point(65, 177)
        Me.txtdY2.MaxLength = 0
        Me.txtdY2.Name = "txtdY2"
        Me.txtdY2.Size = New System.Drawing.Size(57, 21)
        Me.txtdY2.TabIndex = 15
        Me.txtdY2.Text = "0"
        '
        'txtdX2
        '
        Me.txtdX2.AcceptsReturn = True
        Me.txtdX2.Location = New System.Drawing.Point(65, 157)
        Me.txtdX2.MaxLength = 0
        Me.txtdX2.Name = "txtdX2"
        Me.txtdX2.Size = New System.Drawing.Size(57, 21)
        Me.txtdX2.TabIndex = 14
        Me.txtdX2.Text = "0"
        '
        'txtE2
        '
        Me.txtE2.AcceptsReturn = True
        Me.txtE2.Location = New System.Drawing.Point(65, 129)
        Me.txtE2.MaxLength = 0
        Me.txtE2.Name = "txtE2"
        Me.txtE2.Size = New System.Drawing.Size(57, 21)
        Me.txtE2.TabIndex = 13
        Me.txtE2.Text = "0"
        '
        'txtK2
        '
        Me.txtK2.AcceptsReturn = True
        Me.txtK2.Location = New System.Drawing.Point(65, 105)
        Me.txtK2.MaxLength = 0
        Me.txtK2.Name = "txtK2"
        Me.txtK2.Size = New System.Drawing.Size(57, 21)
        Me.txtK2.TabIndex = 12
        Me.txtK2.Text = "0"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label3.Location = New System.Drawing.Point(5, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 29)
        Me.Label3.Text = "平移参数："
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Location = New System.Drawing.Point(5, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 29)
        Me.Label2.Text = "旋转角："
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(5, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 29)
        Me.Label1.Text = "尺度参数："
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(0, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 18)
        Me.Label4.Text = "转换参数："
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(131, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 18)
        Me.Label5.Text = "转换数据："
        '
        'txtYy2
        '
        Me.txtYy2.AcceptsReturn = True
        Me.txtYy2.Location = New System.Drawing.Point(172, 185)
        Me.txtYy2.MaxLength = 0
        Me.txtYy2.Name = "txtYy2"
        Me.txtYy2.Size = New System.Drawing.Size(65, 21)
        Me.txtYy2.TabIndex = 28
        '
        'txtXx2
        '
        Me.txtXx2.AcceptsReturn = True
        Me.txtXx2.Location = New System.Drawing.Point(172, 161)
        Me.txtXx2.MaxLength = 0
        Me.txtXx2.Name = "txtXx2"
        Me.txtXx2.Size = New System.Drawing.Size(65, 21)
        Me.txtXx2.TabIndex = 27
        '
        'txtY2
        '
        Me.txtY2.AcceptsReturn = True
        Me.txtY2.Location = New System.Drawing.Point(172, 129)
        Me.txtY2.MaxLength = 0
        Me.txtY2.Name = "txtY2"
        Me.txtY2.Size = New System.Drawing.Size(65, 21)
        Me.txtY2.TabIndex = 26
        Me.txtY2.Text = "2.3"
        '
        'txtX2
        '
        Me.txtX2.AcceptsReturn = True
        Me.txtX2.Location = New System.Drawing.Point(172, 105)
        Me.txtX2.MaxLength = 0
        Me.txtX2.Name = "txtX2"
        Me.txtX2.Size = New System.Drawing.Size(65, 21)
        Me.txtX2.TabIndex = 25
        Me.txtX2.Text = "1.2"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label7.Location = New System.Drawing.Point(142, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 18)
        Me.Label7.Text = "y'="
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label6.Location = New System.Drawing.Point(142, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 18)
        Me.Label6.Text = "x'="
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label8.Location = New System.Drawing.Point(142, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 18)
        Me.Label8.Text = "y="
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label9.Location = New System.Drawing.Point(142, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 18)
        Me.Label9.Text = "x="
        '
        'cmdClear2
        '
        Me.cmdClear2.Location = New System.Drawing.Point(179, 227)
        Me.cmdClear2.Name = "cmdClear2"
        Me.cmdClear2.Size = New System.Drawing.Size(47, 23)
        Me.cmdClear2.TabIndex = 35
        Me.cmdClear2.Text = "清零"
        '
        'cmdconCalc2
        '
        Me.cmdconCalc2.Location = New System.Drawing.Point(99, 227)
        Me.cmdconCalc2.Name = "cmdconCalc2"
        Me.cmdconCalc2.Size = New System.Drawing.Size(47, 23)
        Me.cmdconCalc2.TabIndex = 34
        Me.cmdconCalc2.Text = "反算"
        '
        'cmdCalc2
        '
        Me.cmdCalc2.Location = New System.Drawing.Point(11, 227)
        Me.cmdCalc2.Name = "cmdCalc2"
        Me.cmdCalc2.Size = New System.Drawing.Size(55, 23)
        Me.cmdCalc2.TabIndex = 33
        Me.cmdCalc2.Text = "正算"
        '
        'Form12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.cmdClear2)
        Me.Controls.Add(Me.cmdconCalc2)
        Me.Controls.Add(Me.cmdCalc2)
        Me.Controls.Add(Me.txtYy2)
        Me.Controls.Add(Me.txtXx2)
        Me.Controls.Add(Me.txtY2)
        Me.Controls.Add(Me.txtX2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtdY2)
        Me.Controls.Add(Me.txtdX2)
        Me.Controls.Add(Me.txtE2)
        Me.Controls.Add(Me.txtK2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Image1)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form12"
        Me.Text = "二维坐标转换"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Public WithEvents Image1 As System.Windows.Forms.PictureBox
    Public WithEvents txtdY2 As System.Windows.Forms.TextBox
    Public WithEvents txtdX2 As System.Windows.Forms.TextBox
    Public WithEvents txtE2 As System.Windows.Forms.TextBox
    Public WithEvents txtK2 As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents txtYy2 As System.Windows.Forms.TextBox
    Public WithEvents txtXx2 As System.Windows.Forms.TextBox
    Public WithEvents txtY2 As System.Windows.Forms.TextBox
    Public WithEvents txtX2 As System.Windows.Forms.TextBox
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents cmdClear2 As System.Windows.Forms.Button
    Public WithEvents cmdconCalc2 As System.Windows.Forms.Button
    Public WithEvents cmdCalc2 As System.Windows.Forms.Button
End Class
