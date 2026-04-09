<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTarefas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSalvarTarefa = New System.Windows.Forms.Button()
        Me.grpCadastroTarefa = New System.Windows.Forms.GroupBox()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.lblProjeto = New System.Windows.Forms.Label()
        Me.cmbPrioridade = New System.Windows.Forms.ComboBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblPrioridade = New System.Windows.Forms.Label()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dgvTarefas = New System.Windows.Forms.DataGridView()
        Me.grpTotalTarefas = New System.Windows.Forms.GroupBox()
        Me.lblConcluidas = New System.Windows.Forms.Label()
        Me.lblEmAndamento = New System.Windows.Forms.Label()
        Me.lblPendentes = New System.Windows.Forms.Label()
        Me.lblTotalTarefas = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.grpCadastroTarefa.SuspendLayout()
        CType(Me.dgvTarefas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTotalTarefas.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalvarTarefa
        '
        Me.btnSalvarTarefa.Location = New System.Drawing.Point(255, 200)
        Me.btnSalvarTarefa.Name = "btnSalvarTarefa"
        Me.btnSalvarTarefa.Size = New System.Drawing.Size(75, 36)
        Me.btnSalvarTarefa.TabIndex = 5
        Me.btnSalvarTarefa.Text = "Salvar"
        Me.btnSalvarTarefa.UseVisualStyleBackColor = True
        '
        'grpCadastroTarefa
        '
        Me.grpCadastroTarefa.Controls.Add(Me.btnEditar)
        Me.grpCadastroTarefa.Controls.Add(Me.btnVoltar)
        Me.grpCadastroTarefa.Controls.Add(Me.lblProjeto)
        Me.grpCadastroTarefa.Controls.Add(Me.cmbPrioridade)
        Me.grpCadastroTarefa.Controls.Add(Me.cmbStatus)
        Me.grpCadastroTarefa.Controls.Add(Me.txtDescricao)
        Me.grpCadastroTarefa.Controls.Add(Me.txtTitulo)
        Me.grpCadastroTarefa.Controls.Add(Me.lblStatus)
        Me.grpCadastroTarefa.Controls.Add(Me.btnSalvarTarefa)
        Me.grpCadastroTarefa.Controls.Add(Me.lblPrioridade)
        Me.grpCadastroTarefa.Controls.Add(Me.lblDescricao)
        Me.grpCadastroTarefa.Controls.Add(Me.lblTitulo)
        Me.grpCadastroTarefa.Location = New System.Drawing.Point(11, 10)
        Me.grpCadastroTarefa.Name = "grpCadastroTarefa"
        Me.grpCadastroTarefa.Size = New System.Drawing.Size(393, 329)
        Me.grpCadastroTarefa.TabIndex = 6
        Me.grpCadastroTarefa.TabStop = False
        Me.grpCadastroTarefa.Text = "Cadastro de Tarefas"
        '
        'btnVoltar
        '
        Me.btnVoltar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVoltar.Location = New System.Drawing.Point(255, 285)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(75, 36)
        Me.btnVoltar.TabIndex = 15
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'lblProjeto
        '
        Me.lblProjeto.AutoSize = True
        Me.lblProjeto.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjeto.Location = New System.Drawing.Point(8, 32)
        Me.lblProjeto.Name = "lblProjeto"
        Me.lblProjeto.Size = New System.Drawing.Size(73, 21)
        Me.lblProjeto.TabIndex = 13
        Me.lblProjeto.Text = "Projeto"
        '
        'cmbPrioridade
        '
        Me.cmbPrioridade.FormattingEnabled = True
        Me.cmbPrioridade.Items.AddRange(New Object() {"Baixa", "Média", "Alta"})
        Me.cmbPrioridade.Location = New System.Drawing.Point(104, 247)
        Me.cmbPrioridade.Name = "cmbPrioridade"
        Me.cmbPrioridade.Size = New System.Drawing.Size(108, 26)
        Me.cmbPrioridade.TabIndex = 12
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Pendente", "Em andamento", "Concluída"})
        Me.cmbStatus.Location = New System.Drawing.Point(104, 206)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(108, 26)
        Me.cmbStatus.TabIndex = 11
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(104, 114)
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(271, 69)
        Me.txtDescricao.TabIndex = 10
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(104, 70)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(271, 26)
        Me.txtTitulo.TabIndex = 9
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(8, 206)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(57, 21)
        Me.lblStatus.TabIndex = 8
        Me.lblStatus.Text = "Status"
        '
        'lblPrioridade
        '
        Me.lblPrioridade.AutoSize = True
        Me.lblPrioridade.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrioridade.Location = New System.Drawing.Point(5, 250)
        Me.lblPrioridade.Name = "lblPrioridade"
        Me.lblPrioridade.Size = New System.Drawing.Size(84, 21)
        Me.lblPrioridade.TabIndex = 7
        Me.lblPrioridade.Text = "Prioridade"
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescricao.Location = New System.Drawing.Point(8, 117)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(83, 21)
        Me.lblDescricao.TabIndex = 6
        Me.lblDescricao.Text = "Descrição"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(8, 70)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(52, 21)
        Me.lblTitulo.TabIndex = 5
        Me.lblTitulo.Text = "Título"
        '
        'dgvTarefas
        '
        Me.dgvTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTarefas.Location = New System.Drawing.Point(410, 12)
        Me.dgvTarefas.Name = "dgvTarefas"
        Me.dgvTarefas.RowTemplate.Height = 24
        Me.dgvTarefas.Size = New System.Drawing.Size(552, 482)
        Me.dgvTarefas.TabIndex = 7
        '
        'grpTotalTarefas
        '
        Me.grpTotalTarefas.Controls.Add(Me.lblConcluidas)
        Me.grpTotalTarefas.Controls.Add(Me.lblEmAndamento)
        Me.grpTotalTarefas.Controls.Add(Me.lblPendentes)
        Me.grpTotalTarefas.Controls.Add(Me.lblTotalTarefas)
        Me.grpTotalTarefas.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTotalTarefas.Location = New System.Drawing.Point(11, 349)
        Me.grpTotalTarefas.Name = "grpTotalTarefas"
        Me.grpTotalTarefas.Size = New System.Drawing.Size(393, 132)
        Me.grpTotalTarefas.TabIndex = 14
        Me.grpTotalTarefas.TabStop = False
        Me.grpTotalTarefas.Text = "Tarefas:"
        '
        'lblConcluidas
        '
        Me.lblConcluidas.AutoSize = True
        Me.lblConcluidas.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConcluidas.Location = New System.Drawing.Point(208, 78)
        Me.lblConcluidas.Name = "lblConcluidas"
        Me.lblConcluidas.Size = New System.Drawing.Size(95, 21)
        Me.lblConcluidas.TabIndex = 21
        Me.lblConcluidas.Text = "Concluídas:"
        '
        'lblEmAndamento
        '
        Me.lblEmAndamento.AutoSize = True
        Me.lblEmAndamento.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmAndamento.Location = New System.Drawing.Point(7, 78)
        Me.lblEmAndamento.Name = "lblEmAndamento"
        Me.lblEmAndamento.Size = New System.Drawing.Size(130, 21)
        Me.lblEmAndamento.TabIndex = 20
        Me.lblEmAndamento.Text = "Em Andamento:"
        '
        'lblPendentes
        '
        Me.lblPendentes.AutoSize = True
        Me.lblPendentes.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendentes.Location = New System.Drawing.Point(210, 37)
        Me.lblPendentes.Name = "lblPendentes"
        Me.lblPendentes.Size = New System.Drawing.Size(93, 21)
        Me.lblPendentes.TabIndex = 19
        Me.lblPendentes.Text = "Pendentes:"
        '
        'lblTotalTarefas
        '
        Me.lblTotalTarefas.AutoSize = True
        Me.lblTotalTarefas.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTarefas.Location = New System.Drawing.Point(6, 37)
        Me.lblTotalTarefas.Name = "lblTotalTarefas"
        Me.lblTotalTarefas.Size = New System.Drawing.Size(115, 21)
        Me.lblTotalTarefas.TabIndex = 18
        Me.lblTotalTarefas.Text = "Total Tarefas:"
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(255, 243)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 36)
        Me.btnEditar.TabIndex = 16
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'frmTarefas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 506)
        Me.Controls.Add(Me.dgvTarefas)
        Me.Controls.Add(Me.grpTotalTarefas)
        Me.Controls.Add(Me.grpCadastroTarefa)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmTarefas"
        Me.Text = "Tarefas"
        Me.grpCadastroTarefa.ResumeLayout(False)
        Me.grpCadastroTarefa.PerformLayout()
        CType(Me.dgvTarefas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTotalTarefas.ResumeLayout(False)
        Me.grpTotalTarefas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSalvarTarefa As System.Windows.Forms.Button
    Friend WithEvents grpCadastroTarefa As System.Windows.Forms.GroupBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblPrioridade As System.Windows.Forms.Label
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPrioridade As System.Windows.Forms.ComboBox
    Friend WithEvents dgvTarefas As System.Windows.Forms.DataGridView
    Friend WithEvents lblProjeto As System.Windows.Forms.Label
    Friend WithEvents grpTotalTarefas As System.Windows.Forms.GroupBox
    Friend WithEvents lblConcluidas As System.Windows.Forms.Label
    Friend WithEvents lblEmAndamento As System.Windows.Forms.Label
    Friend WithEvents lblPendentes As System.Windows.Forms.Label
    Friend WithEvents lblTotalTarefas As System.Windows.Forms.Label
    Friend WithEvents btnVoltar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
End Class
