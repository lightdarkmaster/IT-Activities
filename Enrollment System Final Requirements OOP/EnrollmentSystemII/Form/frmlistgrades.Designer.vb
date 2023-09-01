<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlistgrades
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnsearch_gl = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtglist_gl = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbosearch_subj_gl = New System.Windows.Forms.ComboBox()
        Me.cboyear_lsg = New System.Windows.Forms.ComboBox()
        Me.txtsearch_subj_gl = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.lblyear_s_sub = New System.Windows.Forms.Label()
        Me.lblname_s_sub = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dtglist_gl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(533, 591)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(187, 50)
        Me.Button4.TabIndex = 458
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnsearch_gl
        '
        Me.btnsearch_gl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch_gl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsearch_gl.Location = New System.Drawing.Point(612, 5)
        Me.btnsearch_gl.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsearch_gl.Name = "btnsearch_gl"
        Me.btnsearch_gl.Size = New System.Drawing.Size(165, 49)
        Me.btnsearch_gl.TabIndex = 456
        Me.btnsearch_gl.Text = "Search"
        Me.btnsearch_gl.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsearch_gl.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(-3, -2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(530, 63)
        Me.Label1.TabIndex = 454
        Me.Label1.Text = "List Of Student Grades"
        '
        'dtglist_gl
        '
        Me.dtglist_gl.AllowUserToAddRows = False
        Me.dtglist_gl.AllowUserToDeleteRows = False
        Me.dtglist_gl.AllowUserToResizeColumns = False
        Me.dtglist_gl.AllowUserToResizeRows = False
        Me.dtglist_gl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtglist_gl.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtglist_gl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtglist_gl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtglist_gl.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtglist_gl.Location = New System.Drawing.Point(4, 246)
        Me.dtglist_gl.Margin = New System.Windows.Forms.Padding(4)
        Me.dtglist_gl.Name = "dtglist_gl"
        Me.dtglist_gl.RowHeadersVisible = False
        Me.dtglist_gl.RowHeadersWidth = 51
        Me.dtglist_gl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtglist_gl.Size = New System.Drawing.Size(1317, 337)
        Me.dtglist_gl.TabIndex = 453
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cbosearch_subj_gl)
        Me.Panel1.Controls.Add(Me.cboyear_lsg)
        Me.Panel1.Controls.Add(Me.txtsearch_subj_gl)
        Me.Panel1.Controls.Add(Me.btnsearch_gl)
        Me.Panel1.Location = New System.Drawing.Point(533, 100)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(781, 59)
        Me.Panel1.TabIndex = 471
        '
        'cbosearch_subj_gl
        '
        Me.cbosearch_subj_gl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosearch_subj_gl.FormattingEnabled = True
        Me.cbosearch_subj_gl.Items.AddRange(New Object() {"Student ID", "Student Name", "Student Last Name", "Student Year"})
        Me.cbosearch_subj_gl.Location = New System.Drawing.Point(4, 5)
        Me.cbosearch_subj_gl.Margin = New System.Windows.Forms.Padding(4)
        Me.cbosearch_subj_gl.Name = "cbosearch_subj_gl"
        Me.cbosearch_subj_gl.Size = New System.Drawing.Size(333, 47)
        Me.cbosearch_subj_gl.TabIndex = 446
        Me.cbosearch_subj_gl.Text = "Student ID"
        '
        'cboyear_lsg
        '
        Me.cboyear_lsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboyear_lsg.FormattingEnabled = True
        Me.cboyear_lsg.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.cboyear_lsg.Location = New System.Drawing.Point(72, 9)
        Me.cboyear_lsg.Margin = New System.Windows.Forms.Padding(4)
        Me.cboyear_lsg.Name = "cboyear_lsg"
        Me.cboyear_lsg.Size = New System.Drawing.Size(265, 44)
        Me.cboyear_lsg.TabIndex = 450
        Me.cboyear_lsg.Text = "1st Year"
        '
        'txtsearch_subj_gl
        '
        Me.txtsearch_subj_gl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsearch_subj_gl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch_subj_gl.ForeColor = System.Drawing.Color.Black
        Me.txtsearch_subj_gl.Location = New System.Drawing.Point(340, 6)
        Me.txtsearch_subj_gl.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsearch_subj_gl.Multiline = True
        Me.txtsearch_subj_gl.Name = "txtsearch_subj_gl"
        Me.txtsearch_subj_gl.Size = New System.Drawing.Size(270, 48)
        Me.txtsearch_subj_gl.TabIndex = 447
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Copperplate Gothic Bold", 20.25!)
        Me.Label5.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label5.Location = New System.Drawing.Point(1059, 188)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 38)
        Me.Label5.TabIndex = 477
        Me.Label5.Text = ":"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Copperplate Gothic Bold", 20.25!)
        Me.Label55.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label55.Location = New System.Drawing.Point(308, 188)
        Me.Label55.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(27, 38)
        Me.Label55.TabIndex = 476
        Me.Label55.Text = ":"
        '
        'lblyear_s_sub
        '
        Me.lblyear_s_sub.AutoSize = True
        Me.lblyear_s_sub.Font = New System.Drawing.Font("Copperplate Gothic Bold", 20.25!)
        Me.lblyear_s_sub.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblyear_s_sub.Location = New System.Drawing.Point(1095, 188)
        Me.lblyear_s_sub.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblyear_s_sub.Name = "lblyear_s_sub"
        Me.lblyear_s_sub.Size = New System.Drawing.Size(0, 38)
        Me.lblyear_s_sub.TabIndex = 475
        '
        'lblname_s_sub
        '
        Me.lblname_s_sub.AutoSize = True
        Me.lblname_s_sub.Font = New System.Drawing.Font("Copperplate Gothic Bold", 20.25!)
        Me.lblname_s_sub.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblname_s_sub.Location = New System.Drawing.Point(344, 188)
        Me.lblname_s_sub.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblname_s_sub.Name = "lblname_s_sub"
        Me.lblname_s_sub.Size = New System.Drawing.Size(0, 38)
        Me.lblname_s_sub.TabIndex = 474
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Bold", 20.25!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(760, 188)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 38)
        Me.Label3.TabIndex = 473
        Me.Label3.Text = "Student Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 20.25!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(5, 188)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 38)
        Me.Label2.TabIndex = 472
        Me.Label2.Text = "Student Name"
        '
        'frmlistgrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1331, 649)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.lblyear_s_sub)
        Me.Controls.Add(Me.lblname_s_sub)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtglist_gl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmlistgrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dtglist_gl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnsearch_gl As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtglist_gl As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtsearch_subj_gl As System.Windows.Forms.TextBox
    Friend WithEvents cbosearch_subj_gl As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents lblyear_s_sub As System.Windows.Forms.Label
    Friend WithEvents lblname_s_sub As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboyear_lsg As System.Windows.Forms.ComboBox
End Class
