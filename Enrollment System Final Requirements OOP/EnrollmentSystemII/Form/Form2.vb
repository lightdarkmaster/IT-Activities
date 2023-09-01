Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sql = "DELETE * FROM tblstudent WHERE student_id = '" & TextBox1.Text & "'"
        mysql(sql)
        sql = "DELETE * FROM tblgrade WHERE student_id = '" & TextBox1.Text & "'"
        mysql(sql)
        sql = "DELETE * FROM tbltotalave WHERE student_id = '" & TextBox1.Text & "'"
        mysql(sql)

        MsgBox("deleted")
        Call Form2_Load(sender, e)
        TextBox1.Clear()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT * FROM tblstudent"
        mysqldtg(sql, DataGridView1)
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
    End Sub

  
End Class