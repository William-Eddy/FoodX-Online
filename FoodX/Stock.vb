Public Class Stock
    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbMealStock.DataSource = getMealStockDataSource()

    End Sub

    Function getMealStockDataSource()

        Dim meals As Meals = New Meals
        meals.addColumnsForReturn("mealID")
        meals.addColumnsForReturn("name")
        meals.addColumnsForReturn("stock")
        meals.executeSelect("tblMeal")

        Return meals.getNewTableWithConditions("stock", 0, ">")

    End Function
End Class