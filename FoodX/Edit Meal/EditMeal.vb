Public Class EditMeal

    Dim mealID As String
    Dim editMealManagement As EditMealManagement
    Dim ingredientDisplay As MealIngredientDisplay

    Public Sub New(ByVal mealIDToEdit As String)

        InitializeComponent()

        mealID = mealIDToEdit

        editMealManagement = New EditMealManagement(mealID)

    End Sub

    Private Sub EditMeal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        setCurrentMealData()

    End Sub

    Private Sub setIngredientsView()

        ingredientDisplay = New MealIngredientDisplay(mealID)

        Dim ingredientID As String
        Dim mealIngredientID As String
        Dim name As String
        Dim quantity As String

        Dim insertArray As String()

        setIngredientsListViewFormat()

        ingredientDisplay.setTableContents()

        For Each row As DataRow In ingredientDisplay.getMealIngredientRows()

            ingredientID = ingredientDisplay.getIngredientID
            mealIngredientID = ingredientDisplay.getMealIngredientID
            name = ingredientDisplay.getIngredientName(ingredientID)
            quantity = ingredientDisplay.getIngredientQuantity + ingredientDisplay.getIngredientUnit(ingredientID)

            insertArray = {name, quantity}
            Me.lvIngredients.Items.Add(mealIngredientID).SubItems.AddRange(insertArray)

            ingredientDisplay.mealIngredients.increaseRowCount()

        Next

    End Sub
    Private Sub setCurrentMealData()

        editMealManagement.setContentsForSelectedMeal()

        setCurrentMealDetails()
        setCurrentNutritionalData()
        setIngredientsView()

    End Sub
    Private Sub setCurrentMealDetails()

        Me.txtName.Text = editMealManagement.getMealName()
        Me.txtServes.Text = editMealManagement.getNumberOfServings()
        Me.txtStock.Text = editMealManagement.getStock()
        Me.cboCategory.Text = editMealManagement.getCategory()

    End Sub

    Private Sub setCurrentNutritionalData()

        Me.txtCalories.Text = editMealManagement.getCalories()
        Me.txtCarbs.Text = editMealManagement.getCarbs()
        Me.txtFat.Text = editMealManagement.getFat()
        Me.txtProtein.Text = editMealManagement.getProtein()

    End Sub

    Private Sub setIngredientsListViewFormat()

        With Me.lvIngredients

            .View = View.Details
            .FullRowSelect = True
            .HideSelection = False
            .MultiSelect = False
            .Columns.Add("mealIngredientID", 0)
            .Columns.Add("Ingredient", 180)
            .Columns.Add("Quantity")
            .GridLines = True

        End With

    End Sub

    Private Sub butSave_Click(sender As Object, e As EventArgs) Handles butSave.Click

        Dim editMealIngredientForm As AddEditMealIngredients = New AddEditMealIngredients(0, mealID)

        editMealIngredientForm.Show()

    End Sub

    Private Sub lvIngredients_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvIngredients.DoubleClick

        Dim editIngredientForm As AddEditMealIngredients = New AddEditMealIngredients(Me.lvIngredients.FocusedItem.Text, mealID)

        editIngredientForm.Show()

    End Sub

End Class