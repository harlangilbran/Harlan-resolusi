Public Class Form1
    Private Sub TextJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextJumlah.KeyPress
        ' Jika user Tekan Enter pada Keyboard
        If e.KeyChar = ChrW(Keys.Enter) Then
            '# Lakukan Validasi jika inputan kosong
            If TextNamaBarang.Text = "" Or TextHargaSatuan.Text = "" Or TextJumlah.Text = "" Then
                ' Ubah BG Jika inputan kosong
                Me.BackColor = Color.OrangeRed
                MessageBox.Show("Inputan Tidak Boleh Kosong ..", "PERINGATAN !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                ' Jika Inputan telah terisi
                ' # Ubah Warna Background
                Me.BackColor = Color.Aqua
                ' Deklarasikan Variable
                Dim Harga, Jumlah As Integer
                Dim Total, Diskon, Bayar As Double
                Dim Bonus As String
                ' Pengisian Nilai Variable untuk Harga dan Jumlah
                ' Nilai/Value di ambil dari inputan User
                Harga = TextHargaSatuan.Text
                Jumlah = TextJumlah.Text
                ' Menghitung Total Harga
                Total = Harga * Jumlah
                ' Menentukan Diskon dan Bonus
                If Total >= 500000 Then
                    'Diskon 20%
                    Diskon = 0.2 * Total
                    Bonus = "Hand Bag"
                ElseIf Total >= 200000 Then
                    'Diskon 15%
                    Diskon = 0.15 * Total
                    Bonus = "Payung"
                ElseIf Total >= 100000 Then
                    'Diskon 10%
                    Diskon = 0.1 * Total
                    Bonus = "Kaos"
                ElseIf Total >= 50000 Then
                    'Diskon 5%
                    Diskon = 0.05 * Total
                    Bonus = "Pena"
                Else
                    Diskon = 0
                    Bonus = "Tidak dapat Diskon"
                End If
                ' Menghitung Total Bayar
                Bayar = Total - Diskon
                ' Tampilkan Output untuk Total Harga, Diskon, Total Bayar dan Bonus
                TextTotalHarga.Text = "Rp." & Format(Total, "#,#.##")
                TextDiskon.Text = "Rp." & Format(Diskon, "#,#.##")
                TextTotalBayar.Text = "Rp." & Format(Bayar, "#,#.##")
                TextBonus.Text = Bonus
            End If
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        TextNamaBarang.Clear()
        TextHargaSatuan.Clear()
        TextJumlah.Clear()
        TextTotalHarga.Clear()
        TextDiskon.Clear()
        TextTotalBayar.Clear()
        TextBonus.Clear()
        '# Ubah BG Jika Tombol reset di klik
        Me.BackColor = Color.Aqua
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles Btnclose.Click
        ' Tutup Form jika Tombol Keluar di klik
        End
    End Sub
End Class



