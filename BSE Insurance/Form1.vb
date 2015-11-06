Public Class frMBBE
    'declaring the global variables for the solution
    Dim LocationPrice As Single
    Dim Discount As Single
    Dim Total As Single
    Dim Additions As Single
    Dim Subtractions As Single
    Dim BaseCost As Single


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the program
        End
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Locationprices for area of suburbs to later work out the total cost
        Select Case cmbLocation.Text
            Case "Inner City" : LocationPrice = 0.8
            Case "Eastern Suburbs" : LocationPrice = 0.2
            Case "Northen Suburbs" : LocationPrice = 0.4
            Case "South Eastern Suburbs" : LocationPrice = 0.6
            Case "Western Suburbs" : LocationPrice = 0.1
        End Select

        'membership years are selected and the discount integers are declared for corresponding variables
        Select Case cmbDiscount.Text
            Case "0-2 Years" : Discount = 1
            Case "3-5 Years" : Discount = 0.95
            Case "6-8 Years" : Discount = 0.9
            Case "9-11 Years" : Discount = 0.85
            Case "12+ Years" : Discount = 0.8
        End Select

        'adds integers to variables for when each extras are clicked
        If chkGPS.Checked = True Then
            Additions = Additions + 30
        ElseIf chkSound.Checked = True Then
            Additions = Additions + 50
        ElseIf chkSunroof.Checked = True Then
            Additions = Additions + 60
        ElseIf chkEngine.Checked = True Then
            Subtractions = Subtractions + 80
        ElseIf chkAlarm.Checked = True Then
            Subtractions = Subtractions + 80
        End If
        'selects car ratings and cylinders to figure out the base cost

        Select Case cmbCarType.Text + cmbRating.Text
            Case "4 Cylinder" + "Rating 1" : BaseCost = 1800
            Case "4 Cylinder" + "Rating 2" : BaseCost = 1500
            Case "4 Cylinder" + "Rating 3" : BaseCost = 1200
            Case "4 Cylinder" + "Rating 4" : BaseCost = 900
            Case "4 Cylinder" + "Rating 5" : BaseCost = 600
                '6 cylinders and their ratings
            Case "6 Cylinder" + "Rating 1" : BaseCost = 2100
            Case "6 Cylinder" + "Rating 2" : BaseCost = 1800
            Case "6 Cylinder" + "Rating 3" : BaseCost = 1500
            Case "6 Cylinder" + "Rating 4" : BaseCost = 1200
            Case "6 Cylinder" + "Rating 5" : BaseCost = 900
                '8 Cylinders and their ratings
            Case "8 Cylinder" + "Rating 1" : BaseCost = 2400
            Case "8 Cylinder" + "Rating 2" : BaseCost = 2100
            Case "8 Cylinder" + "Rating 3" : BaseCost = 1800
            Case "8 Cylinder" + "Rating 4" : BaseCost = 1500
            Case "8 Cylinder" + "Rating 5" : BaseCost = 1200
        End Select
        'Adds and multiples the variables together to create the cost and then shown in labels 
        Total = (((BaseCost * LocationPrice) * Discount) + Additions - Subtractions)
        lblMonthly.Text = FormatCurrency(Total)
        lblYearly.Text = FormatCurrency(Total * 12)
        lblGST.Text = FormatCurrency(Total * 0.1)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'set the labels, combo boxes and labels back to their default texts
        cmbCarType.Text = ""
        cmbDiscount.Text = ""
        cmbLocation.Text = ""
        cmbRating.Text = ""
        lblMonthly.Text = "$0.00"
        lblYearly.Text = "$0.00"
        lblGST.Text = "$0.00"
        chkAlarm.Checked = False
        chkEngine.Checked = False
        chkGPS.Checked = False
        chkSound.Checked = False
        chkSunroof.Checked = False

        'disables the combo boxes and checkboxes except for Car Cylinder box
        cmbRating.Enabled = False
        cmbDiscount.Enabled = False
        cmbLocation.Enabled = False
        btnCalculate.Enabled = False
        grpExtras.Enabled = False
        btnClear.Enabled = False
    End Sub

    Private Sub frMBBE_Load(sender As Object, e As EventArgs) Handles Me.Load
        'stats the timer when the form loads
        tmrTimer.Start()
    End Sub

    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick

        'checks Cylinder combo box for text then enables clear button and the rating combo box
        If Not cmbCarType.Text = "" Then
            btnClear.Enabled = True
            cmbRating.Enabled = True
        End If

        'checks the rating combo box for text and enables location box
        If Not cmbRating.Text = "" Then
            cmbLocation.Enabled = True
        End If

        'checks for location box and enblaes discount box
        If Not cmbLocation.Text = "" Then
            cmbDiscount.Enabled = True
        End If

        'enables extras and calculate button
        If Not cmbDiscount.Text = "" Then
            grpExtras.Enabled = True
            btnCalculate.Enabled = True
        End If
    End Sub
End Class
