Imports System.ComponentModel
Imports System.Drawing.Text
Public Class Accueil
    Public CustomFont As New PrivateFontCollection()
    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GestionnaireDeDonnées.ChargementDonnées()
        Me.Update_CBBox_NomsJoueurs()
        Me.ComboBox_ChoixDifficulté.Items.AddRange({Hard, Average, Easy})
        Me.Ranger()
        Me.ComboBox_ChoixJoueur.DropDownHeight = Me.ComboBox_ChoixJoueur.ItemHeight * 10
        CustomFont.AddFontFile("./Ressources/moon_get-Heavy.ttf")
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
        If Not Me.ComboBox_ChoixDifficulté.Items.Contains(Me.ComboBox_ChoixDifficulté.Text) Then
            MsgBox("Vous devez choisir une difficulté pour lancer une partie", MsgBoxStyle.OkOnly, "Avertissement")
            Exit Sub
        End If
        GestionnaireDePartie.LancerPartie(Me.ComboBox_ChoixJoueur.Text, Me.ComboBox_ChoixDifficulté.Text)
        Me.Hide()
    End Sub

    Private Sub Button_AjoutJoueur_Click(sender As Object, e As EventArgs) Handles Button_AjoutJoueur.Click
        Dim nomJoueur As String = Me.ComboBox_ChoixJoueur.Text
        If Me.ComboBox_ChoixJoueur.Items.Contains(Me.ComboBox_ChoixJoueur.Text) Then
            MsgBox("Joueur déjà existant", MsgBoxStyle.OkOnly, "avertissement")
            Exit Sub
        ElseIf Me.ComboBox_ChoixJoueur.Text.Contains(" ") Then
            MsgBox("Nom de joueur incorrect", MsgBoxStyle.OkOnly, "avertissement")
            Exit Sub
        ElseIf GestionnaireDeDonnées.MaxJoueurAtteint Then
            MsgBox("Nombre de joueurs maximal atteint (100)", MsgBoxStyle.OkOnly, "Avertissement")
            Exit Sub
        End If
        GestionnaireDeDonnées.AjouterJoueur(nomJoueur)
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
        Statistiques.Show()
    End Sub

    Private Sub Ranger() Handles Me.VisibleChanged
        Me.CenterToScreen()
        Me.ComboBox_ChoixJoueur.SelectedIndex = Me.ComboBox_ChoixDifficulté.SelectedIndex = 0
        Me.ComboBox_ChoixDifficulté.Text = Me.ComboBox_ChoixDifficulté.Items(0)
        Me.ComboBox_ChoixJoueur.Text = Me.ComboBox_ChoixJoueur.Items(0)
    End Sub

    Private Sub ComboBox_ChoixJoueur_SelectedIndexChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox_ChoixJoueur.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Me.Button_AjoutJoueur.PerformClick()
        End If
    End Sub

    Private Sub Button_SuppressionJoueur_Click(sender As Object, e As EventArgs) Handles Button_SuppressionJoueur.Click
        Dim Nom_Supr = Me.ComboBox_ChoixJoueur.Text
        If Nom_Supr = GetDonnées(0).Nom Then
            MsgBox("Vous ne pouvez pas supprimer l'invité", MsgBoxStyle.OkOnly, "Avertissement")
            Exit Sub
        End If
        Dim res As Integer = MsgBox("Êtes-vous sûr de vouloir supprimer le joueur " &
           Nom_Supr & " ?", MsgBoxStyle.YesNo, "Avertissement")
        If (res = MsgBoxResult.Yes) Then
            GestionnaireDeDonnées.SupprimerJoueur(Nom_Supr)
            Me.Update_CBBox_NomsJoueurs()
            Me.ComboBox_ChoixJoueur.SelectedIndex = 0
        End If
    End Sub
End Class
