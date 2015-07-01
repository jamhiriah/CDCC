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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btninfo = New System.Windows.Forms.Button()
        Me.btnout = New System.Windows.Forms.Button()
        Me.btnmin = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblservertime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelControl = New System.Windows.Forms.Panel()
        Me.lblVersionMonitoring = New System.Windows.Forms.Label()
        Me.lblanggaran = New System.Windows.Forms.Label()
        Me.lblbakihari2 = New System.Windows.Forms.Label()
        Me.lbltempoh = New System.Windows.Forms.Label()
        Me.lblbakihari = New System.Windows.Forms.Label()
        Me.lblpaid = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblstarttime = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblnokp = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblKp = New System.Windows.Forms.Label()
        Me.lblpayment = New System.Windows.Forms.Label()
        Me.lblstartdate = New System.Windows.Forms.Label()
        Me.lblcharge = New System.Windows.Forms.Label()
        Me.lblduration = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.WebBrowser = New System.Windows.Forms.WebBrowser()
        Me.lblUsertype = New System.Windows.Forms.Label()
        Me.panelControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'btninfo
        '
        Me.btninfo.Image = Global.CMSClientMysql.My.Resources.Resources.info1
        Me.btninfo.Location = New System.Drawing.Point(848, 3)
        Me.btninfo.Name = "btninfo"
        Me.btninfo.Size = New System.Drawing.Size(29, 30)
        Me.btninfo.TabIndex = 34
        Me.ToolTip1.SetToolTip(Me.btninfo, "Maklumat Pengguna" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "User information")
        Me.btninfo.UseVisualStyleBackColor = True
        '
        'btnout
        '
        Me.btnout.BackColor = System.Drawing.Color.Transparent
        Me.btnout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnout.ForeColor = System.Drawing.Color.Transparent
        Me.btnout.Image = Global.CMSClientMysql.My.Resources.Resources.close
        Me.btnout.Location = New System.Drawing.Point(912, 3)
        Me.btnout.Name = "btnout"
        Me.btnout.Size = New System.Drawing.Size(29, 30)
        Me.btnout.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.btnout, "Keluar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Logout")
        Me.btnout.UseVisualStyleBackColor = False
        '
        'btnmin
        '
        Me.btnmin.Image = Global.CMSClientMysql.My.Resources.Resources.minimize
        Me.btnmin.Location = New System.Drawing.Point(880, 3)
        Me.btnmin.Name = "btnmin"
        Me.btnmin.Size = New System.Drawing.Size(29, 30)
        Me.btnmin.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.btnmin, "Minimize" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kecilkan")
        Me.btnmin.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        '
        'lblservertime
        '
        Me.lblservertime.AutoSize = True
        Me.lblservertime.Location = New System.Drawing.Point(12, 38)
        Me.lblservertime.Name = "lblservertime"
        Me.lblservertime.Size = New System.Drawing.Size(65, 13)
        Me.lblservertime.TabIndex = 35
        Me.lblservertime.Text = "lblservertime"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 22)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "CMS Pi1M"
        '
        'panelControl
        '
        Me.panelControl.BackColor = System.Drawing.Color.Transparent
        Me.panelControl.Controls.Add(Me.lblUsertype)
        Me.panelControl.Controls.Add(Me.lblVersionMonitoring)
        Me.panelControl.Controls.Add(Me.lblanggaran)
        Me.panelControl.Controls.Add(Me.lblservertime)
        Me.panelControl.Controls.Add(Me.lblbakihari2)
        Me.panelControl.Controls.Add(Me.lbltempoh)
        Me.panelControl.Controls.Add(Me.lblbakihari)
        Me.panelControl.Controls.Add(Me.lblpaid)
        Me.panelControl.Controls.Add(Me.Label11)
        Me.panelControl.Controls.Add(Me.lblstarttime)
        Me.panelControl.Controls.Add(Me.Label10)
        Me.panelControl.Controls.Add(Me.lblnokp)
        Me.panelControl.Controls.Add(Me.Label9)
        Me.panelControl.Controls.Add(Me.Label8)
        Me.panelControl.Controls.Add(Me.Label2)
        Me.panelControl.Controls.Add(Me.lblKp)
        Me.panelControl.Controls.Add(Me.lblpayment)
        Me.panelControl.Controls.Add(Me.lblstartdate)
        Me.panelControl.Controls.Add(Me.lblcharge)
        Me.panelControl.Controls.Add(Me.lblduration)
        Me.panelControl.Controls.Add(Me.Label1)
        Me.panelControl.Controls.Add(Me.btnout)
        Me.panelControl.Controls.Add(Me.btninfo)
        Me.panelControl.Controls.Add(Me.btnmin)
        Me.panelControl.Location = New System.Drawing.Point(12, 5)
        Me.panelControl.Name = "panelControl"
        Me.panelControl.Size = New System.Drawing.Size(944, 73)
        Me.panelControl.TabIndex = 37
        '
        'lblVersionMonitoring
        '
        Me.lblVersionMonitoring.AutoSize = True
        Me.lblVersionMonitoring.Location = New System.Drawing.Point(886, 37)
        Me.lblVersionMonitoring.Name = "lblVersionMonitoring"
        Me.lblVersionMonitoring.Size = New System.Drawing.Size(0, 13)
        Me.lblVersionMonitoring.TabIndex = 54
        '
        'lblanggaran
        '
        Me.lblanggaran.AutoSize = True
        Me.lblanggaran.BackColor = System.Drawing.Color.Transparent
        Me.lblanggaran.Location = New System.Drawing.Point(508, 38)
        Me.lblanggaran.Name = "lblanggaran"
        Me.lblanggaran.Size = New System.Drawing.Size(98, 13)
        Me.lblanggaran.TabIndex = 41
        Me.lblanggaran.Text = "Anggaran Bayaran "
        '
        'lblbakihari2
        '
        Me.lblbakihari2.AutoSize = True
        Me.lblbakihari2.BackColor = System.Drawing.Color.Transparent
        Me.lblbakihari2.Location = New System.Drawing.Point(782, 37)
        Me.lblbakihari2.Name = "lblbakihari2"
        Me.lblbakihari2.Size = New System.Drawing.Size(0, 13)
        Me.lblbakihari2.TabIndex = 53
        '
        'lbltempoh
        '
        Me.lbltempoh.AutoSize = True
        Me.lbltempoh.BackColor = System.Drawing.Color.Transparent
        Me.lbltempoh.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltempoh.Location = New System.Drawing.Point(484, 12)
        Me.lbltempoh.Name = "lbltempoh"
        Me.lbltempoh.Size = New System.Drawing.Size(166, 18)
        Me.lbltempoh.TabIndex = 40
        Me.lbltempoh.Text = "Tempoh Penggunaan"
        '
        'lblbakihari
        '
        Me.lblbakihari.AutoSize = True
        Me.lblbakihari.BackColor = System.Drawing.Color.Transparent
        Me.lblbakihari.Location = New System.Drawing.Point(723, 38)
        Me.lblbakihari.Name = "lblbakihari"
        Me.lblbakihari.Size = New System.Drawing.Size(53, 13)
        Me.lblbakihari.TabIndex = 52
        Me.lblbakihari.Text = "Baki Hari:"
        Me.lblbakihari.Visible = False
        '
        'lblpaid
        '
        Me.lblpaid.AutoSize = True
        Me.lblpaid.BackColor = System.Drawing.Color.Transparent
        Me.lblpaid.Location = New System.Drawing.Point(324, 38)
        Me.lblpaid.Name = "lblpaid"
        Me.lblpaid.Size = New System.Drawing.Size(78, 13)
        Me.lblpaid.TabIndex = 39
        Me.lblpaid.Text = "Bayaran Sejam"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(655, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 18)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = ":"
        '
        'lblstarttime
        '
        Me.lblstarttime.AutoSize = True
        Me.lblstarttime.BackColor = System.Drawing.Color.Transparent
        Me.lblstarttime.Location = New System.Drawing.Point(133, 38)
        Me.lblstarttime.Name = "lblstarttime"
        Me.lblstarttime.Size = New System.Drawing.Size(59, 13)
        Me.lblstarttime.TabIndex = 38
        Me.lblstarttime.Text = "Masa Mula"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(408, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 50
        '
        'lblnokp
        '
        Me.lblnokp.AutoSize = True
        Me.lblnokp.BackColor = System.Drawing.Color.Transparent
        Me.lblnokp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnokp.Location = New System.Drawing.Point(133, 15)
        Me.lblnokp.Name = "lblnokp"
        Me.lblnokp.Size = New System.Drawing.Size(125, 16)
        Me.lblnokp.TabIndex = 37
        Me.lblnokp.Text = "No KP Pengguna"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(200, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 49
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(266, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 16)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(811, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "00"
        Me.Label2.Visible = False
        '
        'lblKp
        '
        Me.lblKp.AutoSize = True
        Me.lblKp.BackColor = System.Drawing.Color.Transparent
        Me.lblKp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKp.Location = New System.Drawing.Point(284, 15)
        Me.lblKp.Name = "lblKp"
        Me.lblKp.Size = New System.Drawing.Size(0, 16)
        Me.lblKp.TabIndex = 42
        '
        'lblpayment
        '
        Me.lblpayment.AutoSize = True
        Me.lblpayment.BackColor = System.Drawing.Color.Transparent
        Me.lblpayment.Location = New System.Drawing.Point(612, 38)
        Me.lblpayment.Name = "lblpayment"
        Me.lblpayment.Size = New System.Drawing.Size(0, 13)
        Me.lblpayment.TabIndex = 46
        '
        'lblstartdate
        '
        Me.lblstartdate.AutoSize = True
        Me.lblstartdate.BackColor = System.Drawing.Color.Transparent
        Me.lblstartdate.Location = New System.Drawing.Point(216, 55)
        Me.lblstartdate.Name = "lblstartdate"
        Me.lblstartdate.Size = New System.Drawing.Size(0, 13)
        Me.lblstartdate.TabIndex = 43
        Me.lblstartdate.Visible = False
        '
        'lblcharge
        '
        Me.lblcharge.AutoSize = True
        Me.lblcharge.BackColor = System.Drawing.Color.Transparent
        Me.lblcharge.Location = New System.Drawing.Point(414, 38)
        Me.lblcharge.Name = "lblcharge"
        Me.lblcharge.Size = New System.Drawing.Size(0, 13)
        Me.lblcharge.TabIndex = 44
        '
        'lblduration
        '
        Me.lblduration.AutoSize = True
        Me.lblduration.BackColor = System.Drawing.Color.Transparent
        Me.lblduration.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblduration.Location = New System.Drawing.Point(673, 13)
        Me.lblduration.Name = "lblduration"
        Me.lblduration.Size = New System.Drawing.Size(0, 18)
        Me.lblduration.TabIndex = 45
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'WebBrowser
        '
        Me.WebBrowser.Location = New System.Drawing.Point(-1, 84)
        Me.WebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser.Name = "WebBrowser"
        Me.WebBrowser.Size = New System.Drawing.Size(964, 447)
        Me.WebBrowser.TabIndex = 38
        '
        'lblUsertype
        '
        Me.lblUsertype.AutoSize = True
        Me.lblUsertype.Location = New System.Drawing.Point(487, 54)
        Me.lblUsertype.Name = "lblUsertype"
        Me.lblUsertype.Size = New System.Drawing.Size(0, 13)
        Me.lblUsertype.TabIndex = 55
        '
        'frmMonitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CMSClientMysql.My.Resources.Resources.tile
        Me.ClientSize = New System.Drawing.Size(962, 500)
        Me.Controls.Add(Me.WebBrowser)
        Me.Controls.Add(Me.panelControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmMonitoring"
        Me.Text = "Monitoring"
        Me.panelControl.ResumeLayout(false)
        Me.panelControl.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents btnout As System.Windows.Forms.Button
    Friend WithEvents btnmin As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btninfo As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblservertime As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panelControl As System.Windows.Forms.Panel
    Friend WithEvents lblanggaran As System.Windows.Forms.Label
    Friend WithEvents lblbakihari2 As System.Windows.Forms.Label
    Friend WithEvents lbltempoh As System.Windows.Forms.Label
    Friend WithEvents lblbakihari As System.Windows.Forms.Label
    Friend WithEvents lblpaid As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblstarttime As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblnokp As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblKp As System.Windows.Forms.Label
    Friend WithEvents lblpayment As System.Windows.Forms.Label
    Friend WithEvents lblstartdate As System.Windows.Forms.Label
    Friend WithEvents lblcharge As System.Windows.Forms.Label
    Friend WithEvents lblduration As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents WebBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents lblVersionMonitoring As System.Windows.Forms.Label
    Friend WithEvents lblUsertype As System.Windows.Forms.Label

End Class
