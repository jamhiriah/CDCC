Public Class frmChatUI

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click

        Dim msg As String

        msg = "CHAT|" & txtMsg.Text

        sendData(msg)

        txtHistory.Text = txtHistory.Text + Environment.NewLine + " C0" & PcNo & " >> " + txtMsg.Text

        txtMsg.Clear()


    End Sub
    Private Sub txtmsg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMsg.KeyDown
        Try

            If e.KeyCode = Keys.Enter Then
                btnSend_Click(sender, e)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            '   DisconnectMysql_Database()
        Finally
            '  DisconnectMysql_Database()
        End Try

    End Sub
End Class