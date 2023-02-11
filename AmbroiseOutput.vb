Public Class frmOutput
    Private Sub frmOutput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strExtraServices As String
        Dim dbExtraServices As String
        Dim dbServiceTotal As Double

        lblHaircutTypeOut.Text = frmMain.strHaircut 'Prints Customer Haircut Choose
        lblHaircutPriceOut.Text = "$" & frmMain.dbHaircutPrice & ".00" 'Prints Price of Haircut Choose

        lblFadeLevelOut.Text = frmMain.strFadeLevel 'Prints Customer Fade Level Choose
        lblFadeLevelPriceOut.Text = "$" & frmMain.dbFadeLevelPrice & ".00" 'Prints Price of Fade Level

        strExtraServices = frmMain.strMoustache & vbCrLf &
                           frmMain.strBeard & vbCrLf &
                           frmMain.strEyebrow & vbCrLf &
                           frmMain.strFaceMask & vbCrLf &
                           frmMain.strShapeUp

        dbExtraServices = "$" & frmMain.dbMoustachePrice & ".00" & vbCrLf &
                          "$" & frmMain.dbBeardPrice & ".00" & vbCrLf &
                          "$" & frmMain.dbEyebrowPrice & ".00" & vbCrLf &
                          "$" & frmMain.dbFaceMaskPrice & ".00" & vbCrLf &
                          "$" & frmMain.dbShapeUpPrice & ".00"

        dbServiceTotal = frmMain.dbHaircutPrice + frmMain.dbFadeLevelPrice + frmMain.dbMoustachePrice + frmMain.dbBeardPrice + frmMain.dbEyebrowPrice + frmMain.dbFaceMaskPrice + frmMain.dbShapeUpPrice

        lblExtraServicesOut.Text = strExtraServices 'Prints Customer Extra Services
        lblExtraServicesPriceOut.Text = dbExtraServices 'Prints Customer Extra Services Prices
        lblServiceTotalOut.Text = "$" & dbServiceTotal & ".00"

        lblBarberOut.Text = frmMain.strBarber 'Prints Customer Barber
        lblDateTimeOut.Text = frmMain.strScheduleDate & " at " & frmMain.strTimeSlot 'Prints Time and Date
        rtxtHaircutDetailsOut.Text = frmMain.strHairDetails 'Prints Hair Details

        lblFullNameOut.Text = frmMain.strFName 'Prints Customer Full Name
        lblFAddressOut.Text = frmMain.strFAddress 'Prints Customer Full Address
        lblPhoneNumOut.Text = frmMain.strPhoneNum 'Prints Customer Phone Number
        lblAgeOut.Text = frmMain.intAge 'Prints Customer Age

        lblCardNumOut.Text = frmMain.strCardNum 'Prints Customer Credit Card Number
        lblCardNameOut.Text = frmMain.strCardName 'Prints Customer Credit Card Name
        lblExpDateOut.Text = frmMain.strExpDate 'Prints Customer Credit Card Expiration Date
        lblSecurityCodeOut.Text = frmMain.strSecurityCode 'Prints Customer Credit Card Security Code

    End Sub

    Private Sub btnOExit_Click(sender As Object, e As EventArgs) Handles btnOExit.Click
        Me.Close()
    End Sub

    Private Sub btnOBack_Click(sender As Object, e As EventArgs) Handles btnOBack.Click
        frmMain.Show()
        Me.Close()
    End Sub
End Class