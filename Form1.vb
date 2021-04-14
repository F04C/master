Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged
        If (RadioButton1.Checked) Then
            Button1.BackColor = Color.Red
        ElseIf (RadioButton2.Checked) Then
            Button1.BackColor = Color.Blue
        ElseIf (RadioButton3.Checked) Then
            Button1.BackColor = Color.Green
        End If
    End Sub
End Class
