Public Class NewBarcode

    Dim ingData As DataTable
    Dim inbarcode As String
    Dim scanForm As scanIngredientsIn

    Dim ingredientDropdown As IngredientDropDown = New IngredientDropDown

    Public Sub New(barcode, masterForm, newBarcode)

        InitializeComponent()
        inbarcode = barcode

        scanForm = masterForm

    End Sub

    Private Sub NewBarcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        populateIngredientDropdown()

    End Sub

    Private Sub butSave_Click(sender As Object, e As EventArgs) Handles butSave.Click

        saveAndExit()

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

    Private Sub txtPrice_Leave(sender As Object, e As EventArgs) Handles txtPrice.Leave

        'Me.txtPrice.Text = FormatCurrency(Me.txtPrice.Text)

    End Sub

    Private Sub txtPrice_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrice.KeyDown

        If e.KeyCode = Keys.Enter Then

            saveAndExit()

        End If

    End Sub

    Private Sub saveAndExit()

        Dim ingredients As Ingredients = New Ingredients

        Me.cbxIngredientList.Select()

        ingredients.addValues("barcode", inbarcode)
        ingredients.addValues("ingredientID", Me.cbxIngredientList.SelectedValue)
        ingredients.addValues("quantity", Me.txtQuantity.Text)
        ingredients.addValues("price", Me.txtPrice.Text)
        ingredients.executeInsert("tblIngredientBarcodes")

        scanForm.addIngredientBarcode(inbarcode)

        Me.Close()

    End Sub
End Class