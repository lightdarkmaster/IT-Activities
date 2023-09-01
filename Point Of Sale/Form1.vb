Imports Class1
Public Class Form1

    Public idname() As String = {}
    Public iname() As String = {}
    Public quantity() As Integer = {}
    Public iprice() As Double = {}
    Public itotal() As Double = {}

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtTotalPrice.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles add.Click
        Dim id As Integer = txtId.Text
        Dim Description As String = txtItemName.Text
        Dim qty As Integer = txtQuanti.Text
        Dim price As Double = txtPrice.Text
        txtTotalPrice.Text = Val(qty) * Val(price)
        Dim tprice As Double = txtTotalPrice.Text


        Array.Resize(idname, idname.Length + 1)
        idname(idname.Length - 1) = id

        Array.Resize(iname, iname.Length + 1)
        idname(idname.Length - 1) = Description

        Array.Resize(quantity, quantity.Length + 1)
        idname(idname.Length - 1) = qty

        Array.Resize(iprice, iprice.Length + 1)
        idname(idname.Length - 1) = price

        Array.Resize(itotal, itotal.Length + 1)
        idname(idname.Length - 1) = tprice

        DataGridView1.Rows.Add(id, Description, qty, price, tprice)
        MsgBox("Added Successfully")

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles subTotal.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        txtId.Text = ""
        txtPrice.Clear()
        txtQuanti.Clear()
        txtTotalPrice.Clear()
        txtItemName.Clear()

    End Sub

    Private Sub change_Click(sender As Object, e As EventArgs) Handles change.Click
        txtChange.Text = Val(money.Text) - Val(totalAmount.Text)
    End Sub

    Private Sub compute_Click(sender As Object, e As EventArgs) Handles compute.Click
        Dim sum As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            sum = sum + DataGridView1.Rows(i).Cells(4).Value
        Next
        subTotal.Text = sum.ToString()
        discount.Text = Val(subTotal.Text) * 10 / 100
        vat.Text = Val(subTotal.Text) * 12 / 100
        totalAmount.Text = Val(subTotal.Text) - (Val(discount.Text) + Val(vat.Text))
    End Sub

    Private Sub remove_Click(sender As Object, e As EventArgs) Handles remove.Click
        For Each transaction As DataGridViewRow In DataGridView1.SelectedRows
            MessageBox.Show("Are you sure you want to delete transactions? ", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            DataGridView1.Rows.Remove(transaction)
        Next
    End Sub
End Class
