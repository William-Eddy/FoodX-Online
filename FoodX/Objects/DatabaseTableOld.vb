Public Class DatabaseTableOld

    Public table As DataTable = New DataTable
    Public currentRowIndex As Integer = 0
    Public currentColumnIndex As Integer = 0
    Public numberOfRows As String
    Public numberOfColumns As String

    Public Sub setTableContents(mysqlstatement)

        table = MainConnectionAccess.conndb.runAdapter(mysqlstatement)
        setIndexToZero()

    End Sub

    Public Sub setIndexToZero()

        currentColumnIndex = 0
        currentRowIndex = 0
        numberOfRows = table.Rows.Count
        numberOfColumns = table.Columns.Count

    End Sub

    Public Sub addColCount()

        currentColumnIndex = currentColumnIndex + 1

    End Sub

    Public Sub addRowCount()

        currentRowIndex = currentRowIndex + 1

    End Sub

    Public Sub initialise()

        table = New DataTable

    End Sub

    Function getCurrentValue(row, column)

        Dim actualRow As Integer
        Dim actualCol As Integer

        If IsNumeric(row) Then
            'nothing
        Else
            actualRow = currentRowIndex
        End If

        If IsNumeric(column) Then
            'nothing
        Else
            actualCol = currentColumnIndex
        End If

        Return table.Rows(actualRow).Item(actualCol).ToString()

    End Function

    Function getCurrentRow(column)

        Return table.Rows(currentRowIndex).Item(column).ToString()

    End Function

    Public Sub increaseQuantity(searchCol, searchValue, addCol, addValue)

        Dim currentRowIndex As Integer = 0
        For Each row As DataRow In table.Rows

            If table.Rows(currentRowIndex).Item(searchCol) = Int(searchValue) Then
                table.Rows(currentRowIndex).Item(addCol) = table.Rows(currentRowIndex).Item(addCol) + addValue
                Exit Sub
            End If
            currentRowIndex += 1

        Next

        addNewItem(searchValue, addValue)

    End Sub

    Function getValue(row, column)

        Return table.Rows(row).Item(column).ToString()

    End Function

    Public Sub printQuantities()

        setIndexToZero()
        For Each row As DataRow In table.Rows

            Console.WriteLine(getValue(currentRowIndex, 0) + "," + getValue(currentRowIndex, 1))
            addRowCount()
        Next

    End Sub

    Public Sub addNewItem(name, quantity)

        table.Rows.Add(name, quantity)

    End Sub

    Function getRowCount()

        Return table.Rows.Count()

    End Function
End Class
