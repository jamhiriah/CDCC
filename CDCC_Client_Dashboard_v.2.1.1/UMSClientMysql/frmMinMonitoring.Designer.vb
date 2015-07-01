<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMinMonitoring
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
        Me.components = New System.ComponentModel.Container()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblstarttime = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblanggaran = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbltempoh = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblpaid = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnout = New System.Windows.Forms.Button()
        Me.lblpayment = New System.Windows.Forms.Label()
        Me.lblduration = New System.Windows.Forms.Label()
        Me.lblcharge = New System.Windows.Forms.Label()
        Me.lblstartdate = New System.Windows.Forms.Label()
        Me.lblKp = New System.Windows.Forms.Label()
        Me.lblnokp = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(129, 29)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(176, 16)
        Me.TextBox2.TabIndex = 38
        Me.TextBox2.Text = "tets"
        Me.TextBox2.Visible = False
        '
        'lblstarttime
        '
        Me.lblstarttime.AutoSize = True
        Me.lblstarttime.Location = New System.Drawing.Point(212, 5)
        Me.lblstarttime.Name = "lblstarttime"
        Me.lblstarttime.Size = New System.Drawing.Size(59, 13)
        Me.lblstarttime.TabIndex = 33
        Me.lblstarttime.Text = "Masa Mula"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(305, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(103, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(10, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = ":"
        '
        'lblanggaran
        '
        Me.lblanggaran.AutoSize = True
        Me.lblanggaran.Location = New System.Drawing.Point(212, 18)
        Me.lblanggaran.Name = "lblanggaran"
        Me.lblanggaran.Size = New System.Drawing.Size(98, 13)
        Me.lblanggaran.TabIndex = 36
        Me.lblanggaran.Text = "Anggaran Bayaran "
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'lbltempoh
        '
        Me.lbltempoh.AutoSize = True
        Me.lbltempoh.Location = New System.Drawing.Point(-2, 18)
        Me.lbltempoh.Name = "lbltempoh"
        Me.lbltempoh.Size = New System.Drawing.Size(110, 13)
        Me.lbltempoh.TabIndex = 35
        Me.lbltempoh.Text = "Tempoh Penggunaan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(271, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(10, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = ":"
        '
        'lblpaid
        '
        Me.lblpaid.AutoSize = True
        Me.lblpaid.Location = New System.Drawing.Point(409, 6)
        Me.lblpaid.Name = "lblpaid"
        Me.lblpaid.Size = New System.Drawing.Size(84, 13)
        Me.lblpaid.TabIndex = 34
        Me.lblpaid.Text = "Bayaran Sejam :"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.lblstarttime)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lblanggaran)
        Me.Panel1.Controls.Add(Me.lbltempoh)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblpaid)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnout)
        Me.Panel1.Controls.Add(Me.lblpayment)
        Me.Panel1.Controls.Add(Me.lblduration)
        Me.Panel1.Controls.Add(Me.lblcharge)
        Me.Panel1.Controls.Add(Me.lblstartdate)
        Me.Panel1.Controls.Add(Me.lblKp)
        Me.Panel1.Location = New System.Drawing.Point(6, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(547, 52)
        Me.Panel1.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "No KP Pengguna"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(102, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'btnout
        '
        Me.btnout.Location = New System.Drawing.Point(444, 21)
        Me.btnout.Name = "btnout"
        Me.btnout.Size = New System.Drawing.Size(75, 23)
        Me.btnout.TabIndex = 23
        Me.btnout.Text = "Keluar"
        Me.btnout.UseVisualStyleBackColor = True
        '
        'lblpayment
        '
        Me.lblpayment.AutoSize = True
        Me.lblpayment.Location = New System.Drawing.Point(316, 18)
        Me.lblpayment.Name = "lblpayment"
        Me.lblpayment.Size = New System.Drawing.Size(0, 13)
        Me.lblpayment.TabIndex = 21
        '
        'lblduration
        '
        Me.lblduration.AutoSize = True
        Me.lblduration.Location = New System.Drawing.Point(114, 18)
        Me.lblduration.Name = "lblduration"
        Me.lblduration.Size = New System.Drawing.Size(0, 13)
        Me.lblduration.TabIndex = 20
        '
        'lblcharge
        '
        Me.lblcharge.AutoSize = True
        Me.lblcharge.Location = New System.Drawing.Point(496, 5)
        Me.lblcharge.Name = "lblcharge"
        Me.lblcharge.Size = New System.Drawing.Size(0, 13)
        Me.lblcharge.TabIndex = 19
        '
        'lblstartdate
        '
        Me.lblstartdate.AutoSize = True
        Me.lblstartdate.Location = New System.Drawing.Point(278, 5)
        Me.lblstartdate.Name = "lblstartdate"
        Me.lblstartdate.Size = New System.Drawing.Size(0, 13)
        Me.lblstartdate.TabIndex = 18
        '
        'lblKp
        '
        Me.lblKp.AutoSize = True
        Me.lblKp.Location = New System.Drawing.Point(114, 4)
        Me.lblKp.Name = "lblKp"
        Me.lblKp.Size = New System.Drawing.Size(0, 13)
        Me.lblKp.TabIndex = 17
        '
        'lblnokp
        '
        Me.lblnokp.AutoSize = True
        Me.lblnokp.Location = New System.Drawing.Point(105, 40)
        Me.lblnokp.Name = "lblnokp"
        Me.lblnokp.Size = New System.Drawing.Size(90, 13)
        Me.lblnokp.TabIndex = 39
        Me.lblnokp.Text = "No KP Pengguna"
        '
        'frmMinMonitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 63)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblnokp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMinMonitoring"
        Me.Text = "frmMinMonitoring"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lblstarttime As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblanggaran As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbltempoh As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblpaid As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnout As System.Windows.Forms.Button
    Friend WithEvents lblpayment As System.Windows.Forms.Label
    Friend WithEvents lblduration As System.Windows.Forms.Label
    Friend WithEvents lblcharge As System.Windows.Forms.Label
    Friend WithEvents lblstartdate As System.Windows.Forms.Label
    Friend WithEvents lblKp As System.Windows.Forms.Label
    Friend WithEvents lblnokp As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
