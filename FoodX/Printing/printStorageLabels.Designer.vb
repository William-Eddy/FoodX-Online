<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class printStorageLabels
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(printStorageLabels))
        Me.butPrint = New System.Windows.Forms.Button()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.lvMealParts = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'butPrint
        '
        Me.butPrint.Location = New System.Drawing.Point(241, 120)
        Me.butPrint.Name = "butPrint"
        Me.butPrint.Size = New System.Drawing.Size(117, 23)
        Me.butPrint.TabIndex = 0
        Me.butPrint.Text = "Print All"
        Me.butPrint.UseVisualStyleBackColor = True
        '
        'PrintDoc
        '
        '
        'PrintPreviewDialog
        '
        Me.PrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog.Enabled = True
        Me.PrintPreviewDialog.Icon = CType(resources.GetObject("PrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog.Name = "PrintPreviewDialog"
        Me.PrintPreviewDialog.Visible = False
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'lvMealParts
        '
        Me.lvMealParts.HideSelection = False
        Me.lvMealParts.Location = New System.Drawing.Point(12, 12)
        Me.lvMealParts.Name = "lvMealParts"
        Me.lvMealParts.Size = New System.Drawing.Size(346, 97)
        Me.lvMealParts.TabIndex = 2
        Me.lvMealParts.UseCompatibleStateImageBehavior = False
        '
        'printStorageLabels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 154)
        Me.Controls.Add(Me.lvMealParts)
        Me.Controls.Add(Me.butPrint)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "printStorageLabels"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Labels"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents butPrint As Button
    Friend WithEvents PrintDoc As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog As PrintPreviewDialog
    Friend WithEvents PrintDialog As PrintDialog
    Friend WithEvents lvMealParts As ListView
End Class
