Public Class Change_Status

    Private Sub Change_Status_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        Try
            lblname_cstatus.Text = ""
            lblyearcstatus.Text = ""
            sql = "SELECT * FROM tblsy"
            cbofill(sql, cbosy_cs)
            sql = "SELECT * FROM tblreplica_gradesubj"
            autoreplica(sql, txtsg_idcs)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub txtstudentid_cstatus_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstudentid_cstatus.TextChanged
        Try
          
            If txtstudentid_cstatus.Text = "" Then
                txtstudentid_cstatus.Clear()
                lblname_cstatus.Text = ""
                lblyearcstatus.Text = ""
                dtgold_cstatus.Columns.Clear()
                TXTREMARKS_CS.Text = "N/A"
                txttotalave.Clear()
                chkconfirm.Checked = False
                If IsInputChar(txtstudentid_cstatus.Text) Then
                    txtstudentid_cstatus.Clear()
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TXTREMARKS_CS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTREMARKS_CS.TextChanged
        If TXTREMARKS_CS.Text = "Passed" Then
            chkconfirm.Enabled = True
        Else
            chkconfirm.Enabled = False
        End If
    End Sub

    Private Sub chkconfirm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkconfirm.CheckedChanged
        Try

            If chkconfirm.Checked = True Then
                cboyear_cstatus.Enabled = True
                cboyear_cstatus.Enabled = True
                cbosy_cs.Enabled = True
                Button1.Enabled = True
                Label6.Enabled = True
                Label9.Enabled = True
                dtgnew_cstatus.Enabled = True
                btnadd_cstatus.Enabled = True
                If lblyearcstatus.Text = "Grade 7" Then

                    cboyear_cstatus.Text = "Grade 7"
                    cboyear_cstatus.Items.Add("2nd Year")
                ElseIf lblyearcstatus.Text = "2nd Year" Then
                    cboyear_cstatus.Text = "2nd Year"
                    cboyear_cstatus.Items.Add("3rd Year")
                ElseIf lblyearcstatus.Text = "3rd Year" Then
                    cboyear_cstatus.Text = "3rd Year"
                    cboyear_cstatus.Items.Add("4th Year")
                ElseIf lblyearcstatus.Text = "4th Year" Then
                    cboyear_cstatus.Text = "4th Year"
                    cboyear_cstatus.Items.Add("5th Year")
                End If
            End If
            If chkconfirm.Checked = False Then
                cboyear_cstatus.Enabled = False
                cbosy_cs.Enabled = False
                Button1.Enabled = False
                dtgnew_cstatus.Enabled = False
                btnadd_cstatus.Enabled = False
                cboyear_cstatus.Items.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnserch_cs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnserch_cs.Click
        Search.Show()
        Search.btnsearch_add.Visible = True
    End Sub

    Private Sub btnadd_cstatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd_cstatus.Click
        Try
            sql = "SELECT * FROM tblreplica_gradesubj"
            autonumcheck(sql) '''''''''''''''''''''checking


            If dtgnew_cstatus.RowCount <= 0 Then
                MsgBox("There is no list of subject", MsgBoxStyle.Information)
            Else
                Dim check As Integer = txtsgidcs_check.Text
                If check >= txtsg_idcs.Text Then

                    MsgBox("Transaction has already existed", MsgBoxStyle.Information)
                    sql = "SELECT * FROM tblreplica_gradesubj"
                    autonum(sql)
                    sql = "UPDATE tblstudent set [s_year] = '" & lblyearupdate.Text _
                                 & "',[s_sy] = '" & cbosy_cs.Text & "' where student_id = '" & txtstudentid_cstatus.Text & "'"
                    mysql(sql)
                    txtstudentid_cstatus.Text = 0.0
                    lblname_cstatus.Text = ""
                    lblyearcstatus.Text = ""
                    dtgold_cstatus.Columns.Clear()
                    dtgnew_cstatus.Columns.Clear()
                    TXTREMARKS_CS.Text = "N/A"

                Else
                    sql = "INSERT INTO tblreplica_gradesubj (gs_id) " & _
                                                   "VALUES ('" & txtsg_idcs.Text & "')"  'Insert replica
                    mysql(sql)
                    '''''''''''''''''''''''''''''''''''''''''''''''''''
                    For Each row As DataGridViewRow In dtgnew_cstatus.Rows
                        'MsgBox(Str(row.Cells(1).FormattedValue))
                        sql = "INSERT INTO tblgrade (subject_id,student_id,gyear,gsy,gadd,gremarks,gtime) VALUES ('" _
                                & CStr(row.Cells(1).FormattedValue) & "','" & txtstudentid_cstatus.Text & "','" _
                                & lblyearcstatus.Text & "','" _
                               & cbosy_cs.Text & "', yes,'null','" & CStr(row.Cells(6).FormattedValue) & "')"
                        mysql(sql)
                        '''''''''''''''''''''''''''''''''''''''''''''''''''update
                        sql = "UPDATE tblstudent SET [s_grade] = no " _
                        & " WHERE student_id = '" & txtstudentid_cstatus.Text & "'"
                        mysql(sql)
                        '''''''''''''''''''''''''''''''''''''''''''''''''''update
                        sql = "UPDATE tblstudent SET [s_enrolled] = yes " _
                        & " WHERE student_id = '" & txtstudentid_cstatus.Text & "'"
                        mysql(sql)

                    Next row
                    For Each row As DataGridViewRow In dtgold_cstatus.Rows
                        If row.Cells(4).Value = "Failed" Then
                            'MsgBox(row.Cells(1).Value)
                            sql = "INSERT INTO tblgrade (subject_id,student_id,gyear,gsy,gadd,gremarks) VALUES ('" _
                                                     & CStr(row.Cells(0).FormattedValue) & "','" _
                                                     & txtstudentid_cstatus.Text & "','" _
                                                     & CStr(row.Cells(6).FormattedValue) & "','" _
                                                     & cbosy_cs.Text & "', yes ,'null' )"
                            mysql(sql)
                        End If
                    Next row
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''insert tbltotalave
                    sql = "INSERT INTO tbltotalave (year_t,student_id)" _
                                        & " VALUES ('" & cboyear_cstatus.Text _
                                        & "','" & txtstudentid_cstatus.Text & "')"
                    mysql(sql)
                    MsgBox("All Subject Saved")
                    sql = "SELECT * FROM tblreplica_gradesubj"
                    autoreplica(sql, txtsg_idcs)
                    txttotalave.Text = ""
                    lblname_cstatus.Text = ""
                    lblyearcstatus.Text = ""
                    dtgold_cstatus.Columns.Clear()
                    dtgnew_cstatus.Columns.Clear()
                    txtstudentid_cstatus.Clear()
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            sql = "SELECT * FROM tblreplica_gradesubj"
            autoreplica(sql, txtsg_idcs)
            sql = "SELECT * FROM tblreplica_gradesubj"
            autonumcheck(sql)
            Dim check As Integer = txtsgidcs_check.Text



            If txtstudentid_cstatus.Text = "" Then
                dtgnew_cstatus.Columns.Clear()
                lblname_cstatus.Text = ""
                lblyearcstatus.Text = ""
            ElseIf check >= txtsg_idcs.Text Then
                MsgBox("Transaction has already existed", MsgBoxStyle.Information)
                sql = "SELECT * FROM tblreplica_gradesubj"
                autonum(sql)
                lblname_cstatus.Text = ""
                lblyearcstatus.Text = ""
                dtgold_cstatus.Columns.Clear()
                txtstudentid_cstatus.Clear()
            Else
                '''''''''''''''''''''''''''''''''''''

                sql = "UPDATE tblstudent set [s_year] = '" & cboyear_cstatus.Text & "'" _
                & ",[s_sy] = '" & cbosy_cs.Text & "' where student_id = '" & txtstudentid_cstatus.Text & "'"
                mysql(sql)

                sql = "SELECT s_fname,s_surname,s_year FROM tblstudent WHERE student_id ='" _
                & txtstudentid_cstatus.Text & "'"
                assignlbl(sql)

                '''''''''''''
                sql = "SELECT student_id,subj.subject_id,subj.subject_s  " _
                & ",subj.description_s ,subj.unit_s  " _
                & ",subj.sy_s,subj_time as [Time] FROM tblsubjects as subj,tblstudent as s" _
                & " WHERE s.s_year = subj.year_s and s.student_id LIKE '" & txtstudentid_cstatus.Text & "%'" _
                & " and s.s_enrolled = no and subj.year_s LIKE '" & cboyear_cstatus.Text & "%'"
                mysqldtg(sql, dtgnew_cstatus)
                dtgnew_cstatus.Columns(0).Visible = False
                dtgnew_cstatus.Columns(4).Visible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub btnsearch_id_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch_id.Click
        Try
            If txtstudentid_cstatus.Text = "" Then


            Else
                sql = "SELECT s_fname ,s_surname,s_year,s_sy From" _
                & " tblstudent Where student_id = '" _
                & txtstudentid_cstatus.Text & "'"
                assignlbl(sql)
                sql = "SELECT s.subject_id, s.subject_s as [Subject],s.description_s as" _
                & " [Discription],g.gfinal as [Final Grades]" _
                & ",g.gremarks as [Remarks] ,sy_s,g.gyear FROM tblsubjects as s,tblgrade as g," _
                & " tblstudent as st Where s.subject_id = g.subject_id" _
                & " and g.gyear = s.year_s and st.s_year = g.gyear and" _
                & " st.student_id = g.student_id and " _
                & " g.student_id = '" & txtstudentid_cstatus.Text & "'"
                mysqldtg(sql, dtgold_cstatus)
                lblyearupdate.Text = dtgold_cstatus.CurrentRow.Cells(6).Value

                dtgold_cstatus.Columns(0).Visible = False
                dtgold_cstatus.Columns(5).Visible = False
                dtgold_cstatus.Columns(6).Visible = False

                '''''''''''''textbox
                'sql = "SELECT totalave FROM tbltotalave WHERE student_id = '" _
                '& txtstudentid_cstatus.Text & "' and year_t ='" _
                '& lblyearcstatus.Text & "'"
                'assigntxt(sql, txttotalave)


                Dim tot As Double = 0
                For Each row As DataGridViewRow In dtgold_cstatus.Rows
                    tot += CStr(row.Cells(3).Value) / dtgold_cstatus.RowCount

                Next row
                txttotalave.Text = FormatNumber(tot, 1)

                
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txttotalave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttotalave.TextChanged
        If txttotalave.Text < 75 Then
            TXTREMARKS_CS.Text = "Failed"
            TXTREMARKS_CS.ForeColor = Color.Red
        Else
            If txttotalave.Text >= 75 Then
                TXTREMARKS_CS.Text = "Passed"
                TXTREMARKS_CS.ForeColor = Color.Blue
            End If
        End If

      
    End Sub

  
    Private Sub dtgold_cstatus_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgold_cstatus.CellContentClick

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
End Class