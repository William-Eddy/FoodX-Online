Public Class Stock

    Dim mealStock As StockDisplay = New StockDisplay("tblMeal", "stock", "mealID")
    Dim mealsPending As StockDisplay = New StockDisplay("tblMeal", "pending", "mealID")
    Dim ingredientStock As StockDisplay = New StockDisplay("tblIngredients", "quantity", "ingredientID")
    Dim editIngredientForm As EditIngredient

    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        populateListViews()

    End Sub

    Private Sub formatMealStock()

        With Me.lvMealStock

            .View = View.Details
            .FullRowSelect = True
            .HideSelection = False
            .MultiSelect = False
            .Columns.Add("mealID", 0)
            .Columns.Add("Meal", 180)
            .Columns.Add("Quantity")
            .GridLines = True

        End With

    End Sub
    Private Sub formatPendingMeals()

        With Me.lvPendingMeals

            .View = View.Details
            .FullRowSelect = True
            .HideSelection = False
            .MultiSelect = False
            .Columns.Add("mealID", 0)
            .Columns.Add("Meal", 180)
            .Columns.Add("Quantity")
            .GridLines = True

        End With

    End Sub

    Private Sub formatIngredients()

        With Me.lvIngredientStock

            .View = View.Details
            .FullRowSelect = True
            .HideSelection = False
            .MultiSelect = False
            .Columns.Add("ingredientID", 0)
            .Columns.Add("Ingredient", 180)
            .Columns.Add("Quantity")
            .GridLines = True

        End With

    End Sub

    Private Sub populateMealStock()

        mealStock.setDataSource()
        formatMealStock()

        For Each row As DataRow In mealStock.table.Rows

            Me.lvMealStock.Items.Add(mealStock.getCurrentID).SubItems.AddRange(mealStock.getInsertArray)
            mealStock.increaseRowCount()
        Next

        mealStock.setRowColumnIndexToZero()

    End Sub
    Private Sub populateMealsPending()

        mealsPending.setDataSource()
        formatPendingMeals()

        For Each row As DataRow In mealsPending.table.Rows

            Me.lvPendingMeals.Items.Add(mealsPending.getCurrentID).SubItems.AddRange(mealsPending.getInsertArray)
            mealsPending.increaseRowCount()
        Next

        mealsPending.setRowColumnIndexToZero()

    End Sub

    Public Sub populateIngredientStock()

        lvIngredientStock.Clear()
        ingredientStock.setDataSource()
        formatIngredients()

        For Each row As DataRow In ingredientStock.table.Rows

            Me.lvIngredientStock.Items.Add(ingredientStock.getCurrentID).SubItems.AddRange(ingredientStock.getInsertArray)
            ingredientStock.increaseRowCount()
        Next

        ingredientStock.setRowColumnIndexToZero()

    End Sub

    Private Sub lvPendingMeals_DoubleClick(sender As Object, e As EventArgs) Handles lvPendingMeals.DoubleClick

        Dim message As MsgBoxResult = MsgBox("Are you sure you want to add these meals to stock?", vbYesNo, "Stock Management")

        If message = vbYes Then

            Dim mealID As String = lvPendingMeals.FocusedItem.Text

            Dim meals As Meals = New Meals

            meals.addColumnsForReturn("stock")
            meals.addConditions("mealID", mealID)
            meals.executeSelect("tblMeal")

            Dim currentStock As Integer = meals.getCurrentRowValue(0)
            Dim newStock As Integer = currentStock + mealsPending.getSingleSearchValue("mealID", mealID, "pending")

            mealStock.addValues("pending", 0)
            mealStock.addValues("stock", newStock)
            mealStock.addConditions("mealID", mealID)
            mealStock.executeUpdate("tblMeal")

            resetListViews()
            populateListViews()

        End If

    End Sub

    Private Sub resetListViews()

        lvMealStock.Clear()
        lvPendingMeals.Clear()
        lvIngredientStock.Clear()

    End Sub

    Private Sub populateListViews()

        populateMealStock()
        populateMealsPending()
        populateIngredientStock()

    End Sub

    Private Sub lvIngredientStock_DoubleClick(sender As Object, e As EventArgs) Handles lvIngredientStock.DoubleClick

        editIngredientForm = New EditIngredient(Me, Me.lvIngredientStock.FocusedItem.Text)
        showIngredientForm()

    End Sub

    Private Sub butAddIngredient_Click(sender As Object, e As EventArgs) Handles butAddIngredient.Click

        editIngredientForm = New EditIngredient(Me)
        showIngredientForm()

    End Sub

    Private Sub showIngredientForm()

        editIngredientForm.Show()

    End Sub
End Class