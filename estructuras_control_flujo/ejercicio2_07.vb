Module ejercicio2_07
    Sub main()
        Dim ingresado As Single
        Console.WriteLine("INGRESE EL VALOR DEL ANGULO: ")
        ingresado = Console.ReadLine()
        Select Case (ingresado)
            Case 1 To 90
                Console.WriteLine("El angulo es AGUDO")
            Case = 90
                Console.WriteLine("El angulo es RECTO")
            Case 91 To 179
                Console.WriteLine("El angulo es OBTUSO")
            Case = 180
                Console.WriteLine("El angulo es LLANO")
            Case 181 To 360
                Console.WriteLine("El angulo es CONCAVO")
            Case Else
                Console.WriteLine("Error")
        End Select
    End Sub
End Module
