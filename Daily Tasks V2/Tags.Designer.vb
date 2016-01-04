<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tags
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tags))
        Me.saveExitTagButton = New System.Windows.Forms.Button()
        Me.tagTextBox = New System.Windows.Forms.TextBox()
        Me.tagIDTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'saveExitTagButton
        '
        Me.saveExitTagButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveExitTagButton.Location = New System.Drawing.Point(76, 44)
        Me.saveExitTagButton.Name = "saveExitTagButton"
        Me.saveExitTagButton.Size = New System.Drawing.Size(125, 30)
        Me.saveExitTagButton.TabIndex = 1
        Me.saveExitTagButton.Text = "Save and Exit"
        Me.saveExitTagButton.UseVisualStyleBackColor = True
        '
        'tagTextBox
        '
        Me.tagTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tagTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tagTextBox.Location = New System.Drawing.Point(39, 12)
        Me.tagTextBox.Name = "tagTextBox"
        Me.tagTextBox.Size = New System.Drawing.Size(200, 26)
        Me.tagTextBox.TabIndex = 0
        Me.tagTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tagIDTextBox
        '
        Me.tagIDTextBox.Location = New System.Drawing.Point(-14, 16)
        Me.tagIDTextBox.Name = "tagIDTextBox"
        Me.tagIDTextBox.Size = New System.Drawing.Size(47, 20)
        Me.tagIDTextBox.TabIndex = 5
        Me.tagIDTextBox.TabStop = False
        Me.tagIDTextBox.Visible = False
        '
        'Tags
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 88)
        Me.Controls.Add(Me.tagIDTextBox)
        Me.Controls.Add(Me.saveExitTagButton)
        Me.Controls.Add(Me.tagTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tags"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Enter New Tag"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents saveExitTagButton As Button
    Friend WithEvents tagTextBox As TextBox
    Friend WithEvents tagIDTextBox As TextBox
End Class
