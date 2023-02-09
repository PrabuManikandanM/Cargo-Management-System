Imports System
Imports System.Data.SqlClient
Public Class Consign
    Dim con As New SqlConnection("Data Source=WELCOME-PC\SQLEXPRESS;Initial Catalog=cargo;Integrated Security=True")
    Dim cmd As SqlCommand
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            con.Open()


            Dim qry As String = "insert into consign values(" & _
        txtcno.Text & ",'" & _
        txtname.Text & "','" & _
        txtcompy.Text & "','" & _
        txtaddr.Text & "','" & _
        txtcity.Text & "'," & _
        txtpin.Text & "," & _
        txtphoneno.Text & "," & _
        txtmobile.Text & "," & _
        txtfaxno.Text & ",'" & _
        txtemail.Text & "')"

            cmd = New SqlCommand(qry, con)

            cmd.ExecuteNonQuery()
            MsgBox("Record inserted successfully")

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged

    End Sub

    Private Sub btnuupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnuupdate.Click
        Try
            con.Open()


            Dim qry As String = "update consign set " & _
        "Cno=" & txtcno.Text & "," & _
        "Name='" & txtname.Text & "'," & _
        "CompName='" & txtcompy.Text & "'," & _
        "Address='" & txtaddr.Text & "'," & _
        "City='" & txtcity.Text & "'," & _
        "PinCode=" & txtpin.Text & "," & _
        "PhoneNo=" & txtphoneno.Text & "," & _
        "Mobile=" & txtmobile.Text & "," & _
        "FaxNo=" & txtfaxno.Text & "," & _
        "Email='" & txtemail.Text & "' " & " where Cno=" & txtcno.Text & ""

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


            Dim qry As String = "delete from consign where Cno='" & txtcno.Text & "'"

            cmd = New SqlCommand(qry, con)

            cmd.ExecuteNonQuery()
            MsgBox("Record deleted successfully")

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtcno.Text = ""
        txtname.Text = ""
        txtcompy.Text = ""
        txtaddr.Text = ""
        txtcity.Text = ""
        txtpin.Text = ""
        txtphoneno.Text = ""
        txtmobile.Text = ""
        txtfaxno.Text = ""
        txtemail.Text = ""
    End Sub
   

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub cmbcno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If e.RowIndex > -1 Then
            txtcno.Text = DataGridView1.Rows(e.RowIndex).Cells("Cno").Value
            txtname.Text = DataGridView1.Rows(e.RowIndex).Cells("Name").Value
            txtcompy.Text = DataGridView1.Rows(e.RowIndex).Cells("CompName").Value
            txtaddr.Text = DataGridView1.Rows(e.RowIndex).Cells("Address").Value
            txtcity.Text = DataGridView1.Rows(e.RowIndex).Cells("City").Value
            txtpin.Text = DataGridView1.Rows(e.RowIndex).Cells("PinCode").Value
            txtphoneno.Text = DataGridView1.Rows(e.RowIndex).Cells("PhoneNo").Value
            txtmobile.Text = DataGridView1.Rows(e.RowIndex).Cells("Mobile").Value
            txtfaxno.Text = DataGridView1.Rows(e.RowIndex).Cells("FaxNo").Value
            txtemail.Text = DataGridView1.Rows(e.RowIndex).Cells("Email").Value
            btnsave.Enabled = False
            btndelete.Enabled = True
            btnexit.Enabled = True
        Else
            btnsave.Enabled = False
            btndelete.Enabled = True
            btnexit.Enabled = True
        End If
    End Sub

    Private Sub Consign_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex > -1 Then
            txtcno.Text = DataGridView1.Rows(e.RowIndex).Cells("Cno").Value
            txtname.Text = DataGridView1.Rows(e.RowIndex).Cells("Name").Value
            txtcompy.Text = DataGridView1.Rows(e.RowIndex).Cells("CompName").Value
            txtaddr.Text = DataGridView1.Rows(e.RowIndex).Cells("Address").Value
            txtcity.Text = DataGridView1.Rows(e.RowIndex).Cells("City").Value
            txtpin.Text = DataGridView1.Rows(e.RowIndex).Cells("PinCode").Value
            txtphoneno.Text = DataGridView1.Rows(e.RowIndex).Cells("PhoneNo").Value
            txtmobile.Text = DataGridView1.Rows(e.RowIndex).Cells("Mobile").Value
            txtfaxno.Text = DataGridView1.Rows(e.RowIndex).Cells("FaxNo").Value
            txtemail.Text = DataGridView1.Rows(e.RowIndex).Cells("Email").Value
        End If
    End Sub
    Private Sub fillgrid()
        Dim qry As String = "select * from consign"
        Dim dtadap As New SqlDataAdapter
        Dim dtset As New DataSet
        Try
            con.Open()
            cmd = New SqlCommand
            cmd.Connection = con
            cmd.CommandText = qry
            dtadap.SelectCommand = cmd
            dtadap.Fill(dtset, "consign")
            DataGridView1.DataSource = dtset.Tables("consign")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Consign_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillgrid()


    End Sub
End Class