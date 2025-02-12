Public Class Form7
    Dim AMOUNT As Integer
    Dim CHANGE As Integer = 0
    Public list As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AMOUNT = CInt(TextBox2.Text)
        Dim total As Integer = CInt(TextBox1.Text)
        CHANGE = AMOUNT - total
        TextBox3.Text = CHANGE.ToString()
        If CHANGE >= 0 Then
            MsgBox("THANK YOU FOR PURCHASING")
        Else
            MsgBox("NOT ENOUGH MONEY")
            TextBox2.Text = ""
            TextBox3.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        TextBox2.Text = ""
        TextBox3.Text = ""
        Me.Hide()
        Form1.Show()
    End Sub
End Class