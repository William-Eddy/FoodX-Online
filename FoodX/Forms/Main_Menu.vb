Imports Emgu.CV

Public Class Main_Menu

    Dim connected As Boolean
    Public shoppingList As New ShoppingListGeneration
    Dim videoCapture As New VideoCapture

    Dim advancedOperations As AdvancedOperations = New AdvancedOperations

    Private Sub ButDashboard_Click(sender As Object, e As EventArgs) Handles butDashboard.Click
        setCurrentTab(0)
        setTabTitle()
    End Sub

    Private Sub ButMeals_Click(sender As Object, e As EventArgs) Handles butMeals.Click
        setCurrentTab(5)
        setTabTitle()

        populateMealListviews()

    End Sub

    Public Sub populateMealListviews()

        Dim listviewFormatting As MealListviewFormatting = New MealListviewFormatting

        lbBreakfast.DataSource = listviewFormatting.getMealsFromDatabase("Breakfast")
        lbLunchDinner.DataSource = listviewFormatting.getMealsFromDatabase("Lunch/Dinner")
        lbSnacks.DataSource = listviewFormatting.getMealsFromDatabase("Pre-workout/Snack")
        lbDrinks.DataSource = listviewFormatting.getMealsFromDatabase("Drink")

    End Sub

    Private Sub ButStock_Click(sender As Object, e As EventArgs) Handles butStock.Click
        Dim stockForm As Stock = New Stock
        stockForm.Show()
    End Sub

    Private Sub ButScan_Click(sender As Object, e As EventArgs) Handles butScan.Click

        Dim scanIngredientsIn As scanIngredientsIn = New scanIngredientsIn
        scanIngredientsIn.Show()

        'cameraTimer.Start()

    End Sub

    Private Sub ButSettings_Click(sender As Object, e As EventArgs) Handles butSettings.Click
        setCurrentTab(4)
        setTabTitle()
    End Sub

    Private Sub setTabTitle()
        Me.txtTabTitle.Text = mainTabControl.SelectedTab.Text
    End Sub

    Private Sub setCurrentTab(index)
        mainTabControl.SelectTab(index)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        StartScanner()

    End Sub

    Private Sub StartScanner()

        Try

            Dim com As IO.Ports.SerialPort = My.Computer.Ports.OpenSerialPort(My.Settings.scannerPort)

            If connected = False Then
                com.ReadTimeout = 1000
                com.WriteLine("a")
                connected = True
                Me.txtScanIn.Focus()
            Else
                com.WriteLine("b")
                laserDisconnect.Start()
                connected = False
            End If

            com.Close()


        Catch e As System.IO.IOException

            Me.lblNoScanner.Visible = True
            Me.lblQuestionMark.Visible = True

        End Try



    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles butConnect.Click

        My.Settings.Save()

        If MainConnectionAccess.conndb.checkConnectionState = 0 Then

            butConnect.Text = "Connecting..."
            txtOnline.Text = "⬤ Connecting..."
            MainConnectionAccess.conndb.establishConnection()
        Else
            MainConnectionAccess.conndb.closeConnection()
        End If

    End Sub

    Private Sub checkStatus_Tick(sender As Object, e As EventArgs) Handles checkStatus.Tick

        If MainConnectionAccess.conndb.checkConnectionState = 1 Then

            butConnect.BackColor = Color.Green
            butConnect.Text = "Disconnect"
            Me.txtOnline.ForeColor = Color.LightGreen
            Me.txtOnline.Text = "⬤ Online"


        Else
            butConnect.BackColor = Color.SlateBlue
            butConnect.Text = "Connect"
            Me.txtOnline.ForeColor = Color.White
            Me.txtOnline.Text = "⬤ Offline"
        End If

    End Sub

    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If MainConnectionAccess.conndb.checkConnectionState = 0 Then
            MainConnectionAccess.conndb.establishConnection()
        End If

        loadContainersInUse()
        loadAverageNutritionalInfo()

    End Sub

    Private Sub laserDisconnect_Tick(sender As Object, e As EventArgs) Handles laserDisconnect.Tick
        laserDisconnect.Stop()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        setCurrentTab(7)
        setTabTitle()

        displayMealEditDays()

    End Sub

    Private Sub ButReconcile_Click(sender As Object, e As EventArgs)

        Me.Refresh()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim oForm As MakeList

        oForm = New MakeList()
        oForm.Show()

    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs)

        Dim editMenu As ChangeMealPlan
        editMenu = New ChangeMealPlan(0)
        editMenu.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

        displayMealEditDays()

    End Sub

    Private Sub displayMealEditDays()

        Dim editMonday As EditFormsManagement = New EditFormsManagement(0)
        panelMonday.Controls.Add(editMonday.editMenu)
        editMonday.show()

        Dim editTuesday As EditFormsManagement = New EditFormsManagement(1)
        panelTuesday.Controls.Add(editTuesday.editMenu)
        editTuesday.show()

        Dim editWednesday As EditFormsManagement = New EditFormsManagement(2)
        panelWednesday.Controls.Add(editWednesday.editMenu)
        editWednesday.show()

        Dim editThursday As EditFormsManagement = New EditFormsManagement(3)
        panelThursday.Controls.Add(editThursday.editMenu)
        editThursday.show()

        Dim editFriday As EditFormsManagement = New EditFormsManagement(4)
        panelFriday.Controls.Add(editFriday.editMenu)
        editFriday.show()

        Dim editSaturday As EditFormsManagement = New EditFormsManagement(5)
        panelSaturday.Controls.Add(editSaturday.editMenu)
        editSaturday.show()

        Dim editSunday As EditFormsManagement = New EditFormsManagement(6)
        panelSunday.Controls.Add(editSunday.editMenu)
        editSunday.show()


    End Sub

    Private Sub lbBreakfast_DoubleClick(sender As Object, e As EventArgs) Handles lbBreakfast.DoubleClick

        openMealEditForm(lbBreakfast.SelectedValue)

    End Sub
    Private Sub lbLunchDinner_DoubleClick(sender As Object, e As EventArgs) Handles lbLunchDinner.DoubleClick

        openMealEditForm(lbLunchDinner.SelectedValue)

    End Sub

    Private Sub lbSnacks_DoubleClick(sender As Object, e As EventArgs) Handles lbSnacks.DoubleClick

        openMealEditForm(lbSnacks.SelectedValue)

    End Sub


    Private Sub lbDrinks_DoubleClick(sender As Object, e As EventArgs) Handles lbDrinks.DoubleClick

        openMealEditForm(lbDrinks.SelectedValue)

    End Sub

    Private Sub openMealEditForm(mealID)

        Dim editMealForm As EditMeal = New EditMeal(mealID, Me)
        editMealForm.Show()

    End Sub

    Private Sub butNewMeal_Click(sender As Object, e As EventArgs) Handles butNewMeal.Click

        Dim editMealForm As EditMeal = New EditMeal(0, Me)
        editMealForm.Show()

    End Sub
    Private Sub cameraTimer_Tick(sender As Object, e As EventArgs) Handles cameraTimer.Tick

        videoCapture = New VideoCapture

        Try
            pbCamera.Image = videoCapture.QueryFrame.ToBitmap

        Catch ecam As System.NullReferenceException
            MsgBox("No camera connected")

        End Try

    End Sub

    Private Sub Scan_Leave(sender As Object, e As EventArgs) Handles Scan.Leave

        StartScanner()

    End Sub

    Private Sub butResetPrices_Click(sender As Object, e As EventArgs) Handles butResetPrices.Click

        advancedOperations.resetPrices()

    End Sub

    Private Sub butResetIngredientStock_Click(sender As Object, e As EventArgs) Handles butResetIngredientStock.Click

        advancedOperations.resetIngredientStock()

    End Sub

    Private Sub butResetMealStock_Click(sender As Object, e As EventArgs) Handles butResetMealStock.Click

        advancedOperations.resetMealStock()

    End Sub

    Private Sub butResetPendingStock_Click(sender As Object, e As EventArgs) Handles butResetPendingStock.Click

        advancedOperations.resetPendingStock()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        Dim containers As Containers = New Containers

        MsgBox(containers.getTotalNumberOfContainersInUse)

    End Sub

    Private Sub loadContainersInUse()

        Dim containers As Containers = New Containers
        Dim foodStorage As FoodStorage = New FoodStorage

        Dim containersInUse As Integer = containers.getTotalNumberOfContainersInUse

        Me.txtContainersInUse.Text = containersInUse
        Me.txtContainersFree.Text = foodStorage.getFreezerCapacity()

    End Sub

    Private Sub loadAverageNutritionalInfo()

        Dim nutritionalInfo As MealsWithNutritionalInfo = New MealsWithNutritionalInfo
        Dim nutritionGoals As NutritionCalculation = New NutritionCalculation

        nutritionalInfo.setNutritionalAverages()


        Dim caloriesGoal As Integer = Int(nutritionGoals.getCalorieGoal)
        Dim caloriesActual As Integer = Int(getAverage(nutritionalInfo.getTotalCalories))
        Dim caloriesDifference As Double = caloriesActual - caloriesGoal

        If caloriesActual > caloriesGoal Then
            Me.txtCalories.ForeColor = Color.LightGreen
        Else
            Me.txtCalories.ForeColor = Color.Red
        End If

        lblCalories.Text += " (" + Str(caloriesDifference) + ")"
        Me.txtCalories.Text = caloriesActual




        Dim proteinGoal As Integer = Int(nutritionGoals.getProteinGoal)
        Dim proteinActual As Integer = Int(getAverage(nutritionalInfo.getTotalProtein))
        Dim proteinDifference As Double = proteinActual - proteinGoal

        If proteinActual > proteinGoal Then
            Me.txtProtein.ForeColor = Color.LightGreen
        Else
            Me.txtProtein.ForeColor = Color.Red
        End If

        lblprotein.Text += " (" + Str(proteinDifference) + ")"
        Me.txtProtein.Text = Str(proteinActual) + "g"




        Dim carbsGoal As Integer = Int(nutritionGoals.getCarbsGoal)
        Dim carbsActual As Integer = Int(getAverage(nutritionalInfo.getTotalCarbs))
        Dim carbsDifference As Double = carbsActual - carbsGoal

        If carbsActual > carbsGoal Then
            Me.txtCarbs.ForeColor = Color.LightGreen
        Else
            Me.txtCarbs.ForeColor = Color.Red
        End If

        lblCarbs.Text += " (" + Str(carbsDifference) + ")"
        Me.txtCarbs.Text = Str(carbsActual) + "g"




        Dim fatGoal As Integer = Int(nutritionGoals.getFatGoal)
        Dim fatActual As Integer = Int(getAverage(nutritionalInfo.getTotalFat))
        Dim fatDifference As Double = fatActual - fatGoal

        If fatActual > fatGoal Then
            Me.txtFat.ForeColor = Color.LightGreen
        Else
            Me.txtFat.ForeColor = Color.Red
        End If

        lblFat.Text += " (" + Str(fatDifference) + ")"
        Me.txtFat.Text = Str(fatActual) + "g"



    End Sub

    Function getAverage(value)

        Return Str(Math.Ceiling(value / 7))

    End Function

    Private Sub butProgress_Click(sender As Object, e As EventArgs) Handles butProgress.Click

        setCurrentTab(8)
        setTabTitle()
        updateMeasurementsListview()
        updateGoals()

    End Sub

    Private Sub butSave_Click(sender As Object, e As EventArgs) Handles butSave.Click

        Dim editMeasurement As EditMeasurement = New EditMeasurement(Me)
        editMeasurement.Show()

    End Sub

    Private Sub lvMeasurements_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvMeasurements.MouseDoubleClick

        Dim editMeasurement As EditMeasurement = New EditMeasurement(Me, lvMeasurements.FocusedItem.Text)
        editMeasurement.Show()

    End Sub

    Public Sub updateMeasurementsListview()

        lvMeasurements.Clear()

        setMeasurementListViewFormat()

        Dim measurements As BodyMeasurements = New BodyMeasurements
        Dim insertArray As String()
        measurements.setContents()

        measurements.setRowColumnIndexToZero()

        For Each row In measurements.table.Rows

            insertArray = {measurements.getCurrentDate, measurements.getCurrentWeight + "kg", measurements.getCurrentBodyFat + "%", measurements.getCurrentBicep + "cm"}
            Me.lvMeasurements.Items.Add(measurements.getCurrentMeasurementID).SubItems.AddRange(insertArray)

            measurements.increaseRowCount()
        Next

    End Sub

    Private Sub setMeasurementListViewFormat()

        With Me.lvMeasurements

            .View = View.Details
            .FullRowSelect = True
            .HideSelection = False
            .MultiSelect = False
            .Columns.Add("measurementID", 0)
            .Columns.Add("Date", 80)
            .Columns.Add("Weight", 80)
            .Columns.Add("Body Fat", 80)
            .Columns.Add("Bicep", 80)
            .GridLines = True

        End With

    End Sub

    Private Sub updateGoals()

        Dim nutritionGoals As NutritionCalculation = New NutritionCalculation

        Me.txtCalorieGoal.Text = nutritionGoals.getCalorieGoal()
        Me.txtProteinGoal.Text = nutritionGoals.getProteinGoal()
        Me.txtFatGoal.Text = nutritionGoals.getFatGoal()
        Me.txtCarbsGoal.Text = nutritionGoals.getCarbsGoal()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        updateGoals()

    End Sub
End Class