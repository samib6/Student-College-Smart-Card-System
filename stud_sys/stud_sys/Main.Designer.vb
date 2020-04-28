Imports System.Windows.Forms
Imports System.Drawing
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Main_Label = New System.Windows.Forms.Label()
        Me.Admin_Label = New System.Windows.Forms.Label()
        Me.Student_Label = New System.Windows.Forms.Label()
        Me.Horizontal_pane = New System.Windows.Forms.Panel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Student_Pic = New System.Windows.Forms.PictureBox()
        Me.Admin_Pic = New System.Windows.Forms.PictureBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Horizontal_pane.SuspendLayout()
        CType(Me.Student_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Admin_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackgroundImage = CType(resources.GetObject("SplitContainer1.Panel1.BackgroundImage"), System.Drawing.Image)
        Me.SplitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel1.Controls.Add(Me.Main_Label)
        Me.SplitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.ControlLight
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SplitContainer1.Panel2.Controls.Add(Me.Admin_Label)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Student_Label)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Horizontal_pane)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Student_Pic)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Admin_Pic)
        Me.SplitContainer1.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SplitContainer1.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Size = New System.Drawing.Size(884, 662)
        Me.SplitContainer1.SplitterDistance = 340
        Me.SplitContainer1.TabIndex = 0
        '
        'Main_Label
        '
        Me.Main_Label.AutoSize = True
        Me.Main_Label.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Main_Label.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Main_Label.Font = New System.Drawing.Font("Baskerville Old Face", 26.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Main_Label.Location = New System.Drawing.Point(0, 300)
        Me.Main_Label.Name = "Main_Label"
        Me.Main_Label.Size = New System.Drawing.Size(423, 40)
        Me.Main_Label.TabIndex = 2
        Me.Main_Label.Text = "Student Smart Card System"
        Me.Main_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Admin_Label
        '
        Me.Admin_Label.AutoSize = True
        Me.Admin_Label.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Admin_Label.Location = New System.Drawing.Point(102, 265)
        Me.Admin_Label.Name = "Admin_Label"
        Me.Admin_Label.Size = New System.Drawing.Size(112, 19)
        Me.Admin_Label.TabIndex = 3
        Me.Admin_Label.Text = "Admin Login "
        '
        'Student_Label
        '
        Me.Student_Label.AutoSize = True
        Me.Student_Label.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_Label.Location = New System.Drawing.Point(626, 265)
        Me.Student_Label.Name = "Student_Label"
        Me.Student_Label.Size = New System.Drawing.Size(106, 18)
        Me.Student_Label.TabIndex = 0
        Me.Student_Label.Text = "Student Login"
        '
        'Horizontal_pane
        '
        Me.Horizontal_pane.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Horizontal_pane.Controls.Add(Me.LinkLabel3)
        Me.Horizontal_pane.Controls.Add(Me.LinkLabel2)
        Me.Horizontal_pane.Controls.Add(Me.LinkLabel1)
        Me.Horizontal_pane.Dock = System.Windows.Forms.DockStyle.Top
        Me.Horizontal_pane.Location = New System.Drawing.Point(0, 0)
        Me.Horizontal_pane.Name = "Horizontal_pane"
        Me.Horizontal_pane.Size = New System.Drawing.Size(884, 67)
        Me.Horizontal_pane.TabIndex = 2
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabel3.Location = New System.Drawing.Point(614, 27)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(99, 20)
        Me.LinkLabel3.TabIndex = 2
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Contact Us"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabel2.Location = New System.Drawing.Point(322, 27)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(89, 20)
        Me.LinkLabel2.TabIndex = 1
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "About Us "
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(55, 27)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(61, 20)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "HOME"
        '
        'Student_Pic
        '
        Me.Student_Pic.BackgroundImage = CType(resources.GetObject("Student_Pic.BackgroundImage"), System.Drawing.Image)
        Me.Student_Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Student_Pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Student_Pic.Location = New System.Drawing.Point(602, 109)
        Me.Student_Pic.Name = "Student_Pic"
        Me.Student_Pic.Size = New System.Drawing.Size(153, 152)
        Me.Student_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Student_Pic.TabIndex = 1
        Me.Student_Pic.TabStop = False
        '
        'Admin_Pic
        '
        Me.Admin_Pic.BackColor = System.Drawing.Color.White
        Me.Admin_Pic.BackgroundImage = CType(resources.GetObject("Admin_Pic.BackgroundImage"), System.Drawing.Image)
        Me.Admin_Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Admin_Pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Admin_Pic.Location = New System.Drawing.Point(94, 109)
        Me.Admin_Pic.Name = "Admin_Pic"
        Me.Admin_Pic.Size = New System.Drawing.Size(140, 152)
        Me.Admin_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Admin_Pic.TabIndex = 0
        Me.Admin_Pic.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 662)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Location = New System.Drawing.Point(500, 500)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student College Smart Card System"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Horizontal_pane.ResumeLayout(False)
        Me.Horizontal_pane.PerformLayout()
        CType(Me.Student_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Admin_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    'Public f As New Form()


    'Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
    '   Admin_LoginForm1.TopLevel = False
    '  Admin_LoginForm1.FormBorderStyle = Me.FormBorderStyle.FixedSingle
    ' Admin_LoginForm1.Size = New System.Drawing.Size(400, 200)
    'Admin_LoginForm1.Location = New System.Drawing.Point(50, 0)
    '   Admin_LoginForm1.WindowState = FormWindowState.Normal
    '  Admin_LoginForm1.Visible = False
    ' SplitContainer1.Panel2.Controls.Add(Admin_LoginForm1)



    'End Sub
    Private Sub Admin_Pic_Click(sender As Object, e As EventArgs) Handles Admin_Pic.Click

        Admin_LoginForm1.Show()
        Me.Hide()

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Student_Pic As PictureBox
    Friend WithEvents Admin_Pic As PictureBox
    Friend WithEvents Main_Label As Label
    Friend WithEvents Admin_Label As Label
    Friend WithEvents Student_Label As Label
    Friend WithEvents Horizontal_pane As Panel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel


End Class

