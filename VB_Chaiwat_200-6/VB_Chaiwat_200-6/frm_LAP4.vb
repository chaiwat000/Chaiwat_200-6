Public Class frm_LAP4
    Private Sub radShortDate_CheckedChanged(sender As Object, e As EventArgs) Handles radShortDate.CheckedChanged
        Dim ShDate As String = Date.Now.ToShortDateString
        lblDate.Text = ShDate
    End Sub

    Private Sub radGenaralDate_CheckedChanged(sender As Object, e As EventArgs) Handles radGenaralDate.CheckedChanged

    End Sub

    Private Sub radLongDate_CheckedChanged(sender As Object, e As EventArgs) Handles radLongDate.CheckedChanged
        Dim LongDate As String = Date.Now.ToLongDateString
        lblDate.Text = LongDate
    End Sub

    Private Sub btnCalTax_Click(sender As Object, e As EventArgs) Handles btnCalTax.Click
        Dim salary, sale, yearSalary, Bonus, allincome, allowance, tax, moneyTotal As Double
        Dim decR_bonus, decR_allow, decR_tax As Decimal
        salary = Val(txtSalary.Text)
        sale = Val(txtSale.Text)

        decR_bonus = 0.2
        decR_allow = 0.01
        decR_tax = 0.07

        yearSalary = salary * 12
        Bonus = sale * decR_bonus
        allincome = yearSalary + Bonus
        allowance = allincome * decR_allow
        moneyTotal = allincome - allowance
        tax = moneyTotal * decR_tax

        lblYearSalary.Text = FormatNumber(yearSalary)
        lblBonus.Text = FormatNumber(Bonus)
        lblAllIncome.Text = FormatNumber(allincome)
        lblAllowance.Text = FormatNumber(allowance)
        lblTax.Text = FormatNumber(tax)
    End Sub

    Private Sub frm_LAP4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim day As String = Now.Date
        lblDate.Text = day
        radGenaralDate.Checked = True
    End Sub
End Class