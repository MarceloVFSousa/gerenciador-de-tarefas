Imports Gerenciador.Application.Services
Imports Gerenciador.Domain.Entities

Public Class frmProjetos

    Private projetoService As New ProjetoService()

    'Abertura do Formulário
    Private Sub frmProjetos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CarregarProjetos()

        dgvProjetos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProjetos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProjetos.ReadOnly = True
        dgvProjetos.AllowUserToAddRows = False

    End Sub


    'Carregar tarefas do datagridview
    Private Sub CarregarProjetos()

        Try

            Dim lista As List(Of Projeto)

            lista = projetoService.ListarProjetos()

            dgvProjetos.DataSource = Nothing
            dgvProjetos.DataSource = lista

            AjustarColunasGrid()

        Catch ex As Exception

            MessageBox.Show("Erro ao carregar projetos: " & ex.Message)

        End Try

    End Sub


    'Ajuste das colunas
    Private Sub AjustarColunasGrid()

        If dgvProjetos.Columns.Count = 0 Then Exit Sub

        dgvProjetos.Columns("Id").Visible = False

        dgvProjetos.Columns("Nome").HeaderText = "Nome"
        dgvProjetos.Columns("Descricao").HeaderText = "Descrição"
        dgvProjetos.Columns("DataCriacao").HeaderText = "Data de Criação"

        dgvProjetos.Columns("Nome").Width = 200
        dgvProjetos.Columns("Descricao").Width = 350
        dgvProjetos.Columns("DataCriacao").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"

    End Sub


    'Botão salvar
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            Dim nome As String = txtNome.Text.Trim()
            Dim descricao As String = txtDescricao.Text.Trim()

            projetoService.CriarProjeto(nome, descricao)

            MessageBox.Show("Projeto salvo com sucesso!")

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
                "Deseja realmente excluir este projeto?",
                "Confirmação",
                MessageBoxButtons.YesNo
            )

            If confirmacao = DialogResult.Yes Then

                projetoService.ExcluirProjeto(id)

                MessageBox.Show("Projeto excluído com sucesso!")

                CarregarProjetos()

            End If

        Catch ex As Exception

            MessageBox.Show("Erro ao excluir projeto: " & ex.Message)

        End Try

    End Sub

End Class