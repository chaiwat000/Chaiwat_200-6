Public Class frm_Main
    Private Sub ออกจากระบบToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ออกจาระบบToolStripMenuItem.Click
        Dim close As DialogResult
        close = MessageBox.Show("ต้องการออกจากระบบ ", "แน่ใจหรือไม่?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If close = DialogResult.Yes Then
            Me.Close()
        Else

        End If
    End Sub

    Private Sub ใบงานท1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ใบงานท1ToolStripMenuItem.Click
        Dim frm1 As New Frm_LAP1
        frm1.ShowDialog()
    End Sub

    Private Sub ใบงานท2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ใบงานท2ToolStripMenuItem.Click
        Dim frm2 As New Frm_LAP2
        frm2.ShowDialog()
    End Sub

    Private Sub ใบงานท3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ใบงานท3ToolStripMenuItem.Click
        Dim frm3 As New frm_LAP3
        frm3.ShowDialog()
    End Sub

    Private Sub ใบงานท4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ใบงานท4ToolStripMenuItem.Click
        Dim frm4 As New frm_LAP4
        frm4.ShowDialog()
    End Sub

    Private Sub ใบงานท5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ใบงานท5ToolStripMenuItem.Click
        Dim frm5 As New frm_Lap5
        frm5.ShowDialog()
    End Sub

    Private Sub ใบงานท6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ใบงานท6ToolStripMenuItem.Click
        Dim frm6 As New frm_LAP6
        frm6.ShowDialog()
    End Sub

    Private Sub ใบงานท7ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ใบงานท7ToolStripMenuItem.Click
        Dim frm7 As New frm_LAP7
        frm7.ShowDialog()
    End Sub

    Private Sub ใบงานท8ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ใบงานท8ToolStripMenuItem.Click
        Dim frm8 As frm_LAP8
        frm8.ShowDialog()
    End Sub
End Class