<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtumur = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkOku = New System.Windows.Forms.CheckBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.cmbEducation = New System.Windows.Forms.ComboBox()
        Me.lblOku = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.lblgender = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.cmbWork = New System.Windows.Forms.ComboBox()
        Me.cmbRace = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblEdu = New System.Windows.Forms.Label()
        Me.lblincome = New System.Windows.Forms.Label()
        Me.cmbIncome = New System.Windows.Forms.ComboBox()
        Me.lblOcc = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.lbladd = New System.Windows.Forms.Label()
        Me.txtOldIc = New System.Windows.Forms.TextBox()
        Me.txtNewIc3 = New System.Windows.Forms.TextBox()
        Me.txtNewIc2 = New System.Windows.Forms.TextBox()
        Me.txtNewIc1 = New System.Windows.Forms.TextBox()
        Me.radOldIc = New System.Windows.Forms.RadioButton()
        Me.lblicold = New System.Windows.Forms.Label()
        Me.radNewIc = New System.Windows.Forms.RadioButton()
        Me.lblicnew = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblRace = New System.Windows.Forms.Label()
        Me.lblmsg = New System.Windows.Forms.Label()
        Me.txtTown = New System.Windows.Forms.TextBox()
        Me.cmbState = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cmbState)
        Me.Panel1.Controls.Add(Me.txtumur)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.chkOku)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnRegister)
        Me.Panel1.Controls.Add(Me.cmbEducation)
        Me.Panel1.Controls.Add(Me.lblOku)
        Me.Panel1.Controls.Add(Me.cmbGender)
        Me.Panel1.Controls.Add(Me.lblgender)
        Me.Panel1.Controls.Add(Me.lblAge)
        Me.Panel1.Controls.Add(Me.cmbWork)
        Me.Panel1.Controls.Add(Me.cmbRace)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lblEdu)
        Me.Panel1.Controls.Add(Me.lblincome)
        Me.Panel1.Controls.Add(Me.cmbIncome)
        Me.Panel1.Controls.Add(Me.lblOcc)
        Me.Panel1.Controls.Add(Me.lblState)
        Me.Panel1.Controls.Add(Me.txtTown)
        Me.Panel1.Controls.Add(Me.lblCity)
        Me.Panel1.Controls.Add(Me.txtAdd)
        Me.Panel1.Controls.Add(Me.lbladd)
        Me.Panel1.Controls.Add(Me.txtOldIc)
        Me.Panel1.Controls.Add(Me.txtNewIc3)
        Me.Panel1.Controls.Add(Me.txtNewIc2)
        Me.Panel1.Controls.Add(Me.txtNewIc1)
        Me.Panel1.Controls.Add(Me.radOldIc)
        Me.Panel1.Controls.Add(Me.lblicold)
        Me.Panel1.Controls.Add(Me.radNewIc)
        Me.Panel1.Controls.Add(Me.lblicnew)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.lblname)
        Me.Panel1.Controls.Add(Me.lblRace)
        Me.Panel1.Location = New System.Drawing.Point(30, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(672, 280)
        Me.Panel1.TabIndex = 38
        '
        'txtumur
        '
        Me.txtumur.Location = New System.Drawing.Point(437, 21)
        Me.txtumur.Name = "txtumur"
        Me.txtumur.Size = New System.Drawing.Size(188, 20)
        Me.txtumur.TabIndex = 38
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(560, 226)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 28)
        Me.btnCancel.TabIndex = 37
        Me.btnCancel.Text = "BATAL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkOku
        '
        Me.chkOku.AutoSize = True
        Me.chkOku.Location = New System.Drawing.Point(437, 191)
        Me.chkOku.Name = "chkOku"
        Me.chkOku.Size = New System.Drawing.Size(15, 14)
        Me.chkOku.TabIndex = 36
        Me.chkOku.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(458, 226)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 28)
        Me.btnClear.TabIndex = 35
        Me.btnClear.Text = "KOSONGKAN"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(367, 226)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(88, 28)
        Me.btnRegister.TabIndex = 34
        Me.btnRegister.Text = "DAFTAR"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'cmbEducation
        '
        Me.cmbEducation.FormattingEnabled = True
        Me.cmbEducation.Location = New System.Drawing.Point(437, 132)
        Me.cmbEducation.Name = "cmbEducation"
        Me.cmbEducation.Size = New System.Drawing.Size(188, 21)
        Me.cmbEducation.TabIndex = 33
        '
        'lblOku
        '
        Me.lblOku.AutoSize = True
        Me.lblOku.Location = New System.Drawing.Point(370, 191)
        Me.lblOku.Name = "lblOku"
        Me.lblOku.Size = New System.Drawing.Size(30, 13)
        Me.lblOku.TabIndex = 32
        Me.lblOku.Text = "OKU"
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Location = New System.Drawing.Point(437, 105)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(188, 21)
        Me.cmbGender.TabIndex = 30
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Location = New System.Drawing.Point(369, 110)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(41, 13)
        Me.lblgender.TabIndex = 29
        Me.lblgender.Text = "Jantina"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(368, 28)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(32, 13)
        Me.lblAge.TabIndex = 28
        Me.lblAge.Text = "Umur"
        '
        'cmbWork
        '
        Me.cmbWork.FormattingEnabled = True
        Me.cmbWork.Location = New System.Drawing.Point(437, 78)
        Me.cmbWork.Name = "cmbWork"
        Me.cmbWork.Size = New System.Drawing.Size(188, 21)
        Me.cmbWork.TabIndex = 27
        '
        'cmbRace
        '
        Me.cmbRace.FormattingEnabled = True
        Me.cmbRace.Location = New System.Drawing.Point(437, 49)
        Me.cmbRace.Name = "cmbRace"
        Me.cmbRace.Size = New System.Drawing.Size(188, 21)
        Me.cmbRace.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(170, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(10, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(228, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(10, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "-"
        '
        'lblEdu
        '
        Me.lblEdu.AutoSize = True
        Me.lblEdu.Location = New System.Drawing.Point(370, 135)
        Me.lblEdu.Name = "lblEdu"
        Me.lblEdu.Size = New System.Drawing.Size(60, 13)
        Me.lblEdu.TabIndex = 22
        Me.lblEdu.Text = "Pendidikan"
        '
        'lblincome
        '
        Me.lblincome.AutoSize = True
        Me.lblincome.Location = New System.Drawing.Point(369, 165)
        Me.lblincome.Name = "lblincome"
        Me.lblincome.Size = New System.Drawing.Size(65, 13)
        Me.lblincome.TabIndex = 21
        Me.lblincome.Text = "Pendapatan"
        '
        'cmbIncome
        '
        Me.cmbIncome.FormattingEnabled = True
        Me.cmbIncome.Location = New System.Drawing.Point(437, 159)
        Me.cmbIncome.Name = "cmbIncome"
        Me.cmbIncome.Size = New System.Drawing.Size(188, 21)
        Me.cmbIncome.TabIndex = 18
        '
        'lblOcc
        '
        Me.lblOcc.AutoSize = True
        Me.lblOcc.Location = New System.Drawing.Point(370, 86)
        Me.lblOcc.Name = "lblOcc"
        Me.lblOcc.Size = New System.Drawing.Size(55, 13)
        Me.lblOcc.TabIndex = 16
        Me.lblOcc.Text = "Pekerjaan"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(21, 226)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(38, 13)
        Me.lblState.TabIndex = 14
        Me.lblState.Text = "Negeri"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(20, 198)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(41, 13)
        Me.lblCity.TabIndex = 12
        Me.lblCity.Text = "Bandar"
        '
        'txtAdd
        '
        Me.txtAdd.Location = New System.Drawing.Point(108, 102)
        Me.txtAdd.Multiline = True
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAdd.Size = New System.Drawing.Size(188, 84)
        Me.txtAdd.TabIndex = 11
        '
        'lbladd
        '
        Me.lbladd.AutoSize = True
        Me.lbladd.Location = New System.Drawing.Point(20, 102)
        Me.lbladd.Name = "lbladd"
        Me.lbladd.Size = New System.Drawing.Size(39, 13)
        Me.lbladd.TabIndex = 10
        Me.lbladd.Text = "Alamat"
        '
        'txtOldIc
        '
        Me.txtOldIc.Location = New System.Drawing.Point(108, 76)
        Me.txtOldIc.Name = "txtOldIc"
        Me.txtOldIc.Size = New System.Drawing.Size(188, 20)
        Me.txtOldIc.TabIndex = 9
        '
        'txtNewIc3
        '
        Me.txtNewIc3.Location = New System.Drawing.Point(241, 48)
        Me.txtNewIc3.MaxLength = 4
        Me.txtNewIc3.Name = "txtNewIc3"
        Me.txtNewIc3.Size = New System.Drawing.Size(55, 20)
        Me.txtNewIc3.TabIndex = 8
        '
        'txtNewIc2
        '
        Me.txtNewIc2.Location = New System.Drawing.Point(183, 48)
        Me.txtNewIc2.MaxLength = 2
        Me.txtNewIc2.Name = "txtNewIc2"
        Me.txtNewIc2.Size = New System.Drawing.Size(40, 20)
        Me.txtNewIc2.TabIndex = 7
        '
        'txtNewIc1
        '
        Me.txtNewIc1.Location = New System.Drawing.Point(108, 48)
        Me.txtNewIc1.MaxLength = 6
        Me.txtNewIc1.Name = "txtNewIc1"
        Me.txtNewIc1.Size = New System.Drawing.Size(62, 20)
        Me.txtNewIc1.TabIndex = 6
        '
        'radOldIc
        '
        Me.radOldIc.AutoSize = True
        Me.radOldIc.Location = New System.Drawing.Point(88, 78)
        Me.radOldIc.Name = "radOldIc"
        Me.radOldIc.Size = New System.Drawing.Size(14, 13)
        Me.radOldIc.TabIndex = 5
        Me.radOldIc.TabStop = True
        Me.radOldIc.UseVisualStyleBackColor = True
        '
        'lblicold
        '
        Me.lblicold.AutoSize = True
        Me.lblicold.Location = New System.Drawing.Point(20, 76)
        Me.lblicold.Name = "lblicold"
        Me.lblicold.Size = New System.Drawing.Size(66, 13)
        Me.lblicold.TabIndex = 4
        Me.lblicold.Text = "No Kp Lama"
        '
        'radNewIc
        '
        Me.radNewIc.AutoSize = True
        Me.radNewIc.Location = New System.Drawing.Point(87, 50)
        Me.radNewIc.Name = "radNewIc"
        Me.radNewIc.Size = New System.Drawing.Size(14, 13)
        Me.radNewIc.TabIndex = 3
        Me.radNewIc.TabStop = True
        Me.radNewIc.UseVisualStyleBackColor = True
        '
        'lblicnew
        '
        Me.lblicnew.AutoSize = True
        Me.lblicnew.Location = New System.Drawing.Point(20, 48)
        Me.lblicnew.Name = "lblicnew"
        Me.lblicnew.Size = New System.Drawing.Size(62, 13)
        Me.lblicnew.TabIndex = 2
        Me.lblicnew.Text = "No Kp Baru"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(108, 21)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(188, 20)
        Me.txtName.TabIndex = 1
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(20, 21)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(35, 13)
        Me.lblname.TabIndex = 0
        Me.lblname.Text = "Nama"
        '
        'lblRace
        '
        Me.lblRace.AutoSize = True
        Me.lblRace.Location = New System.Drawing.Point(368, 57)
        Me.lblRace.Name = "lblRace"
        Me.lblRace.Size = New System.Drawing.Size(43, 13)
        Me.lblRace.TabIndex = 0
        Me.lblRace.Text = "Bangsa"
        '
        'lblmsg
        '
        Me.lblmsg.AutoSize = True
        Me.lblmsg.Location = New System.Drawing.Point(281, 317)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.Size = New System.Drawing.Size(36, 13)
        Me.lblmsg.TabIndex = 39
        Me.lblmsg.Text = "lblmsg"
        '
        'txtTown
        '
        Me.txtTown.Location = New System.Drawing.Point(108, 191)
        Me.txtTown.Name = "txtTown"
        Me.txtTown.Size = New System.Drawing.Size(188, 20)
        Me.txtTown.TabIndex = 13
        '
        'cmbState
        '
        Me.cmbState.FormattingEnabled = True
        Me.cmbState.Location = New System.Drawing.Point(108, 226)
        Me.cmbState.Name = "cmbState"
        Me.cmbState.Size = New System.Drawing.Size(188, 21)
        Me.cmbState.TabIndex = 39
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 350)
        Me.Controls.Add(Me.lblmsg)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmRegister"
        Me.Text = "Pendaftaran"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents chkOku As System.Windows.Forms.CheckBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents cmbEducation As System.Windows.Forms.ComboBox
    Friend WithEvents lblOku As System.Windows.Forms.Label
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents lblgender As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents cmbWork As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRace As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblEdu As System.Windows.Forms.Label
    Friend WithEvents lblincome As System.Windows.Forms.Label
    Friend WithEvents cmbIncome As System.Windows.Forms.ComboBox
    Friend WithEvents lblOcc As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents lbladd As System.Windows.Forms.Label
    Friend WithEvents txtOldIc As System.Windows.Forms.TextBox
    Friend WithEvents txtNewIc3 As System.Windows.Forms.TextBox
    Friend WithEvents txtNewIc2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNewIc1 As System.Windows.Forms.TextBox
    Friend WithEvents radOldIc As System.Windows.Forms.RadioButton
    Friend WithEvents lblicold As System.Windows.Forms.Label
    Friend WithEvents radNewIc As System.Windows.Forms.RadioButton
    Friend WithEvents lblicnew As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lblRace As System.Windows.Forms.Label
    Friend WithEvents lblmsg As System.Windows.Forms.Label
    Friend WithEvents txtumur As System.Windows.Forms.TextBox
    Friend WithEvents cmbState As System.Windows.Forms.ComboBox
    Friend WithEvents txtTown As System.Windows.Forms.TextBox
End Class
