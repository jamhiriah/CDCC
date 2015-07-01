Imports MySql.Data.MySqlClient

Public Class frmRegister

    Private Sub frmRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ValidateLanguange(lgId)

        ' BindState(cmbState)

        'BindState(cmbRace)
        BindRace(cmbRace, lgId)
        BindOccupation(cmbWork, lgId)
        BindGender(cmbGender, lgId)
        BindEducation(cmbEducation, lgId)
        BindIncome(cmbIncome, lgId)


    End Sub
   
    Public Sub ValidateLanguange(ByVal lgid As Integer)


        If lgId = 1 Then
            'BM'

            lblname.Text = "Nama"
            lblicnew.Text = "No Kp Baru"
            lblicold.Text = "No Kp Lama"
            lbladd.Text = "Alamat"
            lblCity.Text = "Bandar"
            lblState.Text = "Negeri"
            lblAge.Text = "Umur"
            lblRace.Text = "Bangsa"
            lblOcc.Text = "Pekerjaan"
            lblgender.Text = "Jantina"
            lblEdu.Text = "Pendidikan"
            lblincome.Text = "Pendapatan"
            lblOku.Text = "OKU"

            btnRegister.Text = "Daftar"
            btnCancel.Text = "Batal"
            btnClear.Text = "Kosongkan"


        ElseIf lgId = 2 Then
            'Eng'

            lblname.Text = "Name"
            lblicnew.Text = "New IC No"
            lblicold.Text = "Old IC No"
            lbladd.Text = "Address"
            lblCity.Text = "City"
            lblState.Text = "State"
            lblAge.Text = "Age"
            lblRace.Text = "Race"
            lblOcc.Text = "Occupation"
            lblgender.Text = "Gender"
            lblEdu.Text = "Education"
            lblincome.Text = "Income"
            lblOku.Text = "Disabilities"

            btnRegister.Text = "Register"
            btnCancel.Text = "Cancel"
            btnClear.Text = "Clear"


        End If


    End Sub

    Private Function ValidateIc()

        Dim ic As String

        If radNewIc.Checked = True Then

            ic = txtNewIc1.Text & txtNewIc2.Text & txtNewIc3.Text

        ElseIf radOldIc.Checked = True Then

            ic = txtOldIc.Text

        End If


        Return ic
    End Function

    Private Function ValidateOku()

        Dim id As Integer

        If chkOku.Checked = True Then

            id = 1
        Else


            id = 0
        End If


        Return id
    End Function

    'Public Function ValidateData()




    'End Function
    'Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click



    '    ''Dim conn As New MySqlConnection(strconn)
    '    Dim sqlcmd, sqlcmd2 As New MySqlCommand
    '    ' Dim sqlreader, sqlreader2 As MySqlDataReader

    '    Dim ic As String
    '    Dim okuid As Integer
    '    Dim regdate As String = Format(Now, "yyyy-MM-dd HH:mm:ss")


    '    conn.Open()

    '    ic = ValidateIc()
    '    okuid = ValidateOku()

    '    'sqlcmd = conn.CreateCommand
    '    dr = dbRead("SELECT * FROM user_details where icNo = '" & ic & "' ")
    '    'sqlcmd.CommandType = CommandType.Text
    '    'sqlreader = sqlcmd.ExecuteReader


    '    If dr.Read = True Then

    '        lblmsg.Text = "No Ic telah didaftarkan"

    '    Else
    '        ' insert new record

    '        If conn.State = ConnectionState.Open Then
    '            conn.Close()
    '        End If


    '        conn.Open()


    '        'sqlcmd2 = conn.CreateCommand
    '        dr = dbRead("INsert into user_details (name,icno,address,city,state_id,gender_id,age,race_id,occupation_id,education_id,income_id,oku,registered_date,user_type_id) " & _
    '                              "values('" & txtName.Text & "','" & ic & "', '" & txtAdd.Text & "','" & txtTown.Text & "', " & _
    '                              "" & cmbState.SelectedValue & "," & cmbGender.SelectedValue & "," & txtumur.Text & ", " & _
    '                              " " & cmbRace.SelectedValue & "," & cmbRace.SelectedValue & "," & cmbEducation.SelectedValue & ", " & _
    '                              " " & cmbIncome.SelectedValue & "," & okuid & ", '" & regdate & "',0)")

    '        'sqlcmd2.CommandType = CommandType.Text
    '        'sqlreader2 = sqlcmd2.ExecuteReader


    '        If lgId = 1 Then

    '            lblmsg.Text = "Berjaya didaftarkan"

    '        ElseIf lgId = 2 Then

    '            lblmsg.Text = "Successful Registered"
    '        End If

    '    End If

    '    dr.Close()
    '    conn.Close()

    'End Sub
End Class