
Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.ComponentModel.Component


Public Class frmMain

    Private intCounter As Integer
    Dim titlebm As String = "Keluar"
    Dim titlebi As String = "Exit"

    Private Sub frmMain_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtIC.Text = ""
        lblmsg.Text = ""
    End Sub

    Public Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim myFileName = fullpath & FileName

        If System.IO.File.Exists(myFileName) Then
            GetPCsetting(myFileName)
        Else
            frmServerconn.ShowDialog()
        End If

        lockMe(True) '// check server setting nak lock atau tidak
        HookKeyboard()


        Me.cmbLanguage.Items.Insert(0, "Bahasa Melayu")
        Me.cmbLanguage.Items.Insert(1, "English")


        Me.cmbLanguage.SelectedItem = "Bahasa Melayu"
        lgId = 1

        appStatus = 1

        timer_conn_server.Interval = 5000           '//TIAedit - for connection to server
        timer_conn_server.Enabled = True

        Timer1_Tick()
        Timer1.Enabled = True


        NowSvrTime = GetServerTime()

        '  InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PanelMain.Left = (My.Computer.Screen.WorkingArea.Width / 2) - (PanelMain.Width / 2)
        ' PanelMain.Top = (My.Computer.Screen.WorkingArea.Height / 2) - (PanelMain.Height / 2) + 165 '//-anbEdit
        PanelMain.Top = (My.Computer.Screen.WorkingArea.Height / 2) - (PanelMain.Height / 2) + 200 '//-anbEdit



        lblPJK.Text = GetSystemName()
        'GetPCNO()

        'Getconnected() '//-anbEdit

    End Sub

    Public Sub doLock()


        btnLogin.Visible = False
        ' Me.Refresh()


    End Sub

    Public Sub doUnLock()


        btnLogin.Visible = True
        ' Me.Refresh()


    End Sub

    Public Sub GetPCNO()

        Dim strdata As String
        Dim arrobj As Object

        ' FileName = "ipclient.txt"
        'FileName = "ipserver.txt" //anbEdit0508

        strdata = ReadFile(FileName)
        arrobj = Split(strdata)

        frmIpconfig.txtPrevHost.Text = arrobj(0)

        lblPCNo.Text = arrobj(1)
        PcNo = lblPCNo.Text
        frmServerconn.cboPCnum.Text = PcNo
        'frmIpconfig.txtPrevIp.Text = arrobj(2)
        'frmIpconfig.txtPrevSub.Text = arrobj(3)
        'frmIpconfig.txtPrevGwy.Text = arrobj(4)

    End Sub

    Private Sub GetPCsetting(ByVal strFileName As String) '//anb0508

        Dim strdata As String
        Dim arrobj As Object

        strdata = ReadFile(strFileName)
        arrobj = Split(strdata)

        IpServer = arrobj(0).ToString
        PcNo = arrobj(1).ToString
        ipChatServer = arrobj(2).ToString

        useServerConn(IpServer)

        lblPCNo.Text = PcNo

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


    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim strPC As String

        ICNo = txtIC.Text

        strPC = CheckOthBrowsing() 'to check if user is still browsing in other pc and get the pc no

        If strPC <> "" Then
            MsgBox("Anda telah login di PC" & strPC)
            Exit Sub
        End If

        If ValidateUSer(ICNo) = True Then

            logoutPreviousUser() '// make sure all other user using this PC is logged out

            '   UserType = GetUserType(ICNo)\
            StartBrowsing(Type, ICNo)
            appStatus = 2 'to set PC as being used

            frmMonitoring.Show() 'frmMonitoring must show after StartBrowsing cuz it reads some figures from StartBrowsing
            Me.Hide() 'hide frmMain

        Else
            lblmsg.Text = "Id tidak sah. Sila daftar"
        End If

    End Sub


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

        frmRegister.Show()

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
            req = Nothing
            Return False
        End Try
    End Function

    Private Function IsDBAvailable() As Boolean  '// for database connection
        Try
            Using sqlConn As New MySqlConnection(strconn)
                sqlConn.Open()

                Dim intStatus As Integer = sqlConn.State

                sqlConn.Close()

                'Return (sqlConn.State = ConnectionState.Open)
                Return intStatus

            End Using
        Catch e1 As MySqlException
            Return False
        Catch e2 As Exception
            Return False
        End Try
    End Function
    Private Sub Timer1_Tick() Handles Timer1.Tick

        'intCounter += 1

        'If intCounter = 5 Then
        '    PCStatus()
        '    intCounter = 0
        'End If

        'If appStatus = 3 Then

        '    'lock
        '    doLock()


        'ElseIf appStatus = 1 Then

        '    'unlock
        '    doUnLock()

        'End If

        PicDisconn.Visible = False
        'ntwkdisconn.Visible = False


        If IsConnectionAvailable() = False Then     '//for internet accesss

            PicDisconn.Visible = True
            PicConn.Visible = False

        End If

        If HasConnectivity() = False Then           '//for chat server connection
            ntwkdisconn.Visible = True
            ntwkconn.Visible = False
        Else                                        '//tia- 20120525
            ntwkdisconn.Visible = False
            ntwkconn.Visible = True
        End If

        If IsDBAvailable() = False Then             '//for database server connection

            PicDBx.Visible = True
            PicDB.Visible = False
        End If


        txtIpclient.Text = GetIPAddress()


        PCStatus()

        '   Console.WriteLine("Timer1 frmMain ticking")

    End Sub

    Public Sub PCStatustest()


        '//-anbEdit

        Dim strMsg As String = "STAT|" + appStatus


        sendData(strMsg)



    End Sub
    Function HasConnectivity() As Boolean '// for ipchat server connection


        Dim status As String
        Dim ip As String
        Dim objdata As Object


        'FileName = "ipserver.txt" '//anb0508

        'ip = ReadFile(FileName)

        objdata = Split(ReadFile(FileName), " ")
        ip = objdata(2)

        Try '//-anbEdit
            status = My.Computer.Network.Ping(ip) '// ip available 
            'Getconnected()
        Catch ex As Exception
            status = False
        End Try


        '//And Getconnected() = TrueAnd Getconnected() = True
        If status = True Then '// if connection ping available then try connect to ip 

            txtipserver.Text = ip
            IpServer = txtipserver.Text
            'Getconnected() '// try to connect 
            Return True

        Else

            Return False

        End If


    End Function

    Private Sub PicIpConn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmIpconfig.Show()

    End Sub

    Private Sub PicChat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicChat.Click
        ' frmChat.Show()
        ' Form2.Show()
        frmChatUI.Show()
    End Sub


    Private Sub ntwkdisconn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ntwkdisconn.Click
        frmServerconn.Show()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Close()

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork


        MsgBox("test")

    End Sub

    Public Sub getMessage() '//-anb0418


        For infiniteCounter = 1 To 2
            infiniteCounter = 1
            Try
                serverStream = clientSocket.GetStream()
                Dim buffSize As Integer
                Dim inStream(10024) As Byte
                buffSize = clientSocket.ReceiveBufferSize
                serverStream.Read(inStream, 0, buffSize)


                Dim returndata As String = System.Text.Encoding.ASCII.GetString(inStream)
                readData = "" + returndata
                'msg() //-anbEdit
                Me.processMsg()
            Catch ex As Exception
                infiniteCounter = 2
            End Try
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

                    'invi login btn
                    Me.panelLock.Visible = True
                    Me.btnLogin.Visible = False

                    appStatus = 3

                Case "UNLK"

                    'vi login btn

                    Me.btnLogin.Visible = True
                    appStatus = 1


                Case "RSTR"

                    'restrat pc

                    System.Diagnostics.Process.Start("shutdown", "-r -t 00")


                Case "TOFF"

                    'blm test

                    'tgh pakai frm monitoring tukar terus jadik main
                    'status = 2


                Case "LGIN"

                    txtIC.Text = strData
                    btnLogin.PerformClick()
                    'appStatus = 2 '// Anb : App status should be set by the Login Process

                Case "LOFF"

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
                    appStatus = 1

                Case "MNMX"

                    If WindowState = FormWindowState.Minimized Then
                        Me.WindowState = FormWindowState.Maximized
                    Else
                        Me.WindowState = FormWindowState.Minimized
                    End If
                    appStatus = 2


                Case "PRPD"

                    txtIC.Text = strData
                    Type = 0
                    btnLogin.PerformClick()

                Case "ALRT"
                    MsgBox(strData)

                Case "SETG"

                Case "IPRQ"
                    Dim ip_address As String
                    ip_address = GetIPv4Address()
                    sendData("IPRQ|" + ip_address)
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

        Try


        Dim msgbm As String = "Sila masukkan id pengguna anda"
        Dim msgBi As String = "Please insert your user id "
        Dim msg As String
        Dim title As String

        If lgId = 1 Then


            msg = msgbm
            title = titlebm

        ElseIf lgId = 2 Then
            msg = msgBi
            title = titlebi

        End If

        If e.KeyCode = Keys.Enter And txtIC.Text = "" Then

                MsgBox(msg, MsgBoxStyle.OkOnly, title)
            Else

                If txtIC.Text.StartsWith("-") Then

                    txtIC.UseSystemPasswordChar = True

                    If txtIC.Text = "-password" Then

                        If e.KeyCode = Keys.Enter Then
                            btnLogin_Click(sender, e)
                            PanelHelp.Visible = True
                        End If

                    End If

                Else


                    txtIC.UseSystemPasswordChar = False


                    If e.KeyCode = Keys.Enter Then
                        btnLogin_Click(sender, e)
                        PanelHelp.Visible = False
                    End If
                End If
        End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            '   DisconnectMysql_Database()
        Finally
            '  DisconnectMysql_Database()
        End Try


    End Sub

   
    '  End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        processMsg()
    End Sub
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

    Private Sub timer_conn_server_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer_conn_server.Tick
        If Getconnected() = True Then  '// TIAedit - kalau da connect ngan server timer akan di offkan
            timer_conn_server.Enabled = False
        End If

    End Sub

    Private Sub logoutPreviousUser() '// Anb : Logout all user instance from this PC
        Dim logoutdate As String = Format(Now, "yyyy-MM-dd HH:mm:ss")

        dr = dbRead("Update browsing set time_end = '" & logoutdate & "' ,browse_status = 1,mod_dt='" & logoutdate & "' " & _
                        "where pcno = " & PcNo)

        dr.Close()
        conn.Close()

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
        Me.Hide()
        NotifyIcon1.BalloonTipText = "HERE!!!"
        NotifyIcon1.Visible = True


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
        Dim msg As String
        Dim title As String

        If lgId = 1 Then

            msg = msgbm
            title = titlebm

        ElseIf lgId = 2 Then

            msg = msgBi
            title = titlebi

        End If

        Dim msgbox As DialogResult = MessageBox.Show(msg, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)


        If msgbox = Windows.Forms.DialogResult.OK Then

            Application.Exit()
        End If


    End Sub

    Private Sub picInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picInfo.Click
        frmServerconn.Show()
    End Sub

   

   
End Class