Public Class Form18

    Const PI As Double = 3.1415926535897931

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Form14.Show()
        Me.Hide()

    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim du, fen, miao, s As Decimal
        Dim d, hd, dy, dx As Decimal
        du = Val(TextBox6.Text)
        fen = Val(TextBox1.Text)
        miao = Val(TextBox5.Text)
        s = Val(TextBox2.Text)
        d = du + fen / 100.0# + miao / 10000.0#
        hd = DoToHu(d)
        dy = Math.Sin(hd) * s
        dx = Math.Cos(hd) * s
        TextBox3.Text = Format(dx, "0.000000")
        TextBox4.Text = Format(dy, "0.000000")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub
End Class