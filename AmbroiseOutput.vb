Public Class frmOutput
    Private Sub frmOutput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Declaring Variables to hold various data from the Main Form
        Dim strExtraServices As String
        Dim dbExtraServices As String
        Dim dbServiceTotal As Double

        'Stores the Extra Services that were selected in a formatted form
        strExtraServices = frmMain.strMoustache & vbCrLf &
                           frmMain.strBeard & vbCrLf &
                           frmMain.strEyebrow & vbCrLf &
                           frmMain.strFaceMask & vbCrLf &
                           frmMain.strShapeUp

        'Stores the Prices of the Extra Services that were selected in a formatted form
        dbExtraServices = "$" & frmMain.dbMoustachePrice & ".00" & vbCrLf &
                          "$" & frmMain.dbBeardPrice & ".00" & vbCrLf &
                          "$" & frmMain.dbEyebrowPrice & ".00" & vbCrLf &
                          "$" & frmMain.dbFaceMaskPrice & ".00" & vbCrLf &
                          "$" & frmMain.dbShapeUpPrice & ".00"

        'Calculates the Total Price of the Services according to the fields that were selected
        dbServiceTotal = frmMain.dbHaircutPrice + frmMain.dbFadeLevelPrice + frmMain.dbMoustachePrice + frmMain.dbBeardPrice + frmMain.dbEyebrowPrice + frmMain.dbFaceMaskPrice + frmMain.dbShapeUpPrice


        lblHaircutTypeOut.Text = frmMain.strHaircut 'Prints Customer Haircut Choose
        lblHaircutPriceOut.Text = "$" & frmMain.dbHaircutPrice & ".00" 'Prints Price of Haircut Choose
        lblFadeLevelOut.Text = frmMain.strFadeLevel 'Prints Customer Fade Level Choose
        lblFadeLevelPriceOut.Text = "$" & frmMain.dbFadeLevelPrice & ".00" 'Prints Price of Fade Level


        lblExtraServicesOut.Text = strExtraServices 'Prints Customer Extra Services
        lblExtraServicesPriceOut.Text = dbExtraServices 'Prints Customer Extra Services Prices
        lblServiceTotalOut.Text = "$" & dbServiceTotal & ".00"
        lblBarberOut.Text = frmMain.strBarber 'Prints Customer Barber
        lblDateTimeOut.Text = frmMain.strScheduleDate & " at " & frmMain.strTimeSlot 'Prints Time and Date
        rtxtHaircutDetailsOut.Text = frmMain.strHairDetails 'Prints Hair Details

        'Outputs data to the Output Form that was inputted into the Billing Address Section from the Main Form
        lblFullNameOut.Text = frmMain.strFName
        lblFAddressOut.Text = frmMain.strFAddress
        lblPhoneNumOut.Text = frmMain.strPhoneNum
        lblAgeOut.Text = frmMain.intAge

        'Outputs data to the Output Form that was inputted into the Payment Info. from the Main Form
        lblCardNumOut.Text = frmMain.strCardNum
        lblCardNameOut.Text = frmMain.strCardName
        lblExpDateOut.Text = frmMain.strExpDate
        lblSecurityCodeOut.Text = frmMain.strSecurityCode

    End Sub

    'Button that closes the entire program
    Private Sub btnOExit_Click(sender As Object, e As EventArgs) Handles btnOExit.Click
        Me.Close()
        frmMain.Close()
    End Sub

    'Button that takes you back to the Main Form
    Private Sub btnOBack_Click(sender As Object, e As EventArgs) Handles btnOBack.Click
        frmMain.Show()
        Me.Close()
    End Sub
End Class