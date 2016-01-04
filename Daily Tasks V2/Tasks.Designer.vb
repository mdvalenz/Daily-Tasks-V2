<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tasks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tasks))
        Me.requiredFieldsLabel = New System.Windows.Forms.Label()
        Me.taskDepartmentTagComboBox = New System.Windows.Forms.ComboBox()
        Me.DepartmentTagsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Daily_Task_LogDataSet = New Daily_Tasks_V2.Daily_Task_LogDataSet()
        Me.taskSpecificTagComboBox = New System.Windows.Forms.ComboBox()
        Me.SpecificTagsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.taskGeneralTagComboBox = New System.Windows.Forms.ComboBox()
        Me.GeneralTagsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tagsTaskLabel = New System.Windows.Forms.Label()
        Me.taskDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.descriptionTaskLabel = New System.Windows.Forms.Label()
        Me.saveExitTaskButton = New System.Windows.Forms.Button()
        Me.taskDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.dateTaskLabel = New System.Windows.Forms.Label()
        Me.taskEstimatedTimeTextBox = New System.Windows.Forms.TextBox()
        Me.estimatedTimeTaskLabel = New System.Windows.Forms.Label()
        Me.taskTextBox = New System.Windows.Forms.TextBox()
        Me.taskTaskLabel = New System.Windows.Forms.Label()
        Me.GeneralTagsTableAdapter = New Daily_Tasks_V2.Daily_Task_LogDataSetTableAdapters.GeneralTagsTableAdapter()
        Me.SpecificTagsTableAdapter = New Daily_Tasks_V2.Daily_Task_LogDataSetTableAdapters.SpecificTagsTableAdapter()
        Me.DepartmentTagsTableAdapter = New Daily_Tasks_V2.Daily_Task_LogDataSetTableAdapters.DepartmentTagsTableAdapter()
        Me.taskUserEmailComboBox = New System.Windows.Forms.ComboBox()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UsersTableAdapter = New Daily_Tasks_V2.Daily_Task_LogDataSetTableAdapters.UsersTableAdapter()
        Me.taskIDTextBox = New System.Windows.Forms.TextBox()
        Me.taskEmailIDTextBox = New System.Windows.Forms.TextBox()
        Me.taskGeneralTagIDTextBox = New System.Windows.Forms.TextBox()
        Me.taskSpecificTagIDTextBox = New System.Windows.Forms.TextBox()
        Me.taskDepartmentTagIDTextBox = New System.Windows.Forms.TextBox()
        Me.saveNewTaskButton = New System.Windows.Forms.Button()
        Me.newTaskGeneralTagButton = New System.Windows.Forms.Button()
        Me.newTaskSpecificTagButton = New System.Windows.Forms.Button()
        Me.newTaskDepartmentTagButton = New System.Windows.Forms.Button()
        Me.refreshTagsButton = New System.Windows.Forms.Button()
        CType(Me.DepartmentTagsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Daily_Task_LogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpecificTagsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralTagsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'requiredFieldsLabel
        '
        Me.requiredFieldsLabel.AutoSize = True
        Me.requiredFieldsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requiredFieldsLabel.Location = New System.Drawing.Point(473, 368)
        Me.requiredFieldsLabel.Name = "requiredFieldsLabel"
        Me.requiredFieldsLabel.Size = New System.Drawing.Size(130, 20)
        Me.requiredFieldsLabel.TabIndex = 40
        Me.requiredFieldsLabel.Text = "* Required Fields"
        '
        'taskDepartmentTagComboBox
        '
        Me.taskDepartmentTagComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.taskDepartmentTagComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.taskDepartmentTagComboBox.DataSource = Me.DepartmentTagsBindingSource
        Me.taskDepartmentTagComboBox.DisplayMember = "DepartmentTag"
        Me.taskDepartmentTagComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taskDepartmentTagComboBox.FormattingEnabled = True
        Me.taskDepartmentTagComboBox.Location = New System.Drawing.Point(106, 188)
        Me.taskDepartmentTagComboBox.Name = "taskDepartmentTagComboBox"
        Me.taskDepartmentTagComboBox.Size = New System.Drawing.Size(316, 28)
        Me.taskDepartmentTagComboBox.TabIndex = 4
        Me.taskDepartmentTagComboBox.ValueMember = "ID"
        '
        'DepartmentTagsBindingSource
        '
        Me.DepartmentTagsBindingSource.DataMember = "DepartmentTags"
        Me.DepartmentTagsBindingSource.DataSource = Me.Daily_Task_LogDataSet
        '
        'Daily_Task_LogDataSet
        '
        Me.Daily_Task_LogDataSet.DataSetName = "Daily_Task_LogDataSet"
        Me.Daily_Task_LogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'taskSpecificTagComboBox
        '
        Me.taskSpecificTagComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.taskSpecificTagComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.taskSpecificTagComboBox.DataSource = Me.SpecificTagsBindingSource
        Me.taskSpecificTagComboBox.DisplayMember = "SpecificTag"
        Me.taskSpecificTagComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taskSpecificTagComboBox.FormattingEnabled = True
        Me.taskSpecificTagComboBox.Location = New System.Drawing.Point(106, 154)
        Me.taskSpecificTagComboBox.Name = "taskSpecificTagComboBox"
        Me.taskSpecificTagComboBox.Size = New System.Drawing.Size(316, 28)
        Me.taskSpecificTagComboBox.TabIndex = 3
        Me.taskSpecificTagComboBox.ValueMember = "ID"
        '
        'SpecificTagsBindingSource
        '
        Me.SpecificTagsBindingSource.DataMember = "SpecificTags"
        Me.SpecificTagsBindingSource.DataSource = Me.Daily_Task_LogDataSet
        '
        'taskGeneralTagComboBox
        '
        Me.taskGeneralTagComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.taskGeneralTagComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.taskGeneralTagComboBox.DataSource = Me.GeneralTagsBindingSource
        Me.taskGeneralTagComboBox.DisplayMember = "GeneralTag"
        Me.taskGeneralTagComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taskGeneralTagComboBox.FormattingEnabled = True
        Me.taskGeneralTagComboBox.Location = New System.Drawing.Point(106, 120)
        Me.taskGeneralTagComboBox.Name = "taskGeneralTagComboBox"
        Me.taskGeneralTagComboBox.Size = New System.Drawing.Size(316, 28)
        Me.taskGeneralTagComboBox.TabIndex = 2
        Me.taskGeneralTagComboBox.ValueMember = "ID"
        '
        'GeneralTagsBindingSource
        '
        Me.GeneralTagsBindingSource.DataMember = "GeneralTags"
        Me.GeneralTagsBindingSource.DataSource = Me.Daily_Task_LogDataSet
        '
        'tagsTaskLabel
        '
        Me.tagsTaskLabel.AutoSize = True
        Me.tagsTaskLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tagsTaskLabel.Location = New System.Drawing.Point(47, 123)
        Me.tagsTaskLabel.Name = "tagsTaskLabel"
        Me.tagsTaskLabel.Size = New System.Drawing.Size(54, 20)
        Me.tagsTaskLabel.TabIndex = 39
        Me.tagsTaskLabel.Text = "* Tags"
        '
        'taskDescriptionTextBox
        '
        Me.taskDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.taskDescriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taskDescriptionTextBox.Location = New System.Drawing.Point(106, 222)
        Me.taskDescriptionTextBox.Multiline = True
        Me.taskDescriptionTextBox.Name = "taskDescriptionTextBox"
        Me.taskDescriptionTextBox.Size = New System.Drawing.Size(497, 143)
        Me.taskDescriptionTextBox.TabIndex = 5
        '
        'descriptionTaskLabel
        '
        Me.descriptionTaskLabel.AutoSize = True
        Me.descriptionTaskLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptionTaskLabel.Location = New System.Drawing.Point(11, 222)
        Me.descriptionTaskLabel.Name = "descriptionTaskLabel"
        Me.descriptionTaskLabel.Size = New System.Drawing.Size(89, 20)
        Me.descriptionTaskLabel.TabIndex = 38
        Me.descriptionTaskLabel.Text = "Description"
        '
        'saveExitTaskButton
        '
        Me.saveExitTaskButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveExitTaskButton.Location = New System.Drawing.Point(477, 404)
        Me.saveExitTaskButton.Name = "saveExitTaskButton"
        Me.saveExitTaskButton.Size = New System.Drawing.Size(126, 51)
        Me.saveExitTaskButton.TabIndex = 35
        Me.saveExitTaskButton.TabStop = False
        Me.saveExitTaskButton.Text = "Save and Exit"
        Me.saveExitTaskButton.UseVisualStyleBackColor = True
        '
        'taskDatePicker
        '
        Me.taskDatePicker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taskDatePicker.CustomFormat = "MM/dd/yy"
        Me.taskDatePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taskDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.taskDatePicker.Location = New System.Drawing.Point(106, 46)
        Me.taskDatePicker.MaxDate = New Date(2200, 12, 31, 0, 0, 0, 0)
        Me.taskDatePicker.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.taskDatePicker.Name = "taskDatePicker"
        Me.taskDatePicker.Size = New System.Drawing.Size(124, 26)
        Me.taskDatePicker.TabIndex = 26
        Me.taskDatePicker.TabStop = False
        '
        'dateTaskLabel
        '
        Me.dateTaskLabel.AutoSize = True
        Me.dateTaskLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTaskLabel.Location = New System.Drawing.Point(46, 49)
        Me.dateTaskLabel.Name = "dateTaskLabel"
        Me.dateTaskLabel.Size = New System.Drawing.Size(54, 20)
        Me.dateTaskLabel.TabIndex = 37
        Me.dateTaskLabel.Text = "* Date"
        '
        'taskEstimatedTimeTextBox
        '
        Me.taskEstimatedTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.taskEstimatedTimeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taskEstimatedTimeTextBox.Location = New System.Drawing.Point(523, 47)
        Me.taskEstimatedTimeTextBox.Name = "taskEstimatedTimeTextBox"
        Me.taskEstimatedTimeTextBox.Size = New System.Drawing.Size(80, 26)
        Me.taskEstimatedTimeTextBox.TabIndex = 0
        Me.taskEstimatedTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'estimatedTimeTaskLabel
        '
        Me.estimatedTimeTaskLabel.AutoSize = True
        Me.estimatedTimeTaskLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estimatedTimeTaskLabel.Location = New System.Drawing.Point(366, 49)
        Me.estimatedTimeTaskLabel.Name = "estimatedTimeTaskLabel"
        Me.estimatedTimeTaskLabel.Size = New System.Drawing.Size(151, 20)
        Me.estimatedTimeTaskLabel.TabIndex = 33
        Me.estimatedTimeTaskLabel.Text = "* Estimated Minutes"
        '
        'taskTextBox
        '
        Me.taskTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.taskTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taskTextBox.Location = New System.Drawing.Point(106, 87)
        Me.taskTextBox.Name = "taskTextBox"
        Me.taskTextBox.Size = New System.Drawing.Size(497, 26)
        Me.taskTextBox.TabIndex = 1
        '
        'taskTaskLabel
        '
        Me.taskTaskLabel.AutoSize = True
        Me.taskTaskLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taskTaskLabel.Location = New System.Drawing.Point(47, 89)
        Me.taskTaskLabel.Name = "taskTaskLabel"
        Me.taskTaskLabel.Size = New System.Drawing.Size(53, 20)
        Me.taskTaskLabel.TabIndex = 27
        Me.taskTaskLabel.Text = "* Task"
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
        'taskUserEmailComboBox
        '
        Me.taskUserEmailComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.taskUserEmailComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.taskUserEmailComboBox.DataSource = Me.UsersBindingSource
        Me.taskUserEmailComboBox.DisplayMember = "Email"
        Me.taskUserEmailComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.taskUserEmailComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taskUserEmailComboBox.FormattingEnabled = True
        Me.taskUserEmailComboBox.Location = New System.Drawing.Point(106, 12)
        Me.taskUserEmailComboBox.Name = "taskUserEmailComboBox"
        Me.taskUserEmailComboBox.Size = New System.Drawing.Size(497, 28)
        Me.taskUserEmailComboBox.TabIndex = 55
        Me.taskUserEmailComboBox.TabStop = False
        Me.taskUserEmailComboBox.ValueMember = "ID"
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.Daily_Task_LogDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "* User Email"
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'taskIDTextBox
        '
        Me.taskIDTextBox.Location = New System.Drawing.Point(268, 49)
        Me.taskIDTextBox.Name = "taskIDTextBox"
        Me.taskIDTextBox.Size = New System.Drawing.Size(64, 20)
        Me.taskIDTextBox.TabIndex = 58
        Me.taskIDTextBox.TabStop = False
        Me.taskIDTextBox.Visible = False
        '
        'taskEmailIDTextBox
        '
        Me.taskEmailIDTextBox.Location = New System.Drawing.Point(609, 17)
        Me.taskEmailIDTextBox.Name = "taskEmailIDTextBox"
        Me.taskEmailIDTextBox.Size = New System.Drawing.Size(88, 20)
        Me.taskEmailIDTextBox.TabIndex = 59
        Me.taskEmailIDTextBox.Visible = False
        '
        'taskGeneralTagIDTextBox
        '
        Me.taskGeneralTagIDTextBox.Location = New System.Drawing.Point(612, 125)
        Me.taskGeneralTagIDTextBox.Name = "taskGeneralTagIDTextBox"
        Me.taskGeneralTagIDTextBox.Size = New System.Drawing.Size(88, 20)
        Me.taskGeneralTagIDTextBox.TabIndex = 60
        Me.taskGeneralTagIDTextBox.Visible = False
        '
        'taskSpecificTagIDTextBox
        '
        Me.taskSpecificTagIDTextBox.Location = New System.Drawing.Point(612, 159)
        Me.taskSpecificTagIDTextBox.Name = "taskSpecificTagIDTextBox"
        Me.taskSpecificTagIDTextBox.Size = New System.Drawing.Size(88, 20)
        Me.taskSpecificTagIDTextBox.TabIndex = 61
        Me.taskSpecificTagIDTextBox.Visible = False
        '
        'taskDepartmentTagIDTextBox
        '
        Me.taskDepartmentTagIDTextBox.Location = New System.Drawing.Point(612, 193)
        Me.taskDepartmentTagIDTextBox.Name = "taskDepartmentTagIDTextBox"
        Me.taskDepartmentTagIDTextBox.Size = New System.Drawing.Size(88, 20)
        Me.taskDepartmentTagIDTextBox.TabIndex = 62
        Me.taskDepartmentTagIDTextBox.Visible = False
        '
        'saveNewTaskButton
        '
        Me.saveNewTaskButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveNewTaskButton.Location = New System.Drawing.Point(345, 404)
        Me.saveNewTaskButton.Name = "saveNewTaskButton"
        Me.saveNewTaskButton.Size = New System.Drawing.Size(126, 51)
        Me.saveNewTaskButton.TabIndex = 63
        Me.saveNewTaskButton.TabStop = False
        Me.saveNewTaskButton.Text = "Save and New"
        Me.saveNewTaskButton.UseVisualStyleBackColor = True
        '
        'newTaskGeneralTagButton
        '
        Me.newTaskGeneralTagButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newTaskGeneralTagButton.Location = New System.Drawing.Point(428, 118)
        Me.newTaskGeneralTagButton.Name = "newTaskGeneralTagButton"
        Me.newTaskGeneralTagButton.Size = New System.Drawing.Size(175, 30)
        Me.newTaskGeneralTagButton.TabIndex = 64
        Me.newTaskGeneralTagButton.TabStop = False
        Me.newTaskGeneralTagButton.Text = "New General Tag"
        Me.newTaskGeneralTagButton.UseVisualStyleBackColor = True
        '
        'newTaskSpecificTagButton
        '
        Me.newTaskSpecificTagButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newTaskSpecificTagButton.Location = New System.Drawing.Point(428, 152)
        Me.newTaskSpecificTagButton.Name = "newTaskSpecificTagButton"
        Me.newTaskSpecificTagButton.Size = New System.Drawing.Size(175, 30)
        Me.newTaskSpecificTagButton.TabIndex = 71
        Me.newTaskSpecificTagButton.TabStop = False
        Me.newTaskSpecificTagButton.Text = "New Specific Tag"
        Me.newTaskSpecificTagButton.UseVisualStyleBackColor = True
        '
        'newTaskDepartmentTagButton
        '
        Me.newTaskDepartmentTagButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newTaskDepartmentTagButton.Location = New System.Drawing.Point(428, 186)
        Me.newTaskDepartmentTagButton.Name = "newTaskDepartmentTagButton"
        Me.newTaskDepartmentTagButton.Size = New System.Drawing.Size(175, 30)
        Me.newTaskDepartmentTagButton.TabIndex = 76
        Me.newTaskDepartmentTagButton.TabStop = False
        Me.newTaskDepartmentTagButton.Text = "New Department Tag"
        Me.newTaskDepartmentTagButton.UseVisualStyleBackColor = True
        '
        'refreshTagsButton
        '
        Me.refreshTagsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshTagsButton.Location = New System.Drawing.Point(213, 404)
        Me.refreshTagsButton.Name = "refreshTagsButton"
        Me.refreshTagsButton.Size = New System.Drawing.Size(126, 51)
        Me.refreshTagsButton.TabIndex = 77
        Me.refreshTagsButton.TabStop = False
        Me.refreshTagsButton.Text = "Refresh Tags"
        Me.refreshTagsButton.UseVisualStyleBackColor = True
        '
        'Tasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 465)
        Me.Controls.Add(Me.refreshTagsButton)
        Me.Controls.Add(Me.newTaskDepartmentTagButton)
        Me.Controls.Add(Me.newTaskSpecificTagButton)
        Me.Controls.Add(Me.newTaskGeneralTagButton)
        Me.Controls.Add(Me.saveNewTaskButton)
        Me.Controls.Add(Me.taskDepartmentTagIDTextBox)
        Me.Controls.Add(Me.taskSpecificTagIDTextBox)
        Me.Controls.Add(Me.taskGeneralTagIDTextBox)
        Me.Controls.Add(Me.taskEmailIDTextBox)
        Me.Controls.Add(Me.taskIDTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.taskUserEmailComboBox)
        Me.Controls.Add(Me.requiredFieldsLabel)
        Me.Controls.Add(Me.taskDepartmentTagComboBox)
        Me.Controls.Add(Me.taskSpecificTagComboBox)
        Me.Controls.Add(Me.taskGeneralTagComboBox)
        Me.Controls.Add(Me.tagsTaskLabel)
        Me.Controls.Add(Me.taskDescriptionTextBox)
        Me.Controls.Add(Me.descriptionTaskLabel)
        Me.Controls.Add(Me.saveExitTaskButton)
        Me.Controls.Add(Me.taskDatePicker)
        Me.Controls.Add(Me.dateTaskLabel)
        Me.Controls.Add(Me.taskEstimatedTimeTextBox)
        Me.Controls.Add(Me.estimatedTimeTaskLabel)
        Me.Controls.Add(Me.taskTextBox)
        Me.Controls.Add(Me.taskTaskLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tasks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tasks"
        CType(Me.DepartmentTagsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Daily_Task_LogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpecificTagsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralTagsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents requiredFieldsLabel As Label
    Friend WithEvents taskDepartmentTagComboBox As ComboBox
    Friend WithEvents taskSpecificTagComboBox As ComboBox
    Friend WithEvents taskGeneralTagComboBox As ComboBox
    Friend WithEvents tagsTaskLabel As Label
    Friend WithEvents taskDescriptionTextBox As TextBox
    Friend WithEvents descriptionTaskLabel As Label
    Friend WithEvents saveExitTaskButton As Button
    Friend WithEvents taskDatePicker As DateTimePicker
    Friend WithEvents dateTaskLabel As Label
    Friend WithEvents taskEstimatedTimeTextBox As TextBox
    Friend WithEvents estimatedTimeTaskLabel As Label
    Friend WithEvents taskTextBox As TextBox
    Friend WithEvents taskTaskLabel As Label
    Friend WithEvents Daily_Task_LogDataSet As Daily_Task_LogDataSet
    Friend WithEvents GeneralTagsBindingSource As BindingSource
    Friend WithEvents GeneralTagsTableAdapter As Daily_Task_LogDataSetTableAdapters.GeneralTagsTableAdapter
    Friend WithEvents SpecificTagsBindingSource As BindingSource
    Friend WithEvents SpecificTagsTableAdapter As Daily_Task_LogDataSetTableAdapters.SpecificTagsTableAdapter
    Friend WithEvents DepartmentTagsBindingSource As BindingSource
    Friend WithEvents DepartmentTagsTableAdapter As Daily_Task_LogDataSetTableAdapters.DepartmentTagsTableAdapter
    Friend WithEvents taskUserEmailComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As Daily_Task_LogDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents taskIDTextBox As TextBox
    Friend WithEvents taskEmailIDTextBox As TextBox
    Friend WithEvents taskGeneralTagIDTextBox As TextBox
    Friend WithEvents taskSpecificTagIDTextBox As TextBox
    Friend WithEvents taskDepartmentTagIDTextBox As TextBox
    Friend WithEvents saveNewTaskButton As Button
    Friend WithEvents newTaskGeneralTagButton As Button
    Friend WithEvents newTaskSpecificTagButton As Button
    Friend WithEvents newTaskDepartmentTagButton As Button
    Friend WithEvents refreshTagsButton As Button
End Class
