Public Class Form2
    Private Structure Point
        Dim x As Double
        Dim y As Double
    End Structure
    Dim d, m, s, d1, a As Double
    Dim xb, yb, dxab, dyab As Double
    Dim p1, p2 As Point
    Const PI As Double = 3.1415926535897931


    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Or e.KeyChar = "." Then
            If e.KeyChar = "." And InStr(TextBox1.Text, ".") > 0 Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Or e.KeyChar = "." Then
            If e.KeyChar = "." And InStr(TextBox2.Text, ".") > 0 Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Or e.KeyChar = "." Then
            If e.KeyChar = "." And InStr(TextBox3.Text, ".") > 0 Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Or e.KeyChar = "." Then
            If e.KeyChar = "." And InStr(TextBox4.Text, ".") > 0 Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Or e.KeyChar = "." Then
            If e.KeyChar = "." And InStr(TextBox5.Text, ".") > 0 Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If

    End Sub
    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Or e.KeyChar = "." Then
            If e.KeyChar = "." And InStr(TextBox6.Text, ".") > 0 Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fen, du, miao As Short
        Dim d, hd As Double
        du = Val(TextBox3.Text)
        fen = Val(TextBox4.Text)
        miao = Val(TextBox5.Text)

        d = du + fen / 100.0# + miao / 10000.0#
        hd = DoToHu(d)
        p1.x = TextBox1.Text
        p1.y = TextBox2.Text 
        d1 = TextBox6.Text

        dxab = d1 * Math.Cos(hd)
        dyab = d1 * Math.Sin(hd)
        p2.x = p1.x + dxab
        p2.y = p1.y + dyab
        TextBox7.Text = Format(p2.x, "0.000000")
        TextBox8.Text = Format(p2.y, "0.000000")
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


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""

    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Form18.Show()
        Me.Hide()

    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Form14.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class