Public Class AboutForm
    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        Me.Hide()
        StansGroceryForm.Show()
    End Sub
End Class