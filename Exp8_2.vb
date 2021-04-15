Module Module1
    Private m_FormBackgroundColor As Color
    Public Property FormBackgroundColor As Color
        Get
            Return m_FormBackgroundColor
        End Get
        Set(value As Color)
            m_FormBackgroundColor = value
            For Each Frm As Form In Application.OpenForms
                Frm.BackColor = m_FormBackgroundColor
            Next
        End Set
    End Property
End Module
Public Class Exp8_2
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged

    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged, RadioButton5.CheckedChanged, RadioButton6.CheckedChanged, RadioButton7.CheckedChanged
        If (RadioButton1.Checked) Then
            Label1.ForeColor = Color.Red
            Label1.Font = New Font("Papyrus", 16, FontStyle.Bold)
        ElseIf (RadioButton2.Checked) Then
            Label1.ForeColor = Color.Orange
            Label1.Font = New Font("Poor Richard", 16, FontStyle.Bold)
        ElseIf (RadioButton3.Checked) Then
            Label1.ForeColor = Color.Yellow
            Label1.Font = New Font("Vivaldi", 16, FontStyle.Bold)
        ElseIf (RadioButton4.Checked) Then
            Label1.ForeColor = Color.Green
            Label1.Font = New Font("Cooper", 16, FontStyle.Bold)
        ElseIf (RadioButton5.Checked) Then
            Label1.ForeColor = Color.Blue
            Label1.Font = New Font("Viner Hand ITC", 16, FontStyle.Bold)
        ElseIf (RadioButton6.Checked) Then
            Label1.ForeColor = Color.Indigo
            Label1.Font = New Font("Castellar", 16, FontStyle.Bold)
        ElseIf (RadioButton7.Checked) Then
            Label1.ForeColor = Color.Violet
            Label1.Font = New Font("Dubai", 16, FontStyle.Bold)
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.BackColor = FormBackgroundColor
    End Sub
    Private Sub bgcblue_Click(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged, RadioButton5.CheckedChanged, RadioButton6.CheckedChanged, RadioButton7.CheckedChanged
        If (RadioButton1.Checked) Then
            FormBackgroundColor = Color.Green
        ElseIf (RadioButton2.Checked) Then
            FormBackgroundColor = Color.Blue
        ElseIf (RadioButton3.Checked) Then
            FormBackgroundColor = Color.Violet
        ElseIf (RadioButton4.Checked) Then
            FormBackgroundColor = Color.Red
        ElseIf (RadioButton5.Checked) Then
            FormBackgroundColor = Color.Orange
        ElseIf (RadioButton6.Checked) Then
            FormBackgroundColor = Color.Gold
        ElseIf (RadioButton7.Checked) Then
            FormBackgroundColor = Color.Yellow
        End If
    End Sub
End Class

