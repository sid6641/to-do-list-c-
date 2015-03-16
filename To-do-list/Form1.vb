Public Class Form1

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        Me.Hide()
        Dim AddForm As New Form2
        AddForm.Show()
        
    End Sub

    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        Me.Hide()
        Dim searchform As New Form3
        searchform.Show()
    End Sub
End Class
