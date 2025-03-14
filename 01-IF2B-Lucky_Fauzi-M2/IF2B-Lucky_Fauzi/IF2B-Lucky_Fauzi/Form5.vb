Public Class volumeTabung
    Private Sub handleVolumeTabung(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valJari2, valTinggi, result As Double
        Dim phi = 3.14

        valJari2 = Val(jari2.Text)
        valTinggi = Val(tinggi.Text)

        result = phi * valJari2 * valJari2 * valTinggi
        hasil.Text = result
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

    Private Sub jari2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jari2.KeyPress
        handleInputValidation(sender, e)
        handleEnter(e, tinggi)
    End Sub

    Private Sub tinggi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tinggi.KeyPress
        handleInputValidation(sender, e)
        handleEnter(e, Button1)
    End Sub
End Class