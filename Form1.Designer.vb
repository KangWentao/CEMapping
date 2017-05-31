<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        Me.mainMenu1.MenuItems.Add(Me.MenuItem2)
        '
        'MenuItem1
        '
        Me.MenuItem1.Text = "关于/帮助"
        '
        'MenuItem2
        '
        Me.MenuItem2.Text = "按OK键退出"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "二维坐标正反算"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(3, 157)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(117, 27)
        Me.Button7.TabIndex = 2
        Me.Button7.Text = "高斯投影计算"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(120, 157)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(117, 27)
        Me.Button8.TabIndex = 3
        Me.Button8.Text = "高斯投影分带"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(3, 107)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(117, 27)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "水平角计算"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(120, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 27)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "坐标方位角运算"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(120, 107)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(117, 27)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "竖直角计算"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(3, 55)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 27)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "三角高程测量"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(3, 210)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(117, 27)
        Me.Button9.TabIndex = 10
        Me.Button9.Text = "交会定点计算"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(120, 210)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(117, 27)
        Me.Button10.TabIndex = 11
        Me.Button10.Text = "带权均值与方差"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(120, 55)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 27)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "平面坐标转换"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button1)
        Me.KeyPreview = True
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.Text = "测绘辅助系统"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
