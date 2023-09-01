<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtInput = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.CmdOff = New System.Windows.Forms.Button
        Me.CmdClearAll = New System.Windows.Forms.Button
        Me.cmd7 = New System.Windows.Forms.Button
        Me.cmd8 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button23 = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdDecimal = New System.Windows.Forms.Button
        Me.cmdSign = New System.Windows.Forms.Button
        Me.cmd0 = New System.Windows.Forms.Button
        Me.CmdInverse = New System.Windows.Forms.Button
        Me.Cmdsubstraction = New System.Windows.Forms.Button
        Me.cmdSqrtRoot = New System.Windows.Forms.Button
        Me.cmd2 = New System.Windows.Forms.Button
        Me.cmd3 = New System.Windows.Forms.Button
        Me.cmd1 = New System.Windows.Forms.Button
        Me.cmdMultiply = New System.Windows.Forms.Button
        Me.cmd6 = New System.Windows.Forms.Button
        Me.cmd5 = New System.Windows.Forms.Button
        Me.CmdPowerOF = New System.Windows.Forms.Button
        Me.cmd4 = New System.Windows.Forms.Button
        Me.cmdDivide = New System.Windows.Forms.Button
        Me.cmd9 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtInput.Location = New System.Drawing.Point(4, 17)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.ReadOnly = True
        Me.txtInput.Size = New System.Drawing.Size(208, 20)
        Me.txtInput.TabIndex = 0
        Me.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtInput)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(218, 43)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(20, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 22)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "BackSpace"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CmdOff
        '
        Me.CmdOff.Location = New System.Drawing.Point(163, 18)
        Me.CmdOff.Name = "CmdOff"
        Me.CmdOff.Size = New System.Drawing.Size(55, 23)
        Me.CmdOff.TabIndex = 3
        Me.CmdOff.Text = "OFF"
        Me.CmdOff.UseVisualStyleBackColor = True
        '
        'CmdClearAll
        '
        Me.CmdClearAll.Location = New System.Drawing.Point(109, 19)
        Me.CmdClearAll.Name = "CmdClearAll"
        Me.CmdClearAll.Size = New System.Drawing.Size(42, 23)
        Me.CmdClearAll.TabIndex = 4
        Me.CmdClearAll.Text = "C"
        Me.CmdClearAll.UseVisualStyleBackColor = True
        '
        'cmd7
        '
        Me.cmd7.Location = New System.Drawing.Point(20, 57)
        Me.cmd7.Name = "cmd7"
        Me.cmd7.Size = New System.Drawing.Size(30, 23)
        Me.cmd7.TabIndex = 5
        Me.cmd7.Text = "7"
        Me.cmd7.UseVisualStyleBackColor = True
        '
        'cmd8
        '
        Me.cmd8.Location = New System.Drawing.Point(56, 57)
        Me.cmd8.Name = "cmd8"
        Me.cmd8.Size = New System.Drawing.Size(34, 23)
        Me.cmd8.TabIndex = 6
        Me.cmd8.Text = "8"
        Me.cmd8.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button23)
        Me.GroupBox2.Controls.Add(Me.cmdAdd)
        Me.GroupBox2.Controls.Add(Me.cmdDecimal)
        Me.GroupBox2.Controls.Add(Me.cmdSign)
        Me.GroupBox2.Controls.Add(Me.cmd0)
        Me.GroupBox2.Controls.Add(Me.CmdInverse)
        Me.GroupBox2.Controls.Add(Me.Cmdsubstraction)
        Me.GroupBox2.Controls.Add(Me.cmdSqrtRoot)
        Me.GroupBox2.Controls.Add(Me.cmd2)
        Me.GroupBox2.Controls.Add(Me.cmd3)
        Me.GroupBox2.Controls.Add(Me.cmd1)
        Me.GroupBox2.Controls.Add(Me.cmdMultiply)
        Me.GroupBox2.Controls.Add(Me.cmd6)
        Me.GroupBox2.Controls.Add(Me.cmd5)
        Me.GroupBox2.Controls.Add(Me.CmdPowerOF)
        Me.GroupBox2.Controls.Add(Me.cmd4)
        Me.GroupBox2.Controls.Add(Me.cmdDivide)
        Me.GroupBox2.Controls.Add(Me.cmd9)
        Me.GroupBox2.Controls.Add(Me.cmd8)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.CmdOff)
        Me.GroupBox2.Controls.Add(Me.CmdClearAll)
        Me.GroupBox2.Controls.Add(Me.cmd7)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(218, 180)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'Button23
        '
        Me.Button23.Location = New System.Drawing.Point(177, 144)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(35, 23)
        Me.Button23.TabIndex = 24
        Me.Button23.Text = "="
        Me.Button23.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(137, 144)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(34, 23)
        Me.cmdAdd.TabIndex = 23
        Me.cmdAdd.Text = "+"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdDecimal
        '
        Me.cmdDecimal.Location = New System.Drawing.Point(96, 144)
        Me.cmdDecimal.Name = "cmdDecimal"
        Me.cmdDecimal.Size = New System.Drawing.Size(35, 23)
        Me.cmdDecimal.TabIndex = 22
        Me.cmdDecimal.Text = "."
        Me.cmdDecimal.UseVisualStyleBackColor = True
        '
        'cmdSign
        '
        Me.cmdSign.Location = New System.Drawing.Point(56, 144)
        Me.cmdSign.Name = "cmdSign"
        Me.cmdSign.Size = New System.Drawing.Size(34, 23)
        Me.cmdSign.TabIndex = 21
        Me.cmdSign.Text = "+/-"
        Me.cmdSign.UseVisualStyleBackColor = True
        '
        'cmd0
        '
        Me.cmd0.Location = New System.Drawing.Point(20, 144)
        Me.cmd0.Name = "cmd0"
        Me.cmd0.Size = New System.Drawing.Size(30, 23)
        Me.cmd0.TabIndex = 20
        Me.cmd0.Text = "0"
        Me.cmd0.UseVisualStyleBackColor = True
        '
        'CmdInverse
        '
        Me.CmdInverse.Location = New System.Drawing.Point(177, 115)
        Me.CmdInverse.Name = "CmdInverse"
        Me.CmdInverse.Size = New System.Drawing.Size(35, 23)
        Me.CmdInverse.TabIndex = 19
        Me.CmdInverse.Text = "1/x"
        Me.CmdInverse.UseVisualStyleBackColor = True
        '
        'Cmdsubstraction
        '
        Me.Cmdsubstraction.Location = New System.Drawing.Point(137, 115)
        Me.Cmdsubstraction.Name = "Cmdsubstraction"
        Me.Cmdsubstraction.Size = New System.Drawing.Size(34, 23)
        Me.Cmdsubstraction.TabIndex = 18
        Me.Cmdsubstraction.Text = "-"
        Me.Cmdsubstraction.UseVisualStyleBackColor = True
        '
        'cmdSqrtRoot
        '
        Me.cmdSqrtRoot.Location = New System.Drawing.Point(177, 86)
        Me.cmdSqrtRoot.Name = "cmdSqrtRoot"
        Me.cmdSqrtRoot.Size = New System.Drawing.Size(35, 23)
        Me.cmdSqrtRoot.TabIndex = 17
        Me.cmdSqrtRoot.Text = "Sqrt"
        Me.cmdSqrtRoot.UseVisualStyleBackColor = True
        '
        'cmd2
        '
        Me.cmd2.Location = New System.Drawing.Point(56, 115)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(34, 23)
        Me.cmd2.TabIndex = 16
        Me.cmd2.Text = "2"
        Me.cmd2.UseVisualStyleBackColor = True
        '
        'cmd3
        '
        Me.cmd3.Location = New System.Drawing.Point(96, 115)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(35, 23)
        Me.cmd3.TabIndex = 15
        Me.cmd3.Text = "3"
        Me.cmd3.UseVisualStyleBackColor = True
        '
        'cmd1
        '
        Me.cmd1.Location = New System.Drawing.Point(20, 115)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(30, 23)
        Me.cmd1.TabIndex = 14
        Me.cmd1.Text = "1"
        Me.cmd1.UseVisualStyleBackColor = True
        '
        'cmdMultiply
        '
        Me.cmdMultiply.Location = New System.Drawing.Point(137, 86)
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.Size = New System.Drawing.Size(34, 23)
        Me.cmdMultiply.TabIndex = 13
        Me.cmdMultiply.Text = "*"
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'cmd6
        '
        Me.cmd6.Location = New System.Drawing.Point(96, 86)
        Me.cmd6.Name = "cmd6"
        Me.cmd6.Size = New System.Drawing.Size(35, 23)
        Me.cmd6.TabIndex = 12
        Me.cmd6.Text = "6"
        Me.cmd6.UseVisualStyleBackColor = True
        '
        'cmd5
        '
        Me.cmd5.Location = New System.Drawing.Point(56, 86)
        Me.cmd5.Name = "cmd5"
        Me.cmd5.Size = New System.Drawing.Size(34, 23)
        Me.cmd5.TabIndex = 11
        Me.cmd5.Text = "5"
        Me.cmd5.UseVisualStyleBackColor = True
        '
        'CmdPowerOF
        '
        Me.CmdPowerOF.Location = New System.Drawing.Point(177, 57)
        Me.CmdPowerOF.Name = "CmdPowerOF"
        Me.CmdPowerOF.Size = New System.Drawing.Size(35, 23)
        Me.CmdPowerOF.TabIndex = 9
        Me.CmdPowerOF.Text = "x^"
        Me.CmdPowerOF.UseVisualStyleBackColor = True
        '
        'cmd4
        '
        Me.cmd4.Location = New System.Drawing.Point(20, 86)
        Me.cmd4.Name = "cmd4"
        Me.cmd4.Size = New System.Drawing.Size(30, 23)
        Me.cmd4.TabIndex = 10
        Me.cmd4.Text = "4"
        Me.cmd4.UseVisualStyleBackColor = True
        '
        'cmdDivide
        '
        Me.cmdDivide.Location = New System.Drawing.Point(137, 57)
        Me.cmdDivide.Name = "cmdDivide"
        Me.cmdDivide.Size = New System.Drawing.Size(34, 23)
        Me.cmdDivide.TabIndex = 8
        Me.cmdDivide.Text = "/"
        Me.cmdDivide.UseVisualStyleBackColor = True
        '
        'cmd9
        '
        Me.cmd9.Location = New System.Drawing.Point(96, 57)
        Me.cmd9.Name = "cmd9"
        Me.cmd9.Size = New System.Drawing.Size(35, 23)
        Me.cmd9.TabIndex = 7
        Me.cmd9.Text = "9"
        Me.cmd9.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 252)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CmdOff As System.Windows.Forms.Button
    Friend WithEvents CmdClearAll As System.Windows.Forms.Button
    Friend WithEvents cmd7 As System.Windows.Forms.Button
    Friend WithEvents cmd8 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd0 As System.Windows.Forms.Button
    Friend WithEvents CmdInverse As System.Windows.Forms.Button
    Friend WithEvents Cmdsubstraction As System.Windows.Forms.Button
    Friend WithEvents cmd2 As System.Windows.Forms.Button
    Friend WithEvents cmd3 As System.Windows.Forms.Button
    Friend WithEvents cmd1 As System.Windows.Forms.Button
    Friend WithEvents cmdMultiply As System.Windows.Forms.Button
    Friend WithEvents cmd6 As System.Windows.Forms.Button
    Friend WithEvents cmd5 As System.Windows.Forms.Button
    Friend WithEvents cmd4 As System.Windows.Forms.Button
    Friend WithEvents cmdDivide As System.Windows.Forms.Button
    Friend WithEvents cmd9 As System.Windows.Forms.Button
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdDecimal As System.Windows.Forms.Button
    Friend WithEvents cmdSign As System.Windows.Forms.Button
    Friend WithEvents cmdSqrtRoot As System.Windows.Forms.Button
    Friend WithEvents CmdPowerOF As System.Windows.Forms.Button

End Class
