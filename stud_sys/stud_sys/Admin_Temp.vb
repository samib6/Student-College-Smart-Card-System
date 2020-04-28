Public Class Admin_Temp
    Private Sub AddStudentsButton_Click(sender As Object, e As EventArgs) Handles AddStudentsButton.Click
        Slider_bar.Height = AddStudentsButton.Height
        Slider_bar.Top = AddStudentsButton.Top

        Main_Panel.Visible = False
        Main_Panel.Controls.Clear()
        Main_Panel.Visible = True

        Dim AddStud As New Add_Student_Form()
        AddStud.TopLevel = False
        AddStud.Parent = Me.Main_Panel

        Me.Main_Panel.Controls.Add(AddStud)
        AddStud.Show()



    End Sub

    Private Sub AddDocumentsButton_Click(sender As Object, e As EventArgs) Handles AddDocumentsButton.Click


        Slider_bar.Height = AddDocumentsButton.Height
        Slider_bar.Top = AddDocumentsButton.Top

        Main_Panel.Visible = False
        Main_Panel.Controls.Clear()
        Main_Panel.Visible = True

        Dim AddDoc As New Add_Documents()
        AddDoc.TopLevel = False
        AddDoc.Parent = Me.Main_Panel

        Me.Main_Panel.Controls.Add(AddDoc)
        AddDoc.Visible = True



    End Sub

    Private Sub MarkAttButton_Click(sender As Object, e As EventArgs) Handles MarkAttButton.Click
        Slider_bar.Height = MarkAttButton.Height
        Slider_bar.Top = MarkAttButton.Top

        Main_Panel.Visible = False
        Main_Panel.Controls.Clear()
        Main_Panel.Visible = True

        Dim MarkAtt As New MarkAttendance()
        MarkAtt.TopLevel = False
        MarkAtt.Parent = Me.Main_Panel

        Me.Main_Panel.Controls.Add(MarkAtt)
        MarkAtt.Visible = True

    End Sub

    Private Sub ViewDocumentsButton_Click(sender As Object, e As EventArgs) Handles ViewDocumentsButton.Click
        Slider_bar.Height = ViewDocumentsButton.Height
        Slider_bar.Top = ViewDocumentsButton.Top

        Main_Panel.Visible = False
        Main_Panel.Controls.Clear()
        Main_Panel.Visible = True

        Dim ViewDoc As New Office_ViewDoc()
        ViewDoc.TopLevel = False
        ViewDoc.Parent = Me.Main_Panel

        Me.Main_Panel.Controls.Add(ViewDoc)
        ViewDoc.Visible = True
    End Sub

    Private Sub AttReportButton_Click(sender As Object, e As EventArgs) Handles AttReportButton.Click
        Slider_bar.Height = AttReportButton.Height
        Slider_bar.Top = AttReportButton.Top

        Main_Panel.Visible = False
        Main_Panel.Controls.Clear()
        Main_Panel.Visible = True

        Dim AttReport As New AttendanceReport()
        AttReport.TopLevel = False
        AttReport.Parent = Me.Main_Panel

        Me.Main_Panel.Controls.Add(AttReport)
        AttReport.Visible = True
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Slider_bar.Height = LogoutButton.Height
        Slider_bar.Top = LogoutButton.Top

        Main_Panel.Visible = False
        Main_Panel.Controls.Clear()
        Main_Panel.Visible = True

        Me.Hide()
        FrontPage.Show()
    End Sub

    Private Sub Admin_Temp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class