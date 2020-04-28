<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class Student_Login_Form
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
    Friend WithEvents Stud_Logo_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Student_Id_Label As System.Windows.Forms.Label
    Friend WithEvents Password_Label As System.Windows.Forms.Label
    Friend WithEvents Student_Id_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Password_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Login_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student_Login_Form))
        Me.Stud_Logo_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Student_Id_Label = New System.Windows.Forms.Label()
        Me.Password_Label = New System.Windows.Forms.Label()
        Me.Student_Id_TextBox = New System.Windows.Forms.TextBox()
        Me.Password_TextBox = New System.Windows.Forms.TextBox()
        Me.Login_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        CType(Me.Stud_Logo_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Stud_Logo_PictureBox
        '
        Me.Stud_Logo_PictureBox.BackColor = System.Drawing.Color.White
        Me.Stud_Logo_PictureBox.Image = CType(resources.GetObject("Stud_Logo_PictureBox.Image"), System.Drawing.Image)
        Me.Stud_Logo_PictureBox.Location = New System.Drawing.Point(0, 0)
        Me.Stud_Logo_PictureBox.Name = "Stud_Logo_PictureBox"
        Me.Stud_Logo_PictureBox.Size = New System.Drawing.Size(188, 242)
        Me.Stud_Logo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Stud_Logo_PictureBox.TabIndex = 0
        Me.Stud_Logo_PictureBox.TabStop = False
        '
        'Student_Id_Label
        '
        Me.Student_Id_Label.Location = New System.Drawing.Point(194, 20)
        Me.Student_Id_Label.Name = "Student_Id_Label"
        Me.Student_Id_Label.Size = New System.Drawing.Size(220, 23)
        Me.Student_Id_Label.TabIndex = 0
        Me.Student_Id_Label.Text = "Student-Id:"
        Me.Student_Id_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Password_Label
        '
        Me.Password_Label.Location = New System.Drawing.Point(194, 77)
        Me.Password_Label.Name = "Password_Label"
        Me.Password_Label.Size = New System.Drawing.Size(220, 23)
        Me.Password_Label.TabIndex = 2
        Me.Password_Label.Text = "&Password"
        Me.Password_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Student_Id_TextBox
        '
        Me.Student_Id_TextBox.Location = New System.Drawing.Point(196, 40)
        Me.Student_Id_TextBox.Name = "Student_Id_TextBox"
        Me.Student_Id_TextBox.Size = New System.Drawing.Size(220, 20)
        Me.Student_Id_TextBox.TabIndex = 1
        '
        'Password_TextBox
        '
        Me.Password_TextBox.Location = New System.Drawing.Point(196, 97)
        Me.Password_TextBox.Name = "Password_TextBox"
        Me.Password_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password_TextBox.Size = New System.Drawing.Size(220, 20)
        Me.Password_TextBox.TabIndex = 3
        '
        'Login_Button
        '
        Me.Login_Button.Location = New System.Drawing.Point(197, 161)
        Me.Login_Button.Name = "Login_Button"
        Me.Login_Button.Size = New System.Drawing.Size(94, 23)
        Me.Login_Button.TabIndex = 4
        Me.Login_Button.Text = "Login"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(300, 161)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(94, 23)
        Me.Cancel_Button.TabIndex = 5
        Me.Cancel_Button.Text = "&Cancel"
        '
        'Student_Login_Form
        '
        Me.AcceptButton = Me.Login_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(457, 237)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.Login_Button)
        Me.Controls.Add(Me.Password_TextBox)
        Me.Controls.Add(Me.Student_Id_TextBox)
        Me.Controls.Add(Me.Password_Label)
        Me.Controls.Add(Me.Student_Id_Label)
        Me.Controls.Add(Me.Stud_Logo_PictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Student_Login_Form"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.Stud_Logo_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
