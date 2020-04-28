<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PdfViewForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PdfViewForm))
        Me.pdfviewer = New AxAcroPDFLib.AxAcroPDF()
        CType(Me.pdfviewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pdfviewer
        '
        Me.pdfviewer.Enabled = True
        Me.pdfviewer.Location = New System.Drawing.Point(12, 12)
        Me.pdfviewer.Name = "pdfviewer"
        Me.pdfviewer.OcxState = CType(resources.GetObject("pdfviewer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.pdfviewer.Size = New System.Drawing.Size(786, 506)
        Me.pdfviewer.TabIndex = 0
        '
        'PdfViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 530)
        Me.Controls.Add(Me.pdfviewer)
        Me.Name = "PdfViewForm"
        CType(Me.pdfviewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pdfviewer As AxAcroPDFLib.AxAcroPDF
End Class
