Public Class Statistiques

    Private TriAZ = False
    Private Tri09 = True

    Private Sub Statistiques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.ResetDonnées()
        Me.Label_TitreStat.Font = New Font(Accueil.CustomFont.Families(0), 20, FontStyle.Regular)
        AddHandler ListBox_Joueurs.SelectedIndexChanged, AddressOf SynchroSelect
        AddHandler ListBox_MeilleursTemps.SelectedIndexChanged, AddressOf SynchroSelect
        AddHandler ComboBox_ChoixJoueur.SelectedIndexChanged, AddressOf SynchroSelect
        Me.ComboBox_ChoixJoueur.DropDownHeight = Me.ComboBox_ChoixJoueur.ItemHeight * 10
    End Sub

    Private Sub SynchroSelect(sender As Object, e As EventArgs)
        For Each element In Me.Controls
            If {GetType(ListBox), GetType(ComboBox)}.Contains(element.GetType) Then
                element.SelectedIndex() = sender.SelectedIndex()
            End If
        Next
        Me.ComboBox_ChoixJoueur.Text = ListBox_Joueurs.SelectedItem
    End Sub

    Public Sub ResetDonnées()
        TriAZ = False
        Tri09 = True
        ListBox_Joueurs.Items.Clear()
        ListBox_MeilleursTemps.Items.Clear()
        ComboBox_ChoixJoueur.Items.Clear()
        For Each element In GestionnaireDeDonnées.GetDonnées
            ListBox_Joueurs.Items.Add(element.Nom)
            ListBox_MeilleursTemps.Items.Add(element.MeilleurTemps)
            ComboBox_ChoixJoueur.Items.Add(element.Nom)
        Next
        Me.ListBox_Joueurs.SelectedIndex = Me.ListBox_MeilleursTemps.SelectedIndex =
        Me.ComboBox_ChoixJoueur.SelectedIndex = 0

    End Sub

    Private Sub Statistiques_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        GestionnaireDeDonnées.SauvegardeDonnées()
        End
    End Sub

    Private Sub Button_FullStats_Click(sender As Object, e As EventArgs) Handles Button_FullStats.Click
        Dim Stats As Joueur = GetJoueur(Me.ListBox_Joueurs.SelectedItem)
        Dim Temps_Total = Stats.TempsTotal \ 60 & "mn" & Stats.TempsTotal Mod 60 & "s"
        MsgBox("Nombre de parties: " & Stats.NbParties & vbCrLf & "Meilleur partie: " &
               Stats.MeilleurTemps & "s" & vbCrLf & "Temps total: " & Temps_Total, MsgBoxStyle.OkOnly,
               "Statistiques Complètes de " & Stats.Nom)
    End Sub

    Private Sub Button_RetourAccueil_Click(sender As Object, e As EventArgs) Handles Button_RetourAccueil.Click
        Me.Hide()
        Accueil.Show()
    End Sub

    Private Sub Centrer() Handles Me.VisibleChanged
        Me.CenterToScreen()
    End Sub

    Private Sub MajALAffichage() Handles Me.VisibleChanged
        Me.ResetDonnées()
    End Sub

    Private Sub Button_TriAlpha_Click(sender As Object, e As EventArgs) Handles Button_TriAlpha.Click
        Me.TriAZ = Not Me.TriAZ
        If Me.TriAZ Then
            For i As Integer = Me.ListBox_Joueurs.Items.Count - 1 To 1 Step -1
                For j As Integer = 0 To i - 1
                    If ListBox_Joueurs.Items(j) > ListBox_Joueurs.Items(j + 1) Then
                        Dim tempJ = ListBox_Joueurs.Items(j), tempMT = ListBox_MeilleursTemps.Items(j)
                        Dim CBboxJ = ComboBox_ChoixJoueur.Items(j)
                        ListBox_Joueurs.Items.RemoveAt(j)
                        ListBox_Joueurs.Items.Insert(j + 1, tempJ)
                        ListBox_MeilleursTemps.Items.RemoveAt(j)
                        ListBox_MeilleursTemps.Items.Insert(j + 1, tempMT)
                        ComboBox_ChoixJoueur.Items.RemoveAt(j)
                        ComboBox_ChoixJoueur.Items.Insert(j + 1, CBboxJ)
                    End If
                Next
            Next
        Else
            For i As Integer = Me.ListBox_Joueurs.Items.Count - 1 To 1 Step -1
                For j As Integer = 0 To i - 1
                    If ListBox_Joueurs.Items(j) < ListBox_Joueurs.Items(j + 1) Then
                        Dim tempJ = ListBox_Joueurs.Items(j), tempMT = ListBox_MeilleursTemps.Items(j)
                        Dim CBboxJ = ComboBox_ChoixJoueur.Items(j)
                        ListBox_Joueurs.Items.RemoveAt(j)
                        ListBox_Joueurs.Items.Insert(j + 1, tempJ)
                        ListBox_MeilleursTemps.Items.RemoveAt(j)
                        ListBox_MeilleursTemps.Items.Insert(j + 1, tempMT)
                        ComboBox_ChoixJoueur.Items.RemoveAt(j)
                        ComboBox_ChoixJoueur.Items.Insert(j + 1, CBboxJ)
                    End If
                Next
            Next
        End If


        Me.ComboBox_ChoixJoueur.SelectedIndex = 0
    End Sub

    Private Sub Button_TriScore_Click(sender As Object, e As EventArgs) Handles Button_TriScore.Click
        Me.Tri09 = Not Me.Tri09
        If Me.Tri09 Then
            For i As Integer = Me.ListBox_MeilleursTemps.Items.Count - 1 To 1 Step -1
                For j As Integer = 0 To i - 1
                    If ListBox_MeilleursTemps.Items(j) > ListBox_MeilleursTemps.Items(j + 1) Then
                        Dim tempJ = ListBox_Joueurs.Items(j), tempMT = ListBox_MeilleursTemps.Items(j)
                        Dim CBboxJ = ComboBox_ChoixJoueur.Items(j)
                        ListBox_Joueurs.Items.RemoveAt(j)
                        ListBox_Joueurs.Items.Insert(j + 1, tempJ)
                        ListBox_MeilleursTemps.Items.RemoveAt(j)
                        ListBox_MeilleursTemps.Items.Insert(j + 1, tempMT)
                        ComboBox_ChoixJoueur.Items.RemoveAt(j)
                        ComboBox_ChoixJoueur.Items.Insert(j + 1, CBboxJ)
                    End If
                Next
            Next
        Else
            For i As Integer = Me.ListBox_MeilleursTemps.Items.Count - 1 To 1 Step -1
                For j As Integer = 0 To i - 1
                    If ListBox_MeilleursTemps.Items(j) < ListBox_MeilleursTemps.Items(j + 1) Then
                        Dim tempJ = ListBox_Joueurs.Items(j), tempMT = ListBox_MeilleursTemps.Items(j)
                        Dim CBboxJ = ComboBox_ChoixJoueur.Items(j)
                        ListBox_Joueurs.Items.RemoveAt(j)
                        ListBox_Joueurs.Items.Insert(j + 1, tempJ)
                        ListBox_MeilleursTemps.Items.RemoveAt(j)
                        ListBox_MeilleursTemps.Items.Insert(j + 1, tempMT)
                        ComboBox_ChoixJoueur.Items.RemoveAt(j)
                        ComboBox_ChoixJoueur.Items.Insert(j + 1, CBboxJ)
                    End If
                Next
            Next
        End If

        Me.ComboBox_ChoixJoueur.SelectedIndex = 0
    End Sub

    Private Sub Button_AucunTri_Click(sender As Object, e As EventArgs) Handles Button_AucunTri.Click
        Me.ResetDonnées()
    End Sub
End Class