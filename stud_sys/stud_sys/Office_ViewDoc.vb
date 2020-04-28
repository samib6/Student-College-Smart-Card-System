
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class Office_ViewDoc
    Dim connection As New SqlConnection("Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=first_db;Integrated Security=True")

    Private Sub Office_ViewDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim combo_cmd As SqlCommand

        'Linking combo box with the User id values in the database
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


            Me.StudentIdComboBox.MaxDropDownItems = 3
            StudentIdComboBox.DataSource = ds.Tables(0)
            StudentIdComboBox.ValueMember = "User_Id"
            StudentIdComboBox.DisplayMember = "User_Id"

        Catch ex As Exception
        Finally
            connection.Close()

        End Try
    End Sub


    ''Displaying the details of the User_Id
    Private Sub StudentIdComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles StudentIdComboBox.SelectionChangeCommitted
        Try
            connection.Open()
            Dim select_query As String
            Dim reader As SqlDataReader
            Dim command As SqlCommand
            select_query = "Select * from Student where User_Id='" & StudentIdComboBox.Text & "' "
            ' MessageBox.Show(Student_Id_Combobox.Text)
            command = New SqlCommand(select_query, connection)
            reader = command.ExecuteReader()

            While reader.Read()

                Me.Name_Show.Text = Convert.ToString(reader("Name"))
                Me.Address_Show.Text = Convert.ToString(reader("Address"))
                Me.ContactNo_Show.Text = Convert.ToString(reader("Mobile_No"))
                Me.EmailId_Show.Text = Convert.ToString(reader("Email_Id"))



            End While
            Photo_pb.Visible = False
            connection.Close()

        Catch ex As Exception

        End Try


    End Sub


    ''Semester 1 link label clicked -opens a pdf doc

    Private Sub Sem1LL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Sem1LL.LinkClicked
        Dim sFilepath As String

        Dim buffers As Byte()
        Try
            connection.Open()
            Dim command As New SqlCommand("SELECT Sem1 FROM Doc_Add WHERE User_Id = '" & StudentIdComboBox.Text & "'", connection)
            buffers = command.ExecuteScalar()

            sFilepath = System.IO.Path.GetTempFileName()
            System.IO.File.Move(sFilepath, System.IO.Path.ChangeExtension(sFilepath, ".pdf"))
            sFilepath = System.IO.Path.ChangeExtension(sFilepath, ".pdf")


            System.IO.File.WriteAllBytes(sFilepath, buffers)

            PdfViewForm.Show()
            PdfViewForm.pdfviewer.src = sFilepath
        Catch ex As Exception

        Finally
            connection.Close()
        End Try



    End Sub



    ''Semester 2 link label clicked -opens a pdf doc

    Private Sub Sem2LL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Sem2LL.LinkClicked
        Dim sFilepath As String
        Dim buffers As Byte()
        Try
            connection.Open()
            Dim command As New SqlCommand("SELECT Sem2 FROM Doc_Add WHERE User_Id = '" & StudentIdComboBox.Text & "'", connection)
            buffers = command.ExecuteScalar()

            sFilepath = System.IO.Path.GetTempFileName()
            System.IO.File.Move(sFilepath, System.IO.Path.ChangeExtension(sFilepath, ".pdf"))
            sFilepath = System.IO.Path.ChangeExtension(sFilepath, ".pdf")


            System.IO.File.WriteAllBytes(sFilepath, buffers)

            PdfViewForm.Show()
            PdfViewForm.pdfviewer.src = sFilepath
        Catch ex As Exception
        Finally

            connection.Close()
        End Try


    End Sub

    ''SSC leaving link label clicked -opens a pdf doc of SSC leaving
    Private Sub SSC_LeavingLL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SSC_LeavingLL.LinkClicked
        Dim sFilepath As String
        Dim buffers As Byte()
        Try
            connection.Open()
            Dim command As New SqlCommand("SELECT SSC_Leaving FROM Doc_Add WHERE User_Id = '" & StudentIdComboBox.Text & "'", connection)
            buffers = command.ExecuteScalar()


            sFilepath = System.IO.Path.GetTempFileName()
            System.IO.File.Move(sFilepath, System.IO.Path.ChangeExtension(sFilepath, ".pdf"))
            sFilepath = System.IO.Path.ChangeExtension(sFilepath, ".pdf")


            System.IO.File.WriteAllBytes(sFilepath, buffers)

            PdfViewForm.Show()
            PdfViewForm.pdfviewer.src = sFilepath
        Catch ex As Exception
        Finally
            connection.Close()
        End Try

    End Sub


    ''Semester 1 link label clicked -opens a pdf doc
    Private Sub SSC_PassingLL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SSC_PassingLL.LinkClicked
        Dim sFilepath As String
        Dim buffers As Byte()
        Try
            connection.Open()
            Dim command As New SqlCommand("SELECT SSC_Passing FROM Doc_Add WHERE User_Id = '" & StudentIdComboBox.Text & "'", connection)
            buffers = command.ExecuteScalar()


            sFilepath = System.IO.Path.GetTempFileName()
            System.IO.File.Move(sFilepath, System.IO.Path.ChangeExtension(sFilepath, ".pdf"))
            sFilepath = System.IO.Path.ChangeExtension(sFilepath, ".pdf")


            System.IO.File.WriteAllBytes(sFilepath, buffers)

            PdfViewForm.Show()
            PdfViewForm.pdfviewer.src = sFilepath
        Catch ex As Exception
        Finally
            connection.Close()
        End Try


    End Sub

    Private Sub StudentIdComboBox_TextChanged(sender As Object, e As EventArgs) Handles StudentIdComboBox.TextChanged
        Try
            connection.Open()
            Dim select_query As String
            Dim reader As SqlDataReader
            Dim command As SqlCommand
            select_query = "Select * from Student where User_Id='" & StudentIdComboBox.Text & "' "
            ' MessageBox.Show(Student_Id_Combobox.Text)
            command = New SqlCommand(select_query, connection)
            reader = command.ExecuteReader()

            While reader.Read()

                Me.Name_Show.Text = Convert.ToString(reader("Name"))
                Me.Address_Show.Text = Convert.ToString(reader("Address"))
                Me.ContactNo_Show.Text = Convert.ToString(reader("Mobile_No"))
                Me.EmailId_Show.Text = Convert.ToString(reader("Email_Id"))



            End While
            Photo_pb.Visible = False
            connection.Close()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub PhotoLL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles PhotoLL.LinkClicked
        Dim command As New SqlCommand("SELECT Photo FROM Doc_Add WHERE User_Id = '" & StudentIdComboBox.Text & "'", connection)

        Try
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
        Catch ex As Exception
        Finally
            connection.Close()
        End Try


    End Sub
End Class