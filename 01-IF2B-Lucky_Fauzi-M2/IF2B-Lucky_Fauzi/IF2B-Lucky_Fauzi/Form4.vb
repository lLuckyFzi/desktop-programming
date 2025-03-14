Public Class hitungLuas_KelilingSegitiga
    Private Sub handleHitungLuas(sender As Object, e As EventArgs) Handles hitungLuas.Click
        Dim valueAlas, valueTinggi, result As Double
        Dim luas As Double = 1.2

        valueAlas = Val(alas.Text)
        valueTinggi = Val(tinggi.Text)
        result = luas * (valueAlas * valueTinggi)

        hasilLuas.Text = result
        sisi.Focus()
    End Sub

    Private Sub handlerKeliling(sender As Object, e As EventArgs) Handles hitungKeliling.Click
        Dim valueSisi, result As Double

        valueSisi = Val(sisi.Text)
        result = valueSisi * valueSisi * valueSisi

        hasilKeliling.Text = result
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

    Private Sub sisi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles sisi.KeyPress
        handleInputValidation(sender, e)
        handleEnter(e, hitungKeliling)
    End Sub
End Class