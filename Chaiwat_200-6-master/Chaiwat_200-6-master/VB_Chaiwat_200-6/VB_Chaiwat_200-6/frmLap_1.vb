Public Class frmLap_1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lblTotal.Text = Val(txtHours.Text) * Val(txtPayRate.Text)
        lblTax.Text = Val(lblTotal.Text) * 0.05
    End Sub

    Private Sub btnCal2_Click(sender As Object, e As EventArgs) Handles btnCal2.Click
        Dim hours As Integer
        Dim payrate, tax, sumMoney As Double

        hours = txtHours.Text
        payrate = txtPayRate.Text

        sumMoney = Val(hours) * Val(payrate)
        tax = Val(sumMoney) * 0.05

        lblTotal.Text = sumMoney.ToString("###,###")
        lblTax.Text = tax.ToString("###,###")
    End Sub
End Class