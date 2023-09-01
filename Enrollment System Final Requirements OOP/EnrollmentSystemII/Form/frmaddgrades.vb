Public Class frmaddgrades

    Private Sub btngo_subj_g_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngo_subj_g.Click
        Try
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''selecting buid on fed 11
            If cbosearch_subj_g.Text = "Student ID" Then
                sql = "SELECT s_fname,s_surname,s_year FROM tblstudent WHERE student_id = '" _
             & txtsearch_subj_g.Text & "'"
                assignlbl(sql)
                sql = "SELECT s.subject_id, s.subject_s as [Subject],s.description_s as" _
                     & " [Discription],g.gfirts as [Firts Grading],g.gsecond as" _
                     & " [Second Grading],g.gthird as [Third Grading],g.gfourth as" _
                     & " [Fourth Grading],g.gfinal as [Final Grades],g.gremarks as " _
                     & "[Remarks],g.student_id,g.gsy FROM tblsubjects as s,tblgrade as g," _
                     & " tblstudent as st WHERE g.gyear = s.year_s and s.subject_id = g.subject_id" _
                     & " and st.student_id = g.student_id and g.ggrades = no  and g.gadd = yes and g.gremarks = 'null'" _
                     & " and  st.student_id = '" & txtsearch_subj_g.Text & "'"
                mysqldtg(sql, dtgsubj_g)
                dtgsubj_g.Columns(0).Visible = False
                dtgsubj_g.Columns(9).Visible = False
                dtgsubj_g.Columns(10).Visible = False
                'dtgsubj_g.Columns(11).Visible = False
            End If
            If cbosearch_subj_g.Text = "Student Name" Then
                sql = "SELECT s_fname,s_surname,s_year FROM tblstudent WHERE s_fname = '" _
            & txtsearch_subj_g.Text & "'"
                assignlbl(sql)
                sql = "SELECT s.subject_id, s.subject_s as [Subject],s.description_s as" _
                     & " [Discription],g.gfirts as [Firts Grading],g.gsecond as" _
                     & " [Second Grading],g.gthird as [Third Grading],g.gfourth as" _
                     & " [Fourth Grading],g.gfinal as [Final Grades],g.gremarks as " _
                     & "[Remarks],g.student_id,g.gsy FROM tblsubjects as s,tblgrade as g," _
                     & " tblstudent as st WHERE g.gyear = s.year_s and s.subject_id = g.subject_id" _
                     & " and st.student_id = g.student_id and g.ggrades = no  and g.gadd = yes and g.gremarks = 'null'" _
                     & " and  st.s_fname = '" & txtsearch_subj_g.Text & "'"
                mysqldtg(sql, dtgsubj_g)
                dtgsubj_g.Columns(0).Visible = False
                dtgsubj_g.Columns(9).Visible = False
                dtgsubj_g.Columns(10).Visible = False
                ' dtgsubj_g.Columns(11).Visible = False
            End If

            If cbosearch_subj_g.Text = "Student Last Name" Then
                sql = "SELECT s_fname,s_surname,s_year FROM tblstudent WHERE s_surname = '" _
         & txtsearch_subj_g.Text & "'"
                assignlbl(sql)
                sql = "SELECT s.subject_id, s.subject_s as [Subject],s.description_s as" _
                     & " [Discription],g.gfirts as [Firts Grading],g.gsecond as" _
                     & " [Second Grading],g.gthird as [Third Grading],g.gfourth as" _
                     & " [Fourth Grading],g.gfinal as [Final Grades],g.gremarks as " _
                     & "[Remarks],g.student_id,g.gsy FROM tblsubjects as s,tblgrade as g," _
                     & " tblstudent as st WHERE g.gyear = s.year_s and s.subject_id = g.subject_id" _
                     & " and st.student_id = g.student_id and g.ggrades = no  and g.gadd = yes and g.gremarks = 'null'" _
                     & " and  st.s_surname = '" & txtsearch_subj_g.Text & "'"
                mysqldtg(sql, dtgsubj_g)
                dtgsubj_g.Columns(0).Visible = False
                dtgsubj_g.Columns(9).Visible = False

                dtgsubj_g.Columns(10).Visible = False
                ' dtgsubj_g.Columns(11).Visible = False
            End If
          
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
        '''''''''''''''''''''''finish asd
    End Sub

    Private Sub btncalculate_g_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalculate_g.Click
        Try
            '   dtgautocompute(dtgsubj_g)
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''build on feb 10.......computing dtg
            For Each row As DataGridViewRow In dtgsubj_g.Rows
                row.Cells(7).Value = Val(row.Cells(3).Value) _
          + Val(row.Cells(4).Value) + Val(row.Cells(5).Value) + Val(row.Cells(6).Value)
                row.Cells(7).Value = row.Cells(7).Value / 4
                '''''''''''''''''''''''''''''
                If row.Cells(7).Value > 0 And row.Cells(7).Value < 75 Then
                    row.Cells(8).Value = "Failed"
                ElseIf row.Cells(7).Value > 74 And row.Cells(7).Value < 101 Then
                    row.Cells(8).Value = "Passed"
                ElseIf row.Cells(7).Value = 0 Then
                    row.Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    row.Cells(3).Value = ""
                    row.Cells(4).Value = ""
                    row.Cells(5).Value = ""
                    row.Cells(6).Value = ""
                    row.Cells(7).Value = ""
                    row.Cells(8).Value = ""
                End If
            Next row
            dtgcompute(dtgsubj_g, txttotalave)
            If txttotalave.Text > 74 And txttotalave.Text < 101 Then
                TextBox3.Text = "Passed"
            End If
            If txttotalave.Text < 75 And txttotalave.Text > 0 Then
                TextBox3.Text = "Failed"
            End If
            If txttotalave.Text = 0 Then
                TextBox3.Text = "N/A"
            End If
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
        ''''''''''''''end finish
    End Sub

    Private Sub btnadd_subj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd_subj.Click
        Try '''''''''''''''''''''''''''''''''''''''''build on fed 11 ,,,,,,,,,,,,,,,,, adding grades
            If txttotalave.Text = "" Then
                MsgBox("You dont final average ,you must fill all subject with grades", MsgBoxStyle.Information)
            Else


                For Each row As DataGridViewRow In dtgsubj_g.Rows
                    'MessageBox.Show(CStr(row.Cells(1).FormattedValue))


                    sql = "UPDATE tblgrade  set [gfirts] ='" & CStr(row.Cells(3).FormattedValue) _
                                                          & "',[gsecond] = '" & CStr(row.Cells(4).FormattedValue) & "',[gthird]='" _
                                                          & CStr(row.Cells(5).FormattedValue) & "',[gfourth]='" _
                                                          & CStr(row.Cells(6).FormattedValue) _
                                                          & "',[gfinal]='" & CStr(row.Cells(7).FormattedValue) & "',[gremarks]='" _
                                                          & CStr(row.Cells(8).FormattedValue) & "' WHERE subject_id ='" _
                                                          & CStr(row.Cells(0).FormattedValue) _
                                                          & "' and student_id = '" & row.Cells(9).Value _
                                                          & "' and gsy = '" & row.Cells(10).Value & "'"
                    mysqladdg(sql)
                    '''''''''''''''''''''''''''''''
                    If row.Cells(8).Value = "Passed" Then
                        'MessageBox.Show(CStr(row.Cells(8).FormattedValue))
                        sql = "UPDATE tblgrade  set [ggrades] = yes WHERE student_id = '" _
                                            & row.Cells(9).Value _
                                            & "' and subject_id ='" & CStr(row.Cells(0).FormattedValue) _
                                            & "' and gsy = '" & row.Cells(10).Value & "'"
                        mysql(sql)
                        ''''''''''''''''''''''''''
                        sql = "UPDATE tblgrade  set [gadd] = no WHERE student_id = '" _
                                            & row.Cells(9).Value _
                                            & "' and subject_id ='" & CStr(row.Cells(0).FormattedValue) _
                                            & "' and gsy = '" & row.Cells(10).Value & "'"
                        mysql(sql)
                        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''update
                        sql = "UPDATE tblgrade set [summer] = no WHERE subject_id = '" _
                                               & CStr(row.Cells(0).FormattedValue) _
                                               & "' and student_id ='" _
                                               & row.Cells(9).Value _
                                               & "' and gsy = '" & row.Cells(10).Value & "'"
                        mysql(sql)
                    End If
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''update
                    sql = "UPDATE tblstudent SET [s_enrolled] = no" _
                                                    & " WHERE student_id = '" _
                                                    & row.Cells(9).Value & "'"
                    mysql(sql)
                    sql = "UPDATE tblstudent SET [s_remarks] = '" & TextBox3.Text _
                                                & "' WHERE student_id = '" _
                                                & row.Cells(9).Value & "'"


                    mysql(sql)
                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    sql = "UPDATE tblstudent SET [s_grade] = yes" _
                                                & " WHERE student_id = '" _
                                                & row.Cells(9).Value & "'"
                    mysql(sql)
                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    If row.Cells(8).Value = "Failed" Then
                        sql = "UPDATE tblgrade set [summer] = yes WHERE subject_id = '" _
                                                    & CStr(row.Cells(0).FormattedValue) _
                                                    & "' and student_id ='" _
                                                    & row.Cells(9).Value _
                                                    & "' and gsy = '" & row.Cells(10).Value & "'"
                        mysql(sql)
                    End If

                Next row
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''insert
                'sql = "INSERT INTO tbltotalave (year_t,student_id,totalave,remarks)" _
                '                    & " VALUES ('" & lblyear_s_sub.Text _
                '                    & "','" & dtgsubj_g.CurrentRow.Cells(9).Value & "','" _
                '                    & txttotalave.Text & "','" & TextBox3.Text & "')"
                'mysql(sql)
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''update failed or passed
                sql = "UPDATE tbltotalave SET totalave = '" _
                            & txttotalave.Text & "' , remarks = '" _
                            & TextBox3.Text & "' WHERE student_id ='" _
                            & dtgsubj_g.CurrentRow.Cells(9).Value & "' and year_t ='" _
                            & lblyear_s_sub.Text & "'"

                mysql(sql)
                MsgBox("Saved Grades")
            End If
        Catch ex As Exception
            MsgBox("There is no list of subject", MsgBoxStyle.Information)
        End Try
        ''''''''''''''''''''''''''''''finish
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub txtsearch_subj_g_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch_subj_g.TextChanged
        If txtsearch_subj_g.Text = "" Then
            dtgsubj_g.Columns.Clear()
            lblname_s_sub.Text = ""
            lblyear_s_sub.Text = ""
        End If


        If cbosearch_subj_g.Text = "Student ID" Then
            If IsNumeric(txtsearch_subj_g.Text) = False Then
                txtsearch_subj_g.Text = ""
            End If
        End If
        If cbosearch_subj_g.Text = "Student Name" Or cbosearch_subj_g.Text = "Student Last Name" Then
            If IsNumeric(txtsearch_subj_g.Text) = True Then
                txtsearch_subj_g.Text = ""
            End If
        End If
    End Sub

    Private Sub dtgsubj_g_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dtgsubj_g.CellBeginEdit
       
    End Sub

    Private Sub dtgsubj_g_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgsubj_g.CellContentClick

    End Sub

    Private Sub dtgsubj_g_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgsubj_g.CellEndEdit
        Try
            For Each row As DataGridViewRow In dtgsubj_g.Rows
                If CStr(row.Cells(3).FormattedValue) < 70 Then
                    row.Cells(3).Value = 70
                ElseIf CStr(row.Cells(3).FormattedValue) > 100 Then
                    row.Cells(3).Value = 100
                End If
                If CStr(row.Cells(4).FormattedValue) < 70 Then
                    row.Cells(4).Value = 70
                ElseIf CStr(row.Cells(4).FormattedValue) > 100 Then
                    row.Cells(4).Value = 100
                End If
                If CStr(row.Cells(5).FormattedValue) < 70 Then
                    row.Cells(5).Value = 70
                ElseIf CStr(row.Cells(5).FormattedValue) > 100 Then
                    row.Cells(5).Value = 100

                End If
                If CStr(row.Cells(6).FormattedValue) < 70 Then
                    row.Cells(6).Value = 70
                ElseIf CStr(row.Cells(6).FormattedValue) > 100 Then
                    row.Cells(6).Value = 100

                End If
            Next row

        Catch ex As Exception
            'MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub dtgsubj_g_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgsubj_g.CellValueChanged
     

    End Sub
End Class