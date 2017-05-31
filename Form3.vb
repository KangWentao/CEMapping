Public Class Form3

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        txtXa.Text = ""
        txtYa.Text = ""
        txtXb.Text = ""
        txtYb.Text = ""
        txtDu.Text = ""
        txtFen.Text = ""
        txtMiao.Text = ""
        txtS.Text = ""

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Xa#, Ya#, Xb#, Yb#, detX#, detY#, tana#, ab#, du%, fen%, miao%, s#
        Const Pi = 3.14159265358979

        Xa = Val(txtXa.Text)
        Ya = Val(txtYa.Text)
        Xb = Val(txtXb.Text)
        Yb = Val(txtYb.Text)

        detX = Xb - Xa
        detY = Yb - Ya
        If Math.Abs(detX) < 0.00000001 Then
            MsgBox("除数为零，请检查坐标输入是否正确！")

            Exit Sub
        End If
        s = Math.Sqrt(detX * detX + detY * detY)
        If Math.Abs(detX) < 0.000001 Then
            If detY > 0 Then
                ab = 90
            Else
                ab = 270
            End If
        Else
            tana = detY / detX
            ab = Math.Atan(tana)  '得到的是弧度
            ab = ab * 180 / Pi
            If detX < 0 Then
                ab = 180 + ab
            ElseIf detX > 0 And detY < 0 Then
                ab = 360 + ab
            End If
        End If


        du = Fix(ab)
        ab = (ab - du) * 60
        fen = Fix(ab)
        ab = (ab - fen) * 60
        miao = Fix(ab)

        txtDu.Text = Trim(Str(du))
        txtFen.Text = Trim(Str(fen))
        txtMiao.Text = Trim(Str(miao))
        txtS.Text = Trim(Format(s, "0.0000"))
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form3_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = System.Windows.Forms.Keys.Up) Then
            'Up
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.Down) Then
            'Down
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.Left) Then
            'Left
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.Right) Then
            'Right
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.Enter) Then
            'Enter
        End If

    End Sub
End Class