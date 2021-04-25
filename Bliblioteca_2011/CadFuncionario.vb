Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class CadFuncionario
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
            lblIdFunc.Enabled = True
            txtNomeFun.Enabled = True
            txtEndFun.Enabled = True
            txtNumFun.Enabled = True
            txtCepFun.Enabled = True
            txtCidadeFun.Enabled = True
            txtUfFun.Enabled = True
            txtCpfFun.Enabled = True
            txtSenhaFun.Enabled = True
            txtRgFun.Enabled = True
            cbStatusFun.Enabled = True
            cbAreaFun.Enabled = True
            txtDtAdmiFun.Enabled = True
            lbldtAtFun.Enabled = True
        Else
            lblIdFunc.Enabled = False
            txtNomeFun.Enabled = False
            txtEndFun.Enabled = False
            txtNumFun.Enabled = False
            txtCepFun.Enabled = False
            txtCidadeFun.Enabled = False
            txtUfFun.Enabled = False
            txtCpfFun.Enabled = False
            txtSenhaFun.Enabled = False
            txtRgFun.Enabled = False
            cbStatusFun.Enabled = False
            cbAreaFun.Enabled = False
            txtDtAdmiFun.Enabled = False
            lbldtAtFun.Enabled = False
        End If
    End Sub
    Private Sub travaBotao()
        BtnIserirFun.Enabled = False
        BtnAlteraFun.Enabled = False
        BtnSalvaFun.Enabled = False
        BtnexcluiFun.Enabled = False
    End Sub
    Private Sub destravaBotao()
        BtnIserirFun.Enabled = True
        BtnAlteraFun.Enabled = True
        BtnSalvaFun.Enabled = True
        BtnexcluiFun.Enabled = True
    End Sub
    Private Sub LimpaCampos()
        lblIdFunc.Text = ""
        txtNomeFun.Text = ""
        txtEndFun.Text = ""
        txtNumFun.Text = ""
        txtCepFun.Text = ""
        txtCidadeFun.Text = ""
        txtUfFun.Text = ""
        txtCpfFun.Text = ""
        txtSenhaFun.Text = ""
        txtRgFun.Text = ""
        cbStatusFun.Text = ""
        cbAreaFun.Text = ""
        txtDtAdmiFun.Text = ""
        lbldtAtFun.Text = ""
    End Sub
    Private Sub Selecionar()
        Try
            lblIdFunc.Text = dRed("id").ToString
            txtNomeFun.Text = dRed("Nome").ToString
            txtEndFun.Text = dRed("Endereco").ToString
            txtNumFun.Text = dRed("Numero").ToString
            txtCepFun.Text = dRed("Cep").ToString
            txtCidadeFun.Text = dRed("Cidade").ToString
            txtUfFun.Text = dRed("Uf").ToString
            txtCpfFun.Text = dRed("Cpf").ToString
            txtSenhaFun.Text = dRed("Senha").ToString
            txtRgFun.Text = dRed("Rg").ToString
            cbStatusFun.Text = dRed("idStatus").ToString
            cbAreaFun.Text = dRed("idArea").ToString
            txtDtAdmiFun.Text = dRed("dtInclusao").ToString
            lbldtAtFun.Text = dRed("dtAlteracao").ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CadFuncionario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_Biblioteca_Pre_Aula_2011DataSet.TB_Area' table. You can move, or remove it, as needed.
        Me.TB_AreaTableAdapter.Fill(Me.DB_Biblioteca_Pre_Aula_2011DataSet.TB_Area)
        'TODO: This line of code loads data into the 'DB_Biblioteca_Pre_Aula_2011DataSet.TB_Status' table. You can move, or remove it, as needed.
        Me.TB_StatusTableAdapter.Fill(Me.DB_Biblioteca_Pre_Aula_2011DataSet.TB_Status)
        habilitaCampo(False)
        travaBotao()
        BtnIserirFun.Enabled = True
        BtnAlteraFun.Enabled = True
    End Sub
    Private Sub BtnEditora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditora.Click
        Dim MenInicio As New MenuIniciar
        MenInicio.Show()
        Me.Hide()
    End Sub
    Private Sub BtnIserirLivro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIserirFun.Click
        habilitaCampo(True)
        LimpaCampos()
        txtNomeFun.Focus()
        destravaBotao()
        iNserir = True
    End Sub
    Private Sub BtnAlteraLivro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAlteraFun.Click
        Dim rEsposta As String
        rEsposta = ""
        While (rEsposta = "")
            rEsposta = InputBox("Digite qual Nome Deseja Pesquisar", "Pesquiosa no Banco de Dados")
            If rEsposta = "" Then
                MsgBox("Você Deverá Digitar Algum Nome", MsgBoxStyle.Exclamation, "Erro")
            End If
        End While
        Try
            sql = "Select * from TB_Funcionario "
            sql += "Where Nome ='" & rEsposta & "'"
            Dim cOn As New OleDbConnection(sTrconn)
            cOn.Open()
            cOmad = New OleDbCommand(sql, cOn)
            dRed = cOmad.ExecuteReader
            If dRed.Read Then
                Selecionar()
                habilitaCampo(True)
                BtnSalvaFun.Enabled = True
                destravaBotao()
                BtnSalvaFun.Enabled = True
            Else
                MsgBox("Não foi Encontrado Nenhum Registro com este Nome", MsgBoxStyle.Exclamation, " Erro - Vazio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cOn = Nothing
    End Sub
    Private Sub BtnSalvaLibro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalvaFun.Click
        If iNserir = True Then
            sql = "Insert Into TB_Funcionario (Nome,Endereco,Numero,Cep,Cidade,Uf,Cpf,Senha,Rg,idStatus,idArea,dtInclusao) Values ("
            sql += "'" & txtNomeFun.Text & "'"
            sql += ",'" & txtEndFun.Text & "'"
            sql += ",'" & txtNumFun.Text & "'"
            sql += ",'" & txtCepFun.Text & "'"
            sql += ",'" & txtCidadeFun.Text & "'"
            sql += ",'" & txtUfFun.Text & "'"
            sql += ",'" & txtCpfFun.Text & "'"
            sql += ",'" & txtSenhaFun.Text & "'"
            sql += ",'" & txtRgFun.Text & "'"
            sql += ",'" & cbStatusFun.Text & "'"
            sql += ",'" & cbAreaFun.Text & "'"
            sql += ",'" & txtDtAdmiFun.Text & "')"
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
            BtnSalvaFun.Enabled = False
            BtnIserirFun.Enabled = True
            BtnAlteraFun.Enabled = True
            BtnexcluiFun.Enabled = False
        Else
            sql = "Update Tb_Funcionario Set "
            sql += "Nome = '" & txtNomeFun.Text & "',"
            sql += "Endereco = '" & txtEndFun.Text & "',"
            sql += "Numero = '" & txtNumFun.Text & "',"
            sql += "Cep = '" & txtCepFun.Text & "',"
            sql += "Cidade = '" & txtCidadeFun.Text & "',"
            sql += "Uf = '" & txtUfFun.Text & "',"
            sql += "Cpf = '" & txtCpfFun.Text & "',"
            sql += "Senha = '" & txtSenhaFun.Text & "',"
            sql += "Rg = '" & txtRgFun.Text & "',"
            sql += "idStatus = '" & cbStatusFun.Text & "',"
            sql += "idArea = '" & cbAreaFun.Text & "',"
            sql += "dtAlteracao = '" & DateTime.Now() & "'"
            sql += "Where id = " & lblIdFunc.Text & ""
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
            BtnSalvaFun.Enabled = False
            BtnIserirFun.Enabled = True
            BtnAlteraFun.Enabled = True
            BtnexcluiFun.Enabled = False
        End If
    End Sub
    Private Sub BtnexcluiLivro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnexcluiFun.Click
        sql = "Delete * From TB_Funcionario"
        sql += " Where"
        sql += " Nome = '" & txtNomeFun.Text & "'"
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
        BtnIserirFun.Enabled = True
        BtnAlteraFun.Enabled = True
    End Sub
End Class


