Imports System.Data.OleDb

Public Class Tags

    Private Sub saveExitUserButton_Click(sender As Object, e As EventArgs) Handles saveExitTagButton.Click
        Call saveTagRecord()
        Call resetForm()
        Close()
    End Sub

    Public Sub resetForm()

        'Clear the text boxes and set cursor
        tagTextBox.Text = ""
        tagTextBox.Focus()

    End Sub

    Private Sub saveTagRecord()

        'Get Full Name and Login ID
        Dim tagText As String = tagTextBox.Text

        'Check if it is blank
        If tagText = "" Then
            MsgBox("Please enter a tag.")
            Exit Sub
        Else

            'Create new connection to the database
            Dim db As New accessDBManagerClass("Daily Task Log.accdb")

            If InStr(Me.Text, "Edit") Then

                Dim tagID As Integer = CInt(tagIDTextBox.Text)

                If InStr(Me.Text, "General") And tagIDTextBox.Text <> "" Then

                    'Check if tag already exists
                    Dim tagCheck As OleDbDataReader = db.GetRecords("GeneralTags", "GeneralTag", "GeneralTag='" & tagText & "'")

                    If tagCheck.HasRows Then
                        MsgBox("Tag exists. Please try again")
                    Else
                        'Edit General Tag
                        db.UpdateRecordField("GeneralTags", "GeneralTag", tagText, tagID)
                    End If

                ElseIf InStr(Me.Text, "Specific") And tagIDTextBox.Text <> "" Then

                    'Check if tag already exists
                    Dim tagCheck As OleDbDataReader = db.GetRecords("SpecificTags", "SpecificTag", "SpecificTag='" & tagText & "'")

                    If tagCheck.HasRows Then
                        MsgBox("Tag exists. Please try again")
                    Else
                        'Edit Specific Tag
                        db.UpdateRecordField("SpecificTags", "SpecificTag", tagText, tagID)
                    End If

                ElseIf InStr(Me.Text, "Department") And tagIDTextBox.Text <> "" Then

                    'Check if tag already exists
                    Dim tagCheck As OleDbDataReader = db.GetRecords("DepartmentTags", "DepartmentTag", "DepartmentTag='" & tagText & "'")

                    If tagCheck.HasRows Then
                        MsgBox("Tag exists. Please try again")
                    Else
                        'Edit Department Tag
                        db.UpdateRecordField("DepartmentTags", "DepartmentTag", tagText, tagID)
                    End If

                End If

            Else

                '*****************check for entry first then save new
                If InStr(Me.Text, "General") Then

                    'Check if tag already exists
                    Dim tagCheck As OleDbDataReader = db.GetRecords("GeneralTags", "GeneralTag", "GeneralTag='" & tagText & "'")

                    If tagCheck.HasRows Then
                        MsgBox("Tag exists. Please try again")
                    Else
                        'Add new General Tag
                        db.InsertRecord("GeneralTags", "GeneralTag", "'" & tagText & "'")
                    End If

                ElseIf InStr(Me.Text, "Specific") Then

                    'Check if tag already exists
                    Dim tagCheck As OleDbDataReader = db.GetRecords("SpecificTags", "SpecificTag", "SpecificTag='" & tagText & "'")

                    If tagCheck.HasRows Then
                        MsgBox("Tag exists. Please try again")
                    Else
                        'Add new Specific Tag
                        db.InsertRecord("SpecificTags", "SpecificTag", "'" & tagText & "'")
                    End If

                ElseIf InStr(Me.Text, "Department") Then

                    'Check if tag already exists
                    Dim tagCheck As OleDbDataReader = db.GetRecords("DepartmentTags", "DepartmentTag", "DepartmentTag='" & tagText & "'")

                    If tagCheck.HasRows Then
                        MsgBox("Tag exists. Please try again")
                    Else
                        'Add new Department Tag
                        db.InsertRecord("DepartmentTags", "DepartmentTag", "'" & tagText & "'")
                    End If

                End If

            End If

        End If

    End Sub

    Private Sub Tags_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class