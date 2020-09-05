Public Class StockDisplay

    Inherits DatabaseTable

    Dim tableName As String
    Dim conditionColumn As String
    Dim IDColumnName As String

    Public Sub New(tableName, conditionColumn, IDColumnName)

        Me.tableName = tableName
        Me.conditionColumn = conditionColumn
        Me.IDColumnName = IDColumnName

        setDataSource()

    End Sub

    Public Sub setDataSource()

        addColumnsForReturn(IDColumnName)
        addColumnsForReturn("name")
        addColumnsForReturn(conditionColumn)
        addConditions(conditionColumn, 0, ">")
        executeSelect(tableName)

    End Sub

    Function getCurrentID()

        Return getCurrentRowValue(0)

    End Function

    Function getInsertArray()

        Dim name As String = getCurrentRowValue(1)
        Dim quantity As String = getCurrentRowValue(2)

        Dim insertArray As String() = {name, quantity}

        Return insertArray

    End Function


End Class
