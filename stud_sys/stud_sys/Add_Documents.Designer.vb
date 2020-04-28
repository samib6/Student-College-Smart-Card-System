<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_Documents
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
        Me.Submit_Button = New System.Windows.Forms.Button()
        Me.Student_Id_Label = New System.Windows.Forms.Label()
        Me.Sem_1_Label = New System.Windows.Forms.Label()
        Me.Photo_label = New System.Windows.Forms.Label()
        Me.Sem_2_Label = New System.Windows.Forms.Label()
        Me.SSC_Passing_Label = New System.Windows.Forms.Label()
        Me.Sem2_Textbox = New System.Windows.Forms.TextBox()
        Me.SSC_Passing_Textbox = New System.Windows.Forms.TextBox()
        Me.SSC_Leaving_Textbox = New System.Windows.Forms.TextBox()
        Me.SSC_Leaving_Label = New System.Windows.Forms.Label()
        Me.Sem1_Textbox = New System.Windows.Forms.TextBox()
        Me.Photo_Textbox = New System.Windows.Forms.TextBox()
        Me.Photo_Add_Button = New System.Windows.Forms.Button()
        Me.Sem1_Button = New System.Windows.Forms.Button()
        Me.Sem2_Button = New System.Windows.Forms.Button()
        Me.SSC_Passing_Button = New System.Windows.Forms.Button()
        Me.SSC_Leave_Button = New System.Windows.Forms.Button()
        Me.Photo_Search = New System.Windows.Forms.Button()
        Me.Sem2_Search = New System.Windows.Forms.Button()
        Me.Sem1_Search = New System.Windows.Forms.Button()
        Me.SSC_Passing_Search = New System.Windows.Forms.Button()
        Me.Student_Id_ComboBox = New System.Windows.Forms.ComboBox()
        Me.SSC_Leaving_Search = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Submit_Button
        '
        Me.Submit_Button.Location = New System.Drawing.Point(368, 391)
        Me.Submit_Button.Name = "Submit_Button"
        Me.Submit_Button.Size = New System.Drawing.Size(131, 25)
        Me.Submit_Button.TabIndex = 12
        Me.Submit_Button.Text = "SUBMIT"
        Me.Submit_Button.UseVisualStyleBackColor = True
        '
        'Student_Id_Label
        '
        Me.Student_Id_Label.AutoSize = True
        Me.Student_Id_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_Id_Label.Location = New System.Drawing.Point(84, 48)
        Me.Student_Id_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Student_Id_Label.Name = "Student_Id_Label"
        Me.Student_Id_Label.Size = New System.Drawing.Size(81, 16)
        Me.Student_Id_Label.TabIndex = 0
        Me.Student_Id_Label.Text = "Student Id:"
        '
        'Sem_1_Label
        '
        Me.Sem_1_Label.AutoSize = True
        Me.Sem_1_Label.Location = New System.Drawing.Point(72, 141)
        Me.Sem_1_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Sem_1_Label.Name = "Sem_1_Label"
        Me.Sem_1_Label.Size = New System.Drawing.Size(142, 16)
        Me.Sem_1_Label.TabIndex = 1
        Me.Sem_1_Label.Text = "Sem -1(Marksheet):"
        '
        'Photo_label
        '
        Me.Photo_label.AutoSize = True
        Me.Photo_label.Location = New System.Drawing.Point(84, 90)
        Me.Photo_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Photo_label.Name = "Photo_label"
        Me.Photo_label.Size = New System.Drawing.Size(52, 16)
        Me.Photo_label.TabIndex = 2
        Me.Photo_label.Text = "Photo:"
        Me.Photo_label.Visible = False
        '
        'Sem_2_Label
        '
        Me.Sem_2_Label.AutoSize = True
        Me.Sem_2_Label.Location = New System.Drawing.Point(72, 196)
        Me.Sem_2_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Sem_2_Label.Name = "Sem_2_Label"
        Me.Sem_2_Label.Size = New System.Drawing.Size(138, 16)
        Me.Sem_2_Label.TabIndex = 4
        Me.Sem_2_Label.Text = "Sem-2(Marksheet):"
        '
        'SSC_Passing_Label
        '
        Me.SSC_Passing_Label.AutoSize = True
        Me.SSC_Passing_Label.Location = New System.Drawing.Point(84, 245)
        Me.SSC_Passing_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SSC_Passing_Label.Name = "SSC_Passing_Label"
        Me.SSC_Passing_Label.Size = New System.Drawing.Size(102, 16)
        Me.SSC_Passing_Label.TabIndex = 5
        Me.SSC_Passing_Label.Text = "SSC Passing:"
        '
        'Sem2_Textbox
        '
        Me.Sem2_Textbox.Location = New System.Drawing.Point(230, 196)
        Me.Sem2_Textbox.Margin = New System.Windows.Forms.Padding(4)
        Me.Sem2_Textbox.Name = "Sem2_Textbox"
        Me.Sem2_Textbox.Size = New System.Drawing.Size(238, 22)
        Me.Sem2_Textbox.TabIndex = 7
        '
        'SSC_Passing_Textbox
        '
        Me.SSC_Passing_Textbox.Location = New System.Drawing.Point(230, 245)
        Me.SSC_Passing_Textbox.Margin = New System.Windows.Forms.Padding(4)
        Me.SSC_Passing_Textbox.Name = "SSC_Passing_Textbox"
        Me.SSC_Passing_Textbox.Size = New System.Drawing.Size(238, 22)
        Me.SSC_Passing_Textbox.TabIndex = 8
        '
        'SSC_Leaving_Textbox
        '
        Me.SSC_Leaving_Textbox.Location = New System.Drawing.Point(230, 304)
        Me.SSC_Leaving_Textbox.Margin = New System.Windows.Forms.Padding(4)
        Me.SSC_Leaving_Textbox.Name = "SSC_Leaving_Textbox"
        Me.SSC_Leaving_Textbox.Size = New System.Drawing.Size(238, 22)
        Me.SSC_Leaving_Textbox.TabIndex = 11
        '
        'SSC_Leaving_Label
        '
        Me.SSC_Leaving_Label.AutoSize = True
        Me.SSC_Leaving_Label.Location = New System.Drawing.Point(85, 304)
        Me.SSC_Leaving_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SSC_Leaving_Label.Name = "SSC_Leaving_Label"
        Me.SSC_Leaving_Label.Size = New System.Drawing.Size(101, 16)
        Me.SSC_Leaving_Label.TabIndex = 6
        Me.SSC_Leaving_Label.Text = "SSC Leaving:"
        '
        'Sem1_Textbox
        '
        Me.Sem1_Textbox.Location = New System.Drawing.Point(230, 141)
        Me.Sem1_Textbox.Margin = New System.Windows.Forms.Padding(4)
        Me.Sem1_Textbox.Name = "Sem1_Textbox"
        Me.Sem1_Textbox.Size = New System.Drawing.Size(238, 22)
        Me.Sem1_Textbox.TabIndex = 9
        '
        'Photo_Textbox
        '
        Me.Photo_Textbox.Location = New System.Drawing.Point(230, 90)
        Me.Photo_Textbox.Margin = New System.Windows.Forms.Padding(4)
        Me.Photo_Textbox.Name = "Photo_Textbox"
        Me.Photo_Textbox.Size = New System.Drawing.Size(238, 22)
        Me.Photo_Textbox.TabIndex = 10
        Me.Photo_Textbox.Visible = False
        '
        'Photo_Add_Button
        '
        Me.Photo_Add_Button.Location = New System.Drawing.Point(571, 91)
        Me.Photo_Add_Button.Name = "Photo_Add_Button"
        Me.Photo_Add_Button.Size = New System.Drawing.Size(72, 25)
        Me.Photo_Add_Button.TabIndex = 13
        Me.Photo_Add_Button.Text = "ADD"
        Me.Photo_Add_Button.UseVisualStyleBackColor = True
        '
        'Sem1_Button
        '
        Me.Sem1_Button.Location = New System.Drawing.Point(571, 143)
        Me.Sem1_Button.Name = "Sem1_Button"
        Me.Sem1_Button.Size = New System.Drawing.Size(72, 24)
        Me.Sem1_Button.TabIndex = 14
        Me.Sem1_Button.Text = "ADD"
        Me.Sem1_Button.UseVisualStyleBackColor = True
        '
        'Sem2_Button
        '
        Me.Sem2_Button.Location = New System.Drawing.Point(571, 196)
        Me.Sem2_Button.Name = "Sem2_Button"
        Me.Sem2_Button.Size = New System.Drawing.Size(72, 28)
        Me.Sem2_Button.TabIndex = 15
        Me.Sem2_Button.Text = "ADD"
        Me.Sem2_Button.UseVisualStyleBackColor = True
        '
        'SSC_Passing_Button
        '
        Me.SSC_Passing_Button.Location = New System.Drawing.Point(571, 248)
        Me.SSC_Passing_Button.Name = "SSC_Passing_Button"
        Me.SSC_Passing_Button.Size = New System.Drawing.Size(72, 25)
        Me.SSC_Passing_Button.TabIndex = 16
        Me.SSC_Passing_Button.Text = "ADD"
        Me.SSC_Passing_Button.UseVisualStyleBackColor = True
        '
        'SSC_Leave_Button
        '
        Me.SSC_Leave_Button.Location = New System.Drawing.Point(571, 305)
        Me.SSC_Leave_Button.Name = "SSC_Leave_Button"
        Me.SSC_Leave_Button.Size = New System.Drawing.Size(72, 25)
        Me.SSC_Leave_Button.TabIndex = 17
        Me.SSC_Leave_Button.Text = "ADD"
        Me.SSC_Leave_Button.UseVisualStyleBackColor = True
        '
        'Photo_Search
        '
        Me.Photo_Search.Location = New System.Drawing.Point(498, 90)
        Me.Photo_Search.Name = "Photo_Search"
        Me.Photo_Search.Size = New System.Drawing.Size(34, 26)
        Me.Photo_Search.TabIndex = 18
        Me.Photo_Search.Text = "..."
        Me.Photo_Search.UseVisualStyleBackColor = True
        '
        'Sem2_Search
        '
        Me.Sem2_Search.Location = New System.Drawing.Point(498, 194)
        Me.Sem2_Search.Name = "Sem2_Search"
        Me.Sem2_Search.Size = New System.Drawing.Size(34, 26)
        Me.Sem2_Search.TabIndex = 19
        Me.Sem2_Search.Text = "..."
        Me.Sem2_Search.UseVisualStyleBackColor = True
        '
        'Sem1_Search
        '
        Me.Sem1_Search.Location = New System.Drawing.Point(498, 139)
        Me.Sem1_Search.Name = "Sem1_Search"
        Me.Sem1_Search.Size = New System.Drawing.Size(34, 26)
        Me.Sem1_Search.TabIndex = 20
        Me.Sem1_Search.Text = "..."
        Me.Sem1_Search.UseVisualStyleBackColor = True
        '
        'SSC_Passing_Search
        '
        Me.SSC_Passing_Search.Location = New System.Drawing.Point(498, 245)
        Me.SSC_Passing_Search.Name = "SSC_Passing_Search"
        Me.SSC_Passing_Search.Size = New System.Drawing.Size(34, 26)
        Me.SSC_Passing_Search.TabIndex = 21
        Me.SSC_Passing_Search.Text = "..."
        Me.SSC_Passing_Search.UseVisualStyleBackColor = True
        '
        'Student_Id_ComboBox
        '
        Me.Student_Id_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Student_Id_ComboBox.FormattingEnabled = True
        Me.Student_Id_ComboBox.IntegralHeight = False
        Me.Student_Id_ComboBox.Location = New System.Drawing.Point(230, 45)
        Me.Student_Id_ComboBox.MaxDropDownItems = 3
        Me.Student_Id_ComboBox.Name = "Student_Id_ComboBox"
        Me.Student_Id_ComboBox.Size = New System.Drawing.Size(238, 24)
        Me.Student_Id_ComboBox.TabIndex = 23
        '
        'SSC_Leaving_Search
        '
        Me.SSC_Leaving_Search.Location = New System.Drawing.Point(498, 305)
        Me.SSC_Leaving_Search.Name = "SSC_Leaving_Search"
        Me.SSC_Leaving_Search.Size = New System.Drawing.Size(34, 23)
        Me.SSC_Leaving_Search.TabIndex = 24
        Me.SSC_Leaving_Search.Text = "..."
        Me.SSC_Leaving_Search.UseVisualStyleBackColor = True
        '
        'Add_Documents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(969, 446)
        Me.Controls.Add(Me.SSC_Leaving_Search)
        Me.Controls.Add(Me.SSC_Leave_Button)
        Me.Controls.Add(Me.SSC_Passing_Button)
        Me.Controls.Add(Me.Student_Id_ComboBox)
        Me.Controls.Add(Me.Sem2_Button)
        Me.Controls.Add(Me.SSC_Passing_Search)
        Me.Controls.Add(Me.Sem1_Button)
        Me.Controls.Add(Me.Photo_Add_Button)
        Me.Controls.Add(Me.Sem2_Search)
        Me.Controls.Add(Me.Sem1_Search)
        Me.Controls.Add(Me.Submit_Button)
        Me.Controls.Add(Me.Student_Id_Label)
        Me.Controls.Add(Me.Photo_Search)
        Me.Controls.Add(Me.Photo_label)
        Me.Controls.Add(Me.Sem_1_Label)
        Me.Controls.Add(Me.Sem_2_Label)
        Me.Controls.Add(Me.SSC_Passing_Label)
        Me.Controls.Add(Me.SSC_Leaving_Label)
        Me.Controls.Add(Me.Photo_Textbox)
        Me.Controls.Add(Me.SSC_Leaving_Textbox)
        Me.Controls.Add(Me.Sem1_Textbox)
        Me.Controls.Add(Me.SSC_Passing_Textbox)
        Me.Controls.Add(Me.Sem2_Textbox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Add_Documents"
        Me.Text = "Add_Documents"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Submit_Button As Button
    Friend WithEvents Student_Id_Label As Label
    Friend WithEvents Sem_1_Label As Label
    Friend WithEvents Photo_label As Label
    Friend WithEvents Sem_2_Label As Label
    Friend WithEvents SSC_Passing_Label As Label
    Friend WithEvents Sem2_Textbox As TextBox
    Friend WithEvents SSC_Passing_Textbox As TextBox
    Friend WithEvents SSC_Leaving_Textbox As TextBox
    Friend WithEvents SSC_Leaving_Label As Label
    Friend WithEvents Sem1_Textbox As TextBox
    Friend WithEvents Photo_Textbox As TextBox
    Friend WithEvents Photo_Add_Button As Button
    Friend WithEvents Sem1_Button As Button
    Friend WithEvents Sem2_Button As Button
    Friend WithEvents SSC_Passing_Button As Button
    Friend WithEvents SSC_Leave_Button As Button
    Friend WithEvents Photo_Search As Button
    Friend WithEvents Sem2_Search As Button
    Friend WithEvents Sem1_Search As Button
    Friend WithEvents SSC_Passing_Search As Button
    Friend WithEvents Student_Id_ComboBox As ComboBox
    Friend WithEvents SSC_Leaving_Search As Button
End Class
