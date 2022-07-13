Imports MySql.Data.MySqlClient
Public Class Form4
    Dim CONNECT As MySqlConnection
    Dim CONSTRING As String = "data source = localhost; user = root; database = votingsystem_cruz"
    Dim CMD As MySqlCommand
    Dim DA As MySqlDataAdapter
    Dim DS As DataSet
    Dim itemcoll(999) As String
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LOADLV()

    End Sub
    Public Sub ClearData()
        PLN2TXT.Clear()
        PLNAMETXT.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        menu_frm.Show()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            PLN2TXT.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(0).Text
            PLNAMETXT.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(1).Text
        End If
    End Sub
    Public Sub LOADLV()
        Try
            ListView1.Items.Clear()
            CONNECT = New MySqlConnection(CONSTRING)
            CONNECT.Open()
            Dim sql As String = "select * from party_list"
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

    Private Sub ADD_BTN_Click(sender As Object, e As EventArgs) Handles ADD_BTN.Click
        Try
            CONNECT = New MySqlConnection(CONSTRING)
            CONNECT.Open()
            Dim SQL As String = "Insert into party_list (Partylist_number, Partylist_name) values('" & PLN2TXT.Text & "','" & PLNAMETXT.Text & "')"
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

    Private Sub DELETE_BTN_Click(sender As Object, e As EventArgs) Handles DELETE_BTN.Click
        Try
            CONNECT = New MySqlConnection(CONSTRING)
            CONNECT.Open()
            Dim SQL As String = "delete from party_list WHERE Partylist_number = '" & PLN2TXT.Text & "'"
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
            Dim SQL As String = "Update party_list set Partylist_name = '" & PLNAMETXT.Text & "' where Partylist_number = '" & PLN2TXT.Text & "'"
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