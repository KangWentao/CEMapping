Public Class Form1

   

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form7.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form12.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form4.Show()
        Me.Hide()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form6.Show()
        Me.Hide()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Form13.Show()
        Me.Hide()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Form5.Show()
        Me.Hide()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Form8.Show()
        Me.Hide()

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Form11.Show()
        Me.Hide()

    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        FormAbout.Show()
        Me.Hide()

    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click

    End Sub
End Class
