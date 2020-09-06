Public Class AddEditMealIngredients

    Dim mealIngredients As MealIngredients = New MealIngredients
    Dim ingredients As Ingredients = New Ingredients

    Dim mealIngredientID As String
    Dim mealID As String
    Dim ingredientID As String

    Dim masterEditForm As EditMeal

    Public Sub New(mealIngredientID, mealID, masterForm)

        InitializeComponent()

        Me.mealIngredientID = mealIngredientID
        Me.mealID = mealID

        masterEditForm = masterForm

        setMealIngredientsContents()
        setIngredientsContents()

    End Sub

    Private Sub AddEditMealIngredients_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        setIngredientDropdown()

        If Not (mealIngredientID = 0) Then

            ingredientID = mealIngredients.getCurrentIngredientID

            setCurrentIngredientID()
            setCurrentQuantity()
            setUnit()

        Else

            Me.cmbIngredients.Text = ""

        End If

    End Sub

    Public Sub setIngredientDropdown()

        Dim ingredientDropdown As IngredientDropDown = New IngredientDropDown

        ingredientDropdown.setContents()

        With cmbIngredients
            .ValueMember = ingredientDropdown.getValueMember
            .DisplayMember = ingredientDropdown.getDisplayMember
            .DataSource = ingredientDropdown.getDataSource

        End With

    End Sub

    Private Sub setCurrentQuantity()

        Me.txtQuantity.Text = mealIngredients.getCurrentQuantity

    End Sub

    Private Sub setCurrentIngredientID()

        Me.cmbIngredients.SelectedValue = ingredientID

    End Sub
    Private Sub setUnit()

        Me.lblUnit.Text = ingredients.getUnit(ingredientID)

    End Sub

    Private Sub butSave_Click(sender As Object, e As EventArgs) Handles butSave.Click

        Me.cmbIngredients.Select()
        Me.txtQuantity.Select()

        If mealIngredientID = 0 Then

            addNewMealIngredient()

        Else

            updateMealIngredient()

        End If

        UpdateMasterAndClose()

    End Sub

    Public Sub setMealIngredientsContents()

        mealIngredients.addColumnsForReturn("quantity")
        mealIngredients.addColumnsForReturn("ingredientID")
        mealIngredients.addColumnsForReturn("mealID")
        mealIngredients.addConditions("mealIngredientsID", mealIngredientID)
        mealIngredients.executeSelect("tblMealIngredients")

    End Sub

    Public Sub setIngredientsContents()

        ingredients.setContents()

    End Sub

    Private Sub updateMealIngredient()

        mealIngredients.addValues("ingredientID", Me.cmbIngredients.SelectedValue)
        mealIngredients.addValues("quantity", Me.txtQuantity.Text)
        mealIngredients.addConditions("mealIngredientsID", mealIngredientID)
        mealIngredients.executeUpdate("tblMealIngredients")

    End Sub


    Private Sub addNewMealIngredient()

        mealIngredients.addValues("ingredientID", Me.cmbIngredients.SelectedValue)
        mealIngredients.addValues("quantity", Me.txtQuantity.Text)
        mealIngredients.addValues("mealID", mealID)
        mealIngredients.executeInsert("tblMealIngredients")

    End Sub

    Private Sub cmbIngredients_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbIngredients.SelectionChangeCommitted

        ingredientID = Me.cmbIngredients.SelectedValue
        setUnit()

    End Sub

    Private Sub butAddNewIngredient_Click(sender As Object, e As EventArgs) Handles butAddNewIngredient.Click

        Dim newIngredientForm As NewIngredient = New NewIngredient(Me)
        newIngredientForm.Show()

    End Sub

    Private Sub UpdateMasterAndClose()

        masterEditForm.setIngredientsView()
        Me.Close()

    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles butDelete.Click

        If (MessageBox.Show("Are you sure you want to remove this ingredient from the meal?", "Removing Ingredient", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then

            mealIngredients.addConditions("mealIngredientsID", mealIngredientID)
            mealIngredients.executeDelete("tblMealIngredients")

            UpdateMasterAndClose()
        End If

    End Sub
End Class