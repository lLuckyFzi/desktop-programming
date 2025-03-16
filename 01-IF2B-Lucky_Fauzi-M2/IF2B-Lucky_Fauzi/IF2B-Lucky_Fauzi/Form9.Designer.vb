<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataKepegawaian
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        inputNip = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        inputName = New TextBox()
        inputJabatan = New ComboBox()
        Label4 = New Label()
        inputDate = New DateTimePicker()
        Label5 = New Label()
        Label6 = New Label()
        inputBorn = New TextBox()
        btnAddData = New Button()
        btnDelete = New Button()
        btnQuit = New Button()
        btnHitungGaji = New Button()
        calculateSalary = New GroupBox()
        Label16 = New Label()
        inputGajiBersih = New TextBox()
        Label15 = New Label()
        inputTax = New TextBox()
        Label14 = New Label()
        inputPotongan = New TextBox()
        Label13 = New Label()
        inputTunjangan = New TextBox()
        Label12 = New Label()
        inputIzin = New TextBox()
        Label11 = New Label()
        inputTanpaKet = New TextBox()
        Label10 = New Label()
        inputSick = New TextBox()
        Label9 = New Label()
        inputHariKerja = New TextBox()
        inputMonth = New ComboBox()
        Label8 = New Label()
        Label7 = New Label()
        inputGajiPokok = New TextBox()
        calculateSalary.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Poppins Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label1.ForeColor = Color.FromArgb(1, 42, 74)
        Label1.Location = New Point(248, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(299, 37)
        Label1.TabIndex = 0
        Label1.Text = "Form Data Kepegawaian"
        ' 
        ' inputNip
        ' 
        inputNip.BackColor = Color.FromArgb(233, 236, 239)
        inputNip.BorderStyle = BorderStyle.None
        inputNip.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0)
        inputNip.Location = New Point(129, 81)
        inputNip.Name = "inputNip"
        inputNip.Size = New Size(226, 24)
        inputNip.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Poppins Medium", 12F)
        Label2.Location = New Point(42, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 28)
        Label2.TabIndex = 2
        Label2.Text = "NIP"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Poppins Medium", 12F)
        Label3.Location = New Point(42, 153)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 28)
        Label3.TabIndex = 4
        Label3.Text = "Nama"
        ' 
        ' inputName
        ' 
        inputName.BackColor = Color.FromArgb(233, 236, 239)
        inputName.BorderStyle = BorderStyle.None
        inputName.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0)
        inputName.Location = New Point(129, 157)
        inputName.Name = "inputName"
        inputName.Size = New Size(226, 24)
        inputName.TabIndex = 3
        ' 
        ' inputJabatan
        ' 
        inputJabatan.BackColor = Color.FromArgb(233, 236, 239)
        inputJabatan.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0)
        inputJabatan.FormattingEnabled = True
        inputJabatan.Location = New Point(129, 221)
        inputJabatan.Name = "inputJabatan"
        inputJabatan.Size = New Size(226, 36)
        inputJabatan.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Poppins Medium", 12F)
        Label4.Location = New Point(413, 81)
        Label4.Name = "Label4"
        Label4.Size = New Size(121, 28)
        Label4.TabIndex = 6
        Label4.Text = "Tanggal Lahir"
        ' 
        ' inputDate
        ' 
        inputDate.CalendarFont = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0)
        inputDate.Location = New Point(555, 82)
        inputDate.Name = "inputDate"
        inputDate.Size = New Size(208, 23)
        inputDate.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Poppins Medium", 12F)
        Label5.Location = New Point(413, 153)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 28)
        Label5.TabIndex = 9
        Label5.Text = "Tempat Lahir"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Poppins Medium", 12F)
        Label6.Location = New Point(42, 224)
        Label6.Name = "Label6"
        Label6.Size = New Size(81, 28)
        Label6.TabIndex = 10
        Label6.Text = "Jabatan"
        ' 
        ' inputBorn
        ' 
        inputBorn.BackColor = Color.FromArgb(233, 236, 239)
        inputBorn.BorderStyle = BorderStyle.None
        inputBorn.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0)
        inputBorn.Location = New Point(555, 153)
        inputBorn.Name = "inputBorn"
        inputBorn.Size = New Size(208, 24)
        inputBorn.TabIndex = 11
        ' 
        ' btnAddData
        ' 
        btnAddData.AutoSize = True
        btnAddData.BackColor = Color.FromArgb(1, 42, 74)
        btnAddData.FlatAppearance.BorderSize = 0
        btnAddData.FlatStyle = FlatStyle.Flat
        btnAddData.Font = New Font("Poppins Medium", 9.75F)
        btnAddData.ForeColor = SystemColors.ButtonHighlight
        btnAddData.Location = New Point(42, 714)
        btnAddData.Name = "btnAddData"
        btnAddData.Size = New Size(201, 38)
        btnAddData.TabIndex = 13
        btnAddData.Text = "Tambah Data"
        btnAddData.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.AutoSize = True
        btnDelete.BackColor = Color.Firebrick
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Poppins Medium", 9.75F)
        btnDelete.ForeColor = SystemColors.ButtonHighlight
        btnDelete.Location = New Point(303, 714)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(201, 38)
        btnDelete.TabIndex = 14
        btnDelete.Text = "Hapus"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnQuit
        ' 
        btnQuit.AutoSize = True
        btnQuit.BackColor = Color.Transparent
        btnQuit.FlatStyle = FlatStyle.Flat
        btnQuit.Font = New Font("Poppins Medium", 9.75F)
        btnQuit.ForeColor = Color.FromArgb(1, 42, 74)
        btnQuit.Location = New Point(562, 714)
        btnQuit.Name = "btnQuit"
        btnQuit.Size = New Size(201, 38)
        btnQuit.TabIndex = 15
        btnQuit.Text = "Keluar"
        btnQuit.UseVisualStyleBackColor = False
        ' 
        ' btnHitungGaji
        ' 
        btnHitungGaji.AutoSize = True
        btnHitungGaji.BackColor = Color.FromArgb(1, 42, 74)
        btnHitungGaji.FlatAppearance.BorderSize = 0
        btnHitungGaji.FlatStyle = FlatStyle.Flat
        btnHitungGaji.Font = New Font("Poppins Medium", 9.75F)
        btnHitungGaji.ForeColor = SystemColors.ButtonHighlight
        btnHitungGaji.Location = New Point(42, 287)
        btnHitungGaji.Name = "btnHitungGaji"
        btnHitungGaji.Size = New Size(721, 38)
        btnHitungGaji.TabIndex = 16
        btnHitungGaji.Text = "Hitung Gaji"
        btnHitungGaji.UseVisualStyleBackColor = False
        ' 
        ' calculateSalary
        ' 
        calculateSalary.Controls.Add(Label16)
        calculateSalary.Controls.Add(inputGajiBersih)
        calculateSalary.Controls.Add(Label15)
        calculateSalary.Controls.Add(inputTax)
        calculateSalary.Controls.Add(Label14)
        calculateSalary.Controls.Add(inputPotongan)
        calculateSalary.Controls.Add(Label13)
        calculateSalary.Controls.Add(inputTunjangan)
        calculateSalary.Controls.Add(Label12)
        calculateSalary.Controls.Add(inputIzin)
        calculateSalary.Controls.Add(Label11)
        calculateSalary.Controls.Add(inputTanpaKet)
        calculateSalary.Controls.Add(Label10)
        calculateSalary.Controls.Add(inputSick)
        calculateSalary.Controls.Add(Label9)
        calculateSalary.Controls.Add(inputHariKerja)
        calculateSalary.Controls.Add(inputMonth)
        calculateSalary.Controls.Add(Label8)
        calculateSalary.Controls.Add(Label7)
        calculateSalary.Controls.Add(inputGajiPokok)
        calculateSalary.Font = New Font("Poppins Medium", 9.75F)
        calculateSalary.ForeColor = Color.FromArgb(1, 42, 74)
        calculateSalary.Location = New Point(62, 349)
        calculateSalary.Name = "calculateSalary"
        calculateSalary.Size = New Size(681, 340)
        calculateSalary.TabIndex = 17
        calculateSalary.TabStop = False
        calculateSalary.Text = "Kalkulasi Gaji"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Transparent
        Label16.Font = New Font("Poppins Medium", 12F)
        Label16.Location = New Point(359, 181)
        Label16.Name = "Label16"
        Label16.RightToLeft = RightToLeft.No
        Label16.Size = New Size(96, 28)
        Label16.TabIndex = 75
        Label16.Text = "Gaji Bersih"
        ' 
        ' inputGajiBersih
        ' 
        inputGajiBersih.BackColor = Color.FromArgb(233, 236, 239)
        inputGajiBersih.BorderStyle = BorderStyle.None
        inputGajiBersih.Enabled = False
        inputGajiBersih.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0)
        inputGajiBersih.Location = New Point(471, 183)
        inputGajiBersih.Name = "inputGajiBersih"
        inputGajiBersih.Size = New Size(184, 24)
        inputGajiBersih.TabIndex = 74
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.Font = New Font("Poppins Medium", 12F)
        Label15.Location = New Point(359, 133)
        Label15.Name = "Label15"
        Label15.RightToLeft = RightToLeft.No
        Label15.Size = New Size(57, 28)
        Label15.TabIndex = 73
        Label15.Text = "Pajak"
        ' 
        ' inputTax
        ' 
        inputTax.BackColor = Color.FromArgb(233, 236, 239)
        inputTax.BorderStyle = BorderStyle.None
        inputTax.Enabled = False
        inputTax.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0)
        inputTax.Location = New Point(471, 135)
        inputTax.Name = "inputTax"
        inputTax.Size = New Size(184, 24)
        inputTax.TabIndex = 72
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Poppins Medium", 12F)
        Label14.Location = New Point(359, 81)
        Label14.Name = "Label14"
        Label14.RightToLeft = RightToLeft.No
        Label14.Size = New Size(90, 28)
        Label14.TabIndex = 71
        Label14.Text = "Potongan"
        ' 
        ' inputPotongan
        ' 
        inputPotongan.BackColor = Color.FromArgb(233, 236, 239)
        inputPotongan.BorderStyle = BorderStyle.None
        inputPotongan.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0)
        inputPotongan.Location = New Point(471, 83)
        inputPotongan.Name = "inputPotongan"
        inputPotongan.Size = New Size(184, 24)
        inputPotongan.TabIndex = 70
        inputPotongan.Text = "0"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Poppins Medium", 12F)
        Label13.Location = New Point(359, 33)
        Label13.Name = "Label13"
        Label13.RightToLeft = RightToLeft.No
        Label13.Size = New Size(98, 28)
        Label13.TabIndex = 69
        Label13.Text = "Tunjangan"
        ' 
        ' inputTunjangan
        ' 
        inputTunjangan.BackColor = Color.FromArgb(233, 236, 239)
        inputTunjangan.BorderStyle = BorderStyle.None
        inputTunjangan.Enabled = False
        inputTunjangan.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0)
        inputTunjangan.Location = New Point(471, 35)
        inputTunjangan.Name = "inputTunjangan"
        inputTunjangan.Size = New Size(184, 24)
        inputTunjangan.TabIndex = 68
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Poppins Medium", 12F)
        Label12.Location = New Point(21, 279)
        Label12.Name = "Label12"
        Label12.Size = New Size(38, 28)
        Label12.TabIndex = 67
        Label12.Text = "Izin"
        ' 
        ' inputIzin
        ' 
        inputIzin.BackColor = Color.FromArgb(233, 236, 239)
        inputIzin.BorderStyle = BorderStyle.None
        inputIzin.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0)
        inputIzin.Location = New Point(133, 281)
        inputIzin.Name = "inputIzin"
        inputIzin.Size = New Size(184, 24)
        inputIzin.TabIndex = 66
        inputIzin.Text = "0"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Poppins Medium", 12F)
        Label11.Location = New Point(21, 230)
        Label11.Name = "Label11"
        Label11.Size = New Size(98, 28)
        Label11.TabIndex = 65
        Label11.Text = "Tanpa Ket."
        ' 
        ' inputTanpaKet
        ' 
        inputTanpaKet.BackColor = Color.FromArgb(233, 236, 239)
        inputTanpaKet.BorderStyle = BorderStyle.None
        inputTanpaKet.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0)
        inputTanpaKet.Location = New Point(133, 232)
        inputTanpaKet.Name = "inputTanpaKet"
        inputTanpaKet.Size = New Size(184, 24)
        inputTanpaKet.TabIndex = 64
        inputTanpaKet.Text = "0"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Poppins Medium", 12F)
        Label10.Location = New Point(21, 182)
        Label10.Name = "Label10"
        Label10.Size = New Size(52, 28)
        Label10.TabIndex = 63
        Label10.Text = "Sakit"
        ' 
        ' inputSick
        ' 
        inputSick.BackColor = Color.FromArgb(233, 236, 239)
        inputSick.BorderStyle = BorderStyle.None
        inputSick.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0)
        inputSick.Location = New Point(133, 184)
        inputSick.Name = "inputSick"
        inputSick.Size = New Size(184, 24)
        inputSick.TabIndex = 62
        inputSick.Text = "0"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Poppins Medium", 12F)
        Label9.Location = New Point(21, 133)
        Label9.Name = "Label9"
        Label9.Size = New Size(89, 28)
        Label9.TabIndex = 61
        Label9.Text = "Hari Kerja"
        ' 
        ' inputHariKerja
        ' 
        inputHariKerja.BackColor = Color.FromArgb(233, 236, 239)
        inputHariKerja.BorderStyle = BorderStyle.None
        inputHariKerja.Enabled = False
        inputHariKerja.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0)
        inputHariKerja.Location = New Point(133, 135)
        inputHariKerja.Name = "inputHariKerja"
        inputHariKerja.Size = New Size(184, 24)
        inputHariKerja.TabIndex = 60
        ' 
        ' inputMonth
        ' 
        inputMonth.BackColor = Color.FromArgb(233, 236, 239)
        inputMonth.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0)
        inputMonth.FormattingEnabled = True
        inputMonth.Location = New Point(133, 80)
        inputMonth.Name = "inputMonth"
        inputMonth.Size = New Size(184, 36)
        inputMonth.TabIndex = 57
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Poppins Medium", 12F)
        Label8.Location = New Point(21, 83)
        Label8.Name = "Label8"
        Label8.Size = New Size(57, 28)
        Label8.TabIndex = 59
        Label8.Text = "Bulan"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Poppins Medium", 12F)
        Label7.Location = New Point(21, 35)
        Label7.Name = "Label7"
        Label7.Size = New Size(95, 28)
        Label7.TabIndex = 58
        Label7.Text = "Gaji Pokok"
        ' 
        ' inputGajiPokok
        ' 
        inputGajiPokok.BackColor = Color.FromArgb(233, 236, 239)
        inputGajiPokok.BorderStyle = BorderStyle.None
        inputGajiPokok.Enabled = False
        inputGajiPokok.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0)
        inputGajiPokok.Location = New Point(133, 37)
        inputGajiPokok.Name = "inputGajiPokok"
        inputGajiPokok.Size = New Size(184, 24)
        inputGajiPokok.TabIndex = 56
        ' 
        ' DataKepegawaian
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(807, 771)
        Controls.Add(calculateSalary)
        Controls.Add(btnHitungGaji)
        Controls.Add(btnQuit)
        Controls.Add(btnDelete)
        Controls.Add(btnAddData)
        Controls.Add(inputBorn)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(inputDate)
        Controls.Add(Label4)
        Controls.Add(inputJabatan)
        Controls.Add(Label3)
        Controls.Add(inputName)
        Controls.Add(Label2)
        Controls.Add(inputNip)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "DataKepegawaian"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Data Kepegawaian"
        calculateSalary.ResumeLayout(False)
        calculateSalary.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents inputNip As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents inputName As TextBox
    Friend WithEvents inputJabatan As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents inputDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents inputBorn As TextBox
    Friend WithEvents btnAddData As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnHitungGaji As Button
    Friend WithEvents calculateSalary As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents inputGajiBersih As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents inputTax As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents inputPotongan As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents inputTunjangan As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents inputIzin As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents inputTanpaKet As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents inputSick As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents inputHariKerja As TextBox
    Friend WithEvents inputMonth As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents inputGajiPokok As TextBox
End Class
