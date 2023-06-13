Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CancelOrderButton.Enabled = False
        CostTextBox.ReadOnly = True
        CostTextBox.Text = "$0.00"
    End Sub

    'Total Cost of Purchase
    Public TotalCost As Decimal

    'CheckBoxInUse


    'Available Products Prices
    Const BreadPrice As Double = 2
    Const MeatPrice As Double = 10
    Const SFoodPrice As Double = 5
    Const PastaPrice As Double = 13
    Const RicePrice As Double = 20
    Const OilPrice As Double = 30
    Const SaucePrice As Double = 15
    Const CerealsPrice As Double = 18
    Const EggsPrice As Double = 1
    Const CheesePrice As Double = 1

    'Disable CheckBoxes
    Friend Function DisableCheckBoxes$()
        BreadCheckBox.Enabled = False
        MeatCheckBox.Enabled = False
        SFoodCheckBox.Enabled = False
        PastaCheckBox.Enabled = False
        RiceCheckBox.Enabled = False
        OilCheckBox.Enabled = False
        SaucesCheckBox.Enabled = False
        CerealsCheckBox.Enabled = False
        EggsCheckBox.Enabled = False
        CheeseCheckBox.Enabled = False
    End Function

    'Enable CheckBoxes
    Friend Function EnableCheckBoxes$()
        BreadCheckBox.Enabled = True
        MeatCheckBox.Enabled = True
        SFoodCheckBox.Enabled = True
        PastaCheckBox.Enabled = True
        RiceCheckBox.Enabled = True
        OilCheckBox.Enabled = True
        SaucesCheckBox.Enabled = True
        CerealsCheckBox.Enabled = True
        EggsCheckBox.Enabled = True
        CheeseCheckBox.Enabled = True
    End Function

    'Reset CheckBoxes
    Friend Function ResetCheckBox$()
        BreadCheckBox.Checked = False
        MeatCheckBox.Checked = False
        SFoodCheckBox.Checked = False
        PastaCheckBox.Checked = False
        RiceCheckBox.Checked = False
        OilCheckBox.Checked = False
        SaucesCheckBox.Checked = False
        CerealsCheckBox.Checked = False
        EggsCheckBox.Checked = False
        CheeseCheckBox.Checked = False
    End Function

    'Reset TextBoxes
    Friend Function ResetTextBoxes$()
        CostTextBox.Text = "$0.00"
        QuantityTextBox.Text = ""
        PhoneNumberTextBox.Text = ""
        CCTextBox.Text = ""
        AddCommentTextBox.Text = ""
    End Function

    'Enable TextBoxes
    Friend Function EnableTextBoxes$()
        QuantityTextBox.ReadOnly = False
        PhoneNumberTextBox.ReadOnly = False
        CCTextBox.ReadOnly = False
        AddCommentTextBox.ReadOnly = False
    End Function

    'Disable TextBoxes
    Friend Function DisableTextBoxes$()
        QuantityTextBox.ReadOnly = True
        PhoneNumberTextBox.ReadOnly = True
        CCTextBox.ReadOnly = True
        AddCommentTextBox.ReadOnly = True
    End Function

    'CheckBox Events
    Friend Function CheckBoxEvent$(Checked As Boolean, CheckPrice As Double)
        Dim Counter As Integer = 0
        If Checked = True And Counter = 0 Then
            Try
                Dim Price As Double
                Price = Decimal.Parse(CostTextBox.Text, Globalization.NumberStyles.Currency) + CheckPrice
                CostTextBox.Text = Price.ToString("C2")
                Counter += 1
            Catch ex As Exception
                MessageBox.Show("Error")
            End Try
        End If
        If Checked = False Then
            Try
                Dim Price As Double
                Price = Decimal.Parse(CostTextBox.Text, Globalization.NumberStyles.Currency) - CheckPrice
                CostTextBox.Text = Price.ToString("C2")
                Counter = 0
            Catch ex As Exception
                MessageBox.Show("Error")
            End Try
        End If
    End Function

    '
    '
    'Events
    'BreadCHeckBox Event
    Private Sub Bread_CheckedChanged(sender As Object, e As EventArgs) Handles BreadCheckBox.CheckedChanged
        CheckBoxEvent(BreadCheckBox.Checked, BreadPrice)
    End Sub

    'CerealsCheckBox Event
    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CerealsCheckBox.CheckedChanged
        CheckBoxEvent(CerealsCheckBox.Checked, CerealsPrice)
    End Sub

    'SaucesCheckBox event
    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles SaucesCheckBox.CheckedChanged
        CheckBoxEvent(SaucesCheckBox.Checked, SaucePrice)
    End Sub

    'OilCheckBox Event
    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles OilCheckBox.CheckedChanged
        CheckBoxEvent(OilCheckBox.Checked, OilPrice)
    End Sub

    'EggsCheckBox Event
    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles EggsCheckBox.CheckedChanged
        CheckBoxEvent(EggsCheckBox.Checked, EggsPrice)
    End Sub

    'CheeseCHeckBox Event
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheeseCheckBox.CheckedChanged
        CheckBoxEvent(CheeseCheckBox.Checked, CheesePrice)
    End Sub

    'RiceCheckBox Event
    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles RiceCheckBox.CheckedChanged
        CheckBoxEvent(RiceCheckBox.Checked, RicePrice)
    End Sub

    'PastaCheckBox Event
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles PastaCheckBox.CheckedChanged
        CheckBoxEvent(PastaCheckBox.Checked, PastaPrice)
    End Sub

    'SeaFoodCheckBox Event
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles SFoodCheckBox.CheckedChanged
        CheckBoxEvent(SFoodCheckBox.Checked, SFoodPrice)
    End Sub

    'MeatCHeckBox Event
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles MeatCheckBox.CheckedChanged
        CheckBoxEvent(MeatCheckBox.Checked, MeatPrice)
    End Sub
    '
    '
    '


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles PriceButton.Click
        MessageBox.Show("BreadPrice: $2" & vbNewLine &
                        "MeatPrice: $10" & vbNewLine & "SFoodPrice: $5" & vbNewLine & " PastaPrice: $13" & vbNewLine &
                        "RicePrice: $20" & vbNewLine & "OilPrice: $30" & vbNewLine &
                        "SaucePrice: $15" & vbNewLine & "CerealsPrice: $18" & vbNewLine & "EggsPrice: $1" _
                        & vbNewLine & "CheesePrice: $1", "Available Products and Prices")
    End Sub

    'Place Order
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PlaceOrderButton.Click
        If QuantityTextBox.Text <> "" And PhoneNumberTextBox.MaskCompleted = True And CCTextBox.MaskCompleted = True Then
            If IsNumeric(QuantityTextBox.Text) Then
                Try


                    Dim Quantity As Double
                    Dim TotalCost As Double = 0
                    Dim Counter As Integer = 0

                    Quantity = Decimal.Parse(CostTextBox.Text, Globalization.NumberStyles.Currency) * Decimal.Parse(QuantityTextBox.Text)
                    CostTextBox.Text = Quantity.ToString("C2")
                    Counter += 1
                    If Counter = 1 Then
                        'enable newOrder button
                        CancelOrderButton.Enabled = True
                        'close Order
                        PlaceOrderButton.Enabled = False
                        'Uncheck the check boxes
                        DisableCheckBoxes()
                        '
                        PlaceOrderButton.BackColor = Color.White
                        DisableCheckBoxes()
                    End If
                    MessageBox.Show("Your Order has been placed", "Ordered")
                Catch ex As Exception

                End Try
            Else
                MessageBox.Show("Input An Integer", "Invalid Input")
            End If

        Else
            MessageBox.Show("Please fill all the required spaces in: 
                           " & vbNewLine & "Quantity" & vbNewLine &
                            "Phone Number" & vbNewLine & "Credit Card Number", "Incomplete Order")
        End If



    End Sub

    'Place Holder Effect in Comment Section
    Dim CountComment As Integer = 0
    Private Sub AddCommentTextBox_TextChanged(sender As Object, e As EventArgs) Handles AddCommentTextBox.Click
        CountComment += 1
        If CountComment = 1 And AddCommentTextBox.Text <> "" Then
            AddCommentTextBox.Text = ""
        End If
        AddCommentTextBox.ForeColor = Color.Black
    End Sub

    Private Sub CancelOrder_Click(sender As Object, e As EventArgs) Handles CancelOrderButton.Click
        Dim Counter As Integer = 0
        If Counter = 0 Then
            Try
                ResetCheckBox()
                ResetTextBoxes()
                MessageBox.Show("Order Canceled", "Cancel Order")
                Counter += 1
                PlaceOrderButton.Enabled = True
                PlaceOrderButton.BackColor = Color.FromArgb(0, 192, 0)
            Catch ex As Exception

            End Try
        End If
        If Counter = 1 Then
            CancelOrderButton.Enabled = False
            QuantityTextBox.Focus()
            EnableTextBoxes()
            EnableCheckBoxes()
        End If

    End Sub

    Private Sub NewOrderButton_Click(sender As Object, e As EventArgs) Handles NewOrderButton.Click

    End Sub

    Private Sub AvailableProductsGroupBox_Enter(sender As Object, e As EventArgs) Handles AvailableProductsGroupBox.Enter

    End Sub

    Private Sub AvailableProductsGroupBox_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles AvailableProductsGroupBox.PreviewKeyDown

    End Sub
End Class
