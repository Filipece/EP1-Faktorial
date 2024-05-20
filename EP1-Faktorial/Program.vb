Imports System

Module Program
    Sub Main()
        Dim continueCalculation As Boolean = True

        While continueCalculation
            Console.WriteLine("Zadej celé èíslo pro výpoèet faktoriálu (0-10):")

            Dim input As String = Console.ReadLine()
            Dim number As Integer

            If Integer.TryParse(input, number) Then
                If number < 0 Then
                    Console.WriteLine("Nelze zadávat záporné hodnoty.")
                ElseIf number > 10 Then
                    Console.WriteLine("Pøíliš vysoká hodnota, Zadej èíslo mezi 0 a 10.")
                Else
                    Dim result As Integer = CalculateFactorial(number)
                    Console.WriteLine($"Faktoriál èísla {number} je {result}.")
                End If
            Else
                Console.WriteLine("Zadej platné celé èíslo.")
            End If

            Console.WriteLine("Chceš pokraèovat? (a/n)")
            Dim response As String = Console.ReadLine().ToLower()
            If response <> "a" Then
                continueCalculation = False
            End If
        End While
    End Sub

    Function CalculateFactorial(ByVal n As Integer) As Integer
        If n = 0 Or n = 1 Then
            Return 1
        Else
            Return n * CalculateFactorial(n - 1)
        End If
    End Function
End Module




