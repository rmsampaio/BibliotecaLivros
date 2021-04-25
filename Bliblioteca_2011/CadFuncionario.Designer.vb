<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadFuncionario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadFuncionario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblIdFunc = New System.Windows.Forms.Label()
        Me.txtNomeFun = New System.Windows.Forms.TextBox()
        Me.txtEndFun = New System.Windows.Forms.TextBox()
        Me.txtNumFun = New System.Windows.Forms.TextBox()
        Me.txtCepFun = New System.Windows.Forms.TextBox()
        Me.txtUfFun = New System.Windows.Forms.TextBox()
        Me.txtCpfFun = New System.Windows.Forms.TextBox()
        Me.txtSenhaFun = New System.Windows.Forms.TextBox()
        Me.txtRgFun = New System.Windows.Forms.TextBox()
        Me.cbStatusFun = New System.Windows.Forms.ComboBox()
        Me.cbAreaFun = New System.Windows.Forms.ComboBox()
        Me.txtDtAdmiFun = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BtnexcluiFun = New System.Windows.Forms.Button()
        Me.BtnEditora = New System.Windows.Forms.Button()
        Me.BtnSalvaFun = New System.Windows.Forms.Button()
        Me.BtnAlteraFun = New System.Windows.Forms.Button()
        Me.BtnIserirFun = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCidadeFun = New System.Windows.Forms.TextBox()
        Me.lbldtAtFun = New System.Windows.Forms.Label()
        Me.DB_Biblioteca_Pre_Aula_2011DataSet = New Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSet()
        Me.TBStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TB_StatusTableAdapter = New Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSetTableAdapters.TB_StatusTableAdapter()
        Me.TBAreaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TB_AreaTableAdapter = New Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSetTableAdapters.TB_AreaTableAdapter()
        CType(Me.DB_Biblioteca_Pre_Aula_2011DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBAreaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(15, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cod_Funcionário:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(15, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(15, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Endereço:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(15, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Número"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(15, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cep:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(15, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "UF:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(15, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "CPF:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Green
        Me.Label8.Location = New System.Drawing.Point(15, 327)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Senha:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Green
        Me.Label9.Location = New System.Drawing.Point(15, 363)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "RG:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Green
        Me.Label10.Location = New System.Drawing.Point(15, 400)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Status"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Green
        Me.Label11.Location = New System.Drawing.Point(15, 441)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Area"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Green
        Me.Label12.Location = New System.Drawing.Point(15, 480)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Data Admissão:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Green
        Me.Label13.Location = New System.Drawing.Point(15, 520)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Data Alteração:"
        '
        'lblIdFunc
        '
        Me.lblIdFunc.AutoSize = True
        Me.lblIdFunc.Location = New System.Drawing.Point(128, 65)
        Me.lblIdFunc.Name = "lblIdFunc"
        Me.lblIdFunc.Size = New System.Drawing.Size(0, 13)
        Me.lblIdFunc.TabIndex = 13
        '
        'txtNomeFun
        '
        Me.txtNomeFun.Location = New System.Drawing.Point(87, 91)
        Me.txtNomeFun.Name = "txtNomeFun"
        Me.txtNomeFun.Size = New System.Drawing.Size(262, 20)
        Me.txtNomeFun.TabIndex = 1
        '
        'txtEndFun
        '
        Me.txtEndFun.Location = New System.Drawing.Point(87, 122)
        Me.txtEndFun.Name = "txtEndFun"
        Me.txtEndFun.Size = New System.Drawing.Size(351, 20)
        Me.txtEndFun.TabIndex = 2
        '
        'txtNumFun
        '
        Me.txtNumFun.Location = New System.Drawing.Point(87, 154)
        Me.txtNumFun.Name = "txtNumFun"
        Me.txtNumFun.Size = New System.Drawing.Size(100, 20)
        Me.txtNumFun.TabIndex = 3
        '
        'txtCepFun
        '
        Me.txtCepFun.Location = New System.Drawing.Point(87, 186)
        Me.txtCepFun.Name = "txtCepFun"
        Me.txtCepFun.Size = New System.Drawing.Size(100, 20)
        Me.txtCepFun.TabIndex = 4
        '
        'txtUfFun
        '
        Me.txtUfFun.Location = New System.Drawing.Point(87, 248)
        Me.txtUfFun.Name = "txtUfFun"
        Me.txtUfFun.Size = New System.Drawing.Size(100, 20)
        Me.txtUfFun.TabIndex = 6
        '
        'txtCpfFun
        '
        Me.txtCpfFun.Location = New System.Drawing.Point(87, 283)
        Me.txtCpfFun.Name = "txtCpfFun"
        Me.txtCpfFun.Size = New System.Drawing.Size(179, 20)
        Me.txtCpfFun.TabIndex = 7
        '
        'txtSenhaFun
        '
        Me.txtSenhaFun.Location = New System.Drawing.Point(87, 319)
        Me.txtSenhaFun.Name = "txtSenhaFun"
        Me.txtSenhaFun.Size = New System.Drawing.Size(141, 20)
        Me.txtSenhaFun.TabIndex = 8
        '
        'txtRgFun
        '
        Me.txtRgFun.Location = New System.Drawing.Point(87, 355)
        Me.txtRgFun.Name = "txtRgFun"
        Me.txtRgFun.Size = New System.Drawing.Size(141, 20)
        Me.txtRgFun.TabIndex = 9
        '
        'cbStatusFun
        '
        Me.cbStatusFun.DataSource = Me.TBStatusBindingSource
        Me.cbStatusFun.DisplayMember = "Status"
        Me.cbStatusFun.FormattingEnabled = True
        Me.cbStatusFun.Location = New System.Drawing.Point(87, 391)
        Me.cbStatusFun.Name = "cbStatusFun"
        Me.cbStatusFun.Size = New System.Drawing.Size(141, 21)
        Me.cbStatusFun.TabIndex = 10
        Me.cbStatusFun.ValueMember = "id"
        '
        'cbAreaFun
        '
        Me.cbAreaFun.DataSource = Me.TBAreaBindingSource
        Me.cbAreaFun.DisplayMember = "Area"
        Me.cbAreaFun.FormattingEnabled = True
        Me.cbAreaFun.Location = New System.Drawing.Point(87, 432)
        Me.cbAreaFun.Name = "cbAreaFun"
        Me.cbAreaFun.Size = New System.Drawing.Size(141, 21)
        Me.cbAreaFun.TabIndex = 11
        Me.cbAreaFun.ValueMember = "id"
        '
        'txtDtAdmiFun
        '
        Me.txtDtAdmiFun.Location = New System.Drawing.Point(117, 472)
        Me.txtDtAdmiFun.Name = "txtDtAdmiFun"
        Me.txtDtAdmiFun.Size = New System.Drawing.Size(149, 20)
        Me.txtDtAdmiFun.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(128, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(192, 13)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "CADASTRO DE FUNCIONÁRIOS"
        '
        'BtnexcluiFun
        '
        Me.BtnexcluiFun.Location = New System.Drawing.Point(190, 593)
        Me.BtnexcluiFun.Name = "BtnexcluiFun"
        Me.BtnexcluiFun.Size = New System.Drawing.Size(75, 23)
        Me.BtnexcluiFun.TabIndex = 18
        Me.BtnexcluiFun.Text = "Excluir"
        Me.BtnexcluiFun.UseVisualStyleBackColor = True
        '
        'BtnEditora
        '
        Me.BtnEditora.Location = New System.Drawing.Point(322, 564)
        Me.BtnEditora.Name = "BtnEditora"
        Me.BtnEditora.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditora.TabIndex = 17
        Me.BtnEditora.Text = "Voltar"
        Me.BtnEditora.UseVisualStyleBackColor = True
        '
        'BtnSalvaFun
        '
        Me.BtnSalvaFun.Location = New System.Drawing.Point(241, 564)
        Me.BtnSalvaFun.Name = "BtnSalvaFun"
        Me.BtnSalvaFun.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalvaFun.TabIndex = 16
        Me.BtnSalvaFun.Text = "Salvar"
        Me.BtnSalvaFun.UseVisualStyleBackColor = True
        '
        'BtnAlteraFun
        '
        Me.BtnAlteraFun.Location = New System.Drawing.Point(160, 564)
        Me.BtnAlteraFun.Name = "BtnAlteraFun"
        Me.BtnAlteraFun.Size = New System.Drawing.Size(75, 23)
        Me.BtnAlteraFun.TabIndex = 15
        Me.BtnAlteraFun.Text = "Alterar"
        Me.BtnAlteraFun.UseVisualStyleBackColor = True
        '
        'BtnIserirFun
        '
        Me.BtnIserirFun.Location = New System.Drawing.Point(78, 564)
        Me.BtnIserirFun.Name = "BtnIserirFun"
        Me.BtnIserirFun.Size = New System.Drawing.Size(75, 23)
        Me.BtnIserirFun.TabIndex = 14
        Me.BtnIserirFun.Text = "Inserir"
        Me.BtnIserirFun.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Green
        Me.Label16.Location = New System.Drawing.Point(15, 223)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Cidade:"
        '
        'txtCidadeFun
        '
        Me.txtCidadeFun.Location = New System.Drawing.Point(87, 215)
        Me.txtCidadeFun.Name = "txtCidadeFun"
        Me.txtCidadeFun.Size = New System.Drawing.Size(100, 20)
        Me.txtCidadeFun.TabIndex = 5
        '
        'lbldtAtFun
        '
        Me.lbldtAtFun.AutoSize = True
        Me.lbldtAtFun.Location = New System.Drawing.Point(117, 519)
        Me.lbldtAtFun.Name = "lbldtAtFun"
        Me.lbldtAtFun.Size = New System.Drawing.Size(0, 13)
        Me.lbldtAtFun.TabIndex = 13
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
        'TBAreaBindingSource
        '
        Me.TBAreaBindingSource.DataMember = "TB_Area"
        Me.TBAreaBindingSource.DataSource = Me.DB_Biblioteca_Pre_Aula_2011DataSet
        '
        'TB_AreaTableAdapter
        '
        Me.TB_AreaTableAdapter.ClearBeforeFill = True
        '
        'CadFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 647)
        Me.Controls.Add(Me.lbldtAtFun)
        Me.Controls.Add(Me.txtCidadeFun)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.BtnexcluiFun)
        Me.Controls.Add(Me.BtnEditora)
        Me.Controls.Add(Me.BtnSalvaFun)
        Me.Controls.Add(Me.BtnAlteraFun)
        Me.Controls.Add(Me.BtnIserirFun)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtDtAdmiFun)
        Me.Controls.Add(Me.cbAreaFun)
        Me.Controls.Add(Me.cbStatusFun)
        Me.Controls.Add(Me.txtRgFun)
        Me.Controls.Add(Me.txtSenhaFun)
        Me.Controls.Add(Me.txtCpfFun)
        Me.Controls.Add(Me.txtUfFun)
        Me.Controls.Add(Me.txtCepFun)
        Me.Controls.Add(Me.txtNumFun)
        Me.Controls.Add(Me.txtEndFun)
        Me.Controls.Add(Me.txtNomeFun)
        Me.Controls.Add(Me.lblIdFunc)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Green
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CadFuncionario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Funcionários"
        CType(Me.DB_Biblioteca_Pre_Aula_2011DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBAreaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblIdFunc As System.Windows.Forms.Label
    Friend WithEvents txtNomeFun As System.Windows.Forms.TextBox
    Friend WithEvents txtEndFun As System.Windows.Forms.TextBox
    Friend WithEvents txtNumFun As System.Windows.Forms.TextBox
    Friend WithEvents txtCepFun As System.Windows.Forms.TextBox
    Friend WithEvents txtUfFun As System.Windows.Forms.TextBox
    Friend WithEvents txtCpfFun As System.Windows.Forms.TextBox
    Friend WithEvents txtSenhaFun As System.Windows.Forms.TextBox
    Friend WithEvents txtRgFun As System.Windows.Forms.TextBox
    Friend WithEvents cbStatusFun As System.Windows.Forms.ComboBox
    Friend WithEvents cbAreaFun As System.Windows.Forms.ComboBox
    Friend WithEvents txtDtAdmiFun As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents BtnexcluiFun As System.Windows.Forms.Button
    Friend WithEvents BtnEditora As System.Windows.Forms.Button
    Friend WithEvents BtnSalvaFun As System.Windows.Forms.Button
    Friend WithEvents BtnAlteraFun As System.Windows.Forms.Button
    Friend WithEvents BtnIserirFun As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCidadeFun As System.Windows.Forms.TextBox
    Friend WithEvents lbldtAtFun As System.Windows.Forms.Label
    Friend WithEvents DB_Biblioteca_Pre_Aula_2011DataSet As Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSet
    Friend WithEvents TBStatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_StatusTableAdapter As Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSetTableAdapters.TB_StatusTableAdapter
    Friend WithEvents TBAreaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_AreaTableAdapter As Bliblioteca_2011.DB_Biblioteca_Pre_Aula_2011DataSetTableAdapters.TB_AreaTableAdapter
End Class
