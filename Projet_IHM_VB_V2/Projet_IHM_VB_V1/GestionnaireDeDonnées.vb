Imports System.IO

Module GestionnaireDeDonnées

    Structure Joueur
        Public Sub New(ByVal Nom As String, ByVal NP As Integer, ByVal MT As Integer, ByVal TT As Integer)
            Me.Nom = Nom
            Me.NbParties = NP
            Me.MeilleurTemps = MT
            Me.TempsTotal = TT
        End Sub

        Public Function GetVals() As String()
            Return {Me.Nom, Me.NbParties, Me.MeilleurTemps, Me.TempsTotal}
        End Function

        Public Sub incPartie()
            Me.NbParties += 1
        End Sub

        Dim Nom As String
        Dim NbParties, MeilleurTemps, TempsTotal
    End Structure


    Dim PlayerData As New ArrayList

    Public Sub ChargementDonnées()
        If Not System.IO.File.Exists("./Ressources/PlayerData/Players.txt") Then
            System.IO.File.Create("./Ressources/PlayerData/Players.txt")
        End If
        Using PlayerData_File As New StreamReader("./Ressources/PlayerData/Players.txt")
            While Not PlayerData_File.EndOfStream
                Dim ligneSplit As String() = PlayerData_File.ReadLine.Split(" ")
                PlayerData.Add(New Joueur(ligneSplit(0), ligneSplit(1), ligneSplit(2), ligneSplit(3)))
            End While
        End Using
    End Sub

    Public Sub SauvegardeDonnées()
        If Not System.IO.File.Exists("./Ressources/PlayerData/Players.txt") Then
            System.IO.File.Create("./Ressources/PlayerData/Players.txt")
        End If
        Using PlayerData_File As New StreamWriter("./Ressources/PlayerData/Players.txt")
            For Each element As Joueur In PlayerData
                PlayerData_File.WriteLine(Join(element.GetVals, " "))
            Next
        End Using
    End Sub

    Public Sub AjouterJoueur(nom As String)
        PlayerData.Add(New Joueur(nom, 0, 0, 0))
    End Sub

    Public Function GetDonnées() As ArrayList
        Return PlayerData
    End Function
End Module
