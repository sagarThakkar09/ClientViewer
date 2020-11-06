Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Form1
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs)
        Process.Start("https://login.teamviewer.com/LogOn#register")
    End Sub

    Private Sub btnlogIn_Click(sender As Object, e As EventArgs) Handles btnlogIn.Click
        Dim HttpCLient = New HttpClient()
        HttpCLient.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Bearer", "10731913-afoajAnkGZPjsxnXTE3L")
        Dim users = New users()
        Dim json = JsonConvert.SerializeObject(users)
        Dim data = New StringContent(json, Encoding.UTF8, "application/json")
        Dim addContact As HttpResponseMessage = HttpCLient.PostAsync("https://webapi.teamviewer.com/api/v1/sessions", data).Result

        If (addContact.IsSuccessStatusCode) Then
            Dim result = (addContact.Content.ReadAsStringAsync().Result)
            Dim code As JObject = JObject.Parse(result)
            ' MessageBox.Show("Your Session code:" + code("code").ToString(), "Session Code", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            visitlink(code("code").ToString())
        Else
            MessageBox.Show("Something went wrong Please try again.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End If

    End Sub
    Sub visitlink(ByRef code As String)
        Process.Start("https://get.teamviewer.com/" + code.Replace("-", ""))
    End Sub
End Class
Class users

    Public Property groupname As String
    Public Property waiting_message As String
    Public Property support_session_type As String
    Public Property assigned_userid As String
    Public Sub New()
        Me.groupname = "My Computers"
        Me.waiting_message = "Please wait"
        Me.support_session_type = "pilot"
        Me.assigned_userid = "u0"
    End Sub

End Class
