Public Class frm_LAP10
    Dim decSale(4, 2) As Integer
    Dim decName(4) As String
    Dim intindex, decSumsale As Integer
    Dim sumA, sumB, sumC As Integer


    Private Sub frm_LAP10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 5
            cboIndex.Items.Add(i + 1)
        Next
        cboIndex.SelectedIndex = 0
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim n As Integer = cboIndex.SelectedIndex
        If Not IsNumeric(txtSaleA.Text) And Not IsNumeric(txtSaleB.Text) And Not IsNumeric(txtSaleC.Text) Then
            MessageBox.Show("กรุณาป้อนข้อมูลเป็นตัวเลขเท่านั้น", "แจ้งเตือนข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        decSale(cboIndex.SelectedIndex, 0) = Val(txtSaleA.Text)
        decSale(cboIndex.SelectedIndex, 1) = Val(txtSaleB.Text)
        decSale(cboIndex.SelectedIndex, 2) = Val(txtSaleC.Text)
        decName(cboIndex.SelectedIndex) = txtSaleName.Text

        Call showData()
        Call showDatagrit()

        txtSaleA.Clear()
        txtSaleB.Clear()
        txtSaleC.Clear()
        txtSaleName.Clear()

        txtSaleName.Select()
    End Sub

    Private Sub showData()
        Dim i, total As Decimal
        lstData.Items.Clear()
        sumA = 0
        sumB = 0
        sumC = 0
        For i = 0 To decName.Length - 1

            lstData.Items.Add(decName(i) & "," & decSale(i, 0) & "," & decSale(i, 1) & "," & decSale(i, 2))

            sumA += decSale(i, 0)
            sumB += decSale(i, 1)
            sumC += decSale(i, 2)

            total = decSale(i, 0) + decSale(i, 1) + decSale(i, 2)

            If decSumsale < total Then
                decSumsale = total
                intindex = i
            End If
        Next
        lblSumA.Text = sumA
        lblSumB.Text = sumB
        lblSumC.Text = sumC
        lblMaxSaleName.Text = decName(intindex)
        lblMaxSaleAmount.Text = decSumsale


    End Sub

    Private Sub showDatagrit()
        Dim i, total As Integer
        For i = 0 To decName.Length - 1
            datagrit.Rows.Add()
            datagrit.Item(0, i).Value = decName(i)
            datagrit.Item(1, i).Value = decSale(i, 0)
            datagrit.Item(2, i).Value = decSale(i, 1)
            datagrit.Item(3, i).Value = decSale(i, 2)

            total = decSale(i, 0) + decSale(i, 1) + decSale(i, 2)

            datagrit.Item(4, i).Value = total
        Next
    End Sub
End Class