'Program Name:Broadway Ticket Group Discount Program
'Author: City Hussen
'Date: 07/10/2022
'Purpose:This windows application computes the estimated cost of orchestra seating based on the
'         number of people coming and the following cost per Group size:Size 1-8 =$249 per person;
'         Size 9-12 =$219 per person;Size 13-24 =$199 per person and Size 25-99=$169 per person.

Public Class frmBroadwayTicket
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'The btnCalculate event handler calculates the estimated cost of
        ' ticket based on the number of person and group size.

        'Declaration Section
        Dim intSizeofPeople As Integer
        Dim intCostPerperson As Integer
        Dim intCostEstimate As Integer
        Dim intRadio1 As Integer = 249
        Dim intRadio2 As Integer = 219
        Dim intRadio3 As Integer = 199
        Dim intRadio4 As Integer = 169

        'Did user enter numeric value?
        If IsNumeric(txtNumber.Text) Then
            intSizeofPeople = Convert.ToInt32(txtNumber.Text)
            'Is Square Footage greater than zero
            If intSizeofPeople > 0 Then
                'Determine cost perSquare foot
                If Radio1.Checked Then
                    intCostPerperson = intRadio1
                ElseIf Radio2.Checked Then
                    intCostPerperson = intRadio2
                ElseIf Radio3.Checked Then
                    intCostPerperson = intRadio3
                ElseIf Radio4.Checked Then
                    intCostPerperson = intRadio4
                End If
                'Calculate and display the cost estimate 
                intCostEstimate = intSizeofPeople * intCostPerperson
                lblDisplaytotal.Text = intCostEstimate.ToString("C")
                If intSizeofPeople >= 100 Then
                    'Display error message if user entered more than 100 ticket value
                    MsgBox("Enter the Correct amount of People", , "Input Error")
                    txtNumber.Text = ""
                    txtNumber.Focus()

                End If

            Else
                'Display error message if user entered a negative value
                MsgBox("You entered " & intSizeofPeople.ToString() & " Enter a Positive Number ", , " Input Error")

                txtNumber.Text = ""
                txtNumber.Focus()
            End If

        Else
            'Display error message if user entered a non numeric value
            MsgBox("You entered a nun numeric value ", , " Input Error")

            txtNumber.Text = ""
            txtNumber.Focus()
        End If


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This event handler is executed when the user clicks the clear button.It 
        'clears the size number text box and the total cost,resets the radio
        'button with the Size 1-8 selected and sets the focus to the number of people text box.

        txtNumber.Clear()
        lblDisplaytotal.Text = ""
        Radio1.Checked = True
        Radio2.Checked = False
        Radio3.Checked = False
        Radio4.Checked = False
        txtNumber.Focus()
    End Sub

    Private Sub frmBroadwayTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This event handler is executed when the form is located at the start of
        'the program.It sets the focus to the number of peoplw text box and 
        'clears the cost of ticket label.

        txtNumber.Focus()
        lblDisplaytotal.Text = ""
    End Sub
End Class

