Imports System
Imports System.Data.SqlClient
Public Class Cargo
    Dim con As New SqlConnection("Data Source=WELCOME-PC\SQLEXPRESS;Initial Catalog=cargo;Integrated Security=True")
    Dim cmd As SqlCommand

    Private Sub cmbcnsgno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub
    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub
    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            con.Open()


            Dim qry As String = "delete from cargo where Carno=" & txtcarno.Text & ""
            cmd = New SqlCommand(qry, con)

            cmd.ExecuteNonQuery()
            MsgBox("Record deleted successfully")

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            con.Open()


            Dim qry As String = "insert into car values (" & _
        txtcarno.Text & "," & _
        txtcnsgno.Text & ",'" & _
        cmbcarmode.Text & "','" & _
        txtOctry.Text & "','" & _
        txtOcity.Text & "'," & _
        txtOzip.Text & ",'" & _
        txtDctry.Text & "','" & _
        txtDcity.Text & "'," & _
        txtDzip.Text & ",'" & _
        DateTimePicker1.Text & "','" & _
        cmbbtype.Text & "')"
            cmd = New SqlCommand(qry, con)

            cmd.ExecuteNonQuery()
            MsgBox("Record inserted successfully")

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub
    Private Sub cmbcarno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        cmbcarmode.Text = ""
        txtcnsgno.Text = ""
        txtOctry.Text = ""
        txtOcity.Text = ""
        txtOzip.Text = ""
        txtDctry.Text = ""
        txtDcity.Text = ""
        txtDzip.Text = ""
        DateTimePicker1.Value = Date.Today
        cmbbtype.Text = ""
    End Sub
    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub
    Private Sub cmbcarmode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcarmode.SelectedIndexChanged

    End Sub
    Private Sub btnuupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnuupdate.Click
        Try
            con.Open()


            Dim qry As String = "update car set " & _
        "Carno= " & txtcarno.Text & "," & _
        "Cno= " & txtcnsgno.Text & "," & _
        "Mode='" & cmbcarmode.Text & "'," & _
        "OCountry= '" & txtOctry.Text & "'," & _
        "OCity='" & txtOcity.Text & "'," & _
        "OZipcode=" & txtOzip.Text & "," & _
        "DCountry= '" & txtDctry.Text & "'," & _
        "DCity= '" & txtDcity.Text & "'," & _
        "DZipcode= " & txtDzip.Text & "," & _
        "BookingDate= '" & DateTimePicker1.Text & "'," & _
        "BillType='" & cmbbtype.Text & "' " & " where Carno=" & txtcarno.Text & ""

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
    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Cargo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillgrid()
    End Sub


    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex > -1 Then
            txtcarno.Text = DataGridView1.Rows(e.RowIndex).Cells("Carno").Value
            txtcnsgno.Text = DataGridView1.Rows(e.RowIndex).Cells("Cno").Value
            cmbcarmode.Text = DataGridView1.Rows(e.RowIndex).Cells("Mode").Value
            txtOctry.Text = DataGridView1.Rows(e.RowIndex).Cells("OCountry").Value
            txtOcity.Text = DataGridView1.Rows(e.RowIndex).Cells("OCity").Value
            txtOzip.Text = DataGridView1.Rows(e.RowIndex).Cells("OZipCode").Value
            txtDctry.Text = DataGridView1.Rows(e.RowIndex).Cells("DCountry").Value
            txtDcity.Text = DataGridView1.Rows(e.RowIndex).Cells("DCity").Value
            txtDzip.Text = DataGridView1.Rows(e.RowIndex).Cells("DZipCode").Value
            DateTimePicker1.Value = DataGridView1.Rows(e.RowIndex).Cells("BookingDate").Value
            cmbbtype.Text = DataGridView1.Rows(e.RowIndex).Cells("BillType").Value

        End If
    End Sub
    Private Sub fillgrid()
        Dim qry As String = "select * from car"
        Dim dtadap As New SqlDataAdapter
        Dim dtset As New DataSet
        Try
            con.Open()
            cmd = New SqlCommand
            cmd.Connection = con
            cmd.CommandText = qry
            dtadap.SelectCommand = cmd
            dtadap.Fill(dtset, "car")
            DataGridView1.DataSource = dtset.Tables("car")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            con.Close()
        End Try
    End Sub
End Class