Imports System.Data.SqlClient
Imports Gerenciador.Domain.Entities

Namespace Repositories

    Public Class ProjetoRepository

        'Método para inserção
        Public Sub Inserir(projeto As Projeto)

            Using conn = DbConnectionFactory.CreateConnection()

                Dim sql As String = "INSERT INTO Projeto (Nome, Descricao, DataCriacao) VALUES (@Nome, @Descricao, @DataCriacao)"


                Using cmd As New SqlCommand(sql, conn)

                    cmd.Parameters.AddWithValue("@Nome", projeto.Nome)
                    cmd.Parameters.AddWithValue("@Descricao", projeto.Descricao)
                    cmd.Parameters.AddWithValue("@DataCriacao", projeto.DataCriacao)

                    cmd.ExecuteNonQuery()

                End Using

            End Using

        End Sub

        'Método para listagem
        Public Function Listar() As List(Of Projeto)

            Dim lista As New List(Of Projeto)

            Using conn = DbConnectionFactory.CreateConnection()

                Dim sql As String = "SELECT * FROM Projeto"

                Using cmd As New SqlCommand(sql, conn)

                    Using reader = cmd.ExecuteReader()

                        While reader.Read()

                            Dim projeto As New Projeto With {
                                .Id = Convert.ToInt32(reader("Id")),
                                .Nome = reader("Nome").ToString(),
                                .Descricao = reader("Descricao").ToString(),
                                .DataCriacao = Convert.ToDateTime(reader("DataCriacao"))
                            }

                            lista.Add(projeto)

                        End While

                    End Using

                End Using

            End Using

            Return lista

        End Function

        'Método para exclusão
        Public Sub Excluir(id As Integer)

            Using conn = DbConnectionFactory.CreateConnection()

                'Primeiro remove as tarefas do projeto
                Dim sqlTarefas As String = "DELETE FROM Tarefa WHERE ProjetoId = @ProjetoId"

                Using cmdTarefas As New SqlClient.SqlCommand(sqlTarefas, conn)
                    cmdTarefas.Parameters.AddWithValue("@ProjetoId", id)
                    cmdTarefas.ExecuteNonQuery()
                End Using

                'Depois remove o projeto
                Dim sqlProjeto As String = "DELETE FROM Projeto WHERE Id = @Id"

                Using cmdProjeto As New SqlClient.SqlCommand(sqlProjeto, conn)
                    cmdProjeto.Parameters.AddWithValue("@Id", id)
                    cmdProjeto.ExecuteNonQuery()
                End Using

            End Using

        End Sub

    End Class

End Namespace