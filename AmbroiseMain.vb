Public Class frmMain
    Private Sub btnServices_Click(sender As Object, e As EventArgs) Handles btnServices.Click
        pnlServices.Visible = True
        pnlBarber.Visible = False
        pnlSchedule.Visible = False
        pnlCheckOut.Visible = False
    End Sub

    Private Sub btnBarber_Click(sender As Object, e As EventArgs) Handles btnBarber.Click
        pnlServices.Visible = False
        pnlBarber.Visible = True
        pnlSchedule.Visible = False
        pnlCheckOut.Visible = False
    End Sub

    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        pnlServices.Visible = False
        pnlBarber.Visible = False
        pnlSchedule.Visible = True
        pnlCheckOut.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        pnlServices.Visible = False
        pnlBarber.Visible = False
        pnlSchedule.Visible = False
        pnlCheckOut.Visible = True
    End Sub

    Private Sub btnServicesReset_Click(sender As Object, e As EventArgs) Handles btnServicesReset.Click
        pnlServices.Dispose()
    End Sub
End Class