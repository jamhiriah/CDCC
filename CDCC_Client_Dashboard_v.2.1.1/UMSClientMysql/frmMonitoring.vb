Imports System.Diagnostics
Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography
Imports System.IO
Imports System.Threading


Public Class frmMonitoring

    Dim starttime As String = Format(Now, "HH:mm:ss")
    Dim accttype As Integer
    Dim tutup As Integer = 0
    Dim idapptracker As Boolean = True
    Dim cekMasa As Integer = 0

    Private Sub frmMonitoring_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed 'imran 20150304
            

    End Sub
    Private Sub frmMonitoring_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Stop()
    End Sub


    Private Sub frmMonitoring_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblVersionMonitoring.Text = frmMain.lblVersion.Text

        WebBrowser.ScriptErrorsSuppressed = True 'False    'debug is false, release is tru 201403050imran

        Me.BringToFront()
        Me.WindowState = FormWindowState.Maximized

        'Dim baldays As Integer

        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height - 32
        Me.Top = 0
        Me.Left = 0

        panelControl.Left = Me.Width - panelControl.Width - 20

        WebBrowser.Height = Me.Height - panelControl.Height - 10
        WebBrowser.Width = Me.Width '20150304 imran

        'Timer1.Interval = 60000 ' 60 seconds = 1 min
        'FormTimerInterval = Timer1.Interval ' to assign the form timer interval to public var- FormTimerInterval
        'Timer1.Enabled = True


        'lblservertime.Text = NowSvrTime

        'ValidateLanguange(lgId)


        'lblKp.Text = ICNo
        'lblstartdate.Text = Regdate

        'lblcharge.Text = "RM" & Format(Rate, "0.00")

        'Duration = GetCurrentDuration(Regdate, Now) '//regdate amik server time
        'lblduration.Text = TimeDef(Duration)

        'Dim baki As Integer = 0

        'If Rate = 0.0 Then
        '    baki = checkEndTime()
        '    baki = baki / 60
        '    If lgId = 1 Then
        '        lblanggaran.Text = "Baki Masa Percuma :"
        '    Else
        '        lblanggaran.Text = "Remaining Free Time :"
        '    End If

        '    lblpayment.Text = "  " & baki & " min"
        'Else
        '    Payment = GetPayment(Duration, Rate, Valueperminute)
        '    lblpayment.Text = "RM" & Format(Payment, "0.00")
        'End If


        'If UserTypeId <> 1 Then
        '    baldays = GetFOCDaysBal(ICNo)
        '    If baldays > 0 And UserTypeId = 3 Then
        '        lblbakihari.Visible = True
        '        lblbakihari2.Visible = True
        '        lblbakihari2.Text = baldays
        '    Else
        '        lblbakihari.Visible = False
        '        lblbakihari2.Visible = False
        '    End If
        'End If


        'autoLoginUser()

    End Sub


    Public Sub AutoLoginCMS
        
        Dim baldays As Integer
        
        Timer1.Interval = 60000 ' 60 seconds = 1 min
        FormTimerInterval = Timer1.Interval ' to assign the form timer interval to public var- FormTimerInterval
        Timer1.Enabled = True


        lblservertime.Text = NowSvrTime

        ValidateLanguange(lgId)

        lblKp.Text = ICNo
        lblstartdate.Text = Regdate

        lblcharge.Text = "RM" & Format(Rate, "0.00")

        Duration = GetCurrentDuration(Regdate, Now)
        lblduration.Text = TimeDef(Duration)

        Dim baki As Integer = 0

        If Rate = 0.0 Then
            baki = checkEndTime()  'return in Min
            'baki = baki / 60
            If lgId = 1 Then
                lblanggaran.Text = "Baki Masa Percuma :"
            Else
                lblanggaran.Text = "Remaining Free Time :"
            End If

            lblpayment.Text = "  " & baki & " min"
        Else
            Payment = GetPayment(Duration, Rate, Valueperminute)
            lblpayment.Text = "RM" & Format(Payment, "0.00")
        End If
        

        If UserTypeId <> 1 Then
            baldays = GetFOCDaysBal(ICNo)
            If baldays > 0 And ((UserTypeId = 3) Or (UserTypeId = 4)) Then  'for member 3.Gold and 4.Platinum
                lblbakihari.Visible = True
                lblbakihari2.Visible = True
                lblbakihari2.Text = baldays
            Else
                lblbakihari.Visible = False
                lblbakihari2.Visible = False
            End If
        Else
            lblbakihari.Visible = False
            lblbakihari2.Visible = False
        End If


        'autoLoginUser()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Console.WriteLine("The frmMonitor Elapsed event was raised")

        Dim currtime As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
        Dim baki As Integer = 0
        Duration = GetCurrentDuration(Regdate, currtime)
        lblduration.Text = TimeDef(Duration)

        '  cekMasa += 1



        If Rate = 0.0 Then
            'baki = checkEndTime()
            'baki = Int(baki / 60)
            'If lgId = 1 Then
            '    lblanggaran.Text = "Baki Masa Percuma :"
            'Else
            '    lblanggaran.Text = "Remaining Free Time :"
            'End If
            'lblpayment.Text = "  " & baki & " min"

            'If baki < 1 Then
            '    btnout.PerformClick()
            'ElseIf lblpayment.Text = "  0 min" Then
            '    btnout.PerformClick()
            'ElseIf lblpayment.Text = "  -1 min" Then 'double check just in case 
            '    btnout.PerformClick()
            'End If


            'updated hafiz 22/08/14 ---- cek baki masa percuma without query (based on label)
            Dim tempTotal As Double
            '   If cekMasa >= 5 Then
            If lblanggaran.Text = "Baki Masa Percuma :" Or lblanggaran.Text = "Remaining Free Time :" Then


                Dim tempMin As String
                tempMin = Trim(lblpayment.Text)

                tempMin = tempMin.Replace(" min", "")
                tempMin = Trim(tempMin)

                If Convert.ToDouble(tempMin) <= 0 Then
                    btnout_Click(btnout, EventArgs.Empty)
                Else

                    Dim tempTime1 As Double = tempMin
                    ' Dim temptime2 As Double = lblduration.Text.Replace(" minit", "") 'jam 20141217 commented out as this brought error convertion string to double when running after 1 hour

                    tempTotal = tempTime1 - 1
                    lblpayment.Text = tempTotal.ToString & " min"

                End If
                baki = Convert.ToInt32(tempTotal.ToString)

                'End If
                'cekMasa = 0


            End If


            'end updated hafiz 22/08/14 ---- cek baki masa percuma without query (based on label)
        Else
            Payment = GetPayment(Duration, Rate, Valueperminute)
            lblpayment.Text = "RM" & Format(Payment, "0.00")
        End If

        If (Duration Mod 5 = 0) Then 'Jam 20150529 update browsing table only at every 5 minutes
            UpdateBrowsingLog(UserTypeId, ICNo, Rate, Duration, Payment)
        End If

        CheckLimitStatus(baki)

        If Type = 0 Then ' if prepaid, Type=0
            CheckPrepaidStatus(Payment)
        End If



    End Sub

    'Public Function checkEndTime()

    '    Dim baki As Integer
    '    Dim balday As Integer = GetFOCDaysBal(ICNo)
    '    Dim balmin As Integer = Check30Minutes(ICNo)
    '    Dim balmem As Integer = GetTodayFOCTimeBal(ICNo)

    '    If UserTypeId = 1 Or UserTypeId = 2 Then
    '        baki = balmin - 1
    '    Else
    '        If balday > 0 Then
    '            baki = balmem - 1  'member time balance
    '        Else
    '            baki = balmin - 1

    '        End If
    '    End If

    '    Return baki / 60  ' return in min

    'End Function

    Public Function checkEndTime()

        Dim baki As Integer
        'Dim balday As Integer = GetFOCDaysBal(ICNo)
        'Dim balmin As Integer = Check30Minutes(ICNo)
        'Dim balmem As Integer = GetTodayFOCTimeBal(ICNo)

        If UserTypeId = 1 Then ' -- Or UserTypeId = 2 Then
            baki = Check30Minutes(ICNo) - 1
        Else
            If GetFOCDaysBal(ICNo) > 0 Then
                baki = GetTodayFOCTimeBal(ICNo) - 1  'member time balance
            Else
                baki = Check30Minutes(ICNo) - 1
            End If
        End If

        Return baki / 60  ' return in min

    End Function


    Public Sub CheckLimitStatus(ByVal baki As Integer)


        Dim limit As Integer
        Dim msg, title As String
        Dim alerttime As Integer
 
        limit = Setting_Limit

        alerttime = limit - Duration

        If baki = 5 Then

            If lgId = 1 Then
                msg = "Waktu percuma anda akan tamat dalam tempoh 5 minit lagi." & Environment.NewLine & "Sila  simpan kerja anda"
                title = "Perhatian"
            Else
                title = "Alert"
                msg = "Your Free Time is almost finish. " & Environment.NewLine & "You will be logout automatically in 5 minutes." & Environment.NewLine & "Please save your work"
            End If

            frmMsgBox.txtmsg.Text = msg
            frmMsgBox.Show()
            frmMsgBox.BringToFront()

        ElseIf alerttime = 5 Then

            If lgId = 1 Then
                msg = "Waktu anda akan mencecah had masa 60 minit dalam tempoh 5 minit lagi." & Environment.NewLine & "Sila  simpan kerja anda"
                title = "Perhatian"
            Else
                title = "Alert"
                msg = "You will reach our 60 minutes/session limit in 5 minutes. " & Environment.NewLine & "You will be logout automatically in 5 minutes." & Environment.NewLine & "Please save your work"
            End If



            frmMsgBox.txtmsg.Text = msg
            frmMsgBox.Show()
            frmMsgBox.BringToFront()


        End If

        If alerttime < 1 Then '// reach time automatically logout, show main page
            btnout.PerformClick()
        End If



    End Sub

    Public Sub CheckPrepaidStatusValue()
        ' 5 minutes reach prepaid time limit

        Dim value As Double
        'Dim limit As Integer
        Dim msg, title As String
        'Dim alerttime As Integer


        value = Balance - Payment

        ' Payment = Duration * Valueperminute


        If value = 0.5 Then

            If lgId = 1 Then
                msg = "Waktu anda akan tamat dalam tempoh 5 minit lagi" & Environment.NewLine & "Sila  simpan kerja anda"
                title = "Perhatian"
            Else
                title = "Alert"
                msg = "You will be logout automatically in 5 minutes." & Environment.NewLine & "Please save your work"
            End If


            frmMsgBox.txtmsg.Text = msg
            frmMsgBox.Show()
            frmMsgBox.BringToFront()


        End If

        If Balance = Payment Then '// reach value limit automatically logout, show main page
            btnout.PerformClick()
        End If
    End Sub

    Public Sub ValidateLanguange(ByVal lgid As Integer)

        If lgid = 1 Then

            lblnokp.Text = "No Kp Pengguna  " '& lblKp.Text
            lblstarttime.Text = "Masa Mula : " & Regdate ' lblstartdate.Text
            lblpaid.Text = "Bayaran Sejam : " '& lblcharge.Text
            lbltempoh.Text = "Tempoh Penggunaan  " '& lblduration.Text
            lblanggaran.Text = " Anggaran Bayaran : " & lblpayment.Text
            lblbakihari.Text = "Baki hari : " '& lblbakihari2.Text


        ElseIf lgid = 2 Then

            lblnokp.Text = "User IC No  " '& lblKp.Text
            lblstarttime.Text = "Start Time : " & Regdate 'lblstartdate.Text
            lblpaid.Text = "Rate per hour : " '& lblcharge.Text
            lbltempoh.Text = "Usage  " '& lblduration.Text
            lblanggaran.Text = "Payment Estimation : " & lblpayment.Text
            lblbakihari.Text = "Rem. days : " '& lblbakihari2.Text

        End If

    End Sub


    Public Sub btnout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnout.Click

        'tutup = 1
        WebBrowser.Navigate("http://dashboard.pi1m.my/#/home/logout") 
        
        'Dim i As Integer 
        'Dim loggy As Boolean 
        'loggy = False
        'i = 1
        'Do  
        '    If loggy =False then
        '        Exit Do 
        '    End If
        '    If i < 1000000 then
        '        Exit Do 
        '    End If
        '    i = i +1
        '    If WebBrowser.Url.ToString=CStr("http://dashboard-test.pi1m.my/#/home") then
        '        loggy = True 
        '    End If

        ' Loop

        

        Logout()
       
        ClearEventLog() '//clear event log by pcno

         
        Me.WindowState = FormWindowState.Maximized
        frmMsgBox.Close()
        frmMain.Show()
        frmMain.BringToFront()
 
       frmMain.timerCloseBrowser.Enabled = True '// wait for browser to complete load before exiting
 
       conn.Close()
        'conn.Dispose  'IMRAN 20150402

       Me.Close() ' test 20150403
 
    End Sub


    Private Sub btnmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmin.Click 
        Dim msg As String

        Me.WindowState = FormWindowState.Minimized
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

    End Sub

    Private Sub btn_bypass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninfo.Click

        btnout.Enabled = False
        frm_user_record.Show()

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

        Me.Show()
        'Me.WindowState = FormWindowState.Normal
        Me.WindowState = FormWindowState.Maximized
        NotifyIcon1.Visible = False
    End Sub

    ' Private Sub PicChat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '   End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmChatUI.Show()
    End Sub

    Private Sub Timer1_Tick()
        Throw New NotImplementedException
    End Sub
    Private Sub ClearEventLog()

        Dim sqlcmd As New MySqlCommand
        sqlcmd = conn.CreateCommand
        dr = dbRead("delete from eventlogs where pcno = " & PcNo & "")
        dr.Close()
        conn.Close()
    End Sub


    'Private Sub buttonHide2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonHide2.Click
    '   If panelControl.Visible Then

    '        panelBrowser.Top = panelControl.Top
    '       panelBrowser.Left = panelControl.Left
    '
    '       panelControl.Visible = False
    '      panelBrowser.Visible = True
    ' Else
    '        panelControl.Visible = True
    '       panelBrowser.Visible = False
    '  End If
    'End Sub

    'Private Sub buttonHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '   txtWebAddress.Text = "http://dashboard.pi1m.my?sitecode=" & SiteCode
    '  buttonGo.PerformClick()
    'End Sub


    'Private Sub buttonGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '   WebBrowser.Navigate(txtWebAddress.Text)
    'End Sub

    'Private Sub buttonForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '   WebBrowser.GoForward()
    ' End Sub

    'Private Sub buttonBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '   WebBrowser.GoBack()
    'End Sub

    ' Private Sub buttonIE10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonIE10.Click
    'Dim strRegKey As String = "\SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION"
    '  Dim strRegKey64 As String = "\SOFTWARE\Wow6432Node\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION"
    '  Dim strRegName As String = "CMSClientMysql.exe"
    '   Dim strRegValue As Decimal = 10001

    '      Try
    'My.Computer.Registry.LocalMachine.CreateSubKey()
    '       My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE" & strRegKey, strRegName, strRegValue, Microsoft.Win32.RegistryValueKind.DWord)
    '         My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE" & strRegKey64, strRegName, strRegValue, Microsoft.Win32.RegistryValueKind.DWord)
    '         My.Computer.Registry.SetValue("HKEY_CURRENT_USER" & strRegKey, strRegName, strRegValue, Microsoft.Win32.RegistryValueKind.DWord)
    '         My.Computer.Registry.SetValue("HKEY_CURRENT_USER" & strRegKey64, strRegName, strRegValue, Microsoft.Win32.RegistryValueKind.DWord)
    '    Catch err As Exception
    '       MsgBox(err.Message.ToString)
    '   End Try
    ' End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim currtime As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
        lblservertime.Text = currtime
    End Sub

    Private Sub frmMonitoring_Shown(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles Me.Shown
        Dim strURL As String
        Dim encURL As String
        Dim hexiv As String = "680ab086ba422f30117460f3478442b0"
        Dim key As String = "1234567890123456"

        
       

        strURL = "{""ic"":""" & ICNo & """, ""site_code"":""" & SiteCode & """}"

        encURL = EncryptRJ256(key, hexiv, strURL)

        Dim url2 As String = HttpUtility.UrlEncode(HttpUtility.UrlEncode(encURL)) ' saiful 2014

        'WebBrowser.Navigate("http://dashboard.pi1m.my?q=" & url2) 'link asal
        
        WebBrowser.Navigate("http://dashboard.pi1m.my/#/home/cms/login/" & url2) 'modified link 20150212
        
        'WebBrowser.ScriptErrorsSuppressed = True

    End Sub

    Public Sub autoLoginUser()
        Dim strURL As String
        Dim encURL As String
        Dim hexiv As String = "680ab086ba422f30117460f3478442b0"
        Dim key As String = "1234567890123456"

        
       

        strURL = "{""ic"":""" & ICNo & """, ""site_code"":""" & SiteCode & """}"

        encURL = EncryptRJ256(key, hexiv, strURL)

        Dim url2 As String = HttpUtility.UrlEncode(HttpUtility.UrlEncode(encURL)) ' saiful 2014

        'WebBrowser.Navigate("http://dashboard.pi1m.my?q=" & url2) 'link asal
        
        WebBrowser.Navigate("http://dashboard.pi1m.my/#/home/cms/login/" & url2) 'modified link 20150212

    End Sub

    Public Function EncryptRJ256(ByVal prm_key As String, ByVal prm_iv As String, ByVal prm_text_to_encrypt As String)


        Dim sToEncrypt As String = prm_text_to_encrypt
        Dim myRijndael As New RijndaelManaged
        myRijndael.Padding = PaddingMode.Zeros
        myRijndael.Mode = CipherMode.CBC
        'myRijndael.KeySize = 256
        myRijndael.BlockSize = 256
        Dim encrypted() As Byte
        Dim toEncrypt() As Byte
        Dim key() As Byte
        Dim IV() As Byte
        key = System.Text.Encoding.ASCII.GetBytes(prm_key)
        IV = System.Text.Encoding.ASCII.GetBytes(prm_iv)

        Dim encryptor As ICryptoTransform = myRijndael.CreateEncryptor(key, IV)
        Dim msEncrypt As New MemoryStream()
        Dim csEncrypt As New CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)

        toEncrypt = System.Text.Encoding.UTF8.GetBytes(sToEncrypt)
        csEncrypt.Write(toEncrypt, 0, toEncrypt.Length)
        csEncrypt.FlushFinalBlock()

        encrypted = msEncrypt.ToArray()

        Return (Convert.ToBase64String(encrypted))

    End Function

    Private Sub MyForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If tutup = 0 Then
            e.Cancel = True
        End If
       
    End Sub


    Private Sub panelControl_Paint(sender As Object, e As PaintEventArgs) Handles panelControl.Paint

    End Sub

Private Sub Button1_Click_1( sender As Object,  e As EventArgs) 
        Dim strTmp As String = WebBrowser.Document.Url.ToString
        MsgBox(strTmp)
End Sub

    
End Class