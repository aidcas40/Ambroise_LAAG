Public Class frmLogin
    'Button that closes the Login form and opens the Main Form
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        frmMain.Show()
        Me.Close()
    End Sub
End Class
