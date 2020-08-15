Imports Renci.SshNet
Imports Renci.SshNet.Common
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class DatabaseConnection
    Dim conn As MySqlConnection
    Dim connIni As Boolean
    Dim portFwld As ForwardedPortLocal
    Dim client As SshClient

    Public query As String = String.Empty
    Public mainPartOfQuery As String = String.Empty
    Public valuesPartOfQuery As String = String.Empty
    Public criteriaPartOfQuery As String = String.Empty
    Public columns As New List(Of String)()
    Public criteria As New List(Of String)()
    Public updateValues As IngredientsRequired = New IngredientsRequired
    Public command As MySqlCommand = New MySqlCommand
    Public Sub establishConnection()

        establishPortForward()
        establishMySQLConnection()

    End Sub

    Public Sub establishMySQLConnection()

        conn = New MySqlConnection("server = " + My.Settings.mysqlAddress + "; port = " + My.Settings.mysqlPort + "; uid = '" + My.Settings.dbUsername + "'; password = '" + My.Settings.dbPassword + "'; database='innovnli_dbuniversityfoodtracker'")

        Console.WriteLine(conn.ConnectionString)

        conn.Open()

        connIni = True

    End Sub
    Public Sub establishPortForward()

        Dim connectionInfo As PasswordConnectionInfo

        connectionInfo = New PasswordConnectionInfo(My.Settings.SSHAddress, Int(My.Settings.SSHPort), My.Settings.SSHUsername, My.Settings.SSHPassword) With {
                .Timeout = TimeSpan.FromSeconds(30)
            }
        client = New SshClient(connectionInfo)
        client.Connect()
        If client.IsConnected Then
            Console.WriteLine("SSH connection successful")
        Else
            Console.WriteLine("SSH connection failed")
        End If

        portFwld = New ForwardedPortLocal(My.Settings.pfBoundHost, Int(My.Settings.pfBoundPort), My.Settings.pfRemoteHost, Int(My.Settings.pfRemotePort))

        '("127.0.0.1", 0, "127.0.0.1", 3306)

        client.AddForwardedPort(portFwld)

        portFwld.Start()

        Console.WriteLine("Port Forward Started")

    End Sub

    Public Function checkConnectionState()

        If connIni = True Then
            Return conn.State
        Else
            Return 0
        End If

    End Function

    Public Sub closeConnection()

        closeDatabaseConnection()
        closePortForward()

    End Sub

    Public Sub closePortForward()

        portFwld.Stop()
        client.Disconnect()

    End Sub

    Public Sub closeDatabaseConnection()

        conn.Close()

    End Sub

    Function getSQLDataTable(sqlcommand)

        Dim adapter As New MySqlDataAdapter(sqlcommand, conn)
        Dim table As New DataTable
        adapter.Fill(table)

        Return table

    End Function

    Function getStringValueString(sqlcommand)

        Dim adapter As New MySqlDataAdapter(sqlcommand, conn)
        Dim table As New DataTable
        adapter.Fill(table)

        Return table.Rows(0).Item(0).ToString()

    End Function

    Private Sub runCommand(commandstring)

        Using command As MySqlCommand = conn.CreateCommand

            command.CommandText = commandstring
            command.ExecuteNonQuery()

        End Using

    End Sub


    Public Sub addNewProduct(barcode, ingredientID, quantity, price)

        Dim query As String = String.Empty
        query &= "INSERT INTO tblIngredientBarcodes (barcode, ingredientID, quantity, price)"
        query &= "VALUES (@barcode,@ingredientID, @quantity, @price)"

        Using command As New MySqlCommand
            With command
                .Connection = conn
                .CommandType = CommandType.Text
                .CommandText = query
                .Parameters.AddWithValue("@barcode", barcode)
                .Parameters.AddWithValue("@ingredientID", Int(ingredientID))
                .Parameters.AddWithValue("@quantity", Int(quantity))
                .Parameters.AddWithValue("@price", price)
            End With
            command.ExecuteNonQuery()
            MsgBox("Insert successful")

        End Using

    End Sub

    Public Sub updatePendingMeals(mealID, quantity)

        Dim query As String = String.Empty
        query = "UPDATE tblMeal SET pending=@pending WHERE mealID=@mealID"
        Using command As New MySqlCommand
            With command
                .Connection = conn
                .CommandType = CommandType.Text
                .CommandText = query
                .Parameters.AddWithValue("@pending", Int(quantity))
                .Parameters.AddWithValue("@mealID", Int(mealID))
            End With
            command.ExecuteNonQuery()

        End Using

    End Sub
    Public Sub executeUpdate(tableName)

        setUpdateQuery()
        setCriteriaQuery()
        query = "UPDATE " + tableName + " SET " + mainPartOfQuery

        If Len(criteriaPartOfQuery) > 0 Then

            query &= " WHERE " + criteriaPartOfQuery

        End If

        setQueryToConnection()
        executeCommand()

        reset()

    End Sub

    Public Sub setUpdateQuery()

        Dim columnName As String
        Dim columnCount As Integer

        columnCount = columns.Count - 1

        For i As Integer = 0 To columnCount

            columnName = columns(i)

            mainPartOfQuery &= columnName + "=@" + columnName

            If i < columnCount Then

                mainPartOfQuery &= ","

            End If

        Next

    End Sub

    Public Sub setCriteriaQuery()

        Dim criteriaName As String
        Dim criteriaCount As Integer

        criteriaCount = criteria.Count - 1

        For i As Integer = 0 To criteriaCount

            criteriaName = criteria(i)

            criteriaPartOfQuery &= (criteriaName + "=@" + criteriaName)

            If i < criteriaCount Then

                criteriaPartOfQuery &= ","

            End If

        Next

    End Sub

    Public Sub addConditions(columnName, value)

        command.Parameters.AddWithValue("@" + columnName, value)
        criteria.Add(columnName)


    End Sub

    Public Sub setQueryToConnection()

        With command
            .Connection = conn
            .CommandType = CommandType.Text
            .CommandText = query
        End With

    End Sub

    Public Sub addValues(columnName, value)

        command.Parameters.AddWithValue("@" + columnName, value)
        columns.Add(columnName)

    End Sub

    Public Sub executeCommand()

        command.ExecuteNonQuery()

    End Sub

    Public Sub executeInsert(tableName)

        setInsertQuery()
        setInsertValueQuery()

        query = "INSERT INTO " + tableName + mainPartOfQuery + " VALUES " + valuesPartOfQuery
        setQueryToConnection()
        executeCommand()

        reset()

    End Sub

    Public Sub reset()

        columns.Clear()
        criteria.Clear()
        command = New MySqlCommand
        mainPartOfQuery = String.Empty
        valuesPartOfQuery = String.Empty
        criteriaPartOfQuery = String.Empty

    End Sub

    Public Sub setInsertQuery()

        Dim columnName As String
        Dim columnCount As Integer

        mainPartOfQuery &= "("

        columnCount = columns.Count - 1

        For i As Integer = 0 To columnCount

            columnName = columns(i)

            mainPartOfQuery &= columnName

            If i < columnCount Then

                mainPartOfQuery &= ","

            End If

        Next

        mainPartOfQuery &= ")"

    End Sub

    Public Sub setInsertValueQuery()

        Dim columnName As String
        Dim columnCount As Integer

        columnCount = columns.Count - 1

        valuesPartOfQuery &= "("

        For i As Integer = 0 To columnCount

            columnName = columns(i)

            valuesPartOfQuery &= "@" + columnName

            If i < columnCount Then

                valuesPartOfQuery &= ","

            End If

        Next

        valuesPartOfQuery &= ")"

    End Sub
End Class