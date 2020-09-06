Public Class Methods
    Inherits DatabaseTable

    Public Overloads Sub executeSelect()

        executeSelect("tblMethodSteps")

    End Sub

    Public Overloads Sub executeUpdate()

        executeUpdate("tblMethodSteps")

    End Sub

    Public Overloads Sub executeInsert()

        executeInsert("tblMethodSteps")

    End Sub

    Function getCurrentOrderID()

        Return getCurrentRowValue("orderID")

    End Function

    Function getCurrentInstruction()

        Return getCurrentRowValue("instruction")

    End Function

    Function getCurrentStepID()

        Return getCurrentRowValue("stepID")

    End Function

    Function getHighestOrderID(mealID)

        addColumnsForReturn("orderID")
        addConditions("mealID", mealID)
        executeSelect()

        Dim highestOrderID As Integer = 0
        Dim currentOrderID As Integer

        For Each row As DataRow In table.Rows()

            currentOrderID = getCurrentOrderID()

            If currentOrderID > highestOrderID Then
                highestOrderID = currentOrderID
            End If

            increaseRowCount()

        Next

        setRowColumnIndexToZero()

        Return highestOrderID

    End Function


End Class
