Public Class Login

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If (TextBox1.Text = "admin" And TextBox2.Text = "admin") Then
            MDIParent1.Show()
            Me.Hide()
        Else
            MessageBox.Show("Incorrect password")
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub
End Class
