'Brandon Barrera
'RCET 226
'Spring 2025
'Stan 's Grocery
'

Option Strict On
Option Explicit On
Option Compare Text

Public Class StansGroceryForm

    'Buttons ///////////////////////////////////////////////////////////
    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click, SearchTextBox.Enter, SearchToolStripMenuItem.Click, SearchToolStripTextBox1.Enter

    End Sub




    'Subs //////////////////////////////////////////////////////////////
    Private Sub StansGroceryForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Static firstTime As Integer
        If firstTime < 2 Then
            Me.Hide()
            SplashScreenForm.Show()
        ElseIf firstTime >= 2 Then

        End If

        firstTime += 1
    End Sub
    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        Me.Hide()
        AboutForm.Show()
    End Sub


    'Functions /////////////////////////////////////////////////////////



End Class
