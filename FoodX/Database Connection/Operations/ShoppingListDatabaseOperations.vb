Public Class ShoppingListDatabaseOperations


    Public Sub initialise()

        MainConnectionAccess.conndb.initaliseInsertQuery()

    End Sub

    Public Sub addIngredientValue(columnName, value)

        MainConnectionAccess.conndb.addValues(columnName, value)

    End Sub

    Public Sub setQueryString()

        MainConnectionAccess.conndb.setQueryString("tblShoppingList")

    End Sub

    Public Sub executeCommand()

        MainConnectionAccess.conndb.setQueryToConnection()
        MainConnectionAccess.conndb.executeCommand()

    End Sub



End Class
