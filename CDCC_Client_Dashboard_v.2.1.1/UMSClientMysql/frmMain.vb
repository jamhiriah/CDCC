
Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.ComponentModel.Component
Imports System.Drawing

Public Class frmMain

    Private intCounter As Integer = 0
    Dim titlebm As String = "Keluar"
    Dim titlebi As String = "Exit"
    Private strApprefms As String = ""
    Public flag As Integer = 0
    Public recheck As Integer = 0
    Dim intTimerType As Integer = 0

    Private Sub frmMain_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtIC.Text = ""
        lblmsg.Text = ""
    End Sub

    Public Sub logoutWeb()

        'frmMonitoring.WebBrowser.Document.
        'frmMonitoring.WebBrowser.Navigate(New uri("http://dashboard-test.pi1m.my/#/home")) 

        frmMonitoring.WebBrowser.Refresh
             
    End Sub

    Public Sub cekLockSetting()
        dr = dbRead("SELECT * FROM settings")
        Dim lockPc As String

        Do While dr.Read()
            lockPc = dr.Item("lock_client").ToString
        Loop


        If lockPc = "0" Then


            If lbllock.Visible = True Then
                doUnLock()
                appStatus = 1
            Else

            End If
        'closing and reopening CMSclient may cause delay in database update
        ElseIf lockPc = "1" Then

            If lbllock.Visible = True Then

            Else
                doLock()
                appStatus = 3
            End If

          

        End If

    End Sub


    Public Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        strApprefms = CheckForShortcut() ' to get location of application manifest file
        ' RunAtStartup(Application.ProductName, Application.ExecutablePath)
        RunAtStartup(Application.ProductName, strApprefms) ' pass product name and manifest file location to be registered at startup registry

        PanelMain.Left = (My.Computer.Screen.WorkingArea.Width / 2) - (PanelMain.Width / 2)
        PanelMain.Top = (My.Computer.Screen.WorkingArea.Height / 2) - (PanelMain.Height / 2) + 200 '//-anbEdit

        Me.TopMost = DeploymentFlag

        frmServerconn.Enabled = False
        Try
            'EnableRegedit()
            'DisableTaskManager()
            'Disableshutdown()
            'Disablechangepassword()
            'Disablelock()
            'Disablelogoff()
            'Disableswitchuser()
        Catch ex As Exception
            ' MsgBox(ex.Message, MsgBoxStyle.Critical, "UAC/registry error")
        End Try

        'regedit on  test pc without regedit installer: 
        'Dim strRegKey As String = "\SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION"
        'Dim strRegKey64 As String = "\SOFTWARE\Wow6432Node\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION"
        'Dim strRegName As String = "CMSClientMysql.exe"
        'Dim strRegValue As Decimal = 11001

        'Try
        '    'My.Computer.Registry.LocalMachine.CreateSubKey()
        '    My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE" & strRegKey, strRegName, strRegValue, Microsoft.Win32.RegistryValueKind.DWord)
        '    My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE" & strRegKey64, strRegName, strRegValue, Microsoft.Win32.RegistryValueKind.DWord)
        '    My.Computer.Registry.SetValue("HKEY_CURRENT_USER" & strRegKey, strRegName, strRegValue, Microsoft.Win32.RegistryValueKind.DWord)
        '    My.Computer.Registry.SetValue("HKEY_CURRENT_USER" & strRegKey64, strRegName, strRegValue, Microsoft.Win32.RegistryValueKind.DWord)
        'Catch err As Exception
        '    MsgBox(err.Message.ToString)
        'End Try

        'KillExplorer()

        'PanelMain.Left = (My.Computer.Screen.WorkingArea.Width / 2) - (PanelMain.Width / 2)
        'PanelMain.Top = (My.Computer.Screen.WorkingArea.Height / 2) - (PanelMain.Height / 2) + 200 '//-anbEdit


        HookKeyboard()

        ' set lbl
        lblinside.Top = Me.Height / 2
        lblinside.Left = Me.Width / 2
        lblinside.BringToFront()


        lblinside.ForeColor = Color.LightGray


        Me.cmbLanguage.Items.Insert(0, "Bahasa Melayu")
        Me.cmbLanguage.Items.Insert(1, "English")


        Me.cmbLanguage.SelectedItem = "Bahasa Melayu"
        lgId = 1

        appStatus = 1

        'Public recheck As Integer = 0



        Do While recheck < 5

            Dim myFileName = fullpath + "\" & FileName

            If System.IO.File.Exists(myFileName) Then
                GetPCsetting(myFileName) '// read setting from the file
                lockMe(True) '// check server setting nak lock atau tidak **

                'If modMain.svflag = 1 Then
                If GetSystemName() = "ERROR" Then
                    '  lblmsg.Text = "Connection Fai led"

                    PicDBx.Visible = True
                    PicDB.Visible = False

                    'Exit Sub

                Else
                    '  lblmsg.Text = "Connection Successfull"
                    PicDBx.Visible = False
                    PicDB.Visible = True

                    lblPJK.Text = GetSystemName()
                    SiteCode = GetSiteCode()
                    cekLockSetting()
                    recheck = 5

                End If
                'End If


                If flag = 0 Then
                    If recheck = 4 Then

                        If lblPJK.Text = "Site name unavailable" Or lblPCNo.Text = "" Or lblPCNo.Text = " " Then
                            frmServerconn.Enabled = True
                            flag = 1
                            If lgId = 1 Then
                                MsgBox("Sila semak tetapan IP")
                                frmServerconn.lblmsg.Text = "Sila semak server IP"
                            Else
                                MsgBox("Please check setting")
                                frmServerconn.lblmsg.Text = "Server IP is wrongly set"
                            End If


                            'Me.SendToBack()
                            recheck = recheck + 1
                            Exit Sub

                        End If
                    Else
                        recheck = recheck + 1
                    End If

                End If
            Else
                If recheck = 4 Then
                    flag = 1
                    frmServerconn.Enabled = True
                    If lgId = 1 Then
                        MsgBox("Sila semak tetapan IP")
                        frmServerconn.lblmsg.Text = "Sila semak server IP"
                    Else
                        MsgBox("Please check setting")
                        frmServerconn.lblmsg.Text = "Server IP is wrongly set"
                    End If
                    recheck = recheck + 1
                    'Me.SendToBack()

                    If lblmsg.Text = "Connection Successfull" Then
                        'Timer1_Tick()
                        'Timer1.Enabled = True
                    End If

                    Exit Sub
                Else
                    recheck = recheck + 1
                End If

            End If

        Loop

        If frmServerconn.Enabled = False Then

            'logout previous user
            logoutPreviousUser()


            Timer1_Tick()
            Timer1.Enabled = True


            ' Getconnected() ' 1st attepmt
            If Getconnected() = True Then
                ntwkdisconn.Visible = False
                ntwkconn.Visible = True
            Else
                ntwkdisconn.Visible = True
                ntwkconn.Visible = False
            End If


            '   IsDBAvailable() '1st attempt

            '// set autorun at startup
            Dim regKey As Object = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True).GetValue("CMS Client")
            strApprefms = CheckForShortcut() ' to get location of application manifest file
            If regKey Is Nothing Or regKey.ToString <> strApprefms Then
                RunAtStartup(Application.ProductName, strApprefms) ' pass product name and manifest file location to be registered at startup registry
                'MsgBox("Autostart CMS Client Set")
            End If

            'check db
            ' '' ''If IsDBAvailable() = False Then             '//for database server connection


        End If

        'tutup dulu sbb ade dlm timer1 knp 2 kali?
        timer_conn_server.Interval = 30000  '//anb: hang bila nk connect to chat server    
        timer_conn_server.Enabled = True


        timerdb.Interval = 30000
        timerdb.Enabled = True

       

        '  lblPJK.Text = GetSystemName()

    End Sub

    Public Sub doLock()


        ' btnLogin.Visible = False

        'invi login btn
        '  Me.panelLock.Visible = True
        Me.cmbLanguage.Visible = False
        Me.btnLogin.Visible = False
        Me.txtIC.Visible = False
        Me.lblKp.Visible = False
        Me.lbllock.Visible = True
        Me.lbllock.Text = "Pc Telah Dikunci. Sila berjumpa pentadbir anda" & Environment.NewLine & "Pc locked.Please see administrator"

        lblinside.Enabled = True


    End Sub

    Public Sub doUnLock()

        ' btnLogin.Visible = True

        'Me.panelLock.Visible = True
        Me.cmbLanguage.Visible = True
        Me.btnLogin.Visible = True
        Me.txtIC.Visible = True
        Me.lblKp.Visible = True
        Me.lbllock.Visible = False
        Me.lbllock.Text = ""

        lblinside.Enabled = False

    End Sub

    Public Sub GetPCNO()

        Dim strdata As String
        Dim arrobj As Object


        strdata = ReadFile(FileName)
        arrobj = Split(strdata)

        IpServer = arrobj(0).ToString
        lblPCNo.Text = arrobj(1).ToString
        ipChatServer = arrobj(2).ToString

        PcNo = lblPCNo.Text
        frmServerconn.cboPCnum.Text = PcNo


    End Sub


    Private Sub lockMe(ByVal boolType As Boolean)
        If boolType Then

            panelLock.Top = 420

            'panelLock.Top = 100
            panelLock.Left = 117
            panelLock.Visible = True
            'btnStart.Enabled = False
        Else
            panelLock.Visible = False
            ' btnStart.Enabled = True
        End If

    End Sub

    Private Sub btnend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub HaltTimer(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HaltTime.Tick
        txtIC.Enabled = True
        cmbLanguage.Enabled = True
        btnLogin.Enabled = True
        intCounter = 0
        txtIC.SelectAll()
        If lgId = 1 Then
            lblmsg.Text = "Sila masukan ID"
        Else
            lblmsg.Text = "Please enter your ID"
        End If
        halttime.Enabled = False


    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        
        If flag = 1 Then
            If lgId = 1 Then
                MsgBox("Sila semak tetapan IP")
            Else
                MsgBox("Please check IP setting")
            End If
        Else
            Dim strPC As String
            Dim msgbm As String = "Sila masukkan id pengguna anda"
            Dim msgBi As String = "Please insert your user id "
            Dim msg As String
            Dim title As String
            '   ICNo = txtIC.Text

            ICNo = Replace(txtIC.Text, " ", "")  'avoid spacing 
            If ICNo <> "" Then

                If ValidateUSer(ICNo) = True Then

                    strPC = CheckOthBrowsing() 'to check if user is still browsing in other pc and get the pc no

                    If strPC <> "" Then
                        MsgBox("Anda telah login di PC" & strPC)
                        intCounter = intCounter + 1
                    Else
                        If CheckActive(ICNo) = 1 Then

                            If activeUsr = 1 Then

                                logoutPreviousUser() '// make sure all other user using this PC is logged out

                                '//check dah guna 30 minit 
                                'UserType = GetUserType(ICNo) ' IMRAN 20150303
                                StartBrowsing(Type, ICNo)  ' Type here is browse type either prepaid or postpaid
                                'RestartExplorer()
                                
                                appStatus = 2 'to set PC as being used

                                intCounter = 0

                                'frmMonitoring.Close()
                                frmMonitoring.Show() 'frmMonitoring must show after StartBrowsing cuz it reads some figures from StartBrowsing
                                Me.Hide() 'hide frmMain
                                frmMonitoring.AutoLoginCMS()
                                frmMonitoring.autoLoginUser()

                            ElseIf activeUsr = 0 Then
                                If lgId = 1 Then
                                    lblmsg.Text = "ID tidak aktif."
                                Else
                                    lblmsg.Text = "ID is not active."
                                End If
                            End If
                        Else
                            If lgId = 1 Then
                                lblmsg.Text = "ID tidak aktif."
                            Else
                                lblmsg.Text = "ID is not active."
                            End If
                            intCounter = intCounter + 1
                        End If

                    End If

                Else
                    If lgId = 1 Then
                        lblmsg.Text = "Id tidak sah. Sila daftar"
                    Else
                        lblmsg.Text = "Invalid ID. Please register"
                    End If

                    intCounter = intCounter + 1
                    txtIC.SelectAll()
                End If


            Else

                If lgId = 1 Then

                    msg = msgbm
                    title = titlebm

                Else
                    msg = msgBi
                    title = titlebi

                End If

                lblmsg.Text = msg

                intCounter = intCounter + 1
                txtIC.SelectAll()
            End If

            If intCounter = 3 Then
                If lgId = 1 Then
                    lblmsg.Text = "Sila cuba lagi selepas 10 saat"
                Else
                    lblmsg.Text = "Please try again after 10 sec"
                End If

                HaltTime.Interval = 10 * 1000 ' (20sec)
                HaltTime.Enabled = True
                txtIC.Enabled = False
                btnLogin.Enabled = False
                cmbLanguage.Enabled = False
                Exit Sub
            End If
        End If

    End Sub

    Private Function Checkprepaiduser(ByVal ic As String) As Boolean


        Dim sqlcmd As New MySqlCommand

        dr = dbRead("SELECT * FROM prepaid where icNo = '" & ic & "' ")

        If dr.Read Then
            Return True
        Else
            Return False


        End If

        dr.Close()
        conn.Close()



    End Function


    Private Sub cmbLanguage_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbLanguage.SelectedIndexChanged

        Dim intSelectedIndex As Integer
        intSelectedIndex = cmbLanguage.SelectedIndex
        Dim objSelectedItem As Object
        objSelectedItem = cmbLanguage.SelectedItem

        If Me.cmbLanguage.SelectedItem = "English" Then

            btnLogin.Text = "Enter"
            LinkLabel1.Text = "New Registartion"
            lblKp.Text = "IC No"
            lgId = 2
            lblIpClient.Text = "IP CLient"
            lblIpsvr.Text = "IP Server"



        ElseIf Me.cmbLanguage.SelectedItem = "Bahasa Melayu" Then

            btnLogin.Text = "Masuk"
            LinkLabel1.Text = "Pendaftaran Baru"
            lblKp.Text = "No Kp"
            lgId = 1
            lblIpClient.Text = "IP Pelanggan"
            lblIpsvr.Text = "IP Pelayan"


        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        '  frmRegister.Show()
        '
    End Sub


    Private Function GetIPAddress()

        Dim strHostName As String
        Dim strIPAddress As String
        Dim ip As String


        strHostName = System.Net.Dns.GetHostName()
        strIPAddress = System.Net.Dns.GetHostEntry(strHostName).AddressList(0).ToString()

        ip = ("Host Name: " & strHostName & "   IP Address: " & strIPAddress)

        Return ip
    End Function

    Private Function IsConnectionAvailable() As Boolean
        'Call url
        Dim url As New System.Uri("http://www.google.com/")
        'Request for request
        Dim req As System.Net.WebRequest
        req = System.Net.WebRequest.Create(url)
        Dim resp As System.Net.WebResponse
        Try
            resp = req.GetResponse()
            resp.Close()
            req = Nothing
            Return True

        Catch ex As Exception

            ErrorlogFile("frmMain", ex.ToString, fullpath)

            req = Nothing
            Return False
        End Try
    End Function



    Private Sub timerdb_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerdb.Tick

        If GetSystemName() <> "ERROR" Then
            timerdb.Enabled = False
            lblPJK.Text = GetSystemName()
        End If
    End Sub
    Private Sub timer_conn_server_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer_conn_server.Tick

        'chech server chat
        If Getconnected() = True Then  '// TIAedit - kalau da connect ngan server timer akan di offkan
            timer_conn_server.Enabled = False

        End If

    End Sub
    Private Sub Timer1_Tick() Handles Timer1.Tick
        If clientSocket.Connected = True Then

            ntwkdisconn.Visible = False
            ntwkconn.Visible = True

            PCStatus()

        Else
            ntwkdisconn.Visible = False
            ntwkconn.Visible = True

            timer_conn_server.Enabled = True  ' try connect to chat serevr
            timer_conn_server.Start()

        End If


    End Sub


    Private Sub PicIpConn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmIpconfig.Show()

    End Sub

    Private Sub PicChat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicChat.Click
        ' frmChat.Show()
        ' Form2.Show()
        'frmChatUI.Show()
    End Sub


    Private Sub ntwkdisconn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ntwkdisconn.Click
        frmServerconn.Show()
    End Sub


    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    '    Me.Close()

    'End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork




    End Sub

    Public Sub getMessage() '//-anb0418


        For infiniteCounter = 1 To 2
            infiniteCounter = 1
            Try
                serverStream = clientSocket.GetStream()
                Dim buffSize As Integer
                Dim inStream(10024) As Byte
                buffSize = clientSocket.ReceiveBufferSize
                serverStream.Read(inStream, 0, inStream.Length)


                Dim returndata As String = System.Text.Encoding.ASCII.GetString(inStream)
                readData = "" + returndata
                'msg() //-anbEdit
                Me.processMsg()

            Catch ex As Exception
                infiniteCounter = 2

                ErrorlogFile("frmMain", ex.ToString, fullpath)

            End Try

            'Me.processMsg()

        Next

    End Sub

    Private Sub processMsg() '//-anbEdit

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf Me.processMsg))
        Else

            Dim arrData As Object
            Dim strCom As String
            Dim intPCnum As Integer
            Dim strPCname As String
            Dim strData As String

            'testing 

            ' readData = "A00|APLS|1"

            '"A00|APEN|1|6104"
            'A00|APLS|1

            arrData = Split(readData, "|")

            If UBound(arrData) <> 2 Then Exit Sub

            strPCname = arrData(0).ToString
            intPCnum = Val(strPCname.Substring(1, 2)) '//remmove C -> 1
            strCom = arrData(1)
            strData = arrData(2)


            Select Case strCom
                Case "CHAT"
                    If frmChatUI.Visible = False Then frmChatUI.Show()

                    frmChatUI.txtHistory.Text = frmChatUI.txtHistory.Text + Environment.NewLine + " Admin >> " + strData

                    frmChatUI.txtHistory.Text += ""

                    frmChatUI.txtHistory.Select(frmChatUI.txtHistory.Text.Length, 0)

                    frmChatUI.txtHistory.ScrollToCaret()

                Case "STAT"
                    '//frm_home.lst_pc.Items(intPCnum - 1).ImageIndex = Val(strData)
                    ' PCStatus()


                Case "LOCK"

                    ''invi login btn
                    'Me.panelLock.Visible = True
                    'Me.btnLogin.Visible = False

                    doLock()
                    appStatus = 3

                Case "UNLK"

                    'vi login btn

                    'Me.btnLogin.Visible = True
                    doUnLock()
                    appStatus = 1


                Case "RSTR"

                    'restrat pc

                    System.Diagnostics.Process.Start("shutdown", "-r -t 00")


                Case "TOFF"

                    'tutup pc
                    'System.Diagnostics.Process.Start("shutdown", "-s -t 00")
                    System.Diagnostics.Process.Start("shutdown", "-s -f -t 0") '-f for force shutdown

                    'logoff
                    'System.Diagnostics.Process.Start("shutdown", "-l -t 00")


                Case "LGIN"

                    txtIC.Text = strData
                    btnLogin.PerformClick()
                    'appStatus = 2 '// Anb : App status should be set by the Login Process

                Case "LOFF"

                    frmMonitoring.Show()
                    If frmMonitoring.btnout.Enabled = False Then
                        frm_user_record.Close()
                        frmMonitoring.btnout.Enabled = True
                    End If

                    txtIC.Text = ""
                    frmMonitoring.btnout.PerformClick()
                    appStatus = 1

                Case "APLS"

                    EventLog()

                    sendData("A00|APLS")
                    appStatus = 2


                Case "APEN"


                    'kill process

                    Dim processname As String

                    processname = GetProcessName(strData)

                    Dim pProcess() As Process = System.Diagnostics.Process.GetProcessesByName(processname)

                    For Each p As Process In pProcess
                        p.Kill()
                    Next


                    sendData("A00|APEN")
                    appStatus = 2

                Case "MNMX"

                    If WindowState = FormWindowState.Minimized Then
                        Me.WindowState = FormWindowState.Maximized
                        'IMRAN 20150403
                        frmMonitoring.WindowState = FormWindowState.Maximized 
                    Else
                        Me.WindowState = FormWindowState.Minimized
                        'IMRAN 20150403
                        frmMonitoring.WindowState = FormWindowState.Minimized 
                    End If

                    appStatus = 1


                Case "PRPD"

                    txtIC.Text = strData
                    Type = 0

                    btnLogin.Visible = True
                    btnLogin.PerformClick()

                Case "ALRT"

                    frmMsgBox.txtmsg.Text = strData
                    frmMsgBox.Show()
                    frmMsgBox.BringToFront()

                Case "SETG"
                    '// tells the client that there are changes to the system Setting

                    'SETG|data
                    Dim strcommand As Object

                    'strcommand = satrDat.Substring(1, 3)
                    strcommand = Split(strData, "=")

                    If strcommand(0) = "Limit" Then

                        If lgId = 1 Then
                            frmMsgBox.txtmsg.Text = "Limit masa bertukar ke  " & strcommand(1)
                        Else
                            frmMsgBox.txtmsg.Text = "Time limit change to " & strcommand(1)
                        End If

                    ElseIf strcommand(0) = "Lock" And strcommand(1) = 1 Then
                        'lock_client = 1

                        If lgId = 1 Then

                            frmMsgBox.txtmsg.Text = "PC telah di kunci "
                        Else

                            frmMsgBox.txtmsg.Text = "Client locked "
                        End If

                        'Me.panelLock.Visible = True
                        'Me.btnLogin.Visible = False

                        doLock()

                        appStatus = 3

                    ElseIf strcommand(0) = "Lock" And strcommand(1) = 0 Then

                        'lock_client = 0

                        If lgId = 1 Then

                            frmMsgBox.txtmsg.Text = "PC telah dibuka"
                        Else

                            frmMsgBox.txtmsg.Text = "Client unlocked " & strData
                        End If

                        'Me.btnLogin.Visible = True

                        doUnLock()

                        appStatus = 1


                    End If

                    frmMsgBox.Show()
                    frmMsgBox.BringToFront()
                    GetSettings()

                Case "IPRQ"
                    Dim ip_address As String
                    ip_address = GetIPv4Address()
                    sendData("IPRQ|" + ip_address)
                    '-----------Semak18-------- 20140428 imran 'if admin tightVNC user ,semak18 will reset
                    'webdetect = False 
                    'appStatus = 2
                    'WebCount = -60
                    '-------------------------

                '-----------Semak18-------- 20140428 imran 'if admin press button in menustrip ,semak18 will reset
                 Case "RSTX"
                    webdetect = False 
                    'appStatus = 2
                    'WebCount = -60
                '-------------------------

                Case "CTEN"
                    frmChatUI.Close()

                Case Else




                    MsgBox(strCom.ToString + " - " + strData)

            End Select

        End If
    End Sub

    Public Sub EventLog()

        Dim HT_processlist As Hashtable = New Hashtable(StringComparer.OrdinalIgnoreCase)
        Dim HT_processname As Hashtable = New Hashtable(StringComparer.OrdinalIgnoreCase)

        Dim procList() As Process = Process.GetProcesses()
        Dim i As Integer
        Dim p As Integer
        Dim strdata As String
        Dim appnames As String
        Dim regdate As String = Format(Now, "yyyy-MM-dd HH:mm:ss")

        Dim conn As New MySqlConnection(strconn)
        Dim sqlcmd As New MySqlCommand
        Dim sqlreader As MySqlDataReader

        On Error Resume Next

        dr = dbRead("SELECT Processname FROM blacklists ")

        Do While dr.Read()
            appnames = dr.Item("Processname").ToString
            i += 1
            HT_processname.Add(i, appnames)  '// save all process in database in 1 table
        Loop

        Dim strInsert As String = ""

        For i = 0 To procList.Count - 1 Step i + 1 '// loop utk process list

            Dim strProcName As String = procList(i).ProcessName
            Dim iProcID As Integer = procList(i).Id
            Dim strmodule As String = procList(i).MainWindowTitle


            strdata = "ProcId:" & iProcID & "  Process: " & strProcName & "  Title:" & strmodule


            p += 1      '// create key for hashtable 
            HT_processlist.Add(p, strProcName) '// save all process in 1 table

            If HT_processname.ContainsValue(strProcName) Then '// kalau ada process yg blacklist, die akan read for next process
                Resume Next
            Else

                strInsert &= "( '" & PcNo & "', " & iProcID & ",'" & strmodule & "','" & regdate & "','" & strProcName & "'),"
                'dr = dbRead("INsert into eventlogs (pcno,appid,module,entry_dt,process) " & _
                '"values( '" & PcNo & "', " & iProcID & ",'" & strmodule & "','" & regdate & "','" & strProcName & "')")
            End If

        Next

        If strInsert.Length > 0 Then

            strInsert = strInsert.Substring(0, strInsert.Length - 1)
            strInsert = "INsert into eventlogs (pcno,appid,module,entry_dt,process) values " & strInsert & ";"

            dr = dbRead(strInsert)

        End If



    End Sub
    Private Function read_all_blacklist() As Boolean
        Dim table As New Hashtable
        Dim i As Integer
        Dim procList() As Process = Process.GetProcesses()
        Dim u As Integer

        On Error Resume Next
        dr = dbRead("SELECT appname FROM blacklists ")
        'dr.Read()
        Do While dr.Read()
            Dim appnames = dr.Item("appname").ToString
            i += 1
            table.Add(i, appnames)

        Loop
        Return False



        'For i = 0 To appnames.Count
        '    table.Add(i, appnames)
        'Next


    End Function

    Private Sub txtic_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIC.KeyDown

        '// determine the right language to use
        Dim title As String
        Dim errMsg As String
        If lgId = 1 Then
            '   msg = msgbm
            title = titlebm
            errMsg = "Sistem tidak dapat log masuk buat masa sekarang"

        Else
            '  msg = msgBi
            title = titlebi
            errMsg = "System could not log you in at this time"

        End If


        If e.KeyCode = Keys.Enter Then

            If txtIC.Text = "-msdcbc383" Then '// if user put in the system bypass panel pwd

                panelmaintenance.Visible = True
                Try
                    EnableTaskManager()
                    Enableshutdown()
                    Enablechangepassword()
                    Enablelock()
                    Enablelogoff()
                    Enableswitchuser()
                Catch ex As Exception
                    ' MsgBox(ex.Message, MsgBoxStyle.Critical, "UAC/registry error")
                End Try

            Else
                Try
                    btnLogin_Click(sender, e)
                Catch ex As Exception
                    MsgBox(errMsg)
                End Try

            End If
        End If

        'Try

        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        '    '   DisconnectMysql_Database()
        'Finally
        '    '  DisconnectMysql_Database()
        'End Try


    End Sub


    ''  End Sub
    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    '    processMsg()
    'End Sub
    Public Function GetIPv4Address() As String


        GetIPv4Address = String.Empty
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Try
            Dim iphe As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)

            For Each ipheal As System.Net.IPAddress In iphe.AddressList
                If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                    GetIPv4Address = ipheal.ToString()

                End If
            Next
            Return GetIPv4Address
        Catch ex As Exception
            MsgBox("No such host is known")
        End Try

    End Function



    Private Sub logoutPreviousUser()


        'dr = dbRead("Update browsing set time_end = now() ,browse_status = 1,mod_dt=now() " & _
        '            "where pcno = " & PcNo & " and browse_status = 0")
        Try

            dr = dbRead("Update browsing set browse_status = 1 " & _
                 "where pcno = " & PcNo & " and browse_status = 0")


            dr.Close()
            conn.Close()
        Catch ex As Exception
            If flag = 0 Then
                If lgId = 1 Then
                    MsgBox("Sila semak tetapan")
                    frmServerconn.lblmsg.Text = "Sila semak tetapan"
                Else
                    MsgBox("Please check setting")
                    frmServerconn.lblmsg.Text = "Please check setting"
                End If
                ErrorlogFile("modMain", ex.ToString, fullpath)
                flag = 1
            End If
        End Try


    End Sub

    Private Function CheckOthBrowsing() As String
        Dim PC As String

        dr = dbRead("select icno,pcno,time_start " +
                    "from browsing " +
                    "where icno = '" & ICNo & "' " +
                    "and date(time_start) = date(current_date()) " +
                    "and browse_status = 0")

        If dr.Read Then
            PC = dr("pcno")
        Else
            PC = ""
        End If

        Return PC
    End Function



    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

        Me.Show()
        'Me.WindowState = FormWindowState.Normal
        Me.WindowState = FormWindowState.Maximized
        NotifyIcon1.Visible = False
    End Sub


    Private Sub PicMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicMin.Click
        Dim msg As String

        Me.WindowState = FormWindowState.Minimized
        frmMonitoring.WindowState = FormWindowState.Minimized 'IMRAN 20150330 
        frmMonitoring.Hide 
        Me.Hide()
        NotifyIcon1.BalloonTipText = "Click Here To Minimize"
        NotifyIcon1.Visible = True
        NotifyIcon1.Text = "CMS PI1M"


        If lgId = 1 Then

            msg = " Applikasi Telah DiPindahkan Di Taskbar "
        Else

            msg = "An application has been moved to Taskbar"
        End If



        NotifyIcon1.ShowBalloonTip(3000, Application.ProductName, msg, ToolTipIcon.Info)
        '"The App has be moved to the tray.",
    End Sub

    Private Sub picOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picOut.Click

        Dim msgbm As String = "Anda Pasti ?"
        Dim msgBi As String = "Are You Sure ? "
        Dim msg As String = ""
        Dim title As String = ""

        If lgId = 1 Then

            msg = msgbm
            title = titlebm

        ElseIf lgId = 2 Then

            msg = msgBi
            title = titlebi

        End If

        Dim msgbox As DialogResult = MessageBox.Show(msg, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)


        If msgbox = Windows.Forms.DialogResult.OK Then
            Try
                EnableTaskManager()
                Enableshutdown()
                Enablechangepassword()
                Enablelock()
                Enablelogoff()
                Enableswitchuser()
            Catch ex As Exception
                'msgbox(ex.Message, MsgBoxStyle.Critical, "UAC/registry error")
            End Try
            Application.ExitThread()
            'Application.Exit()
        End If

        sendData("STAT|0")
        '--------- 'IMRAN 20150402
        If conn.State = ConnectionState.Open 
            conn.Close 
            conn.Dispose
        End If
        '---------
    End Sub

    Private Sub picInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picInfo.Click
        frmServerconn.BringToFront()
        frmServerconn.Show()
    End Sub

    Private Sub txtIC_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIC.TextChanged
        '// change depends on the first character
        If txtIC.Text.StartsWith("-") Then
            txtIC.UseSystemPasswordChar = True
        Else
            txtIC.UseSystemPasswordChar = False
        End If
    End Sub
    Private Sub pictaskmgr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictaskmgr.Click
        If taskmanager = False Then
            EnableTaskManager()
            MsgBox("Task Manager Enabled")
        Else
            DisableTaskManager()
            MsgBox("Task Manager Disabled")
        End If

    End Sub

    Private Sub Picregedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Picregedit.Click

        If regedit = False Then
            EnableRegedit()
            MsgBox("Registry Editor Enabled")
        Else
            DisableRegedit()
            MsgBox("Registry Editor Disabled")
        End If

    End Sub
    Private Sub picautorun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picautorun.Click
        strApprefms = CheckForShortcut() ' to get location of application manifest file
        ' RunAtStartup(Application.ProductName, Application.ExecutablePath)
        RunAtStartup(Application.ProductName, strApprefms) ' pass product name and manifest file location to be registered at startup registry

    End Sub



    Private Sub PicPanelClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicPanelClose.Click
        panelmaintenance.Visible = False
        Try
            DisableTaskManager()
            Disableshutdown()
            Disablechangepassword()
            Disablelock()
            Disablelogoff()
            Disableswitchuser()
        Catch ex As Exception
            '   MsgBox(ex.Message, MsgBoxStyle.Critical, "UAC/registry error")
        End Try
    End Sub

    Private Sub PicErrorlog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicErrorlog.Click
        Dim strFileName = ""
        Dim fileDialogBox As New OpenFileDialog()


        fileDialogBox.Filter = "PJK error log file (*.pjkerror)|*.pjkerror|" _
                     & "All Files(*.*)|"
        fileDialogBox.FilterIndex = 3
        fileDialogBox.InitialDirectory = fullpath & "errorlog\"

        'Check to see if the user clicked the open button
        If (fileDialogBox.ShowDialog() = DialogResult.OK) Then
            strFileName = fileDialogBox.FileName
            'Else
            '   MsgBox("You did not select a file!")
        End If

    End Sub

    Private Sub PicFTP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicFTP.Click

        Dim strFileName = ""
        Dim fileDialogBox As New OpenFileDialog()


        fileDialogBox.Filter = "PJK log file (*.pjklog)|*.pjklog|" _
                     & "All Files(*.*)|"
        fileDialogBox.FilterIndex = 3
        fileDialogBox.InitialDirectory = fullpath & "ftp\"

        'Check to see if the user clicked the open button
        If (fileDialogBox.ShowDialog() = DialogResult.OK) Then
            strFileName = fileDialogBox.FileName
            'Else
            '   MsgBox("You did not select a file!")
        End If

    End Sub

    Private Sub PicConn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicConn.Click
        If IsConnectionAvailable() = True Then

            MsgBox("Internet connected")

        Else
            MsgBox("Internet disconnected")
        End If


    End Sub



    Private Sub lblinside_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblinside.MouseDown
        If e.Button = MouseButtons.Left Then

            '  lblleft.Text = "Pressed"



        ElseIf e.Button = MouseButtons.Right Then

            ' lblright.Text = "Pressed"

            Dim strUserPassword As String

            strUserPassword = InputBox("Please enter your password", "Password")
            If strUserPassword = "-msdcbc383" Then

                doUnLock()

                MsgBox("ok", MsgBoxStyle.OkOnly)
            Else
                MsgBox("wrong password", MsgBoxStyle.OkOnly)
            End If



        End If
    End Sub


    Private Sub lblinside_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblinside.MouseEnter
        'lblinside.Text = "Mouse Is Inside Now"
    End Sub

    Private Sub lblinside_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblinside.MouseLeave
        '  lblinside.Text = "Mouse Is Not Inside"
    End Sub


    Private Sub picDisableAutorun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If autorun = False Then
            EnableAutorun()
        Else
            DisableAutorun()
        End If
        '
    End Sub

    Private Sub ntwkconn_Click(sender As Object, e As EventArgs) Handles ntwkconn.Click

    End Sub

    Private Sub PicDB_Click(sender As Object, e As EventArgs) Handles PicDB.Click

    End Sub


Private Sub Button1_Click( sender As Object,  e As EventArgs) 
        Dim strTmp As String = frmMonitoring.WebBrowser.Document.Url.ToString
        MsgBox(strTmp)
End Sub

Private Sub timerCloseBrowser_Tick( sender As Object,  e As EventArgs) Handles timerCloseBrowser.Tick
        
        'frmMonitoring.Close()
        'frmMonitoring.Hide()

        'timerCloseBrowser.Enabled = False
End Sub


End Class