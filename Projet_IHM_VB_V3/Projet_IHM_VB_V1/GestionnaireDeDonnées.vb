Imports System.IO

Module GestionnaireDeDonnées

    Public Class Joueur
        Public Sub New(ByVal Nom As String, ByVal NP As Integer, ByVal MT As Integer, ByVal TT As Integer)
            Me.Nom = Nom
            Me.NbParties = NP
            Me.MeilleurTemps = MT
            Me.TempsTotal = TT
        End Sub

        Public Function GetVals() As String()
            Return {Me.Nom, Me.NbParties, Me.MeilleurTemps, Me.TempsTotal}
        End Function

        Public Sub AddTempsTotal(temps As Integer)
            Me.TempsTotal += temps
        End Sub

        Public Sub MajMeilleurTemps(temps As Integer)
            If Me.MeilleurTemps > temps Or MeilleurTemps = 0 Then Me.MeilleurTemps = temps
        End Sub

        Public Sub incPartie()
            Me.NbParties += 1
        End Sub

        Public Nom As String
        Public NbParties, MeilleurTemps, TempsTotal As Integer
    End Class

    Const MAX_JOUEURS = 30
    Dim PlayerData As New ArrayList


    Public Sub ChargementDonnées()
        If Not File.Exists("./Ressources/PlayerData/Players.txt") Then
            Using create As New StreamWriter("./Ressources/PlayerData/Players.txt", True)
                create.Write("")
            End Using
        End If
        Using PlayerData_File As New StreamReader("./Ressources/PlayerData/Players.txt")
            While Not PlayerData_File.EndOfStream
                Dim ligne As String = PlayerData_File.ReadLine
                If Not ligne.Contains("  ") And Not ligne.Length = 0 Then
                    Dim ligneSplit As String() = ligne.Split(" ")
                    If ligneSplit.Length = 4 AndAlso (IsNumeric(ligneSplit(1)) AndAlso IsNumeric(ligneSplit(2)) AndAlso IsNumeric(ligneSplit(3))) Then
                        PlayerData.Add(New Joueur(ligneSplit(0), ligneSplit(1), ligneSplit(2), ligneSplit(3)))
                    End If
                End If
            End While
        End Using
        If PlayerData.Count = 0 Then PlayerData.Add(New Joueur("Invité", 0, 0, 0))
        If Not PlayerData(0).Nom = "Invité" Then PlayerData.Insert(0, (New Joueur("Invité", 0, 0, 0)))
    End Sub

    Public Sub SauvegardeDonnées()
        Dim PlayerData_File = System.IO.File.CreateText("./Ressources/PlayerData/Players.txt")
        Using PlayerData_File
            For Each element As Joueur In PlayerData
                PlayerData_File.WriteLine(Join(element.GetVals, " "))
            Next
        End Using
    End Sub

    Public Sub AjouterJoueur(nom As String)
        PlayerData.Add(New Joueur(nom, 0, 0, 0))
    End Sub

    Public Sub SupprimerJoueur(nom As String)
        For Each p As Joueur In PlayerData
            If nom = p.Nom AndAlso Not nom = PlayerData(0).Nom Then
                PlayerData.Remove(p)
                Exit Sub
            End If
        Next
    End Sub

    Public Function GetDonnées() As ArrayList
        Return PlayerData
    End Function

    Public Function MaxJoueurAtteint() As Boolean
        Return PlayerData.Count >= MAX_JOUEURS
    End Function

    Public Function GetJoueur(nom As String) As Joueur
        For Each e In PlayerData
            If e.Nom = nom Then Return PlayerData(PlayerData.IndexOf(e))
        Next
        Return Nothing
    End Function
End Module
