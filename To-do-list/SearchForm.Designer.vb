<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchdate = New System.Windows.Forms.DateTimePicker()
        Me.Search = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.listView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(9, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date And Time"
        '
        'searchdate
        '
        Me.searchdate.CustomFormat = "ddd,MMMM dd,yyyy hh:mm:ss tt"
        Me.searchdate.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.searchdate.Location = New System.Drawing.Point(127, 20)
        Me.searchdate.Name = "searchdate"
        Me.searchdate.Size = New System.Drawing.Size(334, 24)
        Me.searchdate.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.searchdate, "Sets the Date and Time for the task you want to search")
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(488, 20)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(75, 23)
        Me.Search.TabIndex = 3
        Me.Search.Text = "Search"
        Me.ToolTip1.SetToolTip(Me.Search, "Search")
        Me.Search.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Location = New System.Drawing.Point(234, 219)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(110, 23)
        Me.edit.TabIndex = 4
        Me.edit.Text = "Edit Task"
        Me.ToolTip1.SetToolTip(Me.edit, "edit task")
        Me.edit.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(16, 219)
        Me.Delete.MaximumSize = New System.Drawing.Size(110, 23)
        Me.Delete.MinimumSize = New System.Drawing.Size(110, 23)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(110, 23)
        Me.Delete.TabIndex = 5
        Me.Delete.Text = "Delete Task"
        Me.ToolTip1.SetToolTip(Me.Delete, "Delete task")
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(453, 219)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(110, 23)
        Me.Back.TabIndex = 6
        Me.Back.Text = "Go Back"
        Me.ToolTip1.SetToolTip(Me.Back, "Go back to home page")
        Me.Back.UseVisualStyleBackColor = True
        '
        'listView
        '
        Me.listView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.listView.Location = New System.Drawing.Point(16, 61)
        Me.listView.Name = "listView"
        Me.listView.Size = New System.Drawing.Size(547, 136)
        Me.listView.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.listView, "Displays the tasks,date and time,priorities")
        Me.listView.UseCompatibleStateImageBehavior = False
        Me.listView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Task"
        Me.ColumnHeader1.Width = 147
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Date And Time"
        Me.ColumnHeader2.Width = 174
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Priority"
        Me.ColumnHeader3.Width = 216
        '
        'SearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 270)
        Me.Controls.Add(Me.listView)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.searchdate)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SearchForm"
        Me.Text = "Don't Forget a Thing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents searchdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Search As System.Windows.Forms.Button
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents listView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
