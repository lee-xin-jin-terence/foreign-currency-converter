
Imports KamilSzymborski
Imports KamilSzymborski.GoogleCurrencyConverter


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
    ''' external Google Currency Converter API library
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
                                targetForeignCurrency As Decimal) As Task(Of Decimal)

        Dim targetGoogleCurrency As GoogleCurrency =
                    ConvertTargetForeignCurrencyToGoogleCurrency(targetForeignCurrency)

        Dim targetCurrencyExchangeRate As Decimal


        If (sgdValue < 0) Then
            Throw New ArgumentException("sgdValue cannot be negative")
        End If


        'Due to a API bug, cannot convert large singapore dollar value to foreign currency
        ' So, I get the exchange rate first, then manually multiply the sgd
        ' value by exchange rate to get the foreign currency value
        Try
            Const OneSingaporeDollar = 1
            Const TimeoutInMilliseconds = 2000
            targetCurrencyExchangeRate = Await GoogleCurrencyConverter.ConvertAsync(
                                OneSingaporeDollar,
                                GoogleCurrency.SGD, targetGoogleCurrency, TimeoutInMilliseconds)
        Catch ex As Exception

            Throw New CurrencyConversionException("Failed to convert currency")

        End Try


        Return targetCurrencyExchangeRate * sgdValue
    End Function



    ''' <summary>
    ''' Helper method
    ''' 
    ''' Converts the class-defined enum TargetForeignCurrency to the
    ''' external library-defined enum GoogleCurrency
    ''' </summary>
    ''' 
    ''' <param name="targetForeignCurrency">an enum defined by this class
    '''     representing the target foreign currency of interest</param>
    ''' 
    ''' <returns>a external library-defined enum representing the
    '''     foreign currency</returns>
    Private Shared Function ConvertTargetForeignCurrencyToGoogleCurrency(targetForeignCurrency As TargetForeignCurrency)

        Dim googleCurrency As GoogleCurrency

        Select Case targetForeignCurrency
            Case TargetForeignCurrency.AUD
                googleCurrency = GoogleCurrency.AUD

            Case TargetForeignCurrency.CAD
                googleCurrency = GoogleCurrency.CAD

            Case TargetForeignCurrency.EUR
                googleCurrency = GoogleCurrency.EUR

            Case TargetForeignCurrency.HKD
                googleCurrency = GoogleCurrency.HKD

            Case TargetForeignCurrency.JPY
                googleCurrency = GoogleCurrency.JPY

            Case TargetForeignCurrency.USD
                googleCurrency = GoogleCurrency.USD
        End Select


        Return googleCurrency
    End Function



End Class
