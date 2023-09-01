Public Class Listofsubject

    Private Sub btngo_subj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngo_subj.Click
        Try
            sql = "SELECT subject_s as [Subject],description_s as [Description]" _
            & ",unit_s as [Unit],year_s as [Year],subj_time as [Time] FROM tblsubjects Where year_s ='" _
            & cmbsex.Text & "'"
            mysqldtg(sql, dtglist_s)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Listofsubject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT * FROM tblyear"
        cbofill(sql, cmbsex)
    End Sub
End Class