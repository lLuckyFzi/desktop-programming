<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class luas_keliling_jajargenjang
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
        Label2 = New Label()
        alas = New TextBox()
        tinggi = New TextBox()
        Label3 = New Label()
        hitungLuas = New Button()
        hasilLuas = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        sisi_miring = New TextBox()
        Label6 = New Label()
        alas_keliling = New TextBox()
        Label7 = New Label()
        hitungKeliling = New Button()
        hasil_keliling = New TextBox()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Nunito", 13.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(51, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(259, 38)
        Label1.TabIndex = 0
        Label1.Text = "Luas Jajar Genjang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Nunito", 9.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(51, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 28)
        Label2.TabIndex = 1
        Label2.Text = "Alas"
        ' 
        ' alas
        ' 
        alas.Location = New Point(152, 103)
        alas.Name = "alas"
        alas.Size = New Size(150, 31)
        alas.TabIndex = 0
        ' 
        ' tinggi
        ' 
        tinggi.Location = New Point(152, 165)
        tinggi.Name = "tinggi"
        tinggi.Size = New Size(150, 31)
        tinggi.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Nunito", 9.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(51, 166)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 28)
        Label3.TabIndex = 3
        Label3.Text = "Tinggi"
        ' 
        ' hitungLuas
        ' 
        hitungLuas.AutoSize = True
        hitungLuas.BackColor = Color.Beige
        hitungLuas.FlatStyle = FlatStyle.Flat
        hitungLuas.Font = New Font("Nunito Medium", 9.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        hitungLuas.Location = New Point(51, 242)
        hitungLuas.Name = "hitungLuas"
        hitungLuas.Size = New Size(251, 40)
        hitungLuas.TabIndex = 5
        hitungLuas.Text = "Hitung Luas"
        hitungLuas.UseVisualStyleBackColor = False
        ' 
        ' hasilLuas
        ' 
        hasilLuas.Enabled = False
        hasilLuas.Location = New Point(152, 322)
        hasilLuas.Name = "hasilLuas"
        hasilLuas.Size = New Size(150, 31)
        hasilLuas.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Nunito", 9.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(51, 323)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 28)
        Label4.TabIndex = 6
        Label4.Text = "Hasil"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Nunito", 13.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(375, 33)
        Label5.Name = "Label5"
        Label5.Size = New Size(297, 38)
        Label5.TabIndex = 8
        Label5.Text = "Keliling Jajar Genjang"
        ' 
        ' sisi_miring
        ' 
        sisi_miring.Location = New Point(596, 162)
        sisi_miring.Name = "sisi_miring"
        sisi_miring.Size = New Size(150, 31)
        sisi_miring.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Nunito", 9.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(383, 165)
        Label6.Name = "Label6"
        Label6.Size = New Size(185, 28)
        Label6.TabIndex = 11
        Label6.Text = "Panjang Sisi Miring"
        ' 
        ' alas_keliling
        ' 
        alas_keliling.Location = New Point(596, 98)
        alas_keliling.Name = "alas_keliling"
        alas_keliling.Size = New Size(150, 31)
        alas_keliling.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Nunito", 9.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(383, 103)
        Label7.Name = "Label7"
        Label7.Size = New Size(54, 28)
        Label7.TabIndex = 9
        Label7.Text = "Alas"
        ' 
        ' hitungKeliling
        ' 
        hitungKeliling.AutoSize = True
        hitungKeliling.BackColor = Color.Beige
        hitungKeliling.FlatStyle = FlatStyle.Flat
        hitungKeliling.Font = New Font("Nunito Medium", 9.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        hitungKeliling.Location = New Point(375, 242)
        hitungKeliling.Name = "hitungKeliling"
        hitungKeliling.Size = New Size(371, 40)
        hitungKeliling.TabIndex = 13
        hitungKeliling.Text = "Hitung Keliling"
        hitungKeliling.UseVisualStyleBackColor = False
        ' 
        ' hasil_keliling
        ' 
        hasil_keliling.Enabled = False
        hasil_keliling.Location = New Point(596, 320)
        hasil_keliling.Name = "hasil_keliling"
        hasil_keliling.Size = New Size(150, 31)
        hasil_keliling.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Nunito", 9.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(386, 321)
        Label8.Name = "Label8"
        Label8.Size = New Size(59, 28)
        Label8.TabIndex = 14
        Label8.Text = "Hasil"
        ' 
        ' luas_keliling_jajargenjang
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.Gold
        ClientSize = New Size(800, 401)
        Controls.Add(hasil_keliling)
        Controls.Add(Label8)
        Controls.Add(hitungKeliling)
        Controls.Add(sisi_miring)
        Controls.Add(Label6)
        Controls.Add(alas_keliling)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(hasilLuas)
        Controls.Add(Label4)
        Controls.Add(hitungLuas)
        Controls.Add(tinggi)
        Controls.Add(Label3)
        Controls.Add(alas)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "luas_keliling_jajargenjang"
        Text = "Luas dan Keliling Jajar Genjang"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents alas As TextBox
    Friend WithEvents tinggi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents hitungLuas As Button
    Friend WithEvents hasilLuas As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents sisi_miring As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents alas_keliling As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents hitungKeliling As Button
    Friend WithEvents hasil_keliling As TextBox
    Friend WithEvents Label8 As Label
End Class
