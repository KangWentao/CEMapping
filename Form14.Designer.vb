<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form14
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
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.axj = New System.Windows.Forms.TextBox
        Me.ayj = New System.Windows.Forms.TextBox
        Me.bxj = New System.Windows.Forms.TextBox
        Me.byj = New System.Windows.Forms.TextBox
        Me.jl = New System.Windows.Forms.TextBox
        Me.fwj = New System.Windows.Forms.TextBox
        Me.Command1 = New System.Windows.Forms.Button
        Me.Command3 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        Me.mainMenu1.MenuItems.Add(Me.MenuItem2)
        '
        'MenuItem1
        '
        Me.MenuItem1.MenuItems.Add(Me.MenuItem3)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem4)
        Me.MenuItem1.Text = "菜单"
        '
        'MenuItem3
        '
        Me.MenuItem3.Text = "坐标正算"
        '
        'MenuItem4
        '
        Me.MenuItem4.Text = "方位角算坐标增量"
        '
        'MenuItem2
        '
        Me.MenuItem2.Text = "返回"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(7, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 22)
        Me.Label16.Text = "Ax："
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label17.Location = New System.Drawing.Point(7, 92)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(34, 25)
        Me.Label17.Text = "Bx："
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label18.Location = New System.Drawing.Point(34, 200)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 20)
        Me.Label18.Text = "距离"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label19.Location = New System.Drawing.Point(26, 233)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 17)
        Me.Label19.Text = "方位角"
        '
        'axj
        '
        Me.axj.AcceptsReturn = True
        Me.axj.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular)
        Me.axj.Location = New System.Drawing.Point(47, 21)
        Me.axj.MaxLength = 0
        Me.axj.Name = "axj"
        Me.axj.Size = New System.Drawing.Size(110, 25)
        Me.axj.TabIndex = 43
        Me.axj.Text = "0"
        '
        'ayj
        '
        Me.ayj.AcceptsReturn = True
        Me.ayj.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular)
        Me.ayj.Location = New System.Drawing.Point(47, 52)
        Me.ayj.MaxLength = 0
        Me.ayj.Name = "ayj"
        Me.ayj.Size = New System.Drawing.Size(110, 25)
        Me.ayj.TabIndex = 44
        Me.ayj.Text = "0"
        '
        'bxj
        '
        Me.bxj.AcceptsReturn = True
        Me.bxj.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular)
        Me.bxj.Location = New System.Drawing.Point(47, 92)
        Me.bxj.MaxLength = 0
        Me.bxj.Name = "bxj"
        Me.bxj.Size = New System.Drawing.Size(110, 25)
        Me.bxj.TabIndex = 45
        Me.bxj.Text = "10"
        '
        'byj
        '
        Me.byj.AcceptsReturn = True
        Me.byj.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular)
        Me.byj.Location = New System.Drawing.Point(47, 123)
        Me.byj.MaxLength = 0
        Me.byj.Name = "byj"
        Me.byj.Size = New System.Drawing.Size(110, 25)
        Me.byj.TabIndex = 46
        Me.byj.Text = "10"
        '
        'jl
        '
        Me.jl.AcceptsReturn = True
        Me.jl.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular)
        Me.jl.Location = New System.Drawing.Point(99, 198)
        Me.jl.MaxLength = 0
        Me.jl.Name = "jl"
        Me.jl.Size = New System.Drawing.Size(120, 25)
        Me.jl.TabIndex = 47
        '
        'fwj
        '
        Me.fwj.AcceptsReturn = True
        Me.fwj.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular)
        Me.fwj.Location = New System.Drawing.Point(99, 229)
        Me.fwj.MaxLength = 0
        Me.fwj.Name = "fwj"
        Me.fwj.Size = New System.Drawing.Size(120, 25)
        Me.fwj.TabIndex = 48
        '
        'Command1
        '
        Me.Command1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular)
        Me.Command1.Location = New System.Drawing.Point(163, 29)
        Me.Command1.Name = "Command1"
        Me.Command1.Size = New System.Drawing.Size(56, 27)
        Me.Command1.TabIndex = 49
        Me.Command1.Text = "反算"
        '
        'Command3
        '
        Me.Command3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular)
        Me.Command3.Location = New System.Drawing.Point(163, 103)
        Me.Command3.Name = "Command3"
        Me.Command3.Size = New System.Drawing.Size(56, 27)
        Me.Command3.TabIndex = 50
        Me.Command3.Text = "清零"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.Text = "Ay："
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Location = New System.Drawing.Point(7, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 25)
        Me.Label2.Text = "By："
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(7, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 18)
        Me.Label8.Text = "计算结果："
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.axj)
        Me.Controls.Add(Me.ayj)
        Me.Controls.Add(Me.bxj)
        Me.Controls.Add(Me.byj)
        Me.Controls.Add(Me.jl)
        Me.Controls.Add(Me.fwj)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Command3)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form14"
        Me.Text = "二维坐标反算"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents Label19 As System.Windows.Forms.Label
    Public WithEvents axj As System.Windows.Forms.TextBox
    Public WithEvents ayj As System.Windows.Forms.TextBox
    Public WithEvents bxj As System.Windows.Forms.TextBox
    Public WithEvents byj As System.Windows.Forms.TextBox
    Public WithEvents jl As System.Windows.Forms.TextBox
    Public WithEvents fwj As System.Windows.Forms.TextBox
    Public WithEvents Command1 As System.Windows.Forms.Button
    Public WithEvents Command3 As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
End Class
