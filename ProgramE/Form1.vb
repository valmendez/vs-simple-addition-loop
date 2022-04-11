Public Class Form1
    Private Sub btnGetAnswer_Click(sender As Object, e As EventArgs) Handles btnGetAnswer.Click
        Dim num As Integer = 2

        Do

            ListBox1.Items.Add(num & "    " & num + 2 & "    " & num + 4 & "    " & num + 6)
            num = 10
            ListBox1.Items.Add(num & " " & num + 2 & " " & num + 4 & " " & num + 6)
            num = 18
            ListBox1.Items.Add(num & " " & num + 2 & " " & num + 4 & " " & num + 6)
            num = 26
            ListBox1.Items.Add(num & " " & num + 2 & " " & num + 4 & " " & num + 6)

        Loop Until (num <= 32)

        '2 4 6 8
        '10 12 14 16
        '18 20 22 24
        '26 28 30 32

    End Sub
End Class
