<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
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
        Me.MenuItem3.Text = "方位角算坐标增量"
        '
        'MenuItem4
        '
        Me.MenuItem4.Text = "坐标反算"
        '
        'MenuItem2
        '
        Me.MenuItem2.Text = "返回"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 32)
        Me.Label1.Text = "请按照Ax,Ay,α(度，分，秒),S的顺序输入值"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.Text = "Ax:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(28, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(83, 21)
        Me.TextBox1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(117, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 16)
        Me.Label3.Text = "Ay:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(141, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(83, 21)
        Me.TextBox2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(7, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 21)
        Me.Label4.Text = "α:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(27, 72)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(45, 21)
        Me.TextBox3.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(141, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 21)
        Me.Label5.Text = "分"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(96, 73)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(45, 21)
        Me.TextBox4.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(213, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 21)
        Me.Label6.Text = "秒"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(162, 73)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(45, 21)
        Me.TextBox5.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(7, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 20)
        Me.Label7.Text = "S:"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(28, 106)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(83, 21)
        Me.TextBox6.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(156, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 21)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "正算"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(7, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 18)
        Me.Label8.Text = "计算结果："
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(7, 167)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 22)
        Me.Label9.Text = "Bx:"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(27, 168)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(83, 21)
        Me.TextBox7.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(117, 170)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 18)
        Me.Label10.Text = "By:"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(141, 167)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(83, 21)
        Me.TextBox8.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(75, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 21)
        Me.Label11.Text = "度"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(156, 209)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 21)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "清零"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form2"
        Me.Text = "二维坐标正算"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
End Class
