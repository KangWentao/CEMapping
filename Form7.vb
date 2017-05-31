Public Class Form7

    
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim D, n, i, h, a, detH As Double
        Dim fen, du, miao As Short

        i = Val(txti.Text)
        h = Val(txth.Text)
        n = Val(txtn.Text)
        du = Val(txtDu.Text)
        fen = Val(txtFen.Text)
        miao = Val(txtMiao.Text)

        a = du + fen / 60 + miao / 3600
        a = a * 3.14159265358979 / 180
        D = 100 * n * System.Math.Cos(a) * System.Math.Cos(a)
        detH = D * System.Math.Tan(a) + i - h

        txtD.Text = Trim(Str(CDbl(Format(D, "0.000"))))
        txtdetH.Text = Trim(Str(CDbl(Format(detH, "0.000"))))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txti.Text = ""
        txth.Text = ""
        txtn.Text = ""
        txtDu.Text = ""
        txtFen.Text = ""
        txtMiao.Text = ""
        txtD.Text = ""
        txtdetH.Text = ""
        txti.Focus()
    End Sub
End Class