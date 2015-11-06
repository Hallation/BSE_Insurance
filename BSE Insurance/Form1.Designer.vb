<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frMBBE
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmbLocation = New System.Windows.Forms.ComboBox()
        Me.cmbDiscount = New System.Windows.Forms.ComboBox()
        Me.lblMonthly = New System.Windows.Forms.Label()
        Me.lblGSTTitle = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblGST = New System.Windows.Forms.Label()
        Me.lblYearly = New System.Windows.Forms.Label()
        Me.lblYearlyTitle = New System.Windows.Forms.Label()
        Me.lblMonthlyTitle = New System.Windows.Forms.Label()
        Me.lblSuburb = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.grpExtras = New System.Windows.Forms.GroupBox()
        Me.chkAlarm = New System.Windows.Forms.CheckBox()
        Me.chkEngine = New System.Windows.Forms.CheckBox()
        Me.chkSound = New System.Windows.Forms.CheckBox()
        Me.chkSunroof = New System.Windows.Forms.CheckBox()
        Me.chkGPS = New System.Windows.Forms.CheckBox()
        Me.lblRating = New System.Windows.Forms.Label()
        Me.cmbRating = New System.Windows.Forms.ComboBox()
        Me.lblCarType = New System.Windows.Forms.Label()
        Me.cmbCarType = New System.Windows.Forms.ComboBox()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.grpExtras.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(30, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(369, 29)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "BBE Insurance Cost Calculator"
        '
        'cmbLocation
        '
        Me.cmbLocation.Enabled = False
        Me.cmbLocation.FormattingEnabled = True
        Me.cmbLocation.Items.AddRange(New Object() {"Inner City", "Eastern Suburbs", "Northen Suburbs", "South Eastern Suburbs", "Western Suburbs"})
        Me.cmbLocation.Location = New System.Drawing.Point(48, 206)
        Me.cmbLocation.Name = "cmbLocation"
        Me.cmbLocation.Size = New System.Drawing.Size(121, 21)
        Me.cmbLocation.TabIndex = 2
        '
        'cmbDiscount
        '
        Me.cmbDiscount.Enabled = False
        Me.cmbDiscount.FormattingEnabled = True
        Me.cmbDiscount.Items.AddRange(New Object() {"0-2 Years", "3-5 Years", "6-8 Years", "9-11 Years", "12+ Years"})
        Me.cmbDiscount.Location = New System.Drawing.Point(232, 206)
        Me.cmbDiscount.Name = "cmbDiscount"
        Me.cmbDiscount.Size = New System.Drawing.Size(121, 21)
        Me.cmbDiscount.TabIndex = 3
        '
        'lblMonthly
        '
        Me.lblMonthly.BackColor = System.Drawing.Color.White
        Me.lblMonthly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMonthly.Location = New System.Drawing.Point(280, 290)
        Me.lblMonthly.Name = "lblMonthly"
        Me.lblMonthly.Size = New System.Drawing.Size(105, 28)
        Me.lblMonthly.TabIndex = 6
        Me.lblMonthly.Text = "$0.00"
        Me.lblMonthly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGSTTitle
        '
        Me.lblGSTTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGSTTitle.Location = New System.Drawing.Point(226, 365)
        Me.lblGSTTitle.Name = "lblGSTTitle"
        Me.lblGSTTitle.Size = New System.Drawing.Size(48, 24)
        Me.lblGSTTitle.TabIndex = 7
        Me.lblGSTTitle.Text = "GST"
        Me.lblGSTTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.Enabled = False
        Me.btnCalculate.Location = New System.Drawing.Point(29, 427)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 11
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Enabled = False
        Me.btnClear.Location = New System.Drawing.Point(171, 427)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(293, 427)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblGST
        '
        Me.lblGST.BackColor = System.Drawing.Color.White
        Me.lblGST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGST.Location = New System.Drawing.Point(280, 363)
        Me.lblGST.Name = "lblGST"
        Me.lblGST.Size = New System.Drawing.Size(105, 28)
        Me.lblGST.TabIndex = 14
        Me.lblGST.Text = "$0.00"
        Me.lblGST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblYearly
        '
        Me.lblYearly.BackColor = System.Drawing.Color.White
        Me.lblYearly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYearly.Location = New System.Drawing.Point(280, 325)
        Me.lblYearly.Name = "lblYearly"
        Me.lblYearly.Size = New System.Drawing.Size(105, 28)
        Me.lblYearly.TabIndex = 15
        Me.lblYearly.Text = "$0.00"
        Me.lblYearly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblYearlyTitle
        '
        Me.lblYearlyTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearlyTitle.Location = New System.Drawing.Point(192, 327)
        Me.lblYearlyTitle.Name = "lblYearlyTitle"
        Me.lblYearlyTitle.Size = New System.Drawing.Size(82, 24)
        Me.lblYearlyTitle.TabIndex = 16
        Me.lblYearlyTitle.Text = "Total (Yearly)"
        Me.lblYearlyTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMonthlyTitle
        '
        Me.lblMonthlyTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlyTitle.Location = New System.Drawing.Point(184, 294)
        Me.lblMonthlyTitle.Name = "lblMonthlyTitle"
        Me.lblMonthlyTitle.Size = New System.Drawing.Size(90, 24)
        Me.lblMonthlyTitle.TabIndex = 17
        Me.lblMonthlyTitle.Text = "Total (Monthly)"
        Me.lblMonthlyTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSuburb
        '
        Me.lblSuburb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuburb.Location = New System.Drawing.Point(48, 179)
        Me.lblSuburb.Name = "lblSuburb"
        Me.lblSuburb.Size = New System.Drawing.Size(121, 24)
        Me.lblSuburb.TabIndex = 18
        Me.lblSuburb.Text = "Location"
        Me.lblSuburb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDiscount
        '
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(232, 179)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(121, 24)
        Me.lblDiscount.TabIndex = 19
        Me.lblDiscount.Text = "Discount"
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpExtras
        '
        Me.grpExtras.Controls.Add(Me.chkAlarm)
        Me.grpExtras.Controls.Add(Me.chkEngine)
        Me.grpExtras.Controls.Add(Me.chkSound)
        Me.grpExtras.Controls.Add(Me.chkSunroof)
        Me.grpExtras.Controls.Add(Me.chkGPS)
        Me.grpExtras.Enabled = False
        Me.grpExtras.Location = New System.Drawing.Point(29, 275)
        Me.grpExtras.Name = "grpExtras"
        Me.grpExtras.Size = New System.Drawing.Size(135, 132)
        Me.grpExtras.TabIndex = 20
        Me.grpExtras.TabStop = False
        Me.grpExtras.Text = "Extras"
        '
        'chkAlarm
        '
        Me.chkAlarm.AutoSize = True
        Me.chkAlarm.Location = New System.Drawing.Point(6, 107)
        Me.chkAlarm.Name = "chkAlarm"
        Me.chkAlarm.Size = New System.Drawing.Size(52, 17)
        Me.chkAlarm.TabIndex = 4
        Me.chkAlarm.Text = "Alarm"
        Me.chkAlarm.UseVisualStyleBackColor = True
        '
        'chkEngine
        '
        Me.chkEngine.AutoSize = True
        Me.chkEngine.Location = New System.Drawing.Point(6, 84)
        Me.chkEngine.Name = "chkEngine"
        Me.chkEngine.Size = New System.Drawing.Size(113, 17)
        Me.chkEngine.TabIndex = 3
        Me.chkEngine.Text = "Engine Immobiliser"
        Me.chkEngine.UseVisualStyleBackColor = True
        '
        'chkSound
        '
        Me.chkSound.AutoSize = True
        Me.chkSound.Location = New System.Drawing.Point(6, 38)
        Me.chkSound.Name = "chkSound"
        Me.chkSound.Size = New System.Drawing.Size(94, 17)
        Me.chkSound.TabIndex = 2
        Me.chkSound.Text = "Sound System"
        Me.chkSound.UseVisualStyleBackColor = True
        '
        'chkSunroof
        '
        Me.chkSunroof.AutoSize = True
        Me.chkSunroof.Location = New System.Drawing.Point(6, 61)
        Me.chkSunroof.Name = "chkSunroof"
        Me.chkSunroof.Size = New System.Drawing.Size(63, 17)
        Me.chkSunroof.TabIndex = 1
        Me.chkSunroof.Text = "Sunroof"
        Me.chkSunroof.UseVisualStyleBackColor = True
        '
        'chkGPS
        '
        Me.chkGPS.AutoSize = True
        Me.chkGPS.Location = New System.Drawing.Point(6, 15)
        Me.chkGPS.Name = "chkGPS"
        Me.chkGPS.Size = New System.Drawing.Size(48, 17)
        Me.chkGPS.TabIndex = 0
        Me.chkGPS.Text = "GPS"
        Me.chkGPS.UseVisualStyleBackColor = True
        '
        'lblRating
        '
        Me.lblRating.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRating.Location = New System.Drawing.Point(232, 98)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(121, 24)
        Me.lblRating.TabIndex = 22
        Me.lblRating.Text = "Ratings"
        Me.lblRating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbRating
        '
        Me.cmbRating.Enabled = False
        Me.cmbRating.FormattingEnabled = True
        Me.cmbRating.Items.AddRange(New Object() {"Rating 1", "Rating 2", "Rating 3", "Rating 4", "Rating 5"})
        Me.cmbRating.Location = New System.Drawing.Point(232, 125)
        Me.cmbRating.Name = "cmbRating"
        Me.cmbRating.Size = New System.Drawing.Size(121, 21)
        Me.cmbRating.TabIndex = 21
        '
        'lblCarType
        '
        Me.lblCarType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarType.Location = New System.Drawing.Point(48, 98)
        Me.lblCarType.Name = "lblCarType"
        Me.lblCarType.Size = New System.Drawing.Size(121, 24)
        Me.lblCarType.TabIndex = 24
        Me.lblCarType.Text = "Cylinder"
        Me.lblCarType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbCarType
        '
        Me.cmbCarType.FormattingEnabled = True
        Me.cmbCarType.Items.AddRange(New Object() {"4 Cylinder", "6 Cylinder", "8 Cylinder"})
        Me.cmbCarType.Location = New System.Drawing.Point(48, 125)
        Me.cmbCarType.Name = "cmbCarType"
        Me.cmbCarType.Size = New System.Drawing.Size(121, 21)
        Me.cmbCarType.TabIndex = 23
        '
        'tmrTimer
        '
        '
        'frMBBE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 484)
        Me.Controls.Add(Me.lblCarType)
        Me.Controls.Add(Me.cmbCarType)
        Me.Controls.Add(Me.lblRating)
        Me.Controls.Add(Me.cmbRating)
        Me.Controls.Add(Me.grpExtras)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblSuburb)
        Me.Controls.Add(Me.lblMonthlyTitle)
        Me.Controls.Add(Me.lblYearlyTitle)
        Me.Controls.Add(Me.lblYearly)
        Me.Controls.Add(Me.lblGST)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblGSTTitle)
        Me.Controls.Add(Me.lblMonthly)
        Me.Controls.Add(Me.cmbDiscount)
        Me.Controls.Add(Me.cmbLocation)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frMBBE"
        Me.Text = "BBE Calculator"
        Me.grpExtras.ResumeLayout(False)
        Me.grpExtras.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents cmbLocation As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDiscount As System.Windows.Forms.ComboBox
    Friend WithEvents lblMonthly As System.Windows.Forms.Label
    Friend WithEvents lblGSTTitle As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblGST As System.Windows.Forms.Label
    Friend WithEvents lblYearly As System.Windows.Forms.Label
    Friend WithEvents lblYearlyTitle As System.Windows.Forms.Label
    Friend WithEvents lblMonthlyTitle As System.Windows.Forms.Label
    Friend WithEvents lblSuburb As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents grpExtras As System.Windows.Forms.GroupBox
    Friend WithEvents chkAlarm As System.Windows.Forms.CheckBox
    Friend WithEvents chkEngine As System.Windows.Forms.CheckBox
    Friend WithEvents chkSound As System.Windows.Forms.CheckBox
    Friend WithEvents chkSunroof As System.Windows.Forms.CheckBox
    Friend WithEvents chkGPS As System.Windows.Forms.CheckBox
    Friend WithEvents lblRating As System.Windows.Forms.Label
    Friend WithEvents cmbRating As System.Windows.Forms.ComboBox
    Friend WithEvents lblCarType As System.Windows.Forms.Label
    Friend WithEvents cmbCarType As System.Windows.Forms.ComboBox
    Friend WithEvents tmrTimer As System.Windows.Forms.Timer

End Class
