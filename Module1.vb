Module Module1

    Sub Main()
        Dim myName As String
        myName = ""

        Dim myPer As Single
        myPer = 0

        Dim Counter As Integer
        Counter = 0

        Console.Write("Enter your name: ")
        myName = Console.ReadLine()

        For Counter = 1 To 5
            Console.WriteLine(myName)
        Next

        Console.WriteLine("Press any key to continue...")
        Console.ReadKey()
    End Sub

End Module
