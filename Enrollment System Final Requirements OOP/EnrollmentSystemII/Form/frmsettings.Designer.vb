<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsettings
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
        Me.btnexit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnpayment = New System.Windows.Forms.Button()
        Me.btnaddgrades = New System.Windows.Forms.Button()
        Me.Txtsubjectid_as = New System.Windows.Forms.TextBox()
        Me.pnlsy = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnaddyear = New System.Windows.Forms.Button()
        Me.txtyear = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtaddsy = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnsysave = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblyearid_check = New System.Windows.Forms.Label()
        Me.lblsyid = New System.Windows.Forms.Label()
        Me.lblyearrid = New System.Windows.Forms.Label()
        Me.txtear = New System.Windows.Forms.TextBox()
        Me.lblsyid_check = New System.Windows.Forms.Label()
        Me.txtsy = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.pnladdsubj = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtsubjname_ascheck = New System.Windows.Forms.TextBox()
        Me.lblsubjectid_as = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtsubj_id_search = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnsubjadd_as = New System.Windows.Forms.Button()
        Me.cbosubjunit_as = New System.Windows.Forms.ComboBox()
        Me.cbosubjsy_as = New System.Windows.Forms.ComboBox()
        Me.txttime_subj = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbosubjyear_as = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdesc_as = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsubjname_as = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.pnlsy.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pnladdsubj.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Copperplate Gothic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnexit.Location = New System.Drawing.Point(4, 459)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(180, 86)
        Me.btnexit.TabIndex = 3
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnexit)
        Me.Panel2.Controls.Add(Me.btnpayment)
        Me.Panel2.Controls.Add(Me.btnaddgrades)
        Me.Panel2.Controls.Add(Me.Txtsubjectid_as)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(196, 695)
        Me.Panel2.TabIndex = 27
        '
        'btnpayment
        '
        Me.btnpayment.Font = New System.Drawing.Font("Copperplate Gothic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnpayment.Location = New System.Drawing.Point(8, 96)
        Me.btnpayment.Margin = New System.Windows.Forms.Padding(4)
        Me.btnpayment.Name = "btnpayment"
        Me.btnpayment.Size = New System.Drawing.Size(180, 114)
        Me.btnpayment.TabIndex = 1
        Me.btnpayment.Text = "Add Sy and Year"
        Me.btnpayment.UseVisualStyleBackColor = True
        '
        'btnaddgrades
        '
        Me.btnaddgrades.Font = New System.Drawing.Font("Copperplate Gothic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddgrades.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnaddgrades.Location = New System.Drawing.Point(8, 6)
        Me.btnaddgrades.Margin = New System.Windows.Forms.Padding(4)
        Me.btnaddgrades.Name = "btnaddgrades"
        Me.btnaddgrades.Size = New System.Drawing.Size(180, 86)
        Me.btnaddgrades.TabIndex = 0
        Me.btnaddgrades.Text = "Add Subject"
        Me.btnaddgrades.UseVisualStyleBackColor = True
        '
        'Txtsubjectid_as
        '
        Me.Txtsubjectid_as.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtsubjectid_as.Location = New System.Drawing.Point(101, 494)
        Me.Txtsubjectid_as.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtsubjectid_as.Name = "Txtsubjectid_as"
        Me.Txtsubjectid_as.Size = New System.Drawing.Size(12, 25)
        Me.Txtsubjectid_as.TabIndex = 433
        '
        'pnlsy
        '
        Me.pnlsy.Controls.Add(Me.GroupBox2)
        Me.pnlsy.Controls.Add(Me.GroupBox1)
        Me.pnlsy.Controls.Add(Me.Panel4)
        Me.pnlsy.Location = New System.Drawing.Point(204, 206)
        Me.pnlsy.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlsy.Name = "pnlsy"
        Me.pnlsy.Size = New System.Drawing.Size(99, 101)
        Me.pnlsy.TabIndex = 452
        Me.pnlsy.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnaddyear)
        Me.GroupBox2.Controls.Add(Me.txtyear)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkCyan
        Me.GroupBox2.Location = New System.Drawing.Point(-260, 84)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(359, 17)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add Year"
        '
        'btnaddyear
        '
        Me.btnaddyear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddyear.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnaddyear.Location = New System.Drawing.Point(104, 214)
        Me.btnaddyear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnaddyear.Name = "btnaddyear"
        Me.btnaddyear.Size = New System.Drawing.Size(143, 38)
        Me.btnaddyear.TabIndex = 10
        Me.btnaddyear.Text = "Save"
        Me.btnaddyear.UseVisualStyleBackColor = True
        '
        'txtyear
        '
        Me.txtyear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtyear.ForeColor = System.Drawing.Color.DarkCyan
        Me.txtyear.Location = New System.Drawing.Point(104, 137)
        Me.txtyear.Margin = New System.Windows.Forms.Padding(4)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.Size = New System.Drawing.Size(148, 30)
        Me.txtyear.TabIndex = 8
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label18.Location = New System.Drawing.Point(149, 90)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 25)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Year :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtaddsy)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.btnsysave)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkCyan
        Me.GroupBox1.Location = New System.Drawing.Point(0, 84)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(324, 17)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add School Year"
        '
        'txtaddsy
        '
        Me.txtaddsy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddsy.ForeColor = System.Drawing.Color.DarkCyan
        Me.txtaddsy.Location = New System.Drawing.Point(75, 133)
        Me.txtaddsy.Margin = New System.Windows.Forms.Padding(4)
        Me.txtaddsy.Name = "txtaddsy"
        Me.txtaddsy.Size = New System.Drawing.Size(148, 30)
        Me.txtaddsy.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label16.Location = New System.Drawing.Point(68, 90)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(143, 25)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "School Year :"
        '
        'btnsysave
        '
        Me.btnsysave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsysave.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnsysave.Location = New System.Drawing.Point(75, 214)
        Me.btnsysave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsysave.Name = "btnsysave"
        Me.btnsysave.Size = New System.Drawing.Size(143, 38)
        Me.btnsysave.TabIndex = 10
        Me.btnsysave.Text = "Save"
        Me.btnsysave.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel4.Controls.Add(Me.lblyearid_check)
        Me.Panel4.Controls.Add(Me.lblsyid)
        Me.Panel4.Controls.Add(Me.lblyearrid)
        Me.Panel4.Controls.Add(Me.txtear)
        Me.Panel4.Controls.Add(Me.lblsyid_check)
        Me.Panel4.Controls.Add(Me.txtsy)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(99, 84)
        Me.Panel4.TabIndex = 6
        '
        'lblyearid_check
        '
        Me.lblyearid_check.AutoSize = True
        Me.lblyearid_check.Location = New System.Drawing.Point(200, 33)
        Me.lblyearid_check.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblyearid_check.Name = "lblyearid_check"
        Me.lblyearid_check.Size = New System.Drawing.Size(59, 17)
        Me.lblyearid_check.TabIndex = 9
        Me.lblyearid_check.Text = "Label19"
        '
        'lblsyid
        '
        Me.lblsyid.AutoSize = True
        Me.lblsyid.Location = New System.Drawing.Point(200, 33)
        Me.lblsyid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsyid.Name = "lblsyid"
        Me.lblsyid.Size = New System.Drawing.Size(59, 17)
        Me.lblsyid.TabIndex = 8
        Me.lblsyid.Text = "Label19"
        '
        'lblyearrid
        '
        Me.lblyearrid.AutoSize = True
        Me.lblyearrid.Location = New System.Drawing.Point(188, 30)
        Me.lblyearrid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblyearrid.Name = "lblyearrid"
        Me.lblyearrid.Size = New System.Drawing.Size(59, 17)
        Me.lblyearrid.TabIndex = 5
        Me.lblyearrid.Text = "Label19"
        '
        'txtear
        '
        Me.txtear.Location = New System.Drawing.Point(140, 30)
        Me.txtear.Margin = New System.Windows.Forms.Padding(4)
        Me.txtear.Name = "txtear"
        Me.txtear.Size = New System.Drawing.Size(132, 22)
        Me.txtear.TabIndex = 7
        '
        'lblsyid_check
        '
        Me.lblsyid_check.AutoSize = True
        Me.lblsyid_check.Location = New System.Drawing.Point(188, 33)
        Me.lblsyid_check.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsyid_check.Name = "lblsyid_check"
        Me.lblsyid_check.Size = New System.Drawing.Size(59, 17)
        Me.lblsyid_check.TabIndex = 10
        Me.lblsyid_check.Text = "Label20"
        '
        'txtsy
        '
        Me.txtsy.Location = New System.Drawing.Point(140, 30)
        Me.txtsy.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsy.Name = "txtsy"
        Me.txtsy.Size = New System.Drawing.Size(132, 22)
        Me.txtsy.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Arial", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(204, 570)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(355, 49)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Subject Enrolled"
        '
        'pnladdsubj
        '
        Me.pnladdsubj.Controls.Add(Me.Panel3)
        Me.pnladdsubj.Controls.Add(Me.Label15)
        Me.pnladdsubj.Controls.Add(Me.txtsubj_id_search)
        Me.pnladdsubj.Controls.Add(Me.Label7)
        Me.pnladdsubj.Controls.Add(Me.Label14)
        Me.pnladdsubj.Controls.Add(Me.btnsubjadd_as)
        Me.pnladdsubj.Controls.Add(Me.cbosubjunit_as)
        Me.pnladdsubj.Controls.Add(Me.cbosubjsy_as)
        Me.pnladdsubj.Controls.Add(Me.txttime_subj)
        Me.pnladdsubj.Controls.Add(Me.Label13)
        Me.pnladdsubj.Controls.Add(Me.Label12)
        Me.pnladdsubj.Controls.Add(Me.Label11)
        Me.pnladdsubj.Controls.Add(Me.Label10)
        Me.pnladdsubj.Controls.Add(Me.Label9)
        Me.pnladdsubj.Controls.Add(Me.Label6)
        Me.pnladdsubj.Controls.Add(Me.cbosubjyear_as)
        Me.pnladdsubj.Controls.Add(Me.Label4)
        Me.pnladdsubj.Controls.Add(Me.Label3)
        Me.pnladdsubj.Controls.Add(Me.txtdesc_as)
        Me.pnladdsubj.Controls.Add(Me.Label5)
        Me.pnladdsubj.Controls.Add(Me.Label2)
        Me.pnladdsubj.Controls.Add(Me.Label1)
        Me.pnladdsubj.Controls.Add(Me.txtsubjname_as)
        Me.pnladdsubj.Location = New System.Drawing.Point(204, 96)
        Me.pnladdsubj.Margin = New System.Windows.Forms.Padding(4)
        Me.pnladdsubj.Name = "pnladdsubj"
        Me.pnladdsubj.Size = New System.Drawing.Size(99, 84)
        Me.pnladdsubj.TabIndex = 31
        Me.pnladdsubj.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtsubjname_ascheck)
        Me.Panel3.Controls.Add(Me.lblsubjectid_as)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(99, 74)
        Me.Panel3.TabIndex = 451
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Copperplate Gothic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(185, 16)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(254, 38)
        Me.Label8.TabIndex = 472
        Me.Label8.Text = "Add Subject"
        '
        'txtsubjname_ascheck
        '
        Me.txtsubjname_ascheck.Location = New System.Drawing.Point(263, 23)
        Me.txtsubjname_ascheck.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsubjname_ascheck.Name = "txtsubjname_ascheck"
        Me.txtsubjname_ascheck.Size = New System.Drawing.Size(132, 22)
        Me.txtsubjname_ascheck.TabIndex = 474
        '
        'lblsubjectid_as
        '
        Me.lblsubjectid_as.AutoSize = True
        Me.lblsubjectid_as.Location = New System.Drawing.Point(291, 27)
        Me.lblsubjectid_as.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsubjectid_as.Name = "lblsubjectid_as"
        Me.lblsubjectid_as.Size = New System.Drawing.Size(59, 17)
        Me.lblsubjectid_as.TabIndex = 473
        Me.lblsubjectid_as.Text = "Label19"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(372, 87)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 17)
        Me.Label15.TabIndex = 459
        Me.Label15.Text = "Search subj.id"
        '
        'txtsubj_id_search
        '
        Me.txtsubj_id_search.Location = New System.Drawing.Point(495, 85)
        Me.txtsubj_id_search.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsubj_id_search.Name = "txtsubj_id_search"
        Me.txtsubj_id_search.Size = New System.Drawing.Size(132, 22)
        Me.txtsubj_id_search.TabIndex = 458
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(171, 393)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(12, 17)
        Me.Label7.TabIndex = 457
        Me.Label7.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(40, 353)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 17)
        Me.Label14.TabIndex = 456
        Me.Label14.Text = "Time"
        '
        'btnsubjadd_as
        '
        Me.btnsubjadd_as.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubjadd_as.Location = New System.Drawing.Point(192, 418)
        Me.btnsubjadd_as.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsubjadd_as.Name = "btnsubjadd_as"
        Me.btnsubjadd_as.Size = New System.Drawing.Size(100, 28)
        Me.btnsubjadd_as.TabIndex = 455
        Me.btnsubjadd_as.Text = "Add"
        Me.btnsubjadd_as.UseVisualStyleBackColor = True
        '
        'cbosubjunit_as
        '
        Me.cbosubjunit_as.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosubjunit_as.FormattingEnabled = True
        Me.cbosubjunit_as.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cbosubjunit_as.Location = New System.Drawing.Point(192, 383)
        Me.cbosubjunit_as.Margin = New System.Windows.Forms.Padding(4)
        Me.cbosubjunit_as.Name = "cbosubjunit_as"
        Me.cbosubjunit_as.Size = New System.Drawing.Size(67, 25)
        Me.cbosubjunit_as.TabIndex = 454
        '
        'cbosubjsy_as
        '
        Me.cbosubjsy_as.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosubjsy_as.FormattingEnabled = True
        Me.cbosubjsy_as.Location = New System.Drawing.Point(495, 123)
        Me.cbosubjsy_as.Margin = New System.Windows.Forms.Padding(4)
        Me.cbosubjsy_as.Name = "cbosubjsy_as"
        Me.cbosubjsy_as.Size = New System.Drawing.Size(160, 25)
        Me.cbosubjsy_as.TabIndex = 453
        '
        'txttime_subj
        '
        Me.txttime_subj.Location = New System.Drawing.Point(192, 351)
        Me.txttime_subj.Margin = New System.Windows.Forms.Padding(4)
        Me.txttime_subj.Name = "txttime_subj"
        Me.txttime_subj.Size = New System.Drawing.Size(109, 22)
        Me.txttime_subj.TabIndex = 452
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(473, 127)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(12, 17)
        Me.Label13.TabIndex = 450
        Me.Label13.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(171, 351)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(12, 17)
        Me.Label12.TabIndex = 449
        Me.Label12.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(171, 319)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(12, 17)
        Me.Label11.TabIndex = 448
        Me.Label11.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(171, 246)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(12, 17)
        Me.Label10.TabIndex = 447
        Me.Label10.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(171, 214)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(12, 17)
        Me.Label9.TabIndex = 446
        Me.Label9.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(39, 250)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 17)
        Me.Label6.TabIndex = 444
        Me.Label6.Text = "Description"
        '
        'cbosubjyear_as
        '
        Me.cbosubjyear_as.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosubjyear_as.FormattingEnabled = True
        Me.cbosubjyear_as.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.cbosubjyear_as.Location = New System.Drawing.Point(192, 315)
        Me.cbosubjyear_as.Margin = New System.Windows.Forms.Padding(4)
        Me.cbosubjyear_as.Name = "cbosubjyear_as"
        Me.cbosubjyear_as.Size = New System.Drawing.Size(129, 25)
        Me.cbosubjyear_as.TabIndex = 441
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 319)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 440
        Me.Label4.Text = "year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 386)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 17)
        Me.Label3.TabIndex = 439
        Me.Label3.Text = "Unit"
        '
        'txtdesc_as
        '
        Me.txtdesc_as.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesc_as.Location = New System.Drawing.Point(192, 242)
        Me.txtdesc_as.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdesc_as.Multiline = True
        Me.txtdesc_as.Name = "txtdesc_as"
        Me.txtdesc_as.Size = New System.Drawing.Size(279, 64)
        Me.txtdesc_as.TabIndex = 438
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(368, 127)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 17)
        Me.Label5.TabIndex = 437
        Me.Label5.Text = "School Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 214)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 436
        Me.Label2.Text = "Subject Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 182)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 435
        Me.Label1.Text = "Subject Id"
        '
        'txtsubjname_as
        '
        Me.txtsubjname_as.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubjname_as.Location = New System.Drawing.Point(192, 210)
        Me.txtsubjname_as.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsubjname_as.Name = "txtsubjname_as"
        Me.txtsubjname_as.Size = New System.Drawing.Size(185, 25)
        Me.txtsubjname_as.TabIndex = 434
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(239, 96)
        Me.Label55.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(12, 17)
        Me.Label55.TabIndex = 445
        Me.Label55.Text = ":"
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label19.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(196, 0)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(700, 86)
        Me.Label19.TabIndex = 453
        Me.Label19.Text = "Settings"
        '
        'frmsettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(896, 695)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.pnladdsubj)
        Me.Controls.Add(Me.pnlsy)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label55)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmsettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlsy.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.pnladdsubj.ResumeLayout(False)
        Me.pnladdsubj.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnpayment As System.Windows.Forms.Button
    Friend WithEvents btnaddgrades As System.Windows.Forms.Button
    Friend WithEvents pnlsy As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtaddsy As System.Windows.Forms.TextBox
    Friend WithEvents pnladdsubj As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbosubjyear_as As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdesc_as As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsubjname_as As System.Windows.Forms.TextBox
    Friend WithEvents Txtsubjectid_as As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnsubjadd_as As System.Windows.Forms.Button
    Friend WithEvents cbosubjunit_as As System.Windows.Forms.ComboBox
    Friend WithEvents cbosubjsy_as As System.Windows.Forms.ComboBox
    Friend WithEvents txttime_subj As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtsubj_id_search As System.Windows.Forms.TextBox
    Friend WithEvents btnsysave As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtyear As System.Windows.Forms.TextBox
    Friend WithEvents lblyearrid As System.Windows.Forms.Label
    Friend WithEvents txtear As System.Windows.Forms.TextBox
    Friend WithEvents txtsy As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnaddyear As System.Windows.Forms.Button
    Friend WithEvents lblsyid As System.Windows.Forms.Label
    Friend WithEvents lblsyid_check As System.Windows.Forms.Label
    Friend WithEvents lblyearid_check As System.Windows.Forms.Label
    Friend WithEvents lblsubjectid_as As System.Windows.Forms.Label
    Friend WithEvents txtsubjname_ascheck As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
End Class
