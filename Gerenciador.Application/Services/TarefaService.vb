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

    Public Sub ExcluirTarefa(id As Integer)

        If id = 0 Then
            Throw New Exception("Tarefa inválida")
        End If

        repository.Excluir(id)

    End Sub

    Public Function FiltrarTarefas(projetoId As Integer, busca As String, status As String, prioridade As String) As List(Of Tarefa)

        Dim lista = repository.ListarPorProjeto(projetoId)

        'Filtro por texto
        If Not String.IsNullOrWhiteSpace(busca) Then
            lista = lista.Where(Function(t) t.Titulo.ToLower().Contains(busca.ToLower())).ToList()
        End If

        'Filtro por status
        If status <> "Todos" Then
            lista = lista.Where(Function(t) t.Status = status).ToList()
        End If

        'Filtro por prioridade
        If prioridade <> "Todas" Then
            lista = lista.Where(Function(t) t.Prioridade = prioridade).ToList()
        End If

        Return lista

    End Function

End Class