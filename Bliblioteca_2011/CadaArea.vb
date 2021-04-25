Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class CadaArea
    Dim cOn As OleDbConnection
    Dim cOmad As OleDbCommand
    Dim dRed As OleDbDataReader
    Dim sql As String
    Dim dSet As DataSet
    Dim sTrconn = "provider=microsoft.Jet.OLEDB.4.0;Data Source = |DataDirectory|\DB_Biblioteca_Pre_Aula_2011.mdb"
    Dim eDitar, iNserir As Boolean
    Public Sub cOnectaDB(ByVal sql As String)
        Dim cOn As New OleDbConnection(sTrconn)
        cOn.Open()
        cOmad = New OleDbCommand(sql, cOn)
        cOmad.ExecuteNonQuery()
    End Sub
    Public Sub dEsconectDb()
        cOn.Close()
        cOn = Nothing 'Limpa área reservada para memória'
    End Sub
    Private Sub habilitaCampo(ByVal Habilita As Boolean)
        If Habilita = True Then
            lblArea.Enabled = True
            txtArea.Enabled = True
            cbAreaStatus.Enabled = True
            txtAreaInclusao.Enabled = True
            lblAreaAlteracao.Enabled = True
        Else
            lblArea.Enabled = False
            txtArea.Enabled = False
            cbAreaStatus.Enabled = False
            txtAreaInclusao.Enabled = False
            lblAreaAlteracao.Enabled = False
        End If
    End Sub
    Private Sub travaBotao()
        BtnIserirArea.Enabled = False
        BtnAlteraArea.Enabled = False
        BtnSalvaArea.Enabled = False
        BtnexcluiArea.Enabled = False
    End Sub
    Private Sub destravaBotao()
        BtnIserirArea.Enabled = True
        BtnAlteraArea.Enabled = True
        BtnSalvaArea.Enabled = True
        BtnexcluiArea.Enabled = True
    End Sub
    Private Sub LimpaCampos()
        lblArea.Text = ""
        txtArea.Text = ""
        cbAreaStatus.Text = ""
        txtAreaInclusao.Text = ""
        lblAreaAlteracao.Text = ""
    End Sub
    Private Sub Selecionar()
        Try
            lblArea.Text = dRed("id").ToString
            txtArea.Text = dRed("Area").ToString
            cbAreaStatus.Text = dRed("idStatus").ToString
            txtAreaInclusao.Text = dRed("dtInclusao").ToString
            lblAreaAlteracao.Text = dRed("dtAlteracao").ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CadaArea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_Biblioteca_Pre_Aula_2011DataSet.TB_Status' table. You can move, or remove it, as needed.
        Me.TB_StatusTableAdapter.Fill(Me.DB_Biblioteca_Pre_Aula_2011DataSet.TB_Status)
        habilitaCampo(False)
        travaBotao()
        BtnIserirArea.Enabled = True
        BtnAlteraArea.Enabled = True
    End Sub
    Private Sub BtnMenuIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMenuIniciar.Click
        Dim MenInicio As New MenuIniciar
        MenInicio.Show()
        Me.Hide()
    End Sub

    Private Sub BtnIserirArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIserirArea.Click
        habilitaCampo(True)
        LimpaCampos()
        txtArea.Focus()
        destravaBotao()
        iNserir = True
    End Sub

    Private Sub BtnSalvaArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalvaArea.Click
        If iNserir = True Then
            sql = "Insert into TB_Area (Area,idStatus,dtInclusao) Values ("
            sql += "'" & txtArea.Text & "'"
            sql += ",'" & cbAreaStatus.Text & "'"
            sql += ",'" & txtAreaInclusao.Text & "')"
            Try
                cOnectaDB(sql)
                MsgBox("Cadastro Efetuado com Sucesso")
            Catch ex As Exception
                cOn = Nothing
                MsgBox(Err.Description)
            End Try
            LimpaCampos()
            iNserir = False
            BtnSalvaArea.Enabled = False
            BtnIserirArea.Enabled = True
            BtnAlteraArea.Enabled = True
            BtnexcluiArea.Enabled = False
        Else
            sql = "Update Tb_Area Set "
            sql += "Area = '" & txtArea.Text & "',"
            sql += "idStatus = '" & cbAreaStatus.Text & "',"
            sql += "dtAlteracao = '" & DateTime.Now() & "'"
            sql += "Where id = " & lblArea.Text & ""
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
            BtnSalvaArea.Enabled = False
            BtnIserirArea.Enabled = True
            BtnAlteraArea.Enabled = True
            BtnexcluiArea.Enabled = False
        End If
    End Sub

    Private Sub BtnexcluiArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnexcluiArea.Click
        sql = "Delete * from TB_Area"
        sql += " Where"
        sql += " Area  = '" & txtArea.Text & "'"

        Try
            cOnectaDB(sql)
            MsgBox("Registro Apagado")
        Catch ex As Exception
            MsgBox(ex.Message) 'se houver erro mostra o qual em questão
            cOn = Nothing 'Desconecta do Banco de Dados
        End Try
        LimpaCampos() 'Deixa Todos os Campos em Branco
        travaBotao()
        habilitaCampo(False)
        BtnIserirArea.Enabled = True
        BtnAlteraArea.Enabled = True
    End Sub

    Private Sub BtnAlteraArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAlteraArea.Click
        Dim rEsposta As String
        rEsposta = ""
        While (rEsposta = "")
            rEsposta = InputBox("Digite qual Código Deseja Pesquisar", "Pesquisa no Banco de Dados")
            If rEsposta = "" Then
                MsgBox("Você Deverá Digitar Algum Código", MsgBoxStyle.Exclamation, "Erro")
            End If
        End While
        Try
            sql = " Select * from TB_Area "
            sql += "Where Area ='" & rEsposta & "'"
            Dim cOn As New OleDbConnection(sTrconn)
            cOn.Open()
            cOmad = New OleDbCommand(sql, cOn)
            dRed = cOmad.ExecuteReader
            If dRed.Read Then
                Selecionar()
                habilitaCampo(True)
                BtnSalvaArea.Enabled = True
                destravaBotao()
                BtnSalvaArea.Enabled = True
            Else
                MsgBox("Não Foi Encontrado Nenhum Registro com esse Nome", MsgBoxStyle.Exclamation, "Erro - Vazio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cOn = Nothing
    End Sub

End Class