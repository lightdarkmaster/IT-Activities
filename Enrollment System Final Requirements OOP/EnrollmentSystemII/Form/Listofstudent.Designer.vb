<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listofstudent
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
        Me.dtglist_s = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbostatus_l = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnaddstudent_l = New System.Windows.Forms.Button()
        Me.btnsearch_l = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        CType(Me.dtglist_s, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.dtglist_s.Location = New System.Drawing.Point(16, 126)
        Me.dtglist_s.Margin = New System.Windows.Forms.Padding(4)
        Me.dtglist_s.Name = "dtglist_s"
        Me.dtglist_s.RowHeadersVisible = False
        Me.dtglist_s.RowHeadersWidth = 51
        Me.dtglist_s.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtglist_s.Size = New System.Drawing.Size(1357, 430)
        Me.dtglist_s.TabIndex = 443
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 63)
        Me.Label1.TabIndex = 444
        Me.Label1.Text = "List Of Student"
        '
        'cbostatus_l
        '
        Me.cbostatus_l.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbostatus_l.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbostatus_l.FormattingEnabled = True
        Me.cbostatus_l.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.cbostatus_l.Location = New System.Drawing.Point(964, 65)
        Me.cbostatus_l.Margin = New System.Windows.Forms.Padding(4)
        Me.cbostatus_l.Name = "cbostatus_l"
        Me.cbostatus_l.Size = New System.Drawing.Size(233, 38)
        Me.cbostatus_l.TabIndex = 445
        Me.cbostatus_l.Text = "1st Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(836, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 34)
        Me.Label2.TabIndex = 447
        Me.Label2.Text = "Year :"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(784, 564)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(187, 50)
        Me.Button4.TabIndex = 449
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnaddstudent_l
        '
        Me.btnaddstudent_l.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddstudent_l.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnaddstudent_l.Location = New System.Drawing.Point(560, 564)
        Me.btnaddstudent_l.Margin = New System.Windows.Forms.Padding(4)
        Me.btnaddstudent_l.Name = "btnaddstudent_l"
        Me.btnaddstudent_l.Size = New System.Drawing.Size(187, 50)
        Me.btnaddstudent_l.TabIndex = 450
        Me.btnaddstudent_l.Text = "Add"
        Me.btnaddstudent_l.UseVisualStyleBackColor = True
        '
        'btnsearch_l
        '
        Me.btnsearch_l.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch_l.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsearch_l.Location = New System.Drawing.Point(1207, 62)
        Me.btnsearch_l.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsearch_l.Name = "btnsearch_l"
        Me.btnsearch_l.Size = New System.Drawing.Size(167, 44)
        Me.btnsearch_l.TabIndex = 446
        Me.btnsearch_l.Text = "Search"
        Me.btnsearch_l.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsearch_l.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_edit.Location = New System.Drawing.Point(342, 562)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(187, 50)
        Me.btn_edit.TabIndex = 451
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'Listofstudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1389, 620)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btnaddstudent_l)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnsearch_l)
        Me.Controls.Add(Me.cbostatus_l)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtglist_s)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Listofstudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dtglist_s, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtglist_s As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnsearch_l As System.Windows.Forms.Button
    Friend WithEvents cbostatus_l As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnaddstudent_l As System.Windows.Forms.Button
    Friend WithEvents btn_edit As Button
End Class
