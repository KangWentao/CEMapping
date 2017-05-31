<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form5
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
        Me.Text1 = New System.Windows.Forms.TextBox
        Me.Text3 = New System.Windows.Forms.TextBox
        Me.Text2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        Me.mainMenu1.MenuItems.Add(Me.MenuItem2)
        '
        'Text1
        '
        Me.Text1.Location = New System.Drawing.Point(89, 23)
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(127, 21)
        Me.Text1.TabIndex = 0
        '
        'Text3
        '
        Me.Text3.Location = New System.Drawing.Point(115, 117)
        Me.Text3.Name = "Text3"
        Me.Text3.Size = New System.Drawing.Size(101, 21)
        Me.Text3.TabIndex = 1
        '
        'Text2
        '
        Me.Text2.Location = New System.Drawing.Point(89, 70)
        Me.Text2.Name = "Text2"
        Me.Text2.Size = New System.Drawing.Size(127, 21)
        Me.Text2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(21, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 19)
        Me.Label1.Text = "经度："
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(21, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 19)
        Me.Label2.Text = "带号："
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(21, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 19)
        Me.Label3.Text = "中央子午线："
        '
        'MenuItem1
        '
        Me.MenuItem1.Text = "计算"
        '
        'MenuItem2
        '
        Me.MenuItem2.Text = "返回"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Text2)
        Me.Controls.Add(Me.Text3)
        Me.Controls.Add(Me.Text1)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form5"
        Me.Text = "高斯投影分带计算"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents Text1 As System.Windows.Forms.TextBox
    Friend WithEvents Text3 As System.Windows.Forms.TextBox
    Friend WithEvents Text2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
