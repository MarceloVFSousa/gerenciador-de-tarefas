Imports System.Data.SqlClient
Imports Gerenciador.Domain.Entities

Public Class TarefaRepository

    Public Sub Inserir(tarefa As Tarefa)

        Using conn = DbConnectionFactory.CreateConnection()

            Dim sql As String = "SELECT * FROM Tarefa WHERE ProjetoId = @ProjetoId ORDER BY CASE WHEN Status = 'Concluído' THEN 2 ELSE 1 END, CASE Prioridade WHEN 'Alta' THEN 1 WHEN 'Média' THEN 2 WHEN 'Baixa' THEN 3 END"

            Using cmd As New SqlCommand(sql, conn)

                cmd.Parameters.AddWithValue("@ProjetoId", tarefa.ProjetoId)
                cmd.Parameters.AddWithValue("@Titulo", tarefa.Titulo)
                cmd.Parameters.AddWithValue("@Descricao", tarefa.Descricao)
                cmd.Parameters.AddWithValue("@Status", tarefa.Status)
                cmd.Parameters.AddWithValue("@Prioridade", tarefa.Prioridade)

                cmd.ExecuteNonQuery()

            End Using

        End Using

    End Sub

    Public Function ListarPorProjeto(projetoId As Integer) As List(Of Tarefa)

        Dim lista As New List(Of Tarefa)

        Using conn = DbConnectionFactory.CreateConnection()

            Dim sql As String = "SELECT * FROM Tarefa WHERE ProjetoId = @ProjetoId ORDER BY CASE Prioridade WHEN 'Alta' THEN 1 WHEN 'Média' THEN 2 WHEN 'Baixa' THEN 3 END, DataCriacao DESC"

            Using cmd As New SqlClient.SqlCommand(sql, conn)

                cmd.Parameters.AddWithValue("@ProjetoId", projetoId)

                Using reader = cmd.ExecuteReader()

                    While reader.Read()

                        Dim tarefa As New Tarefa()

                        tarefa.Id = Convert.ToInt32(reader("Id"))
                        tarefa.ProjetoId = Convert.ToInt32(reader("ProjetoId"))
                        tarefa.Titulo = reader("Titulo").ToString()
                        tarefa.Descricao = reader("Descricao").ToString()
                        tarefa.Status = reader("Status").ToString()
                        tarefa.Prioridade = reader("Prioridade").ToString()
                        tarefa.DataCriacao = Convert.ToDateTime(reader("DataCriacao"))

                        lista.Add(tarefa)

                    End While

                End Using

            End Using

        End Using

        Return lista

    End Function

End Class