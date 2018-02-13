Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqr() As Integer
        Dim i, n As Integer
        n = InputBox("Enter the size of array")
        ListBox1.Items.Clear()
        For i = 0 To n
            ReDim sqr(i)
            ListBox1.Items.Add(sqr(i))
        Next
    End Sub
End Class
