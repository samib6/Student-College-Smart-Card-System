<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class My_Documents
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
        Me.My_Document_Label = New System.Windows.Forms.Label()
        Me.Photo_LLabel = New System.Windows.Forms.LinkLabel()
        Me.SSC_Passing_LLabel = New System.Windows.Forms.LinkLabel()
        Me.SSC_Leaving_LLabel = New System.Windows.Forms.LinkLabel()
        Me.Sem_I_LLabel = New System.Windows.Forms.LinkLabel()
        Me.Sem_II_LLabel = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'My_Document_Label
        '
        Me.My_Document_Label.AutoSize = True
        Me.My_Document_Label.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.My_Document_Label.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.My_Document_Label.Location = New System.Drawing.Point(320, 44)
        Me.My_Document_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.My_Document_Label.Name = "My_Document_Label"
        Me.My_Document_Label.Size = New System.Drawing.Size(166, 30)
        Me.My_Document_Label.TabIndex = 0
        Me.My_Document_Label.Text = "My Documents"
        '
        'Photo_LLabel
        '
        Me.Photo_LLabel.AutoSize = True
        Me.Photo_LLabel.Location = New System.Drawing.Point(384, 119)
        Me.Photo_LLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Photo_LLabel.Name = "Photo_LLabel"
        Me.Photo_LLabel.Size = New System.Drawing.Size(48, 16)
        Me.Photo_LLabel.TabIndex = 1
        Me.Photo_LLabel.TabStop = True
        Me.Photo_LLabel.Text = "Photo"
        '
        'SSC_Passing_LLabel
        '
        Me.SSC_Passing_LLabel.AutoSize = True
        Me.SSC_Passing_LLabel.Location = New System.Drawing.Point(359, 163)
        Me.SSC_Passing_LLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SSC_Passing_LLabel.Name = "SSC_Passing_LLabel"
        Me.SSC_Passing_LLabel.Size = New System.Drawing.Size(98, 16)
        Me.SSC_Passing_LLabel.TabIndex = 2
        Me.SSC_Passing_LLabel.TabStop = True
        Me.SSC_Passing_LLabel.Text = "SSC Passing"
        '
        'SSC_Leaving_LLabel
        '
        Me.SSC_Leaving_LLabel.AutoSize = True
        Me.SSC_Leaving_LLabel.Location = New System.Drawing.Point(360, 215)
        Me.SSC_Leaving_LLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SSC_Leaving_LLabel.Name = "SSC_Leaving_LLabel"
        Me.SSC_Leaving_LLabel.Size = New System.Drawing.Size(97, 16)
        Me.SSC_Leaving_LLabel.TabIndex = 3
        Me.SSC_Leaving_LLabel.TabStop = True
        Me.SSC_Leaving_LLabel.Text = "SSC Leaving"
        '
        'Sem_I_LLabel
        '
        Me.Sem_I_LLabel.AutoSize = True
        Me.Sem_I_LLabel.Location = New System.Drawing.Point(384, 265)
        Me.Sem_I_LLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Sem_I_LLabel.Name = "Sem_I_LLabel"
        Me.Sem_I_LLabel.Size = New System.Drawing.Size(48, 16)
        Me.Sem_I_LLabel.TabIndex = 4
        Me.Sem_I_LLabel.TabStop = True
        Me.Sem_I_LLabel.Text = "Sem-I"
        '
        'Sem_II_LLabel
        '
        Me.Sem_II_LLabel.AutoSize = True
        Me.Sem_II_LLabel.Location = New System.Drawing.Point(380, 315)
        Me.Sem_II_LLabel.Name = "Sem_II_LLabel"
        Me.Sem_II_LLabel.Size = New System.Drawing.Size(52, 16)
        Me.Sem_II_LLabel.TabIndex = 5
        Me.Sem_II_LLabel.TabStop = True
        Me.Sem_II_LLabel.Text = "Sem-II"
        '
        'My_Documents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(914, 432)
        Me.Controls.Add(Me.Sem_II_LLabel)
        Me.Controls.Add(Me.Sem_I_LLabel)
        Me.Controls.Add(Me.SSC_Leaving_LLabel)
        Me.Controls.Add(Me.SSC_Passing_LLabel)
        Me.Controls.Add(Me.Photo_LLabel)
        Me.Controls.Add(Me.My_Document_Label)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "My_Documents"
        Me.Text = "My Documents"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents My_Document_Label As Label
    Friend WithEvents Photo_LLabel As LinkLabel
    Friend WithEvents SSC_Passing_LLabel As LinkLabel
    Friend WithEvents SSC_Leaving_LLabel As LinkLabel
    Friend WithEvents Sem_I_LLabel As LinkLabel
    Friend WithEvents Sem_II_LLabel As LinkLabel
End Class
