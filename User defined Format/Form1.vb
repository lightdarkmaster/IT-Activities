Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = Format(8971.234, "0.0")
        TextBox2.Text = Format(8971.234, "0.00")
        TextBox3.Text = Format(8971.234, "#, ##0.00")
        TextBox4.Text = Format(8971.234, "$#,##0.00")
        TextBox5.Text = Format(8971.234, "0%")

    End Sub
End Class
