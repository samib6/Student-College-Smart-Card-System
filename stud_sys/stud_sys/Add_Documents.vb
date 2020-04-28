
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class Add_Documents
    Dim label_array() As Label = {Photo_label, Sem_1_Label, Sem_2_Label, SSC_Leaving_Label, SSC_Passing_Label}
    Dim textbox_array() As TextBox = {Photo_Textbox, Sem1_Textbox, Sem2_Textbox, SSC_Leaving_Textbox, SSC_Passing_Textbox}
    Dim search_array() As Button = {Photo_Search, Sem1_Search, Sem2_Search, SSC_Leaving_Search, SSC_Passing_Search}
    Dim add_array() As Button = {Photo_Add_Button, Sem1_Button, Sem2_Button, SSC_Leave_Button, SSC_Passing_Button}
    Dim StrPath As String
    'Dim alabel As Label = New Label
    'Dim atextbox As TextBox = New TextBox

    Dim connection As New SqlConnection("Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=first_db;Integrated Security=True")

    ''search click button


    Private Sub Add_Documents_Load(sender As Object, e As EventArgs) Handles Me.Load

        'combobox link with db
        Dim connection As New SqlConnection("Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=first_db;Integrated Security=True")
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


            ' Me.Student_Id_ComboBox.MaxDropDownItems = 3
            Student_Id_ComboBox.DataSource = ds.Tables(0)
            Student_Id_ComboBox.ValueMember = "User_Id"
            Student_Id_ComboBox.DisplayMember = "User_Id"

        Catch ex As Exception
        Finally
            connection.Close()

        End Try

        '
        'Label and textbox hide
        For Each alabel As Label In Me.Controls.OfType(Of Label).ToArray
            alabel.Hide()
        Next alabel

        For Each atextbox As TextBox In Me.Controls.OfType(Of TextBox).ToArray

            atextbox.Hide()
        Next atextbox

        For Each asearch As Button In Me.Controls.OfType(Of Button).ToArray
            asearch.Hide()
        Next

        For Each aadd As Button In Me.Controls.OfType(Of Button).ToArray
            aadd.Hide()
        Next

        'check if submitted or not


    End Sub




    Private Sub Student_Id_ComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Student_Id_ComboBox.SelectionChangeCommitted

    End Sub

    Private Sub Student_Id_ComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Student_Id_ComboBox.SelectedValueChanged



        Try
            For Each alabel As Label In Me.Controls.OfType(Of Label).ToArray
                alabel.Show()

            Next alabel

            For Each atextbox As TextBox In Me.Controls.OfType(Of TextBox).ToArray
                atextbox.Show()
            Next atextbox

            For Each asearch As Button In Me.Controls.OfType(Of Button).ToArray
                asearch.Show()
            Next

            For Each aadd As Button In Me.Controls.OfType(Of Button).ToArray
                aadd.Show()
            Next


        Catch ex As Exception
        Finally
            connection.Close()

        End Try

        Dim photo_query As String = "Select Photo from Doc_Add where User_Id='" & Student_Id_ComboBox.Text & "'"
        Dim photo_cmd As SqlCommand
        Dim sem1_query As String = "select Sem1 from Doc_Add where User_Id='" & Student_Id_ComboBox.Text & "'"
        Dim sem1_cmd As SqlCommand
        Dim sem2_query As String = "Select Sem2 from Doc_Add where User_Id='" & Student_Id_ComboBox.Text & "'"
        Dim ssc_leaving_query As String = "Select SSC_Leaving  from Doc_Add where User_Id='" & Student_Id_ComboBox.Text & "'"
        Dim ssc_passing_query As String = "Select SSC_Passing from Doc_Add where User_Id='" & Student_Id_ComboBox.Text & "'"


        Try


            photo_cmd = New SqlCommand(photo_query, connection)
            connection.Open()
            Dim photo_reader As SqlDataReader = photo_cmd.ExecuteReader()
            photo_reader.Read()
            If Not IsDBNull(photo_reader("Photo")) Then
                Photo_Textbox.Text = "submitted"

            Else
                Photo_Textbox.Text = "Not Submitted"

            End If

            connection.Close()



            sem1_cmd = New SqlCommand(sem1_query, connection)
            connection.Open()
            Dim sem1_reader As SqlDataReader = sem1_cmd.ExecuteReader()
            sem1_reader.Read()

            If Not IsDBNull(sem1_reader("Sem1")) Then
                Sem1_Textbox.Text = "submitted"
            Else
                Sem1_Textbox.Text = "Not Submitted"

            End If

            connection.Close()

            Dim sem2_cmd = New SqlCommand(sem2_query, connection)
            connection.Open()
            Dim sem2_reader As SqlDataReader = sem2_cmd.ExecuteReader()
            sem2_reader.Read()

            If Not IsDBNull(sem2_reader("Sem2")) Then
                Sem2_Textbox.Text = "submitted"
            Else
                Sem2_Textbox.Text = "Not Submitted"

            End If

            connection.Close()




            Dim ssc_leaving_cmd = New SqlCommand(ssc_leaving_query, connection)
            connection.Open()
            Dim ssc_leaving_reader As SqlDataReader = ssc_leaving_cmd.ExecuteReader()
            ssc_leaving_reader.Read()
            If Not IsDBNull(ssc_leaving_reader("SSC_Leaving")) Then
                SSC_Leaving_Textbox.Text = "submitted"
            Else
                SSC_Leaving_Textbox.Text = "Not Submitted"

            End If
            connection.Close()


            Dim ssc_passing_cmd = New SqlCommand(ssc_passing_query, connection)
            connection.Open()
            Dim ssc_passing_reader As SqlDataReader = ssc_passing_cmd.ExecuteReader()
            ssc_passing_reader.Read()
            If Not IsDBNull(ssc_passing_reader("SSC_Passing")) Then
                SSC_Passing_Textbox.Text = "submitted"
            Else
                SSC_Passing_Textbox.Text = "Not Submitted"

            End If



        Catch ex As Exception

        Finally
            connection.Close()
        End Try


    End Sub

    ''Execute queries function
    Public Sub ExecuteQuery(query As String)
        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

    End Sub

    Private Sub Photo_Search_Click(sender As Object, e As EventArgs) Handles Photo_Search.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG)|*.jpg;*.png"
        If opf.ShowDialog = DialogResult.OK Then
            StrPath = opf.FileName.ToString
            'MessageBox.Show(StrPath)


        End If
    End Sub


    Private Sub Photo_Add_Button_Click(sender As Object, e As EventArgs) Handles Photo_Add_Button.Click
        Dim sql As String = "update Doc_Add set Photo=@Photo where User_Id='" & Student_Id_ComboBox.Text & "'"
        Dim command As SqlCommand = New SqlCommand(sql, connection)
        Try
            Using picture As Image = Image.FromFile(StrPath)
                Using stream As New IO.MemoryStream
                    picture.Save(stream, Imaging.ImageFormat.Jpeg)
                    command.Parameters.Add("@Photo", SqlDbType.Image).Value = stream.GetBuffer()

                End Using
            End Using

            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
        Finally
            connection.Close()
        End Try


    End Sub

    Private Sub Sem1_Search_Click(sender As Object, e As EventArgs) Handles Sem1_Search.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "pdf file(*.PDF)|*.pdf"
        If opf.ShowDialog = DialogResult.OK Then
            StrPath = opf.FileName.ToString
            'MessageBox.Show(StrPath)


        End If
    End Sub

    Private Sub Sem1_Button_Click(sender As Object, e As EventArgs) Handles Sem1_Button.Click
        Dim sql As String = "update Doc_Add set Sem1=@Sem1 where User_Id='" & Student_Id_ComboBox.Text & "'"
        Dim command As SqlCommand = New SqlCommand(sql, connection)
        Try
            Dim filebyte() As Byte = System.IO.File.ReadAllBytes(StrPath)

            command.Parameters.Add("@Sem1", SqlDbType.VarBinary).Value = filebyte

            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub Sem2_Search_Click(sender As Object, e As EventArgs) Handles Sem2_Search.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "pdf file(*.PDF)|*.pdf"
        If opf.ShowDialog = DialogResult.OK Then
            StrPath = opf.FileName.ToString
            'MessageBox.Show(StrPath)


        End If
    End Sub

    Private Sub Sem2_Button_Click(sender As Object, e As EventArgs) Handles Sem2_Button.Click
        Dim sql As String = "update Doc_Add set Sem2=@Sem2 where User_Id='" & Student_Id_ComboBox.Text & "'"
        Dim command As SqlCommand = New SqlCommand(sql, connection)
        Try
            Dim filebyte() As Byte = System.IO.File.ReadAllBytes(StrPath)

            command.Parameters.Add("@Sem2", SqlDbType.VarBinary).Value = filebyte

            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SSC_Leaving_Search_Click(sender As Object, e As EventArgs) Handles SSC_Leaving_Search.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "pdf file(*.PDF)|*.pdf"
        If opf.ShowDialog = DialogResult.OK Then
            StrPath = opf.FileName.ToString
            'MessageBox.Show(StrPath)


        End If
    End Sub

    Private Sub SSC_Passing_Search_Click(sender As Object, e As EventArgs) Handles SSC_Passing_Search.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "pdf file(*.PDF)|*.pdf"
        If opf.ShowDialog = DialogResult.OK Then
            StrPath = opf.FileName.ToString
            'MessageBox.Show(StrPath)


        End If
    End Sub

    Private Sub SSC_Leave_Button_Click(sender As Object, e As EventArgs) Handles SSC_Leave_Button.Click
        Dim sql As String = "update Doc_Add set SSC_Leaving=@SSC_Leaving where User_Id='" & Student_Id_ComboBox.Text & "'"
        Dim command As SqlCommand = New SqlCommand(sql, connection)
        Try
            Dim filebyte() As Byte = System.IO.File.ReadAllBytes(StrPath)

            command.Parameters.Add("@SSC_Leaving", SqlDbType.VarBinary).Value = filebyte

            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception

        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub SSC_Passing_Button_Click(sender As Object, e As EventArgs) Handles SSC_Passing_Button.Click
        Dim sql As String = "update Doc_Add set SSC_Passing=@SSC_Passing where User_Id='" & Student_Id_ComboBox.Text & "'"
        Dim command As SqlCommand = New SqlCommand(sql, connection)

        Try
            Dim filebyte() As Byte = System.IO.File.ReadAllBytes(StrPath)

            command.Parameters.Add("@SSC_Passing", SqlDbType.VarBinary).Value = filebyte

            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception

        End Try

    End Sub
End Class