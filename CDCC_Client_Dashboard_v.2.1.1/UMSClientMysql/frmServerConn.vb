Imports System.Net.Sockets

Public Class frmServerconn

    Private Sub frmServerconn_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Enabled = True
        'txtIpclient.Text = GetIPAddress() '// get the current IP Address of this PC

        '// store previous data if user decide to revert back to original

        '// load default data


        Dim myFileName = fullpath + "\" & FileName

        If System.IO.File.Exists(myFileName) Then
            GetPCsetting(myFileName) '// read setting from the file
        End If
        ' lockMe(True) '// check server setting nak lock atau tidak **


        '  frmMain.GetPCNO()


        For i As Integer = 1 To 30
            cboPCnum.Items.Add(i)
        Next

        txtSvrConn.Text = IpServer
        txtChatServerIP.Text = ipChatServer
        cboPCnum.SelectedText = PcNo


        If txtChatServerIP.Text = "" Or txtSvrConn.Text = "" Then
            chkSameServer.Checked = False
        End If


        txtSvrConn.Focus()

    End Sub
    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click

        '// put input checking here


        '// store App to variable
        IpServer = txtSvrConn.Text

        If chkSameServer.Checked = True Then
            ipChatServer = IpServer
        Else
            ipChatServer = txtChatServerIP.Text
        End If

        PcNo = cboPCnum.Text
        useServerConn(IpServer)

        lblmsg.Text = "Trying to Connect"

        '// check for connection
        Dim mySysName As String = GetSystemName()
        If mySysName = "ERROR" Then
            lblmsg.Text = "Connection Failed"
            btnSave.Enabled = False
        Else
            lblmsg.Text = "Connection Successfull"

            'db ok
            frmMain.lblPJK.Text = mySysName
            frmMain.PicDBx.Visible = False
            frmMain.PicDB.Visible = True

            btnSave.Enabled = True
        End If


    End Sub

    Private Sub frmServerconn_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        txtSvrConn.Focus()
    End Sub

   

    Private Sub chkSameServer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSameServer.CheckedChanged

        If chkSameServer.Checked Then
            txtChatServerIP.Text = txtSvrConn.Text
        Else
            txtChatServerIP.Enabled = True
        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        '// put input check here before saving

        '// store App to variable

        IpServer = txtSvrConn.Text

        frmMain.flag = 0

        If chkSameServer.Checked Then
            ipChatServer = IpServer
        Else
            ipChatServer = txtChatServerIP.Text
        End If

        PcNo = cboPCnum.Text
        useServerConn(IpServer)

        '// delete file if exist
        Dim myFileName = fullpath + "\" & FileName
        If System.IO.File.Exists(myFileName) Then
            System.IO.File.Delete(myFileName)
        End If


        '< Create the ipserver.txt file >---------------------------
        Dim varWrite As New System.IO.StreamWriter(myFileName)

        varWrite.WriteLine(IpServer & " " & cboPCnum.Text & " " & txtChatServerIP.Text)
        varWrite.Close()
        '</"dat" file Created >--------------------------------------------------

        '-----------------------------
        'serverStream.Close()
        'clientSocket.Close()
        'clientSocket = New System.Net.Sockets.TcpClient()

        '   Getconnected() '//connect with new pc no


        '  Me.Close()

        '   frmMain.frmMain_Load(frmMain, EventArgs.Empty) 'to refresh the main form with latest config. info just keyed in

        '-------------------

        'update pcno in main page after new pc
   

        appStatus = 1

        ' Dim myFileName = fullpath & FileName

        If System.IO.File.Exists(myFileName) Then
            GetPCsetting(myFileName) '// read setting from the file

        End If


        Dim strMsg As String '= "x|C0" & PcNo
        'Dim tempcno As String
        Dim count As Integer

        strMsg = PcNo.Substring(0, 1)

        count = PcNo.Length

        If count = "1" Then 'to cehck which format to use

            'Format c01
            strMsg = "xC0" & PcNo

        Else
            'format C10
            strMsg = "xC" & PcNo

        End If

        sendData(strMsg)


        '  Getconnected()
        Me.Close()

    End Sub

  
    
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        txtChatServerIP.Text = ""
        txtSvrConn.Text = ""
        chkSameServer.Checked = False
        btnSave.Enabled = True

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class