Public Class frmMsgBox

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Me.Close()

    End Sub

    Private Sub frmMsgBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  Panel1.Left = (My.Computer.Screen.WorkingArea.Width / 2) - (Panel1.Width / 2)
        '  Panel1.Top = (My.Computer.Screen.WorkingArea.Height / 2) - (Panel1.Height / 2) + 200 '//-anbEdit
    End Sub
End Class