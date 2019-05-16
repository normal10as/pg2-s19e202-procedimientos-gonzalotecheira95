Imports System

Module Program
    Sub Main()
        Dim ing As Short
        Console.WriteLine("Ingrese un numero: ")
        ing = Console.ReadLine()

        Potencia(ing)
    End Sub
    Private Function Potencia(ByVal numero As Integer) As Integer

        For i As Byte = 2 To 5
            numero = numero ^ i
            Console.WriteLine("El numero ingresado elevado a la " & i & " es " & numero)
        Next

        Return Potencia
    End Function
End Module