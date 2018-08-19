Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub btnAnalize_Click(sender As Object, e As RoutedEventArgs)
        Dim loanAmount, monthlyInterest, anualInterestRate, monthlyPayment As Double
        Dim months As Int32

        If Double.TryParse(txtAmountOfLoan.Text, loanAmount) And Double.TryParse(txtInterestRate.Text, anualInterestRate) And Int32.TryParse(txtDuration.Text, months) Then
            monthlyInterest = (anualInterestRate / 100) / 12
            monthlyPayment = FormatCurrency(loanAmount * monthlyInterest / (1 - Math.Pow(1 + monthlyInterest, months * -1)))
            txtMonthyPayments.Text = FormatCurrency(monthlyPayment)
            txtInterestPaid.Text = FormatCurrency(months * monthlyPayment - loanAmount)
            Return
        End If


    End Sub
End Class
