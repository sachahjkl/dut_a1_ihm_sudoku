Imports System.Drawing.Text
Public Class Accueil

    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GestionnaireDeDonnées.ChargementDonnées()
        Dim PlayerData = GestionnaireDeDonnées.GetDonnées
        For Each element As String() In PlayerData
            Me.ComboBox_ChoixJoueur.Items.Add(element(0))
        Next
    End Sub

    Private Sub Button_Quitter_Click(sender As Object, e As EventArgs) Handles Button_Quitter.Click
        Dim res As Integer = MsgBox("Êtes-vous sûr de vouloir quitter ?", MsgBoxStyle.YesNo, "Quitter")
        If (res = MsgBoxResult.Yes) Then End


    End Sub



    Private Sub Button_LancerPartie_Click(sender As Object, e As EventArgs) Handles Button_LancerPartie.Click
        Me.Hide()
        GrilleDeJeu.Show()
    End Sub

    Private Sub Button_AjoutJoueur_Click(sender As Object, e As EventArgs) Handles Button_AjoutJoueur.Click
        Dim nomJoueur As String = Me.ComboBox_ChoixJoueur.Text
    End Sub
End Class
