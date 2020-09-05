Public Class ShoppingListEmail

    Inherits Emails

    Dim htmlFolderPath As String = "D:\FoodTrackV1\Emails\Shopping_List\"

    Public Sub setEmailSetup()

        setEmailAccountSettings()
        createNewEmail()
        setRecipient("philip.eddy1@ntlworld.com")
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

    Public Sub addIngredient(ingredientName As String, price As String, quantity As String, unit As String)

        If unit = "Unit" Then
            ingredientName = quantity + " " + ingredientName
        Else
            ingredientName = quantity + unit + " of " + ingredientName
        End If

        addHTMLFileToBody(htmlFolderPath + "AddItem\Shopping_List_Email_AddItemPart1.html")
        addToBody(ingredientName)
        addHTMLFileToBody(htmlFolderPath + "AddItem\Shopping_List_Email_AddItemPart2.html")
        addToBody("£" + price)
        addHTMLFileToBody(htmlFolderPath + "AddItem\Shopping_List_Email_AddItemPart3.html")

    End Sub

    Public Sub addTotal(total As String)

        addToBody("£" + total)

    End Sub

    Public Sub setHTMLFolder(path)

        htmlFolderPath = path

    End Sub


End Class
