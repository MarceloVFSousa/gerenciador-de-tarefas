Imports Gerenciador.Domain.Entities
Imports Gerenciador.Application

Public Class frmTarefas

    Public Property ProjetoId As Integer
    Public Property NomeProjeto As String
    Private tarefaSelecionadaId As Integer = 0
    Private listaCompleta As List(Of Tarefa)

    Private tarefaService As New TarefaService()

    'Carrega a tela
    Private Sub frmTarefas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblProjeto.Text = "Projeto: " & NomeProjeto

        ConfigurarCombos()

        ConfigurarGrid()

        CarregarTarefas()

        dgvTarefas.ClearSelection()

    End Sub

    'Configura as Combobox
    Private Sub ConfigurarCombos()

        cmbStatus.Items.Clear()
        cmbStatus.Items.Add("Pendente")
        cmbStatus.Items.Add("Em andamento")
        cmbStatus.Items.Add("Concluída")

        cmbPrioridade.Items.Clear()
        cmbPrioridade.Items.Add("Baixa")
        cmbPrioridade.Items.Add("Média")
        cmbPrioridade.Items.Add("Alta")

        cmbFiltroStatus.Items.Clear()
        cmbFiltroStatus.Items.Add("Todos")
        cmbFiltroStatus.Items.Add("Pendente")
        cmbFiltroStatus.Items.Add("Em andamento")
        cmbFiltroStatus.Items.Add("Concluída")
        cmbFiltroStatus.SelectedIndex = 0

        cmbFiltroPrioridade.Items.Clear()
        cmbFiltroPrioridade.Items.Add("Todas")
        cmbFiltroPrioridade.Items.Add("Alta")
        cmbFiltroPrioridade.Items.Add("Média")
        cmbFiltroPrioridade.Items.Add("Baixa")
        cmbFiltroPrioridade.SelectedIndex = 0

    End Sub

    'Configura o Grid
    Private Sub ConfigurarGrid()

        dgvTarefas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        dgvTarefas.ScrollBars = ScrollBars.Both
        dgvTarefas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTarefas.ReadOnly = True
        dgvTarefas.AllowUserToAddRows = False

    End Sub

    Private Sub btnSalvarTarefa_Click(sender As Object, e As EventArgs) Handles btnSalvarTarefa.Click

        Try

            If txtTitulo.Text.Trim() = "" Then
                MessageBox.Show("Informe o título da tarefa.")
                txtTitulo.Focus()
                Return
            End If

            If txtDescricao.Text.Trim() = "" Then
                MessageBox.Show("Informe a descrição da tarefa.")
                txtDescricao.Focus()
                Return
            End If

            If cmbStatus.SelectedIndex = -1 Then
                MessageBox.Show("Selecione o status da tarefa.")
                cmbStatus.Focus()
                Return
            End If

            If cmbPrioridade.SelectedIndex = -1 Then
                MessageBox.Show("Selecione a prioridade da tarefa.")
                cmbPrioridade.Focus()
                Return
            End If

            Dim tarefa As New Tarefa()

            tarefa.ProjetoId = ProjetoId
            tarefa.Titulo = txtTitulo.Text
            tarefa.Descricao = txtDescricao.Text
            tarefa.Status = cmbStatus.Text
            tarefa.Prioridade = cmbPrioridade.Text

            tarefaService.CriarTarefa(tarefa)

            MessageBox.Show("Tarefa criada com sucesso!")

            LimparCampos()

            CarregarTarefas()

        Catch ex As Exception

            MessageBox.Show("Erro ao salvar tarefa: " & ex.Message)

        End Try

    End Sub

    'Limpa os campos da tela
    Private Sub LimparCampos()

        txtTitulo.Clear()
        txtDescricao.Clear()

        cmbStatus.SelectedIndex = -1
        cmbPrioridade.SelectedIndex = -1
        tarefaSelecionadaId = 0

    End Sub

    'Carrega as tarefas
    Private Sub CarregarTarefas()

        Try

            listaCompleta = tarefaService.ListarPorProjeto(ProjetoId)

            dgvTarefas.DataSource = listaCompleta

            dgvTarefas.Columns("Id").Visible = False

            dgvTarefas.Columns("Titulo").Width = 200
            dgvTarefas.Columns("Descricao").Width = 300
            dgvTarefas.Columns("Status").Width = 120
            dgvTarefas.Columns("Prioridade").Width = 120
            dgvTarefas.Columns("DataCriacao").Width = 150

            AtualizarContadores()

            dgvTarefas.ClearSelection()

        Catch ex As Exception

            MessageBox.Show("Erro ao carregar tarefas: " & ex.Message)

        End Try

    End Sub

    'Formata as celulas da tabela das tarefas
    Private Sub dgvTarefas_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvTarefas.CellFormatting

        If e.RowIndex < 0 Then Exit Sub

        Dim status As String = dgvTarefas.Rows(e.RowIndex).Cells("Status").Value.ToString()
        Dim prioridade As String = dgvTarefas.Rows(e.RowIndex).Cells("Prioridade").Value.ToString()

        'cor padrão
        e.CellStyle.BackColor = Color.White
        e.CellStyle.ForeColor = Color.Black

        'Concluída sempre verde
        If status = "Concluída" Then

            e.CellStyle.BackColor = Color.LightGreen

        Else

            Select Case prioridade

                Case "Alta"
                    e.CellStyle.BackColor = Color.LightCoral

                Case "Média"
                    e.CellStyle.BackColor = Color.Orange

                Case "Baixa"
                    e.CellStyle.BackColor = Color.Khaki

            End Select

        End If

    End Sub

    'Atualiza o contador de tarefas
    Private Sub AtualizarContadores()

        If listaCompleta Is Nothing Then Exit Sub

        Dim total As Integer = listaCompleta.Count

        Dim pendentes As Integer = listaCompleta.Where(Function(t) t.Status = "Pendente").Count()
        Dim andamento As Integer = listaCompleta.Where(Function(t) t.Status = "Em andamento").Count()
        Dim concluidas As Integer = listaCompleta.Where(Function(t) t.Status = "Concluída").Count()

        lblTotalTarefas.Text = "Total: " & total
        lblPendentes.Text = "Pendentes: " & pendentes
        lblEmAndamento.Text = "Em andamento: " & andamento
        lblConcluidas.Text = "Concluídas: " & concluidas

    End Sub

    'Botão de voltar para a tela anterior
    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click

        Dim resposta = MessageBox.Show(
        "Deseja voltar para a tela de projetos?",
        "Confirmação",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)

        If resposta = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    'Captura o clique nas células
    Private Sub dgvTarefas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTarefas.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim row = dgvTarefas.Rows(e.RowIndex)

        tarefaSelecionadaId = Convert.ToInt32(row.Cells("Id").Value)

        txtTitulo.Text = row.Cells("Titulo").Value.ToString()
        txtDescricao.Text = row.Cells("Descricao").Value.ToString()
        cmbStatus.Text = row.Cells("Status").Value.ToString()
        cmbPrioridade.Text = row.Cells("Prioridade").Value.ToString()

    End Sub


    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try

            If tarefaSelecionadaId = 0 Then
                MessageBox.Show("Selecione uma tarefa para editar.")
                Return
            End If

            Dim tarefa As New Tarefa()

            tarefa.Id = tarefaSelecionadaId
            tarefa.ProjetoId = ProjetoId
            tarefa.Titulo = txtTitulo.Text
            tarefa.Descricao = txtDescricao.Text
            tarefa.Status = cmbStatus.Text
            tarefa.Prioridade = cmbPrioridade.Text

            tarefaService.AtualizarTarefa(tarefa)

            MessageBox.Show("Tarefa atualizada com sucesso!")

            LimparCampos()
            CarregarTarefas()

        Catch ex As Exception

            MessageBox.Show("Erro ao editar tarefa: " & ex.Message)

        End Try
    End Sub

    Private Sub btnExcluirTarefa_Click(sender As Object, e As EventArgs) Handles btnExcluirTarefa.Click
        Try

            If tarefaSelecionadaId = 0 Then
                MessageBox.Show("Selecione uma tarefa para excluir.")
                Return
            End If

            Dim confirmacao = MessageBox.Show(
                "Deseja realmente excluir esta tarefa?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)

            If confirmacao = DialogResult.Yes Then

                tarefaService.ExcluirTarefa(tarefaSelecionadaId)

                MessageBox.Show("Tarefa excluída com sucesso!")

                LimparCampos()
                CarregarTarefas()

            End If

        Catch ex As Exception

            MessageBox.Show("Erro ao excluir tarefa: " & ex.Message)

        End Try
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Dim busca As String = txtBusca.Text
        Dim status As String = cmbFiltroStatus.Text
        Dim prioridade As String = cmbFiltroPrioridade.Text

        Dim listaFiltrada = tarefaService.FiltrarTarefas(ProjetoId, busca, status, prioridade)

        dgvTarefas.DataSource = listaFiltrada

        AtualizarContadores()

        dgvTarefas.ClearSelection()

    End Sub

    Private Sub btnLimparFiltro_Click(sender As Object, e As EventArgs) Handles btnLimparFiltro.Click

        txtBusca.Clear()
        cmbFiltroStatus.SelectedIndex = 0
        cmbFiltroPrioridade.SelectedIndex = 0

        CarregarTarefas()

    End Sub
End Class