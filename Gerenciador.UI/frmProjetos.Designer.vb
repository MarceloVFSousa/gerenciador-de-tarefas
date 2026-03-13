<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjetos
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
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.tabProjetos = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.grpCadastroProjetos = New System.Windows.Forms.GroupBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.grpProjetos = New System.Windows.Forms.GroupBox()
        Me.dgvProjetos = New System.Windows.Forms.DataGridView()
        Me.btnAbrirTarefas = New System.Windows.Forms.Button()
        Me.tabProjetos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grpCadastroProjetos.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.grpProjetos.SuspendLayout()
        CType(Me.dgvProjetos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(243, 329)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(116, 51)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'tabProjetos
        '
        Me.tabProjetos.Controls.Add(Me.TabPage1)
        Me.tabProjetos.Controls.Add(Me.TabPage2)
        Me.tabProjetos.Location = New System.Drawing.Point(15, 17)
        Me.tabProjetos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabProjetos.Name = "tabProjetos"
        Me.tabProjetos.SelectedIndex = 0
        Me.tabProjetos.Size = New System.Drawing.Size(631, 453)
        Me.tabProjetos.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.grpCadastroProjetos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Size = New System.Drawing.Size(623, 424)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cadastro de Projetos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'grpCadastroProjetos
        '
        Me.grpCadastroProjetos.Controls.Add(Me.txtDescricao)
        Me.grpCadastroProjetos.Controls.Add(Me.btnSalvar)
        Me.grpCadastroProjetos.Controls.Add(Me.Label1)
        Me.grpCadastroProjetos.Controls.Add(Me.txtNome)
        Me.grpCadastroProjetos.Controls.Add(Me.lblNome)
        Me.grpCadastroProjetos.Location = New System.Drawing.Point(7, 8)
        Me.grpCadastroProjetos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpCadastroProjetos.Name = "grpCadastroProjetos"
        Me.grpCadastroProjetos.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpCadastroProjetos.Size = New System.Drawing.Size(609, 399)
        Me.grpCadastroProjetos.TabIndex = 1
        Me.grpCadastroProjetos.TabStop = False
        Me.grpCadastroProjetos.Text = "Cadastro"
        '
        'txtDescricao
        '
        Me.txtDescricao.AcceptsReturn = True
        Me.txtDescricao.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricao.Location = New System.Drawing.Point(105, 113)
        Me.txtDescricao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(497, 200)
        Me.txtDescricao.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Descrição:"
        '
        'txtNome
        '
        Me.txtNome.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(105, 58)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(271, 23)
        Me.txtNome.TabIndex = 1
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(18, 62)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(59, 21)
        Me.lblNome.TabIndex = 0
        Me.lblNome.Text = "Nome:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnAbrirTarefas)
        Me.TabPage2.Controls.Add(Me.btnExcluir)
        Me.TabPage2.Controls.Add(Me.grpProjetos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Size = New System.Drawing.Size(623, 419)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Projetos Listados"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Location = New System.Drawing.Point(323, 358)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(119, 42)
        Me.btnExcluir.TabIndex = 3
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'grpProjetos
        '
        Me.grpProjetos.Controls.Add(Me.dgvProjetos)
        Me.grpProjetos.Location = New System.Drawing.Point(7, 8)
        Me.grpProjetos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpProjetos.Name = "grpProjetos"
        Me.grpProjetos.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpProjetos.Size = New System.Drawing.Size(609, 343)
        Me.grpProjetos.TabIndex = 2
        Me.grpProjetos.TabStop = False
        Me.grpProjetos.Text = "Projetos"
        '
        'dgvProjetos
        '
        Me.dgvProjetos.AllowUserToAddRows = False
        Me.dgvProjetos.AllowUserToDeleteRows = False
        Me.dgvProjetos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjetos.Location = New System.Drawing.Point(7, 28)
        Me.dgvProjetos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvProjetos.Name = "dgvProjetos"
        Me.dgvProjetos.ReadOnly = True
        Me.dgvProjetos.RowTemplate.Height = 24
        Me.dgvProjetos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProjetos.Size = New System.Drawing.Size(595, 307)
        Me.dgvProjetos.TabIndex = 0
        '
        'btnAbrirTarefas
        '
        Me.btnAbrirTarefas.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbrirTarefas.Location = New System.Drawing.Point(180, 358)
        Me.btnAbrirTarefas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAbrirTarefas.Name = "btnAbrirTarefas"
        Me.btnAbrirTarefas.Size = New System.Drawing.Size(119, 42)
        Me.btnAbrirTarefas.TabIndex = 4
        Me.btnAbrirTarefas.Text = "Abrir Tarefas"
        Me.btnAbrirTarefas.UseVisualStyleBackColor = True
        '
        'frmProjetos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 484)
        Me.Controls.Add(Me.tabProjetos)
        Me.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmProjetos"
        Me.Text = "Projetos - Cadastro"
        Me.tabProjetos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.grpCadastroProjetos.ResumeLayout(False)
        Me.grpCadastroProjetos.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.grpProjetos.ResumeLayout(False)
        CType(Me.dgvProjetos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents tabProjetos As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents grpCadastroProjetos As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents grpProjetos As System.Windows.Forms.GroupBox
    Friend WithEvents dgvProjetos As System.Windows.Forms.DataGridView
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnAbrirTarefas As System.Windows.Forms.Button

End Class
