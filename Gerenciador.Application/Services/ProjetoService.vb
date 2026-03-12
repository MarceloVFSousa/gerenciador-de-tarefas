Imports Gerenciador.Domain.Entities
Imports Gerenciador.Estrutura.Repositories

Namespace Services

    Public Class ProjetoService

        Private ReadOnly _repository As New ProjetoRepository()

        Public Sub CriarProjeto(nome As String, descricao As String)

            If String.IsNullOrWhiteSpace(nome) Then
                Throw New Exception("O nome do projeto é obrigatório")
            End If

            Dim projeto As New Projeto With {
                .Nome = nome,
                .Descricao = descricao,
                .DataCriacao = DateTime.Now
            }

            _repository.Inserir(projeto)

        End Sub


        Public Function ListarProjetos() As List(Of Projeto)

            Return _repository.Listar()

        End Function

    End Class

End Namespace