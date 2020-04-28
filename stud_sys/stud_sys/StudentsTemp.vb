Public Class StudentsTemp
    Private Sub StudentsTemp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub ViewDoc_Button_Click(sender As Object, e As EventArgs) Handles ViewDoc_Button.Click
        SliderBar.Height = ViewDoc_Button.Height
        SliderBar.Top = ViewDoc_Button.Top

        Main_Panel.Visible = False
        Main_Panel.Controls.Clear()
        Main_Panel.Visible = True

        Dim ViewDoc As New Office_ViewDoc()
        ViewDoc.TopLevel = False
        ViewDoc.Parent = Me.Main_Panel

        Me.Main_Panel.Controls.Add(ViewDoc)
        ViewDoc.Visible = True
    End Sub

    Private Sub AttReport_Button_Click(sender As Object, e As EventArgs) Handles AttReport_Button.Click
        SliderBar.Height = AttReport_Button.Height
        SliderBar.Top = AttReport_Button.Top

        Main_Panel.Visible = False
        Main_Panel.Controls.Clear()
        Main_Panel.Visible = True

        Dim AttReport As New AttendanceReport()
        AttReport.TopLevel = False
        AttReport.Parent = Me.Main_Panel

        Me.Main_Panel.Controls.Add(AttReport)
        AttReport.Visible = True
    End Sub

    Private Sub Logout_Button_Click(sender As Object, e As EventArgs) Handles Logout_Button.Click
        SliderBar.Height = Logout_Button.Height
        SliderBar.Top = Logout_Button.Top

        FrontPage.Show()
        Me.Hide()
        ' Main_Panel.Visible = False
        'Main_Panel.Controls.Clear()
        'Main_Panel.Visible = True
    End Sub
End Class