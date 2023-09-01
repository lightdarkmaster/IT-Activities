Public Class frmlistgrades

    Private Sub txtsearch_subj_gl_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch_subj_gl.TextChanged
        If txtsearch_subj_gl.Text = "" Then
            dtglist_gl.Columns.Clear()
            lblname_s_sub.Text = ""
            lblyear_s_sub.Text = ""
        End If

        If cbosearch_subj_gl.Text = "Student ID" Then
            If IsNumeric(txtsearch_subj_gl.Text) = False Then
                txtsearch_subj_gl.Text = ""
            End If
        End If
        If cbosearch_subj_gl.Text = "Student Name" Or cbosearch_subj_gl.Text = "Student Last Name" Then
            If IsNumeric(txtsearch_subj_gl.Text) = True Then
                txtsearch_subj_gl.Text = ""
            End If
        End If
    End Sub

    Private Sub btnsearch_gl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch_gl.Click
        Try


            If cbosearch_subj_gl.Text = "Student ID" Then


                sql = "SELECT s_fname,s_surname,s_year FROM tblstudent WHERE student_id = '" _
                 & txtsearch_subj_gl.Text & "'"
                assignlbl(sql)

                ''''''''''''
                sql = "SELECT subj.subject_s as [Subject]" _
                                                                & ",subj.description_s as [Description],subj.unit_s as [Units]" _
                                                                & ",g.gyear as [Year],g.gfinal as [Total Average]" _
                                                                & ",g.gremarks as [Remarks],g.gsy as [School Year] FROM tblsubjects as subj,tblstudent as s,tblgrade as g" _
                                                                & " WHERE g.gyear = subj.year_s And subj.subject_id = g.subject_id " _
                                                                & " and s.student_id = '" & txtsearch_subj_gl.Text & "'" _
                                                                & " and g.gyear = '" & cboyear_lsg.Text & "'" _
                                                                & " and s.student_id = g.student_id and not g.gremarks = 'null' "
                mysqldtg(sql, dtglist_gl)

            End If
            If cbosearch_subj_gl.Text = "Student Name" Then


                sql = "SELECT s_fname,s_surname,s_year FROM tblstudent WHERE s_fname = '" _
                 & txtsearch_subj_gl.Text & "'"
                assignlbl(sql)

                ''''''''''''
                sql = "SELECT subj.subject_s as [Subject]" _
                  & ",subj.description_s as [Description],subj.unit_s as [Units]" _
                  & ",g.gyear as [Year],g.gfinal as [Total Average]" _
                  & ",g.gremarks as [Remarks],g.gsy as [School Year]  FROM tblsubjects as subj,tblstudent as s,tblgrade as g" _
                  & " WHERE g.subject_id = subj.subject_id and s.s_fname = '" & txtsearch_subj_gl.Text & "'" _
                  & " and not s.s_enrolled = yes and s.s_grade = yes and g.student_id = s.student_id and g.gyear = '" & cboyear_lsg.Text & "'"
                mysqldtg(sql, dtglist_gl)

            End If

            If cbosearch_subj_gl.Text = "Student Last Name" Then

                sql = "SELECT s_fname,s_surname,s_year FROM tblstudent WHERE s_surname = '" _
                 & txtsearch_subj_gl.Text & "'"
                assignlbl(sql)

                ''''''''''''
                sql = "SELECT subj.subject_s as [Subject]" _
                 & ",subj.description_s as [Description],subj.unit_s as [Units]" _
                 & ",g.gyear as [Year],g.gfinal as [Total Average]" _
                 & ",g.gremarks as [Remarks],g.gsy as [School Year]  FROM tblsubjects as subj,tblstudent as s,tblgrade as g" _
                 & " WHERE g.subject_id = subj.subject_id and s.s_surname = '" & txtsearch_subj_gl.Text & "'" _
                 & " and not s.s_enrolled = yes and s.s_grade = yes and g.student_id = s.student_id and g.gyear = '" & cboyear_lsg.Text & "'"
                mysqldtg(sql, dtglist_gl)

            End If
           
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub cbosearch_subj_gl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosearch_subj_gl.SelectedIndexChanged

    End Sub

    Private Sub frmlistgrades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT * FROM tblyear "
        cbofill(sql, cboyear_lsg)
    End Sub
End Class