Module Module1

    Sub Main()
        Console.Clear()

        While True

            Dim currentTime As String = DateTime.Now.ToString("hh:mm:ss tt")

            Console.SetCursorPosition(0, 0)
            Console.WriteLine("Digital Clock")
            Console.WriteLine("=======================")
            Console.WriteLine($"Time: {currentTime}")

            'Pause time
            Threading.Thread.Sleep(1000) ' 1 Second
        End While

    End Sub

End Module
