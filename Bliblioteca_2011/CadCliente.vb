Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class CadCliente
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
            lblIdCliente.Enabled = True
            txtCliNome.Enabled = True
            txtCliEnd.Enabled = True
            txtCliNum.Enabled = True
            txtCliCep.Enabled = True
            txtCliCidade.Enabled = True
            txtCliUf.Enabled = True
            txtCliCpf.Enabled = True
            txtCliRg.Enabled = True
            cbCliStatus.Enabled = True
            txtCliInclusao.Enabled = True
            lblCliAlteracao.Enabled = True
        Else
            lblIdCliente.Enabled = False
            txtCliNome.Enabled = False
            txtCliEnd.Enabled = False
            txtCliNum.Enabled = False
            txtCliCep.Enabled = False
            txtCliCidade.Enabled = False
            txtCliUf.Enabled = False
            txtCliCpf.Enabled = False
            txtCliRg.Enabled = False
            cbCliStatus.Enabled = False
            txtCliInclusao.Enabled = False
            lblCliAlteracao.Enabled = False
        End If
    End Sub
    Private Sub travaBotao()
        BtnIserirCliente.Enabled = False
        BtnAlteraCliente.Enabled = False
        BtnSalvaCliente.Enabled = False
        BtnexcluiCliente.Enabled = False
    End Sub
    Private Sub destravaBotao()
        BtnIserirCliente.Enabled = True
        BtnAlteraCliente.Enabled = True
        BtnSalvaCliente.Enabled = True
        BtnexcluiCliente.Enabled = True
    End Sub
    Private Sub LimpaCampos()
        lblIdCliente.Text = ""
        txtCliNome.Text = ""
        txtCliEnd.Text = ""
        txtCliNum.Text = ""
        txtCliCep.Text = ""
        txtCliCidade.Text = ""
        txtCliUf.Text = ""
        txtCliCpf.Text = ""
        txtCliRg.Text = ""
        cbCliStatus.Text = ""
        txtCliInclusao.Text = ""
        lblCliAlteracao.Text = ""
    End Sub
    Private Sub Selecionar()
        Try
            lblIdCliente.Text = dRed("id").ToString
            txtCliNome.Text = dRed("Nome").ToString
            txtCliEnd.Text = dRed("Endereco").ToString
            txtCliNum.Text = dRed("Numero").ToString
            txtCliCep.Text = dRed("Cep").ToString
            txtCliCidade.Text = dRed("Cidade").ToString
            txtCliUf.Text = dRed("Uf").ToString
            txtCliCpf.Text = dRed("Cpf").ToString
            txtCliRg.Text = dRed("Rg").ToString
            cbCliStatus.Text = dRed("idStatus").ToString
            txtCliInclusao.Text = dRed("dtInclusao").ToString
            lblCliAlteracao.Text = dRed("dtAlteracao").ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CadCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_Biblioteca_Pre_Aula_2011DataSet.TB_Status' table. You can move, or remove it, as needed.
        Me.TB_StatusTableAdapter.Fill(Me.DB_Biblioteca_Pre_Aula_2011DataSet.TB_Status)
        habilitaCampo(False)
        travaBotao()
        BtnIserirCliente.Enabled = True
        BtnAlteraCliente.Enabled = True
    End Sub
    Private Sub BtnIserirCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIserirCliente.Click
        habilitaCampo(True)
        LimpaCampos()
        txtCliNome.Focus()
        destravaBotao()
        iNserir = True
    End Sub

    Private Sub BtnAlteraCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAlteraCliente.Click
        Dim rEsposta As String
        rEsposta = ""
        While (rEsposta = "")
            rEsposta = InputBox("Digite qual Nome Deseja Pesquisar", "Pesquiosa no Banco de Dados")
            If rEsposta = "" Then
                MsgBox("Você Deverá Digitar Algum Nome", MsgBoxStyle.Exclamation, "Erro")
            End If
        End While
        Try
            sql = "Select * from TB_Cliente "
            sql += "Where Nome ='" & rEsposta & "'"
            Dim cOn As New OleDbConnection(sTrconn)
            cOn.Open()
            cOmad = New OleDbCommand(sql, cOn)
            dRed = cOmad.ExecuteReader
            If dRed.Read Then
                Selecionar()
                habilitaCampo(True)
                BtnSalvaCliente.Enabled = True
                destravaBotao()
                BtnSalvaCliente.Enabled = True
            Else
                MsgBox("Não foi Encontrado Nenhum Registro com este Nome", MsgBoxStyle.Exclamation, " Erro - Vazio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cOn = Nothing
    End Sub
    Private Sub BtnEditora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMenuIniciar.Click
        Dim MenInicio As New MenuIniciar
        MenInicio.Show()
        Me.Hide()
    End Sub

    Private Sub BtnSalvaCliente_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalvaCliente.Click
        If iNserir = True Then
            sql = "Insert Into TB_Cliente (Nome,Endereco,Numero,Cep,Cidade,Uf,Cpf,Rg,idStatus,dtInclusao) Values ("
            sql += "'" & txtCliNome.Text & "'"
            sql += ",'" & txtCliEnd.Text & "'"
            sql += ",'" & txtCliNum.Text & "'"
            sql += ",'" & txtCliCep.Text & "'"
            sql += ",'" & txtCliCidade.Text & "'"
            sql += ",'" & txtCliUf.Text & "'"
            sql += ",'" & txtCliCpf.Text & "'"
            sql += ",'" & txtCliRg.Text & "'"
            sql += ",'" & cbCliStatus.Text & "'"
            sql += ",'" & txtCliInclusao.Text & "')"
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
            BtnSalvaCliente.Enabled = False
            BtnIserirCliente.Enabled = True
            BtnAlteraCliente.Enabled = True
            BtnexcluiCliente.Enabled = False
        Else
            sql = "Update Tb_Cliente Set "
            sql += "Nome = '" & txtCliNome.Text & "',"
            sql += "Endereco = '" & txtCliEnd.Text & "',"
            sql += "Numero = '" & txtCliNum.Text & "',"
            sql += "Cep = '" & txtCliCep.Text & "',"
            sql += "Cidade = '" & txtCliCidade.Text & "',"
            sql += "Uf = '" & txtCliUf.Text & "',"
            sql += "Cpf = '" & txtCliCpf.Text & "',"
            sql += "Rg = '" & txtCliRg.Text & "',"
            sql += "idStatus = '" & cbCliStatus.Text & "',"
            sql += "dtAlteracao = '" & DateTime.Now() & "'"
            sql += "Where id = " & lblIdCliente.Text & ""
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
            BtnSalvaCliente.Enabled = False
            BtnIserirCliente.Enabled = True
            BtnAlteraCliente.Enabled = True
            BtnexcluiCliente.Enabled = False
        End If
    End Sub

    Private Sub BtnexcluiCliente_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnexcluiCliente.Click
        sql = "Delete * From TB_Cliente"
        sql += " Where"
        sql += " Nome = '" & txtCliNome.Text & "'"
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
        BtnIserirCliente.Enabled = True
        BtnAlteraCliente.Enabled = True
    End Sub
End Class