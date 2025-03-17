'Jacob Horsley
'RCET 0265
'Spring 2025
'Address Label Program
'URL: 

'TO DO:
'| | Clear button to clear all entered info
'|x| reset all the text boxes upon entering data
'| | get the carriage returns to work appropriately within the big box
'| | 

Option Strict On
Option Explicit On

Public Class AddressLabel
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles StateTextBox.TextChanged

    End Sub

    Sub addtolist(thisString As String)
        ListBox1.Items.Add(thisString)
    End Sub

    Sub SetDefaults()
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        StreetAddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipTextBox.Text = ""
        FirstNameTextBox.Focus()
        If ListBox1.SelectedIndex = -1 Then
            ClearButton.Enabled = False
        Else
            ClearButton.Enabled = True
        End If

    End Sub
    Function UserInputIsValid() As Boolean
        Dim valid As Boolean = True
        Dim message As String

        If FirstNameTextBox.Text = "" Then
            valid = False
            FirstNameTextBox.Focus()
            message &= "First name is required."
        End If

        If LastNameTextBox.Text = "" Then
            valid = False
            LastNameTextBox.Focus()
            message &= "Last name is required."
        End If

        If StreetAddressTextBox.Text = "" Then
            valid = False
            StreetAddressTextBox.Text = ""
            message &= "Street address required."
        End If

        If CityTextBox.Text = "" Then
            valid = False
            CityTextBox.Text = ""
            message &= "City box required."
        End If

        If StateTextBox.Text = "" Then
            valid = False
            StateTextBox.Focus()
            message &= "State box required."
        End If

        If ZipTextBox.Text = "" Then
            valid = False
            ZipTextBox.Focus()
            message &= "Zip code box is empty."
        End If

        If Not valid Then
            MsgBox(message, MsgBoxStyle.Exclamation, "User Input Fail!")
        End If

        Return valid

    End Function

    Private Sub LastNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles LastNameTextBox.TextChanged

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        'If UserInputIsValid() Then
        '    FirstTextBox.Text = Scramble(FirstTextBox.Text)
        '    LastTextBox.Text = Scramble(LastTextBox.Text)
        '    SetCase()
        '    SetFormat()
        '    ReverseString()
        '    RemoveWhiteSpace()
        '    'ddToList(Me.Text)
        '    AddToList(FirstTextBox.Text.PadRight(10) & LastTextBox.Text.PadRight(10) & AgeTextBox.Text.PadLeft(3))
        '    SetDefaults()
        'End If

        If UserInputIsValid() Then
            addtolist(FirstNameTextBox.Text.PadRight(10) &
                      LastNameTextBox.Text.PadRight(10) & vbCrLf &
                      StreetAddressTextBox.Text & vbCrLf _
                      & CityTextBox.Text & ", " & StateTextBox.Text & ZipTextBox.Text)
        End If


        FirstNameTextBox.Clear()
        LastNameTextBox.Clear()
        StreetAddressTextBox.Clear()
        CityTextBox.Clear()
        StateTextBox.Clear()
        ZipTextBox.Clear()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDefaults()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Console.WriteLine($"The information at {ListBox1.SelectedIndex} is {ListBox1.SelectedIndex}")
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
    End Sub


    Private Sub ZipTextBox_TextChanged(sender As Object, e As EventArgs) Handles ZipTextBox.TextChanged

    End Sub

    Private Sub StreetAddressTextBox_TextChanged(sender As Object, e As EventArgs) Handles StreetAddressTextBox.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub


End Class
