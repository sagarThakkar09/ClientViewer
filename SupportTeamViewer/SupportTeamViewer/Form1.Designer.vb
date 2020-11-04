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
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblClientViewer
        '
        Me.lblClientViewer.AutoSize = True
        Me.lblClientViewer.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblClientViewer.Font = New System.Drawing.Font("Arial", 16.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientViewer.Location = New System.Drawing.Point(300, 125)
        Me.lblClientViewer.Name = "lblClientViewer"
        Me.lblClientViewer.Padding = New System.Windows.Forms.Padding(20)
        Me.lblClientViewer.Size = New System.Drawing.Size(195, 67)
        Me.lblClientViewer.TabIndex = 14
        Me.lblClientViewer.Text = "ClientViewer"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(393, 216)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(29, 20)
        Me.label2.TabIndex = 13
        Me.label2.Text = "C-"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(428, 216)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(100, 20)
        Me.txtid.TabIndex = 12
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(273, 216)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(89, 20)
        Me.label1.TabIndex = 11
        Me.label1.Text = "Client ID:"
        '
        'btnConnect
        '
        Me.btnConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.Location = New System.Drawing.Point(293, 271)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(202, 54)
        Me.btnConnect.TabIndex = 10
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblClientViewer)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnConnect)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblClientViewer As Label
    Private WithEvents label2 As Label
    Private WithEvents txtid As TextBox
    Private WithEvents label1 As Label
    Private WithEvents btnConnect As Button
End Class
