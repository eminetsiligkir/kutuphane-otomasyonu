Imports System.Data.SqlClient
Imports System.Threading.Thread
Imports System.Globalization
Imports System.Threading
Public Class Giriş
    Dim conn As New SqlConnection("Data Source=ASUS\EMINE;Initial Catalog=kutuphane;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim tur, g_kadi, g_sifre, k_adi, sifre As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tur = ComboBox1.SelectedItem
        If tur = "Yönetici" Then

            Try
                g_kadi = txtkullanici.Text
                g_sifre = txtsifre.Text
                cmd.Connection = conn
                cmd.CommandText = "Select kullanici_adi,sifre  FROM kullanici WHERE kullanici_adi = '" & g_kadi & "' and sifre='" & g_sifre & "'"
                conn.Open()
                dr = cmd.ExecuteReader
                Do While dr.Read
                    k_adi = dr("kullanici_adi")
                    sifre = dr("sifre")
                Loop
                If k_adi = g_kadi Then

                    Yönetici.Show()
                    Me.Hide()

                Else
                    MsgBox("Hatalı kullanici adı veya sifre.")
                End If
                dr.Close()
                conn.Close()
            Catch ex As Exception
                MsgBox("Hatalı kullanici adı veya sifre.")
            End Try
        ElseIf tur = "Personel" Then
            Try
                g_kadi = txtkullanici.Text
                g_sifre = txtsifre.Text
                cmd.Connection = conn
                cmd.CommandText = "Select kullanici_adi,sifre  FROM kullanici WHERE kullanici_adi = '" & g_kadi & "' and sifre='" & g_sifre & "'"
                conn.Open()
                dr = cmd.ExecuteReader
                Do While dr.Read
                    k_adi = dr("kullanici_adi")
                    sifre = dr("sifre")
                Loop
                If k_adi = g_kadi Then

                    Personel.Show()
                    Me.Hide()

                Else
                    MsgBox("Hatalı kullanici adı veya sifre.")
                End If
                dr.Close()
                conn.Close()
            Catch ex As Exception
                MsgBox("Hatalı kullanici adı veya sifre.")
            End Try

        ElseIf tur = "Üye" Then
            Try
                g_kadi = txtkullanici.Text
                g_sifre = txtsifre.Text
                cmd.Connection = conn
                cmd.CommandText = "Select kullanici_adi,sifre  FROM kullanici WHERE kullanici_adi = '" & g_kadi & "' and sifre='" & g_sifre & "'"
                conn.Open()
                dr = cmd.ExecuteReader
                Do While dr.Read
                    k_adi = dr("kullanici_adi")
                    sifre = dr("sifre")
                Loop
                If k_adi = g_kadi Then

                    Uye.Show()
                    Me.Hide()

                Else
                    MsgBox("Hatalı kullanici adı veya sifre.")
                End If
                dr.Close()
                conn.Close()
            Catch ex As Exception
                MsgBox("Hatalı kullanici adı veya sifre.")
            End Try
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Yönetici")
        ComboBox1.Items.Add("Personel")
        ComboBox1.Items.Add("Üye")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Katalog.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en")
        Dim login As New Giriş
        login.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Thread.CurrentThread.CurrentCulture = New CultureInfo("tr")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("tr")
        Dim login As New Giriş
        login.Show()
        Me.Hide()
    End Sub
End Class
