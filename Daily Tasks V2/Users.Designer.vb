<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Users))
        Me.emailUserLabel = New System.Windows.Forms.Label()
        Me.emailUserTextBox = New System.Windows.Forms.TextBox()
        Me.loginIDUserLabel = New System.Windows.Forms.Label()
        Me.loginIDUserTextBox = New System.Windows.Forms.TextBox()
        Me.firstNameUserLabel = New System.Windows.Forms.Label()
        Me.saveExitUserButton = New System.Windows.Forms.Button()
        Me.firstNameUserTextBox = New System.Windows.Forms.TextBox()
        Me.lastNameUserLabel = New System.Windows.Forms.Label()
        Me.lastNameUserTextBox = New System.Windows.Forms.TextBox()
        Me.userIDTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'emailUserLabel
        '
        Me.emailUserLabel.AutoSize = True
        Me.emailUserLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailUserLabel.Location = New System.Drawing.Point(8, 113)
        Me.emailUserLabel.Name = "emailUserLabel"
        Me.emailUserLabel.Size = New System.Drawing.Size(53, 20)
        Me.emailUserLabel.TabIndex = 48
        Me.emailUserLabel.Text = "E-mail"
        '
        'emailUserTextBox
        '
        Me.emailUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.emailUserTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailUserTextBox.Location = New System.Drawing.Point(12, 136)
        Me.emailUserTextBox.Name = "emailUserTextBox"
        Me.emailUserTextBox.Size = New System.Drawing.Size(410, 26)
        Me.emailUserTextBox.TabIndex = 3
        Me.emailUserTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'loginIDUserLabel
        '
        Me.loginIDUserLabel.AutoSize = True
        Me.loginIDUserLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginIDUserLabel.Location = New System.Drawing.Point(12, 61)
        Me.loginIDUserLabel.Name = "loginIDUserLabel"
        Me.loginIDUserLabel.Size = New System.Drawing.Size(69, 20)
        Me.loginIDUserLabel.TabIndex = 47
        Me.loginIDUserLabel.Text = "Login ID"
        '
        'loginIDUserTextBox
        '
        Me.loginIDUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.loginIDUserTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginIDUserTextBox.Location = New System.Drawing.Point(12, 84)
        Me.loginIDUserTextBox.Name = "loginIDUserTextBox"
        Me.loginIDUserTextBox.Size = New System.Drawing.Size(410, 26)
        Me.loginIDUserTextBox.TabIndex = 2
        Me.loginIDUserTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'firstNameUserLabel
        '
        Me.firstNameUserLabel.AutoSize = True
        Me.firstNameUserLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNameUserLabel.Location = New System.Drawing.Point(8, 9)
        Me.firstNameUserLabel.Name = "firstNameUserLabel"
        Me.firstNameUserLabel.Size = New System.Drawing.Size(86, 20)
        Me.firstNameUserLabel.TabIndex = 46
        Me.firstNameUserLabel.Text = "First Name"
        '
        'saveExitUserButton
        '
        Me.saveExitUserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveExitUserButton.Location = New System.Drawing.Point(297, 168)
        Me.saveExitUserButton.Name = "saveExitUserButton"
        Me.saveExitUserButton.Size = New System.Drawing.Size(125, 30)
        Me.saveExitUserButton.TabIndex = 4
        Me.saveExitUserButton.Text = "Save and Exit"
        Me.saveExitUserButton.UseVisualStyleBackColor = True
        '
        'firstNameUserTextBox
        '
        Me.firstNameUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.firstNameUserTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNameUserTextBox.Location = New System.Drawing.Point(12, 32)
        Me.firstNameUserTextBox.Name = "firstNameUserTextBox"
        Me.firstNameUserTextBox.Size = New System.Drawing.Size(200, 26)
        Me.firstNameUserTextBox.TabIndex = 0
        Me.firstNameUserTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lastNameUserLabel
        '
        Me.lastNameUserLabel.AutoSize = True
        Me.lastNameUserLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNameUserLabel.Location = New System.Drawing.Point(218, 9)
        Me.lastNameUserLabel.Name = "lastNameUserLabel"
        Me.lastNameUserLabel.Size = New System.Drawing.Size(86, 20)
        Me.lastNameUserLabel.TabIndex = 50
        Me.lastNameUserLabel.Text = "Last Name"
        '
        'lastNameUserTextBox
        '
        Me.lastNameUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lastNameUserTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNameUserTextBox.Location = New System.Drawing.Point(222, 32)
        Me.lastNameUserTextBox.Name = "lastNameUserTextBox"
        Me.lastNameUserTextBox.Size = New System.Drawing.Size(200, 26)
        Me.lastNameUserTextBox.TabIndex = 1
        Me.lastNameUserTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'userIDTextBox
        '
        Me.userIDTextBox.Location = New System.Drawing.Point(12, 174)
        Me.userIDTextBox.Name = "userIDTextBox"
        Me.userIDTextBox.Size = New System.Drawing.Size(47, 20)
        Me.userIDTextBox.TabIndex = 51
        Me.userIDTextBox.TabStop = False
        Me.userIDTextBox.Visible = False
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 206)
        Me.Controls.Add(Me.userIDTextBox)
        Me.Controls.Add(Me.lastNameUserLabel)
        Me.Controls.Add(Me.lastNameUserTextBox)
        Me.Controls.Add(Me.emailUserLabel)
        Me.Controls.Add(Me.emailUserTextBox)
        Me.Controls.Add(Me.loginIDUserLabel)
        Me.Controls.Add(Me.loginIDUserTextBox)
        Me.Controls.Add(Me.firstNameUserLabel)
        Me.Controls.Add(Me.saveExitUserButton)
        Me.Controls.Add(Me.firstNameUserTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Users"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Enter User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents emailUserLabel As Label
    Friend WithEvents emailUserTextBox As TextBox
    Friend WithEvents loginIDUserLabel As Label
    Friend WithEvents loginIDUserTextBox As TextBox
    Friend WithEvents firstNameUserLabel As Label
    Friend WithEvents saveExitUserButton As Button
    Friend WithEvents firstNameUserTextBox As TextBox
    Friend WithEvents lastNameUserLabel As Label
    Friend WithEvents lastNameUserTextBox As TextBox
    Friend WithEvents userIDTextBox As TextBox
End Class
