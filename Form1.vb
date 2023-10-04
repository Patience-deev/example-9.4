Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Mytext As String

        Mytext = "visual basic"
        MsgBox(Microsoft.VisualBasic.Right(Mytext, 4))
    End Sub
End Class
