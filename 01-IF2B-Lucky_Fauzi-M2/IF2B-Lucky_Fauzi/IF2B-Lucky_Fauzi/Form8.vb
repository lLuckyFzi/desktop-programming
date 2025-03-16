Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class OrderMakanan
    Dim HargaMakanan, HargaMinuman As Double
    Dim TotalMakanan, TotalMinuman As Integer

    Private Sub handleInputValidation(sender As Object, e As KeyPressEventArgs)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled() = True
        End If
    End Sub

    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        inputDrinks.Enabled = False
        inputTotalDrink.Enabled = False
    End Sub

    Function FormatPriceRupiah(value As Double) As String
        Return value.ToString("#,##0", Globalization.CultureInfo.GetCultureInfo("id-Id"))
    End Function

    Private Sub inputSelectFoodsHandler(sender As Object, e As EventArgs) Handles inputFoods.SelectedIndexChanged
        Select Case inputFoods.Text
            Case "Nasi Padang"
                labelFoodPrice.Text = FormatPriceRupiah(20000)
                HargaMakanan = 20000
            Case "Nasi Uduk"
                labelFoodPrice.Text = FormatPriceRupiah(12000)
                HargaMakanan = 12000
            Case "Nasi Goreng"
                labelFoodPrice.Text = FormatPriceRupiah(18000)
                HargaMakanan = 18000
        End Select
    End Sub

    Private Sub inputSelectDrinksHandler(sender As Object, e As EventArgs) Handles inputDrinks.SelectedIndexChanged
        Select Case inputDrinks.Text
            Case "Jus Mangga"
                labelDrinkPrice.Text = FormatPriceRupiah(8000)
                HargaMinuman = 8000
            Case "Jus Alpukat"
                labelDrinkPrice.Text = FormatPriceRupiah(10000)
                HargaMinuman = 10000
            Case "Jus Jeruk"
                labelDrinkPrice.Text = FormatPriceRupiah(7000)
                HargaMinuman = 7000
        End Select
    End Sub

    Private Sub isWithDrinkHandler(sender As Object, e As EventArgs) Handles isWithDrink.CheckedChanged
        If isWithDrink.Checked = True Then
            inputDrinks.Enabled = True
            inputTotalDrink.Enabled = True
        Else
            inputDrinks.Enabled = False
            inputTotalDrink.Enabled = False
        End If
    End Sub
    Private Sub inputTotalFoodsHandler(sender As Object, e As KeyPressEventArgs) Handles inputTotalFood.KeyPress
        'Input number validation
        handleInputValidation(sender, e)
    End Sub

    Private Sub inputTotalDrinksHandler(sender As Object, e As KeyPressEventArgs) Handles inputTotalDrink.KeyPress
        'Input number validation
        handleInputValidation(sender, e)
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        TotalMakanan = inputTotalFood.Text
        TotalMinuman = inputTotalDrink.Text

        'Immediate If or Ternary
        labelTotal.Text = FormatPriceRupiah(
                IIf(isWithDrink.Checked = False, HargaMakanan * TotalMakanan, (HargaMakanan * TotalMakanan) + (HargaMinuman * TotalMinuman))
            )
    End Sub

End Class