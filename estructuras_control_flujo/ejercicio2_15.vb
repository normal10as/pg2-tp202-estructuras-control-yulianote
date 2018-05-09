Module ejercicio2_15
    Const inte As Single = 36
    Sub Main()
        Dim capital As Single
        Dim interes As Single
        Dim saldo As Single
        Dim acumuladorinteres As Single
        Dim cantmes As Byte
        Console.WriteLine("interes del " & inte & " %")
        Console.Write("ingrese la cantidad de capital: ")
        capital = Console.ReadLine()
        Console.Write("ingrese la cantidad de meses: ")
        cantmes = Console.ReadLine()
        Console.WriteLine("|   MES    |" & "CAPITAL   |" & "INTERES   |" & "SALDO   |")
        For cont As Byte = 1 To cantmes Step +1
            interes = capital * ((inte / 100) / 12)
            saldo = capital + interes
            Console.WriteLine("|  " & cont & "  |  " & capital & "  |  " & interes & "  |  " & saldo)
            acumuladorinteres += interes
            capital = saldo
        Next
        Console.WriteLine("El saldo total es: " & saldo)
        Console.WriteLine("El total de interes ganado: " & acumuladorinteres)
    End Sub
End Module
