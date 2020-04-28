<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Office_ViewDoc
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
        Me.StudentIdComboBox = New System.Windows.Forms.ComboBox()
        Me.StudentIdLabel = New System.Windows.Forms.Label()
        Me.Sem1LL = New System.Windows.Forms.LinkLabel()
        Me.Sem2LL = New System.Windows.Forms.LinkLabel()
        Me.SSC_LeavingLL = New System.Windows.Forms.LinkLabel()
        Me.SSC_PassingLL = New System.Windows.Forms.LinkLabel()
        Me.PhotoLL = New System.Windows.Forms.LinkLabel()
        Me.ContactLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.EmailIdLabel = New System.Windows.Forms.Label()
        Me.Name_Show = New System.Windows.Forms.Label()
        Me.Address_Show = New System.Windows.Forms.Label()
        Me.ContactNo_Show = New System.Windows.Forms.Label()
        Me.EmailId_Show = New System.Windows.Forms.Label()
        Me.Photo_pb = New System.Windows.Forms.PictureBox()
        CType(Me.Photo_pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentIdComboBox
        '
        Me.StudentIdComboBox.FormattingEnabled = True
        Me.StudentIdComboBox.Location = New System.Drawing.Point(203, 28)
        Me.StudentIdComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StudentIdComboBox.Name = "StudentIdComboBox"
        Me.StudentIdComboBox.Size = New System.Drawing.Size(257, 23)
        Me.StudentIdComboBox.TabIndex = 0
        '
        'StudentIdLabel
        '
        Me.StudentIdLabel.AutoSize = True
        Me.StudentIdLabel.Location = New System.Drawing.Point(43, 32)
        Me.StudentIdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StudentIdLabel.Name = "StudentIdLabel"
        Me.StudentIdLabel.Size = New System.Drawing.Size(76, 15)
        Me.StudentIdLabel.TabIndex = 1
        Me.StudentIdLabel.Text = "Student Id:"
        '
        'Sem1LL
        '
        Me.Sem1LL.AutoSize = True
        Me.Sem1LL.Location = New System.Drawing.Point(624, 67)
        Me.Sem1LL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Sem1LL.Name = "Sem1LL"
        Me.Sem1LL.Size = New System.Drawing.Size(41, 15)
        Me.Sem1LL.TabIndex = 2
        Me.Sem1LL.TabStop = True
        Me.Sem1LL.Text = "Sem1"
        '
        'Sem2LL
        '
        Me.Sem2LL.AutoSize = True
        Me.Sem2LL.Location = New System.Drawing.Point(624, 109)
        Me.Sem2LL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Sem2LL.Name = "Sem2LL"
        Me.Sem2LL.Size = New System.Drawing.Size(41, 15)
        Me.Sem2LL.TabIndex = 3
        Me.Sem2LL.TabStop = True
        Me.Sem2LL.Text = "Sem2"
        '
        'SSC_LeavingLL
        '
        Me.SSC_LeavingLL.AutoSize = True
        Me.SSC_LeavingLL.Location = New System.Drawing.Point(624, 149)
        Me.SSC_LeavingLL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SSC_LeavingLL.Name = "SSC_LeavingLL"
        Me.SSC_LeavingLL.Size = New System.Drawing.Size(85, 15)
        Me.SSC_LeavingLL.TabIndex = 4
        Me.SSC_LeavingLL.TabStop = True
        Me.SSC_LeavingLL.Text = "SSC Leaving"
        '
        'SSC_PassingLL
        '
        Me.SSC_PassingLL.AutoSize = True
        Me.SSC_PassingLL.Location = New System.Drawing.Point(624, 208)
        Me.SSC_PassingLL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SSC_PassingLL.Name = "SSC_PassingLL"
        Me.SSC_PassingLL.Size = New System.Drawing.Size(86, 15)
        Me.SSC_PassingLL.TabIndex = 5
        Me.SSC_PassingLL.TabStop = True
        Me.SSC_PassingLL.Text = "SSC Passing"
        '
        'PhotoLL
        '
        Me.PhotoLL.AutoSize = True
        Me.PhotoLL.Location = New System.Drawing.Point(624, 27)
        Me.PhotoLL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PhotoLL.Name = "PhotoLL"
        Me.PhotoLL.Size = New System.Drawing.Size(43, 15)
        Me.PhotoLL.TabIndex = 6
        Me.PhotoLL.TabStop = True
        Me.PhotoLL.Text = "Photo"
        '
        'ContactLabel
        '
        Me.ContactLabel.AutoSize = True
        Me.ContactLabel.Location = New System.Drawing.Point(43, 163)
        Me.ContactLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ContactLabel.Name = "ContactLabel"
        Me.ContactLabel.Size = New System.Drawing.Size(82, 15)
        Me.ContactLabel.TabIndex = 7
        Me.ContactLabel.Text = "Contact No:"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(43, 118)
        Me.AddressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(64, 15)
        Me.AddressLabel.TabIndex = 8
        Me.AddressLabel.Text = "Address:"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(43, 78)
        Me.NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(50, 15)
        Me.NameLabel.TabIndex = 9
        Me.NameLabel.Text = "Name:"
        '
        'EmailIdLabel
        '
        Me.EmailIdLabel.AutoSize = True
        Me.EmailIdLabel.Location = New System.Drawing.Point(43, 208)
        Me.EmailIdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmailIdLabel.Name = "EmailIdLabel"
        Me.EmailIdLabel.Size = New System.Drawing.Size(68, 15)
        Me.EmailIdLabel.TabIndex = 10
        Me.EmailIdLabel.Text = "Email Id:"
        '
        'Name_Show
        '
        Me.Name_Show.AutoSize = True
        Me.Name_Show.Location = New System.Drawing.Point(210, 83)
        Me.Name_Show.Name = "Name_Show"
        Me.Name_Show.Size = New System.Drawing.Size(12, 15)
        Me.Name_Show.TabIndex = 11
        Me.Name_Show.Text = "."
        '
        'Address_Show
        '
        Me.Address_Show.AutoSize = True
        Me.Address_Show.Location = New System.Drawing.Point(210, 118)
        Me.Address_Show.Name = "Address_Show"
        Me.Address_Show.Size = New System.Drawing.Size(12, 15)
        Me.Address_Show.TabIndex = 12
        Me.Address_Show.Text = "."
        '
        'ContactNo_Show
        '
        Me.ContactNo_Show.AutoSize = True
        Me.ContactNo_Show.Location = New System.Drawing.Point(210, 163)
        Me.ContactNo_Show.Name = "ContactNo_Show"
        Me.ContactNo_Show.Size = New System.Drawing.Size(12, 15)
        Me.ContactNo_Show.TabIndex = 13
        Me.ContactNo_Show.Text = "."
        '
        'EmailId_Show
        '
        Me.EmailId_Show.AutoSize = True
        Me.EmailId_Show.Location = New System.Drawing.Point(210, 208)
        Me.EmailId_Show.Name = "EmailId_Show"
        Me.EmailId_Show.Size = New System.Drawing.Size(12, 15)
        Me.EmailId_Show.TabIndex = 14
        Me.EmailId_Show.Text = "."
        '
        'Photo_pb
        '
        Me.Photo_pb.Location = New System.Drawing.Point(333, 254)
        Me.Photo_pb.Name = "Photo_pb"
        Me.Photo_pb.Size = New System.Drawing.Size(153, 159)
        Me.Photo_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Photo_pb.TabIndex = 15
        Me.Photo_pb.TabStop = False
        '
        'Office_ViewDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(914, 432)
        Me.Controls.Add(Me.Photo_pb)
        Me.Controls.Add(Me.EmailId_Show)
        Me.Controls.Add(Me.ContactNo_Show)
        Me.Controls.Add(Me.Address_Show)
        Me.Controls.Add(Me.Name_Show)
        Me.Controls.Add(Me.EmailIdLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.ContactLabel)
        Me.Controls.Add(Me.PhotoLL)
        Me.Controls.Add(Me.SSC_PassingLL)
        Me.Controls.Add(Me.SSC_LeavingLL)
        Me.Controls.Add(Me.Sem2LL)
        Me.Controls.Add(Me.Sem1LL)
        Me.Controls.Add(Me.StudentIdLabel)
        Me.Controls.Add(Me.StudentIdComboBox)
        Me.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Office_ViewDoc"
        Me.Text = "Office_ViewDoc"
        CType(Me.Photo_pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StudentIdComboBox As ComboBox
    Friend WithEvents StudentIdLabel As Label
    Friend WithEvents Sem1LL As LinkLabel
    Friend WithEvents Sem2LL As LinkLabel
    Friend WithEvents SSC_LeavingLL As LinkLabel
    Friend WithEvents SSC_PassingLL As LinkLabel
    Friend WithEvents PhotoLL As LinkLabel
    Friend WithEvents ContactLabel As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents EmailIdLabel As Label
    Friend WithEvents Name_Show As Label
    Friend WithEvents Address_Show As Label
    Friend WithEvents ContactNo_Show As Label
    Friend WithEvents EmailId_Show As Label
    Friend WithEvents Photo_pb As PictureBox
End Class
