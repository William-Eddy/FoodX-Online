<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewBarcode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewBarcode))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxIngredientList = New System.Windows.Forms.ComboBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.butSave = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingredient:"
        '
        'cbxIngredientList
        '
        Me.cbxIngredientList.FormattingEnabled = True
        Me.cbxIngredientList.Location = New System.Drawing.Point(79, 22)
        Me.cbxIngredientList.Name = "cbxIngredientList"
        Me.cbxIngredientList.Size = New System.Drawing.Size(179, 21)
        Me.cbxIngredientList.TabIndex = 0
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(79, 52)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(51, 20)
        Me.txtQuantity.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Quantity:"
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Location = New System.Drawing.Point(131, 56)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(26, 13)
        Me.lblUnit.TabIndex = 5
        Me.lblUnit.Text = "Unit"
        '
        'butSave
        '
        Me.butSave.BackColor = System.Drawing.Color.SlateBlue
        Me.butSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.butSave.FlatAppearance.BorderSize = 0
        Me.butSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butSave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSave.ForeColor = System.Drawing.Color.White
        Me.butSave.Location = New System.Drawing.Point(19, 117)
        Me.butSave.Name = "butSave"
        Me.butSave.Size = New System.Drawing.Size(121, 22)
        Me.butSave.TabIndex = 4
        Me.butSave.Text = "Save"
        Me.butSave.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Price:"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(79, 80)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(77, 20)
        Me.txtPrice.TabIndex = 3
        '
        'NewBarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 159)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.butSave)
        Me.Controls.Add(Me.lblUnit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.cbxIngredientList)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewBarcode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Ingredient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbxIngredientList As ComboBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUnit As Label
    Friend WithEvents butSave As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrice As TextBox
End Class
