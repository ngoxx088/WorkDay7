Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As Object, e As EventArgs) Handles btnPopulation.Click
        Dim Population As Double = 7000.0
        Dim Year As Integer = 2014

        Do While (Population > 6)
            Population = Population / 2
            Year = Year - 50
        Loop

        MessageBox.Show("The correct answer is " & Year)

    End Sub
End Class
