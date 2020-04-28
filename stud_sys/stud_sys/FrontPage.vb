Public Class FrontPage
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Admin_Pic_Click(sender As Object, e As EventArgs) Handles Admin_Pic.Click
        Admin_LoginForm1.Show()
        Me.Hide()

    End Sub

    Private Sub Student_Pic_Click(sender As Object, e As EventArgs) Handles Student_Pic.Click
        Student_Login_Form.Show()
        Me.Hide()
    End Sub

    Private Sub Office_Pic_Click(sender As Object, e As EventArgs) Handles Office_Pic.Click
        OfficeLoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub FrontPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class