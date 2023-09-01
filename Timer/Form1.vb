Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = Format(Now, "m")
        TextBox2.Text = Format(Now, "mm")
        TextBox3.Text = Format(Now, "mmm")
        TextBox4.Text = Format(Now, "mmmm")
        TextBox5.Text = Format(Now, "dd/mm/yyyy")
        TextBox6.Text = Format(Now, "mmm/d/yyyy")
        TextBox7.Text = Format(Now, "h:mm:ss tt")
        TextBox8.Text = Format(Now, "MM/dd/yyyy h:mm:ss tt")

    End Sub
End Class
