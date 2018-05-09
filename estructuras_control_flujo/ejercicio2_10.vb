Module ejercicio2_10
    Sub main()
        Dim val1 As Single
        Dim val2 As Single
        Dim contador As Byte = 0
        Console.WriteLine("Ingrese el primer valor: ")
        val1 = Console.ReadLine()
        Do
            Console.WriteLine("Ingrese el segundo valor mayor al primero: ")
            val2 = Console.ReadLine()
        Loop Until (val1 < val2)

        Do While (val1 >= 0 & val2 >= 0)
            val1 = val1 / 5
            val2 = val2 / 5
            If val1 = val2 Then
                contador += 1
            End If
        Loop

        Console.WriteLine("el valor tiene" & contador & " de multiplos " & val1 & val2)

    End Sub
End Module
