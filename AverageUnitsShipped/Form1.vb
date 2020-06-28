''' <summary>
''' AverageUnitsShipped
''' Author: Spencer Evans 100777371
''' Date: 2020-06-07
''' Description: This application calculates the weekly average units shipped for 3 employees and overall average
''' units shipped for the company.
'''
''' </summary>

Public Class frmAverageUnitsShipped
    Dim day As Integer = 1          ' tracks the day that data is being input for
    Dim d As Integer                ' array index
    Dim employee As Integer = 1     ' Tracks the employee that data is being input for
    Dim emp As Integer              ' array index
    Dim units(2, 6) As Integer      ' 2D array that stores the units shipped per day per employee
    Dim averages(3) As Double       ' Stores the weekly average shipped units for each employee
    Dim averagesTotal As Double = 0 ' Sum of employee averages for overall company average calculation

    ''' <summary>
    ''' Event handler for "Enter" button click. Input is validated and displayed in the appropriate textbox.
    ''' Averages for each employee and displayed in their respective labels. The overall average is also displayed.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        emp = employee - 1
        d = day - 1

        ' Sets the font style to bold for the employee that data is being entered for
        If employee = 1 Then
            lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Bold)
            lblEmployee2.Font = New Font(lblEmployee2.Font, FontStyle.Regular)
            lblEmployee3.Font = New Font(lblEmployee3.Font, FontStyle.Regular)
        ElseIf employee = 2 Then
            lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Regular)
            lblEmployee2.Font = New Font(lblEmployee2.Font, FontStyle.Bold)
            lblEmployee3.Font = New Font(lblEmployee3.Font, FontStyle.Regular)
        ElseIf employee = 3 Then
            lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Regular)
            lblEmployee2.Font = New Font(lblEmployee2.Font, FontStyle.Regular)
            lblEmployee3.Font = New Font(lblEmployee3.Font, FontStyle.Bold)
        End If

        ' Data validation 
        ' Only whole number input is allowed. Valid inputs are stored in units array
        If Integer.TryParse(txtUnits.Text, units(emp, d)) Then
            ' Inputs must be between 0 and 5000, inclusive
            If units(emp, d) >= 0 And units(emp, d) <= 5000 Then
                ' If input is valid display is employee's textbox and increments day
                If employee = 1 Then
                    txtEmployee1.AppendText(String.Format("{0}", units(emp, d) & Environment.NewLine))
                ElseIf employee = 2 Then
                    txtEmployee2.AppendText(String.Format("{0}", units(emp, d) & Environment.NewLine))
                Else
                    txtEmployee3.AppendText(String.Format("{0}", units(emp, d) & Environment.NewLine))
                End If
                day += 1
            Else
                ' Error message for out of range input
                MessageBox.Show("Input must be between 0 and 5000")
            End If
        Else
            ' Error message for non-numeric input
            MessageBox.Show("Input must be numeric")
        End If

        ' Outputs averages to appropriate textboxes
        ' Final average is only calculated once input is made for third employee on after final day
        If day = 8 And employee = 3 Then
            ' Sums all inputs for employee 3
            For i As Integer = 0 To 6
                averages(2) += units(2, i)
            Next
            averages(2) = averages(2) / 7
            ' Employee 3 weekly average output
            lblEmp3Average.Text = String.Format("Average: {0}", FormatNumber(averages(2), 2))
            ' Sums all averages
            For i As Integer = 0 To 2
                averagesTotal += averages(i)
            Next
            ' Overall average output
            lblFinalAverage.Text = String.Format("Average units per day: {0}", FormatNumber(averagesTotal / 3, 2))
            txtUnits.ReadOnly = True ' Disables input
            btnEnter.Enabled = False ' Disables enter button
            ' After final day for employees 1 and 2 the averages are calculated and displayed
        ElseIf day = 8 Then
            If employee = 1 Then
                ' Sums all inputs for employee 1
                For i As Integer = 0 To 6
                    averages(0) += units(0, i)
                Next
                averages(0) = averages(0) / 7
                ' Employee 1 weekly average output
                lblEmp1Average.Text = String.Format("Average: {0}", FormatNumber(averages(0), 2))
            ElseIf employee = 2 Then
                ' Sums all inputs for employee 2
                For i As Integer = 0 To 6
                    averages(1) += units(1, i)
                Next
                averages(1) = averages(1) / 7
                ' Employee 2 weekly average output
                lblEmp2Average.Text = String.Format("Average: {0}", FormatNumber(averages(1), 2))
            End If
            employee += 1 ' Proceed to next employee after output is displayed
            day = 1 ' Day reset to 1 after average is displayed
        Else
            ' Updates "Day" label
            lblDays.Text = String.Format("Day {0}", day)
        End If
        'Clears input textbox
        txtUnits.Text = ""

    End Sub

    ''' <summary>
    ''' Event handler for "Reset" button
    ''' Clears all input and output from the form and re-enables user input
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        day = 1
        employee = 1
        For i As Integer = 0 To 2
            averages(i) = 0
        Next
        averagesTotal = 0
        lblDays.Text = "Day 1"
        txtUnits.Text = ""
        txtEmployee1.Text = ""
        txtEmployee2.Text = ""
        txtEmployee3.Text = ""
        lblEmp1Average.Text = ""
        lblEmp2Average.Text = ""
        lblEmp3Average.Text = ""
        lblFinalAverage.Text = ""
        txtUnits.ReadOnly = False
        btnEnter.Enabled = True
        lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Bold)
        lblEmployee2.Font = New Font(lblEmployee2.Font, FontStyle.Regular)
        lblEmployee3.Font = New Font(lblEmployee3.Font, FontStyle.Regular)
    End Sub

    ''' <summary>
    ''' Event handler for "Exit" button
    ''' Closes the program
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
