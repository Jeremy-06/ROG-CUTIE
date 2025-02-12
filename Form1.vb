Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioButton1.Checked = True Then
            Me.Hide()
            Form2.Show()
        ElseIf RadioButton2.Checked = True Then
            Me.Hide()
            Form3.Show()
        ElseIf RadioButton3.Checked = True Then
            Me.Hide()
            Form4.Show()
        ElseIf RadioButton4.Checked = True Then
            Me.Hide()
            Form5.Show()
        ElseIf RadioButton5.Checked = True Then
            Me.Hide()
            Form6.Show()
        Else
            MsgBox("PLEASE SELECT A UNIT")
        End If
    End Sub
End Class
