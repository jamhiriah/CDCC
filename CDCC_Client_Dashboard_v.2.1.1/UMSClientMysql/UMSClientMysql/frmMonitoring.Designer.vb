<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonitoring
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonitoring))
        Me.btnout = New System.Windows.Forms.Button()
        Me.btnmin = New System.Windows.Forms.Button()
        Me.lblduration = New System.Windows.Forms.Label()
        Me.lblcharge = New System.Windows.Forms.Label()
        Me.lblstartdate = New System.Windows.Forms.Label()
        Me.lblKp = New System.Windows.Forms.Label()
        Me.lblanggaran = New System.Windows.Forms.Label()
        Me.lbltempoh = New System.Windows.Forms.Label()
        Me.lblpaid = New System.Windows.Forms.Label()
        Me.lblstarttime = New System.Windows.Forms.Label()
        Me.lblnokp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblpayment = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblservertime = New System.Windows.Forms.Label()
        Me.btn_bypass = New System.Windows.Forms.Button()
        Me.lblbakihari2 = New System.Windows.Forms.Label()
        Me.lblbakihari = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnout
        '
        Me.btnout.Image = Global.UMSClientMysql.My.Resources.Resources.out
        Me.btnout.Location = New System.Drawing.Point(163, 179)
        Me.btnout.Name = "btnout"
        Me.btnout.Size = New System.Drawing.Size(40, 43)
        Me.btnout.TabIndex = 23
        Me.btnout.UseVisualStyleBackColor = True
        '
        'btnmin
        '
        Me.btnmin.Image = Global.UMSClientMysql.My.Resources.Resources.minimize_icon
        Me.btnmin.Location = New System.Drawing.Point(116, 179)
        Me.btnmin.Name = "btnmin"
        Me.btnmin.Size = New System.Drawing.Size(41, 43)
        Me.btnmin.TabIndex = 22
        Me.btnmin.UseVisualStyleBackColor = True
        '
        'lblduration
        '
        Me.lblduration.AutoSize = True
        Me.lblduration.Location = New System.Drawing.Point(134, 120)
        Me.lblduration.Name = "lblduration"
        Me.lblduration.Size = New System.Drawing.Size(0, 13)
        Me.lblduration.TabIndex = 20
        '
        'lblcharge
        '
        Me.lblcharge.AutoSize = True
        Me.lblcharge.Location = New System.Drawing.Point(134, 95)
        Me.lblcharge.Name = "lblcharge"
        Me.lblcharge.Size = New System.Drawing.Size(0, 13)
        Me.lblcharge.TabIndex = 19
        '
        'lblstartdate
        '
        Me.lblstartdate.AutoSize = True
        Me.lblstartdate.Location = New System.Drawing.Point(134, 64)
        Me.lblstartdate.Name = "lblstartdate"
        Me.lblstartdate.Size = New System.Drawing.Size(0, 13)
        Me.lblstartdate.TabIndex = 18
        '
        'lblKp
        '
        Me.lblKp.AutoSize = True
        Me.lblKp.Location = New System.Drawing.Point(134, 36)
        Me.lblKp.Name = "lblKp"
        Me.lblKp.Size = New System.Drawing.Size(0, 13)
        Me.lblKp.TabIndex = 17
        '
        'lblanggaran
        '
        Me.lblanggaran.AutoSize = True
        Me.lblanggaran.Location = New System.Drawing.Point(12, 159)
        Me.lblanggaran.Name = "lblanggaran"
        Me.lblanggaran.Size = New System.Drawing.Size(98, 13)
        Me.lblanggaran.TabIndex = 16
        Me.lblanggaran.Text = "Anggaran Bayaran "
        '
        'lbltempoh
        '
        Me.lbltempoh.AutoSize = True
        Me.lbltempoh.Location = New System.Drawing.Point(13, 129)
        Me.lbltempoh.Name = "lbltempoh"
        Me.lbltempoh.Size = New System.Drawing.Size(110, 13)
        Me.lbltempoh.TabIndex = 15
        Me.lbltempoh.Text = "Tempoh Penggunaan"
        '
        'lblpaid
        '
        Me.lblpaid.AutoSize = True
        Me.lblpaid.Location = New System.Drawing.Point(13, 101)
        Me.lblpaid.Name = "lblpaid"
        Me.lblpaid.Size = New System.Drawing.Size(78, 13)
        Me.lblpaid.TabIndex = 14
        Me.lblpaid.Text = "Bayaran Sejam"
        '
        'lblstarttime
        '
        Me.lblstarttime.AutoSize = True
        Me.lblstarttime.Location = New System.Drawing.Point(13, 73)
        Me.lblstarttime.Name = "lblstarttime"
        Me.lblstarttime.Size = New System.Drawing.Size(59, 13)
        Me.lblstarttime.TabIndex = 13
        Me.lblstarttime.Text = "Masa Mula"
        '
        'lblnokp
        '
        Me.lblnokp.AutoSize = True
        Me.lblnokp.Location = New System.Drawing.Point(13, 45)
        Me.lblnokp.Name = "lblnokp"
        Me.lblnokp.Size = New System.Drawing.Size(90, 13)
        Me.lblnokp.TabIndex = 12
        Me.lblnokp.Text = "No KP Pengguna"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(221, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(8, 179)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(48, 16)
        Me.TextBox1.TabIndex = 26
        Me.TextBox1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(111, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = ":"
        '
        'lblpayment
        '
        Me.lblpayment.AutoSize = True
        Me.lblpayment.Location = New System.Drawing.Point(126, 153)
        Me.lblpayment.Name = "lblpayment"
        Me.lblpayment.Size = New System.Drawing.Size(0, 13)
        Me.lblpayment.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(111, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(111, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(10, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(111, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(111, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(10, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = ":"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblservertime)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.btn_bypass)
        Me.Panel1.Controls.Add(Me.lblbakihari2)
        Me.Panel1.Controls.Add(Me.lblbakihari)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnout)
        Me.Panel1.Controls.Add(Me.lblpayment)
        Me.Panel1.Controls.Add(Me.btnmin)
        Me.Panel1.Controls.Add(Me.lblduration)
        Me.Panel1.Controls.Add(Me.lblcharge)
        Me.Panel1.Controls.Add(Me.lblstartdate)
        Me.Panel1.Controls.Add(Me.lblKp)
        Me.Panel1.Location = New System.Drawing.Point(6, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(272, 233)
        Me.Panel1.TabIndex = 31
        '
        'lblservertime
        '
        Me.lblservertime.AutoSize = True
        Me.lblservertime.Location = New System.Drawing.Point(5, 9)
        Me.lblservertime.Name = "lblservertime"
        Me.lblservertime.Size = New System.Drawing.Size(39, 13)
        Me.lblservertime.TabIndex = 35
        Me.lblservertime.Text = "Label3"
        '
        'btn_bypass
        '
        Me.btn_bypass.Image = Global.UMSClientMysql.My.Resources.Resources.info1
        Me.btn_bypass.Location = New System.Drawing.Point(73, 179)
        Me.btn_bypass.Name = "btn_bypass"
        Me.btn_bypass.Size = New System.Drawing.Size(37, 43)
        Me.btn_bypass.TabIndex = 34
        Me.btn_bypass.UseVisualStyleBackColor = True
        '
        'lblbakihari2
        '
        Me.lblbakihari2.AutoSize = True
        Me.lblbakihari2.Location = New System.Drawing.Point(232, 95)
        Me.lblbakihari2.Name = "lblbakihari2"
        Me.lblbakihari2.Size = New System.Drawing.Size(0, 13)
        Me.lblbakihari2.TabIndex = 33
        '
        'lblbakihari
        '
        Me.lblbakihari.AutoSize = True
        Me.lblbakihari.Location = New System.Drawing.Point(182, 95)
        Me.lblbakihari.Name = "lblbakihari"
        Me.lblbakihari.Size = New System.Drawing.Size(53, 13)
        Me.lblbakihari.TabIndex = 32
        Me.lblbakihari.Text = "Baki Hari:"
        Me.lblbakihari.Visible = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        '
        'frmMonitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 243)
        Me.Controls.Add(Me.lblanggaran)
        Me.Controls.Add(Me.lbltempoh)
        Me.Controls.Add(Me.lblpaid)
        Me.Controls.Add(Me.lblstarttime)
        Me.Controls.Add(Me.lblnokp)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMonitoring"
        Me.Text = "Monitoring"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnout As System.Windows.Forms.Button
    Friend WithEvents btnmin As System.Windows.Forms.Button
    Friend WithEvents lblduration As System.Windows.Forms.Label
    Friend WithEvents lblcharge As System.Windows.Forms.Label
    Friend WithEvents lblstartdate As System.Windows.Forms.Label
    Friend WithEvents lblKp As System.Windows.Forms.Label
    Friend WithEvents lblanggaran As System.Windows.Forms.Label
    Friend WithEvents lbltempoh As System.Windows.Forms.Label
    Friend WithEvents lblpaid As System.Windows.Forms.Label
    Friend WithEvents lblstarttime As System.Windows.Forms.Label
    Friend WithEvents lblnokp As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblpayment As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblbakihari2 As System.Windows.Forms.Label
    Friend WithEvents lblbakihari As System.Windows.Forms.Label
    Friend WithEvents btn_bypass As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents lblservertime As System.Windows.Forms.Label
End Class
