Imports System.IO

Public Class AddForm
    ' set datetime to present date and time
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(100, 100) 'positions the box
        DateTimePicker2.Value = Date.Now
        comboPriority.SelectedIndex = 1 'set priority to moderate
    End Sub

    ' define a structure
    Private Structure tasks
        Public name As String
        Public taskdate As Date ' a date variable to store timestamp of task
        Public taskpriority As String
    End Structure


    'event handler for click button i.e adds the task to the list
    Private Sub add1_Click(sender As Object, e As EventArgs) Handles add1.Click

        ' empty string error handling
        If txtTask.Text = "" Then
            MessageBox.Show("Please add some Desciption", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            ' user input stored in 'tasks'
            Static Dim entrynumber As Integer = 1
            Dim newtask As tasks
            newtask.name = txtTask.Text
            newtask.taskdate = DateTimePicker2.Value
            newtask.taskpriority = comboPriority.Text

            ' string manipulation to write in file
            Dim finalstring As String
            finalstring = newtask.name & " , " & newtask.taskdate.ToString & " , " & newtask.taskpriority
            Dim dir As String
            dir = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) 'setting up the path for project
            dir = Path.Combine(dir, "file.txt")

            ' file missing error handling  
            If Not File.Exists(dir) Then
                ' Create a file to write to. 
                Using sw As StreamWriter = File.CreateText(dir) 'using streamwriter to write the file 
                    sw.WriteLine(finalstring)
                End Using
            Else

                ' append to the existing file
                Using sw As StreamWriter = File.AppendText(dir) 'using streamwriter to write the file 
                    sw.WriteLine(finalstring)
                End Using
            End If

            ' notification to user 
            txtTask.Text = ""
            notification.Text = entrynumber & " task(s) added"
            entrynumber += 1
        End If


    End Sub

    ' opens MasterControl.vb and hides AddForm.vb
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Dim AddForm As New MasterControl ' crating instance of the form
        AddForm.Show()
    End Sub


    'closes the app 
    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' close the hidden MasterControl
        MasterControl.Close()
    End Sub

    
End Class