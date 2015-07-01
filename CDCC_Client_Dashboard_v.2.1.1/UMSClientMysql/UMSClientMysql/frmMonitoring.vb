Imports System.Diagnostics
Imports MySql.Data.MySqlClient


Public Class frmMonitoring

    Dim starttime As String = Format(Now, "HH:mm:ss")
    '  Dim regdate As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
    ' Dim rate As Double
    ' Dim valueperminute As Double = Format(valueperminute, "0.00")
    Dim accttype As Integer

    Dim idapptracker As Boolean = True

    Private Sub frmMonitoring_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Stop()
    End Sub


    Private Sub frmMonitoring_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim x As Integer
        Dim y As Integer
        Dim baldays As Integer


        x = Screen.PrimaryScreen.WorkingArea.Width - 280
        y = Screen.PrimaryScreen.WorkingArea.Height - 760

        Me.Location = New Point(x, y)

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
        Payment = GetPayment(Duration, Rate, Valueperminute)
        lblpayment.Text = "RM" & Format(Payment, "0.00")


        If UserTypeId <> 1 Then
            baldays = GetFOCDaysBal(ICNo)
            If baldays > 0 Then
                lblbakihari.Visible = True
                lblbakihari2.Visible = True
                lblbakihari2.Text = baldays
            Else
                lblbakihari.Visible = False
                lblbakihari2.Visible = False
            End If
        End If

    End Sub
  
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Console.WriteLine("The frmMonitor Elapsed event was raised")
        Dim currtime As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
        Duration = GetCurrentDuration(Regdate, currtime)
        lblduration.Text = TimeDef(Duration)
        Payment = GetPayment(Duration, Rate, Valueperminute)
        lblpayment.Text = "RM" & Format(Payment, "0.00")
        ' TextBox1.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
        UpdateBrowsingLog(UserTypeId, ICNo, Rate, Duration, Payment, currtime)

        'If Type = 0 Then ' if prepaid, Type=0
        '    CheckPrepaidStatus(Payment)
        'End If

        'If accttype = 0 Then
        '    'prepaid 

        '    Dim balance As String

        '    balance = GetPrepaidBalance()


        '    'balance still cukup atau still in time, consider ok 
        '    If balance > Payment Then
        '        TextBox2.Text = "duit cukup masa pun ada lagi"

        '    Else

        '        TextBox2.Text = "prepaid habis ler atau masa dah habis"


        '        '//kena test blk ni

        '        Timer1.Stop()
        '        MsgBox("Ingin meneruskan ?", vbOKCancel)

        '        If MsgBoxResult.Ok Then
        '            'continue

        '        Else

        '            'tutuplah bile masa hbs



        '        End If

        '    End If

    End Sub

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


    '    'AppTracker()


    '    Dim start As String
    '    Dim duration As Integer
    '    Dim payment As Double

    '    start = lblstartdate.Text

    '    lblduration.Text = GetCurrentDuration(start)
    '    duration = removeChar(lblduration.Text)
    '    payment = GetPayment(duration, rate, valueperminute)
    '    lblpayment.Text = "RM" & Format(payment, "0.00")
    '    UpdateBrowsingLog(regdate)
    '    TextBox1.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")

    '    'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx


    '    If accttype = 0 Then
    '        'prepaid 

    '        Dim balance As String

    '        balance = GetPrepaidBalance()


    '        'balance still cukup atau still in time, consider ok 
    '        If balance > payment Then
    '            TextBox2.Text = "duit cukup masa pun ada lagi"

    '        Else

    '            TextBox2.Text = "prepaid habis ler atau masa dah habis"


    '            '//kena test blk ni

    '            Timer1.Stop()
    '            MsgBox("Ingin meneruskan ?", vbOKCancel)

    '            If MsgBoxResult.Ok Then
    '                'continue

    '            Else

    '                'tutuplah bile masa hbs



    '            End If

    '        End If


    '    End If


    '    'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx



    'End Sub


    'JJ , modified and move to modMain
    'Public Sub StartBrowsing(ByVal rate As Double, ByVal accttype As Integer)


    '    ''Dim conn As New MySqlConnection(strconn)
    '    Dim sqlcmd As New MySqlCommand
    '    ' Dim sqlreader As MySqlDataReader
    '    Dim acct As Integer


    '    If conn.State = ConnectionState.Open Then
    '        conn.Close()
    '    End If


    '    If IsSKMM() = True Then
    '        'registered as in SKMM mode
    '        acct = 0

    '    Else

    '        'registered as in PERSONAL mode
    '        acct = 1

    '    End If

    '    conn.Open()


    '    sqlcmd = conn.CreateCommand
    '    dr = dbRead("INsert into browsing (icno,pcno,rate_per_hour,time_start,time_end,acct,type,sendstatus,entry_dt) " & _
    '                           "values('" & ICNo & "','" & PcNo & "', " & rate & ",'" & regdate & "','" & regdate & "'," & acct & ", " & _
    '                           " " & accttype & ", 0,'" & regdate & "')")

    '    'sqlcmd.CommandType = CommandType.Text
    '    'sqlreader = sqlcmd.ExecuteReader



    '    dr.Close()
    '    conn.Close()

    '    lastbrowsingid = GetlastBrowsing() ' to get lastbrowsing id that was just inserted and assign to public var-lastbrowsingid

    'End Sub

    'Public Sub UpdateBrowsingLog(ByVal starttime As DateTime)

    '    'update time_end and modift_dt if not proper logout


    '    ' 'Dim conn As New MySqlConnection(strconn)
    '    Dim sqlcmd As New MySqlCommand
    '    'Dim sqlreader As MySqlDataReader
    '    Dim id As Integer
    '    Dim acct As Integer

    '    Dim acctstatus As Integer

    '    Dim currenttime As String = Format(Now, "yyyy-MM-dd HH:mm:ss")

    '    'If conn.State = ConnectionState.Open Then
    '    '    conn.Close()
    '    'End If

    '    'conn.Open()

    '    'get last row for this user
    '    id = GetlastBrowsing()

    '    'get latest acct mmode status
    '    acctstatus = GetAcctStatus(id)








    '    If IsSKMM() = True And acctstatus = 0 Then
    '        'still in SKMM mode
    '        'maintain acct = 0
    '        'login in SKMM mode

    '        'sqlcmd = conn.CreateCommand
    '        dr = dbRead("Update browsing  set time_end = '" & currenttime & "',mod_dt='" & currenttime & "' " & _
    '                              "where id = " & id & " and icno = '" & ICNo & "'")


    '        'sqlcmd.CommandType = CommandType.Text
    '        'sqlreader = sqlcmd.ExecuteReader


    '        dr.Close()


    '    ElseIf IsSKMM() = False And acctstatus = 0 Then

    '        'from skkmm change to personal
    '        'change to acct = 1
    '        'update <> user must logout from skmm mode


    '        'sqlcmd = conn.CreateCommand
    '        dr = dbRead("Update browsing  set browse_status= 1,mod_dt='" & currenttime & "' " & _
    '                              "where id = " & id & " and icno = '" & ICNo & "'")


    '        'sqlcmd.CommandType = CommandType.Text
    '        'sqlreader = sqlcmd.ExecuteReader


    '        dr.Close()

    '        acct = 1

    '        StartBrowsing(Rate, acct)

    '    ElseIf IsSKMM() = False And acctstatus = 1 Then

    '        'in personal mode 
    '        'remian acct = 1


    '        'sqlcmd = conn.CreateCommand
    '        dr = dbRead("Update browsing  set time_end = '" & currenttime & "',mod_dt='" & currenttime & "' " & _
    '                              "where id = " & id & " and icno = '" & ICNo & "'")


    '        'sqlcmd.CommandType = CommandType.Text
    '        'sqlreader = sqlcmd.ExecuteReader


    '        dr.Close()



    '    End If



    '    conn.Close()


    'End Sub
    Public Sub ValidateLanguange(ByVal lgid As Integer)

        If lgid = 1 Then

            lblnokp.Text = "No Kp Pengguna:" & lblKp.Text
            lblstarttime.Text = "Masa Mula:" & lblstartdate.Text
            lblpaid.Text = "Bayaran Sejam:" & lblcharge.Text
            lbltempoh.Text = "Tempoh Pengguna:" & lblduration.Text
            lblanggaran.Text = " Anggaran Bayaran:" & lblpayment.Text
            lblbakihari.Text = "Baki hari:" & lblbakihari2.Text


        ElseIf lgid = 2 Then

            lblnokp.Text = "User IC No:" & lblKp.Text
            lblstarttime.Text = "Start Time:" & lblstartdate.Text
            lblpaid.Text = "Rate per hour:" & lblcharge.Text
            lbltempoh.Text = "Usage:" & lblduration.Text
            lblanggaran.Text = "Payment Estimation:" & lblpayment.Text
            lblbakihari.Text = "Rem. days:" & lblbakihari2.Text

        End If

    End Sub


    'Public Function GetCurrentDuration(ByVal starttime As DateTime)

    '    Dim duration As String
    '    Dim currenttime As String = Format(Now, "yyyy-MM-dd HH:mm:ss")

    '    duration = TimeDiff(starttime, 1)

    '    Return duration

    'End Function


    Public Sub btnout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnout.Click
        Logout()
        frmMain.Show()
        Me.Close()

    End Sub

    'Public Function IsSKMM() As Boolean

    '    Dim yes As Boolean



    '    'ni tak sepatutnya mcm ni.get frm db 
    '    If (Now.Hour >= 9 Or Now.Hour <= 18) And Now.Minute >= 0 And Now.Second >= 0 Then

    '        yes = True

    '    Else
    '        yes = False


    '    End If


    '    Return yes

    'End Function

    'Public Function GetPayment(ByVal duration As Integer, ByVal rate As Double, ByVal valueperminute As Double) As Double

    '    Dim payment As Double



    '    If duration <= 5 Then
    '        'first 5 minute is free

    '        payment = 0

    '    ElseIf duration = 60 Then
    '        '1 hour usage

    '        payment = rate


    '    Else


    '        '  payment = duration * rate

    '        payment = duration * valueperminute



    '    End If





    '    Return payment

    'End Function

    'Public Sub Logout(ByVal starttime As DateTime)


    '    ' 'Dim conn As New MySqlConnection(strconn)
    '    Dim sqlcmd As New MySqlCommand
    '    ' Dim sqlreader As MySqlDataReader
    '    Dim id As Integer
    '    Dim logoutdate As String = Format(Now, "yyyy-MM-dd HH:mm:ss")

    '    'If conn.State = ConnectionState.Open Then
    '    '    conn.Close()
    '    'End If


    '    'conn.Open()

    '    'get last row for this user
    '    id = GetlastBrowsing()



    '    ' sqlcmd = conn.CreateCommand
    '    dr = dbRead("Update browsing  set sendstatus = 0,time_end = '" & logoutdate & "' ,browse_status = 1,mod_dt='" & logoutdate & "' " & _
    '                          "where id = " & id & " and icno = '" & ICNo & "'")


    '    'sqlcmd.CommandType = CommandType.Text
    '    'sqlreader = sqlcmd.ExecuteReader




    '    dr.Close()
    '    conn.Close()


    'End Sub
    'Public Sub AppTracker()

    '    Dim procList() As Process = Process.GetProcesses()
    '    Dim i As Integer

    '    Dim strdata As String


    '    On Error Resume Next

    '    For i = 0 To 200 - 1 Step i + 1


    '        Dim strProcName As String = procList(i).ProcessName
    '        Dim iProcID As Integer = procList(i).Id
    '        Dim strmodule As String = procList(i).MainWindowTitle
    '        Dim strMainModule As String = procList(i).MainModule.ToString

    '        '   GetCurrentUrl(proc.MainWindowHandle, browserName, className, ComboBox1)

    '        strdata = iProcID & "|" & strProcName & "|" & strmodule & "|" & strMainModule

    '        If GetApp(strProcName) = True Then

    '            WriteToFile(strdata, fullpath)

    '        End If

    '    Next

    'End Sub

    Private Sub btnmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmin.Click

        ''Me.WindowState = FormWindowState.Minimized

        'frmMinMonitoring.Show()
        'Me.Close()

    End Sub

    Private Sub btn_bypass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bypass.Click
        frm_user_record.Show()

    End Sub
End Class