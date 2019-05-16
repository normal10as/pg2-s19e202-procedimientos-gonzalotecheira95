Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine(Sumar(5, 7))
        Console.WriteLine(Sumar(5, 7, 7))
        Console.WriteLine(Sumar(5, 7, 7, 5))
    End Sub
    Private Function Sumar(ByRef val1 As Short, ByRef val2 As Short) As Short
        Return val1 + val2
    End Function
    Private Function Sumar(ByRef val1 As Short, ByRef val2 As Short, ByRef val3 As Short) As Short
        Return val1 + val2 + val3
    End Function
    Private Function Sumar(ByRef val1 As Short, ByRef val2 As Short, ByRef val3 As Short, ByRef val4 As Short) As Short
        Return val1 + val2 + val3 + val4
    End Function
End Module
