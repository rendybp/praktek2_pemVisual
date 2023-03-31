Public Class Form1
    Dim jumlahObat As Integer
    Dim hargaObat As String
    Dim total As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        jumlahObat = CInt(inputJumlah.Text)
        hargaObat = CInt(inputHarga.Text)
        total = (jumlahObat * hargaObat)
        output1.Text = "Total Pembayaran : Rp. " & total
        output2.Text = "Terimakasih Semoga Lekas Sembuh"
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inputJumlah.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        namaInput.Text = "0"
        noDaftarInput.Text = "0"
        alamatInput.Text = "0"
        jenisKelamin.Text = "0"
        inputJumlah.Text = "0"
        inputHarga.Text = "0"
        namaInput.Focus()
    End Sub
End Class
