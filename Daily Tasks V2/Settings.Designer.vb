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
        Me.DBSettingsTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'exitSettingsButton
        '
        Me.exitSettingsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitSettingsButton.Location = New System.Drawing.Point(392, 86)
        Me.exitSettingsButton.Name = "exitSettingsButton"
        Me.exitSettingsButton.Size = New System.Drawing.Size(128, 30)
        Me.exitSettingsButton.TabIndex = 2
        Me.exitSettingsButton.Text = "Save and Exit"
        Me.exitSettingsButton.UseVisualStyleBackColor = True
        '
        'BrowseSettingsButton
        '
        Me.BrowseSettingsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrowseSettingsButton.Location = New System.Drawing.Point(437, 30)
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
        Me.DBSettingsLabel.Location = New System.Drawing.Point(12, 9)
        Me.DBSettingsLabel.Name = "DBSettingsLabel"
        Me.DBSettingsLabel.Size = New System.Drawing.Size(144, 20)
        Me.DBSettingsLabel.TabIndex = 46
        Me.DBSettingsLabel.Text = "Database Location"
        '
        'DBSettingsTextBox
        '
        Me.DBSettingsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Daily_Tasks_V2.My.MySettings.Default, "DBLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DBSettingsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DBSettingsTextBox.Location = New System.Drawing.Point(16, 32)
        Me.DBSettingsTextBox.Name = "DBSettingsTextBox"
        Me.DBSettingsTextBox.Size = New System.Drawing.Size(415, 26)
        Me.DBSettingsTextBox.TabIndex = 0
        Me.DBSettingsTextBox.Text = Global.Daily_Tasks_V2.My.MySettings.Default.DBLocation
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 132)
        Me.Controls.Add(Me.exitSettingsButton)
        Me.Controls.Add(Me.BrowseSettingsButton)
        Me.Controls.Add(Me.DBSettingsLabel)
        Me.Controls.Add(Me.DBSettingsTextBox)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitSettingsButton As Button
    Friend WithEvents BrowseSettingsButton As Button
    Friend WithEvents DBSettingsLabel As Label
    Friend WithEvents DBSettingsTextBox As TextBox
End Class
