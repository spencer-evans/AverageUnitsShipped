Public Class frmAverageUnitsShipped
    Dim currentDay As Integer = 1
    Dim totalUnits As Integer = 0

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim units As Integer


        If Integer.TryParse(txtUnits.Text, units) Then
            If units >= 0 And units <= 5000 Then
                totalUnits += units
                txtEntryDisplay.AppendText(String.Format("{0}", units & Environment.NewLine))
                currentDay += 1
            Else
                MessageBox.Show("Input must be between 0 and 5000")
            End If
        Else
            MessageBox.Show("Input must be numeric")
        End If

        If currentDay = 8 Then
            lblOutput.Text = String.Format("Average units per day: {0}", FormatNumber(totalUnits / 7, 2))
            txtUnits.ReadOnly = True
            btnEnter.Enabled = False
        Else
            lblDays.Text = String.Format("Day {0}", currentDay)
        End If
        txtUnits.Text = ""

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        currentDay = 1
        lblDays.Text = "Day 1"
        txtUnits.Text = ""
        txtEntryDisplay.Text = ""
        totalUnits = 0
        lblOutput.Text = ""
        txtUnits.ReadOnly = False
        btnEnter.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
