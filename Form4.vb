Public Class Form4
    Dim iRound, n As Short
    Dim dblAngle() As Double
    Const PI As Double = 3.14159265
    
    Private Sub VScrollBar1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim fenRB, miaoRA, duRA, fenLB, miaoLA, duLA, fenLA, duLB, miaoLB, fenRA, duRB, miaoRB As Short
        Dim fenWH, miaoHAR, duHAR, fenHAL, duHAL, miaoHAL, fenHAR, duWH, miaoWH As Short
        Dim halfR, halfL, angle As Double

        duLA = Val(Text1.Text)
        fenLA = Val(Text2.Text)
        miaoLA = Val(Text3.Text)
        duLB = Val(Text4.Text)
        fenLB = Val(Text5.Text)
        miaoLB = Val(Text6.Text)
        duRA = Val(Text7.Text)
        fenRA = Val(Text8.Text)
        miaoRA = Val(Text9.Text)
        duRB = Val(Text10.Text)
        fenRB = Val(Text11.Text)
        miaoRB = Val(Text12.Text)

        halfL = (duLB - duLA) + (fenLB - fenLA) / 60 + (miaoLB - miaoLA) / 3600
        halfR = (duRB - duRA) + (fenRB - fenRA) / 60 + (miaoRB - miaoRA) / 3600
        If System.Math.Abs(halfL - halfR) * 3600 > 40 Then
            MsgBox("半测回差超限，请检查观测和输入是否正确！", , "角差超限")
            Exit Sub
        End If
        angle = (halfL + halfR) / 2

        duHAL = Int(halfL)
        halfL = (halfL - duHAL) * 60
        fenHAL = Int(halfL)
        halfL = (halfL - fenHAL) * 60
        miaoHAL = Int(halfL + 0.5)

        duHAR = Int(halfR)
        halfR = (halfR - duHAR) * 60
        fenHAR = Int(halfR)
        halfR = (halfR - fenHAR) * 60
        miaoHAR = Int(halfR + 0.5)

        duWH = Int(angle)
        angle = (angle - duWH) * 60
        fenWH = Int(angle)
        angle = (angle - fenWH) * 60
        miaoWH = Int(angle + 0.5)

        Text13.Text = Str(duHAL)
        Text14.Text = Str(fenHAL)
        Text15.Text = Str(miaoHAL)
        Text16.Text = Str(duHAR)
        Text17.Text = Str(fenHAR)
        Text18.Text = Str(miaoHAR)
        Text19.Text = Str(duWH)
        Text20.Text = Str(fenWH)
        Text21.Text = Str(miaoWH)
    End Sub

    
    
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Text1.Text = ""
        Text2.Text = ""
        Text3.Text = ""
        Text4.Text = ""
        Text5.Text = ""
        Text6.Text = ""
        Text7.Text = ""
        Text8.Text = ""
        Text9.Text = ""
        Text10.Text = ""
        Text11.Text = ""
        Text12.Text = ""
        Text13.Text = ""
        Text14.Text = ""
        Text15.Text = ""
        Text16.Text = ""
        Text17.Text = ""
        Text18.Text = ""
        Text19.Text = ""
        Text20.Text = ""
        Text21.Text = ""
        Text1.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        n = Val(Text22.Text)
        ReDim dblAngle(n)
        Button3_Click(Button3, New System.EventArgs())
        iRound = iRound + 1
        Label2.Visible = True
        Label2.Text = "正在输入第1个测回，共" & Trim(Str(n)) & "个。"
    End Sub
    Public Sub CalcPerRound(ByRef i As Short)
        Dim fen, du, miao As Short

        MenuItem1_Click(MenuItem1, New System.EventArgs())
        du = Val(Text19.Text)
        fen = Val(Text20.Text)
        miao = Val(Text21.Text)

        dblAngle(i) = du + fen / 100.0# + miao / 10000.0#
        dblAngle(i) = DoToHu(dblAngle(i))
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim result As Double
        Dim i As Short

        If iRound = n Then
            CalcPerRound((iRound))

            For i = 1 To n
                result = result + dblAngle(i)
            Next i
            result = result / n
            result = HuToDo(result)
            Text23.Text = Format(result, "0.0000")

            Exit Sub
        End If
        If iRound = n - 1 Then Button2.Text = "计算"
        CalcPerRound((iRound))
        iRound = iRound + 1
        Label2.Text = "正在输入第" & Trim(Str(iRound)) & "个测回，共" & Trim(Str(n)) & "个。"
        Button3_Click(Button3, New System.EventArgs())
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

    Private Sub Text1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text1.TextChanged

    End Sub
End Class