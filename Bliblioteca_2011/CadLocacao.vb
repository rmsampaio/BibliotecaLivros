Imports System.Data.OleDb
Imports System.Data.DataTable

Public Class CadLocacao
    Dim cOn As OleDbConnection
    Dim cOmad As OleDbCommand
    Dim dRed As OleDbDataReader
    Dim sql As String
    Dim dSet As DataSet
    Dim sTrconn = "provider=microsoft.jet.OLEDB.4.0;Data Source = |DataDirectory|\DB_Biblioteca_Pre_Aula_2011.mdb"
    Dim eDitar, iNserir As Boolean
    Public Sub cOnectaBD(ByVal sql As String)
        Dim cOn As New OleDbConnection(sTrconn)
        cOn.Open()
        cOmad = New OleDbCommand(sql, cOn)
        cOmad.ExecuteNonQuery()
    End Sub
    Public Sub dEsconectBD()
        cOn.Close()
        cOn = Nothing ' Limpa area reservada para a memória
    End Sub
    Private Sub habilitaCampo(ByVal Habilita As Boolean)
        If Habilita = True Then
            lblIdLocacao.Enabled = True
            cbCliente.Enabled = True
            cbLivro.Enabled = True
            cbStatus.Enabled = True
            cbFuncionario.Enabled = True
            txtDtLoca.Enabled = True
            txtDtDevolucao.Enabled = True
            rtxtObservacoes.Enabled = True
        Else
            lblIdLocacao.Enabled = False
            cbCliente.Enabled = False
            cbLivro.Enabled = False
            cbStatus.Enabled = False
            cbFuncionario.Enabled = False
            txtDtLoca.Enabled = False
            txtDtDevolucao.Enabled = False
            rtxtObservacoes.Enabled = False
        End If
    End Sub
    Private Sub travaBotao()
        btnInserirLoc.Enabled = False
        BtnAlterarLoc.Enabled = False
        BtnExcluirLoc.Enabled = False
    End Sub
    Private Sub destravaBotao()
        btnInserirLoc.Enabled = True
        BtnAlterarLoc.Enabled = True
        BtnExcluirLoc.Enabled = True
    End Sub
    Private Sub LimpaCampos()
        lblIdLocacao.Text = ""
        cbCliente.Text = ""
        cbLivro.Text = ""
        cbStatus.Text = ""
        cbFuncionario.Text = ""
        txtDtLoca.Text = ""
        txtDtDevolucao.Text = ""
        rtxtObservacoes.Text = ""
    End Sub
    Private Sub Selecionar()
        Try
            lblIdLocacao.Text = dRed("id").ToString
            cbCliente.Text = dRed("idCliente").ToString
            cbLivro.Text = dRed("idLivro").ToString
            cbStatus.Text = dRed("idStatus").ToString
            cbFuncionario.Text = dRed("idFuncionario").ToString
            txtDtLoca.Text = dRed("dtLocacao").ToString
            txtDtDevolucao.Text = dRed("dtDevolucao").ToString
            rtxtObservacoes.Text = dRed("Obsescacao").ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnConsultaLoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultaLoc.Click
        Try
            sql = "Select id,idCliente as [Cliente],idLivro as [Livro],idStatus as [Status],idFuncionario as [Funcionario],dtLocacao as [Data Locação],dtDevolucao as [Data de Devolução],Obsercacao from TB_Locacao "
            sql += "Where idFuncionario like ('%" & txtConsultaLoc.Text & "%')"
            Dim cOn As New OleDbConnection(sTrconn)
            cOn.Open()
            cOmad = New OleDbCommand(sql, cOn)
            Dim adapter As New OleDbDataAdapter(cOmad)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            If Not dt.Rows.Count.Equals(0) Then
                DataGridView1.DataSource = dt
            Else
                MsgBox(" Não Foi Encontrado Nenhum Registro com esse Nome", MsgBoxStyle.Exclamation, "Erro - Vazio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cOn = Nothing ' Fecha Conexão com banco de dados
    End Sub

    Private Sub btnLimpaLoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpaLoc.Click
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim MenuInicio As New MenuIniciar
        MenuInicio.Show()
        Me.Hide()
    End Sub

    Private Sub btnInserirLoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirLoc.Click
        habilitaCampo(True)
        LimpaCampos()
        cbCliente.Focus()
        destravaBotao()
        iNserir = True
    End Sub

    Private Sub BtnAlterarLoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAlterarLoc.Click
        Dim rEsposta As String
        rEsposta = ""
        While (rEsposta = "")
            rEsposta = InputBox("Digite qual Nome do Funcionário Deseja Pesquisar", "Pesquiosa no Banco de Dados")
            If rEsposta = "" Then
                MsgBox("Você Deverá Digitar Algum Nome", MsgBoxStyle.Exclamation, "Erro")
            End If
        End While
        Try
            sql = "Select * from TB_Locacao "
            sql += "Where idFuncionario Like ('%" & rEsposta & "%')"
            Dim cOn As New OleDbConnection(sTrconn)
            cOn.Open()
            cOmad = New OleDbCommand(sql, cOn)
            dRed = cOmad.ExecuteReader
            If dRed.Read Then
                Selecionar()
                habilitaCampo(True)
                BtnSalvarLoc.Enabled = True
                destravaBotao()
                BtnSalvarLoc.Enabled = True
            Else
                MsgBox("Não foi Encontrado Nenhum Registro com este Nome", MsgBoxStyle.Exclamation, " Erro - Vazio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cOn = Nothing
    End Sub

    Private Sub BtnSalvarLoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalvarLoc.Click
        If iNserir = True Then
            sql = "Insert Into TB_Locacao (idCliente,idLivro,idStatus,idFuncionario,dtLocacao,Obsercacao) Values ("
            sql += "'" & cbCliente.Text & "'"
            sql += ",'" & cbLivro.Text & "'"
            sql += ",'" & cbStatus.Text & "'"
            sql += ",'" & cbFuncionario.Text & "'"
            sql += ",'" & txtDtLoca.Text & "'"
            sql += ",'" & rtxtObservacoes.Text & "')"
            Try
                cOnectaBD(sql)
                MsgBox("Cadastro Efetuado com Sucesso")
            Catch ex As Exception
                cOn = Nothing
                MsgBox(Err.Description)
            End Try
            LimpaCampos()
            habilitaCampo(False)
            iNserir = False
            BtnSalvarLoc.Enabled = False
            btnInserirLoc.Enabled = True
            BtnAlterarLoc.Enabled = True
            BtnExcluirLoc.Enabled = False
        Else
            sql = "Update Tb_Locacao Set "
            sql += "idCliente = '" & cbCliente.Text & "',"
            sql += "idLivro = '" & cbLivro.Text & "',"
            sql += "idStatus = '" & cbStatus.Text & "',"
            sql += "idFuncionario = '" & cbFuncionario.Text & "',"
            sql += "Obsercacao = '" & rtxtObservacoes.Text & "',"
            sql += "dtDevolucao = '" & DateTime.Now() & "'"
            sql += "Where id = " & lblIdLocacao.Text & ""
            Try
                cOnectaBD(sql)
                MsgBox("Registro Alterado com Sucesso")
            Catch ex As Exception
                cOn = Nothing
                MsgBox(Err.Description)
            End Try
            LimpaCampos()
            habilitaCampo(False)
            iNserir = False
            BtnSalvarLoc.Enabled = False
            btnInserirLoc.Enabled = True
            BtnAlterarLoc.Enabled = True
            BtnExcluirLoc.Enabled = False
        End If
    End Sub

    Private Sub BtnExcluirLoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExcluirLoc.Click
        sql = "Delete * From TB_Locacao"
        sql += " Where"
        sql += " id = '" & lblIdLocacao.Text & "'"
        Try
            cOnectaBD(sql)
            MsgBox("Registro Apagado")
        Catch ex As Exception
            MsgBox(ex.Message)
            cOn = Nothing
        End Try
        LimpaCampos()
        travaBotao()
        habilitaCampo(False)
        btnInserirLoc.Enabled = True
        BtnAlterarLoc.Enabled = True
    End Sub

    Private Sub CadLocacao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_Biblioteca_Pre_Aula_2011DataSet.TB_Funcionario' table. You can move, or remove it, as needed.
        Me.TB_FuncionarioTableAdapter.Fill(Me.DB_Biblioteca_Pre_Aula_2011DataSet.TB_Funcionario)
        'TODO: This line of code loads data into the 'DB_Biblioteca_Pre_Aula_2011DataSet.TB_Status' table. You can move, or remove it, as needed.
        Me.TB_StatusTableAdapter.Fill(Me.DB_Biblioteca_Pre_Aula_2011DataSet.TB_Status)
        'TODO: This line of code loads data into the 'DB_Biblioteca_Pre_Aula_2011DataSet.TB_Livro' table. You can move, or remove it, as needed.
        Me.TB_LivroTableAdapter.Fill(Me.DB_Biblioteca_Pre_Aula_2011DataSet.TB_Livro)
        'TODO: This line of code loads data into the 'DB_Biblioteca_Pre_Aula_2011DataSet.TB_Cliente' table. You can move, or remove it, as needed.
        Me.TB_ClienteTableAdapter.Fill(Me.DB_Biblioteca_Pre_Aula_2011DataSet.TB_Cliente)
        habilitaCampo(False)
        travaBotao()
        btnInserirLoc.Enabled = True
        BtnAlterarLoc.Enabled = True
    End Sub
End Class