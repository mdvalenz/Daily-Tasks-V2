<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGeneralTagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewSpecificTagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewDepartmentTagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mainTabControl = New System.Windows.Forms.TabControl()
        Me.taskTabPage = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.specificTagMainComboBox = New System.Windows.Forms.ComboBox()
        Me.SpecificTagsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Daily_Task_LogDataSet = New Daily_Tasks_V2.Daily_Task_LogDataSet()
        Me.deleteTaskButton = New System.Windows.Forms.Button()
        Me.editTaskButton = New System.Windows.Forms.Button()
        Me.departmentMainLabel = New System.Windows.Forms.Label()
        Me.departmentTagMainComboBox = New System.Windows.Forms.ComboBox()
        Me.DepartmentTagsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.monthMainComboBox = New System.Windows.Forms.ComboBox()
        Me.totalHoursMainTextBox = New System.Windows.Forms.TextBox()
        Me.totalMinutesMainTextBox = New System.Windows.Forms.TextBox()
        Me.totalHoursMainLabel = New System.Windows.Forms.Label()
        Me.totalTimeMainLabel = New System.Windows.Forms.Label()
        Me.searchMainLabel = New System.Windows.Forms.Label()
        Me.newTaskMainButton = New System.Windows.Forms.Button()
        Me.emailMainButton = New System.Windows.Forms.Button()
        Me.refreshTasksButton = New System.Windows.Forms.Button()
        Me.startDateMainLabel = New System.Windows.Forms.Label()
        Me.startDateTimeMainPicker = New System.Windows.Forms.DateTimePicker()
        Me.endDateMainLabel = New System.Windows.Forms.Label()
        Me.endDateTimeMainPicker = New System.Windows.Forms.DateTimePicker()
        Me.personMainLabel = New System.Windows.Forms.Label()
        Me.userEmailMainComboBox = New System.Windows.Forms.ComboBox()
        Me.UsersBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.tag1MainLabel = New System.Windows.Forms.Label()
        Me.searchMainButton = New System.Windows.Forms.Button()
        Me.generalTagMainComboBox = New System.Windows.Forms.ComboBox()
        Me.GeneralTagsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.tagsTabPage = New System.Windows.Forms.TabPage()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.departmentTagComboBox = New System.Windows.Forms.ComboBox()
        Me.DepartmentTagsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.editDepartmentTagButton = New System.Windows.Forms.Button()
        Me.newDepartmentTagButton = New System.Windows.Forms.Button()
        Me.departmentDepartmentLabel = New System.Windows.Forms.Label()
        Me.specificTagComboBox = New System.Windows.Forms.ComboBox()
        Me.SpecificTagsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.editSpecificTagButton = New System.Windows.Forms.Button()
        Me.newSpecificTagButton = New System.Windows.Forms.Button()
        Me.specificTagLabel = New System.Windows.Forms.Label()
        Me.generalTagComboBox = New System.Windows.Forms.ComboBox()
        Me.GeneralTagsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.editGeneralTagButton = New System.Windows.Forms.Button()
        Me.searchMainTagLabel = New System.Windows.Forms.Label()
        Me.newGeneralTagButton = New System.Windows.Forms.Button()
        Me.refreshTagsButton = New System.Windows.Forms.Button()
        Me.tagMainTagLabel = New System.Windows.Forms.Label()
        Me.userTabPage = New System.Windows.Forms.TabPage()
        Me.userLoginIDTextBox = New System.Windows.Forms.TextBox()
        Me.UsersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.usersLoginIDLabel = New System.Windows.Forms.Label()
        Me.userLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.userFirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.userUsersLabel = New System.Windows.Forms.Label()
        Me.userEmailLabel = New System.Windows.Forms.Label()
        Me.userEmailComboBox = New System.Windows.Forms.ComboBox()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.editUserButton = New System.Windows.Forms.Button()
        Me.searchUsersLabel = New System.Windows.Forms.Label()
        Me.newUserButton = New System.Windows.Forms.Button()
        Me.refreshUsersButton = New System.Windows.Forms.Button()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New Daily_Tasks_V2.Daily_Task_LogDataSetTableAdapters.UsersTableAdapter()
        Me.GeneralTagsTableAdapter = New Daily_Tasks_V2.Daily_Task_LogDataSetTableAdapters.GeneralTagsTableAdapter()
        Me.SpecificTagsTableAdapter = New Daily_Tasks_V2.Daily_Task_LogDataSetTableAdapters.SpecificTagsTableAdapter()
        Me.DepartmentTagsTableAdapter = New Daily_Tasks_V2.Daily_Task_LogDataSetTableAdapters.DepartmentTagsTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        Me.mainTabControl.SuspendLayout()
        Me.taskTabPage.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpecificTagsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Daily_Task_LogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentTagsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralTagsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tagsTabPage.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentTagsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpecificTagsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralTagsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.userTabPage.SuspendLayout()
        CType(Me.UsersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AddToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1158, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTaskToolStripMenuItem, Me.NewGeneralTagToolStripMenuItem, Me.NewSpecificTagToolStripMenuItem, Me.NewDepartmentTagToolStripMenuItem, Me.NewUserToolStripMenuItem})
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'NewTaskToolStripMenuItem
        '
        Me.NewTaskToolStripMenuItem.Name = "NewTaskToolStripMenuItem"
        Me.NewTaskToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.NewTaskToolStripMenuItem.Text = "New Task"
        '
        'NewGeneralTagToolStripMenuItem
        '
        Me.NewGeneralTagToolStripMenuItem.Name = "NewGeneralTagToolStripMenuItem"
        Me.NewGeneralTagToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.NewGeneralTagToolStripMenuItem.Text = "New General Tag"
        '
        'NewSpecificTagToolStripMenuItem
        '
        Me.NewSpecificTagToolStripMenuItem.Name = "NewSpecificTagToolStripMenuItem"
        Me.NewSpecificTagToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.NewSpecificTagToolStripMenuItem.Text = "New Specific Tag"
        '
        'NewDepartmentTagToolStripMenuItem
        '
        Me.NewDepartmentTagToolStripMenuItem.Name = "NewDepartmentTagToolStripMenuItem"
        Me.NewDepartmentTagToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.NewDepartmentTagToolStripMenuItem.Text = "New Department Tag"
        '
        'NewUserToolStripMenuItem
        '
        Me.NewUserToolStripMenuItem.Name = "NewUserToolStripMenuItem"
        Me.NewUserToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.NewUserToolStripMenuItem.Text = "New User"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem1})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.SettingsToolStripMenuItem.Text = "Edit"
        '
        'SettingsToolStripMenuItem1
        '
        Me.SettingsToolStripMenuItem1.Name = "SettingsToolStripMenuItem1"
        Me.SettingsToolStripMenuItem1.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem1.Text = "Settings"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'mainTabControl
        '
        Me.mainTabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainTabControl.Controls.Add(Me.taskTabPage)
        Me.mainTabControl.Controls.Add(Me.tagsTabPage)
        Me.mainTabControl.Controls.Add(Me.userTabPage)
        Me.mainTabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainTabControl.Location = New System.Drawing.Point(0, 31)
        Me.mainTabControl.Name = "mainTabControl"
        Me.mainTabControl.Padding = New System.Drawing.Point(50, 10)
        Me.mainTabControl.SelectedIndex = 0
        Me.mainTabControl.Size = New System.Drawing.Size(1146, 502)
        Me.mainTabControl.TabIndex = 42
        Me.mainTabControl.TabStop = False
        '
        'taskTabPage
        '
        Me.taskTabPage.AutoScroll = True
        Me.taskTabPage.Controls.Add(Me.DataGridView1)
        Me.taskTabPage.Controls.Add(Me.Label1)
        Me.taskTabPage.Controls.Add(Me.specificTagMainComboBox)
        Me.taskTabPage.Controls.Add(Me.deleteTaskButton)
        Me.taskTabPage.Controls.Add(Me.editTaskButton)
        Me.taskTabPage.Controls.Add(Me.departmentMainLabel)
        Me.taskTabPage.Controls.Add(Me.departmentTagMainComboBox)
        Me.taskTabPage.Controls.Add(Me.monthMainComboBox)
        Me.taskTabPage.Controls.Add(Me.totalHoursMainTextBox)
        Me.taskTabPage.Controls.Add(Me.totalMinutesMainTextBox)
        Me.taskTabPage.Controls.Add(Me.totalHoursMainLabel)
        Me.taskTabPage.Controls.Add(Me.totalTimeMainLabel)
        Me.taskTabPage.Controls.Add(Me.searchMainLabel)
        Me.taskTabPage.Controls.Add(Me.newTaskMainButton)
        Me.taskTabPage.Controls.Add(Me.emailMainButton)
        Me.taskTabPage.Controls.Add(Me.refreshTasksButton)
        Me.taskTabPage.Controls.Add(Me.startDateMainLabel)
        Me.taskTabPage.Controls.Add(Me.startDateTimeMainPicker)
        Me.taskTabPage.Controls.Add(Me.endDateMainLabel)
        Me.taskTabPage.Controls.Add(Me.endDateTimeMainPicker)
        Me.taskTabPage.Controls.Add(Me.personMainLabel)
        Me.taskTabPage.Controls.Add(Me.userEmailMainComboBox)
        Me.taskTabPage.Controls.Add(Me.tag1MainLabel)
        Me.taskTabPage.Controls.Add(Me.searchMainButton)
        Me.taskTabPage.Controls.Add(Me.generalTagMainComboBox)
        Me.taskTabPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taskTabPage.Location = New System.Drawing.Point(4, 43)
        Me.taskTabPage.Name = "taskTabPage"
        Me.taskTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.taskTabPage.Size = New System.Drawing.Size(1138, 455)
        Me.taskTabPage.TabIndex = 0
        Me.taskTabPage.Text = "Tasks"
        Me.taskTabPage.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(375, 65)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.Size = New System.Drawing.Size(760, 385)
        Me.DataGridView1.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Specific Tag"
        '
        'specificTagMainComboBox
        '
        Me.specificTagMainComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.specificTagMainComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.specificTagMainComboBox.DataSource = Me.SpecificTagsBindingSource1
        Me.specificTagMainComboBox.DisplayMember = "SpecificTag"
        Me.specificTagMainComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specificTagMainComboBox.FormattingEnabled = True
        Me.specificTagMainComboBox.Location = New System.Drawing.Point(135, 221)
        Me.specificTagMainComboBox.Name = "specificTagMainComboBox"
        Me.specificTagMainComboBox.Size = New System.Drawing.Size(234, 28)
        Me.specificTagMainComboBox.TabIndex = 4
        Me.specificTagMainComboBox.Tag = ""
        Me.specificTagMainComboBox.ValueMember = "ID"
        '
        'SpecificTagsBindingSource1
        '
        Me.SpecificTagsBindingSource1.DataMember = "SpecificTags"
        Me.SpecificTagsBindingSource1.DataSource = Me.Daily_Task_LogDataSet
        Me.SpecificTagsBindingSource1.Sort = "SpecificTag"
        '
        'Daily_Task_LogDataSet
        '
        Me.Daily_Task_LogDataSet.DataSetName = "Daily_Task_LogDataSet"
        Me.Daily_Task_LogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'deleteTaskButton
        '
        Me.deleteTaskButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteTaskButton.Location = New System.Drawing.Point(637, 20)
        Me.deleteTaskButton.Name = "deleteTaskButton"
        Me.deleteTaskButton.Size = New System.Drawing.Size(125, 30)
        Me.deleteTaskButton.TabIndex = 50
        Me.deleteTaskButton.TabStop = False
        Me.deleteTaskButton.Text = "Delete Task"
        Me.deleteTaskButton.UseVisualStyleBackColor = True
        '
        'editTaskButton
        '
        Me.editTaskButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editTaskButton.Location = New System.Drawing.Point(506, 20)
        Me.editTaskButton.Name = "editTaskButton"
        Me.editTaskButton.Size = New System.Drawing.Size(125, 30)
        Me.editTaskButton.TabIndex = 49
        Me.editTaskButton.TabStop = False
        Me.editTaskButton.Text = "Edit Task"
        Me.editTaskButton.UseVisualStyleBackColor = True
        '
        'departmentMainLabel
        '
        Me.departmentMainLabel.AutoSize = True
        Me.departmentMainLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departmentMainLabel.Location = New System.Drawing.Point(4, 258)
        Me.departmentMainLabel.Name = "departmentMainLabel"
        Me.departmentMainLabel.Size = New System.Drawing.Size(125, 20)
        Me.departmentMainLabel.TabIndex = 48
        Me.departmentMainLabel.Text = "Department Tag"
        '
        'departmentTagMainComboBox
        '
        Me.departmentTagMainComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.departmentTagMainComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.departmentTagMainComboBox.DataSource = Me.DepartmentTagsBindingSource1
        Me.departmentTagMainComboBox.DisplayMember = "DepartmentTag"
        Me.departmentTagMainComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departmentTagMainComboBox.FormattingEnabled = True
        Me.departmentTagMainComboBox.Location = New System.Drawing.Point(135, 255)
        Me.departmentTagMainComboBox.Name = "departmentTagMainComboBox"
        Me.departmentTagMainComboBox.Size = New System.Drawing.Size(234, 28)
        Me.departmentTagMainComboBox.TabIndex = 5
        Me.departmentTagMainComboBox.ValueMember = "ID"
        '
        'DepartmentTagsBindingSource1
        '
        Me.DepartmentTagsBindingSource1.DataMember = "DepartmentTags"
        Me.DepartmentTagsBindingSource1.DataSource = Me.Daily_Task_LogDataSet
        Me.DepartmentTagsBindingSource1.Sort = "DepartmentTag"
        '
        'monthMainComboBox
        '
        Me.monthMainComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.monthMainComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monthMainComboBox.FormattingEnabled = True
        Me.monthMainComboBox.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.monthMainComboBox.Location = New System.Drawing.Point(987, 21)
        Me.monthMainComboBox.Name = "monthMainComboBox"
        Me.monthMainComboBox.Size = New System.Drawing.Size(102, 28)
        Me.monthMainComboBox.TabIndex = 46
        Me.monthMainComboBox.TabStop = False
        '
        'totalHoursMainTextBox
        '
        Me.totalHoursMainTextBox.Location = New System.Drawing.Point(210, 382)
        Me.totalHoursMainTextBox.Name = "totalHoursMainTextBox"
        Me.totalHoursMainTextBox.Size = New System.Drawing.Size(100, 26)
        Me.totalHoursMainTextBox.TabIndex = 45
        Me.totalHoursMainTextBox.TabStop = False
        Me.totalHoursMainTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'totalMinutesMainTextBox
        '
        Me.totalMinutesMainTextBox.Location = New System.Drawing.Point(59, 382)
        Me.totalMinutesMainTextBox.Name = "totalMinutesMainTextBox"
        Me.totalMinutesMainTextBox.Size = New System.Drawing.Size(100, 26)
        Me.totalMinutesMainTextBox.TabIndex = 44
        Me.totalMinutesMainTextBox.TabStop = False
        Me.totalMinutesMainTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'totalHoursMainLabel
        '
        Me.totalHoursMainLabel.AutoSize = True
        Me.totalHoursMainLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalHoursMainLabel.Location = New System.Drawing.Point(215, 411)
        Me.totalHoursMainLabel.Name = "totalHoursMainLabel"
        Me.totalHoursMainLabel.Size = New System.Drawing.Size(91, 20)
        Me.totalHoursMainLabel.TabIndex = 43
        Me.totalHoursMainLabel.Text = "Total Hours"
        '
        'totalTimeMainLabel
        '
        Me.totalTimeMainLabel.AutoSize = True
        Me.totalTimeMainLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalTimeMainLabel.Location = New System.Drawing.Point(55, 411)
        Me.totalTimeMainLabel.Name = "totalTimeMainLabel"
        Me.totalTimeMainLabel.Size = New System.Drawing.Size(104, 20)
        Me.totalTimeMainLabel.TabIndex = 41
        Me.totalTimeMainLabel.Text = "Total Minutes"
        '
        'searchMainLabel
        '
        Me.searchMainLabel.AutoSize = True
        Me.searchMainLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchMainLabel.Location = New System.Drawing.Point(149, 18)
        Me.searchMainLabel.Name = "searchMainLabel"
        Me.searchMainLabel.Size = New System.Drawing.Size(89, 29)
        Me.searchMainLabel.TabIndex = 21
        Me.searchMainLabel.Text = "Search"
        '
        'newTaskMainButton
        '
        Me.newTaskMainButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newTaskMainButton.Location = New System.Drawing.Point(375, 20)
        Me.newTaskMainButton.Name = "newTaskMainButton"
        Me.newTaskMainButton.Size = New System.Drawing.Size(125, 30)
        Me.newTaskMainButton.TabIndex = 5
        Me.newTaskMainButton.TabStop = False
        Me.newTaskMainButton.Text = "New Task"
        Me.newTaskMainButton.UseVisualStyleBackColor = True
        '
        'emailMainButton
        '
        Me.emailMainButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailMainButton.Location = New System.Drawing.Point(768, 20)
        Me.emailMainButton.Name = "emailMainButton"
        Me.emailMainButton.Size = New System.Drawing.Size(213, 30)
        Me.emailMainButton.TabIndex = 8
        Me.emailMainButton.TabStop = False
        Me.emailMainButton.Text = "Create Monthly Task Email for:"
        Me.emailMainButton.UseVisualStyleBackColor = True
        '
        'refreshTasksButton
        '
        Me.refreshTasksButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshTasksButton.Location = New System.Drawing.Point(49, 318)
        Me.refreshTasksButton.Name = "refreshTasksButton"
        Me.refreshTasksButton.Size = New System.Drawing.Size(125, 30)
        Me.refreshTasksButton.TabIndex = 40
        Me.refreshTasksButton.TabStop = False
        Me.refreshTasksButton.Text = "Refresh Table"
        Me.refreshTasksButton.UseVisualStyleBackColor = True
        '
        'startDateMainLabel
        '
        Me.startDateMainLabel.AutoSize = True
        Me.startDateMainLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startDateMainLabel.Location = New System.Drawing.Point(46, 113)
        Me.startDateMainLabel.Name = "startDateMainLabel"
        Me.startDateMainLabel.Size = New System.Drawing.Size(83, 20)
        Me.startDateMainLabel.TabIndex = 17
        Me.startDateMainLabel.Text = "Start Date"
        '
        'startDateTimeMainPicker
        '
        Me.startDateTimeMainPicker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startDateTimeMainPicker.CustomFormat = "MM/dd/yyyy"
        Me.startDateTimeMainPicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startDateTimeMainPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.startDateTimeMainPicker.Location = New System.Drawing.Point(135, 110)
        Me.startDateTimeMainPicker.MaxDate = New Date(2200, 12, 31, 0, 0, 0, 0)
        Me.startDateTimeMainPicker.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.startDateTimeMainPicker.Name = "startDateTimeMainPicker"
        Me.startDateTimeMainPicker.Size = New System.Drawing.Size(121, 26)
        Me.startDateTimeMainPicker.TabIndex = 1
        '
        'endDateMainLabel
        '
        Me.endDateMainLabel.AutoSize = True
        Me.endDateMainLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endDateMainLabel.Location = New System.Drawing.Point(52, 145)
        Me.endDateMainLabel.Name = "endDateMainLabel"
        Me.endDateMainLabel.Size = New System.Drawing.Size(77, 20)
        Me.endDateMainLabel.TabIndex = 19
        Me.endDateMainLabel.Text = "End Date"
        '
        'endDateTimeMainPicker
        '
        Me.endDateTimeMainPicker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endDateTimeMainPicker.CustomFormat = "MM/dd/yyyy"
        Me.endDateTimeMainPicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endDateTimeMainPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.endDateTimeMainPicker.Location = New System.Drawing.Point(135, 142)
        Me.endDateTimeMainPicker.MaxDate = New Date(2200, 12, 31, 0, 0, 0, 0)
        Me.endDateTimeMainPicker.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.endDateTimeMainPicker.Name = "endDateTimeMainPicker"
        Me.endDateTimeMainPicker.Size = New System.Drawing.Size(121, 26)
        Me.endDateTimeMainPicker.TabIndex = 2
        '
        'personMainLabel
        '
        Me.personMainLabel.AutoSize = True
        Me.personMainLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.personMainLabel.Location = New System.Drawing.Point(43, 68)
        Me.personMainLabel.Name = "personMainLabel"
        Me.personMainLabel.Size = New System.Drawing.Size(86, 20)
        Me.personMainLabel.TabIndex = 22
        Me.personMainLabel.Text = "User Email"
        '
        'userEmailMainComboBox
        '
        Me.userEmailMainComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.userEmailMainComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.userEmailMainComboBox.DataSource = Me.UsersBindingSource2
        Me.userEmailMainComboBox.DisplayMember = "Email"
        Me.userEmailMainComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userEmailMainComboBox.FormattingEnabled = True
        Me.userEmailMainComboBox.Location = New System.Drawing.Point(135, 65)
        Me.userEmailMainComboBox.Name = "userEmailMainComboBox"
        Me.userEmailMainComboBox.Size = New System.Drawing.Size(234, 28)
        Me.userEmailMainComboBox.TabIndex = 0
        Me.userEmailMainComboBox.ValueMember = "ID"
        '
        'UsersBindingSource2
        '
        Me.UsersBindingSource2.DataMember = "Users"
        Me.UsersBindingSource2.DataSource = Me.Daily_Task_LogDataSet
        Me.UsersBindingSource2.Sort = "Email"
        '
        'tag1MainLabel
        '
        Me.tag1MainLabel.AutoSize = True
        Me.tag1MainLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tag1MainLabel.Location = New System.Drawing.Point(32, 190)
        Me.tag1MainLabel.Name = "tag1MainLabel"
        Me.tag1MainLabel.Size = New System.Drawing.Size(97, 20)
        Me.tag1MainLabel.TabIndex = 29
        Me.tag1MainLabel.Text = "General Tag"
        '
        'searchMainButton
        '
        Me.searchMainButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchMainButton.Location = New System.Drawing.Point(200, 318)
        Me.searchMainButton.Name = "searchMainButton"
        Me.searchMainButton.Size = New System.Drawing.Size(125, 30)
        Me.searchMainButton.TabIndex = 6
        Me.searchMainButton.Text = "Search"
        Me.searchMainButton.UseVisualStyleBackColor = True
        '
        'generalTagMainComboBox
        '
        Me.generalTagMainComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.generalTagMainComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.generalTagMainComboBox.DataSource = Me.GeneralTagsBindingSource1
        Me.generalTagMainComboBox.DisplayMember = "GeneralTag"
        Me.generalTagMainComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.generalTagMainComboBox.FormattingEnabled = True
        Me.generalTagMainComboBox.Location = New System.Drawing.Point(135, 187)
        Me.generalTagMainComboBox.Name = "generalTagMainComboBox"
        Me.generalTagMainComboBox.Size = New System.Drawing.Size(234, 28)
        Me.generalTagMainComboBox.TabIndex = 3
        Me.generalTagMainComboBox.Tag = ""
        Me.generalTagMainComboBox.ValueMember = "ID"
        '
        'GeneralTagsBindingSource1
        '
        Me.GeneralTagsBindingSource1.DataMember = "GeneralTags"
        Me.GeneralTagsBindingSource1.DataSource = Me.Daily_Task_LogDataSet
        Me.GeneralTagsBindingSource1.Sort = "GeneralTag"
        '
        'tagsTabPage
        '
        Me.tagsTabPage.Controls.Add(Me.DataGridView4)
        Me.tagsTabPage.Controls.Add(Me.DataGridView3)
        Me.tagsTabPage.Controls.Add(Me.DataGridView2)
        Me.tagsTabPage.Controls.Add(Me.departmentTagComboBox)
        Me.tagsTabPage.Controls.Add(Me.editDepartmentTagButton)
        Me.tagsTabPage.Controls.Add(Me.newDepartmentTagButton)
        Me.tagsTabPage.Controls.Add(Me.departmentDepartmentLabel)
        Me.tagsTabPage.Controls.Add(Me.specificTagComboBox)
        Me.tagsTabPage.Controls.Add(Me.editSpecificTagButton)
        Me.tagsTabPage.Controls.Add(Me.newSpecificTagButton)
        Me.tagsTabPage.Controls.Add(Me.specificTagLabel)
        Me.tagsTabPage.Controls.Add(Me.generalTagComboBox)
        Me.tagsTabPage.Controls.Add(Me.editGeneralTagButton)
        Me.tagsTabPage.Controls.Add(Me.searchMainTagLabel)
        Me.tagsTabPage.Controls.Add(Me.newGeneralTagButton)
        Me.tagsTabPage.Controls.Add(Me.refreshTagsButton)
        Me.tagsTabPage.Controls.Add(Me.tagMainTagLabel)
        Me.tagsTabPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tagsTabPage.Location = New System.Drawing.Point(4, 43)
        Me.tagsTabPage.Name = "tagsTabPage"
        Me.tagsTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.tagsTabPage.Size = New System.Drawing.Size(1138, 455)
        Me.tagsTabPage.TabIndex = 1
        Me.tagsTabPage.Text = "Tags"
        Me.tagsTabPage.UseVisualStyleBackColor = True
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToAddRows = False
        Me.DataGridView4.AllowUserToDeleteRows = False
        Me.DataGridView4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.ColumnHeadersVisible = False
        Me.DataGridView4.Location = New System.Drawing.Point(782, 166)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.ReadOnly = True
        Me.DataGridView4.RowHeadersVisible = False
        Me.DataGridView4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView4.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView4.Size = New System.Drawing.Size(350, 283)
        Me.DataGridView4.TabIndex = 85
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.ColumnHeadersVisible = False
        Me.DataGridView3.Location = New System.Drawing.Point(396, 166)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView3.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView3.Size = New System.Drawing.Size(350, 283)
        Me.DataGridView3.TabIndex = 84
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.ColumnHeadersVisible = False
        Me.DataGridView2.Location = New System.Drawing.Point(11, 166)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.Size = New System.Drawing.Size(350, 283)
        Me.DataGridView2.TabIndex = 83
        '
        'departmentTagComboBox
        '
        Me.departmentTagComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.departmentTagComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.departmentTagComboBox.DataSource = Me.DepartmentTagsBindingSource
        Me.departmentTagComboBox.DisplayMember = "DepartmentTag"
        Me.departmentTagComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departmentTagComboBox.FormattingEnabled = True
        Me.departmentTagComboBox.Location = New System.Drawing.Point(782, 96)
        Me.departmentTagComboBox.Name = "departmentTagComboBox"
        Me.departmentTagComboBox.Size = New System.Drawing.Size(350, 28)
        Me.departmentTagComboBox.TabIndex = 2
        Me.departmentTagComboBox.ValueMember = "ID"
        '
        'DepartmentTagsBindingSource
        '
        Me.DepartmentTagsBindingSource.DataMember = "DepartmentTags"
        Me.DepartmentTagsBindingSource.DataSource = Me.Daily_Task_LogDataSet
        Me.DepartmentTagsBindingSource.Sort = "DepartmentTag"
        '
        'editDepartmentTagButton
        '
        Me.editDepartmentTagButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editDepartmentTagButton.Location = New System.Drawing.Point(957, 130)
        Me.editDepartmentTagButton.Name = "editDepartmentTagButton"
        Me.editDepartmentTagButton.Size = New System.Drawing.Size(175, 30)
        Me.editDepartmentTagButton.TabIndex = 78
        Me.editDepartmentTagButton.TabStop = False
        Me.editDepartmentTagButton.Text = "Edit Department Tag"
        Me.editDepartmentTagButton.UseVisualStyleBackColor = True
        '
        'newDepartmentTagButton
        '
        Me.newDepartmentTagButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newDepartmentTagButton.Location = New System.Drawing.Point(782, 130)
        Me.newDepartmentTagButton.Name = "newDepartmentTagButton"
        Me.newDepartmentTagButton.Size = New System.Drawing.Size(175, 30)
        Me.newDepartmentTagButton.TabIndex = 75
        Me.newDepartmentTagButton.TabStop = False
        Me.newDepartmentTagButton.Text = "New Department Tag"
        Me.newDepartmentTagButton.UseVisualStyleBackColor = True
        '
        'departmentDepartmentLabel
        '
        Me.departmentDepartmentLabel.AutoSize = True
        Me.departmentDepartmentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departmentDepartmentLabel.Location = New System.Drawing.Point(892, 73)
        Me.departmentDepartmentLabel.Name = "departmentDepartmentLabel"
        Me.departmentDepartmentLabel.Size = New System.Drawing.Size(133, 20)
        Me.departmentDepartmentLabel.TabIndex = 77
        Me.departmentDepartmentLabel.Text = "Department Tags"
        '
        'specificTagComboBox
        '
        Me.specificTagComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.specificTagComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.specificTagComboBox.DataSource = Me.SpecificTagsBindingSource
        Me.specificTagComboBox.DisplayMember = "SpecificTag"
        Me.specificTagComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specificTagComboBox.FormattingEnabled = True
        Me.specificTagComboBox.Location = New System.Drawing.Point(396, 96)
        Me.specificTagComboBox.Name = "specificTagComboBox"
        Me.specificTagComboBox.Size = New System.Drawing.Size(350, 28)
        Me.specificTagComboBox.TabIndex = 1
        Me.specificTagComboBox.ValueMember = "ID"
        '
        'SpecificTagsBindingSource
        '
        Me.SpecificTagsBindingSource.DataMember = "SpecificTags"
        Me.SpecificTagsBindingSource.DataSource = Me.Daily_Task_LogDataSet
        Me.SpecificTagsBindingSource.Sort = "SpecificTag"
        '
        'editSpecificTagButton
        '
        Me.editSpecificTagButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editSpecificTagButton.Location = New System.Drawing.Point(571, 130)
        Me.editSpecificTagButton.Name = "editSpecificTagButton"
        Me.editSpecificTagButton.Size = New System.Drawing.Size(175, 30)
        Me.editSpecificTagButton.TabIndex = 73
        Me.editSpecificTagButton.TabStop = False
        Me.editSpecificTagButton.Text = "Edit Specific Tag"
        Me.editSpecificTagButton.UseVisualStyleBackColor = True
        '
        'newSpecificTagButton
        '
        Me.newSpecificTagButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newSpecificTagButton.Location = New System.Drawing.Point(396, 130)
        Me.newSpecificTagButton.Name = "newSpecificTagButton"
        Me.newSpecificTagButton.Size = New System.Drawing.Size(175, 30)
        Me.newSpecificTagButton.TabIndex = 70
        Me.newSpecificTagButton.TabStop = False
        Me.newSpecificTagButton.Text = "New Specific Tag"
        Me.newSpecificTagButton.UseVisualStyleBackColor = True
        '
        'specificTagLabel
        '
        Me.specificTagLabel.AutoSize = True
        Me.specificTagLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specificTagLabel.Location = New System.Drawing.Point(521, 73)
        Me.specificTagLabel.Name = "specificTagLabel"
        Me.specificTagLabel.Size = New System.Drawing.Size(104, 20)
        Me.specificTagLabel.TabIndex = 72
        Me.specificTagLabel.Text = "Specific Tags"
        '
        'generalTagComboBox
        '
        Me.generalTagComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.generalTagComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.generalTagComboBox.DataSource = Me.GeneralTagsBindingSource
        Me.generalTagComboBox.DisplayMember = "GeneralTag"
        Me.generalTagComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.generalTagComboBox.FormattingEnabled = True
        Me.generalTagComboBox.Location = New System.Drawing.Point(11, 96)
        Me.generalTagComboBox.Name = "generalTagComboBox"
        Me.generalTagComboBox.Size = New System.Drawing.Size(350, 28)
        Me.generalTagComboBox.TabIndex = 0
        Me.generalTagComboBox.ValueMember = "ID"
        '
        'GeneralTagsBindingSource
        '
        Me.GeneralTagsBindingSource.DataMember = "GeneralTags"
        Me.GeneralTagsBindingSource.DataSource = Me.Daily_Task_LogDataSet
        Me.GeneralTagsBindingSource.Sort = "GeneralTag"
        '
        'editGeneralTagButton
        '
        Me.editGeneralTagButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editGeneralTagButton.Location = New System.Drawing.Point(186, 130)
        Me.editGeneralTagButton.Name = "editGeneralTagButton"
        Me.editGeneralTagButton.Size = New System.Drawing.Size(175, 30)
        Me.editGeneralTagButton.TabIndex = 66
        Me.editGeneralTagButton.TabStop = False
        Me.editGeneralTagButton.Text = "Edit General Tag"
        Me.editGeneralTagButton.UseVisualStyleBackColor = True
        '
        'searchMainTagLabel
        '
        Me.searchMainTagLabel.AutoSize = True
        Me.searchMainTagLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchMainTagLabel.Location = New System.Drawing.Point(139, 13)
        Me.searchMainTagLabel.Name = "searchMainTagLabel"
        Me.searchMainTagLabel.Size = New System.Drawing.Size(142, 29)
        Me.searchMainTagLabel.TabIndex = 52
        Me.searchMainTagLabel.Text = "Tag Lookup"
        '
        'newGeneralTagButton
        '
        Me.newGeneralTagButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newGeneralTagButton.Location = New System.Drawing.Point(11, 130)
        Me.newGeneralTagButton.Name = "newGeneralTagButton"
        Me.newGeneralTagButton.Size = New System.Drawing.Size(175, 30)
        Me.newGeneralTagButton.TabIndex = 45
        Me.newGeneralTagButton.TabStop = False
        Me.newGeneralTagButton.Text = "New General Tag"
        Me.newGeneralTagButton.UseVisualStyleBackColor = True
        '
        'refreshTagsButton
        '
        Me.refreshTagsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshTagsButton.Location = New System.Drawing.Point(375, 15)
        Me.refreshTagsButton.Name = "refreshTagsButton"
        Me.refreshTagsButton.Size = New System.Drawing.Size(125, 30)
        Me.refreshTagsButton.TabIndex = 57
        Me.refreshTagsButton.TabStop = False
        Me.refreshTagsButton.Text = "Refresh Tags"
        Me.refreshTagsButton.UseVisualStyleBackColor = True
        '
        'tagMainTagLabel
        '
        Me.tagMainTagLabel.AutoSize = True
        Me.tagMainTagLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tagMainTagLabel.Location = New System.Drawing.Point(132, 73)
        Me.tagMainTagLabel.Name = "tagMainTagLabel"
        Me.tagMainTagLabel.Size = New System.Drawing.Size(105, 20)
        Me.tagMainTagLabel.TabIndex = 53
        Me.tagMainTagLabel.Text = "General Tags"
        '
        'userTabPage
        '
        Me.userTabPage.Controls.Add(Me.userLoginIDTextBox)
        Me.userTabPage.Controls.Add(Me.usersLoginIDLabel)
        Me.userTabPage.Controls.Add(Me.userLastNameTextBox)
        Me.userTabPage.Controls.Add(Me.Label2)
        Me.userTabPage.Controls.Add(Me.userFirstNameTextBox)
        Me.userTabPage.Controls.Add(Me.userUsersLabel)
        Me.userTabPage.Controls.Add(Me.userEmailLabel)
        Me.userTabPage.Controls.Add(Me.userEmailComboBox)
        Me.userTabPage.Controls.Add(Me.DataGridView5)
        Me.userTabPage.Controls.Add(Me.editUserButton)
        Me.userTabPage.Controls.Add(Me.searchUsersLabel)
        Me.userTabPage.Controls.Add(Me.newUserButton)
        Me.userTabPage.Controls.Add(Me.refreshUsersButton)
        Me.userTabPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userTabPage.Location = New System.Drawing.Point(4, 43)
        Me.userTabPage.Name = "userTabPage"
        Me.userTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.userTabPage.Size = New System.Drawing.Size(1138, 455)
        Me.userTabPage.TabIndex = 2
        Me.userTabPage.Text = "Users"
        Me.userTabPage.UseVisualStyleBackColor = True
        '
        'userLoginIDTextBox
        '
        Me.userLoginIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource1, "LoginID", True))
        Me.userLoginIDTextBox.Location = New System.Drawing.Point(100, 230)
        Me.userLoginIDTextBox.Name = "userLoginIDTextBox"
        Me.userLoginIDTextBox.ReadOnly = True
        Me.userLoginIDTextBox.Size = New System.Drawing.Size(234, 26)
        Me.userLoginIDTextBox.TabIndex = 89
        Me.userLoginIDTextBox.TabStop = False
        '
        'UsersBindingSource1
        '
        Me.UsersBindingSource1.DataMember = "Users"
        Me.UsersBindingSource1.DataSource = Me.Daily_Task_LogDataSet
        Me.UsersBindingSource1.Sort = "Email"
        '
        'usersLoginIDLabel
        '
        Me.usersLoginIDLabel.AutoSize = True
        Me.usersLoginIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usersLoginIDLabel.Location = New System.Drawing.Point(25, 233)
        Me.usersLoginIDLabel.Name = "usersLoginIDLabel"
        Me.usersLoginIDLabel.Size = New System.Drawing.Size(69, 20)
        Me.usersLoginIDLabel.TabIndex = 90
        Me.usersLoginIDLabel.Text = "Login ID"
        '
        'userLastNameTextBox
        '
        Me.userLastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource1, "LastName", True))
        Me.userLastNameTextBox.Location = New System.Drawing.Point(100, 184)
        Me.userLastNameTextBox.Name = "userLastNameTextBox"
        Me.userLastNameTextBox.ReadOnly = True
        Me.userLastNameTextBox.Size = New System.Drawing.Size(234, 26)
        Me.userLastNameTextBox.TabIndex = 87
        Me.userLastNameTextBox.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Last name"
        '
        'userFirstNameTextBox
        '
        Me.userFirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource1, "FirstName", True))
        Me.userFirstNameTextBox.Location = New System.Drawing.Point(100, 141)
        Me.userFirstNameTextBox.Name = "userFirstNameTextBox"
        Me.userFirstNameTextBox.ReadOnly = True
        Me.userFirstNameTextBox.Size = New System.Drawing.Size(234, 26)
        Me.userFirstNameTextBox.TabIndex = 85
        Me.userFirstNameTextBox.TabStop = False
        '
        'userUsersLabel
        '
        Me.userUsersLabel.AutoSize = True
        Me.userUsersLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userUsersLabel.Location = New System.Drawing.Point(10, 144)
        Me.userUsersLabel.Name = "userUsersLabel"
        Me.userUsersLabel.Size = New System.Drawing.Size(84, 20)
        Me.userUsersLabel.TabIndex = 86
        Me.userUsersLabel.Text = "First name"
        '
        'userEmailLabel
        '
        Me.userEmailLabel.AutoSize = True
        Me.userEmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userEmailLabel.Location = New System.Drawing.Point(8, 67)
        Me.userEmailLabel.Name = "userEmailLabel"
        Me.userEmailLabel.Size = New System.Drawing.Size(86, 20)
        Me.userEmailLabel.TabIndex = 84
        Me.userEmailLabel.Text = "User Email"
        '
        'userEmailComboBox
        '
        Me.userEmailComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.userEmailComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.userEmailComboBox.DataSource = Me.UsersBindingSource1
        Me.userEmailComboBox.DisplayMember = "Email"
        Me.userEmailComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userEmailComboBox.FormattingEnabled = True
        Me.userEmailComboBox.Location = New System.Drawing.Point(100, 64)
        Me.userEmailComboBox.Name = "userEmailComboBox"
        Me.userEmailComboBox.Size = New System.Drawing.Size(234, 28)
        Me.userEmailComboBox.TabIndex = 0
        Me.userEmailComboBox.ValueMember = "ID"
        '
        'DataGridView5
        '
        Me.DataGridView5.AllowUserToAddRows = False
        Me.DataGridView5.AllowUserToDeleteRows = False
        Me.DataGridView5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView5.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Location = New System.Drawing.Point(375, 64)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.ReadOnly = True
        Me.DataGridView5.RowHeadersVisible = False
        Me.DataGridView5.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView5.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView5.Size = New System.Drawing.Size(757, 385)
        Me.DataGridView5.TabIndex = 82
        Me.DataGridView5.TabStop = False
        '
        'editUserButton
        '
        Me.editUserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editUserButton.Location = New System.Drawing.Point(209, 98)
        Me.editUserButton.Name = "editUserButton"
        Me.editUserButton.Size = New System.Drawing.Size(125, 30)
        Me.editUserButton.TabIndex = 66
        Me.editUserButton.TabStop = False
        Me.editUserButton.Text = "Edit User"
        Me.editUserButton.UseVisualStyleBackColor = True
        '
        'searchUsersLabel
        '
        Me.searchUsersLabel.AutoSize = True
        Me.searchUsersLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchUsersLabel.Location = New System.Drawing.Point(136, 13)
        Me.searchUsersLabel.Name = "searchUsersLabel"
        Me.searchUsersLabel.Size = New System.Drawing.Size(150, 29)
        Me.searchUsersLabel.TabIndex = 60
        Me.searchUsersLabel.Text = "User Lookup"
        '
        'newUserButton
        '
        Me.newUserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newUserButton.Location = New System.Drawing.Point(100, 98)
        Me.newUserButton.Name = "newUserButton"
        Me.newUserButton.Size = New System.Drawing.Size(103, 30)
        Me.newUserButton.TabIndex = 59
        Me.newUserButton.TabStop = False
        Me.newUserButton.Text = "New User"
        Me.newUserButton.UseVisualStyleBackColor = True
        '
        'refreshUsersButton
        '
        Me.refreshUsersButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshUsersButton.Location = New System.Drawing.Point(375, 15)
        Me.refreshUsersButton.Name = "refreshUsersButton"
        Me.refreshUsersButton.Size = New System.Drawing.Size(125, 30)
        Me.refreshUsersButton.TabIndex = 64
        Me.refreshUsersButton.TabStop = False
        Me.refreshUsersButton.Text = "Refresh Users"
        Me.refreshUsersButton.UseVisualStyleBackColor = True
        Me.refreshUsersButton.Visible = False
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.Daily_Task_LogDataSet
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'GeneralTagsTableAdapter
        '
        Me.GeneralTagsTableAdapter.ClearBeforeFill = True
        '
        'SpecificTagsTableAdapter
        '
        Me.SpecificTagsTableAdapter.ClearBeforeFill = True
        '
        'DepartmentTagsTableAdapter
        '
        Me.DepartmentTagsTableAdapter.ClearBeforeFill = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1158, 545)
        Me.Controls.Add(Me.mainTabControl)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1174, 583)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily Tasks"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.mainTabControl.ResumeLayout(False)
        Me.taskTabPage.ResumeLayout(False)
        Me.taskTabPage.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpecificTagsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Daily_Task_LogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentTagsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralTagsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tagsTabPage.ResumeLayout(False)
        Me.tagsTabPage.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentTagsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpecificTagsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralTagsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.userTabPage.ResumeLayout(False)
        Me.userTabPage.PerformLayout()
        CType(Me.UsersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mainTabControl As TabControl
    Friend WithEvents taskTabPage As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents specificTagMainComboBox As ComboBox
    Friend WithEvents deleteTaskButton As Button
    Friend WithEvents editTaskButton As Button
    Friend WithEvents departmentMainLabel As Label
    Friend WithEvents departmentTagMainComboBox As ComboBox
    Friend WithEvents monthMainComboBox As ComboBox
    Friend WithEvents totalHoursMainTextBox As TextBox
    Friend WithEvents totalMinutesMainTextBox As TextBox
    Friend WithEvents totalHoursMainLabel As Label
    Friend WithEvents totalTimeMainLabel As Label
    Friend WithEvents searchMainLabel As Label
    Friend WithEvents newTaskMainButton As Button
    Friend WithEvents emailMainButton As Button
    Friend WithEvents refreshTasksButton As Button
    Friend WithEvents startDateMainLabel As Label
    Friend WithEvents startDateTimeMainPicker As DateTimePicker
    Friend WithEvents endDateMainLabel As Label
    Friend WithEvents endDateTimeMainPicker As DateTimePicker
    Friend WithEvents personMainLabel As Label
    Friend WithEvents userEmailMainComboBox As ComboBox
    Friend WithEvents tag1MainLabel As Label
    Friend WithEvents searchMainButton As Button
    Friend WithEvents generalTagMainComboBox As ComboBox
    Friend WithEvents tagsTabPage As TabPage
    Friend WithEvents searchMainTagLabel As Label
    Friend WithEvents newGeneralTagButton As Button
    Friend WithEvents refreshTagsButton As Button
    Friend WithEvents tagMainTagLabel As Label
    Friend WithEvents userTabPage As TabPage
    Friend WithEvents searchUsersLabel As Label
    Friend WithEvents newUserButton As Button
    Friend WithEvents refreshUsersButton As Button
    Friend WithEvents editGeneralTagButton As Button
    Friend WithEvents editUserButton As Button
    Friend WithEvents generalTagComboBox As ComboBox
    Friend WithEvents departmentTagComboBox As ComboBox
    Friend WithEvents editDepartmentTagButton As Button
    Friend WithEvents newDepartmentTagButton As Button
    Friend WithEvents departmentDepartmentLabel As Label
    Friend WithEvents specificTagComboBox As ComboBox
    Friend WithEvents editSpecificTagButton As Button
    Friend WithEvents newSpecificTagButton As Button
    Friend WithEvents specificTagLabel As Label
    Friend WithEvents Daily_Task_LogDataSet As Daily_Task_LogDataSet
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As Daily_Task_LogDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents UsersBindingSource1 As BindingSource
    Friend WithEvents GeneralTagsBindingSource As BindingSource
    Friend WithEvents GeneralTagsTableAdapter As Daily_Task_LogDataSetTableAdapters.GeneralTagsTableAdapter
    Friend WithEvents SpecificTagsBindingSource As BindingSource
    Friend WithEvents SpecificTagsTableAdapter As Daily_Task_LogDataSetTableAdapters.SpecificTagsTableAdapter
    Friend WithEvents DepartmentTagsBindingSource As BindingSource
    Friend WithEvents DepartmentTagsTableAdapter As Daily_Task_LogDataSetTableAdapters.DepartmentTagsTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SpecificTagsBindingSource1 As BindingSource
    Friend WithEvents DepartmentTagsBindingSource1 As BindingSource
    Friend WithEvents UsersBindingSource2 As BindingSource
    Friend WithEvents GeneralTagsBindingSource1 As BindingSource
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents userEmailLabel As Label
    Friend WithEvents userEmailComboBox As ComboBox
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents userLoginIDTextBox As TextBox
    Friend WithEvents usersLoginIDLabel As Label
    Friend WithEvents userLastNameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents userFirstNameTextBox As TextBox
    Friend WithEvents userUsersLabel As Label
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewTaskToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewGeneralTagToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewSpecificTagToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewDepartmentTagToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewUserToolStripMenuItem As ToolStripMenuItem
End Class
