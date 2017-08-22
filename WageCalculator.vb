Public Class WageCalculatorForm

   Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
      Dim hours As Double
      Dim wage As Decimal
      Dim earning As Decimal


      hours = Val(hoursTextBox.Text)
      wage = Val(wageTextBox.Text)

      If hours <= 40 Then
         earning = hours * wage
      Else
         earning = (40 * wage) + (hours - 40) * (2 * wage)
      End If

      earningsResultLabel.Text = earning


   End Sub
End Class ' WageCalculatorForm

' **************************************************************************
' * (C) Copyright 1992-2013 by Deitel & Associates, Inc. and               *
' * Pearson Education, Inc. All Rights Reserved.                           *
' *                                                                        *
' * DISCLAIMER: The authors and publisher of this book have used their     *
' * best efforts in preparing the book. These efforts include the          *
' * development, research, and testing of the theories and programs        *
' * to determine their effectiveness. The authors and publisher make       *
' * no warranty of any kind, expressed or implied, with regard to these    *
' * programs or to the documentation contained in these books. The authors *
' * and publisher shall not be liable in any event for incidental or       *
' * consequential damages in connection with, or arising out of, the       *
' * furnishing, performance, or use of these programs.                     *
' **************************************************************************