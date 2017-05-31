<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form18
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
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
        Me.MenuItem3.Text = "坐标正算"
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
        Me.Label1.Location = New System.Drawing.Point(3, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 17)
        Me.Label1.Text = "请输入方位角和距离："
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(19, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.Text = "△x=cosα·s"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(125, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.Text = "△y=sinα·s"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(75, 116)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(112, 21)
        Me.TextBox2.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(45, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 19)
        Me.Label5.Text = "s："
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(75, 197)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(112, 21)
        Me.TextBox3.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(43, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 19)
        Me.Label6.Text = "△x="
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(75, 233)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(112, 21)
        Me.TextBox4.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(43, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 19)
        Me.Label7.Text = "△y="
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(19, 152)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "计算"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(25, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 16)
        Me.Label8.Text = "结果："
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(77, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 21)
        Me.Label11.Text = "度"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(164, 78)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(45, 21)
        Me.TextBox5.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(215, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 21)
        Me.Label4.Text = "秒"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(98, 78)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(45, 21)
        Me.TextBox1.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(143, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 21)
        Me.Label9.Text = "分"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(29, 77)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(45, 21)
        Me.TextBox6.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(9, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 21)
        Me.Label10.Text = "α:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(143, 152)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 23)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "清零"
        '
        'Form18
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form18"
        Me.Text = "方位角算坐标增量"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
