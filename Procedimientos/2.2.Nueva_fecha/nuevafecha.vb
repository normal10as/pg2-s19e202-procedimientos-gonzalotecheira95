Imports System.DateTime

Module Program
    Sub Main()
        Dim fecha_actual As Date
        Dim dias_sumar As UShort

        Console.WriteLine("Ingrese una fecha: ")
        fecha_actual = Console.ReadLine()
        Console.WriteLine("Ingrese dias a sumar: ")
        dias_sumar = Console.ReadLine()

        Console.WriteLine("La nueva fecha es: " & NuevaFecha(fecha_actual, dias_sumar))
    End Sub

    Private Function NuevaFecha(fecha_actual As Date, dias As UShort) As Date
        Dim nueva_fecha As Date
        nueva_fecha = New DateTime(fecha_actual.Year, fecha_actual.Month, fecha_actual.Day)

        Return nueva_fecha.AddDays(dias)
    End Function
End Module
