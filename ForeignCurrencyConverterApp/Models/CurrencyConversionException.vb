Namespace ForeignCurrencyConverter



    ''' <author>Terence Lee</author>
    ''' 
    ''' <summary>
    ''' Represent exception that occurs when there is an error
    ''' converting singapore currency to foreign currency value
    ''' </summary>
    Public Class CurrencyConversionException

        Inherits Exception

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(message As String)
            MyBase.New(message)
        End Sub

    End Class


End Namespace