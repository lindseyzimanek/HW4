
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'create variables to hold values entered by user
        Dim HourlyWage As Integer = txbxHourlyWage.Text
        Dim HoursWorked As Integer = txbxHoursWorked.Text
        Dim PretaxDeduction As Decimal = txbxPretaxDeductions.Text
        Dim AfterTaxDeduction As Decimal = txbxAfterTaxDeductions.Text
        Dim TaxRate As Decimal
        Dim NetPay As Decimal

        Dim GrossPay As Decimal
        GrossPay = HourlyWage * HoursWorked

        'specify tax conditions
        If GrossPay < 500 Then
            TaxRate = 0.18
        End If

        If GrossPay >= 500 Then
            TaxRate = 0.22
        End If

        'compute net pay
        NetPay = GrossPay - (PretaxDeduction * TaxRate) - (AfterTaxDeduction * TaxRate)

        'display result in results label
        lblResult.Text = "Your estimated net pay for the week is $" & NetPay.ToString("#,###.##")
    End Sub

    Protected Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txbxHourlyWage.Text = ""
        txbxHoursWorked.Text = ""
        txbxPretaxDeductions.Text = ""
        txbxAfterTaxDeductions.Text = ""
        lblResult.Text = ""

    End Sub
End Class
