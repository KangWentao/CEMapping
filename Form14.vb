Public Class Form14
    Inherits System.Windows.Forms.Form
    Const PI As Double = 3.14159265358979

    Private Sub Command3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Command1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label16_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.ParentChanged

    End Sub

    Private Sub Form14_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Command1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command1.Click
        Dim ax As Double
        Dim bx As Double
        Dim ay As Double
        Dim by As Double
        Dim xx As Double
        Dim yy As Double
        Dim fwj1 As Double
        Dim hudu As Double
        ax = Val(axj.Text)
        bx = Val(bxj.Text)
        ay = Val(ayj.Text)
        by = Val(byj.Text)

        xx = bx - ax
        yy = by - ay
        jl.Text = CStr((xx * xx + yy * yy) ^ 0.5)

        If xx = 0 Then
            If yy > 0 Then
                fwj.Text = CStr(90)
            End If
            If yy < 0 Then
                fwj.Text = CStr(270)
            End If
        Else

            hudu = System.Math.Atan(yy / xx)

            Call hdhwdfm(hudu, fwj1) '方位角等于90°的情况需要考虑
            fwj.Text = CStr(fwj1)
            If yy < 0 Then
                fwj.Text = CStr(CDbl(fwj.Text) + 180)

            End If
        End If
    End Sub
    Public Sub hdhwdfm(ByRef Hu As Double, ByRef dfm As Double)
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
        dfm = du + fen / 100 + miao / 10000
    End Sub
    Private Sub Command3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command3.Click
        axj.Text = ""
        bxj.Text = ""
        ayj.Text = ""
        byj.Text = ""
        jl.Text = ""
        fwj.Text = ""
    End Sub


    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Form18.Show()
        Me.Hide()

    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Form2.Show()
        Me.Hide()

    End Sub
End Class