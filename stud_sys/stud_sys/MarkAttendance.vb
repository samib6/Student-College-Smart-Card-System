Imports System.Data.SqlClient
Imports System.IO
Imports System.Data
Public Class MarkAttendance
    Dim connection As New SqlConnection("Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=first_db;Integrated Security=True")

    Private Sub MarkAttendance_Button_Click(sender As Object, e As EventArgs) Handles MarkAttendance_Button.Click
        Dim insert_query As String = "Insert into MarkA(User_Id,Date,Time,Status) values('" & StudId_TextBox.Text & "','" & DateTimePicker.Text & "','" & Time_Label.Text & "','P') "
        ExecuteQuery(insert_query)

    End Sub
    Public Sub ExecuteQuery(query As String)
        Dim command As New SqlCommand(query, connection)
        Dim flag As Integer
        Try
            connection.Open()
            flag = command.ExecuteNonQuery()
            If flag > 0 Then
                MessageBox.Show("attendance marked!!")
            Else
                MessageBox.Show("attendance was not marked!!")
            End If
            connection.Close()
        Catch ex As Exception
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub MarkAttendance_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Time_Label.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub
End Class