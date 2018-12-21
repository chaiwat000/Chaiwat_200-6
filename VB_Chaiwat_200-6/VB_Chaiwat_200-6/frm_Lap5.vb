Public Class frm_Lap5
    Dim nPro As String
    Dim price, unit, discount, total, totalPrice, totalDiscount As Double

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        price = Val(txtPrice.Text)
        unit = Val(txtUnit.Text)

        total = price * unit
        lblTotal.Text = total
    End Sub

    Private Sub btnCalculater_Click(sender As Object, e As EventArgs) Handles btnCalculater.Click
        nPro = txtProduct.Text
        If txtProduct.Text = "" Or txtPrice.Text = "" Or txtUnit.Text = "" Or txtPrice.Text = "0" Or txtUnit.Text = "0" Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์", "ทำรายการไม่สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            If radMember.Checked = True Then
                If radCash.Checked = True Then
                    If total < 1000 Then
                        discount = 0
                        totalPrice = total

                    ElseIf total < 5000 Then
                        discount = 0.05
                        totalDiscount = total * discount
                        totalPrice = total - totalDiscount
                    ElseIf total < 10000 Then
                        discount = 0.1
                        totalDiscount = total * discount
                        totalPrice = total - totalDiscount
                    Else
                        discount = 0.15
                        totalDiscount = total * discount
                        totalPrice = total - totalDiscount
                    End If

                    lblTotal.Text = FormatNumber(total)
                    lblDiscount.Text = FormatNumber(totalDiscount)
                    lblPaide.Text = FormatNumber(totalPrice)
                    lblCredit.Text = "ไม่มียอดค้างเพราะจ่ายเป็นเงินสด"

                ElseIf radCredit.Checked = True Then
                    lblDiscount.Text = "ไม่มีส่วนลด"
                    lblPaide.Text = FormatNumber(total)
                    lblCredit.Text = FormatNumber(total)
                End If

            ElseIf radOther.Checked = True Then
                lblPaide.Text = FormatNumber(total)
                lblDiscount.Text = "ไม่มีสิทธิส่วนลด"
                lblCredit.Text = "ไม่มีสิทธิจ่ายเป็นเงินเชื่อ"
            End If

        End If
    End Sub

    Private Sub radMember_CheckedChanged(sender As Object, e As EventArgs) Handles radMember.CheckedChanged
        If radMember.Checked = True Then
            gpMoney.Enabled = True
        End If
    End Sub

    Private Sub radOther_CheckedChanged(sender As Object, e As EventArgs) Handles radOther.CheckedChanged
        If radOther.Checked = True Then
            gpMoney.Enabled = False
            radCash.Checked = True
        End If
    End Sub

    Private Sub txtUnit_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged
        price = Val(txtPrice.Text)
        unit = Val(txtUnit.Text)

        total = price * unit
        lblTotal.Text = total
    End Sub
End Class