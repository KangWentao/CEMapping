<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form11
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
        Me.Text2 = New System.Windows.Forms.TextBox
        Me.Text3 = New System.Windows.Forms.TextBox
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
        Me.Text1.AcceptsReturn = True
        Me.Text1.Location = New System.Drawing.Point(83, 25)
        Me.Text1.MaxLength = 0
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(130, 21)
        Me.Text1.TabIndex = 10
        '
        'Text2
        '
        Me.Text2.AcceptsReturn = True
        Me.Text2.Location = New System.Drawing.Point(83, 60)
        Me.Text2.MaxLength = 0
        Me.Text2.Name = "Text2"
        Me.Text2.Size = New System.Drawing.Size(130, 21)
        Me.Text2.TabIndex = 9
        '
        'Text3
        '
        Me.Text3.AcceptsReturn = True
        Me.Text3.Location = New System.Drawing.Point(83, 97)
        Me.Text3.MaxLength = 0
        Me.Text3.Name = "Text3"
        Me.Text3.Size = New System.Drawing.Size(130, 21)
        Me.Text3.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(18, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 21)
        Me.Label1.Text = "观测数："
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Location = New System.Drawing.Point(18, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 24)
        Me.Label2.Text = "平均值："
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label3.Location = New System.Drawing.Point(18, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 22)
        Me.Label3.Text = "中误差："
        '
        'MenuItem1
        '
        Me.MenuItem1.Text = "计算"
        '
        'MenuItem2
        '
        Me.MenuItem2.Text = "返回"
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.Text2)
        Me.Controls.Add(Me.Text3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form11"
        Me.Text = "带权均值与方差计算"
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Text1 As System.Windows.Forms.TextBox
    Public WithEvents Text2 As System.Windows.Forms.TextBox
    Public WithEvents Text3 As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
End Class
