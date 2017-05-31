<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form3
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
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.txtXa = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtXb = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtYa = New System.Windows.Forms.TextBox
        Me.txtYb = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtS = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDu = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtFen = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtMiao = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        Me.mainMenu1.MenuItems.Add(Me.MenuItem2)
        '
        'MenuItem1
        '
        Me.MenuItem1.Text = "清零"
        '
        'MenuItem2
        '
        Me.MenuItem2.Text = "返回"
        '
        'txtXa
        '
        Me.txtXa.Location = New System.Drawing.Point(38, 22)
        Me.txtXa.Name = "txtXa"
        Me.txtXa.Size = New System.Drawing.Size(63, 21)
        Me.txtXa.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 22)
        Me.Label1.Text = "Xa="
        '
        'txtXb
        '
        Me.txtXb.Location = New System.Drawing.Point(38, 59)
        Me.txtXb.Name = "txtXb"
        Me.txtXb.Size = New System.Drawing.Size(63, 21)
        Me.txtXb.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 22)
        Me.Label2.Text = "Xb="
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(127, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 20)
        Me.Label3.Text = "Ya="
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(127, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 20)
        Me.Label4.Text = "Yb="
        '
        'txtYa
        '
        Me.txtYa.Location = New System.Drawing.Point(164, 22)
        Me.txtYa.Name = "txtYa"
        Me.txtYa.Size = New System.Drawing.Size(63, 21)
        Me.txtYa.TabIndex = 6
        '
        'txtYb
        '
        Me.txtYb.Location = New System.Drawing.Point(164, 59)
        Me.txtYb.Name = "txtYb"
        Me.txtYb.Size = New System.Drawing.Size(63, 21)
        Me.txtYb.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(38, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 21)
        Me.Label5.Text = "距离："
        '
        'txtS
        '
        Me.txtS.Location = New System.Drawing.Point(81, 168)
        Me.txtS.Name = "txtS"
        Me.txtS.Size = New System.Drawing.Size(125, 21)
        Me.txtS.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(11, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 21)
        Me.Label6.Text = "方位角ab："
        '
        'txtDu
        '
        Me.txtDu.Location = New System.Drawing.Point(81, 211)
        Me.txtDu.Name = "txtDu"
        Me.txtDu.Size = New System.Drawing.Size(31, 21)
        Me.txtDu.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(79, 114)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 29)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "计算"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(112, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 18)
        Me.Label7.Text = "度"
        '
        'txtFen
        '
        Me.txtFen.Location = New System.Drawing.Point(127, 211)
        Me.txtFen.Name = "txtFen"
        Me.txtFen.Size = New System.Drawing.Size(31, 21)
        Me.txtFen.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(158, 212)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 19)
        Me.Label8.Text = "分"
        '
        'txtMiao
        '
        Me.txtMiao.Location = New System.Drawing.Point(175, 211)
        Me.txtMiao.Name = "txtMiao"
        Me.txtMiao.Size = New System.Drawing.Size(31, 21)
        Me.txtMiao.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(210, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 17)
        Me.Label9.Text = "秒"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtMiao)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtFen)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDu)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtYb)
        Me.Controls.Add(Me.txtYa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtXb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtXa)
        Me.KeyPreview = True
        Me.Menu = Me.mainMenu1
        Me.Name = "Form3"
        Me.Text = "坐标方位角运算"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents txtXa As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtXb As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtYa As System.Windows.Forms.TextBox
    Friend WithEvents txtYb As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtS As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDu As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFen As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMiao As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
