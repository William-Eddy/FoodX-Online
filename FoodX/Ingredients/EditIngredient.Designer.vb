<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditIngredient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditIngredient))
        Me.butDelete = New System.Windows.Forms.Button()
        Me.butSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtIngredient = New System.Windows.Forms.TextBox()
        Me.cmoUnit = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'butDelete
        '
        Me.butDelete.BackColor = System.Drawing.Color.Crimson
        Me.butDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.butDelete.FlatAppearance.BorderSize = 0
        Me.butDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butDelete.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butDelete.ForeColor = System.Drawing.Color.White
        Me.butDelete.Location = New System.Drawing.Point(169, 122)
        Me.butDelete.Name = "butDelete"
        Me.butDelete.Size = New System.Drawing.Size(121, 22)
        Me.butDelete.TabIndex = 32
        Me.butDelete.Text = "Delete"
        Me.butDelete.UseVisualStyleBackColor = False
        '
        'butSave
        '
        Me.butSave.BackColor = System.Drawing.Color.SlateBlue
        Me.butSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.butSave.FlatAppearance.BorderSize = 0
        Me.butSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butSave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSave.ForeColor = System.Drawing.Color.White
        Me.butSave.Location = New System.Drawing.Point(23, 122)
        Me.butSave.Name = "butSave"
        Me.butSave.Size = New System.Drawing.Size(121, 22)
        Me.butSave.TabIndex = 30
        Me.butSave.Text = "Save"
        Me.butSave.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Quantity:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(83, 54)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(49, 20)
        Me.txtQuantity.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Ingredient:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Price:"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(83, 81)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(61, 20)
        Me.txtPrice.TabIndex = 3
        '
        'txtIngredient
        '
        Me.txtIngredient.Location = New System.Drawing.Point(83, 25)
        Me.txtIngredient.Name = "txtIngredient"
        Me.txtIngredient.Size = New System.Drawing.Size(181, 20)
        Me.txtIngredient.TabIndex = 0
        '
        'cmoUnit
        '
        Me.cmoUnit.FormattingEnabled = True
        Me.cmoUnit.Items.AddRange(New Object() {"Unit", "g", "ml"})
        Me.cmoUnit.Location = New System.Drawing.Point(138, 53)
        Me.cmoUnit.Name = "cmoUnit"
        Me.cmoUnit.Size = New System.Drawing.Size(51, 21)
        Me.cmoUnit.TabIndex = 2
        '
        'EditIngredient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 162)
        Me.Controls.Add(Me.cmoUnit)
        Me.Controls.Add(Me.txtIngredient)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.butDelete)
        Me.Controls.Add(Me.butSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditIngredient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Ingredient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents butDelete As Button
    Friend WithEvents butSave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtIngredient As TextBox
    Friend WithEvents cmoUnit As ComboBox
End Class
