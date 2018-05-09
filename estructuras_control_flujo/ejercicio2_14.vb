Module ejercicio2_14
    Sub main()
        Dim x As Byte = 1
        Do
            Dim preciou As Single
            Dim cantidad As Int32
            Dim resultados As Single
            Dim descuento As Single
            Dim final As Single
            Console.WriteLine("INGRESE EL PRECIO UNITARIO: ")
            preciou = Console.ReadLine()
            Console.WriteLine("INGRESE LA CANTIDAD DE PRODUCTOS: ")
            cantidad = Console.ReadLine()
            resultados = preciou * cantidad
            If cantidad >= 10 And cantidad <= 50 Then
                descuento = resultados * 0.05
                final = resultados - descuento
                Console.WriteLine("El sub total es: " & resultados & " $")
                Console.WriteLine("El porcentaje aplicado es 5 % con un descuento de: " & descuento & " $")
                Console.WriteLine("El total: " & final & " $")
            End If
            If cantidad > 50 And cantidad <= 250 Then
                descuento = resultados * 0.1
                final = resultados - descuento
                Console.WriteLine("El sub total es: " & resultados & " $")
                Console.WriteLine("El porcentaje aplicado es 10 % con un descuento de: " & descuento & " $")
                Console.WriteLine("El total: " & final & " $")
            End If
            If cantidad >= 251 Then
                descuento = resultados * 0.2
                final = resultados - descuento
            End If
            If cantidad < 10 Then
                Console.WriteLine("El sub total es: " & resultados & " $")
                Console.WriteLine("No se aplican descuentos")
                Console.WriteLine("El total ah pagar: " & resultados & " $")
            End If
        Loop While (x)
    End Sub
End Module
