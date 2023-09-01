Public Class Form1
    Dim Name(15) As String
    Dim age(15) As Integer
    Dim counter As Integer = 0


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Name(counter) = TextBox1.Text
        age(counter) = TextBox2.Text
        counter = counter + 1
    End Sub
End Class
