Imports System.IO
Public Class Form2


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker2.Value = Date.Now

    End Sub

    Private Structure tasks
        Public name As String
        Public taskdate As Date
    End Structure



    Private Sub add1_Click(sender As Object, e As EventArgs) Handles add1.Click
        'read text file and store in array of structs
        Dim currenttask As tasks
        currenttask.name = "today's Date"
        currenttask.taskdate = Date.Now

        Dim listtask() As tasks = {currenttask} 'just redim and things later 

        Dim newtask As tasks
        newtask.name = TextBox1.Text 'check string length to empty case
        newtask.taskdate = DateTimePicker2.Value
        ' MessageBox.Show(newtask.taskdate, "current time")

        ' add both things to file
        'den close the file 
        'add notification dat it has been added 
        'Dim mywriter As New StreamWriter("F:\list.txt")
        Dim finalstring As String
        finalstring = newtask.name & " , " & newtask.taskdate.ToString
        Dim path As String = "F:\list.txt"

        ' This text is added only once to the file.  
        If Not File.Exists(path) Then
            ' Create a file to write to. 
            Using sw As StreamWriter = File.CreateText(path)
                sw.WriteLine(finalstring)
            End Using
        Else

            ' This text is always added, making the file longer over time  
            ' if it is not deleted. 
            Using sw As StreamWriter = File.AppendText(path)
                sw.WriteLine(finalstring)
            End Using
        End If
        ' mywriter.WriteLine(finalstring)
        'MessageBox.Show(finalstring, "current time")
        'mywriter.Close()



    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Dim AddForm As New Form1
        AddForm.Show()
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Close()
    End Sub
End Class