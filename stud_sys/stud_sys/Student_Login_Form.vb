Imports System.Data.SqlClient
Imports System.IO
Imports System.Data
Imports System.Security.Cryptography

Public Class Student_Login_Form
    Dim connection As New SqlConnection("Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=first_db;Integrated Security=True")

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.



    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
        FrontPage.Show()
    End Sub

    Private Sub Login_Button_Click(sender As Object, e As EventArgs) Handles Login_Button.Click
        Dim select_query As String = "select Password from Student_Passwords where User_Id='" & Student_Id_TextBox.Text & "'"
        Dim reader As SqlDataReader
        Dim var As String = ""
        Dim Pass_hash As String

        connection.Open()
        Dim command As New SqlCommand(select_query, connection)
        reader = command.ExecuteReader()
        While reader.Read()
            var = Convert.ToString(reader("Password"))
            'MessageBox.Show(var)

        End While
        connection.Close()
        Using md5hash As MD5 = MD5.Create()
            Pass_hash =
           System.Convert.ToBase64String(md5hash.ComputeHash(System.Text.Encoding.ASCII.GetBytes(Password_TextBox.Text)))
        End Using

        If (Not String.IsNullOrEmpty(Student_Id_TextBox.Text) And Not String.IsNullOrEmpty(Password_TextBox.Text)) Then

            If var.Equals(Pass_hash) Then
                MessageBox.Show("Login successful!!")
                StudentsTemp.Show()
                Me.Hide()
            Else
                MsgBox("check ur Id or password once again!!", MsgBoxStyle.Critical)

            End If
        Else
            MsgBox("one of the fields are empty !!", MsgBoxStyle.Critical)
        End If
        Student_Id_TextBox.Text = ""
        Password_TextBox.Text = ""

    End Sub
End Class
