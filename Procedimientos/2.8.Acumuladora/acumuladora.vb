Imports System

Module Program
    Friend valor_decimal As Decimal
    Sub Main()
        Console.WriteLine("Ingrese un valor decimal para acumular.")

        Acumuladora(valor_decimal)
        Console.WriteLine("Ingrese un valor decimal para acumular.")
        Acumuladora(valor_decimal)
        Console.WriteLine("Ingrese un valor decimal para acumular.")
        Acumuladora(valor_decimal)

    End Sub

    Private Sub Acumuladora(ByRef valor_decimal As Decimal)
        Dim num As Decimal
        num = Console.ReadLine()

        valor_decimal = valor_decimal + num
        Console.WriteLine("El valor acumulado hasta ahora es: {0}", valor_decimal)
    End Sub
End Module
