Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = Math.Round(Val(TextBox1.Text), 2)
    End Sub
End Class
