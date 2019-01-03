Public Class frm_LAP8
    Dim sumScore As Decimal
    Dim sumCredit As Decimal
    Dim gpa As Decimal
    Dim credit As Decimal
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim grade As String
        Dim cal As String

        txtSubject.Text = txtSubject.Text.Trim()
        txtScore.Text = txtScore.Text.Trim()
        txtCredit.Text = txtCredit.Text.Trim()

        If txtSubject.Text = "" Or txtScore.Text = "" Or txtCredit.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลก่อน", "Error")
            Exit Sub
        Else
            grade = getGrade(Val(txtScore.Text))
            lstGrade.Items.Add(grade)
            lstSubject.Items.Add(txtSubject.Text)
            lstScore.Items.Add(Val(txtScore.Text))
            lstCredit.Items.Add(Val(txtCredit.Text))

            lstSubject.SelectedIndex = lstSubject.Items.Count - 1
            lstScore.SelectedIndex = lstScore.Items.Count - 1
            lstCredit.SelectedIndex = lstCredit.Items.Count - 1
            lstGrade.SelectedIndex = lstGrade.Items.Count - 1

            calGrade()
            lblNewGrade.Text = gpa.ToString("0.00")


            txtSubject.Text = ""
            txtScore.Text = ""
            txtCredit.Text = ""

            txtSubject.Select()
        End If


    End Sub

    Private Function getGrade(ByVal score As Decimal) As String
        score = Val(txtScore.Text)
        Dim grade As String


        If score < 50 Then
            grade = "F"
        ElseIf score < 55 Then
            grade = "D"
        ElseIf score < 60 Then
            grade = "D+"
        ElseIf score < 65 Then
            grade = "C"
        ElseIf score < 70 Then
            grade = "C+"
        ElseIf score < 75 Then
            grade = "B"
        ElseIf score < 80 Then
            grade = "B+"
        Else
            grade = "A"
        End If

        Return grade
    End Function

    Private Sub calGrade()
        sumCredit = Val(lblTotalCredit.Text)
        sumScore = Val(lblTotalScore.Text)
        Dim grade As Decimal
        Dim credit As Decimal

        For i = 0 To lstCredit.Items.Count - 1
            credit = lstCredit.Items(i)
            If lstGrade.Items(i) = "A" Then
                grade = 4
            ElseIf lstGrade.Items(i) = "B+" Then
                grade = 3.5
            ElseIf lstGrade.Items(i) = "B" Then
                grade = 3
            ElseIf lstGrade.Items(i) = "C+" Then
                grade = 2.5
            ElseIf lstGrade.Items(i) = "C" Then
                grade = 2
            ElseIf lstGrade.Items(i) = "D+" Then
                grade = 1.5
            ElseIf lstGrade.Items(i) = "D" Then
                grade = 1
            Else
                grade = 0
            End If
            sumScore += grade * credit
            sumCredit += credit


        Next
        gpa = sumScore / sumCredit


    End Sub

    Private Sub txtScore_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtScore.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 Then
                e.KeyChar = Nothing
            End If

        End If
    End Sub

    Private Sub txtCredit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCredit.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 Then
                e.KeyChar = Nothing
            End If

        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstSubject.Items.Clear()
        lstScore.Items.Clear()
        lstCredit.Items.Clear()
        lstGrade.Items.Clear()
    End Sub
End Class