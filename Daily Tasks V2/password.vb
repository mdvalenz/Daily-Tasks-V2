Public Class password

    Private Sub passwordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passwordTextBox.Text = ""
    End Sub

    Private Sub passwordButton_Click(sender As Object, e As EventArgs) Handles passwordButton.Click
        My.Settings.PasswordCheck = passwordTextBox.Text
        Close()
    End Sub

End Class