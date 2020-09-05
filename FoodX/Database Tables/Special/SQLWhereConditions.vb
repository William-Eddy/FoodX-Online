Public Class SQLWhereConditions

    Inherits DatabaseTable

    Public Sub New()

        setColumns()

    End Sub

    Public Sub addCondition(columnName, Optional mathOperator = "=")

        table.Rows.Add(columnName, mathOperator)

    End Sub

    Public Sub setColumns()

        With table.Columns

            .Add("columnName", GetType(String))
            .Add("mathOperator", GetType(String))

        End With

    End Sub


End Class
