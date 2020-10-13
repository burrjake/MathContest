Option Strict On
Option Compare Text
Option Explicit On

'Jake Burrell
'RCET0265
'Fall 2020
'Math Contest
'https://github.com/burrjake/MathContest.git

Public Class MathContestForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub AgeBox_TextChanged(sender As Object, e As EventArgs) Handles AgeTextBox.Leave
        Dim ageNumber As Integer

        Try
            ageNumber = CInt(AgeTextBox.Text)
            If ageNumber >= 7 And ageNumber <= 11 Then
                MsgBox("Welcome to the Math Contest")
            ElseIf ageNumber < 7 And ageNumber > 11 Then
                MsgBox("Student not eligible to complete")
            End If
        Catch ex As Exception
            MsgBox("Please enter valid age")


        End Try
    End Sub


End Class
