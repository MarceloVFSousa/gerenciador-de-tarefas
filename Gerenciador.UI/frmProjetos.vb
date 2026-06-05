Imports Gerenciador.Application.Services
Imports Gerenciador.Domain.Entities

Public Class frmProjetos

    Private projetoService As New ProjetoService()

    'Abertura do Formulário
    Private Sub frmProjetos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvProjetos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProjetos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProjetos.ReadOnly = True
        dgvProjetos.AllowUserToAddRows = False

        CarregarProjetos()

    End Sub


    'Carregar projetos do datagridview
    Private Sub CarregarProjetos()

        Try

            If projetoService Is Nothing Then
                projetoService = New ProjetoService()
            End If

            Dim lista As List(Of Projeto)

            lista = projetoService.ListarProjetos()

            If lista Is Nothing Then
                lista = New List(Of Projeto)
            End If

            dgvProjetos.DataSource = Nothing
            dgvProjetos.DataSource = lista

        Catch ex As Exception

            MessageBox.Show("Erro ao carregar projetos: " & ex.Message)

        End Try

    End Sub

    'Catch ex As Exception

    'MessageBox.Show("Erro ao carregar projetos: " & ex.Message)

    'End Try

    'End Sub


    'Ajuste das colunas
    Private Sub AjustarColunasGrid()

        If dgvProjetos.Columns.Count = 0 Then Exit Sub

        If dgvProjetos.Columns.Contains("Id") Then
            dgvProjetos.Columns("Id").Visible = False
        End If

        If dgvProjetos.Columns.Contains("Nome") Then
            dgvProjetos.Columns("Nome").HeaderText = "Nome"
            dgvProjetos.Columns("Nome").Width = 200
        End If

        If dgvProjetos.Columns.Contains("Descricao") Then
            dgvProjetos.Columns("Descricao").HeaderText = "Descrição"
            dgvProjetos.Columns("Descricao").Width = 350
        End If

        If dgvProjetos.Columns.Contains("DataCriacao") Then
            dgvProjetos.Columns("DataCriacao").HeaderText = "Data de Criação"
            dgvProjetos.Columns("DataCriacao").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
        End If

    End Sub


    'Botão salvar
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            Dim nome As String = txtNome.Text.Trim()
            Dim descricao As String = txtDescricao.Text.Trim()

            'Validação adicional para criação de projeto
            If nome.Length < 3 Then

                MessageBox.Show(
                    "O nome do projeto deve possuir pelo menos 3 caracteres.",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning)

                txtNome.Focus()

                Return

            End If

            projetoService.CriarProjeto(nome, descricao)

            MessageBox.Show(
                "Projeto criado com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            LimparCampos()

            CarregarProjetos()

        Catch ex As Exception

            MessageBox.Show("Erro ao salvar projeto: " & ex.Message)

        End Try

    End Sub


    'Limpar campos após salvar
    Private Sub LimparCampos()

        txtNome.Clear()
        txtDescricao.Clear()

        txtNome.Focus()

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        Try

            If dgvProjetos.SelectedRows.Count = 0 Then

                MessageBox.Show("Selecione um projeto para excluir.")
                Return

            End If

            Dim id As Integer = Convert.ToInt32(dgvProjetos.SelectedRows(0).Cells("Id").Value)

            Dim confirmacao = MessageBox.Show(
                "Deseja realmente excluir este projeto?" & vbCrLf & vbCrLf &
                "Todas as tarefas vinculadas a este projeto também serão removidas." & vbCrLf & vbCrLf &
                "Esta ação não poderá ser desfeita.",
                "Confirmação de Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            )

            If confirmacao = DialogResult.Yes Then

                projetoService.ExcluirProjeto(id)

                MessageBox.Show(
                    "Projeto excluído com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                CarregarProjetos()

            End If

        Catch ex As Exception

            MessageBox.Show("Erro ao excluir projeto: " & ex.Message)

        End Try

    End Sub

    Private Sub btnAbrirTarefas_Click(sender As Object, e As EventArgs) Handles btnAbrirTarefas.Click

        If dgvProjetos.SelectedRows.Count = 0 Then

            MessageBox.Show("Selecione um projeto.")

            Return

        End If

        Dim id As Integer = Convert.ToInt32(dgvProjetos.SelectedRows(0).Cells("Id").Value)

        Dim nomeProjeto As String = dgvProjetos.SelectedRows(0).Cells("Nome").Value.ToString()

        Dim tela As New frmTarefas()

        tela.ProjetoId = id
        tela.NomeProjeto = nomeProjeto

        tela.ShowDialog()

    End Sub

    Private Sub dgvProjetos_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvProjetos.DataBindingComplete

        AjustarColunasGrid()

    End Sub
End Class