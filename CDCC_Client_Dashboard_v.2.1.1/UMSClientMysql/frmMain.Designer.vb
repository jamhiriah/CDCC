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
        Me.ntwkconn = New System.Windows.Forms.PictureBox()
        Me.PicDB = New System.Windows.Forms.PictureBox()
        Me.ntwkdisconn = New System.Windows.Forms.PictureBox()
        Me.PicDBx = New System.Windows.Forms.PictureBox()
        Me.PicChat = New System.Windows.Forms.PictureBox()
        Me.txtipserver = New System.Windows.Forms.TextBox()
        Me.lblIpsvr = New System.Windows.Forms.Label()
        Me.lblIpClient = New System.Windows.Forms.Label()
        Me.txtIpclient = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PicConnx = New System.Windows.Forms.PictureBox()
        Me.PicPanelClose = New System.Windows.Forms.PictureBox()
        Me.PicErrorlog = New System.Windows.Forms.PictureBox()
        Me.picOut = New System.Windows.Forms.PictureBox()
        Me.picInfo = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.timer_conn_server = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtIC = New System.Windows.Forms.TextBox()
        Me.PicFTP = New System.Windows.Forms.PictureBox()
        Me.PicMin = New System.Windows.Forms.PictureBox()
        Me.pictaskmgr = New System.Windows.Forms.PictureBox()
        Me.Picregedit = New System.Windows.Forms.PictureBox()
        Me.PicConn = New System.Windows.Forms.PictureBox()
        Me.picautorun = New System.Windows.Forms.PictureBox()
        Me.lblmsg = New System.Windows.Forms.Label()
        Me.lblKp = New System.Windows.Forms.Label()
        Me.cmbLanguage = New System.Windows.Forms.ComboBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.panelLock = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPCNo = New System.Windows.Forms.Label()
        Me.lblPJK = New System.Windows.Forms.Label()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lbllock = New System.Windows.Forms.Label()
        Me.panelmaintenance = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.timerdb = New System.Windows.Forms.Timer(Me.components)
        Me.lblinside = New System.Windows.Forms.Label()
        Me.HaltTime = New System.Windows.Forms.Timer(Me.components)
        Me.timerCloseBrowser = New System.Windows.Forms.Timer(Me.components)
        Me.PanelHelp.SuspendLayout
        CType(Me.ntwkconn,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PicDB,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ntwkdisconn,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PicDBx,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PicChat,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PicConnx,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PicPanelClose,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PicErrorlog,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.picOut,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.picInfo,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PicFTP,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PicMin,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pictaskmgr,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Picregedit,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PicConn,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.picautorun,System.ComponentModel.ISupportInitialize).BeginInit
        Me.panelLock.SuspendLayout
        Me.PanelMain.SuspendLayout
        Me.panelmaintenance.SuspendLayout
        Me.SuspendLayout
        '
        'PanelHelp
        '
        Me.PanelHelp.Controls.Add(Me.ntwkconn)
        Me.PanelHelp.Controls.Add(Me.PicDB)
        Me.PanelHelp.Controls.Add(Me.ntwkdisconn)
        Me.PanelHelp.Controls.Add(Me.PicDBx)
        Me.PanelHelp.Controls.Add(Me.PicChat)
        Me.PanelHelp.Controls.Add(Me.txtipserver)
        Me.PanelHelp.Controls.Add(Me.lblIpsvr)
        Me.PanelHelp.Controls.Add(Me.lblIpClient)
        Me.PanelHelp.Controls.Add(Me.txtIpclient)
        Me.PanelHelp.Controls.Add(Me.LinkLabel1)
        Me.PanelHelp.Location = New System.Drawing.Point(89, 6)
        Me.PanelHelp.Name = "PanelHelp"
        Me.PanelHelp.Size = New System.Drawing.Size(138, 52)
        Me.PanelHelp.TabIndex = 22
        '
        'ntwkconn
        '
        Me.ntwkconn.Image = Global.CMSClientMysql.My.Resources.Resources.pc
        Me.ntwkconn.Location = New System.Drawing.Point(13, 10)
        Me.ntwkconn.Name = "ntwkconn"
        Me.ntwkconn.Size = New System.Drawing.Size(39, 31)
        Me.ntwkconn.TabIndex = 17
        Me.ntwkconn.TabStop = false
        Me.ToolTip1.SetToolTip(Me.ntwkconn, "Pelayan chat berjaya dihubungi"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Chat server connected")
        Me.ntwkconn.Visible = false
        '
        'PicDB
        '
        Me.PicDB.BackgroundImage = Global.CMSClientMysql.My.Resources.Resources.db
        Me.PicDB.Image = Global.CMSClientMysql.My.Resources.Resources.database
        Me.PicDB.Location = New System.Drawing.Point(57, 10)
        Me.PicDB.Name = "PicDB"
        Me.PicDB.Size = New System.Drawing.Size(33, 33)
        Me.PicDB.TabIndex = 24
        Me.PicDB.TabStop = false
        Me.ToolTip1.SetToolTip(Me.PicDB, "Pangkalan data berjaya dihubungi"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Database connected")
        '
        'ntwkdisconn
        '
        Me.ntwkdisconn.Image = Global.CMSClientMysql.My.Resources.Resources.pcoff
        Me.ntwkdisconn.Location = New System.Drawing.Point(12, 9)
        Me.ntwkdisconn.Name = "ntwkdisconn"
        Me.ntwkdisconn.Size = New System.Drawing.Size(39, 32)
        Me.ntwkdisconn.TabIndex = 18
        Me.ntwkdisconn.TabStop = false
        Me.ToolTip1.SetToolTip(Me.ntwkdisconn, "Pelayan chat tidak dapat dihubungi"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Chat server disconnected")
        Me.ntwkdisconn.Visible = false
        '
        'PicDBx
        '
        Me.PicDBx.BackgroundImage = CType(resources.GetObject("PicDBx.BackgroundImage"),System.Drawing.Image)
        Me.PicDBx.Image = Global.CMSClientMysql.My.Resources.Resources.databaseoff
        Me.PicDBx.Location = New System.Drawing.Point(57, 10)
        Me.PicDBx.Name = "PicDBx"
        Me.PicDBx.Size = New System.Drawing.Size(33, 33)
        Me.PicDBx.TabIndex = 25
        Me.PicDBx.TabStop = false
        Me.ToolTip1.SetToolTip(Me.PicDBx, "Pangkalan data tidak dapat dihubungi"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Database disconnected")
        '
        'PicChat
        '
        Me.PicChat.Image = Global.CMSClientMysql.My.Resources.Resources.chat
        Me.PicChat.Location = New System.Drawing.Point(96, 9)
        Me.PicChat.Name = "PicChat"
        Me.PicChat.Size = New System.Drawing.Size(38, 33)
        Me.PicChat.TabIndex = 23
        Me.PicChat.TabStop = false
        Me.ToolTip1.SetToolTip(Me.PicChat, "Berkomunikasi bersama admin"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Talk to admin")
        '
        'txtipserver
        '
        Me.txtipserver.Enabled = false
        Me.txtipserver.Location = New System.Drawing.Point(76, 78)
        Me.txtipserver.Name = "txtipserver"
        Me.txtipserver.Size = New System.Drawing.Size(219, 20)
        Me.txtipserver.TabIndex = 21
        '
        'lblIpsvr
        '
        Me.lblIpsvr.AutoSize = true
        Me.lblIpsvr.Location = New System.Drawing.Point(3, 78)
        Me.lblIpsvr.Name = "lblIpsvr"
        Me.lblIpsvr.Size = New System.Drawing.Size(51, 13)
        Me.lblIpsvr.TabIndex = 20
        Me.lblIpsvr.Text = "Server IP"
        '
        'lblIpClient
        '
        Me.lblIpClient.AutoSize = true
        Me.lblIpClient.Location = New System.Drawing.Point(5, 57)
        Me.lblIpClient.Name = "lblIpClient"
        Me.lblIpClient.Size = New System.Drawing.Size(46, 13)
        Me.lblIpClient.TabIndex = 19
        Me.lblIpClient.Text = "Client IP"
        '
        'txtIpclient
        '
        Me.txtIpclient.Enabled = false
        Me.txtIpclient.Location = New System.Drawing.Point(75, 53)
        Me.txtIpclient.Name = "txtIpclient"
        Me.txtIpclient.Size = New System.Drawing.Size(220, 20)
        Me.txtIpclient.TabIndex = 15
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = true
        Me.LinkLabel1.Enabled = false
        Me.LinkLabel1.Location = New System.Drawing.Point(19, 101)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(90, 13)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = true
        Me.LinkLabel1.Text = "Pendafatran Baru"
        '
        'PicConnx
        '
        Me.PicConnx.Image = Global.CMSClientMysql.My.Resources.Resources.notconnected
        Me.PicConnx.Location = New System.Drawing.Point(316, 13)
        Me.PicConnx.Name = "PicConnx"
        Me.PicConnx.Size = New System.Drawing.Size(37, 31)
        Me.PicConnx.TabIndex = 12
        Me.PicConnx.TabStop = false
        Me.ToolTip1.SetToolTip(Me.PicConnx, "Semak Internet "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Check Internet connection")
        '
        'PicPanelClose
        '
        Me.PicPanelClose.Image = Global.CMSClientMysql.My.Resources.Resources.close2
        Me.PicPanelClose.Location = New System.Drawing.Point(182, 9)
        Me.PicPanelClose.Name = "PicPanelClose"
        Me.PicPanelClose.Size = New System.Drawing.Size(38, 33)
        Me.PicPanelClose.TabIndex = 34
        Me.PicPanelClose.TabStop = false
        Me.ToolTip1.SetToolTip(Me.PicPanelClose, "Tutup panel"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Panel close")
        '
        'PicErrorlog
        '
        Me.PicErrorlog.Image = Global.CMSClientMysql.My.Resources.Resources.folderkesalahan
        Me.PicErrorlog.Location = New System.Drawing.Point(226, 10)
        Me.PicErrorlog.Name = "PicErrorlog"
        Me.PicErrorlog.Size = New System.Drawing.Size(38, 33)
        Me.PicErrorlog.TabIndex = 33
        Me.PicErrorlog.TabStop = false
        Me.ToolTip1.SetToolTip(Me.PicErrorlog, "Buka folder kesalahan"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Open error log folder")
        '
        'picOut
        '
        Me.picOut.Image = Global.CMSClientMysql.My.Resources.Resources.close
        Me.picOut.Location = New System.Drawing.Point(396, 11)
        Me.picOut.Name = "picOut"
        Me.picOut.Size = New System.Drawing.Size(38, 33)
        Me.picOut.TabIndex = 28
        Me.picOut.TabStop = false
        Me.ToolTip1.SetToolTip(Me.picOut, "Keluar dari aplikasi "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Logout from application")
        '
        'picInfo
        '
        Me.picInfo.Image = Global.CMSClientMysql.My.Resources.Resources.setting
        Me.picInfo.Location = New System.Drawing.Point(12, 8)
        Me.picInfo.Name = "picInfo"
        Me.picInfo.Size = New System.Drawing.Size(38, 33)
        Me.picInfo.TabIndex = 27
        Me.picInfo.TabStop = false
        Me.ToolTip1.SetToolTip(Me.picInfo, "Tetapan Ip & Pc"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Pc and Ip setting")
        '
        'Timer1
        '
        Me.Timer1.Interval = 15000
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
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"),System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        '
        'txtIC
        '
        Me.txtIC.Location = New System.Drawing.Point(219, 142)
        Me.txtIC.MaxLength = 20
        Me.txtIC.Name = "txtIC"
        Me.txtIC.Size = New System.Drawing.Size(121, 20)
        Me.txtIC.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtIC, "Masukkan kata pengenalan diri"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Please insert your id")
        '
        'PicFTP
        '
        Me.PicFTP.Image = Global.CMSClientMysql.My.Resources.Resources.folder
        Me.PicFTP.Location = New System.Drawing.Point(270, 10)
        Me.PicFTP.Name = "PicFTP"
        Me.PicFTP.Size = New System.Drawing.Size(38, 33)
        Me.PicFTP.TabIndex = 34
        Me.PicFTP.TabStop = false
        Me.ToolTip1.SetToolTip(Me.PicFTP, "Buka folder ftp"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Open ftp folder")
        '
        'PicMin
        '
        Me.PicMin.Image = Global.CMSClientMysql.My.Resources.Resources.minimize
        Me.PicMin.Location = New System.Drawing.Point(354, 11)
        Me.PicMin.Name = "PicMin"
        Me.PicMin.Size = New System.Drawing.Size(38, 33)
        Me.PicMin.TabIndex = 26
        Me.PicMin.TabStop = false
        Me.ToolTip1.SetToolTip(Me.PicMin, "Kecilkan"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Minimize")
        '
        'pictaskmgr
        '
        Me.pictaskmgr.Image = Global.CMSClientMysql.My.Resources.Resources.taskmanager
        Me.pictaskmgr.Location = New System.Drawing.Point(56, 9)
        Me.pictaskmgr.Name = "pictaskmgr"
        Me.pictaskmgr.Size = New System.Drawing.Size(38, 33)
        Me.pictaskmgr.TabIndex = 35
        Me.pictaskmgr.TabStop = false
        Me.ToolTip1.SetToolTip(Me.pictaskmgr, "Task manager"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Enable Task manager")
        '
        'Picregedit
        '
        Me.Picregedit.Image = Global.CMSClientMysql.My.Resources.Resources.registryedit
        Me.Picregedit.Location = New System.Drawing.Point(97, 9)
        Me.Picregedit.Name = "Picregedit"
        Me.Picregedit.Size = New System.Drawing.Size(38, 33)
        Me.Picregedit.TabIndex = 36
        Me.Picregedit.TabStop = false
        Me.ToolTip1.SetToolTip(Me.Picregedit, "Regedit"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Enable regedit")
        '
        'PicConn
        '
        Me.PicConn.Image = Global.CMSClientMysql.My.Resources.Resources.connected
        Me.PicConn.Location = New System.Drawing.Point(314, 9)
        Me.PicConn.Name = "PicConn"
        Me.PicConn.Size = New System.Drawing.Size(36, 38)
        Me.PicConn.TabIndex = 37
        Me.PicConn.TabStop = false
        Me.ToolTip1.SetToolTip(Me.PicConn, "Semak Internet "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Check Internet connection")
        '
        'picautorun
        '
        Me.picautorun.Image = Global.CMSClientMysql.My.Resources.Resources.run_auto
        Me.picautorun.Location = New System.Drawing.Point(140, 11)
        Me.picautorun.Name = "picautorun"
        Me.picautorun.Size = New System.Drawing.Size(38, 32)
        Me.picautorun.TabIndex = 38
        Me.picautorun.TabStop = false
        Me.ToolTip1.SetToolTip(Me.picautorun, "Set Autorun")
        '
        'lblmsg
        '
        Me.lblmsg.AutoSize = true
        Me.lblmsg.Enabled = false
        Me.lblmsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblmsg.ForeColor = System.Drawing.Color.Red
        Me.lblmsg.Location = New System.Drawing.Point(225, 165)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.Size = New System.Drawing.Size(11, 13)
        Me.lblmsg.TabIndex = 11
        Me.lblmsg.Text = "-"
        '
        'lblKp
        '
        Me.lblKp.AutoSize = true
        Me.lblKp.BackColor = System.Drawing.Color.Transparent
        Me.lblKp.Location = New System.Drawing.Point(154, 142)
        Me.lblKp.Name = "lblKp"
        Me.lblKp.Size = New System.Drawing.Size(34, 13)
        Me.lblKp.TabIndex = 5
        Me.lblKp.Text = "NoKp"
        '
        'cmbLanguage
        '
        Me.cmbLanguage.FormattingEnabled = true
        Me.cmbLanguage.Location = New System.Drawing.Point(219, 113)
        Me.cmbLanguage.Name = "cmbLanguage"
        Me.cmbLanguage.Size = New System.Drawing.Size(121, 21)
        Me.cmbLanguage.TabIndex = 7
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(380, 142)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 9
        Me.btnLogin.Text = "Masuk"
        Me.btnLogin.UseVisualStyleBackColor = true
        '
        'panelLock
        '
        Me.panelLock.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(128,Byte),Integer))
        Me.panelLock.Controls.Add(Me.Label1)
        Me.panelLock.Location = New System.Drawing.Point(0, 122)
        Me.panelLock.Name = "panelLock"
        Me.panelLock.Size = New System.Drawing.Size(566, 127)
        Me.panelLock.TabIndex = 4
        Me.panelLock.Visible = false
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(209, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORM LOCKED!"
        '
        'lblPCNo
        '
        Me.lblPCNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblPCNo.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblPCNo.Location = New System.Drawing.Point(3, 73)
        Me.lblPCNo.Name = "lblPCNo"
        Me.lblPCNo.Size = New System.Drawing.Size(560, 22)
        Me.lblPCNo.TabIndex = 23
        Me.lblPCNo.Text = "pcno"
        Me.lblPCNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPJK
        '
        Me.lblPJK.Font = New System.Drawing.Font("Microsoft Sans Serif", 13!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblPJK.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblPJK.Location = New System.Drawing.Point(3, 51)
        Me.lblPJK.Name = "lblPJK"
        Me.lblPJK.Size = New System.Drawing.Size(560, 22)
        Me.lblPJK.TabIndex = 24
        Me.lblPJK.Text = "Site name unavailable"
        Me.lblPJK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.Color.Transparent
        Me.PanelMain.Controls.Add(Me.lblVersion)
        Me.PanelMain.Controls.Add(Me.lbllock)
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
        'lblVersion
        '
        Me.lblVersion.AutoSize = true
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.ForeColor = System.Drawing.Color.Coral
        Me.lblVersion.Location = New System.Drawing.Point(260, 241)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(41, 13)
        Me.lblVersion.TabIndex = 33
        Me.lblVersion.Text = "V 2.1.1"
        '
        'lbllock
        '
        Me.lbllock.Font = New System.Drawing.Font("Microsoft Sans Serif", 13!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbllock.ForeColor = System.Drawing.Color.Red
        Me.lbllock.Location = New System.Drawing.Point(3, 122)
        Me.lbllock.Name = "lbllock"
        Me.lbllock.Size = New System.Drawing.Size(560, 22)
        Me.lbllock.TabIndex = 25
        Me.lbllock.Text = "Lock"
        Me.lbllock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbllock.Visible = false
        '
        'panelmaintenance
        '
        Me.panelmaintenance.Controls.Add(Me.picautorun)
        Me.panelmaintenance.Controls.Add(Me.PicConn)
        Me.panelmaintenance.Controls.Add(Me.Picregedit)
        Me.panelmaintenance.Controls.Add(Me.pictaskmgr)
        Me.panelmaintenance.Controls.Add(Me.PicConnx)
        Me.panelmaintenance.Controls.Add(Me.PicFTP)
        Me.panelmaintenance.Controls.Add(Me.PicMin)
        Me.panelmaintenance.Controls.Add(Me.PicPanelClose)
        Me.panelmaintenance.Controls.Add(Me.picInfo)
        Me.panelmaintenance.Controls.Add(Me.PicErrorlog)
        Me.panelmaintenance.Controls.Add(Me.TextBox1)
        Me.panelmaintenance.Controls.Add(Me.Label3)
        Me.panelmaintenance.Controls.Add(Me.Label4)
        Me.panelmaintenance.Controls.Add(Me.picOut)
        Me.panelmaintenance.Controls.Add(Me.TextBox2)
        Me.panelmaintenance.Controls.Add(Me.LinkLabel2)
        Me.panelmaintenance.Location = New System.Drawing.Point(401, 6)
        Me.panelmaintenance.Name = "panelmaintenance"
        Me.panelmaintenance.Size = New System.Drawing.Size(450, 52)
        Me.panelmaintenance.TabIndex = 31
        Me.panelmaintenance.Visible = false
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = false
        Me.TextBox1.Location = New System.Drawing.Point(76, 78)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(219, 20)
        Me.TextBox1.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(3, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Server IP"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(5, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Client IP"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = false
        Me.TextBox2.Location = New System.Drawing.Point(75, 53)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(220, 20)
        Me.TextBox2.TabIndex = 15
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = true
        Me.LinkLabel2.Enabled = false
        Me.LinkLabel2.Location = New System.Drawing.Point(19, 101)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(90, 13)
        Me.LinkLabel2.TabIndex = 8
        Me.LinkLabel2.TabStop = true
        Me.LinkLabel2.Text = "Pendafatran Baru"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'timerdb
        '
        '
        'lblinside
        '
        Me.lblinside.BackColor = System.Drawing.Color.Transparent
        Me.lblinside.Enabled = false
        Me.lblinside.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblinside.Location = New System.Drawing.Point(726, 135)
        Me.lblinside.Name = "lblinside"
        Me.lblinside.Size = New System.Drawing.Size(50, 100)
        Me.lblinside.TabIndex = 38
        '
        'HaltTime
        '
        '
        'timerCloseBrowser
        '
        Me.timerCloseBrowser.Interval = 2000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.CMSClientMysql.My.Resources.Resources.cms_client
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1015, 604)
        Me.ControlBox = false
        Me.Controls.Add(Me.lblinside)
        Me.Controls.Add(Me.panelmaintenance)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.PanelHelp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmMain"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.Text = "UMS Client "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelHelp.ResumeLayout(false)
        Me.PanelHelp.PerformLayout
        CType(Me.ntwkconn,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicDB,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ntwkdisconn,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicDBx,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicChat,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicConnx,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicPanelClose,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicErrorlog,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picOut,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picInfo,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicFTP,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicMin,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pictaskmgr,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Picregedit,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicConn,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picautorun,System.ComponentModel.ISupportInitialize).EndInit
        Me.panelLock.ResumeLayout(false)
        Me.panelLock.PerformLayout
        Me.PanelMain.ResumeLayout(false)
        Me.PanelMain.PerformLayout
        Me.panelmaintenance.ResumeLayout(false)
        Me.panelmaintenance.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PanelHelp As System.Windows.Forms.Panel
    Friend WithEvents txtipserver As System.Windows.Forms.TextBox
    Friend WithEvents lblIpsvr As System.Windows.Forms.Label
    Friend WithEvents lblIpClient As System.Windows.Forms.Label
    Friend WithEvents ntwkconn As System.Windows.Forms.PictureBox
    Friend WithEvents ntwkdisconn As System.Windows.Forms.PictureBox
    Friend WithEvents txtIpclient As System.Windows.Forms.TextBox
    Friend WithEvents PicConnx As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents PicChat As System.Windows.Forms.PictureBox
    Friend WithEvents PicDB As System.Windows.Forms.PictureBox
    Friend WithEvents PicDBx As System.Windows.Forms.PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents timer_conn_server As System.Windows.Forms.Timer
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents picInfo As System.Windows.Forms.PictureBox
    Friend WithEvents picOut As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PicErrorlog As System.Windows.Forms.PictureBox
    Friend WithEvents PicPanelClose As System.Windows.Forms.PictureBox
    Friend WithEvents lblmsg As System.Windows.Forms.Label
    Friend WithEvents lblKp As System.Windows.Forms.Label
    Friend WithEvents cmbLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents txtIC As System.Windows.Forms.TextBox
    Friend WithEvents panelLock As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPCNo As System.Windows.Forms.Label
    Friend WithEvents lblPJK As System.Windows.Forms.Label
    Friend WithEvents PanelMain As System.Windows.Forms.Panel
    Friend WithEvents lbllock As System.Windows.Forms.Label
    Friend WithEvents panelmaintenance As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PicFTP As System.Windows.Forms.PictureBox
    Friend WithEvents PicMin As System.Windows.Forms.PictureBox
    Friend WithEvents pictaskmgr As System.Windows.Forms.PictureBox
    Friend WithEvents Picregedit As System.Windows.Forms.PictureBox
    Friend WithEvents timerdb As System.Windows.Forms.Timer
    Friend WithEvents picautorun As System.Windows.Forms.PictureBox
    Friend WithEvents PicConn As System.Windows.Forms.PictureBox
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblinside As System.Windows.Forms.Label
    Friend WithEvents HaltTime As System.Windows.Forms.Timer
    Friend WithEvents timerCloseBrowser As System.Windows.Forms.Timer
End Class
