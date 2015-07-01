Imports System.Net.Sockets
Imports System.Text
Public Class frmChat

    Dim clientSocket As New System.Net.Sockets.TcpClient()
    Dim serverStream As NetworkStream
    Dim readData As String
    Dim infiniteCounter As Integer

    Private Sub frmChat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ValidateLanguange(lgId)
        lblPcNo.Text = PcNo

        clientSocket.Connect(ipChatServer, 8888)

        Getconnected()
    End Sub

   
    Public Sub ValidateLanguange(ByVal lgid As Integer)

        If lgid = 1 Then
            'BM'

            btnSend.Text = "Hantar"

            If frmMain.HasConnectivity() = True Then

                lblConnect.Text = "Pelayan di sambungkan"
            Else
                lblConnect.Text = "Pelayan tidak disambungkan"
            End If


        ElseIf lgid = 2 Then
            'Eng'

            btnSend.Text = "Send"

            If frmMain.HasConnectivity() = True Then

                lblConnect.Text = "Connected"
            Else
                lblConnect.Text = "Disconnected"

            End If

        End If

    End Sub

    Sub msg(ByVal mesg As String)

        '    '-begin
        '    'If Me.InvokeRequired Then
        '    '    Me.Invoke(New MethodInvoker(AddressOf msg)
        '    'Else
        '    '    ' txtHistory.Text = txtHistory.Text + Environment.NewLine + " >> " + readData
        '    '    txtHistory.Text = txtHistory.Text + Environment.NewLine + " >> " + mesg
        '    'End If

        '    '-end

        txthistory.Text = txthistory.Text + Environment.NewLine + " >> " + mesg + readData
    End Sub


    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click

        Dim serverStream As NetworkStream = clientSocket.GetStream()
        Dim buffSize As Integer

        'send message to server
        Dim outStream As Byte() = _
        System.Text.Encoding.ASCII.GetBytes("CHAT|" + txtSend.Text + "$")
        serverStream.Write(outStream, 0, outStream.Length)
        serverStream.Flush()

        '///////
        Dim ctThread As Threading.Thread = New Threading.Thread(AddressOf getMessage)
        ctThread.Start()
        '-end

        Dim inStream(10024) As Byte
        buffSize = clientSocket.ReceiveBufferSize
        serverStream.Read(inStream, 0, buffSize)



        Dim returndata As String = _
        System.Text.Encoding.ASCII.GetString(inStream)

        'receive data from server   
        '        msg(returndata)

        msgx()
    End Sub

    Private Sub send(ByVal msg As String)

        Dim outStream As Byte() = _
        System.Text.Encoding.ASCII.GetBytes(msg + "$")
        serverStream.Write(outStream, 0, outStream.Length)
        serverStream.Flush()
    End Sub

    Private Sub getMessage()
        For infiniteCounter = 1 To 2
            infiniteCounter = 1
            serverStream = clientSocket.GetStream()
            Dim buffSize As Integer
            Dim inStream(10024) As Byte
            buffSize = clientSocket.ReceiveBufferSize
            serverStream.Read(inStream, 0, buffSize)


            Dim returndata As String = _
            System.Text.Encoding.ASCII.GetString(inStream)
            readData = "" + returndata
            msgx()
        Next
    End Sub
    Private Sub msgx()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf msgx))
        Else
            txthistory.Text = txthistory.Text + Environment.NewLine + " >> " + readData
        End If
    End Sub
End Class