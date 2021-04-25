<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadCategoria))
        Me.txtCatdtinclusao = New System.Windows.Forms.TextBox()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LblCategoria = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnexcluiCat = New System.Windows.Forms.Button()
        Me.BtnMenuIniciar = New System.Windows.Forms.Button()
        Me.BtnSalvaCat = New System.Windows.Forms.Button()
        Me.BtnAlteraCat = New System.Windows.Forms.Button()
        Me.BtnIserirCat = New System.Windows.Forms.Button()
        Me.lblCatAlteracao = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCatdtinclusao
        '
        Me.txtCatdtinclusao.Location = New System.Drawing.Point(118, 99)
        Me.txtCatdtinclusao.Name = "txtCatdtinclusao"
        Me.txtCatdtinclusao.Size = New System.Drawing.Size(139, 20)
        Me.txtCatdtinclusao.TabIndex = 2
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(87, 66)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(170, 20)
        Me.txtCategoria.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(21, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Data Alteração:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(21, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Data Inclusão:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(21, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Categoria:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Green
        Me.Label15.Location = New System.Drawing.Point(61, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(170, 13)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "CADASTRO DE CATEGORIA"
        '
        'LblCategoria
        '
        Me.LblCategoria.AutoSize = True
        Me.LblCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCategoria.ForeColor = System.Drawing.Color.Green
        Me.LblCategoria.Location = New System.Drawing.Point(115, 39)
        Me.LblCategoria.Name = "LblCategoria"
        Me.LblCategoria.Size = New System.Drawing.Size(0, 13)
        Me.LblCategoria.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(21, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Cod. Categoria:"
        '
        'BtnexcluiCat
        '
        Me.BtnexcluiCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnexcluiCat.ForeColor = System.Drawing.Color.Green
        Me.BtnexcluiCat.Location = New System.Drawing.Point(64, 217)
        Me.BtnexcluiCat.Name = "BtnexcluiCat"
        Me.BtnexcluiCat.Size = New System.Drawing.Size(75, 23)
        Me.BtnexcluiCat.TabIndex = 6
        Me.BtnexcluiCat.Text = "Excluir"
        Me.BtnexcluiCat.UseVisualStyleBackColor = True
        '
        'BtnMenuIniciar
        '
        Me.BtnMenuIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMenuIniciar.ForeColor = System.Drawing.Color.Green
        Me.BtnMenuIniciar.Location = New System.Drawing.Point(145, 217)
        Me.BtnMenuIniciar.Name = "BtnMenuIniciar"
        Me.BtnMenuIniciar.Size = New System.Drawing.Size(75, 23)
        Me.BtnMenuIniciar.TabIndex = 7
        Me.BtnMenuIniciar.Text = "Voltar"
        Me.BtnMenuIniciar.UseVisualStyleBackColor = True
        '
        'BtnSalvaCat
        '
        Me.BtnSalvaCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvaCat.ForeColor = System.Drawing.Color.Green
        Me.BtnSalvaCat.Location = New System.Drawing.Point(187, 179)
        Me.BtnSalvaCat.Name = "BtnSalvaCat"
        Me.BtnSalvaCat.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalvaCat.TabIndex = 5
        Me.BtnSalvaCat.Text = "Salvar"
        Me.BtnSalvaCat.UseVisualStyleBackColor = True
        '
        'BtnAlteraCat
        '
        Me.BtnAlteraCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlteraCat.ForeColor = System.Drawing.Color.Green
        Me.BtnAlteraCat.Location = New System.Drawing.Point(106, 179)
        Me.BtnAlteraCat.Name = "BtnAlteraCat"
        Me.BtnAlteraCat.Size = New System.Drawing.Size(75, 23)
        Me.BtnAlteraCat.TabIndex = 4
        Me.BtnAlteraCat.Text = "Alterar"
        Me.BtnAlteraCat.UseVisualStyleBackColor = True
        '
        'BtnIserirCat
        '
        Me.BtnIserirCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIserirCat.ForeColor = System.Drawing.Color.Green
        Me.BtnIserirCat.Location = New System.Drawing.Point(24, 179)
        Me.BtnIserirCat.Name = "BtnIserirCat"
        Me.BtnIserirCat.Size = New System.Drawing.Size(75, 23)
        Me.BtnIserirCat.TabIndex = 3
        Me.BtnIserirCat.Text = "Inserir"
        Me.BtnIserirCat.UseVisualStyleBackColor = True
        '
        'lblCatAlteracao
        '
        Me.lblCatAlteracao.AutoSize = True
        Me.lblCatAlteracao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCatAlteracao.ForeColor = System.Drawing.Color.Green
        Me.lblCatAlteracao.Location = New System.Drawing.Point(118, 143)
        Me.lblCatAlteracao.Name = "lblCatAlteracao"
        Me.lblCatAlteracao.Size = New System.Drawing.Size(0, 13)
        Me.lblCatAlteracao.TabIndex = 67
        '
        'CadCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.lblCatAlteracao)
        Me.Controls.Add(Me.BtnexcluiCat)
        Me.Controls.Add(Me.BtnMenuIniciar)
        Me.Controls.Add(Me.BtnSalvaCat)
        Me.Controls.Add(Me.BtnAlteraCat)
        Me.Controls.Add(Me.BtnIserirCat)
        Me.Controls.Add(Me.txtCatdtinclusao)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LblCategoria)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CadCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Categoria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCatdtinclusao As System.Windows.Forms.TextBox
    Friend WithEvents txtCategoria As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LblCategoria As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnexcluiCat As System.Windows.Forms.Button
    Friend WithEvents BtnMenuIniciar As System.Windows.Forms.Button
    Friend WithEvents BtnSalvaCat As System.Windows.Forms.Button
    Friend WithEvents BtnAlteraCat As System.Windows.Forms.Button
    Friend WithEvents BtnIserirCat As System.Windows.Forms.Button
    Friend WithEvents lblCatAlteracao As System.Windows.Forms.Label
End Class
