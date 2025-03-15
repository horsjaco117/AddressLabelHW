'Jacob Horsley
'RCET 0265
'Spring 2025
'Address Label Program
'URL: 

Option Strict On
Option Explicit On

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles StateTextBox.TextChanged

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
            addtolist(FirstNameTextBox.Text.PadRight(10) & LastNameTextBox.Text.PadRight(10) & StreetAddressTextBox.Text _
                      & CityTextBox.Text & StateTextBox.Text & ZipTextBox.Text)
        End If
    End Sub

    Sub addtolist(thisString As String)
        ListBox1.Items.Add(thisString)
    End Sub

    Function UserInputIsValid() As Boolean
        Dim valid As Boolean = True
        Dim message As String

        If FirstNameTextBox.Text = "" Then
            valid = False
            FirstNameTextBox.Focus()
            message &= "First name is required."
        End If

        Return valid

    End Function
End Class
