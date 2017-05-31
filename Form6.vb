Public Class Form6


    
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim angle, angLeft, angRight, cha As Double
        Dim fenS, miaoR, duR, fenL, duL, miaoL, fenR, duS, miaoS As Short

        duL = Val(txtduL.Text)
        fenL = Val(txtfenL.Text)
        miaoL = Val(txtmiaoL.Text)
        duR = Val(txtduR.Text)
        fenR = Val(txtfenR.Text)
        miaoR = Val(txtmiaoR.Text)

        angLeft = duL + fenL / 60 + miaoL / 3600
        angRight = duR + fenR / 60 + miaoR / 3600
        cha = (angLeft + angRight - 360) / 2
        angle = (angLeft - angRight + 180) / 2

        duS = Fix(angle)
        angle = (angle - duS) * 60
        fenS = Int(angle)
        angle = (angle - fenS) * 60
        miaoS = Int(angle)

        txtcha.Text = Trim(Str(Int(cha * 3600 + 0.5)))
        txtduS.Text = Trim(Str(duS))
        txtfenS.Text = Trim(Str(System.Math.Abs(fenS)))
        txtmiaoS.Text = Trim(Str(System.Math.Abs(miaoS)))
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Form1.Show()
        Me.Hide()

    End Sub
End Class