Public Class frmComic
    Private Sub btn_Calculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'ltf 03/01/2023
        'initializes all varibles
        Dim intGroup As Integer = 0
        Dim decRegistration As Decimal
        Dim decTotalCost As Decimal
        Dim decSuperHero As Decimal = 380D
        Dim decAutographs As Decimal = 275D
        Dim decConvention As Decimal = 209D

        If IsNumeric(txtGroup.Text) Then
            'is number of group greater than 1 and less than 20
            intGroup = Convert.ToInt32(txtGroup.Text)
            If intGroup > 0 And intGroup < 20 Then
                If rad_Superhero.Checked Then
                    decRegistration = decSuperHero
                ElseIf rad_Autographs.Checked Then
                    decRegistration = decAutographs
                ElseIf radConvention.Checked Then
                    decRegistration = decConvention
                End If

                decTotalCost = (intGroup * decRegistration)
                lblTotal.Text = decTotalCost.ToString("C")
            Else
                'Display error message if user entered a negative number
                MsgBox("Enter a postive number between 1 and 20", , "Invalid Number Error")
            End If
        Else
            'Display error message if user entered a nonnumeric value
            MsgBox("Enter a reasonable number between 1 and 20", , "Invalid Entry Number")
        End If
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGroup.Text = ""
        rad_Superhero.Checked = True
        lblTotal.Text = "$0000.00"
    End Sub
End Class
