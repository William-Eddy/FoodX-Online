Public Class MethodEmail

    Inherits Emails

    Dim meals As Meals = New Meals
    Dim mealID As String
    Dim methods As Methods = New Methods
    Dim mealIngredients As MealIngredients = New MealIngredients
    Dim ingredients As Ingredients = New Ingredients

    Public Sub New(mealID)

        Me.mealID = mealID
        htmlFolderPath &= "Methods\"

    End Sub
    Public Sub setEmailSetup()

        setEmailAccountSettings()
        createNewEmail()
        setRecipient(My.Settings.emailAddress)

    End Sub

    Public Sub setMealData()

        meals.addColumnsForReturn("name")
        meals.addConditions("mealID", mealID)
        meals.executeSelect()

    End Sub

    Public Sub setSubjectWithMealName()

        setSubject("Here's how to make " + getMealName())

    End Sub

    Public Sub setBodyParts()

        addHTMLFileToBody(htmlFolderPath + "part1.html")
        addTitleToBody()
        addHTMLFileToBody(htmlFolderPath + "part2.html")
        addInstructionsToBody()
        addHTMLFileToBody(htmlFolderPath + "part3.html")
        addIngredientsToBody()
        addHTMLFileToBody(htmlFolderPath + "part4.html")

    End Sub

    Public Sub addTitleToBody()

        addToBody("Here's how to make " + getMealName())

    End Sub

    Function getMealName()

        Return meals.getCurrentMealName

    End Function

    Public Sub addInstructionsToBody()

        Dim pathExtension As String = "addStep/"
        Dim stepFolderPath As String = htmlFolderPath + pathExtension

        setMethodsContents()

        For Each row In methods.table.Rows

            addHTMLFileToBody(stepFolderPath + "part1.html")
            addToBody(methods.getCurrentOrderID)
            addHTMLFileToBody(stepFolderPath + "part2.html")
            addToBody(methods.getCurrentInstruction)
            addHTMLFileToBody(stepFolderPath + "part3.html")

            methods.increaseRowCount()
        Next

        methods.setRowColumnIndexToZero()

    End Sub

    Public Sub addIngredientsToBody()

        Dim pathExtension As String = "addIngredient/"
        Dim stepFolderPath As String = htmlFolderPath + pathExtension
        Dim ingredientID As String
        Dim ingredientName As String
        Dim quantity As String
        Dim unit As String

        setMealIngredientsContents()
        setIngredientsContents()

        For Each row In mealIngredients.table.Rows

            ingredientID = mealIngredients.getCurrentIngredientID
            quantity = mealIngredients.getCurrentQuantity
            ingredientName = ingredients.getSingleSearchValue("ingredientID", ingredientID, "name")
            unit = ingredients.getSingleSearchValue("ingredientID", ingredientID, "measurement")

            If unit = "Unit" Then
                unit = " "
            Else
                unit &= " of "
            End If

            addHTMLFileToBody(stepFolderPath + "part1.html")
            addToBody(quantity + unit + ingredientName)
            addHTMLFileToBody(stepFolderPath + "part2.html")

            mealIngredients.increaseRowCount()
        Next

        mealIngredients.setRowColumnIndexToZero()

    End Sub

    Public Sub setMethodsContents()

        methods.addColumnsForReturn("orderID")
        methods.addColumnsForReturn("instruction")
        methods.addConditions("mealID", mealID)
        methods.executeSelect()

    End Sub

    Public Sub setMealIngredientsContents()

        mealIngredients.addColumnsForReturn("ingredientID")
        mealIngredients.addColumnsForReturn("quantity")
        mealIngredients.addConditions("mealID", mealID)
        mealIngredients.executeSelect()

    End Sub

    Public Sub setIngredientsContents()

        ingredients.addColumnsForReturn("ingredientID")
        ingredients.addColumnsForReturn("name")
        ingredients.addColumnsForReturn("measurement")
        ingredients.executeSelect()

    End Sub

    Public Sub sendMethodEmail()

        setEmailSetup()
        setMealData()
        setSubjectWithMealName()
        setBodyParts()
        setToBody()
        sendEmail()

    End Sub


End Class
