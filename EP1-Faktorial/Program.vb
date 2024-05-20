Imports System

Module Program
    Sub Main()
        Console.WriteLine("Zadej celé èíslo pro výpoèet faktoriálu:")

        Dim input As String = Console.ReadLine()
        Dim number As Integer

        If Integer.TryParse(input, number) Then
            Dim result As Integer = CalculateFactorial(number)
            Console.WriteLine($"Faktoriál èísla {number} je {result}.")
        Else
            Console.WriteLine("Zadej platné celé èíslo.")
        End If

        Console.WriteLine("Stiskni libovolnou klávesu pro ukonèení programu.")
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
