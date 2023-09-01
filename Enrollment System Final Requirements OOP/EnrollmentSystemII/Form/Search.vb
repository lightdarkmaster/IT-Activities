Public Class Search

    Private Sub txtbplace_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        If txtsearch.Text = "" Then
            dtglist_s2.Columns.Clear()

        End If

        If cbostatus_s.Text = "ID No." Then
            If IsNumeric(txtsearch.Text) = False Then
                txtsearch.Text = ""
            End If
        End If
        If cbostatus_s.Text = "First Name" Or cbostatus_s.Text = "Last Name" Then
            If IsNumeric(txtsearch.Text) = True Then
                txtsearch.Text = ""
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub btnsearch_s_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
           

            If cbostatus_s.Text = "ID No." And txtsearch.Text = "" Then

                sql = "SELECT student_id as [ID],s_fname as [Student Name]" _
                & ",s_surname as [Surname],s_midname as " _
                & "[Middle Name],s_year as [Year],s_homeadd as [Address]" _
                & ",s_transfer as [Transferee],s_drop as [Drop]" _
                & " FROM tblstudent"
                mysqldtg(sql, dtglist_s2)
            Else
                sql = "SELECT student_id as [ID],s_fname as [Student Name]" _
                & ",s_surname as [Surname],s_midname as " _
                & "[Middle Name],s_year as [Year],s_homeadd as [Address]" _
                 & ",s_transfer as [Transferee],s_drop as [Drop]" _
                & " FROM tblstudent WHERE student_id ='" & txtsearch.Text & "'"
                mysqldtg(sql, dtglist_s2)
            End If

            If cbostatus_s.Text = "First Name" Then
                sql = "SELECT student_id as [ID],s_fname as [Student Name]" _
                & ",s_surname as [Surname],s_midname as " _
                & "[Middle Name],s_year as [Year],s_homeadd as [Address]" _
                 & ",s_transfer as [Transferee],s_drop as [Drop]" _
                & " FROM tblstudent WHERE s_fname ='" & txtsearch.Text & "'"
                mysqldtg(sql, dtglist_s2)
            End If

            If cbostatus_s.Text = "Last Name" Then
                sql = "SELECT student_id as [ID],s_fname as [Student Name]" _
                & ",s_surname as [Surname],s_midname as " _
                & "[Middle Name],s_year as [Year],s_homeadd as [Address]" _
                 & ",s_transfer as [Transferee],s_drop as [Drop]" _
                & " FROM tblstudent WHERE s_surname ='" & txtsearch.Text & "'"
                mysqldtg(sql, dtglist_s2)
            End If
            If cbostatus_s.Text = "Status" Then
                sql = "SELECT student_id as [ID],s_fname as [Student Name]" _
           & ",s_surname as [Surname],s_midname as " _
           & "[Middle Name],s_year as [Year],s_homeadd as [Address]" _
            & ",s_transfer as [Transferee],s_drop as [Drop]" _
           & " FROM tblstudent  WHERE s_year ='" _
           & txtsearch.Text & "'"
                mysqldtg(sql, dtglist_s2)

            End If
            dtglist_s2.Columns(6).Width = 66
            dtglist_s2.Columns(7).Width = 60

        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnsearch_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch_add.Click
        Try
            If dtglist_s2.CurrentCell.Selected = True Then
                Change_Status.txtstudentid_cstatus.Text = dtglist_s2.CurrentRow.Cells(0).Value
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
 
    Private Sub dtglist_s2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtglist_s2.CellContentClick

    End Sub

    Private Sub dtglist_s2_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtglist_s2.CellDoubleClick
        Try

            frmAddstudent.Show()
            frmAddstudent.btnsave_s.Text = "Edit"
            sql = "SELECT student_id,s_fname,s_surname,s_midname,s_year," _
                      & "s_sex,s_datebirthm,s_datebirthd,s_datebirthy,s_placebirth,s_age,s_homeadd" _
                      & ",s_guardian,s_relation,s_gaddress,s_lastschoola,s_elemaddress " _
                      & ",s_bcert,s_f137,s_transfer,s_drop,s_sy FROM tblstudent WHERE student_id = '" _
                      & dtglist_s2.CurrentRow.Cells(0).Value & "'"
            editprofile(sql)
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtglist_s2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles dtglist_s2.Paint

    End Sub

    Private Sub dtglist_s2_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtglist_s2.ParentChanged
       
    End Sub
End Class