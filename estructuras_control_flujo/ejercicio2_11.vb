Module ejercicio2_11
    Sub main()
        Dim x As Int32
        Dim contadorinpar As Int32 = 0
        Dim contadorpar As Int32 = 0
        Dim entidad As Integer = 0
        Do
            Console.WriteLine("ingrese numeros enteros")
            x = Console.ReadLine()
            If x < 0 Then
                Console.WriteLine("no podes ingresar negativos")
                x = Console.ReadLine()
            Else
                If x Mod 2 = 0 And x <> 0 Then
                    contadorpar += 1
                End If
                If x Mod 2 <> 0 And x <> 0 Then
                    contadorinpar += 1
                End If
                If contadorinpar = 0 Then
                    Console.WriteLine("Son todos pares")
                End If
                If contadorpar = 0 Then
                    Console.WriteLine("Son todos inpares")
                End If
            End If
        Loop While (x)
        Console.WriteLine("el numero de pares es " & contadorpar)
        Console.WriteLine("el numero de inpares es " & contadorinpar)
    End Sub
End Module
