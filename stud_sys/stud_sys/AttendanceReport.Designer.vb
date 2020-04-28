<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendanceReport
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Show_Button = New System.Windows.Forms.Button()
        Me.StartDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.EndDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.StartDate_Label = New System.Windows.Forms.Label()
        Me.EndDate_Label = New System.Windows.Forms.Label()
        Me.FirstdbDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.First_dbDataSet1 = New stud_sys.first_dbDataSet1()
        Me.FirstdbDataSet1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FirstdbDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.First_dbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FirstdbDataSet1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(654, 362)
        Me.DataGridView1.TabIndex = 0
        '
        'Show_Button
        '
        Me.Show_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Show_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Show_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show_Button.ForeColor = System.Drawing.Color.Black
        Me.Show_Button.Location = New System.Drawing.Point(720, 247)
        Me.Show_Button.Name = "Show_Button"
        Me.Show_Button.Size = New System.Drawing.Size(109, 26)
        Me.Show_Button.TabIndex = 1
        Me.Show_Button.Text = "SHOW"
        Me.Show_Button.UseVisualStyleBackColor = False
        '
        'StartDatePicker
        '
        Me.StartDatePicker.Location = New System.Drawing.Point(751, 94)
        Me.StartDatePicker.Name = "StartDatePicker"
        Me.StartDatePicker.Size = New System.Drawing.Size(126, 20)
        Me.StartDatePicker.TabIndex = 2
        '
        'EndDatePicker
        '
        Me.EndDatePicker.Location = New System.Drawing.Point(751, 175)
        Me.EndDatePicker.Name = "EndDatePicker"
        Me.EndDatePicker.Size = New System.Drawing.Size(126, 20)
        Me.EndDatePicker.TabIndex = 3
        '
        'StartDate_Label
        '
        Me.StartDate_Label.AutoSize = True
        Me.StartDate_Label.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartDate_Label.Location = New System.Drawing.Point(672, 97)
        Me.StartDate_Label.Name = "StartDate_Label"
        Me.StartDate_Label.Size = New System.Drawing.Size(63, 15)
        Me.StartDate_Label.TabIndex = 4
        Me.StartDate_Label.Text = "Start Date"
        '
        'EndDate_Label
        '
        Me.EndDate_Label.AutoSize = True
        Me.EndDate_Label.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndDate_Label.Location = New System.Drawing.Point(675, 175)
        Me.EndDate_Label.Name = "EndDate_Label"
        Me.EndDate_Label.Size = New System.Drawing.Size(56, 15)
        Me.EndDate_Label.TabIndex = 5
        Me.EndDate_Label.Text = "End Date"
        '
        'FirstdbDataSet1BindingSource
        '
        Me.FirstdbDataSet1BindingSource.DataSource = Me.First_dbDataSet1
        Me.FirstdbDataSet1BindingSource.Position = 0
        '
        'First_dbDataSet1
        '
        Me.First_dbDataSet1.DataSetName = "first_dbDataSet1"
        Me.First_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FirstdbDataSet1BindingSource1
        '
        Me.FirstdbDataSet1BindingSource1.DataSource = Me.First_dbDataSet1
        Me.FirstdbDataSet1BindingSource1.Position = 0
        '
        'AttendanceReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(906, 447)
        Me.Controls.Add(Me.Show_Button)
        Me.Controls.Add(Me.EndDatePicker)
        Me.Controls.Add(Me.EndDate_Label)
        Me.Controls.Add(Me.StartDate_Label)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.StartDatePicker)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AttendanceReport"
        Me.Text = "AttendanceReport"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FirstdbDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.First_dbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FirstdbDataSet1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FirstdbDataSet1BindingSource As BindingSource
    Friend WithEvents First_dbDataSet1 As first_dbDataSet1
    Friend WithEvents Show_Button As Button
    Friend WithEvents StartDatePicker As DateTimePicker
    Friend WithEvents EndDatePicker As DateTimePicker
    Friend WithEvents StartDate_Label As Label
    Friend WithEvents EndDate_Label As Label
    Friend WithEvents FirstdbDataSet1BindingSource1 As BindingSource
End Class
