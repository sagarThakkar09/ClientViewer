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
        Me.btnlogIn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblClientViewer
        '
        Me.lblClientViewer.AutoSize = True
        Me.lblClientViewer.Font = New System.Drawing.Font("Arial", 16.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientViewer.Location = New System.Drawing.Point(290, 69)
        Me.lblClientViewer.Name = "lblClientViewer"
        Me.lblClientViewer.Padding = New System.Windows.Forms.Padding(20)
        Me.lblClientViewer.Size = New System.Drawing.Size(195, 67)
        Me.lblClientViewer.TabIndex = 17
        Me.lblClientViewer.Text = "ClientViewer"
        '
        'btnlogIn
        '
        Me.btnlogIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogIn.Location = New System.Drawing.Point(250, 204)
        Me.btnlogIn.Margin = New System.Windows.Forms.Padding(5)
        Me.btnlogIn.Name = "btnlogIn"
        Me.btnlogIn.Size = New System.Drawing.Size(289, 33)
        Me.btnlogIn.TabIndex = 10
        Me.btnlogIn.Text = "Ask for remote assistance"
        Me.btnlogIn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblClientViewer)
        Me.Controls.Add(Me.btnlogIn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblClientViewer As Label
    Private WithEvents btnlogIn As Button
End Class
