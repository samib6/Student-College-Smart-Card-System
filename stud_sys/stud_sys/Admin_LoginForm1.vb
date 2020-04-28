Public Class Admin_LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub Admin_LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Admin Login"
        Me.BackColor = Color.AliceBlue

        Admin_Logo.SizeMode = PictureBoxSizeMode.StretchImage
        Admin_Logo.BackColor = Color.White
        Login.Text = "Login"
        Login.BackColor = Color.Wheat


        'Dim Admin_password As String = "ADMIN"
        'Dim Admin_username As String = "admin"
    End Sub

    Private Sub Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Login.Click
        If Not String.IsNullOrEmpty(UsernameTextBox.Text) AndAlso Not String.IsNullOrEmpty(PasswordTextBox.Text) Then

            If UsernameTextBox.Text = "admin" AndAlso PasswordTextBox.Text = "ADMIN" Then
                MessageBox.Show("Login Successful!!")
                Admin_Temp.Show()
                Me.Hide()
            Else
                MessageBox.Show("Incorrect Username/password")
            End If

        Else
            MsgBox("One of the fields are empty.Kindly type in something!!", MsgBoxStyle.Critical)

        End If

        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        FrontPage.Show()

    End Sub


    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub


End Class
