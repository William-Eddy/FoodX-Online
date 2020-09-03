Public Class DatabaseTable

    Public table As DataTable = New DataTable
    Public currentRowIndex As Integer = 0
    Public currentColumnIndex As Integer = 0
    Public numberOfRows As Integer
    Public numberOfColumns As Integer

    Public Sub setTableContents(query)

        table = MainConnectionAccess.conndb.getSQLDataTable(query)
        setRowColumnIndexToZero()

    End Sub

    Public Sub setRowIndexToZero()

        currentRowIndex = 0

    End Sub

    Public Sub setColumnIndexToZero()

        currentColumnIndex = 0

    End Sub

    Public Sub setRowColumnIndexToZero()

        setRowIndexToZero()
        setColumnIndexToZero()

    End Sub

    Private Sub setRowColumnCounts()

        numberOfRows = table.Rows.Count
        numberOfColumns = table.Columns.Count

    End Sub

    Public Sub increaseColumnCount()

        currentColumnIndex = currentColumnIndex + 1

    End Sub

    Public Sub increaseRowCount()

        currentRowIndex = currentRowIndex + 1

    End Sub

    Function getCurrentRowValue(column)

        Return getValue(currentRowIndex, column)

    End Function

    Public Function getValue(row, column)

        Return table.Rows(row).Item(column).ToString()

    End Function

    Function getCurrentValue()

        Return getValue(currentRowIndex, currentColumnIndex)

    End Function

    Public Sub printTable()

        setRowColumnIndexToZero()

        For Each row As DataRow In table.Rows

            Console.WriteLine(getCurrentRowValue(0) + "," + getCurrentRowValue(1))
            increaseRowCount()
        Next

    End Sub

    Function getSingleSearchValue(searchColumn As String, searchValue As String, returnColumn As String)

        Dim rows() As DataRow = getDataRow(searchColumn, searchValue)

        Return rows(0).Item(returnColumn)

    End Function

    Function getDataRow(searchColumn As String, searchValue As String)

        Return table.Select(searchColumn + "= '" + searchValue + "'")

    End Function

    Function convertToDataTable(dataRow)

        Dim outputTable As DataTable = New DataTable

        For Each row As DataRow In dataRow

            outputTable.ImportRow(row)

        Next

        Return outputTable

    End Function

    Function getNewTableWithConditions(searchColumn As String, searchValue As String)

        Return convertToDataTable(getDataRow(searchColumn, searchValue))

    End Function

    Public Sub executeSelect(tableName)

        table = MainConnectionAccess.conndb.executeSelect(tableName)

    End Sub
    Public Sub executeUpdate(tableName)

        MainConnectionAccess.conndb.executeUpdate(tableName)

    End Sub
    Public Sub executeInsert(tableName)

        MainConnectionAccess.conndb.executeInsert(tableName)

    End Sub
    Public Sub executeDelete(tableName)

        MainConnectionAccess.conndb.executeDelete(tableName)

    End Sub

    Public Sub addConditions(columnName, value)

        MainConnectionAccess.conndb.addConditions(columnName, value)

    End Sub

    Public Sub addColumns(columnName, value)

        MainConnectionAccess.conndb.addColumns(columnName, value)

    End Sub

    Public Sub addValues(columnName, value)

        MainConnectionAccess.conndb.addValues(columnName, value)

    End Sub
    Public Sub addColumnsForReturn(columnName)

        MainConnectionAccess.conndb.addColumns(columnName, 0)

    End Sub

End Class
