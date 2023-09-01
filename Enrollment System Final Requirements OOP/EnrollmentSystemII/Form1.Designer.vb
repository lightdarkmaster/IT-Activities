<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ts_Student = New System.Windows.Forms.ToolStripButton()
        Me.ts_ListStudent = New System.Windows.Forms.ToolStripButton()
        Me.ts_ChangeStatus = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_Subject = New System.Windows.Forms.ToolStripButton()
        Me.ts_StudentSubject = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_Grade = New System.Windows.Forms.ToolStripButton()
        Me.ts_StudentGrades = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_Report = New System.Windows.Forms.ToolStripButton()
        Me.ts_User = New System.Windows.Forms.ToolStripButton()
        Me.ts_Settings = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_Login = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_Student, Me.ts_ListStudent, Me.ts_ChangeStatus, Me.ToolStripSeparator1, Me.ts_Subject, Me.ts_StudentSubject, Me.ToolStripSeparator2, Me.ts_Grade, Me.ts_StudentGrades, Me.ToolStripSeparator3, Me.ts_Report, Me.ts_User, Me.ts_Settings, Me.ToolStripSeparator4, Me.ts_Login})
        Me.ToolStrip1.Location = New System.Drawing.Point(547, 9)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(411, 37)
        Me.ToolStrip1.TabIndex = 23
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ts_Student
        '
        Me.ts_Student.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_Student.Image = CType(resources.GetObject("ts_Student.Image"), System.Drawing.Image)
        Me.ts_Student.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Student.Name = "ts_Student"
        Me.ts_Student.Size = New System.Drawing.Size(34, 34)
        Me.ts_Student.Text = "Add Student"
        '
        'ts_ListStudent
        '
        Me.ts_ListStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_ListStudent.Image = CType(resources.GetObject("ts_ListStudent.Image"), System.Drawing.Image)
        Me.ts_ListStudent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_ListStudent.Name = "ts_ListStudent"
        Me.ts_ListStudent.Size = New System.Drawing.Size(34, 34)
        Me.ts_ListStudent.Text = "List of Student"
        '
        'ts_ChangeStatus
        '
        Me.ts_ChangeStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_ChangeStatus.Image = CType(resources.GetObject("ts_ChangeStatus.Image"), System.Drawing.Image)
        Me.ts_ChangeStatus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_ChangeStatus.Name = "ts_ChangeStatus"
        Me.ts_ChangeStatus.Size = New System.Drawing.Size(34, 34)
        Me.ts_ChangeStatus.Text = "Change Status"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 37)
        '
        'ts_Subject
        '
        Me.ts_Subject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_Subject.Image = CType(resources.GetObject("ts_Subject.Image"), System.Drawing.Image)
        Me.ts_Subject.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Subject.Name = "ts_Subject"
        Me.ts_Subject.Size = New System.Drawing.Size(34, 34)
        Me.ts_Subject.Text = "Subject"
        '
        'ts_StudentSubject
        '
        Me.ts_StudentSubject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_StudentSubject.Image = CType(resources.GetObject("ts_StudentSubject.Image"), System.Drawing.Image)
        Me.ts_StudentSubject.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_StudentSubject.Name = "ts_StudentSubject"
        Me.ts_StudentSubject.Size = New System.Drawing.Size(34, 34)
        Me.ts_StudentSubject.Text = "Student Subject"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 37)
        '
        'ts_Grade
        '
        Me.ts_Grade.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_Grade.Image = CType(resources.GetObject("ts_Grade.Image"), System.Drawing.Image)
        Me.ts_Grade.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Grade.Name = "ts_Grade"
        Me.ts_Grade.Size = New System.Drawing.Size(34, 34)
        Me.ts_Grade.Text = "ToolStripButton1"
        '
        'ts_StudentGrades
        '
        Me.ts_StudentGrades.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_StudentGrades.Image = CType(resources.GetObject("ts_StudentGrades.Image"), System.Drawing.Image)
        Me.ts_StudentGrades.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_StudentGrades.Name = "ts_StudentGrades"
        Me.ts_StudentGrades.Size = New System.Drawing.Size(34, 34)
        Me.ts_StudentGrades.Text = "Student Grades"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 37)
        '
        'ts_Report
        '
        Me.ts_Report.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_Report.Image = CType(resources.GetObject("ts_Report.Image"), System.Drawing.Image)
        Me.ts_Report.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Report.Name = "ts_Report"
        Me.ts_Report.Size = New System.Drawing.Size(34, 34)
        Me.ts_Report.Text = "Report"
        '
        'ts_User
        '
        Me.ts_User.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_User.Image = CType(resources.GetObject("ts_User.Image"), System.Drawing.Image)
        Me.ts_User.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_User.Name = "ts_User"
        Me.ts_User.Size = New System.Drawing.Size(34, 34)
        Me.ts_User.Text = "Manage Users"
        '
        'ts_Settings
        '
        Me.ts_Settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_Settings.Image = CType(resources.GetObject("ts_Settings.Image"), System.Drawing.Image)
        Me.ts_Settings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Settings.Name = "ts_Settings"
        Me.ts_Settings.Size = New System.Drawing.Size(34, 34)
        Me.ts_Settings.Text = "Settings"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 37)
        '
        'ts_Login
        '
        Me.ts_Login.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_Login.Image = Global.EnrollmentSystemII.My.Resources.Resources.lock
        Me.ts_Login.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Login.Name = "ts_Login"
        Me.ts_Login.Size = New System.Drawing.Size(34, 34)
        Me.ts_Login.Text = "Login"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 488)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "By:  Christian Barbosa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 521)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Jovert Espino"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(460, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(568, 32)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Sta. Fe Central School Enrollmet System"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.ErrorImage = Global.EnrollmentSystemII.My.Resources.Resources.iStock_000021647930_Medium
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(255, 113)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(923, 546)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1343, 718)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "="
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ts_Subject As ToolStripButton
    Friend WithEvents ts_Grade As ToolStripButton
    Friend WithEvents ts_Report As ToolStripButton
    Friend WithEvents ts_User As ToolStripButton
    Friend WithEvents ts_Settings As ToolStripButton
    Friend WithEvents ts_ListStudent As ToolStripButton
    Friend WithEvents ts_ChangeStatus As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ts_StudentSubject As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ts_StudentGrades As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ts_Login As ToolStripButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ts_Student As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
