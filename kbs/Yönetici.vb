Imports System.Data.SqlClient
Imports System.Threading.Thread
Imports System.Globalization
Imports System.Threading
Public Class Yönetici
    Dim conn As New SqlConnection("Data Source=ASUS\EMINE;Initial Catalog=kutuphane;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim dt As DataTable
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtad.Clear()
        txtsoyad.Clear()
        txtadres.Clear()
        txteposta.Clear()
        txtkimlik.Clear()
        txtsifre.Clear()
        txttelefon.Clear()
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub btnkaydet_Click(sender As Object, e As EventArgs) Handles btnkaydet.Click
        Try
            If RadioButton1.Checked Then
                cmd.Connection = conn
                cmd.CommandText = "insert uyeler (uye_ad,uye_soyad,tc_kimlik,telefon,eposta,adres,sifre) values (@uye_ad,@uye_soyad,@tc_kimlik,@telefon,@eposta,@adres,@sifre)"
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
            Else
                cmd.Connection = conn
                cmd.CommandText = "insert uyeler (personel_ad,personel_soyad,tc_kimlik,telefon,eposta,adres,sifre) values (@personel_ad,@personel_soyad,@tc_kimlik,@telefon,@eposta,@adres,@sifre)"
                cmd.Parameters.AddWithValue("@personel_ad", txtad.Text)
                cmd.Parameters.AddWithValue("@personel_soyad", txtsoyad.Text)
                cmd.Parameters.AddWithValue("@tc_kimlik", txtkimlik.Text)
                cmd.Parameters.AddWithValue("@telefon", txttelefon.Text)
                cmd.Parameters.AddWithValue("@eposta", txteposta.Text)
                cmd.Parameters.AddWithValue("@adres", txtadres.Text)
                cmd.Parameters.AddWithValue("@sifre", txtsifre.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Başarıyla Kaydedildi")
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("hata oluştu", ex.Message, MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        dt = New DataTable
        cmd.Connection = conn
        cmd.CommandText = "select * from dbo.teslim"
        conn.Open()
        dt.Load(cmd.ExecuteReader)
        conn.Close()
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Giriş.Show()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton1.Checked Then

        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            dt = New DataTable
            cmd.Connection = conn
            cmd.CommandText = "select * from dbo.kitaplar"
            conn.Open()
            dt.Load(cmd.ExecuteReader)
            conn.Close()
            DataGridView1.DataSource = dt
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
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("hata oluştu", ex.Message, MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            dt = New DataTable
            cmd.Connection = conn
            cmd.CommandText = "select * from dbo.uyeler"
            conn.Open()
            dt.Load(cmd.ExecuteReader)
            conn.Close()
            DataGridView1.DataSource = dt
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
            DataGridView1.DataSource = dt
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
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("hata oluştu", ex.Message, MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            dt = New DataTable
            cmd.Connection = conn
            cmd.CommandText = "select * from dbo.personeller"
            conn.Open()
            dt.Load(cmd.ExecuteReader)
            conn.Close()
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("hata oluştu", ex.Message, MessageBoxButtons.OK)
        End Try
    End Sub
End Class