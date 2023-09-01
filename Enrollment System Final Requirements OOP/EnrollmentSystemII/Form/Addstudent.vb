Public Class frmAddstudent

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit_s.Click
        Me.Close()
    End Sub

    Private Sub txtmname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmname.TextChanged
        If IsNumeric(txtmname.Text) Then
            MsgBox("Middle name contain a numeric value!", vbExclamation, "Unable to Add!")
            txtmname.Clear()
        End If
    End Sub

    Private Sub btnsave_s_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave_s.Click
        sql = "SELECT student_id FROM tblstudent "
        autonumcheck(sql)
        Dim check As Integer = txtstudentid_check.Text
        Try
            If txtfname.Text = "" Or txtaddress.Text = "" Or txtage.Text = "" Or txtday.Text = "" Or txtyear.Text = "" Or txtbplace.Text = "" Or txtguardian.Text = "" Or txtnsla.Text = "" Or txtfname.Text = "" Or txtbplace.Text = "" Or txtguardian.Text = "" Or txtnsla.Text = "" Then
                MsgBox("One of the field(s) is empty!", vbExclamation, "Unable to Add!")
                'ElseIf check >= lblstudent_id.Text Then
                '    'MsgBox(lblstudent_id.Text & " has already existed", MsgBoxStyle.Information)
                '    clearing()
                '    sql = "SELECT * FROM tblstudent"
                '    autonum(sql)
            ElseIf btnsave_s.Text = "Update" Then

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
                btnsave_s.Text = "Save"
                sql = "SELECT * FROM tblstudent"
                autonum(sql)
                sql = "SELECT * FROM tblreplica_gradesubj"
                autonum(sql)
                clearing()
                Label16.Text = "Add Student"
            ElseIf btnsave_s.Text = "Save" Then

                sql = "INSERT INTO tblstudent (student_id,s_fname,s_surname,s_midname,s_year," _
                  & "s_sex,s_datebirthm,s_datebirthd,s_datebirthy,s_placebirth,s_age,s_homeadd" _
                  & ",s_guardian,s_relation,s_gaddress,s_lastschoola,s_elemaddress,s_bcert,s_f137,s_transfer,s_remarks,s_drop,s_sy)" _
                 & " VALUES ('" & lblstudent_id.Text & "','" & txtfname.Text _
                & "','" & txtlname.Text & "','" & txtmname.Text & "','" & cbostatus.Text _
                & "','" & cbosex.Text & "','" & cbomonth.Text & "','" & txtday.Text _
                & "','" & txtyear.Text & "','" & txtbplace.Text & "','" & txtage.Text _
               & "','" & txtaddress.Text & "','" & txtguardian.Text _
               & "','" & txtrelation.Text & "','" & txtgaddress.Text _
               & "','" & txtnsla.Text & "','" & txtnslaaddress.Text _
               & "','" & chkbc.CheckState & "','" & chkf137.CheckState _
               & "','" & chktransfer_s.CheckState & "','null','" _
               & chkdrop.CheckState & "','" & cbos_sy.Text & "')"
                mysql(sql)
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''selecting subject
                sql = "INSERT INTO tblreplica_gradesubj (gs_id) " & _
                                                "VALUES ('" & txtgs_id.Text & "')"  'Insert replica
                mysql(sql)

                sql = "SELECT s.student_id, subj.subject_id, subj.subject_s, subj.description_s, subj.unit_s, subj.sy_s, subj_time AS [Time]" _
                                                                                & " FROM tblsubjects AS subj, tblstudent AS s " _
                                                                                & "WHERE s.s_year = subj.year_s  and  s.student_id = '" _
                                                                                & lblstudent_id.Text & "'" _
                                                                                & "and s.s_enrolled = no and s.s_remarks = 'null'"
                mysqldtg(sql, dtgsubj)
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''add subject
                For Each row As DataGridViewRow In dtgsubj.Rows
                    'MessageBox.Show(CStr(row.Cells(2).FormattedValue) & CStr(row.Cells(3).FormattedValue))
                    sql = "INSERT INTO tblgrade (subject_id,student_id,gyear,gsy,gadd,gremarks,gtime) VALUES ('" _
                            & CStr(row.Cells(1).FormattedValue) & "','" & CStr(row.Cells(0).FormattedValue) & "','" _
                            & cbostatus.Text & "','" _
                           & CStr(row.Cells(5).FormattedValue) & "', yes, 'null','" _
                           & CStr(row.Cells(6).FormattedValue) & "')"
                    mysql(sql)

                    '''''''''''''''''''''''''''''''''''''''''''''''''''update
                    sql = "UPDATE tblstudent SET [s_enrolled] = yes" _
                    & " WHERE student_id = '" & CStr(row.Cells(0).FormattedValue) & "'"
                    mysql(sql)
                Next row
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''insert
                sql = "INSERT INTO tbltotalave (year_t,student_id)" _
                                    & " VALUES ('" & cbostatus.Text _
                                    & "','" & lblstudent_id.Text & "')"
                mysql(sql)
                MsgBox(txtlname.Text & " save")
                sql = "SELECT * FROM tblstudent"
                autonum(sql)
                

                clearing()
                Call frmAddstudent_Load(sender, e)
            End If
           
            Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub btnsearch_s_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch_s.Click
        Search.Show()
        ' Me.Close()
    End Sub

    Private Sub btncancel_s_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel_s.Click
        clearing()
        btnsave_s.Text = "Save"
        sql = "SELECT * FROM tblstudent"
        autonum(sql)
    End Sub

    Private Sub ListOfStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Listofstudent.Show()
    End Sub

    Private Sub ListOfSubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Listofsubject.Show()
    End Sub

    Private Sub StudentGradesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmlistgrades.Show()
    End Sub

    Private Sub txtlname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlname.TextChanged
        If IsNumeric(txtlname.Text) Then
            MsgBox("Last name contain a numeric value!", vbExclamation, "Unable to Add!")
            txtlname.Clear()
        End If
    End Sub

    Private Sub txtfname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfname.TextChanged
        If IsNumeric(txtfname.Text) Then
            MsgBox("First name contain a numeric value!", vbExclamation, "Unable to Add!")
            txtfname.Clear()
        End If
    End Sub

    Private Sub txtaddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtaddress.TextChanged
        'If IsNumeric(txtaddress.Text) Then
        '    MsgBox("The numeric is not valid", MsgBoxStyle.Critical)

        'End If
    End Sub

    Private Sub txtday_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtday.TextChanged
        If txtday.Text = "" Then
            txtday.Clear()
        ElseIf Not IsNumeric(txtday.Text) Then
            MsgBox("Day contain a non numeric value!", vbExclamation, "Unable to Add!")
            txtday.Clear()
        End If
    End Sub

    Private Sub txtyear_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtyear.TextChanged
        If txtyear.Text = "" Then
            txtyear.Clear()
        ElseIf IsNumeric(txtyear.Text) = False Then
            MsgBox("Year contain a non numeric value!", vbExclamation, "Unable to Add!")
            txtyear.Clear()

        End If
    End Sub

    Private Sub txtage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtage.TextChanged
        If txtage.Text = "" Then
            txtage.Clear()
        ElseIf IsNumeric(txtage.Text) = False Then
            MsgBox("Age contain a non numeric value!", vbExclamation, "Unable to Add!")
            txtage.Clear()
        End If
    End Sub

   
    Private Sub frmAddstudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT * FROM tblreplica_gradesubj"
        autoreplica(sql, txtgs_id)
    End Sub
 

    Private Sub cbostatus_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbostatus.TextChanged
        cbostatus.Text = ""
    End Sub
 

    Private Sub cbos_sy_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbos_sy.TextChanged
        cbos_sy.Text = ""
    End Sub
 

    Private Sub cbomonth_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbomonth.TextChanged
        cbomonth.Text = ""
    End Sub
 

    Private Sub cbosex_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbosex.TextChanged
        cbosex.Text = ""
    End Sub

    Private Sub lblstudent_id_Click(sender As Object, e As EventArgs) Handles lblstudent_id.Click

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub cbostatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbostatus.SelectedIndexChanged

    End Sub

    Private Sub cbos_sy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbos_sy.SelectedIndexChanged

    End Sub

    Private Sub chkbc_CheckedChanged(sender As Object, e As EventArgs) Handles chkbc.CheckedChanged

    End Sub
End Class