Public Class CadLocalozacao

    Private Sub TB_EstoqueBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_EstoqueBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TB_EstoqueBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_Biblioteca_Pre_Aula_2011DataSet)

    End Sub

    Private Sub CadLocalozacao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_Biblioteca_Pre_Aula_2011DataSet.TB_Estoque' table. You can move, or remove it, as needed.
        Me.TB_EstoqueTableAdapter.Fill(Me.DB_Biblioteca_Pre_Aula_2011DataSet.TB_Estoque)

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click
        Dim MenuInicio As New MenuIniciar
        MenuInicio.Show()
        Me.Hide()
    End Sub
End Class