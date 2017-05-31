<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FormAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAbout))
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        '
        'MenuItem1
        '
        Me.MenuItem1.Text = "返回"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 135)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(48, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 16)
        Me.Label1.Text = "Developed By：Midori"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(40, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 19)
        Me.Label2.Text = "WinCE内核版本：5.2.1620"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(40, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 17)
        Me.Label3.Text = ".Net Framework版本：3.5"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(4, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(223, 107)
        Me.Label4.Text = "推荐使用触屏笔操作，因为这键盘手感实在太糟心，笔的位置在机器的右上角，后面。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "键盘右下角的黄色按键连按两下，看到下方屏幕中央的""拼""变成一个实心黄色圆球的时候就" & _
            "可以连续输入键盘上面表示为黄色的字符"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(4, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(222, 79)
        Me.Label5.Text = "由于相同的原因，一些需要大量输入的计算功能被转移到电脑上。PC程序下载地址：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "http://pan.baidu.com/s/1mgUK5fy " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "密码: p5w" & _
            "u"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(4, 376)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(219, 49)
        Me.Label7.Text = "哦对了还有，用这个的时候前几遍一定要动手验算，因为写出这玩意的那个程序员，他高数没及格！"
        '
        'FormAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 100)
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Menu = Me.mainMenu1
        Me.Name = "FormAbout"
        Me.Text = "关于这个程序"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
