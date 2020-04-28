<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewDocAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewDocAdmin))
        Me.Student_Id_Combobox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Photo_LL = New System.Windows.Forms.LinkLabel()
        Me.Sem1_LL = New System.Windows.Forms.LinkLabel()
        Me.Sem2_LL = New System.Windows.Forms.LinkLabel()
        Me.SSC_Passing_LL = New System.Windows.Forms.LinkLabel()
        Me.SSC_Leaving_LL = New System.Windows.Forms.LinkLabel()
        Me.Name_Show = New System.Windows.Forms.Label()
        Me.Address_Show = New System.Windows.Forms.Label()
        Me.Mobile_No_Show = New System.Windows.Forms.Label()
        Me.Email_Id_Show = New System.Windows.Forms.Label()
        Me.pdfviewer = New AxAcroPDFLib.AxAcroPDF()
        Me.Photo_pb = New System.Windows.Forms.PictureBox()
        CType(Me.pdfviewer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Photo_pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Student_Id_Combobox
        '
        Me.Student_Id_Combobox.FormattingEnabled = True
        Me.Student_Id_Combobox.Location = New System.Drawing.Point(199, 18)
        Me.Student_Id_Combobox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Student_Id_Combobox.Name = "Student_Id_Combobox"
        Me.Student_Id_Combobox.Size = New System.Drawing.Size(244, 26)
        Me.Student_Id_Combobox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Student Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 86)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 142)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 200)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Mobile Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 260)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Email Id:"
        '
        'Photo_LL
        '
        Me.Photo_LL.AutoSize = True
        Me.Photo_LL.Location = New System.Drawing.Point(535, 26)
        Me.Photo_LL.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Photo_LL.Name = "Photo_LL"
        Me.Photo_LL.Size = New System.Drawing.Size(50, 18)
        Me.Photo_LL.TabIndex = 6
        Me.Photo_LL.TabStop = True
        Me.Photo_LL.Text = "Photo"
        '
        'Sem1_LL
        '
        Me.Sem1_LL.AutoSize = True
        Me.Sem1_LL.Location = New System.Drawing.Point(535, 87)
        Me.Sem1_LL.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Sem1_LL.Name = "Sem1_LL"
        Me.Sem1_LL.Size = New System.Drawing.Size(52, 18)
        Me.Sem1_LL.TabIndex = 7
        Me.Sem1_LL.TabStop = True
        Me.Sem1_LL.Text = "Sem1 "
        '
        'Sem2_LL
        '
        Me.Sem2_LL.AutoSize = True
        Me.Sem2_LL.Location = New System.Drawing.Point(535, 155)
        Me.Sem2_LL.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Sem2_LL.Name = "Sem2_LL"
        Me.Sem2_LL.Size = New System.Drawing.Size(48, 18)
        Me.Sem2_LL.TabIndex = 8
        Me.Sem2_LL.TabStop = True
        Me.Sem2_LL.Text = "Sem2"
        '
        'SSC_Passing_LL
        '
        Me.SSC_Passing_LL.AutoSize = True
        Me.SSC_Passing_LL.Location = New System.Drawing.Point(535, 213)
        Me.SSC_Passing_LL.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.SSC_Passing_LL.Name = "SSC_Passing_LL"
        Me.SSC_Passing_LL.Size = New System.Drawing.Size(98, 18)
        Me.SSC_Passing_LL.TabIndex = 9
        Me.SSC_Passing_LL.TabStop = True
        Me.SSC_Passing_LL.Text = "SSC Passing"
        '
        'SSC_Leaving_LL
        '
        Me.SSC_Leaving_LL.AutoSize = True
        Me.SSC_Leaving_LL.Location = New System.Drawing.Point(533, 273)
        Me.SSC_Leaving_LL.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.SSC_Leaving_LL.Name = "SSC_Leaving_LL"
        Me.SSC_Leaving_LL.Size = New System.Drawing.Size(100, 18)
        Me.SSC_Leaving_LL.TabIndex = 10
        Me.SSC_Leaving_LL.TabStop = True
        Me.SSC_Leaving_LL.Text = "SSC Leaving"
        '
        'Name_Show
        '
        Me.Name_Show.AutoSize = True
        Me.Name_Show.Location = New System.Drawing.Point(219, 94)
        Me.Name_Show.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Name_Show.Name = "Name_Show"
        Me.Name_Show.Size = New System.Drawing.Size(33, 18)
        Me.Name_Show.TabIndex = 11
        Me.Name_Show.Text = "....."
        '
        'Address_Show
        '
        Me.Address_Show.AutoSize = True
        Me.Address_Show.Location = New System.Drawing.Point(219, 150)
        Me.Address_Show.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Address_Show.Name = "Address_Show"
        Me.Address_Show.Size = New System.Drawing.Size(43, 18)
        Me.Address_Show.TabIndex = 12
        Me.Address_Show.Text = "......."
        '
        'Mobile_No_Show
        '
        Me.Mobile_No_Show.AutoSize = True
        Me.Mobile_No_Show.Location = New System.Drawing.Point(219, 208)
        Me.Mobile_No_Show.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Mobile_No_Show.Name = "Mobile_No_Show"
        Me.Mobile_No_Show.Size = New System.Drawing.Size(38, 18)
        Me.Mobile_No_Show.TabIndex = 13
        Me.Mobile_No_Show.Text = "......"
        '
        'Email_Id_Show
        '
        Me.Email_Id_Show.AutoSize = True
        Me.Email_Id_Show.Location = New System.Drawing.Point(219, 268)
        Me.Email_Id_Show.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Email_Id_Show.Name = "Email_Id_Show"
        Me.Email_Id_Show.Size = New System.Drawing.Size(33, 18)
        Me.Email_Id_Show.TabIndex = 14
        Me.Email_Id_Show.Text = "....."
        '
        'pdfviewer
        '
        Me.pdfviewer.Enabled = True
        Me.pdfviewer.Location = New System.Drawing.Point(12, 332)
        Me.pdfviewer.Name = "pdfviewer"
        Me.pdfviewer.OcxState = CType(resources.GetObject("pdfviewer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.pdfviewer.Size = New System.Drawing.Size(298, 144)
        Me.pdfviewer.TabIndex = 0
        Me.pdfviewer.Visible = False
        '
        'Photo_pb
        '
        Me.Photo_pb.Location = New System.Drawing.Point(671, 26)
        Me.Photo_pb.Name = "Photo_pb"
        Me.Photo_pb.Size = New System.Drawing.Size(210, 234)
        Me.Photo_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Photo_pb.TabIndex = 15
        Me.Photo_pb.TabStop = False
        '
        'ViewDocAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(969, 446)
        Me.Controls.Add(Me.Photo_pb)
        Me.Controls.Add(Me.pdfviewer)
        Me.Controls.Add(Me.Email_Id_Show)
        Me.Controls.Add(Me.Mobile_No_Show)
        Me.Controls.Add(Me.Address_Show)
        Me.Controls.Add(Me.Name_Show)
        Me.Controls.Add(Me.SSC_Leaving_LL)
        Me.Controls.Add(Me.SSC_Passing_LL)
        Me.Controls.Add(Me.Sem2_LL)
        Me.Controls.Add(Me.Sem1_LL)
        Me.Controls.Add(Me.Photo_LL)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Student_Id_Combobox)
        Me.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "ViewDocAdmin"
        Me.Text = "Form5"
        CType(Me.pdfviewer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Photo_pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Student_Id_Combobox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Photo_LL As LinkLabel
    Friend WithEvents Sem1_LL As LinkLabel
    Friend WithEvents Sem2_LL As LinkLabel
    Friend WithEvents SSC_Passing_LL As LinkLabel
    Friend WithEvents SSC_Leaving_LL As LinkLabel
    Friend WithEvents Name_Show As Label
    Friend WithEvents Address_Show As Label
    Friend WithEvents Mobile_No_Show As Label
    Friend WithEvents Email_Id_Show As Label
    Friend WithEvents pdfviewer As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents Photo_pb As PictureBox
End Class
