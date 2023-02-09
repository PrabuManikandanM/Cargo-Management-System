Public Class domesreport

    Private Sub domesreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As New cargoDataSet1
        Dim ad As New cargoDataSet1TableAdapters.domesticTableAdapter
        ad.Fill(ds.domestic)
        Dim rpt As New domesrpt
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class