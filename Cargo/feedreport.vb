Public Class feedreport

    Private Sub feedreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As New cargoDataSet1
        Dim ad As New cargoDataSet1TableAdapters.feedbackTableAdapter
        ad.Fill(ds.feedback)
        Dim rpt As New feedbackrpt
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class