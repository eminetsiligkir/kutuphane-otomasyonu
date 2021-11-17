Imports System.Data.SqlClient
Imports System.Threading.Thread
Imports System.Globalization
Imports System.Threading
Public Class Personel
    Dim conn As New SqlConnection("Data Source=ASUS\EMINE;Initial Catalog=kutuphane;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim dt As DataTable
    Dim sorgu As String
    Dim dr As SqlDataReader
    Dim kitap, dergi, gazete, dvd As String

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        Try
            dt = New DataTable
            cmd.Connection = conn
            cmd.CommandText = "select * from dbo.odunc_kitap"
            conn.Open()
            dt.Load(cmd.ExecuteReader)
            conn.Close()
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("hata oluştu", ex.Message, MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Radiokitap.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "insert dbo.kitaplar (barkod_no,kitap_ad,eser_no,yazar_ad,yayin_evi,sayfa_sayisi,isbn,ozet,anahtar_kelime,kapak_) values (@barkod_no,@kitap_ad,@eser_no,@yazar_ad,@yayin_evi,@sayfa_sayisi,@isbn,@ozet,@anahtar_kelime,@kapak_)"
            cmd.Parameters.AddWithValue("@barkod_no", txtbarkod.Text)
            cmd.Parameters.AddWithValue("@kitap_ad", txteserad.Text)
            cmd.Parameters.AddWithValue("@eser_no", txteserno.Text)
            cmd.Parameters.AddWithValue("@yazar_ad", txtyazarad.Text)
            cmd.Parameters.AddWithValue("@yayin_evi", txtyayinevi.Text)
            cmd.Parameters.AddWithValue("@sayfa_sayisi", txtsayfasayisi.Text)
            cmd.Parameters.AddWithValue("@isbn", txtisbn.Text)
            cmd.Parameters.AddWithValue("@ozet", RichTextBox1.Text)
            cmd.Parameters.AddWithValue("@anahtar_kelime", TextBox2.Text)
            cmd.Parameters.AddWithValue("@kapak_", TextBox5.Text)

            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Başarıyla Kaydedildi")
            conn.Close()
        End If
        If Radiodergi.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "insert dbo.dergiler (dergi_ad,dergi_no,dergi_tur,cilt,sayi,issn,y_tarihi,kapak) values (@dergi_ad,@dergi_no,@dergi_tur,@cilt,@sayi,@issn,@y_tarihi,@kapak)"
            cmd.Parameters.AddWithValue("@dergi_ad", txtdergiad.Text)
            cmd.Parameters.AddWithValue("@dergi_no", txtdergino.Text)
            cmd.Parameters.AddWithValue("@dergi_tur", txtdtur.Text)
            cmd.Parameters.AddWithValue("@cilt", txtcilt.Text)
            cmd.Parameters.AddWithValue("@sayi", txtdsayi.Text)
            cmd.Parameters.AddWithValue("@issn", txtissn.Text)
            cmd.Parameters.AddWithValue("@y_tarihi", txty_tarih.Text)
            cmd.Parameters.AddWithValue("@kapak", TextBox6.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Başarıyla Kaydedildi")
            conn.Close()
        End If
        If Radiogazete.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "insert dbo.gazete (gazete_ad,sa_yi,yayintarihi,gazete_no) values (@gazete_ad,@sa_yi,@yayintarihi,@gazete_no)"
            cmd.Parameters.AddWithValue("@gazete_ad", txtgazetead.Text)
            cmd.Parameters.AddWithValue("@yayintarihi", txtya_tarih.Text)
            cmd.Parameters.AddWithValue("@sa_yi", txtgsayi.Text)
            cmd.Parameters.AddWithValue("@gazete_no", txtgno.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Başarıyla Kaydedildi")
            conn.Close()
        End If
        If Radiodvd.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "insert dbo.dvd (dvd_ad,tur,yayin_tarihi,dvd_no) values (@dvd_ad,@tur,@yayin_tarihi,@dvd_no)"
            cmd.Parameters.AddWithValue("@dvd_ad", txtdad.Text)
            cmd.Parameters.AddWithValue("@yayin_tarihi", txty_tarihi.Text)
            cmd.Parameters.AddWithValue("@tur", txtdtur.Text)
            cmd.Parameters.AddWithValue("@dvd_no", txtdad.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Başarıyla Kaydedildi")
            conn.Close()
        End If

    End Sub


    Private Sub btnkaydet_Click(sender As Object, e As EventArgs) Handles btnkaydet.Click
        Try
            cmd.Connection = conn
            cmd.CommandText = "insert dbo.uyeler (uye_ad,uye_soyad,tc_kimlik,telefon,eposta,adres,sifre) values (@uye_ad,@uye_soyad,@tc_kimlik,@telefon,@eposta,@adres,@sifre)"
            cmd.Parameters.AddWithValue("@uye_ad", txtad.Text)
            cmd.Parameters.AddWithValue("@uye_soyad", txtsoyad.Text)
            cmd.Parameters.AddWithValue("@tc_kimlik", txtkimlik.Text)
            cmd.Parameters.AddWithValue("@telefon", txttelefon.Text)
            cmd.Parameters.AddWithValue("@eposta", txteposta.Text)
            cmd.Parameters.AddWithValue("@adres", txtadres.Text)
            cmd.Parameters.AddWithValue("@sifre", txtsifre.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Başarıyla Kaydedildi")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("hata oluştu", ex.Message, MessageBoxButtons.OK)
        End Try
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtad.Clear()
        txtadres.Clear()
        txtbarkod.Clear()
        txtcilt.Clear()
        txtdad.Clear()
        txtdergiad.Clear()
        txtdergino.Clear()
        txtdsayi.Clear()
        txtdtur.Clear()
        txteposta.Clear()
        txteser.Clear()
        txteserad.Clear()
        txteserno.Clear()
        txtgazetead.Clear()
        txtgsayi.Clear()
        txtisbn.Clear()
        txtissn.Clear()
        txtkad.Clear()
        txtkimlik.Clear()
        txtodunct.Clear()
        txtsayfasayisi.Clear()
        txtsifre.Clear()
        txtsoyad.Clear()
        txttc.Clear()
        txttelefon.Clear()
        txtteslimt.Clear()
        txtyazarad.Clear()
        txtyayinevi.Clear()
        txtya_tarih.Clear()
        txty_tarih.Clear()
        txty_tarihi.Clear()
        txtyazar.Clear()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnsil.Click
        If Radiokitap.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "delete from dbo.kitaplar where eser_no=@eser_no and barkod_no=@barkod_no"
            cmd.Parameters.AddWithValue("@barkod_no", txtbarkod.Text)
            cmd.Parameters.AddWithValue("@kitap_ad", txteserad.Text)
            cmd.Parameters.AddWithValue("@eser_no", txteserno.Text)
            cmd.Parameters.AddWithValue("@yazar_ad", txtyazarad.Text)
            cmd.Parameters.AddWithValue("@yayin_evi", txtyayinevi.Text)
            cmd.Parameters.AddWithValue("@sayfa_sayisi", txtsayfasayisi.Text)
            cmd.Parameters.AddWithValue("@isbn", txtisbn.Text)
            cmd.Parameters.AddWithValue("@ozet", RichTextBox1.Text)
            cmd.Parameters.AddWithValue("@kapak_", TextBox5.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Başarıyla Silindi")
            conn.Close()
        End If
        If Radiodergi.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "delete from dbo.dergiler where dergi_no=@dergi_no"
            cmd.Parameters.AddWithValue("@dergi_ad", txtdergiad.Text)
            cmd.Parameters.AddWithValue("@dergi_no", txtdergino.Text)
            cmd.Parameters.AddWithValue("@dergi_tur", txtdtur.Text)
            cmd.Parameters.AddWithValue("@cilt", txtcilt.Text)
            cmd.Parameters.AddWithValue("@sayi", txtdsayi.Text)
            cmd.Parameters.AddWithValue("@issn", txtissn.Text)
            cmd.Parameters.AddWithValue("@y_tarihi", txty_tarih.Text)
            cmd.Parameters.AddWithValue("@kapak", TextBox5.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Başarıyla Silindi")
            conn.Close()
        End If
        If Radiogazete.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "delete from dbo.gazete where gazete_ad=@gazete_ad and gazete_no=@gazete_no"
            cmd.Parameters.AddWithValue("@gazete_ad", txtgazetead.Text)
            cmd.Parameters.AddWithValue("@yayintarihi", txtya_tarih.Text)
            cmd.Parameters.AddWithValue("@sa_yi", txtgsayi.Text)
            cmd.Parameters.AddWithValue("@gazete_no", txtgno.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Başarıyla Silindi")
            conn.Close()
        End If
        If Radiodvd.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "delete from dbo.dvd where dvd_no=@dvd_no"
            cmd.Parameters.AddWithValue("@dvd_ad", txtdad.Text)
            cmd.Parameters.AddWithValue("@yayin_tarihi", txty_tarihi.Text)
            cmd.Parameters.AddWithValue("@tur", txtdtur.Text)
            cmd.Parameters.AddWithValue("@dvd_no", txtdad.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Başarıyla Silindi")
            conn.Close()
        End If
    End Sub

    Private Sub btnguncelle_Click(sender As Object, e As EventArgs) Handles btnguncelle.Click
        If Radiokitap.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "update dbo.kitaplar set barkod_no=@barkod_no,kitap_ad=@kitap_ad,eser_no=@eser_no,yazar_ad=@yazar_ad,yayin_evi=@yayin_evi,sayfa_sayisi=@sayfa_sayisi,isbn=@isbn,ozet=@ozet,kapak_=@kapak_ where eser_no=@eser_no"
            cmd.Parameters.AddWithValue("@barkod_no", txtbarkod.Text)
            cmd.Parameters.AddWithValue("@kitap_ad", txteserad.Text)
            cmd.Parameters.AddWithValue("@eser_no", txteserno.Text)
            cmd.Parameters.AddWithValue("@yazar_ad", txtyazarad.Text)
            cmd.Parameters.AddWithValue("@yayin_evi", txtyayinevi.Text)
            cmd.Parameters.AddWithValue("@sayfa_sayisi", txtsayfasayisi.Text)
            cmd.Parameters.AddWithValue("@isbn", txtisbn.Text)
            cmd.Parameters.AddWithValue("@ozet", RichTextBox1.Text)
            cmd.Parameters.AddWithValue("@kapak_", TextBox5.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Başarıyla Güncellendi")
            conn.Close()
        End If
        If Radiodergi.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "update dbo.dergiler set dergi_ad=@dergi_ad,dergi_no=@dergi_no,dergi_tur=@dergi_tur,cilt=@cilt,sayi=@sayi,issn=@issn,y_tarihi=@y_tarihi,kapak=@kapak where dergi_no=@dergi_no"
            cmd.Parameters.AddWithValue("@dergi_ad", txtdergiad.Text)
            cmd.Parameters.AddWithValue("@dergi_no", txtdergino.Text)
            cmd.Parameters.AddWithValue("@dergi_tur", txtdtur.Text)
            cmd.Parameters.AddWithValue("@cilt", txtcilt.Text)
            cmd.Parameters.AddWithValue("@sayi", txtdsayi.Text)
            cmd.Parameters.AddWithValue("@issn", txtissn.Text)
            cmd.Parameters.AddWithValue("@y_tarihi", txty_tarih.Text)
            cmd.Parameters.AddWithValue("@kapak", TextBox5.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Başarıyla Güncellendi")
            conn.Close()
        End If
        If Radiogazete.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "update dbo.gazete set gazete_ad=@gazete_ad,sa_yi=@sa_yi,yayintarihi=@yayintarihi,gazete_no=@gazete_no where gazete_no=@gazete_no"
            cmd.Parameters.AddWithValue("@gazete_ad", txtgazetead.Text)
            cmd.Parameters.AddWithValue("@yayintarihi", txtya_tarih.Text)
            cmd.Parameters.AddWithValue("@sa_yi", txtgsayi.Text)
            cmd.Parameters.AddWithValue("@gazete_no", txtgno.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Başarıyla Güncellendi")
            conn.Close()
        End If
        If Radiodvd.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "update dbo.dvd set dvd_ad=@dvd_ad,tur=@tur,yayin_tarihi=@yayin_tarihi,dvd_n0=@dvd_no where dvd_ad=@dvd_ad"
            cmd.Parameters.AddWithValue("@dvd_ad", txtdad.Text)
            cmd.Parameters.AddWithValue("@yayin_tarihi", txty_tarihi.Text)
            cmd.Parameters.AddWithValue("@tur", txtdtur.Text)
            cmd.Parameters.AddWithValue("@dvd_no", txtdad.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Başarıyla Güncellendi")
            conn.Close()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            dt = New DataTable
            cmd.Connection = conn
            cmd.CommandText = "select * from dbo.kitaplar"
            conn.Open()
            dt.Load(cmd.ExecuteReader)
            conn.Close()
            DataGridView2.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("hata oluştu", ex.Message, MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try

            If RadioButton1.Checked Then
                cmd.Connection = conn
                cmd.CommandText = "delete from dbo.rezerve where tc_kimlik=@tc_kimlik and kitap_ad=@kitap_ad and eser_no=@eser_no "
                cmd.Parameters.AddWithValue("@tc_kimlik", txttc.Text)
                cmd.Parameters.AddWithValue("@teslimtarih", txtteslimt.Text)
                cmd.Parameters.AddWithValue("@odunctarih", txtodunct.Text)
                cmd.Parameters.AddWithValue("@kitap_ad", txtkad.Text)
                cmd.Parameters.AddWithValue("@eser_no", txteser.Text)
                cmd.Parameters.AddWithValue("@yazar_ad", txtyazar.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Kaydedildi")
                conn.Close()
            Else
                MsgBox("Hata Oluştu")
            End If
            If RadioButton2.Checked Then
                cmd.Connection = conn
                cmd.CommandText = "delete from dbo.rezerve where tc_kimlik=@tc_kimlik and dergi_ad=@dergi_ad and eser_no=@eser_no"
                cmd.Parameters.AddWithValue("@tc_kimlik", txttc.Text)
                cmd.Parameters.AddWithValue("@teslimtarih", txtteslimt.Text)
                cmd.Parameters.AddWithValue("@odunctarih", txtodunct.Text)
                cmd.Parameters.AddWithValue("@dergi_ad", txtkad.Text)
                cmd.Parameters.AddWithValue("@eser_no", txteser.Text)
                cmd.Parameters.AddWithValue("@yazar_ad", txtyazar.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Kaydedildi")
                conn.Close()
            Else
                MsgBox("Hata Oluştu")
            End If
            If RadioButton3.Checked Then
                cmd.Connection = conn
                cmd.CommandText = "delete from dbo.rezerve  where tc_kimlik=@tc_kimlik and dvd_ad=@dvd_ad "
                cmd.Parameters.AddWithValue("@tc_kimlik", txttc.Text)
                cmd.Parameters.AddWithValue("@teslimtarih", txtteslimt.Text)
                cmd.Parameters.AddWithValue("@odunctarih", txtodunct.Text)
                cmd.Parameters.AddWithValue("@dvd_ad", txtkad.Text)
                cmd.Parameters.AddWithValue("@eser_no", txteser.Text)
                cmd.Parameters.AddWithValue("@yazar_ad", txtyazar.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Kaydedildi")
                conn.Close()
            Else
                MsgBox("Hata Oluştu")
            End If
            If RadioButton4.Checked Then
                cmd.Connection = conn
                cmd.CommandText = "delete from dbo.rezerve where tc_kimlik=@tc_kimlik and gazete_ad=@gazete_ad "
                cmd.Parameters.AddWithValue("@tc_kimlik", txttc.Text)
                cmd.Parameters.AddWithValue("@teslimtarih", txtteslimt.Text)
                cmd.Parameters.AddWithValue("@odunctarih", txtodunct.Text)
                cmd.Parameters.AddWithValue("@gazete_ad", txtkad.Text)
                cmd.Parameters.AddWithValue("@eser_no", txteser.Text)
                cmd.Parameters.AddWithValue("@yazar_ad", txtyazar.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Kaydedildi")
                conn.Close()
            Else
                MsgBox("Hata Oluştu")
            End If
        Catch ex As Exception
            MessageBox.Show("hata oluştu", ex.Message, MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            dt = New DataTable
            cmd.Connection = conn
            cmd.CommandText = "select * from dbo.dergiler"
            conn.Open()
            dt.Load(cmd.ExecuteReader)
            conn.Close()
            DataGridView2.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("hata oluştu", ex.Message, MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            dt = New DataTable
            cmd.Connection = conn
            cmd.CommandText = "select * from dbo.uyeler"
            conn.Open()
            dt.Load(cmd.ExecuteReader)
            conn.Close()
            DataGridView2.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("hata oluştu", ex.Message, MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            dt = New DataTable
            cmd.Connection = conn
            cmd.CommandText = "select * from dbo.gazete"
            conn.Open()
            dt.Load(cmd.ExecuteReader)
            conn.Close()
            DataGridView2.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("hata oluştu", ex.Message, MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            dt = New DataTable
            cmd.Connection = conn
            cmd.CommandText = "select * from dbo.dvd"
            conn.Open()
            dt.Load(cmd.ExecuteReader)
            conn.Close()
            DataGridView2.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("hata oluştu", ex.Message, MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        Try
            dt = New DataTable
            cmd.Connection = conn
            cmd.CommandText = "select * from dbo.odunc_kitap"
            conn.Open()
            dt.Load(cmd.ExecuteReader)
            conn.Close()
            DataGridView2.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("hata oluştu", ex.Message, MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btngetir_Click(sender As Object, e As EventArgs)
        Dim barkod_no, kitap_ad, eser_no, yazar_ad, yayin_evi, sayfa_sayisi, isbn, ozet As String
        If RadioButton1.Checked Then
            barkod_no = txtbarkod.Text
            kitap_ad = txteserad.Text
            eser_no = txteserno.Text
            yazar_ad = txtyazarad.Text
            yayin_evi = txtyayinevi.Text
            sayfa_sayisi = txtsayfasayisi.Text
            isbn = txtisbn.Text
            ozet = RichTextBox1.Text

            cmd.Connection = conn
            cmd.CommandText = "select barkod_no,kitap_ad,eser_no,yazar_ad,yayin_evi,sayfa_sayisi,isbn,ozet from dbo.kitaplar barkod_no,kitap_ad,eser_no,yazar_ad,yayin_evi,sayfa_sayisi,isbn,ozet where barkod_no='" & txtbarkod.Text & "'kitap_ad='" & txteserad.Text & "'eser_no='" & txteserno.Text & "'yazar_ad='" & txtyazarad.Text & "'yayin_evi='" & txtyayinevi.Text & "'sayfa_sayisi='" & txtsayfasayisi.Text & "'isbn='" & txtisbn.Text & "'ozet='" & RichTextBox1.Text & "'"
            conn.Open()
            cmd.ExecuteReader()
            conn.Close()
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        Try
            dt = New DataTable
            cmd.Connection = conn
            cmd.CommandText = "select * from dbo.teslim"
            conn.Open()
            dt.Load(cmd.ExecuteReader)
            conn.Close()
            DataGridView2.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("hata oluştu", ex.Message, MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        dt = New DataTable
        cmd.Connection = conn
        cmd.CommandText = "select * from dbo.rezerve"
        conn.Open()
        dt.Load(cmd.ExecuteReader)
        conn.Close()
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)

        OpenFileDialog2.ShowDialog()
        OpenFileDialog2.Filter = "Jpeg Files (*.jpg)|*.jpg|Png Files (*.png)|*.png"

    End Sub

    Private Sub OpenFileDialog2_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog2.FileOk

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs)

        OpenFileDialog1.ShowDialog()
        OpenFileDialog1.Filter = "Jpeg Files (*.jpg)|*.jpg|Png Files (*.png)|*.png"

    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button15_Click_1(sender As Object, e As EventArgs) Handles Button15.Click
        Dim resim As New OpenFileDialog
        resim.Title = "resim dosyası seç"
        resim.Title = "Jpeg Dosyaları (*.jpeg)|*.jpeg"
        resim.ShowDialog()
        PictureBox1.ImageLocation = resim.FileName
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        TextBox5.Text = "konum " & resim.FileName
    End Sub

    Private Sub Button16_Click_1(sender As Object, e As EventArgs) Handles Button16.Click
        Dim resim As New OpenFileDialog
        resim.Title = "resim dosyası seç"
        resim.Title = "Jpeg Dosyaları (*.jpeg)|*.jpeg"
        resim.ShowDialog()
        PictureBox2.ImageLocation = resim.FileName
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        TextBox6.Text = "konum " & resim.FileName
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If RadioButton1.Checked Then
            Dim eser_no, eser_no2, eser_ad, yazar_ad, o_tarih, t_tarih, odunc_no As String
            eser_no2 = txteser.Text
            cmd.Connection = conn
            conn.Open()
            cmd.CommandText = "select * from kitaplar where eser_no='" & eser_no2 & "'"
            dr = cmd.ExecuteReader()
            Do While dr.Read
                eser_no = dr("eser_no")
                yazar_ad = dr("yazar_ad")
                eser_ad = dr("kitap_ad")
                t_tarih = dr("t_tarih")
                o_tarih = dr("o_tarih")
                odunc_no = dr("odunc_no")
            Loop
            If eser_no = eser_no2 Then
                txteser.Text = eser_no2
                txtyazar.Text = yazar_ad
                txtkad.Text = eser_ad
                txtodunct.Text = o_tarih
                txtteslimt.Text = t_tarih
                TextBox3.Text = odunc_no
            Else
                MsgBox("Aradığınız bulunmamakta")
            End If
            conn.Close()
            dr.Close()
        End If
        If RadioButton2.Checked Then
            Dim eser_no, eser_no2, eser_ad, yazar_ad, o_no As String
            Dim teslim_t, odunc_t As String
            eser_no2 = txteser.Text
            cmd.Connection = conn
            conn.Open()
            cmd.CommandText = "select * from dergiler where dergi_no='" & eser_no2 & "'"
            dr = cmd.ExecuteReader()
            Do While dr.Read
                eser_no = dr("dergi_no")
                eser_ad = dr("dergi_ad")
                teslim_t = dr("teslim_t")
                odunc_t = dr("odunc_t")
                o_no = dr("o_no")

            Loop
            If eser_no = eser_no2 Then
                txteser.Text = eser_no2
                txtkad.Text = eser_ad
                txtodunct.Text = odunc_t
                txtteslimt.Text = teslim_t
                TextBox3.Text = o_no
            Else
                MsgBox("Aradığınız bulunmamakta")
            End If
            conn.Close()
            dr.Close()
        End If
        If RadioButton3.Checked Then
            Dim eser_no, eser_no2, eser_ad, yazar_ad, od_tar, tes_tar, odunc_num As String
            eser_no2 = txteser.Text
            cmd.Connection = conn
            conn.Open()
            cmd.CommandText = "select * from dvd where dvd_no='" & eser_no2 & "'"
            dr = cmd.ExecuteReader()
            Do While dr.Read
                eser_no = dr("dvd_no")
                eser_ad = dr("dvd_ad")
                tes_tar = dr("tes_tar")
                od_tar = dr("od_tar")
                odunc_num = dr("odunc_num")

            Loop
            If eser_no = eser_no2 Then
                txteser.Text = eser_no2
                txtkad.Text = eser_ad
                txtodunct.Text = od_tar
                txtteslimt.Text = tes_tar
                TextBox3.Text = odunc_num

            Else
                MsgBox("Aradığınız bulunmamakta")
            End If
            conn.Close()
            dr.Close()
        End If
        If RadioButton4.Checked Then
            Dim eser_no, eser_no2, eser_ad, yazar_ad, odunc_tar, teslim_tar, od_no As String
            eser_no2 = txteser.Text
            cmd.Connection = conn
            conn.Open()
            cmd.CommandText = "select * from gazete where gazete_no='" & eser_no2 & "'"
            dr = cmd.ExecuteReader()
            Do While dr.Read
                eser_no = dr("gazete_no")
                eser_ad = dr("gazete_ad")
                teslim_tar = dr("teslim_tar")
                odunc_tar = dr("odunc_tar")
                od_no = dr("od_no")

            Loop
            If eser_no = eser_no2 Then
                txteser.Text = eser_no2
                txtkad.Text = eser_ad
                txtodunct.Text = odunc_tar
                txtteslimt.Text = teslim_tar
                TextBox3.Text = od_no
            Else
                MsgBox("Aradığınız bulunmamakta")
            End If
            conn.Close()
            dr.Close()
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If RadioButton1.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "select * from dbo.kitaplar where odunc_no= '" + TextBox3.Text + "'"
            dt = New DataTable
            conn.Open()
            dt.Load(cmd.ExecuteReader)
            conn.Close()
            DataGridView1.DataSource = dt
        End If
        If RadioButton2.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "select * from dbo.dergiler where o_no= '" + TextBox3.Text + "'"
            dt = New DataTable
            conn.Open()
            dt.Load(cmd.ExecuteReader)
            conn.Close()
            DataGridView1.DataSource = dt
        End If
        If RadioButton3.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "select * from dbo.dvd where odunc_num= '" + TextBox3.Text + "'"
            dt = New DataTable
            conn.Open()
            dt.Load(cmd.ExecuteReader)
            conn.Close()
            DataGridView1.DataSource = dt
        End If
        If RadioButton4.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "select * from dbo.gazete where od_no= '" + TextBox3.Text + "'"
            dt = New DataTable
            conn.Open()
            dt.Load(cmd.ExecuteReader)
            conn.Close()
            DataGridView1.DataSource = dt
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If RadioButton1.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "update dbo.kitaplar set odunc_no=@odunc_no,o_tarih=@o_tarih,t_tarih=@t_tarih where eser_no=@eser_no"
            cmd.Parameters.AddWithValue("@odunc_no", TextBox3.Text)
            cmd.Parameters.AddWithValue("@o_tarih", txtodunct.Text)
            cmd.Parameters.AddWithValue("@t_tarih", txtteslimt.Text)
            cmd.Parameters.AddWithValue("@eser_no", txteser.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Başarıyla Kaydedildi")
            conn.Close()
        End If
        If RadioButton2.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "update dbo.dergiler set o_no=@o_no,odunc_t=@odunc_t,teslim_t=@teslim_ where dergi_no=@dergi_no"
            cmd.Parameters.AddWithValue("@o_no", TextBox3.Text)
            cmd.Parameters.AddWithValue("@odunc_t", txtodunct.Text)
            cmd.Parameters.AddWithValue("@teslim_t", txtteslimt.Text)
            cmd.Parameters.AddWithValue("@dergi_no", txteser.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Başarıyla Kaydedildi")
            conn.Close()
        End If
        If RadioButton3.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "update dbo.dvd set odunc_num=@odunc_num,od_tar=@od_tar,tes_tar=@tes_tar where dvd_no=@dvd_no"
            cmd.Parameters.AddWithValue("@odunc_num", TextBox3.Text)
            cmd.Parameters.AddWithValue("@od_tar", txtodunct.Text)
            cmd.Parameters.AddWithValue("@tes_tar", txtteslimt.Text)
            cmd.Parameters.AddWithValue("@dvd_no", txteser.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Başarıyla Kaydedildi")
            conn.Close()
        End If
        If RadioButton4.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "update dbo.gazete set od_no=@od_no,odunc_tar=@odunc_tar,teslim_tar=@teslim_tar where gazete_no=@gazete_no"
            cmd.Parameters.AddWithValue("@od_no", TextBox3.Text)
            cmd.Parameters.AddWithValue("@odunc_tar", txtodunct.Text)
            cmd.Parameters.AddWithValue("@teslim_tar", txtteslimt.Text)
            cmd.Parameters.AddWithValue("@gazete_no", txteser.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Başarıyla Kaydedildi")
            conn.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Try
            If RadioButton1.Checked Then
                cmd.Connection = conn
                cmd.CommandText = "insert dbo.odunc_kitap (tc_kimlik,teslimtarih,odunctarih,kitap_ad,eser_no,yazar) values (@tc_kimlik,@teslimtarih,@odunctarih,@kitap_ad,@eser_no,@yazar)"
                cmd.Parameters.AddWithValue("@tc_kimlik", txttc.Text)
                cmd.Parameters.AddWithValue("@teslimtarih", txtteslimt.Text)
                cmd.Parameters.AddWithValue("@odunctarih", txtodunct.Text)
                cmd.Parameters.AddWithValue("@kitap_ad", txtkad.Text)
                cmd.Parameters.AddWithValue("@eser_no", txteser.Text)
                cmd.Parameters.AddWithValue("@yazar", txtyazar.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Kaydedildi")
                conn.Close()
            End If

            If RadioButton2.Checked Then
                cmd.Connection = conn
                cmd.CommandText = "insert dbo.odunc_kitap (tc_kimlik,teslimtarih,odunctarih,dergi_ad,eser_no,yazar) values (@tc_kimlik,@teslimtarih,@odunctarih,@dergi_ad,@eser_no,@yazar)"
                cmd.Parameters.AddWithValue("@tc_kimlik", txttc.Text)
                cmd.Parameters.AddWithValue("@teslimtarih", txtteslimt.Text)
                cmd.Parameters.AddWithValue("@odunctarih", txtodunct.Text)
                cmd.Parameters.AddWithValue("@dergi_ad", txtkad.Text)
                cmd.Parameters.AddWithValue("@eser_no", txteser.Text)
                cmd.Parameters.AddWithValue("@yazar", txtyazar.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Kaydedildi")
            End If
            If RadioButton3.Checked Then
                cmd.Connection = conn
                cmd.CommandText = "insert dbo.odunc_kitap (tc_kimlik,teslimtarih,odunctarih,dvd_ad,eser_no,yazar) values (@tc_kimlik,@teslimtarih,@odunctarih,@dvd_ad,@eser_no,@yazar)"
                cmd.Parameters.AddWithValue("@tc_kimlik", txttc.Text)
                cmd.Parameters.AddWithValue("@teslimtarih", txtteslimt.Text)
                cmd.Parameters.AddWithValue("@odunctarih", txtodunct.Text)
                cmd.Parameters.AddWithValue("@dvd_ad", txtkad.Text)
                cmd.Parameters.AddWithValue("@eser_no", txteser.Text)
                cmd.Parameters.AddWithValue("@yazar", txtyazar.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Kaydedildi")
            End If
            If RadioButton4.Checked Then
                cmd.Connection = conn
                cmd.CommandText = "insert dbo.odunc_kitap (tc_kimlik,teslimtarih,odunctarih,gazete_ad,eser_no,yazar) values (@tc_kimlik,@teslimtarih,@odunctarih,@gazete_ad,@eser_no,@yazar)"
                cmd.Parameters.AddWithValue("@tc_kimlik", txttc.Text)
                cmd.Parameters.AddWithValue("@teslimtarih", txtteslimt.Text)
                cmd.Parameters.AddWithValue("@odunctarih", txtodunct.Text)
                cmd.Parameters.AddWithValue("@gazete_ad", txtkad.Text)
                cmd.Parameters.AddWithValue("@eser_no", txteser.Text)
                cmd.Parameters.AddWithValue("@yazar", txtyazar.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Kaydedildi")
            End If
            dt = New DataTable
            conn.Open()
            dt.Load(cmd.ExecuteReader)
            cmd.ExecuteNonQuery()
            MsgBox("Kaydedildi")
            conn.Close()
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("hata oluştu", ex.Message, MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Try

        Catch ex As Exception
            MessageBox.Show("hata oluştu", ex.Message, MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        Giriş.Show()
    End Sub
End Class