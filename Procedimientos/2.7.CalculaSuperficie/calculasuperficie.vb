Imports System

Module Program
    Sub Main(args As String())
        Dim lado, base, altura As Double

        Console.WriteLine("Ingrese Lado: ")
        lado = Console.ReadLine()
        Console.WriteLine("Ingrese Base: ")
        base = Console.ReadLine()
        Console.WriteLine("Ingrese la Altura: ")
        altura = Console.ReadLine()

        Console.WriteLine("Funcion resuelve cuadrado: " & CalculaSuperficie(lado))
        Console.WriteLine("Funcion resuelve rectangulo: " & CalculaSuperficie(base, altura))
        Console.WriteLine("Funcion resuelve trapecio: " & CalculaSuperficie(lado, base, altura))
    End Sub

    Private Function CalculaSuperficie(ByRef lado As Double) As Double
        Return lado * lado
    End Function
    Private Function CalculaSuperficie(ByRef base As Double, ByRef altura As Double) As Double
        Return base * altura
    End Function
    Private Function CalculaSuperficie(ByRef lado As Single, ByRef base As Single, ByRef altura As Single) As Double
        Return base + lado / 2 * altura
    End Function
End Module
