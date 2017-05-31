<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form15
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
        components = New System.ComponentModel.Container
        mainMenu1 = New System.Windows.Forms.Mainmenu()
        Me.Menu = mainMenu1
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Text = "Form15"
        Me.AutoScroll = True
    End Sub
End Class
