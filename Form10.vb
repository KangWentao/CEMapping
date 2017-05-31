Public Class Form10

    Const Pi As Double = 3.141592653589
    
    Private Sub Command6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command6.Click
        Dim Xc, Xb, Xa, Ya, Yb, Yc As Double
        Dim fenC, miaoB, duB, fenA, duA, miaoA, fenB, duC, miaoC As Short
        Dim Xp, Pb, ctgc, ctga, b, a, c, ctgb, Pa, Pc, Yp As Double
        Dim ctgib, ic, ia, ib, ctgia, ctgic As Double

        Xa = Val(txthouXa.Text) : Ya = Val(txthouYa.Text)
        Xb = Val(txthouXb.Text) : Yb = Val(txthouYb.Text)
        Xc = Val(txthouXc.Text) : Yc = Val(txthouYc.Text)
        duA = Val(txthoudua.Text) : fenA = Val(txthoufena.Text) : miaoA = Val(txthoumiaoa.Text)
        duB = Val(txthoudub.Text) : fenB = Val(txthoufenb.Text) : miaoB = Val(txthoumiaob.Text)
        duC = Val(txthouduc.Text) : fenC = Val(txthoufenc.Text) : miaoC = Val(txthoumiaoc.Text)

        a = duA + fenA / 60 + miaoA / 3600 : a = a * Pi / 180 : ctga = 1 / System.Math.Tan(a)
        b = duB + fenB / 60 + miaoB / 3600 : b = b * Pi / 180 : ctgb = 1 / System.Math.Tan(b)
        c = duC + fenC / 60 + miaoC / 3600 : c = c * Pi / 180 : ctgc = 1 / System.Math.Tan(c)

        Call GetInnerAngle(Xa, Ya, Xb, Yb, Xc, Yc, ia, ib, ic)
        ctgia = 1 / System.Math.Tan(ia) : ctgib = 1 / System.Math.Tan(ib) : ctgic = 1 / System.Math.Tan(ic)

        Pa = 1 / (ctgia - ctga)
        Pb = 1 / (ctgib - ctgb)
        Pc = 1 / (ctgic - ctgc)

        Xp = (Xa * Pa + Xb * Pb + Xc * Pc) / (Pa + Pb + Pc)
        Yp = (Ya * Pa + Yb * Pb + Yc * Pc) / (Pa + Pb + Pc)

        txthouXp.Text = Trim(Format(Xp, "0.000"))
        txthouYp.Text = Trim(Format(Yp, "0.000"))
    End Sub
    Private Sub Command5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Command6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Command5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command5.Click
        txthouXa.Text = ""
        txthouYa.Text = ""
        txthouXb.Text = ""
        txthouYb.Text = ""
        txthouXc.Text = ""
        txthouYc.Text = ""
        txthoudua.Text = ""
        txthoufena.Text = ""
        txthoumiaoa.Text = ""
        txthoudub.Text = ""
        txthoufenb.Text = ""
        txthoumiaob.Text = ""
        txthouduc.Text = ""
        txthoufenc.Text = ""
        txthoumiaoc.Text = ""
        txthouXp.Text = ""
        txthouYp.Text = ""
        txthouXa.Focus()
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Form9.Show()
        Me.Hide()

    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Form8.Show()
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

    Private Sub txthouYa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txthouYa.TextChanged

    End Sub
End Class