<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEditMealIngredient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddEditMealIngredient))
        Me.butSave = New System.Windows.Forms.Button()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.cbxIngredientList = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.butAddNewIngredient = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'butSave
        '
        Me.butSave.BackColor = System.Drawing.Color.SlateBlue
        Me.butSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.butSave.FlatAppearance.BorderSize = 0
        Me.butSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butSave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSave.ForeColor = System.Drawing.Color.White
        Me.butSave.Location = New System.Drawing.Point(28, 87)
        Me.butSave.Name = "butSave"
        Me.butSave.Size = New System.Drawing.Size(121, 22)
        Me.butSave.TabIndex = 15
        Me.butSave.Text = "Save"
        Me.butSave.UseVisualStyleBackColor = False
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Location = New System.Drawing.Point(155, 52)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(26, 13)
        Me.lblUnit.TabIndex = 14
        Me.lblUnit.Text = "Unit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Quantity:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(88, 49)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(61, 20)
        Me.txtQuantity.TabIndex = 12
        '
        'cbxIngredientList
        '
        Me.cbxIngredientList.FormattingEnabled = True
        Me.cbxIngredientList.Location = New System.Drawing.Point(88, 19)
        Me.cbxIngredientList.Name = "cbxIngredientList"
        Me.cbxIngredientList.Size = New System.Drawing.Size(179, 21)
        Me.cbxIngredientList.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Ingredient:"
        '
        'butAddNewIngredient
        '
        Me.butAddNewIngredient.BackColor = System.Drawing.Color.SlateBlue
        Me.butAddNewIngredient.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.butAddNewIngredient.FlatAppearance.BorderSize = 0
        Me.butAddNewIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddNewIngredient.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddNewIngredient.ForeColor = System.Drawing.Color.White
        Me.butAddNewIngredient.Location = New System.Drawing.Point(275, 19)
        Me.butAddNewIngredient.Name = "butAddNewIngredient"
        Me.butAddNewIngredient.Size = New System.Drawing.Size(21, 21)
        Me.butAddNewIngredient.TabIndex = 16
        Me.butAddNewIngredient.Text = "+"
        Me.butAddNewIngredient.UseVisualStyleBackColor = False
        '
        'AddEditMealIngredient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 130)
        Me.Controls.Add(Me.butAddNewIngredient)
        Me.Controls.Add(Me.butSave)
        Me.Controls.Add(Me.lblUnit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.cbxIngredientList)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddEditMealIngredient"
        Me.Text = "Ingredient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents butSave As Button
    Friend WithEvents lblUnit As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents cbxIngredientList As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents butAddNewIngredient As Button
End Class
