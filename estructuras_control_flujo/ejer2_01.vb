Module ejer2_01
    Sub Main()
        Dim num1 As Int32
        Dim num2 As Int32
        Console.WriteLine("ESTE PROGRAMA SACA EL MAYOR DE DOS NUMEROS")
        Console.WriteLine("ingrese el primer valor: ")
        num1 = Console.ReadLine()
        Console.WriteLine("ingrese el segundo valor: ")
        num2 = Console.ReadLine()
        If num1 > num2 Then
            Console.WriteLine("El primer valor es mayor al segundo  " & num1 & " > " & num2)
        Else
            Console.WriteLine("El segundo valor es mayor al primer  " & num2 & " > " & num1)
        End If
    End Sub
End Module