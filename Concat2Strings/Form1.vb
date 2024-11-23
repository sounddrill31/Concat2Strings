Public Class Form1
    Private Sub Result_Click(sender As Object, e As EventArgs) Handles Result.Click
        ResultBox.Text = FirstNameBox.Text & " " & LastNameBox.Text
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Close()
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        FirstNameBox.Text = String.Empty
        LastNameBox.Text = String.Empty
        ResultBox.Text = "Result"

    End Sub

End Class
