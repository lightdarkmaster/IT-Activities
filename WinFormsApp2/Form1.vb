Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Integer Val(textBox1.Text)
        Dim num2 As Integer Val(textBox2.Text)
        Dim num3 As Integer

        num3 = num1 + num2
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
