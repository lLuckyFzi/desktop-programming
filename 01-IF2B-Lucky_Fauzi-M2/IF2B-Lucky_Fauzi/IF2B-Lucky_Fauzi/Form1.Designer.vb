<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Welcome
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
        Label1 = New Label()
        btnPesan = New Button()
        btnQuit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.System
        Label1.Font = New Font("Nunito", 34F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(249, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(338, 93)
        Label1.TabIndex = 0
        Label1.Text = "Welcome"
        ' 
        ' btnPesan
        ' 
        btnPesan.AutoSize = True
        btnPesan.FlatStyle = FlatStyle.Flat
        btnPesan.Font = New Font("Nunito Medium", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPesan.ForeColor = SystemColors.ButtonHighlight
        btnPesan.Location = New Point(179, 216)
        btnPesan.Name = "btnPesan"
        btnPesan.Size = New Size(194, 80)
        btnPesan.TabIndex = 1
        btnPesan.Text = "Message"
        btnPesan.UseVisualStyleBackColor = True
        ' 
        ' btnQuit
        ' 
        btnQuit.AutoSize = True
        btnQuit.FlatStyle = FlatStyle.Flat
        btnQuit.Font = New Font("Nunito Medium", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnQuit.ForeColor = SystemColors.ButtonHighlight
        btnQuit.Location = New Point(423, 216)
        btnQuit.Name = "btnQuit"
        btnQuit.Size = New Size(194, 80)
        btnQuit.TabIndex = 2
        btnQuit.Text = "Quit"
        btnQuit.UseVisualStyleBackColor = True
        ' 
        ' Welcome
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(803, 400)
        Controls.Add(btnQuit)
        Controls.Add(btnPesan)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Welcome"
        RightToLeftLayout = True
        StartPosition = FormStartPosition.CenterScreen
        Text = "Welcome"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnPesan As Button
    Friend WithEvents btnQuit As Button

End Class
