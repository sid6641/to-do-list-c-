<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddForm))
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTask = New System.Windows.Forms.TextBox()
        Me.add1 = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.notification = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.comboPriority = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "ddd,MMMM dd,yyyy hh:mm:ss tt"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(166, 32)
        Me.DateTimePicker2.MinDate = New Date(2015, 1, 10, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(249, 24)
        Me.DateTimePicker2.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.DateTimePicker2, "Sets Date And Time for the task")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(13, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Add Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(13, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Date And Time"
        '
        'txtTask
        '
        Me.txtTask.Location = New System.Drawing.Point(16, 90)
        Me.txtTask.Multiline = True
        Me.txtTask.Name = "txtTask"
        Me.txtTask.Size = New System.Drawing.Size(399, 65)
        Me.txtTask.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtTask, "Type the Task here")
        '
        'add1
        '
        Me.add1.Location = New System.Drawing.Point(16, 211)
        Me.add1.Name = "add1"
        Me.add1.Size = New System.Drawing.Size(125, 23)
        Me.add1.TabIndex = 6
        Me.add1.Text = "Add Task"
        Me.ToolTip1.SetToolTip(Me.add1, "Add Task")
        Me.add1.UseVisualStyleBackColor = True
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(285, 211)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(130, 23)
        Me.Back.TabIndex = 7
        Me.Back.Text = "Go Back"
        Me.ToolTip1.SetToolTip(Me.Back, "Go back to home page")
        Me.Back.UseVisualStyleBackColor = True
        '
        'notification
        '
        Me.notification.AutoSize = True
        Me.notification.Location = New System.Drawing.Point(13, 237)
        Me.notification.Name = "notification"
        Me.notification.Size = New System.Drawing.Size(0, 13)
        Me.notification.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(13, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Priority"
        '
        'comboPriority
        '
        Me.comboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboPriority.Items.AddRange(New Object() {"High", "Moderate", "Low"})
        Me.comboPriority.Location = New System.Drawing.Point(210, 175)
        Me.comboPriority.Name = "comboPriority"
        Me.comboPriority.Size = New System.Drawing.Size(205, 21)
        Me.comboPriority.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.comboPriority, "Sets the priority here")
        '
        'AddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 264)
        Me.Controls.Add(Me.comboPriority)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.notification)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.add1)
        Me.Controls.Add(Me.txtTask)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AddForm"
        Me.Text = "Add a Task"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTask As System.Windows.Forms.TextBox
    Friend WithEvents add1 As System.Windows.Forms.Button
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents notification As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents comboPriority As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
