Public Class OfficeTemp
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

    Private Sub SetChgPass_Button_Click(sender As Object, e As EventArgs) Handles SetChgPass_Button.Click
        SliderBar.Height = SetChgPass_Button.Height
        SliderBar.Top = SetChgPass_Button.Top

        Main_Panel.Visible = False
        Main_Panel.Controls.Clear()
        Main_Panel.Visible = True

        Dim SetPass As New Office_ChangePassword()
        SetPass.TopLevel = False
        SetPass.Parent = Me.Main_Panel

        Me.Main_Panel.Controls.Add(SetPass)
        SetPass.Visible = True
    End Sub

    Private Sub Logout_Button_Click(sender As Object, e As EventArgs) Handles Logout_Button.Click
        SliderBar.Height = Logout_Button.Height
        SliderBar.Top = Logout_Button.Top

        Main_Panel.Visible = False
        Main_Panel.Controls.Clear()
        Main_Panel.Visible = True

        Me.Hide()
        FrontPage.Show()
    End Sub
End Class