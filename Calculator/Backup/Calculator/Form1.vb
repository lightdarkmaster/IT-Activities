Option Explicit On

Public Class Form1
    Dim Operand1 As Double
    Dim Operand2 As Double
    Dim [Operator] As String

    Dim hasDecimal As Boolean
    Dim tmpValue As Double


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click
        txtInput.Text = txtInput.Text & sender.text

    End Sub

    Private Sub cmd0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd0.Click
        txtInput.Text = txtInput.Text & sender.text

    End Sub

    Private Sub cmdDecimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDecimal.Click
        If InStr(txtInput.Text, ".") > 0 Then
            Exit Sub
        Else
            txtInput.Text = txtInput.Text & "."
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Operand1 = Val(txtInput.Text)
        txtInput.Text = ""
        txtInput.Focus()
        [Operator] = "+"

    End Sub



    Private Sub cmdSqrtRoot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSqrtRoot.Click
        'Make sure the input box has a value
        If txtInput.Text.Length <> 0 Then
            'Assign our variable the value in the input box
            tmpValue = CType(txtInput.Text, Double)
            'Perform the square root
            tmpValue = System.Math.Sqrt(tmpValue)
            'Display the results in the input box
            txtInput.Text = CType(tmpValue, String)
            'Clear the decimal flag
            hasDecimal = False
        End If

    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Dim Result As Double
        Operand2 = Val(txtInput.Text)

        'If [Operator] = "+" Then
        '    Result = Operand1 + Operand2
        'ElseIf [Operator] = "-" Then
        '    Result = Operand1 - Operand2
        'ElseIf [Operator] = "/" Then
        '    Result = Operand1 / Operand2
        'ElseIf [Operator] = "*" Then
        '    Result = Operand1 * Operand2
        'End If

        Select Case [Operator]
            Case "+"
                Result = Operand1 + Operand2
                txtInput.Text = Result.ToString()
            Case "-"
                Result = Operand1 - Operand2
                txtInput.Text = Result.ToString()
            Case "/"
                Result = Operand1 / Operand2
                txtInput.Text = Result.ToString()
            Case "*"
                Result = Operand1 * Operand2
                txtInput.Text = Result.ToString()
            Case "^"
                Result = Operand1 ^ Operand2
                txtInput.Text = Result.ToString()
            Case "%"
                Result = Operand1 * 1 / 100
                txtInput.Text = Result.ToString()


        End Select

        txtInput.Text = Result.ToString()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Declare locals needed
        Dim str As String
        Dim loc As Integer
        'Make sure the text length is > 1
        If txtInput.Text.Length > 0 Then
            'Get the next to last character
            str = txtInput.Text.Chars(txtInput.Text.Length - 1)
            'Check if its a decimal
            If str = "." Then
                'If it is toggle the hasDecimal flag
            End If
            'Get the length of the string
            loc = txtInput.Text.Length
            'Remove the last character, incrementing by 1
            txtInput.Text = txtInput.Text.Remove(loc - 1, 1)
        End If
    End Sub

    Private Sub cmdOFF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOff.Click

        txtInput.Text = ""

    End Sub

    Private Sub CmdClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClearAll.Click
        txtInput.Text = ""

    End Sub
  

    Private Sub cmd7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd7.Click
        txtInput.Text = txtInput.Text & sender.text

    End Sub

    Private Sub cmd8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd8.Click
        txtInput.Text = txtInput.Text & sender.text

    End Sub

    Private Sub cmd9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd9.Click
        txtInput.Text = txtInput.Text & sender.text

    End Sub

    Private Sub cmd4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd4.Click
        txtInput.Text = txtInput.Text & sender.text

    End Sub

    Private Sub cmd5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd5.Click
        txtInput.Text = txtInput.Text & sender.text


    End Sub

    Private Sub cmd6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd6.Click
        txtInput.Text = txtInput.Text & sender.text

    End Sub

    Private Sub cmd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd2.Click
        txtInput.Text = txtInput.Text & sender.text


    End Sub

    Private Sub cmd3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd3.Click
        txtInput.Text = txtInput.Text & sender.text


    End Sub

    Private Sub cmdDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDivide.Click
        Operand1 = Val(txtInput.Text)
        txtInput.Text = ""
        txtInput.Focus()
        [Operator] = "/"
   
    End Sub

    Private Sub cmdMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMultiply.Click
        Operand1 = Val(txtInput.Text)
        txtInput.Text = ""
        txtInput.Focus()
        [Operator] = "*"
    End Sub

    Private Sub CmdSubstraction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmdsubstraction.Click
        Operand1 = Val(txtInput.Text)
        txtInput.Text = ""
        txtInput.Focus()
        [Operator] = "-"
    End Sub

    Private Sub CmdPowerOF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPowerOF.Click
        Operand1 = Val(txtInput.Text)
        txtInput.Text = ""
        txtInput.Focus()
        [Operator] = "^"
    End Sub
    Private Sub CmdInverse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdInverse.Click
        Dim convert As Single
        If txtInput.Text <> 0 Then
            convert = 1 / Val(txtInput.Text)
            txtInput.Text = convert

        End If
    End Sub

    Private Sub Cmdsign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSign.Click
        txtInput.Text = -1 * txtInput.Text
    End Sub



End Class
