Imports System.Timers

Module GestionnaireDePartie
    Dim NomJoueurActif As String

    Public Temps_Partie As Integer

    Public Sub LancerPartie(nomJ As String)
        Init_Temps()
        GrilleDeJeu.Label_Temps.Text = "Temps restant: " & Temps_Partie
        GrilleDeJeu.Show()
        NomJoueurActif = nomJ
        For Each element In GestionnaireDeDonnées.GetDonnées()
            If element.Nom = NomJoueurActif Then GetDonnées()(GetDonnées().IndexOf(element)).incPartie()
        Next
    End Sub

    Public Sub Init_Temps()
        Temps_Partie = 60
        GrilleDeJeu.Timer_Partie.Interval = 1000
        GrilleDeJeu.Timer_Partie.Start()
    End Sub

    Public Sub Fin_Partie(signal As Integer)
        If signal = 0 Then
            GrilleDeJeu.Timer_Partie.Stop()
            If Grille_Correct() Then
                MsgBox("Vous avez gagné la partie !", MsgBoxStyle.OkOnly, "Information")
            Else
                MsgBox("Vous avez perdu la partie..", MsgBoxStyle.OkOnly, "Information")
            End If
            GrilleDeJeu.Hide()
            GestionnaireDeDonnées.SauvegardeDonnées()
            Accueil.Show()
        End If

    End Sub

    Private Function Grille_Correct() As Boolean
        Return False
    End Function

End Module
