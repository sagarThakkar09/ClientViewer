Public Class Form1
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Process.Start("https://start.teamviewer.com/contact/" + txtid.Text + "/authorization/prompt/mode/control")
    End Sub
End Class
