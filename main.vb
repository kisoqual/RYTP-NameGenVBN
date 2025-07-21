Imports System '* говорят по хорошему лучше его юзать
'Imports System.Console '* вроде тоже доступно с .NET 6 (core)

Module Program
    Sub Lulz(Optional i As String = "")
        Console.Write("какой ты RYTP хочеш? ")
        Dim j As String = Console.ReadLine()
        Console.WriteLine(j+i)

        '' так тоже можно, если подключен Imports System.Console
        ' Write("какой ты RYTP хочеш? ")
        ' Dim j As String = ReadLine()
        ' WriteLine(j+i)
    End Sub
    Sub Main()
        Lulz(" RYTP")
    End Sub
End Module
