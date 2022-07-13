Public Class menu_frm

    Private Sub pb3_Click(sender As Object, e As EventArgs) Handles pb3.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub pb1_Click(sender As Object, e As EventArgs) Handles pb1.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("YOU LOGGED OUT SUCCESSFULLY!", vbInformation, "STATUS:")
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub pb2_Click(sender As Object, e As EventArgs) Handles pb2.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class