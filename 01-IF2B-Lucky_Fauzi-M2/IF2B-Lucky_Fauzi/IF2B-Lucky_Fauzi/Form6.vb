Public Class luas_keliling_jajargenjang
    Private Sub handlerLuas(sender As Object, e As EventArgs) Handles hitungLuas.Click
        Dim valAlas, valTinggi, result As Double

        valAlas = Val(alas.Text)
        valTinggi = Val(tinggi.Text)

        result = valAlas * valTinggi
        hasilLuas.Text = result

        alas_keliling.Focus()
    End Sub

    Private Sub hitungKeliling_Click(sender As Object, e As EventArgs) Handles hitungKeliling.Click
        Dim valAlas, valSisiMiring, result As Double

        valAlas = Val(alas_keliling.Text)
        valSisiMiring = Val(sisi_miring.Text)

        result = 2 * (valAlas + valSisiMiring)
        hasil_keliling.Text = result
    End Sub

    Private Sub handleInputValidation(sender As Object, e As KeyPressEventArgs)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled() = True
        End If
    End Sub

    Private Sub handleEnter(e As KeyPressEventArgs, nextControl As Control)
        If (e.KeyChar = Chr(13)) Then
            nextControl.Focus()
        End If
    End Sub

    Private Sub alas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles alas.KeyPress
        handleInputValidation(sender, e)
        handleEnter(e, tinggi)
    End Sub

    Private Sub tinggi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tinggi.KeyPress
        handleInputValidation(sender, e)
        handleEnter(e, hitungLuas)
    End Sub

    Private Sub alas_keliling_KeyPress(sender As Object, e As KeyPressEventArgs) Handles alas_keliling.KeyPress
        handleInputValidation(sender, e)
        handleEnter(e, sisi_miring)
    End Sub

    Private Sub sisi_miring_KeyPress(sender As Object, e As KeyPressEventArgs) Handles sisi_miring.KeyPress
        handleInputValidation(sender, e)
        handleEnter(e, hitungKeliling)
    End Sub
End Class