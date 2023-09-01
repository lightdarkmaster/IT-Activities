Friend Class Class1
    Dim id As Integer = txtId.Text
    Dim Description As String = txtItemName.Text
    Dim qty As Integer = txtQuanti.Text
    Dim price As Double = txtPrice.Text
        txtTotalPrice.Text = Val(qty) * Val(price)
        Dim tprice As Double = txtTotalPrice.Text
End Class
