Module ejer2_02
    Sub Main()
        Dim num1 As Int32
        Dim num2 As Int32
        Dim num3 As Int32
        Console.WriteLine("ESTE PROGRAMA SACA EL MENOR DE TRES NUMEROS")
        Console.WriteLine("ingrese el primer valor: ")
        num1 = Console.ReadLine()
        Console.WriteLine("ingrese el segundo valor: ")
        num2 = Console.ReadLine()
        Console.WriteLine("ingrese el tercer valor: ")
        num3 = Console.ReadLine()
        If num1 < num2 And num1 < num3 Then
            Console.WriteLine("El menor es el primero y es = " & num1)
        ElseIf num3 < num1 And num3 < num2 Then
            Console.WriteLine("El menor es el tercero y es = " & num3)
        ElseIf num2 < num1 And num2 < num3 Then
            Console.WriteLine("El menor es el segundo y es = " & num2)
        Else
            Console.WriteLine("LOS VALORES SON IGUALES")
        End If
    End Sub
End Module
