Public Class Form5

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim L, N As Double
        L = CDbl(Text1.Text)
        N = L \ 6
        Text2.Text = CStr(N)
        Text3.Text = CStr(N * 6 + 3)
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Form1.Show()
        Me.Hide()

    End Sub
End Class