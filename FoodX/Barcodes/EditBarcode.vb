Public Class EditBarcode

    Dim barcode As String
    Dim masterForm As scanIngredientsIn
    Dim newBarcode As Boolean

    Dim ingredientDropdown As IngredientDropDown = New IngredientDropDown
    Dim ingredientBarcodes As IngredientBarcodes = New IngredientBarcodes

    Public Sub New(masterForm As scanIngredientsIn, barcode As String, newBarcode As Boolean)

        InitializeComponent()

        Me.barcode = barcode
        Me.masterForm = masterForm
        Me.newBarcode = newBarcode

    End Sub

    Private Sub NewBarcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        populateIngredientDropdown()

        If newBarcode = False Then
            getCurrentBarcodeData()
        End If

    End Sub


    Private Sub butSave_Click(sender As Object, e As EventArgs) Handles butSave.Click

        save()

    End Sub

    Private Sub populateIngredientDropdown()

        ingredientDropdown.setContents()

        With cbxIngredientList

            .ValueMember = ingredientDropdown.getValueMember
            .DisplayMember = ingredientDropdown.getDisplayMember
            .DataSource = ingredientDropdown.getDataSource

        End With

    End Sub

    Private Sub cbxIngredientList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxIngredientList.SelectedIndexChanged

        Me.lblUnit.Text = ingredientDropdown.getUnit(Me.cbxIngredientList.SelectedValue)

    End Sub

    Private Sub txtPrice_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrice.KeyDown

        If e.KeyCode = Keys.Enter Then

            save()

        End If


    End Sub

    Private Sub save()

        If newBarcode = True Then

            addNewBarcode()

        Else

            updateBarcode()

        End If

        addToReconcileList()
        Me.Close()

    End Sub

    Private Sub addNewBarcode()

        addValues()
        ingredientBarcodes.executeInsert()

    End Sub

    Private Sub updateBarcode()

        addValues()
        ingredientBarcodes.addConditions("barcode", barcode)
        ingredientBarcodes.executeUpdate()

    End Sub

    Private Sub addValues()

        Me.cbxIngredientList.Select()

        ingredientBarcodes.addValues("barcode", barcode)
        ingredientBarcodes.addValues("ingredientID", Me.cbxIngredientList.SelectedValue)
        ingredientBarcodes.addValues("quantity", Me.txtQuantity.Text)
        ingredientBarcodes.addValues("price", Me.txtPrice.Text)

    End Sub

    Private Sub addToReconcileList()

        masterForm.addIngredientBarcode(barcode)

    End Sub

    Private Sub getCurrentBarcodeData()

        ingredientBarcodes.addColumnsForReturn("ingredientID")
        ingredientBarcodes.addColumnsForReturn("quantity")
        ingredientBarcodes.addColumnsForReturn("price")
        ingredientBarcodes.addConditions("barcode", barcode)
        ingredientBarcodes.executeSelect()

        Me.cbxIngredientList.SelectedValue = ingredientBarcodes.getCurrentIngredientID
        Me.txtQuantity.Text = ingredientBarcodes.getCurrentQuantity
        Me.txtPrice.Text = ingredientBarcodes.getCurrentPrice

    End Sub

End Class