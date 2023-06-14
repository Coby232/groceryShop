<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BreadCheckBox = New System.Windows.Forms.CheckBox()
        Me.MeatCheckBox = New System.Windows.Forms.CheckBox()
        Me.SFoodCheckBox = New System.Windows.Forms.CheckBox()
        Me.PastaCheckBox = New System.Windows.Forms.CheckBox()
        Me.RiceCheckBox = New System.Windows.Forms.CheckBox()
        Me.CheeseCheckBox = New System.Windows.Forms.CheckBox()
        Me.EggsCheckBox = New System.Windows.Forms.CheckBox()
        Me.CerealsCheckBox = New System.Windows.Forms.CheckBox()
        Me.SaucesCheckBox = New System.Windows.Forms.CheckBox()
        Me.OilCheckBox = New System.Windows.Forms.CheckBox()
        Me.AvailableProductsGroupBox = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CCTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CostTextBox = New System.Windows.Forms.TextBox()
        Me.AddCommentTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PhoneNumberTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PlaceOrderButton = New System.Windows.Forms.Button()
        Me.CancelOrderButton = New System.Windows.Forms.Button()
        Me.FAQButton = New System.Windows.Forms.Button()
        Me.PriceButton = New System.Windows.Forms.Button()
        Me.NewOrderButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AvailableProductsGroupBox.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(42, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(267, 198)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(210, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "The best grocery shop"
        '
        'BreadCheckBox
        '
        Me.BreadCheckBox.AutoSize = True
        Me.BreadCheckBox.Location = New System.Drawing.Point(23, 47)
        Me.BreadCheckBox.Name = "BreadCheckBox"
        Me.BreadCheckBox.Size = New System.Drawing.Size(76, 24)
        Me.BreadCheckBox.TabIndex = 5
        Me.BreadCheckBox.Text = "Bread"
        Me.BreadCheckBox.UseVisualStyleBackColor = True
        '
        'MeatCheckBox
        '
        Me.MeatCheckBox.AutoSize = True
        Me.MeatCheckBox.Location = New System.Drawing.Point(23, 73)
        Me.MeatCheckBox.Name = "MeatCheckBox"
        Me.MeatCheckBox.Size = New System.Drawing.Size(68, 24)
        Me.MeatCheckBox.TabIndex = 6
        Me.MeatCheckBox.Text = "Meat"
        Me.MeatCheckBox.UseVisualStyleBackColor = True
        '
        'SFoodCheckBox
        '
        Me.SFoodCheckBox.AutoSize = True
        Me.SFoodCheckBox.Location = New System.Drawing.Point(23, 99)
        Me.SFoodCheckBox.Name = "SFoodCheckBox"
        Me.SFoodCheckBox.Size = New System.Drawing.Size(92, 24)
        Me.SFoodCheckBox.TabIndex = 7
        Me.SFoodCheckBox.Text = "Seafood"
        Me.SFoodCheckBox.UseVisualStyleBackColor = True
        '
        'PastaCheckBox
        '
        Me.PastaCheckBox.AutoSize = True
        Me.PastaCheckBox.Location = New System.Drawing.Point(23, 125)
        Me.PastaCheckBox.Name = "PastaCheckBox"
        Me.PastaCheckBox.Size = New System.Drawing.Size(74, 24)
        Me.PastaCheckBox.TabIndex = 8
        Me.PastaCheckBox.Text = "Pasta"
        Me.PastaCheckBox.UseVisualStyleBackColor = True
        '
        'RiceCheckBox
        '
        Me.RiceCheckBox.AutoSize = True
        Me.RiceCheckBox.Location = New System.Drawing.Point(23, 151)
        Me.RiceCheckBox.Name = "RiceCheckBox"
        Me.RiceCheckBox.Size = New System.Drawing.Size(65, 24)
        Me.RiceCheckBox.TabIndex = 9
        Me.RiceCheckBox.Text = "Rice"
        Me.RiceCheckBox.UseVisualStyleBackColor = True
        '
        'CheeseCheckBox
        '
        Me.CheeseCheckBox.AutoSize = True
        Me.CheeseCheckBox.Location = New System.Drawing.Point(147, 151)
        Me.CheeseCheckBox.Name = "CheeseCheckBox"
        Me.CheeseCheckBox.Size = New System.Drawing.Size(88, 24)
        Me.CheeseCheckBox.TabIndex = 14
        Me.CheeseCheckBox.Text = "Cheese"
        Me.CheeseCheckBox.UseVisualStyleBackColor = True
        '
        'EggsCheckBox
        '
        Me.EggsCheckBox.AutoSize = True
        Me.EggsCheckBox.Location = New System.Drawing.Point(147, 125)
        Me.EggsCheckBox.Name = "EggsCheckBox"
        Me.EggsCheckBox.Size = New System.Drawing.Size(69, 24)
        Me.EggsCheckBox.TabIndex = 13
        Me.EggsCheckBox.Text = "Eggs"
        Me.EggsCheckBox.UseVisualStyleBackColor = True
        '
        'CerealsCheckBox
        '
        Me.CerealsCheckBox.AutoSize = True
        Me.CerealsCheckBox.Location = New System.Drawing.Point(147, 99)
        Me.CerealsCheckBox.Name = "CerealsCheckBox"
        Me.CerealsCheckBox.Size = New System.Drawing.Size(89, 24)
        Me.CerealsCheckBox.TabIndex = 12
        Me.CerealsCheckBox.Text = "Cereals"
        Me.CerealsCheckBox.UseVisualStyleBackColor = True
        '
        'SaucesCheckBox
        '
        Me.SaucesCheckBox.AutoSize = True
        Me.SaucesCheckBox.Location = New System.Drawing.Point(147, 73)
        Me.SaucesCheckBox.Name = "SaucesCheckBox"
        Me.SaucesCheckBox.Size = New System.Drawing.Size(87, 24)
        Me.SaucesCheckBox.TabIndex = 11
        Me.SaucesCheckBox.Text = "Sauces"
        Me.SaucesCheckBox.UseVisualStyleBackColor = True
        '
        'OilCheckBox
        '
        Me.OilCheckBox.AutoSize = True
        Me.OilCheckBox.Location = New System.Drawing.Point(147, 47)
        Me.OilCheckBox.Name = "OilCheckBox"
        Me.OilCheckBox.Size = New System.Drawing.Size(52, 24)
        Me.OilCheckBox.TabIndex = 10
        Me.OilCheckBox.Text = "Oil"
        Me.OilCheckBox.UseVisualStyleBackColor = True
        '
        'AvailableProductsGroupBox
        '
        Me.AvailableProductsGroupBox.Controls.Add(Me.MeatCheckBox)
        Me.AvailableProductsGroupBox.Controls.Add(Me.CheeseCheckBox)
        Me.AvailableProductsGroupBox.Controls.Add(Me.BreadCheckBox)
        Me.AvailableProductsGroupBox.Controls.Add(Me.EggsCheckBox)
        Me.AvailableProductsGroupBox.Controls.Add(Me.SFoodCheckBox)
        Me.AvailableProductsGroupBox.Controls.Add(Me.CerealsCheckBox)
        Me.AvailableProductsGroupBox.Controls.Add(Me.PastaCheckBox)
        Me.AvailableProductsGroupBox.Controls.Add(Me.SaucesCheckBox)
        Me.AvailableProductsGroupBox.Controls.Add(Me.RiceCheckBox)
        Me.AvailableProductsGroupBox.Controls.Add(Me.OilCheckBox)
        Me.AvailableProductsGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvailableProductsGroupBox.Location = New System.Drawing.Point(319, 38)
        Me.AvailableProductsGroupBox.Name = "AvailableProductsGroupBox"
        Me.AvailableProductsGroupBox.Size = New System.Drawing.Size(300, 203)
        Me.AvailableProductsGroupBox.TabIndex = 15
        Me.AvailableProductsGroupBox.TabStop = False
        Me.AvailableProductsGroupBox.Text = "Available products:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CCTextBox)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.CostTextBox)
        Me.GroupBox2.Controls.Add(Me.AddCommentTextBox)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.QuantityTextBox)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.PhoneNumberTextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(35, 270)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(401, 283)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Make a purchase:"
        '
        'CCTextBox
        '
        Me.CCTextBox.Location = New System.Drawing.Point(207, 160)
        Me.CCTextBox.Mask = "0000-0000-0000"
        Me.CCTextBox.Name = "CCTextBox"
        Me.CCTextBox.RejectInputOnFirstFailure = True
        Me.CCTextBox.Size = New System.Drawing.Size(160, 26)
        Me.CCTextBox.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Cost:"
        '
        'CostTextBox
        '
        Me.CostTextBox.Location = New System.Drawing.Point(207, 58)
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.Size = New System.Drawing.Size(160, 26)
        Me.CostTextBox.TabIndex = 9
        '
        'AddCommentTextBox
        '
        Me.AddCommentTextBox.ForeColor = System.Drawing.Color.Silver
        Me.AddCommentTextBox.Location = New System.Drawing.Point(180, 195)
        Me.AddCommentTextBox.MaxLength = 50
        Me.AddCommentTextBox.Multiline = True
        Me.AddCommentTextBox.Name = "AddCommentTextBox"
        Me.AddCommentTextBox.Size = New System.Drawing.Size(187, 77)
        Me.AddCommentTextBox.TabIndex = 10
        Me.AddCommentTextBox.Text = "Text here"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Add comment:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Credit Card Number: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Phone Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Quantity:"
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(207, 90)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(160, 26)
        Me.QuantityTextBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(20, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(332, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select any of the available products to begin purchase "
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(207, 128)
        Me.PhoneNumberTextBox.Mask = "000-000-0000"
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.RejectInputOnFirstFailure = True
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(160, 26)
        Me.PhoneNumberTextBox.TabIndex = 0
        '
        'PlaceOrderButton
        '
        Me.PlaceOrderButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PlaceOrderButton.ForeColor = System.Drawing.Color.White
        Me.PlaceOrderButton.Location = New System.Drawing.Point(442, 294)
        Me.PlaceOrderButton.Name = "PlaceOrderButton"
        Me.PlaceOrderButton.Size = New System.Drawing.Size(185, 53)
        Me.PlaceOrderButton.TabIndex = 17
        Me.PlaceOrderButton.Text = "Place Order"
        Me.PlaceOrderButton.UseVisualStyleBackColor = False
        '
        'CancelOrderButton
        '
        Me.CancelOrderButton.Location = New System.Drawing.Point(442, 365)
        Me.CancelOrderButton.Name = "CancelOrderButton"
        Me.CancelOrderButton.Size = New System.Drawing.Size(90, 53)
        Me.CancelOrderButton.TabIndex = 18
        Me.CancelOrderButton.Text = "Cancel Order"
        Me.CancelOrderButton.UseVisualStyleBackColor = True
        '
        'FAQButton
        '
        Me.FAQButton.Location = New System.Drawing.Point(442, 489)
        Me.FAQButton.Name = "FAQButton"
        Me.FAQButton.Size = New System.Drawing.Size(185, 53)
        Me.FAQButton.TabIndex = 19
        Me.FAQButton.Text = "FAQ"
        Me.FAQButton.UseVisualStyleBackColor = True
        '
        'PriceButton
        '
        Me.PriceButton.Location = New System.Drawing.Point(442, 430)
        Me.PriceButton.Name = "PriceButton"
        Me.PriceButton.Size = New System.Drawing.Size(185, 53)
        Me.PriceButton.TabIndex = 20
        Me.PriceButton.Text = "Prices"
        Me.PriceButton.UseVisualStyleBackColor = True
        '
        'NewOrderButton
        '
        Me.NewOrderButton.Location = New System.Drawing.Point(537, 365)
        Me.NewOrderButton.Name = "NewOrderButton"
        Me.NewOrderButton.Size = New System.Drawing.Size(90, 53)
        Me.NewOrderButton.TabIndex = 21
        Me.NewOrderButton.Text = "New Order"
        Me.NewOrderButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 584)
        Me.Controls.Add(Me.NewOrderButton)
        Me.Controls.Add(Me.PriceButton)
        Me.Controls.Add(Me.FAQButton)
        Me.Controls.Add(Me.CancelOrderButton)
        Me.Controls.Add(Me.PlaceOrderButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.AvailableProductsGroupBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(680, 631)
        Me.MinimumSize = New System.Drawing.Size(680, 631)
        Me.Name = "Form1"
        Me.Text = "Selorm's Grocery Shop"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AvailableProductsGroupBox.ResumeLayout(False)
        Me.AvailableProductsGroupBox.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BreadCheckBox As CheckBox
    Friend WithEvents MeatCheckBox As CheckBox
    Friend WithEvents SFoodCheckBox As CheckBox
    Friend WithEvents PastaCheckBox As CheckBox
    Friend WithEvents RiceCheckBox As CheckBox
    Friend WithEvents CheeseCheckBox As CheckBox
    Friend WithEvents EggsCheckBox As CheckBox
    Friend WithEvents CerealsCheckBox As CheckBox
    Friend WithEvents SaucesCheckBox As CheckBox
    Friend WithEvents OilCheckBox As CheckBox
    Friend WithEvents AvailableProductsGroupBox As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PlaceOrderButton As Button
    Friend WithEvents CancelOrderButton As Button
    Friend WithEvents FAQButton As Button
    Friend WithEvents AddCommentTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PhoneNumberTextBox As MaskedTextBox
    Friend WithEvents PriceButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents CostTextBox As TextBox
    Friend WithEvents CCTextBox As MaskedTextBox
    Friend WithEvents NewOrderButton As Button
End Class
