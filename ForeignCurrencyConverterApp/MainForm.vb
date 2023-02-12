
''' <author>Terence Lee</author>
''' <summary>
'''     The main form of the app, allowing user to convert 
'''     Singapore Dollar (SGD) value to foreign currency values
''' </summary>
Public Class MainForm

    Private targetForeignCurrency As ForeignCurrencyConverter.TargetForeignCurrency =
                    ForeignCurrencyConverter.TargetForeignCurrency.AUD


    Public Sub New()
        InitializeComponent()

        InitializeTargetCurrencyComboBox()

    End Sub

    ''' <summary>
    ''' Initialize the targetCurrencyComboBox with various supported
    ''' currencies
    ''' </summary>
    Public Sub InitializeTargetCurrencyComboBox()

        Me.targetCurrencyComboBox.Items.Add("AUD")
        Me.targetCurrencyComboBox.Items.Add("CAD")
        Me.targetCurrencyComboBox.Items.Add("EUR")
        Me.targetCurrencyComboBox.Items.Add("HKD")
        Me.targetCurrencyComboBox.Items.Add("JPY")
        Me.targetCurrencyComboBox.Items.Add("USD")

        Me.targetCurrencyComboBox.SelectedIndex = 0
    End Sub



    ''' <summary>
    ''' When the convert button is clicked, convert the user entered
    ''' singapore dollar value to selected foreign currency value
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub convertButton_Click(sender As Object, e As EventArgs) Handles convertButton.Click
        ConvertCurrency()
    End Sub



    ''' <summary>
    ''' Convert the user entered singapore dollar value to selected 
    ''' foreign currency value
    ''' </summary>
    Private Async Sub ConvertCurrency()


        Try
            Dim singaporeInputCurrency As Decimal = Convert.ToDecimal(Me.singaporeCurrencyTextBox.Text)

            Dim convertedValue As Decimal = Await ForeignCurrencyConverter.ConvertToCurrency(
                                singaporeInputCurrency,
                               Me.targetForeignCurrency)

            Me.convertedForeignCurrencyValueTextBox.Text = convertedValue.ToString("0.00")

        Catch ex As ArgumentException

            DisplayErrorMessage("Error: Negative SGD value entered.")

        Catch ex As FormatException

            DisplayErrorMessage("Error: Invalid non-number SGD value entered.")


        Catch ex As OverflowException

            DisplayErrorMessage("Error: SGD value entered is too large")

        Catch ex As CurrencyConversionException

            DisplayErrorMessage("Error: An error occurred while communicating with the server. " +
                                "Please try again later")
        End Try

    End Sub



    ''' <summary>
    ''' Upon the user changing the singapore dollar value in the textbox,
    ''' clear the converted foreign currency value
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub singaporeCurrencyTextBox_TextChanged(sender As Object, e As EventArgs) Handles singaporeCurrencyTextBox.TextChanged
        ClearConvertedForeignCurrencyValueTextBox()
    End Sub


    Private Sub targetCurrencyComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles targetCurrencyComboBox.SelectedIndexChanged

        Me.ClearConvertedForeignCurrencyValueTextBox()

        Me.UpdateTargetForeignCurrency()

        Me.UpdateTargetForeignCurrencyLabel()

    End Sub



    ''' <summary>
    ''' Helper method that clears the value in the
    ''' converted foreign currency value text box
    ''' </summary>
    Private Sub ClearConvertedForeignCurrencyValueTextBox()
        Me.convertedForeignCurrencyValueTextBox.Text = ""
    End Sub


    ''' <summary>
    ''' Update the label in the form that states what the target foreign currency is,
    ''' based on the user selection
    ''' 
    ''' If the user selected "AUD", then the label will have the following text:
    '''     "Converted Amount in AUD" 
    ''' </summary>
    Private Sub UpdateTargetForeignCurrencyLabel()

        Dim foreignCurrencySymbol As String = "AUD"

        Select Case Me.targetCurrencyComboBox.SelectedIndex

            Case 0
                foreignCurrencySymbol = "AUD"

            Case 1
                foreignCurrencySymbol = "CAD"

            Case 2
                foreignCurrencySymbol = "EUR"

            Case 3
                foreignCurrencySymbol = "HKD"

            Case 4
                foreignCurrencySymbol = "JPY"

            Case 5
                foreignCurrencySymbol = "USD"

        End Select

        Me.targetForeignCurrencyLabel.Text = "Converted Amount in " +
                                                foreignCurrencySymbol
    End Sub


    ''' <summary>
    ''' Update the instance variable targetForeignCurrency depending on what 
    ''' foreign currency the user selected
    ''' </summary>
    Private Sub UpdateTargetForeignCurrency()

        Select Case Me.targetCurrencyComboBox.SelectedIndex
            Case 0
                targetForeignCurrency =
                    ForeignCurrencyConverter.TargetForeignCurrency.AUD

            Case 1
                targetForeignCurrency =
                    ForeignCurrencyConverter.TargetForeignCurrency.CAD

            Case 2
                targetForeignCurrency =
                    ForeignCurrencyConverter.TargetForeignCurrency.EUR

            Case 3
                targetForeignCurrency =
                    ForeignCurrencyConverter.TargetForeignCurrency.HKD

            Case 4
                targetForeignCurrency =
                    ForeignCurrencyConverter.TargetForeignCurrency.JPY

            Case 5
                targetForeignCurrency =
                    ForeignCurrencyConverter.TargetForeignCurrency.USD

        End Select

    End Sub

    Private Sub DisplayErrorMessage(errorMessage As String)
        MessageBox.Show(errorMessage)
    End Sub

End Class
