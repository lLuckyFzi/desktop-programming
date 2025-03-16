Public Class DataKepegawaian
    'Dim pegawai As New Pegawai()
    Dim isAdd As Boolean = False
    Private monthList As List(Of Month)
    Dim jabatan As Jabatan() = {
        New Jabatan With {.Name = "Operator", .Salary = 1000000, .Tax = 0.05},
        New Jabatan With {.Name = "Pejabat Level 2", .Salary = 1500000, .Tax = 0.075},
        New Jabatan With {.Name = "Pejabat Level 1", .Salary = 2000000, .Tax = 0.0975}
    }
    Dim violations As New Dictionary(Of String, Integer) From {
        {"sakit", 20000},
        {"izin", 5000},
        {"tanpa_ket", 30000}
    }
    Function FormatPriceRupiah(value As Double) As String
        Return value.ToString("#,##0", Globalization.CultureInfo.GetCultureInfo("id-Id"))
    End Function

    Private Sub handleInputValidation(sender As Object, e As KeyPressEventArgs)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled() = True
        End If
    End Sub

    Private Function GenerateMonths() As List(Of Month)
        Dim monthName As String() = {
            "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "October", "November", "December"
        }
        Dim totalDay As Integer() = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
        Dim list As New List(Of Month)

        For i As Integer = 0 To 11
            list.Add(New Month(monthName(i), totalDay(i)))
        Next

        Return list
    End Function

    Private Sub FormLoad() Handles MyBase.Load
        inputEnabledHandler(False)
        btnDelete.Enabled = False
        btnHitungGaji.Enabled = False
        calculateSalary.Enabled = False

        'Input Select Jabatan Settings
        inputJabatan.DataSource = jabatan
        inputJabatan.DisplayMember = "Name"
        inputJabatan.ValueMember = "Salary"
        'End Input Select Jabatan Settings

        'Input Select Bulan Settings
        monthList = GenerateMonths()
        inputMonth.DataSource = monthList
        inputMonth.DisplayMember = "Name"
        inputMonth.ValueMember = "TotalDay"
        'End Input Select Bulan Settings
    End Sub

    Private Sub inputEnabledHandler(value As Boolean)
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Enabled = value
            ElseIf TypeOf ctrl Is ComboBox Then
                DirectCast(ctrl, ComboBox).Enabled = value
            ElseIf TypeOf ctrl Is DateTimePicker Then
                DirectCast(ctrl, DateTimePicker).Enabled = value
            End If
        Next
    End Sub
    Private Sub inputClearHandler(Optional parent As Control = Nothing)
        Dim selectedInputMonth As Month = CType(inputMonth.SelectedItem, Month)
        If parent Is Nothing Then parent = Me

        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Text = ""
                inputPotongan.Text = 0
                inputSick.Text = 0
                inputIzin.Text = 0
                inputTanpaKet.Text = 0
            ElseIf TypeOf ctrl Is ComboBox Then
                DirectCast(ctrl, ComboBox).SelectedIndex = 0
                inputHariKerja.Text = selectedInputMonth.TotalDay - 4
                inputGajiPokok.Text = FormatPriceRupiah(inputJabatan.SelectedValue)
            ElseIf TypeOf ctrl Is DateTimePicker Then
                DirectCast(ctrl, DateTimePicker).Value = DateTime.Now
            ElseIf TypeOf ctrl Is GroupBox Then
                inputClearHandler(ctrl)
            End If
        Next
    End Sub

    Private Function DateTimeValidation()
        Dim valueTanggalLahir As Date = inputDate.Value
        Dim usia As Integer = DateDiff(DateInterval.Year, valueTanggalLahir, DateTime.Now)

        If (DateTime.Now.Month < valueTanggalLahir.Month) Or (DateTime.Now.Month = valueTanggalLahir.Month And DateTime.Now.Day < valueTanggalLahir.Day) Then
            usia -= 1
        End If

        If usia < 18 Then
            MessageBox.Show("Maaf, Minimal harus berusia 18 tahun ke atas!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Public Function FirstFormValidation()
        Dim requiredFirstForm As Dictionary(Of Control, String) = New Dictionary(Of Control, String) From {
            {inputNip, "NIP Tidak Boleh Kosong!"},
            {inputName, "Nama Tidak Boleh Kosong!"},
            {inputBorn, "Tempat Lahir Tidak Boleh Kosong!"}
        }
        Dim requiredGroupBoxForm As Dictionary(Of Control, String) = New Dictionary(Of Control, String) From {
            {inputPotongan, "Input Potongan Tidak Boleh Kosong!"},
            {inputSick, "Input Sakit Tidak Boleh Kosong!"},
            {inputIzin, "Input Izin Tidak Boleh Kosong!"},
            {inputTanpaKet, "Input Tanpa Keterangan Tidak Boleh Kosong!"}
        }

        For Each field In requiredFirstForm
            If TypeOf field.Key Is TextBox AndAlso String.IsNullOrWhiteSpace(DirectCast(field.Key, TextBox).Text) Then
                MessageBox.Show(field.Value, "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                field.Key.Focus()
                Return False
            ElseIf TypeOf field.Key Is ComboBox AndAlso DirectCast(field.Key, ComboBox).SelectedIndex = -1 Then
                MessageBox.Show(field.Value, "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                field.Key.Focus()
                Return False
            End If
        Next

        For Each field In requiredGroupBoxForm
            If String.IsNullOrWhiteSpace(DirectCast(field.Key, TextBox).Text) Then
                MessageBox.Show(field.Value, "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                field.Key.Focus()
                Return False
            End If
        Next

        If inputDate.Value = DateTimePicker.MinimumDateTime Then
            MessageBox.Show("Tanggal Lahir Tidak Boleh Kosong!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            inputDate.Focus()
            Return False
        ElseIf Not DateTimeValidation() Then
            Return False
        End If

        Return True
    End Function

    Private Sub disabledFormHandler()
        isAdd = True
        btnAddData.Text = "Batal"
        btnAddData.BackColor = Color.Red
        inputEnabledHandler(True)
        btnDelete.Enabled = True
        btnHitungGaji.Enabled = True
        inputNip.Focus()
    End Sub
    Private Sub enabledFormHandler()
        isAdd = False
        btnAddData.Text = "Tambah Data"
        btnAddData.BackColor = Color.FromArgb(1, 42, 74)
        inputEnabledHandler(False)
        btnDelete.Enabled = False
        btnHitungGaji.Enabled = False
        calculateSalary.Enabled = False
        inputClearHandler()
    End Sub

    Private Sub onAddHandler(sender As Object, e As EventArgs) Handles btnAddData.Click
        If isAdd = False Then
            disabledFormHandler()
        ElseIf isAdd = True Then
            enabledFormHandler()
        End If
    End Sub

    Private Sub onCalculateSalary(sender As Object, e As EventArgs) Handles btnHitungGaji.Click
        Dim TotalBenefits, TotalViolation, NetSalary, TotalTax As Double
        Dim sakit As Integer = violations("sakit")
        Dim izin As Integer = violations("izin")
        Dim tanpaKet As Integer = violations("tanpa_ket")

        If FirstFormValidation() And isAdd = True Then
            Dim selectedJabatan As Jabatan = CType(inputJabatan.SelectedItem, Jabatan)
            Dim selectedInputMonth As Month = CType(inputMonth.SelectedItem, Month)
            Dim totalWorks As Integer = selectedInputMonth.TotalDay - 4

            calculateSalary.Enabled = True

            TotalViolation = (inputSick.Text * sakit) + (inputIzin.Text * izin) + (inputTanpaKet.Text * tanpaKet)
            TotalBenefits = (totalWorks * 50000) - TotalViolation

            inputGajiPokok.Text = FormatPriceRupiah(inputJabatan.SelectedValue)
            inputTunjangan.Text = FormatPriceRupiah(TotalBenefits)

            TotalTax = inputGajiPokok.Text * selectedJabatan.Tax
            inputTax.Text = FormatPriceRupiah(TotalTax)

            NetSalary = inputGajiPokok.Text + TotalBenefits - inputPotongan.Text - TotalTax
            inputGajiBersih.Text = FormatPriceRupiah(NetSalary)
        End If
    End Sub

    Private Sub onDeleteHandler(sender As Object, e As EventArgs) Handles btnDelete.Click
        inputClearHandler()
        inputNip.Focus()
        calculateSalary.Enabled = False
    End Sub

    Private Sub onQuitHandler(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub

    Private Sub inputMonthSelectHandler(sender As Object, e As EventArgs) Handles inputMonth.SelectedIndexChanged
        If inputMonth.SelectedItem IsNot Nothing Then
            Dim selectedInputMonth As Month = CType(inputMonth.SelectedItem, Month)
            inputHariKerja.Text = selectedInputMonth.TotalDay - 4
        End If
    End Sub

    Private Sub inputJabatanSelectHandler(sender As Object, e As EventArgs) Handles inputJabatan.SelectedIndexChanged
        If inputJabatan.SelectedItem IsNot Nothing Then
            Dim selectedJabatan As Jabatan = CType(inputJabatan.SelectedItem, Jabatan)
            inputGajiPokok.Text = FormatPriceRupiah(selectedJabatan.Salary)
        End If
    End Sub

    Private Sub inputNipKeyPress(sender As Object, e As KeyPressEventArgs) Handles inputNip.KeyPress
        handleInputValidation(sender, e)
    End Sub
    Private Sub inputSickKeyPress(sender As Object, e As KeyPressEventArgs) Handles inputSick.KeyPress
        handleInputValidation(sender, e)
    End Sub
    Private Sub inputIzinKeyPress(sender As Object, e As KeyPressEventArgs) Handles inputIzin.KeyPress
        handleInputValidation(sender, e)
    End Sub
    Private Sub inputTanpaKetKeyPress(sender As Object, e As KeyPressEventArgs) Handles inputTanpaKet.KeyPress
        handleInputValidation(sender, e)
    End Sub
End Class

Public Class Month
    Public Property Name As String
    Public Property TotalDay As Integer

    Public Sub New(name As String, totalDay As Integer)
        Me.Name = name
        Me.TotalDay = totalDay
    End Sub
End Class

Public Class Jabatan
    Public Property Name As String
    Public Property Salary As Double
    Public Property Tax As Double
End Class