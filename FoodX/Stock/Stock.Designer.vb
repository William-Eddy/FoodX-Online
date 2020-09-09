<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stock))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lvMealStock = New System.Windows.Forms.ListView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lvPendingMeals = New System.Windows.Forms.ListView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.butAddIngredient = New System.Windows.Forms.Button()
        Me.lvIngredientStock = New System.Windows.Forms.ListView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lvMealStock)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(546, 162)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Meal Stock"
        '
        'lvMealStock
        '
        Me.lvMealStock.HideSelection = False
        Me.lvMealStock.Location = New System.Drawing.Point(15, 30)
        Me.lvMealStock.Name = "lvMealStock"
        Me.lvMealStock.Size = New System.Drawing.Size(507, 110)
        Me.lvMealStock.TabIndex = 71
        Me.lvMealStock.UseCompatibleStateImageBehavior = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lvPendingMeals)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 357)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(546, 167)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pending Meals"
        '
        'lvPendingMeals
        '
        Me.lvPendingMeals.HideSelection = False
        Me.lvPendingMeals.Location = New System.Drawing.Point(15, 36)
        Me.lvPendingMeals.Name = "lvPendingMeals"
        Me.lvPendingMeals.Size = New System.Drawing.Size(507, 110)
        Me.lvPendingMeals.TabIndex = 73
        Me.lvPendingMeals.UseCompatibleStateImageBehavior = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.butAddIngredient)
        Me.GroupBox3.Controls.Add(Me.lvIngredientStock)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 180)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(546, 162)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingredient Stock"
        '
        'butAddIngredient
        '
        Me.butAddIngredient.BackColor = System.Drawing.Color.SlateBlue
        Me.butAddIngredient.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.butAddIngredient.FlatAppearance.BorderSize = 0
        Me.butAddIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddIngredient.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddIngredient.ForeColor = System.Drawing.Color.White
        Me.butAddIngredient.Location = New System.Drawing.Point(15, 128)
        Me.butAddIngredient.Name = "butAddIngredient"
        Me.butAddIngredient.Size = New System.Drawing.Size(121, 22)
        Me.butAddIngredient.TabIndex = 73
        Me.butAddIngredient.Text = "Add"
        Me.butAddIngredient.UseVisualStyleBackColor = False
        '
        'lvIngredientStock
        '
        Me.lvIngredientStock.HideSelection = False
        Me.lvIngredientStock.Location = New System.Drawing.Point(15, 31)
        Me.lvIngredientStock.Name = "lvIngredientStock"
        Me.lvIngredientStock.Size = New System.Drawing.Size(507, 86)
        Me.lvIngredientStock.TabIndex = 72
        Me.lvIngredientStock.UseCompatibleStateImageBehavior = False
        '
        'Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 551)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Stock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lvMealStock As ListView
    Friend WithEvents lvPendingMeals As ListView
    Friend WithEvents lvIngredientStock As ListView
    Friend WithEvents butAddIngredient As Button
End Class
