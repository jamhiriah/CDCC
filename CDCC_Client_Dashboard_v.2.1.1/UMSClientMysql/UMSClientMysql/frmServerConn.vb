Public Class frmServerconn

   
    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click

        '// put input checking here


        '// store App to variable
        IpServer = txtSvrConn.Text

        If chkSameServer.Checked Then
            ipChatServer = IpServer
        Else
            ipChatServer = txtChatServerIP.Text
        End If

        PcNo = cboPCnum.Text
        useServerConn(IpServer)

        lblmsg.Text = "Trying to Connect"

        '// check for connection
        If GetSystemName() = "ERROR" Then
            lblmsg.Text = "Connection Failed"
            btnSave.Enabled = False
        Else
            lblmsg.Text = "Connection Successfull"
            btnSave.Enabled = True
        End If


        'Dim has As Boolean

        'If frmMain.HasConnectivity = True Then

        'has = True
        'lblmsg.Text = " Connected "

        'Else

        'has = False
        'lblmsg.Text = " Not connected"

        'End If



    End Sub

    Private Sub frmServerconn_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        txtSvrConn.Focus()
    End Sub

    Private Sub frmServerconn_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '// store previous data if user decide to revert back to original

        '// load default data

        frmMain.GetPCNO()
        For i As Integer = 1 To 30
            cboPCnum.Items.Add(i)
        Next

        If IpServer <> "" Then
            txtSvrConn.Text = IpServer
        End If

        If ipChatServer <> "" Then
            txtChatServerIP.Text = ipChatServer
            chkSameServer.Checked = False
        End If

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


        If chkSameServer.Checked Then
            ipChatServer = IpServer
        Else
            ipChatServer = txtChatServerIP.Text
        End If

        PcNo = cboPCnum.Text
        useServerConn(IpServer)

        '// delete file if exist
        Dim myFileName = fullpath & FileName
        If System.IO.File.Exists(myFileName) Then
            System.IO.File.Delete(myFileName)
        End If

        '< Create the ipserver.txt file >---------------------------
        Dim varWrite As New System.IO.StreamWriter(myFileName)

        varWrite.WriteLine(IpServer & " " & cboPCnum.Text & " " & txtChatServerIP.Text)
        varWrite.Close()
        '</"dat" file Created >--------------------------------------------------
        Getconnected()
        Me.Close()

        frmMain.frmMain_Load(frmMain, EventArgs.Empty) 'to refresh the main form with latest config. info just keyed in

    End Sub
End Class