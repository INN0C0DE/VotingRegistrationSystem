<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PLNTXT = New System.Windows.Forms.ComboBox()
        Me.POSITION = New System.Windows.Forms.ComboBox()
        Me.CFNTXT = New System.Windows.Forms.TextBox()
        Me.CNTXT = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DELETE_BTN = New System.Windows.Forms.Button()
        Me.UPDATE_BTN = New System.Windows.Forms.Button()
        Me.ADD_BTN = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PLNTXT)
        Me.GroupBox2.Controls.Add(Me.POSITION)
        Me.GroupBox2.Controls.Add(Me.CFNTXT)
        Me.GroupBox2.Controls.Add(Me.CNTXT)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 198)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(334, 189)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CANDIDATE:"
        '
        'PLNTXT
        '
        Me.PLNTXT.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PLNTXT.FormattingEnabled = True
        Me.PLNTXT.Items.AddRange(New Object() {"1", "2", "3"})
        Me.PLNTXT.Location = New System.Drawing.Point(158, 133)
        Me.PLNTXT.Name = "PLNTXT"
        Me.PLNTXT.Size = New System.Drawing.Size(163, 31)
        Me.PLNTXT.TabIndex = 21
        '
        'POSITION
        '
        Me.POSITION.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POSITION.FormattingEnabled = True
        Me.POSITION.Items.AddRange(New Object() {"President", "Vice President", "Secretary", "Treasurer", "Auditor", "Public Relation Officer", "1st year Representative", "2nd year Representative", "3rd year Representative"})
        Me.POSITION.Location = New System.Drawing.Point(158, 96)
        Me.POSITION.Name = "POSITION"
        Me.POSITION.Size = New System.Drawing.Size(163, 31)
        Me.POSITION.TabIndex = 20
        '
        'CFNTXT
        '
        Me.CFNTXT.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CFNTXT.Location = New System.Drawing.Point(158, 63)
        Me.CFNTXT.Name = "CFNTXT"
        Me.CFNTXT.Size = New System.Drawing.Size(163, 27)
        Me.CFNTXT.TabIndex = 19
        '
        'CNTXT
        '
        Me.CNTXT.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CNTXT.Location = New System.Drawing.Point(158, 30)
        Me.CNTXT.Name = "CNTXT"
        Me.CNTXT.Size = New System.Drawing.Size(163, 27)
        Me.CNTXT.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 23)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Party list Number:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 23)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Position:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 23)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Full Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 23)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Candidate Number:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(453, 353)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 34)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.ListView1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(12, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(529, 180)
        Me.ListView1.TabIndex = 34
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Candidate No."
        Me.ColumnHeader8.Width = 105
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Full Name"
        Me.ColumnHeader9.Width = 194
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Position"
        Me.ColumnHeader10.Width = 141
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Party list No."
        Me.ColumnHeader11.Width = 90
        '
        'DELETE_BTN
        '
        Me.DELETE_BTN.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DELETE_BTN.Location = New System.Drawing.Point(388, 291)
        Me.DELETE_BTN.Name = "DELETE_BTN"
        Me.DELETE_BTN.Size = New System.Drawing.Size(125, 34)
        Me.DELETE_BTN.TabIndex = 33
        Me.DELETE_BTN.Text = "DELETE"
        Me.DELETE_BTN.UseVisualStyleBackColor = True
        '
        'UPDATE_BTN
        '
        Me.UPDATE_BTN.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UPDATE_BTN.Location = New System.Drawing.Point(388, 252)
        Me.UPDATE_BTN.Name = "UPDATE_BTN"
        Me.UPDATE_BTN.Size = New System.Drawing.Size(125, 34)
        Me.UPDATE_BTN.TabIndex = 32
        Me.UPDATE_BTN.Text = "UPDATE"
        Me.UPDATE_BTN.UseVisualStyleBackColor = True
        '
        'ADD_BTN
        '
        Me.ADD_BTN.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADD_BTN.Location = New System.Drawing.Point(388, 212)
        Me.ADD_BTN.Name = "ADD_BTN"
        Me.ADD_BTN.Size = New System.Drawing.Size(125, 34)
        Me.ADD_BTN.TabIndex = 31
        Me.ADD_BTN.Text = "ADD"
        Me.ADD_BTN.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 394)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.DELETE_BTN)
        Me.Controls.Add(Me.UPDATE_BTN)
        Me.Controls.Add(Me.ADD_BTN)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VOTING REGISTRATION SYSTEM"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PLNTXT As System.Windows.Forms.ComboBox
    Friend WithEvents POSITION As System.Windows.Forms.ComboBox
    Friend WithEvents CFNTXT As System.Windows.Forms.TextBox
    Friend WithEvents CNTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DELETE_BTN As System.Windows.Forms.Button
    Friend WithEvents UPDATE_BTN As System.Windows.Forms.Button
    Friend WithEvents ADD_BTN As System.Windows.Forms.Button
End Class
