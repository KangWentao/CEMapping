<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form6
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtduL = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtfenL = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtmiaoL = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtmiaoR = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtfenR = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtduR = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtmiaoS = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtfenS = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtduS = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtcha = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.DataSet1 = New System.Data.DataSet
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        Me.mainMenu1.MenuItems.Add(Me.MenuItem2)
        '
        'MenuItem1
        '
        Me.MenuItem1.Text = "计算"
        '
        'MenuItem2
        '
        Me.MenuItem2.Text = "返回"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 19)
        Me.Label1.Text = "盘左："
        '
        'txtduL
        '
        Me.txtduL.Location = New System.Drawing.Point(46, 30)
        Me.txtduL.Name = "txtduL"
        Me.txtduL.Size = New System.Drawing.Size(35, 21)
        Me.txtduL.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(86, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 17)
        Me.Label2.Text = "度"
        '
        'txtfenL
        '
        Me.txtfenL.Location = New System.Drawing.Point(108, 30)
        Me.txtfenL.Name = "txtfenL"
        Me.txtfenL.Size = New System.Drawing.Size(35, 21)
        Me.txtfenL.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(152, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 17)
        Me.Label3.Text = "分"
        '
        'txtmiaoL
        '
        Me.txtmiaoL.Location = New System.Drawing.Point(171, 30)
        Me.txtmiaoL.Name = "txtmiaoL"
        Me.txtmiaoL.Size = New System.Drawing.Size(35, 21)
        Me.txtmiaoL.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(212, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 17)
        Me.Label4.Text = "秒"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(212, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 17)
        Me.Label5.Text = "秒"
        '
        'txtmiaoR
        '
        Me.txtmiaoR.Location = New System.Drawing.Point(171, 73)
        Me.txtmiaoR.Name = "txtmiaoR"
        Me.txtmiaoR.Size = New System.Drawing.Size(35, 21)
        Me.txtmiaoR.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(152, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 17)
        Me.Label6.Text = "分"
        '
        'txtfenR
        '
        Me.txtfenR.Location = New System.Drawing.Point(108, 73)
        Me.txtfenR.Name = "txtfenR"
        Me.txtfenR.Size = New System.Drawing.Size(35, 21)
        Me.txtfenR.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(86, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 17)
        Me.Label7.Text = "度"
        '
        'txtduR
        '
        Me.txtduR.Location = New System.Drawing.Point(46, 73)
        Me.txtduR.Name = "txtduR"
        Me.txtduR.Size = New System.Drawing.Size(35, 21)
        Me.txtduR.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(3, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 19)
        Me.Label8.Text = "盘右："
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(223, 181)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 17)
        Me.Label9.Text = "秒"
        '
        'txtmiaoS
        '
        Me.txtmiaoS.Location = New System.Drawing.Point(182, 179)
        Me.txtmiaoS.Name = "txtmiaoS"
        Me.txtmiaoS.Size = New System.Drawing.Size(35, 21)
        Me.txtmiaoS.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(163, 181)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 17)
        Me.Label10.Text = "分"
        '
        'txtfenS
        '
        Me.txtfenS.Location = New System.Drawing.Point(119, 179)
        Me.txtfenS.Name = "txtfenS"
        Me.txtfenS.Size = New System.Drawing.Size(35, 21)
        Me.txtfenS.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(97, 181)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 17)
        Me.Label11.Text = "度"
        '
        'txtduS
        '
        Me.txtduS.Location = New System.Drawing.Point(57, 179)
        Me.txtduS.Name = "txtduS"
        Me.txtduS.Size = New System.Drawing.Size(35, 21)
        Me.txtduS.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(3, 181)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 19)
        Me.Label12.Text = "竖直角："
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(37, 128)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 19)
        Me.Label13.Text = "指标："
        '
        'txtcha
        '
        Me.txtcha.Location = New System.Drawing.Point(81, 126)
        Me.txtcha.Name = "txtcha"
        Me.txtcha.Size = New System.Drawing.Size(98, 21)
        Me.txtcha.TabIndex = 31
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(185, 128)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 17)
        Me.Label14.Text = "秒"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Namespace = ""
        Me.DataSet1.Prefix = ""
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtcha)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtmiaoS)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtfenS)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtduS)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtmiaoR)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtfenR)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtduR)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtmiaoL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtfenL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtduL)
        Me.Controls.Add(Me.Label1)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form6"
        Me.Text = "竖直角计算"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtduL As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtfenL As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtmiaoL As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtmiaoR As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtfenR As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtduR As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtmiaoS As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtfenS As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtduS As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtcha As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet
End Class
