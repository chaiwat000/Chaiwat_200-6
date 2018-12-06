Public Class Frm_LAP1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim salary As Double = txtSalary.Text
        Dim salaryYear, tax, total As Double


        salaryYear = Val(salary) * 12
        tax = Val(salaryYear) * 0.05
        total = Val(salaryYear) - tax

        lblMoneyYear.Text += "  =  " + salaryYear.ToString("###,###,###,###") + "  บาท"
        lblTax.Text += "  =  " + tax.ToString("###,###,###,###") + "  บาท"
        lblTotal.Text += "  =  " + total.ToString("###,###,###,###") + "  บาท"
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
