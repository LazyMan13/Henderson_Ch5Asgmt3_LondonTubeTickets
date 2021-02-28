Public Class frmLondon
    Private Sub frmTickets_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblCostTickets.Text = ""

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtNumberOfTickets.Clear()
        lblCostTickets.Text = ""
        radZone3.Checked = False
        radZone5.Checked = False
        radZone6.Checked = False
        txtNumberOfTickets.Focus()
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim intNumberOfTickets As Integer = 0
        Dim decTicketCost As Decimal
        Dim decTotalCost As Decimal
        Dim decZone3 As Decimal = 4.9D
        Dim decZone5 As Decimal = 5.9D
        Dim decZone6 As Decimal = 6D
        Dim decPound As Decimal = 1.407D

        If IsNumeric(txtNumberOfTickets.Text) Then
            intNumberOfTickets = Convert.ToInt32(txtNumberOfTickets.Text)
            If intNumberOfTickets > 0 Then
                If radZone3.Checked Then
                    decTicketCost = decZone3
                ElseIf radZone5.Checked Then
                    decTicketCost = decZone5
                ElseIf radZone6.Checked Then
                    decTicketCost = decZone6
                End If
                decTotalCost = (intNumberOfTickets * decTicketCost) * decPound
                lblCostTickets.Text = decTotalCost.ToString("C")
            Else
                MsgBox("You entered " + txtNumberOfTickets.Text + Environment.NewLine + "Enter a positive number", , "Negative Number")
            End If
        Else
            MsgBox("You entered " + txtNumberOfTickets.Text + Environment.NewLine + "Enter a positive number", , "Invalid Entry")
        End If
    End Sub
End Class
