Imports System.IO
Public Class MasterControl
    ' opens AddForm.vb and hides MasterControl.vb
    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        Me.Hide()
        Dim AddForm As New AddForm 'creating instance of form
        AddForm.Show()
    End Sub

    ' opens SearchForm.vb and hides MasterControl.vb
    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        Me.Hide()
        Dim searchform As New SearchForm
        searchform.Show()
    End Sub

    'closes MasterControl on clicking close button
    Private Sub MasterControl_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit() 'stops all the matercontrol pages and closes the application
    End Sub

    'opens license 
    Private Sub Blicense_Click(sender As Object, e As EventArgs) Handles Blicense.Click
        Dim AddForm As New license
        AddForm.ShowDialog() ' shows the license as dialog box
    End Sub

    
    Private Sub MasterControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(100, 100) 'positioning the master control page
        Timer1.Enabled = True 'starting the timer

    End Sub


    ' gives the notification to the user about tasks in every 15 minutes 
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim dir As String
        dir = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) 'creating the path for storage
        dir = Path.Combine(dir, "file.txt") 'creating the file

        ' file missing error handling  
        If File.Exists(dir) Then



            Dim caseq As Boolean = False

            Dim mydate As Date        'to store the tasks date
            Dim final As String = "" 'string to store all the due tasks

            For Each line As String In System.IO.File.ReadAllLines("list.txt")
                'splits the description and date/time
                Dim flds() As String = line.Split(",")
                mydate = CDate(Trim(flds(1)))
                If mydate.Date = Date.Now.Date Then 'comapring date
                    If mydate.Hour = Date.Now.Hour Then 'comaparing hour 
                        final = final & flds(0) & "," 'final string consisting of all tasks
                        caseq = True
                    End If
                End If

            Next
            If caseq = True Then
                'Notification to the user
                MessageBox.Show(final & " are tasks scheduled to be done today", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If
    End Sub
End Class



'Software Lab project 
