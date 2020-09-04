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
        Me.lbMealStock = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbIngredientStock = New System.Windows.Forms.ListBox()
        Me.lbPendingMeals = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbMealStock
        '
        Me.lbMealStock.DisplayMember = "name"
        Me.lbMealStock.FormattingEnabled = True
        Me.lbMealStock.Location = New System.Drawing.Point(15, 30)
        Me.lbMealStock.Name = "lbMealStock"
        Me.lbMealStock.Size = New System.Drawing.Size(507, 108)
        Me.lbMealStock.TabIndex = 20
        Me.lbMealStock.ValueMember = "mealID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbMealStock)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(546, 162)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Meal Stock"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbPendingMeals)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 357)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(546, 167)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pending Meals"
        '
        'lbIngredientStock
        '
        Me.lbIngredientStock.DisplayMember = "name"
        Me.lbIngredientStock.FormattingEnabled = True
        Me.lbIngredientStock.Location = New System.Drawing.Point(15, 33)
        Me.lbIngredientStock.Name = "lbIngredientStock"
        Me.lbIngredientStock.Size = New System.Drawing.Size(507, 108)
        Me.lbIngredientStock.TabIndex = 20
        Me.lbIngredientStock.ValueMember = "mealID"
        '
        'lbPendingMeals
        '
        Me.lbPendingMeals.DisplayMember = "name"
        Me.lbPendingMeals.FormattingEnabled = True
        Me.lbPendingMeals.Location = New System.Drawing.Point(15, 35)
        Me.lbPendingMeals.Name = "lbPendingMeals"
        Me.lbPendingMeals.Size = New System.Drawing.Size(507, 108)
        Me.lbPendingMeals.TabIndex = 21
        Me.lbPendingMeals.ValueMember = "mealID"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbIngredientStock)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 180)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(546, 162)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingredient Stock"
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
        Me.Text = "Stock"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbMealStock As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbIngredientStock As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbPendingMeals As ListBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
