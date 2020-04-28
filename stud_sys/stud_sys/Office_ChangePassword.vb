Imports System.Data.SqlClient
Imports System.IO
Imports System.Data
Imports System.Security.Cryptography


Public Class Office_ChangePassword
    Dim connection As New SqlConnection("Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=first_db;Integrated Security=True")

    Private Sub SetButton_Click(sender As Object, e As EventArgs) Handles SetButton.Click
        Try
            ' Dim insert_query As String = " INSERT INTO Student_Passwords(User_Id) VALUES('" & SetP_StudId_Textbox.Text & "')"

            'connection.Open()
            'Dim command As New SqlCommand(insert_query, connection)
            'Command.ExecuteNonQuery()
            'connection.Close()
        Catch ex As Exception
        Finally
            'connection.Close()
        End Try
        Dim setPass As String = SetP_Password_TextBox.Text
        Dim confirmPass As String = SetP_CPass_TextBox.Text
        Dim hashedPass As String = ""

        If (Not String.IsNullOrEmpty(setPass) And setPass.Equals(confirmPass)) Then
            Using md5hash As MD5 = MD5.Create()
                hashedPass =
               System.Convert.ToBase64String(md5hash.ComputeHash(System.Text.Encoding.ASCII.GetBytes(SetP_Password_TextBox.Text)))

            End Using
            Dim update_query As String = "update Student_Passwords set Password=@Password where User_Id='" & SetP_StudId_Textbox.Text & "'"

            connection.Open()

            Dim command As New SqlCommand(update_query, connection)
            ' MessageBox.Show(hashedPass)
            command.Parameters.Add(New SqlParameter("@Password", hashedPass))

            If command.ExecuteNonQuery = 1 Then
                MsgBox("Password set!! ", MsgBoxStyle.Information)
                SetP_StudId_Textbox.Text = ""
                SetP_Password_TextBox.Text = ""
                SetP_CPass_TextBox.Text = ""

            Else
                MsgBox("Password not  set!! ", MsgBoxStyle.Information)
            End If

            connection.Close()
        Else
            MsgBox("passwords dont match ....", MsgBoxStyle.Critical)

        End If

    End Sub

    Private Sub ChangeButton_Click(sender As Object, e As EventArgs) Handles ChangeButton.Click
        Dim select_query As String = "select Password from Student_Passwords where User_Id='" & ChgP_StudId_Textbox.Text & "'"
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
           System.Convert.ToBase64String(md5hash.ComputeHash(System.Text.Encoding.ASCII.GetBytes(ChgP_OldPass_Textbox.Text)))
        End Using
        Dim flag As Integer

        If var.Equals(Pass_hash) Then
            MessageBox.Show("old pass matched")
            flag = 1
        Else
            MessageBox.Show("old pass didnot matched")
            flag = 0
        End If


        Dim setPass As String = ChgP_NewPass_Textbox.Text
        Dim confirmPass As String = ChgP_ConfPass_Textbox.Text
        Dim hashedPass As String = ""
        If flag = 1 Then
            If (Not String.IsNullOrEmpty(setPass) And setPass.Equals(confirmPass)) Then
                Using md5hash As MD5 = MD5.Create()
                    hashedPass =
               System.Convert.ToBase64String(md5hash.ComputeHash(System.Text.Encoding.ASCII.GetBytes(ChgP_NewPass_Textbox.Text)))

                End Using
                Dim update_query As String = "update Student_Passwords set Password=@Password where User_Id='" & ChgP_StudId_Textbox.Text & "'"

                connection.Open()

                Dim cmd As New SqlCommand(update_query, connection)

                cmd.Parameters.Add(New SqlParameter("@Password", hashedPass))

                If cmd.ExecuteNonQuery = 1 Then
                    MsgBox("Password set!! ", MsgBoxStyle.Information)
                    ChgP_StudId_Textbox.Text = ""
                    ChgP_OldPass_Textbox.Text = ""
                    ChgP_NewPass_Textbox.Text = ""
                    ChgP_ConfPass_Textbox.Text = ""
                Else
                    MsgBox("Password not  set!! ", MsgBoxStyle.Information)
                End If


            Else
                MsgBox("passwords dont match ....", MsgBoxStyle.Critical)

            End If
        End If
        connection.Close()

    End Sub

    Private Sub Office_ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class