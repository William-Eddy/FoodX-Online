Public Class ShoppingListDatabaseOperations

    Public Sub addIngredientValue(columnName, value)

        MainConnectionAccess.conndb.addValues(columnName, value)

    End Sub

    Public Sub executeInsertCommand()

        MainConnectionAccess.conndb.executeInsert("tblShoppingList")

    End Sub
    Public Sub clearShoppingList()

        MainConnectionAccess.conndb.getSQLDataTable("DELETE FROM `tblShoppingList`")

    End Sub
    Public Sub clearPending()

        MainConnectionAccess.conndb.addValues("pending", 0)
        MainConnectionAccess.conndb.activateOverride()
        MainConnectionAccess.conndb.executeUpdate("tblMeal")

    End Sub
    Public Sub updatePendingMeals(mealID, quantity)

        MainConnectionAccess.conndb.addValues("pending", quantity)
        MainConnectionAccess.conndb.addConditions("mealID", mealID)
        MainConnectionAccess.conndb.activateOverride()
        MainConnectionAccess.conndb.executeUpdate("tblMeal")

    End Sub



End Class
