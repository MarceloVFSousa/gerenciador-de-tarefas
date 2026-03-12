Imports System.Data.SqlClient
Imports Gerenciador.Domain.Entities
Imports Gerenciador.Estrutura.Data

Namespace Repositories

    Public Class ProjetoRepository

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

    End Class

End Namespace