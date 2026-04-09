Imports Gerenciador.Domain.Entities
Imports Gerenciador.Estrutura

Public Class TarefaService

    Private repository As New TarefaRepository()

    Public Sub CriarTarefa(tarefa As Tarefa)

        repository.Inserir(tarefa)

    End Sub

    Public Sub AtualizarTarefa(tarefa As Tarefa)

        If tarefa.Id = 0 Then
            Throw New Exception("Tarefa inválida")
        End If

        repository.Atualizar(tarefa)

    End Sub

    Public Function ListarPorProjeto(projetoId As Integer) As List(Of Tarefa)

        Return repository.ListarPorProjeto(projetoId)

    End Function

End Class