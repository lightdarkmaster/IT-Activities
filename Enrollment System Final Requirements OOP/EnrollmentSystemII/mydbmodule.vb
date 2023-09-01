Module mydbmodule
    Public sql As String
    Public Function dbmodule() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" _
                                         & Application.StartupPath & "\db_enrolment.mdb;Jet OLEDB:Database Password = admin")
    End Function
    Public con As OleDb.OleDbConnection = dbmodule()
    Public Sub mysql(ByVal sql As String)
        Try
            Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub mysqladdg(ByVal sql As String)
        Try
            Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
        Catch ex As Exception
            'MsgBox(ex.Message)

        End Try

    End Sub
    Public Sub mysqldtg(ByVal sql As String, ByVal dtg As DataGridView)
        Try
            Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            dtg.DataSource = dt
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub assignlbl(ByVal sql As String)
        Try
            Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            drmliststudentsubj.lblname_s_subs.Text = dt.Rows(0).Item(1) & " ," & dt.Rows(0).Item(0)
            drmliststudentsubj.lblyear_s_subs.Text = dt.Rows(0).Item(2)
            'frmSubjectenrol.lblname_s_sub.Text = dt.Rows(0).Item(1) & " ," & dt.Rows(0).Item(0)
            'frmSubjectenrol.lblyear_s_sub.Text = dt.Rows(0).Item(2)
            frmaddgrades.lblname_s_sub.Text = dt.Rows(0).Item(1) & " ," & dt.Rows(0).Item(0)
            frmaddgrades.lblyear_s_sub.Text = dt.Rows(0).Item(2)
            frmlistgrades.lblname_s_sub.Text = dt.Rows(0).Item(1) & " ," & dt.Rows(0).Item(0)
            frmlistgrades.lblyear_s_sub.Text = dt.Rows(0).Item(2)
            Change_Status.lblname_cstatus.Text = dt.Rows(0).Item(1) & " ," & dt.Rows(0).Item(0)
            Change_Status.lblyearcstatus.Text = dt.Rows(0).Item(2)
            Change_Status.lblsy_cs.Text = dt.Rows(0).Item(3)
            
            'Frmviewsubj_stu.Label6.Text = dt.Rows(0).Item(1) & "   ,    " & dt.Rows(0).Item(0)
            'Frmviewsubj_stu.Label7.Text = dt.Rows(0).Item(2)

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub autoreplica(ByVal sql As String, ByVal txt As Object)
        Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, con)
        Dim dt As New DataTable
        da.Fill(dt)
        txt.Text = dt.Rows.Count + 1
    End Sub
    Public Sub autoreplica_check(ByVal sql As String, ByVal lbl As Object)
        Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, con)
        Dim dt As New DataTable
        da.Fill(dt)
        lbl.Text = dt.Rows.Count
    End Sub
    Public Sub autonum(ByVal sql As String)
        Try
            Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            frmsettings.Txtsubjectid_as.Text = dt.Rows.Count + 1 & "212"
            User.lblid.Text = dt.Rows.Count + 1 & "454"
            frmAddstudent.lblstudent_id.Text = dt.Rows.Count + 1 & "343"


            'frmsettings.lblsyid.Text = dt.Rows.Count + 1 & "222"


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub autonumcheck(ByVal sql As String)
        Try
            Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            User.txtuserid_check.Text = dt.Rows.Count & "454"
            frmAddstudent.txtstudentid_check.Text = dt.Rows.Count & "343"
            Change_Status.txtsgidcs_check.Text = dt.Rows.Count
            frmsettings.lblsubjectid_as.Text = dt.Rows.Count & "212"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub cbofill(ByVal sql As String, ByVal cbo As ComboBox)
        Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, con)
        Dim ds As New DataSet
        da.Fill(ds, "db_enrolmet")
        cbo.DataSource = ds.Tables(0)
        cbo.DisplayMember = "sy"
        cbo.DisplayMember = "nameyear"

    End Sub
    Public Sub editprofile(ByVal sql As String)
        Dim da As OleDb.OleDbDataAdapter
        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            frmAddstudent.lblstudent_id.Text = dt.Rows(0).Item(0)
            frmAddstudent.txtfname.Text = dt.Rows(0).Item(1)
            frmAddstudent.txtlname.Text = dt.Rows(0).Item(2)
            frmAddstudent.txtmname.Text = dt.Rows(0).Item(3)
            frmAddstudent.cbostatus.Text = dt.Rows(0).Item(4)
            frmAddstudent.cbosex.Text = dt.Rows(0).Item(5)
            frmAddstudent.cbomonth.Text = dt.Rows(0).Item(6)
            frmAddstudent.txtday.Text = dt.Rows(0).Item(7)
            frmAddstudent.txtyear.Text = dt.Rows(0).Item(8)
            frmAddstudent.txtbplace.Text = dt.Rows(0).Item(9)
            frmAddstudent.txtage.Text = dt.Rows(0).Item(10)
            frmAddstudent.txtaddress.Text = dt.Rows(0).Item(11)
            frmAddstudent.txtguardian.Text = dt.Rows(0).Item(12)
            frmAddstudent.txtrelation.Text = dt.Rows(0).Item(13)
            frmAddstudent.txtgaddress.Text = dt.Rows(0).Item(14)
            frmAddstudent.txtnsla.Text = dt.Rows(0).Item(15)
            frmAddstudent.txtnslaaddress.Text = dt.Rows(0).Item(16)
            frmAddstudent.chkbc.Checked = dt.Rows(0).Item(17)
            frmAddstudent.chkf137.Checked = dt.Rows(0).Item(18)
            frmAddstudent.chktransfer_s.Checked = dt.Rows(0).Item(19)
            frmAddstudent.chkdrop.Checked = dt.Rows(0).Item(20)
            frmAddstudent.cbos_sy.Text = dt.Rows(0).Item(21)


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try

    End Sub
    Public Sub assigntxt(ByVal sql As String, ByVal txt As Object)
        Try
            Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            txt.Text = dt.Rows(0).Item(0)
        Catch ex As Exception
            '  MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub jannogo(ByVal sql As String)
        Try

            Dim maxrows As Integer

            Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            maxrows = dt.Rows.Count

            If maxrows > 0 Then
                If dt.Rows(0).Item(4) = "Administrator" And dt.Rows(0).Item(6) = "Active" Then
                    MsgBox ("Welcom administrator")
                    visible_Menu(True)
                    Form1.ts_Login.Text = "Logout"
                    Form1.ts_Login.Image = My.Resources.logoutCLIP
                    LoginForm1.Close()
                Else
                    MsgBox("This account is inactive,please contact administrator", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("account does not exist", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub addsubj(ByVal sql As String)
        Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, con)
        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count = 0 Then
            MsgBox("there is no list of subject", MsgBoxStyle.Information)
        Else
            For Each row As DataGridViewRow In dt.Rows
                'MessageBox.Show(CStr(row.Cells(2).FormattedValue) & CStr(row.Cells(3).FormattedValue))
                sql = "INSERT INTO tblgrade (subject_id,student_id,gyear,gsy) VALUES ('" _
                        & CStr(row.Cells(1).FormattedValue) & "','" _
                        & CStr(row.Cells(0).FormattedValue) & "','" _
                        & frmAddstudent.lblstudent_id.Text & "','" _
                       & CStr(row.Cells(4).FormattedValue) & "')"
                addsubj(sql)

                '''''''''''''''''''''''''''''''''''''''''''''''''''update
                sql = "UPDATE tblstudent SET [s_enrolled] = yes" _
                & " WHERE student_id = '" & CStr(row.Cells(0).FormattedValue) & "'"
                mysql(sql)
            Next row
            MsgBox("All Subject Saved")
        End If
    End Sub
    Public Sub editsubj(ByVal sql As String)
        Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, con)
        Dim dt As New DataTable
        da.Fill(dt)

        frmsettings.Txtsubjectid_as.Text = dt.Rows(0).Item(0)
        frmsettings.txtsubjname_as.Text = dt.Rows(0).Item(1)
        frmsettings.txtdesc_as.Text = dt.Rows(0).Item(2)
        frmsettings.cbosubjunit_as.Text = dt.Rows(0).Item(3)
        frmsettings.cbosubjyear_as.Text = dt.Rows(0).Item(4)
        frmsettings.cbosubjsy_as.Text = dt.Rows(0).Item(5)
        frmsettings.txttime_subj.Text = dt.Rows(0).Item(6)

    End Sub
End Module
