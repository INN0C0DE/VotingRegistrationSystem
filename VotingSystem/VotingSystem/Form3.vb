Imports MySql.Data.MySqlClient
Public Class Form3
    Dim CONNECT As MySqlConnection
    Dim CONSTRING As String = "data source = localhost; user = root; database = votingsystem_cruz"
    Dim CMD As MySqlCommand
    Dim DA As MySqlDataAdapter
    Dim DS As DataSet
    Dim itemcoll(999) As String

    Private Sub DELETE_BTN_Click(sender As Object, e As EventArgs) Handles DELETE_BTN.Click
        Try
            CONNECT = New MySqlConnection(CONSTRING)
            CONNECT.Open()
            Dim SQL As String = "delete from candidates WHERE Candidate_number = '" & CNTXT.Text & "'"
            CMD = New MySqlCommand(SQL, CONNECT)
            Dim p As Integer = CMD.ExecuteNonQuery
            If p <> 0 Then
                MsgBox("Information Deleted", vbInformation, "STATUS:")
            Else
                MsgBox("Information Cannot be Deleted", vbCritical, "STATUS:")
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
            Dim SQL As String = "Update candidates set Full_name = '" & CFNTXT.Text & "', Position = '" & POSITION.Text & "', Partylist_number = '" & PLNTXT.Text & "' where Candidate_number = '" & CNTXT.Text & "'"
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
    Private Sub ADD_BTN_Click(sender As Object, e As EventArgs) Handles ADD_BTN.Click
        Try
            CONNECT = New MySqlConnection(CONSTRING)
            CONNECT.Open()
            Dim SQL As String = "Insert into candidates (Candidate_number, Full_name, Position, Partylist_number) values('" & CNTXT.Text & "','" & CFNTXT.Text & "', '" & POSITION.Text & "', '" & PLNTXT.Text & "')"
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

    Public Sub ClearData()
        CNTXT.Clear()
        CFNTXT.Clear()
        POSITION.Text = ""
        PLNTXT.Text = ""


    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LOADLV()

    End Sub
    Public Sub LOADLV()
        Try
            ListView1.Items.Clear()
            CONNECT = New MySqlConnection(CONSTRING)
            CONNECT.Open()
            Dim sql As String = "select * from candidates"
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

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            CNTXT.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(0).Text
            CFNTXT.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(1).Text
            POSITION.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(2).Text
            PLNTXT.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(3).Text
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        menu_frm.Show()
    End Sub
End Class