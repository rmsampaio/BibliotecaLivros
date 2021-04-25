<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadaArea
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadaArea))
        Me.BtnexcluiArea = New System.Windows.Forms.Button()
        Me.BtnMenuIniciar = New System.Windows.Forms.Button()
        Me.BtnSalvaArea = New System.Windows.Forms.Button()
        Me.BtnAlteraArea = New System.Windows.Forms.Button()
        Me.BtnIserirArea = New System.Windows.Forms.Button()
        Me.txtAreaInclusao = New System.Windows.Forms.TextBox()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.lblAreaAlteracao = New System.Windows.Forms.Label()
        Me.cbAreaStatus = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DB_Biblioteca_Pre_Aula_2011DataSet = New Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSet()
        Me.TBStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TB_StatusTableAdapter = New Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSetTableAdapters.TB_StatusTableAdapter()
        CType(Me.DB_Biblioteca_Pre_Aula_2011DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnexcluiArea
        '
        Me.BtnexcluiArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnexcluiArea.ForeColor = System.Drawing.Color.Green
        Me.BtnexcluiArea.Location = New System.Drawing.Point(64, 265)
        Me.BtnexcluiArea.Name = "BtnexcluiArea"
        Me.BtnexcluiArea.Size = New System.Drawing.Size(75, 23)
        Me.BtnexcluiArea.TabIndex = 7
        Me.BtnexcluiArea.Text = "Excluir"
        Me.BtnexcluiArea.UseVisualStyleBackColor = True
        '
        'BtnMenuIniciar
        '
        Me.BtnMenuIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMenuIniciar.ForeColor = System.Drawing.Color.Green
        Me.BtnMenuIniciar.Location = New System.Drawing.Point(145, 265)
        Me.BtnMenuIniciar.Name = "BtnMenuIniciar"
        Me.BtnMenuIniciar.Size = New System.Drawing.Size(75, 23)
        Me.BtnMenuIniciar.TabIndex = 8
        Me.BtnMenuIniciar.Text = "Voltar"
        Me.BtnMenuIniciar.UseVisualStyleBackColor = True
        '
        'BtnSalvaArea
        '
        Me.BtnSalvaArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvaArea.ForeColor = System.Drawing.Color.Green
        Me.BtnSalvaArea.Location = New System.Drawing.Point(187, 227)
        Me.BtnSalvaArea.Name = "BtnSalvaArea"
        Me.BtnSalvaArea.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalvaArea.TabIndex = 6
        Me.BtnSalvaArea.Text = "Salvar"
        Me.BtnSalvaArea.UseVisualStyleBackColor = True
        '
        'BtnAlteraArea
        '
        Me.BtnAlteraArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlteraArea.ForeColor = System.Drawing.Color.Green
        Me.BtnAlteraArea.Location = New System.Drawing.Point(106, 227)
        Me.BtnAlteraArea.Name = "BtnAlteraArea"
        Me.BtnAlteraArea.Size = New System.Drawing.Size(75, 23)
        Me.BtnAlteraArea.TabIndex = 5
        Me.BtnAlteraArea.Text = "Alterar"
        Me.BtnAlteraArea.UseVisualStyleBackColor = True
        '
        'BtnIserirArea
        '
        Me.BtnIserirArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIserirArea.ForeColor = System.Drawing.Color.Green
        Me.BtnIserirArea.Location = New System.Drawing.Point(24, 227)
        Me.BtnIserirArea.Name = "BtnIserirArea"
        Me.BtnIserirArea.Size = New System.Drawing.Size(75, 23)
        Me.BtnIserirArea.TabIndex = 4
        Me.BtnIserirArea.Text = "Inserir"
        Me.BtnIserirArea.UseVisualStyleBackColor = True
        '
        'txtAreaInclusao
        '
        Me.txtAreaInclusao.Location = New System.Drawing.Point(116, 135)
        Me.txtAreaInclusao.Name = "txtAreaInclusao"
        Me.txtAreaInclusao.Size = New System.Drawing.Size(139, 20)
        Me.txtAreaInclusao.TabIndex = 3
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(71, 68)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(184, 20)
        Me.txtArea.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(19, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Data Alteração:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(19, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Data Inclusão:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(19, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Area:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Green
        Me.Label15.Location = New System.Drawing.Point(78, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(132, 13)
        Me.Label15.TabIndex = 67
        Me.Label15.Text = "CADASTRO DE AREA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(19, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Cod_Area:"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.ForeColor = System.Drawing.Color.Green
        Me.lblArea.Location = New System.Drawing.Point(91, 41)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(0, 13)
        Me.lblArea.TabIndex = 1
        '
        'lblAreaAlteracao
        '
        Me.lblAreaAlteracao.AutoSize = True
        Me.lblAreaAlteracao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAreaAlteracao.ForeColor = System.Drawing.Color.Green
        Me.lblAreaAlteracao.Location = New System.Drawing.Point(121, 180)
        Me.lblAreaAlteracao.Name = "lblAreaAlteracao"
        Me.lblAreaAlteracao.Size = New System.Drawing.Size(0, 13)
        Me.lblAreaAlteracao.TabIndex = 4
        '
        'cbAreaStatus
        '
        Me.cbAreaStatus.DataSource = Me.TBStatusBindingSource
        Me.cbAreaStatus.DisplayMember = "Status"
        Me.cbAreaStatus.FormattingEnabled = True
        Me.cbAreaStatus.Location = New System.Drawing.Point(74, 102)
        Me.cbAreaStatus.Name = "cbAreaStatus"
        Me.cbAreaStatus.Size = New System.Drawing.Size(146, 21)
        Me.cbAreaStatus.TabIndex = 2
        Me.cbAreaStatus.ValueMember = "id"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(21, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Status:"
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
        'CadaArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 300)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbAreaStatus)
        Me.Controls.Add(Me.lblAreaAlteracao)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.BtnexcluiArea)
        Me.Controls.Add(Me.BtnMenuIniciar)
        Me.Controls.Add(Me.BtnSalvaArea)
        Me.Controls.Add(Me.BtnAlteraArea)
        Me.Controls.Add(Me.BtnIserirArea)
        Me.Controls.Add(Me.txtAreaInclusao)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CadaArea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Area"
        CType(Me.DB_Biblioteca_Pre_Aula_2011DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnexcluiArea As System.Windows.Forms.Button
    Friend WithEvents BtnMenuIniciar As System.Windows.Forms.Button
    Friend WithEvents BtnSalvaArea As System.Windows.Forms.Button
    Friend WithEvents BtnAlteraArea As System.Windows.Forms.Button
    Friend WithEvents BtnIserirArea As System.Windows.Forms.Button
    Friend WithEvents txtAreaInclusao As System.Windows.Forms.TextBox
    Friend WithEvents txtArea As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents lblAreaAlteracao As System.Windows.Forms.Label
    Friend WithEvents cbAreaStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DB_Biblioteca_Pre_Aula_2011DataSet As Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSet
    Friend WithEvents TBStatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_StatusTableAdapter As Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSetTableAdapters.TB_StatusTableAdapter
End Class
