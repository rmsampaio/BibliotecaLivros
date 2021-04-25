Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class CadLivro
    Dim cOn As OleDbConnection
    Dim cOmad As OleDbCommand
    Dim dRed As OleDbDataReader
    Dim sql As String
    Dim dSet As DataSet
    Dim sTrconn = "provider=microsoft.jet.OLEDB.4.0;Data Source = |DataDirectory|\DB_Biblioteca_Pre_Aula_2011.mdb"
    Dim eDitar, iNserir As Boolean
    Public Sub cOnectaDB(ByVal sql As String)
        Dim cOn As New OleDbConnection(sTrconn)
        cOn.Open()
        cOmad = New OleDbCommand(sql, cOn)
        cOmad.ExecuteNonQuery()
    End Sub
    Public Sub dEsconectaDB()
        cOn.Close()
        cOn = Nothing 'Limpa Memória'
    End Sub
    Private Sub habilitaCampo(ByVal Habilita As Boolean)
        If Habilita = True Then
            lblidLivro.Enabled = True
            txtNomeLivro.Enabled = True
            txtNomeEditora.Enabled = True
            txtAutor.Enabled = True
            cbEstoque.Enabled = True
            cbCategoria.Enabled = True
            cbStatus.Enabled = True
            txtIsbn.Enabled = True
            txtDtinclusao.Enabled = True
            lblDtAlteracao.Enabled = True
        Else
            lblidLivro.Enabled = False
            txtNomeLivro.Enabled = False
            txtNomeEditora.Enabled = False
            txtAutor.Enabled = False
            cbEstoque.Enabled = False
            cbCategoria.Enabled = False
            cbStatus.Enabled = False
            txtIsbn.Enabled = False
            txtDtinclusao.Enabled = False
            lblDtAlteracao.Enabled = False
        End If
    End Sub
    Private Sub travaBotao()
        BtnIserirLivro.Enabled = False
        BtnAlteraLivro.Enabled = False
        BtnSalvaLibro.Enabled = False
        BtnexcluiLivro.Enabled = False
    End Sub
    Private Sub destravaBotao()
        BtnIserirLivro.Enabled = True
        BtnAlteraLivro.Enabled = True
        BtnSalvaLibro.Enabled = True
        BtnexcluiLivro.Enabled = True
    End Sub
    Private Sub LimpaCampos()
        lblidLivro.Text = ""
        txtNomeLivro.Text = ""
        txtNomeEditora.Text = ""
        txtAutor.Text = ""
        cbEstoque.Text = ""
        cbCategoria.Text = ""
        cbStatus.Text = ""
        txtIsbn.Text = ""
        txtDtinclusao.Text = ""
        lblDtAlteracao.Text = ""
    End Sub
    Private Sub Selecionar()
        Try
            lblidLivro.Text = dRed("id").ToString
            txtNomeLivro.Text = dRed("nomeLivro").ToString
            txtNomeEditora.Text = dRed("Editora").ToString
            txtAutor.Text = dRed("Autor").ToString
            cbEstoque.Text = dRed("idEstoque").ToString
            cbCategoria.Text = dRed("idCategoria").ToString
            cbStatus.Text = dRed("idStatus").ToString
            txtIsbn.Text = dRed("Isbn").ToString
            txtDtinclusao.Text = dRed("dtInclusao").ToString
            lblDtAlteracao.Text = dRed("dtAlteracao").ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CadLivro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_Biblioteca_Pre_Aula_2011DataSet.TB_Status' table. You can move, or remove it, as needed.
        Me.TB_StatusTableAdapter.Fill(Me.DB_Biblioteca_Pre_Aula_2011DataSet.TB_Status)
        'TODO: This line of code loads data into the 'DB_Biblioteca_Pre_Aula_2011DataSet.TB_Categoria' table. You can move, or remove it, as needed.
        Me.TB_CategoriaTableAdapter.Fill(Me.DB_Biblioteca_Pre_Aula_2011DataSet.TB_Categoria)
        'TODO: This line of code loads data into the 'DB_Biblioteca_Pre_Aula_2011DataSet.TB_Estoque' table. You can move, or remove it, as needed.
        Me.TB_EstoqueTableAdapter.Fill(Me.DB_Biblioteca_Pre_Aula_2011DataSet.TB_Estoque)
        habilitaCampo(False)
        travaBotao()
        BtnIserirLivro.Enabled = True
        BtnAlteraLivro.Enabled = True
    End Sub
    Private Sub BtnEditora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditora.Click
        Dim MenInicio As New MenuIniciar
        MenInicio.Show()
        Me.Hide()
    End Sub

    Private Sub BtnIserirLivro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIserirLivro.Click
        habilitaCampo(True)
        LimpaCampos()
        txtNomeLivro.Focus()
        destravaBotao()
        iNserir = True
    End Sub

    Private Sub BtnAlteraLivro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAlteraLivro.Click
        Dim rEsposta As String
        rEsposta = ""
        While (rEsposta = "")
            rEsposta = InputBox("Digite qual Livro Deseja Pesquisar", "Pesquiosa no Banco de Dados")
            If rEsposta = "" Then
                MsgBox("Você Deverá Digitar Algum Nome", MsgBoxStyle.Exclamation, "Erro")
            End If
        End While
        Try
            sql = "Select * from TB_Livro "
            sql += "Where Nome ='" & rEsposta & "'"
            Dim cOn As New OleDbConnection(sTrconn)
            cOn.Open()
            cOmad = New OleDbCommand(sql, cOn)
            dRed = cOmad.ExecuteReader
            If dRed.Read Then
                Selecionar()
                habilitaCampo(True)
                BtnSalvaLibro.Enabled = True
                destravaBotao()
                BtnSalvaLibro.Enabled = True
            Else
                MsgBox("Não foi Encontrado Nenhum Registro com este Nome", MsgBoxStyle.Exclamation, " Erro - Vazio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cOn = Nothing
    End Sub

    Private Sub BtnSalvaLibro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalvaLibro.Click
        If iNserir = True Then
            sql = "Insert Into TB_Livro (nomeLivro,Editora,Autor,idEstoque,idCategoria,idStatus,isbn,dtInclusao) Values ("
            sql += "'" & txtNomeLivro.Text & "'"
            sql += ",'" & txtNomeEditora.Text & "'"
            sql += ",'" & txtAutor.Text & "'"
            sql += ",'" & cbEstoque.Text & "'"
            sql += ",'" & cbCategoria.Text & "'"
            sql += ",'" & cbStatus.Text & "'"
            sql += ",'" & txtIsbn.Text & "'"
            sql += ",'" & txtDtinclusao.Text & "')"
            Try
                cOnectaDB(sql)
                MsgBox("Cadastro Efetuado com Sucesso")
            Catch ex As Exception
                cOn = Nothing
                MsgBox(Err.Description)
            End Try
            LimpaCampos()
            habilitaCampo(False)
            iNserir = False
            BtnSalvaLibro.Enabled = False
            BtnIserirLivro.Enabled = True
            BtnAlteraLivro.Enabled = True
            BtnexcluiLivro.Enabled = False
        Else
            sql = "Update Tb_Livro Set "
            sql += "nomeLivro = '" & txtNomeLivro.Text & "',"
            sql += "Editora = '" & txtNomeEditora.Text & "',"
            sql += "Autor = '" & txtAutor.Text & "',"
            sql += "idEstoque = '" & cbEstoque.Text & "',"
            sql += "idCategoria = '" & cbCategoria.Text & "',"
            sql += "idStatus = '" & cbStatus.Text & "',"
            sql += "Isbn = '" & txtIsbn.Text & "',"
            sql += "dtAlteracao = '" & DateTime.Now() & "'"
            sql += "Where id = " & lblidLivro.Text & ""
            Try
                cOnectaDB(sql)
                MsgBox("Registro Alterado com Sucesso")
            Catch ex As Exception
                cOn = Nothing
                MsgBox(Err.Description)
            End Try
            LimpaCampos()
            habilitaCampo(False)
            iNserir = False
            BtnSalvaLibro.Enabled = False
            BtnIserirLivro.Enabled = True
            BtnAlteraLivro.Enabled = True
            BtnexcluiLivro.Enabled = False
        End If
    End Sub

    Private Sub BtnexcluiLivro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnexcluiLivro.Click
        sql = "Delete * From TB_Livro"
        sql += " Where"
        sql += " Nome = '" & txtNomeLivro.Text & "'"
        Try
            cOnectaDB(sql)
            MsgBox("Registro Apagado")
        Catch ex As Exception
            MsgBox(ex.Message)
            cOn = Nothing
        End Try
        LimpaCampos()
        travaBotao()
        habilitaCampo(False)
        BtnIserirLivro.Enabled = True
        BtnAlteraLivro.Enabled = True
    End Sub
End Class