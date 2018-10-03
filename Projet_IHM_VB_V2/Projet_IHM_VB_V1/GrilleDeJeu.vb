Public Class GrilleDeJeu
    Const TAILLE_GRILLE = 9
    Const Marge = 20, BoxSpacing = 5, BoxDim = 50, TailleFenetreX = 518, TailleFenetreY = 578
    Public Timer_Partie As Timer = New Timer()
    Dim Grille

    Public Sub GrilleDeJeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label_Temps.Text = "Temps restant: " & GestionnaireDePartie.Temps_Partie
        AddHandler Timer_Partie.Tick, AddressOf MajTemps
        Me.CenterToScreen()
        Me.GénérerGrille(TAILLE_GRILLE, TAILLE_GRILLE)
        Me.Size = New Size(TailleFenetreX, TailleFenetreY)

    End Sub

    Private Sub GénérerGrille(iMax As Integer, jMax As Integer)
        Dim txtBox = New TextBox
        Dim TAB(iMax - 1, jMax - 1) As TextBox
        Grille = TAB
        Dim dX = 0, dY = 0
        For i = 0 To iMax - 1
            If i > 2 And i < 6 Then
                dY = BoxSpacing
            ElseIf i > 5 Then
                dY = BoxSpacing * 2
            End If
            For j = 0 To jMax - 1
                txtBox.Name = "txtBox_" & i & "_" & j
                If j > 2 And j < 6 Then
                    dX = BoxSpacing
                ElseIf j > 5 Then
                    dX = BoxSpacing * 2
                End If
                txtBox.Location = New Point((BoxDim * j) + dX + Marge, (BoxDim * i) + dY + Marge)
                txtBox.Multiline = True
                txtBox.Size = New Size(BoxDim, BoxDim)
                txtBox.Font = New Font("Microsoft Sans Serif", txtBox.Height / 1.7)
                txtBox.MaxLength = 1
                txtBox.TextAlign = HorizontalAlignment.Center
                Me.Controls.Add(txtBox)
                AddHandler txtBox.KeyPress, AddressOf CaractèreAutorisés
                Grille(i, j) = txtBox
                txtBox = New TextBox
            Next
            dX = 0
        Next
    End Sub

    Private Sub Button_RetourAccueil_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Accueil.Show()
    End Sub

    Public Sub MajTemps()
        GestionnaireDePartie.Temps_Partie -= 1
        Me.Label_Temps.Text = "Temps restant: " & GestionnaireDePartie.Temps_Partie
        GestionnaireDePartie.Fin_Partie(GestionnaireDePartie.Temps_Partie)
    End Sub

    Private Sub CaractèreAutorisés(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Or e.KeyChar = "0" Then
            e.Handled = True
        End If
    End Sub

    Private Sub GrilleDeJeu_Closed(sender As Object, e As EventArgs) Handles Me.Closing
        GestionnaireDeDonnées.SauvegardeDonnées()
        End
    End Sub

    Private Sub Button_Retour_Click(sender As Object, e As EventArgs) Handles Button_Retour.Click
        Timer_Partie.Stop()
        Dim res As Integer = MsgBox("Vous allez perdre votre partie. Êtes-vous sûrs?", MsgBoxStyle.YesNo, "Quitter")
        If (res = MsgBoxResult.Yes) Then
            Me.Hide()
            Accueil.Show()
            End
        End If
        Timer_Partie.Start()
    End Sub

    Private Sub Button_Valider_Click(sender As Object, e As EventArgs) Handles Button_Valider.Click

    End Sub
End Class