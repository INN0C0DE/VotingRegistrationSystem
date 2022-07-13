Public Class LoadingScreen

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1

        If ProgressBar1.Value = 100 Then
            Form1.Show()
            Me.Hide()
            Timer1.Dispose()
        End If
    End Sub
End Class