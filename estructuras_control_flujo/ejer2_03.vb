Module ejer2_03
    Sub Main()
        Dim n1 As Int32
        Dim n2 As Int32
        Dim n3 As Int32
        Dim n4 As Int32
        Dim n5 As Int32
        Console.WriteLine("ESTE PROGRAMA SACA EL MAYOR DE CINCO NUMEROS")
        Console.WriteLine("ingrese el PRIMER valor: ")
        n1 = Console.ReadLine()
        Console.WriteLine("ingrese el SEGUNDO valor: ")
        n2 = Console.ReadLine()
        Console.WriteLine("ingrese el TERCERO valor: ")
        n3 = Console.ReadLine()
        Console.WriteLine("ingrese el CUARTO valor: ")
        n4 = Console.ReadLine()
        Console.WriteLine("ingrese el QUINTO valor: ")
        n5 = Console.ReadLine()
        If n1 > n2 And n1 > n3 And n1 > n4 And n1 > n5 Then
            Console.WriteLine("El mayor es el PRIMERO")
        ElseIf n2 > n1 And n2 > n3 And n2 > n4 And n2 > n5 Then
            Console.WriteLine("El mayor es el SEGUNDO")
        ElseIf n3 > n1 And n3 > n2 And n3 > n4 And n3 > n5 Then
            Console.WriteLine("El mayor es el TERCERO")
        ElseIf n4 > n1 And n4 > n3 And n4 > n2 And n4 > n5 Then
            Console.WriteLine("El mayor es el CUARTO")
        ElseIf n5 > n1 And n5 > n2 And n5 > n3 And n5 > n4 Then
            Console.WriteLine("El mayor es el QUINTO")
        Else
            Console.WriteLine("LOS VALORES SON IGUALES Y MAYORES")
        End If
    End Sub
End Module
