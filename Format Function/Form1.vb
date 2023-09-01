Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = Format(8972.234, "General Number")
        TextBox2.Text = Format(8972.2, "Fixed Number")
        TextBox3.Text = Format(6648972.265, "Standard")
        TextBox4.Text = Format(6648972.265, "Currency")
        TextBox5.Text = Format(0.56324, "Percentage")
    End Sub
End Class
