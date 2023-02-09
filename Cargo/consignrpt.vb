Public Class consignrpt

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As New cargoDataSet1
        Dim ad As New cargoDataSet1TableAdapters.consignTableAdapter
        ad.Fill(ds.consign)
        Dim rpt As New CrystalReport1
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class