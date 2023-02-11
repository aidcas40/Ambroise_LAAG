'----------------------------------------------------------------------------------
'Program Title: 		Ambroise
'Program Author: 		Aiden Castillo, Luis Garcia
'Date Created:  		11 Feb, 2023
'School:			    Corozal Junior College
'Course Number/Name:	CS206 - Programming II
'Program Description:	This program demonstrates a Barber Booking System with various GUI controls and their functionalities within. It also Outputs the inputted data from the Main Form to the Output Form. 
'----------------------------------------------------------------------------------
Public Class frmMain
    'Declaring various variables for Services Section
    Public strHaircut As String
    Public dbHaircutPrice As Double
    Public strMoustache As String
    Public dbMoustachePrice As Double
    Public strBeard As String
    Public dbBeardPrice As Double
    Public strEyebrow As String
    Public dbEyebrowPrice As Double
    Public strFaceMask As String
    Public dbFaceMaskPrice As Double
    Public strShapeUp As String
    Public dbShapeUpPrice As Double
    Public strFadeLevel As String
    Public dbFadeLevelPrice As Double
    Public strHairDetails As String

    'Declaring variable for Barber Section
    Public strBarber As String

    'Declaring various variables for Schedule Section
    Public strScheduleDate As String
    Public strTimeSlot As String

    'Declaring various variables for Check Out Section
    Public strFName As String
    Public strFAddress As String
    Public strPhoneNum As String
    Public intAge As Integer
    Public strCardNum As String
    Public strCardName As String
    Public strExpDate As String
    Public strSecurityCode As String

    'Makes Service Panel visible when the Services button is clicked and the rest of panels invisible
    Private Sub btnServices_Click(sender As Object, e As EventArgs) Handles btnServices.Click
        pnlServices.Visible = True
        pnlBarber.Visible = False
        pnlSchedule.Visible = False
        pnlCheckOut.Visible = False
    End Sub

    'Makes Barber Panel visible when the Barber button is clicked and the rest of panels invisible
    Private Sub btnBarber_Click(sender As Object, e As EventArgs) Handles btnBarber.Click
        pnlServices.Visible = False
        pnlBarber.Visible = True
        pnlSchedule.Visible = False
        pnlCheckOut.Visible = False
    End Sub

    'Makes Schedule Panel visible when the Schedule button is clicked and the rest of panels invisible
    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        pnlServices.Visible = False
        pnlBarber.Visible = False
        pnlSchedule.Visible = True
        pnlCheckOut.Visible = False
    End Sub

    'Makes Check Out Panel visible when the Check Out button is clicked and the rest of panels invisible
    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        pnlServices.Visible = False
        pnlBarber.Visible = False
        pnlSchedule.Visible = False
        pnlCheckOut.Visible = True
    End Sub

    'Exit Button that takes you out of the program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExitServices.Click
        Me.Close()
    End Sub

    'Buttons for Services Panel
    'Next Button on the Service Panel that takes you to the Barber Panel
    Private Sub btnServicesNext_Click(sender As Object, e As EventArgs) Handles btnServicesNext.Click
        pnlServices.Visible = False
        pnlBarber.Visible = True
        pnlSchedule.Visible = False
        pnlCheckOut.Visible = False
    End Sub

    'Reset Button that resets all the controls to their original state 
    Private Sub btnServicesReset_Click(sender As Object, e As EventArgs) Handles btnServicesReset.Click
        For Each control As Control In pnlHaircut.Controls
            If TypeOf control Is RadioButton Then
                DirectCast(control, RadioButton).Checked = False
            End If
        Next
        For Each control As Control In pnlAddOns.Controls
            If TypeOf control Is RichTextBox Then
                control.Text = ""
            End If
        Next
        For Each control As Control In grbExtraServices.Controls
            If TypeOf control Is CheckBox Then
                DirectCast(control, CheckBox).Checked = False
            End If
        Next
        For Each control As Control In grbFade.Controls
            If TypeOf control Is RadioButton Then
                DirectCast(control, RadioButton).Checked = False
            End If
        Next
    End Sub

    'Buttons for the Barber Panel
    'Back Button that takes you back to the Services Panel
    Private Sub btnBarberBack_Click(sender As Object, e As EventArgs) Handles btnBarberBack.Click
        pnlServices.Visible = True
        pnlBarber.Visible = False
        pnlSchedule.Visible = False
        pnlCheckOut.Visible = False
    End Sub

    'Next Button that takes you to the Schedule Panel
    Private Sub btnBarberNext_Click(sender As Object, e As EventArgs) Handles btnBarberNext.Click
        pnlServices.Visible = False
        pnlBarber.Visible = False
        pnlSchedule.Visible = True
        pnlCheckOut.Visible = False
    End Sub

    'Reset Button that resets all the controls to their original state
    Private Sub btnBarberReset_Click(sender As Object, e As EventArgs) Handles btnBarberReset.Click
        For Each control As Control In pnlBarber.Controls
            If TypeOf control Is RadioButton Then
                DirectCast(control, RadioButton).Checked = False
            End If
        Next
    End Sub

    'Buttons for Schedule Section
    'Back Button that takes you back to the Barber Panel
    Private Sub btnScheduleBack_Click(sender As Object, e As EventArgs) Handles btnScheduleBack.Click
        pnlServices.Visible = False
        pnlBarber.Visible = True
        pnlSchedule.Visible = False
        pnlCheckOut.Visible = False
    End Sub

    'Next Button that takes you to the Check Out Panel
    Private Sub btnScheduleNext_Click(sender As Object, e As EventArgs) Handles btnScheduleNext.Click
        pnlServices.Visible = False
        pnlBarber.Visible = False
        pnlSchedule.Visible = False
        pnlCheckOut.Visible = True
    End Sub

    'Reset Button that resets all the controls to their original state
    Private Sub btnScheduleReset_Click(sender As Object, e As EventArgs) Handles btnScheduleReset.Click
        For Each control As Control In pnlSchedule.Controls
            If TypeOf control Is DateTimePicker Then
                control.Text = Date.Now
            End If
        Next
        For Each control As Control In grbTimeSlots.Controls
            If TypeOf control Is RadioButton Then
                DirectCast(control, RadioButton).Checked = False
            End If
        Next
    End Sub

    'Buttons for CheckOut Panel
    'Back Button that takes you back to the Schedule Panel
    Private Sub btnCheckOutBack_Click(sender As Object, e As EventArgs) Handles btnCheckOutBack.Click
        pnlServices.Visible = False
        pnlBarber.Visible = False
        pnlSchedule.Visible = True
        pnlCheckOut.Visible = False
    End Sub

    'Reset Button that resets all the controls to their original state
    Private Sub btnCheckOutReset_Click(sender As Object, e As EventArgs) Handles btnCheckOutReset.Click
        For Each control As Control In pnlCheckOut.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""
            End If
            If TypeOf control Is ComboBox Then
                control.Text = ""
            End If
            If TypeOf control Is NumericUpDown Then
                control.Text = ""
            End If
            If TypeOf control Is MaskedTextBox Then
                control.Text = ""
            End If
            If TypeOf control Is DateTimePicker Then
                control.Text = Date.Now
            End If
        Next
    End Sub

    'Submit Button that defines the variables declared with the data inputted so that it is outputted on the Output Form 
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'If statements that checks and stores the Hair Cut that was selected with their corresponding price
        If radBuzzCut.Checked Then
            strHaircut = radBuzzCut.Text
            dbHaircutPrice = 25
        ElseIf radFrenchCrop.Checked Then
            strHaircut = radFrenchCrop.Text
            dbHaircutPrice = 20
        ElseIf radQuiff.Checked Then
            strHaircut = radQuiff.Text
            dbHaircutPrice = 35
        ElseIf radPompadour.Checked Then
            strHaircut = radPompadour.Text
            dbHaircutPrice = 30
        ElseIf radCombOver.Checked Then
            strHaircut = radCombOver.Text
            dbHaircutPrice = 25
        ElseIf radSlickBack.Checked Then
            strHaircut = radSlickBack.Text
            dbHaircutPrice = 25
        ElseIf radScissor.Checked Then
            strHaircut = radScissor.Text
            dbHaircutPrice = 23
        ElseIf radMohawkMullet.Checked Then
            strHaircut = radMohawkMullet.Text
            dbHaircutPrice = 27
        ElseIf radFringe.Checked Then
            strHaircut = radFringe.Text
            dbHaircutPrice = 20
        End If

        'If statements that checks and stores the Extra Services that were selected with their corresponding price
        If chkMoustache.Checked Then
            strMoustache = chkMoustache.Text
            dbMoustachePrice = 3
        Else
            strMoustache = "-"
        End If
        If chkBeard.Checked Then
            strBeard = chkBeard.Text
            dbBeardPrice = 5
        Else
            strBeard = "-"
        End If
        If chkEyebrow.Checked Then
            strEyebrow = chkEyebrow.Text
            dbEyebrowPrice = 10
        Else
            strEyebrow = "-"
        End If
        If chkFaceMask.Checked Then
            strFaceMask = chkFaceMask.Text
            dbFaceMaskPrice = 15
        Else
            strFaceMask = "-"
        End If
        If chkShapeUp.Checked Then
            strShapeUp = chkShapeUp.Text
            dbShapeUpPrice = 10
        Else
            strShapeUp = "-"
        End If

        'If statements that checks and stores the Fade Level that was selected with their corresponding price
        If radTaperFade.Checked Then
            strFadeLevel = radTaperFade.Text
            dbFadeLevelPrice = 10
        ElseIf radHighFade.Checked Then
            strFadeLevel = radHighFade.Text
            dbFadeLevelPrice = 10
        ElseIf radMidFade.Checked Then
            strFadeLevel = radMidFade.Text
            dbFadeLevelPrice = 7
        ElseIf radLowFade.Checked Then
            strFadeLevel = radLowFade.Text
            dbFadeLevelPrice = 5
        ElseIf radNoFade.Checked Then
            strFadeLevel = radNoFade.Text
            dbFadeLevelPrice = 0
        End If

        'Stores Hair Details that were inputted
        strHairDetails = rtxtHairDetails.Text

        'If statements that checks and stores the Barber that was selected
        If radBarber1.Checked Then
            strBarber = radBarber1.Text
        ElseIf radBarber2.Checked Then
            strBarber = radBarber2.Text
        ElseIf radBarber3.Checked Then
            strBarber = radBarber3.Text
        ElseIf radBarber4.Checked Then
            strBarber = radBarber4.Text
        ElseIf radBarber5.Checked Then
            strBarber = radBarber5.Text
        ElseIf radBarber6.Checked Then
            strBarber = radBarber6.Text
        End If

        'Stores the date that was chosen from Schedule Panel
        strScheduleDate = dtpScheduleDate.Text

        'If statements that checks and stores the time slot selected and concatenates AM or PM to it
        If radMorning1.Checked Then
            strTimeSlot = radMorning1.Text & " AM"
        ElseIf radMorning2.Checked Then
            strTimeSlot = radMorning2.Text & " AM"
        ElseIf radMorning3.Checked Then
            strTimeSlot = radMorning3.Text & " AM"
        ElseIf radMorning4.Checked Then
            strTimeSlot = radMorning4.Text & " AM"
        ElseIf radMorning5.Checked Then
            strTimeSlot = radMorning5.Text & " AM"
        ElseIf radMorning6.Checked Then
            strTimeSlot = radMorning6.Text & " AM"
        ElseIf radMorning7.Checked Then
            strTimeSlot = radMorning7.Text & " AM"
        ElseIf radMorning8.Checked Then
            strTimeSlot = radMorning8.Text & " PM"
        ElseIf radAfternoon1.Checked Then
            strTimeSlot = radAfternoon1.Text & " PM"
        ElseIf radAfternoon2.Checked Then
            strTimeSlot = radAfternoon2.Text & " PM"
        ElseIf radAfternoon3.Checked Then
            strTimeSlot = radAfternoon3.Text & " PM"
        ElseIf radAfternoon4.Checked Then
            strTimeSlot = radAfternoon4.Text & " PM"
        ElseIf radAfternoon5.Checked Then
            strTimeSlot = radAfternoon5.Text & " PM"
        ElseIf radAfternoon6.Checked Then
            strTimeSlot = radAfternoon6.Text & " PM"
        ElseIf radAfternoon7.Checked Then
            strTimeSlot = radAfternoon7.Text & " PM"
        ElseIf radAfternoon8.Checked Then
            strTimeSlot = radAfternoon8.Text & " PM"
        End If

        'Stores various data inputted from the Billing Address Section in a formatted form 
        strFName = txtFName.Text & " " & txtLName.Text
        strFAddress = txtAddress.Text & ", " & vbCrLf & cboCityTown.Text & ", " & cboDistrict.Text
        strPhoneNum = mtxtPhoneNum.Text
        intAge = nudAge.Text

        'Stores various data inputted from the Payment Info. Section
        strCardNum = txtCardNum.Text
        strCardName = txtCardName.Text
        strExpDate = dtpExpDate.Text
        strSecurityCode = txtSecurityCode.Text

        frmOutput.Show() 'Opens the Output Form
        Me.Hide() 'Hides the Main Form 
    End Sub
End Class