Imports System.Data.SqlClient

Namespace Data

    Public Class DbConnectionFactory

        Private Shared ReadOnly connectionString As String =
            "Server=.\SQLEXPRESS;Database=GerenciadorDeTarefasDB;Trusted_Connection=True;"

        Public Shared Function CreateConnection() As SqlConnection

            Dim conn As New SqlConnection(connectionString)
            conn.Open()

            Return conn

        End Function

    End Class

End Namespace