Imports System
Imports System.Data.SqlClient
Public Class Feedback
    Dim con As New SqlConnection("Data Source=WELCOME-PC\SQLEXPRESS;Initial Catalog=cargo;Integrated Security=True")
    Dim cmd As SqlCommand
    Private Sub Feedback_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillgrid()
    End Sub

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        Try
            con.Open()


            Dim qry As String = "insert into feedback values ( " & _
        txtfno.Text & ",'" & _
        txtname.Text & "','" & _
        txtcity.Text & "','" & _
        txtphoneno.Text & "','" & _
        txtemail.Text & "','" & _
        cmbcategory.Text & "','" & _
        txtmsg.Text & "')"

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

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex > -1 Then
            txtfno.Text = DataGridView1.Rows(e.RowIndex).Cells("Fno").Value
            txtname.Text = DataGridView1.Rows(e.RowIndex).Cells("Name").Value
            txtcity.Text = DataGridView1.Rows(e.RowIndex).Cells("City").Value
            txtphoneno.Text = DataGridView1.Rows(e.RowIndex).Cells("PhoneNo").Value
            txtemail.Text = DataGridView1.Rows(e.RowIndex).Cells("Email").Value
            cmbcategory.Text = DataGridView1.Rows(e.RowIndex).Cells("Category").Value
            txtmsg.Text = DataGridView1.Rows(e.RowIndex).Cells("Message").Value
        End If
    End Sub
    Private Sub fillgrid()
        Dim qry As String = "select * from feedback"
        Dim dtadap As New SqlDataAdapter
        Dim dtset As New DataSet
        Try
            con.Open()
            cmd = New SqlCommand
            cmd.Connection = con
            cmd.CommandText = qry
            dtadap.SelectCommand = cmd
            dtadap.Fill(dtset, "feedback")
            DataGridView1.DataSource = dtset.Tables("feedback")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            con.Close()
        End Try
    End Sub

End Class