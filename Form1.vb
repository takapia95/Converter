Public Class Form1
    Private Const _cdecIntoMet As Decimal = 0.0254D
    Private Const _cdecMettoIn As Decimal = 39.37D
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtValue.Clear()
        txtValue.Focus()
        radInch.Checked = True
        radMeter.Checked = False
        lblResult.Text = ""
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        'declare and initialize variables
        Dim strValue As String
        Dim decValue As Decimal
        Dim decResult As Decimal

        ' Make sure user enters a numeric value
        If IsNumeric(txtValue.Text) Then
            decValue = Convert.ToDecimal(txtValue.Text)
            'check positive
            If decValue > 0 Then
                If radInch.Checked Then
                    decResult = decValue * _cdecIntoMet
                    lblResult.Text = txtValue.Text & " inches is " & decResult.ToString("F3") & " meters."
                ElseIf radMeter.Checked Then
                    decResult = decValue * _cdecMettoIn
                    lblResult.Text = txtValue.Text & " meters is " & decResult.ToString("F3") & " inches."
                End If

            Else
                MsgBox("ERROR - Enter a positive number")

            End If
        Else
            'Error message
            MsgBox("ERROR - Enter a nuber")
        End If

    End Sub
End Class
