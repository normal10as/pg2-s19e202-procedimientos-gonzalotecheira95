Imports System

Module Program
    Sub Main()
        Dim A, B As UShort

        Console.WriteLine("Ingrese tamaño del lado A: ")
        A = Console.ReadLine()
        Console.WriteLine("Ingrese tamaño del lado B: ")
        B = Console.ReadLine()

        Console.WriteLine("La hipotenusa es igual a: " & Hipotenusa(A, B))
    End Sub
    Private Function Hipotenusa(ByRef ladoA As UShort, ByRef ladoB As UShort) As UShort
        Dim hipo As UShort
        hipo = ladoA ^ 2 + ladoB ^ 2
        Return hipo
    End Function
End Module
