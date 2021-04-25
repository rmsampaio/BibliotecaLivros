Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class CadCategoria
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
            LblCategoria.Enabled = True
            txtCategoria.Enabled = True
            txtCatdtinclusao.Enabled = True
            lblCatAlteracao.Enabled = True
        Else
            LblCategoria.Enabled = False
            txtCategoria.Enabled = False
            txtCatdtinclusao.Enabled = False
            lblCatAlteracao.Enabled = False
        End If
    End Sub
    Private Sub travaBotao()
        BtnIserirCat.Enabled = False
        BtnAlteraCat.Enabled = False
        BtnSalvaCat.Enabled = False
        BtnexcluiCat.Enabled = False
    End Sub
    Private Sub destravaBotao()
        BtnIserirCat.Enabled = True
        BtnAlteraCat.Enabled = True
        BtnSalvaCat.Enabled = True
        BtnexcluiCat.Enabled = True
    End Sub
    Private Sub LimpaCampos()
        LblCategoria.Text = ""
        txtCategoria.Text = ""
        txtCatdtinclusao.Text = ""
        lblCatAlteracao.Text = ""
    End Sub
    Private Sub Selecionar()
        Try
            LblCategoria.Text = dRed("id").ToString
            txtCategoria.Text = dRed("Categoria").ToString
            txtCatdtinclusao.Text = dRed("dtInclusao").ToString
            lblCatAlteracao.Text = dRed("dtAlteracao").ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CadCategoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        habilitaCampo(False)
        travaBotao()
        BtnIserirCat.Enabled = True
        BtnAlteraCat.Enabled = True
    End Sub
    Private Sub BtnEditora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMenuIniciar.Click
        Dim MenInicio As New MenuIniciar
        MenInicio.Show()
        Me.Hide()
    End Sub

    Private Sub BtnIserirCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIserirCat.Click
        habilitaCampo(True)
        LimpaCampos()
        txtCategoria.Focus()
        destravaBotao()
        iNserir = True
    End Sub

    Private Sub BtnSalvaCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalvaCat.Click
        If iNserir = True Then
            sql = "Insert Into TB_Categoria (Categoria,dtInclusao) Values ("
            sql += "'" & txtCategoria.Text & "'"
            sql += ",'" & txtCatdtinclusao.Text & "')"
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
            BtnSalvaCat.Enabled = False
            BtnIserirCat.Enabled = True
            BtnAlteraCat.Enabled = True
            BtnexcluiCat.Enabled = False
        Else
            sql = "Update Tb_Categoria Set "
            sql += "Categoria = '" & txtCategoria.Text & "',"
            sql += "dtAlteracao = '" & DateTime.Now() & "'"
            sql += "Where id = " & LblCategoria.Text & ""
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
            BtnSalvaCat.Enabled = False
            BtnIserirCat.Enabled = True
            BtnAlteraCat.Enabled = True
            BtnexcluiCat.Enabled = False
        End If
    End Sub

    Private Sub BtnexcluiCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnexcluiCat.Click
        sql = "Delete * From TB_Categoria"
        sql += " Where"
        sql += " Categoria = '" & txtCategoria.Text & "'"
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
        BtnIserirCat.Enabled = True
        BtnAlteraCat.Enabled = True
    End Sub

    Private Sub BtnAlteraCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAlteraCat.Click
        Dim rEsposta As String
        rEsposta = ""
        While (rEsposta = "")
            rEsposta = InputBox("Digite qual Categoria Deseja Pesquisar", "Pesqiosa no Banco de Dados")
            If rEsposta = "" Then
                MsgBox("Você Deverá Digitar Alguma Categoria", MsgBoxStyle.Exclamation, "Erro")
            End If
        End While
        Try
            sql = "Select * from TB_Categoria "
            sql += "Where Categoria ='" & rEsposta & "'"
            Dim cOn As New OleDbConnection(sTrconn)
            cOn.Open()
            cOmad = New OleDbCommand(sql, cOn)
            dRed = cOmad.ExecuteReader
            If dRed.Read Then
                Selecionar()
                habilitaCampo(True)
                BtnSalvaCat.Enabled = True
                destravaBotao()
                BtnSalvaCat.Enabled = True
            Else
                MsgBox("Não foi Encontrado Nenhum Registro com este Nome", MsgBoxStyle.Exclamation, " Erro - Vazio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cOn = Nothing
    End Sub
End Class