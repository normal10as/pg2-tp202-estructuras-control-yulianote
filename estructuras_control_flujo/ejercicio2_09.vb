Module ejercicio2_09
    Enum medidas As Byte
        centimetros = 1
        metros = 2
        yardas = 3
        pulgadas = 4
        pies = 5
    End Enum
    Sub main()
        Dim elegir As medidas
        Dim cem As Single
        Dim met As Single
        Dim yard As Single
        Dim pulg As Single
        Dim pes As Single
        Console.WriteLine("INGRESE LA UNIDAD QUE DESEA CONOCER" & vbCrLf & "1-CENTIMETROS" & vbCrLf &
                          "2-METROS" & vbCrLf & "3-YARDAS" & vbCrLf & "4-PULGADAS" & vbCrLf & "5-PIES")
        elegir = Console.ReadLine()
        Select Case (elegir)
            Case 1
                Console.WriteLine("El ingresado es " & elegir.ToString())
                Console.WriteLine("ingrese el valor a convertir: ")
                cem = Console.ReadLine()
                met = cem / 100
                pulg = cem / 2.54
                pes = pulg / 12
                yard = 3 / pes
                Console.WriteLine("metros= " & met & vbCrLf & "pulgadas= " & pulg & vbCrLf &
                                  "pies= " & pes & vbCrLf & "yardas= " & yard)
            Case 2
                Console.WriteLine("El ingresado es " & elegir.ToString())
                Console.WriteLine("ingrese el valor a convertir: ")
                met = Console.ReadLine()
                cem = met * 100
                pulg = cem / 2.54
                pes = pulg / 12
                yard = 3 / pes
                Console.WriteLine("centimetros= " & cem & vbCrLf & "pulgadas= " & pulg & vbCrLf &
                                  "pies= " & pes & vbCrLf & "yardas= " & yard)
            Case 3
                Console.WriteLine("El ingresado es " & elegir.ToString())
                Console.WriteLine("ingrese el valor a convertir: ")
                yard = Console.ReadLine()
                pes = yard * 3
                pulg = 12 * pes
                cem = pulg / 2.54
                met = cem / 100
                Console.WriteLine("centimetros= " & cem & vbCrLf & "metros= " & met & vbCrLf & "pulgadas= " & pulg & vbCrLf &
                                  "pies= " & pes)
            Case 4
                Console.WriteLine("El ingresado es " & elegir.ToString())
                Console.WriteLine("ingrese el valor a convertir: ")
                pulg = Console.ReadLine()
                cem = pulg * 2.54
                met = cem / 100
                pes = pulg * 12
                yard = 3 * pes
                Console.WriteLine("centimetros= " & cem & vbCrLf & "metros= " & met & vbCrLf & "pies= " & pes & vbCrLf &
                                  "yardas= " & yard)
            Case 5
                Console.WriteLine("El ingresado es " & elegir.ToString())
                Console.WriteLine("ingrese el valor a convertir: ")
                pes = Console.ReadLine()
                pulg = pes * 12
                cem = pulg * 2.54
                met = cem / 100
                yard = 3 * pes
                Console.WriteLine("centimetros= " & cem & vbCrLf & "metros= " & met & vbCrLf & "pulgadas= " & pulg & vbCrLf &
                                  "yardas= " & yard)
            Case Else
                Console.WriteLine("FUERA DE RANGO")
        End Select
    End Sub
End Module
