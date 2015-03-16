<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editForm))
        Me.edittask = New System.Windows.Forms.DateTimePicker()
        Me.label1 = New System.Windows.Forms.Button()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.comboPriority = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'edittask
        '
        Me.edittask.CustomFormat = "ddd,MMMM dd,yyyy hh:mm:ss tt"
        Me.edittask.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edittask.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.edittask.Location = New System.Drawing.Point(122, 37)
        Me.edittask.MinDate = New Date(2015, 1, 12, 0, 0, 0, 0)
        Me.edittask.Name = "edittask"
        Me.edittask.Size = New System.Drawing.Size(259, 24)
        Me.edittask.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.edittask, "sets date and time")
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(18, 215)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(125, 23)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Done Editing"
        Me.ToolTip1.SetToolTip(Me.label1, "Done editing")
        Me.label1.UseVisualStyleBackColor = True
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(18, 89)
        Me.tbName.Multiline = True
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(363, 65)
        Me.tbName.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.tbName, "Task you want to enter")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(15, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "add description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(15, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Date and Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(15, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Priority"
        '
        'comboPriority
        '
        Me.comboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboPriority.FormattingEnabled = True
        Me.comboPriority.Items.AddRange(New Object() {"High", "Moderate", "Low"})
        Me.comboPriority.Location = New System.Drawing.Point(177, 174)
        Me.comboPriority.Name = "comboPriority"
        Me.comboPriority.Size = New System.Drawing.Size(204, 21)
        Me.comboPriority.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.comboPriority, "Priority you want to set")
        '
        'editForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 263)
        Me.ControlBox = False
        Me.Controls.Add(Me.comboPriority)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.edittask)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "editForm"
        Me.Text = "Edit a Task"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents edittask As System.Windows.Forms.DateTimePicker
    Friend WithEvents label1 As System.Windows.Forms.Button
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents comboPriority As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
