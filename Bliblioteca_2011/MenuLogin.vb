Public Class MenuLogin
    '1ª Dim - Definição dos comandos do banco de dados
    '2ª Dim - Conecta banco de dados
    '3ª Dim - Definição de variável (Tentativas)
    Dim VerificaComando1, VerificaComando2 As New OleDb.OleDbCommand()
    Dim auto As New OleDb.OleDbConnection()
    Dim tentativas As Integer
    ' testar qual forma conecta mais rápido. 
    Private Sub MenuLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        auto.ConnectionString = "provider=microsoft.jet.OLEDB.4.0;Data Source = |DataDirectory|\DB_Biblioteca_Pre_Aula_2011.mdb"
        'Comando de conexão 1º Dim Variavel VerificaComando1
        With VerificaComando1
            .Connection = auto
            .CommandType = CommandType.Text
            .CommandText = "Select * from TB_Funcionario Where Cpf=? and Senha=?"
        End With
        'Comando de conexão 1º Dim Variavel VerificaComando2
        With VerificaComando2
            .Connection = auto
            .CommandType = CommandType.Text
            .CommandText = "Select * from TB_Funcionario Where Cpf=? and Senha=?"
        End With
        txtUsuario.Focus() ' Manda cursor para campo usuário
    End Sub
    Private Sub VerificaLogin(ByVal read As OleDb.OleDbDataReader)
        With read
            If read.Read Then
                MessageBox.Show("Aceso Permitido ! Bem Vindo """ & txtUsuario.Text & """", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If cbLocal.SelectedIndex = 0 Then
                    Me.Hide()
                    Dim X As New MenuIniciar
                    X.Show()
                ElseIf cbLocal.SelectedIndex = 1 Then
                    Me.Hide()
                    Dim X As New MenuIniciar
                    X.Show()
                End If
            Else
                tentativas += 1
                If tentativas >= 3 Then
                    MessageBox.Show("Numero de tentativas foi excedido!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Fechar aplicativo
                    End
                Else
                    txtUsuario.Clear()
                    txtSenha.Clear()
                    MessageBox.Show("CPF ou Senha inválida !", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
            txtUsuario.Focus()
        End With
    End Sub

    Private Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim Read As OleDb.OleDbDataReader
        'Proteção se o textBox1 estiver em branco
        If txtUsuario.Text.Trim = "" Then
            MessageBox.Show("Informe seu CPF!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsuario.Focus()
            Exit Sub
        End If
        'Proteção se o textbox2 estiver em branco
        If txtSenha.Text.Trim = "" Then
            MessageBox.Show("Informe sua Senha !", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSenha.Focus()
            Exit Sub
        End If
        'Proteção se o ComboBox estiver em Branco
        If cbLocal.Text.Trim = "" Then
            MessageBox.Show(" Selecione o modo de Login: Matriz ou Filial !", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbLocal.Focus()
            Exit Sub
        End If
        'Logar Como Administrador
        If cbLocal.SelectedIndex = 0 Then
            With VerificaComando1
                .Parameters.Add("Cpf", Data.OleDb.OleDbType.Variant)
                .Parameters.Add("Senha", Data.OleDb.OleDbType.Variant)
                .Parameters("Cpf").Value = txtUsuario.Text
                .Parameters("Senha").Value = txtSenha.Text
                'Abrir conexões de dados
                auto.Open()
                'Leitura das informações do banco de dados
                Read = .ExecuteReader
                VerificaLogin(Read)
                Read.Close()
                'Fechar a conexão com banco de dados
                auto.Close()
            End With
        End If
        'Logar como Usuário
        If cbLocal.SelectedIndex = 1 Then
            With VerificaComando2
                .Parameters.Add("Cpf", Data.OleDb.OleDbType.Variant)
                .Parameters.Add("Senha", Data.OleDb.OleDbType.Variant)
                .Parameters("Cpf").Value = txtUsuario.Text
                .Parameters("Senha").Value = txtSenha.Text
                'Abrir conexões de dados
                auto.Open()
                'Leitura das informações do banco de dados
                Read = .ExecuteReader
                VerificaLogin(Read)
                Read.Close()
                'Fechar a conexão com banco de dados
                auto.Close()
            End With
        End If
    End Sub

    Private Sub btbCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btbCancel.Click
        ' Encerrar Programa
        End
    End Sub

    Private Sub txtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress
        'Aceitará somente numeros
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtSenha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSenha.KeyPress
        'Aceitará somente letras
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
