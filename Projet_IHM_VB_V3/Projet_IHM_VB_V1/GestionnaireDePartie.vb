Imports System.Timers

Module GestionnaireDePartie
    Public JoueurActif As Joueur
    Public Const TempsPartieHard = 60, CellsHard = 20, Hard = "Difficile"
    Public Const TempsPartieAverage = 120, CellsAverage = 35, Average = "Moyen"
    Public Const TempsPartieEasy = 500, CellsEasy = 50, Easy = "Facile"
    Dim TempsChoisi
    Public Temps_Partie As Integer

    Public Sub LancerPartie(nomJ As String, difficulté As String)
        TempsChoisi = If(difficulté = Hard, TempsPartieHard, If(difficulté = Average, TempsPartieAverage, TempsPartieEasy))
        Dim DifficultéCases As Integer = If(difficulté = Hard, CellsHard, If(difficulté = Average, CellsAverage, CellsEasy))
        Init_Temps(TempsChoisi)
        GrilleDeJeu.Label_Temps.Text = "Temps restant: " & Temps_Partie
        For Each element In GestionnaireDeDonnées.GetDonnées()
            If element.Nom = nomJ Then
                JoueurActif = element
                JoueurActif.incPartie()
            End If
        Next
        GrilleDeJeu.Show()
        GrilleDeJeu.ViderGrille()
        GrilleDeJeu.RemplirGrille(DifficultéCases)
    End Sub

    Public Sub Init_Temps(temps As Integer)
        Temps_Partie = temps
        GrilleDeJeu.Timer_Partie.Interval = 1000
        GrilleDeJeu.Timer_Partie.Start()
    End Sub

    Public Sub Fin_Partie(signal As Integer)
        If signal = 0 Or signal = -1 Then
            GrilleDeJeu.Timer_Partie.Stop()
            If Grille_Correct() AndAlso Not signal = -1 Then
                MsgBox("Vous avez gagné la partie !", MsgBoxStyle.OkOnly, "Information")
                GetJoueur(JoueurActif.Nom).MajMeilleurTemps(TempsChoisi - Temps_Partie)
            Else
                MsgBox("Vous avez perdu la partie..", MsgBoxStyle.OkOnly, "Information")
            End If
            GrilleDeJeu.Hide()
            GetJoueur(JoueurActif.Nom).AddTempsTotal(TempsChoisi - Temps_Partie)
            GestionnaireDeDonnées.SauvegardeDonnées()
            Accueil.Show()
        End If
    End Sub

    Public Function Grille_Correct() As Boolean
        For Each textBox In GrilleDeJeu.Grille
            Dim i As Integer = Integer.Parse(textBox.Name.ToCharArray()(7)),
            j As Integer = Integer.Parse(textBox.Name.ToCharArray()(8)),
            val As String = textBox.Text
            If Not (VerifColonne(i, j, val) AndAlso VerifLigne(i, j, val) AndAlso VerifSecteur(i, j, val)) Then
                Return False
            End If
        Next
        Return True
    End Function

    Public Function VerifColonne(i As Integer, j As Integer, val As String) As Boolean
        For ligne As Integer = 0 To GrilleDeJeu.Grille.Length / 9 - 1
            If ligne <> i AndAlso GrilleDeJeu.Grille(ligne, j).Text = val Then
                Return False
            End If
        Next
        Return True
    End Function

    Public Function VerifLigne(i As Integer, j As Integer, val As String) As Boolean
        For colonne As Integer = 0 To GrilleDeJeu.Grille.Length / 9 - 1
            If colonne <> j AndAlso GrilleDeJeu.Grille(i, colonne).Text = val Then
                Return False
            End If
        Next
        Return True
    End Function

    Public Function VerifSecteur(i As Integer, j As Integer, val As String) As Boolean
        Dim iDépart As Integer = If(i < 3, 0, If(i < 6, 3, 6)),
        jDépart As Integer = If(j < 3, 0, If(j < 6, 3, 6))
        For iD As Integer = iDépart To iDépart + 2
            For jD As Integer = jDépart To jDépart + 2
                If iD <> i AndAlso jD <> j AndAlso GrilleDeJeu.Grille(iD, jD).Text = val Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function

End Module
