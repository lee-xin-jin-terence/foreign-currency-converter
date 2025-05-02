
Imports APIVerve
Imports ForeignCurrencyConverterApp.ForeignCurrencyConverter.Keys

Namespace ForeignCurrencyConverter.Models


    ''' <author>Terence Lee</author>
    ''' 
    ''' <summary>
    ''' A class that wraps a currency converter external library, and exposes only
    ''' the methods that is used by this application
    ''' 
    ''' Example usage:
    ''' 
    ''' Dim singaporeDollarValue As Decimal = 100.0
    ''' 
    ''' Dim japanYenValue As Decimal = 
    '''     ForeignCurrencyConverter.ConvertToCurrency(singaporeDollarValue,
    '''                        ForeignCurrencyConverter.TargetForeignCurrency.JPY)
    ''' </summary>
    Public Class ForeignCurrencyConverter

        ''' <summary>
        ''' Enum of the various supported foreign currencies
        ''' </summary>
        Public Enum TargetForeignCurrency
            AUD
            CAD
            EUR
            HKD
            JPY
            USD
        End Enum



        ''' <summary>
        ''' Constructor will not be used, so made private
        ''' </summary>
        Private Sub New()

        End Sub



        ''' <summary>
        ''' Converts the singapore value to a foreign currency value using the 
        ''' external Currency Converter API library
        ''' 
        ''' </summary>
        ''' <param name="sgdValue">value in singapore dollars to be converted to
        '''         foreign currency</param>
        '''         
        ''' <param name="targetForeignCurrency">target foreign currency of interest,
        '''     to be converted from Singapore dollars</param>
        ''' 
        ''' <exception name="ArgumentException">If the sgdValue argument is less than zero
        ''' </exception>
        '''     
        ''' <exception name="CurrencyConversionException">if there is an error
        '''     converting the sgd currency to foreign currency value</exception>
        ''' 
        ''' <returns>amount of money in target foreign currency converted from
        '''     singapore dollars</returns>
        Public Shared Async Function ConvertToCurrency(sgdValue As Decimal,
                                targetForeignCurrency As TargetForeignCurrency) As Task(Of Decimal)

            Dim targetCurrencyCodeString As String =
                    ConvertTargetForeignCurrencyToCurrencyCodeString(targetForeignCurrency)

            Dim targetCurrencyExchangeRate As Decimal


            If (sgdValue < 0) Then
                Throw New ArgumentException("sgdValue cannot be negative")
            End If



            Try

                Dim options As CurrencyConverterQueryOptions = New CurrencyConverterQueryOptions()
                options.from = "SGD"
                options.to = targetCurrencyCodeString
                options.value = sgdValue

                targetCurrencyExchangeRate = New CurrencyConverterAPIClient(
                    ApiKeys.APIVerveKey, True).Execute(options).data.convertedValue

            Catch ex As Exception

                Throw New CurrencyConversionException("Failed to convert currency")

            End Try


            Return targetCurrencyExchangeRate
        End Function



        ''' <summary>
        ''' Helper method
        ''' 
        ''' Converts the class-defined enum TargetForeignCurrency to the
        ''' string code representing currency
        ''' </summary>
        ''' 
        ''' <param name="targetForeignCurrency">an enum defined by this class
        '''     representing the target foreign currency of interest</param>
        ''' 
        ''' <returns>a universally used 3-letter standard string representing the
        '''     foreign currency. E.g. "AUD" for australian dollar </returns>
        Private Shared Function ConvertTargetForeignCurrencyToCurrencyCodeString(targetForeignCurrency As TargetForeignCurrency)

            Dim targetCurrencyString As String

            Select Case targetForeignCurrency
                Case TargetForeignCurrency.AUD
                    targetCurrencyString = "AUD"

                Case TargetForeignCurrency.CAD
                    targetCurrencyString = "CAD"

                Case TargetForeignCurrency.EUR
                    targetCurrencyString = "EUR"

                Case TargetForeignCurrency.HKD
                    targetCurrencyString = "HKD"

                Case TargetForeignCurrency.JPY
                    targetCurrencyString = "JPY"

                Case TargetForeignCurrency.USD
                    targetCurrencyString = "USD"
            End Select


            Return targetCurrencyString
        End Function



    End Class

End Namespace
