Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = Format(Now, "General Date")
        TextBox2.Text = Format(Now, "Long Date")
        TextBox3.Text = Format(Now, "Short Date")
        TextBox4.Text = Format(Now, "Long Time")
        TextBox5.Text = Format(Now, "Short Time")
    End Sub
End Class
