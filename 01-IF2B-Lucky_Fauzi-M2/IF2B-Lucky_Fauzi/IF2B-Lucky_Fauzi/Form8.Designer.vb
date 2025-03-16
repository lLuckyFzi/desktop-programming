<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderMakanan
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
        inputFoods = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        labelFoodPrice = New Label()
        isWithDrink = New CheckBox()
        labelDrinkPrice = New Label()
        Label4 = New Label()
        Label5 = New Label()
        inputDrinks = New ComboBox()
        GroupBox1 = New GroupBox()
        labelTotal = New Label()
        btnHitung = New Button()
        Label8 = New Label()
        Label7 = New Label()
        inputTotalDrink = New TextBox()
        Label6 = New Label()
        inputTotalFood = New TextBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' inputFoods
        ' 
        inputFoods.Font = New Font("Raleway", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        inputFoods.FormattingEnabled = True
        inputFoods.Items.AddRange(New Object() {"Nasi Padang", "Nasi Uduk", "Nasi Goreng"})
        inputFoods.Location = New Point(30, 27)
        inputFoods.Name = "inputFoods"
        inputFoods.Size = New Size(188, 30)
        inputFoods.TabIndex = 0
        inputFoods.Text = "Pilih Makanan"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Inclusive Sans Medium", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(261, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 24)
        Label1.TabIndex = 1
        Label1.Text = "Harga:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Inclusive Sans Medium", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(383, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 24)
        Label2.TabIndex = 2
        Label2.Text = "Rp."
        ' 
        ' labelFoodPrice
        ' 
        labelFoodPrice.AutoSize = True
        labelFoodPrice.Font = New Font("Inclusive Sans Medium", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelFoodPrice.ForeColor = SystemColors.ButtonHighlight
        labelFoodPrice.Location = New Point(418, 30)
        labelFoodPrice.Name = "labelFoodPrice"
        labelFoodPrice.Size = New Size(19, 24)
        labelFoodPrice.TabIndex = 3
        labelFoodPrice.Text = "-"
        ' 
        ' isWithDrink
        ' 
        isWithDrink.AutoSize = True
        isWithDrink.Font = New Font("Inclusive Sans", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        isWithDrink.ForeColor = SystemColors.ButtonHighlight
        isWithDrink.Location = New Point(30, 90)
        isWithDrink.Name = "isWithDrink"
        isWithDrink.Size = New Size(178, 28)
        isWithDrink.TabIndex = 4
        isWithDrink.Text = "Termasuk Minuman"
        isWithDrink.UseVisualStyleBackColor = True
        ' 
        ' labelDrinkPrice
        ' 
        labelDrinkPrice.AutoSize = True
        labelDrinkPrice.Font = New Font("Inclusive Sans Medium", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelDrinkPrice.ForeColor = SystemColors.ButtonHighlight
        labelDrinkPrice.Location = New Point(418, 127)
        labelDrinkPrice.Name = "labelDrinkPrice"
        labelDrinkPrice.Size = New Size(19, 24)
        labelDrinkPrice.TabIndex = 8
        labelDrinkPrice.Text = "-"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Inclusive Sans Medium", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(383, 127)
        Label4.Name = "Label4"
        Label4.Size = New Size(38, 24)
        Label4.TabIndex = 7
        Label4.Text = "Rp."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Inclusive Sans Medium", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(261, 127)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 24)
        Label5.TabIndex = 6
        Label5.Text = "Harga:"
        ' 
        ' inputDrinks
        ' 
        inputDrinks.Font = New Font("Raleway", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        inputDrinks.FormattingEnabled = True
        inputDrinks.Items.AddRange(New Object() {"Jus Mangga", "Jus Alpukat", "Jus Jeruk"})
        inputDrinks.Location = New Point(30, 124)
        inputDrinks.Name = "inputDrinks"
        inputDrinks.Size = New Size(188, 30)
        inputDrinks.TabIndex = 5
        inputDrinks.Text = "Pilih Minuman"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(labelTotal)
        GroupBox1.Controls.Add(btnHitung)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(inputTotalDrink)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(inputTotalFood)
        GroupBox1.Font = New Font("Inclusive Sans Medium", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = SystemColors.ButtonHighlight
        GroupBox1.Location = New Point(95, 199)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(465, 217)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Menu Pesanan"
        ' 
        ' labelTotal
        ' 
        labelTotal.AutoSize = True
        labelTotal.Font = New Font("Inclusive Sans Medium", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelTotal.ForeColor = SystemColors.ButtonHighlight
        labelTotal.Location = New Point(305, 155)
        labelTotal.Name = "labelTotal"
        labelTotal.Size = New Size(19, 24)
        labelTotal.TabIndex = 11
        labelTotal.Text = "-"
        ' 
        ' btnHitung
        ' 
        btnHitung.AutoSize = True
        btnHitung.BackColor = SystemColors.HotTrack
        btnHitung.FlatAppearance.BorderSize = 0
        btnHitung.FlatStyle = FlatStyle.Flat
        btnHitung.Font = New Font("Inclusive Sans Medium", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHitung.ForeColor = SystemColors.Control
        btnHitung.Location = New Point(25, 149)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(178, 36)
        btnHitung.TabIndex = 10
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Inclusive Sans Medium", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ButtonHighlight
        Label8.Location = New Point(270, 155)
        Label8.Name = "Label8"
        Label8.Size = New Size(38, 24)
        Label8.TabIndex = 10
        Label8.Text = "Rp."
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Inclusive Sans", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(20, 90)
        Label7.Name = "Label7"
        Label7.Size = New Size(183, 24)
        Label7.TabIndex = 9
        Label7.Text = "Jumlah Porsi Minuman"
        ' 
        ' inputTotalDrink
        ' 
        inputTotalDrink.Font = New Font("Inclusive Sans", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        inputTotalDrink.Location = New Point(270, 90)
        inputTotalDrink.Name = "inputTotalDrink"
        inputTotalDrink.Size = New Size(160, 27)
        inputTotalDrink.TabIndex = 8
        inputTotalDrink.Text = "1"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Inclusive Sans", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ButtonHighlight
        Label6.Location = New Point(20, 42)
        Label6.Name = "Label6"
        Label6.Size = New Size(182, 24)
        Label6.TabIndex = 7
        Label6.Text = "Jumlah Porsi Makanan"
        ' 
        ' inputTotalFood
        ' 
        inputTotalFood.Font = New Font("Inclusive Sans", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        inputTotalFood.Location = New Point(270, 42)
        inputTotalFood.Name = "inputTotalFood"
        inputTotalFood.Size = New Size(160, 27)
        inputTotalFood.TabIndex = 0
        inputTotalFood.Text = "1"
        ' 
        ' OrderMakanan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnablePreventFocusChange
        BackColor = Color.Firebrick
        ClientSize = New Size(654, 455)
        Controls.Add(GroupBox1)
        Controls.Add(labelDrinkPrice)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(inputDrinks)
        Controls.Add(isWithDrink)
        Controls.Add(labelFoodPrice)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(inputFoods)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "OrderMakanan"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Order Makanan"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents inputFoods As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents labelFoodPrice As Label
    Friend WithEvents isWithDrink As CheckBox
    Friend WithEvents labelDrinkPrice As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents inputDrinks As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents inputTotalDrink As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents inputTotalFood As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents labelTotal As Label
    Friend WithEvents Label8 As Label
End Class
