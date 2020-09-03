Imports Emgu.CV

Public Class Main_Menu

    Dim connected As Boolean
    Public shoppingList As New ShoppingListGeneration
    Dim videoCapture As New VideoCapture

    Private Sub ButDashboard_Click(sender As Object, e As EventArgs) Handles butDashboard.Click
        SetCurrentTab(0)
        SetTabTitle()
    End Sub

    Private Sub ButMeals_Click(sender As Object, e As EventArgs) Handles butMeals.Click
        SetCurrentTab(5)
        SetTabTitle()

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
        SetCurrentTab(6)
        SetTabTitle()
    End Sub

    Private Sub ButScan_Click(sender As Object, e As EventArgs) Handles butScan.Click
        SetCurrentTab(3)
        SetTabTitle()
        StartScanner()

        With lvIngredients
            .View = View.Details
            .FullRowSelect = True
            .HideSelection = False
            .MultiSelect = False
            .Columns.Add("barcode", 0)
            .Columns.Add("ingID", 0)
            .Columns.Add("Ingredient", 160)
            .Columns.Add("Quantity", 70)
            .Columns.Add("Price")
        End With

        'cameraTimer.Start()

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

    End Sub

    Private Sub laserDisconnect_Tick(sender As Object, e As EventArgs) Handles laserDisconnect.Tick
        laserDisconnect.Stop()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        SetCurrentTab(7)
        SetTabTitle()

        displayMealEditDays()

    End Sub

    Private Sub txtScanIn_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtScanIn.KeyDown

        If e.KeyCode = Keys.Enter Then

            addIngredientBarcode(Me.txtScanIn.Text)
            Me.txtScanIn.Text = ""

        End If

    End Sub

    Public Sub addIngredientBarcode(barcode)

        Try

            Dim addIngredientBarcode As AddIngredientBarcode = New AddIngredientBarcode

            AddToIngListView(barcode, addIngredientBarcode.getBarcodeDataArray(barcode))

        Catch err As System.IndexOutOfRangeException

            Dim oForm As NewBarcode
            oForm = New NewBarcode(barcode, Me)
            oForm.Show()

            Exit Sub

        Finally

        End Try

    End Sub

    Public Sub AddToIngListView(barcode, array)

        Me.lvIngredients.Items.Add(barcode).SubItems.AddRange(array)

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


End Class