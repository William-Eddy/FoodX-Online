Public Class Main_Menu
    Dim connected As Boolean
    Public newShoppingList As New ShoppingListGeneration

    Private Sub ButDashboard_Click(sender As Object, e As EventArgs) Handles butDashboard.Click
        SetCurrentTab(0)
        SetTabTitle()
    End Sub

    Private Sub ButMeals_Click(sender As Object, e As EventArgs) Handles butMeals.Click
        SetCurrentTab(5)
        SetTabTitle()

        lbBreakfast.DataSource = MainConnectionAccess.conndb.getSQLDataTable("SELECT `mealID`, `name` FROM `tblMeal` WHERE category='Breakfast'")
        lbLunchDinner.DataSource = MainConnectionAccess.conndb.getSQLDataTable("SELECT `mealID`, `name` FROM `tblMeal` WHERE category='Lunch/Dinner'")
        lbSnacks.DataSource = MainConnectionAccess.conndb.getSQLDataTable("SELECT `mealID`, `name` FROM `tblMeal` WHERE category='Pre-workout/Snack'")
        lbDrinks.DataSource = MainConnectionAccess.conndb.getSQLDataTable("SELECT `mealID`, `name` FROM `tblMeal` WHERE category='Drink'")

    End Sub

    Private Sub ButStock_Click(sender As Object, e As EventArgs) Handles butStock.Click
        SetCurrentTab(6)
        SetTabTitle()
    End Sub

    Private Sub ButScan_Click(sender As Object, e As EventArgs) Handles butScan.Click
        SetCurrentTab(3)
        SetTabTitle()
        'StartScanner()

        With lvIngredients
            .View = View.Details
            .FullRowSelect = True
            .HideSelection = False
            .MultiSelect = False
            .Columns.Add("barcode", 0)
            .Columns.Add("ingID", 0)
            .Columns.Add("Name", 160)
            .Columns.Add("Quantity", 60)
            .Columns.Add("Price", 60)
        End With

        With lvMeals
            .View = View.Details
            .FullRowSelect = True
            .HideSelection = False
            .MultiSelect = False
            .Columns.Add("mealStockbarcode", 0)
            .Columns.Add("mealID", 0)
            .Columns.Add("Name", 160)
            .Columns.Add("Quantity", 80)
            .Columns.Add("Date made", 150)
        End With

    End Sub

    Private Sub ButSettings_Click(sender As Object, e As EventArgs) Handles butSettings.Click
        SetCurrentTab(4)
        SetTabTitle()
    End Sub

    Private Sub SetTabTitle()
        Me.txtTabTitle.Text = mainTabControl.SelectedTab.Text
    End Sub

    Private Sub SetCurrentTab(index)
        mainTabControl.SelectTab(index)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButScanConnect.Click

        'StartScanner()

    End Sub

    Private Sub StartScanner()

        Dim com As IO.Ports.SerialPort = My.Computer.Ports.OpenSerialPort(My.Settings.scannerPort)

        If connected = False Then
            com.ReadTimeout = 1000
            com.WriteLine("a")
            ButScanConnect.BackColor = Color.Green
            ButScanConnect.Text = "Stop"
            connected = True
            Me.txtScanIn.Focus()
        Else
            ButScanConnect.Text = "Disconnecting..."
            ButScanConnect.BackColor = Color.SlateBlue
            com.WriteLine("b")
            laserDisconnect.Start()
            connected = False
        End If

        com.Close()

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

    End Sub

    Private Sub laserDisconnect_Tick(sender As Object, e As EventArgs) Handles laserDisconnect.Tick
        laserDisconnect.Stop()
        ButScanConnect.Text = "Start"
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        SetCurrentTab(1)
        SetTabTitle()
    End Sub

    Private Sub txtScanIn_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtScanIn.KeyDown

        If e.KeyCode = Keys.Enter Then


            If Me.txtScanIn.TextLength = 10 Then
                addMealBarcode()
            Else
                addIngredientBarcode(Me.txtScanIn.Text)
            End If

            Me.txtScanIn.Text = ""

        End If

    End Sub

    Public Sub addIngredientBarcode(barcode)

        Dim ingID As Integer
        Dim barcodeData As DataTable
        Dim name As String
        Dim quantity As String
        Dim price As String
        Dim insertArray As String()

        Try

            barcodeData = MainConnectionAccess.conndb.getSQLDataTable("SELECT `ingredientID`, `quantity`, `price`  FROM `tblIngredientBarcodes` WHERE barcode='" + barcode + "'")
            ingID = barcodeData.Rows(0).Item(0).ToString()
            name = (MainConnectionAccess.conndb.getSQLDataTable("SELECT `name` FROM `tblIngredients` WHERE ingredientID=" + Str(ingID))).Rows(0).Item(0).ToString()
            quantity = barcodeData.Rows(0).Item(1).ToString()
            price = barcodeData.Rows(0).Item(2).ToString()

            insertArray = {ingID, name, quantity, price}

            AddToIngListView(barcode, insertArray)

        Catch err As System.IndexOutOfRangeException

            Dim oForm As NewBarcode
            oForm = New NewBarcode(barcode)
            oForm.Show()

            Exit Sub

        Finally

        End Try

    End Sub

    Private Sub addMealBarcode()

        Dim mealStockData As DataTable
        Dim mealName As String
        Dim madeDate As String
        Dim mealID As String
        Dim insertArray As String()


        mealStockData = (MainConnectionAccess.conndb.getSQLDataTable("SELECT `mealID`, `madedate` FROM `tblMealStock` WHERE mealStockBarcode='" + Me.txtScanIn.Text + "'"))
        madeDate = mealStockData.Rows(0)("madedate").ToString
        mealID = mealStockData.Rows(0).Item(0).ToString()
        mealName = (MainConnectionAccess.conndb.getSQLDataTable("SELECT `name` FROM `tblMeal` WHERE mealID=" + mealID)).Rows(0).Item(0).ToString()

        insertArray = {mealID, mealName, madeDate}

        lvMeals.Items.Add(Me.txtScanIn.Text).SubItems.AddRange(insertArray)


    End Sub

    Public Sub AddToIngListView(barcode, array)

        Me.lvIngredients.Items.Add(barcode).SubItems.AddRange(array)

    End Sub

    Private Sub ButReconcile_Click(sender As Object, e As EventArgs) Handles ButReconcile.Click

        Me.Refresh()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim oForm As MakeList

        oForm = New MakeList()
        oForm.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        getMealPlan()

    End Sub

    Private Sub getMealPlan()

        Dim day As Integer

        MealPlanConnection.mealPlan = New MealPlanOld

        With MealPlanConnection.mealPlan

            .setMealPlanTableData()
            .setMealTableData()

        End With

        day = 0

        MealPlanConnection.mealPlan.resetNutritionalCounts()

        Me.monPreWorkout.Text = MealPlanConnection.mealPlan.getMeal(day, 0)
        Me.monBreakfast.Text = MealPlanConnection.mealPlan.getMeal(day, 1)
        Me.monLunch.Text = MealPlanConnection.mealPlan.getMeal(day, 2)
        Me.monDinner.Text = MealPlanConnection.mealPlan.getMeal(day, 3)
        Me.monSnack.Text = MealPlanConnection.mealPlan.getMeal(day, 4)
        Me.monMornDrink.Text = MealPlanConnection.mealPlan.getMeal(day, 5)
        Me.monAfternoonDrink.Text = MealPlanConnection.mealPlan.getMeal(day, 6)

        Me.MonCalories.Text = "Calories: " + Str(MealPlanConnection.mealPlan.getTotalCalories)
        Me.monFat.Text = "Fat: " + Str(MealPlanConnection.mealPlan.getTotalFat) + "g"
        Me.monProtein.Text = "Protein: " + Str(MealPlanConnection.mealPlan.getTotalProtein) + "g"
        Me.monCarbs.Text = "Carbs: " + Str(MealPlanConnection.mealPlan.getTotalCarbs) + "g"

    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles monMornDrink.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim editMenu As ChangeMealPlan
        editMenu = New ChangeMealPlan(0)
        editMenu.Show()

    End Sub
End Class