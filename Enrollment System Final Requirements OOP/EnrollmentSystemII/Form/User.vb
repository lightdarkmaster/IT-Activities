Public Class User

    Private Sub Btnsave_u_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsave_u.Click
        Try
            sql = "SELECT * FROM tblusers"
            autonumcheck(sql) 'checking


            If Not txtconfirm.Text = txtpass.Text Then
                MsgBox("Password does not match", MsgBoxStyle.Information)
            Else
                If txtname.Text = "" Or txtpass.Text = "" Or txtuname.Text = "" Then
                    MsgBox("Incorrect , all textboxes must filled up.", MsgBoxStyle.Information)
                    

                Else
                    Dim ckeck As Integer = txtuserid_check.Text
                    If ckeck >= lblid.Text Then
                        MsgBox(lblid.Text & " has already existed", MsgBoxStyle.Information)
                        sql = "SELECT * FROM tblusers"
                        autonum(sql)
                        txtname.Text = ""
                        txtuname.Text = ""
                        txtpass.Text = ""
                        cbtype.Text = ""
                        txtconfirm.Text = ""
                    Else
                        sql = "INSERT INTO tblusers (user_id,name_u,username,passwords,type)" _
                                         & " VALUES ('" & lblid.Text & "','" & txtname.Text & "','" & txtuname.Text _
                                         & "','" & txtpass.Text & "','" & cbtype.Text & "')"
                        mysql(sql)
                        If chkactiveuser.Checked = True Then
                            sql = "UPDATE tblusers set statususer = 'Active' Where user_id = '" & lblid.Text & "'"
                            mysql(sql)
                        Else
                            If chkactiveuser.Checked = False Then
                                sql = "UPDATE tblusers set statususer = 'Inactive' Where user_id = '" & lblid.Text & "'"
                                mysql(sql)
                            End If
                        End If
                        MsgBox(txtuname.Text & " Save")
                        txtname.Text = ""
                        txtuname.Text = ""
                        txtpass.Text = ""
                        cbtype.Text = ""
                        txtconfirm.Text = ""
                        Call User_Load(sender, e)
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        sql = "SELECT user_id,name_u as [Name],username as [Username],passwords as [Passwords],type as [Type],statususer as [Status] FROM tblusers"
        mysqldtg(sql, dtglist_user)
    End Sub

    Private Sub dtglist_user_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtglist_user.CellClick
        btndelete_u.Enabled = True
       
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Btnsave_u.Enabled = True
        btndelete_u.Enabled = False
        btnedit.Enabled = False

        txtname.Text = ""
        txtuname.Text = ""
        txtpass.Text = ""
        cbtype.Text = ""
        txtconfirm.Text = ""
        dtglist_user.Columns.Clear()
        sql = "SELECT user_id,name_u as [Name],username as [Username],passwords as [Passwords],type as [Type] FROM tblusers"
        autonum(sql)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Try
            If Not txtconfirm.Text = txtpass.Text Then
                MsgBox("Password does not match", MsgBoxStyle.Information)
            Else
                sql = "UPDATE tblusers set [name_u]='" _
                & txtname.Text & "',[username]='" _
                & txtuname.Text & "',[passwords]='" _
                & txtpass.Text & "',[type]='" _
                & cbtype.Text & "' WHERE user_id = '" _
                & lblid.Text & "'"
                mysql(sql)
                If chkactiveuser.Checked = True Then
                    sql = "UPDATE tblusers set statususer = 'Active' Where user_id = '" & lblid.Text & "'"
                    mysql(sql)
                Else
                    If chkactiveuser.Checked = False Then
                        sql = "UPDATE tblusers set statususer = 'Inactive' Where user_id = '" & lblid.Text & "'"
                        mysql(sql)
                    End If
                End If
                MsgBox("Succesfully Changed")
                Btnsave_u.Enabled = True
                btnedit.Enabled = False
                btndelete_u.Enabled = False
                Call Label6_Click(sender, e)
                sql = "SELECT user_id,name_u as [Name],username as [Username],passwords as [Passwords],type as [Type] FROM tblusers"
                autonum(sql)
                txtname.Text = ""
                txtuname.Text = ""
                txtpass.Text = ""
                cbtype.Text = ""
                txtconfirm.Text = ""
                dtglist_user.Columns.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtconfirm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtconfirm.TextChanged
        txtconfirm.PasswordChar = "*"
    End Sub

    Private Sub txtpass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpass.TextChanged
        txtpass.PasswordChar = "*"
    End Sub

    Private Sub User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT * FROM tblusers"
        autonum(sql)
        sql = "SELECT * FROM tblusers"
        autonumcheck(sql)
    End Sub

     

    Private Sub GroupBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupBox2.Click
        sql = "SELECT user_id,name_u as [Name],username as [Username],passwords as [Passwords],type as [Type] FROM tblusers"
        mysqldtg(sql, dtglist_user)
    End Sub

   
    Private Sub dtglist_user_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtglist_user.CellContentClick

    End Sub

    Private Sub dtglist_user_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtglist_user.DoubleClick
        lblid.Text = dtglist_user.CurrentRow.Cells(0).Value
        txtname.Text = dtglist_user.CurrentRow.Cells(1).Value
        txtuname.Text = dtglist_user.CurrentRow.Cells(2).Value
        txtpass.Text = dtglist_user.CurrentRow.Cells(3).Value
        cbtype.Text = dtglist_user.CurrentRow.Cells(4).Value

        btnedit.Enabled = True
        Btnsave_u.Enabled = False
        If dtglist_user.CurrentRow.Cells(5).Value.ToString = "Active" Then
            chkactiveuser.Checked = True
        Else
            chkactiveuser.Checked = False
        End If
    End Sub

    Private Sub btndelete_u_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete_u.Click
        sql = "DELETE * FROM tblusers WHERE user_id = '" & lblid.Text & "'"
        mysql(sql)
        MsgBox("User account Deleted")
        txtname.Text = ""
        txtuname.Text = ""
        txtpass.Text = ""
        cbtype.Text = ""
        txtconfirm.Text = ""
        dtglist_user.Columns.Clear()
        sql = "SELECT * FROM tblusers"
        autonum(sql)
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class