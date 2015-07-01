Imports System.Net.Sockets
Imports System.Text
Public Class Form2


    Dim clientSocket As New System.Net.Sockets.TcpClient()
    Dim serverStream As NetworkStream
    Dim readData As String
    Dim infiniteCounter As Integer


    Private Sub btnsend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsend.Click
        Dim outStream As Byte() = _
       System.Text.Encoding.ASCII.GetBytes(txtmsg.Text + "$")
        serverStream.Write(outStream, 0, outStream.Length)
        serverStream.Flush()
    End Sub
    Private Sub msg()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf msg))
        Else
            txtHistory.Text = txtHistory.Text + Environment.NewLine + " >> " + readData
        End If
    End Sub


    Private Sub btnName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnName.Click
        readData = "Conected to Chat Server ..."
        msg()

        clientSocket.Connect(ipChatServer, 8888)
        'Label1.Text = "Client Socket Program - Server Connected ..."
        serverStream = clientSocket.GetStream()

        Dim outStream As Byte() = _
        System.Text.Encoding.ASCII.GetBytes(txtname.Text + "$")
        serverStream.Write(outStream, 0, outStream.Length)
        serverStream.Flush()

        Dim ctThread As Threading.Thread = New Threading.Thread(AddressOf getMessage)
        ctThread.Start()
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
            msg()
        Next
    End Sub
End Class