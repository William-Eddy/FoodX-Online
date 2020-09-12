Imports System.Drawing.Printing
Public Class printStorageLabels

    Dim mealID As String
    Dim mealName As String
    Dim mealQuantity As Integer
    Dim mealParts As MealParts = New MealParts
    Dim linesForPrint As New ArrayList

    Public Sub New(mealID, quantity)

        InitializeComponent()
        Me.mealID = mealID
        Me.mealQuantity = quantity

    End Sub

    Private Sub PrintDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage

        Dim fntText As Font = lvMealParts.Font
        Dim height As Integer
        Dim leftMargin As Integer = PrintDoc.DefaultPageSettings.Margins.Left
        Dim topMargin As Integer = PrintDoc.DefaultPageSettings.Margins.Top + 4

        height = 40

        Dim linesPerPage As Integer = 4
        Dim i As Integer

        For i = 0 To linesForPrint.Count - 1
            e.Graphics.DrawString(linesForPrint(i), fntText, Brushes.Black, leftMargin, 18 * i + topMargin)
        Next

        linesForPrint.Clear()

    End Sub

    Private Sub butPrint_Click(sender As Object, e As EventArgs) Handles butPrint.Click

        Dim totalContainers As Integer

        Dim partName As String
        Dim perContainer As String
        Dim perServing As String

        mealParts.setRowColumnIndexToZero()

        For Each row In mealParts.table.Rows

            totalContainers = mealParts.getCurrentTotalContainers(mealQuantity)

            For i = 0 To totalContainers - 1

                perContainer = mealParts.getCurrentPerContainer
                perServing = mealParts.getCurrentPerServing

                If mealParts.getCurrentCompleteMealStatus = True Then

                    linesForPrint.Add(mealName)
                    linesForPrint.Add("Made: " + String.Format("{0:dd/MM/yyyy}", DateTime.Now))

                Else

                    partName = mealParts.getCurrentPartName
                    linesForPrint.Add(perContainer + " " + partName + " for")
                    linesForPrint.Add(mealName + "     Serves: " + perServing)

                End If

                setPrintSettings()
                PrintDoc.Print()

            Next

            mealParts.increaseRowCount()

        Next

    End Sub

    Private Sub setPrintSettings()

        PrintDialog.PrinterSettings = PrintDoc.PrinterSettings

        Dim pageSetup As New PageSettings

        With pageSetup

            .Margins.Left = 2
            .Margins.Right = 2
            .Margins.Top = 2
            .Margins.Bottom = 2
            .Landscape = False

        End With

        PrintDoc.DefaultPageSettings = pageSetup

    End Sub
    Private Sub setMealPartsListViewFormat()

        With Me.lvMealParts

            .View = View.Details
            .FullRowSelect = True
            .HideSelection = False
            .MultiSelect = False
            .Columns.Add("mealPartID", 0)
            .Columns.Add("Part", 125)
            .Columns.Add("Per serving", 70)
            .Columns.Add("Per container", 80)
            .Columns.Add("Total", 50)
            .GridLines = True

        End With

    End Sub

    Private Sub populateMealPartsListView()

        lvMealParts.Clear()
        setMealPartsListViewFormat()

        mealParts.setRowColumnIndexToZero()

        Dim insertArray As String()

        MealParts.setPartsContentsForSpecificMealID(mealID)

        For Each row As DataRow In MealParts.table.Rows

            insertArray = {mealParts.getCurrentPartName, mealParts.getCurrentPerServing, mealParts.getCurrentPerContainer, mealParts.getCurrentTotalContainers(mealQuantity)}
            Me.lvMealParts.Items.Add(MealParts.getCurrentMealPartID).SubItems.AddRange(insertArray)

            MealParts.increaseRowCount()

        Next

        MealParts.setRowColumnIndexToZero()

    End Sub

    Private Sub setMealName()

        Dim meals As Meals = New Meals

        meals.addColumnsForReturn("name")
        meals.addConditions("mealID", mealID)
        meals.executeSelect()

        mealName = meals.getCurrentMealName

    End Sub

    Private Sub printStorageLabels_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        populateMealPartsListView()
        setMealName()

    End Sub
End Class