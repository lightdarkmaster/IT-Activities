Public Class Form1

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        User.Show()
        'frmuser.Show()
        sql = "SELECT * FROM tblusers"
        autonum(sql)
    End Sub


    Private Sub btnregistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        visible_Menu(False)
    End Sub

    Private Sub ts_Student_Click(sender As Object, e As EventArgs) Handles ts_Student.Click
        With frmAddstudent
            .Show()
            .Focus()
        End With

        Try
            sql = "SELECT * FROM tblstudent"
            autonum(sql)

            '''''''''''''''''''
            sql = "SELECT * FROM tblyear "
            cbofill(sql, frmAddstudent.cbostatus)
            sql = "Select * From tblsy"
            cbofill(sql, frmAddstudent.cbos_sy)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ts_ListStudent_Click(sender As Object, e As EventArgs) Handles ts_ListStudent.Click
        With Listofstudent
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ts_ChangeStatus_Click(sender As Object, e As EventArgs) Handles ts_ChangeStatus.Click
        With Change_Status
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ts_Subject_Click(sender As Object, e As EventArgs) Handles ts_Subject.Click
        With Listofsubject
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ts_StudentSubject_Click(sender As Object, e As EventArgs) Handles ts_StudentSubject.Click
        With drmliststudentsubj
            .Show()
            .Focus()
        End With

    End Sub

    Private Sub ts_Grade_Click(sender As Object, e As EventArgs) Handles ts_Grade.Click
        With frmaddgrades
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ts_StudentGrades_Click(sender As Object, e As EventArgs) Handles ts_StudentGrades.Click
        With frmlistgrades
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ts_Report_Click(sender As Object, e As EventArgs) Handles ts_Report.Click
        With reports
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ts_User_Click(sender As Object, e As EventArgs) Handles ts_User.Click
        With User
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ts_Settings_Click(sender As Object, e As EventArgs) Handles ts_Settings.Click
        With frmsettings
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ts_Login_Click(sender As Object, e As EventArgs) Handles ts_Login.Click
        If ts_Login.Text = "Login" Then
            LoginForm1.Show()
        Else
            ts_Login.Text = "Login"
            ts_Login.Image = My.Resources.lock
            visible_Menu(False)
        End If
    End Sub
End Class
