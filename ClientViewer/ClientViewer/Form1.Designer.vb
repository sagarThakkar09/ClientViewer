<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblClientViewer = New System.Windows.Forms.Label()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.Label()
        Me.btnlogIn = New System.Windows.Forms.Button()
        Me.textEmail = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblClientViewer
        '
        Me.lblClientViewer.AutoSize = True
        Me.lblClientViewer.Font = New System.Drawing.Font("Arial", 16.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientViewer.Location = New System.Drawing.Point(299, 20)
        Me.lblClientViewer.Name = "lblClientViewer"
        Me.lblClientViewer.Padding = New System.Windows.Forms.Padding(20)
        Me.lblClientViewer.Size = New System.Drawing.Size(195, 67)
        Me.lblClientViewer.TabIndex = 17
        Me.lblClientViewer.Text = "ClientViewer"
        '
        'btnSignUp
        '
        Me.btnSignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.Location = New System.Drawing.Point(335, 397)
        Me.btnSignUp.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(125, 33)
        Me.btnSignUp.TabIndex = 16
        Me.btnSignUp.Text = "SignUp"
        Me.btnSignUp.UseVisualStyleBackColor = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(254, 259)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(87, 19)
        Me.lblPassword.TabIndex = 15
        Me.lblPassword.Text = "Password"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(254, 171)
        Me.lblName.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(53, 19)
        Me.lblName.TabIndex = 14
        Me.lblName.Text = "Name"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(383, 251)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(164, 20)
        Me.txtPassword.TabIndex = 13
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(383, 171)
        Me.txtName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(164, 20)
        Me.txtName.TabIndex = 12
        '
        'txtEmail
        '
        Me.txtEmail.AutoSize = True
        Me.txtEmail.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(254, 99)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(51, 19)
        Me.txtEmail.TabIndex = 11
        Me.txtEmail.Text = "Email"
        '
        'btnlogIn
        '
        Me.btnlogIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogIn.Location = New System.Drawing.Point(258, 343)
        Me.btnlogIn.Margin = New System.Windows.Forms.Padding(5)
        Me.btnlogIn.Name = "btnlogIn"
        Me.btnlogIn.Size = New System.Drawing.Size(289, 33)
        Me.btnlogIn.TabIndex = 10
        Me.btnlogIn.Text = "Ask for remote assistance"
        Me.btnlogIn.UseVisualStyleBackColor = True
        '
        'textEmail
        '
        Me.textEmail.Location = New System.Drawing.Point(383, 99)
        Me.textEmail.Margin = New System.Windows.Forms.Padding(5)
        Me.textEmail.Name = "textEmail"
        Me.textEmail.Size = New System.Drawing.Size(164, 20)
        Me.textEmail.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblClientViewer)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.btnlogIn)
        Me.Controls.Add(Me.textEmail)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblClientViewer As Label
    Private WithEvents btnSignUp As Button
    Private WithEvents lblPassword As Label
    Private WithEvents lblName As Label
    Private WithEvents txtPassword As TextBox
    Private WithEvents txtName As TextBox
    Private WithEvents txtEmail As Label
    Private WithEvents btnlogIn As Button
    Private WithEvents textEmail As TextBox
End Class
