Imports System.Data.SqlClient
Imports System.Threading.Thread
Imports System.Globalization
Imports System.Threading
Public Class Katalog
    Dim conn As New SqlConnection("Data Source=ASUS\EMINE;Initial Catalog=kutuphane;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim sorgu, i As String
    Dim dr As SqlDataReader
    Dim dt As DataTable
    Dim kitap, dergi, gazete, dvd As String

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kitap = 0
        dergi = 0
        gazete = 0
        dvd = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioButton1.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "select * from dbo.kitaplar where kitap_ad ='" + txteserad.Text + "'"
            dt = New DataTable
            conn.Open()
            dt.Load(cmd.ExecuteReader)
            conn.Close()
            DataGridView1.DataSource = dt
        End If
        If RadioButton2.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "select * from dbo.dergiler where dergi_ad ='" + txteserad.Text + "'"
            dt = New DataTable
            conn.Open()
            dt.Load(cmd.ExecuteReader)
            conn.Close()
            DataGridView1.DataSource = dt
        End If
        If RadioButton3.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "select * from dbo.dvd where dvd_ad ='" + txteserad.Text + "'"
            dt = New DataTable
            conn.Open()
            dt.Load(cmd.ExecuteReader)
            conn.Close()
            DataGridView1.DataSource = dt
        End If
        If RadioButton4.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "select * from dbo.gazete where gazete_ad ='" + txteserad.Text + "'"
            dt = New DataTable
            conn.Open()
            dt.Load(cmd.ExecuteReader)
            conn.Close()
            DataGridView1.DataSource = dt
        End If

        If RadioButton1.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "select * from dbo.kitaplar where yazar_ad ='" + txtyazar.Text + "'"
            dt = New DataTable
            conn.Open()
            dt.Load(cmd.ExecuteReader)
            conn.Close()
            DataGridView1.DataSource = dt
        End If

        If RadioButton1.Checked Then
            cmd.Connection = conn
            cmd.CommandText = "select * from dbo.kitaplar where yayin_evi ='" + txtyayinevi.Text + "'"
            dt = New DataTable
            conn.Open()
            dt.Load(cmd.ExecuteReader)
            conn.Close()
            DataGridView1.DataSource = dt
        End If


    End Sub

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
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If gazete = 1 Then
            kitap = 0
            dergi = 0
            dvd = 0
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txteserad.Clear()
        txtyayinevi.Clear()
        txtyazar.Clear()
    End Sub
End Class