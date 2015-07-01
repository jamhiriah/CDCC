<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIpconfig
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Ip = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrevGwy = New System.Windows.Forms.TextBox()
        Me.txtPrevSub = New System.Windows.Forms.TextBox()
        Me.txtPrevIp = New System.Windows.Forms.TextBox()
        Me.txtCurrGtw = New System.Windows.Forms.TextBox()
        Me.txtCurrSub = New System.Windows.Forms.TextBox()
        Me.txtCurrIp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrevHost = New System.Windows.Forms.TextBox()
        Me.txtCurrHost = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ip
        '
        Me.Ip.AutoSize = True
        Me.Ip.Location = New System.Drawing.Point(3, 62)
        Me.Ip.Name = "Ip"
        Me.Ip.Size = New System.Drawing.Size(16, 13)
        Me.Ip.TabIndex = 0
        Me.Ip.Text = "Ip"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Subnetmask"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.58076!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.41924!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Ip, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPrevGwy, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPrevSub, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPrevIp, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCurrGtw, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCurrSub, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCurrIp, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPrevHost, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCurrHost, 2, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 33)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.81967!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.18033!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(450, 229)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(119, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Previous"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(281, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Current"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Default Gateway"
        '
        'txtPrevGwy
        '
        Me.txtPrevGwy.Location = New System.Drawing.Point(119, 122)
        Me.txtPrevGwy.Name = "txtPrevGwy"
        Me.txtPrevGwy.Size = New System.Drawing.Size(156, 20)
        Me.txtPrevGwy.TabIndex = 9
        '
        'txtPrevSub
        '
        Me.txtPrevSub.Location = New System.Drawing.Point(119, 93)
        Me.txtPrevSub.Name = "txtPrevSub"
        Me.txtPrevSub.Size = New System.Drawing.Size(156, 20)
        Me.txtPrevSub.TabIndex = 8
        '
        'txtPrevIp
        '
        Me.txtPrevIp.Location = New System.Drawing.Point(119, 65)
        Me.txtPrevIp.Name = "txtPrevIp"
        Me.txtPrevIp.Size = New System.Drawing.Size(156, 20)
        Me.txtPrevIp.TabIndex = 2
        '
        'txtCurrGtw
        '
        Me.txtCurrGtw.Location = New System.Drawing.Point(281, 122)
        Me.txtCurrGtw.Name = "txtCurrGtw"
        Me.txtCurrGtw.Size = New System.Drawing.Size(162, 20)
        Me.txtCurrGtw.TabIndex = 10
        '
        'txtCurrSub
        '
        Me.txtCurrSub.Location = New System.Drawing.Point(281, 93)
        Me.txtCurrSub.Name = "txtCurrSub"
        Me.txtCurrSub.Size = New System.Drawing.Size(162, 20)
        Me.txtCurrSub.TabIndex = 6
        '
        'txtCurrIp
        '
        Me.txtCurrIp.Location = New System.Drawing.Point(281, 65)
        Me.txtCurrIp.Name = "txtCurrIp"
        Me.txtCurrIp.Size = New System.Drawing.Size(162, 20)
        Me.txtCurrIp.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Hostname"
        '
        'txtPrevHost
        '
        Me.txtPrevHost.Location = New System.Drawing.Point(119, 35)
        Me.txtPrevHost.Name = "txtPrevHost"
        Me.txtPrevHost.Size = New System.Drawing.Size(156, 20)
        Me.txtPrevHost.TabIndex = 12
        '
        'txtCurrHost
        '
        Me.txtCurrHost.Location = New System.Drawing.Point(281, 35)
        Me.txtCurrHost.Name = "txtCurrHost"
        Me.txtCurrHost.Size = New System.Drawing.Size(162, 20)
        Me.txtCurrHost.TabIndex = 13
        '
        'frmIpconfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 197)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmIpconfig"
        Me.Text = "Ip Configuration"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Ip As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtPrevIp As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrIp As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCurrSub As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPrevSub As System.Windows.Forms.TextBox
    Friend WithEvents txtPrevGwy As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrGtw As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPrevHost As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrHost As System.Windows.Forms.TextBox
End Class
