Imports System.DateTime

Module Program
    Sub Main()
        FechaActual()
        HoraActual()
    End Sub

    Private Sub FechaActual()
        Dim fecha As Date

        fecha = New DateTime(Now.Year, Now.Month, Now.Day)
        Console.WriteLine("La fecha actual es: " & fecha)
    End Sub
    Private Function HoraActual() As Date
        Console.WriteLine("La hora actual es: " & Now.Hour & ":" & Now.Minute)
        Return HoraActual
    End Function
End Module