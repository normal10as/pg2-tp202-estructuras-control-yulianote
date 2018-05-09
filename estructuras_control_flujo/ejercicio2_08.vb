Module ejercicio2_08
    Enum enumermeses As Byte
        enero = 1
        febrero = 2
        marzo = 3
        mayo = 4
        abril = 5
        junio = 6
        julio = 7
        agosto = 8
        septiembre = 9
        octubre = 10
        noviembre = 11
        diciembre = 12
    End Enum
    Sub main()
        Dim elegido As enumermeses
        Dim febrero As Single
        Console.WriteLine("Ingrese un mes ")
        elegido = Console.ReadLine()
        Select Case (elegido)
            Case 1 To 12
                Console.WriteLine("el mes ingresado es " & elegido.ToString())
            Case Else
                Console.WriteLine("no existe un mes")
        End Select

        If elegido = 2 Then
            Console.WriteLine("Ingrese ano estamos en febrero ")
            febrero = Console.ReadLine()
            If febrero Mod 4 = 0 Then
                If febrero Mod 100 = 0 Then
                    If febrero Mod 400 = 0 Then
                        Console.WriteLine("el ano SI es bisiesto ")
                    Else
                        Console.WriteLine("el ano NO es bisiesto")
                    End If
                Else
                    Console.WriteLine("el ano Si es bisiesto")
                End If
            Else
                Console.WriteLine("el ano NO es bisiesto ")

            End If
        End If
    End Sub
End Module
