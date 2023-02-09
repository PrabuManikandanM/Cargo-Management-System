Public Class internationalreport

    Private Sub internationalreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As New cargoDataSet1
        Dim ad As New cargoDataSet1TableAdapters.internationalTableAdapter
        ad.Fill(ds.international)
        Dim rpt As New internatrpt
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class