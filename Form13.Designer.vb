<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form13
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
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.cmdNear = New System.Windows.Forms.Button
        Me.cmdChange = New System.Windows.Forms.Button
        Me.cmdCalc = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtY = New System.Windows.Forms.TextBox
        Me.txtX = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtL = New System.Windows.Forms.TextBox
        Me.txtB = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.optCon = New System.Windows.Forms.RadioButton
        Me.optTran = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.opt6du = New System.Windows.Forms.RadioButton
        Me.opt3du = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtalfa = New System.Windows.Forms.TextBox
        Me.txta = New System.Windows.Forms.TextBox
        Me.Combo1 = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
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
        'cmdNear
        '
        Me.cmdNear.Location = New System.Drawing.Point(151, 335)
        Me.cmdNear.Name = "cmdNear"
        Me.cmdNear.Size = New System.Drawing.Size(65, 25)
        Me.cmdNear.TabIndex = 84
        Me.cmdNear.Text = "临带换算"
        '
        'cmdChange
        '
        Me.cmdChange.Location = New System.Drawing.Point(79, 335)
        Me.cmdChange.Name = "cmdChange"
        Me.cmdChange.Size = New System.Drawing.Size(65, 25)
        Me.cmdChange.TabIndex = 83
        Me.cmdChange.Text = " 6°->3°"
        '
        'cmdCalc
        '
        Me.cmdCalc.Location = New System.Drawing.Point(7, 335)
        Me.cmdCalc.Name = "cmdCalc"
        Me.cmdCalc.Size = New System.Drawing.Size(65, 25)
        Me.cmdCalc.TabIndex = 82
        Me.cmdCalc.Text = "BL->xy"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(2, 252)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 18)
        Me.Label13.Text = "高斯坐标："
        '
        'txtY
        '
        Me.txtY.AcceptsReturn = True
        Me.txtY.Enabled = False
        Me.txtY.Location = New System.Drawing.Point(20, 297)
        Me.txtY.MaxLength = 0
        Me.txtY.Name = "txtY"
        Me.txtY.Size = New System.Drawing.Size(161, 21)
        Me.txtY.TabIndex = 81
        Me.txtY.Text = "18399692.74"
        '
        'txtX
        '
        Me.txtX.AcceptsReturn = True
        Me.txtX.Enabled = False
        Me.txtX.Location = New System.Drawing.Point(20, 273)
        Me.txtX.MaxLength = 0
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(161, 21)
        Me.txtX.TabIndex = 80
        Me.txtX.Text = "3386902.25"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(188, 297)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 12)
        Me.Label11.Text = "m"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(188, 273)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 12)
        Me.Label10.Text = "m"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(4, 297)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 12)
        Me.Label7.Text = "Y"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(4, 273)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 12)
        Me.Label12.Text = "X"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(-1, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 19)
        Me.Label6.Text = "大地坐标："
        '
        'txtL
        '
        Me.txtL.AcceptsReturn = True
        Me.txtL.Location = New System.Drawing.Point(20, 227)
        Me.txtL.MaxLength = 0
        Me.txtL.Name = "txtL"
        Me.txtL.Size = New System.Drawing.Size(177, 21)
        Me.txtL.TabIndex = 79
        Me.txtL.Text = "111.47248974"
        '
        'txtB
        '
        Me.txtB.AcceptsReturn = True
        Me.txtB.Location = New System.Drawing.Point(20, 203)
        Me.txtB.MaxLength = 0
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(177, 21)
        Me.txtB.TabIndex = 78
        Me.txtB.Text = "31.04416832"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label4.Location = New System.Drawing.Point(4, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 12)
        Me.Label4.Text = "L"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label5.Location = New System.Drawing.Point(4, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 12)
        Me.Label5.Text = "B"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(3, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 19)
        Me.Label3.Text = "换算方式："
        '
        'optCon
        '
        Me.optCon.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.optCon.Location = New System.Drawing.Point(82, 161)
        Me.optCon.Name = "optCon"
        Me.optCon.Size = New System.Drawing.Size(57, 17)
        Me.optCon.TabIndex = 77
        Me.optCon.Text = "反算"
        '
        'optTran
        '
        Me.optTran.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.optTran.Checked = True
        Me.optTran.Location = New System.Drawing.Point(10, 161)
        Me.optTran.Name = "optTran"
        Me.optTran.Size = New System.Drawing.Size(57, 17)
        Me.optTran.TabIndex = 76
        Me.optTran.Text = "正算"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 19)
        Me.Label2.Text = "选择分带："
        '
        'opt6du
        '
        Me.opt6du.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.opt6du.Checked = True
        Me.opt6du.Location = New System.Drawing.Point(10, 118)
        Me.opt6du.Name = "opt6du"
        Me.opt6du.Size = New System.Drawing.Size(57, 17)
        Me.opt6du.TabIndex = 75
        Me.opt6du.Text = "六度带"
        '
        'opt3du
        '
        Me.opt3du.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.opt3du.Location = New System.Drawing.Point(82, 118)
        Me.opt3du.Name = "opt3du"
        Me.opt3du.Size = New System.Drawing.Size(57, 17)
        Me.opt3du.TabIndex = 74
        Me.opt3du.Text = "三度带"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 23)
        Me.Label1.Text = "选择椭球："
        '
        'txtalfa
        '
        Me.txtalfa.AcceptsReturn = True
        Me.txtalfa.Enabled = False
        Me.txtalfa.Location = New System.Drawing.Point(34, 47)
        Me.txtalfa.MaxLength = 0
        Me.txtalfa.Name = "txtalfa"
        Me.txtalfa.Size = New System.Drawing.Size(105, 21)
        Me.txtalfa.TabIndex = 73
        Me.txtalfa.Text = "298.3"
        '
        'txta
        '
        Me.txta.AcceptsReturn = True
        Me.txta.Enabled = False
        Me.txta.Location = New System.Drawing.Point(34, 23)
        Me.txta.MaxLength = 0
        Me.txta.Name = "txta"
        Me.txta.Size = New System.Drawing.Size(105, 21)
        Me.txta.TabIndex = 72
        Me.txta.Text = "6378245"
        '
        'Combo1
        '
        Me.Combo1.Location = New System.Drawing.Point(2, 71)
        Me.Combo1.Name = "Combo1"
        Me.Combo1.Size = New System.Drawing.Size(137, 22)
        Me.Combo1.TabIndex = 71
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label9.Location = New System.Drawing.Point(2, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 12)
        Me.Label9.Text = "alfa="
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label8.Location = New System.Drawing.Point(2, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 12)
        Me.Label8.Text = "a   ="
        '
        'MenuItem2
        '
        Me.MenuItem2.Text = "返回"
        '
        'Form13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 30)
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.cmdNear)
        Me.Controls.Add(Me.cmdChange)
        Me.Controls.Add(Me.cmdCalc)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtY)
        Me.Controls.Add(Me.txtX)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtL)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.optCon)
        Me.Controls.Add(Me.optTran)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.opt6du)
        Me.Controls.Add(Me.opt3du)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtalfa)
        Me.Controls.Add(Me.txta)
        Me.Controls.Add(Me.Combo1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form13"
        Me.Text = "高斯投影计算"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Public WithEvents cmdNear As System.Windows.Forms.Button
    Public WithEvents cmdChange As System.Windows.Forms.Button
    Public WithEvents cmdCalc As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents txtY As System.Windows.Forms.TextBox
    Public WithEvents txtX As System.Windows.Forms.TextBox
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents txtL As System.Windows.Forms.TextBox
    Public WithEvents txtB As System.Windows.Forms.TextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents optCon As System.Windows.Forms.RadioButton
    Public WithEvents optTran As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents opt6du As System.Windows.Forms.RadioButton
    Public WithEvents opt3du As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents txtalfa As System.Windows.Forms.TextBox
    Public WithEvents txta As System.Windows.Forms.TextBox
    Public WithEvents Combo1 As System.Windows.Forms.ComboBox
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
End Class
