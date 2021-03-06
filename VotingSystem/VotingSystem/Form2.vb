Imports MySql.Data.MySqlClient
Public Class Form2
    Dim CONNECT As MySqlConnection
    Dim CONSTRING As String = "data source = localhost; user = root; database = votingsystem_cruz"
    Dim CMD As MySqlCommand
    Dim DA As MySqlDataAdapter
    Dim DS As DataSet
    Dim itemcoll(999) As String

Public Sub LOADLV()
        Try
            ListView1.Items.Clear()
            CONNECT = New MySqlConnection(CONSTRING)
            CONNECT.Open()
            Dim sql As String = "select * from voters"
            CMD = New MySqlCommand(sql, CONNECT)
            DA = New MySqlDataAdapter(CMD)
            DS = New DataSet
            DA.Fill(DS, "Tables")
            For a = 0 To DS.Tables(0).Rows.Count - 1
                For b = 0 To DS.Tables(0).Columns.Count - 1
                    itemcoll(b) = DS.Tables(0).Rows(a)(b).ToString
                Next
                Dim lvitm As New ListViewItem(itemcoll)
                ListView1.Items.Add(lvitm)
            Next


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CONNECT.Close()
    End Sub

    Public Sub ClearData()
        SNTXT.Clear()
        FNTXT.Clear()
        MNTXT.Clear()
        LNTXT.Clear()
        COURSETXT.Clear()
        YSTXT.Clear()
        EMAILTXT.Clear()


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LOADLV()
    End Sub

    Private Sub ADD_BTN_Click(sender As Object, e As EventArgs) Handles ADD_BTN.Click
        Try
            CONNECT = New MySqlConnection(CONSTRING)
            CONNECT.Open()
            Dim SQL As String = "Insert into voters (Student_number, First_name, Middle_name, Last_name, Course, Year_Section, Email) values('" & SNTXT.Text & "','" & FNTXT.Text & "', '" & MNTXT.Text & "', '" & LNTXT.Text & "', '" & COURSETXT.Text & "', '" & YSTXT.Text & "','" & EMAILTXT.Text & "')"
            CMD = New MySqlCommand(SQL, CONNECT)
            CMD.ExecuteNonQuery()
            CONNECT.Close()
            MsgBox("INFORMATION ADDED!", vbInformation, "STATUS:")
            Call LOADLV()
            Call ClearData()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        menu_frm.Show()

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            SNTXT.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(0).Text
            FNTXT.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(1).Text
            MNTXT.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(2).Text
            LNTXT.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(3).Text
            COURSETXT.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(4).Text
            YSTXT.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(5).Text
            EMAILTXT.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(6).Text
        End If
    End Sub

    Private Sub DELETE_BTN_Click(sender As Object, e As EventArgs) Handles DELETE_BTN.Click
        Try
            CONNECT = New MySqlConnection(CONSTRING)
            CONNECT.Open()
            Dim SQL As String = "delete from voters WHERE Student_number = '" & SNTXT.Text & "'"
            CMD = New MySqlCommand(SQL, CONNECT)
            Dim p As Integer = CMD.ExecuteNonQuery
            If p <> 0 Then
                MsgBox("Record Deleted", vbInformation, "STATUS:")
            Else
                MsgBox("Record Cannot be Deleted", vbCritical, "STATUS:")
            End If
            Call LOADLV()
            CONNECT.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call ClearData()
    End Sub

    Private Sub UPDATE_BTN_Click(sender As Object, e As EventArgs) Handles UPDATE_BTN.Click
        Try
            CONNECT = New MySqlConnection(CONSTRING)
            CONNECT.Open()
            Dim SQL As String = "Update voters set First_name = '" & FNTXT.Text & "', Middle_name = '" & MNTXT.Text & "', Last_name = '" & LNTXT.Text & "', Course = '" & COURSETXT.Text & "', Year_Section = '" & YSTXT.Text & "', Email = '" & EMAILTXT.Text & "' where Student_number = '" & SNTXT.Text & "'"
            CMD = New MySqlCommand(SQL, CONNECT)
            Dim p As Integer = CMD.ExecuteNonQuery
            If p <> 0 Then
                MsgBox("Information Updated", vbInformation, "STATUS:")
            Else
                MsgBox("Information Cannot be Updated", vbCritical, "STATUS:")
            End If
            Call LOADLV()
            CONNECT.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call ClearData()
    End Sub
End Class