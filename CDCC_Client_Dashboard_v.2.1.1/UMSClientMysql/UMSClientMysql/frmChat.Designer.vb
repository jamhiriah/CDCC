<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChat
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
        Me.txthistory = New System.Windows.Forms.TextBox()
        Me.txtSend = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.lblConnect = New System.Windows.Forms.Label()
        Me.lblPcNo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txthistory
        '
        Me.txthistory.Location = New System.Drawing.Point(12, 37)
        Me.txthistory.Multiline = True
        Me.txthistory.Name = "txthistory"
        Me.txthistory.Size = New System.Drawing.Size(381, 154)
        Me.txthistory.TabIndex = 0
        '
        'txtSend
        '
        Me.txtSend.Location = New System.Drawing.Point(12, 197)
        Me.txtSend.Multiline = True
        Me.txtSend.Name = "txtSend"
        Me.txtSend.Size = New System.Drawing.Size(307, 56)
        Me.txtSend.TabIndex = 1
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(323, 229)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 2
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'lblConnect
        '
        Me.lblConnect.AutoSize = True
        Me.lblConnect.Location = New System.Drawing.Point(246, 9)
        Me.lblConnect.Name = "lblConnect"
        Me.lblConnect.Size = New System.Drawing.Size(0, 13)
        Me.lblConnect.TabIndex = 3
        '
        'lblPcNo
        '
        Me.lblPcNo.AutoSize = True
        Me.lblPcNo.Location = New System.Drawing.Point(12, 9)
        Me.lblPcNo.Name = "lblPcNo"
        Me.lblPcNo.Size = New System.Drawing.Size(44, 13)
        Me.lblPcNo.TabIndex = 4
        Me.lblPcNo.Text = "lblPcNo"
        '
        'frmChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 269)
        Me.Controls.Add(Me.lblPcNo)
        Me.Controls.Add(Me.lblConnect)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtSend)
        Me.Controls.Add(Me.txthistory)
        Me.Name = "frmChat"
        Me.Text = "Chat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txthistory As System.Windows.Forms.TextBox
    Friend WithEvents txtSend As System.Windows.Forms.TextBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents lblConnect As System.Windows.Forms.Label
    Friend WithEvents lblPcNo As System.Windows.Forms.Label
End Class
