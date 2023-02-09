Public Class cargoreport

    Private Sub cargoreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As New cargoDataSet1
        Dim ad As New cargoDataSet1TableAdapters.carTableAdapter
        ad.Fill(ds.car)
        Dim rpt As New cargorpt
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class