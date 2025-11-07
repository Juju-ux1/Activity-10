Imports System.IO
Imports System.Linq

Public Class Form1

    Private filePath As String = Path.Combine(My.Application.Info.DirectoryPath, "numbers.txt")

    ' ===========================
    ' FORM LOAD
    ' ===========================
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists(filePath) Then
            ReadNumbers()
        End If
    End Sub

    ' ===========================
    ' ADD BUTTON
    ' ===========================
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim input As String = txtNumbers.Text.Trim()

            If String.IsNullOrWhiteSpace(input) Then
                MessageBox.Show("Please enter a number.")
                Return
            End If

            Dim number As Integer
            If Not Integer.TryParse(input, number) Then
                MessageBox.Show("Please enter a valid whole number.")
                Return
            End If

            ' Append number to file
            Using writer As New StreamWriter(filePath, append:=True)
                writer.Write(number.ToString() & " ")
            End Using

            txtNumbers.Clear()
            txtNumbers.Focus()

            ReadNumbers() ' Refresh the list

        Catch ex As Exception
            MessageBox.Show("Error adding number: " & ex.Message)
        End Try
    End Sub

    ' ===========================
    ' READ BUTTON
    ' ===========================
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        ReadNumbers()
    End Sub

    ' ===========================
    ' SORT BUTTON
    ' ===========================
    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        Try
            If Not File.Exists(filePath) Then
                MessageBox.Show("No numbers to sort yet.")
                Return
            End If

            Dim fileContent As String = File.ReadAllText(filePath).Trim()
            If String.IsNullOrWhiteSpace(fileContent) Then
                MessageBox.Show("The file is empty. Add numbers first.")
                Return
            End If

            ' Safely convert to integers (ignore invalid values)
            Dim numbers As New List(Of Integer)
            For Each part In fileContent.Split(New Char() {" "c, ControlChars.Lf, ControlChars.Tab}, StringSplitOptions.RemoveEmptyEntries)
                Dim value As Integer
                If Integer.TryParse(part.Trim(), value) Then
                    numbers.Add(value)
                End If
            Next

            ' Sort numbers
            numbers.Sort()

            ' Save sorted list back to file
            File.WriteAllText(filePath, String.Join(" ", numbers))

            ' Display in ListBox
            DisplayNumbers(numbers)

        Catch ex As Exception
            MessageBox.Show("Error while sorting: " & ex.Message)
        End Try
    End Sub

    ' ===========================
    ' HELPER: READ NUMBERS
    ' ===========================
    Private Sub ReadNumbers()
        Try
            Sorted.Items.Clear()

            If Not File.Exists(filePath) Then
                MessageBox.Show("No file found. Add numbers first.")
                Return
            End If

            Dim fileContent As String = File.ReadAllText(filePath).Trim()
            If String.IsNullOrWhiteSpace(fileContent) Then
                MessageBox.Show("The file is empty.")
                Return
            End If

            ' Safe parsing: only keep valid integers
            Dim numbers As New List(Of Integer)
            For Each part In fileContent.Split(New Char() {" "c, ControlChars.Lf, ControlChars.Tab}, StringSplitOptions.RemoveEmptyEntries)
                Dim value As Integer
                If Integer.TryParse(part.Trim(), value) Then
                    numbers.Add(value)
                End If
            Next

            DisplayNumbers(numbers)

        Catch ex As Exception
            MessageBox.Show("Error while reading: " & ex.Message)
        End Try
    End Sub

    ' ===========================
    ' HELPER: DISPLAY NUMBERS
    ' ===========================
    Private Sub DisplayNumbers(numbers As List(Of Integer))
        Sorted.Items.Clear()
        For Each num In numbers
            Sorted.Items.Add(num)
        Next
    End Sub

End Class
