Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declaring variables
        Dim dPricePerUnit As Decimal
        Dim dQuantity As Decimal
        Dim dDiscountPerUnit As Decimal
        Dim dDiscoutedAmount As Decimal
        Dim dVAT As Decimal
        Dim dTotalAmountExVAT As Decimal
        Dim dTotalAmountIncVAT As Decimal

        dPricePerUnit = 10
        dQuantity = 10
        dDiscountPerUnit = 2
        dVAT = 0.15
        dDiscoutedAmount = dDiscountPerUnit * dQuantity
        dTotalAmountExVAT = (dPricePerUnit * dQuantity) - dDiscoutedAmount
        dTotalAmountIncVAT = (dTotalAmountExVAT * dVAT) + dTotalAmountExVAT

        'Print the Vat excluded amount
        MessageBox.Show("Total Exc. VAT:" & " " & dTotalAmountExVAT)

        'Print the Vat included amount
        MessageBox.Show("Total Inc. VAT:" & " " & dTotalAmountIncVAT)
    End Sub
End Class
