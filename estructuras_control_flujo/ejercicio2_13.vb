Module ejercicio2_13
    Sub main()
        Dim x As Int32 = 0
        Console.WriteLine("NUMEROS PRIMOS HASTA EL 1000")
        For num As Int32 = 1 To 1000 Step 1
            For i As Int32 = 1 To 9 Step 1
                If num Mod i = 0 Then

                    x = x + 1
                End If
            Next
            If (x = 2) Then
                Console.Write("-" & num)
            End If
            x = 0
        Next
    End Sub
End Module
