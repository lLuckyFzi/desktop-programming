<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class programBelanja
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
        inputNamaBarang = New TextBox()
        inputHargaSatuan = New TextBox()
        Label2 = New Label()
        inputJumlahSatuan = New TextBox()
        Label3 = New Label()
        btn_hitung = New Button()
        btn_reset = New Button()
        inputTotalHarga = New TextBox()
        Label4 = New Label()
        inputDiskon = New TextBox()
        Label5 = New Label()
        inputTotalBayar = New TextBox()
        Label6 = New Label()
        inputBonus = New TextBox()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Raleway SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(12, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 26)
        Label1.TabIndex = 0
        Label1.Text = "Nama Barang"
        ' 
        ' inputNamaBarang
        ' 
        inputNamaBarang.Location = New Point(180, 31)
        inputNamaBarang.Name = "inputNamaBarang"
        inputNamaBarang.Size = New Size(292, 23)
        inputNamaBarang.TabIndex = 0
        ' 
        ' inputHargaSatuan
        ' 
        inputHargaSatuan.Location = New Point(180, 81)
        inputHargaSatuan.Name = "inputHargaSatuan"
        inputHargaSatuan.Size = New Size(143, 23)
        inputHargaSatuan.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Raleway SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(12, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 26)
        Label2.TabIndex = 2
        Label2.Text = "Harga Satuan"
        ' 
        ' inputJumlahSatuan
        ' 
        inputJumlahSatuan.Location = New Point(180, 136)
        inputJumlahSatuan.Name = "inputJumlahSatuan"
        inputJumlahSatuan.Size = New Size(143, 23)
        inputJumlahSatuan.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Raleway SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(13, 129)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 26)
        Label3.TabIndex = 4
        Label3.Text = "Jumlah Satuan"
        ' 
        ' btn_hitung
        ' 
        btn_hitung.AutoSize = True
        btn_hitung.BackColor = Color.FloralWhite
        btn_hitung.FlatStyle = FlatStyle.Flat
        btn_hitung.Font = New Font("Raleway", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_hitung.Location = New Point(180, 191)
        btn_hitung.Name = "btn_hitung"
        btn_hitung.Size = New Size(110, 34)
        btn_hitung.TabIndex = 5
        btn_hitung.Text = "Hitung"
        btn_hitung.UseVisualStyleBackColor = False
        ' 
        ' btn_reset
        ' 
        btn_reset.AutoSize = True
        btn_reset.BackColor = Color.FloralWhite
        btn_reset.FlatStyle = FlatStyle.Flat
        btn_reset.Font = New Font("Raleway", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_reset.Location = New Point(341, 191)
        btn_reset.Name = "btn_reset"
        btn_reset.Size = New Size(110, 34)
        btn_reset.TabIndex = 6
        btn_reset.Text = "Ulang"
        btn_reset.UseVisualStyleBackColor = False
        ' 
        ' inputTotalHarga
        ' 
        inputTotalHarga.Location = New Point(180, 301)
        inputTotalHarga.Name = "inputTotalHarga"
        inputTotalHarga.Size = New Size(143, 23)
        inputTotalHarga.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Raleway SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(13, 294)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 26)
        Label4.TabIndex = 8
        Label4.Text = "Total Harga"
        ' 
        ' inputDiskon
        ' 
        inputDiskon.Location = New Point(180, 347)
        inputDiskon.Name = "inputDiskon"
        inputDiskon.Size = New Size(143, 23)
        inputDiskon.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Raleway SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonFace
        Label5.Location = New Point(13, 340)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 26)
        Label5.TabIndex = 10
        Label5.Text = "Diskon"
        ' 
        ' inputTotalBayar
        ' 
        inputTotalBayar.Location = New Point(180, 394)
        inputTotalBayar.Name = "inputTotalBayar"
        inputTotalBayar.Size = New Size(143, 23)
        inputTotalBayar.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Raleway SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ButtonFace
        Label6.Location = New Point(13, 387)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 26)
        Label6.TabIndex = 12
        Label6.Text = "Total Bayar"
        ' 
        ' inputBonus
        ' 
        inputBonus.Location = New Point(180, 444)
        inputBonus.Name = "inputBonus"
        inputBonus.Size = New Size(143, 23)
        inputBonus.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Raleway SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ButtonFace
        Label7.Location = New Point(13, 437)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 26)
        Label7.TabIndex = 14
        Label7.Text = "Bonus"
        ' 
        ' programBelanja
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Olive
        ClientSize = New Size(484, 508)
        Controls.Add(inputBonus)
        Controls.Add(Label7)
        Controls.Add(inputTotalBayar)
        Controls.Add(Label6)
        Controls.Add(inputDiskon)
        Controls.Add(Label5)
        Controls.Add(inputTotalHarga)
        Controls.Add(Label4)
        Controls.Add(btn_reset)
        Controls.Add(btn_hitung)
        Controls.Add(inputJumlahSatuan)
        Controls.Add(Label3)
        Controls.Add(inputHargaSatuan)
        Controls.Add(Label2)
        Controls.Add(inputNamaBarang)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "programBelanja"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Program Belanja Sederhana"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents inputNamaBarang As TextBox
    Friend WithEvents inputHargaSatuan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents inputJumlahSatuan As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_hitung As Button
    Friend WithEvents btn_reset As Button
    Friend WithEvents inputTotalHarga As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents inputDiskon As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents inputTotalBayar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents inputBonus As TextBox
    Friend WithEvents Label7 As Label
End Class
