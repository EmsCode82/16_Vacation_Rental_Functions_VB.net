﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radStandard = New System.Windows.Forms.RadioButton()
        Me.radPeak = New System.Windows.Forms.RadioButton()
        Me.radOff = New System.Windows.Forms.RadioButton()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.chkRepeat = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.radNone = New System.Windows.Forms.RadioButton()
        Me.radAAA = New System.Windows.Forms.RadioButton()
        Me.radAARP = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(194, 582)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(55, 23)
        Me.btnExit.TabIndex = 72
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Sub Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Tax"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(80, 83)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(84, 23)
        Me.lblTotal.TabIndex = 16
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(133, 582)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(55, 23)
        Me.btnClear.TabIndex = 71
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radStandard)
        Me.GroupBox1.Controls.Add(Me.radPeak)
        Me.GroupBox1.Controls.Add(Me.radOff)
        Me.GroupBox1.Location = New System.Drawing.Point(64, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 119)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Season"
        '
        'radStandard
        '
        Me.radStandard.AutoSize = True
        Me.radStandard.Location = New System.Drawing.Point(39, 51)
        Me.radStandard.Name = "radStandard"
        Me.radStandard.Size = New System.Drawing.Size(107, 17)
        Me.radStandard.TabIndex = 7
        Me.radStandard.TabStop = True
        Me.radStandard.Text = "Standard-Season"
        Me.radStandard.UseVisualStyleBackColor = True
        '
        'radPeak
        '
        Me.radPeak.AutoSize = True
        Me.radPeak.Location = New System.Drawing.Point(39, 83)
        Me.radPeak.Name = "radPeak"
        Me.radPeak.Size = New System.Drawing.Size(89, 17)
        Me.radPeak.TabIndex = 6
        Me.radPeak.TabStop = True
        Me.radPeak.Text = "Peak-Season"
        Me.radPeak.UseVisualStyleBackColor = True
        '
        'radOff
        '
        Me.radOff.AutoSize = True
        Me.radOff.Location = New System.Drawing.Point(39, 19)
        Me.radOff.Name = "radOff"
        Me.radOff.Size = New System.Drawing.Size(78, 17)
        Me.radOff.TabIndex = 5
        Me.radOff.TabStop = True
        Me.radOff.Text = "Off-Season"
        Me.radOff.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(72, 582)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(55, 23)
        Me.btnSubmit.TabIndex = 70
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Location = New System.Drawing.Point(79, 300)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(83, 13)
        Me.lblDays.TabIndex = 69
        Me.lblDays.Text = "Number of Days"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(61, 104)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 68
        Me.lblEmail.Text = "Email"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(61, 75)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(78, 13)
        Me.lblPhoneNumber.TabIndex = 66
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(61, 46)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 65
        Me.lblLastName.Text = "Last Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(61, 17)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 64
        Me.lblFirstName.Text = "First Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(148, 46)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 60
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(148, 104)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 62
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(168, 297)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(63, 20)
        Me.txtDays.TabIndex = 67
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(148, 17)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 59
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubTotal.Location = New System.Drawing.Point(80, 13)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(84, 23)
        Me.lblSubTotal.TabIndex = 14
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkRepeat
        '
        Me.chkRepeat.AutoSize = True
        Me.chkRepeat.Location = New System.Drawing.Point(98, 425)
        Me.chkRepeat.Name = "chkRepeat"
        Me.chkRepeat.Size = New System.Drawing.Size(119, 17)
        Me.chkRepeat.TabIndex = 76
        Me.chkRepeat.Text = "Returning Customer"
        Me.chkRepeat.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "State"
        '
        'cboState
        '
        Me.cboState.FormattingEnabled = True
        Me.cboState.Items.AddRange(New Object() {"Alabama", "Alaska", "Arizona", "Arkansas", "California ", "Colorado", "Conneticut", "Deleware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine ", "Maryland", "Massachusett", "Michigan", "Minnesota", "Mississippi", "Missiouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Corolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virgina", "Washington", "West Virgina", "Wisconsin", "Wyoming"})
        Me.cboState.Location = New System.Drawing.Point(148, 133)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(100, 21)
        Me.cboState.TabIndex = 63
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.lblSubTotal)
        Me.GroupBox2.Controls.Add(Me.lblTax)
        Me.GroupBox2.Location = New System.Drawing.Point(64, 448)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 119)
        Me.GroupBox2.TabIndex = 74
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Totals"
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(80, 49)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(84, 23)
        Me.lblTax.TabIndex = 15
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(148, 75)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtPhoneNumber.TabIndex = 61
        '
        'radNone
        '
        Me.radNone.AutoSize = True
        Me.radNone.Checked = True
        Me.radNone.Location = New System.Drawing.Point(65, 58)
        Me.radNone.Name = "radNone"
        Me.radNone.Size = New System.Drawing.Size(51, 17)
        Me.radNone.TabIndex = 20
        Me.radNone.TabStop = True
        Me.radNone.Text = "None"
        Me.radNone.UseVisualStyleBackColor = True
        '
        'radAAA
        '
        Me.radAAA.AutoSize = True
        Me.radAAA.Location = New System.Drawing.Point(65, 14)
        Me.radAAA.Name = "radAAA"
        Me.radAAA.Size = New System.Drawing.Size(46, 17)
        Me.radAAA.TabIndex = 18
        Me.radAAA.TabStop = True
        Me.radAAA.Text = "AAA"
        Me.radAAA.UseVisualStyleBackColor = True
        '
        'radAARP
        '
        Me.radAARP.AutoSize = True
        Me.radAARP.Location = New System.Drawing.Point(65, 37)
        Me.radAARP.Name = "radAARP"
        Me.radAARP.Size = New System.Drawing.Size(54, 17)
        Me.radAARP.TabIndex = 19
        Me.radAARP.TabStop = True
        Me.radAARP.Text = "AARP"
        Me.radAARP.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radNone)
        Me.GroupBox3.Controls.Add(Me.radAAA)
        Me.GroupBox3.Controls.Add(Me.radAARP)
        Me.GroupBox3.Location = New System.Drawing.Point(65, 329)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(184, 88)
        Me.GroupBox3.TabIndex = 77
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Discount Program"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 619)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtDays)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.chkRepeat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboState)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "Form1"
        Me.Text = "Vacation Rental Function"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radStandard As RadioButton
    Friend WithEvents radPeak As RadioButton
    Friend WithEvents radOff As RadioButton
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblDays As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtDays As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents chkRepeat As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboState As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblTax As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents radNone As RadioButton
    Friend WithEvents radAAA As RadioButton
    Friend WithEvents radAARP As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
End Class
