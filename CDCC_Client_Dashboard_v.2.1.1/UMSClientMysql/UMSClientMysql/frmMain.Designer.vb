<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.PanelHelp = New System.Windows.Forms.Panel()
        Me.picOut = New System.Windows.Forms.PictureBox()
        Me.picInfo = New System.Windows.Forms.PictureBox()
        Me.PicMin = New System.Windows.Forms.PictureBox()
        Me.ntwkdisconn = New System.Windows.Forms.PictureBox()
        Me.ntwkconn = New System.Windows.Forms.PictureBox()
        Me.PicDB = New System.Windows.Forms.PictureBox()
        Me.PicDBx = New System.Windows.Forms.PictureBox()
        Me.PicChat = New System.Windows.Forms.PictureBox()
        Me.txtipserver = New System.Windows.Forms.TextBox()
        Me.lblIpsvr = New System.Windows.Forms.Label()
        Me.lblIpClient = New System.Windows.Forms.Label()
        Me.txtIpclient = New System.Windows.Forms.TextBox()
        Me.PicConn = New System.Windows.Forms.PictureBox()
        Me.PicDisconn = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lblmsg = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.cmbLanguage = New System.Windows.Forms.ComboBox()
        Me.txtIC = New System.Windows.Forms.TextBox()
        Me.lblKp = New System.Windows.Forms.Label()
        Me.panelLock = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblPCNo = New System.Windows.Forms.Label()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.lblPJK = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.timer_conn_server = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.PanelHelp.SuspendLayout()
        CType(Me.picOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ntwkdisconn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ntwkconn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDBx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicChat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicConn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDisconn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelLock.SuspendLayout()
        Me.PanelMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHelp
        '
        Me.PanelHelp.Controls.Add(Me.picOut)
        Me.PanelHelp.Controls.Add(Me.picInfo)
        Me.PanelHelp.Controls.Add(Me.PicMin)
        Me.PanelHelp.Controls.Add(Me.ntwkdisconn)
        Me.PanelHelp.Controls.Add(Me.ntwkconn)
        Me.PanelHelp.Controls.Add(Me.PicDB)
        Me.PanelHelp.Controls.Add(Me.PicDBx)
        Me.PanelHelp.Controls.Add(Me.PicChat)
        Me.PanelHelp.Controls.Add(Me.txtipserver)
        Me.PanelHelp.Controls.Add(Me.lblIpsvr)
        Me.PanelHelp.Controls.Add(Me.lblIpClient)
        Me.PanelHelp.Controls.Add(Me.txtIpclient)
        Me.PanelHelp.Controls.Add(Me.PicConn)
        Me.PanelHelp.Controls.Add(Me.PicDisconn)
        Me.PanelHelp.Controls.Add(Me.LinkLabel1)
        Me.PanelHelp.Location = New System.Drawing.Point(510, 12)
        Me.PanelHelp.Name = "PanelHelp"
        Me.PanelHelp.Size = New System.Drawing.Size(326, 52)
        Me.PanelHelp.TabIndex = 22
        Me.PanelHelp.Visible = False
        '
        'picOut
        '
        Me.picOut.Image = Global.UMSClientMysql.My.Resources.Resources.out
        Me.picOut.Location = New System.Drawing.Point(270, 12)
        Me.picOut.Name = "picOut"
        Me.picOut.Size = New System.Drawing.Size(38, 33)
        Me.picOut.TabIndex = 28
        Me.picOut.TabStop = False
        '
        'picInfo
        '
        Me.picInfo.Image = Global.UMSClientMysql.My.Resources.Resources.info1
        Me.picInfo.Location = New System.Drawing.Point(226, 12)
        Me.picInfo.Name = "picInfo"
        Me.picInfo.Size = New System.Drawing.Size(38, 33)
        Me.picInfo.TabIndex = 27
        Me.picInfo.TabStop = False
        '
        'PicMin
        '
        Me.PicMin.Image = Global.UMSClientMysql.My.Resources.Resources.minimize_icon1
        Me.PicMin.Location = New System.Drawing.Point(185, 12)
        Me.PicMin.Name = "PicMin"
        Me.PicMin.Size = New System.Drawing.Size(38, 33)
        Me.PicMin.TabIndex = 26
        Me.PicMin.TabStop = False
        '
        'ntwkdisconn
        '
        Me.ntwkdisconn.Image = CType(resources.GetObject("ntwkdisconn.Image"), System.Drawing.Image)
        Me.ntwkdisconn.Location = New System.Drawing.Point(57, 11)
        Me.ntwkdisconn.Name = "ntwkdisconn"
        Me.ntwkdisconn.Size = New System.Drawing.Size(39, 32)
        Me.ntwkdisconn.TabIndex = 18
        Me.ntwkdisconn.TabStop = False
        Me.ntwkdisconn.Visible = False
        '
        'ntwkconn
        '
        Me.ntwkconn.Image = CType(resources.GetObject("ntwkconn.Image"), System.Drawing.Image)
        Me.ntwkconn.Location = New System.Drawing.Point(57, 11)
        Me.ntwkconn.Name = "ntwkconn"
        Me.ntwkconn.Size = New System.Drawing.Size(39, 31)
        Me.ntwkconn.TabIndex = 17
        Me.ntwkconn.TabStop = False
        Me.ntwkconn.Visible = False
        '
        'PicDB
        '
        Me.PicDB.BackgroundImage = Global.UMSClientMysql.My.Resources.Resources.db
        Me.PicDB.Location = New System.Drawing.Point(101, 11)
        Me.PicDB.Name = "PicDB"
        Me.PicDB.Size = New System.Drawing.Size(33, 33)
        Me.PicDB.TabIndex = 24
        Me.PicDB.TabStop = False
        '
        'PicDBx
        '
        Me.PicDBx.BackgroundImage = CType(resources.GetObject("PicDBx.BackgroundImage"), System.Drawing.Image)
        Me.PicDBx.Location = New System.Drawing.Point(102, 10)
        Me.PicDBx.Name = "PicDBx"
        Me.PicDBx.Size = New System.Drawing.Size(33, 33)
        Me.PicDBx.TabIndex = 25
        Me.PicDBx.TabStop = False
        '
        'PicChat
        '
        Me.PicChat.Image = Global.UMSClientMysql.My.Resources.Resources.chat
        Me.PicChat.Location = New System.Drawing.Point(141, 11)
        Me.PicChat.Name = "PicChat"
        Me.PicChat.Size = New System.Drawing.Size(38, 33)
        Me.PicChat.TabIndex = 23
        Me.PicChat.TabStop = False
        '
        'txtipserver
        '
        Me.txtipserver.Enabled = False
        Me.txtipserver.Location = New System.Drawing.Point(76, 78)
        Me.txtipserver.Name = "txtipserver"
        Me.txtipserver.Size = New System.Drawing.Size(219, 20)
        Me.txtipserver.TabIndex = 21
        '
        'lblIpsvr
        '
        Me.lblIpsvr.AutoSize = True
        Me.lblIpsvr.Location = New System.Drawing.Point(3, 78)
        Me.lblIpsvr.Name = "lblIpsvr"
        Me.lblIpsvr.Size = New System.Drawing.Size(51, 13)
        Me.lblIpsvr.TabIndex = 20
        Me.lblIpsvr.Text = "Server IP"
        '
        'lblIpClient
        '
        Me.lblIpClient.AutoSize = True
        Me.lblIpClient.Location = New System.Drawing.Point(5, 57)
        Me.lblIpClient.Name = "lblIpClient"
        Me.lblIpClient.Size = New System.Drawing.Size(46, 13)
        Me.lblIpClient.TabIndex = 19
        Me.lblIpClient.Text = "Client IP"
        '
        'txtIpclient
        '
        Me.txtIpclient.Enabled = False
        Me.txtIpclient.Location = New System.Drawing.Point(75, 53)
        Me.txtIpclient.Name = "txtIpclient"
        Me.txtIpclient.Size = New System.Drawing.Size(220, 20)
        Me.txtIpclient.TabIndex = 15
        '
        'PicConn
        '
        Me.PicConn.Image = CType(resources.GetObject("PicConn.Image"), System.Drawing.Image)
        Me.PicConn.Location = New System.Drawing.Point(14, 11)
        Me.PicConn.Name = "PicConn"
        Me.PicConn.Size = New System.Drawing.Size(37, 31)
        Me.PicConn.TabIndex = 12
        Me.PicConn.TabStop = False
        '
        'PicDisconn
        '
        Me.PicDisconn.Image = CType(resources.GetObject("PicDisconn.Image"), System.Drawing.Image)
        Me.PicDisconn.Location = New System.Drawing.Point(14, 11)
        Me.PicDisconn.Name = "PicDisconn"
        Me.PicDisconn.Size = New System.Drawing.Size(34, 32)
        Me.PicDisconn.TabIndex = 13
        Me.PicDisconn.TabStop = False
        Me.PicDisconn.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Enabled = False
        Me.LinkLabel1.Location = New System.Drawing.Point(19, 101)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(90, 13)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Pendafatran Baru"
        '
        'lblmsg
        '
        Me.lblmsg.AutoSize = True
        Me.lblmsg.Enabled = False
        Me.lblmsg.ForeColor = System.Drawing.Color.Black
        Me.lblmsg.Location = New System.Drawing.Point(225, 165)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.Size = New System.Drawing.Size(10, 13)
        Me.lblmsg.TabIndex = 11
        Me.lblmsg.Text = "-"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(380, 142)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 9
        Me.btnLogin.Text = "Masuk"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'cmbLanguage
        '
        Me.cmbLanguage.FormattingEnabled = True
        Me.cmbLanguage.Location = New System.Drawing.Point(219, 113)
        Me.cmbLanguage.Name = "cmbLanguage"
        Me.cmbLanguage.Size = New System.Drawing.Size(121, 21)
        Me.cmbLanguage.TabIndex = 7
        '
        'txtIC
        '
        Me.txtIC.Location = New System.Drawing.Point(219, 142)
        Me.txtIC.MaxLength = 12
        Me.txtIC.Name = "txtIC"
        Me.txtIC.Size = New System.Drawing.Size(121, 20)
        Me.txtIC.TabIndex = 6
        '
        'lblKp
        '
        Me.lblKp.AutoSize = True
        Me.lblKp.BackColor = System.Drawing.Color.Transparent
        Me.lblKp.Location = New System.Drawing.Point(154, 142)
        Me.lblKp.Name = "lblKp"
        Me.lblKp.Size = New System.Drawing.Size(34, 13)
        Me.lblKp.TabIndex = 5
        Me.lblKp.Text = "NoKp"
        '
        'panelLock
        '
        Me.panelLock.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.panelLock.Controls.Add(Me.Label1)
        Me.panelLock.Location = New System.Drawing.Point(14, 177)
        Me.panelLock.Name = "panelLock"
        Me.panelLock.Size = New System.Drawing.Size(533, 69)
        Me.panelLock.TabIndex = 4
        Me.panelLock.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(108, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORM LOCKED!"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblPCNo
        '
        Me.lblPCNo.AutoSize = True
        Me.lblPCNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPCNo.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblPCNo.Location = New System.Drawing.Point(269, 79)
        Me.lblPCNo.Name = "lblPCNo"
        Me.lblPCNo.Size = New System.Drawing.Size(53, 22)
        Me.lblPCNo.TabIndex = 23
        Me.lblPCNo.Text = "pcno"
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.Color.Transparent
        Me.PanelMain.Controls.Add(Me.lblPJK)
        Me.PanelMain.Controls.Add(Me.lblPCNo)
        Me.PanelMain.Controls.Add(Me.panelLock)
        Me.PanelMain.Controls.Add(Me.txtIC)
        Me.PanelMain.Controls.Add(Me.btnLogin)
        Me.PanelMain.Controls.Add(Me.cmbLanguage)
        Me.PanelMain.Controls.Add(Me.lblKp)
        Me.PanelMain.Controls.Add(Me.lblmsg)
        Me.PanelMain.Location = New System.Drawing.Point(227, 334)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(566, 258)
        Me.PanelMain.TabIndex = 0
        '
        'lblPJK
        '
        Me.lblPJK.AutoSize = True
        Me.lblPJK.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPJK.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblPJK.Location = New System.Drawing.Point(236, 51)
        Me.lblPJK.Name = "lblPJK"
        Me.lblPJK.Size = New System.Drawing.Size(36, 22)
        Me.lblPJK.TabIndex = 24
        Me.lblPJK.Text = "pjk"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(760, 110)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 23)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "test"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(760, 163)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(52, 23)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'BackgroundWorker1
        '
        '
        'timer_conn_server
        '
        Me.timer_conn_server.Interval = 1000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImage = Global.UMSClientMysql.My.Resources.Resources.ums_contoh3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(964, 604)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.PanelHelp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "UMS Client "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelHelp.ResumeLayout(False)
        Me.PanelHelp.PerformLayout()
        CType(Me.picOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ntwkdisconn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ntwkconn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDBx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicChat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicConn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDisconn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelLock.ResumeLayout(False)
        Me.panelLock.PerformLayout()
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelLock As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PanelHelp As System.Windows.Forms.Panel
    Friend WithEvents txtipserver As System.Windows.Forms.TextBox
    Friend WithEvents lblIpsvr As System.Windows.Forms.Label
    Friend WithEvents lblIpClient As System.Windows.Forms.Label
    Friend WithEvents ntwkconn As System.Windows.Forms.PictureBox
    Friend WithEvents ntwkdisconn As System.Windows.Forms.PictureBox
    Friend WithEvents txtIpclient As System.Windows.Forms.TextBox
    Friend WithEvents PicConn As System.Windows.Forms.PictureBox
    Friend WithEvents PicDisconn As System.Windows.Forms.PictureBox
    Friend WithEvents lblmsg As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents cmbLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents txtIC As System.Windows.Forms.TextBox
    Friend WithEvents lblKp As System.Windows.Forms.Label
    Friend WithEvents PicChat As System.Windows.Forms.PictureBox
    Friend WithEvents lblPCNo As System.Windows.Forms.Label
    Friend WithEvents PanelMain As System.Windows.Forms.Panel
    Friend WithEvents PicDB As System.Windows.Forms.PictureBox
    Friend WithEvents PicDBx As System.Windows.Forms.PictureBox
    Friend WithEvents lblPJK As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents timer_conn_server As System.Windows.Forms.Timer
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents PicMin As System.Windows.Forms.PictureBox
    Friend WithEvents picInfo As System.Windows.Forms.PictureBox
    Friend WithEvents picOut As System.Windows.Forms.PictureBox
End Class
