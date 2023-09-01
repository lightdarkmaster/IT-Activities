Public Class Form1
    Private Function sqroot(ByRef x As Single) As Double
        x = x ^ 0.5
        sqroot = x
    End Function
    Private Function sqroot1(ByVal y As Single) As Double
        y = y ^ 0.5
        sqroot1 = y
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim u As Single
        u = 9
        MsgBox(3 * sqroot(u),, "ByRef")
        MsgBox("Value of u is " & u,, "ByRef")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim u As Single
        u = 9
        MsgBox(3 * sqroot1(u),, "ByVal")
        MsgBox("Value of u is " & u,, "ByVal")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
