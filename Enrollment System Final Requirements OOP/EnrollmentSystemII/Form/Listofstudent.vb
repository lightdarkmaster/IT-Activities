Public Class Listofstudent

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub btnaddstudent_l_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddstudent_l.Click
        Try
            frmAddstudent.Show()
            sql = "SELECT * FROM tblstudent"
            autonum(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbostatus_l_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbostatus_l.SelectedIndexChanged
       
    End Sub

    Private Sub btnsearch_l_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch_l.Click
        Try

            sql = "SELECT student_id,s_fname as [Student Name]" _
            & ",s_surname as [Surname],s_midname as " _
            & "[Middle Name],s_year as [Year],s_homeadd" _
            & " as [Address]" _
            & " FROM tblstudent WHERE s_year ='" _
            & cbostatus_l.Text & "'"
            mysqldtg(sql, dtglist_s)
            dtglist_s.Columns(0).Visible = False
       
        Catch ex As Exception

        End Try
    End Sub

   

    Private Sub dtglist_s_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtglist_s.CellContentClick

    End Sub

    Private Sub dtglist_s_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtglist_s.Click
       
    End Sub

    Private Sub Listofstudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT * FROM tblyear "
        cbofill(sql, cbostatus_l)
    End Sub

    Private Sub dtglist_s_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtglist_s.DoubleClick
        Try
            If dtglist_s.CurrentRow.Selected = True Then
                frmAddstudent.Show()
                frmAddstudent.btnsave_s.Text = "Update"
                frmAddstudent.Label16.Text = "Update Student"
                sql = "SELECT student_id,s_fname,s_surname,s_midname,s_year," _
                          & "s_sex,s_datebirthm,s_datebirthd,s_datebirthy,s_placebirth,s_age,s_homeadd" _
                          & ",s_guardian,s_relation,s_gaddress,s_lastschoola,s_elemaddress,s_bcert,s_f137,s_transfer,s_drop,s_sy " _
                          & "FROM tblstudent WHERE student_id = '" _
                          & dtglist_s.CurrentRow.Cells(0).Value & "'"
                editprofile(sql)
                'Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Try

            frmUpdateStudent.lblstudent_id.Text = dtglist_s.CurrentRow.Cells(0).Value
            frmUpdateStudent.Show()
            frmUpdateStudent.Focus()
        Catch ex As Exception

        End Try
    End Sub
End Class