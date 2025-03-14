Public Class Form2
    Private Sub kaliHandler(sender As Object, e As EventArgs) Handles btnKali.Click
        Dim a, b, result As Double
        a = Val(txtAngka1.Text)
        b = Val(txtAngka2.Text)
        result = a * b
        txtHasil.Text = result

    End Sub

    Private Sub btnBagi_Click(sender As Object, e As EventArgs) Handles btnBagi.Click
        Dim a, b, result As Double
        a = Val(txtAngka1.Text)
        b = Val(txtAngka2.Text)
        result = a / b
        txtHasil.Text = result
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim a, b, result As Double
        a = Val(txtAngka1.Text)
        b = Val(txtAngka2.Text)
        result = a + b
        txtHasil.Text = result
    End Sub

    Private Sub btnKurang_Click(sender As Object, e As EventArgs) Handles btnKurang.Click
        Dim a, b, result As Double
        a = Val(txtAngka1.Text)
        b = Val(txtAngka2.Text)
        result = a - b
        txtHasil.Text = result
    End Sub

    Private Sub inputAngkaValidation(sender As Object, e As KeyPressEventArgs) Handles txtAngka1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled() = True
        End If
        If (e.KeyChar = Chr(13)) Then
            txtAngka2.Focus()
        End If
    End Sub

    Private Sub inputAngka2(sender As Object, e As KeyPressEventArgs) Handles txtAngka2.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled() = True
        End If
        If (e.KeyChar = Chr(13)) Then
            txtHasil.Focus()
        End If
    End Sub
End Class