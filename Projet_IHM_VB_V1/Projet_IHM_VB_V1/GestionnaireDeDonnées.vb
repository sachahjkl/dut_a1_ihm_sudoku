Imports System.IO
Imports System.Timers

Module GestionnaireDeDonnées
    Dim PlayerData As New ArrayList
    Public Sub ChargementDonnées()
        If Not System.IO.File.Exists("./Ressources/PlayerData/Players.txt") Then
            System.IO.File.Create("./Ressources/PlayerData/Players.txt")
        End If
        Dim PlayerData_File As New StreamReader("./Ressources/PlayerData/Players.txt")
        While Not PlayerData_File.EndOfStream
            Dim ligneSplit As String() = PlayerData_File.ReadLine.Split(" ")
            PlayerData.Add({ligneSplit(0), ligneSplit(1), ligneSplit(2), ligneSplit(3)})
        End While
    End Sub

    Public Function GetDonnées() As ArrayList
        Return PlayerData
    End Function
End Module
