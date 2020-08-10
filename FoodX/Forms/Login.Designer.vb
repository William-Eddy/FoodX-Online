<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.imgProfilePic = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.imgProfilePicSelected = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        CType(Me.imgProfilePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgProfilePicSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(228, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Eat better."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(474, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(277, 56)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Feel better."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(401, 362)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hello William"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'imgProfilePic
        '
        Me.imgProfilePic.Image = CType(resources.GetObject("imgProfilePic.Image"), System.Drawing.Image)
        Me.imgProfilePic.Location = New System.Drawing.Point(389, 218)
        Me.imgProfilePic.Name = "imgProfilePic"
        Me.imgProfilePic.Size = New System.Drawing.Size(183, 141)
        Me.imgProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgProfilePic.TabIndex = 3
        Me.imgProfilePic.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(918, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 32)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "×"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(406, 487)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(153, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'imgProfilePicSelected
        '
        Me.imgProfilePicSelected.Image = CType(resources.GetObject("imgProfilePicSelected.Image"), System.Drawing.Image)
        Me.imgProfilePicSelected.Location = New System.Drawing.Point(389, 218)
        Me.imgProfilePicSelected.Name = "imgProfilePicSelected"
        Me.imgProfilePicSelected.Size = New System.Drawing.Size(183, 141)
        Me.imgProfilePicSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgProfilePicSelected.TabIndex = 8
        Me.imgProfilePicSelected.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(960, 550)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.imgProfilePic)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.imgProfilePicSelected)
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        CType(Me.imgProfilePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgProfilePicSelected, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents imgProfilePic As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents imgProfilePicSelected As PictureBox
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
End Class
