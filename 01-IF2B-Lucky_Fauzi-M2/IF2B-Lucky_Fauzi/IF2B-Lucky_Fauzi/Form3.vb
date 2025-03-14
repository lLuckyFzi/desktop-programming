Public Class hitungNilai
    Private Sub handlerValue(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim valueTatapMuka, valueMidTest, valueFinalTest, results As Integer
        valueTatapMuka = Val(tatapMuka.Text)
        valueMidTest = Val(midTest.Text)
        valueFinalTest = Val(finalTest.Text)

        results = valueTatapMuka * valueMidTest * valueFinalTest / 3
        nilaiAkhir.Text = results
    End Sub

    Private Sub inputTatapMuka(sender As Object, e As KeyPressEventArgs) Handles tatapMuka.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled() = True
        End If
        If (e.KeyChar = Chr(13)) Then
            midTest.Focus()
        End If
    End Sub

    Private Sub midTest_KeyPress(sender As Object, e As KeyPressEventArgs) Handles midTest.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled() = True
        End If
        If (e.KeyChar = Chr(13)) Then
            finalTest.Focus()
        End If
    End Sub

    Private Sub btnHitung_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnHitung.KeyPress
        If (e.KeyChar = Chr(13)) Then
            Return
        End If
    End Sub
End Class