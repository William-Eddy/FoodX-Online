<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEditMealIngredients
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddEditMealIngredients))
        Me.butAddNewIngredient = New System.Windows.Forms.Button()
        Me.butSave = New System.Windows.Forms.Button()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.cmbIngredients = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.butDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'butAddNewIngredient
        '
        Me.butAddNewIngredient.BackColor = System.Drawing.Color.SlateBlue
        Me.butAddNewIngredient.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.butAddNewIngredient.FlatAppearance.BorderSize = 0
        Me.butAddNewIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddNewIngredient.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddNewIngredient.ForeColor = System.Drawing.Color.White
        Me.butAddNewIngredient.Location = New System.Drawing.Point(273, 27)
        Me.butAddNewIngredient.Name = "butAddNewIngredient"
        Me.butAddNewIngredient.Size = New System.Drawing.Size(21, 21)
        Me.butAddNewIngredient.TabIndex = 23
        Me.butAddNewIngredient.Text = "+"
        Me.butAddNewIngredient.UseVisualStyleBackColor = False
        '
        'butSave
        '
        Me.butSave.BackColor = System.Drawing.Color.SlateBlue
        Me.butSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.butSave.FlatAppearance.BorderSize = 0
        Me.butSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butSave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSave.ForeColor = System.Drawing.Color.White
        Me.butSave.Location = New System.Drawing.Point(26, 95)
        Me.butSave.Name = "butSave"
        Me.butSave.Size = New System.Drawing.Size(121, 22)
        Me.butSave.TabIndex = 22
        Me.butSave.Text = "Save"
        Me.butSave.UseVisualStyleBackColor = False
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Location = New System.Drawing.Point(137, 60)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(26, 13)
        Me.lblUnit.TabIndex = 21
        Me.lblUnit.Text = "Unit"
        Me.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Quantity:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(86, 57)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(49, 20)
        Me.txtQuantity.TabIndex = 19
        '
        'cmbIngredients
        '
        Me.cmbIngredients.FormattingEnabled = True
        Me.cmbIngredients.Location = New System.Drawing.Point(86, 27)
        Me.cmbIngredients.Name = "cmbIngredients"
        Me.cmbIngredients.Size = New System.Drawing.Size(179, 21)
        Me.cmbIngredients.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Ingredient:"
        '
        'butDelete
        '
        Me.butDelete.BackColor = System.Drawing.Color.Crimson
        Me.butDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.butDelete.FlatAppearance.BorderSize = 0
        Me.butDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butDelete.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butDelete.ForeColor = System.Drawing.Color.White
        Me.butDelete.Location = New System.Drawing.Point(173, 95)
        Me.butDelete.Name = "butDelete"
        Me.butDelete.Size = New System.Drawing.Size(121, 22)
        Me.butDelete.TabIndex = 24
        Me.butDelete.Text = "Delete"
        Me.butDelete.UseVisualStyleBackColor = False
        '
        'AddEditMealIngredients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 140)
        Me.Controls.Add(Me.butDelete)
        Me.Controls.Add(Me.butAddNewIngredient)
        Me.Controls.Add(Me.butSave)
        Me.Controls.Add(Me.lblUnit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.cmbIngredients)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddEditMealIngredients"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingredients"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents butAddNewIngredient As Button
    Friend WithEvents butSave As Button
    Friend WithEvents lblUnit As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents cmbIngredients As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents butDelete As Button
End Class
