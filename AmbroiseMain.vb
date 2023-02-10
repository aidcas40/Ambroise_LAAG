Public Class frmMain

    Public strHaircut As String
    Public intHaircutPrice As Double
    Public strFName As String

    'Makes Service Panel visible when the Services button is clicked
    Private Sub btnServices_Click(sender As Object, e As EventArgs) Handles btnServices.Click
        pnlServices.Visible = True
        pnlBarber.Visible = False
        pnlSchedule.Visible = False
        pnlCheckOut.Visible = False
    End Sub

    'Makes Barber Panel visible when the Barber button is clicked
    Private Sub btnBarber_Click(sender As Object, e As EventArgs) Handles btnBarber.Click
        pnlServices.Visible = False
        pnlBarber.Visible = True
        pnlSchedule.Visible = False
        pnlCheckOut.Visible = False
    End Sub

    'Makes Schedule Panel visible when the Schedule button is clicked
    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        pnlServices.Visible = False
        pnlBarber.Visible = False
        pnlSchedule.Visible = True
        pnlCheckOut.Visible = False
    End Sub

    'Makes Check Out Panel visible when the Check Out button is clicked
    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        pnlServices.Visible = False
        pnlBarber.Visible = False
        pnlSchedule.Visible = False
        pnlCheckOut.Visible = True
    End Sub

    Private Sub btnServicesReset_Click(sender As Object, e As EventArgs) Handles btnServicesReset.Click
        For Each control As Control In pnlServices.Controls
            If TypeOf control Is TextBox Then
                Dim textBox As TextBox = DirectCast(control, TextBox)
                textBox.Text = ""
            ElseIf TypeOf control Is RadioButton Then
                Dim radioButton As RadioButton = DirectCast(control, RadioButton)
                radioButton.Checked = False
            ElseIf TypeOf control Is CheckBox Then
                Dim checkBox As CheckBox = DirectCast(control, CheckBox)
                checkBox.Checked = False
            End If
        Next
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        strFName = txtFName.Text & " " & txtLName.Text

        frmOutput.Show()
        Me.Close()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExitServices.Click
        Me.Close()
    End Sub
End Class