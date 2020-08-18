Public Class EditFormsManagement

    Public editMenu As ChangeMealPlan

    Public Sub New(ByVal dayID As String)

        editMenu = New ChangeMealPlan(dayID)
        With editMenu
            .TopLevel = False

            .BringToFront()
        End With

    End Sub

    Public Sub show()

        editMenu.Show()

    End Sub

End Class
