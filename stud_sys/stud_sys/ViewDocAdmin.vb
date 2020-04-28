Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class ViewDocAdmin
    Dim connection As New SqlConnection("Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=first_db;Integrated Security=True")

    Private Sub ViewDocAdmin_Load(sender As Object, e As EventArgs) Handles Me.Load
        'combobox link with db
        Photo_pb.Visible = False
        Dim combo_cmd As SqlCommand

        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim sql As String
        sql = "select User_Id from Student"
        Try
            connection.Open()
            combo_cmd = New SqlCommand(sql, connection)
            adapter.SelectCommand = combo_cmd
            adapter.Fill(ds)
            adapter.Dispose()
            combo_cmd.Dispose()
            connection.Close()


            Me.Student_Id_Combobox.MaxDropDownItems = 3
            Student_Id_Combobox.DataSource = ds.Tables(0)
            Student_Id_Combobox.ValueMember = "User_Id"
            Student_Id_Combobox.DisplayMember = "User_Id"

        Catch ex As Exception
        Finally
            connection.Close()

        End Try

    End Sub

    Private Sub Student_Id_Combobox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Student_Id_Combobox.SelectionChangeCommitted
        Try
            connection.Open()
            Dim select_query As String
            Dim reader As SqlDataReader
            Dim command As SqlCommand
            select_query = "Select * from Student where User_Id='" & Student_Id_Combobox.Text & "' "
            ' MessageBox.Show(Student_Id_Combobox.Text)
            command = New SqlCommand(select_query, connection)
            reader = command.ExecuteReader()

            While reader.Read()

                Me.Name_Show.Text = Convert.ToString(reader("Name"))
                Me.Address_Show.Text = Convert.ToString(reader("Address"))
                Me.Mobile_No_Show.Text = Convert.ToString(reader("Mobile_No"))
                Me.Email_Id_Show.Text = Convert.ToString(reader("Email_Id"))



            End While
            connection.Close()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub Photo_LL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Photo_LL.LinkClicked

        Dim command As New SqlCommand("SELECT Photo FROM Doc_Add WHERE User_Id = '" & Student_Id_Combobox.Text & "'", connection)


        connection.Open()

        Dim pictureData As Byte() = DirectCast(command.ExecuteScalar(), Byte())

        connection.Close()

        Dim picture As Image = Nothing

        'Create a stream in memory containing the bytes that comprise the image.
        Using stream As New IO.MemoryStream(pictureData)
            'Read the stream and create an Image object from the data.
            picture = Image.FromStream(stream)
        End Using
        Photo_pb.Visible = True
        Photo_pb.Image = picture


    End Sub

    Private Sub Sem1_LL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Sem1_LL.LinkClicked

        Dim sFilepath As String
        Dim buffer As Byte()
        connection.Open()
        Dim command As New SqlCommand("SELECT Sem1 FROM Doc_Add WHERE User_Id = '" & Student_Id_Combobox.Text & "'", connection)
        buffer = command.ExecuteScalar()
        connection.Close()

        sFilepath = System.IO.Path.GetTempFileName()
        System.IO.File.Move(sFilepath, System.IO.Path.ChangeExtension(sFilepath, ".pdf"))
        sFilepath = System.IO.Path.ChangeExtension(sFilepath, ".pdf")

        System.IO.File.WriteAllBytes(sFilepath, buffer)
        PdfViewForm.Show()
        PdfViewForm.pdfviewer.src = sFilepath

    End Sub

    Private Sub Sem2_LL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Sem2_LL.LinkClicked
        Dim sFilepath As String
        Dim buffer As Byte()
        connection.Open()
        Dim command As New SqlCommand("SELECT Sem2 FROM Doc_Add WHERE User_Id = '" & Student_Id_Combobox.Text & "'", connection)
        buffer = command.ExecuteScalar()
        connection.Close()

        sFilepath = System.IO.Path.GetTempFileName()
        System.IO.File.Move(sFilepath, System.IO.Path.ChangeExtension(sFilepath, ".pdf"))
        sFilepath = System.IO.Path.ChangeExtension(sFilepath, ".pdf")

        System.IO.File.WriteAllBytes(sFilepath, buffer)
        PdfViewForm.Show()
        PdfViewForm.pdfviewer.src = sFilepath

    End Sub

    Private Sub SSC_Leaving_LL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SSC_Leaving_LL.LinkClicked
        Dim sFilepath As String
        Dim buffer As Byte()
        connection.Open()
        Dim command As New SqlCommand("SELECT SSC_Leaving FROM Doc_Add WHERE User_Id = '" & Student_Id_Combobox.Text & "'", connection)
        buffer = command.ExecuteScalar()
        connection.Close()

        sFilepath = System.IO.Path.GetTempFileName()
        System.IO.File.Move(sFilepath, System.IO.Path.ChangeExtension(sFilepath, ".pdf"))
        sFilepath = System.IO.Path.ChangeExtension(sFilepath, ".pdf")

        System.IO.File.WriteAllBytes(sFilepath, buffer)
        PdfViewForm.Show()
        PdfViewForm.pdfviewer.src = sFilepath

    End Sub

    Private Sub SSC_Passing_LL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SSC_Passing_LL.LinkClicked
        Dim sFilepath As String
        Dim buffer As Byte()
        connection.Open()
        Dim command As New SqlCommand("SELECT SSC_Passing FROM Doc_Add WHERE User_Id = '" & Student_Id_Combobox.Text & "'", connection)
        buffer = command.ExecuteScalar()
        connection.Close()

        sFilepath = System.IO.Path.GetTempFileName()
        System.IO.File.Move(sFilepath, System.IO.Path.ChangeExtension(sFilepath, ".pdf"))
        sFilepath = System.IO.Path.ChangeExtension(sFilepath, ".pdf")

        System.IO.File.WriteAllBytes(sFilepath, buffer)
        PdfViewForm.Show()
        PdfViewForm.pdfviewer.src = sFilepath

    End Sub
End Class