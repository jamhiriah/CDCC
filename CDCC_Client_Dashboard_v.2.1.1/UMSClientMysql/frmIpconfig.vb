Imports System.Net.NetworkInformation
Imports System.Management
Imports Microsoft.Win32
Imports System.Net


Public Class frmIpconfig

    Private Sub frmIpconfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim strHostName As String
        Dim strIPAddress As String
        Dim strGwy As String
        ' Dim strDns As String



        strHostName = System.Net.Dns.GetHostName()
        strIPAddress = System.Net.Dns.GetHostEntry(strHostName).AddressList(0).ToString()
        strGwy = GetGatewayIP()

        txtCurrHost.Text = strHostName
        txtCurrIp.Text = strIPAddress
        txtCurrGtw.Text = strGwy


        GetSubnetMask()

    End Sub

    Public Function GetGatewayIP()

        Dim ipProperties As IPGlobalProperties = IPGlobalProperties.GetIPGlobalProperties()
        Dim strgwy As String = ""

        For Each networkCard As NetworkInterface In NetworkInterface.GetAllNetworkInterfaces()


            For Each gatewayAddr As GatewayIPAddressInformation In networkCard.GetIPProperties().GatewayAddresses

                strgwy = gatewayAddr.Address.ToString()
            Next
        Next

        Return strgwy
    End Function


    Sub GetSubnetMask()

        Dim regPath As String = "System\CurrentControlSet\Services\Tcpip\Parameters\Interfaces\"

        Dim x As RegistryKey = My.Computer.Registry.LocalMachine.OpenSubKey(regPath, False)

        For Each skn As String In x.GetSubKeyNames
            Dim y As RegistryKey =
            My.Computer.Registry.LocalMachine.OpenSubKey(regPath & skn, False)

            Dim z As Integer = y.GetValue("EnableDHCP")
            If z = 1 Then
                Try
                    If y.GetValue("DhcpIPAddress").ToString =
                    Dns.GetHostAddresses(Dns.GetHostName)(0).ToString Then

                        ' MsgBox("DHCP: " & y.GetValue("DhcpSubnetMask"))
                        txtCurrSub.Text = y.GetValue("DhcpSubnetMask")

                        Exit Sub
                    End If
                Catch
                End Try
                'Else
                '    Try
                '        If y.GetValue("IPAddress").ToString =
                '        Dns.GetHostAddresses(Dns.GetHostName)(0).ToString Then
                '            MsgBox("STATIC: " & y.GetValue("SubnetMask"))
                '            Exit Sub
                '        End If
                '    Catch
                '    End Try
            End If
            y.Close()
        Next
        x.Close()



    End Sub
End Class