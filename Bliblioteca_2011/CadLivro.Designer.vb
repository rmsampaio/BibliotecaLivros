<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadLivro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadLivro))
        Me.BtnexcluiLivro = New System.Windows.Forms.Button()
        Me.BtnEditora = New System.Windows.Forms.Button()
        Me.BtnSalvaLibro = New System.Windows.Forms.Button()
        Me.BtnAlteraLivro = New System.Windows.Forms.Button()
        Me.BtnIserirLivro = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtDtinclusao = New System.Windows.Forms.TextBox()
        Me.txtIsbn = New System.Windows.Forms.TextBox()
        Me.txtAutor = New System.Windows.Forms.TextBox()
        Me.txtNomeEditora = New System.Windows.Forms.TextBox()
        Me.txtNomeLivro = New System.Windows.Forms.TextBox()
        Me.lblidLivro = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbEstoque = New System.Windows.Forms.ComboBox()
        Me.cbCategoria = New System.Windows.Forms.ComboBox()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.lblDtAlteracao = New System.Windows.Forms.Label()
        Me.DB_Biblioteca_Pre_Aula_2011DataSet = New Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSet()
        Me.TBEstoqueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TB_EstoqueTableAdapter = New Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSetTableAdapters.TB_EstoqueTableAdapter()
        Me.TBCategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TB_CategoriaTableAdapter = New Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSetTableAdapters.TB_CategoriaTableAdapter()
        Me.TBStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TB_StatusTableAdapter = New Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSetTableAdapters.TB_StatusTableAdapter()
        CType(Me.DB_Biblioteca_Pre_Aula_2011DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBEstoqueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBCategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnexcluiLivro
        '
        Me.BtnexcluiLivro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnexcluiLivro.ForeColor = System.Drawing.Color.Green
        Me.BtnexcluiLivro.Location = New System.Drawing.Point(161, 449)
        Me.BtnexcluiLivro.Name = "BtnexcluiLivro"
        Me.BtnexcluiLivro.Size = New System.Drawing.Size(75, 23)
        Me.BtnexcluiLivro.TabIndex = 14
        Me.BtnexcluiLivro.Text = "Excluir"
        Me.BtnexcluiLivro.UseVisualStyleBackColor = True
        '
        'BtnEditora
        '
        Me.BtnEditora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditora.ForeColor = System.Drawing.Color.Green
        Me.BtnEditora.Location = New System.Drawing.Point(283, 420)
        Me.BtnEditora.Name = "BtnEditora"
        Me.BtnEditora.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditora.TabIndex = 13
        Me.BtnEditora.Text = "Voltar"
        Me.BtnEditora.UseVisualStyleBackColor = True
        '
        'BtnSalvaLibro
        '
        Me.BtnSalvaLibro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvaLibro.ForeColor = System.Drawing.Color.Green
        Me.BtnSalvaLibro.Location = New System.Drawing.Point(202, 420)
        Me.BtnSalvaLibro.Name = "BtnSalvaLibro"
        Me.BtnSalvaLibro.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalvaLibro.TabIndex = 12
        Me.BtnSalvaLibro.Text = "Salvar"
        Me.BtnSalvaLibro.UseVisualStyleBackColor = True
        '
        'BtnAlteraLivro
        '
        Me.BtnAlteraLivro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlteraLivro.ForeColor = System.Drawing.Color.Green
        Me.BtnAlteraLivro.Location = New System.Drawing.Point(121, 420)
        Me.BtnAlteraLivro.Name = "BtnAlteraLivro"
        Me.BtnAlteraLivro.Size = New System.Drawing.Size(75, 23)
        Me.BtnAlteraLivro.TabIndex = 11
        Me.BtnAlteraLivro.Text = "Alterar"
        Me.BtnAlteraLivro.UseVisualStyleBackColor = True
        '
        'BtnIserirLivro
        '
        Me.BtnIserirLivro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIserirLivro.ForeColor = System.Drawing.Color.Green
        Me.BtnIserirLivro.Location = New System.Drawing.Point(39, 420)
        Me.BtnIserirLivro.Name = "BtnIserirLivro"
        Me.BtnIserirLivro.Size = New System.Drawing.Size(75, 23)
        Me.BtnIserirLivro.TabIndex = 10
        Me.BtnIserirLivro.Text = "Inserir"
        Me.BtnIserirLivro.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Green
        Me.Label15.Location = New System.Drawing.Point(139, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(144, 13)
        Me.Label15.TabIndex = 61
        Me.Label15.Text = "CADASTRO DE LIVROS"
        '
        'txtDtinclusao
        '
        Me.txtDtinclusao.Location = New System.Drawing.Point(128, 328)
        Me.txtDtinclusao.Name = "txtDtinclusao"
        Me.txtDtinclusao.Size = New System.Drawing.Size(149, 20)
        Me.txtDtinclusao.TabIndex = 8
        '
        'txtIsbn
        '
        Me.txtIsbn.Location = New System.Drawing.Point(98, 293)
        Me.txtIsbn.Name = "txtIsbn"
        Me.txtIsbn.Size = New System.Drawing.Size(141, 20)
        Me.txtIsbn.TabIndex = 7
        '
        'txtAutor
        '
        Me.txtAutor.Location = New System.Drawing.Point(98, 154)
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(179, 20)
        Me.txtAutor.TabIndex = 3
        '
        'txtNomeEditora
        '
        Me.txtNomeEditora.Location = New System.Drawing.Point(98, 122)
        Me.txtNomeEditora.Name = "txtNomeEditora"
        Me.txtNomeEditora.Size = New System.Drawing.Size(222, 20)
        Me.txtNomeEditora.TabIndex = 2
        '
        'txtNomeLivro
        '
        Me.txtNomeLivro.Location = New System.Drawing.Point(98, 91)
        Me.txtNomeLivro.Name = "txtNomeLivro"
        Me.txtNomeLivro.Size = New System.Drawing.Size(222, 20)
        Me.txtNomeLivro.TabIndex = 1
        '
        'lblidLivro
        '
        Me.lblidLivro.AutoSize = True
        Me.lblidLivro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidLivro.ForeColor = System.Drawing.Color.Green
        Me.lblidLivro.Location = New System.Drawing.Point(105, 66)
        Me.lblidLivro.Name = "lblidLivro"
        Me.lblidLivro.Size = New System.Drawing.Size(0, 13)
        Me.lblidLivro.TabIndex = 48
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Green
        Me.Label13.Location = New System.Drawing.Point(26, 376)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 13)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Data Alteração:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Green
        Me.Label12.Location = New System.Drawing.Point(26, 336)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 13)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Data Inclusão:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Green
        Me.Label8.Location = New System.Drawing.Point(26, 301)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "ISBN:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(26, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Status:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(26, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Categoria:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(26, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Estoque:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(26, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Autor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(26, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Editora:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(26, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Nome:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(26, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Cod.Livro:"
        '
        'cbEstoque
        '
        Me.cbEstoque.DataSource = Me.TBEstoqueBindingSource
        Me.cbEstoque.DisplayMember = "id"
        Me.cbEstoque.FormattingEnabled = True
        Me.cbEstoque.Location = New System.Drawing.Point(98, 184)
        Me.cbEstoque.Name = "cbEstoque"
        Me.cbEstoque.Size = New System.Drawing.Size(121, 21)
        Me.cbEstoque.TabIndex = 4
        Me.cbEstoque.ValueMember = "id"
        '
        'cbCategoria
        '
        Me.cbCategoria.DataSource = Me.TBCategoriaBindingSource
        Me.cbCategoria.DisplayMember = "Categoria"
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Location = New System.Drawing.Point(98, 219)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(121, 21)
        Me.cbCategoria.TabIndex = 5
        Me.cbCategoria.ValueMember = "id"
        '
        'cbStatus
        '
        Me.cbStatus.DataSource = Me.TBStatusBindingSource
        Me.cbStatus.DisplayMember = "Status"
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(98, 257)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(121, 21)
        Me.cbStatus.TabIndex = 6
        Me.cbStatus.ValueMember = "id"
        '
        'lblDtAlteracao
        '
        Me.lblDtAlteracao.AutoSize = True
        Me.lblDtAlteracao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDtAlteracao.ForeColor = System.Drawing.Color.Green
        Me.lblDtAlteracao.Location = New System.Drawing.Point(128, 375)
        Me.lblDtAlteracao.Name = "lblDtAlteracao"
        Me.lblDtAlteracao.Size = New System.Drawing.Size(0, 13)
        Me.lblDtAlteracao.TabIndex = 62
        '
        'DB_Biblioteca_Pre_Aula_2011DataSet
        '
        Me.DB_Biblioteca_Pre_Aula_2011DataSet.DataSetName = "DB_Biblioteca_Pre_Aula_2011DataSet"
        Me.DB_Biblioteca_Pre_Aula_2011DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBEstoqueBindingSource
        '
        Me.TBEstoqueBindingSource.DataMember = "TB_Estoque"
        Me.TBEstoqueBindingSource.DataSource = Me.DB_Biblioteca_Pre_Aula_2011DataSet
        '
        'TB_EstoqueTableAdapter
        '
        Me.TB_EstoqueTableAdapter.ClearBeforeFill = True
        '
        'TBCategoriaBindingSource
        '
        Me.TBCategoriaBindingSource.DataMember = "TB_Categoria"
        Me.TBCategoriaBindingSource.DataSource = Me.DB_Biblioteca_Pre_Aula_2011DataSet
        '
        'TB_CategoriaTableAdapter
        '
        Me.TB_CategoriaTableAdapter.ClearBeforeFill = True
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
        'CadLivro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 495)
        Me.Controls.Add(Me.lblDtAlteracao)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.cbCategoria)
        Me.Controls.Add(Me.cbEstoque)
        Me.Controls.Add(Me.BtnexcluiLivro)
        Me.Controls.Add(Me.BtnEditora)
        Me.Controls.Add(Me.BtnSalvaLibro)
        Me.Controls.Add(Me.BtnAlteraLivro)
        Me.Controls.Add(Me.BtnIserirLivro)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtDtinclusao)
        Me.Controls.Add(Me.txtIsbn)
        Me.Controls.Add(Me.txtAutor)
        Me.Controls.Add(Me.txtNomeEditora)
        Me.Controls.Add(Me.txtNomeLivro)
        Me.Controls.Add(Me.lblidLivro)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CadLivro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Livro."
        CType(Me.DB_Biblioteca_Pre_Aula_2011DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBEstoqueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBCategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnexcluiLivro As System.Windows.Forms.Button
    Friend WithEvents BtnEditora As System.Windows.Forms.Button
    Friend WithEvents BtnSalvaLibro As System.Windows.Forms.Button
    Friend WithEvents BtnAlteraLivro As System.Windows.Forms.Button
    Friend WithEvents BtnIserirLivro As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtDtinclusao As System.Windows.Forms.TextBox
    Friend WithEvents txtIsbn As System.Windows.Forms.TextBox
    Friend WithEvents txtAutor As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeEditora As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeLivro As System.Windows.Forms.TextBox
    Friend WithEvents lblidLivro As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbEstoque As System.Windows.Forms.ComboBox
    Friend WithEvents cbCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblDtAlteracao As System.Windows.Forms.Label
    Friend WithEvents DB_Biblioteca_Pre_Aula_2011DataSet As Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSet
    Friend WithEvents TBEstoqueBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_EstoqueTableAdapter As Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSetTableAdapters.TB_EstoqueTableAdapter
    Friend WithEvents TBCategoriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_CategoriaTableAdapter As Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSetTableAdapters.TB_CategoriaTableAdapter
    Friend WithEvents TBStatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_StatusTableAdapter As Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSetTableAdapters.TB_StatusTableAdapter
End Class
