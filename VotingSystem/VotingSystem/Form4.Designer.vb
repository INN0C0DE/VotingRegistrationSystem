<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PLNAMETXT = New System.Windows.Forms.TextBox()
        Me.PLN2TXT = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.DELETE_BTN = New System.Windows.Forms.Button()
        Me.UPDATE_BTN = New System.Windows.Forms.Button()
        Me.ADD_BTN = New System.Windows.Forms.Button()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PLNAMETXT)
        Me.GroupBox3.Controls.Add(Me.PLN2TXT)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(13, 198)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(384, 115)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PARTY LIST:"
        '
        'PLNAMETXT
        '
        Me.PLNAMETXT.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PLNAMETXT.Location = New System.Drawing.Point(157, 65)
        Me.PLNAMETXT.Name = "PLNAMETXT"
        Me.PLNAMETXT.Size = New System.Drawing.Size(221, 27)
        Me.PLNAMETXT.TabIndex = 24
        '
        'PLN2TXT
        '
        Me.PLN2TXT.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PLN2TXT.Location = New System.Drawing.Point(157, 32)
        Me.PLN2TXT.Name = "PLN2TXT"
        Me.PLN2TXT.Size = New System.Drawing.Size(221, 27)
        Me.PLN2TXT.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(18, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 23)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Party list Name:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 23)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Party list Number:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(306, 376)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 34)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(12, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(384, 180)
        Me.ListView1.TabIndex = 39
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'DELETE_BTN
        '
        Me.DELETE_BTN.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DELETE_BTN.Location = New System.Drawing.Point(266, 319)
        Me.DELETE_BTN.Name = "DELETE_BTN"
        Me.DELETE_BTN.Size = New System.Drawing.Size(125, 34)
        Me.DELETE_BTN.TabIndex = 38
        Me.DELETE_BTN.Text = "DELETE"
        Me.DELETE_BTN.UseVisualStyleBackColor = True
        '
        'UPDATE_BTN
        '
        Me.UPDATE_BTN.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UPDATE_BTN.Location = New System.Drawing.Point(141, 319)
        Me.UPDATE_BTN.Name = "UPDATE_BTN"
        Me.UPDATE_BTN.Size = New System.Drawing.Size(125, 34)
        Me.UPDATE_BTN.TabIndex = 37
        Me.UPDATE_BTN.Text = "UPDATE"
        Me.UPDATE_BTN.UseVisualStyleBackColor = True
        '
        'ADD_BTN
        '
        Me.ADD_BTN.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADD_BTN.Location = New System.Drawing.Point(16, 319)
        Me.ADD_BTN.Name = "ADD_BTN"
        Me.ADD_BTN.Size = New System.Drawing.Size(125, 34)
        Me.ADD_BTN.TabIndex = 36
        Me.ADD_BTN.Text = "ADD"
        Me.ADD_BTN.UseVisualStyleBackColor = True
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Party list No."
        Me.ColumnHeader1.Width = 158
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Partly list Name"
        Me.ColumnHeader2.Width = 221
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 416)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.DELETE_BTN)
        Me.Controls.Add(Me.UPDATE_BTN)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ADD_BTN)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VOTING REGISTRATION SYSTEM"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PLNAMETXT As System.Windows.Forms.TextBox
    Friend WithEvents PLN2TXT As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DELETE_BTN As System.Windows.Forms.Button
    Friend WithEvents UPDATE_BTN As System.Windows.Forms.Button
    Friend WithEvents ADD_BTN As System.Windows.Forms.Button
End Class
