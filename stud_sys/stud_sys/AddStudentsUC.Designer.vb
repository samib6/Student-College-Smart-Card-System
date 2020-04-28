<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Students_UC
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Update_Button = New System.Windows.Forms.Button()
        Me.Submit_Button = New System.Windows.Forms.Button()
        Me.Delete_Button = New System.Windows.Forms.Button()
        Me.Add_Button = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MaxQualification_DomainUpDown = New System.Windows.Forms.DomainUpDown()
        Me.Address_TextBox = New System.Windows.Forms.RichTextBox()
        Me.Name_TextBox = New System.Windows.Forms.TextBox()
        Me.MobileNo_TextBox = New System.Windows.Forms.TextBox()
        Me.Email_TextBox = New System.Windows.Forms.TextBox()
        Me.UserId_TextBox = New System.Windows.Forms.TextBox()
        Me.MaxQualification_Label = New System.Windows.Forms.Label()
        Me.Email_Label = New System.Windows.Forms.Label()
        Me.MobileNo_Label = New System.Windows.Forms.Label()
        Me.Address_Label = New System.Windows.Forms.Label()
        Me.Name_Label = New System.Windows.Forms.Label()
        Me.UserId_Label = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Update_Button)
        Me.GroupBox2.Controls.Add(Me.Submit_Button)
        Me.GroupBox2.Controls.Add(Me.Delete_Button)
        Me.GroupBox2.Controls.Add(Me.Add_Button)
        Me.GroupBox2.Location = New System.Drawing.Point(525, 87)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(263, 172)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'Update_Button
        '
        Me.Update_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Update_Button.Location = New System.Drawing.Point(18, 99)
        Me.Update_Button.Name = "Update_Button"
        Me.Update_Button.Size = New System.Drawing.Size(106, 27)
        Me.Update_Button.TabIndex = 2
        Me.Update_Button.Text = "Update"
        Me.Update_Button.UseVisualStyleBackColor = False
        '
        'Submit_Button
        '
        Me.Submit_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Submit_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Submit_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit_Button.Location = New System.Drawing.Point(151, 99)
        Me.Submit_Button.Name = "Submit_Button"
        Me.Submit_Button.Size = New System.Drawing.Size(95, 27)
        Me.Submit_Button.TabIndex = 6
        Me.Submit_Button.Text = "SUBMIT"
        Me.Submit_Button.UseVisualStyleBackColor = False
        '
        'Delete_Button
        '
        Me.Delete_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Delete_Button.Location = New System.Drawing.Point(140, 40)
        Me.Delete_Button.Name = "Delete_Button"
        Me.Delete_Button.Size = New System.Drawing.Size(106, 27)
        Me.Delete_Button.TabIndex = 1
        Me.Delete_Button.Text = "Delete"
        Me.Delete_Button.UseVisualStyleBackColor = False
        '
        'Add_Button
        '
        Me.Add_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Add_Button.Location = New System.Drawing.Point(18, 39)
        Me.Add_Button.Name = "Add_Button"
        Me.Add_Button.Size = New System.Drawing.Size(106, 27)
        Me.Add_Button.TabIndex = 0
        Me.Add_Button.Text = "Add"
        Me.Add_Button.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.MaxQualification_DomainUpDown)
        Me.GroupBox1.Controls.Add(Me.Address_TextBox)
        Me.GroupBox1.Controls.Add(Me.Name_TextBox)
        Me.GroupBox1.Controls.Add(Me.MobileNo_TextBox)
        Me.GroupBox1.Controls.Add(Me.Email_TextBox)
        Me.GroupBox1.Controls.Add(Me.UserId_TextBox)
        Me.GroupBox1.Controls.Add(Me.MaxQualification_Label)
        Me.GroupBox1.Controls.Add(Me.Email_Label)
        Me.GroupBox1.Controls.Add(Me.MobileNo_Label)
        Me.GroupBox1.Controls.Add(Me.Address_Label)
        Me.GroupBox1.Controls.Add(Me.Name_Label)
        Me.GroupBox1.Controls.Add(Me.UserId_Label)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(421, 354)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Students"
        '
        'MaxQualification_DomainUpDown
        '
        Me.MaxQualification_DomainUpDown.Location = New System.Drawing.Point(175, 264)
        Me.MaxQualification_DomainUpDown.Name = "MaxQualification_DomainUpDown"
        Me.MaxQualification_DomainUpDown.Size = New System.Drawing.Size(156, 20)
        Me.MaxQualification_DomainUpDown.TabIndex = 14
        Me.MaxQualification_DomainUpDown.Text = "DomainUpDown1"
        '
        'Address_TextBox
        '
        Me.Address_TextBox.Location = New System.Drawing.Point(175, 116)
        Me.Address_TextBox.Name = "Address_TextBox"
        Me.Address_TextBox.Size = New System.Drawing.Size(156, 38)
        Me.Address_TextBox.TabIndex = 13
        Me.Address_TextBox.Text = ""
        '
        'Name_TextBox
        '
        Me.Name_TextBox.Location = New System.Drawing.Point(175, 68)
        Me.Name_TextBox.Name = "Name_TextBox"
        Me.Name_TextBox.Size = New System.Drawing.Size(156, 20)
        Me.Name_TextBox.TabIndex = 12
        '
        'MobileNo_TextBox
        '
        Me.MobileNo_TextBox.Location = New System.Drawing.Point(175, 170)
        Me.MobileNo_TextBox.Name = "MobileNo_TextBox"
        Me.MobileNo_TextBox.Size = New System.Drawing.Size(156, 20)
        Me.MobileNo_TextBox.TabIndex = 10
        '
        'Email_TextBox
        '
        Me.Email_TextBox.Location = New System.Drawing.Point(175, 218)
        Me.Email_TextBox.Name = "Email_TextBox"
        Me.Email_TextBox.Size = New System.Drawing.Size(156, 20)
        Me.Email_TextBox.TabIndex = 9
        '
        'UserId_TextBox
        '
        Me.UserId_TextBox.Location = New System.Drawing.Point(175, 23)
        Me.UserId_TextBox.Name = "UserId_TextBox"
        Me.UserId_TextBox.Size = New System.Drawing.Size(156, 20)
        Me.UserId_TextBox.TabIndex = 7
        '
        'MaxQualification_Label
        '
        Me.MaxQualification_Label.AutoSize = True
        Me.MaxQualification_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaxQualification_Label.Location = New System.Drawing.Point(17, 264)
        Me.MaxQualification_Label.Name = "MaxQualification_Label"
        Me.MaxQualification_Label.Size = New System.Drawing.Size(130, 16)
        Me.MaxQualification_Label.TabIndex = 5
        Me.MaxQualification_Label.Text = "Max Qualification:"
        '
        'Email_Label
        '
        Me.Email_Label.AutoSize = True
        Me.Email_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_Label.Location = New System.Drawing.Point(17, 218)
        Me.Email_Label.Name = "Email_Label"
        Me.Email_Label.Size = New System.Drawing.Size(51, 16)
        Me.Email_Label.TabIndex = 4
        Me.Email_Label.Text = "Email:"
        '
        'MobileNo_Label
        '
        Me.MobileNo_Label.AutoSize = True
        Me.MobileNo_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobileNo_Label.Location = New System.Drawing.Point(17, 170)
        Me.MobileNo_Label.Name = "MobileNo_Label"
        Me.MobileNo_Label.Size = New System.Drawing.Size(83, 16)
        Me.MobileNo_Label.TabIndex = 3
        Me.MobileNo_Label.Text = "Mobile No:"
        '
        'Address_Label
        '
        Me.Address_Label.AutoSize = True
        Me.Address_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address_Label.Location = New System.Drawing.Point(17, 116)
        Me.Address_Label.Name = "Address_Label"
        Me.Address_Label.Size = New System.Drawing.Size(70, 16)
        Me.Address_Label.TabIndex = 2
        Me.Address_Label.Text = "Address:"
        '
        'Name_Label
        '
        Me.Name_Label.AutoSize = True
        Me.Name_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_Label.Location = New System.Drawing.Point(17, 68)
        Me.Name_Label.Name = "Name_Label"
        Me.Name_Label.Size = New System.Drawing.Size(53, 16)
        Me.Name_Label.TabIndex = 1
        Me.Name_Label.Text = "Name:"
        '
        'UserId_Label
        '
        Me.UserId_Label.AutoSize = True
        Me.UserId_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserId_Label.Location = New System.Drawing.Point(17, 23)
        Me.UserId_Label.Name = "UserId_Label"
        Me.UserId_Label.Size = New System.Drawing.Size(62, 16)
        Me.UserId_Label.TabIndex = 0
        Me.UserId_Label.Text = "User Id:"
        '
        'Add_Students_UC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Add_Students_UC"
        Me.Size = New System.Drawing.Size(828, 430)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Update_Button As Button
    Friend WithEvents Submit_Button As Button
    Friend WithEvents Delete_Button As Button
    Friend WithEvents Add_Button As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MaxQualification_DomainUpDown As DomainUpDown
    Friend WithEvents Address_TextBox As RichTextBox
    Friend WithEvents Name_TextBox As TextBox
    Friend WithEvents MobileNo_TextBox As TextBox
    Friend WithEvents Email_TextBox As TextBox
    Friend WithEvents UserId_TextBox As TextBox
    Friend WithEvents MaxQualification_Label As Label
    Friend WithEvents Email_Label As Label
    Friend WithEvents MobileNo_Label As Label
    Friend WithEvents Address_Label As Label
    Friend WithEvents Name_Label As Label
    Friend WithEvents UserId_Label As Label
End Class
