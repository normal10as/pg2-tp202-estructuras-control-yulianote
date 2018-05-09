Module ejercicio2_12
    Sub main()
        Dim a As Int32 = 0
        Dim b As Int32 = 1
        Dim c As Int32
        Dim j As String = a & " " & b & " "
        Console.WriteLine("La ecuacion de fibo hasta X=20")
        For x As Short = 1 To 20 Step 1
            Console.WriteLine("PARA X=" & x)
            c = a + b
            Console.WriteLine("secuencia a=" & a & " y b=" & b)
            Console.WriteLine("el numero resultante c = " & c)
            Console.WriteLine("secuencia llevada " & "-" & a & "-" & b & "-" & c & "-")
            j = j & c & " "
            a = b
            b = c
            c = 0
        Next
        Console.WriteLine("Secuencia completa")
        Console.WriteLine(" X=" & j)
    End Sub
End Module
