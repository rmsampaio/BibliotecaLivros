Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class CadStatus
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
            lblIdStatus.Enabled = True
            txtStatus.Enabled = True
            txtdtStatus.Enabled = True
            lblAltStatus.Enabled = True
        Else
            lblIdStatus.Enabled = False
            txtStatus.Enabled = False
            txtdtStatus.Enabled = False
            lblAltStatus.Enabled = False
        End If
    End Sub
    Private Sub travaBotao()
        BtnIserirStatus.Enabled = False
        BtnAlteraStatus.Enabled = False
        BtnSalvaStatus.Enabled = False
        BtnexcluiStatus.Enabled = False
    End Sub
    Private Sub destravaBotao()
        BtnIserirStatus.Enabled = True
        BtnAlteraStatus.Enabled = True
        BtnSalvaStatus.Enabled = True
        BtnexcluiStatus.Enabled = True
    End Sub
    Private Sub LimpaCampos()
        lblIdStatus.Text = ""
        txtStatus.Text = ""
        txtdtStatus.Text = ""
        lblAltStatus.Text = ""
    End Sub
    Private Sub Selecionar()
        Try
            lblIdStatus.Text = dRed("id").ToString
            txtStatus.Text = dRed("Status").ToString
            txtdtStatus.Text = dRed("dtInclusao").ToString
            lblAltStatus.Text = dRed("dtAlteracao").ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CadStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        habilitaCampo(False)
        travaBotao()
        BtnIserirStatus.Enabled = True
        BtnAlteraStatus.Enabled = True
    End Sub
    Private Sub BtnEditora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditora.Click
        Dim MenInicio As New MenuIniciar
        MenInicio.Show()
        Me.Hide()
    End Sub

  
    Private Sub BtnIserirStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIserirStatus.Click
        habilitaCampo(True)
        LimpaCampos()
        txtStatus.Focus()
        destravaBotao()
        iNserir = True
    End Sub

    Private Sub BtnAlteraStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAlteraStatus.Click
        Dim rEsposta As String
        rEsposta = ""
        While (rEsposta = "")
            rEsposta = InputBox("Digite qual Nome Deseja Pesquisar", "Pesquiosa no Banco de Dados")
            If rEsposta = "" Then
                MsgBox("Você Deverá Digitar Algum Nome", MsgBoxStyle.Exclamation, "Erro")
            End If
        End While
        Try
            sql = "Select * from TB_Status "
            sql += "Where Status ='" & rEsposta & "'"
            Dim cOn As New OleDbConnection(sTrconn)
            cOn.Open()
            cOmad = New OleDbCommand(sql, cOn)
            dRed = cOmad.ExecuteReader
            If dRed.Read Then
                Selecionar()
                habilitaCampo(True)
                BtnSalvaStatus.Enabled = True
                destravaBotao()
                BtnSalvaStatus.Enabled = True
            Else
                MsgBox("Não foi Encontrado Nenhum Registro com este Nome", MsgBoxStyle.Exclamation, " Erro - Vazio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cOn = Nothing
    End Sub

    Private Sub BtnSalvaStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalvaStatus.Click
        If iNserir = True Then
            sql = "Insert Into TB_Status (Status,dtInclusao) Values ("
            sql += "'" & txtStatus.Text & "'"
            sql += ",'" & txtdtStatus.Text & "')"
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
            BtnSalvaStatus.Enabled = False
            BtnIserirStatus.Enabled = True
            BtnAlteraStatus.Enabled = True
            BtnexcluiStatus.Enabled = False
        Else
            sql = "Update Tb_Status Set "
            sql += "Status = '" & txtStatus.Text & "',"
            sql += "dtAlteracao = '" & DateTime.Now() & "'"
            sql += "Where id = " & lblIdStatus.Text & ""
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
            BtnSalvaStatus.Enabled = False
            BtnIserirStatus.Enabled = True
            BtnAlteraStatus.Enabled = True
            BtnexcluiStatus.Enabled = False
        End If
    End Sub

    Private Sub BtnexcluiStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnexcluiStatus.Click
        sql = "Delete * From TB_Status"
        sql += " Where"
        sql += " Status = '" & txtStatus.Text & "'"
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
        BtnIserirStatus.Enabled = True
        BtnAlteraStatus.Enabled = True
    End Sub
End Class