<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Office_ChangePassword
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
        Me.SetPassword = New System.Windows.Forms.GroupBox()
        Me.SetButton = New System.Windows.Forms.Button()
        Me.SetP_StudId_Textbox = New System.Windows.Forms.TextBox()
        Me.SetP_CPass_TextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SetP_Password_TextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ConfPassword_Label = New System.Windows.Forms.Label()
        Me.Password_Label = New System.Windows.Forms.Label()
        Me.StudentId_Label = New System.Windows.Forms.Label()
        Me.ChangePassword = New System.Windows.Forms.GroupBox()
        Me.ChangeButton = New System.Windows.Forms.Button()
        Me.ChgP_ConfPass_Textbox = New System.Windows.Forms.MaskedTextBox()
        Me.ChgP_StudId_Textbox = New System.Windows.Forms.TextBox()
        Me.ChgP_NewPass_Textbox = New System.Windows.Forms.MaskedTextBox()
        Me.ChgP_OldPass_Textbox = New System.Windows.Forms.MaskedTextBox()
        Me.ConfPass_Label = New System.Windows.Forms.Label()
        Me.NewPass_Label = New System.Windows.Forms.Label()
        Me.OldPass_Label = New System.Windows.Forms.Label()
        Me.StudId_Label = New System.Windows.Forms.Label()
        Me.SetPassword.SuspendLayout()
        Me.ChangePassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'SetPassword
        '
        Me.SetPassword.Controls.Add(Me.SetButton)
        Me.SetPassword.Controls.Add(Me.SetP_StudId_Textbox)
        Me.SetPassword.Controls.Add(Me.SetP_CPass_TextBox)
        Me.SetPassword.Controls.Add(Me.SetP_Password_TextBox)
        Me.SetPassword.Controls.Add(Me.ConfPassword_Label)
        Me.SetPassword.Controls.Add(Me.Password_Label)
        Me.SetPassword.Controls.Add(Me.StudentId_Label)
        Me.SetPassword.Location = New System.Drawing.Point(29, 12)
        Me.SetPassword.Name = "SetPassword"
        Me.SetPassword.Size = New System.Drawing.Size(333, 399)
        Me.SetPassword.TabIndex = 0
        Me.SetPassword.TabStop = False
        Me.SetPassword.Text = "Set Password"
        '
        'SetButton
        '
        Me.SetButton.Location = New System.Drawing.Point(81, 347)
        Me.SetButton.Name = "SetButton"
        Me.SetButton.Size = New System.Drawing.Size(152, 39)
        Me.SetButton.TabIndex = 6
        Me.SetButton.Text = "Set"
        Me.SetButton.UseVisualStyleBackColor = True
        '
        'SetP_StudId_Textbox
        '
        Me.SetP_StudId_Textbox.Location = New System.Drawing.Point(16, 50)
        Me.SetP_StudId_Textbox.Name = "SetP_StudId_Textbox"
        Me.SetP_StudId_Textbox.Size = New System.Drawing.Size(301, 20)
        Me.SetP_StudId_Textbox.TabIndex = 5
        '
        'SetP_CPass_TextBox
        '
        Me.SetP_CPass_TextBox.Location = New System.Drawing.Point(16, 201)
        Me.SetP_CPass_TextBox.Name = "SetP_CPass_TextBox"
        Me.SetP_CPass_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.SetP_CPass_TextBox.Size = New System.Drawing.Size(301, 20)
        Me.SetP_CPass_TextBox.TabIndex = 4
        '
        'SetP_Password_TextBox
        '
        Me.SetP_Password_TextBox.Location = New System.Drawing.Point(16, 125)
        Me.SetP_Password_TextBox.Name = "SetP_Password_TextBox"
        Me.SetP_Password_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.SetP_Password_TextBox.Size = New System.Drawing.Size(301, 20)
        Me.SetP_Password_TextBox.TabIndex = 3
        '
        'ConfPassword_Label
        '
        Me.ConfPassword_Label.AutoSize = True
        Me.ConfPassword_Label.Location = New System.Drawing.Point(13, 185)
        Me.ConfPassword_Label.Name = "ConfPassword_Label"
        Me.ConfPassword_Label.Size = New System.Drawing.Size(94, 13)
        Me.ConfPassword_Label.TabIndex = 2
        Me.ConfPassword_Label.Text = "Confirm Password:"
        '
        'Password_Label
        '
        Me.Password_Label.AutoSize = True
        Me.Password_Label.Location = New System.Drawing.Point(13, 109)
        Me.Password_Label.Name = "Password_Label"
        Me.Password_Label.Size = New System.Drawing.Size(56, 13)
        Me.Password_Label.TabIndex = 1
        Me.Password_Label.Text = "Password:"
        '
        'StudentId_Label
        '
        Me.StudentId_Label.AutoSize = True
        Me.StudentId_Label.Location = New System.Drawing.Point(13, 34)
        Me.StudentId_Label.Name = "StudentId_Label"
        Me.StudentId_Label.Size = New System.Drawing.Size(59, 13)
        Me.StudentId_Label.TabIndex = 0
        Me.StudentId_Label.Text = "Student Id:"
        '
        'ChangePassword
        '
        Me.ChangePassword.Controls.Add(Me.ChangeButton)
        Me.ChangePassword.Controls.Add(Me.ChgP_ConfPass_Textbox)
        Me.ChangePassword.Controls.Add(Me.ChgP_StudId_Textbox)
        Me.ChangePassword.Controls.Add(Me.ChgP_NewPass_Textbox)
        Me.ChangePassword.Controls.Add(Me.ChgP_OldPass_Textbox)
        Me.ChangePassword.Controls.Add(Me.ConfPass_Label)
        Me.ChangePassword.Controls.Add(Me.NewPass_Label)
        Me.ChangePassword.Controls.Add(Me.OldPass_Label)
        Me.ChangePassword.Controls.Add(Me.StudId_Label)
        Me.ChangePassword.Location = New System.Drawing.Point(403, 12)
        Me.ChangePassword.Name = "ChangePassword"
        Me.ChangePassword.Size = New System.Drawing.Size(390, 402)
        Me.ChangePassword.TabIndex = 1
        Me.ChangePassword.TabStop = False
        Me.ChangePassword.Text = "Change Password"
        '
        'ChangeButton
        '
        Me.ChangeButton.Location = New System.Drawing.Point(114, 350)
        Me.ChangeButton.Name = "ChangeButton"
        Me.ChangeButton.Size = New System.Drawing.Size(152, 39)
        Me.ChangeButton.TabIndex = 9
        Me.ChangeButton.Text = "Change"
        Me.ChangeButton.UseVisualStyleBackColor = True
        '
        'ChgP_ConfPass_Textbox
        '
        Me.ChgP_ConfPass_Textbox.Location = New System.Drawing.Point(34, 284)
        Me.ChgP_ConfPass_Textbox.Name = "ChgP_ConfPass_Textbox"
        Me.ChgP_ConfPass_Textbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ChgP_ConfPass_Textbox.Size = New System.Drawing.Size(301, 20)
        Me.ChgP_ConfPass_Textbox.TabIndex = 8
        '
        'ChgP_StudId_Textbox
        '
        Me.ChgP_StudId_Textbox.Location = New System.Drawing.Point(34, 53)
        Me.ChgP_StudId_Textbox.Name = "ChgP_StudId_Textbox"
        Me.ChgP_StudId_Textbox.Size = New System.Drawing.Size(301, 20)
        Me.ChgP_StudId_Textbox.TabIndex = 6
        '
        'ChgP_NewPass_Textbox
        '
        Me.ChgP_NewPass_Textbox.Location = New System.Drawing.Point(34, 204)
        Me.ChgP_NewPass_Textbox.Name = "ChgP_NewPass_Textbox"
        Me.ChgP_NewPass_Textbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ChgP_NewPass_Textbox.Size = New System.Drawing.Size(301, 20)
        Me.ChgP_NewPass_Textbox.TabIndex = 7
        '
        'ChgP_OldPass_Textbox
        '
        Me.ChgP_OldPass_Textbox.Location = New System.Drawing.Point(34, 128)
        Me.ChgP_OldPass_Textbox.Name = "ChgP_OldPass_Textbox"
        Me.ChgP_OldPass_Textbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ChgP_OldPass_Textbox.Size = New System.Drawing.Size(301, 20)
        Me.ChgP_OldPass_Textbox.TabIndex = 5
        '
        'ConfPass_Label
        '
        Me.ConfPass_Label.AutoSize = True
        Me.ConfPass_Label.Location = New System.Drawing.Point(31, 268)
        Me.ConfPass_Label.Name = "ConfPass_Label"
        Me.ConfPass_Label.Size = New System.Drawing.Size(94, 13)
        Me.ConfPass_Label.TabIndex = 6
        Me.ConfPass_Label.Text = "Confirm Password:"
        '
        'NewPass_Label
        '
        Me.NewPass_Label.AutoSize = True
        Me.NewPass_Label.Location = New System.Drawing.Point(31, 188)
        Me.NewPass_Label.Name = "NewPass_Label"
        Me.NewPass_Label.Size = New System.Drawing.Size(81, 13)
        Me.NewPass_Label.TabIndex = 5
        Me.NewPass_Label.Text = "New Password:"
        '
        'OldPass_Label
        '
        Me.OldPass_Label.AutoSize = True
        Me.OldPass_Label.Location = New System.Drawing.Point(31, 112)
        Me.OldPass_Label.Name = "OldPass_Label"
        Me.OldPass_Label.Size = New System.Drawing.Size(75, 13)
        Me.OldPass_Label.TabIndex = 4
        Me.OldPass_Label.Text = "Old Password:"
        '
        'StudId_Label
        '
        Me.StudId_Label.AutoSize = True
        Me.StudId_Label.Location = New System.Drawing.Point(31, 37)
        Me.StudId_Label.Name = "StudId_Label"
        Me.StudId_Label.Size = New System.Drawing.Size(59, 13)
        Me.StudId_Label.TabIndex = 3
        Me.StudId_Label.Text = "Student Id:"
        '
        'Office_ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(914, 421)
        Me.Controls.Add(Me.ChangePassword)
        Me.Controls.Add(Me.SetPassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Office_ChangePassword"
        Me.Text = "Set/Change Password"
        Me.SetPassword.ResumeLayout(False)
        Me.SetPassword.PerformLayout()
        Me.ChangePassword.ResumeLayout(False)
        Me.ChangePassword.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SetPassword As GroupBox
    Friend WithEvents ConfPassword_Label As Label
    Friend WithEvents Password_Label As Label
    Friend WithEvents StudentId_Label As Label
    Friend WithEvents ChangePassword As GroupBox
    Friend WithEvents ConfPass_Label As Label
    Friend WithEvents NewPass_Label As Label
    Friend WithEvents OldPass_Label As Label
    Friend WithEvents StudId_Label As Label
    Friend WithEvents SetButton As Button
    Friend WithEvents SetP_StudId_Textbox As TextBox
    Friend WithEvents SetP_CPass_TextBox As MaskedTextBox
    Friend WithEvents SetP_Password_TextBox As MaskedTextBox
    Friend WithEvents ChangeButton As Button
    Friend WithEvents ChgP_ConfPass_Textbox As MaskedTextBox
    Friend WithEvents ChgP_StudId_Textbox As TextBox
    Friend WithEvents ChgP_NewPass_Textbox As MaskedTextBox
    Friend WithEvents ChgP_OldPass_Textbox As MaskedTextBox
End Class
