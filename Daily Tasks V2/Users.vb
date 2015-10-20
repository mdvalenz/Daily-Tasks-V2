Public Class Users

    Private Sub saveExitUserButton_Click(sender As Object, e As EventArgs) Handles saveExitUserButton.Click
        Call saveUserRecord()
        Call resetForm()
        Close()
    End Sub

    Private Sub resetForm()

        'Clear the text boxes and set cursor
        firstNameUserTextBox.Text = ""
        lastNameUserTextBox.Text = ""
        loginIDUserTextBox.Text = ""
        emailUserTextBox.Text = ""
        userIDTextBox.Text = ""
        firstNameUserTextBox.Focus()

    End Sub

    Private Sub saveUserRecord()

        'Get Full Name and Login ID
        Dim firstNameText As String = firstNameUserTextBox.Text
        Dim lastNameText As String = lastNameUserTextBox.Text
        Dim loginIDText As String = loginIDUserTextBox.Text
        Dim emailText As String = emailUserTextBox.Text

        'Check if it is blank
        If firstNameText = "" Or lastNameText = "" Or loginIDText = "" Or emailText = "" Then
            MsgBox("Please fill in all boxes.")
            Exit Sub
        Else

            'Create new connection to the database
            Dim db As New accessDBManagerClass("Daily Task Log.accdb")

            If InStr(Me.Text, "Edit") And userIDTextBox.Text <> "" Then

                Dim userID As Integer = CInt(userIDTextBox.Text)

                'Edit user fields
                db.UpdateRecordField("Users", "FirstName", firstNameText, userID)
                db.UpdateRecordField("Users", "LastName", lastNameText, userID)
                db.UpdateRecordField("Users", "LoginID", loginIDText, userID)
                db.UpdateRecordField("Users", "Email", emailText, userID)

            Else

                'Add new user
                db.InsertRecord("Users", "FirstName,LastName,LoginID,Email", "'" &
                                firstNameText & "','" &
                                lastNameText & "','" &
                                loginIDText & "','" &
                                emailText & "'")

            End If


        End If

    End Sub

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class