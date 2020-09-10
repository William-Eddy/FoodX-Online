<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditMeal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditMeal))
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtServes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCalories = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCarbs = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtProtein = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lvIngredients = New System.Windows.Forms.ListView()
        Me.butSave = New System.Windows.Forms.Button()
        Me.butEmailMethod = New System.Windows.Forms.Button()
        Me.butSaveAndClose = New System.Windows.Forms.Button()
        Me.butDelete = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.butAddStep = New System.Windows.Forms.Button()
        Me.lvMethodSteps = New System.Windows.Forms.ListView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.butPrintLabels = New System.Windows.Forms.Button()
        Me.lvMealParts = New System.Windows.Forms.ListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(16, 29)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(71, 15)
        Me.Label42.TabIndex = 51
        Me.Label42.Text = "Meal name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(93, 27)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(184, 20)
        Me.txtName.TabIndex = 52
        '
        'txtServes
        '
        Me.txtServes.Location = New System.Drawing.Point(347, 27)
        Me.txtServes.Name = "txtServes"
        Me.txtServes.Size = New System.Drawing.Size(53, 20)
        Me.txtServes.TabIndex = 54
        Me.txtServes.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(293, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Serves:"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(469, 27)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(53, 20)
        Me.txtStock.TabIndex = 56
        Me.txtStock.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(423, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 15)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Stock:"
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(93, 53)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(147, 21)
        Me.cmbCategory.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(28, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Category:"
        '
        'txtCalories
        '
        Me.txtCalories.Location = New System.Drawing.Point(121, 28)
        Me.txtCalories.Name = "txtCalories"
        Me.txtCalories.Size = New System.Drawing.Size(56, 20)
        Me.txtCalories.TabIndex = 60
        Me.txtCalories.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(58, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Calories:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCarbs
        '
        Me.txtCarbs.Location = New System.Drawing.Point(121, 54)
        Me.txtCarbs.Name = "txtCarbs"
        Me.txtCarbs.Size = New System.Drawing.Size(56, 20)
        Me.txtCarbs.TabIndex = 62
        Me.txtCarbs.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(24, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 15)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Carbohydrates:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFat
        '
        Me.txtFat.Location = New System.Drawing.Point(121, 80)
        Me.txtFat.Name = "txtFat"
        Me.txtFat.Size = New System.Drawing.Size(56, 20)
        Me.txtFat.TabIndex = 64
        Me.txtFat.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(86, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 15)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Fat:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtProtein
        '
        Me.txtProtein.Location = New System.Drawing.Point(121, 106)
        Me.txtProtein.Name = "txtProtein"
        Me.txtProtein.Size = New System.Drawing.Size(56, 20)
        Me.txtProtein.TabIndex = 66
        Me.txtProtein.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(64, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 15)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Protein:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label42)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtServes)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtStock)
        Me.GroupBox1.Controls.Add(Me.cmbCategory)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(549, 92)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Meal Details"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblUnit)
        Me.GroupBox2.Controls.Add(Me.txtCalories)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtProtein)
        Me.GroupBox2.Controls.Add(Me.txtCarbs)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtFat)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 298)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(225, 150)
        Me.GroupBox2.TabIndex = 69
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nutritional Information: Per serving"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(181, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "g"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(181, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "g"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(181, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 13)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "g"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Location = New System.Drawing.Point(179, 32)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(21, 13)
        Me.lblUnit.TabIndex = 74
        Me.lblUnit.Text = "cal"
        Me.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lvIngredients)
        Me.GroupBox3.Controls.Add(Me.butSave)
        Me.GroupBox3.Location = New System.Drawing.Point(259, 298)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(318, 150)
        Me.GroupBox3.TabIndex = 70
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingredients"
        '
        'lvIngredients
        '
        Me.lvIngredients.HideSelection = False
        Me.lvIngredients.Location = New System.Drawing.Point(19, 27)
        Me.lvIngredients.Name = "lvIngredients"
        Me.lvIngredients.Size = New System.Drawing.Size(273, 73)
        Me.lvIngredients.TabIndex = 70
        Me.lvIngredients.UseCompatibleStateImageBehavior = False
        '
        'butSave
        '
        Me.butSave.BackColor = System.Drawing.Color.SlateBlue
        Me.butSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.butSave.FlatAppearance.BorderSize = 0
        Me.butSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butSave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSave.ForeColor = System.Drawing.Color.White
        Me.butSave.Location = New System.Drawing.Point(19, 110)
        Me.butSave.Name = "butSave"
        Me.butSave.Size = New System.Drawing.Size(121, 22)
        Me.butSave.TabIndex = 71
        Me.butSave.Text = "Add Instruction"
        Me.butSave.UseVisualStyleBackColor = False
        '
        'butEmailMethod
        '
        Me.butEmailMethod.BackColor = System.Drawing.Color.SlateBlue
        Me.butEmailMethod.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.butEmailMethod.FlatAppearance.BorderSize = 0
        Me.butEmailMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butEmailMethod.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butEmailMethod.ForeColor = System.Drawing.Color.White
        Me.butEmailMethod.Location = New System.Drawing.Point(146, 130)
        Me.butEmailMethod.Name = "butEmailMethod"
        Me.butEmailMethod.Size = New System.Drawing.Size(121, 22)
        Me.butEmailMethod.TabIndex = 72
        Me.butEmailMethod.Text = "Email Method"
        Me.butEmailMethod.UseVisualStyleBackColor = False
        '
        'butSaveAndClose
        '
        Me.butSaveAndClose.BackColor = System.Drawing.Color.SlateBlue
        Me.butSaveAndClose.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.butSaveAndClose.FlatAppearance.BorderSize = 0
        Me.butSaveAndClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butSaveAndClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSaveAndClose.ForeColor = System.Drawing.Color.White
        Me.butSaveAndClose.Location = New System.Drawing.Point(52, 87)
        Me.butSaveAndClose.Name = "butSaveAndClose"
        Me.butSaveAndClose.Size = New System.Drawing.Size(121, 22)
        Me.butSaveAndClose.TabIndex = 72
        Me.butSaveAndClose.Text = "Save and Close"
        Me.butSaveAndClose.UseVisualStyleBackColor = False
        '
        'butDelete
        '
        Me.butDelete.BackColor = System.Drawing.Color.Crimson
        Me.butDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.butDelete.FlatAppearance.BorderSize = 0
        Me.butDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butDelete.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butDelete.ForeColor = System.Drawing.Color.White
        Me.butDelete.Location = New System.Drawing.Point(52, 58)
        Me.butDelete.Name = "butDelete"
        Me.butDelete.Size = New System.Drawing.Size(121, 22)
        Me.butDelete.TabIndex = 73
        Me.butDelete.Text = "Delete"
        Me.butDelete.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.butEmailMethod)
        Me.GroupBox4.Controls.Add(Me.butAddStep)
        Me.GroupBox4.Controls.Add(Me.lvMethodSteps)
        Me.GroupBox4.Location = New System.Drawing.Point(28, 119)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(549, 173)
        Me.GroupBox4.TabIndex = 71
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Method"
        '
        'butAddStep
        '
        Me.butAddStep.BackColor = System.Drawing.Color.SlateBlue
        Me.butAddStep.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.butAddStep.FlatAppearance.BorderSize = 0
        Me.butAddStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddStep.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddStep.ForeColor = System.Drawing.Color.White
        Me.butAddStep.Location = New System.Drawing.Point(19, 130)
        Me.butAddStep.Name = "butAddStep"
        Me.butAddStep.Size = New System.Drawing.Size(121, 22)
        Me.butAddStep.TabIndex = 74
        Me.butAddStep.Text = "Add Step"
        Me.butAddStep.UseVisualStyleBackColor = False
        '
        'lvMethodSteps
        '
        Me.lvMethodSteps.HideSelection = False
        Me.lvMethodSteps.Location = New System.Drawing.Point(19, 27)
        Me.lvMethodSteps.Name = "lvMethodSteps"
        Me.lvMethodSteps.Size = New System.Drawing.Size(504, 92)
        Me.lvMethodSteps.TabIndex = 70
        Me.lvMethodSteps.UseCompatibleStateImageBehavior = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.butPrintLabels)
        Me.GroupBox5.Controls.Add(Me.lvMealParts)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Location = New System.Drawing.Point(28, 454)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(318, 163)
        Me.GroupBox5.TabIndex = 72
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Storage"
        '
        'butPrintLabels
        '
        Me.butPrintLabels.BackColor = System.Drawing.Color.SlateBlue
        Me.butPrintLabels.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.butPrintLabels.FlatAppearance.BorderSize = 0
        Me.butPrintLabels.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butPrintLabels.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butPrintLabels.ForeColor = System.Drawing.Color.White
        Me.butPrintLabels.Location = New System.Drawing.Point(146, 126)
        Me.butPrintLabels.Name = "butPrintLabels"
        Me.butPrintLabels.Size = New System.Drawing.Size(121, 22)
        Me.butPrintLabels.TabIndex = 75
        Me.butPrintLabels.Text = "Print Labels"
        Me.butPrintLabels.UseVisualStyleBackColor = False
        '
        'lvMealParts
        '
        Me.lvMealParts.HideSelection = False
        Me.lvMealParts.Location = New System.Drawing.Point(19, 27)
        Me.lvMealParts.Name = "lvMealParts"
        Me.lvMealParts.Size = New System.Drawing.Size(273, 89)
        Me.lvMealParts.TabIndex = 70
        Me.lvMealParts.UseCompatibleStateImageBehavior = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SlateBlue
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(19, 126)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 22)
        Me.Button1.TabIndex = 71
        Me.Button1.Text = "Add Part"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.butDelete)
        Me.GroupBox6.Controls.Add(Me.butSaveAndClose)
        Me.GroupBox6.Location = New System.Drawing.Point(352, 454)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(225, 163)
        Me.GroupBox6.TabIndex = 74
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Operations"
        '
        'EditMeal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 633)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditMeal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Meal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label42 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtServes As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCalories As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCarbs As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFat As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtProtein As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lvIngredients As ListView
    Friend WithEvents butSave As Button
    Friend WithEvents butSaveAndClose As Button
    Friend WithEvents butDelete As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblUnit As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents butAddStep As Button
    Friend WithEvents lvMethodSteps As ListView
    Friend WithEvents butEmailMethod As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lvMealParts As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents butPrintLabels As Button
End Class
