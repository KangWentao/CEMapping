Public Class Form11
    Dim n, i As Short
    Dim a() As Double
    Dim b() As Double
    Dim total, mean, var, totalb As Double
   
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        n = Val(Text1.Text)
        ReDim a(n)
        ReDim b(n)
        total = 0
        totalb = 0

        For i = 1 To n
            a(i) = Val(InputBox("请输入第" & Str(i) & "个观测值：", "输入观测值"))
            b(i) = Val(InputBox("请输入第" & Str(i) & "个观测值的权：", "输入权"))
            total = total + a(i) * b(i)
            totalb = totalb + b(i)
        Next i
        mean = total / totalb
        For i = 1 To n
            var = var + (a(i) - mean) * (a(i) - mean) * b(i) * b(i) / (totalb * totalb)
        Next i
        var = System.Math.Sqrt(var / (n - 1))

        Text2.Text = Str(CDbl(Format(mean, "0.0000")))
        Text3.Text = Str(CDbl(Format(var, "0.0000")))
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Form1.Show()
        Me.Hide()

    End Sub
End Class