'Jacob Horsley
'RCET 0265
'Spring 2025
'Address Label Program
'URL: https://github.com/horsjaco117/AddressLabelHW

'TO DO:
'|x| Clear button to clear all entered info
'|x| reset all the text boxes upon entering data
'|x| get the carriage returns to work appropriately within the big box
'|x| Successfully rename the program
'|x| Make zip code exclusively for numbers

Option Strict On
Option Explicit On

Public Class HWAddressLabel
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles StateTextBox.TextChanged

    End Sub

    'Sub addtolist(thisString As String)
    '    ListBox1.Items.Add(thisString)
    'End Sub

    Sub SetDefaults()
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        StreetAddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipTextBox.Text = ""
        WordsLabel.Text = ""
        FirstNameTextBox.Focus()

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

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click

        If UserInputIsValid() Then 'Instead of having individual label for each text box these were concatenated into one
            WordsLabel.Text = FirstNameTextBox.Text.PadRight(10) &
                       LastNameTextBox.Text.PadRight(10) & vbCrLf &
                       StreetAddressTextBox.Text & vbCrLf &
                       CityTextBox.Text & ", " & StateTextBox.Text & " " & ZipTextBox.Text
        End If

        'FYI using a singular label for each text box would totally work also. Simplifies code. 

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
        'Console.WriteLine($"The information at {ListBox1.SelectedIndex} is {ListBox1.SelectedIndex}")
        'ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        WordsLabel.Text = ""
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        SetDefaults()
    End Sub

End Class
