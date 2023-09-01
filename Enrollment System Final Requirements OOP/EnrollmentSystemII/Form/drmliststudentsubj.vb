Public Class drmliststudentsubj

    Private Sub txtsearch_subjs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch_subjs.TextChanged
        If txtsearch_subjs.Text = "" Then
            dtglist__subjs.Columns.Clear()
            lblname_s_subs.Text = ""
            lblyear_s_subs.Text = ""

        End If
        If cbosearch_subjs.Text = "Student ID" Then
            If IsNumeric(txtsearch_subjs.Text) = False Then
                txtsearch_subjs.Text = ""
            End If
        End If
        If cbosearch_subjs.Text = "Student Name" Or cbosearch_subjs.Text = "Student Last Name" Then
            If IsNumeric(txtsearch_subjs.Text) = True Then
                txtsearch_subjs.Text = ""
            End If
        End If
    End Sub

    Private Sub btnsearch_gl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch_gl.Click
        Try ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''selecting ,,,,,build on feb 11
            If cbosearch_subjs.Text = "Student ID" And txtsearch_subjs.Text = "" Then
                sql = "SELECT student_id,subj.subject_id,subj.subject_s  " _
               & ",subj.description_s ,subj.unit_s  " _
               & ",subj_time as [Time],subj.sy_s FROM tblsubjects as subj,tblstudent as s" _
               & " WHERE s.s_year = subj.year_s" _
               & " and  s.s_enrolled = yes and not s.s_grade = yes"
                mysqldtg(sql, dtglist__subjs)
                dtglist__subjs.Columns(0).Visible = False
                dtglist__subjs.Columns(1).Visible = False
                dtglist__subjs.Columns(6).Visible = False
            Else
                sql = "SELECT s_fname,s_surname,s_year FROM tblstudent WHERE student_id = '" _
                 & txtsearch_subjs.Text & "'"
                assignlbl(sql)


                ''''''''''''
                ''''''''''''
                sql = "SELECT g.student_id,subj.subject_id,subj.subject_s as [Subject]" _
                                                                & ",subj.description_s as [Description],subj.unit_s as [Unit] " _
                                                                & ",g.gtime as [Time],g.gsy FROM tblsubjects as subj ,tblgrade as g,tblstudent as s " _
                                                                & " WHERE g.gyear = subj.year_s And subj.subject_id = g.subject_id " _
                                                                & " and s.student_id = '" & txtsearch_subjs.Text & "'" _
                                                                & "   and g.ggrades = no " _
                                                                & " and g.gadd = yes and s.student_id = g.student_id and g.gremarks = 'null' "

                mysqldtg(sql, dtglist__subjs)
                dtglist__subjs.Columns(0).Visible = False
                dtglist__subjs.Columns(1).Visible = False
                dtglist__subjs.Columns(6).Visible = False
            End If
            If cbosearch_subjs.Text = "Student Name" Then
                sql = "SELECT s_fname,s_surname,s_year FROM tblstudent WHERE s_fname = '" _
                 & txtsearch_subjs.Text & "'"
                assignlbl(sql)

                ''''''''''''
                sql = "SELECT g.student_id,subj.subject_id,subj.subject_s as [Subject]" _
                                                                & ",subj.description_s as [Description],subj.unit_s as [Unit] " _
                                                                & ",g.gtime as [Time],g.gsy FROM tblsubjects as subj ,tblgrade as g,tblstudent as s " _
                                                                & " WHERE g.gyear = subj.year_s And subj.subject_id = g.subject_id " _
                                                                & " and s.s_fname = '" & txtsearch_subjs.Text & "'" _
                                                                & " and g.ggrades = no " _
                                                                & " and g.gadd = yes and s.student_id = g.student_id and g.gremarks = 'null' "


                mysqldtg(sql, dtglist__subjs)
                dtglist__subjs.Columns(0).Visible = False
                dtglist__subjs.Columns(1).Visible = False
                dtglist__subjs.Columns(6).Visible = False
            End If


            If cbosearch_subjs.Text = "Student Last Name" Then
                sql = "SELECT s_fname,s_surname,s_year FROM tblstudent WHERE s_surname = '" _
                 & txtsearch_subjs.Text & "'"
                assignlbl(sql)

                ''''''''''''
                sql = "SELECT g.student_id,subj.subject_id,subj.subject_s as [Subject]" _
                                                                & ",subj.description_s as [Description],subj.unit_s as [Unit] " _
                                                                & ",g.gtime as [Time],g.gsy FROM tblsubjects as subj ,tblgrade as g,tblstudent as s " _
                                                                & " WHERE g.gyear = subj.year_s And subj.subject_id = g.subject_id " _
                                                                & " and s.s_surname = '" & txtsearch_subjs.Text & "'" _
                                                                & " and g.ggrades = no " _
                                                                & " and g.gadd = yes and s.student_id = g.student_id and g.gremarks = 'null' "


                mysqldtg(sql, dtglist__subjs)
                dtglist__subjs.Columns(0).Visible = False
                dtglist__subjs.Columns(1).Visible = False
                dtglist__subjs.Columns(6).Visible = False

            End If
            'If cbosearch_subjs.Text = "Student Year" Then
            '    sql = "SELECT s_fname,s_surname,s_year FROM tblstudent WHERE s_year = '" _
            '                     & txtsearch_subjs.Text & "'"
            '    assignlbl(sql)


            '    ''''''''''''
            '    ''''''''''''
            '    sql = "SELECT student_id,subj.subject_id,subj.subject_s  " _
            '    & ",subj.description_s ,subj.unit_s  " _
            '    & ",subj.sy_s,subj_time as [Time] FROM tblsubjects as subj,tblstudent as s" _
            '   & " WHERE s.s_year = subj.year_s and s.s_year LIKE '" & txtsearch_subjs.Text & "%'" _
            '   & " and s.s_enrolled = yes and s.s_grade = no and s.s_year = '" & cboyear_lss.Text & "'"
            '    mysqldtg(sql, dtglist__subjs)
            '    dtglist__subjs.Columns(0).Visible = False
            '    dtglist__subjs.Columns(1).Visible = False
            '    dtglist__subjs.Columns(5).Visible = False
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ''''''''''''''''''''''''''''''''''''''  finish
    End Sub

    Private Sub drmliststudentsubj_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clearing()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub btnEdittime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdittime.Click
        Try '''''''''''''''''''''''''buyiled on feb 12 '''''''''''''
            For Each row As DataGridViewRow In dtglist__subjs.Rows
                sql = "UPDATE tblgrade set [gtime] ='" & CStr(row.Cells(5).FormattedValue) & "' WHERE subject_id = '" _
                & CStr(row.Cells(1).FormattedValue) & "'"
                mysql(sql)
            Next row
            MsgBox("Time Change")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try '''''''finish'''''''''''''''''''''
    End Sub

    Private Sub cbosearch_subjs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbosearch_subjs.SelectedIndexChanged

    End Sub
End Class