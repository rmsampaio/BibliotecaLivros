Public Class MenuIniciar
    Private Sub SobreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreToolStripMenuItem.Click
        End
    End Sub

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        MsgBox(" - Pesquisa Aplicada a Novas Metodologias Para Desenvolvimento de Sistema" & vbCrLf & " - Tecnologia em Análise e Desenvolvimento de Sistema" & vbCrLf & " - Tuarma: 5º A" & vbCrLf & " - Prof. Danielle" & vbCrLf & vbCrLf & " - Autores" & vbCrLf & vbCrLf & " - Rodrigo de Melo Samapio - RA: 909112127" & vbCrLf & " - Rogerio Daoglio do Rego - RA: 909107191" & vbCrLf & " - Rinalva Aparecida da Costa - RA: 909102595" & vbCrLf & " - Sheila Paula Fialho Araujo - RA: 909104558" & vbCrLf & " - Tatiane Biazi Sahd Couto - RA: 309102877" & vbCrLf & " - Everton Ikuno - RA: 910116816" & vbCrLf & " - Renan Cesar Falavinha - RA: 909102380" & vbCrLf & " - Erica de Melo Pereira - RA: 409103533")
    End Sub

    Private Sub CadastroDeFuncionárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroDeFuncionárioToolStripMenuItem.Click
        Dim CadFun As New CadFuncionario
        CadFun.Show()
        Me.Hide()
    End Sub

    Private Sub CadastroDeClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroDeClienteToolStripMenuItem.Click
        Dim CadCli As New CadCliente
        CadCli.Show()
        Me.Hide()
    End Sub

    Private Sub LocaçãoDeLivrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocaçãoDeLivrosToolStripMenuItem.Click
        Dim LocLiv As New CadLocacao
        LocLiv.Show()
        Me.Hide()
    End Sub

    Private Sub CadastrosDeLivrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrosDeLivrosToolStripMenuItem.Click
        Dim CadLivro As New CadLivro
        CadLivro.Show()
        Me.Hide()
    End Sub

    Private Sub CadastrosDeAreasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrosDeAreasToolStripMenuItem.Click
        Dim CadaArea As New CadaArea
        CadaArea.Show()
        Me.Hide()
    End Sub

    Private Sub StatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusToolStripMenuItem.Click
        Dim CadStatus As New CadStatus
        CadStatus.Show()
        Me.Hide()
    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoriaToolStripMenuItem.Click
        Dim CadCat As New CadCategoria
        CadCat.Show()
        Me.Hide()
    End Sub
    Private Sub LocalizaçãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalizaçãoToolStripMenuItem.Click
        Dim CadLocalizacao As New CadLocalozacao
        CadLocalizacao.Show()
        Me.Hide()
    End Sub
End Class