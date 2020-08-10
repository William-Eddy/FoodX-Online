Public Class QuantityList

    Inherits DatabaseTable

    Public Sub addItem(ID, quantity)

        Dim rows() As DataRow = getTableSelect("id", ID)

        If rows.Count > 0 Then
            rows(0).Item("quantity") = rows(0).Item("quantity") + 1
        Else
            table.Rows.Add(Str(ID), Int(quantity))
        End If

    End Sub

    Public Sub setColumns()

        With table.Columns

            .Add("id", GetType(String))
            .Add("quantity", GetType(Integer))

        End With

    End Sub

End Class


