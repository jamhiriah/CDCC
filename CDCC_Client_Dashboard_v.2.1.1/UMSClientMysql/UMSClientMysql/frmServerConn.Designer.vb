<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServerconn
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
        Me.btnTest = New System.Windows.Forms.Button()
        Me.txtSvrConn = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblmsg = New System.Windows.Forms.Label()
        Me.cboPCnum = New System.Windows.Forms.ComboBox()
        Me.txtChatServerIP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.chkSameServer = New System.Windows.Forms.CheckBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(327, 25)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 46)
        Me.btnTest.TabIndex = 0
        Me.btnTest.Text = "Test Connection"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'txtSvrConn
        '
        Me.txtSvrConn.Location = New System.Drawing.Point(113, 27)
        Me.txtSvrConn.Name = "txtSvrConn"
        Me.txtSvrConn.Size = New System.Drawing.Size(206, 20)
        Me.txtSvrConn.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Database Server IP"
        '
        'lblmsg
        '
        Me.lblmsg.Location = New System.Drawing.Point(113, 138)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.Size = New System.Drawing.Size(206, 22)
        Me.lblmsg.TabIndex = 3
        Me.lblmsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboPCnum
        '
        Me.cboPCnum.FormattingEnabled = True
        Me.cboPCnum.Location = New System.Drawing.Point(113, 97)
        Me.cboPCnum.Name = "cboPCnum"
        Me.cboPCnum.Size = New System.Drawing.Size(121, 21)
        Me.cboPCnum.TabIndex = 4
        '
        'txtChatServerIP
        '
        Me.txtChatServerIP.Enabled = False
        Me.txtChatServerIP.Location = New System.Drawing.Point(113, 53)
        Me.txtChatServerIP.Name = "txtChatServerIP"
        Me.txtChatServerIP.Size = New System.Drawing.Size(206, 20)
        Me.txtChatServerIP.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Chat Server IP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Client PC Number"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(327, 116)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'chkSameServer
        '
        Me.chkSameServer.AutoSize = True
        Me.chkSameServer.Location = New System.Drawing.Point(113, 74)
        Me.chkSameServer.Name = "chkSameServer"
        Me.chkSameServer.Size = New System.Drawing.Size(112, 17)
        Me.chkSameServer.TabIndex = 9
        Me.chkSameServer.Text = "User Same Server"
        Me.chkSameServer.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(327, 87)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmServerconn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 184)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.chkSameServer)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtChatServerIP)
        Me.Controls.Add(Me.cboPCnum)
        Me.Controls.Add(Me.lblmsg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSvrConn)
        Me.Controls.Add(Me.btnTest)
        Me.Name = "frmServerconn"
        Me.Text = "Connection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents txtSvrConn As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblmsg As System.Windows.Forms.Label
    Friend WithEvents cboPCnum As System.Windows.Forms.ComboBox
    Friend WithEvents txtChatServerIP As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents chkSameServer As System.Windows.Forms.CheckBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
