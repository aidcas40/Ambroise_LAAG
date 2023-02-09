Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        frmMain.Show()
        Me.Close()
    End Sub
    Private Sub txtEmail_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.GotFocus
        If txtEmail.Text = "Email" Then
            txtEmail.Text = ""
        End If
    End Sub
    Private Sub txtEmail_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.LostFocus
        If txtEmail.Text = "" Then
            txtEmail.Text = "Email"
        End If
    End Sub
    Private Sub txtPassword_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.GotFocus
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
        End If
    End Sub
    Private Sub txtPassword_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.LostFocus
        If txtPassword.Text = "" Then
            txtPassword.Text = "Password"
        End If
    End Sub
End Class
