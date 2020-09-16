Public Class BodyMeasurements

    Inherits DatabaseTable

    Dim tableName As String = "tblBodyMeasurements"

    Public Sub setContents()

        executeSelect(tableName)

    End Sub
    Public Overloads Sub executeUpdate()

        executeUpdate(tableName)

    End Sub
    Public Overloads Sub executeInsert()

        executeInsert(tableName)

    End Sub

    Function getCurrentMeasurementID()

        Return getCurrentRowValue("measurementID")

    End Function

    Function getCurrentDate()

        Return getCurrentRowValue("date")

    End Function
    Function getCurrentWeight()

        Return getCurrentRowValue("weight")

    End Function
    Function getCurrentWaist()

        Return getCurrentRowValue("waist")

    End Function
    Function getCurrentChest()

        Return getCurrentRowValue("chest")

    End Function
    Function getCurrentShoulders()

        Return getCurrentRowValue("shoulders")

    End Function
    Function getCurrentThigh()

        Return getCurrentRowValue("thigh")

    End Function
    Function getCurrentBicep()

        Return getCurrentRowValue("bicep")

    End Function
    Function getCurrentForearm()

        Return getCurrentRowValue("forearm")

    End Function
    Function getCurrentBodyFat()

        Return getCurrentRowValue("bodyFat")

    End Function

    Public Sub setContentsForMeasurementID(measurementID)

        addConditions("measurementID", measurementID)
        setContents()

    End Sub

End Class
