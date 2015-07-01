Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net.Sockets
Imports System.Timers
Imports System.Windows.Automation
Imports BytesRoad.Net.Ftp



Module modMain

    '   Public strconn As String = "Server=localhost;Uid=sa;Pwd=password;Database=ums;"

    Public lgId As Integer = 1
    Public ICNo As String
    Public UserType As Integer
    Public UserTypeId As Integer
    Public FileName As String = "ipserver.txt"
    Public PcNo As String
    Public IpServer As String = ""
    Public ipChatServer As String = "" '//anb0508
    Public SiteCode As String

    Public appStatus As String '// keep the current UMS Client Application Status

    Public clientSocket As New System.Net.Sockets.TcpClient()
    Public serverStream As NetworkStream
    Public readData As String
    Public fullpath As String = My.Application.Info.DirectoryPath + "\"

    Public conn As MySqlConnection
    Public dr As MySqlDataReader
    Public strconn As String = "" '//anb0508

    'JJ
    Public ELogTimer As System.Timers.Timer
    Public FiveMinLogoutTimer As System.Timers.Timer
    Public ELogDir As String = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\ftp\"
    Public ElogFilename As String ' = ICNo + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt"
    Public ELogFile As String ' = ELogDir + ElogFilename
    Public eventlog As StreamWriter
    Public GFFurl As String = ""
    Public GIEurl As String = ""
    Public GCHurl As String = ""
    Public Lastbrowsingid As Integer
    Public AppTrackerList As DataTable

    Public Regdate As String ' browsing start time
    Public Rate As Double ' browsing rate for user
    Public Payment As Double ' payment as of now from start time.
    Public Balance As Double ' prepaid balance
    Public Type As Integer = 1  ' browsing type , 0 prepaid , 1 postpaid
    Public Duration As Integer
    Public Valueperminute As Double = Format(Valueperminute, "0.00")
    Public usageTimer As System.Timers.Timer
    Public Skmm_start As String = ""
    Public Skmm_end As String = ""
    Public FormTimerInterval As Integer
    Public FiveMinTimer As Integer '
    Public PrepaidMsgCnt As Integer

    Public NowSvrTime As DateTime


    Private Property cmbTransport As Object


    Public Function dbRead(ByVal strSQL As String) As MySqlDataReader  '// set connection with database 

        ''Dim conn As New MySqlConnection(strconn)
        conn = New MySqlConnection(strconn)
        Dim dr As MySqlDataReader
        Try

            If conn.State = ConnectionState.Open Then   '// if connection still open, do close

                conn.Close()

            End If

            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Error while connecting to the Database." + vbCrLf + "Please check your Application setting." + vbCrLf + _
                           "System Error Messange : " + ex.Message)

            'If frm_login.IsAccessible Then              '// if no connection from database, button setting IP will visible
            '    frm_login.btn_setting.Visible = True
            'End If

            conn.Close()

            Return Nothing

            Exit Function
        End Try

        Dim cmd As New MySqlCommand(strSQL, conn)

        Try
            'If conn.State = ConnectionState.Open Then   '// if connection still open, do close

            '    conn.Close()

            'End If

            'conn.Open()
            dr = cmd.ExecuteReader
        Catch ex As Exception
            MessageBox.Show("Error while executing SQL statement. Please check your Query." + vbCrLf + _
               "System Error Messange : " + ex.Message + vbCrLf + _
               "SQL Query : " + strSQL.ToString)


            Return Nothing

            Exit Function

        End Try

        Return dr

    End Function

    
    Public Sub BindState(ByVal cmbstate As ComboBox)

        'Dim conn As New MySqlConnection(strconn)
        Dim strSQL As String = "SELECT name,id FROM states"
        Dim da As New MySqlDataAdapter(strSQL, conn)
        Dim ds As New DataSet
        da.Fill(ds, "name")

        With cmbstate
            .DataSource = ds.Tables("name")
            .DisplayMember = "name"
            .ValueMember = "id"
            '.SelectedIndex = 0
        End With

    End Sub

    Public Sub BindRace(ByVal cmbRace As ComboBox, ByVal lgid As String)

        Dim lgname As String
        Dim strSQL As String = ""

        lgname = checklanguange(lgid)

        'Dim conn As New MySqlConnection(strconn)

        If lgname = "bm" Then

            strSQL = "SELECT bm, id FROM races"

        ElseIf lgname = "eng" Then

            strSQL = "SELECT eng , id FROM races"

        End If

        Dim da As New MySqlDataAdapter(strSQL, conn)
        Dim ds As New DataSet
        da.Fill(ds, lgname)

        With cmbRace
            .DataSource = ds.Tables(lgname)
            .DisplayMember = lgname
            .ValueMember = "id"
            '.SelectedIndex = 0
        End With

    End Sub

    Public Function checklanguange(ByVal lgid As Integer) As String


        Dim lgname As String = ""

        If lgid = 1 Then

            lgname = "bm"

            'Return lgname

        ElseIf lgid = 2 Then

            lgname = "eng"

            'Return lgname


        End If
        Return lgname

    End Function
    Public Sub BindOccupation(ByVal cmbOccu As ComboBox, ByVal lgid As String)

        Dim lgname As String
        Dim strSQL As String = ""

        lgname = checklanguange(lgid)

        'Dim conn As New MySqlConnection(strconn)

        If lgname = "bm" Then

            strSQL = "SELECT bm, id FROM occupations"

        ElseIf lgname = "eng" Then

            strSQL = "SELECT eng , id FROM occupations"

        End If

        Dim da As New MySqlDataAdapter(strSQL, conn)
        Dim ds As New DataSet
        da.Fill(ds, lgname)

        With cmbOccu
            .DataSource = ds.Tables(lgname)
            .DisplayMember = lgname
            .ValueMember = "id"
            '.SelectedIndex = 0
        End With


    End Sub

    Public Sub BindGender(ByVal cmbGender As ComboBox, ByVal lgid As String)


        Dim lgname As String
        Dim strSQL As String = ""

        lgname = checklanguange(lgid)

        'Dim conn As New MySqlConnection(strconn)

        If lgname = "bm" Then

            strSQL = "SELECT bm, id FROM genders"

        ElseIf lgname = "eng" Then

            strSQL = "SELECT eng , id FROM genders"

        End If

        Dim da As New MySqlDataAdapter(strSQL, conn)
        Dim ds As New DataSet
        da.Fill(ds, lgname)

        With cmbGender
            .DataSource = ds.Tables(lgname)
            .DisplayMember = lgname
            .ValueMember = "id"
            '.SelectedIndex = 0
        End With




    End Sub

    Public Sub BindNationality(ByVal cmbGender As ComboBox, ByVal lgid As String)


        Dim lgname As String
        Dim strSQL As String = ""

        lgname = checklanguange(lgid)

        'Dim conn As New MySqlConnection(strconn)

        If lgname = "bm" Then

            strSQL = "SELECT bm, id FROM nationalities"

        ElseIf lgname = "eng" Then

            strSQL = "SELECT eng , id FROM nationalities"

        End If

        Dim da As New MySqlDataAdapter(strSQL, conn)
        Dim ds As New DataSet
        da.Fill(ds, lgname)

        With cmbGender
            .DataSource = ds.Tables(lgname)
            .DisplayMember = lgname
            .ValueMember = "id"
            '.SelectedIndex = 0
        End With




    End Sub


    Public Sub BindEducation(ByVal cmbEdu As ComboBox, ByVal lgid As String)

        Dim lgname As String
        Dim strSQL As String = ""

        lgname = checklanguange(lgid)

        'Dim conn As New MySqlConnection(strconn)

        If lgname = "bm" Then

            strSQL = "SELECT bm, id FROM educations"

        ElseIf lgname = "eng" Then

            strSQL = "SELECT eng , id FROM educations"

        End If

        Dim da As New MySqlDataAdapter(strSQL, conn)
        Dim ds As New DataSet
        da.Fill(ds, lgname)

        With cmbEdu
            .DataSource = ds.Tables(lgname)
            .DisplayMember = lgname
            .ValueMember = "id"
            '.SelectedIndex = 0
        End With




    End Sub


    Public Sub BindIncome(ByVal cmbIncome As ComboBox, ByVal lgid As String)

        Dim lgname As String
        Dim strSQL As String = ""

        lgname = checklanguange(lgid)

        'Dim conn As New MySqlConnection(strconn)

        If lgname = "bm" Then

            strSQL = "SELECT bm, id FROM income"

        ElseIf lgname = "eng" Then

            strSQL = "SELECT eng , id FROM income"

        End If

        Dim da As New MySqlDataAdapter(strSQL, conn)
        Dim ds As New DataSet
        da.Fill(ds, lgname)

        With cmbIncome
            .DataSource = ds.Tables(lgname)
            .DisplayMember = lgname
            .ValueMember = "id"
            '.SelectedIndex = 0
        End With

    End Sub
    Public Sub BindTypeMember(ByVal cmbUserType As ComboBox, ByVal lgid As String) '// read from database - table usertypes--- data will insert into combobox

        Dim lgname As String
        Dim strSQL As String = ""

        lgname = checklanguange(lgid)

        'Dim conn As New MySqlConnection(strconn)

        If lgname = "bm" Then

            strSQL = "SELECT bm,id FROM usertypes order by id"

        ElseIf lgname = "eng" Then

            strSQL = "SELECT eng , id FROM usertypes order by id"

        End If

        Dim da As New MySqlDataAdapter(strSQL, conn)
        Dim ds As New DataSet
        da.Fill(ds, lgname)

        With cmbUserType
            .DataSource = ds.Tables(lgname)
            .DisplayMember = lgname
            .ValueMember = "id"
            ' .SelectedIndex = -1
        End With


        conn.Close()
    End Sub

    Public Sub BindTransport(ByVal cmbTransport As ComboBox, ByVal lgid As Integer) '// read from database - table transports--- data will insert into combobox
        Dim lgname As String
        Dim strSQL As String = ""

        lgname = checklanguange(lgId)

        'Dim conn As New MySqlConnection(strconn)

        If lgname = "bm" Then

            strSQL = "SELECT bm,id FROM  transports order by id"

        ElseIf lgname = "eng" Then

            strSQL = "SELECT eng , id FROM  transports order by id"

        End If

        Dim da As New MySqlDataAdapter(strSQL, conn)
        Dim ds As New DataSet
        da.Fill(ds, lgname)

        With cmbTransport
            .DataSource = ds.Tables(lgname)
            .DisplayMember = lgname
            .ValueMember = "id"
            ' .SelectedIndex = -1
        End With

        conn.Close()
    End Sub

    Public Sub BindKnowledge(ByVal cmbKnowledge As ComboBox, ByVal lgid As Integer) '// read from database - table transports--- data will insert into combobox
        Dim lgname As String
        Dim strSQL As String = ""

        lgname = checklanguange(lgid)

        'Dim conn As New MySqlConnection(strconn)

        If lgname = "bm" Then

            strSQL = "SELECT bm,id FROM ictknowledges order by id"

        ElseIf lgname = "eng" Then

            strSQL = "SELECT eng , id FROM  ictknowledges order by id"

        End If

        Dim da As New MySqlDataAdapter(strSQL, conn)
        Dim ds As New DataSet
        da.Fill(ds, lgname)

        With cmbKnowledge
            .DataSource = ds.Tables(lgname)
            .DisplayMember = lgname
            .ValueMember = "id"
            ' .SelectedIndex = -1
        End With

        conn.Close()
    End Sub
    Public Function ValidateUSer(ByVal ic As String) As Boolean


        Dim sqlcmd As New MySqlCommand
        
        dr = dbRead("SELECT * FROM userdetails where icNo = '" & ic & "' ")

        If dr.Read Then
            Return True
        Else
            Return False


        End If

        dr.Close()
        conn.Close()



    End Function

    Public Function GetUserType(ByVal icno As String) As Integer


        Dim sqlcmd As New MySqlCommand
        Dim type As Integer

       
        dr = dbRead("SELECT usertype_id FROM userdetails where icNo = '" & icno & "' ")
      

        If dr.Read Then


            type = dr(0)

        End If

        dr.Close()
        conn.Close()

        Return type


    End Function

    Public Function GetlastBrowsing(ByVal ICNo As String, ByVal PcNo As String) As Integer
       
        Dim sqlcmd As New MySqlCommand
        Dim lastrow As Integer


        dr = dbRead("SELECT id  FROM browsing where icNo = '" & ICNo & "' and pcno = '" & PcNo & "' and browse_status = 0 order by id desc limit 1")
      

        If dr.Read Then

            lastrow = dr(0)
        Else

            lastrow = ""

        End If

        dr.Close()
        conn.Close()

        Return lastrow


    End Function
    Public Function GetAcctStatus(ByVal id) As Integer

        ' find acct = 0
        Dim dr As MySqlDataReader
        Dim sqlcmd As New MySqlCommand
        Dim acct As Integer

      
        dr = dbRead("SELECT acct  FROM browsing where icNo = '" & ICNo & "' and browse_status = 0 and id = '" & id & "' order by id desc limit 1")


        If dr.Read Then

            acct = dr(0)
        Else

            acct = ""

        End If

        dr.Close()
        conn.Close()

        Return acct

    End Function
    Public Function GetSiteCode() As String

        ' find acct = 0


        Dim sqlcmd As New MySqlCommand
        Dim SiteCode As String

        dr = dbRead("SELECT systemcode  FROM systemname limit 1")

        If dr.Read Then

            SiteCode = dr(0)
        Else

            SiteCode = ""

        End If

        dr.Close()
        conn.Close()

        Return SiteCode


    End Function

    Public Function GetApp(ByVal appname As String) As Boolean

        Dim sqlcmd As New MySqlCommand

        appname = appname & ".exe"

        dr = dbRead("SELECT appName FROM apptrackers where appname = '" & appname & "' ")

        If dr.Read = True Then

            Return True

        Else

            Return False

        End If


        dr.Close()
        conn.Close()



    End Function
    Public Function GetBlacklistApp(ByVal appname As String) As Boolean


        appname = appname & ".exe"

        dr = dbRead("SELECT appname FROM blacklists where appname = '" & appname & "' ")

        If dr.Read = True Then

            Return True

        Else

            Return False

        End If


        dr.Close()
        conn.Close()



    End Function
    Public Function GetRateValue(ByVal usertypeID As Integer, ByVal ICNo As String) As Double

        Dim rateValue As Double
        Dim bal_days As Integer
        Dim bal_time As Integer

        bal_days = GetFOCDaysBal(ICNo)
        bal_time = GetTodayFOCTimeBal(ICNo)

        If IsSKMM() = False Then 'Non-SKMM time
            dr = dbRead("Select value from charges where ID = 1") 'fixed flat rate for Non-SKMM time
        Else 'SKMM time
            If usertypeID = 1 Then 'if visitor
                dr = dbRead("Select value from charges where ID = 3") 'visitor rate on SKMM time
            Else 'for member  whereby usertypeid <> 1
                If bal_days > 0 Then
                    If bal_time > 0 Then
                        dr = dbRead("Select 0 from charges where ID = 2") 'if not put dbread, next db.read step will become error.
                    Else
                        dr = dbRead("Select value from charges where ID = 2") ' member rate on SKMM time
                    End If
                Else
                    dr = dbRead("Select value from charges where ID = 2") ' member rate on SKMM time
                End If
            End If
        End If

        If dr.Read = True And dr(0) IsNot DBNull.Value Then
            rateValue = dr(0)
        Else
            rateValue = 0
        End If

        dr.Close()
        conn.Close()

        Return rateValue
    End Function

    Public Function GetFOCDaysBal(ByVal ICNo As String) As Integer
        Dim Days As Integer
        Dim dr As MySqlDataReader
        'Dim str As String

        'str = "select a.member_freedays-(datediff(now(),b.registered_date))" +
        '            " from settings a,userdetails b" +
        '            " where b.icno = '771216086444' ='" & ICNo & "' "




        dr = dbRead("select a.member_freedays-(datediff(now(),b.registered_date))" +
                    " from settings a,userdetails b" +
                    " where b.icno ='" & ICNo & "' ")

        If dr.Read = True Then
            If dr(0) >= 0 Then
                Days = dr(0)
            Else ' dont wanna show -ve value
                Days = 0
            End If
        Else
            Days = 0
        End If

        dr.Close()
        conn.Close()

        Return Days
    End Function

    Public Function GetTodayFOCTimeBal(ByVal ICNo As String) As Integer ' return bal time in minutes
        Dim FOCbal As Integer  'bal in minutes
        Dim FOCtime As Integer 'time in minutes

        'dr = dbRead("select member_freehour*(60*60) member_freehour ,member_freehour*(60*60)-(select sum(time_end-time_start) " +
        '            "from(browsing) " +
        '            "where(rate_per_hour = 0) " +
        '            "and icno ='" & ICNo & "' " +
        '            "and date(time_start) = current_date()) as bal " +
        '            "from settings")

        dr = dbRead("select member_freehour*(60*60) member_freehour,member_freehour*(60*60)-(select sum(TIMESTAMPDIFF(second,time_start,time_end)) " +
                    "from browsing " +
                    "where(rate_per_hour = 0) " +
                    "and icno ='" & ICNo & "' " +
                    "and date(time_start) = current_date())  as bal " +
                    "from settings")

        If dr.Read Then
            If dr("member_freehour") Is DBNull.Value Then
                FOCtime = 0
            Else
                FOCtime = dr("member_freehour")
            End If

            If dr("bal") Is DBNull.Value Then
                FOCbal = FOCtime
            ElseIf dr("bal") < 0 Then
                FOCbal = 0
            Else
                FOCbal = dr("bal")
            End If
        Else
            FOCbal = 0
            FOCtime = 0
        End If

        dr.Close()
        conn.Close()

        Return FOCbal
    End Function
    'Public Function GetFOCTime() As Integer
    '    Dim FOCtime As Integer

    '    dr = dbRead("select member_freehour*(60*60)" +
    '                "from settings")  ' getting member free hour in seconds



    '    If dr.Read = True Then
    '        If dr(0) Is DBNull.Value Then
    '            FOCtime = 0
    '        Else
    '            FOCtime = dr(0)
    '        End If
    '    Else
    '        FOCtime = 0
    '    End If


    '    dr.Close()
    '    conn.Close()

    '    Return FOCtime
    'End Function



    Public Function GetChargeType(ByVal usertype As Integer) As Double

        Dim charge As Double

        dr = dbRead("SELECT chargevalue FROM charges where usertype = " & usertype & "")

        If dr.Read Then


            charge = dr(0)
        Else

            charge = dr(0)

        End If

        dr.Close()
        conn.Close()

        Return charge


    End Function



    Public Function GetSystemName() As String

        Dim sqlcmd As New MySqlCommand
        Dim name As String



        Try
          
            dr = dbRead("SELECT systemname FROM systemname")
           

            dr.Read()

            name = dr(0)

            dr.Close()
        Catch ex As Exception
            MsgBox(strconn & vbCrLf & ex.Message)
            name = "ERROR"
        End Try



        Return name


    End Function

    Public Function GetUsageLimit() As String


        Dim sqlcmd As New MySqlCommand
        Dim limit As String


        dr = dbRead("SELECT usageduration FROM settings")
      
        If dr.Read Then


            limit = dr(0)

        End If

        dr.Close()
        conn.Close()

        Return limit


    End Function

    Public Sub useServerConn(ByVal strIP As String) '//anb0508
        strconn = "Server=" & strIP & ";Uid=dewi;Pwd=password;Database=ums;Pooling=false;"

        'strconn = "Server=192.168.9.184;Uid=dewi;Pwd=password;Database=ums;"
    End Sub

    'Function TimeDiff(ByVal Starttime As Date, ByVal Type As Integer) As String
    '    Dim hour As Integer
    '    Dim minute As Integer
    '    Dim day As Integer
    '    Dim tempTime As String

    '    tempTime = DateDiff(DateInterval.Minute, Starttime, Now)

    '    hour = Int(tempTime / 60)
    '    minute = tempTime Mod 60
    '    day = Int(hour / 24)
    '    If Type = 1 Then
    '        If hour > 23 Then
    '            hour = hour Mod 24
    '            Return day & "hari" & hour & "jam " & minute & " minit "
    '        ElseIf hour > 0 And hour < 24 Then
    '            Return hour & "jam " & minute & " minit "
    '        Else
    '            Return minute & " minit"
    '        End If
    '    Else
    '        If hour > 23 Then
    '            hour = hour Mod 24
    '            Return day & "hari " & hour & "jam " & minute & " minit "
    '        ElseIf hour > 0 And hour < 24 Then
    '            Return hour & "jam " & minute & " minit "
    '        Else
    '            Return minute & " minit "
    '        End If
    '    End If

    'End Function
    Function TimeDef(ByVal tempTime As Integer) As String
        Dim hour As Integer
        Dim minute As Integer
        Dim day As Integer

        hour = Int(tempTime / 60)
        minute = tempTime Mod 60
        day = Int(hour / 24)
        If lgId = 1 Then
            If hour > 23 Then
                hour = hour Mod 24
                Return day & " hari" & hour & " jam " & minute & " minit "
            ElseIf hour > 0 And hour < 24 Then
                Return hour & " jam " & minute & " minit "
            Else
                Return minute & " minit"
            End If
        Else
            If hour > 23 Then
                hour = hour Mod 24
                Return day & " day(s) " & hour & " hour(s) " & minute & " minute(s) "
            ElseIf hour > 0 And hour < 24 Then
                Return hour & " hour(s) " & minute & "  minute(s) "
            Else
                Return minute & " minute(s) "
            End If
        End If

    End Function



    Public Function GetRate(ByVal ICNo As String) As Double

        Dim rate As Double

        UserTypeId = GetUserType(ICNo)

        rate = GetRateValue(UserTypeId, ICNo)

        Return rate

    End Function

    Public Function GetPrepaidBalance() As Double

        ''Dim conn As New MySqlConnection(strconn)
        'Dim sqlcmd As New MySqlCommand
        'Dim sqlreader As MySqlDataReader
        Dim balance As Double



        'If conn.State = ConnectionState.Open Then

        '    conn.Close()

        'End If

        'conn.Open()
        'sqlcmd = conn.CreateCommand
        dr = dbRead("SELECT balance FROM prepaid where icno =  '" & ICNo & "' order by id  desc limit 1")
        'sqlcmd.CommandType = CommandType.Text
        'sqlreader = sqlcmd.ExecuteReader


        If dr.Read = True Then


            balance = dr(0)

        Else

            balance = 0.0


        End If


        dr.Close()
        conn.Close()

        Return balance

    End Function

    Public Function GetAcctType() As Integer

        Dim accttype As Integer


        dr = dbRead("SELECT u.icno FROM userdetails u , prepaid p where u.icno = p.icno and u.icno = '" & ICNo & "'")
      

        If dr.Read = True Then

            'prepaid
            accttype = 0

        Else

            'postpaid
            accttype = 1


        End If


        dr.Close()
        conn.Close()

        Return accttype

    End Function




    Public Function ReadFile(ByVal Failname As String) As String

        '  Dim FILE_NAME As String = fullpath & Failname

        Dim FILE_NAME As String = Failname

        Dim TextLine As String

        ' Dim hostname As String
        Dim strdata As String = ""
        'Dim subnetmask As String
        'Dim defaultgateway As String

        Dim delimiter As String
        'Dim arrobj As Object

        Dim arrdata As New ArrayList
        'Dim objdata As Object
        delimiter = "|"

        If System.IO.File.Exists(FILE_NAME) = True Then

            Dim objReader As New System.IO.StreamReader(FILE_NAME)

            Do While objReader.Peek() <> -1

                TextLine = objReader.ReadLine()


                'objdata = Split(TextLine, " ")
                'strdata = objdata(0)

                strdata = TextLine

            Loop

            objReader.Close()

        Else

            strdata = "File Does Not Exist"


        End If

        Return strdata


    End Function


    Public Function removeChar(ByVal duration) As String

        duration = Replace(duration, "minit", "")
        duration = Replace(duration, "jam", "")
        duration = Replace(duration, "hari", "")

        Return Trim(duration)
    End Function

    Public Function Getconnected() As Boolean
        If clientSocket.Connected = True Then
            clientSocket.Close()

        End If
        ' msg()
        Try

            clientSocket.Connect(ipChatServer, 8888)
            '  clientSocket.Connect("192.168.9.184", 8888)

            'Label1.Text = "Client Socket Program - Server Connected ..."
            serverStream = clientSocket.GetStream()

            'System.Text.Encoding.ASCII.GetBytes("C0" + PcNo + "Joined" + "$")

            Dim outStream As Byte() = _
            System.Text.Encoding.ASCII.GetBytes("C" + Format(Val(PcNo), "00") + "$") '//-anbEdit
            serverStream.Write(outStream, 0, outStream.Length)
            serverStream.Flush()

            Dim ctThread As Threading.Thread = New Threading.Thread(AddressOf frmMain.getMessage)
            ctThread.Start()
            Return True
        Catch ex As Exception

            'MsgBox("IP Chat Server Not Connected!")


        End Try
        Return False
    End Function



    Public Sub sendData(ByVal strMsg As String) '//-anbEdit
        'Dim outStream As Byte() = System.Text.Encoding.ASCII.GetBytes(strMsg + "$")
        'serverStream.Write(outStream, 0, outStream.Length)
        'serverStream.Flush()


        Dim outStream As Byte() = System.Text.Encoding.ASCII.GetBytes(strMsg + "$")

        Try
            serverStream.Write(outStream, 0, outStream.Length)
            serverStream.Flush()
        Catch ex As Exception

        End Try

        Console.WriteLine("strMsg {0}", strMsg)

    End Sub

    Public Sub PCStatus()


        '//-anbEdit



        Dim strMsg As String = "STAT|" + appStatus

        sendData(strMsg)





    End Sub

    Private Sub msg()
        If frmChat.InvokeRequired Then
            frmChat.Invoke(New MethodInvoker(AddressOf msg))
        Else
            frmChat.txthistory.Text = frmChat.txthistory.Text + Environment.NewLine + " >> " + readData
        End If
    End Sub


    Public Sub EventLogTracker(ByVal iProcID As Integer, ByVal strProcName As String, ByVal strmodule As String)


        ''Dim conn As New MySqlConnection(strconn)
        'Dim sqlcmd As New MySqlCommand
        'Dim sqlreader As MySqlDataReader

        'Dim strdata As String

        Dim procList() As Process = Process.GetProcesses()
        'Dim i As Integer


        Dim regdate As String = Format(Now, "yyyy-MM-dd HH:mm:ss")


        'If conn.State = ConnectionState.Open Then
        '    conn.Close()
        'End If


        'conn.Open()

        'sqlcmd = conn.CreateCommand
        dr = dbRead("INsert into eventlogs (pcno,appid,module,entry_dt,process) " & _
                              "values( '" & PcNo & "', " & iProcID & ",'" & strmodule & "','" & regdate & "','" & strProcName & "')")

        'sqlcmd.CommandType = CommandType.Text
        'sqlreader = sqlcmd.ExecuteReader



        dr.Close()
        conn.Close()


    End Sub


    Public Function GetProcessName(ByVal id As Integer) As String

        ' 'Dim conn As New MySqlConnection(strconn)
        'Dim sqlcmd As New MySqlCommand
        'Dim sqlreader As MySqlDataReader
        Dim process As String = ""

        'If conn.State = ConnectionState.Open Then

        '    conn.Close()

        'End If


        'conn.Open()
        'sqlcmd = conn.CreateCommand
        dr = dbRead("SELECT process from eventlogs where appid = '" & id & "'")
        'sqlcmd.CommandType = CommandType.Text
        'sqlreader = sqlcmd.ExecuteReader


        If dr.Read = True Then


            process = dr(0)


        End If


        dr.Close()
        conn.Close()

        Return process

    End Function

    Public Sub ElogTimerAndSetting() ' JJ , start timer to track eventlog

        OpenELogFile()  'to open text file to write app and url been tracked


        AppTrackerList = ExecuteDataTable("select processname from apptrackers") 'to get list of applications to track


        ' Normally, the timer is declared at the class level,
        ' so that it stays in scope as long as it is needed.
        ' If the timer is declared in a long-running method,  
        ' KeepAlive must be used to prevent the JIT compiler 
        ' from allowing aggressive garbage collection to occur 
        ' before the method ends. You can experiment with this
        ' by commenting out the class-level declaration and 
        ' uncommenting the declaration below; then uncomment
        ' the GC.KeepAlive(aTimer) at the end of the method.
        'Dim aTimer As System.Timers.Timer

        ' Create a timer 
        ELogTimer = New System.Timers.Timer()

        ' Hook up the Elapsed event for the timer.
        AddHandler ELogTimer.Elapsed, AddressOf ELogTimer_Event

        ' Set the Interval to 2 seconds (2000 milliseconds).
        ELogTimer.Interval = 5000
        ELogTimer.Enabled = True

        'Console.WriteLine("Press the Enter key to exit the program.")
        'Console.ReadLine()

        ' If the timer is declared in a long-running method, use
        ' KeepAlive to prevent garbage collection from occurring
        ' before the method ends.

        GC.KeepAlive(ELogTimer)
    End Sub
    Public Sub ELogTimer_Event(ByVal source As Object, ByVal e As ElapsedEventArgs) ' JJ , eventlog timer event
        BrowserTracker() 'to track browser with the url
        AppTracker() 'to track applications running based on apps listed in apptrackers table
        Console.WriteLine("The Eventlog Timer Elapsed event was raised at {0}", e.SignalTime)
    End Sub

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


    Public Sub AppTracker() 'JJ version
        Dim i As Integer
        Dim runningProcess As Boolean
        Dim currProcess As Process()
        Dim eProcess As Process
        Dim strCurrApp As String

        'table AppTrackerList containing applications list 
        For i = 0 To AppTrackerList.Rows.Count - 1
            runningProcess = IsProcessOpen(AppTrackerList.Rows(i)(0).ToString) 'to check whether the app is running or not
            If runningProcess = True Then
                currProcess = Process.GetProcessesByName(AppTrackerList.Rows(i)(0).ToString)
                For Each eProcess In currProcess
                    strCurrApp = AppTrackerList.Rows(i)(0).ToString & "<|>" & eProcess.MainWindowTitle & "<|>" & eProcess.MainWindowTitle
                    WriteToFile(strCurrApp, ELogFile)
                    '    MsgBox("Testing process " & strCurrApp & "i is " & i)
                Next
                AppTrackerList.Rows(i).Delete() ' once found, remove app from AppTrackerList - no more detection of that app 

            End If

        Next

        AppTrackerList.AcceptChanges() 'commit changes made to AppTrackerList datatable, actually to remove gap due to rows been removed
    End Sub

    'Public Function WriteToFile(ByVal strData As String, ByVal FullPath As String) As Boolean
    '    Dim bAns As Boolean = False
    '    Dim tarikh As String = Format(Now, "yyyyMMdd")


    '    Try
    '        Dim sw As IO.TextWriter
    '        sw = IO.File.AppendText(FullPath & ICNo & "_" & tarikh & ".txt")
    '        sw.WriteLine(Format(Now, "dd/MM/yyyy HH:mm:ss") & "|" & strData & "|" & SiteCode)
    '        '     sw.WriteLine()
    '        sw.Flush()
    '        sw.Close()
    '        bAns = True
    '    Catch Ex As Exception
    '        Ex.ToString()
    '        'MsgBoErr.Description)
    '        ' SendMail(Format(Now, "dd/MM/yyyy HH:mms") & " -> " & "Error at ErrorLog (" & strData & ") : " & Err.Description, "Broadcast Error...")
    '    End Try
    '    Return bAns
    'End Function

    Public Function WriteToFile(ByVal strData As String, ByVal LogFile As String) As Boolean
        Dim bAns As Boolean = False
        Dim tarikh As String = Format(Now, "yyyyMMdd")

        Try
            eventlog = File.AppendText(LogFile)
            eventlog.WriteLine(Format(Now, "yyyy-MM-dd HH:mm:ss") & "<|>" & ICNo & "<|>" & Lastbrowsingid & "<|>" & strData & "<|>" & SiteCode)
            eventlog.Flush()
            eventlog.Close()
            bAns = True
        Catch Ex As Exception
            Ex.ToString()
        End Try
        Return bAns
    End Function

    Public Sub OpenELogFile()
        Dim efilename As String = ICNo + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt"
        Dim efile As String = ELogDir + efilename
        ELogFile = efile 'assigning the name to public var to enable WriteToFile() getting the name and write to the same text file. 

        ' to open log file based on directory & file name specified
        If Not Directory.Exists(ELogDir) Then
            'if directory not exist , create directory. "/ftp" directory
            Directory.CreateDirectory(ELogDir)
        End If

        If Not File.Exists(efile) Then
            ' if file not exist, create log file
            eventlog = New StreamWriter(efile)
        Else
            eventlog = File.AppendText(efile)
        End If
        eventlog.Close()

    End Sub

    Public Function GetChromeUrl(ByVal process As Process) As String
        If process Is Nothing Then
            Throw New ArgumentNullException("process")
        End If

        If process.MainWindowHandle = IntPtr.Zero Then
            Return Nothing
        End If

        Dim element As AutomationElement = AutomationElement.FromHandle(process.MainWindowHandle)
        If element Is Nothing Then
            Return Nothing
        End If

        Dim edit As AutomationElement = element.FindFirst(TreeScope.Children, New PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Edit))
        If edit Is Nothing Then
            Return Nothing
        Else
            Return TryCast(DirectCast(edit.GetCurrentPattern(ValuePattern.Pattern), ValuePattern).Current.Value, String)
        End If


    End Function

    Public Function GetInternetExplorerUrl(ByVal process As Process) As String
        If process Is Nothing Then
            Throw New ArgumentNullException("process")
        End If

        If process.MainWindowHandle = IntPtr.Zero Then
            Return Nothing
        End If

        Dim element As AutomationElement = AutomationElement.FromHandle(process.MainWindowHandle)
        If element Is Nothing Then
            Return Nothing
        End If

        Dim rebar As AutomationElement = element.FindFirst(TreeScope.Children, New PropertyCondition(AutomationElement.ClassNameProperty, "ReBarWindow32"))
        If rebar Is Nothing Then
            Return Nothing
        End If

        Dim edit As AutomationElement = rebar.FindFirst(TreeScope.Subtree, New PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Edit))

        Return TryCast(DirectCast(edit.GetCurrentPattern(ValuePattern.Pattern), ValuePattern).Current.Value, String)

    End Function

    Public Function GetFirefoxUrl(ByVal process As Process) As String
        If process Is Nothing Then
            Throw New ArgumentNullException("process")
        End If

        If process.MainWindowHandle = IntPtr.Zero Then
            Return Nothing
        End If

        Dim element As AutomationElement = AutomationElement.FromHandle(process.MainWindowHandle)
        If element Is Nothing Then
            Return Nothing
        End If

        Dim doc As AutomationElement = element.FindFirst(TreeScope.Subtree, New PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Document))
        If doc Is Nothing Then
            Return Nothing
        End If

        Return TryCast(DirectCast(doc.GetCurrentPattern(ValuePattern.Pattern), ValuePattern).Current.Value, String)
    End Function

    Public Sub BrowserTracker()
        For Each process__1 As Process In Process.GetProcessesByName("firefox")
            Dim FFurl As String = GetFirefoxUrl(process__1)
            If FFurl Is Nothing Then
                Continue For
            End If

            Console.WriteLine("FF Url for '" + process__1.MainWindowTitle & "' is " & FFurl)

            If (GFFurl <> FFurl) Then
                WriteToFile("firefox" & "<|>" & FFurl & "<|>" & process__1.MainWindowTitle, ELogFile)
            End If
            GFFurl = FFurl


        Next

        For Each process__1 As Process In Process.GetProcessesByName("iexplore")
            Dim IEurl As String = GetInternetExplorerUrl(process__1)
            If IEurl Is Nothing Then
                Continue For
            End If

            Console.WriteLine("IE Url for '" + process__1.MainWindowTitle & "' is " & IEurl)

            If (GIEurl <> IEurl) Then
                WriteToFile("iexplore" & "<|>" & IEurl & "<|>" & process__1.MainWindowTitle, ELogFile)
            End If

            GIEurl = IEurl
        Next

        For Each process__1 As Process In Process.GetProcessesByName("chrome")
            Dim CHurl As String = GetChromeUrl(process__1)
            If CHurl Is Nothing Then
                Continue For
            End If

            Console.WriteLine("CH Url for '" + process__1.MainWindowTitle & "' is " & CHurl)

            If (GCHurl <> CHurl) Then
                WriteToFile("chrome" & "<|>" & CHurl & "<|>" & process__1.MainWindowTitle, ELogFile)
            End If

            GCHurl = CHurl
        Next

    End Sub

    Public Sub UploadFile(ByVal Timeout As Integer, ByVal RemotePath As String, ByVal LocalFile As String)
        'Dim Timeout As Integer = 1000

        '  Dim FtpServer As String = "10.10.8.106"
        Dim FtpServer As String = "210.48.150.106"

        Dim Username As String = "pjkumsftp"
        Dim Password As String = "pjkumsftp"
        'Dim RemotePath As String = "/var/ftp/eventlog/"
        'Dim LocalFile As String = ELogFile

        ' get instance of the FtpClient
        Dim client As New FtpClient()

        ' use passive mode
        client.PassiveMode = True



        ' build the target file path
        Dim target As String = Path.Combine(RemotePath, Path.GetFileName(LocalFile)).Replace("\", "/")
        Try
            ' connect to the specified FTP server
            client.Connect(Timeout, FtpServer, 21)
            client.Login(Timeout, Username, Password)
            ' synchronously upload the file
            client.PutFile(Timeout, target, LocalFile)
            Console.WriteLine("File Uploaded!")
            '''delete
        Catch
            Console.WriteLine("File Uploaded Error!")
        End Try

    End Sub

    Public Function ExecuteDataTable(ByVal strSQL As String) As DataTable
        'general function to execute datatable by sql string
        Dim dt As New DataTable()
        '   Dim da As MySqlDataAdapter
        'Dim cnn As MySqlConnection
        ' Open the connection 
        Dim cnn As New MySqlConnection(strconn)
        Try
            cnn.Open()
            ' Define the data adapter and fill it
            Dim da As New MySqlDataAdapter(strSQL, cnn)
            da.Fill(dt)

        Catch ex As MySqlException
            Select Case ex.Number
                Case 0
                    MessageBox.Show("Aplikasi tidak dapat menghubungi pangkalan data...")
                    Exit Select
                Case 1045
                    MessageBox.Show("Salah id dan katalaluan pangkalan data...")
                    Exit Select
                Case Else
                    MessageBox.Show("Aplikasi tidak dapat menghubungi pangkalan data...")
                    Exit Select
            End Select
        Finally
            cnn.Close()
        End Try

        Return dt
    End Function

    Public Function IsProcessOpen(ByVal name As String) As Boolean
        'here we're going to get a list of all running processes on
        'the computer
        For Each clsProcess As Process In Process.GetProcesses()
            'now we're going to see if any of the running processes
            'match the currently running processes. Be sure to not
            'add the .exe to the name you provide, i.e: NOTEPAD,
            'not NOTEPAD.EXE or false is always returned even if
            'notepad is running.
            'Remember, if you have the process running more than once,
            'say IE open 4 times the loop thr way it is now will close all 4,
            'if you want it to just close the first one it finds
            'then add a return; after the Kill
            If clsProcess.ProcessName.Contains(name) Then
                'if the process is found to be running then we
                'return a true
                Return True
            End If
        Next
        'otherwise we return a false
        Return False
    End Function


    Public Sub StartBrowsing(ByVal browsetype As Integer, ByVal ICNo As String)

        'type=0 prepaid , type=1 postpaid
        'browsetype 0 = prepaid, browsetype 1 = postpaid (Default)


        Dim sqlcmd As New MySqlCommand
        Dim acct As Integer

        If browsetype = 0 Then  ' if prepaid, get balance
            Balance = GetPrepaidBalance()
            PrepaidMsgCnt = 0
        End If

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Regdate = Format(Now, "yyyy-MM-dd HH:mm:ss") ' assign start time to public var- Regdate

        Regdate = NowSvrTime

        'Type = browsetype ' assigning browsing type to public var- Type
        FiveMinTimer = 0 'set to 0 for new browsing
        FormTimerInterval = 0 'set to 0 for new browsing
        Rate = GetRate(ICNo) 'to get rate and assign to public var- Rate
        Valueperminute = Rate / 60 'setting value/minute to public var- Valueperminute
        GetSKMMTime() 'to get skmm time start and end and assign to public var- skmm_start , skmm_end

        '   Console.WriteLine("Regdate {0} type {1}", Regdate, browsetype) 'Type
        '  Console.WriteLine("Skmm_start {0} Skmm_end {1} FormTimerInterval {2} FiveMinTimer {3} Rate {4} Valueperminute {5}", Skmm_start, Skmm_end, FormTimerInterval, FiveMinTimer, Rate, Valueperminute)


        If IsSKMM() = True Then
            'registered as in SKMM mode
            acct = 0

        Else

            'registered as in PERSONAL mode
            acct = 1

        End If

        conn.Open()


        sqlcmd = conn.CreateCommand
        dr = dbRead("INsert into browsing (icno,pcno,rate_per_hour,time_start,time_end,acct,type,sendstatus,entry_dt) " & _
                               "values('" & ICNo & "','" & PcNo & "', " & Rate & ",'" & Regdate & "','" & Regdate & "'," & acct & ", " & _
                               " " & browsetype & ", 0,'" & Regdate & "')") '// Anb changed "Type" to "browsetype" - utk make sure current status is recorded

        'sqlcmd.CommandType = CommandType.Text
        'sqlreader = sqlcmd.ExecuteReader



        dr.Close()
        conn.Close()

        Lastbrowsingid = GetlastBrowsing(ICNo, PcNo) ' to get lastbrowsing id that was just inserted and assign to public var-Lastbrowsingid
        SiteCode = GetSiteCode() ' to get site code and assign to public var- SiteCode


        ElogTimerAndSetting() 'JJ , starts eventlog timer and settings needed



        'not used...incase wanna use, pls uncomment the necessary part below, and then update usageTimer_Event for its event 
        '' Create a timer 
        'usageTimer = New System.Timers.Timer()

        '' Hook up the Elapsed event for the timer.
        'AddHandler usageTimer.Elapsed, AddressOf usageTimer_Event

        '' Set the Interval to 2 seconds (2000 milliseconds).
        'usageTimer.Interval = 10000
        'usageTimer.Enabled = True


    End Sub

    Public Sub UpdateBrowsingLog(ByVal usertypeID As Integer, ByVal ICNo As String, ByVal Rate As Double, ByVal Duration As Integer, ByVal Payment As Double, ByVal currenttime As String)


        Dim sqlcmd As New MySqlCommand


        Dim acctstatus As Integer

        acctstatus = GetAcctStatus(Lastbrowsingid) ' Lastbrowsingid is from global var

        '//   Case of Both SMKMM                 |           case of both personal
        If (IsSKMM() = True And acctstatus = 0) Or (IsSKMM() = False And acctstatus = 1) Then
            dr = dbRead("Update browsing  set time_end = '" & currenttime & "',mod_dt='" & currenttime & "' " & _
                      "where id = " & Lastbrowsingid & " and icno = '" & ICNo & "'")

        Else
            If FiveMinTimer = 0 Then
                'had to use frm as msgbox, if normal MsgBox, the counter for FiveMinTimer will not work
                frmMsgBox.lblMsg1.Text = "Diff time zone, pls save your work,logout and relogin, or you'll be logged out automatically in 5 minutes time"
                frmMsgBox.Show()
            End If

            If FiveMinTimer >= 300000 Then  'If more than 5 minutes already, do logout
                frmMonitoring.btnout_Click(frmMonitoring.btnout, EventArgs.Empty)
            Else
                dr = dbRead("Update browsing  set time_end = '" & currenttime & "',mod_dt='" & currenttime & "' " & _
                      "where id = " & Lastbrowsingid & " and icno = '" & ICNo & "'")
            End If

            FiveMinTimer = FiveMinTimer + FormTimerInterval 'accumulate seconds until 5 min

        End If

        dr.Close()
        conn.Close()

        'If IsSKMM() = False And acctstatus = 0 Then 'if it is non-SKMM time but browsing mode is 0=SKMM mode

        '    '  Console.WriteLine("{0} {1} {2} {3}", Skmm_start, Skmm_end, FormTimerInterval, FiveMinTimer)

        '    If FiveMinTimer = 0 Then
        '        'had to use frm as msgbox, if normal MsgBox, the counter for FiveMinTimer will not work
        '        frmMsgBox.lblMsg1.Text = "Diff time zone, pls save your work,logout and relogin, or you'll be logged out automatically in 5 minutes time"
        '        frmMsgBox.Show()
        '    End If

        '    If FiveMinTimer >= 300000 Then  'If more than 5 minutes already, do logout
        '        frmMonitoring.btnout_Click(frmMonitoring.btnout, EventArgs.Empty)
        '    Else
        '        dr = dbRead("Update browsing  set time_end = '" & currenttime & "',mod_dt='" & currenttime & "' " & _
        '              "where id = " & Lastbrowsingid & " and icno = '" & ICNo & "'")
        '    End If

        '    FiveMinTimer = FiveMinTimer + FormTimerInterval 'accumulate seconds until 5 min

        '    '    Console.WriteLine("{0} {1} {2} {3}", Skmm_start, Skmm_end, FormTimerInterval, FiveMinTimer)


        'ElseIf IsSKMM() = True And acctstatus = 1 Then 'if it is SKMM time but browsing mode is 1=Personal mode


        '    If FiveMinTimer = 0 Then
        '        'had to use frm as msgbox, if normal MsgBox, the counter for FiveMinTimer will not work
        '        frmMsgBox.lblMsg1.Text = "Diff time zone, pls save your work,logout and relogin, or you'll be logged out automatically in 5 minutes time"
        '        frmMsgBox.Show()
        '    End If

        '    If FiveMinTimer >= 300000 Then  'If more than 5 minutes already, do logout
        '        frmMonitoring.btnout_Click(frmMonitoring.btnout, EventArgs.Empty)
        '    Else
        '        dr = dbRead("Update browsing  set time_end = '" & currenttime & "',mod_dt='" & currenttime & "' " & _
        '              "where id = " & Lastbrowsingid & " and icno = '" & ICNo & "'")
        '    End If

        '    FiveMinTimer = FiveMinTimer + FormTimerInterval  'accumulate seconds until 5 min

        'Else

        '    dr = dbRead("Update browsing  set time_end = '" & currenttime & "',mod_dt='" & currenttime & "' " & _
        '                          "where id = " & Lastbrowsingid & " and icno = '" & ICNo & "'")

        '    dr.Close()
        'End If
        'conn.Close()


        If Type = 0 Then ' if prepaid, Type=0
            CheckPrepaidStatus(Payment)
        End If


        If usertypeID <> 1 And Rate = 0 Then 'member which still having FOC surfing privilage
            If GetTodayFOCTimeBal(ICNo) = 0 Then '// kalau dah habis FOC 2jam sehari
                frmMonitoring.btnout_Click(frmMonitoring.btnout, EventArgs.Empty)
            End If
        End If

    End Sub

    Public Sub CheckPrepaidStatus(ByVal Payment As Double)
        Dim status As String = ""

        If (Balance - Payment) <= (5 * Valueperminute) Then '5 min before credit finished
            If PrepaidMsgCnt = 0 Then
                frmMsgBox.lblMsg1.Text = "You prepaid balance is just enough for less than 5 minutes"
                frmMsgBox.lblMsg2.Text = "Pls save your work, logout and top-up, or you'll be logged out automatically once your credit finished"
                frmMsgBox.Show()
                PrepaidMsgCnt = 1
            End If

            If Balance < Payment Then 'once balance < payment , do logout 
                frmMonitoring.btnout_Click(frmMonitoring.btnout, EventArgs.Empty)
            End If
        End If
    End Sub

    Public Sub usageTimer_Event(ByVal source As Object, ByVal e As ElapsedEventArgs) ' JJ , usage timer event
        '    frmMonitoring.lblduration.Text = GetCurrentDuration(regdate)
        '    frmMonitoring.lblduration.Update()
        '     Application.DoEvents()
        Console.WriteLine("The usage Timer Elapsed event was raised at {0}{1}", e.SignalTime, frmMonitoring.lblduration.Text)
    End Sub

    Public Function GetCurrentDuration(ByVal starttime As DateTime, ByVal currtime As DateTime)
        Dim duration As Integer

        duration = DateDiff(DateInterval.Minute, starttime, currtime)

        ' duration = TimeDiff(starttime, 1)

        Return duration

    End Function

    Public Function GetPayment(ByVal duration As Integer, ByVal rate As Double, ByVal valueperminute As Double) As Double

        Dim payment As Double

        If duration <= 5 Then
            'first 5 minute is free

            payment = 0

        ElseIf duration = 60 Then
            '1 hour usage

            payment = rate


        Else


            '  payment = duration * rate

            payment = duration * valueperminute



        End If





        Return payment

    End Function

    Public Sub GetSKMMTime()

        dr = dbRead("select time_start,time_end from settings")

        If dr.Read = True Then
            Skmm_start = dr("time_start").ToString.Trim 'assign to public var - Skmm_start
            Skmm_end = dr("time_end").ToString.Trim 'assign to public var - Skmm_end
        Else
            Skmm_start = ""
            Skmm_end = ""
        End If
        dr.Close()
        conn.Close()

    End Sub

    Public Function IsSKMM() As Boolean

        Dim yes As Boolean

        Dim CurrTime As String
        CurrTime = Now.ToString("HH:mm:ss")

        GetSKMMTime()

        If (CurrTime >= Skmm_start And CurrTime <= Skmm_end) Then 'check with global/public var 
            yes = True

        Else
            yes = False


        End If


        Return yes

    End Function

    Public Function GetServerTime() As String

        Dim time As String

        dr = dbRead("SELECT now()")

        If dr.Read Then
            time = dr(0)
        End If

        dr.Close()
        conn.Close()

        Return time
    End Function
    Public Sub Logout()

        Dim sqlcmd As New MySqlCommand
       
        Dim logoutdate As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
        frmMonitoring.Timer1.Stop() 'JJ, stops frmMonitoring timer
        frmMinMonitoring.Timer1.Stop() 'JJ, stops frmMinMonitoring timer

        ELogTimer.Stop() 'JJ , stops eventlog timer.
        UploadFile(1000, "/var/ftp/eventlog/", ELogFile) 'JJ, upload eventlog text file to server

        'JJ, close forms incase they are still open
        frmMonitoring.Close()
        frmMinMonitoring.Close()
        frmMsgBox.Close()
        'For Each f As Form In My.Application.OpenForms
        '    f.Close()
        'Next
        'If conn.State = ConnectionState.Open Then
        '    conn.Close()
        'End If

        'conn.Open()

        'get last row for this user
        'id = GetlastBrowsing()

        ' sqlcmd = conn.CreateCommand
        dr = dbRead("Update browsing  set sendstatus = 0,time_end = '" & logoutdate & "' ,browse_status = 1,mod_dt='" & logoutdate & "' " & _
                              "where icno = '" & ICNo & "'") ' id = " & Lastbrowsingid & " and '// Anb:Tak logic ada instance lain yg guna IC sama

        'sqlcmd.CommandType = CommandType.Text
        'sqlreader = sqlcmd.ExecuteReader

        dr.Close()
        conn.Close()

        appStatus = 1  'to set PC as standby

        Type = 1 '// Anb : Reset to default value

    End Sub

    Private Sub GetUserdetails()


    End Sub




End Module
