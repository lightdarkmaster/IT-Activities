Public Class frmUpdateStudent
    Private Sub btnsave_s_Click(sender As Object, e As EventArgs) Handles btnsave_s.Click
        sql = "UPDATE tblstudent SET" _
          & "[s_fname]= '" & txtfname.Text & "' , [s_surname] ='" & txtlname.Text & "'" _
          & ",[s_midname]='" & txtmname.Text & "' ,[s_year]='" & cbostatus.Text & "'" _
          & ",[s_sex]='" & cbosex.Text & "' ,[s_datebirthm]='" & cbomonth.Text & "'" _
          & ",[s_datebirthd]='" & txtday.Text & "' ,[s_datebirthy]='" & txtyear.Text & "'" _
           & ",[s_placebirth]='" & txtbplace.Text & "' ,[s_age]='" & txtage.Text & "'" _
           & ",[s_homeadd]='" & txtaddress.Text & "' ,[s_guardian]='" & txtguardian.Text & "'" _
           & ",[s_relation]='" & txtrelation.Text & "',[s_gaddress]='" & txtgaddress.Text & "'" _
            & ",[s_lastschoola]='" & txtnsla.Text & "' ,[s_elemaddress]='" & txtnslaaddress.Text & "'" _
            & " ,[s_bcert]= '" & chkbc.CheckState & "',[s_f137]='" & chkf137.CheckState & "'" _
            & ",[s_transfer] ='" & chktransfer_s.CheckState & "',[s_drop] = '" & chkdrop.CheckState & "'" _
            & ",[s_sy] ='" & cbos_sy.Text & "'" _
            & " WHERE student_id = '" & lblstudent_id.Text & "'"
        mysql(sql)
        MsgBox("Successfully changed")
    End Sub

    Private Sub lblstudent_id_Click(sender As Object, e As EventArgs) Handles lblstudent_id.Click
        sql = "SELECT * FROM tblstudent WHERE student_id=" & lblstudent_id.Text
        editprofile(sql)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class