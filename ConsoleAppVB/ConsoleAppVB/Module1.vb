Module Module1

    Sub Main()
        Dim valorDecimal As Decimal?

        Dim valorString As String = "5459,33"
        Dim resultadoDecimal As String
        Dim resultadoString As String
        ' User-defined numeric formats.
        resultadoDecimal = Format(valorDecimal, "##,##0")

        Dim testes = IsNothing(valorDecimal)

        If (String.IsNullOrEmpty(valorString)) Then
            resultadoString = "0"
        Else
            resultadoString = Format(Convert.ToDecimal(valorString), "##,##0")
        End If

        Convert.ToDecimal(valorString)

        Dim test = FormatCurrency(valorString, , TriState.False, TriState.False, TriState.False)

        FormatCurrency(123.456, 0)

        Console.WriteLine($"Resultado Final.")
        Console.WriteLine($"Resultado convertendo Decimal : {resultadoDecimal} .")
        Console.WriteLine($"Resultado convertendo String : {resultadoString} .")
        Console.WriteLine($"FIM.   ")

    End Sub

End Module