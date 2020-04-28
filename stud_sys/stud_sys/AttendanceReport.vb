Imports System.Data.SqlClient
Imports System.IO
Imports System.Data
Imports System.Configuration

Public Class AttendanceReport

    Dim connection As New SqlConnection("Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=first_db;Integrated Security=True")



    Dim StartDate As String
    Dim EndDate As String
    Dim sd As DateTime
    Dim ed As DateTime

    Private Sub AttendanceReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' MsgBox(StartDate)


        '   Using cmd As SqlCommand = New SqlCommand("first_db", connection)

        'cmd.CommandType = CommandType.StoredProcedure

        '      cmd.Parameters.Add("@StartDate", SqlDbType.Date).Value = StartDate
        '     cmd.Parameters.Add("@EndDate", SqlDbType.Date).Value = EndDate


        'End Using
    End Sub

    Private Sub StartDatePicker_ValueChanged(sender As Object, e As EventArgs) Handles StartDatePicker.ValueChanged
        ' StartDate = Format(StartDatePicker.Value, "yyyy/mm/dd")
        sd = DateTime.Parse(StartDatePicker.Text)


    End Sub

    Private Sub EndDatePicker_ValueChanged(sender As Object, e As EventArgs) Handles EndDatePicker.ValueChanged
        'EndDate = Format(EndDatePicker.Value, "yyyy/mm/dd")
        ed = DateTime.Parse(EndDatePicker.Text)

    End Sub

    Private Sub Show_Button_Click(sender As Object, e As EventArgs) Handles Show_Button.Click
        Dim cmd As New SqlCommand
        Dim ds As New DataSet()
        Try
            connection.Open()

            Dim da As SqlDataAdapter = New SqlDataAdapter("GET_ATTENDANCE", connection)
            da.SelectCommand.CommandType = CommandType.StoredProcedure

            da.SelectCommand.Parameters.Add("@STARTDATE", SqlDbType.DateTime).Value = sd
            da.SelectCommand.Parameters.Add("@ENDDATE", SqlDbType.DateTime).Value = ed

            da.Fill(ds, "GET_ATTENDANCE")
            DataGridView1.Visible = True

            DataGridView1.DataSource = ds.Tables(0)
            da.Dispose()
            connection.Close()
        Catch ex As Exception

        End Try



    End Sub

End Class