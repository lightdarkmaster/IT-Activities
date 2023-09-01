Module mymodule
    Public Sub subj_clearing()
        frmsettings.txtyear.Clear()
        frmsettings.txtaddsy.Clear()
        frmsettings.txtdesc_as.Clear()
        frmsettings.txtsubjname_as.Clear()
        'frmsettings.cbosubjsy_as.Text = ""
        frmsettings.cbosubjunit_as.Text = ""
        'frmsettings.cbosubjyear_as.Text = ""
        frmsettings.txttime_subj.Clear()
    End Sub

    Public Sub clearing()
        ' frmstudent.txtstudent_id.Clear()
        frmAddstudent.txtfname.Clear()
        frmAddstudent.txtlname.Clear()
        frmAddstudent.txtmname.Clear()

        frmAddstudent.txtage.Clear()
        frmAddstudent.cbosex.Text = "Male"
        frmAddstudent.cbomonth.Text = "January"
        frmAddstudent.txtday.Clear()
        frmAddstudent.txtyear.Clear()
        frmAddstudent.txtaddress.Clear()
        frmAddstudent.chkdrop.Checked = False
        frmAddstudent.chkf137.Checked = False
        frmAddstudent.chktransfer_s.Checked = False
        frmAddstudent.txtbplace.Clear()
        frmAddstudent.txtnsla.Clear()
        frmAddstudent.txtnsla.Clear()
        frmAddstudent.txtaddress.Clear()
        frmAddstudent.txtrelation.Clear()
        frmAddstudent.txtguardian.Clear()
        frmAddstudent.txtgaddress.Clear()
        frmAddstudent.txtnslaaddress.Clear()
        'frmAddstudent.txtamname.Clear()
        frmAddstudent.txtbplace.Clear()
        frmAddstudent.txtaddress.Clear()
        'frmSubjectenrol.lblname_s_sub.Text = ""
        'frmSubjectenrol.lblyear_s_sub.Text = ""
        frmaddgrades.lblname_s_sub.Text = ""
        frmaddgrades.lblyear_s_sub.Text = ""
        frmlistgrades.lblname_s_sub.Text = ""
        frmlistgrades.lblyear_s_sub.Text = ""
        frmAddstudent.chkbc.Checked = False
        frmAddstudent.chkf137.Checked = False
        drmliststudentsubj.lblname_s_subs.Text = ""
        drmliststudentsubj.lblyear_s_subs.Text = ""
    End Sub
    Public Sub dtgautocompute(ByVal dtg As DataGridView)

        Try
            If dtg.RowCount = 1 Then
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''0
                dtg.Rows(0).Cells(7).Value = Val(dtg.Rows(0).Cells(3).Value) _
              + Val(dtg.Rows(0).Cells(4).Value) + Val(dtg.Rows(0).Cells(5).Value) + Val(dtg.Rows(0).Cells(6).Value)
                dtg.Rows(0).Cells(7).Value = dtg.Rows(0).Cells(7).Value / 4
                If dtg.Rows(0).Cells(7).Value > 0 And dtg.Rows(0).Cells(7).Value < 75 Then
                    dtg.Rows(0).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(0).Cells(7).Value > 74 And dtg.Rows(0).Cells(7).Value < 101 Then
                    dtg.Rows(0).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(0).Cells(7).Value = 0 Then
                    dtg.Rows(0).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(0).Cells(3).Value = ""
                    dtg.Rows(0).Cells(4).Value = ""
                    dtg.Rows(0).Cells(5).Value = ""
                    dtg.Rows(0).Cells(6).Value = ""
                    dtg.Rows(0).Cells(7).Value = ""
                    dtg.Rows(0).Cells(8).Value = ""
                End If


            End If
            If dtg.RowCount = 2 Then
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''0
                dtg.Rows(0).Cells(7).Value = Val(dtg.Rows(0).Cells(3).Value) _
              + Val(dtg.Rows(0).Cells(4).Value) + Val(dtg.Rows(0).Cells(5).Value) + Val(dtg.Rows(0).Cells(6).Value)
                dtg.Rows(0).Cells(7).Value = dtg.Rows(0).Cells(7).Value / 4
                If dtg.Rows(0).Cells(7).Value > 0 And dtg.Rows(0).Cells(7).Value < 75 Then
                    dtg.Rows(0).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(0).Cells(7).Value > 74 And dtg.Rows(0).Cells(7).Value < 101 Then
                    dtg.Rows(0).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(0).Cells(7).Value = 0 Then
                    dtg.Rows(0).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(0).Cells(3).Value = ""
                    dtg.Rows(0).Cells(4).Value = ""
                    dtg.Rows(0).Cells(5).Value = ""
                    dtg.Rows(0).Cells(6).Value = ""
                    dtg.Rows(0).Cells(7).Value = ""
                    dtg.Rows(0).Cells(8).Value = ""
                End If


                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''1
                dtg.Rows(1).Cells(7).Value = Val(dtg.Rows(1).Cells(3).Value) _
                + Val(dtg.Rows(1).Cells(4).Value) + Val(dtg.Rows(1).Cells(5).Value) + Val(dtg.Rows(1).Cells(6).Value)
                dtg.Rows(1).Cells(7).Value = dtg.Rows(1).Cells(7).Value / 4
                If dtg.Rows(1).Cells(7).Value > 0 And dtg.Rows(1).Cells(7).Value < 75 Then
                    dtg.Rows(1).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(1).Cells(7).Value > 74 And dtg.Rows(1).Cells(7).Value < 101 Then
                    dtg.Rows(1).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(1).Cells(7).Value = 0 Then
                    dtg.Rows(1).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(1).Cells(3).Value = ""
                    dtg.Rows(1).Cells(4).Value = ""
                    dtg.Rows(1).Cells(5).Value = ""
                    dtg.Rows(1).Cells(6).Value = ""
                    dtg.Rows(1).Cells(7).Value = ""
                    dtg.Rows(1).Cells(8).Value = ""
                End If


            End If
            If dtg.RowCount = 3 Then
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''0
                dtg.Rows(0).Cells(7).Value = Val(dtg.Rows(0).Cells(3).Value) _
              + Val(dtg.Rows(0).Cells(4).Value) + Val(dtg.Rows(0).Cells(5).Value) + Val(dtg.Rows(0).Cells(6).Value)
                dtg.Rows(0).Cells(7).Value = dtg.Rows(0).Cells(7).Value / 4
                If dtg.Rows(0).Cells(7).Value > 0 And dtg.Rows(0).Cells(7).Value < 75 Then
                    dtg.Rows(0).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(0).Cells(7).Value > 74 And dtg.Rows(0).Cells(7).Value < 101 Then
                    dtg.Rows(0).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(0).Cells(7).Value = 0 Then
                    dtg.Rows(0).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(0).Cells(3).Value = ""
                    dtg.Rows(0).Cells(4).Value = ""
                    dtg.Rows(0).Cells(5).Value = ""
                    dtg.Rows(0).Cells(6).Value = ""
                    dtg.Rows(0).Cells(7).Value = ""
                    dtg.Rows(0).Cells(8).Value = ""
                End If


                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''1
                dtg.Rows(1).Cells(7).Value = Val(dtg.Rows(1).Cells(3).Value) _
                + Val(dtg.Rows(1).Cells(4).Value) + Val(dtg.Rows(1).Cells(5).Value) + Val(dtg.Rows(1).Cells(6).Value)
                dtg.Rows(1).Cells(7).Value = dtg.Rows(1).Cells(7).Value / 4
                If dtg.Rows(1).Cells(7).Value > 0 And dtg.Rows(1).Cells(7).Value < 75 Then
                    dtg.Rows(1).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(1).Cells(7).Value > 74 And dtg.Rows(1).Cells(7).Value < 101 Then
                    dtg.Rows(1).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(1).Cells(7).Value = 0 Then
                    dtg.Rows(1).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(1).Cells(3).Value = ""
                    dtg.Rows(1).Cells(4).Value = ""
                    dtg.Rows(1).Cells(5).Value = ""
                    dtg.Rows(1).Cells(6).Value = ""
                    dtg.Rows(1).Cells(7).Value = ""
                    dtg.Rows(1).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''2
                dtg.Rows(2).Cells(7).Value = Val(dtg.Rows(2).Cells(3).Value) _
              + Val(dtg.Rows(0).Cells(4).Value) + Val(dtg.Rows(2).Cells(5).Value) + Val(dtg.Rows(2).Cells(6).Value)
                dtg.Rows(2).Cells(7).Value = dtg.Rows(2).Cells(7).Value / 4
                If dtg.Rows(2).Cells(7).Value > 0 And dtg.Rows(2).Cells(7).Value < 75 Then
                    dtg.Rows(2).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(2).Cells(7).Value > 74 And dtg.Rows(2).Cells(7).Value < 101 Then
                    dtg.Rows(2).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(2).Cells(7).Value = 0 Then
                    dtg.Rows(2).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(2).Cells(3).Value = ""
                    dtg.Rows(2).Cells(4).Value = ""
                    dtg.Rows(2).Cells(5).Value = ""
                    dtg.Rows(2).Cells(6).Value = ""
                    dtg.Rows(2).Cells(7).Value = ""
                    dtg.Rows(2).Cells(8).Value = ""
                End If

            End If
            If dtg.RowCount = 4 Then
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''0
                dtg.Rows(0).Cells(7).Value = Val(dtg.Rows(0).Cells(3).Value) _
              + Val(dtg.Rows(0).Cells(4).Value) + Val(dtg.Rows(0).Cells(5).Value) + Val(dtg.Rows(0).Cells(6).Value)
                dtg.Rows(0).Cells(7).Value = dtg.Rows(0).Cells(7).Value / 4
                If dtg.Rows(0).Cells(7).Value > 0 And dtg.Rows(0).Cells(7).Value < 75 Then
                    dtg.Rows(0).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(0).Cells(7).Value > 74 And dtg.Rows(0).Cells(7).Value < 101 Then
                    dtg.Rows(0).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(0).Cells(7).Value = 0 Then
                    dtg.Rows(0).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(0).Cells(3).Value = ""
                    dtg.Rows(0).Cells(4).Value = ""
                    dtg.Rows(0).Cells(5).Value = ""
                    dtg.Rows(0).Cells(6).Value = ""
                    dtg.Rows(0).Cells(7).Value = ""
                    dtg.Rows(0).Cells(8).Value = ""
                End If


                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''1
                dtg.Rows(1).Cells(7).Value = Val(dtg.Rows(1).Cells(3).Value) _
                + Val(dtg.Rows(1).Cells(4).Value) + Val(dtg.Rows(1).Cells(5).Value) + Val(dtg.Rows(1).Cells(6).Value)
                dtg.Rows(1).Cells(7).Value = dtg.Rows(1).Cells(7).Value / 4
                If dtg.Rows(1).Cells(7).Value > 0 And dtg.Rows(1).Cells(7).Value < 75 Then
                    dtg.Rows(1).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(1).Cells(7).Value > 74 And dtg.Rows(1).Cells(7).Value < 101 Then
                    dtg.Rows(1).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(1).Cells(7).Value = 0 Then
                    dtg.Rows(1).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(1).Cells(3).Value = ""
                    dtg.Rows(1).Cells(4).Value = ""
                    dtg.Rows(1).Cells(5).Value = ""
                    dtg.Rows(1).Cells(6).Value = ""
                    dtg.Rows(1).Cells(7).Value = ""
                    dtg.Rows(1).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''2
                dtg.Rows(2).Cells(7).Value = Val(dtg.Rows(2).Cells(3).Value) _
              + Val(dtg.Rows(0).Cells(4).Value) + Val(dtg.Rows(2).Cells(5).Value) + Val(dtg.Rows(2).Cells(6).Value)
                dtg.Rows(2).Cells(7).Value = dtg.Rows(2).Cells(7).Value / 4
                If dtg.Rows(2).Cells(7).Value > 0 And dtg.Rows(2).Cells(7).Value < 75 Then
                    dtg.Rows(2).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(2).Cells(7).Value > 74 And dtg.Rows(2).Cells(7).Value < 101 Then
                    dtg.Rows(2).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(2).Cells(7).Value = 0 Then
                    dtg.Rows(2).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(2).Cells(3).Value = ""
                    dtg.Rows(2).Cells(4).Value = ""
                    dtg.Rows(2).Cells(5).Value = ""
                    dtg.Rows(2).Cells(6).Value = ""
                    dtg.Rows(2).Cells(7).Value = ""
                    dtg.Rows(2).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''3
                dtg.Rows(3).Cells(7).Value = Val(dtg.Rows(3).Cells(3).Value) _
               + Val(dtg.Rows(3).Cells(4).Value) + Val(dtg.Rows(3).Cells(5).Value) + Val(dtg.Rows(3).Cells(6).Value)
                dtg.Rows(3).Cells(7).Value = dtg.Rows(3).Cells(7).Value / 4
                If dtg.Rows(3).Cells(7).Value > 0 And dtg.Rows(3).Cells(7).Value < 75 Then
                    dtg.Rows(3).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(3).Cells(7).Value > 74 And dtg.Rows(3).Cells(7).Value < 101 Then
                    dtg.Rows(3).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(3).Cells(7).Value = 0 Then
                    dtg.Rows(3).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(3).Cells(3).Value = ""
                    dtg.Rows(3).Cells(4).Value = ""
                    dtg.Rows(3).Cells(5).Value = ""
                    dtg.Rows(3).Cells(6).Value = ""
                    dtg.Rows(3).Cells(7).Value = ""
                    dtg.Rows(3).Cells(8).Value = ""
                End If

            End If
            If dtg.RowCount = 5 Then
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''0
                dtg.Rows(0).Cells(7).Value = Val(dtg.Rows(0).Cells(3).Value) _
               + Val(dtg.Rows(0).Cells(4).Value) + Val(dtg.Rows(0).Cells(5).Value) + Val(dtg.Rows(0).Cells(6).Value)
                dtg.Rows(0).Cells(7).Value = dtg.Rows(0).Cells(7).Value / 4
                If dtg.Rows(0).Cells(7).Value > 0 And dtg.Rows(0).Cells(7).Value < 75 Then
                    dtg.Rows(0).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(0).Cells(7).Value > 74 And dtg.Rows(0).Cells(7).Value < 101 Then
                    dtg.Rows(0).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(0).Cells(7).Value = 0 Then
                    dtg.Rows(0).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(0).Cells(3).Value = ""
                    dtg.Rows(0).Cells(4).Value = ""
                    dtg.Rows(0).Cells(5).Value = ""
                    dtg.Rows(0).Cells(6).Value = ""
                    dtg.Rows(0).Cells(7).Value = ""
                    dtg.Rows(0).Cells(8).Value = ""
                End If


                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''1
                dtg.Rows(1).Cells(7).Value = Val(dtg.Rows(1).Cells(3).Value) _
                + Val(dtg.Rows(1).Cells(4).Value) + Val(dtg.Rows(1).Cells(5).Value) + Val(dtg.Rows(1).Cells(6).Value)
                dtg.Rows(1).Cells(7).Value = dtg.Rows(1).Cells(7).Value / 4
                If dtg.Rows(1).Cells(7).Value > 0 And dtg.Rows(1).Cells(7).Value < 75 Then
                    dtg.Rows(1).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(1).Cells(7).Value > 74 And dtg.Rows(1).Cells(7).Value < 101 Then
                    dtg.Rows(1).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(1).Cells(7).Value = 0 Then
                    dtg.Rows(1).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(1).Cells(3).Value = ""
                    dtg.Rows(1).Cells(4).Value = ""
                    dtg.Rows(1).Cells(5).Value = ""
                    dtg.Rows(1).Cells(6).Value = ""
                    dtg.Rows(1).Cells(7).Value = ""
                    dtg.Rows(1).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''2
                dtg.Rows(2).Cells(7).Value = Val(dtg.Rows(2).Cells(3).Value) _
              + Val(dtg.Rows(0).Cells(4).Value) + Val(dtg.Rows(2).Cells(5).Value) + Val(dtg.Rows(2).Cells(6).Value)
                dtg.Rows(2).Cells(7).Value = dtg.Rows(2).Cells(7).Value / 4
                If dtg.Rows(2).Cells(7).Value > 0 And dtg.Rows(2).Cells(7).Value < 75 Then
                    dtg.Rows(2).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(2).Cells(7).Value > 74 And dtg.Rows(2).Cells(7).Value < 101 Then
                    dtg.Rows(2).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(2).Cells(7).Value = 0 Then
                    dtg.Rows(2).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(2).Cells(3).Value = ""
                    dtg.Rows(2).Cells(4).Value = ""
                    dtg.Rows(2).Cells(5).Value = ""
                    dtg.Rows(2).Cells(6).Value = ""
                    dtg.Rows(2).Cells(7).Value = ""
                    dtg.Rows(2).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''3
                dtg.Rows(3).Cells(7).Value = Val(dtg.Rows(3).Cells(3).Value) _
               + Val(dtg.Rows(3).Cells(4).Value) + Val(dtg.Rows(3).Cells(5).Value) + Val(dtg.Rows(3).Cells(6).Value)
                dtg.Rows(3).Cells(7).Value = dtg.Rows(3).Cells(7).Value / 4
                If dtg.Rows(3).Cells(7).Value > 0 And dtg.Rows(3).Cells(7).Value < 75 Then
                    dtg.Rows(3).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(3).Cells(7).Value > 74 And dtg.Rows(3).Cells(7).Value < 101 Then
                    dtg.Rows(3).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(3).Cells(7).Value = 0 Then
                    dtg.Rows(3).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(3).Cells(3).Value = ""
                    dtg.Rows(3).Cells(4).Value = ""
                    dtg.Rows(3).Cells(5).Value = ""
                    dtg.Rows(3).Cells(6).Value = ""
                    dtg.Rows(3).Cells(7).Value = ""
                    dtg.Rows(3).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''4
                dtg.Rows(4).Cells(7).Value = Val(dtg.Rows(4).Cells(3).Value) _
               + Val(dtg.Rows(4).Cells(4).Value) + Val(dtg.Rows(4).Cells(5).Value) + Val(dtg.Rows(4).Cells(6).Value)
                dtg.Rows(4).Cells(7).Value = dtg.Rows(4).Cells(7).Value / 4
                If dtg.Rows(4).Cells(7).Value > 0 And dtg.Rows(4).Cells(7).Value < 75 Then
                    dtg.Rows(4).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(4).Cells(7).Value > 74 And dtg.Rows(4).Cells(7).Value < 101 Then
                    dtg.Rows(4).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(4).Cells(7).Value = 0 Then
                    dtg.Rows(4).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(4).Cells(3).Value = ""
                    dtg.Rows(4).Cells(4).Value = ""
                    dtg.Rows(4).Cells(5).Value = ""
                    dtg.Rows(4).Cells(6).Value = ""
                    dtg.Rows(4).Cells(7).Value = ""
                    dtg.Rows(4).Cells(8).Value = ""
                End If

            End If
            If dtg.RowCount = 6 Then
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''0
                dtg.Rows(0).Cells(7).Value = Val(dtg.Rows(0).Cells(3).Value) _
                               + Val(dtg.Rows(0).Cells(4).Value) + Val(dtg.Rows(0).Cells(5).Value) + Val(dtg.Rows(0).Cells(6).Value)
                dtg.Rows(0).Cells(7).Value = dtg.Rows(0).Cells(7).Value / 4
                If dtg.Rows(0).Cells(7).Value > 0 And dtg.Rows(0).Cells(7).Value < 75 Then
                    dtg.Rows(0).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(0).Cells(7).Value > 74 And dtg.Rows(0).Cells(7).Value < 101 Then
                    dtg.Rows(0).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(0).Cells(7).Value = 0 Then
                    dtg.Rows(0).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(0).Cells(3).Value = ""
                    dtg.Rows(0).Cells(4).Value = ""
                    dtg.Rows(0).Cells(5).Value = ""
                    dtg.Rows(0).Cells(6).Value = ""
                    dtg.Rows(0).Cells(7).Value = ""
                    dtg.Rows(0).Cells(8).Value = ""
                End If


                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''1
                dtg.Rows(1).Cells(7).Value = Val(dtg.Rows(1).Cells(3).Value) _
                + Val(dtg.Rows(1).Cells(4).Value) + Val(dtg.Rows(1).Cells(5).Value) + Val(dtg.Rows(1).Cells(6).Value)
                dtg.Rows(1).Cells(7).Value = dtg.Rows(1).Cells(7).Value / 4
                If dtg.Rows(1).Cells(7).Value > 0 And dtg.Rows(1).Cells(7).Value < 75 Then
                    dtg.Rows(1).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(1).Cells(7).Value > 74 And dtg.Rows(1).Cells(7).Value < 101 Then
                    dtg.Rows(1).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(1).Cells(7).Value = 0 Then
                    dtg.Rows(1).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(1).Cells(3).Value = ""
                    dtg.Rows(1).Cells(4).Value = ""
                    dtg.Rows(1).Cells(5).Value = ""
                    dtg.Rows(1).Cells(6).Value = ""
                    dtg.Rows(1).Cells(7).Value = ""
                    dtg.Rows(1).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''2
                dtg.Rows(2).Cells(7).Value = Val(dtg.Rows(2).Cells(3).Value) _
              + Val(dtg.Rows(0).Cells(4).Value) + Val(dtg.Rows(2).Cells(5).Value) + Val(dtg.Rows(2).Cells(6).Value)
                dtg.Rows(2).Cells(7).Value = dtg.Rows(2).Cells(7).Value / 4
                If dtg.Rows(2).Cells(7).Value > 0 And dtg.Rows(2).Cells(7).Value < 75 Then
                    dtg.Rows(2).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(2).Cells(7).Value > 74 And dtg.Rows(2).Cells(7).Value < 101 Then
                    dtg.Rows(2).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(2).Cells(7).Value = 0 Then
                    dtg.Rows(2).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(2).Cells(3).Value = ""
                    dtg.Rows(2).Cells(4).Value = ""
                    dtg.Rows(2).Cells(5).Value = ""
                    dtg.Rows(2).Cells(6).Value = ""
                    dtg.Rows(2).Cells(7).Value = ""
                    dtg.Rows(2).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''3
                dtg.Rows(3).Cells(7).Value = Val(dtg.Rows(3).Cells(3).Value) _
               + Val(dtg.Rows(3).Cells(4).Value) + Val(dtg.Rows(3).Cells(5).Value) + Val(dtg.Rows(3).Cells(6).Value)
                dtg.Rows(3).Cells(7).Value = dtg.Rows(3).Cells(7).Value / 4
                If dtg.Rows(3).Cells(7).Value > 0 And dtg.Rows(3).Cells(7).Value < 75 Then
                    dtg.Rows(3).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(3).Cells(7).Value > 74 And dtg.Rows(3).Cells(7).Value < 101 Then
                    dtg.Rows(3).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(3).Cells(7).Value = 0 Then
                    dtg.Rows(3).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(3).Cells(3).Value = ""
                    dtg.Rows(3).Cells(4).Value = ""
                    dtg.Rows(3).Cells(5).Value = ""
                    dtg.Rows(3).Cells(6).Value = ""
                    dtg.Rows(3).Cells(7).Value = ""
                    dtg.Rows(3).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''4
                dtg.Rows(4).Cells(7).Value = Val(dtg.Rows(4).Cells(3).Value) _
               + Val(dtg.Rows(4).Cells(4).Value) + Val(dtg.Rows(4).Cells(5).Value) + Val(dtg.Rows(4).Cells(6).Value)
                dtg.Rows(4).Cells(7).Value = dtg.Rows(4).Cells(7).Value / 4
                If dtg.Rows(4).Cells(7).Value > 0 And dtg.Rows(4).Cells(7).Value < 75 Then
                    dtg.Rows(4).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(4).Cells(7).Value > 74 And dtg.Rows(4).Cells(7).Value < 101 Then
                    dtg.Rows(4).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(4).Cells(7).Value = 0 Then
                    dtg.Rows(4).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(4).Cells(3).Value = ""
                    dtg.Rows(4).Cells(4).Value = ""
                    dtg.Rows(4).Cells(5).Value = ""
                    dtg.Rows(4).Cells(6).Value = ""
                    dtg.Rows(4).Cells(7).Value = ""
                    dtg.Rows(4).Cells(8).Value = ""
                End If
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''5
                dtg.Rows(5).Cells(7).Value = Val(dtg.Rows(5).Cells(3).Value) _
               + Val(dtg.Rows(5).Cells(4).Value) + Val(dtg.Rows(5).Cells(5).Value) _
               + Val(dtg.Rows(5).Cells(6).Value)
                dtg.Rows(5).Cells(7).Value = dtg.Rows(5).Cells(7).Value / 4
                If dtg.Rows(5).Cells(7).Value > 0 _
                And dtg.Rows(5).Cells(7).Value < 75 Then
                    dtg.Rows(5).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(0).Cells(7).Value > 74 _
                And dtg.Rows(5).Cells(7).Value < 101 Then
                    dtg.Rows(5).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(5).Cells(7).Value = 0 Then
                    dtg.Rows(5).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(5).Cells(3).Value = ""
                    dtg.Rows(5).Cells(4).Value = ""
                    dtg.Rows(5).Cells(5).Value = ""
                    dtg.Rows(5).Cells(6).Value = ""
                    dtg.Rows(5).Cells(7).Value = ""
                    dtg.Rows(5).Cells(8).Value = ""
                End If

            End If
            If dtg.RowCount = 7 Then
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''0
                dtg.Rows(0).Cells(7).Value = Val(dtg.Rows(0).Cells(3).Value) _
               + Val(dtg.Rows(0).Cells(4).Value) + Val(dtg.Rows(0).Cells(5).Value) + Val(dtg.Rows(0).Cells(6).Value)
                dtg.Rows(0).Cells(7).Value = dtg.Rows(0).Cells(7).Value / 4
                If dtg.Rows(0).Cells(7).Value > 0 And dtg.Rows(0).Cells(7).Value < 75 Then
                    dtg.Rows(0).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(0).Cells(7).Value > 74 And dtg.Rows(0).Cells(7).Value < 101 Then
                    dtg.Rows(0).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(0).Cells(7).Value = 0 Then
                    dtg.Rows(0).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(0).Cells(3).Value = ""
                    dtg.Rows(0).Cells(4).Value = ""
                    dtg.Rows(0).Cells(5).Value = ""
                    dtg.Rows(0).Cells(6).Value = ""
                    dtg.Rows(0).Cells(7).Value = ""
                    dtg.Rows(0).Cells(8).Value = ""
                End If


                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''1
                dtg.Rows(1).Cells(7).Value = Val(dtg.Rows(1).Cells(3).Value) _
                + Val(dtg.Rows(1).Cells(4).Value) + Val(dtg.Rows(1).Cells(5).Value) + Val(dtg.Rows(1).Cells(6).Value)
                dtg.Rows(1).Cells(7).Value = dtg.Rows(1).Cells(7).Value / 4
                If dtg.Rows(1).Cells(7).Value > 0 And dtg.Rows(1).Cells(7).Value < 75 Then
                    dtg.Rows(1).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(1).Cells(7).Value > 74 And dtg.Rows(1).Cells(7).Value < 101 Then
                    dtg.Rows(1).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(1).Cells(7).Value = 0 Then
                    dtg.Rows(1).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(1).Cells(3).Value = ""
                    dtg.Rows(1).Cells(4).Value = ""
                    dtg.Rows(1).Cells(5).Value = ""
                    dtg.Rows(1).Cells(6).Value = ""
                    dtg.Rows(1).Cells(7).Value = ""
                    dtg.Rows(1).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''2
                dtg.Rows(2).Cells(7).Value = Val(dtg.Rows(2).Cells(3).Value) _
              + Val(dtg.Rows(0).Cells(4).Value) + Val(dtg.Rows(2).Cells(5).Value) + Val(dtg.Rows(2).Cells(6).Value)
                dtg.Rows(2).Cells(7).Value = dtg.Rows(2).Cells(7).Value / 4
                If dtg.Rows(2).Cells(7).Value > 0 And dtg.Rows(2).Cells(7).Value < 75 Then
                    dtg.Rows(2).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(2).Cells(7).Value > 74 And dtg.Rows(2).Cells(7).Value < 101 Then
                    dtg.Rows(2).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(2).Cells(7).Value = 0 Then
                    dtg.Rows(2).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(2).Cells(3).Value = ""
                    dtg.Rows(2).Cells(4).Value = ""
                    dtg.Rows(2).Cells(5).Value = ""
                    dtg.Rows(2).Cells(6).Value = ""
                    dtg.Rows(2).Cells(7).Value = ""
                    dtg.Rows(2).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''3
                dtg.Rows(3).Cells(7).Value = Val(dtg.Rows(3).Cells(3).Value) _
               + Val(dtg.Rows(3).Cells(4).Value) + Val(dtg.Rows(3).Cells(5).Value) + Val(dtg.Rows(3).Cells(6).Value)
                dtg.Rows(3).Cells(7).Value = dtg.Rows(3).Cells(7).Value / 4
                If dtg.Rows(3).Cells(7).Value > 0 And dtg.Rows(3).Cells(7).Value < 75 Then
                    dtg.Rows(3).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(3).Cells(7).Value > 74 And dtg.Rows(3).Cells(7).Value < 101 Then
                    dtg.Rows(3).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(3).Cells(7).Value = 0 Then
                    dtg.Rows(3).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(3).Cells(3).Value = ""
                    dtg.Rows(3).Cells(4).Value = ""
                    dtg.Rows(3).Cells(5).Value = ""
                    dtg.Rows(3).Cells(6).Value = ""
                    dtg.Rows(3).Cells(7).Value = ""
                    dtg.Rows(3).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''4
                dtg.Rows(4).Cells(7).Value = Val(dtg.Rows(4).Cells(3).Value) _
               + Val(dtg.Rows(4).Cells(4).Value) + Val(dtg.Rows(4).Cells(5).Value) + Val(dtg.Rows(4).Cells(6).Value)
                dtg.Rows(4).Cells(7).Value = dtg.Rows(4).Cells(7).Value / 4
                If dtg.Rows(4).Cells(7).Value > 0 And dtg.Rows(4).Cells(7).Value < 75 Then
                    dtg.Rows(4).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(4).Cells(7).Value > 74 And dtg.Rows(4).Cells(7).Value < 101 Then
                    dtg.Rows(4).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(4).Cells(7).Value = 0 Then
                    dtg.Rows(4).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(4).Cells(3).Value = ""
                    dtg.Rows(4).Cells(4).Value = ""
                    dtg.Rows(4).Cells(5).Value = ""
                    dtg.Rows(4).Cells(6).Value = ""
                    dtg.Rows(4).Cells(7).Value = ""
                    dtg.Rows(4).Cells(8).Value = ""
                End If
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''5
                dtg.Rows(5).Cells(7).Value = Val(dtg.Rows(5).Cells(3).Value) _
               + Val(dtg.Rows(5).Cells(4).Value) + Val(dtg.Rows(5).Cells(5).Value) _
               + Val(dtg.Rows(5).Cells(6).Value)
                dtg.Rows(5).Cells(7).Value = dtg.Rows(5).Cells(7).Value / 4
                If dtg.Rows(5).Cells(7).Value > 0 _
                And dtg.Rows(5).Cells(7).Value < 75 Then
                    dtg.Rows(5).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(0).Cells(7).Value > 74 _
                And dtg.Rows(5).Cells(7).Value < 101 Then
                    dtg.Rows(5).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(5).Cells(7).Value = 0 Then
                    dtg.Rows(5).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(5).Cells(3).Value = ""
                    dtg.Rows(5).Cells(4).Value = ""
                    dtg.Rows(5).Cells(5).Value = ""
                    dtg.Rows(5).Cells(6).Value = ""
                    dtg.Rows(5).Cells(7).Value = ""
                    dtg.Rows(5).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''6
                dtg.Rows(6).Cells(7).Value = Val(dtg.Rows(6).Cells(3).Value) _
               + Val(dtg.Rows(6).Cells(4).Value) + Val(dtg.Rows(6).Cells(5).Value) _
               + Val(dtg.Rows(6).Cells(6).Value)
                dtg.Rows(6).Cells(7).Value = dtg.Rows(6).Cells(7).Value / 4
                If dtg.Rows(6).Cells(7).Value > 0 _
                And dtg.Rows(6).Cells(7).Value < 75 Then
                    dtg.Rows(6).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(6).Cells(7).Value > 74 _
                And dtg.Rows(6).Cells(7).Value < 101 Then
                    dtg.Rows(6).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(6).Cells(7).Value = 0 Then
                    dtg.Rows(6).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(6).Cells(3).Value = ""
                    dtg.Rows(6).Cells(4).Value = ""
                    dtg.Rows(6).Cells(5).Value = ""
                    dtg.Rows(6).Cells(6).Value = ""
                    dtg.Rows(6).Cells(7).Value = ""
                    dtg.Rows(6).Cells(8).Value = ""
                End If

            End If
            If dtg.RowCount = 8 Then
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''0
                dtg.Rows(0).Cells(7).Value = Val(dtg.Rows(0).Cells(3).Value) _
               + Val(dtg.Rows(0).Cells(4).Value) + Val(dtg.Rows(0).Cells(5).Value) + Val(dtg.Rows(0).Cells(6).Value)
                dtg.Rows(0).Cells(7).Value = dtg.Rows(0).Cells(7).Value / 4
                If dtg.Rows(0).Cells(7).Value > 0 And dtg.Rows(0).Cells(7).Value < 75 Then
                    dtg.Rows(0).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(0).Cells(7).Value > 74 And dtg.Rows(0).Cells(7).Value < 101 Then
                    dtg.Rows(0).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(0).Cells(7).Value = 0 Then
                    dtg.Rows(0).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(0).Cells(3).Value = ""
                    dtg.Rows(0).Cells(4).Value = ""
                    dtg.Rows(0).Cells(5).Value = ""
                    dtg.Rows(0).Cells(6).Value = ""
                    dtg.Rows(0).Cells(7).Value = ""
                    dtg.Rows(0).Cells(8).Value = ""
                End If


                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''1
                dtg.Rows(1).Cells(7).Value = Val(dtg.Rows(1).Cells(3).Value) _
                + Val(dtg.Rows(1).Cells(4).Value) + Val(dtg.Rows(1).Cells(5).Value) + Val(dtg.Rows(1).Cells(6).Value)
                dtg.Rows(1).Cells(7).Value = dtg.Rows(1).Cells(7).Value / 4
                If dtg.Rows(1).Cells(7).Value > 0 And dtg.Rows(1).Cells(7).Value < 75 Then
                    dtg.Rows(1).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(1).Cells(7).Value > 74 And dtg.Rows(1).Cells(7).Value < 101 Then
                    dtg.Rows(1).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(1).Cells(7).Value = 0 Then
                    dtg.Rows(1).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(1).Cells(3).Value = ""
                    dtg.Rows(1).Cells(4).Value = ""
                    dtg.Rows(1).Cells(5).Value = ""
                    dtg.Rows(1).Cells(6).Value = ""
                    dtg.Rows(1).Cells(7).Value = ""
                    dtg.Rows(1).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''2
                dtg.Rows(2).Cells(7).Value = Val(dtg.Rows(2).Cells(3).Value) _
              + Val(dtg.Rows(0).Cells(4).Value) + Val(dtg.Rows(2).Cells(5).Value) + Val(dtg.Rows(2).Cells(6).Value)
                dtg.Rows(2).Cells(7).Value = dtg.Rows(2).Cells(7).Value / 4
                If dtg.Rows(2).Cells(7).Value > 0 And dtg.Rows(2).Cells(7).Value < 75 Then
                    dtg.Rows(2).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(2).Cells(7).Value > 74 And dtg.Rows(2).Cells(7).Value < 101 Then
                    dtg.Rows(2).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(2).Cells(7).Value = 0 Then
                    dtg.Rows(2).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(2).Cells(3).Value = ""
                    dtg.Rows(2).Cells(4).Value = ""
                    dtg.Rows(2).Cells(5).Value = ""
                    dtg.Rows(2).Cells(6).Value = ""
                    dtg.Rows(2).Cells(7).Value = ""
                    dtg.Rows(2).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''3
                dtg.Rows(3).Cells(7).Value = Val(dtg.Rows(3).Cells(3).Value) _
               + Val(dtg.Rows(3).Cells(4).Value) + Val(dtg.Rows(3).Cells(5).Value) + Val(dtg.Rows(3).Cells(6).Value)
                dtg.Rows(3).Cells(7).Value = dtg.Rows(3).Cells(7).Value / 4
                If dtg.Rows(3).Cells(7).Value > 0 And dtg.Rows(3).Cells(7).Value < 75 Then
                    dtg.Rows(3).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(3).Cells(7).Value > 74 And dtg.Rows(3).Cells(7).Value < 101 Then
                    dtg.Rows(3).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(3).Cells(7).Value = 0 Then
                    dtg.Rows(3).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(3).Cells(3).Value = ""
                    dtg.Rows(3).Cells(4).Value = ""
                    dtg.Rows(3).Cells(5).Value = ""
                    dtg.Rows(3).Cells(6).Value = ""
                    dtg.Rows(3).Cells(7).Value = ""
                    dtg.Rows(3).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''4
                dtg.Rows(4).Cells(7).Value = Val(dtg.Rows(4).Cells(3).Value) _
               + Val(dtg.Rows(4).Cells(4).Value) + Val(dtg.Rows(4).Cells(5).Value) + Val(dtg.Rows(4).Cells(6).Value)
                dtg.Rows(4).Cells(7).Value = dtg.Rows(4).Cells(7).Value / 4
                If dtg.Rows(4).Cells(7).Value > 0 And dtg.Rows(4).Cells(7).Value < 75 Then
                    dtg.Rows(4).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(4).Cells(7).Value > 74 And dtg.Rows(4).Cells(7).Value < 101 Then
                    dtg.Rows(4).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(4).Cells(7).Value = 0 Then
                    dtg.Rows(4).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(4).Cells(3).Value = ""
                    dtg.Rows(4).Cells(4).Value = ""
                    dtg.Rows(4).Cells(5).Value = ""
                    dtg.Rows(4).Cells(6).Value = ""
                    dtg.Rows(4).Cells(7).Value = ""
                    dtg.Rows(4).Cells(8).Value = ""
                End If
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''5
                dtg.Rows(5).Cells(7).Value = Val(dtg.Rows(5).Cells(3).Value) _
               + Val(dtg.Rows(5).Cells(4).Value) + Val(dtg.Rows(5).Cells(5).Value) _
               + Val(dtg.Rows(5).Cells(6).Value)
                dtg.Rows(5).Cells(7).Value = dtg.Rows(5).Cells(7).Value / 4
                If dtg.Rows(5).Cells(7).Value > 0 _
                And dtg.Rows(5).Cells(7).Value < 75 Then
                    dtg.Rows(5).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(0).Cells(7).Value > 74 _
                And dtg.Rows(5).Cells(7).Value < 101 Then
                    dtg.Rows(5).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(5).Cells(7).Value = 0 Then
                    dtg.Rows(5).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(5).Cells(3).Value = ""
                    dtg.Rows(5).Cells(4).Value = ""
                    dtg.Rows(5).Cells(5).Value = ""
                    dtg.Rows(5).Cells(6).Value = ""
                    dtg.Rows(5).Cells(7).Value = ""
                    dtg.Rows(5).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''6
                dtg.Rows(6).Cells(7).Value = Val(dtg.Rows(6).Cells(3).Value) _
               + Val(dtg.Rows(6).Cells(4).Value) + Val(dtg.Rows(6).Cells(5).Value) _
               + Val(dtg.Rows(6).Cells(6).Value)
                dtg.Rows(6).Cells(7).Value = dtg.Rows(6).Cells(7).Value / 4
                If dtg.Rows(6).Cells(7).Value > 0 _
                And dtg.Rows(6).Cells(7).Value < 75 Then
                    dtg.Rows(6).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(6).Cells(7).Value > 74 _
                And dtg.Rows(6).Cells(7).Value < 101 Then
                    dtg.Rows(6).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(6).Cells(7).Value = 0 Then
                    dtg.Rows(6).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(6).Cells(3).Value = ""
                    dtg.Rows(6).Cells(4).Value = ""
                    dtg.Rows(6).Cells(5).Value = ""
                    dtg.Rows(6).Cells(6).Value = ""
                    dtg.Rows(6).Cells(7).Value = ""
                    dtg.Rows(6).Cells(8).Value = ""
                End If
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''7
                dtg.Rows(7).Cells(7).Value = Val(dtg.Rows(7).Cells(3).Value) _
              + Val(dtg.Rows(7).Cells(4).Value) + Val(dtg.Rows(7).Cells(5).Value) _
              + Val(dtg.Rows(7).Cells(6).Value)
                dtg.Rows(7).Cells(7).Value = dtg.Rows(7).Cells(7).Value / 4
                If dtg.Rows(7).Cells(7).Value > 0 _
                And dtg.Rows(7).Cells(7).Value < 75 Then
                    dtg.Rows(7).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(7).Cells(7).Value > 74 _
                And dtg.Rows(7).Cells(7).Value < 101 Then
                    dtg.Rows(7).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(7).Cells(7).Value = 0 Then
                    dtg.Rows(7).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(7).Cells(3).Value = ""
                    dtg.Rows(7).Cells(4).Value = ""
                    dtg.Rows(7).Cells(5).Value = ""
                    dtg.Rows(7).Cells(6).Value = ""
                    dtg.Rows(7).Cells(7).Value = ""
                    dtg.Rows(7).Cells(8).Value = ""
                End If
            End If

            If dtg.RowCount = 9 Then
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''0
                dtg.Rows(0).Cells(7).Value = Val(dtg.Rows(0).Cells(3).Value) _
                + Val(dtg.Rows(0).Cells(4).Value) + Val(dtg.Rows(0).Cells(5).Value) + Val(dtg.Rows(0).Cells(6).Value)
                dtg.Rows(0).Cells(7).Value = dtg.Rows(0).Cells(7).Value / 4
                If dtg.Rows(0).Cells(7).Value > 0 And dtg.Rows(0).Cells(7).Value < 75 Then
                    dtg.Rows(0).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(0).Cells(7).Value > 74 And dtg.Rows(0).Cells(7).Value < 101 Then
                    dtg.Rows(0).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(0).Cells(7).Value = 0 Then
                    dtg.Rows(0).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(0).Cells(3).Value = ""
                    dtg.Rows(0).Cells(4).Value = ""
                    dtg.Rows(0).Cells(5).Value = ""
                    dtg.Rows(0).Cells(6).Value = ""
                    dtg.Rows(0).Cells(7).Value = ""
                    dtg.Rows(0).Cells(8).Value = ""
                End If


                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''1
                dtg.Rows(1).Cells(7).Value = Val(dtg.Rows(1).Cells(3).Value) _
                + Val(dtg.Rows(1).Cells(4).Value) + Val(dtg.Rows(1).Cells(5).Value) + Val(dtg.Rows(1).Cells(6).Value)
                dtg.Rows(1).Cells(7).Value = dtg.Rows(1).Cells(7).Value / 4
                If dtg.Rows(1).Cells(7).Value > 0 And dtg.Rows(1).Cells(7).Value < 75 Then
                    dtg.Rows(1).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(1).Cells(7).Value > 74 And dtg.Rows(1).Cells(7).Value < 101 Then
                    dtg.Rows(1).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(1).Cells(7).Value = 0 Then
                    dtg.Rows(1).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(1).Cells(3).Value = ""
                    dtg.Rows(1).Cells(4).Value = ""
                    dtg.Rows(1).Cells(5).Value = ""
                    dtg.Rows(1).Cells(6).Value = ""
                    dtg.Rows(1).Cells(7).Value = ""
                    dtg.Rows(1).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''2
                dtg.Rows(2).Cells(7).Value = Val(dtg.Rows(2).Cells(3).Value) _
              + Val(dtg.Rows(0).Cells(4).Value) + Val(dtg.Rows(2).Cells(5).Value) + Val(dtg.Rows(2).Cells(6).Value)
                dtg.Rows(2).Cells(7).Value = dtg.Rows(2).Cells(7).Value / 4
                If dtg.Rows(2).Cells(7).Value > 0 And dtg.Rows(2).Cells(7).Value < 75 Then
                    dtg.Rows(2).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(2).Cells(7).Value > 74 And dtg.Rows(2).Cells(7).Value < 101 Then
                    dtg.Rows(2).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(2).Cells(7).Value = 0 Then
                    dtg.Rows(2).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(2).Cells(3).Value = ""
                    dtg.Rows(2).Cells(4).Value = ""
                    dtg.Rows(2).Cells(5).Value = ""
                    dtg.Rows(2).Cells(6).Value = ""
                    dtg.Rows(2).Cells(7).Value = ""
                    dtg.Rows(2).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''3
                dtg.Rows(3).Cells(7).Value = Val(dtg.Rows(3).Cells(3).Value) _
               + Val(dtg.Rows(3).Cells(4).Value) + Val(dtg.Rows(3).Cells(5).Value) + Val(dtg.Rows(3).Cells(6).Value)
                dtg.Rows(3).Cells(7).Value = dtg.Rows(3).Cells(7).Value / 4
                If dtg.Rows(3).Cells(7).Value > 0 And dtg.Rows(3).Cells(7).Value < 75 Then
                    dtg.Rows(3).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(3).Cells(7).Value > 74 And dtg.Rows(3).Cells(7).Value < 101 Then
                    dtg.Rows(3).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(3).Cells(7).Value = 0 Then
                    dtg.Rows(3).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(3).Cells(3).Value = ""
                    dtg.Rows(3).Cells(4).Value = ""
                    dtg.Rows(3).Cells(5).Value = ""
                    dtg.Rows(3).Cells(6).Value = ""
                    dtg.Rows(3).Cells(7).Value = ""
                    dtg.Rows(3).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''4
                dtg.Rows(4).Cells(7).Value = Val(dtg.Rows(4).Cells(3).Value) _
               + Val(dtg.Rows(4).Cells(4).Value) + Val(dtg.Rows(4).Cells(5).Value) + Val(dtg.Rows(4).Cells(6).Value)
                dtg.Rows(4).Cells(7).Value = dtg.Rows(4).Cells(7).Value / 4
                If dtg.Rows(4).Cells(7).Value > 0 And dtg.Rows(4).Cells(7).Value < 75 Then
                    dtg.Rows(4).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(4).Cells(7).Value > 74 And dtg.Rows(4).Cells(7).Value < 101 Then
                    dtg.Rows(4).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(4).Cells(7).Value = 0 Then
                    dtg.Rows(4).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(4).Cells(3).Value = ""
                    dtg.Rows(4).Cells(4).Value = ""
                    dtg.Rows(4).Cells(5).Value = ""
                    dtg.Rows(4).Cells(6).Value = ""
                    dtg.Rows(4).Cells(7).Value = ""
                    dtg.Rows(4).Cells(8).Value = ""
                End If
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''5
                dtg.Rows(5).Cells(7).Value = Val(dtg.Rows(5).Cells(3).Value) _
               + Val(dtg.Rows(5).Cells(4).Value) + Val(dtg.Rows(5).Cells(5).Value) _
               + Val(dtg.Rows(5).Cells(6).Value)
                dtg.Rows(5).Cells(7).Value = dtg.Rows(5).Cells(7).Value / 4
                If dtg.Rows(5).Cells(7).Value > 0 _
                And dtg.Rows(5).Cells(7).Value < 75 Then
                    dtg.Rows(5).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(0).Cells(7).Value > 74 _
                And dtg.Rows(5).Cells(7).Value < 101 Then
                    dtg.Rows(5).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(5).Cells(7).Value = 0 Then
                    dtg.Rows(5).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(5).Cells(3).Value = ""
                    dtg.Rows(5).Cells(4).Value = ""
                    dtg.Rows(5).Cells(5).Value = ""
                    dtg.Rows(5).Cells(6).Value = ""
                    dtg.Rows(5).Cells(7).Value = ""
                    dtg.Rows(5).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''6
                dtg.Rows(6).Cells(7).Value = Val(dtg.Rows(6).Cells(3).Value) _
               + Val(dtg.Rows(6).Cells(4).Value) + Val(dtg.Rows(6).Cells(5).Value) _
               + Val(dtg.Rows(6).Cells(6).Value)
                dtg.Rows(6).Cells(7).Value = dtg.Rows(6).Cells(7).Value / 4
                If dtg.Rows(6).Cells(7).Value > 0 _
                And dtg.Rows(6).Cells(7).Value < 75 Then
                    dtg.Rows(6).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(6).Cells(7).Value > 74 _
                And dtg.Rows(6).Cells(7).Value < 101 Then
                    dtg.Rows(6).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(6).Cells(7).Value = 0 Then
                    dtg.Rows(6).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(6).Cells(3).Value = ""
                    dtg.Rows(6).Cells(4).Value = ""
                    dtg.Rows(6).Cells(5).Value = ""
                    dtg.Rows(6).Cells(6).Value = ""
                    dtg.Rows(6).Cells(7).Value = ""
                    dtg.Rows(6).Cells(8).Value = ""
                End If
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''7
                dtg.Rows(7).Cells(7).Value = Val(dtg.Rows(7).Cells(3).Value) _
              + Val(dtg.Rows(7).Cells(4).Value) + Val(dtg.Rows(7).Cells(5).Value) _
              + Val(dtg.Rows(7).Cells(6).Value)
                dtg.Rows(7).Cells(7).Value = dtg.Rows(7).Cells(7).Value / 4
                If dtg.Rows(7).Cells(7).Value > 0 _
                And dtg.Rows(7).Cells(7).Value < 75 Then
                    dtg.Rows(7).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(7).Cells(7).Value > 74 _
                And dtg.Rows(7).Cells(7).Value < 101 Then
                    dtg.Rows(7).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(7).Cells(7).Value = 0 Then
                    dtg.Rows(7).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(7).Cells(3).Value = ""
                    dtg.Rows(7).Cells(4).Value = ""
                    dtg.Rows(7).Cells(5).Value = ""
                    dtg.Rows(7).Cells(6).Value = ""
                    dtg.Rows(7).Cells(7).Value = ""
                    dtg.Rows(7).Cells(8).Value = ""
                End If
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''8
                dtg.Rows(8).Cells(7).Value = Val(dtg.Rows(8).Cells(3).Value) _
               + Val(dtg.Rows(8).Cells(4).Value) + Val(dtg.Rows(8).Cells(5).Value) _
               + Val(dtg.Rows(8).Cells(6).Value)
                dtg.Rows(8).Cells(7).Value = dtg.Rows(8).Cells(7).Value / 4
                If dtg.Rows(8).Cells(7).Value > 0 _
                And dtg.Rows(8).Cells(7).Value < 75 Then
                    dtg.Rows(8).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(8).Cells(7).Value > 74 _
                And dtg.Rows(8).Cells(7).Value < 101 Then
                    dtg.Rows(8).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(8).Cells(7).Value = 0 Then
                    dtg.Rows(8).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(8).Cells(3).Value = ""
                    dtg.Rows(8).Cells(4).Value = ""
                    dtg.Rows(8).Cells(5).Value = ""
                    dtg.Rows(8).Cells(6).Value = ""
                    dtg.Rows(8).Cells(7).Value = ""
                    dtg.Rows(8).Cells(8).Value = ""
                End If

            End If

            If dtg.RowCount = 10 Then
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''0
                dtg.Rows(0).Cells(7).Value = Val(dtg.Rows(0).Cells(3).Value) _
                + Val(dtg.Rows(0).Cells(4).Value) + Val(dtg.Rows(0).Cells(5).Value) + Val(dtg.Rows(0).Cells(6).Value)
                dtg.Rows(0).Cells(7).Value = dtg.Rows(0).Cells(7).Value / 4
                If dtg.Rows(0).Cells(7).Value > 0 And dtg.Rows(0).Cells(7).Value < 75 Then
                    dtg.Rows(0).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(0).Cells(7).Value > 74 And dtg.Rows(0).Cells(7).Value < 101 Then
                    dtg.Rows(0).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(0).Cells(7).Value = 0 Then
                    dtg.Rows(0).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(0).Cells(3).Value = ""
                    dtg.Rows(0).Cells(4).Value = ""
                    dtg.Rows(0).Cells(5).Value = ""
                    dtg.Rows(0).Cells(6).Value = ""
                    dtg.Rows(0).Cells(7).Value = ""
                    dtg.Rows(0).Cells(8).Value = ""
                End If


                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''1
                dtg.Rows(1).Cells(7).Value = Val(dtg.Rows(1).Cells(3).Value) _
                + Val(dtg.Rows(1).Cells(4).Value) + Val(dtg.Rows(1).Cells(5).Value) + Val(dtg.Rows(1).Cells(6).Value)
                dtg.Rows(1).Cells(7).Value = dtg.Rows(1).Cells(7).Value / 4
                If dtg.Rows(1).Cells(7).Value > 0 And dtg.Rows(1).Cells(7).Value < 75 Then
                    dtg.Rows(1).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(1).Cells(7).Value > 74 And dtg.Rows(1).Cells(7).Value < 101 Then
                    dtg.Rows(1).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(1).Cells(7).Value = 0 Then
                    dtg.Rows(1).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(1).Cells(3).Value = ""
                    dtg.Rows(1).Cells(4).Value = ""
                    dtg.Rows(1).Cells(5).Value = ""
                    dtg.Rows(1).Cells(6).Value = ""
                    dtg.Rows(1).Cells(7).Value = ""
                    dtg.Rows(1).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''2
                dtg.Rows(2).Cells(7).Value = Val(dtg.Rows(2).Cells(3).Value) _
              + Val(dtg.Rows(0).Cells(4).Value) + Val(dtg.Rows(2).Cells(5).Value) + Val(dtg.Rows(2).Cells(6).Value)
                dtg.Rows(2).Cells(7).Value = dtg.Rows(2).Cells(7).Value / 4
                If dtg.Rows(2).Cells(7).Value > 0 And dtg.Rows(2).Cells(7).Value < 75 Then
                    dtg.Rows(2).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(2).Cells(7).Value > 74 And dtg.Rows(2).Cells(7).Value < 101 Then
                    dtg.Rows(2).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(2).Cells(7).Value = 0 Then
                    dtg.Rows(2).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(2).Cells(3).Value = ""
                    dtg.Rows(2).Cells(4).Value = ""
                    dtg.Rows(2).Cells(5).Value = ""
                    dtg.Rows(2).Cells(6).Value = ""
                    dtg.Rows(2).Cells(7).Value = ""
                    dtg.Rows(2).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''3
                dtg.Rows(3).Cells(7).Value = Val(dtg.Rows(3).Cells(3).Value) _
               + Val(dtg.Rows(3).Cells(4).Value) + Val(dtg.Rows(3).Cells(5).Value) + Val(dtg.Rows(3).Cells(6).Value)
                dtg.Rows(3).Cells(7).Value = dtg.Rows(3).Cells(7).Value / 4
                If dtg.Rows(3).Cells(7).Value > 0 And dtg.Rows(3).Cells(7).Value < 75 Then
                    dtg.Rows(3).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(3).Cells(7).Value > 74 And dtg.Rows(3).Cells(7).Value < 101 Then
                    dtg.Rows(3).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(3).Cells(7).Value = 0 Then
                    dtg.Rows(3).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(3).Cells(3).Value = ""
                    dtg.Rows(3).Cells(4).Value = ""
                    dtg.Rows(3).Cells(5).Value = ""
                    dtg.Rows(3).Cells(6).Value = ""
                    dtg.Rows(3).Cells(7).Value = ""
                    dtg.Rows(3).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''4
                dtg.Rows(4).Cells(7).Value = Val(dtg.Rows(4).Cells(3).Value) _
               + Val(dtg.Rows(4).Cells(4).Value) + Val(dtg.Rows(4).Cells(5).Value) + Val(dtg.Rows(4).Cells(6).Value)
                dtg.Rows(4).Cells(7).Value = dtg.Rows(4).Cells(7).Value / 4
                If dtg.Rows(4).Cells(7).Value > 0 And dtg.Rows(4).Cells(7).Value < 75 Then
                    dtg.Rows(4).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(4).Cells(7).Value > 74 And dtg.Rows(4).Cells(7).Value < 101 Then
                    dtg.Rows(4).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(4).Cells(7).Value = 0 Then
                    dtg.Rows(4).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(4).Cells(3).Value = ""
                    dtg.Rows(4).Cells(4).Value = ""
                    dtg.Rows(4).Cells(5).Value = ""
                    dtg.Rows(4).Cells(6).Value = ""
                    dtg.Rows(4).Cells(7).Value = ""
                    dtg.Rows(4).Cells(8).Value = ""
                End If
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''5
                dtg.Rows(5).Cells(7).Value = Val(dtg.Rows(5).Cells(3).Value) _
               + Val(dtg.Rows(5).Cells(4).Value) + Val(dtg.Rows(5).Cells(5).Value) _
               + Val(dtg.Rows(5).Cells(6).Value)
                dtg.Rows(5).Cells(7).Value = dtg.Rows(5).Cells(7).Value / 4
                If dtg.Rows(5).Cells(7).Value > 0 _
                And dtg.Rows(5).Cells(7).Value < 75 Then
                    dtg.Rows(5).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(0).Cells(7).Value > 74 _
                And dtg.Rows(5).Cells(7).Value < 101 Then
                    dtg.Rows(5).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(5).Cells(7).Value = 0 Then
                    dtg.Rows(5).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(5).Cells(3).Value = ""
                    dtg.Rows(5).Cells(4).Value = ""
                    dtg.Rows(5).Cells(5).Value = ""
                    dtg.Rows(5).Cells(6).Value = ""
                    dtg.Rows(5).Cells(7).Value = ""
                    dtg.Rows(5).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''6
                dtg.Rows(6).Cells(7).Value = Val(dtg.Rows(6).Cells(3).Value) _
               + Val(dtg.Rows(6).Cells(4).Value) + Val(dtg.Rows(6).Cells(5).Value) _
               + Val(dtg.Rows(6).Cells(6).Value)
                dtg.Rows(6).Cells(7).Value = dtg.Rows(6).Cells(7).Value / 4
                If dtg.Rows(6).Cells(7).Value > 0 _
                And dtg.Rows(6).Cells(7).Value < 75 Then
                    dtg.Rows(6).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(6).Cells(7).Value > 74 _
                And dtg.Rows(6).Cells(7).Value < 101 Then
                    dtg.Rows(6).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(6).Cells(7).Value = 0 Then
                    dtg.Rows(6).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(6).Cells(3).Value = ""
                    dtg.Rows(6).Cells(4).Value = ""
                    dtg.Rows(6).Cells(5).Value = ""
                    dtg.Rows(6).Cells(6).Value = ""
                    dtg.Rows(6).Cells(7).Value = ""
                    dtg.Rows(6).Cells(8).Value = ""
                End If
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''7
                dtg.Rows(7).Cells(7).Value = Val(dtg.Rows(7).Cells(3).Value) _
              + Val(dtg.Rows(7).Cells(4).Value) + Val(dtg.Rows(7).Cells(5).Value) _
              + Val(dtg.Rows(7).Cells(6).Value)
                dtg.Rows(7).Cells(7).Value = dtg.Rows(7).Cells(7).Value / 4
                If dtg.Rows(7).Cells(7).Value > 0 _
                And dtg.Rows(7).Cells(7).Value < 75 Then
                    dtg.Rows(7).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(7).Cells(7).Value > 74 _
                And dtg.Rows(7).Cells(7).Value < 101 Then
                    dtg.Rows(7).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(7).Cells(7).Value = 0 Then
                    dtg.Rows(7).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(7).Cells(3).Value = ""
                    dtg.Rows(7).Cells(4).Value = ""
                    dtg.Rows(7).Cells(5).Value = ""
                    dtg.Rows(7).Cells(6).Value = ""
                    dtg.Rows(7).Cells(7).Value = ""
                    dtg.Rows(7).Cells(8).Value = ""
                End If
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''8
                dtg.Rows(8).Cells(7).Value = Val(dtg.Rows(8).Cells(3).Value) _
               + Val(dtg.Rows(8).Cells(4).Value) + Val(dtg.Rows(8).Cells(5).Value) _
               + Val(dtg.Rows(8).Cells(6).Value)
                dtg.Rows(8).Cells(7).Value = dtg.Rows(8).Cells(7).Value / 4
                If dtg.Rows(8).Cells(7).Value > 0 _
                And dtg.Rows(8).Cells(7).Value < 75 Then
                    dtg.Rows(8).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(8).Cells(7).Value > 74 _
                And dtg.Rows(8).Cells(7).Value < 101 Then
                    dtg.Rows(8).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(8).Cells(7).Value = 0 Then
                    dtg.Rows(8).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(8).Cells(3).Value = ""
                    dtg.Rows(8).Cells(4).Value = ""
                    dtg.Rows(8).Cells(5).Value = ""
                    dtg.Rows(8).Cells(6).Value = ""
                    dtg.Rows(8).Cells(7).Value = ""
                    dtg.Rows(8).Cells(8).Value = ""
                End If
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''9
                dtg.Rows(9).Cells(7).Value = Val(dtg.Rows(9).Cells(3).Value) _
             + Val(dtg.Rows(9).Cells(4).Value) + Val(dtg.Rows(9).Cells(5).Value) _
             + Val(dtg.Rows(9).Cells(6).Value)
                dtg.Rows(9).Cells(7).Value = dtg.Rows(9).Cells(7).Value / 4
                If dtg.Rows(9).Cells(7).Value > 0 _
                And dtg.Rows(9).Cells(7).Value < 75 Then
                    dtg.Rows(9).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(9).Cells(7).Value > 74 _
                And dtg.Rows(9).Cells(7).Value < 101 Then
                    dtg.Rows(9).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(9).Cells(7).Value = 0 Then
                    dtg.Rows(9).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(9).Cells(3).Value = ""
                    dtg.Rows(9).Cells(4).Value = ""
                    dtg.Rows(9).Cells(5).Value = ""
                    dtg.Rows(9).Cells(6).Value = ""
                    dtg.Rows(9).Cells(7).Value = ""
                    dtg.Rows(9).Cells(8).Value = ""
                End If
            End If
            If dtg.RowCount = 11 Then
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''0
                dtg.Rows(0).Cells(7).Value = Val(dtg.Rows(0).Cells(3).Value) _
                + Val(dtg.Rows(0).Cells(4).Value) + Val(dtg.Rows(0).Cells(5).Value) + Val(dtg.Rows(0).Cells(6).Value)
                dtg.Rows(0).Cells(7).Value = dtg.Rows(0).Cells(7).Value / 4
                If dtg.Rows(0).Cells(7).Value > 0 And dtg.Rows(0).Cells(7).Value < 75 Then
                    dtg.Rows(0).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(0).Cells(7).Value > 74 And dtg.Rows(0).Cells(7).Value < 101 Then
                    dtg.Rows(0).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(0).Cells(7).Value = 0 Then
                    dtg.Rows(0).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(0).Cells(3).Value = ""
                    dtg.Rows(0).Cells(4).Value = ""
                    dtg.Rows(0).Cells(5).Value = ""
                    dtg.Rows(0).Cells(6).Value = ""
                    dtg.Rows(0).Cells(7).Value = ""
                    dtg.Rows(0).Cells(8).Value = ""
                End If


                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''1
                dtg.Rows(1).Cells(7).Value = Val(dtg.Rows(1).Cells(3).Value) _
                + Val(dtg.Rows(1).Cells(4).Value) + Val(dtg.Rows(1).Cells(5).Value) + Val(dtg.Rows(1).Cells(6).Value)
                dtg.Rows(1).Cells(7).Value = dtg.Rows(1).Cells(7).Value / 4
                If dtg.Rows(1).Cells(7).Value > 0 And dtg.Rows(1).Cells(7).Value < 75 Then
                    dtg.Rows(1).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(1).Cells(7).Value > 74 And dtg.Rows(1).Cells(7).Value < 101 Then
                    dtg.Rows(1).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(1).Cells(7).Value = 0 Then
                    dtg.Rows(1).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(1).Cells(3).Value = ""
                    dtg.Rows(1).Cells(4).Value = ""
                    dtg.Rows(1).Cells(5).Value = ""
                    dtg.Rows(1).Cells(6).Value = ""
                    dtg.Rows(1).Cells(7).Value = ""
                    dtg.Rows(1).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''2
                dtg.Rows(2).Cells(7).Value = Val(dtg.Rows(2).Cells(3).Value) _
              + Val(dtg.Rows(0).Cells(4).Value) + Val(dtg.Rows(2).Cells(5).Value) + Val(dtg.Rows(2).Cells(6).Value)
                dtg.Rows(2).Cells(7).Value = dtg.Rows(2).Cells(7).Value / 4
                If dtg.Rows(2).Cells(7).Value > 0 And dtg.Rows(2).Cells(7).Value < 75 Then
                    dtg.Rows(2).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(2).Cells(7).Value > 74 And dtg.Rows(2).Cells(7).Value < 101 Then
                    dtg.Rows(2).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(2).Cells(7).Value = 0 Then
                    dtg.Rows(2).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(2).Cells(3).Value = ""
                    dtg.Rows(2).Cells(4).Value = ""
                    dtg.Rows(2).Cells(5).Value = ""
                    dtg.Rows(2).Cells(6).Value = ""
                    dtg.Rows(2).Cells(7).Value = ""
                    dtg.Rows(2).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''3
                dtg.Rows(3).Cells(7).Value = Val(dtg.Rows(3).Cells(3).Value) _
               + Val(dtg.Rows(3).Cells(4).Value) + Val(dtg.Rows(3).Cells(5).Value) + Val(dtg.Rows(3).Cells(6).Value)
                dtg.Rows(3).Cells(7).Value = dtg.Rows(3).Cells(7).Value / 4
                If dtg.Rows(3).Cells(7).Value > 0 And dtg.Rows(3).Cells(7).Value < 75 Then
                    dtg.Rows(3).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(3).Cells(7).Value > 74 And dtg.Rows(3).Cells(7).Value < 101 Then
                    dtg.Rows(3).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(3).Cells(7).Value = 0 Then
                    dtg.Rows(3).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(3).Cells(3).Value = ""
                    dtg.Rows(3).Cells(4).Value = ""
                    dtg.Rows(3).Cells(5).Value = ""
                    dtg.Rows(3).Cells(6).Value = ""
                    dtg.Rows(3).Cells(7).Value = ""
                    dtg.Rows(3).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''4
                dtg.Rows(4).Cells(7).Value = Val(dtg.Rows(4).Cells(3).Value) _
               + Val(dtg.Rows(4).Cells(4).Value) + Val(dtg.Rows(4).Cells(5).Value) + Val(dtg.Rows(4).Cells(6).Value)
                dtg.Rows(4).Cells(7).Value = dtg.Rows(4).Cells(7).Value / 4
                If dtg.Rows(4).Cells(7).Value > 0 And dtg.Rows(4).Cells(7).Value < 75 Then
                    dtg.Rows(4).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(4).Cells(7).Value > 74 And dtg.Rows(4).Cells(7).Value < 101 Then
                    dtg.Rows(4).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(4).Cells(7).Value = 0 Then
                    dtg.Rows(4).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(4).Cells(3).Value = ""
                    dtg.Rows(4).Cells(4).Value = ""
                    dtg.Rows(4).Cells(5).Value = ""
                    dtg.Rows(4).Cells(6).Value = ""
                    dtg.Rows(4).Cells(7).Value = ""
                    dtg.Rows(4).Cells(8).Value = ""
                End If
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''5
                dtg.Rows(5).Cells(7).Value = Val(dtg.Rows(5).Cells(3).Value) _
               + Val(dtg.Rows(5).Cells(4).Value) + Val(dtg.Rows(5).Cells(5).Value) _
               + Val(dtg.Rows(5).Cells(6).Value)
                dtg.Rows(5).Cells(7).Value = dtg.Rows(5).Cells(7).Value / 4
                If dtg.Rows(5).Cells(7).Value > 0 _
                And dtg.Rows(5).Cells(7).Value < 75 Then
                    dtg.Rows(5).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(0).Cells(7).Value > 74 _
                And dtg.Rows(5).Cells(7).Value < 101 Then
                    dtg.Rows(5).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(5).Cells(7).Value = 0 Then
                    dtg.Rows(5).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(5).Cells(3).Value = ""
                    dtg.Rows(5).Cells(4).Value = ""
                    dtg.Rows(5).Cells(5).Value = ""
                    dtg.Rows(5).Cells(6).Value = ""
                    dtg.Rows(5).Cells(7).Value = ""
                    dtg.Rows(5).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''6
                dtg.Rows(6).Cells(7).Value = Val(dtg.Rows(6).Cells(3).Value) _
               + Val(dtg.Rows(6).Cells(4).Value) + Val(dtg.Rows(6).Cells(5).Value) _
               + Val(dtg.Rows(6).Cells(6).Value)
                dtg.Rows(6).Cells(7).Value = dtg.Rows(6).Cells(7).Value / 4
                If dtg.Rows(6).Cells(7).Value > 0 _
                And dtg.Rows(6).Cells(7).Value < 75 Then
                    dtg.Rows(6).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(6).Cells(7).Value > 74 _
                And dtg.Rows(6).Cells(7).Value < 101 Then
                    dtg.Rows(6).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(6).Cells(7).Value = 0 Then
                    dtg.Rows(6).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(6).Cells(3).Value = ""
                    dtg.Rows(6).Cells(4).Value = ""
                    dtg.Rows(6).Cells(5).Value = ""
                    dtg.Rows(6).Cells(6).Value = ""
                    dtg.Rows(6).Cells(7).Value = ""
                    dtg.Rows(6).Cells(8).Value = ""
                End If
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''7
                dtg.Rows(7).Cells(7).Value = Val(dtg.Rows(7).Cells(3).Value) _
              + Val(dtg.Rows(7).Cells(4).Value) + Val(dtg.Rows(7).Cells(5).Value) _
              + Val(dtg.Rows(7).Cells(6).Value)
                dtg.Rows(7).Cells(7).Value = dtg.Rows(7).Cells(7).Value / 4
                If dtg.Rows(7).Cells(7).Value > 0 _
                And dtg.Rows(7).Cells(7).Value < 75 Then
                    dtg.Rows(7).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(7).Cells(7).Value > 74 _
                And dtg.Rows(7).Cells(7).Value < 101 Then
                    dtg.Rows(7).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(7).Cells(7).Value = 0 Then
                    dtg.Rows(7).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(7).Cells(3).Value = ""
                    dtg.Rows(7).Cells(4).Value = ""
                    dtg.Rows(7).Cells(5).Value = ""
                    dtg.Rows(7).Cells(6).Value = ""
                    dtg.Rows(7).Cells(7).Value = ""
                    dtg.Rows(7).Cells(8).Value = ""
                End If
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''8
                dtg.Rows(8).Cells(7).Value = Val(dtg.Rows(8).Cells(3).Value) _
               + Val(dtg.Rows(8).Cells(4).Value) + Val(dtg.Rows(8).Cells(5).Value) _
               + Val(dtg.Rows(8).Cells(6).Value)
                dtg.Rows(8).Cells(7).Value = dtg.Rows(8).Cells(7).Value / 4
                If dtg.Rows(8).Cells(7).Value > 0 _
                And dtg.Rows(8).Cells(7).Value < 75 Then
                    dtg.Rows(8).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(8).Cells(7).Value > 74 _
                And dtg.Rows(8).Cells(7).Value < 101 Then
                    dtg.Rows(8).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(8).Cells(7).Value = 0 Then
                    dtg.Rows(8).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(8).Cells(3).Value = ""
                    dtg.Rows(8).Cells(4).Value = ""
                    dtg.Rows(8).Cells(5).Value = ""
                    dtg.Rows(8).Cells(6).Value = ""
                    dtg.Rows(8).Cells(7).Value = ""
                    dtg.Rows(8).Cells(8).Value = ""
                End If
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''9
                dtg.Rows(9).Cells(7).Value = Val(dtg.Rows(9).Cells(3).Value) _
             + Val(dtg.Rows(9).Cells(4).Value) + Val(dtg.Rows(9).Cells(5).Value) _
             + Val(dtg.Rows(9).Cells(6).Value)
                dtg.Rows(9).Cells(7).Value = dtg.Rows(9).Cells(7).Value / 4
                If dtg.Rows(9).Cells(7).Value > 0 _
                And dtg.Rows(9).Cells(7).Value < 75 Then
                    dtg.Rows(9).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(9).Cells(7).Value > 74 _
                And dtg.Rows(9).Cells(7).Value < 101 Then
                    dtg.Rows(9).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(9).Cells(7).Value = 0 Then
                    dtg.Rows(9).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(9).Cells(3).Value = ""
                    dtg.Rows(9).Cells(4).Value = ""
                    dtg.Rows(9).Cells(5).Value = ""
                    dtg.Rows(9).Cells(6).Value = ""
                    dtg.Rows(9).Cells(7).Value = ""
                    dtg.Rows(9).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''10
                dtg.Rows(10).Cells(7).Value = Val(dtg.Rows(10).Cells(3).Value) _
             + Val(dtg.Rows(10).Cells(4).Value) + Val(dtg.Rows(10).Cells(5).Value) _
             + Val(dtg.Rows(10).Cells(6).Value)
                dtg.Rows(10).Cells(7).Value = dtg.Rows(10).Cells(7).Value / 4
                If dtg.Rows(10).Cells(7).Value > 0 _
                And dtg.Rows(10).Cells(7).Value < 75 Then
                    dtg.Rows(10).Cells(8).Value = "Failed"
                ElseIf dtg.Rows(10).Cells(7).Value > 74 _
                And dtg.Rows(10).Cells(7).Value < 101 Then
                    dtg.Rows(10).Cells(8).Value = "Passed"
                ElseIf dtg.Rows(10).Cells(7).Value = 0 Then
                    dtg.Rows(10).Cells(8).Value = "N/A"
                Else
                    MsgBox("invalid input grades")
                    dtg.Rows(10).Cells(3).Value = ""
                    dtg.Rows(10).Cells(4).Value = ""
                    dtg.Rows(10).Cells(5).Value = ""
                    dtg.Rows(10).Cells(6).Value = ""
                    dtg.Rows(10).Cells(7).Value = ""
                    dtg.Rows(10).Cells(8).Value = ""
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''end
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub computeDTG2(ByVal dtg As DataGridView, ByVal txt As TextBox)
        Try
            Dim tot As Double = 0
            For Each row As DataGridViewRow In dtg.Rows
                tot += CStr(row.Cells(2).Value) / dtg.RowCount

            Next row
            txt.Text = FormatNumber(tot, 1)
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub dtgcompute(ByVal dtg As DataGridView, ByVal txt As TextBox)
        Try
            Dim tot As Double = 0
            For Each row As DataGridViewRow In dtg.Rows
                tot += CStr(row.Cells(7).Value) / dtg.RowCount

            Next row
            txt.Text = FormatNumber(tot, 1)

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub visible_Menu(ByVal result As Boolean)
        With Form1
            .ts_ChangeStatus.Enabled = result
            .ts_Grade.Enabled = result
            .ts_ListStudent.Enabled = result
            .ts_Report.Enabled = result
            .ts_Settings.Enabled = result
            .ts_Student.Enabled = result
            .ts_StudentGrades.Enabled = result
            .ts_StudentSubject.Enabled = result
            .ts_User.Enabled = result
            .ts_Subject.Enabled = result

        End With
    End Sub
End Module
