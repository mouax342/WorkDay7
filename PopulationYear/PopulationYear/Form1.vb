Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As Object, e As EventArgs) Handles btnPopulation.Click

        Dim pop As Double = 7000.0 'pop of 7bln in year of 2014 & doubles every 50 years
        Dim year As Integer = 2014

        Do While (pop >= 6)
            pop = pop / 2
            year = year - 50

        Loop

        MessageBox.Show("The answer is " & year)

    End Sub
End Class
