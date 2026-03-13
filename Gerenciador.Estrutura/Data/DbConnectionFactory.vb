Imports System.Data.SqlClient

Public Class DbConnectionFactory

    Public Shared Function CreateConnection() As SqlConnection

        Dim connectionString As String =
            "Server=.\SQLEXPRESS;Database=GerenciadorDeTarefasDB;Trusted_Connection=True;"

        Dim conn As New SqlConnection(connectionString)

        conn.Open()

        Return conn

    End Function

End Class