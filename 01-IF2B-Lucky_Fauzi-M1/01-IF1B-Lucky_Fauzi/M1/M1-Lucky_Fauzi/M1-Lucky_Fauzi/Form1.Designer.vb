<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblJudul = New Label()
        btnPesan = New Button()
        btnQuit = New Button()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Sans Serif Collection", 19.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblJudul.ForeColor = Color.Snow
        lblJudul.Location = New Point(212, 73)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(349, 99)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Welcome!"
        ' 
        ' btnPesan
        ' 
        btnPesan.FlatStyle = FlatStyle.Flat
        btnPesan.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPesan.ForeColor = SystemColors.ButtonHighlight
        btnPesan.Location = New Point(129, 227)
        btnPesan.Name = "btnPesan"
        btnPesan.Size = New Size(195, 67)
        btnPesan.TabIndex = 1
        btnPesan.Text = "Message"
        btnPesan.UseVisualStyleBackColor = True
        ' 
        ' btnQuit
        ' 
        btnQuit.FlatStyle = FlatStyle.Flat
        btnQuit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnQuit.ForeColor = SystemColors.ButtonHighlight
        btnQuit.Location = New Point(449, 227)
        btnQuit.Name = "btnQuit"
        btnQuit.Size = New Size(195, 67)
        btnQuit.TabIndex = 2
        btnQuit.Text = "Quit"
        btnQuit.UseVisualStyleBackColor = True
        ' 
        ' frmUtama
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(800, 450)
        Controls.Add(btnQuit)
        Controls.Add(btnPesan)
        Controls.Add(lblJudul)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "frmUtama"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents btnPesan As Button
    Friend WithEvents btnQuit As Button

End Class
