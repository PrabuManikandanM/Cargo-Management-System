Imports System
Imports System.Data.SqlClient
Public Class International
    Dim con As New SqlConnection("Data Source=WELCOME-PC\SQLEXPRESS;Initial Catalog=cargo;Integrated Security=True")
    Dim cmd As SqlCommand
    Private Sub International_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillgrid()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            con.Open()


            Dim qry As String = "insert into international values (" & _
        txtinternat.Text & "," & _
        txtcnsgno.Text & ",'" & _
        txtorcntry.Text & "','" & _
        txtorcity.Text & "'," & _
        txtorzip.Text & ",'" & _
        txtdestcntry.Text & "','" & _
        txtdestcity.Text & "'," & _
        txtdeszip.Text & "," & _
        txtwght.Text & ",'" & _
        DateTimePicker2.Value & "'," & _
        txtbtime.Text & "," & _
        txtamt.Text & ",'" & _
        txtprod.Text & "','" & _
        cmbstatus.Text & "')"
            cmd = New SqlCommand(qry, con)

            cmd.ExecuteNonQuery()
            MsgBox("Record inserted successfully")

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Try
            con.Open()


            Dim qry As String = "update international set " & _
        "Cno=" & txtcnsgno.Text & "," & _
        "OCountry='" & txtorcntry.Text & "'," & _
        "OCity= '" & txtorcity.Text & "'," & _
        "OZipCode= " & txtorzip.Text & "," & _
        "DCountry='" & txtdestcntry.Text & "'," & _
        "DCity='" & txtdestcity.Text & "'," & _
        "DZipCode=" & txtdeszip.Text & "," & _
        "Weight='" & txtwght.Text & "'," & _
        "BookingDate= '" & DateTimePicker2.Text & "'," & _
        "BookingTime=" & txtbtime.Text & "," & _
        "Amt=" & txtamt.Text & "," & _
        "ProductTypeu='" & txtprod.Text & "'," & _
        "Status='" & cmbstatus.Text & "' " & " where CInternatno=" & txtinternat.Text & ""

            cmd = New SqlCommand(qry, con)

            cmd.ExecuteNonQuery()
            MsgBox("Record updated successfully")

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        Finally
            con.Close()
        End Try
        fillgrid()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            con.Open()


            Dim qry As String = "delete from international where CInternatno= " & txtinternat.Text & " "
            cmd = New SqlCommand(qry, con)

            cmd.ExecuteNonQuery()
            MsgBox("Record deleted successfully")

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtcnsgno.Text = ""
        txtorcntry.Text = ""
        txtorcity.Text = ""
        txtorzip.Text = ""
        txtdestcntry.Text = ""
        txtdestcity.Text = ""
        txtdeszip.Text = ""
        txtwght.Text = ""
        DateTimePicker2.Text = Date.Today
        txtbtime.Text = ""
        txtamt.Text = ""
        txtprod.Text = ""
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex > -1 Then
            txtinternat.Text = DataGridView1.Rows(e.RowIndex).Cells("CInternatno").Value
            txtcnsgno.Text = DataGridView1.Rows(e.RowIndex).Cells("Cno").Value
            txtorcntry.Text = DataGridView1.Rows(e.RowIndex).Cells("OCountry").Value
            txtorcity.Text = DataGridView1.Rows(e.RowIndex).Cells("OCity").Value
            txtorzip.Text = DataGridView1.Rows(e.RowIndex).Cells("OZipCode").Value
            txtdestcntry.Text = DataGridView1.Rows(e.RowIndex).Cells("DCountry").Value
            txtdestcity.Text = DataGridView1.Rows(e.RowIndex).Cells("DCity").Value
            txtdeszip.Text = DataGridView1.Rows(e.RowIndex).Cells("DZipCode").Value
            txtwght.Text = DataGridView1.Rows(e.RowIndex).Cells("Weight").Value
            DateTimePicker2.Text = DataGridView1.Rows(e.RowIndex).Cells("BookingDate").Value
            txtbtime.Text = DataGridView1.Rows(e.RowIndex).Cells("BookingTime").Value
            txtamt.Text = DataGridView1.Rows(e.RowIndex).Cells("Amt").Value
            txtprod.Text = DataGridView1.Rows(e.RowIndex).Cells("ProductType").Value
            cmbstatus.Text = DataGridView1.Rows(e.RowIndex).Cells("Status").Value
        End If
    End Sub
    Private Sub fillgrid()
        Dim qry As String = "select * from international"
        Dim dtadap As New SqlDataAdapter
        Dim dtset As New DataSet
        Try
            con.Open()
            cmd = New SqlCommand
            cmd.Connection = con
            cmd.CommandText = qry
            dtadap.SelectCommand = cmd
            dtadap.Fill(dtset, "international")
            DataGridView1.DataSource = dtset.Tables("international")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            con.Close()
        End Try
    End Sub
End Class