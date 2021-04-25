<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuIniciar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuIniciar))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArquivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeFuncionárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocaçãoDeLivrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrosDeLivrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrosDeAreasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalizaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivosToolStripMenuItem, Me.LocaçãoToolStripMenuItem, Me.CadastrosToolStripMenuItem, Me.SairToolStripMenuItem, Me.SobreToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(385, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivosToolStripMenuItem
        '
        Me.ArquivosToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.ArquivosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroDeFuncionárioToolStripMenuItem, Me.CadastroDeClienteToolStripMenuItem})
        Me.ArquivosToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArquivosToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.ArquivosToolStripMenuItem.Name = "ArquivosToolStripMenuItem"
        Me.ArquivosToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ArquivosToolStripMenuItem.Text = "Arquivos"
        '
        'CadastroDeFuncionárioToolStripMenuItem
        '
        Me.CadastroDeFuncionárioToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.CadastroDeFuncionárioToolStripMenuItem.Name = "CadastroDeFuncionárioToolStripMenuItem"
        Me.CadastroDeFuncionárioToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.CadastroDeFuncionárioToolStripMenuItem.Text = "Cadastro de Funcionário"
        '
        'CadastroDeClienteToolStripMenuItem
        '
        Me.CadastroDeClienteToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.CadastroDeClienteToolStripMenuItem.Name = "CadastroDeClienteToolStripMenuItem"
        Me.CadastroDeClienteToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.CadastroDeClienteToolStripMenuItem.Text = "Cadastro de Cliente"
        '
        'LocaçãoToolStripMenuItem
        '
        Me.LocaçãoToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.LocaçãoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LocaçãoDeLivrosToolStripMenuItem})
        Me.LocaçãoToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocaçãoToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.LocaçãoToolStripMenuItem.Name = "LocaçãoToolStripMenuItem"
        Me.LocaçãoToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.LocaçãoToolStripMenuItem.Text = "Locação"
        '
        'LocaçãoDeLivrosToolStripMenuItem
        '
        Me.LocaçãoDeLivrosToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.LocaçãoDeLivrosToolStripMenuItem.Name = "LocaçãoDeLivrosToolStripMenuItem"
        Me.LocaçãoDeLivrosToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.LocaçãoDeLivrosToolStripMenuItem.Text = "Locação de Livros"
        '
        'CadastrosToolStripMenuItem
        '
        Me.CadastrosToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.CadastrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrosDeLivrosToolStripMenuItem, Me.CadastrosDeAreasToolStripMenuItem, Me.StatusToolStripMenuItem, Me.CategoriaToolStripMenuItem, Me.LocalizaçãoToolStripMenuItem})
        Me.CadastrosToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CadastrosToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem"
        Me.CadastrosToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.CadastrosToolStripMenuItem.Text = "Cadastros"
        '
        'CadastrosDeLivrosToolStripMenuItem
        '
        Me.CadastrosDeLivrosToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.CadastrosDeLivrosToolStripMenuItem.Name = "CadastrosDeLivrosToolStripMenuItem"
        Me.CadastrosDeLivrosToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.CadastrosDeLivrosToolStripMenuItem.Text = "Cadastros de Livros"
        '
        'CadastrosDeAreasToolStripMenuItem
        '
        Me.CadastrosDeAreasToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.CadastrosDeAreasToolStripMenuItem.Name = "CadastrosDeAreasToolStripMenuItem"
        Me.CadastrosDeAreasToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.CadastrosDeAreasToolStripMenuItem.Text = "Cadastros de Areas"
        '
        'StatusToolStripMenuItem
        '
        Me.StatusToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.StatusToolStripMenuItem.Name = "StatusToolStripMenuItem"
        Me.StatusToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.StatusToolStripMenuItem.Text = "Status"
        '
        'CategoriaToolStripMenuItem
        '
        Me.CategoriaToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem"
        Me.CategoriaToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.CategoriaToolStripMenuItem.Text = "Categoria"
        '
        'LocalizaçãoToolStripMenuItem
        '
        Me.LocalizaçãoToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.LocalizaçãoToolStripMenuItem.Name = "LocalizaçãoToolStripMenuItem"
        Me.LocalizaçãoToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.LocalizaçãoToolStripMenuItem.Text = "Localização"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.SairToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SairToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.SairToolStripMenuItem.Text = "Sobre"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.SobreToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SobreToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SobreToolStripMenuItem.Text = "Sair"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(385, 303)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MenuIniciar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(385, 327)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Green
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuIniciar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bibliotéca Virtual"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArquivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroDeFuncionárioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroDeClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocaçãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocaçãoDeLivrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastrosDeLivrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastrosDeAreasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LocalizaçãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
