<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label3 = New Label()
        btnKali = New Button()
        Label4 = New Label()
        btnBagi = New Button()
        btnTambah = New Button()
        btnKurang = New Button()
        txtAngka1 = New TextBox()
        txtAngka2 = New TextBox()
        txtHasil = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(48, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(196, 32)
        Label1.TabIndex = 0
        Label1.Text = "First Number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(48, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(227, 32)
        Label2.TabIndex = 1
        Label2.Text = "Second Number"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(48, 360)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 32)
        Label3.TabIndex = 2
        Label3.Text = "Result"
        ' 
        ' btnKali
        ' 
        btnKali.AutoSize = True
        btnKali.FlatStyle = FlatStyle.Flat
        btnKali.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKali.ForeColor = SystemColors.ButtonHighlight
        btnKali.Location = New Point(60, 241)
        btnKali.Name = "btnKali"
        btnKali.Size = New Size(99, 64)
        btnKali.TabIndex = 3
        btnKali.Text = "x"
        btnKali.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(52, 201)
        Label4.Name = "Label4"
        Label4.Size = New Size(119, 27)
        Label4.TabIndex = 4
        Label4.Text = "Operator"
        ' 
        ' btnBagi
        ' 
        btnBagi.AutoSize = True
        btnBagi.FlatStyle = FlatStyle.Flat
        btnBagi.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBagi.ForeColor = SystemColors.ButtonHighlight
        btnBagi.Location = New Point(227, 241)
        btnBagi.Name = "btnBagi"
        btnBagi.Size = New Size(99, 64)
        btnBagi.TabIndex = 5
        btnBagi.Text = "/"
        btnBagi.UseVisualStyleBackColor = True
        ' 
        ' btnTambah
        ' 
        btnTambah.AutoSize = True
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTambah.ForeColor = SystemColors.ButtonHighlight
        btnTambah.Location = New Point(410, 241)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(99, 64)
        btnTambah.TabIndex = 6
        btnTambah.Text = "+"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnKurang
        ' 
        btnKurang.AutoSize = True
        btnKurang.FlatStyle = FlatStyle.Flat
        btnKurang.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKurang.ForeColor = SystemColors.ButtonHighlight
        btnKurang.Location = New Point(603, 241)
        btnKurang.Name = "btnKurang"
        btnKurang.Size = New Size(99, 64)
        btnKurang.TabIndex = 7
        btnKurang.Text = "-"
        btnKurang.UseVisualStyleBackColor = True
        ' 
        ' txtAngka1
        ' 
        txtAngka1.Location = New Point(341, 50)
        txtAngka1.Name = "txtAngka1"
        txtAngka1.Size = New Size(361, 31)
        txtAngka1.TabIndex = 0
        ' 
        ' txtAngka2
        ' 
        txtAngka2.Location = New Point(341, 128)
        txtAngka2.Name = "txtAngka2"
        txtAngka2.Size = New Size(361, 31)
        txtAngka2.TabIndex = 9
        ' 
        ' txtHasil
        ' 
        txtHasil.Enabled = False
        txtHasil.Location = New Point(341, 360)
        txtHasil.Name = "txtHasil"
        txtHasil.ReadOnly = True
        txtHasil.Size = New Size(361, 31)
        txtHasil.TabIndex = 10
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.HotTrack
        ClientSize = New Size(800, 450)
        Controls.Add(txtHasil)
        Controls.Add(txtAngka2)
        Controls.Add(txtAngka1)
        Controls.Add(btnKurang)
        Controls.Add(btnTambah)
        Controls.Add(btnBagi)
        Controls.Add(Label4)
        Controls.Add(btnKali)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kalkulator Sederhana"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnKali As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBagi As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnKurang As Button
    Friend WithEvents txtAngka1 As TextBox
    Friend WithEvents txtAngka2 As TextBox
    Friend WithEvents txtHasil As TextBox
End Class
