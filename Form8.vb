Public Class Form8
    Const Pi As Double = 3.141592653589

    Private Sub Command1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command1.Click
        Dim Xb, Xa, Ya, Yb As Double
        Dim fenB, miaoA, duA, fenA, duB, miaoB As Short
        Dim Xp, ctga, a, b, ctgb, Yp As Double

        Xa = Val(txtXa.Text)
        Ya = Val(txtYa.Text)
        Xb = Val(txtXb.Text)
        Yb = Val(txtYb.Text)
        duA = Val(txtDua.Text)
        fenA = Val(txtFena.Text)
        miaoA = Val(txtMiaoa.Text)
        duB = Val(txtDub.Text)
        fenB = Val(txtFenb.Text)
        miaoB = Val(txtMiaob.Text)

        a = duA + fenA / 60 + miaoA / 3600
        b = duB + fenB / 60 + miaoB / 3600
        a = a * Pi / 180
        b = b * Pi / 180
        ctga = 1 / System.Math.Tan(a)
        ctgb = 1 / System.Math.Tan(b)
        Xp = (Xa * ctgb + Xb * ctga + (Yb - Ya)) / (ctga + ctgb)
        Yp = (Ya * ctgb + Yb * ctga + (Xa - Xb)) / (ctga + ctgb)

        txtXp.Text = Trim(Format(Xp, "0.000"))
        txtYp.Text = Trim(Format(Yp, "0.000"))
    End Sub

    Private Sub Command2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command2.Click
        txtXa.Text = ""
        txtYa.Text = ""
        txtXb.Text = ""
        txtYb.Text = ""
        txtDua.Text = ""
        txtFena.Text = ""
        txtMiaoa.Text = ""
        txtDub.Text = ""
        txtFenb.Text = ""
        txtMiaob.Text = ""
        txtXp.Text = ""
        txtYp.Text = ""
        txtXa.Focus()
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Form9.Show()
        Me.Hide()

    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Form10.Show()
        Me.Hide()

    End Sub
    '求AB的坐标方位角，输出的是弧度值
    Public Function DirectAB(ByRef Xa As Double, ByRef Ya As Double, ByRef Xb As Double, ByRef Yb As Double) As Double
        Dim detY, detX, tana As Double
        detX = Xb - Xa
        detY = Yb - Ya
        If System.Math.Abs(detX) < 0.000001 Then
            If detY > 0 Then
                DirectAB = Pi / 2
            Else
                DirectAB = Pi * 3 / 2
            End If
        Else
            tana = detY / detX
            DirectAB = System.Math.Atan(tana)
            If detX < 0 Then
                DirectAB = Pi + DirectAB
            ElseIf detX > 0 And detY < 0 Then
                DirectAB = Pi * 2 + DirectAB
            End If
        End If
    End Function


    '由三角形顶点求内角的子过程
    Public Sub GetInnerAngle(ByRef Xa As Double, ByRef Ya As Double, ByRef Xb As Double, ByRef Yb As Double, ByRef Xc As Double, ByRef Yc As Double, ByRef a As Double, ByRef b As Double, ByRef c As Double)
        Dim cosb, Sc, Sa, Sb, cosa, cosc As Double

        Sa = System.Math.Sqrt((Xc - Xb) * (Xc - Xb) + (Yc - Yb) * (Yc - Yb))
        Sb = System.Math.Sqrt((Xc - Xa) * (Xc - Xa) + (Yc - Ya) * (Yc - Ya))
        Sc = System.Math.Sqrt((Xa - Xb) * (Xa - Xb) + (Ya - Yb) * (Ya - Yb))
        cosa = (Sb * Sb + Sc * Sc - Sa * Sa) / (2 * Sb * Sc)
        cosb = (Sa * Sa + Sc * Sc - Sb * Sb) / (2 * Sa * Sc)
        cosc = (Sb * Sb + Sa * Sa - Sc * Sc) / (2 * Sa * Sb)

        a = Math.Acos(cosa) : b = Math.Acos(cosb) : c = Math.Acos(cosc)
    End Sub

    '由三角形边长求内角的子过程
    Public Sub GetInnerAngleS(ByRef Sa As Double, ByRef Sb As Double, ByRef Sc As Double, ByRef a As Double, ByRef b As Double, ByRef c As Double)
        Dim cosb, cosa, cosc As Double

        cosa = (Sb * Sb + Sc * Sc - Sa * Sa) / (2 * Sb * Sc)
        cosb = (Sa * Sa + Sc * Sc - Sb * Sb) / (2 * Sa * Sc)
        cosc = (Sb * Sb + Sa * Sa - Sc * Sc) / (2 * Sa * Sb)

        a = Math.Acos(cosa) : b = Math.Acos(cosb) : c = Math.Acos(cosc)
    End Sub
End Class