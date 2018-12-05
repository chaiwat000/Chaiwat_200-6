Public Class Frm_LAP1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim txtNum As Double = txtSalary.Text
        Dim num1 As Double
        Dim num2 As Double
        Dim num3 As Double

        num1 = txtNum * 12
        num2 = num1 * 0.05
        num3 = num1 - num2

        lblMoneyYear.Text += "  =  " + num1.ToString("###,###,###,###") + "  บาท"
        lblTax.Text += "  =  " + num2.ToString("###,###,###,###") + "  บาท"
        lblTotal.Text += "  =  " + num3.ToString("###,###,###,###") + "  บาท"
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
