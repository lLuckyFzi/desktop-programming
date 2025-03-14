<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hitungLuas_KelilingSegitiga
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
        tinggi = New TextBox()
        Label3 = New Label()
        alas = New TextBox()
        Label2 = New Label()
        hitungLuas = New Button()
        hasilLuas = New TextBox()
        Label4 = New Label()
        hasilKeliling = New TextBox()
        Label5 = New Label()
        hitungKeliling = New Button()
        sisi = New TextBox()
        Label6 = New Label()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Snow
        Label1.Location = New Point(37, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(325, 44)
        Label1.TabIndex = 0
        Label1.Text = "Hitung Luas Segitiga"
        ' 
        ' tinggi
        ' 
        tinggi.Location = New Point(43, 217)
        tinggi.Name = "tinggi"
        tinggi.Size = New Size(331, 31)
        tinggi.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(37, 183)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 31)
        Label3.TabIndex = 3
        Label3.Text = "Tinggi"
        ' 
        ' alas
        ' 
        alas.Location = New Point(44, 133)
        alas.Name = "alas"
        alas.Size = New Size(330, 31)
        alas.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(38, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 31)
        Label2.TabIndex = 5
        Label2.Text = "Alas"
        ' 
        ' hitungLuas
        ' 
        hitungLuas.AutoSize = True
        hitungLuas.BackColor = Color.RoyalBlue
        hitungLuas.FlatStyle = FlatStyle.Flat
        hitungLuas.Font = New Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        hitungLuas.ForeColor = Color.Snow
        hitungLuas.Location = New Point(44, 295)
        hitungLuas.Name = "hitungLuas"
        hitungLuas.Size = New Size(330, 40)
        hitungLuas.TabIndex = 7
        hitungLuas.Text = "Hitung"
        hitungLuas.UseVisualStyleBackColor = False
        ' 
        ' hasilLuas
        ' 
        hasilLuas.Enabled = False
        hasilLuas.Location = New Point(44, 406)
        hasilLuas.Name = "hasilLuas"
        hasilLuas.Size = New Size(331, 31)
        hasilLuas.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(38, 372)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 31)
        Label4.TabIndex = 8
        Label4.Text = "Hasil"
        ' 
        ' hasilKeliling
        ' 
        hasilKeliling.Enabled = False
        hasilKeliling.Location = New Point(553, 304)
        hasilKeliling.Name = "hasilKeliling"
        hasilKeliling.Size = New Size(331, 31)
        hasilKeliling.TabIndex = 17
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(547, 270)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 31)
        Label5.TabIndex = 16
        Label5.Text = "Hasil"
        ' 
        ' hitungKeliling
        ' 
        hitungKeliling.AutoSize = True
        hitungKeliling.BackColor = Color.RoyalBlue
        hitungKeliling.FlatStyle = FlatStyle.Flat
        hitungKeliling.Font = New Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        hitungKeliling.ForeColor = Color.Snow
        hitungKeliling.Location = New Point(552, 205)
        hitungKeliling.Name = "hitungKeliling"
        hitungKeliling.Size = New Size(330, 40)
        hitungKeliling.TabIndex = 15
        hitungKeliling.Text = "Hitung"
        hitungKeliling.UseVisualStyleBackColor = False
        ' 
        ' sisi
        ' 
        sisi.Location = New Point(553, 133)
        sisi.Name = "sisi"
        sisi.Size = New Size(330, 31)
        sisi.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(547, 99)
        Label6.Name = "Label6"
        Label6.Size = New Size(133, 31)
        Label6.TabIndex = 13
        Label6.Text = "Sisi Segitiga"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Montserrat", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Snow
        Label8.Location = New Point(546, 33)
        Label8.Name = "Label8"
        Label8.Size = New Size(366, 44)
        Label8.TabIndex = 10
        Label8.Text = "Hitung Keliling Segitiga"
        ' 
        ' hitungLuas_KelilingSegitiga
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Indigo
        ClientSize = New Size(995, 509)
        Controls.Add(hasilKeliling)
        Controls.Add(Label5)
        Controls.Add(hitungKeliling)
        Controls.Add(sisi)
        Controls.Add(Label6)
        Controls.Add(Label8)
        Controls.Add(hasilLuas)
        Controls.Add(Label4)
        Controls.Add(hitungLuas)
        Controls.Add(alas)
        Controls.Add(Label2)
        Controls.Add(tinggi)
        Controls.Add(Label3)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "hitungLuas_KelilingSegitiga"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Hitung Luas dan Keliling Segitiga"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tinggi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents alas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents hitungLuas As Button
    Friend WithEvents hasilLuas As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents hasilKeliling As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents hitungKeliling As Button
    Friend WithEvents sisi As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
End Class
