Imports System
Imports System.Data.SqlClient
Public Class Domestic
    Dim con As New SqlConnection("Data Source=WELCOME-PC\SQLEXPRESS;Initial Catalog=cargo;Integrated Security=True")
    Dim cmd As SqlCommand
    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub Domestic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillgrid()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click


        Try
            con.Open()


            Dim qry As String = "insert into domestic values (" & _
        txtdomesno.Text & "," & _
        txtcnsgno.Text & ",'" & _
        txtocity.Text & "','" & _
        txtdcity.Text & "'," & _
        txtdzip.Text & ",'" & _
       txtweight.Text & "','" & _
       DateTimePicker1.Value & "'," & _
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

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            con.Open()


            Dim qry As String = "delete from domestic where CDomesticno=" & txtdomesno.Text & ""
            cmd = New SqlCommand(qry, con)

            cmd.ExecuteNonQuery()
            MsgBox("Record deleted successfully")

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Try
            con.Open()


            Dim qry As String = "update domestic set " & _
        "CDomesticno=" & txtdomesno.Text & "," & _
        "Cno=" & txtcnsgno.Text & "," & _
        "OCity='" & txtocity.Text & "'," & _
        "Dcity='" & txtdcity.Text & "'," & _
        "ZipCode=" & txtdzip.Text & "," & _
        "Weight='" & txtweight.Text & "'," & _
        "BookingDate='" & DateTimePicker1.Value & "'," & _
        "Amt=" & txtamt.Text & "," & _
        "ProductType='" & txtprod.Text & "'," & _
        "Status='" & cmbstatus.Text & "' " & " where CDomesticno=" & txtdomesno.Text & ""
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

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtcnsgno.Text = ""
        txtocity.Text = ""
        txtdcity.Text = ""
        txtdzip.Text = ""
        txtweight.Text = ""
        DateTimePicker1.Value = Date.Today
        txtamt.Text = ""
        txtprod.Text = ""
        cmbstatus.Text = ""
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex > -1 Then
            txtdomesno.Text = DataGridView1.Rows(e.RowIndex).Cells("CDomesticno").Value
            txtcnsgno.Text = DataGridView1.Rows(e.RowIndex).Cells("Cno").Value
            txtocity.Text = DataGridView1.Rows(e.RowIndex).Cells("OCity").Value
            txtdcity.Text = DataGridView1.Rows(e.RowIndex).Cells("DCity").Value
            txtdzip.Text = DataGridView1.Rows(e.RowIndex).Cells("ZipCode").Value
            txtweight.Text = DataGridView1.Rows(e.RowIndex).Cells("Weight").Value
            DateTimePicker1.Text = DataGridView1.Rows(e.RowIndex).Cells("BookingDate").Value
            txtamt.Text = DataGridView1.Rows(e.RowIndex).Cells("Amt").Value
            txtprod.Text = DataGridView1.Rows(e.RowIndex).Cells("ProductType").Value
            cmbstatus.Text = DataGridView1.Rows(e.RowIndex).Cells("Status").Value
        End If
    End Sub
    Private Sub fillgrid()
        Dim qry As String = "select * from domestic"
        Dim dtadap As New SqlDataAdapter
        Dim dtset As New DataSet
        Try
            con.Open()
            cmd = New SqlCommand
            cmd.Connection = con
            cmd.CommandText = qry
            dtadap.SelectCommand = cmd
            dtadap.Fill(dtset, "domestic")
            DataGridView1.DataSource = dtset.Tables("domestic")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdomesno.TextChanged

    End Sub
End Class