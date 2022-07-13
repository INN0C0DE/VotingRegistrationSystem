<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menu_frm))
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.pb2 = New System.Windows.Forms.PictureBox()
        Me.pb3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.Color.MintCream
        Me.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pb1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.pb1.Image = CType(resources.GetObject("pb1.Image"), System.Drawing.Image)
        Me.pb1.Location = New System.Drawing.Point(22, 46)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(200, 200)
        Me.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb1.TabIndex = 0
        Me.pb1.TabStop = False
        '
        'pb2
        '
        Me.pb2.BackColor = System.Drawing.Color.MintCream
        Me.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pb2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.pb2.Image = CType(resources.GetObject("pb2.Image"), System.Drawing.Image)
        Me.pb2.Location = New System.Drawing.Point(237, 46)
        Me.pb2.Name = "pb2"
        Me.pb2.Size = New System.Drawing.Size(200, 200)
        Me.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb2.TabIndex = 1
        Me.pb2.TabStop = False
        '
        'pb3
        '
        Me.pb3.BackColor = System.Drawing.Color.MintCream
        Me.pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pb3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.pb3.Image = CType(resources.GetObject("pb3.Image"), System.Drawing.Image)
        Me.pb3.Location = New System.Drawing.Point(453, 46)
        Me.pb3.Name = "pb3"
        Me.pb3.Size = New System.Drawing.Size(200, 200)
        Me.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb3.TabIndex = 2
        Me.pb3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 247)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 42)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "VOTER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(259, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 42)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "CANDIDATE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(484, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 42)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "PARTY LIST"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(529, 313)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 34)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "LOG OUT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'menu_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(674, 359)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb3)
        Me.Controls.Add(Me.pb2)
        Me.Controls.Add(Me.pb1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "menu_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VOTING REGISTRATION SYSTEM"
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
    Friend WithEvents pb2 As System.Windows.Forms.PictureBox
    Friend WithEvents pb3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
