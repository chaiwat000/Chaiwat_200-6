Public Class Frm_LAP2
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        Dim Vis As Double = txtVista.Text
        Dim Fris As Double = txtFrista.Text
        Dim ComVis As Double
        Dim ComFris As Double
        Dim SumProduct As Double
        Dim SumCom As Double

        ComVis = Vis * 0.05
        ComFris = Fris * 0.1
        SumCom = ComVis + ComFris
        SumProduct = Vis + Fris

        lblVistra.Text += "  " + Vis.ToString("###,###,###,###")
        lblFrista.Text += "  " + Fris.ToString("###,###,###,###")
        lblComVis.Text += "  " + ComVis.ToString("###,###,###,###")
        lblComFris.Text += "  " + ComFris.ToString("###,###,###,###")
        lblSumVisAndFris.Text += "  " + SumProduct.ToString("###,###,###,###")
        lblSumCom.Text += "  " + SumCom.ToString("###,###,###,###")

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class