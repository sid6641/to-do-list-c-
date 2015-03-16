Imports System.IO

Public Class SearchForm

    'setting the default positions and options
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(100, 100) 'setting the position
        ' set the defaults
        searchdate.Value = Date.Now
    End Sub

    ' close the MasterControl
    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MasterControl.Close()
    End Sub

    ' opens MasterControl.vb and hides SearchForm.vb
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Dim mc As New MasterControl 'creates an instance
        mc.Show()
    End Sub

    ' define a struct
    Private Structure tasks
        Public name As String
        Public taskdate As Date 'declaring date for storing timestamp
        Public taskpriority As String
    End Structure

    ' search a task before the date/time entered by the user in the txt file
    Private Function searchtask() As Integer
        Dim mylist(0) As tasks
        Dim num As Integer = 0
        ' clear the listview
        listView.Items.Clear()
        Dim dir As String
        dir = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) 'setting the path for the file to be read
        dir = Path.Combine(dir, "file.txt")

        ' read the text file line by line
        For Each line As String In System.IO.File.ReadAllLines(dir)
            ' splits the description and date/time
            Dim flds() As String = line.Split(",")
            ' redimension and preserve
            ReDim Preserve mylist(num)
            mylist(num).name = flds(0) ' the three splitted storage values
            mylist(num).taskdate = CDate(flds(1))
            mylist(num).taskpriority = flds(2)
            num += 1
        Next
        Dim finaldate As Date
        finaldate = searchdate.Value


        'sort according to ascending order
        Array.Sort(Of tasks)(mylist, Function(p2, p1) p2.taskdate.CompareTo(p1.taskdate))

        Dim i As ListViewItem
        For Each item In mylist
            ' error handling: empty string
            If item.name <> Nothing And item.name <> "" Then
                ' compare with the date given
                If item.taskdate <= finaldate Then
                    listView.BeginUpdate()

                    'adding tasks to listview according to different columns
                    i = listView.Items.Add(item.name)
                    i.SubItems.Add(item.taskdate)
                    i.SubItems.Add(item.taskpriority)
                    'updating the listview
                    listView.Update()
                    listView.EndUpdate()
                End If
            End If
        Next

        Return 1 'returning the defaut data type
    End Function

    ' delete the selected task from the file
    Private Function deletetask() As Integer
        Dim dir As String

        'setting the path for deleting the variable
        dir = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        dir = Path.Combine(dir, "file.txt")

        'read the list.txt items into mynum
        Dim mylist(0) As tasks
        Dim num As Integer = 0

        For Each line As String In System.IO.File.ReadAllLines(dir)
            Dim flds1() As String = line.Split(",")
            ReDim Preserve mylist(num)
            mylist(num).name = flds1(0)
            ' convert string to date(type)

            mylist(num).taskdate = CDate(flds1(1))
            mylist(num).taskpriority = flds1(2)
            num += 1
        Next

        Dim finallist(0) As tasks
        ' remove the selected task from finallist
        Dim str As String
        str = listView.SelectedItems(0).Text 'getting the value of selected index 

        For Each item In mylist
            If item.name <> Nothing And item.name <> "" Then
                If Trim(item.name) <> Trim(str) Then 'donot rewriting the selected index
                    'redimensioning the final array
                    ReDim Preserve finallist(num)

                    'adding the final interies
                    finallist(num).name = item.name
                    finallist(num).taskdate = item.taskdate
                    finallist(num).taskpriority = item.taskpriority
                    num += 1

                End If
            End If
        Next


        'again opening the writer and writing the files
        Dim mywriter As New StreamWriter(dir)
        Dim line1 As String
        For Each item In finallist
            If item.name <> Nothing And item.name <> "" Then
                line1 = item.name & "," & item.taskdate.ToString & "," & item.taskpriority
                mywriter.WriteLine(line1)
            End If
        Next
        ' close the file
        mywriter.Close()
        Return 1

    End Function


    'event handler for search button
    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        searchtask()
    End Sub

    'event handler for delete 
    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If MessageBox.Show("you really want to delete", "delete-warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then

            ' error handling: no task selected 
            If listView.SelectedItems.Count() = 0 Then
                MessageBox.Show("Please Select the task", " error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                deletetask() 'deleting the item 
                listView.Items.Clear() 'clearing the list
                searchtask() ' modifying the search
            End If
        End If
    End Sub


    'public variable to send the data 
    Public task_name As String = ""
    Public task_date As Date = Date.Now
    Public task_priority As String = ""


    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        ' check if any entry is selected
        If listView.SelectedItems.Count() = 0 Then
            MessageBox.Show("Please Select the task", " error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            ' saving data in variable to send to EditForm.vb

            task_name = listView.SelectedItems(0).Text
            task_date = listView.SelectedItems(0).SubItems(1).Text
            task_priority = listView.SelectedItems(0).SubItems(2).Text

            'deleting the edited task 
            deletetask()


            ' send data to EditForm.vb
            Dim AddForm As New editForm
            AddForm.namepass = task_name 'passing variables as properties
            AddForm.datepass = task_date
            AddForm.prioritypass = task_priority

            listView.Items.Clear()
            AddForm.ShowDialog()
            searchtask() 'modifying the search after closing of the edit form

        End If
    End Sub
End Class