Public Class Form1
    Dim cashier_hourly_rate As String
    Dim cashier_hourly_rate_text As Single
    Dim scrollbar As Integer
    Dim total_number_of_hour_pay As String
    Dim store_keeper_hourly_rate As String
    Dim total_number_of_hour_pay_for_store_keeper As String

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblHour_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHour.TextChanged

    End Sub

    Private Sub hsbHourd_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hsbHourd.Scroll
        scrollbar = hsbHourd.Value
        lblHour.Text = hsbHourd.Value.ToString


    End Sub

    Private Sub Optjob1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Optjob1.CheckedChanged
        cashier_hourly_rate = Optjob1.Text
       





    End Sub

    Private Sub lblClaimed_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClaimed.TextChanged

    End Sub

    Private Sub cmdClaimd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClaimd.Click
        cashier_hourly_rate = 7.5
        total_number_of_hour_pay = cashier_hourly_rate * hsbHourd.Value.ToString
        lblClaimed.Text = "You have worked " & lblHour.Text & " hours today" & vbCrLf & "Your claime is $" & total_number_of_hour_pay

        If Optjob2.Checked = True Then
            store_keeper_hourly_rate = 9.8
            total_number_of_hour_pay = store_keeper_hourly_rate * hsbHourd.Value.ToString
            lblClaimed.Text = "You have worked " & lblHour.Text & " hours today" & vbCrLf & "Your claime is $" & total_number_of_hour_pay

        End If


    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        lblClaimed.Text = ""
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        End
    End Sub

    Private Sub Optjob2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Optjob2.CheckedChanged
        store_keeper_hourly_rate = Optjob2.Text
    End Sub
End Class
