Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json.Linq

Public Class Form1
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim httpclient As New HttpClient()
        httpclient.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Bearer", "10731913-afoajAnkGZPjsxnXTE3L")
        Dim getsession As HttpResponseMessage = httpclient.GetAsync("https://webapi.teamviewer.com/api/v1/sessions?State=open&full_list=true&groupid=g177166325").Result
        If (getsession.IsSuccessStatusCode) Then
            Dim result = getsession.Content.ReadAsStringAsync().Result
            Dim link As JObject = JObject.Parse(result)
            If (link("sessions").HasValues) Then
                visitlink(link("sessions")(0)("supporter_link").ToString())

            Else
                MessageBox.Show("Something went worng please try again", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("No Sessions are created , please try again", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End If
    End Sub
    Sub visitlink(ByRef link As String)
        Process.Start(link)
    End Sub
End Class
