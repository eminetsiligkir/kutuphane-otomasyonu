Imports System.Data.SqlClient
Imports System.Threading.Thread
Imports System.Globalization
Imports System.Threading
Public Class Uye
    Dim conn As New SqlConnection("Data Source=ASUS\EMINE;Initial Catalog=kutuphane;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim dt As New DataTable
    Dim kitap, dergi, gazete, dvd As String

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If kitap = 1 Then
            dergi = 0
            gazete = 0
            dvd = 0
        End If
    End Sub


    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If dergi = 1 Then
            kitap = 0
            gazete = 0
            dvd = 0
        End If

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If dvd = 1 Then
            kitap = 0
            dergi = 0
            gazete = 0
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub


    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If gazete = 1 Then
            kitap = 0
            dergi = 0
            dvd = 0
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Giriş.Show()
    End Sub

    Private Sub Uye_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kitap = 0
        dergi = 0
        gazete = 0
        dvd = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If RadioButton1.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "select * from dbo.kitaplar where kitap_ad ='" + TextBox1.Text + "' "
            dt = New DataTable
            conn.Open()
            dt.Load(cmd.ExecuteReader)
            conn.Close()
            DataGridView1.DataSource = dt
        End If
        If RadioButton2.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "Select * from dbo.dergiler where dergi_ad ='" + TextBox1.Text + "'"
            dt = New DataTable
            conn.Open()
            dt.Load(cmd.ExecuteReader)
            conn.Close()
            DataGridView1.DataSource = dt
        End If
        If RadioButton3.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "select * from dbo.dvd where dvd_ad ='" + TextBox1.Text + "'"
            dt = New DataTable
            conn.Open()
            dt.Load(cmd.ExecuteReader)
            conn.Close()
            DataGridView1.DataSource = dt
        End If
        If RadioButton4.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "select * from dbo.gazete where gazete_ad ='" + TextBox1.Text + "'"
            dt = New DataTable
            conn.Open()
            dt.Load(cmd.ExecuteReader)
            conn.Close()
            DataGridView1.DataSource = dt
        End If
        If RadioButton1.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "select * from dbo.kitaplar where yazar_ad ='" + TextBox3.Text + "'"
            dt = New DataTable
            conn.Open()
            dt.Load(cmd.ExecuteReader)
            conn.Close()
            DataGridView1.DataSource = dt
        End If
        If RadioButton1.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "select * from dbo.kitaplar where yayin_evi ='" + TextBox4.Text + "'"
            dt = New DataTable
            conn.Open()
            dt.Load(cmd.ExecuteReader)
            conn.Close()
            DataGridView1.DataSource = dt
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "insert dbo.rezerve (kitap_ad) values (@kitap_ad)"
            cmd.Parameters.AddWithValue("@kitap_ad", TextBox1.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Başarıyla Kaydedildi")
            conn.Close()
        End If
        If RadioButton2.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "insert dbo.rezerve (dergi_ad) values (@dergi_ad)"
            cmd.Parameters.AddWithValue("@dergi_ad", TextBox1.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Başarıyla Kaydedildi")
            conn.Close()
        End If

    End Sub
End Class