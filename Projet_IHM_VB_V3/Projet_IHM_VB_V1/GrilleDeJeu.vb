Public Class GrilleDeJeu
    Const TAILLE_GRILLE = 9
    Const Marge = 20, BoxSpacing = 5, BoxDim = 50, TailleFenetreX = 518, TailleFenetreY = 578
    Public Timer_Partie As Timer = New Timer()
    Public Grille

    ' Au chargement, initialise les paramètres de bases du formulaires (compteur, textBox et En tête)
    Public Sub GrilleDeJeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Timer_Partie.Tick, AddressOf MajTemps
        Me.GénérerGrille()
        Me.MajVisible()
        Me.Size = New Size(TailleFenetreX, TailleFenetreY)

    End Sub

    'Vide toutes les TextBox de la grille et remet leur style par défaut
    Public Sub ViderGrille()
        For Each txtBox As TextBox In Grille
            txtBox.Text = ""
            txtBox.BackColor = Color.LightGray
            txtBox.ForeColor = Color.Black
            txtBox.Enabled = True
        Next
    End Sub

    'Remplis la grille avec des valeurs d'une grille valide selon la difficulté choisie, représentée par
    'nbCells, le nombre de cases préremplies
    Public Sub RemplirGrille(ByVal nbCells As Integer)
        Static Generator As System.Random = New System.Random()
        'Utilisation d'un code open source afin de générer des grilles correctes aléatoirement
        ' - Code provenant d'un projet de générateur de grille sudoku open source
        ' - Par : The ANZAC, 17 Feb 2009
        ' - lien : https://www.codeproject.com/Articles/23206/Sudoku-Algorithm-Generates-a-Valid-Sudoku-in
        SudoGen.GenerateGrid()
        Dim NbCasesRestantes = nbCells
        Dim i As Integer = 0, j As Integer = 0
        For Each s As SudoGen.Square In SudoGen.Sudoku
            If NbCasesRestantes = 0 Then Exit Sub
            Dim PlacerValeur As Boolean = Generator.Next(1, TAILLE_GRILLE * TAILLE_GRILLE + 1) <= nbCells
            If PlacerValeur Then
                NbCasesRestantes -= 1
                Grille(i, j).Text = s.Value
                Grille(i, j).Enabled = False
                Grille(i, j).BackColor = Color.Coral
                Grille(i, j).ForeColor = Color.White

            End If
            j += 1
            If j = 9 Then
                j = 0
                i += 1
            End If
        Next

    End Sub

    'instancie chaque textbox et leurs paramètres et les range dans une matrice 9x9 
    Private Sub GénérerGrille()
        Dim txtBox = New TextBox
        Dim TAB(TAILLE_GRILLE - 1, TAILLE_GRILLE - 1) As TextBox
        Grille = TAB
        Dim dX = 0, dY = 0
        For i = 0 To TAILLE_GRILLE - 1
            If i > 2 And i < 6 Then
                dY = BoxSpacing
            ElseIf i > 5 Then
                dY = BoxSpacing * 2
            End If
            For j = 0 To TAILLE_GRILLE - 1
                txtBox.Name = "txtBox_" & i & j 'txtBox.Name.ToCharArray()(7) = i txtBox.Name.ToCharArray()(8) = j
                If j > 2 And j < 6 Then
                    dX = BoxSpacing
                ElseIf j > 5 Then
                    dX = BoxSpacing * 2
                End If
                txtBox.Location = New Point((BoxDim * j) + dX + Marge, (BoxDim * i) + dY + Marge)
                txtBox.Multiline = True
                txtBox.Size = New Size(BoxDim, BoxDim)
                txtBox.Font = New Font("Trebuchet MS", txtBox.Height / 1.7)
                txtBox.MaxLength = 1
                txtBox.TextAlign = HorizontalAlignment.Center
                Me.Controls.Add(txtBox)
                AddHandler txtBox.KeyPress, AddressOf CaractèreAutorisés
                AddHandler txtBox.KeyDown, AddressOf PasDeDelete
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

    Private Sub PasDeDelete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub CaractèreAutorisés(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Const Arrêt_Validation = 0
        Dim i As Integer = Integer.Parse(sender.Name.ToCharArray()(7)),
            j As Integer = Integer.Parse(sender.Name.ToCharArray()(8))
        Dim toutRempli = True
        If e.KeyChar = vbBack Then
            sender.Text = ""
        ElseIf Not Char.IsDigit(e.KeyChar) Or e.KeyChar = "0" Then
            e.Handled = True
        Else
            sender.Text = e.KeyChar
        End If
        For di As Integer = 0 To TAILLE_GRILLE - 1
            For dj As Integer = 0 To TAILLE_GRILLE - 1
                Dim val As String = Grille(di, dj).Text
                If Grille(di, dj).Text = "" Then toutRempli = False
                If Grille(di, dj).Text = "" OrElse (Grille(di, dj).Enabled AndAlso VerifColonne(di, dj, val) AndAlso
                    VerifLigne(di, dj, val) AndAlso VerifSecteur(di, dj, val)) Then
                    Grille(di, dj).BackColor = Color.LightGray
                    Grille(di, dj).ForeColor = Color.Black
                ElseIf Grille(di, dj).Enabled Then
                    Grille(di, dj).BackColor = Color.IndianRed
                    Grille(di, dj).ForeColor = Color.White
                End If
            Next
        Next
        If toutRempli Then Fin_Partie(Arrêt_Validation)
    End Sub

    Private Sub MajVisible() Handles Me.VisibleChanged
        Me.Text = "Sudoku VB.NET: " & GestionnaireDePartie.JoueurActif.Nom & " à toi de jouer !"
        Me.CenterToScreen()
    End Sub

    Private Sub GrilleDeJeu_Closed(sender As Object, e As EventArgs) Handles Me.Closing
        Const Arrêt_Forcé = -1
        GestionnaireDeDonnées.SauvegardeDonnées()
        Fin_Partie(Arrêt_Forcé)
        End
    End Sub

    Private Sub Button_Retour_Click(sender As Object, e As EventArgs) Handles Button_Retour.Click
        Const Arrêt_Forcé = -1
        Timer_Partie.Stop()
        Dim res As Integer = MsgBox("Vous allez perdre votre partie. Êtes-vous sûrs?", MsgBoxStyle.YesNo, "Quitter")
        If (res = MsgBoxResult.Yes) Then
            Fin_Partie(Arrêt_Forcé)
            Exit Sub
        End If
        Timer_Partie.Start()
    End Sub

    Private Sub Button_Valider_Click(sender As Object, e As EventArgs) Handles Button_Valider.Click
        Const Arrêt_Validation = 0
        Timer_Partie.Stop()
        Dim res As Integer = MsgBox("Êtes-vous sûrs de vouloir valider votre partie", MsgBoxStyle.YesNo, "Terminer partie")
        If (res = MsgBoxResult.Yes) Then
            Fin_Partie(Arrêt_Validation)
            Exit Sub
        End If
        Timer_Partie.Start()

    End Sub
End Class