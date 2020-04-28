Public Class Admin_template
    'Dim AddStud As New Add_Students_UC
    Private Sub Menu_Panel_Paint(sender As Object, e As PaintEventArgs) Handles Menu_Panel.Paint
        Menu_Panel.BackColor = Color.FromArgb(29, 31, 35)

    End Sub

    Private Sub Add_Students_Button_Click(sender As Object, e As EventArgs) Handles Add_Students_Button.Click
        Slider_Bar.Height = Add_Students_Button.Height
        Slider_Bar.Top = Add_Students_Button.Top

        MessageBox.Show("clicked")

        Dim AddStud As New Add_Student_Form()
        AddStud.TopLevel = False
        ' AddStud.Parent = Me.Centre_Panel

        'Me.Centre_Panel.Controls.Add(AddStud)
        AddStud.Show()




    End Sub





    Private Sub Admin_template_Load(sender As Object, e As EventArgs) Handles Me.Load

        InitializeComponent()
        Slider_Bar2.Visible = False
        Slider_Bar.Show()
        Slider_Bar.Height = Add_Students_Button.Height
        Slider_Bar.Top = Add_Students_Button.Top

    End Sub

    Private Sub Mark_Att_Button_Click(sender As Object, e As EventArgs) Handles Mark_Att_Button.Click
        Slider_Bar2.Visible = False
        Slider_Bar.Show()
        Slider_Bar.Height = Mark_Att_Button.Height
        Slider_Bar.Top = Mark_Att_Button.Top
    End Sub

    Private Sub Att_Report_Button_Click(sender As Object, e As EventArgs) Handles Att_Report_Button.Click
        Slider_Bar2.Visible = False
        Slider_Bar.Show()
        Slider_Bar.Height = Att_Report_Button.Height
        Slider_Bar.Top = Att_Report_Button.Top
    End Sub

    Private Sub Logout_Button_Click(sender As Object, e As EventArgs) Handles Logout_Button.Click
        Slider_Bar2.Visible = False
        Slider_Bar.Show()
        Slider_Bar.Height = Logout_Button.Height
        Slider_Bar.Top = Logout_Button.Top
    End Sub

    Private Sub View_Docs_Button_Click(sender As Object, e As EventArgs) Handles View_Docs_Button.Click
        Slider_Bar2.Visible = False
        Slider_Bar.Show()
        Slider_Bar.Height = View_Docs_Button.Height
        Slider_Bar.Top = View_Docs_Button.Top
    End Sub

    Private Sub Add_Docs_Button_Click(sender As Object, e As EventArgs) Handles Add_Docs_Button.Click
        Slider_Bar2.Visible = True
        Slider_Bar.Hide()
        Slider_Bar2.Height = View_Docs_Button.Height
        Slider_Bar2.Top = Add_Docs_Button.Top
    End Sub
End Class