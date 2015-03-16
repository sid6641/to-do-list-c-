Imports System.IO

Public Class editForm

    ' define a struct
    Private Structure tasks
        Public taskname As String
        Public taskdate As Date
        Public taskpriority As String
    End Structure

    Public namepass As String
    Public datepass As Date = Now
    Public prioritypass As String

    Private Sub edit123_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(100, 100)
        ' set text and date/time boxes to passed values
        tbName.Text = namepass
        edittask.Value = datepass

        'setting the combo box value ...on checking the passed variable value
        If Trim(prioritypass) = "High" Then
            comboPriority.SelectedIndex = 0
        ElseIf Trim(prioritypass) = "Moderate" Then
            comboPriority.SelectedIndex = 1
        Else
            comboPriority.SelectedIndex = 2
        End If
    End Sub


    ' write the modified task to the txt file 
    Private Sub label1_Click(sender As Object, e As EventArgs) Handles label1.Click

        Dim edit_string As String = tbName.Text
        Dim edit_date As Date = edittask.Value
        Dim edit_priority As String = comboPriority.Text

        ' error handeling: empty string error
        If edit_string = "" Then
            MessageBox.Show("Enter some description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim finalstring As String
            finalstring = edit_string & " , " & edit_date.ToString & " , " & edit_priority
            Dim dir As String
            dir = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) 'setting the path variable
            dir = Path.Combine(dir, "file.txt")

            ' error handling: file does not exist 
            If Not File.Exists(dir) Then
                ' Create a file to write to. 
                Using sw As StreamWriter = File.CreateText(dir)
                    sw.WriteLine(finalstring)
                End Using
            Else

                ' append the task to the txt file 
                Using sw As StreamWriter = File.AppendText(dir)
                    sw.WriteLine(finalstring)
                End Using
            End If
            Me.Close() 'closing the form on done button 
        End If
    End Sub

    
End Class