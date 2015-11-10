<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.exitSettingsButton = New System.Windows.Forms.Button()
        Me.BrowseSettingsButton = New System.Windows.Forms.Button()
        Me.DBSettingsLabel = New System.Windows.Forms.Label()
        Me.oldPassTextBox = New System.Windows.Forms.TextBox()
        Me.plainPassLabel = New System.Windows.Forms.Label()
        Me.hashButton = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.dbTabPage = New System.Windows.Forms.TabPage()
        Me.passwordTabPage = New System.Windows.Forms.TabPage()
        Me.DBSettingsTextBox = New System.Windows.Forms.TextBox()
        Me.newPassOneTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.newPassTwoTextBox = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.dbTabPage.SuspendLayout()
        Me.passwordTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'exitSettingsButton
        '
        Me.exitSettingsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitSettingsButton.Location = New System.Drawing.Point(420, 267)
        Me.exitSettingsButton.Name = "exitSettingsButton"
        Me.exitSettingsButton.Size = New System.Drawing.Size(125, 44)
        Me.exitSettingsButton.TabIndex = 2
        Me.exitSettingsButton.Text = "Save and Exit"
        Me.exitSettingsButton.UseVisualStyleBackColor = True
        '
        'BrowseSettingsButton
        '
        Me.BrowseSettingsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrowseSettingsButton.Location = New System.Drawing.Point(433, 31)
        Me.BrowseSettingsButton.Name = "BrowseSettingsButton"
        Me.BrowseSettingsButton.Size = New System.Drawing.Size(83, 30)
        Me.BrowseSettingsButton.TabIndex = 1
        Me.BrowseSettingsButton.Text = "Browse"
        Me.BrowseSettingsButton.UseVisualStyleBackColor = True
        '
        'DBSettingsLabel
        '
        Me.DBSettingsLabel.AutoSize = True
        Me.DBSettingsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DBSettingsLabel.Location = New System.Drawing.Point(9, 10)
        Me.DBSettingsLabel.Name = "DBSettingsLabel"
        Me.DBSettingsLabel.Size = New System.Drawing.Size(144, 20)
        Me.DBSettingsLabel.TabIndex = 46
        Me.DBSettingsLabel.Text = "Database Location"
        '
        'oldPassTextBox
        '
        Me.oldPassTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oldPassTextBox.Location = New System.Drawing.Point(13, 34)
        Me.oldPassTextBox.Name = "oldPassTextBox"
        Me.oldPassTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.oldPassTextBox.Size = New System.Drawing.Size(414, 27)
        Me.oldPassTextBox.TabIndex = 47
        '
        'plainPassLabel
        '
        Me.plainPassLabel.AutoSize = True
        Me.plainPassLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plainPassLabel.Location = New System.Drawing.Point(9, 11)
        Me.plainPassLabel.Name = "plainPassLabel"
        Me.plainPassLabel.Size = New System.Drawing.Size(149, 20)
        Me.plainPassLabel.TabIndex = 49
        Me.plainPassLabel.Text = "Enter Old Password"
        '
        'hashButton
        '
        Me.hashButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hashButton.Location = New System.Drawing.Point(257, 153)
        Me.hashButton.Name = "hashButton"
        Me.hashButton.Size = New System.Drawing.Size(170, 30)
        Me.hashButton.TabIndex = 51
        Me.hashButton.Text = "Save new password"
        Me.hashButton.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.dbTabPage)
        Me.TabControl1.Controls.Add(Me.passwordTabPage)
        Me.TabControl1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(20, 10)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(537, 249)
        Me.TabControl1.TabIndex = 52
        '
        'dbTabPage
        '
        Me.dbTabPage.Controls.Add(Me.DBSettingsLabel)
        Me.dbTabPage.Controls.Add(Me.DBSettingsTextBox)
        Me.dbTabPage.Controls.Add(Me.BrowseSettingsButton)
        Me.dbTabPage.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dbTabPage.Location = New System.Drawing.Point(4, 49)
        Me.dbTabPage.Name = "dbTabPage"
        Me.dbTabPage.Padding = New System.Windows.Forms.Padding(10)
        Me.dbTabPage.Size = New System.Drawing.Size(529, 196)
        Me.dbTabPage.TabIndex = 0
        Me.dbTabPage.Text = "Database"
        Me.dbTabPage.UseVisualStyleBackColor = True
        '
        'passwordTabPage
        '
        Me.passwordTabPage.Controls.Add(Me.newPassTwoTextBox)
        Me.passwordTabPage.Controls.Add(Me.newPassOneTextBox)
        Me.passwordTabPage.Controls.Add(Me.Label1)
        Me.passwordTabPage.Controls.Add(Me.hashButton)
        Me.passwordTabPage.Controls.Add(Me.oldPassTextBox)
        Me.passwordTabPage.Controls.Add(Me.plainPassLabel)
        Me.passwordTabPage.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordTabPage.Location = New System.Drawing.Point(4, 49)
        Me.passwordTabPage.Name = "passwordTabPage"
        Me.passwordTabPage.Padding = New System.Windows.Forms.Padding(10)
        Me.passwordTabPage.Size = New System.Drawing.Size(529, 196)
        Me.passwordTabPage.TabIndex = 1
        Me.passwordTabPage.Text = "Password"
        Me.passwordTabPage.UseVisualStyleBackColor = True
        '
        'DBSettingsTextBox
        '
        Me.DBSettingsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Daily_Tasks_V2.My.MySettings.Default, "DBLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DBSettingsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DBSettingsTextBox.Location = New System.Drawing.Point(13, 33)
        Me.DBSettingsTextBox.Name = "DBSettingsTextBox"
        Me.DBSettingsTextBox.Size = New System.Drawing.Size(415, 26)
        Me.DBSettingsTextBox.TabIndex = 0
        Me.DBSettingsTextBox.Text = Global.Daily_Tasks_V2.My.MySettings.Default.DBLocation
        '
        'newPassOneTextBox
        '
        Me.newPassOneTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newPassOneTextBox.Location = New System.Drawing.Point(13, 87)
        Me.newPassOneTextBox.Name = "newPassOneTextBox"
        Me.newPassOneTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newPassOneTextBox.Size = New System.Drawing.Size(414, 27)
        Me.newPassOneTextBox.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 20)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Enter New Password Twice"
        '
        'newPassTwoTextBox
        '
        Me.newPassTwoTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newPassTwoTextBox.Location = New System.Drawing.Point(13, 120)
        Me.newPassTwoTextBox.Name = "newPassTwoTextBox"
        Me.newPassTwoTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newPassTwoTextBox.Size = New System.Drawing.Size(414, 27)
        Me.newPassTwoTextBox.TabIndex = 54
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 322)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.exitSettingsButton)
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.TabControl1.ResumeLayout(False)
        Me.dbTabPage.ResumeLayout(False)
        Me.dbTabPage.PerformLayout()
        Me.passwordTabPage.ResumeLayout(False)
        Me.passwordTabPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents exitSettingsButton As Button
    Friend WithEvents BrowseSettingsButton As Button
    Friend WithEvents DBSettingsLabel As Label
    Friend WithEvents DBSettingsTextBox As TextBox
    Friend WithEvents oldPassTextBox As TextBox
    Friend WithEvents plainPassLabel As Label
    Friend WithEvents hashButton As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents dbTabPage As TabPage
    Friend WithEvents passwordTabPage As TabPage
    Friend WithEvents newPassTwoTextBox As TextBox
    Friend WithEvents newPassOneTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
