Public Class Statistiques


    Private Sub Statistiques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.ResetDonnées()
        AddHandler ListBox_Joueurs.SelectedIndexChanged, AddressOf SynchroSelect
        AddHandler ListBox_MeilleursTemps.SelectedIndexChanged, AddressOf SynchroSelect
    End Sub

    Private Sub SynchroSelect(sender As Object, e As EventArgs)
        For Each element In Me.Controls
            If element.GetType = GetType(ListBox) Then element.SelectedIndex() = sender.SelectedIndex()
        Next

    End Sub

    Public Sub ResetDonnées()
        ListBox_Joueurs.Items.Clear()
        ListBox_MeilleursTemps.Items.Clear()
        For Each element In GestionnaireDeDonnées.GetDonnées
            ListBox_Joueurs.Items.Add(element.Nom)
            ListBox_MeilleursTemps.Items.Add(element.MeilleurTemps)
        Next
        Me.ListBox_Joueurs.SelectedIndex = Me.ListBox_MeilleursTemps.SelectedIndex = 0
    End Sub

    Private Sub Statistiques_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        GestionnaireDeDonnées.SauvegardeDonnées()
        End
    End Sub

    Private Sub Button_FullStats_Click(sender As Object, e As EventArgs) Handles Button_FullStats.Click
        Dim Stats As New Joueur
        For Each element In GestionnaireDeDonnées.GetDonnées
            If element.Nom = Me.ListBox_Joueurs.SelectedItem Then Stats = element
        Next
        Dim Temps_Total = (Math.Truncate(Integer.Parse(Stats.TempsTotal) / 60)).ToString & "mn" & (Math.Truncate((Integer.Parse(Stats.TempsTotal) Mod 60))).ToString
        MsgBox("Nombre de parties: " & Stats.NbParties & " - Meilleur partie: " &
               Stats.MeilleurTemps & "s - Temps Total: " & Temps_Total, MsgBoxStyle.OkOnly,
               "Statistiques Complêtes de " & Stats.Nom)
    End Sub

    Private Sub Button_RetourAccueil_Click(sender As Object, e As EventArgs) Handles Button_RetourAccueil.Click
        Me.Hide()
        Accueil.Show()
    End Sub
End Class