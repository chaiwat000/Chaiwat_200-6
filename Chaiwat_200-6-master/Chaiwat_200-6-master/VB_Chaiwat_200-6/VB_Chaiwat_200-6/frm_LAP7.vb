Public Class frm_LAP7
    Private Sub frm_LAP7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAdd.Enabled = False
    End Sub

    Private Sub txtAdd_TextChanged(sender As Object, e As EventArgs) Handles txtAdd.TextChanged
        If txtAdd.Text <> "" Then
            btnAdd.Enabled = True
        Else
            btnAdd.Enabled = False
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstAdd.Items.Add(txtAdd.Text)
        txtAdd.Text = ""
        lstAdd.SelectedIndex = lstAdd.Items.Count - 1
        txtAdd.Select()
    End Sub

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        Dim ao As Integer
        If lstAdd.Items.Count = 0 Then
            MessageBox.Show("Listbox ต้องไม่เป็นค่าว่าง", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            ao = lstAdd.SelectedIndex
            cboOutput.Items.Add(lstAdd.SelectedItem)


            If lstAdd.SelectedIndex = lstAdd.Items.Count - 1 Then
                lstAdd.Items.RemoveAt(lstAdd.SelectedIndex)
                lstAdd.SelectedIndex = lstAdd.Items.Count - 1
            Else
                lstAdd.Items.RemoveAt(lstAdd.SelectedIndex)
                lstAdd.SelectedIndex = ao
            End If
            cboOutput.SelectedIndex = cboOutput.Items.Count - 1


        End If

    End Sub

    Private Sub btnMoveAll_Click(sender As Object, e As EventArgs) Handles btnMoveAll.Click
        If lstAdd.Items.Count = 0 Then
            MessageBox.Show("Listbox ต้องไม่เป็นค่าว่าง", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            For Each item As Object In lstAdd.Items
                cboOutput.Items.Add(item)
                cboOutput.SelectedIndex = 0
            Next
            lstAdd.Items.Clear()
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If cboOutput.Items.Count = 0 Then
            MessageBox.Show("ComboBox ต้องไม่เป็นค่าว่าง", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            lstAdd.Items.Add(cboOutput.SelectedItem)
            cboOutput.Items.Remove(cboOutput.SelectedItem)

            For i As Integer = 0 To cboOutput.SelectedIndex
                cboOutput.Items.RemoveAt(cboOutput.SelectedItem)
            Next

        End If
    End Sub

    Private Sub btnBackAll_Click(sender As Object, e As EventArgs) Handles btnBackAll.Click
        If cboOutput.Items.Count = 0 Then
            MessageBox.Show("ComboBox", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            For Each item As Object In cboOutput.Items
                lstAdd.Items.Add(item)
            Next
            cboOutput.Items.Clear()
            cboOutput.Text = ""

            Dim list As New List(Of Object)
            For Each item As String In list
                lstAdd.Items.Add(item)
                cboOutput.Items.Remove(item)
                lstAdd.SelectedIndex = lstAdd.Items.Count - 1
            Next

        End If

    End Sub


    Private Sub cboOutput_TextChanged(sender As Object, e As EventArgs) Handles cboOutput.TextChanged
        lblOutput.Text = cboOutput.SelectedItem
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstAdd.Items.Clear()
        cboOutput.Items.Clear()
        lblOutput.Text = ""
        txtAdd.Clear()
    End Sub
End Class