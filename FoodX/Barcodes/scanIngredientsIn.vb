Public Class scanIngredientsIn

    Dim IngredientBarcodes As IngredientBarcodes = New IngredientBarcodes
    Dim Ingredients As Ingredients = New Ingredients

    Dim totalPrice As Double = 0
    Dim connected As Boolean = False

    Dim com As IO.Ports.SerialPort = My.Computer.Ports.OpenSerialPort(My.Settings.scannerPort)

    Private Sub scanIngredientsIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        formatListView()
        StartScanner()

        Me.txtScanIn.Select()

    End Sub

    Private Sub formatListView()

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

    End Sub

    Private Sub txtScanIn_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtScanIn.KeyDown

        If e.KeyCode = Keys.Enter Then

            addIngredientBarcode(Me.txtScanIn.Text)
            Me.txtScanIn.Text = ""

        End If

        Me.txtScanIn.Select()

    End Sub

    Public Sub addIngredientBarcode(barcode)

        Try

            Dim addIngredientBarcode As AddIngredientBarcode = New AddIngredientBarcode

            AddToIngListView(barcode, addIngredientBarcode.getBarcodeDataArray(barcode))

            totalPrice = totalPrice + addIngredientBarcode.getPrice()

            Me.txtTotalPrice.Text = "£" + Format(totalPrice, "0.00")

        Catch err As System.IndexOutOfRangeException

            Dim oForm As NewBarcode
            oForm = New NewBarcode(barcode, Me, True)
            oForm.Show()

            Exit Sub

        Finally

        End Try

    End Sub

    Public Sub AddToIngListView(barcode, array)

        Me.lvIngredients.Items.Add(barcode).SubItems.AddRange(array)

    End Sub

    Private Sub butReconcile_Click(sender As Object, e As EventArgs) Handles butReconcile.Click

        Dim currentIngredientID As String
        Dim quantity As Integer

        For Each item As ListViewItem In Me.lvIngredients.Items

            currentIngredientID = item.SubItems(1).Text
            quantity = item.SubItems(3).Text

            updateIngredientData(item)

        Next

        MsgBox("Reconcile complete!", vbOKOnly, "Ingredients Added")

        Me.Close()

    End Sub

    Public Sub updateIngredientData(currentIngredientItem As ListViewItem)

        Dim ingredientID As String = currentIngredientItem.SubItems(1).Text
        Dim addQuantity As Integer = currentIngredientItem.SubItems(3).Text
        Dim price As Double = currentIngredientItem.SubItems(4).Text

        Ingredients.addColumnsForReturn("quantity")
        Ingredients.addConditions("ingredientID", ingredientID)
        Ingredients.executeSelect("tblIngredients")

        price = price / addQuantity

        Dim currentQuantity As Integer = Int(Ingredients.getValue(0, 0))
        addQuantity = currentQuantity + addQuantity

        Ingredients.addValues("quantity", addQuantity)
        Ingredients.addValues("price", price)
        Ingredients.addConditions("ingredientID", ingredientID)
        Ingredients.executeUpdate("tblIngredients")

    End Sub
    Function getIngredientName(ingredientID)

        Ingredients.addColumnsForReturn("name")
        Ingredients.addConditions("ingredientID", ingredientID)
        Ingredients.executeSelect("tblIngredients")

        Return Ingredients.getIngredientName(ingredientID)

    End Function

    Private Sub StartScanner()

        com.ReadTimeout = 1000
        com.WriteLine("a")
        connected = True
        Me.txtScanIn.Focus()


    End Sub

    Private Sub laserDisconnect_Tick(sender As Object, e As EventArgs) Handles laserDisconnect.Tick
        laserDisconnect.Stop()
    End Sub

    Private Sub scanIngredientsFormClose(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        com.WriteLine("b")
        laserDisconnect.Start()
        connected = False
        com.Close()

    End Sub

    Private Sub lvIngredients_DoubleClick(sender As Object, e As EventArgs) Handles lvIngredients.DoubleClick

        Dim oForm As NewBarcode
        oForm = New NewBarcode(Me.lvIngredients.FocusedItem, Me, False)
        oForm.Show()

    End Sub
End Class