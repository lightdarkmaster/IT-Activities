<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboyear_report = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnfailed_rep = New System.Windows.Forms.Button
        Me.btntransfer_rep = New System.Windows.Forms.Button
        Me.btndrop_rep = New System.Windows.Forms.Button
        Me.dtnlistst_rep_ = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cboyear_report)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnfailed_rep)
        Me.Panel1.Controls.Add(Me.btntransfer_rep)
        Me.Panel1.Controls.Add(Me.btndrop_rep)
        Me.Panel1.Controls.Add(Me.dtnlistst_rep_)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(232, 531)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Search for the Year of the Students"
        '
        'cboyear_report
        '
        Me.cboyear_report.FormattingEnabled = True
        Me.cboyear_report.Location = New System.Drawing.Point(30, 87)
        Me.cboyear_report.Name = "cboyear_report"
        Me.cboyear_report.Size = New System.Drawing.Size(158, 21)
        Me.cboyear_report.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnfailed_rep
        '
        Me.btnfailed_rep.Location = New System.Drawing.Point(30, 219)
        Me.btnfailed_rep.Name = "btnfailed_rep"
        Me.btnfailed_rep.Size = New System.Drawing.Size(158, 29)
        Me.btnfailed_rep.TabIndex = 8
        Me.btnfailed_rep.Text = "Failed Student"
        Me.btnfailed_rep.UseVisualStyleBackColor = True
        '
        'btntransfer_rep
        '
        Me.btntransfer_rep.Location = New System.Drawing.Point(30, 184)
        Me.btntransfer_rep.Name = "btntransfer_rep"
        Me.btntransfer_rep.Size = New System.Drawing.Size(158, 29)
        Me.btntransfer_rep.TabIndex = 7
        Me.btntransfer_rep.Text = "Transferee Student"
        Me.btntransfer_rep.UseVisualStyleBackColor = True
        '
        'btndrop_rep
        '
        Me.btndrop_rep.Location = New System.Drawing.Point(30, 149)
        Me.btndrop_rep.Name = "btndrop_rep"
        Me.btndrop_rep.Size = New System.Drawing.Size(158, 29)
        Me.btndrop_rep.TabIndex = 6
        Me.btndrop_rep.Text = "Drop Student"
        Me.btndrop_rep.UseVisualStyleBackColor = True
        '
        'dtnlistst_rep_
        '
        Me.dtnlistst_rep_.Location = New System.Drawing.Point(30, 114)
        Me.dtnlistst_rep_.Name = "dtnlistst_rep_"
        Me.dtnlistst_rep_.Size = New System.Drawing.Size(158, 29)
        Me.dtnlistst_rep_.TabIndex = 0
        Me.dtnlistst_rep_.Text = "Student List"
        Me.dtnlistst_rep_.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.CrystalReportViewer1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(232, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(822, 531)
        Me.Panel2.TabIndex = 1
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(820, 529)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "If combobox is clear mean's all the student"
        '
        'reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 531)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "reports"
        Me.Text = "reports"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtnlistst_rep_ As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnfailed_rep As System.Windows.Forms.Button
    Friend WithEvents btntransfer_rep As System.Windows.Forms.Button
    Friend WithEvents btndrop_rep As System.Windows.Forms.Button
    Friend WithEvents cboyear_report As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
