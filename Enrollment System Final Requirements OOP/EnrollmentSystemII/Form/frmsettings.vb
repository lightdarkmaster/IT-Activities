Public Class frmsettings

    Private Sub btnaddgrades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddgrades.Click
        pnladdsubj.Show()
        pnladdsubj.Dock = DockStyle.Fill
        pnlsy.Dock = DockStyle.None
        pnlsy.Hide()
        subj_clearing()
        sql = "SELECT * FROM tblsubjects"
        autonum(sql)
        sql = "SELECT * FROM tblsy"
        cbofill(sql, cbosubjsy_as)
        sql = "SELECT * FROM tblyear"
        cbofill(sql, cbosubjyear_as)
    End Sub

    Private Sub btnpayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpayment.Click
        pnlsy.Show()
        pnlsy.Dock = DockStyle.Fill
        pnladdsubj.Dock = DockStyle.None
        pnladdsubj.Hide()
        sql = "SELECT * FROM tblyear"
        autoreplica(sql, lblyearrid)
        sql = "SELECT * FROM tblsy"
        autoreplica(sql, lblsyid)
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnsubjadd_as_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub btnsysave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub btnsubjadd_as_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubjadd_as.Click
        Try
            sql = "SELECT * FROM tblsubjects"
            autonumcheck(sql)
            '''''''''''''''''''''' 
            


            If txtsubjname_as.Text = "" Or txtdesc_as.Text = "" Or cbosubjyear_as.Text = "" _
             Or cbosubjunit_as.Text = "" Or cbosubjsy_as.Text = "" Or txttime_subj.Text = "" Then
                MsgBox("One of the textbox is not filled up", MsgBoxStyle.Information)
            Else
                Dim check As Integer = lblsubjectid_as.Text
                If check >= Txtsubjectid_as.Text Then
                    MsgBox("The " & Txtsubjectid_as.Text & " subject id has already existed", MsgBoxStyle.Information)
                    sql = "SELECT * FROM tblsubjects"
                    autonum(sql)
                    subj_clearing()
                Else
                    If txtsubjname_ascheck.Text = txtsubjname_as.Text Then
                        MsgBox(txtsubjname_as.Text & " has already existed", MsgBoxStyle.Information)
                        subj_clearing()
                        sql = "SELECT * FROM tblsubjects"
                        autonum(sql)
                        'sql = "SELECT * FROM tblyear"
                        'cbofill(sql, cbosubjyear_as)
                        sql = "SELECT * FROM tblsy"
                        cbofill(sql, cbosubjsy_as)
                        txtsubj_id_search.Clear()
                    Else
                        If btnsubjadd_as.Text = "Add" Then

                            sql = "INSERT INTO tblsubjects (subject_id,subject_s,description_s,unit_s,year_s,sy_s,subj_time)" _
                                                    & " VALUES ('" & Txtsubjectid_as.Text & "','" & txtsubjname_as.Text & "','" _
                                                    & txtdesc_as.Text & "','" & cbosubjunit_as.Text & "','" & cbosubjyear_as.Text & "','" _
                                                    & cbosubjsy_as.Text & "','" & txttime_subj.Text & "')"
                            mysql(sql)
                            MsgBox("Saved")
                            sql = "SELECT * FROM tblsubjects"
                            autonum(sql)
                            'sql = "SELECT * FROM tblyear"
                            'cbofill(sql, cbosubjyear_as)
                            sql = "SELECT * FROM tblsy"
                            cbofill(sql, cbosubjsy_as)
                            subj_clearing()
                            txtsubj_id_search.Clear()

                        Else
                            If btnsubjadd_as.Text = "Edit" Then
                                sql = "UPDATE tblsubjects set [subject_s] ='" & txtsubjname_as.Text & "',[description_s] ='" _
                                & txtdesc_as.Text & "',[unit_s] ='" & cbosubjunit_as.Text & "',[year_s] ='" _
                                & cbosubjyear_as.Text & "',[sy_s] ='" & cbosubjsy_as.Text & "',[subj_time] ='" _
                                & txttime_subj.Text & "' WHERE subject_id ='" & Txtsubjectid_as.Text & "'"
                                mysql(sql)
                                MsgBox("Successfully Change")
                                subj_clearing()
                                txtsubj_id_search.Clear()
                                sql = "SELECT * FROM tblsubjects"
                                autonum(sql)
                            End If
                        End If
                    End If
            End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtsubj_id_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsubj_id_search.TextChanged
        Try
            If IsNumeric(txtsubj_id_search.Text) = False Then
                txtsubj_id_search.Clear()
            End If
            If txtsubj_id_search.Text = "" Then
                btnsubjadd_as.Text = "Add"
                subj_clearing()
                sql = "SELECT * FROM tblsubjects"
                autonum(sql)
            Else
                sql = "SELECT subject_id,subject_s,description_s,unit_s,year_s,sy_s,subj_time " _
                & "From tblsubjects Where subject_id = '" & txtsubj_id_search.Text & "'"
                editsubj(sql)
            End If
            If txtsubj_id_search.Text = Txtsubjectid_as.Text Then
                btnsubjadd_as.Text = "Edit"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Txtsubjectid_as_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtsubjectid_as.TextChanged
       
    End Sub

    Private Sub btnsysave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsysave.Click
        Try '''''''''''''''''''''''''''''''''''''''''''''''build n feb 25
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''checking

            sql = "SELECT * FROM tblsy"
            autoreplica_check(sql, lblsyid_check)
            ''
            If txtaddsy.Text = "" Then
                MsgBox("The sy's not filled up", MsgBoxStyle.Information)
            Else
                Dim check As Integer = lblsyid_check.Text
                If check >= lblsyid.Text Then
                    MsgBox(txtaddsy.Text & " has already existed", MsgBoxStyle.Information)
                    sql = "SELECT * FROM tblsy"
                    autoreplica(sql, lblsyid)
                    txtaddsy.Clear()
                End If

                If txtsy.Text = "" Then
                    sql = "INSERT INTO tblsy (sy,idsy)" _
                                    & " VALUES ('" & txtaddsy.Text & "','" _
                                    & lblsyid.Text & "')"
                    mysql(sql)
                    MsgBox(txtaddsy.Text & " save")
                    sql = "SELECT * FROM tblsy"
                    autoreplica(sql, lblsyid)
                    txtaddsy.Clear()




                Else
                    MsgBox(txtaddsy.Text & " has already existed", MsgBoxStyle.Information)
                    txtaddsy.Clear()
                End If

            End If

        Catch ex As Exception

        End Try
        ''''''''''''''''''''''''''''''finish
    End Sub

  

    Private Sub txtyear_RegionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtyear.RegionChanged
        txtear.Clear()
    End Sub

  

    Private Sub txtyear_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtyear.TextChanged
        Try
            If txtyear.Text = "" Then
                txtear.Clear()
            Else
                sql = "SELECT nameyear FROM tblyear WHERE nameyear = '" & txtyear.Text & "'"
                assigntxt(sql, txtear)
            End If


        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtaddsy_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtaddsy.TextChanged
        Try
            If txtaddsy.Text = "" Then
                txtsy.Clear()
            Else
                sql = "SELECT * FROM tblsy WHERE sy = '" & txtaddsy.Text & "'"
                assigntxt(sql, txtsy)
            End If

            
        Catch ex As Exception

        End Try
    End Sub

    Private Sub pnlsy_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlsy.Paint

    End Sub
 
    Private Sub btnaddyear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddyear.Click
        Try '''''''''''''''''''''''''''''''''''''''''''''''build n feb 25
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''checking
            sql = "SELECT * FROM tblyear"
            autoreplica_check(sql, lblyearid_check)
            ''
            If txtyear.Text = "" Then
                MsgBox("The Year's not filled up", MsgBoxStyle.Information)
            Else
                Dim check As Integer = lblyearid_check.Text
                If check >= lblyearrid.Text Then
                    MsgBox(txtyear.Text & " has already existed", MsgBoxStyle.Information)
                    sql = "SELECT * FROM tblyear"
                    autoreplica(sql, lblyearrid)
                    txtyear.Clear()
                Else
                    If txtear.Text = "" Then

                        sql = "INSERT INTO tblyear (nameyear,year_id) " _
                                                  & " VALUES ('" & txtyear.Text & "','" & lblyearrid.Text & "')"
                        mysql(sql)
                        ''
                        MsgBox(txtyear.Text & " save")
                        sql = "SELECT * FROM tblyear"
                        autoreplica(sql, lblyearrid)
                        txtyear.Clear()
                    Else
                        MsgBox(txtyear.Text & " has already existed", MsgBoxStyle.Information)
                        txtyear.Clear()
                    End If

                End If
            End If
        Catch ex As Exception

        End Try
        '''''''finish
    End Sub

     
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub cbosubjsy_as_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosubjsy_as.SelectedIndexChanged

    End Sub

    Private Sub cbosubjsy_as_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbosubjsy_as.TextChanged
        cbosubjsy_as.Text = ""
    End Sub

    Private Sub cbosubjyear_as_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosubjyear_as.SelectedIndexChanged

    End Sub

    Private Sub cbosubjyear_as_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbosubjyear_as.TextChanged
        cbosubjyear_as.Text = ""
    End Sub

    Private Sub cbosubjunit_as_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosubjunit_as.SelectedIndexChanged
        cbosubjunit_as.Text = ""
    End Sub

    Private Sub txtsubjname_as_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsubjname_as.TextChanged
        Try
            txtsubjname_as.Text.ToUpper()
            If txtsubjname_as.Text = "" Then
                txtsubjname_ascheck.Clear()

            End If
            sql = "SELECT subject_s FROM tblsubjects WHERE subject_s ='" & txtsubjname_as.Text & "'"
            assigntxt(sql, txtsubjname_ascheck)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtsubjname_ascheck_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsubjname_ascheck.TextChanged
        Try
            txtsubjname_as.Text = txtsubjname_ascheck.Text
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtear_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtear.TextChanged
        Try
            txtyear.Text = txtear.Text
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtsy_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsy.TextChanged
        Try
            txtdesc_as.Text = txtsy.Text
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub pnladdsubj_Paint(sender As Object, e As PaintEventArgs) Handles pnladdsubj.Paint

    End Sub
End Class