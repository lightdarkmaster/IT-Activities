<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtQuanti = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.add = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.remove = New System.Windows.Forms.Button()
        Me.change = New System.Windows.Forms.Button()
        Me.compute = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.money = New System.Windows.Forms.TextBox()
        Me.totalAmount = New System.Windows.Forms.TextBox()
        Me.vat = New System.Windows.Forms.TextBox()
        Me.discount = New System.Windows.Forms.TextBox()
        Me.subTotal = New System.Windows.Forms.TextBox()
        Me.Head = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtId
        '
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtId.Location = New System.Drawing.Point(167, 236)
        Me.txtId.Multiline = True
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(359, 34)
        Me.txtId.TabIndex = 0
        '
        'txtQuanti
        '
        Me.txtQuanti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuanti.Location = New System.Drawing.Point(167, 314)
        Me.txtQuanti.Multiline = True
        Me.txtQuanti.Name = "txtQuanti"
        Me.txtQuanti.Size = New System.Drawing.Size(66, 34)
        Me.txtQuanti.TabIndex = 1
        '
        'txtPrice
        '
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.Location = New System.Drawing.Point(336, 313)
        Me.txtPrice.Multiline = True
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(190, 34)
        Me.txtPrice.TabIndex = 2
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalPrice.Location = New System.Drawing.Point(680, 314)
        Me.txtTotalPrice.Multiline = True
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(195, 34)
        Me.txtTotalPrice.TabIndex = 3
        '
        'txtItemName
        '
        Me.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemName.Location = New System.Drawing.Point(167, 419)
        Me.txtItemName.Multiline = True
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(359, 34)
        Me.txtItemName.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(56, 247)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Item ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(46, 324)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(261, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(568, 324)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(27, 430)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Item Name"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(37, 531)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(675, 387)
        Me.DataGridView1.TabIndex = 10
        '
        'Column1
        '
        Me.Column1.HeaderText = "Item Id"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Description"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "QTY"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Price"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Total Price"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'add
        '
        Me.add.BackColor = System.Drawing.Color.Aqua
        Me.add.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.add.Location = New System.Drawing.Point(56, 958)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(131, 40)
        Me.add.TabIndex = 11
        Me.add.Text = "Add"
        Me.add.UseVisualStyleBackColor = False
        '
        'Clear
        '
        Me.Clear.BackColor = System.Drawing.Color.Aqua
        Me.Clear.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Clear.Location = New System.Drawing.Point(568, 958)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(131, 40)
        Me.Clear.TabIndex = 12
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Cornsilk
        Me.GroupBox1.Controls.Add(Me.remove)
        Me.GroupBox1.Controls.Add(Me.change)
        Me.GroupBox1.Controls.Add(Me.compute)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtChange)
        Me.GroupBox1.Controls.Add(Me.money)
        Me.GroupBox1.Controls.Add(Me.totalAmount)
        Me.GroupBox1.Controls.Add(Me.vat)
        Me.GroupBox1.Controls.Add(Me.discount)
        Me.GroupBox1.Controls.Add(Me.subTotal)
        Me.GroupBox1.Location = New System.Drawing.Point(1019, 313)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(556, 730)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'remove
        '
        Me.remove.BackColor = System.Drawing.Color.WhiteSmoke
        Me.remove.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.remove.Location = New System.Drawing.Point(352, 673)
        Me.remove.Name = "remove"
        Me.remove.Size = New System.Drawing.Size(186, 37)
        Me.remove.TabIndex = 17
        Me.remove.Text = "Remove Transactions"
        Me.remove.UseVisualStyleBackColor = False
        '
        'change
        '
        Me.change.BackColor = System.Drawing.Color.WhiteSmoke
        Me.change.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.change.Location = New System.Drawing.Point(225, 673)
        Me.change.Name = "change"
        Me.change.Size = New System.Drawing.Size(96, 37)
        Me.change.TabIndex = 16
        Me.change.Text = "Change"
        Me.change.UseVisualStyleBackColor = False
        '
        'compute
        '
        Me.compute.BackColor = System.Drawing.Color.WhiteSmoke
        Me.compute.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.compute.Location = New System.Drawing.Point(51, 673)
        Me.compute.Name = "compute"
        Me.compute.Size = New System.Drawing.Size(96, 37)
        Me.compute.TabIndex = 15
        Me.compute.Text = "Compute"
        Me.compute.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(127, 582)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 23)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Change"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(51, 474)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(146, 23)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Rendered Money"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(78, 370)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 23)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Total Amount"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(116, 277)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 23)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "12% VAT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(77, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 23)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "10% Discount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(112, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 23)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Sub Total"
        '
        'txtChange
        '
        Me.txtChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChange.Location = New System.Drawing.Point(225, 571)
        Me.txtChange.Multiline = True
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(234, 34)
        Me.txtChange.TabIndex = 5
        '
        'money
        '
        Me.money.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.money.Location = New System.Drawing.Point(225, 463)
        Me.money.Multiline = True
        Me.money.Name = "money"
        Me.money.Size = New System.Drawing.Size(234, 34)
        Me.money.TabIndex = 4
        '
        'totalAmount
        '
        Me.totalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalAmount.Location = New System.Drawing.Point(225, 359)
        Me.totalAmount.Multiline = True
        Me.totalAmount.Name = "totalAmount"
        Me.totalAmount.Size = New System.Drawing.Size(234, 34)
        Me.totalAmount.TabIndex = 3
        '
        'vat
        '
        Me.vat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.vat.Location = New System.Drawing.Point(225, 266)
        Me.vat.Multiline = True
        Me.vat.Name = "vat"
        Me.vat.Size = New System.Drawing.Size(234, 34)
        Me.vat.TabIndex = 2
        '
        'discount
        '
        Me.discount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.discount.Location = New System.Drawing.Point(225, 168)
        Me.discount.Multiline = True
        Me.discount.Name = "discount"
        Me.discount.Size = New System.Drawing.Size(234, 34)
        Me.discount.TabIndex = 1
        '
        'subTotal
        '
        Me.subTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.subTotal.Location = New System.Drawing.Point(225, 69)
        Me.subTotal.Multiline = True
        Me.subTotal.Name = "subTotal"
        Me.subTotal.Size = New System.Drawing.Size(234, 34)
        Me.subTotal.TabIndex = 0
        '
        'Head
        '
        Me.Head.AutoSize = True
        Me.Head.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Head.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Head.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Head.Location = New System.Drawing.Point(624, 61)
        Me.Head.Name = "Head"
        Me.Head.Size = New System.Drawing.Size(407, 99)
        Me.Head.TabIndex = 14
        Me.Head.Text = "Chan's Store"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(1668, 1055)
        Me.Controls.Add(Me.Head)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtQuanti)
        Me.Controls.Add(Me.txtId)
        Me.Name = "Form1"
        Me.Text = "Point of Sale System"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtId As TextBox
    Friend WithEvents txtQuanti As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents add As Button
    Friend WithEvents Clear As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents subTotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtChange As TextBox
    Friend WithEvents money As TextBox
    Friend WithEvents totalAmount As TextBox
    Friend WithEvents vat As TextBox
    Friend WithEvents discount As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Head As Label
    Friend WithEvents remove As Button
    Friend WithEvents change As Button
    Friend WithEvents compute As Button
End Class
