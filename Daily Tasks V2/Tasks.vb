Public Class Tasks
    Dim exitSub As Boolean = False

    Private Sub Tasks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loadTasks()
        Call setComboBoxes()
    End Sub

    Private Sub loadTasks()

        'TODO: This line of code loads data into the 'Daily_Task_LogDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.Daily_Task_LogDataSet.Users)
        UsersBindingSource.Sort = "Email ASC"

        'TODO: This line of code loads data into the 'Daily_Task_LogDataSet.DepartmentTags' table. You can move, or remove it, as needed.
        Me.DepartmentTagsTableAdapter.Fill(Me.Daily_Task_LogDataSet.DepartmentTags)
        DepartmentTagsBindingSource.Sort = "DepartmentTag ASC"

        'TODO: This line of code loads data into the 'Daily_Task_LogDataSet.SpecificTags' table. You can move, or remove it, as needed.
        Me.SpecificTagsTableAdapter.Fill(Me.Daily_Task_LogDataSet.SpecificTags)
        SpecificTagsBindingSource.Sort = "SpecificTag ASC"

        'TODO: This line of code loads data into the 'Daily_Task_LogDataSet.GeneralTags' table. You can move, or remove it, as needed.
        Me.GeneralTagsTableAdapter.Fill(Me.Daily_Task_LogDataSet.GeneralTags)
        GeneralTagsBindingSource.Sort = "GeneralTag ASC"

    End Sub

    Public Sub setComboBoxes()

        If InStr(Me.Text, "Edit") Then

            'Set combobox values
            taskUserEmailComboBox.SelectedValue = taskEmailIDTextBox.Text
            taskGeneralTagComboBox.SelectedValue = taskGeneralTagIDTextBox.Text
            taskSpecificTagComboBox.SelectedValue = taskSpecificTagIDTextBox.Text
            taskDepartmentTagComboBox.SelectedValue = taskDepartmentTagIDTextBox.Text

        ElseIf InStr(Me.Text, "New") Then

            taskUserEmailComboBox.SelectedValue = taskEmailIDTextBox.Text
            taskGeneralTagComboBox.Text = "Select General Tag"
            taskSpecificTagComboBox.Text = "Select Specific Tag"
            taskDepartmentTagComboBox.Text = "Select Department Tag"

        End If

    End Sub

    Private Sub taskEstimatedTimeTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles taskEstimatedTimeTextBox.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter whole numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub saveExitTaskButton_Click(sender As Object, e As EventArgs) Handles saveExitTaskButton.Click
        Call saveTaskRecord()
        Call resetForm()
        Close()
    End Sub

    Private Sub saveNewTaskButton_Click(sender As Object, e As EventArgs) Handles saveNewTaskButton.Click
        Dim selectedDate As Date = taskDatePicker.Value
        Call saveTaskRecord()
        Call resetForm()
        Me.Text = "Enter New Task"
        Call loadTasks()
        Call setComboBoxes()
        taskDatePicker.Value = selectedDate
    End Sub

    Private Sub saveTaskRecord()

        'Check Estimated Minutes
        If taskEstimatedTimeTextBox.Text = "" Or taskEstimatedTimeTextBox.Text = "0" Then
            MsgBox("Please enter your estimated minutes.")
            exitSub = True
        Else
            exitSub = False
        End If
        If exitSub = True Then Exit Sub

        'Check Task Name
        If taskTextBox.Text = "" Then
            MsgBox("Please enter the task name")
            exitSub = True
        Else
            exitSub = False
        End If
        If exitSub = True Then Exit Sub

        'Check Tags
        If taskGeneralTagComboBox.Text = "Select General Tag" Then
            MsgBox("Please select a general tag.")
            exitSub = True
        Else
            exitSub = False
        End If
        If exitSub = True Then Exit Sub

        If taskSpecificTagComboBox.Text = "Select Specific Tag" Then
            MsgBox("Please select a specific tag.")
            exitSub = True
        Else
            exitSub = False
        End If
        If exitSub = True Then Exit Sub

        If taskDepartmentTagComboBox.Text = "Select Department Tag" Then
            MsgBox("Please select a department tag.")
            exitSub = True
        Else
            exitSub = False
        End If
        If exitSub = True Then Exit Sub

        If exitSub = False Then

            'Get name, date, and task ID
            Dim userID As String = taskUserEmailComboBox.SelectedValue
            Dim enteredDate As Date = taskDatePicker.Value

            'Get Task, Description, Minutes, Tags, and Department
            Dim estimatedTime As Integer = Convert.ToInt32(taskEstimatedTimeTextBox.Text)
            Dim taskName As String = taskTextBox.Text
            Dim taskDescription As String = taskDescriptionTextBox.Text
            Dim generalTagID As String = taskGeneralTagComboBox.SelectedValue
            Dim specificTagID As String = taskSpecificTagComboBox.SelectedValue
            Dim departmentTagID As String = taskDepartmentTagComboBox.SelectedValue

            'Create new connection to the database
            Dim db As New accessDBManagerClass("Daily Task Log.accdb")

            'Determine if new task or edit
            If InStr(Me.Text, "Edit") And taskIDTextBox.Text <> "" Then

                Dim taskID As Integer = CInt(taskIDTextBox.Text)

                'Edit user fields
                db.UpdateRecordField("Tasks", "User_ID", userID, taskID)
                db.UpdateRecordField("Tasks", "TaskName", taskName, taskID)
                db.UpdateRecordField("Tasks", "TaskDescription", taskDescription, taskID)
                db.UpdateRecordField("Tasks", "TaskDate", enteredDate, taskID)
                db.UpdateRecordField("Tasks", "TaskTime", estimatedTime, taskID)
                db.UpdateRecordField("Tasks", "GeneralTag_ID", generalTagID, taskID)
                db.UpdateRecordField("Tasks", "SpecificTag_ID", specificTagID, taskID)
                db.UpdateRecordField("Tasks", "DepartmentTag_ID", departmentTagID, taskID)

            Else

                'Add new task
                db.InsertRecord("Tasks", "User_ID,TaskName,TaskDescription,TaskDate,TaskTime,GeneralTag_ID,SpecificTag_ID,DepartmentTag_ID", "'" &
                                userID & "','" &
                                taskName & "','" &
                                taskDescription & "','" &
                                enteredDate & "','" &
                                estimatedTime & "','" &
                                generalTagID & "','" &
                                specificTagID & "','" &
                                departmentTagID & "'")

            End If

        End If

    End Sub

    Public Sub resetForm()

        'Clear the text boxes and set cursor
        taskIDTextBox.Text = ""
        taskUserEmailComboBox.Text = ""
        taskDatePicker.Value = Today
        taskEstimatedTimeTextBox.Text = ""
        taskTextBox.Text = ""
        taskDescriptionTextBox.Text = ""
        taskGeneralTagComboBox.Text = "Select General Tag"
        taskSpecificTagComboBox.Text = "Select Specific Tag"
        taskDepartmentTagComboBox.Text = "Select Department Tag"
        taskEstimatedTimeTextBox.Focus()

    End Sub

    Private Sub newTaskGeneralTagButton_Click(sender As Object, e As EventArgs) Handles newTaskGeneralTagButton.Click

        taskEmailIDTextBox.Text = taskUserEmailComboBox.SelectedValue

        'Open Form
        Tags.resetForm()
        Tags.Text = "Enter New General Tag"
        Tags.ShowDialog()

        Main.refreshInformation("TaskTab")

        Call loadTasks()
        taskUserEmailComboBox.SelectedValue = taskEmailIDTextBox.Text
        taskGeneralTagComboBox.Text = "Select General Tag"
        taskSpecificTagComboBox.Text = "Select Specific Tag"
        taskDepartmentTagComboBox.Text = "Select Department Tag"

    End Sub

    Private Sub newTaskSpecificTagButton_Click(sender As Object, e As EventArgs) Handles newTaskSpecificTagButton.Click

        taskEmailIDTextBox.Text = taskUserEmailComboBox.SelectedValue

        'Open Form
        Tags.resetForm()
        Tags.Text = "Enter New Specific Tag"
        Tags.ShowDialog()

        Main.refreshInformation("TaskTab")

        Call loadTasks()
        taskUserEmailComboBox.SelectedValue = taskEmailIDTextBox.Text
        taskGeneralTagComboBox.Text = "Select General Tag"
        taskSpecificTagComboBox.Text = "Select Specific Tag"
        taskDepartmentTagComboBox.Text = "Select Department Tag"

    End Sub

    Private Sub newTaskDepartmentTagButton_Click(sender As Object, e As EventArgs) Handles newTaskDepartmentTagButton.Click

        taskEmailIDTextBox.Text = taskUserEmailComboBox.SelectedValue

        'Open Form
        Tags.resetForm()
        Tags.Text = "Enter New Department Tag"
        Tags.ShowDialog()

        Main.refreshInformation("TaskTab")

        Call loadTasks()
        taskUserEmailComboBox.SelectedValue = taskEmailIDTextBox.Text
        taskGeneralTagComboBox.Text = "Select General Tag"
        taskSpecificTagComboBox.Text = "Select Specific Tag"
        taskDepartmentTagComboBox.Text = "Select Department Tag"

    End Sub

    Private Sub refreshTagsButton_Click(sender As Object, e As EventArgs) Handles refreshTagsButton.Click
        refreshTags()
    End Sub

    Public Sub refreshTags()

        Main.refreshInformation("TaskTab")

        Call loadTasks()
        taskUserEmailComboBox.SelectedValue = taskEmailIDTextBox.Text
        taskGeneralTagComboBox.Text = "Select General Tag"
        taskSpecificTagComboBox.Text = "Select Specific Tag"
        taskDepartmentTagComboBox.Text = "Select Department Tag"

    End Sub

End Class