Public Class Form2

    Dim ROG7 As Integer
    Dim PBANK As Integer = 2000
    Dim COOLER As Integer = 1000
    Dim PCASE As Integer = 600
    Dim BACKPACK As Integer = 1200
    Dim HEADSET As Integer = 1500
    Public TOTAL As Integer

    Public Function GetTotal(ByVal total As Integer)
        Form7.TextBox1.Text = total
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form7.list = Form7.ListBox1.Items.Add("ROG PHONE 7 | 256GB")
        ROG7 = 50995
        TOTAL = ROG7 ' Base price

        If CheckBox1.Checked Then
            TOTAL += PBANK
            Form7.list = Form7.ListBox1.Items.Add("   + POWER BANK  P" & PBANK)
        End If
        If CheckBox2.Checked Then
            TOTAL += COOLER
            Form7.list = Form7.ListBox1.Items.Add("   + PHONE CASE P" & COOLER)
        End If
        If CheckBox3.Checked Then
            TOTAL += PCASE
            Form7.list = Form7.ListBox1.Items.Add("   + PHONE COOLER P" & PCASE)
        End If
        If CheckBox4.Checked Then
            TOTAL += BACKPACK
            Form7.list = Form7.ListBox1.Items.Add("   + BACKPACK P" & BACKPACK)
        End If
        If CheckBox5.Checked Then
            TOTAL += HEADSET
            Form7.list = Form7.ListBox1.Items.Add("   + HEADSET P" & HEADSET)
        End If

        GetTotal(TOTAL)

        Me.Hide()
        Form7.Show()

    End Sub
End Class