Public Class ShoppingListEmail

    Inherits Emails
    Dim totalPrice As Double
    Public Sub New()

        htmlFolderPath &= "Shopping_List\"

    End Sub

    Public Sub setEmailSetup()


        setEmailAccountSettings()
        createNewEmail()
        setRecipient(My.Settings.emailAddress)
        setSubject("Here's your shopping list")

    End Sub

    Public Sub setBodyPart1()

        addHTMLFileToBody(htmlFolderPath + "Shopping_List_Email_Part1.html")

    End Sub

    Public Sub setBodyPart2()

        addHTMLFileToBody(htmlFolderPath + "Shopping_List_Email_Part2.html")

    End Sub

    Public Sub setBodyPart3()

        addHTMLFileToBody(htmlFolderPath + "Shopping_List_Email_Part3.html")

    End Sub

    Public Sub addIngredient(ingredientName As String, price As Double, quantity As String, unit As String)


        Dim subTotalPrice As Double = price * quantity

        totalPrice += subTotalPrice

        If unit = "Unit" Then
            ingredientName = quantity + " " + ingredientName
        Else
            ingredientName = quantity + unit + " of " + ingredientName
        End If

        addHTMLFileToBody(htmlFolderPath + "AddItem\Shopping_List_Email_AddItemPart1.html")
        addToBody(ingredientName)
        addHTMLFileToBody(htmlFolderPath + "AddItem\Shopping_List_Email_AddItemPart2.html")
        addToBody("£" + Format(subTotalPrice, "0.00"))
        addHTMLFileToBody(htmlFolderPath + "AddItem\Shopping_List_Email_AddItemPart3.html")

    End Sub

    Public Sub addTotal()

        addToBody("£" + Format(totalPrice, "0.00"))

    End Sub

    Public Sub setHTMLFolder(path)

        htmlFolderPath = path

    End Sub


End Class
