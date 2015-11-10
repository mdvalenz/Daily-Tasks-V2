Imports System.Security.Cryptography
Imports System.Text

Public Class Settings
    Dim salt As String = ""

    Private Sub BrowseSettingsButton_Click(sender As Object, e As EventArgs) Handles BrowseSettingsButton.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "F:\QA\Daily Tasks\Database\"
        fd.Filter = "Microsoft Access Database (*.accdb)|*.accdb"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            My.Settings.DBLocation = fd.FileName
            DBSettingsTextBox.Text = My.Settings.DBLocation
        End If

    End Sub

    Private Sub exitSettingsButton_Click(sender As Object, e As EventArgs) Handles exitSettingsButton.Click
        My.Settings.Save()
        Close()
    End Sub

    Public Function CreateRandomSalt() As String
        'the following is the string that will hold the salt charachters
        Dim mix As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=][}{<>"
        Dim rnd As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 100 'Length of the salt
            Dim x As Integer = rnd.Next(0, mix.Length - 1)
            salt &= (mix.Substring(x, 1))
        Next
        Return salt
    End Function

    Public Function Hash512(password As String, salt As String) As String
        Dim convertedToBytes As Byte() = Encoding.UTF8.GetBytes(password & salt)
        Dim hashType As HashAlgorithm = New SHA512Managed()
        Dim hashBytes As Byte() = hashType.ComputeHash(convertedToBytes)
        Dim hashedResult As String = Convert.ToBase64String(hashBytes)
        Return hashedResult
    End Function

    Private Sub hashButton_Click(sender As Object, e As EventArgs) Handles hashButton.Click

        'Check old password
        If My.Settings.PasswordHash = (Hash512(oldPassTextBox.Text, My.Settings.PasswordSalt)) Or My.Settings.PasswordHash = "" Then

            'Check if both new password boxes are the same
            If newPassOneTextBox.Text = newPassTwoTextBox.Text Then
                My.Settings.PasswordHash = (Hash512(newPassOneTextBox.Text, CreateRandomSalt))
                My.Settings.PasswordSalt = salt
            Else
                MsgBox("The new passwords don't match. Please try again")
                Exit Sub
            End If
        Else
            MsgBox("The old password is not correct. Please try again.")
            Exit Sub
        End If

    End Sub

End Class