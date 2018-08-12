Class MainWindow

    Private Sub btnCalculate_Click(sender As Object, e As RoutedEventArgs)
        Const fatCaloriesPerGram = 9
        Dim foodName As String = txtNameOfFood.Text
        Dim caloriesPerServing, gramsOfFat, totalCaloriesFromFat, percentCaloriesFromFat As Double
        Dim AHAapproved As String

        If foodName <> "" And Double.TryParse(txtGramsOfFat.Text, gramsOfFat) And Double.TryParse(txtCaloriesPerServing.Text, caloriesPerServing) Then
            totalCaloriesFromFat = gramsOfFat * fatCaloriesPerGram
            percentCaloriesFromFat = totalCaloriesFromFat / caloriesPerServing
            If percentCaloriesFromFat < 0.3 Then
                AHAapproved = "AHA approved"
            Else
                AHAapproved = "No AHA approved"
            End If

            txtDisplay.Text = foodName & " contains " & FormatPercent(percentCaloriesFromFat, 2) & " calories from fat. " & vbNewLine & "It is " & AHAapproved & "."

        Else
            MessageBox.Show("Error: missing information.")
        End If



    End Sub
End Class
