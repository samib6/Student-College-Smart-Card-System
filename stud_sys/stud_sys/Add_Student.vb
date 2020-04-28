Imports System.Data.SqlClient

Public Class Add_Student_Form
    Dim connection As New SqlConnection("Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=first_db;Integrated Security=True")
    Dim flag As Integer


    Private Sub Add_Button_Click(sender As Object, e As EventArgs) Handles Add_Button.Click

        mob_validation()
        If flag = 0 Then
            Dim insertQuery As String = " 
            INSERT INTO Student(User_Id, Name, Address, Mobile_No, Email_Id)
            VALUES('" & UserId_TextBox.Text & "','" & Name_TextBox.Text & "','" & Address_TextBox.Text & "','" & MobileNo_TextBox.Text & "','" & Email_TextBox.Text & "')"

            Dim updateQuery As String = "Update Student
            SET User_Id = '" & UserId_TextBox.Text & "',Name ='" & Name_TextBox.Text & "' ,Address ='" & Address_TextBox.Text & "' ,Mobile_No ='" & MobileNo_TextBox.Text & "',Email_Id = '" & Email_TextBox.Text & "'
            WHERE User_Id = '" & UserId_TextBox.Text & "'"

            Dim id_insert As String = "Insert into Doc_Add(User_Id) values('" & UserId_TextBox.Text & "') "
            Dim Stud_Pass_insert As String = "Insert into Student_Passwords(User_Id) values('" & UserId_TextBox.Text & "') "
            ExecuteQuery(insertQuery)
            ExecuteQuery(Stud_Pass_insert)
            ExecuteQuery(id_insert)
            'MessageBox.Show("")

        Else
            MessageBox.Show("cannot insert!")
            UserId_TextBox.Text = ""
            Name_TextBox.Text = ""
            Address_TextBox.Text = ""
            MobileNo_TextBox.Text = ""
            Email_TextBox.Text = ""
        End If



    End Sub

    Public Sub ExecuteQuery(query As String)
        Dim command As New SqlCommand(query, connection)
        Dim num As Integer
        Try
            connection.Open()
            num = command.ExecuteNonQuery()
            If num > 0 Then
                MessageBox.Show("operation  done successfully")
                UserId_TextBox.Text = ""
                Name_TextBox.Text = ""
                Address_TextBox.Text = ""
                MobileNo_TextBox.Text = ""
                Email_TextBox.Text = ""
            Else
                MessageBox.Show("operation  not done successfully")
                UserId_TextBox.Text = ""
                Name_TextBox.Text = ""
                Address_TextBox.Text = ""
                MobileNo_TextBox.Text = ""
                Email_TextBox.Text = ""
            End If
            connection.Close()
        Catch ex As Exception
        Finally
            connection.Close()
        End Try


    End Sub

    Private Sub Update_Button_Click(sender As Object, e As EventArgs) Handles Update_Button.Click
        Dim updateQuery As String = "Update Student
        SET User_Id = '" & UserId_TextBox.Text & "',Name ='" & Name_TextBox.Text & "' ,Address ='" & Address_TextBox.Text & "' ,Mobile_No ='" & MobileNo_TextBox.Text & "',Email_Id = '" & Email_TextBox.Text & "'
        WHERE User_Id = '" & UserId_TextBox.Text & "'"

        ExecuteQuery(updateQuery)


    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        Dim deleteQuery As String = "delete from Student where User_Id='" & UserId_TextBox.Text & "'"
        Dim doc_add_del_query As String = "delete from Doc_Add where User_Id='" & UserId_TextBox.Text & "'"
        Dim Pass_del_query As String = "delete from Student_Passwords where User_Id='" & UserId_TextBox.Text & "'"

        ExecuteQuery(deleteQuery)
        ExecuteQuery(doc_add_del_query)
        ExecuteQuery(Pass_del_query)


    End Sub

    Public Sub mob_validation()
        Dim cmd As New SqlCommand()

        Try
            connection.Open()
            cmd.Connection = connection
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select User_Id from Student where User_Id='" & UserId_TextBox.Text & "'"
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            reader.Read()
            If reader.HasRows Then
                MessageBox.Show("user id already exists cannot insert !!")
                cmd.Dispose()
                connection.Close()
            End If

        Catch ex As Exception
        Finally
            connection.Close()
        End Try


        Dim output As String = New String((From c As Char In Clipboard.GetText.ToString Select c Where Char.IsLetter(c)).ToArray())
        If output = "" And Len(MobileNo_TextBox.Text) = 10 Then
            MessageBox.Show("Mobile Number is correct")
            flag = 0
        Else
            MessageBox.Show("Mobile Number is incorrect")
            flag = 1
            Clipboard.Clear()
        End If




    End Sub


End Class