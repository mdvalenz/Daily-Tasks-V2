Imports System.Data.OleDb

Public Class accessDBManagerClass

    'Maintain the connection to the DB
    Private _connection As OleDbConnection

    Public Sub New(database As String)

        'Call the connect sub
        Connect(database)

    End Sub

    Public Sub Connect(database As String)

        'Provider to access the database and where the database is located
        Dim dbProvider As String
        Dim dbSource As String

        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = " & My.Settings.DBLocation 'F:\QA\Daily Tasks\Database\Daily Task Log.accdb

        Try

            'Create the connection string
            _connection = New OleDbConnection(dbProvider & dbSource)

            'Open the connection
            _connection.Open()

        Catch ex As Exception

            MsgBox("Error occurred while connecting to the database." & vbNewLine &
                   "Error message: " & ex.Message, MsgBoxStyle.Critical)

            'Destroy the connection
            _connection = Nothing

        End Try

    End Sub

    Public Function GetRecords(table As String,
                               Optional fields As String = "*",
                               Optional where As String = "",
                               Optional orderBy As String = "") As OleDbDataReader

        'SELECT <fields> FROM <table> [WHERE <condition>] [ORDER BY <field> ASC|DESC]

        'Build the query string
        Dim q As String = "SELECT " & fields & " FROM " & table

        'Check if they have a where condition
        If where <> "" Then
            q &= " WHERE " & where
        End If

        'Check if they have an orderBy condition
        If orderBy <> "" Then
            q &= " ORDER BY " & orderBy
        End If

        Try
            'Create the command
            Dim cmd As New OleDbCommand(q, _connection)
            Return cmd.ExecuteReader

        Catch ex As Exception

            MsgBox("Error occurred while fetching data from table " & table & vbNewLine &
                   "Query string: " & q & vbNewLine &
                   "Error message: " & ex.Message, MsgBoxStyle.Critical)

        End Try

        Return Nothing

    End Function

    Public Function getTaskTime(Optional where As String = "") As OleDbDataReader

        'SELECT SUM(TaskTime) FROM Tasks [WHERE <condition>]

        'Build the query string
        Dim q As String = "SELECT SUM(TaskTime) AS 'Total Minutes' FROM Tasks"

        'Check if they have a where condition
        If where <> "" Then
            q &= " WHERE " & where
        End If

        Try
            'Create the command
            Dim cmd As New OleDbCommand(q, _connection)
            Return cmd.ExecuteReader

        Catch ex As Exception

            MsgBox("Error occurred while fetching data from Tasks table " & vbNewLine &
                   "Query string: " & q & vbNewLine &
                   "Error message: " & ex.Message, MsgBoxStyle.Critical)

        End Try

        Return Nothing

    End Function

    Public Function GetRelatedRecords(table1 As String,
                                      table2 As String,
                                      onField1 As String,
                                      onfield2 As String,
                                      Optional fields As String = "*",
                                      Optional where As String = "",
                                      Optional orderBy As String = "") As OleDbDataReader

        'SELECT <fields> FROM <table1> INNER JOIN <table2> ON <field1> = <field2> [WHERE <condition>] [ORDER BY <field> ASC|DESC]

        'Build the query string
        Dim q As String = "SELECT " & fields & " FROM " & table1 & " INNER JOIN " & table2 &
            " ON " & onField1 & "=" & onfield2

        'Check if they have a where condition
        If where <> "" Then
            q &= " WHERE " & where
        End If

        'Check if they have an orderBy condition
        If orderBy <> "" Then
            q &= " ORDER BY " & orderBy
        End If

        Try

            'Create the command
            Dim cmd As New OleDbCommand(q, _connection)
            Return cmd.ExecuteReader

        Catch ex As Exception

            MsgBox("Error occurred while fetching data from table " & table1 & vbNewLine &
                   "Query string: " & q & vbNewLine &
                   "Error message: " & ex.Message, MsgBoxStyle.Critical)

        End Try

        Return Nothing

    End Function

    Public Sub InsertRecord(table As String,
                            fields As String,
                            values As String)

        'INSERT INTO <table>(<fields>) VALUES (<values>)

        'Build the query string
        Dim q As String = "INSERT INTO " & table & "(" & fields & ") VALUES(" & values & ")"

        Try

            'Create the command
            Dim cmd As New OleDbCommand(q, _connection)
            cmd.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error occurred while inserting data into table " & table & vbNewLine &
                   "Query string: " & q & vbNewLine &
                   "Error message: " & ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub

    Public Sub UpdateRecordField(table As String,
                                 field As String,
                                 value As Object,
                                 ID As Integer)

        'UPDATE <table> SET <field>='<value>' [WHERE ID=<id>]

        'Build query string
        Dim q As String = "UPDATE " & table & " SET " & field & "='" & value & "' WHERE ID=" & ID

        Try

            'Create the command
            Dim cmd As New OleDbCommand(q, _connection)
            cmd.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error occurred while updating data in table " & table & vbNewLine &
                   "Query string: " & q & vbNewLine &
                   "Error message: " & ex.Message, MsgBoxStyle.Critical)

        End Try


    End Sub

    Public Sub DeleteRecord(table As String,
                            Optional where As String = "")

        'DELETE FROM <table> [WHERE <condition>]

        'Build the query string
        Dim q As String = "DELETE FROM " & table

        'Check if they have a where condition
        If where <> "" Then
            q &= " WHERE " & where
        End If

        Try

            'Create the command
            Dim cmd As New OleDbCommand(q, _connection)
            cmd.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error occurred while trying to delete data from table " & table & vbNewLine &
                   "Query string: " & q & vbNewLine &
                   "Error message: " & ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub

End Class
