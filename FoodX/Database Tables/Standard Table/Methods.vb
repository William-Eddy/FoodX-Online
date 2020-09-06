Public Class Methods
    Inherits DatabaseTable

    Public Overloads Sub executeSelect()

        executeSelect("tblMethods")

    End Sub

    Public Overloads Sub executeUpdate()

        executeUpdate("tblMethods")

    End Sub

    Function getCurrentOrderID()

        Return getCurrentRowValue("orderID")

    End Function

    Function getCurrentInstruction()

        Return getCurrentRowValue("instruction")

    End Function


End Class
