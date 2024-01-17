Public Class Form1
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declaration of varaibles
        Dim height, weight, bmi As Double
        weight = Val(TextBox1.Text)
        height = Val(TextBox2.Text)

        bmi = weight / (height) ^ 2 'BMI formula

        TextBox3.Text = bmi

        If bmi < 18 Then
            TextBox4.Text = "You are underweight"
        ElseIf 18 <= bmi And bmi < 26 Then
            TextBox4.Text = "You are normal"
        Else
            TextBox4.Text = "You are overweight"
        End If

    End Sub
End Class
