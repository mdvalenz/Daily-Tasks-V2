Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports System.Security.Cryptography
Imports System.Text

Public Class Main

    Public Shared lastMonth As Integer
    Public Shared userLogin, userLoginID, userEmail, userFirstName, userLastName, userFullName, tagName, taskName, generalTag, specificTag, departmentTag As String
    Public Shared taskStartDate, taskEndDate As Date
    Public Shared tagID, taskID, userID As Integer

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadMain()
    End Sub

    Private Sub loadMain()

        'TODO: This line of code loads data into the 'Daily_Task_LogDataSet.DepartmentTags' table. You can move, or remove it, as needed.
        Me.DepartmentTagsTableAdapter.Fill(Me.Daily_Task_LogDataSet.DepartmentTags)
        DepartmentTagsBindingSource.Sort = "DepartmentTag ASC"

        'TODO: This line of code loads data into the 'Daily_Task_LogDataSet.SpecificTags' table. You can move, or remove it, as needed.
        Me.SpecificTagsTableAdapter.Fill(Me.Daily_Task_LogDataSet.SpecificTags)
        SpecificTagsBindingSource.Sort = "SpecificTag ASC"

        'TODO: This line of code loads data into the 'Daily_Task_LogDataSet.GeneralTags' table. You can move, or remove it, as needed.
        Me.GeneralTagsTableAdapter.Fill(Me.Daily_Task_LogDataSet.GeneralTags)
        GeneralTagsBindingSource.Sort = "GeneralTag ASC"

        'TODO: This line of code loads data into the 'Daily_Task_LogDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.Daily_Task_LogDataSet.Users)
        UsersBindingSource1.Sort = "Email ASC"

        'Load Task Tab 
        resetTaskTab()
        getMonth()

        'Fill Data Grid
        loadTaskDataGridView()

        'Load Tags Tab Data Grids
        loadGeneralTagsDataGridView()
        loadSpecificTagsDataGridView()
        loadDepartmentTagsDataGridView()

        'Load User Tab Data Grid
        loadUsersDataGridView()

    End Sub

    Public Sub refreshInformation(Tab As String)
        Try
            Me.Controls.Clear() 'removes all the controls on the form
        Catch
        End Try

        InitializeComponent() 'load all the controls again

        If Tab = "Tasks" Then
            'Main Task Tab
            userEmailMainComboBox.DataSource = UsersBindingSource2
            generalTagMainComboBox.DataSource = GeneralTagsBindingSource1
            specificTagMainComboBox.DataSource = SpecificTagsBindingSource1
            departmentTagMainComboBox.DataSource = DepartmentTagsBindingSource1

            'Task Form
            Tasks.taskUserEmailComboBox.DataSource = UsersBindingSource
            Tasks.taskGeneralTagComboBox.DataSource = GeneralTagsBindingSource
            Tasks.taskSpecificTagComboBox.DataSource = SpecificTagsBindingSource
            Tasks.taskDepartmentTagComboBox.DataSource = DepartmentTagsBindingSource

            loadMain()

        ElseIf Tab = "Tags" Then
            generalTagComboBox.DataSource = GeneralTagsBindingSource
            specificTagComboBox.DataSource = SpecificTagsBindingSource
            departmentTagComboBox.DataSource = DepartmentTagsBindingSource
            loadMain()

        ElseIf Tab = "Users" Then
            userEmailComboBox.DataSource = UsersBindingSource1
            loadMain()

        ElseIf Tab = "TaskTab" Then
            'Main Task Tab
            userEmailMainComboBox.DataSource = UsersBindingSource2
            generalTagMainComboBox.DataSource = GeneralTagsBindingSource1
            specificTagMainComboBox.DataSource = SpecificTagsBindingSource1
            departmentTagMainComboBox.DataSource = DepartmentTagsBindingSource1

            'Task Form
            Tasks.taskUserEmailComboBox.DataSource = UsersBindingSource
            Tasks.taskGeneralTagComboBox.DataSource = GeneralTagsBindingSource
            Tasks.taskSpecificTagComboBox.DataSource = SpecificTagsBindingSource
            Tasks.taskDepartmentTagComboBox.DataSource = DepartmentTagsBindingSource

            'Tags
            generalTagComboBox.DataSource = GeneralTagsBindingSource
            specificTagComboBox.DataSource = SpecificTagsBindingSource
            departmentTagComboBox.DataSource = DepartmentTagsBindingSource

            loadMain()

        ElseIf Tab = "EditTasks" Then
            'Main Task Tab
            userEmailMainComboBox.DataSource = UsersBindingSource2

            generalTagMainComboBox.DataSource = GeneralTagsBindingSource1

            specificTagMainComboBox.DataSource = SpecificTagsBindingSource1

            departmentTagMainComboBox.DataSource = DepartmentTagsBindingSource1


            'Task Form
            Tasks.taskUserEmailComboBox.DataSource = UsersBindingSource
            Tasks.taskGeneralTagComboBox.DataSource = GeneralTagsBindingSource
            Tasks.taskSpecificTagComboBox.DataSource = SpecificTagsBindingSource
            Tasks.taskDepartmentTagComboBox.DataSource = DepartmentTagsBindingSource

            loadMain()

            'Reset task tab to previous selections
            userEmailMainComboBox.Text = userEmail

            generalTagMainComboBox.Text = generalTag
            specificTagMainComboBox.Text = specificTag
            departmentTagMainComboBox.Text = departmentTag

            startDateTimeMainPicker.Value = taskStartDate
            endDateTimeMainPicker.Value = taskEndDate

            'Fill Data Grid
            loadTaskDataGridView()

        End If

    End Sub

    Private Sub SettingsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem1.Click
        Settings.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub emailMainButton_Click(sender As Object, e As EventArgs) Handles emailMainButton.Click
        Call createEmail()
    End Sub

    Dim filePrefix, fileName As String
    Dim Openfilename As String
    Dim LastRow As Integer

    'Dimension Arrays
    Dim ExportArray(8, 0) As String

    'Other file locations
    Dim ExportFilePath As String = Nothing
    Dim HTMLString As String = Nothing
    Dim HTMLFilePath As String = Nothing
    Dim myRange As Excel.Range

    Private Sub createEmail()

        'Clear Form
        resetTaskTab()

        'Get the month
        Dim selectedMonth As Integer = Nothing
        Select Case monthMainComboBox.Text
            Case "January"
                selectedMonth = 1
            Case "February"
                selectedMonth = 2
            Case "March"
                selectedMonth = 3
            Case "April"
                selectedMonth = 4
            Case "May"
                selectedMonth = 5
            Case "June"
                selectedMonth = 6
            Case "July"
                selectedMonth = 7
            Case "August"
                selectedMonth = 8
            Case "September"
                selectedMonth = 9
            Case "October"
                selectedMonth = 10
            Case "November"
                selectedMonth = 11
            Case "December"
                selectedMonth = 12
        End Select

        Select Case selectedMonth
            Case 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11
                startDateTimeMainPicker.Value = DateSerial(Today.Year, selectedMonth, 1)
                filePrefix = Format(startDateTimeMainPicker.Value, "yyyy-MM")
                endDateTimeMainPicker.Value = DateSerial(Today.Year, selectedMonth + 1, 0)
            Case 12
                startDateTimeMainPicker.Value = DateSerial(Today.Year - 1, selectedMonth, 1)
                endDateTimeMainPicker.Value = DateSerial(Today.Year - 1, selectedMonth + 1, 0)
        End Select

        'Get userFullName
        userFullName = userFirstName & " " & userLastName

        ProgressBar.exportProgressBar.Maximum = 100
        ProgressBar.exportProgressBar.Value = 0
        ProgressBar.Show()

        Call loadTaskDataGridView()

        Call exportMonthlyTaskList()

        ProgressBar.exportProgressBar.Value = 100
        ProgressBar.Update()
        ProgressBar.Show()

        Call emailMonthlyTaskList()

        ProgressBar.Show()
        ProgressBar.Close()

    End Sub

    Private Sub exportMonthlyTaskList()

        'Pull information from the datagridview and put into email or Excel
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("Sheet1")

        For i = 0 To DataGridView1.RowCount - 1

            Dim progressBarValue As Integer = ((i / (DataGridView1.RowCount)) / 2) * 100
            ProgressBar.exportProgressBar.Value = progressBarValue
            ProgressBar.Update()
            ProgressBar.Show()

            For j = 0 To DataGridView1.ColumnCount - 1
                For k As Integer = 1 To DataGridView1.Columns.Count
                    xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                Next
            Next
        Next

        ExportFilePath = "F:\QA\Daily Tasks\Excel\" & filePrefix & " " & userFullName & " Daily Tasks.xlsx"
        xlWorkSheet.SaveAs(ExportFilePath)
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        'Open Export File
        OpenExcel(ExportFilePath, "Sheet1")

        'MsgBox("You can find the file")

    End Sub

    Public Sub OpenExcel(ByVal FileName As String, ByVal SheetName As String)
        If IO.File.Exists(FileName) Then
            Dim Proceed As Boolean = False
            Dim xlApp As Microsoft.Office.Interop.Excel.Application = Nothing
            Dim xlWorkBooks As Microsoft.Office.Interop.Excel.Workbooks = Nothing
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook = Nothing
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet = Nothing
            Dim xlWorkSheets As Microsoft.Office.Interop.Excel.Sheets = Nothing
            Dim xlCells As Microsoft.Office.Interop.Excel.Range = Nothing
            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlApp.DisplayAlerts = False
            xlWorkBooks = xlApp.Workbooks
            xlWorkBook = xlWorkBooks.Open(FileName)
            xlApp.Visible = False
            xlApp.ScreenUpdating = False
            xlWorkSheets = xlWorkBook.Sheets
            For x As Integer = 1 To xlWorkSheets.Count
                xlWorkSheet = CType(xlWorkSheets(x), Microsoft.Office.Interop.Excel.Worksheet)
                If xlWorkSheet.Name = SheetName Then
                    Console.WriteLine(SheetName)
                    Proceed = True
                    Exit For
                End If
                Runtime.InteropServices.Marshal.FinalReleaseComObject(xlWorkSheet)
                xlWorkSheet = Nothing
            Next
            If Proceed Then
                xlWorkSheet.Activate()
                Openfilename = xlWorkBook.Name

                With xlWorkSheet

                    'Fit and filter
                    LastRow = .Range("A" & .Rows.Count).End(Microsoft.Office.Interop.Excel.XlDirection.xlUp).Row

                    If Not .AutoFilterMode Then 
                        .Range("A1:I" & LastRow).AutoFilter(Field:=2)

                        myRange = xlWorkSheet.Range("A2", "I" & LastRow)
                        myRange.Select()

                        'Sort by Date
                        myRange.Sort(Key1:=myRange.Range("B1"),
                                                Order1:=Excel.XlSortOrder.xlAscending,
                                                Orientation:=Excel.XlSortOrientation.xlSortColumns)
                    End If

                    .Columns.AutoFit()
                    xlApp.Visible = True
                    xlApp.ScreenUpdating = True
                    xlWorkBook.Save()

                    xlApp.Visible = False
                    xlApp.ScreenUpdating = False

                    'Create Arrays
                    ReDim ExportArray(8, LastRow)
                    Dim generalTagArray(3, 0) As String
                    Dim specificTagArray(3, 0) As String
                    Dim taskArray(2, 0) As String

                    Dim Present As Integer = Nothing
                    Dim generalCount As Integer = 0
                    Dim specificCount As Integer = 0
                    Dim taskCount As Integer = 0

                    'Work through worksheet and create HTML file

                    'Start HTML string
                    'Header
                    HTMLString = "<html lang=""en-GB"">" &
                                    "<head>" &
                                    "<meta http-equiv=""Content-Type"" content=""text/html;charset=utf-8"">" &
                                    "<meta name=""author"" content=""The CSS Ninja"">" &
                                    "<meta name=""keywords"" content=""CSS, Tree menu, checked pseudo-class, CSS Ninja"">" &
                                    "<meta name=""description"" content=""Create a pure CSS tree folder structure with collapsible folders utilizing checkboxes along with the checked pseudo-class"">" &
                                    "<meta name=""robots"" content=""all"">" &
                                    "<meta name=""copyright"" content=""The CSS Ninja"">" &
                                    "<!--[if gte IE 9 ]><link rel=""stylesheet"" type=""text/css"" href=""F:\QA\Daily Tasks\HTML\_styles.css"" media=""screen""><![endif]-->" &
                                    "<!--[if !IE]>--><link rel=""stylesheet"" type=""text/css"" href=""F:\QA\Daily Tasks\HTML\_styles.css"" media=""screen""><!--<![endif]-->" &
                                    "<title>" & userFullName & "'s Daily Tasks for " & monthMainComboBox.Text & "</title>" &
                                    "</head>"

                    'Start HTML Body
                    HTMLString &= "<body>" &
                                userFullName & "'s Daily Tasks for " & monthMainComboBox.Text &
                                "<ol class=""tree"">" &
                                "<li>"

                    'Get General Tags, number of items, and total minutes
                    'Sort alpha
                    myRange.Select()
                    myRange.Sort(Key1:=myRange.Range("G1"),
                                            Order1:=Excel.XlSortOrder.xlAscending,
                                            Orientation:=Excel.XlSortOrientation.xlSortColumns)

                    For RowNumGen = 2 To LastRow

                        If .Range("A" & RowNumGen).Text = "" Then Exit For
                        Present = 0

                        For checkGeneralTags = 2 To generalTagArray.GetUpperBound(1)
                            If generalTagArray(1, checkGeneralTags) = .Range("G" & RowNumGen).Value Then
                                generalTagArray(2, checkGeneralTags) += 1
                                generalTagArray(3, checkGeneralTags) += .Range("C" & RowNumGen).Value
                                Present = 1
                                Exit For
                            End If
                        Next

                        If Present = 0 Then
                            ReDim Preserve generalTagArray(3, RowNumGen)
                            generalTagArray(1, RowNumGen) = .Range("G" & RowNumGen).Value
                            generalTagArray(2, RowNumGen) = 1
                            generalTagArray(3, RowNumGen) = .Range("C" & RowNumGen).Value
                        End If

                    Next

                    'Filter by each General Tag
                    For generalTagCount = 2 To generalTagArray.GetUpperBound(1)

                        Dim progressBarValue As Integer = ((generalTagCount / generalTagArray.GetUpperBound(1)) / 2) * 100 + 50
                        ProgressBar.exportProgressBar.Value = progressBarValue
                        ProgressBar.Update()
                        ProgressBar.Show()

                        On Error Resume Next 'in case no dropdown arrows/filters are on the current sheet
                        .ShowAllData()
                        On Error GoTo 0

                        Dim generalTask As String = generalTagArray(1, generalTagCount)
                        'MessageBox.Show(generalTagArray(1, generalTagCount))

                        If generalTask <> "" Then

                            .Range("A1:I" & LastRow).AutoFilter(Field:=7, Criteria1:=generalTask)
                            generalCount = generalCount + 1

                            'Add General Tag to HTML String
                            Dim generalTime As String = Nothing
                            Dim generalTimeUnit As String = Nothing
                            If generalTagArray(3, generalTagCount) > 60 Then
                                generalTime = Format(generalTagArray(3, generalTagCount) / 60, "0.0")
                                generalTimeUnit = "hours"
                            Else
                                generalTime = generalTagArray(3, generalTagCount)
                                generalTimeUnit = "minutes"
                            End If

                            HTMLString &= "<label for=""generalTag" & generalCount & """>" & generalTagArray(1, generalTagCount) &
                                        " [" & generalTagArray(2, generalTagCount) & " items]" &
                                        "[" & generalTime & " " & generalTimeUnit & "]" &
                                        "</label> <input type=""checkbox"" id=""generalTag" & generalCount & """ />" &
                                        "<ol>" &
                                        "<li>"

                            'Get Specific Tags, number of items, and total time
                            ReDim specificTagArray(3, 0)

                            'Sort alpha
                            myRange.Select()
                            myRange.Sort(Key1:=myRange.Range("H1"),
                                                    Order1:=Excel.XlSortOrder.xlAscending,
                                                    Orientation:=Excel.XlSortOrientation.xlSortColumns)

                            For RowNumSpec = 2 To LastRow
                                If .Range("A" & RowNumSpec).Text = "" Then Exit For
                                Present = 0


                                If .Range("A" & RowNumSpec).Height <> 0 Then
                                    For checkSpecificTags = 2 To specificTagArray.GetUpperBound(1)
                                        If specificTagArray(1, checkSpecificTags) = .Range("H" & RowNumSpec).Value Then
                                            specificTagArray(2, checkSpecificTags) += +1
                                            specificTagArray(3, checkSpecificTags) += .Range("C" & RowNumSpec).Value
                                            Present = 1
                                            Exit For
                                        End If
                                    Next

                                    If Present = 0 Then
                                        ReDim Preserve specificTagArray(3, RowNumSpec)
                                        specificTagArray(1, RowNumSpec) = .Range("H" & RowNumSpec).Value
                                        specificTagArray(2, RowNumSpec) = 1
                                        specificTagArray(3, RowNumSpec) = .Range("C" & RowNumSpec).Value
                                    End If
                                End If
                            Next

                            'Filter by each Specific Tag
                            For specificTagCount = 2 To specificTagArray.GetUpperBound(1)
                                Dim specificTask As String = specificTagArray(1, specificTagCount)
                                'MessageBox.Show(specificTagArray(1, specificTagCount))

                                If specificTask <> "" Then

                                    .Range("A1:I" & LastRow).AutoFilter(Field:=8, Criteria1:=specificTask)
                                    specificCount = specificCount + 1

                                    'Add Specific Tag to HTML String
                                    Dim specificTime As String = Nothing
                                    Dim specificTimeUnit As String = Nothing
                                    If specificTagArray(3, specificTagCount) > 60 Then
                                        specificTime = Format(specificTagArray(3, specificTagCount) / 60, "0.0")
                                        specificTimeUnit = "hours"
                                    Else
                                        specificTime = specificTagArray(3, specificTagCount)
                                        specificTimeUnit = "minutes"
                                    End If

                                    HTMLString &= "<label for=""specificTag" & specificCount & """>" & specificTagArray(1, specificTagCount) &
                                                " [" & specificTagArray(2, specificTagCount) & " items]" &
                                                "[" & specificTime & " " & specificTimeUnit & "]" &
                                                "</label> <input type=""checkbox"" id=""specificTag" & specificCount & """ />" &
                                                "<ol>" &
                                                "<li>"

                                    'Get Task Names and times
                                    ReDim taskArray(2, 0)

                                    'Sort by date
                                    myRange.Select()
                                    myRange.Sort(Key1:=myRange.Range("B1"),
                                                            Order1:=Excel.XlSortOrder.xlAscending,
                                                            Orientation:=Excel.XlSortOrientation.xlSortColumns)

                                    For RowNumtTask = 2 To LastRow
                                        If .Range("A" & RowNumtTask).Text = "" Then Exit For

                                        If .Range("A" & RowNumtTask).Height <> 0 Then

                                            ReDim Preserve taskArray(2, RowNumtTask)
                                            taskArray(0, RowNumtTask) = Format(.Range("B" & RowNumtTask).Value, "MM/dd")
                                            taskArray(1, RowNumtTask) = .Range("D" & RowNumtTask).Value
                                            taskArray(2, RowNumtTask) = .Range("C" & RowNumtTask).Value

                                            If taskArray(1, RowNumtTask) <> "" Then
                                                taskCount = taskCount + 1

                                                'Put Tasks in HTML String
                                                Dim taskTime As String = Nothing
                                                Dim taskTimeUnit As String = Nothing
                                                If taskArray(2, RowNumtTask) > 60 Then
                                                    taskTime = Format(taskArray(2, RowNumtTask) / 60, "0.0")
                                                    taskTimeUnit = "hours"
                                                Else
                                                    taskTime = taskArray(2, RowNumtTask)
                                                    taskTimeUnit = "minutes"
                                                End If

                                                HTMLString &= "<label for=""task" & taskCount & """>" & taskArray(0, RowNumtTask) & " - " &
                                                            taskArray(1, RowNumtTask) & " [" & taskTime & " " & taskTimeUnit & "]" &
                                                            "</label> <input type=""checkbox"" id=""task" & taskCount & """ />"
                                            End If
                                        End If
                                    Next

                                    'Close Tasks and Specific Tag in HTML String
                                    HTMLString &= "</li>" &
                                                "</ol>"
                                End If
                            Next

                            'Close General Tag in HTML String
                            HTMLString &= "</li>" &
                                            "</ol>"
                        End If
                    Next

                    'Close Tree in HTML String
                    HTMLString &= "</li>" &
                                    "</ol>"

                    'Close Body and HTML in HTML String
                    HTMLString &= "</body>" &
                                    "</html>"

                    'Write HTML String to file
                    HTMLFilePath = "F:\QA\Daily Tasks\HTML\" & filePrefix & " " & userFullName & "'s Daily Tasks.html"
                    IO.File.WriteAllText(HTMLFilePath, HTMLString)

                    'Close Export File without saving
                    On Error Resume Next 'in case no dropdown arrows/filters are on the current sheet
                    .ShowAllData()
                    On Error GoTo 0

                    'Sort alpha
                    myRange.Select()
                    myRange.Sort(Key1:=myRange.Range("B1"),
                                            Order1:=Excel.XlSortOrder.xlAscending,
                                            Orientation:=Excel.XlSortOrientation.xlSortColumns)

                    xlApp.Visible = True
                    xlApp.ScreenUpdating = True
                    xlWorkBook.Close(SaveChanges:=True)
                    xlApp.UserControl = True
                    xlApp.Quit()

                    releaseObject(xlCells)
                    releaseObject(xlWorkSheets)
                    releaseObject(xlWorkSheet)
                    releaseObject(xlWorkBook)
                    releaseObject(xlWorkBooks)
                    releaseObject(xlApp)
                End With

                'Kill Export and Batch Files              
                'System.IO.File.Delete(ExportFilePath)

                'MessageBox.Show("File is open, if you close Excel just opened outside of this program we will crash-n-burn.")
            Else
                MessageBox.Show(SheetName & " not found.")
            End If

        Else
            MessageBox.Show("'" & FileName & "' not located. Try one of the write examples first.")
        End If
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub emailMonthlyTaskList()

        Dim OutlookMessage As Outlook.MailItem
        Dim AppOutlook As New Outlook.Application

        Dim objNS As Outlook._NameSpace = AppOutlook.Session
        Dim objFolder As Outlook.MAPIFolder
        objFolder = objNS.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDrafts)

        'Get recipients
        Dim recipients As String = Nothing
        Dim supervisor As String = Nothing
        Select Case userEmail
            Case "TakensB@TheNFL.com"
                supervisor = "Bob"
                recipients = "Bob Takens"
            Case "ValenzuelaM@TheNFL.com"
                supervisor = "Bob"
                recipients = "Bob Takens"
            Case "WillmoreC@TheNFL.com"
                supervisor = "Bob and Mario"
                recipients = "Bob Takens; Mario Valenzuela"
        End Select

        'Create subject
        Dim subject As String = Nothing
        subject = userFullName & "'s Daily Tasks for " & monthMainComboBox.Text

        'Create HTML Body
        Dim MsgTxt As String = Nothing
        MsgTxt &= "<p>Hello " & supervisor & ",</p>" &
        "<p>Here are my daily tasks for " & monthMainComboBox.Text & "." &
        "<br>Please use the included link if you would like more information.</p>"

        'Include link to the HTML file

        'Replace spaces with %20
        Dim urlstring As String = Nothing
        Do While InStr(HTMLFilePath, " ") > 0 'Replace spaces with %20
            urlstring = Mid(HTMLFilePath, 1, InStr(HTMLFilePath, " ") - 1) 'Portion before the space
            urlstring = urlstring & "%20"
            urlstring = urlstring & Mid(HTMLFilePath, InStr(HTMLFilePath, " ") + 1, Len(HTMLFilePath)) 'Portion after the space
            HTMLFilePath = urlstring
        Loop

        MsgTxt &= "<p><strong><A HREF=file://" & HTMLFilePath & ">" & subject & "</A></td></strong></p>"

        'Closing
        MsgTxt &= "<p>Thank you, <br><br>     " & userFullName

        ''Signature location for sending via Document Control
        'Dim sigstring As String = Nothing
        'SigString = Environ("appdata") & "\Microsoft\Signatures\Formal.htm"

        ''Set variables for the signature
        'Dim fso As Object = Nothing
        'Dim ts As Object = Nothing
        'Dim vsignature As Object = Nothing

        'fso = CreateObject("Scripting.FileSystemObject")
        'ts = fso.GetFile(SigString).OpenAsTextStream(1, -2)
        'vsignature = ts.readall

        Try
            OutlookMessage = AppOutlook.CreateItem(Outlook.OlItemType.olMailItem)
            Dim Recipents As Outlook.Recipients = OutlookMessage.Recipients
            Recipents.Add(recipients)
            OutlookMessage.Subject = subject
            OutlookMessage.BodyFormat = Outlook.OlBodyFormat.olFormatHTML
            OutlookMessage.HTMLBody = "<html><body>" & MsgTxt & "</body></html>"
            'OutlookMessage.Save()
            OutlookMessage.Display()
            'OutlookMessage.Move(objFolder)
        Catch ex As Exception
            MessageBox.Show("Mail could not be sent") 'if you dont want this message, simply delete this line    
        Finally
            OutlookMessage = Nothing
            AppOutlook = Nothing
        End Try


    End Sub



    'Task Tab*************************************************************************
    Private Sub resetTaskTab()

        'Reset Task Tab

        'Default show tasks from selected user
        generalTagMainComboBox.Text = "Select General Tag"
        specificTagMainComboBox.Text = "Select Specific Tag"
        departmentTagMainComboBox.Text = "Select Department Tag"

        totalMinutesMainTextBox.Text = ""
        totalHoursMainTextBox.Text = ""

        startDateTimeMainPicker.Value = Today
        endDateTimeMainPicker.Value = Today

        'Get User
        userLogin = Environment.UserName
        getUserEmail()

        userEmailMainComboBox.Text = userEmail

    End Sub

    Private Sub getMonth()

        'Fill in Month
        lastMonth = (Month(Today) - 1)

        Select Case lastMonth
            Case 1
                monthMainComboBox.Text = "January"
            Case 2
                monthMainComboBox.Text = "February"
            Case 3
                monthMainComboBox.Text = "March"
            Case 4
                monthMainComboBox.Text = "April"
            Case 5
                monthMainComboBox.Text = "May"
            Case 6
                monthMainComboBox.Text = "June"
            Case 7
                monthMainComboBox.Text = "July"
            Case 8
                monthMainComboBox.Text = "August"
            Case 9
                monthMainComboBox.Text = "September"
            Case 10
                monthMainComboBox.Text = "October"
            Case 11
                monthMainComboBox.Text = "November"
            Case 12, 0
                monthMainComboBox.Text = "December"
        End Select

    End Sub

    Private Sub getUserEmail()

        'Create new connection to the database
        Dim db As New accessDBManagerClass("Daily Task Log.accdb")

        'Create where variable
        Dim where As String = ""
        where = "LoginID='" & userLogin & "'"

        Dim reader As OleDbDataReader = db.GetRecords("Users", , where)

        While reader.Read
            userID = reader("ID")
            userEmail = reader("Email")
            userFirstName = reader("FirstName")
            userLastName = reader("LastName")
        End While

    End Sub

    Private Sub loadTaskDataGridView()

        'Get variables
        Dim selectedUserText As String = userEmailMainComboBox.Text
        Dim selectedUserID As Integer = userEmailMainComboBox.SelectedValue
        Dim selectedUserSQL As String = ""

        Dim startDate As Date = startDateTimeMainPicker.Value
        Dim endDate As Date = endDateTimeMainPicker.Value
        Dim dateSQL As String = ""

        Dim generalTagText As String = generalTagMainComboBox.Text
        Dim generalTagID As Integer = generalTagMainComboBox.SelectedValue
        Dim generalTagSQL As String = ""

        Dim specificTagText As String = specificTagMainComboBox.Text
        Dim specificTagID As Integer = specificTagMainComboBox.SelectedValue
        Dim specificTagSQL As String = ""

        Dim departmentTagText As String = departmentTagMainComboBox.Text
        Dim departmentTagID As Integer = departmentTagMainComboBox.SelectedValue
        Dim departmentTagSQL As String = ""

        Dim where As String = ""
        Dim fields As String = ""

        'Create new connection to the database
        Dim db As New accessDBManagerClass("Daily Task Log.accdb")

        'Create SQL variables

        'Show tasks between selected dates
        dateSQL = "(taskDate BETWEEN #" & startDate & "# and  #" & endDate & "#)"

        If selectedUserText <> "Select Email" And selectedUserText <> "" Or generalTagText <> "Select General Tag" And generalTagText <> "" Or specificTagText <> "Select Specific Tag" And specificTagText <> "" Or departmentTagText <> "Select Department Tag" And departmentTagText <> "" Then
            dateSQL &= " AND "
        End If

        If selectedUserText <> "Select Email" And selectedUserText <> "" Then
            selectedUserSQL = "User_ID=" & selectedUserID

            If generalTagText <> "Select General Tag" And generalTagText <> "" Or specificTagText <> "Select Specific Tag" And specificTagText <> "" Or departmentTagText <> "Select Department Tag" And departmentTagText <> "" Then
                selectedUserSQL &= " AND "
            End If
        End If

        If generalTagText <> "Select General Tag" And generalTagText <> "" Then
            generalTagSQL = "GeneralTag_ID=" & generalTagID

            If specificTagText <> "Select Specific Tag" And specificTagText <> "" And departmentTagText <> "Select Department Tag" And departmentTagText <> "" Then
                generalTagSQL &= " AND "
            End If
        End If

        If specificTagText <> "Select Specific Tag" And specificTagText <> "" Then
            specificTagSQL = "SpecificTag_ID=" & specificTagID

            If departmentTagText <> "Select Department Tag" And departmentTagText <> "" Then
                specificTagSQL &= " AND "
            End If
        End If

        If departmentTagText <> "Select Department Tag" And departmentTagText <> "" Then
            departmentTagSQL = "DepartmentTag_ID=" & departmentTagID
        End If

        'Create where Variable
        where = dateSQL & selectedUserSQL & generalTagSQL & specificTagSQL & departmentTagSQL

        'Create Fields String
        fields = "Tasks.[ID], Tasks.[TaskDate], Tasks.[TaskTime], Tasks.[TaskName], Tasks.[TaskDescription], Users.[FirstName] + ' ' + Users.[LastName] as UserName, GeneralTags.[GeneralTag], SpecificTags.[SpecificTag], DepartmentTags.[DepartmentTag]"

        'Get information from database
        Dim reader As OleDbDataReader = db.innerJoinRecord("Tasks", fields, where, "TaskDate")

        'Add information to datagridview
        Dim dt = New DataTable()
        dt.Load(reader)
        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = dt
        DataGridView1.Columns(0).Visible = False

        'Change Headers
        With DataGridView1
            .Columns(1).HeaderCell.Value = "Task Date"
            .Columns(2).HeaderCell.Value = "Task Time"
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).HeaderCell.Value = "Task Name"
            .Columns(4).HeaderCell.Value = "Task Description"
            .Columns(5).HeaderCell.Value = "User Name"
            .Columns(6).HeaderCell.Value = "General Tag"
            .Columns(7).HeaderCell.Value = "Specific Tag"
            .Columns(8).HeaderCell.Value = "Department Tag"
        End With

        DataGridView1.Refresh()

        'Get total minutes from database
        Dim taskTime As OleDbDataReader = db.getTaskTime(where)

        Try

            While taskTime.Read
                totalMinutesMainTextBox.Text = taskTime("TotalMinutes")
                Dim totalHours As Double = (taskTime("TotalMinutes") / 60)
                totalHoursMainTextBox.Text = Format(totalHours, "0.00")
            End While

        Catch ex As Exception
            totalMinutesMainTextBox.Text = ""
            totalHoursMainTextBox.Text = ""
            'MsgBox("Error occurred While displaying data from Tasks table " & vbNewLine &
            '       "Query String: " & where & vbNewLine &
            '       "Error message: " & ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub refreshTasksButton_Click(sender As Object, e As EventArgs) Handles refreshTasksButton.Click
        resetTaskTab()
        getMonth()
        loadTaskDataGridView()
    End Sub

    Private Sub searchMainButton_Click(sender As Object, e As EventArgs) Handles searchMainButton.Click
        loadTaskDataGridView()
    End Sub

    Private Sub NewTaskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewTaskToolStripMenuItem.Click
        addNewTask()
    End Sub

    Private Sub newTaskMainButton_Click(sender As Object, e As EventArgs) Handles newTaskMainButton.Click
        addNewTask()
    End Sub

    Public Sub addNewTask()
        'Open Form
        Tasks.resetForm()
        Tasks.Text = "Enter New Task"
        Tasks.taskEmailIDTextBox.Text = userID
        Tasks.ShowDialog()
        refreshInformation("Tasks")
        mainTabControl.SelectedTab = taskTabPage
    End Sub

    Private Sub editTaskButton_Click(sender As Object, e As EventArgs) Handles editTaskButton.Click

        'Get existing task data from database
        userEmail = userEmailComboBox.Text
        generalTag = generalTagMainComboBox.Text
        specificTag = specificTagMainComboBox.Text
        departmentTag = departmentTagMainComboBox.Text
        taskStartDate = startDateTimeMainPicker.Value
        taskEndDate = endDateTimeMainPicker.Value

        'Create new connection to the database
        Dim db As New accessDBManagerClass("Daily Task Log.accdb")

        'create where string
        Dim where As String = "ID=" & taskID

        'Get information from database
        Dim selectedTask As OleDbDataReader = db.GetRecords("Tasks",, where)

        'Enter existing task info on form 
        While selectedTask.Read
            Tasks.taskIDTextBox.Text = selectedTask("ID")
            Tasks.taskEmailIDTextBox.Text = selectedTask("User_ID")
            Tasks.taskTextBox.Text = selectedTask("TaskName")
            Tasks.taskDescriptionTextBox.Text = selectedTask("TaskDescription")
            Tasks.taskDatePicker.Value = selectedTask("TaskDate")
            Tasks.taskEstimatedTimeTextBox.Text = selectedTask("TaskTime")
            Tasks.taskGeneralTagIDTextBox.Text = selectedTask("GeneralTag_ID")
            Tasks.taskSpecificTagIDTextBox.Text = selectedTask("SpecificTag_ID")
            Tasks.taskDepartmentTagIDTextBox.Text = selectedTask("DepartmentTag_ID")
        End While

        'Open Form
        Tasks.Text = "Edit Task"
        Tasks.ShowDialog()
        refreshInformation("EditTasks")
        mainTabControl.SelectedTab = taskTabPage

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        'Get Task ID number
        If e.RowIndex <> -1 Then
            taskID = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            'taskName = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        End If

    End Sub

    Private Sub deleteTaskButton_Click(sender As Object, e As EventArgs) Handles deleteTaskButton.Click

        MsgBox("Are you sure you want to delete this task?" & vbNewLine & taskName, MsgBoxStyle.YesNo, "Delete Task")

        If vbYes = 6 Then

            password.ShowDialog()

            'Get entered password
            Dim enteredPassword As String = My.Settings.PasswordCheck

            'Get the salt from settings
            Dim passwordSalt As String = My.Settings.PasswordSalt

            'Check the entered hash against the true hash
            If My.Settings.PasswordHash = (Hash512(enteredPassword, passwordSalt)) Then

                'Create new connection to the database
                Dim db As New accessDBManagerClass("Daily Task Log.accdb")

                db.DeleteRecord("Tasks", "ID=" & taskID)

                refreshInformation("Tasks")
                resetTaskTab()

            Else
                MsgBox("Incorrect password. Please try again.")
            End If

        End If

    End Sub

    Public Function CreateRandomSalt() As String
        'the following is the string that will hold the salt charachters
        Dim mix As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=][}{<>"
        Dim salt As String = ""
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



    'Tags Tab**************************************************************************
    'General Tags********************************
    Private Sub loadGeneralTagsDataGridView()

        'Create new connection to the database
        Dim db As New accessDBManagerClass("Daily Task Log.accdb")

        'Get information from database
        Dim reader As OleDbDataReader = db.GetRecords("GeneralTags",,, "GeneralTag")

        'Add information to datagridview
        Dim dt = New DataTable()
        dt.Load(reader)
        DataGridView2.AutoGenerateColumns = True
        DataGridView2.DataSource = dt
        DataGridView2.Columns(0).Visible = False
        DataGridView2.Refresh()

    End Sub

    Private Sub NewGeneralTagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGeneralTagToolStripMenuItem.Click
        addNewGeneralTag()
    End Sub

    Private Sub newGeneralTagButton_Click(sender As Object, e As EventArgs) Handles newGeneralTagButton.Click
        addNewGeneralTag()
    End Sub

    Private Sub addNewGeneralTag()
        'Open Form
        Tags.resetForm()
        Tags.Text = "Enter New General Tag"
        Tags.ShowDialog()
        refreshInformation("Tags")
        mainTabControl.SelectedTab = tagsTabPage
    End Sub

    Private Sub editGeneralTagButton_Click(sender As Object, e As EventArgs) Handles editGeneralTagButton.Click

        'Enter existing tag info on form
        Tags.tagTextBox.Text = generalTagComboBox.Text
        Tags.tagIDTextBox.Text = generalTagComboBox.SelectedValue.ToString

        'Open Form
        Tags.Text = "Edit General Tag"
        Tags.ShowDialog()
        refreshInformation("Tags")
        mainTabControl.SelectedTab = tagsTabPage

    End Sub

    'Specific Tags*******************************
    Private Sub loadSpecificTagsDataGridView()

        'Create new connection to the database
        Dim db As New accessDBManagerClass("Daily Task Log.accdb")

        'Get information from database
        Dim reader As OleDbDataReader = db.GetRecords("SpecificTags",,, "SpecificTag")

        'Add information to datagridview
        Dim dt = New DataTable()
        dt.Load(reader)
        DataGridView3.AutoGenerateColumns = True
        DataGridView3.DataSource = dt
        DataGridView3.Columns(0).Visible = False
        DataGridView3.Refresh()

    End Sub

    Private Sub NewSpecificTagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewSpecificTagToolStripMenuItem.Click
        addNewSpecificTag()
    End Sub

    Private Sub newSpecificTagButton_Click(sender As Object, e As EventArgs) Handles newSpecificTagButton.Click
        addNewSpecificTag()
    End Sub

    Private Sub addNewSpecificTag()
        'Open Form
        Tags.resetForm()
        Tags.Text = "Enter New Specific Tag"
        Tags.ShowDialog()
        refreshInformation("Tags")
        mainTabControl.SelectedTab = tagsTabPage
    End Sub

    Private Sub editSpecificTagButton_Click(sender As Object, e As EventArgs) Handles editSpecificTagButton.Click

        'Enter existing user info on form
        Tags.tagTextBox.Text = specificTagComboBox.Text
        Tags.tagIDTextBox.Text = specificTagComboBox.SelectedValue.ToString

        'Open Form
        Tags.Text = "Edit Specific Tag"
        Tags.ShowDialog()
        refreshInformation("Tags")
        mainTabControl.SelectedTab = tagsTabPage

    End Sub

    'Department Tags*****************************
    Private Sub loadDepartmentTagsDataGridView()

        'Create new connection to the database
        Dim db As New accessDBManagerClass("Daily Task Log.accdb")

        'Get information from database
        Dim reader As OleDbDataReader = db.GetRecords("DepartmentTags",,, "DepartmentTag")

        'Add information to datagridview
        Dim dt = New DataTable()
        dt.Load(reader)
        DataGridView4.AutoGenerateColumns = True
        DataGridView4.DataSource = dt
        DataGridView4.Columns(0).Visible = False
        DataGridView4.Refresh()

    End Sub

    Private Sub NewDepartmentTagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewDepartmentTagToolStripMenuItem.Click
        addNewDepartmentTag()
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.GeneralTagsTableAdapter.FillBy(Me.Daily_Task_LogDataSet.GeneralTags)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub newDepartmentTagButton_Click(sender As Object, e As EventArgs) Handles newDepartmentTagButton.Click
        addNewDepartmentTag()
    End Sub

    Private Sub addNewDepartmentTag()
        'Open Form
        Tags.resetForm()
        Tags.Text = "Enter New Department Tag"
        Tags.ShowDialog()
        refreshInformation("Tags")
        mainTabControl.SelectedTab = tagsTabPage
    End Sub

    Private Sub editDepartmentTagButton_Click(sender As Object, e As EventArgs) Handles editDepartmentTagButton.Click

        'Enter existing user info on form
        Tags.tagTextBox.Text = departmentTagComboBox.Text
        Tags.tagIDTextBox.Text = departmentTagComboBox.SelectedValue.ToString

        'Open Form
        Tags.Text = "Edit Department Tag"
        Tags.ShowDialog()
        refreshInformation("Tags")
        mainTabControl.SelectedTab = tagsTabPage

    End Sub

    'Refresh All Tags****************************
    Private Sub refreshTagsButton_Click(sender As Object, e As EventArgs) Handles refreshTagsButton.Click
        refreshInformation("Tags")
        mainTabControl.SelectedTab = tagsTabPage
    End Sub



    'Users Tab*************************************************************************
    Private Sub loadUsersDataGridView()

        'Create new connection to the database
        Dim db As New accessDBManagerClass("Daily Task Log.accdb")

        'Get information from database
        Dim reader As OleDbDataReader = db.GetRecords("Users",,, "Email")

        'Add information to datagridview
        Dim dt = New DataTable()
        dt.Load(reader)
        DataGridView5.AutoGenerateColumns = True
        DataGridView5.DataSource = dt
        DataGridView5.Columns(0).Visible = False

        'Change Headers
        With DataGridView5
            .Columns(1).HeaderCell.Value = "First Name"
            .Columns(2).HeaderCell.Value = "Last Name"
            .Columns(3).HeaderCell.Value = "Login ID"
            .Columns(4).HeaderCell.Value = "Email"
        End With

        DataGridView5.Refresh()

    End Sub

    Private Sub NewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewUserToolStripMenuItem.Click
        addNewUser()
    End Sub

    Private Sub newUserButton_Click(sender As Object, e As EventArgs) Handles newUserButton.Click
        addNewUser()
    End Sub

    Private Sub addNewUser()
        'Open Form
        Users.resetForm()
        Users.Text = "Enter New User"
        Users.ShowDialog()
        refreshInformation("Users")
        mainTabControl.SelectedTab = userTabPage
    End Sub

    Private Sub editUserButton_Click(sender As Object, e As EventArgs) Handles editUserButton.Click



        'Enter existing user info on form
        Users.userIDTextBox.Text = userEmailComboBox.SelectedValue.ToString
        Users.firstNameUserTextBox.Text = userFirstNameTextBox.Text
        Users.lastNameUserTextBox.Text = userLastNameTextBox.Text
        Users.loginIDUserTextBox.Text = userLoginIDTextBox.Text
        Users.emailUserTextBox.Text = userEmailComboBox.Text

        'Open Form
        Users.Text = "Edit User"
        Users.ShowDialog()
        refreshInformation("Users")
        mainTabControl.SelectedTab = userTabPage

    End Sub

    Private Sub refreshUsersButton_Click(sender As Object, e As EventArgs) Handles refreshUsersButton.Click
        refreshInformation("Users")
        mainTabControl.SelectedTab = userTabPage
    End Sub

End Class
