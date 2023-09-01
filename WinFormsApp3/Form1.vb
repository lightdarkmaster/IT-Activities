Public Class Form1
    Dim ngaran(15) As String
    Dim age(15) As Integer
    Dim count As Integer = 1


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ngaran(count) = TextBox1.Text
        age(count) = TextBox2.Text
        count = count + 1
        MsgBox("Added Succesfully")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ngaran(TextBox3.Text) = TextBox4.Text
        age(TextBox3.Text) = TextBox5.Text

        MsgBox("Data Updated")


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ngaran(TextBox3.Text) = 0
        age(TextBox3.Text) = 0
        MsgBox("Data Deleted Sucessfully")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox4.Text = ngaran(TextBox3.Text)
        TextBox5.Text = age(TextBox3.Text)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
