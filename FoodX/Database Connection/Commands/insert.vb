Imports MySql.Data.MySqlClient

Public Class Insert

    Inherits DatabaseConnection
    Public query As String = String.Empty
    Public command As MySqlCommand

    Public Sub setQueryToConnection()

        Using command As New MySqlCommand
            With command
                '         .Connection = conn
                .CommandType = CommandType.Text
                .CommandText = query
            End With
        End Using

    End Sub

    Public Sub addValues(column)

        command.Parameters.AddWithValue("@" + column, column)

    End Sub





    Private Sub runCommand(commandstring)

        Using command As MySqlCommand = conn.CreateCommand

            command.CommandText = commandstring
            command.ExecuteNonQuery()

        End Using

    End Sub


    Public Sub addNewProduct(barcode, ingredientID, quantity, price)


        query &= "INSERT INTO tblIngredientBarcodes (barcode, ingredientID, quantity, price)"
        query &= "VALUES (@barcode,@ingredientID, @quantity, @price)"


        .Parameters.AddWithValue("@barcode", barcode)
        .Parameters.AddWithValue("@ingredientID", Int(ingredientID))
        .Parameters.AddWithValue("@quantity", Int(quantity))
        .Parameters.AddWithValue("@price", price)

        command.ExecuteNonQuery()
        MsgBox("Insert successful")

        End Using

    End Sub




End Class
