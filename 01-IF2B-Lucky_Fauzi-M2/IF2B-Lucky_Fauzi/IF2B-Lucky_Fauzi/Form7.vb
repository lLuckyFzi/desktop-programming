Public Class programBelanja
    Private Sub onResetHandler(sender As Object, e As EventArgs) Handles btn_reset.Click
        'inputNamaBarang.Text = ""
        'inputHargaSatuan.Text = ""
        'inputJumlahSatuan.Text = ""
        'inputTotalHarga.Text = ""
        'inputDiskon.Text = ""
        'inputTotalBayar.Text = ""
        'inputBonus.Text = ""

        'Refactoring
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Text = ""
            End If
        Next

        inputNamaBarang.Focus()
    End Sub

    Private Sub onCalculateHandler(sender As Object, e As EventArgs) Handles btn_hitung.Click
        Dim TotalHarga, Diskon, Bayar As Double
        Dim ValJumlahSatuan, ValHargaSatuan As Integer
        Dim Bonus As String

        ValHargaSatuan = inputHargaSatuan.Text
        ValJumlahSatuan = inputJumlahSatuan.Text
        TotalHarga = ValHargaSatuan * ValJumlahSatuan

        If TotalHarga >= 500000 Then
            Diskon = 0.2 * TotalHarga
            Bonus = "Tas Pinggang"
        ElseIf TotalHarga >= 200000 Then
            Diskon = 0.15 * TotalHarga
            Bonus = "Payung"
        ElseIf TotalHarga >= 100000 Then
            Diskon = 0.1 * TotalHarga
            Bonus = "Kaos"
        ElseIf TotalHarga >= 50000 Then
            Diskon = 0.05 * TotalHarga
            Bonus = "Pena"
        Else
            Diskon = 0
            Bonus = "Tidak Mendapatkan Bonus"
        End If

        Bayar = TotalHarga - Diskon

        inputBonus.Text = Bonus
        inputDiskon.Text = Diskon
        inputTotalHarga.Text = TotalHarga
        inputTotalBayar.Text = Bayar

    End Sub
End Class