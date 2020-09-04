<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scanIngredientsIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scanIngredientsIn))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.lvIngredients = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.butReconcile = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtScanIn = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtTotalPrice)
        Me.GroupBox4.Controls.Add(Me.lvIngredients)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(20, 23)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(334, 267)
        Me.GroupBox4.TabIndex = 72
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ingredients"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPrice.Location = New System.Drawing.Point(62, 235)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(105, 19)
        Me.txtTotalPrice.TabIndex = 79
        Me.txtTotalPrice.Text = "£0.00"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(19, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 18)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Total: "
        '
        'butReconcile
        '
        Me.butReconcile.BackColor = System.Drawing.Color.SlateBlue
        Me.butReconcile.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.butReconcile.FlatAppearance.BorderSize = 0
        Me.butReconcile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butReconcile.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butReconcile.ForeColor = System.Drawing.Color.White
        Me.butReconcile.Location = New System.Drawing.Point(17, 351)
        Me.butReconcile.Name = "butReconcile"
        Me.butReconcile.Size = New System.Drawing.Size(121, 22)
        Me.butReconcile.TabIndex = 74
        Me.butReconcile.Text = "Reconcile"
        Me.butReconcile.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SlateBlue
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(144, 351)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 22)
        Me.Button2.TabIndex = 75
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtScanIn
        '
        Me.txtScanIn.Location = New System.Drawing.Point(93, 311)
        Me.txtScanIn.Name = "txtScanIn"
        Me.txtScanIn.Size = New System.Drawing.Size(229, 20)
        Me.txtScanIn.TabIndex = 78
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(31, 313)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(56, 15)
        Me.Label42.TabIndex = 77
        Me.Label42.Text = "Barcode:"
        '
        'scanIngredientsIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 399)
        Me.Controls.Add(Me.txtScanIn)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.butReconcile)
        Me.Controls.Add(Me.GroupBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "scanIngredientsIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scan Ingredients"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents butReconcile As Button
    Friend WithEvents lvIngredients As ListView
    Friend WithEvents Button2 As Button
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtScanIn As TextBox
    Friend WithEvents Label42 As Label
End Class
