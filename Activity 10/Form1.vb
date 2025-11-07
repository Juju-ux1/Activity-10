Imports System.IO

Public Class Form1
    Private Sub btnSaveSort_Click(sender As Object, e As EventArgs) Handles btnSaveSort.Click
        Try
            Dim input As String = txtNumbers.Text

            ' Write to file
            Using writer As New StreamWriter("numbers.txt")
                writer.WriteLine(input)
            End Using

            ' Read from file
            Dim fileContent As String
            Using reader As New StreamReader("numbers.txt")
                fileContent = reader.ReadToEnd()
            End Using

            ' Convert to list of integers
            Dim numbers As List(Of Integer) = fileContent.Split(","c).Select(Function(n) Integer.Parse(n.Trim())).ToList()

            ' Sort numbers using LINQ OrderBy
            Dim sortedNumbers = numbers.OrderBy(Function(n) n).ToList()

            ' Display in ListBox
            Sorted.Items.Clear()
            For Each num In sortedNumbers
                Sorted.Items.Add(num)
            Next

            ' Also show in Console
            Console.WriteLine("Sorted Numbers:")
            For Each num In sortedNumbers
                Console.WriteLine(num)
            Next

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub
End Class
