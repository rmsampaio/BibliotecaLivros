<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadCliente))
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCliInclusao = New System.Windows.Forms.TextBox()
        Me.cbCliStatus = New System.Windows.Forms.ComboBox()
        Me.txtCliRg = New System.Windows.Forms.TextBox()
        Me.txtCliCpf = New System.Windows.Forms.TextBox()
        Me.txtCliUf = New System.Windows.Forms.TextBox()
        Me.txtCliCep = New System.Windows.Forms.TextBox()
        Me.txtCliNum = New System.Windows.Forms.TextBox()
        Me.txtCliEnd = New System.Windows.Forms.TextBox()
        Me.txtCliNome = New System.Windows.Forms.TextBox()
        Me.lblIdCliente = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnMenuIniciar = New System.Windows.Forms.Button()
        Me.BtnAlteraCliente = New System.Windows.Forms.Button()
        Me.BtnIserirCliente = New System.Windows.Forms.Button()
        Me.lblCliAlteracao = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCliCidade = New System.Windows.Forms.TextBox()
        Me.BtnSalvaCliente = New System.Windows.Forms.Button()
        Me.BtnexcluiCliente = New System.Windows.Forms.Button()
        Me.DB_Biblioteca_Pre_Aula_2011DataSet = New Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSet()
        Me.TBStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TB_StatusTableAdapter = New Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSetTableAdapters.TB_StatusTableAdapter()
        CType(Me.DB_Biblioteca_Pre_Aula_2011DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Green
        Me.Label15.Location = New System.Drawing.Point(140, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(159, 13)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "CADASTRO DE CLIENTES"
        '
        'txtCliInclusao
        '
        Me.txtCliInclusao.Location = New System.Drawing.Point(129, 395)
        Me.txtCliInclusao.Name = "txtCliInclusao"
        Me.txtCliInclusao.Size = New System.Drawing.Size(149, 20)
        Me.txtCliInclusao.TabIndex = 10
        '
        'cbCliStatus
        '
        Me.cbCliStatus.DataSource = Me.TBStatusBindingSource
        Me.cbCliStatus.DisplayMember = "Status"
        Me.cbCliStatus.FormattingEnabled = True
        Me.cbCliStatus.Location = New System.Drawing.Point(99, 358)
        Me.cbCliStatus.Name = "cbCliStatus"
        Me.cbCliStatus.Size = New System.Drawing.Size(141, 21)
        Me.cbCliStatus.TabIndex = 9
        Me.cbCliStatus.ValueMember = "id"
        '
        'txtCliRg
        '
        Me.txtCliRg.Location = New System.Drawing.Point(99, 322)
        Me.txtCliRg.Name = "txtCliRg"
        Me.txtCliRg.Size = New System.Drawing.Size(141, 20)
        Me.txtCliRg.TabIndex = 8
        '
        'txtCliCpf
        '
        Me.txtCliCpf.Location = New System.Drawing.Point(99, 287)
        Me.txtCliCpf.Name = "txtCliCpf"
        Me.txtCliCpf.Size = New System.Drawing.Size(179, 20)
        Me.txtCliCpf.TabIndex = 7
        '
        'txtCliUf
        '
        Me.txtCliUf.Location = New System.Drawing.Point(99, 255)
        Me.txtCliUf.Name = "txtCliUf"
        Me.txtCliUf.Size = New System.Drawing.Size(100, 20)
        Me.txtCliUf.TabIndex = 6
        '
        'txtCliCep
        '
        Me.txtCliCep.Location = New System.Drawing.Point(99, 186)
        Me.txtCliCep.Name = "txtCliCep"
        Me.txtCliCep.Size = New System.Drawing.Size(100, 20)
        Me.txtCliCep.TabIndex = 4
        '
        'txtCliNum
        '
        Me.txtCliNum.Location = New System.Drawing.Point(99, 154)
        Me.txtCliNum.Name = "txtCliNum"
        Me.txtCliNum.Size = New System.Drawing.Size(100, 20)
        Me.txtCliNum.TabIndex = 3
        '
        'txtCliEnd
        '
        Me.txtCliEnd.Location = New System.Drawing.Point(99, 122)
        Me.txtCliEnd.Name = "txtCliEnd"
        Me.txtCliEnd.Size = New System.Drawing.Size(351, 20)
        Me.txtCliEnd.TabIndex = 2
        '
        'txtCliNome
        '
        Me.txtCliNome.Location = New System.Drawing.Point(99, 91)
        Me.txtCliNome.Name = "txtCliNome"
        Me.txtCliNome.Size = New System.Drawing.Size(262, 20)
        Me.txtCliNome.TabIndex = 1
        '
        'lblIdCliente
        '
        Me.lblIdCliente.AutoSize = True
        Me.lblIdCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdCliente.ForeColor = System.Drawing.Color.Green
        Me.lblIdCliente.Location = New System.Drawing.Point(112, 66)
        Me.lblIdCliente.Name = "lblIdCliente"
        Me.lblIdCliente.Size = New System.Drawing.Size(0, 13)
        Me.lblIdCliente.TabIndex = 40
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Green
        Me.Label13.Location = New System.Drawing.Point(27, 443)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 13)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Data Alteração:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Green
        Me.Label12.Location = New System.Drawing.Point(27, 403)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 13)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Data Inclusão:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Green
        Me.Label10.Location = New System.Drawing.Point(27, 367)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Status"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Green
        Me.Label9.Location = New System.Drawing.Point(27, 330)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "RG:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(27, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "CPF:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(27, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "UF:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(27, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Cep:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(27, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Número"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(27, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Endereço:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(27, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Nome:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(27, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Cod.Cliente:"
        '
        'BtnMenuIniciar
        '
        Me.BtnMenuIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMenuIniciar.ForeColor = System.Drawing.Color.Green
        Me.BtnMenuIniciar.Location = New System.Drawing.Point(317, 480)
        Me.BtnMenuIniciar.Name = "BtnMenuIniciar"
        Me.BtnMenuIniciar.Size = New System.Drawing.Size(75, 23)
        Me.BtnMenuIniciar.TabIndex = 14
        Me.BtnMenuIniciar.Text = "Voltar"
        Me.BtnMenuIniciar.UseVisualStyleBackColor = True
        '
        'BtnAlteraCliente
        '
        Me.BtnAlteraCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlteraCliente.ForeColor = System.Drawing.Color.Green
        Me.BtnAlteraCliente.Location = New System.Drawing.Point(155, 480)
        Me.BtnAlteraCliente.Name = "BtnAlteraCliente"
        Me.BtnAlteraCliente.Size = New System.Drawing.Size(75, 23)
        Me.BtnAlteraCliente.TabIndex = 12
        Me.BtnAlteraCliente.Text = "Alterar"
        Me.BtnAlteraCliente.UseVisualStyleBackColor = True
        '
        'BtnIserirCliente
        '
        Me.BtnIserirCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIserirCliente.ForeColor = System.Drawing.Color.Green
        Me.BtnIserirCliente.Location = New System.Drawing.Point(73, 480)
        Me.BtnIserirCliente.Name = "BtnIserirCliente"
        Me.BtnIserirCliente.Size = New System.Drawing.Size(75, 23)
        Me.BtnIserirCliente.TabIndex = 11
        Me.BtnIserirCliente.Text = "Inserir"
        Me.BtnIserirCliente.UseVisualStyleBackColor = True
        '
        'lblCliAlteracao
        '
        Me.lblCliAlteracao.AutoSize = True
        Me.lblCliAlteracao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliAlteracao.ForeColor = System.Drawing.Color.Green
        Me.lblCliAlteracao.Location = New System.Drawing.Point(129, 442)
        Me.lblCliAlteracao.Name = "lblCliAlteracao"
        Me.lblCliAlteracao.Size = New System.Drawing.Size(0, 13)
        Me.lblCliAlteracao.TabIndex = 54
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Green
        Me.Label8.Location = New System.Drawing.Point(27, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Cidade:"
        '
        'txtCliCidade
        '
        Me.txtCliCidade.Location = New System.Drawing.Point(99, 221)
        Me.txtCliCidade.Name = "txtCliCidade"
        Me.txtCliCidade.Size = New System.Drawing.Size(100, 20)
        Me.txtCliCidade.TabIndex = 5
        '
        'BtnSalvaCliente
        '
        Me.BtnSalvaCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvaCliente.ForeColor = System.Drawing.Color.Green
        Me.BtnSalvaCliente.Location = New System.Drawing.Point(236, 480)
        Me.BtnSalvaCliente.Name = "BtnSalvaCliente"
        Me.BtnSalvaCliente.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalvaCliente.TabIndex = 56
        Me.BtnSalvaCliente.Text = "Salvar"
        Me.BtnSalvaCliente.UseVisualStyleBackColor = True
        '
        'BtnexcluiCliente
        '
        Me.BtnexcluiCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnexcluiCliente.ForeColor = System.Drawing.Color.Green
        Me.BtnexcluiCliente.Location = New System.Drawing.Point(194, 509)
        Me.BtnexcluiCliente.Name = "BtnexcluiCliente"
        Me.BtnexcluiCliente.Size = New System.Drawing.Size(75, 23)
        Me.BtnexcluiCliente.TabIndex = 57
        Me.BtnexcluiCliente.Text = "Excluir"
        Me.BtnexcluiCliente.UseVisualStyleBackColor = True
        '
        'DB_Biblioteca_Pre_Aula_2011DataSet
        '
        Me.DB_Biblioteca_Pre_Aula_2011DataSet.DataSetName = "DB_Biblioteca_Pre_Aula_2011DataSet"
        Me.DB_Biblioteca_Pre_Aula_2011DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'CadCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 552)
        Me.Controls.Add(Me.BtnexcluiCliente)
        Me.Controls.Add(Me.BtnSalvaCliente)
        Me.Controls.Add(Me.txtCliCidade)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblCliAlteracao)
        Me.Controls.Add(Me.BtnMenuIniciar)
        Me.Controls.Add(Me.BtnAlteraCliente)
        Me.Controls.Add(Me.BtnIserirCliente)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtCliInclusao)
        Me.Controls.Add(Me.cbCliStatus)
        Me.Controls.Add(Me.txtCliRg)
        Me.Controls.Add(Me.txtCliCpf)
        Me.Controls.Add(Me.txtCliUf)
        Me.Controls.Add(Me.txtCliCep)
        Me.Controls.Add(Me.txtCliNum)
        Me.Controls.Add(Me.txtCliEnd)
        Me.Controls.Add(Me.txtCliNome)
        Me.Controls.Add(Me.lblIdCliente)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CadCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Cliente"
        CType(Me.DB_Biblioteca_Pre_Aula_2011DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCliInclusao As System.Windows.Forms.TextBox
    Friend WithEvents cbCliStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtCliRg As System.Windows.Forms.TextBox
    Friend WithEvents txtCliCpf As System.Windows.Forms.TextBox
    Friend WithEvents txtCliUf As System.Windows.Forms.TextBox
    Friend WithEvents txtCliCep As System.Windows.Forms.TextBox
    Friend WithEvents txtCliNum As System.Windows.Forms.TextBox
    Friend WithEvents txtCliEnd As System.Windows.Forms.TextBox
    Friend WithEvents txtCliNome As System.Windows.Forms.TextBox
    Friend WithEvents lblIdCliente As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnMenuIniciar As System.Windows.Forms.Button
    Friend WithEvents BtnAlteraCliente As System.Windows.Forms.Button
    Friend WithEvents BtnIserirCliente As System.Windows.Forms.Button
    Friend WithEvents lblCliAlteracao As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCliCidade As System.Windows.Forms.TextBox
    Friend WithEvents BtnSalvaCliente As System.Windows.Forms.Button
    Friend WithEvents BtnexcluiCliente As System.Windows.Forms.Button
    Friend WithEvents DB_Biblioteca_Pre_Aula_2011DataSet As Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSet
    Friend WithEvents TBStatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_StatusTableAdapter As Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSetTableAdapters.TB_StatusTableAdapter
End Class
