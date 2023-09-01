Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmCalculator
	Inherits System.Windows.Forms.Form
	
	Private mdblResult As Double
	Private mdblSavedNumber As Double
	Private mstrDot As String
	Private mstrOp As String
	Private mstrDisplay As String
	Private mblnDecEntered As Boolean
	Private mblnOpPending As Boolean
	Private mblnNewEquals As Boolean
	Private mblnEqualsPressed As Boolean
	Private mintCurrKeyIndex As Short
	
	Private Sub frmCalculator_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Height)) / 2)
		Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Width)) / 2)
		
	End Sub
	
	
	Private Sub frmCalculator_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		
		Dim intIndex As Short
		
		Select Case KeyCode
			Case System.Windows.Forms.Keys.Back : intIndex = 0
			Case System.Windows.Forms.Keys.Delete : intIndex = 1
			Case System.Windows.Forms.Keys.Escape : intIndex = 2
			Case System.Windows.Forms.Keys.D0, System.Windows.Forms.Keys.NumPad0 : intIndex = 18
			Case System.Windows.Forms.Keys.D1, System.Windows.Forms.Keys.NumPad1 : intIndex = 13
			Case System.Windows.Forms.Keys.D2, System.Windows.Forms.Keys.NumPad2 : intIndex = 14
			Case System.Windows.Forms.Keys.D3, System.Windows.Forms.Keys.NumPad3 : intIndex = 15
			Case System.Windows.Forms.Keys.D4, System.Windows.Forms.Keys.NumPad4 : intIndex = 8
			Case System.Windows.Forms.Keys.D5, System.Windows.Forms.Keys.NumPad5 : intIndex = 9
			Case System.Windows.Forms.Keys.D6, System.Windows.Forms.Keys.NumPad6 : intIndex = 10
			Case System.Windows.Forms.Keys.D7, System.Windows.Forms.Keys.NumPad7 : intIndex = 3
			Case System.Windows.Forms.Keys.D8, System.Windows.Forms.Keys.NumPad8 : intIndex = 4
			Case System.Windows.Forms.Keys.D9, System.Windows.Forms.Keys.NumPad9 : intIndex = 5
			Case System.Windows.Forms.Keys.Decimal : intIndex = 20
			Case System.Windows.Forms.Keys.Add : intIndex = 21
			Case System.Windows.Forms.Keys.Subtract : intIndex = 16
			Case System.Windows.Forms.Keys.Multiply : intIndex = 11
			Case System.Windows.Forms.Keys.Divide : intIndex = 6
			Case Else : Exit Sub
		End Select
		
		cmdCalc(intIndex).Focus()
		cmdCalc_Click(cmdCalc.Item(intIndex), New System.EventArgs())
		
	End Sub
	
	
	Private Sub frmCalculator_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		
		Dim intIndex As Short
		
		Select Case Chr(KeyAscii)
			Case "S", "s" : intIndex = 7
			Case "P", "p" : intIndex = 12
			Case "R", "r" : intIndex = 17
			Case "X", "x" : intIndex = 11
			Case "=" : intIndex = 22
			Case Else : GoTo EventExitSub
		End Select
		
		cmdCalc(intIndex).Focus()
		cmdCalc_Click(cmdCalc.Item(intIndex), New System.EventArgs())
		
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cmdCalc_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCalc.Click
		Dim Index As Short = cmdCalc.GetIndex(eventSender)
		
		Dim strPressedKey As String
		
		mintCurrKeyIndex = Index
		
		If mstrDisplay = "ERROR" Then
			mstrDisplay = ""
		End If
		
		strPressedKey = cmdCalc(Index).Text
		
		Select Case strPressedKey
			Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
				If mblnOpPending Then
					mstrDisplay = ""
					mblnOpPending = False
				End If
				If mblnEqualsPressed Then
					mstrDisplay = ""
					mblnEqualsPressed = False
				End If
				mstrDisplay = mstrDisplay & strPressedKey
			Case "."
				If mblnOpPending Then
					mstrDisplay = ""
					mblnOpPending = False
				End If
				If mblnEqualsPressed Then
					mstrDisplay = ""
					mblnEqualsPressed = False
				End If
				If InStr(mstrDisplay, ".") > 0 Then
					Beep()
				Else
					mstrDisplay = mstrDisplay & strPressedKey
				End If
			Case "+", "-", "X", "/"
				mdblResult = Val(mstrDisplay)
				mstrOp = strPressedKey
				mblnOpPending = True
				mblnDecEntered = False
				mblnNewEquals = True
			Case "%"
				mdblSavedNumber = (Val(mstrDisplay) / 100) * mdblResult
				mstrDisplay = VB6.Format(mdblSavedNumber)
			Case "="
				If mblnNewEquals Then
					mdblSavedNumber = Val(mstrDisplay)
					mblnNewEquals = False
				End If
				Select Case mstrOp
					Case "+"
						mdblResult = mdblResult + mdblSavedNumber
					Case "-"
						mdblResult = mdblResult - mdblSavedNumber
					Case "X"
						mdblResult = mdblResult * mdblSavedNumber
					Case "/"
						If mdblSavedNumber = 0 Then
							mstrDisplay = "ERROR"
						Else
							mdblResult = mdblResult / mdblSavedNumber
						End If
					Case Else
						mdblResult = Val(mstrDisplay)
				End Select
				If mstrDisplay <> "ERROR" Then
					mstrDisplay = VB6.Format(mdblResult)
				End If
				mblnEqualsPressed = True
			Case "+/-"
				If mstrDisplay <> "" Then
					If VB.Left(mstrDisplay, 1) = "-" Then
						mstrDisplay = VB.Right(mstrDisplay, 2)
					Else
						mstrDisplay = "-" & mstrDisplay
					End If
				End If
			Case "Backspace"
				If Val(mstrDisplay) <> 0 Then
					mstrDisplay = VB.Left(mstrDisplay, Len(mstrDisplay) - 1)
					mdblResult = Val(mstrDisplay)
				End If
			Case "CE"
				mstrDisplay = ""
			Case "C"
				mstrDisplay = ""
				mdblResult = 0
				mdblSavedNumber = 0
			Case "1/x"
				If Val(mstrDisplay) = 0 Then
					mstrDisplay = "ERROR"
				Else
					mdblResult = Val(mstrDisplay)
					mdblResult = 1 / mdblResult
					mstrDisplay = VB6.Format(mdblResult)
				End If
			Case "sqrt"
				If Val(mstrDisplay) < 0 Then
					mstrDisplay = "ERROR"
				Else
					mdblResult = Val(mstrDisplay)
					mdblResult = System.Math.Sqrt(mdblResult)
					mstrDisplay = VB6.Format(mdblResult)
				End If
		End Select
		
		If mstrDisplay = "" Then
			lblDisplay.Text = "0."
		Else
			mstrDot = IIf(InStr(mstrDisplay, ".") > 0, "", ".")
			lblDisplay.Text = mstrDisplay & mstrDot
			If VB.Left(lblDisplay.Text, 1) = "0" Then
				lblDisplay.Text = Mid(lblDisplay.Text, 2)
			End If
		End If
		
		If lblDisplay.Text = "." Then lblDisplay.Text = "0."
		
	End Sub
End Class