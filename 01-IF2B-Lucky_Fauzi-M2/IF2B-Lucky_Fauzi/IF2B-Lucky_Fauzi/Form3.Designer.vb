<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hitungNilai
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
        tatapMuka = New TextBox()
        midTest = New TextBox()
        Label3 = New Label()
        finalTest = New TextBox()
        Label4 = New Label()
        btnHitung = New Button()
        nilaiAkhir = New TextBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(100, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(327, 44)
        Label1.TabIndex = 0
        Label1.Text = "Program Hitung Nilai"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(44, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 31)
        Label2.TabIndex = 1
        Label2.Text = "Tatap Muka"
        ' 
        ' tatapMuka
        ' 
        tatapMuka.Location = New Point(211, 129)
        tatapMuka.Name = "tatapMuka"
        tatapMuka.Size = New Size(279, 31)
        tatapMuka.TabIndex = 2
        ' 
        ' midTest
        ' 
        midTest.Location = New Point(211, 193)
        midTest.Name = "midTest"
        midTest.Size = New Size(279, 31)
        midTest.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(44, 194)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 31)
        Label3.TabIndex = 3
        Label3.Text = "Mid Test"
        ' 
        ' finalTest
        ' 
        finalTest.Location = New Point(211, 255)
        finalTest.Name = "finalTest"
        finalTest.Size = New Size(279, 31)
        finalTest.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(44, 256)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 31)
        Label4.TabIndex = 5
        Label4.Text = "Final Test"
        ' 
        ' btnHitung
        ' 
        btnHitung.AutoSize = True
        btnHitung.BackColor = Color.MidnightBlue
        btnHitung.FlatStyle = FlatStyle.Flat
        btnHitung.Font = New Font("Montserrat SemiBold", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHitung.ForeColor = SystemColors.ButtonHighlight
        btnHitung.Location = New Point(44, 343)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(446, 50)
        btnHitung.TabIndex = 7
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = False
        ' 
        ' nilaiAkhir
        ' 
        nilaiAkhir.Enabled = False
        nilaiAkhir.Location = New Point(211, 450)
        nilaiAkhir.Name = "nilaiAkhir"
        nilaiAkhir.Size = New Size(279, 31)
        nilaiAkhir.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(44, 451)
        Label5.Name = "Label5"
        Label5.Size = New Size(115, 31)
        Label5.TabIndex = 8
        Label5.Text = "Nilai Akhir"
        ' 
        ' hitungNilai
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.MenuHighlight
        ClientSize = New Size(534, 574)
        Controls.Add(nilaiAkhir)
        Controls.Add(Label5)
        Controls.Add(btnHitung)
        Controls.Add(finalTest)
        Controls.Add(Label4)
        Controls.Add(midTest)
        Controls.Add(Label3)
        Controls.Add(tatapMuka)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "hitungNilai"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Program Hitung Nilai"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tatapMuka As TextBox
    Friend WithEvents midTest As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents finalTest As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents nilaiAkhir As TextBox
    Friend WithEvents Label5 As Label
End Class
