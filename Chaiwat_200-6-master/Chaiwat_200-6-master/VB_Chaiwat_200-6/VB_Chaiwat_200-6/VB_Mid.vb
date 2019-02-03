Public Class VB_Mid
    Private Sub radMoter_CheckedChanged(sender As Object, e As EventArgs) Handles radMoter.CheckedChanged
        If radMoter.Checked Then
            lblCar.Text = radMoter.Text
            lblStart.Text = 20
        End If
    End Sub

    Private Sub radBigcar_CheckedChanged(sender As Object, e As EventArgs) Handles radBigcar.CheckedChanged
        If radBigcar.Checked Then
            lblCar.Text = radBigcar.Text
            lblStart.Text = 50
        End If

    End Sub

    Private Sub radSmallcar_CheckedChanged(sender As Object, e As EventArgs) Handles radSmallcar.CheckedChanged
        If radSmallcar.Checked Then
            lblCar.Text = radSmallcar.Text
            lblStart.Text = 50
        End If

    End Sub

    Private Sub radSUV_CheckedChanged(sender As Object, e As EventArgs) Handles radSUV.CheckedChanged
        If radSUV.Checked Then
            lblCar.Text = radSUV.Text
            lblStart.Text = 50
        End If
    End Sub

    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        If txtDistance.Text.Trim() = "" Or Not IsNumeric(Val(txtDistance.Text)) Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Call CalPriceDistance()
    End Sub

    Private Sub CalPriceDistance()
        Dim distance As Decimal = Val(txtDistance.Text)
        Dim PriceDistance, netDistance, OptionCar, Price As Decimal

        If radMoter.Checked Then
            PriceDistance = 2
            OptionCar = 20
        ElseIf radBigcar.Checked Then
            PriceDistance = 4
            OptionCar = 50
        ElseIf radSmallcar.Checked Then
            PriceDistance = 6
            OptionCar = 50
        Else
            PriceDistance = 8
            OptionCar = 50
        End If

        netDistance = (PriceDistance * distance) + OptionCar

        If radOnetour.Checked Then
            Price = netDistance

        ElseIf radTwotour.Checked Then
            Price = ((PriceDistance * distance) * 2) + 50 + OptionCar
        End If


        lblDistance.Text = Val(txtDistance.Text)
        lblService.Text = PriceDistance
        lblTotal.Text = Price
    End Sub

    Private Sub radTwotour_CheckedChanged(sender As Object, e As EventArgs) Handles radTwotour.CheckedChanged
        If radTwotour.Checked Then
            lblOption.Text = 50
        End If
    End Sub

    Private Sub VB_Mid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radOnetour.Checked = True
    End Sub

    Private Sub radOnetour_CheckedChanged(sender As Object, e As EventArgs) Handles radOnetour.CheckedChanged
        If radOnetour.Checked Then
            lblOption.Text = 0
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim out As DialogResult
        out = MessageBox.Show("ต้องการออกจากระบบหรือไม่", "แจ้งเตือนออกจากระบบ", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
        If out = DialogResult.Yes Then
            Me.Close()
        Else
            txtDistance.Clear()
            lblCar.Text = ""
            lblDistance.Text = ""
            lblOption.Text = ""
            lblService.Text = ""
            lblStart.Text = ""
            lblTotal.Text = ""

            radMoter.Checked = True
            radOnetour.Checked = True
        End If
    End Sub
End Class