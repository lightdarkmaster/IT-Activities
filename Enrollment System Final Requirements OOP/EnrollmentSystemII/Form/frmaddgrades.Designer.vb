<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmaddgrades
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.lblyear_s_sub = New System.Windows.Forms.Label()
        Me.lblname_s_sub = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnadd_subj = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtsearch_subj_g = New System.Windows.Forms.TextBox()
        Me.btngo_subj_g = New System.Windows.Forms.Button()
        Me.cbosearch_subj_g = New System.Windows.Forms.ComboBox()
        Me.cboyear_ag = New System.Windows.Forms.ComboBox()
        Me.dtgsubj_g = New System.Windows.Forms.DataGridView()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txttotalave = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btncalculate_g = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgsubj_g, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Copperplate Gothic Bold", 20.25!)
        Me.Label5.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label5.Location = New System.Drawing.Point(1137, 193)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 38)
        Me.Label5.TabIndex = 479
        Me.Label5.Text = ":"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Copperplate Gothic Bold", 20.25!)
        Me.Label55.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label55.Location = New System.Drawing.Point(309, 193)
        Me.Label55.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(27, 38)
        Me.Label55.TabIndex = 478
        Me.Label55.Text = ":"
        '
        'lblyear_s_sub
        '
        Me.lblyear_s_sub.AutoSize = True
        Me.lblyear_s_sub.Font = New System.Drawing.Font("Copperplate Gothic Bold", 20.25!)
        Me.lblyear_s_sub.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblyear_s_sub.Location = New System.Drawing.Point(1173, 193)
        Me.lblyear_s_sub.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblyear_s_sub.Name = "lblyear_s_sub"
        Me.lblyear_s_sub.Size = New System.Drawing.Size(0, 38)
        Me.lblyear_s_sub.TabIndex = 477
        '
        'lblname_s_sub
        '
        Me.lblname_s_sub.AutoSize = True
        Me.lblname_s_sub.Font = New System.Drawing.Font("Copperplate Gothic Bold", 20.25!)
        Me.lblname_s_sub.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblname_s_sub.Location = New System.Drawing.Point(345, 193)
        Me.lblname_s_sub.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblname_s_sub.Name = "lblname_s_sub"
        Me.lblname_s_sub.Size = New System.Drawing.Size(0, 38)
        Me.lblname_s_sub.TabIndex = 476
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Bold", 20.25!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(839, 193)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 38)
        Me.Label3.TabIndex = 475
        Me.Label3.Text = "Student Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 20.25!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(15, 193)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 38)
        Me.Label2.TabIndex = 474
        Me.Label2.Text = "Student Name"
        '
        'btnadd_subj
        '
        Me.btnadd_subj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd_subj.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnadd_subj.Location = New System.Drawing.Point(533, 607)
        Me.btnadd_subj.Margin = New System.Windows.Forms.Padding(4)
        Me.btnadd_subj.Name = "btnadd_subj"
        Me.btnadd_subj.Size = New System.Drawing.Size(187, 50)
        Me.btnadd_subj.TabIndex = 473
        Me.btnadd_subj.Text = "Add"
        Me.btnadd_subj.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(754, 607)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(187, 50)
        Me.Button4.TabIndex = 472
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(554, 9)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(289, 63)
        Me.Label4.TabIndex = 471
        Me.Label4.Text = "Add Grades"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtsearch_subj_g)
        Me.Panel1.Controls.Add(Me.btngo_subj_g)
        Me.Panel1.Controls.Add(Me.cbosearch_subj_g)
        Me.Panel1.Controls.Add(Me.cboyear_ag)
        Me.Panel1.Location = New System.Drawing.Point(561, 117)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(804, 54)
        Me.Panel1.TabIndex = 470
        '
        'txtsearch_subj_g
        '
        Me.txtsearch_subj_g.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsearch_subj_g.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch_subj_g.ForeColor = System.Drawing.Color.Black
        Me.txtsearch_subj_g.Location = New System.Drawing.Point(341, 4)
        Me.txtsearch_subj_g.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsearch_subj_g.Multiline = True
        Me.txtsearch_subj_g.Name = "txtsearch_subj_g"
        Me.txtsearch_subj_g.Size = New System.Drawing.Size(270, 46)
        Me.txtsearch_subj_g.TabIndex = 447
        '
        'btngo_subj_g
        '
        Me.btngo_subj_g.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngo_subj_g.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btngo_subj_g.Location = New System.Drawing.Point(612, 2)
        Me.btngo_subj_g.Margin = New System.Windows.Forms.Padding(4)
        Me.btngo_subj_g.Name = "btngo_subj_g"
        Me.btngo_subj_g.Size = New System.Drawing.Size(187, 48)
        Me.btngo_subj_g.TabIndex = 445
        Me.btngo_subj_g.Text = "Search"
        Me.btngo_subj_g.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btngo_subj_g.UseVisualStyleBackColor = True
        '
        'cbosearch_subj_g
        '
        Me.cbosearch_subj_g.BackColor = System.Drawing.SystemColors.Info
        Me.cbosearch_subj_g.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosearch_subj_g.FormattingEnabled = True
        Me.cbosearch_subj_g.Items.AddRange(New Object() {"Student ID", "Student Name", "Student Last Name"})
        Me.cbosearch_subj_g.Location = New System.Drawing.Point(0, 3)
        Me.cbosearch_subj_g.Margin = New System.Windows.Forms.Padding(4)
        Me.cbosearch_subj_g.Name = "cbosearch_subj_g"
        Me.cbosearch_subj_g.Size = New System.Drawing.Size(333, 47)
        Me.cbosearch_subj_g.TabIndex = 446
        Me.cbosearch_subj_g.Text = "Student ID"
        '
        'cboyear_ag
        '
        Me.cboyear_ag.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboyear_ag.FormattingEnabled = True
        Me.cboyear_ag.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.cboyear_ag.Location = New System.Drawing.Point(4, 5)
        Me.cboyear_ag.Margin = New System.Windows.Forms.Padding(4)
        Me.cboyear_ag.Name = "cboyear_ag"
        Me.cboyear_ag.Size = New System.Drawing.Size(236, 45)
        Me.cboyear_ag.TabIndex = 448
        Me.cboyear_ag.Text = "1st Year"
        '
        'dtgsubj_g
        '
        Me.dtgsubj_g.AllowUserToAddRows = False
        Me.dtgsubj_g.AllowUserToDeleteRows = False
        Me.dtgsubj_g.AllowUserToResizeColumns = False
        Me.dtgsubj_g.AllowUserToResizeRows = False
        Me.dtgsubj_g.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgsubj_g.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgsubj_g.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgsubj_g.Location = New System.Drawing.Point(4, 247)
        Me.dtgsubj_g.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgsubj_g.Name = "dtgsubj_g"
        Me.dtgsubj_g.RowHeadersVisible = False
        Me.dtgsubj_g.RowHeadersWidth = 51
        Me.dtgsubj_g.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgsubj_g.Size = New System.Drawing.Size(1361, 299)
        Me.dtgsubj_g.TabIndex = 468
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.TextBox3.Location = New System.Drawing.Point(1213, 554)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(151, 25)
        Me.TextBox3.TabIndex = 482
        '
        'txttotalave
        '
        Me.txttotalave.Enabled = False
        Me.txttotalave.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txttotalave.Location = New System.Drawing.Point(1096, 554)
        Me.txttotalave.Margin = New System.Windows.Forms.Padding(4)
        Me.txttotalave.Name = "txttotalave"
        Me.txttotalave.Size = New System.Drawing.Size(116, 25)
        Me.txttotalave.TabIndex = 481
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.TextBox1.Location = New System.Drawing.Point(4, 554)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1089, 25)
        Me.TextBox1.TabIndex = 480
        Me.TextBox1.Text = "Final Average"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btncalculate_g
        '
        Me.btncalculate_g.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalculate_g.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncalculate_g.Location = New System.Drawing.Point(316, 607)
        Me.btncalculate_g.Margin = New System.Windows.Forms.Padding(4)
        Me.btncalculate_g.Name = "btncalculate_g"
        Me.btncalculate_g.Size = New System.Drawing.Size(187, 50)
        Me.btncalculate_g.TabIndex = 483
        Me.btncalculate_g.Text = "Calculate"
        Me.btncalculate_g.UseVisualStyleBackColor = True
        '
        'frmaddgrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1371, 670)
        Me.Controls.Add(Me.btncalculate_g)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.txttotalave)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.lblyear_s_sub)
        Me.Controls.Add(Me.lblname_s_sub)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnadd_subj)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtgsubj_g)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmaddgrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtgsubj_g, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents lblyear_s_sub As System.Windows.Forms.Label
    Friend WithEvents lblname_s_sub As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnadd_subj As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtsearch_subj_g As System.Windows.Forms.TextBox
    Friend WithEvents btngo_subj_g As System.Windows.Forms.Button
    Friend WithEvents cbosearch_subj_g As System.Windows.Forms.ComboBox
    Friend WithEvents dtgsubj_g As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents txttotalave As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btncalculate_g As System.Windows.Forms.Button
    Friend WithEvents cboyear_ag As System.Windows.Forms.ComboBox
End Class
