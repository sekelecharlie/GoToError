Imports System.IO

Public Class Form1
    Private Sub btnGoToError_Click(sender As Object, e As EventArgs) Handles btnGoToError.Click

        Dim isNumber As String
        isNumber = txtUserInput.Text

        On Error GoTo ErrorEventHandler

        Dim numericValue As Double
        numericValue = CDbl(isNumber)

        MsgBox("You have entered a correct number: " & numericValue)
        Exit Sub

ErrorEventHandler:
        MsgBox("Error: " & isNumber & " is not a number")
    End Sub
End Class
