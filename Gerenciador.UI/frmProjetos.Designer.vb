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
        Me.grpTarefas = New System.Windows.Forms.GroupBox()
        Me.dgvProjetos = New System.Windows.Forms.DataGridView()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.tabProjetos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grpCadastroProjetos.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.grpTarefas.SuspendLayout()
        CType(Me.dgvProjetos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(216, 216)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(103, 39)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'tabProjetos
        '
        Me.tabProjetos.Controls.Add(Me.TabPage1)
        Me.tabProjetos.Controls.Add(Me.TabPage2)
        Me.tabProjetos.Location = New System.Drawing.Point(13, 13)
        Me.tabProjetos.Name = "tabProjetos"
        Me.tabProjetos.SelectedIndex = 0
        Me.tabProjetos.Size = New System.Drawing.Size(561, 345)
        Me.tabProjetos.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.grpCadastroProjetos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(553, 273)
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
        Me.grpCadastroProjetos.Location = New System.Drawing.Point(6, 6)
        Me.grpCadastroProjetos.Name = "grpCadastroProjetos"
        Me.grpCadastroProjetos.Size = New System.Drawing.Size(541, 261)
        Me.grpCadastroProjetos.TabIndex = 1
        Me.grpCadastroProjetos.TabStop = False
        Me.grpCadastroProjetos.Text = "Cadastro"
        '
        'txtDescricao
        '
        Me.txtDescricao.AcceptsReturn = True
        Me.txtDescricao.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricao.Location = New System.Drawing.Point(93, 86)
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(442, 113)
        Me.txtDescricao.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Descrição:"
        '
        'txtNome
        '
        Me.txtNome.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(93, 44)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(241, 23)
        Me.txtNome.TabIndex = 1
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(16, 47)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(49, 17)
        Me.lblNome.TabIndex = 0
        Me.lblNome.Text = "Nome:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnExcluir)
        Me.TabPage2.Controls.Add(Me.grpTarefas)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(553, 316)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tarefas Listadas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'grpTarefas
        '
        Me.grpTarefas.Controls.Add(Me.dgvProjetos)
        Me.grpTarefas.Location = New System.Drawing.Point(6, 6)
        Me.grpTarefas.Name = "grpTarefas"
        Me.grpTarefas.Size = New System.Drawing.Size(541, 261)
        Me.grpTarefas.TabIndex = 2
        Me.grpTarefas.TabStop = False
        Me.grpTarefas.Text = "Tarefas"
        '
        'dgvProjetos
        '
        Me.dgvProjetos.AllowUserToAddRows = False
        Me.dgvProjetos.AllowUserToDeleteRows = False
        Me.dgvProjetos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjetos.Location = New System.Drawing.Point(6, 21)
        Me.dgvProjetos.Name = "dgvProjetos"
        Me.dgvProjetos.ReadOnly = True
        Me.dgvProjetos.RowTemplate.Height = 24
        Me.dgvProjetos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProjetos.Size = New System.Drawing.Size(529, 234)
        Me.dgvProjetos.TabIndex = 0
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(220, 273)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(106, 32)
        Me.btnExcluir.TabIndex = 3
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'frmProjetos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 369)
        Me.Controls.Add(Me.tabProjetos)
        Me.Name = "frmProjetos"
        Me.Text = "Projetos - Cadastro"
        Me.tabProjetos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.grpCadastroProjetos.ResumeLayout(False)
        Me.grpCadastroProjetos.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.grpTarefas.ResumeLayout(False)
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
    Friend WithEvents grpTarefas As System.Windows.Forms.GroupBox
    Friend WithEvents dgvProjetos As System.Windows.Forms.DataGridView
    Friend WithEvents btnExcluir As System.Windows.Forms.Button

End Class
