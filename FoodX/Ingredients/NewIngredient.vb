Public Class NewIngredient

    Dim masterEditForm As AddEditMealIngredients
    Public Sub New(masterForm)

        InitializeComponent()

        masterEditForm = masterForm

    End Sub

    Private Sub butSave_Click(sender As Object, e As EventArgs) Handles butSave.Click

        Dim ingredients As Ingredients = New Ingredients

        ingredients.addValues("name", Me.txtName.Text)
        ingredients.executeInsert("tblIngredients")

        masterEditForm.setIngredientDropdown()
        masterEditForm.setIngredientsContents()

        Me.Close()

    End Sub

End Class