Public Class frm_LAP6

    Private Sub frm_LAP6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbEquipment.Enabled = False
        gbFree.Enabled = False
    End Sub

    Private Sub chkItemAdd3_Click(sender As Object, e As EventArgs) Handles chkItemAdd3.Click

        If chkItemAdd3.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblItemPrice3.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblItemPrice3.Text)
        End If


    End Sub

    Private Sub chkItemAdd4_Click(sender As Object, e As EventArgs) Handles chkItemAdd4.Click

        If chkItemAdd4.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblItemPrice4.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblItemPrice4.Text)
        End If


    End Sub

    Private Sub chkCarForMe_Click(sender As Object, e As EventArgs) Handles chkCarForMe.Click
        If chkCarForMe.Checked = True Then
            lblStarPrice.Text = 1250000
            lblPaidPrice.Text = 1325000

            gbEquipment.Enabled = True
            gbFree.Enabled = True
        Else
            Dim result As DialogResult
            result = MessageBox.Show("ต้องการยกเลิกการเลือกหรือไม่", "ออกจากการคำนวณ", MessageBoxButtons.YesNo, MessageBoxIcon.Error)


            If result = DialogResult.Yes Then
                chkItemAdd1.Checked = False
                chkItemAdd2.Checked = False
                chkItemAdd3.Checked = False
                chkItemAdd4.Checked = False
                lblPaidPrice.Text = ""
                gbEquipment.Enabled = False
                gbFree.Enabled = False
            Else
                chkCarForMe.Checked = True
            End If


        End If
    End Sub

    Private Sub chkItemAdd1_Click(sender As Object, e As EventArgs) Handles chkItemAdd1.Click

        If chkItemAdd1.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblItemPrice1.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblItemPrice1.Text)

        End If


    End Sub

    Private Sub chkItemAdd2_Click(sender As Object, e As EventArgs) Handles chkItemAdd2.Click

        If chkItemAdd2.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblItemPrice2.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblItemPrice2.Text)
        End If

    End Sub

    Private Sub chkFree1_Click(sender As Object, e As EventArgs) Handles chkFree1.Click
        If chkFree1.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblFree1.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblFree1.Text)
        End If
    End Sub

    Private Sub chkFree2_Click(sender As Object, e As EventArgs) Handles chkFree2.Click
        If chkFree2.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblFree2.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblFree2.Text)
        End If
    End Sub

    Private Sub chkFree3_Click(sender As Object, e As EventArgs) Handles chkFree3.Click
        If chkFree3.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblFree3.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblFree3.Text)
        End If
    End Sub
End Class