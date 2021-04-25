<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadLocacao
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadLocacao))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnLimpaLoc = New System.Windows.Forms.Button()
        Me.btnConsultaLoc = New System.Windows.Forms.Button()
        Me.txtConsultaLoc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cbFuncionario = New System.Windows.Forms.ComboBox()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.cbLivro = New System.Windows.Forms.ComboBox()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.txtDtLoca = New System.Windows.Forms.TextBox()
        Me.txtDtDevolucao = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnInserirLoc = New System.Windows.Forms.Button()
        Me.BtnAlterarLoc = New System.Windows.Forms.Button()
        Me.BtnSalvarLoc = New System.Windows.Forms.Button()
        Me.BtnExcluirLoc = New System.Windows.Forms.Button()
        Me.lblIdLocacao = New System.Windows.Forms.Label()
        Me.rtxtObservacoes = New System.Windows.Forms.RichTextBox()
        Me.DB_Biblioteca_Pre_Aula_2011DataSet = New Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSet()
        Me.TBClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TB_ClienteTableAdapter = New Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSetTableAdapters.TB_ClienteTableAdapter()
        Me.TBLivroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TB_LivroTableAdapter = New Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSetTableAdapters.TB_LivroTableAdapter()
        Me.TBStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TB_StatusTableAdapter = New Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSetTableAdapters.TB_StatusTableAdapter()
        Me.TBFuncionarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TB_FuncionarioTableAdapter = New Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSetTableAdapters.TB_FuncionarioTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_Biblioteca_Pre_Aula_2011DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLivroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBFuncionarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.btnLimpaLoc)
        Me.GroupBox1.Controls.Add(Me.btnConsultaLoc)
        Me.GroupBox1.Controls.Add(Me.txtConsultaLoc)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Green
        Me.GroupBox1.Location = New System.Drawing.Point(25, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(617, 559)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consulta Locação"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(356, 67)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Sair"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnLimpaLoc
        '
        Me.btnLimpaLoc.Location = New System.Drawing.Point(274, 68)
        Me.btnLimpaLoc.Name = "btnLimpaLoc"
        Me.btnLimpaLoc.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpaLoc.TabIndex = 3
        Me.btnLimpaLoc.Text = "Limpa"
        Me.btnLimpaLoc.UseVisualStyleBackColor = True
        '
        'btnConsultaLoc
        '
        Me.btnConsultaLoc.Location = New System.Drawing.Point(192, 69)
        Me.btnConsultaLoc.Name = "btnConsultaLoc"
        Me.btnConsultaLoc.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultaLoc.TabIndex = 2
        Me.btnConsultaLoc.Text = "Consulta"
        Me.btnConsultaLoc.UseVisualStyleBackColor = True
        '
        'txtConsultaLoc
        '
        Me.txtConsultaLoc.Location = New System.Drawing.Point(192, 42)
        Me.txtConsultaLoc.Name = "txtConsultaLoc"
        Me.txtConsultaLoc.Size = New System.Drawing.Size(239, 20)
        Me.txtConsultaLoc.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(247, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Faça sua Consulta"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(7, 114)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(604, 439)
        Me.DataGridView1.TabIndex = 0
        '
        'cbFuncionario
        '
        Me.cbFuncionario.DataSource = Me.TBFuncionarioBindingSource
        Me.cbFuncionario.DisplayMember = "Nome"
        Me.cbFuncionario.FormattingEnabled = True
        Me.cbFuncionario.Location = New System.Drawing.Point(485, 653)
        Me.cbFuncionario.Name = "cbFuncionario"
        Me.cbFuncionario.Size = New System.Drawing.Size(121, 21)
        Me.cbFuncionario.TabIndex = 8
        Me.cbFuncionario.ValueMember = "id"
        '
        'cbStatus
        '
        Me.cbStatus.DataSource = Me.TBStatusBindingSource
        Me.cbStatus.DisplayMember = "Status"
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(344, 653)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(121, 21)
        Me.cbStatus.TabIndex = 7
        Me.cbStatus.ValueMember = "id"
        '
        'cbLivro
        '
        Me.cbLivro.DataSource = Me.TBLivroBindingSource
        Me.cbLivro.DisplayMember = "nomeLivro"
        Me.cbLivro.FormattingEnabled = True
        Me.cbLivro.Location = New System.Drawing.Point(204, 653)
        Me.cbLivro.Name = "cbLivro"
        Me.cbLivro.Size = New System.Drawing.Size(121, 21)
        Me.cbLivro.TabIndex = 6
        Me.cbLivro.ValueMember = "id"
        '
        'cbCliente
        '
        Me.cbCliente.DataSource = Me.TBClienteBindingSource
        Me.cbCliente.DisplayMember = "Nome"
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(46, 653)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(121, 21)
        Me.cbCliente.TabIndex = 5
        Me.cbCliente.ValueMember = "id"
        '
        'txtDtLoca
        '
        Me.txtDtLoca.Location = New System.Drawing.Point(46, 706)
        Me.txtDtLoca.Name = "txtDtLoca"
        Me.txtDtLoca.Size = New System.Drawing.Size(100, 20)
        Me.txtDtLoca.TabIndex = 9
        '
        'txtDtDevolucao
        '
        Me.txtDtDevolucao.Location = New System.Drawing.Point(204, 706)
        Me.txtDtDevolucao.Name = "txtDtDevolucao"
        Me.txtDtDevolucao.Size = New System.Drawing.Size(100, 20)
        Me.txtDtDevolucao.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Green
        Me.Label8.Location = New System.Drawing.Point(341, 690)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Observação:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(201, 690)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Data da Devolução:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(43, 690)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Data da Locação:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(482, 637)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Funcionário:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(341, 637)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(201, 637)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Livro:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(43, 637)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Cliente:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Green
        Me.Label10.Location = New System.Drawing.Point(30, 604)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Código da Locação:"
        '
        'btnInserirLoc
        '
        Me.btnInserirLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInserirLoc.ForeColor = System.Drawing.Color.Green
        Me.btnInserirLoc.Location = New System.Drawing.Point(46, 749)
        Me.btnInserirLoc.Name = "btnInserirLoc"
        Me.btnInserirLoc.Size = New System.Drawing.Size(75, 23)
        Me.btnInserirLoc.TabIndex = 12
        Me.btnInserirLoc.Text = "Inserir"
        Me.btnInserirLoc.UseVisualStyleBackColor = True
        '
        'BtnAlterarLoc
        '
        Me.BtnAlterarLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlterarLoc.ForeColor = System.Drawing.Color.Green
        Me.BtnAlterarLoc.Location = New System.Drawing.Point(127, 749)
        Me.BtnAlterarLoc.Name = "BtnAlterarLoc"
        Me.BtnAlterarLoc.Size = New System.Drawing.Size(75, 23)
        Me.BtnAlterarLoc.TabIndex = 13
        Me.BtnAlterarLoc.Text = "Alterar"
        Me.BtnAlterarLoc.UseVisualStyleBackColor = True
        '
        'BtnSalvarLoc
        '
        Me.BtnSalvarLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvarLoc.ForeColor = System.Drawing.Color.Green
        Me.BtnSalvarLoc.Location = New System.Drawing.Point(208, 749)
        Me.BtnSalvarLoc.Name = "BtnSalvarLoc"
        Me.BtnSalvarLoc.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalvarLoc.TabIndex = 14
        Me.BtnSalvarLoc.Text = "Salvar"
        Me.BtnSalvarLoc.UseVisualStyleBackColor = True
        '
        'BtnExcluirLoc
        '
        Me.BtnExcluirLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcluirLoc.ForeColor = System.Drawing.Color.Green
        Me.BtnExcluirLoc.Location = New System.Drawing.Point(127, 778)
        Me.BtnExcluirLoc.Name = "BtnExcluirLoc"
        Me.BtnExcluirLoc.Size = New System.Drawing.Size(75, 23)
        Me.BtnExcluirLoc.TabIndex = 15
        Me.BtnExcluirLoc.Text = "Excluir"
        Me.BtnExcluirLoc.UseVisualStyleBackColor = True
        '
        'lblIdLocacao
        '
        Me.lblIdLocacao.AutoSize = True
        Me.lblIdLocacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdLocacao.ForeColor = System.Drawing.Color.Green
        Me.lblIdLocacao.Location = New System.Drawing.Point(158, 603)
        Me.lblIdLocacao.Name = "lblIdLocacao"
        Me.lblIdLocacao.Size = New System.Drawing.Size(0, 13)
        Me.lblIdLocacao.TabIndex = 46
        '
        'rtxtObservacoes
        '
        Me.rtxtObservacoes.Location = New System.Drawing.Point(344, 705)
        Me.rtxtObservacoes.Name = "rtxtObservacoes"
        Me.rtxtObservacoes.Size = New System.Drawing.Size(262, 96)
        Me.rtxtObservacoes.TabIndex = 47
        Me.rtxtObservacoes.Text = ""
        '
        'DB_Biblioteca_Pre_Aula_2011DataSet
        '
        Me.DB_Biblioteca_Pre_Aula_2011DataSet.DataSetName = "DB_Biblioteca_Pre_Aula_2011DataSet"
        Me.DB_Biblioteca_Pre_Aula_2011DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBClienteBindingSource
        '
        Me.TBClienteBindingSource.DataMember = "TB_Cliente"
        Me.TBClienteBindingSource.DataSource = Me.DB_Biblioteca_Pre_Aula_2011DataSet
        '
        'TB_ClienteTableAdapter
        '
        Me.TB_ClienteTableAdapter.ClearBeforeFill = True
        '
        'TBLivroBindingSource
        '
        Me.TBLivroBindingSource.DataMember = "TB_Livro"
        Me.TBLivroBindingSource.DataSource = Me.DB_Biblioteca_Pre_Aula_2011DataSet
        '
        'TB_LivroTableAdapter
        '
        Me.TB_LivroTableAdapter.ClearBeforeFill = True
        '
        'TBStatusBindingSource
        '
        Me.TBStatusBindingSource.DataMember = "TB_Status"
        Me.TBStatusBindingSource.DataSource = Me.DB_Biblioteca_Pre_Aula_2011DataSet
        '
        'TB_StatusTableAdapter
        '
        Me.TB_StatusTableAdapter.ClearBeforeFill = True
        '
        'TBFuncionarioBindingSource
        '
        Me.TBFuncionarioBindingSource.DataMember = "TB_Funcionario"
        Me.TBFuncionarioBindingSource.DataSource = Me.DB_Biblioteca_Pre_Aula_2011DataSet
        '
        'TB_FuncionarioTableAdapter
        '
        Me.TB_FuncionarioTableAdapter.ClearBeforeFill = True
        '
        'CadLocacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 820)
        Me.Controls.Add(Me.rtxtObservacoes)
        Me.Controls.Add(Me.lblIdLocacao)
        Me.Controls.Add(Me.BtnExcluirLoc)
        Me.Controls.Add(Me.BtnSalvarLoc)
        Me.Controls.Add(Me.BtnAlterarLoc)
        Me.Controls.Add(Me.btnInserirLoc)
        Me.Controls.Add(Me.cbFuncionario)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.cbLivro)
        Me.Controls.Add(Me.cbCliente)
        Me.Controls.Add(Me.txtDtLoca)
        Me.Controls.Add(Me.txtDtDevolucao)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CadLocacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Locação"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_Biblioteca_Pre_Aula_2011DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLivroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBFuncionarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnLimpaLoc As System.Windows.Forms.Button
    Friend WithEvents btnConsultaLoc As System.Windows.Forms.Button
    Friend WithEvents txtConsultaLoc As System.Windows.Forms.TextBox
    Friend WithEvents cbFuncionario As System.Windows.Forms.ComboBox
    Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cbLivro As System.Windows.Forms.ComboBox
    Friend WithEvents cbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents txtDtLoca As System.Windows.Forms.TextBox
    Friend WithEvents txtDtDevolucao As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnInserirLoc As System.Windows.Forms.Button
    Friend WithEvents BtnAlterarLoc As System.Windows.Forms.Button
    Friend WithEvents BtnSalvarLoc As System.Windows.Forms.Button
    Friend WithEvents BtnExcluirLoc As System.Windows.Forms.Button
    Friend WithEvents lblIdLocacao As System.Windows.Forms.Label
    Friend WithEvents rtxtObservacoes As System.Windows.Forms.RichTextBox
    Friend WithEvents DB_Biblioteca_Pre_Aula_2011DataSet As Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSet
    Friend WithEvents TBClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_ClienteTableAdapter As Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSetTableAdapters.TB_ClienteTableAdapter
    Friend WithEvents TBLivroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_LivroTableAdapter As Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSetTableAdapters.TB_LivroTableAdapter
    Friend WithEvents TBStatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_StatusTableAdapter As Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSetTableAdapters.TB_StatusTableAdapter
    Friend WithEvents TBFuncionarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_FuncionarioTableAdapter As Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSetTableAdapters.TB_FuncionarioTableAdapter
End Class
