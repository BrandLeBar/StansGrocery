Public Class SplashScreenForm
    Private Sub SplashScreenForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        SplashTimer.Enabled = True
    End Sub

    Private Sub SplashTimer_Tick(sender As Object, e As EventArgs) Handles SplashTimer.Tick
        SplashTimer.Enabled = False
        StansGroceryForm.Show()
        Me.Hide()
    End Sub

End Class