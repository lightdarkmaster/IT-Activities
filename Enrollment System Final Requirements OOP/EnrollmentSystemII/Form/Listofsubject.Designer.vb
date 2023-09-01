<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listofsubject
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btngo_subj = New System.Windows.Forms.Button()
        Me.cmbsex = New System.Windows.Forms.ComboBox()
        Me.dtglist_s = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dtglist_s, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(564, 558)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(187, 50)
        Me.Button4.TabIndex = 453
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btngo_subj)
        Me.Panel1.Controls.Add(Me.cmbsex)
        Me.Panel1.ForeColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Location = New System.Drawing.Point(843, 66)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(537, 69)
        Me.Panel1.TabIndex = 452
        '
        'btngo_subj
        '
        Me.btngo_subj.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngo_subj.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btngo_subj.Location = New System.Drawing.Point(336, 9)
        Me.btngo_subj.Margin = New System.Windows.Forms.Padding(4)
        Me.btngo_subj.Name = "btngo_subj"
        Me.btngo_subj.Size = New System.Drawing.Size(197, 56)
        Me.btngo_subj.TabIndex = 445
        Me.btngo_subj.Text = "Search"
        Me.btngo_subj.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btngo_subj.UseVisualStyleBackColor = True
        '
        'cmbsex
        '
        Me.cmbsex.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsex.FormattingEnabled = True
        Me.cmbsex.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.cmbsex.Location = New System.Drawing.Point(4, 11)
        Me.cmbsex.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbsex.Name = "cmbsex"
        Me.cmbsex.Size = New System.Drawing.Size(324, 54)
        Me.cmbsex.TabIndex = 446
        Me.cmbsex.Text = "1st Year"
        '
        'dtglist_s
        '
        Me.dtglist_s.AllowUserToAddRows = False
        Me.dtglist_s.AllowUserToDeleteRows = False
        Me.dtglist_s.AllowUserToResizeColumns = False
        Me.dtglist_s.AllowUserToResizeRows = False
        Me.dtglist_s.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtglist_s.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtglist_s.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtglist_s.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtglist_s.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtglist_s.Location = New System.Drawing.Point(8, 155)
        Me.dtglist_s.Margin = New System.Windows.Forms.Padding(4)
        Me.dtglist_s.Name = "dtglist_s"
        Me.dtglist_s.RowHeadersVisible = False
        Me.dtglist_s.RowHeadersWidth = 51
        Me.dtglist_s.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtglist_s.Size = New System.Drawing.Size(1372, 395)
        Me.dtglist_s.TabIndex = 451
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(374, 63)
        Me.Label1.TabIndex = 454
        Me.Label1.Text = "List Of Subjects"
        '
        'Listofsubject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1389, 612)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtglist_s)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Listofsubject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.dtglist_s, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btngo_subj As System.Windows.Forms.Button
    Friend WithEvents cmbsex As System.Windows.Forms.ComboBox
    Friend WithEvents dtglist_s As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
