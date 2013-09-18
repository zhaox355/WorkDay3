Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1 As Double = CDbl(txtFirstNum.Text)
        Dim num2 As Double = CDbl(txtSecondNum.Text)
        If (num1 > num2) Then
            txtResult.Text = "The larger number is" & CStr(num1)
        ElseIf (num1 < num2) Then
            txtResult.Text = "The larger number is" & CStr(num2)
        Else
            txtResult.Text = "They are equal"
        End If


    End Sub

    
End Class
