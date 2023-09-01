Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Clicking the Label huh?")
    End Sub

    Private Sub MsgBox(v As String)
        Throw New NotImplementedException()
    End Sub
End Class
