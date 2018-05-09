Module ejercicio2_05
    Sub main()
        Dim meses As String
        Console.WriteLine("INGRESE UN MES A BUSCAR: ")
        meses = Console.ReadLine()
        Select Case (meses)
            Case 1
                Console.WriteLine("MES DE ENERO")
            Case 2
                Console.WriteLine("MES DE FEBRERO")
            Case 3
                Console.WriteLine("MES DE MARZO")
            Case 4
                Console.WriteLine("MES DE ABRIL")
            Case 5
                Console.WriteLine("MES DE MAYO")
            Case 6
                Console.WriteLine("MES DE JUNIO")
            Case 7
                Console.WriteLine("MES DE JULIO")
            Case 8
                Console.WriteLine("MES DE AGOSTO")
            Case 9
                Console.WriteLine("MES DE SEPTIEMBRE")
            Case 10
                Console.WriteLine("MES DE OCTUBRE")
            Case 11
                Console.WriteLine("MES DE NOVIEMBRE")
            Case 12
                Console.WriteLine("MES DE DICIEMBRE")
            Case Else
                Console.WriteLine("EL VALOR NO CORRESPONDE A NINGUN MES")
        End Select
    End Sub
End Module
