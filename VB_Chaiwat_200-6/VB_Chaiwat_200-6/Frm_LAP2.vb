Public Class Frm_LAP2
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        Dim GluVis, ComToshi, totalsel, totalCommit, commitGluVis, commitCom As Double

        GluVis = txtVista.Text
        ComToshi = txtComToshiba.Text

        totalsel = Val(GluVis) + Val(ComToshi)
        commitGluVis = Val(GluVis) * 0.05
        commitCom = Val(ComToshi) * 0.1
        totalCommit = Val(commitGluVis) + Val(ComToshi)


        lblVistra.Text += "  " + GluVis.ToString("###,###,###,###")
        lblComtoshi.Text += "  " + ComToshi.ToString("###,###,###,###")
        lblComVis.Text += "  " + commitGluVis.ToString("###,###,###,###")
        lblComshi.Text += "  " + commitCom.ToString("###,###,###,###")
        lblSumsell.Text += "  " + totalsel.ToString("###,###,###,###")
        lblSumCom.Text += "  " + totalCommit.ToString("###,###,###,###")

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class