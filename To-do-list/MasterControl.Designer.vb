<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterControl))
        Me.add = New System.Windows.Forms.Button()
        Me.search = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Blicense = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout
        '
        'add
        '
        Me.add.Location = New System.Drawing.Point(54, 121)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(100, 30)
        Me.add.TabIndex = 0
        Me.add.Text = "Add Task"
        Me.ToolTip1.SetToolTip(Me.add, "Adds a new task")
        Me.add.UseVisualStyleBackColor = true
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(261, 121)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(100, 30)
        Me.search.TabIndex = 1
        Me.search.Text = "Search"
        Me.ToolTip1.SetToolTip(Me.search, "Searches a Task by Taking credentials")
        Me.search.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!)
        Me.Label1.Location = New System.Drawing.Point(133, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "To-Do List"
        '
        'Blicense
        '
        Me.Blicense.Location = New System.Drawing.Point(150, 211)
        Me.Blicense.Name = "Blicense"
        Me.Blicense.Size = New System.Drawing.Size(100, 27)
        Me.Blicense.TabIndex = 3
        Me.Blicense.Text = "Licence"
        Me.ToolTip1.SetToolTip(Me.Blicense, "License ")
        Me.Blicense.UseVisualStyleBackColor = true
        '
        'Timer1
        '
        Me.Timer1.Enabled = true
        Me.Timer1.Interval = 900000
        '
        'MasterControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 263)
        Me.Controls.Add(Me.Blicense)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.add)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "MasterControl"
        Me.Text = "To-Do-List"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents add As System.Windows.Forms.Button
    Friend WithEvents search As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Blicense As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
