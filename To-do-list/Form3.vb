Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        searchdate.Value = Date.Now
    End Sub

    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Close()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Dim AddForm As New Form1
        AddForm.Show()
    End Sub
    Private Structure tasks
        Public name As String
        Public taskdate As Date
    End Structure

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        Dim mylist(0) As tasks
        Dim num As Integer = 0
        For Each line As String In System.IO.File.ReadAllLines("F:\list.txt")
            Dim flds() As String = line.Split(",")
            ReDim Preserve mylist(num + 1)
            mylist(num).name = flds(0)
            mylist(num).taskdate = CDate(flds(1))
            num += 1
            MessageBox.Show(flds(0), "title")

        Next
        For Each item In mylist
            Listtasknames.Items.Add(item.name)
            'Listtasknames.Items.Add("google")
        Next
        Dim finaldate As Date
        finaldate = searchdate.Value

        ' For Each item In listtask
        'show them in the list if before that date 
        'Next
    End Sub
End Class