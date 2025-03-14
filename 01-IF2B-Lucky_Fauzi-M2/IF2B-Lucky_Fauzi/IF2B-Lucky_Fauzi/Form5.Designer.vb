<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class volumeTabung
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
        jari2 = New TextBox()
        tinggi = New TextBox()
        Label3 = New Label()
        Button1 = New Button()
        hasil = New TextBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(121, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(248, 44)
        Label1.TabIndex = 0
        Label1.Text = "Volume Tabung"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Montserrat Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(36, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 31)
        Label2.TabIndex = 1
        Label2.Text = "Jari-Jari"
        ' 
        ' jari2
        ' 
        jari2.Location = New Point(172, 103)
        jari2.Name = "jari2"
        jari2.Size = New Size(267, 31)
        jari2.TabIndex = 0
        ' 
        ' tinggi
        ' 
        tinggi.Location = New Point(172, 160)
        tinggi.Name = "tinggi"
        tinggi.Size = New Size(267, 31)
        tinggi.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Montserrat Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(36, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 31)
        Label3.TabIndex = 3
        Label3.Text = "Tinggi"
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.BackColor = Color.ForestGreen
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Montserrat Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(36, 237)
        Button1.Name = "Button1"
        Button1.Size = New Size(403, 43)
        Button1.TabIndex = 5
        Button1.Text = "Hitung Volume"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' hasil
        ' 
        hasil.Enabled = False
        hasil.Location = New Point(172, 325)
        hasil.Name = "hasil"
        hasil.Size = New Size(267, 31)
        hasil.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Montserrat Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(36, 325)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 31)
        Label4.TabIndex = 6
        Label4.Text = "Hasil"
        ' 
        ' volumeTabung
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LimeGreen
        ClientSize = New Size(502, 417)
        Controls.Add(hasil)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(tinggi)
        Controls.Add(Label3)
        Controls.Add(jari2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "volumeTabung"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menghitung Volume Tabung"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents jari2 As TextBox
    Friend WithEvents tinggi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents hasil As TextBox
    Friend WithEvents Label4 As Label
End Class
