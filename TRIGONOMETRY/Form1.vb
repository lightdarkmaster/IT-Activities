Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pi As Single
        pi = 2 * Math.Asin(1)
        MsgBox("Sin 90 is " & Math.Round(Math.Sin(pi / 2), 4))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pi As Single
        pi = 2 * Math.Asin(1)
        MsgBox("Cos 180 is " & Math.Round(Math.Cos(pi), 4))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pi As Single
        pi = 2 * Math.Asin(1)
        MsgBox("Tan 45 is " & Math.Round(Math.Tan(pi / 4)), 4)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim pi As Single
        pi = 2 * Math.Asin(1)
        MsgBox("Asin(1) is " & Math.Round(Math.Asin(1) * 180 / pi), 4)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim pi As Single
        pi = 2 * Math.Asin(1)
        MsgBox("Acos(1) is " & Math.Round(Math.Acos(1) * 180 / pi), 4)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim pi As Single
        pi = 2 * Math.Asin(1)
        MsgBox("Atan(1) is " & Math.Round(Math.Atan(1) * 180 / pi), 4)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim pi As Single
        Dim A As Single, B As Single, x As Single
        pi = 2 * Math.Asin(1)
        A = 60 * pi / 180
        B = 60 * pi / 180
        x = 4
        MsgBox("AC = " & Math.Round((x * Math.Sin(A) / Math.Sin(B)), 4))
    End Sub
End Class
