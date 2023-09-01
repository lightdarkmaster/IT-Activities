Public Class Form1

    Private Function FV(pv As Single, i As Single, n As Integer) As Double
        FV = pv * (1 + i / 100) ^ n
    End Function
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FutureVal As Single
        Dim PresentVal As Single
        Dim Interest As Single
        Dim Period As Integer
        PresentVal = TextBox1.Text
        Interest = TextBox2.Text
        Period = TextBox3.Text
        FutureVal = FV(PresentVal, Interest, Period)
        TextBox4.Text = Format(FutureVal, "$#,##0.00")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

    End Sub
End Class
