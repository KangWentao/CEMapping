Public Class Form12
    Dim dX2, k2, e2, dY2 As Double '尺度参数、旋转参数、两个平移参数
    Dim y2, x2, Xx2, Yy2 As Double '二维坐标变换的正反数值
    Dim dY3, Ez, Ex, k3, Ey, dX3, dZ3 As Double '尺度参数、三个旋转参数、三个平移参数
    Dim Yy3, Z3, X3, Y3, Xx3, Zz3 As Double '三维坐标转换的正算数值
    Const PI As Double = 3.14159265358979
    Private Sub cmdCalc2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub cmdconCalc2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub cmdClear2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdCalc2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalc2.Click
        k2 = Val(txtK2.Text)
        e2 = Val(txtE2.Text)
        e2 = DoToHu(e2)
        dX2 = Val(txtdX2.Text)
        dY2 = Val(txtdY2.Text)
        x2 = Val(txtX2.Text)
        y2 = Val(txtY2.Text)

        Xx2 = (k2 + 1) * (x2 * System.Math.Cos(e2) + y2 * System.Math.Sin(e2)) + dX2
        Yy2 = (k2 + 1) * (y2 * System.Math.Cos(e2) - x2 * System.Math.Sin(e2)) + dY2

        txtXx2.Text = Format(Xx2, "0.0000")
        txtYy2.Text = Format(Yy2, "0.0000")
    End Sub
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

        HuToDo = du + fen / 100 + miao / 10000
    End Function


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

    Private Sub cmdconCalc2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdconCalc2.Click
        k2 = Val(txtK2.Text)
        e2 = Val(txtE2.Text)
        e2 = DoToHu(e2)
        dX2 = Val(txtdX2.Text)
        dY2 = Val(txtdY2.Text)
        Xx2 = Val(txtXx2.Text)
        Yy2 = Val(txtYy2.Text)

        x2 = ((Xx2 - dX2) * System.Math.Cos(e2) - (Yy2 - dY2) * System.Math.Sin(e2)) / (k2 + 1)
        y2 = ((Yy2 - dY2) * System.Math.Cos(e2) + (Xx2 - dX2) * System.Math.Sin(e2)) / (k2 + 1)

        txtX2.Text = Format(x2, "0.0000")
        txtY2.Text = Format(y2, "0.0000")
    End Sub

    Private Sub cmdClear2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear2.Click
        txtX2.Text = ""
        txtY2.Text = ""
        txtXx2.Text = ""
        txtYy2.Text = ""
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Form1.Show()
        Me.Hide()

    End Sub
End Class