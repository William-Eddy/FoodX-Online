Public Class ShoppingListEmail

    Inherits Emails

    Dim htmlFolderPath As String = "D:\FoodTrackV1\Emails\Shopping List\"

    Public Sub setEmailSetup()

        setEmailAccountSettings()
        createNewEmail()
        setRecipient("william-eddy@outlook.com")
        setSubject("Here's your shopping list")
        addToBody("test")
        setToBody()
        sendEmail()

    End Sub

    Public Sub setbodypart1()

        addHTMLFileToBody("Shopping_List Email_Part1.html")

    End Sub

    Public Sub addIngredient(ingredientName, price)

        addHTMLFileToBody(htmlFolderPath + "AddItem\Shopping_List_Email_AddItemPart1.html")
        addToBody(ingredientName)
        addHTMLFileToBody(htmlFolderPath + "AddItem\Shopping_List_Email_AddItemPart2.html")
        addToBody(price)
        addHTMLFileToBody(htmlFolderPath + "AddItem\Shopping_List_Email_AddItemPart3.html")


    End Sub

    Public Sub setHTMLFolder(path)

        htmlFolderPath = path

    End Sub




End Class
