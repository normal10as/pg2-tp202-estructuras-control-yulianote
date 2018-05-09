Module ejercicio2_06
    Sub main()
        Dim precio As Single
        Dim cantidad As Int32
        Dim final As Single
        Dim resultado As Single
        Console.WriteLine("INGRESE EL PRECIO: ")
        precio = Console.ReadLine()
        Console.WriteLine("INGRESE LA CANTIDAD: ")
        cantidad = Console.ReadLine()
        resultado = cantidad * precio
        Select Case (cantidad)
            Case 10 To 50
                final = (cantidad * precio) - ((precio * cantidad) * 0.05)
                Console.WriteLine("El sub total es: " & resultado & " $")
                Console.WriteLine("EL DESCUENTO DEL 5 %  Y EL FINAL A PAGAR ES = " & final & "$")
            Case 51 To 251
                final = (cantidad * precio) - ((precio * cantidad) * 0.1)
                Console.WriteLine("El sub total es: " & resultado & " $")
                Console.WriteLine("EL DESCUENTO DEL 10 %  Y EL FINAL A PAGAR ES = " & final & "$")
            Case > 251
                final = (cantidad * precio) - ((precio * cantidad) * 0.2)
                Console.WriteLine("El sub total es: " & resultado & " $")
                Console.WriteLine("EL DESCUENTO DEL 20 %  Y EL FINAL A PAGAR ES = " & final & " $")
            Case Else
                Console.WriteLine("NO EXISTE DESCUENTO PARA ESTA CANTIDAD")
        End Select
    End Sub
End Module
