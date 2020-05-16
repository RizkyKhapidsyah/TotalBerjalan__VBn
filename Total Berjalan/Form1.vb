Public Class Form1

    Private Sub tombolMasukkan_Click(sender As Object, e As EventArgs) Handles tombolMasukkan.Click
        Const intBANYAK_HARI As Integer = 5 'banyak hari
        Dim intHitung As Integer = 1        'pencacah loop
        Dim decPenjualan As Decimal = 0     'memuat penjualan harian
        Dim decTotal As Decimal = 0         'memuat penjualan total
        Dim strMasukan As String            'memuat masukan string

        'membaca penjualan tiap hari
        Do While intHitung <= intBANYAK_HARI
            'membaca penjualan harian dari user
            strMasukan = InputBox("Masukkan nilai penjualan untuk hari " &
            intHitung.ToString())

            'mengkonversi masukan menjadi sebuah Decimal
            If Decimal.TryParse(strMasukan, decPenjualan) Then
                'menambahkan penjualan harian pada penjualan total
                decTotal += decPenjualan

                'menambahkan 1 pada pencacah loop
                intHitung += 1
            Else
                'menampilkan pesan error karena masukan tak valid
                MessageBox.Show("Masukkan nilai numerik.")
            End If
        Loop

        'menampilkan penjualan total
        labelTotal.Text = "Rp. " & decTotal.ToString()
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        'menutup form
        Me.Close()
    End Sub
End Class
