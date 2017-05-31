Imports VB = Microsoft.VisualBasic
Public Class Form13

    Dim Y, L, B, X, L0 As Double
    Dim N As Short '经纬度，高斯坐标，和带号、中央子午线经度
    Dim lenL As Double '三度带还是六度带
    Const PI As Double = 3.14159265358979
    Private Sub cmdCalc_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCalc.Click
        B = Val(txtB.Text)
        L = Val(txtL.Text)
        X = Val(txtX.Text) : Y = Val(Mid(txtY.Text, 3))

        '计算中央子午线经度和带号
        If optTran.Checked = True Then '正算
            N = (L + lenL / 2) \ lenL
        ElseIf optCon.Checked = True Then  '反算
            N = Val(VB.Left(txtY.Text, 2))
        End If
        L0 = N * lenL - lenL / 2
        B = DoToHu(B)
        L = DoToHu(L)
        '根据椭球进行投影计算
        If optTran.Checked = True Then '正算
            If Combo1.SelectedIndex = 0 Then '54
                Call Pro54()
            ElseIf Combo1.SelectedIndex = 1 Then  '80
                Call Pro80()
            End If
            'Y坐标加500公里加带号
            Y = Y + N * 1000000 + 500000
            txtX.Text = Format(X, "0.0000")
            txtY.Text = Format(Y, "0.0000")
        ElseIf optCon.Checked = True Then  '反算
            'Y坐标还要再减500km
            Y = Y - 500000
            If Combo1.SelectedIndex = 0 Then '54
                Call ConPro54()
            ElseIf Combo1.SelectedIndex = 1 Then  '80
                Call ConPro80()
            End If
            txtB.Text = Format(HuToDo(B), "0.00000000")
            txtL.Text = Format(HuToDo(L), "0.00000000")
        End If
    End Sub

    Private Sub cmdChange_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdChange.Click
        X = Val(txtX.Text) : Y = Val(Mid(txtY.Text, 3))
        'Y坐标还要再减500km
        Y = Y - 500000

        '计算开始的中央子午线经度和带号
        N = Val(VB.Left(txtY.Text, 2))
        L0 = N * lenL - lenL / 2
        '根据椭球进行投影反算
        If Combo1.SelectedIndex = 0 Then '54
            Call ConPro54()
        ElseIf Combo1.SelectedIndex = 1 Then  '80
            Call ConPro80()
        End If
        '计算目标中央子午线经度和带号
        lenL = IIf(lenL = 6, 3, 6)
        N = (HuToDo(L) + lenL / 2) \ lenL
        L0 = N * lenL - lenL / 2
        '根据椭球进行投影计算
        If Combo1.SelectedIndex = 0 Then '54
            Call Pro54()
        ElseIf Combo1.SelectedIndex = 1 Then  '80
            Call Pro80()
        End If

        'Y坐标加500公里加带号
        Y = Y + N * 1000000 + 500000
        txtX.Text = Format(X, "0.0000")
        txtY.Text = Format(Y, "0.0000")
    End Sub

    Private Sub cmdNear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNear.Click
        X = Val(txtX.Text) : Y = Val(Mid(txtY.Text, 3))
        'Y坐标还要再减500km
        Y = Y - 500000

        '计算开始的中央子午线经度和带号
        N = Val(VB.Left(txtY.Text, 2))
        L0 = N * lenL - lenL / 2
        '根据椭球进行投影反算
        If Combo1.SelectedIndex = 0 Then '54
            Call ConPro54()
        ElseIf Combo1.SelectedIndex = 1 Then  '80
            Call ConPro80()
        End If
        '计算目标中央子午线经度和带号
        L = HuToDo(L)
        L = IIf(L > L0, L + lenL, L - lenL)
        N = (L + lenL / 2) \ lenL
        L = DoToHu(L)
        L0 = N * lenL - lenL / 2
        '根据椭球进行投影计算
        If Combo1.SelectedIndex = 0 Then '54
            Call Pro54()
        ElseIf Combo1.SelectedIndex = 1 Then  '80
            Call Pro80()
        End If
        'Y坐标加500公里加带号
        Y = Y + N * 1000000 + 500000
        txtX.Text = Format(X, "0.0000")
        txtY.Text = Format(Y, "0.0000")
    End Sub

    'UPGRADE_WARNING: 初始化窗体时可能激发事件 Combo1.SelectedIndexChanged。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"”
    Private Sub Combo1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Combo1.SelectedIndexChanged
        Dim i As Short
        i = Combo1.SelectedIndex
        If i = 0 Then
            txta.Enabled = False
            txtalfa.Enabled = False
            txta.Text = Str(6378245)
            txtalfa.Text = Str(298.3)
        ElseIf i = 1 Then
            txta.Enabled = False
            txtalfa.Enabled = False
            txta.Text = Str(6378140)
            txtalfa.Text = Str(298.257)
        ElseIf i = 2 Then
            txta.Enabled = False
            txtalfa.Enabled = False
            txta.Text = Str(6378137)
            txtalfa.Text = Str(298.2572235635)
        ElseIf i = 3 Then
            txta.Enabled = True
            txtalfa.Enabled = True
            txta.Focus()
        End If
    End Sub

    Private Sub frmProjection_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        '初始化组合框
        Combo1.Items.Add("北京1954参考椭球")
        Combo1.Items.Add("西安1980参考椭球")
        Combo1.Items.Add("WGS1984参考椭球")
        Combo1.Items.Add("自定义参考椭球")
        Combo1.SelectedIndex = 0
        '初始化参数
        lenL = 6
    End Sub

    '选择了3度带分
    'UPGRADE_WARNING: 初始化窗体时可能激发事件 opt3du.CheckedChanged。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"”
    Private Sub opt3du_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles opt3du.CheckedChanged

        cmdChange.Text = " 3°->6°"
        lenL = 3

    End Sub

    '选择了6度分带
    'UPGRADE_WARNING: 初始化窗体时可能激发事件 opt6du.CheckedChanged。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"”
    Private Sub opt6du_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles opt6du.CheckedChanged

        cmdChange.Text = " 6°->3°"
        lenL = 6

    End Sub

    '选择了反算方式
    'UPGRADE_WARNING: 初始化窗体时可能激发事件 optCon.CheckedChanged。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"”
    Private Sub optCon_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optCon.CheckedChanged

        cmdCalc.Text = "xy->BL"

        txtB.Enabled = False
        txtL.Enabled = False
        txtX.Enabled = True
        txtY.Enabled = True
        txtX.Focus()

    End Sub

    '选择了正算方式
    'UPGRADE_WARNING: 初始化窗体时可能激发事件 optTran.CheckedChanged。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"”
    Private Sub optTran_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optTran.CheckedChanged

        cmdCalc.Text = "BL->xy"

        txtB.Enabled = True
        txtL.Enabled = True
        txtX.Enabled = False
        txtY.Enabled = False
        txtB.Focus()

    End Sub

    Public Sub Pro54()
        Dim a5, a6, a0, ll, N, a4, a3, cosB As Double

        cosB = System.Math.Cos(B)
        ll = L - DoToHu(L0)
        N = 6399698.902 - (21562.267 - (108.973 - 0.612 * cosB * cosB) * cosB * cosB) * cosB * cosB
        a0 = 32140.404 - (135.3302 - (0.7092 - 0.004 * cosB * cosB) * cosB * cosB) * cosB * cosB
        a4 = (0.25 + 0.00252 * cosB * cosB) * cosB * cosB - 0.04166
        a6 = (0.166 * cosB * cosB - 0.084) * cosB * cosB
        a3 = (0.3333333 + 0.001123 * cosB * cosB) * cosB * cosB - 0.1666667
        a5 = 0.0083 - (0.1667 - (0.1968 + 0.004 * cosB * cosB) * cosB * cosB) * cosB * cosB

        X = 6367558.4969 * B - (a0 - (0.5 + (a4 + a6 * ll * ll) * ll * ll) * ll * ll * N) * System.Math.Sin(B) * cosB
        Y = (1 + (a3 + a5 * ll * ll) * ll * ll) * ll * N * cosB
    End Sub

    Public Sub Pro80()
        Dim a5, a6, a0, ll, N, a4, a3, cosB As Double

        cosB = System.Math.Cos(B)
        ll = L - DoToHu(L0)
        N = 6399596.652 - (21565.045 - (108.996 - 0.603 * cosB * cosB) * cosB * cosB) * cosB * cosB
        a0 = 32144.5189 - (135.3646 - (0.7034 - 0.0041 * cosB * cosB) * cosB * cosB) * cosB * cosB
        a4 = (0.25 + 0.00253 * cosB * cosB) * cosB * cosB - 0.04167
        a6 = (0.167 * cosB * cosB - 0.083) * cosB * cosB
        a3 = (0.3333333 + 0.001123 * cosB * cosB) * cosB * cosB - 0.1666667
        a5 = 0.00878 - (0.1702 - 0.20382 * cosB * cosB) * cosB * cosB

        X = 6367452.1328 * B - (a0 - (0.5 + (a4 + a6 * ll * ll) * ll * ll) * ll * ll * N) * System.Math.Sin(B) * cosB
        Y = (1 + (a3 + a5 * ll * ll) * ll * ll) * ll * N * cosB
    End Sub

    Public Sub ConPro54()
        Dim cos2B, b4, b2, Z, Bf, bet, Nf, b3, b5, cos2Bf As Double

        bet = X * 206265 / 6367558.4969
        cos2B = System.Math.Cos(bet) * System.Math.Cos(bet)
        Bf = bet + (50221746 + (293622 + (2350 + 22 * cos2B) * cos2B) * cos2B) * 0.0000000001 * System.Math.Sin(bet) * System.Math.Cos(bet)
        cos2Bf = System.Math.Cos(Bf) * System.Math.Cos(Bf)

        Nf = 6399698.902 - (21562.267 - (108.973 - 0.612 * cos2Bf) * cos2Bf) * cos2Bf
        Z = Y / (Nf * System.Math.Cos(Bf))
        b2 = (0.5 + 0.003369 * cos2Bf) * System.Math.Sin(Bf) * System.Math.Cos(Bf)
        b3 = 0.333333 - (0.166667 - 0.001123 * cos2Bf) * cos2Bf
        b4 = 0.25 + (0.16161 + 0.00562 * cos2Bf) * cos2Bf
        b5 = 0.2 - (0.1667 - 0.0088 * cos2Bf) * cos2Bf

        B = Bf / 206265 - (1 - (b4 - 0.12 * Z * Z) * Z * Z) * Z * Z * b2
        L = DoToHu(L0) + (1 - (b3 - b5 * Z * Z) * Z * Z) * Z
    End Sub

    Public Sub ConPro80()
        Dim cos2B, b4, b2, Z, Bf, bet, Nf, b3, b5, cos2Bf As Double

        bet = X * 206265 / 6367558.4969
        cos2B = System.Math.Cos(B) * System.Math.Cos(B)
        Bf = bet + (50221746 + (293622 + (2350 + 22 * cos2B) * cos2B) * cos2B) * 0.0000000001 * System.Math.Sin(bet) * System.Math.Cos(bet)
        cos2Bf = System.Math.Cos(Bf) * System.Math.Cos(Bf)

        Nf = 6399698.902 - (21562.267 - (108.973 - 0.612 * cos2Bf) * cos2Bf) * cos2Bf
        Z = Y / (Nf * System.Math.Cos(Bf))
        b2 = (0.5 + 0.00336975 * cos2Bf) * System.Math.Sin(Bf) * System.Math.Cos(Bf)
        b3 = 0.333333 - (0.166667 - 0.001123 * cos2Bf) * cos2Bf
        b4 = 0.25 + (0.161612 + 0.005617 * cos2Bf) * cos2Bf
        b5 = 0.2 - (0.16667 - 0.00878 * cos2Bf) * cos2Bf

        B = Bf / 206265 - (1 - (b4 - 0.147 * Z * Z) * Z * Z) * Z * Z * b2
        L = DoToHu(L0) + (1 - (b3 - b5 * Z * Z) * Z * Z) * Z
    End Sub

    '将度.分秒形式化为弧度：输入为度.分秒形式，输出为弧度
    Public Function DoToHu(ByVal DoFenMiao As Double) As Single
        Dim fen, du, miao As Short
        Dim angle As Double
        du = Fix(DoFenMiao)
        DoFenMiao = (DoFenMiao - du) * 100
        fen = Fix(DoFenMiao)
        miao = (DoFenMiao - fen) * 100
        angle = du + fen / 60 + miao / 3600
        DoToHu = angle * PI / 180
    End Function

    '弧度化为度.分秒的形式：输入弧度值，输出度.分秒（各占两位）
    Public Function HuToDo(ByVal Hu As Double) As Single
        Dim fen, du, miao As Short

        Hu = Hu * 180 / PI

        du = Fix(Hu)
        Hu = (Hu - du) * 60
        fen = Fix(Hu)
        Hu = (Hu - fen) * 60
        miao = Fix(Hu + 0.5)
        If miao = 60 Then
            fen = fen + 1
            miao = 0
        End If
        If fen = 60 Then
            du = du + 1
            fen = 0
        End If
        HuToDo = du + fen / 100 + miao / 10000
    End Function

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Form1.Show()
        Me.Hide()

    End Sub
End Class