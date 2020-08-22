Public Class ShoppingList
    Private Sub ShoppingList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ingredients As DatabaseTableOld
        Dim ingredientCount As Integer
        Dim name As String
        Dim quantity As String
        Dim insertArray As String()
        Dim unit As String
        ingredients = New DatabaseTableOld

        ingredients.setTableContents("SELECT `name`, `quantity`, `unit` FROM `tblShoppingList`")

        With Me.lvIngredients

            .View = View.Details
            .FullRowSelect = True
            .HideSelection = False
            .MultiSelect = False
            .Columns.Add("Ingredient", 180)
            .Columns.Add("Quantity")
            .GridLines = True

        End With

        ingredientCount = ingredients.numberOfRows


        For index As Integer = 0 To ingredientCount - 1

            name = ingredients.getValue(index, 0)
            quantity = Str(ingredients.getValue(index, 1))
            unit = ingredients.getValue(index, 2)

            If unit = "Unit" Then
                unit = ""
            End If

            insertArray = {quantity + unit}
            Me.lvIngredients.Items.Add(name).SubItems.AddRange(insertArray)
        Next

        setMealsRequired()

    End Sub


    Private Sub setMealsRequired()

        Dim meals As DatabaseTableOld
        meals = New DatabaseTableOld
        Dim name As String
        Dim quantity As String
        Dim insertArray As String()

        meals.setTableContents("SELECT `name`, `pending` FROM `tblMeal` WHERE pending>0")

        With Me.lvMeals

            .View = View.Details
            .FullRowSelect = True
            .HideSelection = False
            .MultiSelect = False
            .Columns.Add("Meal ", 180)
            .Columns.Add("Quantity")
            .GridLines = True

        End With

        For index As Integer = 0 To meals.numberOfRows - 1

            Name = meals.getValue(index, 0)
            quantity = Str(meals.getValue(index, 1))

            insertArray = {quantity}
            Me.lvMeals.Items.Add(name).SubItems.AddRange(insertArray)
        Next


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class