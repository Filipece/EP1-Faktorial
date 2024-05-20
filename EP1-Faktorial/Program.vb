Imports System

Module Program
    Sub Main()
        Console.WriteLine("Zadej cel� ��slo pro v�po�et faktori�lu (0-10):")

        Dim input As String = Console.ReadLine()
        Dim number As Integer

        If Integer.TryParse(input, number) Then
            If number > 10 Then
                Console.WriteLine("P��li� vysok� hodnota, zadej ��slo mezi 0 a 10.")
            Else
                Dim result As Integer = CalculateFactorial(number)
                Console.WriteLine($"Faktori�l ��sla {number} je {result}.")
            End If
        Else
            Console.WriteLine("Zadej platn� cel� ��slo.")
        End If

        Console.WriteLine("Stiskni libovolnou kl�vesu pro ukon�en� programu.")
        Console.ReadKey()
    End Sub

    Function CalculateFactorial(ByVal n As Integer) As Integer
        If n = 0 Or n = 1 Then
            Return 1
        Else
            Return n * CalculateFactorial(n - 1)
        End If
    End Function
End Module


