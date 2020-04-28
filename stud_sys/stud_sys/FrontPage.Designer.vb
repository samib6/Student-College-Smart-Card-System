<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrontPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrontPage))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Admin_Pic = New System.Windows.Forms.PictureBox()
        Me.Student_Pic = New System.Windows.Forms.PictureBox()
        Me.Office_Pic = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.Admin_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Office_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(69, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(632, 46)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Student College Smart Card System"
        '
        'Admin_Pic
        '
        Me.Admin_Pic.BackColor = System.Drawing.Color.Gainsboro
        Me.Admin_Pic.Image = CType(resources.GetObject("Admin_Pic.Image"), System.Drawing.Image)
        Me.Admin_Pic.Location = New System.Drawing.Point(77, 276)
        Me.Admin_Pic.Name = "Admin_Pic"
        Me.Admin_Pic.Size = New System.Drawing.Size(171, 171)
        Me.Admin_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Admin_Pic.TabIndex = 5
        Me.Admin_Pic.TabStop = False
        '
        'Student_Pic
        '
        Me.Student_Pic.BackColor = System.Drawing.Color.Gainsboro
        Me.Student_Pic.Image = CType(resources.GetObject("Student_Pic.Image"), System.Drawing.Image)
        Me.Student_Pic.Location = New System.Drawing.Point(307, 276)
        Me.Student_Pic.Name = "Student_Pic"
        Me.Student_Pic.Size = New System.Drawing.Size(171, 171)
        Me.Student_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Student_Pic.TabIndex = 6
        Me.Student_Pic.TabStop = False
        '
        'Office_Pic
        '
        Me.Office_Pic.BackColor = System.Drawing.Color.Gray
        Me.Office_Pic.Image = CType(resources.GetObject("Office_Pic.Image"), System.Drawing.Image)
        Me.Office_Pic.Location = New System.Drawing.Point(528, 276)
        Me.Office_Pic.Name = "Office_Pic"
        Me.Office_Pic.Size = New System.Drawing.Size(171, 171)
        Me.Office_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Office_Pic.TabIndex = 7
        Me.Office_Pic.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(90, 460)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 28)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Admin Login"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(312, 460)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 28)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Student Login"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(548, 460)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 28)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Office Login"
        '
        'FrontPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(811, 550)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Office_Pic)
        Me.Controls.Add(Me.Student_Pic)
        Me.Controls.Add(Me.Admin_Pic)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrontPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Admin_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Office_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Admin_Pic As PictureBox
    Friend WithEvents Student_Pic As PictureBox
    Friend WithEvents Office_Pic As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
