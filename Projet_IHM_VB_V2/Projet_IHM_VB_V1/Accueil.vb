Imports System.ComponentModel
Imports System.Drawing.Text
Public Class Accueil

    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        GestionnaireDeDonnées.ChargementDonnées()
        Me.Update_CBBox_NomsJoueurs()
    End Sub

    Private Sub Button_Quitter_Click(sender As Object, e As EventArgs) Handles Button_Quitter.Click
        Dim res As Integer = MsgBox("Êtes-vous sûr de vouloir quitter ?", MsgBoxStyle.YesNo, "Quitter")
        If (res = MsgBoxResult.Yes) Then
            GestionnaireDeDonnées.SauvegardeDonnées()
            End
        End If
    End Sub

    Private Sub Button_LancerPartie_Click(sender As Object, e As EventArgs) Handles Button_LancerPartie.Click
        If Not Me.ComboBox_ChoixJoueur.Items.Contains(Me.ComboBox_ChoixJoueur.Text) Then
            MsgBox("Vous devez choisir un joueur pour lancer une partie", MsgBoxStyle.OkOnly, "Avertissement")
            Exit Sub
        End If
        Me.Hide()
        GestionnaireDePartie.LancerPartie(Me.ComboBox_ChoixJoueur.Text)
    End Sub

    Private Sub Button_AjoutJoueur_Click(sender As Object, e As EventArgs) Handles Button_AjoutJoueur.Click
        Dim nomjoueur As String = Me.ComboBox_ChoixJoueur.Text
        If Me.ComboBox_ChoixJoueur.Items.Contains(Me.ComboBox_ChoixJoueur.Text) Then
            MsgBox("Joueur déjà existant", MsgBoxStyle.OkOnly, "avertissement")
            Exit Sub
        ElseIf Me.ComboBox_ChoixJoueur.Text.Contains(" ") Then
            MsgBox("Nom de joueur incorrect", MsgBoxStyle.OkOnly, "avertissement")
            Exit Sub
        End If
        GestionnaireDeDonnées.AjouterJoueur(nomjoueur)
        Me.Update_CBBox_NomsJoueurs()
    End Sub

    Private Sub Update_CBBox_NomsJoueurs()
        Dim PlayerData = GestionnaireDeDonnées.GetDonnées
        Me.ComboBox_ChoixJoueur.Items.Clear()
        For Each element As Joueur In PlayerData
            Me.ComboBox_ChoixJoueur.Items.Add(element.Nom)
        Next
    End Sub

    Private Sub Accueil_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        GestionnaireDeDonnées.SauvegardeDonnées()
        End
    End Sub

    Private Sub Button_StatistiquesJoueur_Click(sender As Object, e As EventArgs) Handles Button_StatistiquesJoueur.Click
        Me.Hide()
        Statistiques.ResetDonnées()
        Statistiques.Show()
    End Sub
End Class
