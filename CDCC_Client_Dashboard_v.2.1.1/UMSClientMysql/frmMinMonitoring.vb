Imports System.Diagnostics
Imports MySql.Data.MySqlClient
Public Class frmMinMonitoring

    Dim starttime As String = Format(Now, "HH:mm:ss")
    '  Dim regdate As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
    '   Dim rate As Double
    ' Dim valueperminute As Double = Format(valueperminute, "0.00")
    Dim accttype As Integer

    Dim idapptracker As Boolean = True

    Private Sub frmMinMonitoring_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Stop()
    End Sub

    Private Sub frmMinMonitoring_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim x As Integer
        Dim y As Integer

        x = Screen.PrimaryScreen.WorkingArea.Width - 600
        y = Screen.PrimaryScreen.WorkingArea.Height - 80

        Me.Location = New Point(x, y)

        Timer1.Interval = 60000
        FormTimerInterval = Timer1.Interval ' to assign the form timer interval to public var- FormTimerInterval
        Timer1.Enabled = True

        ValidateLanguange(lgId)

        lblKp.Text = ICNo
        lblstartdate.Text = Regdate

        lblcharge.Text = "RM" & Format(Rate, "0.00")

        Duration = GetCurrentDuration(Regdate, Now)
        lblduration.Text = TimeDef(Duration)
        lblpayment.Text = "RM" & Format(Payment, "0.00")


        'lblKp.Text = ICNo
        'lblstartdate.Text = regdate

        'rate = GetRate()
        'lblcharge.Text = "RM" & Format(rate, "0.00")

        'accttype = GetAcctType()


        ''frmMonitoring.StartBrowsing(rate, accttype)

        'valueperminute = rate / 60


        'SiteCode = GetSiteCode()
    End Sub


    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


    '    '  frmmonitoring.AppTracker()


    '    Dim start As String
    '    Dim duration As Integer
    '    Dim payment As Double

    '    start = lblstartdate.Text

    '    '     lblduration.Text = frmMonitoring.GetCurrentDuration(start)

    '    duration = removeChar(lblduration.Text)


    '    payment = frmMonitoring.GetPayment(duration, rate, valueperminute)

    '    lblpayment.Text = "RM" & Format(payment, "0.00")


    '    frmMonitoring.UpdateBrowsingLog(regdate)


    '    TextBox2.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")


    'End Sub

   

    Private Sub btnout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnout.Click
        frmMonitoring.Show()
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Console.WriteLine("The frmMinMonitor Elapsed event was raised")
        Dim currtime As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
        Duration = GetCurrentDuration(Regdate, currtime)

        lblduration.Text = TimeDef(Duration)
        Payment = GetPayment(Duration, Rate, Valueperminute)
        lblpayment.Text = "RM" & Format(Payment, "0.00")

        UpdateBrowsingLog(UserTypeId, ICNo, Rate, Duration, Payment, currtime)

        'If Type = 0 Then ' if prepaid, Type=0
        '    CheckPrepaidStatus(Payment)
        'End If

    End Sub

    Public Sub ValidateLanguange(ByVal lgid As Integer)

        If lgid = 1 Then

            lblnokp.Text = "No Kp Pengguna:" & lblKp.Text
            lblstarttime.Text = "Masa Mula:" & lblstartdate.Text
            lblpaid.Text = "Bayaran Sejam:" & lblcharge.Text
            lbltempoh.Text = "Tempoh Pengguna:" & lblduration.Text
            lblanggaran.Text = " Anggaran Bayaran:" & lblpayment.Text
            '    lblbakihari.Text = "Baki hari:" & lblbakihari2.Text


        ElseIf lgid = 2 Then

            lblnokp.Text = "User IC No:" & lblKp.Text
            lblstarttime.Text = "Start Time:" & lblstartdate.Text
            lblpaid.Text = "Rate per hour:" & lblcharge.Text
            lbltempoh.Text = "Usage:" & lblduration.Text
            lblanggaran.Text = "Payment Estimation:" & lblpayment.Text
            '    lblbakihari.Text = "Rem. days:" & lblbakihari2.Text

        End If

    End Sub
End Class