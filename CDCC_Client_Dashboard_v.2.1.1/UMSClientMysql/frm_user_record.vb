﻿Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Threading



Public Class frm_user_record

    Public strSQL As String
    'Dim conn As New MySqlConnection(strconn)
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public table As New DataTable

    Private Sub frm_user_record_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmMonitoring.btnout.Enabled = True
    End Sub


    Private Sub frmRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        If lgId = 1 Then

            lbl_title.Text = "MAKLUMAT PENGGUNA"


            lbl_nama.Text = "Nama"
            lbl_No_KP_baru.Text = "No KP Baru"
            lbl_No_KP_lama.Text = "No KP Lama/ Polis/Tentera/dll"
            lbldob.Text = "Tarikh Lahir"
            lbl_Alamat.Text = "Alamat"
            lbl_bandar.Text = "Bandar"
            lbl_negeri.Text = "Negeri"
            lbl_Bangsa.Text = "Bangsa"
            lbl_warganegara.Text = "Kewarganegaraan"
            lbl_Umur.Text = "Umur"
            lbl_jantina.Text = "Jantina"
            lbl_no_hp.Text = "No HP"
            lbl_no_tel.Text = "No Tel"
            lbl_email.Text = "Emel"
            lbl_pekerjaan.Text = "Pekerjaan"
            lbl_pendidikan.Text = "Pendidikan"
            lbl_pendapatan.Text = "Pendapatan"
            lbl_trkh_daftar.Text = "Tarikh Daftar"
            lbl_pengangkutan.Text = "Pengangkutan ke CBC"
            lbl_pngthuan_ict.Text = "Pengetahuan ICT "
            lbl_bil_isi_rmh.Text = "Bilangan isi rumah "
            lbl_jrk_rumah.Text = "Jarak dari rumah ke PJK"
            lbl_No_Kad.Text = "No Kad"
            lbl_masa.Text = "Masa dari rumah ke PJK"
            lbl_nama_site.Text = "Nama site"
            lbl_JenisAhli.Text = " Jenis Ahli"



        ElseIf lgId = 2 Then


            lbl_title.Text = "USER INFO"

            lbl_nama.Text = "Name"
            lbl_No_KP_baru.Text = "New IC no"
            lbl_No_KP_lama.Text = "Old IC no/Police/Army/etc"
            lbldob.Text = "Birth of date"
            lbl_Alamat.Text = "Address"
            lbl_bandar.Text = "Town"
            lbl_negeri.Text = "City"
            lbl_Bangsa.Text = "Race"
            lbl_warganegara.Text = "Nationality"
            lbl_Umur.Text = "Age"
            lbl_jantina.Text = "Gender"
            lbl_no_hp.Text = "HP No"
            lbl_no_tel.Text = "Tel No"
            lbl_email.Text = "Email"
            lbl_pekerjaan.Text = "Occupation"
            lbl_pendidikan.Text = "Education"
            lbl_pendapatan.Text = "Income"
            lbl_trkh_daftar.Text = "Register date"
            lbl_pengangkutan.Text = "Transport to CBC"
            lbl_pngthuan_ict.Text = "ICT Knowledge"
            lbl_bil_isi_rmh.Text = "Total no of household "
            lbl_jrk_rumah.Text = "Distance from house to PJK"
            lbl_No_Kad.Text = "Card No"
            lbl_masa.Text = "Time duration from house to PJK"
            lbl_nama_site.Text = "Site name"
            lbl_JenisAhli.Text = " User type"


        End If
        


        BindState(cbx_negeri)
        BindRace(cbx_bangsa, lgId)
        BindOccupation(cbx_pekerjaan, lgId)
        BindGender(cbx_jantina, lgId)
        BindNationality(cbx_warganegara, lgId)
        BindEducation(cbx_pendidikan, lgId)
        BindIncome(cbx_pndapatan, lgId)

        BindTypeMember(cbx_Jenis_Ahli, lgId)
        BindTransport(cbx_pengangkutan, lgId)
        BindKnowledge(cbx_pengetahuan, lgId)

        GetUserdetails(ICNo)


    End Sub

    Public Sub GetUserdetails(ByVal icno As String)

        'display data into textbox              //updated: 12/3/2012
        dr = dbRead("SELECT u.*, s.name statename,r.bm racename ,i.bm  salaryValue ,g.bm gendername , t.bm transportname, ut.bm uservaluename, o.bm occu_name, e.bm educ_name, ict.bm ict_name, nat.bm nat_type  " _
        & "FROM userdetails u " _
        & "inner join states s on u.state_id = s.id " _
        & "inner join races r on u.race_id = r.Id " _
        & "inner join income i on u.income_id = i.Id " _
        & "inner join genders g on u.gender_id = g.Id " _
        & "inner join transports t on u.transport_id = t.Id " _
        & "inner join usertypes ut on u.usertype_id = ut.Id " _
        & "inner join occupations o on u.occupation_id = o.Id " _
        & "inner join educations e on u.education_id = e.Id " _
        & "inner join ictknowledges ict on u.ictknowledge_id = ict.Id " _
        & "inner join nationalities nat on u.nationality_id = nat.Id " _
       & "WHERE u.icno ='" & icno & "'")


        dr.Read()

        Dim name = (dr.Item("name").ToString())
        Me.txt_nama.Text = name
        txt_nama.Enabled = False

        Me.RTB_Alamat.Text = dr.Item("address").ToString()
        RTB_Alamat.Enabled = False

        Dim city = (dr.Item("city").ToString())
        Me.txt_bandar.Text = city
        txt_bandar.Enabled = False

        Dim address = (dr.Item("address").ToString())
        Me.RTB_Alamat.Text = address
        RTB_Alamat.Enabled = False

        Dim state = (dr.Item("statename").ToString())
        Me.cbx_negeri.Text = state
        cbx_negeri.Enabled = False

        Dim salary = (dr.Item("salaryValue").ToString())
        Me.cbx_pndapatan.Text = salary
        cbx_pndapatan.Enabled = False

        Dim nationality = (dr.Item("nat_type").ToString())
        Me.cbx_warganegara.Text = nationality
        cbx_warganegara.Enabled = False

        Dim race = (dr.Item("racename").ToString())
        Me.cbx_bangsa.Text = race
        cbx_bangsa.Enabled = False

        Dim age = (dr.Item("age").ToString())
        Me.txt_age.Text = age
        txt_age.Enabled = False

        Dim gender = (dr.Item("gendername").ToString())
        Me.cbx_jantina.Text = gender
        cbx_jantina.Enabled = False

        Dim nombor_kad = (dr.Item("cardno").ToString())
        Me.txt_no_kad.Text = nombor_kad
        txt_no_kad.Enabled = False

        Dim nama_site = (dr.Item("other_site").ToString())
        Me.txt_nama_site.Text = nama_site
        txt_nama_site.Enabled = False

        Dim OKU = (dr.Item("oku").ToString())

        If OKU = "1" Then
            Me.chk_OKU.Checked = True
        Else
            Me.chk_OKU.Checked = False
        End If
        chk_OKU.Enabled = False

        Dim transport = (dr.Item("transportname").ToString())
        Me.cbx_pengangkutan.Text = transport
        cbx_pengangkutan.Enabled = False

        Dim ict_knowledge = (dr.Item("ict_name").ToString())
        Me.cbx_pengetahuan.Text = ict_knowledge
        cbx_pengetahuan.Enabled = False

        Dim distance = (dr.Item("distance").ToString())
        Me.txt_jrk_rmh.Text = distance
        txt_jrk_rmh.Enabled = False

        Dim duration = (dr.Item("time_to_cbc").ToString())
        Me.txt_masa_ke_pjk.Text = duration
        txt_masa_ke_pjk.Enabled = False

        Dim no_hp = (dr.Item("hp_no").ToString())
        Me.txt_no_hp.Text = no_hp
        txt_no_hp.Enabled = False

        Dim no_tel = (dr.Item("tel_no").ToString())
        Me.txt_no_tel.Text = no_tel
        txt_no_tel.Enabled = False

        Dim email = (dr.Item("email").ToString())
        Me.txt_email.Text = email
        txt_email.Enabled = False

        Dim household = (dr.Item("household").ToString())
        Me.txt_bil_isi_rmh.Text = household
        txt_bil_isi_rmh.Enabled = False

        Dim jenis_ahli = (dr.Item("uservaluename").ToString())
        Me.cbx_Jenis_Ahli.Text = jenis_ahli
        cbx_Jenis_Ahli.Enabled = False

        Dim occupation = (dr.Item("occu_name").ToString())
        Me.cbx_pekerjaan.Text = occupation
        cbx_pekerjaan.Enabled = False

        Dim education = (dr.Item("educ_name").ToString())
        Me.cbx_pendidikan.Text = education
        cbx_pendidikan.Enabled = False

        If icno.Length = 12 Then


            RB_KP_Baru.Checked = True
            RB_KP_Lama.Checked = False

            Dim first = icno.Substring(0, 6)
            Me.txt_ic_1.Text = first

            Dim Second = icno.Substring(6, 2)
            Me.txt_ic_2.Text = Second

            Dim Third = icno.Substring(8, 4)
            Me.txt_ic_3.Text = Third

            

        Else

            RB_KP_Lama.Checked = True
            RB_KP_Baru.Checked = False

            Me.txt_ic_lama.Text = icno


        End If

        Dim dob As String
        dob = dtp_DOB.Value.ToString("yyyy-MM-dd")
        dob = (dr.Item("dob").ToString())
        Me.dtp_DOB.Text = dob

        Dim register As String
        register = DTP_Daftar.Value.ToString("yyyy-MM-dd HH:mm:ss")
        register = (dr.Item("entry_dt").ToString())
        Me.DTP_Daftar.Text = register

        RB_KP_Baru.Enabled = False
        RB_KP_Lama.Enabled = False
        txt_ic_1.Enabled = False
        txt_ic_2.Enabled = False
        txt_ic_3.Enabled = False
        txt_ic_lama.Enabled = False
        dtp_DOB.Enabled = False
        DTP_Daftar.Enabled = False

        conn.Close()

    End Sub
   
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        frmMonitoring.btnout.Enabled = True
        Me.Close()
    End Sub
End Class
