<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddressLabel
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
        ListBox1 = New ListBox()
        MailingAddressGroupBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' FirstNameTextBox
        ' 
        FirstNameTextBox.Location = New Point(16, 83)
        FirstNameTextBox.Name = "FirstNameTextBox"
        FirstNameTextBox.Size = New Size(150, 31)
        FirstNameTextBox.TabIndex = 0
        ' 
        ' LastNameTextBox
        ' 
        LastNameTextBox.Location = New Point(16, 145)
        LastNameTextBox.Name = "LastNameTextBox"
        LastNameTextBox.Size = New Size(150, 31)
        LastNameTextBox.TabIndex = 1
        ' 
        ' StreetAddressTextBox
        ' 
        StreetAddressTextBox.Location = New Point(16, 207)
        StreetAddressTextBox.Name = "StreetAddressTextBox"
        StreetAddressTextBox.Size = New Size(150, 31)
        StreetAddressTextBox.TabIndex = 2
        ' 
        ' CityTextBox
        ' 
        CityTextBox.Location = New Point(16, 269)
        CityTextBox.Name = "CityTextBox"
        CityTextBox.Size = New Size(150, 31)
        CityTextBox.TabIndex = 3
        ' 
        ' StateTextBox
        ' 
        StateTextBox.Location = New Point(16, 334)
        StateTextBox.Name = "StateTextBox"
        StateTextBox.Size = New Size(150, 31)
        StateTextBox.TabIndex = 4
        ' 
        ' ZipTextBox
        ' 
        ZipTextBox.Location = New Point(16, 396)
        ZipTextBox.Name = "ZipTextBox"
        ZipTextBox.Size = New Size(150, 31)
        ZipTextBox.TabIndex = 5
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
        MailingAddressGroupBox.Size = New Size(416, 502)
        MailingAddressGroupBox.TabIndex = 7
        MailingAddressGroupBox.TabStop = False
        MailingAddressGroupBox.Text = "Mailing Address"
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
        DisplayButton.Location = New Point(469, 330)
        DisplayButton.Name = "DisplayButton"
        DisplayButton.Size = New Size(131, 75)
        DisplayButton.TabIndex = 8
        DisplayButton.Text = "Display"
        DisplayButton.UseVisualStyleBackColor = True
        ' 
        ' ClearButton
        ' 
        ClearButton.Location = New Point(622, 333)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(119, 75)
        ClearButton.TabIndex = 9
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(756, 333)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(115, 75)
        ExitButton.TabIndex = 10
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 25
        ListBox1.Location = New Point(444, 30)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(411, 279)
        ListBox1.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(995, 615)
        Controls.Add(ListBox1)
        Controls.Add(ExitButton)
        Controls.Add(ClearButton)
        Controls.Add(DisplayButton)
        Controls.Add(MailingAddressGroupBox)
        Name = "Form1"
        Text = "Form1"
        MailingAddressGroupBox.ResumeLayout(False)
        MailingAddressGroupBox.PerformLayout()
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
    Friend WithEvents ListBox1 As ListBox

End Class
