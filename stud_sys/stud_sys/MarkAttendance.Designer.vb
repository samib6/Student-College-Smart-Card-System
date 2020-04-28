<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MarkAttendance
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
        Me.components = New System.ComponentModel.Container()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Date_Label = New System.Windows.Forms.Label()
        Me.StudId_Label = New System.Windows.Forms.Label()
        Me.StudId_TextBox = New System.Windows.Forms.TextBox()
        Me.MarkAttendance_Button = New System.Windows.Forms.Button()
        Me.Time_Label = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ColorDialog2 = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Location = New System.Drawing.Point(262, 79)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(243, 20)
        Me.DateTimePicker.TabIndex = 0
        '
        'Date_Label
        '
        Me.Date_Label.AutoSize = True
        Me.Date_Label.Font = New System.Drawing.Font("Century Schoolbook", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Label.Location = New System.Drawing.Point(149, 85)
        Me.Date_Label.Name = "Date_Label"
        Me.Date_Label.Size = New System.Drawing.Size(46, 18)
        Me.Date_Label.TabIndex = 2
        Me.Date_Label.Text = "Date:"
        '
        'StudId_Label
        '
        Me.StudId_Label.AutoSize = True
        Me.StudId_Label.Font = New System.Drawing.Font("Century Schoolbook", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudId_Label.Location = New System.Drawing.Point(149, 128)
        Me.StudId_Label.Name = "StudId_Label"
        Me.StudId_Label.Size = New System.Drawing.Size(87, 18)
        Me.StudId_Label.TabIndex = 3
        Me.StudId_Label.Text = "Student Id:"
        '
        'StudId_TextBox
        '
        Me.StudId_TextBox.Location = New System.Drawing.Point(262, 125)
        Me.StudId_TextBox.Name = "StudId_TextBox"
        Me.StudId_TextBox.Size = New System.Drawing.Size(244, 20)
        Me.StudId_TextBox.TabIndex = 4
        '
        'MarkAttendance_Button
        '
        Me.MarkAttendance_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MarkAttendance_Button.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarkAttendance_Button.ForeColor = System.Drawing.Color.Black
        Me.MarkAttendance_Button.Location = New System.Drawing.Point(262, 234)
        Me.MarkAttendance_Button.Name = "MarkAttendance_Button"
        Me.MarkAttendance_Button.Size = New System.Drawing.Size(244, 29)
        Me.MarkAttendance_Button.TabIndex = 5
        Me.MarkAttendance_Button.Text = "Mark Attendance"
        Me.MarkAttendance_Button.UseVisualStyleBackColor = False
        '
        'Time_Label
        '
        Me.Time_Label.AutoSize = True
        Me.Time_Label.Location = New System.Drawing.Point(164, 23)
        Me.Time_Label.Name = "Time_Label"
        Me.Time_Label.Size = New System.Drawing.Size(13, 13)
        Me.Time_Label.TabIndex = 7
        Me.Time_Label.Text = ".."
        '
        'Timer1
        '
        '
        'MarkAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(890, 409)
        Me.Controls.Add(Me.Time_Label)
        Me.Controls.Add(Me.MarkAttendance_Button)
        Me.Controls.Add(Me.StudId_TextBox)
        Me.Controls.Add(Me.StudId_Label)
        Me.Controls.Add(Me.Date_Label)
        Me.Controls.Add(Me.DateTimePicker)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MarkAttendance"
        Me.Text = "MarkAttendance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents Date_Label As Label
    Friend WithEvents StudId_Label As Label
    Friend WithEvents StudId_TextBox As TextBox
    Friend WithEvents MarkAttendance_Button As Button
    Friend WithEvents Time_Label As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ColorDialog2 As ColorDialog
End Class
