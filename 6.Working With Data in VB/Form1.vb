Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim YourMessage As String

        Dim BirthYear As Integer
        YourMessage = "Happy Birthday, How old are you now?"

        MessageBox.Show(YourMessage)
        BirthYear = Val(InputBox("Enter year of birth"))
        MessageBox.Show("You are now, " & 2024 - BirthYear & " Years old.")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
