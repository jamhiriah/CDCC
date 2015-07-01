<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txtmsg = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHistory = New System.Windows.Forms.TextBox()
        Me.btnsend = New System.Windows.Forms.Button()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.btnName = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtmsg
        '
        Me.txtmsg.Location = New System.Drawing.Point(15, 234)
        Me.txtmsg.Name = "txtmsg"
        Me.txtmsg.Size = New System.Drawing.Size(187, 20)
        Me.txtmsg.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Enter your chat name"
        '
        'txtHistory
        '
        Me.txtHistory.Location = New System.Drawing.Point(15, 88)
        Me.txtHistory.Multiline = True
        Me.txtHistory.Name = "txtHistory"
        Me.txtHistory.Size = New System.Drawing.Size(268, 137)
        Me.txtHistory.TabIndex = 8
        '
        'btnsend
        '
        Me.btnsend.Location = New System.Drawing.Point(208, 231)
        Me.btnsend.Name = "btnsend"
        Me.btnsend.Size = New System.Drawing.Size(75, 23)
        Me.btnsend.TabIndex = 7
        Me.btnsend.Text = "Send"
        Me.btnsend.UseVisualStyleBackColor = True
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(135, 9)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(148, 20)
        Me.txtname.TabIndex = 12
        '
        'btnName
        '
        Me.btnName.Location = New System.Drawing.Point(135, 47)
        Me.btnName.Name = "btnName"
        Me.btnName.Size = New System.Drawing.Size(148, 23)
        Me.btnName.TabIndex = 11
        Me.btnName.Text = "Connect to server"
        Me.btnName.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.btnName)
        Me.Controls.Add(Me.txtmsg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHistory)
        Me.Controls.Add(Me.btnsend)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtmsg As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtHistory As System.Windows.Forms.TextBox
    Friend WithEvents btnsend As System.Windows.Forms.Button
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents btnName As System.Windows.Forms.Button
End Class
