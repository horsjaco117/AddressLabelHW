<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HWAddressLabel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        FirstNameTextBox = New TextBox()
        LastNameTextBox = New TextBox()
        StreetAddressTextBox = New TextBox()
        CityTextBox = New TextBox()
        StateTextBox = New TextBox()
        ZipTextBox = New TextBox()
        MailingAddressGroupBox = New GroupBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        DisplayButton = New Button()
        ClearButton = New Button()
        ExitButton = New Button()
        WordsLabel = New Label()
        AddressLabelBox = New GroupBox()
        ToolTip1 = New ToolTip(components)
        MailingAddressGroupBox.SuspendLayout()
        AddressLabelBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' FirstNameTextBox
        ' 
        FirstNameTextBox.Location = New Point(16, 83)
        FirstNameTextBox.Name = "FirstNameTextBox"
        FirstNameTextBox.Size = New Size(243, 31)
        FirstNameTextBox.TabIndex = 0
        ToolTip1.SetToolTip(FirstNameTextBox, "Your legal first name here")
        ' 
        ' LastNameTextBox
        ' 
        LastNameTextBox.Location = New Point(16, 145)
        LastNameTextBox.Name = "LastNameTextBox"
        LastNameTextBox.Size = New Size(243, 31)
        LastNameTextBox.TabIndex = 1
        ToolTip1.SetToolTip(LastNameTextBox, "Allotted space for last name")
        ' 
        ' StreetAddressTextBox
        ' 
        StreetAddressTextBox.Location = New Point(16, 207)
        StreetAddressTextBox.Name = "StreetAddressTextBox"
        StreetAddressTextBox.Size = New Size(243, 31)
        StreetAddressTextBox.TabIndex = 2
        ToolTip1.SetToolTip(StreetAddressTextBox, "Your address of residency")
        ' 
        ' CityTextBox
        ' 
        CityTextBox.Location = New Point(16, 269)
        CityTextBox.Name = "CityTextBox"
        CityTextBox.Size = New Size(243, 31)
        CityTextBox.TabIndex = 3
        ToolTip1.SetToolTip(CityTextBox, "Your city of residency")
        ' 
        ' StateTextBox
        ' 
        StateTextBox.Location = New Point(16, 334)
        StateTextBox.Name = "StateTextBox"
        StateTextBox.Size = New Size(243, 31)
        StateTextBox.TabIndex = 4
        ToolTip1.SetToolTip(StateTextBox, "Your state of residency")
        ' 
        ' ZipTextBox
        ' 
        ZipTextBox.Location = New Point(16, 396)
        ZipTextBox.Name = "ZipTextBox"
        ZipTextBox.Size = New Size(150, 31)
        ZipTextBox.TabIndex = 5
        ToolTip1.SetToolTip(ZipTextBox, "The postal code of your town")
        ' 
        ' MailingAddressGroupBox
        ' 
        MailingAddressGroupBox.Controls.Add(Label6)
        MailingAddressGroupBox.Controls.Add(Label5)
        MailingAddressGroupBox.Controls.Add(Label4)
        MailingAddressGroupBox.Controls.Add(Label3)
        MailingAddressGroupBox.Controls.Add(Label2)
        MailingAddressGroupBox.Controls.Add(Label1)
        MailingAddressGroupBox.Controls.Add(FirstNameTextBox)
        MailingAddressGroupBox.Controls.Add(ZipTextBox)
        MailingAddressGroupBox.Controls.Add(LastNameTextBox)
        MailingAddressGroupBox.Controls.Add(StreetAddressTextBox)
        MailingAddressGroupBox.Controls.Add(StateTextBox)
        MailingAddressGroupBox.Controls.Add(CityTextBox)
        MailingAddressGroupBox.Location = New Point(12, 21)
        MailingAddressGroupBox.Name = "MailingAddressGroupBox"
        MailingAddressGroupBox.Size = New Size(286, 502)
        MailingAddressGroupBox.TabIndex = 7
        MailingAddressGroupBox.TabStop = False
        MailingAddressGroupBox.Text = "Mailing Address"
        ToolTip1.SetToolTip(MailingAddressGroupBox, "Enter your address info here")
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 368)
        Label6.Name = "Label6"
        Label6.Size = New Size(37, 25)
        Label6.TabIndex = 11
        Label6.Text = "Zip"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 303)
        Label5.Name = "Label5"
        Label5.Size = New Size(51, 25)
        Label5.TabIndex = 10
        Label5.Text = "State"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 241)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 25)
        Label4.TabIndex = 9
        Label4.Text = "City"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 179)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 25)
        Label3.TabIndex = 8
        Label3.Text = "Street Address"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 25)
        Label2.TabIndex = 7
        Label2.Text = "Last Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 25)
        Label1.TabIndex = 6
        Label1.Text = "First Name"
        ' 
        ' DisplayButton
        ' 
        DisplayButton.Location = New Point(337, 376)
        DisplayButton.Name = "DisplayButton"
        DisplayButton.Size = New Size(185, 112)
        DisplayButton.TabIndex = 8
        DisplayButton.Text = "Display"
        ToolTip1.SetToolTip(DisplayButton, "Click here to display entered info")
        DisplayButton.UseVisualStyleBackColor = True
        ' 
        ' ClearButton
        ' 
        ClearButton.Location = New Point(542, 376)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(149, 112)
        ClearButton.TabIndex = 9
        ClearButton.Text = "Clear"
        ToolTip1.SetToolTip(ClearButton, "Clears entered info")
        ClearButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(706, 376)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(160, 112)
        ExitButton.TabIndex = 10
        ExitButton.Text = "Exit"
        ToolTip1.SetToolTip(ExitButton, "Close the window")
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' WordsLabel
        ' 
        WordsLabel.Location = New Point(6, 34)
        WordsLabel.Name = "WordsLabel"
        WordsLabel.Size = New Size(463, 199)
        WordsLabel.TabIndex = 12
        ' 
        ' AddressLabelBox
        ' 
        AddressLabelBox.Controls.Add(WordsLabel)
        AddressLabelBox.Location = New Point(317, 21)
        AddressLabelBox.Name = "AddressLabelBox"
        AddressLabelBox.Size = New Size(549, 328)
        AddressLabelBox.TabIndex = 13
        AddressLabelBox.TabStop = False
        AddressLabelBox.Text = "AddressLabel"
        ' 
        ' HWAddressLabel
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(986, 594)
        Controls.Add(AddressLabelBox)
        Controls.Add(ExitButton)
        Controls.Add(ClearButton)
        Controls.Add(DisplayButton)
        Controls.Add(MailingAddressGroupBox)
        Name = "HWAddressLabel"
        Text = "Form1"
        ToolTip1.SetToolTip(Me, "Displayed address will appear here")
        MailingAddressGroupBox.ResumeLayout(False)
        MailingAddressGroupBox.PerformLayout()
        AddressLabelBox.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents StreetAddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents MailingAddressGroupBox As GroupBox
    Friend WithEvents DisplayButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents WordsLabel As Label
    Friend WithEvents AddressLabelBox As GroupBox
    Friend WithEvents ToolTip1 As ToolTip

End Class
