<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class scanIngredientsIn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scanIngredientsIn))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lvIngredients = New System.Windows.Forms.ListView()
        Me.butReconcile = New System.Windows.Forms.Button()
        Me.butDelete = New System.Windows.Forms.Button()
        Me.txtScanIn = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.laserDisconnect = New System.Windows.Forms.Timer(Me.components)
        Me.barcodeLaser = New System.IO.Ports.SerialPort(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lvIngredients)
        Me.GroupBox4.Location = New System.Drawing.Point(20, 23)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(334, 248)
        Me.GroupBox4.TabIndex = 72
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ingredients"
        '
        'lvIngredients
        '
        Me.lvIngredients.HideSelection = False
        Me.lvIngredients.Location = New System.Drawing.Point(19, 27)
        Me.lvIngredients.Name = "lvIngredients"
        Me.lvIngredients.Size = New System.Drawing.Size(291, 194)
        Me.lvIngredients.TabIndex = 70
        Me.lvIngredients.UseCompatibleStateImageBehavior = False
        '
        'butReconcile
        '
        Me.butReconcile.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.butReconcile.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.butReconcile.FlatAppearance.BorderSize = 0
        Me.butReconcile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butReconcile.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butReconcile.ForeColor = System.Drawing.Color.White
        Me.butReconcile.Location = New System.Drawing.Point(20, 324)
        Me.butReconcile.Name = "butReconcile"
        Me.butReconcile.Size = New System.Drawing.Size(121, 22)
        Me.butReconcile.TabIndex = 74
        Me.butReconcile.Text = "Reconcile"
        Me.butReconcile.UseVisualStyleBackColor = False
        '
        'butDelete
        '
        Me.butDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.butDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.butDelete.FlatAppearance.BorderSize = 0
        Me.butDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butDelete.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butDelete.ForeColor = System.Drawing.Color.White
        Me.butDelete.Location = New System.Drawing.Point(147, 324)
        Me.butDelete.Name = "butDelete"
        Me.butDelete.Size = New System.Drawing.Size(86, 22)
        Me.butDelete.TabIndex = 75
        Me.butDelete.Text = "Delete"
        Me.butDelete.UseVisualStyleBackColor = False
        '
        'txtScanIn
        '
        Me.txtScanIn.Location = New System.Drawing.Point(96, 284)
        Me.txtScanIn.Name = "txtScanIn"
        Me.txtScanIn.Size = New System.Drawing.Size(229, 20)
        Me.txtScanIn.TabIndex = 78
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(34, 286)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(56, 15)
        Me.Label42.TabIndex = 77
        Me.Label42.Text = "Barcode:"
        '
        'laserDisconnect
        '
        Me.laserDisconnect.Interval = 8000
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(268, 324)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 22)
        Me.Button1.TabIndex = 79
        Me.Button1.Text = "Manual"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'scanIngredientsIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 362)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtScanIn)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.butDelete)
        Me.Controls.Add(Me.butReconcile)
        Me.Controls.Add(Me.GroupBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "scanIngredientsIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scan Ingredients"
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents butReconcile As Button
    Friend WithEvents lvIngredients As ListView
    Friend WithEvents butDelete As Button
    Friend WithEvents txtScanIn As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents laserDisconnect As Timer
    Friend WithEvents barcodeLaser As IO.Ports.SerialPort
    Friend WithEvents Button1 As Button
End Class
