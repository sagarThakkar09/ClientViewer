Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Form1
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Process.Start("https://login.teamviewer.com/LogOn#register")
    End Sub

    Private Sub btnlogIn_Click(sender As Object, e As EventArgs) Handles btnlogIn.Click
        Dim HttpCLient = New HttpClient()
        HttpCLient.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Bearer", "10695247-UX9QiYb0apQPdgMTsS9v")
        Dim users = New users()
        txtEmail.Text = users.email
        txtName.Text = users.name
        txtPassword.Text = users.password
        Dim json = JsonConvert.SerializeObject(users)
        Dim data = New StringContent(json, Encoding.UTF8, "application/json")
        Dim addContact As HttpResponseMessage = HttpCLient.PostAsync("https://webapi.teamviewer.com/api/v1/contacts", data).Result
        Dim Contactinlist As HttpResponseMessage = HttpCLient.GetAsync("https://webapi.teamviewer.com/api/v1/contacts?name=" + txtName.Text).Result
        Dim statusCode = addContact.StatusCode.ToString()
        If (addContact.IsSuccessStatusCode) Then
            Dim result = (addContact.Content.ReadAsStringAsync().Result)
            Dim result1 As JObject = JObject.Parse(result)
            MessageBox.Show("Your Contect Id:" + result1("contact_id").ToString() + "Please accept invitation link send on your register email and provid this Id for remote control", "ClientId", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        ElseIf (statusCode = "BadRequest" AndAlso Contactinlist.IsSuccessStatusCode) Then
            Dim result = (Contactinlist.Content.ReadAsStringAsync().Result)
            Dim result1 As JObject = JObject.Parse(result)
            MessageBox.Show("Your Contect Id:  " + result1("contacts")(0)("contact_id").ToString() + ", Please provid this Id for remote control", "ClientId", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        Else
            ''MessageBox.Show("Please Enter Valid Email/Name/Password Or SignUp your Account", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End If

    End Sub
End Class
Class users
    Public Property email As String
    Public Property password As String
    Public Property name As String
    Public Property groupname As String
    Public Property Invite As Boolean
    Public Property contact_id As Integer

    Public Sub New()
        Me.groupname = "My Computers"
        Me.Invite = False
    End Sub
End Class
