Imports System

Module Program
    Private Const Pi As Double = 3.1415
    Sub Main()
        Dim radio, altura As Single

        Console.WriteLine("Ingrese el radio del cilindro: ")
        radio = Console.ReadLine()
        Console.WriteLine("Ingrese la altura del cilindro: ")
        altura = Console.ReadLine()

        Console.WriteLine("El volumen del cilindro es de: " & CalculoVolumen(radio, altura))
    End Sub

    Private Function CalculoVolumen(ByRef radio As Single, ByRef altura As Single) As Single
        Dim volumen As Single
        volumen = Pi * radio ^ 2 * altura
        Return volumen
    End Function
End Module
