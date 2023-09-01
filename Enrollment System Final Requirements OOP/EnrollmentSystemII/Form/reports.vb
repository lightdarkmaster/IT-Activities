Public Class reports
#Region ""
    Dim acscmd As New OleDb.OleDbCommand
    Dim acsda As New OleDb.OleDbDataAdapter
    Dim acscon As OleDb.OleDbConnection = dbmodule()
    Dim acsds As New DataSet
    Dim strsql As String
    Dim strreportname As String
#End Region
#Region ""
    Public Sub report(ByVal sql As String, ByVal rptname As String)
        Try
            acsds = New DataSet
            strsql = sql
            acscmd.CommandText = strsql
            acscmd.Connection = acscon
            acsda.SelectCommand = acscmd
            acsda.Fill(acsds)

            strreportname = rptname
            Dim strreportpath As String = Application.StartupPath & "\reports\" & strreportname & ".rpt"
            '  Dim strreportpath As String = "C:\Users\DELL\Documents\Visual Studio 2008\Projects\mytest\mytest\bin\reports\" & strreportname & ".rpt"
            If Not IO.File.Exists(strreportpath) Then
                MsgBox("Unable to locate file:" & vbCrLf & strreportpath)

            End If
            Dim reportdoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            reportdoc.Load(strreportpath)
            reportdoc.SetDataSource(acsds.Tables(0))

            CrystalReportViewer1.ShowRefreshButton = False
            CrystalReportViewer1.ShowCloseButton = False
            CrystalReportViewer1.ShowGroupTreeButton = False
            CrystalReportViewer1.ReportSource = reportdoc
        Catch ex As Exception
            MsgBox("No Crystal Reports have been Installed")
        End Try

    End Sub


    Private Sub dtnlistst_rep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtnlistst_rep_.Click
        Try
            If cboyear_report.Text = "" Then
                report("SELECT * FROM tblstudent", "all_students")
            Else
                report("SELECT * FROM tblstudent WHERE s_year ='" & cboyear_report.Text & "'", "all_students")
            End If

        Catch ex As Exception
            MsgBox("No Crystal Reports have been Installed")
        End Try

    End Sub
    Private Sub btndrop_rep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndrop_rep.Click
        Try
            If cboyear_report.Text = "" Then
                report("SELECT * FROM tblstudent", "all_students")
            Else
                report("SELECT *  FROM tblstudent Where s_drop = yes and s_year ='" & cboyear_report.Text & "'", "dropstudent")
            End If
  Catch ex As Exception
            MsgBox("No Crystal Reports have been Installed")
        End Try
    End Sub

    Private Sub btntransfer_rep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntransfer_rep.Click
        Try
            If cboyear_report.Text = "" Then
                report("SELECT * FROM tblstudent", "all_students")
            Else
                report("SELECT *  FROM tblstudent Where s_transfer = yes and s_year ='" & cboyear_report.Text & "'", "transfered")

            End If
        Catch ex As Exception
            MsgBox("No Crystal Reports have been Installed")
        End Try

    End Sub

    Private Sub btnfailed_rep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfailed_rep.Click
        Try
            If cboyear_report.Text = "" Then
                report("SELECT * FROM tblstudent", "all_students")
            Else
                report("SELECT * FROM tblstudent WHERE s_remarks = 'Failed' and s_year ='" & cboyear_report.Text & "'", "failedstudent")

            End If
        Catch ex As Exception
            MsgBox("No Crystal Reports have been Installed")
        End Try

    End Sub
#End Region

    Private Sub reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            sql = "SELECT nameyear FROM tblyear"
            cbofill(sql, cboyear_report)
            cboyear_report.Text = ""
        Catch ex As Exception

        End Try

    End Sub
 
    Private Sub cboyear_report_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboyear_report.TextChanged
        cboyear_report.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class