<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditMealParts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditMealParts))
        Me.butDelete = New System.Windows.Forms.Button()
        Me.butSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPerContainer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalContainers = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPerServing = New System.Windows.Forms.TextBox()
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
        Me.butDelete.Location = New System.Drawing.Point(172, 141)
        Me.butDelete.Name = "butDelete"
        Me.butDelete.Size = New System.Drawing.Size(121, 22)
        Me.butDelete.TabIndex = 4
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
        Me.butSave.Location = New System.Drawing.Point(25, 141)
        Me.butSave.Name = "butSave"
        Me.butSave.Size = New System.Drawing.Size(121, 22)
        Me.butSave.TabIndex = 3
        Me.butSave.Text = "Save"
        Me.butSave.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Per Container:"
        '
        'txtPerContainer
        '
        Me.txtPerContainer.Location = New System.Drawing.Point(112, 51)
        Me.txtPerContainer.Name = "txtPerContainer"
        Me.txtPerContainer.Size = New System.Drawing.Size(49, 20)
        Me.txtPerContainer.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Part:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(57, 21)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(236, 20)
        Me.txtName.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Total Containers:"
        '
        'txtTotalContainers
        '
        Me.txtTotalContainers.Location = New System.Drawing.Point(112, 103)
        Me.txtTotalContainers.Name = "txtTotalContainers"
        Me.txtTotalContainers.Size = New System.Drawing.Size(49, 20)
        Me.txtTotalContainers.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Per Serving:"
        '
        'txtPerServing
        '
        Me.txtPerServing.Location = New System.Drawing.Point(112, 77)
        Me.txtPerServing.Name = "txtPerServing"
        Me.txtPerServing.Size = New System.Drawing.Size(49, 20)
        Me.txtPerServing.TabIndex = 36
        '
        'EditMealParts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 180)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPerServing)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTotalContainers)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.butDelete)
        Me.Controls.Add(Me.butSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPerContainer)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditMealParts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Meal Parts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents butDelete As Button
    Friend WithEvents butSave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPerContainer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotalContainers As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPerServing As TextBox
End Class
