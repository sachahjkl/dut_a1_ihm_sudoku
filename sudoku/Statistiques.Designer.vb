<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statistiques
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBox_Joueurs = New System.Windows.Forms.ListBox()
        Me.ListBox_MeilleursTemps = New System.Windows.Forms.ListBox()
        Me.Button_FullStats = New System.Windows.Forms.Button()
        Me.Button_RetourAccueil = New System.Windows.Forms.Button()
        Me.Label_TitreStat = New System.Windows.Forms.Label()
        Me.ComboBox_ChoixJoueur = New System.Windows.Forms.ComboBox()
        Me.Button_TriAlpha = New System.Windows.Forms.Button()
        Me.Button_TriScore = New System.Windows.Forms.Button()
        Me.Button_AucunTri = New System.Windows.Forms.Button()
        Me.Label_NomsJoueurs = New System.Windows.Forms.Label()
        Me.Label_MeilleurTemps = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox_Joueurs
        '
        Me.ListBox_Joueurs.FormattingEnabled = True
        Me.ListBox_Joueurs.Location = New System.Drawing.Point(13, 66)
        Me.ListBox_Joueurs.Name = "ListBox_Joueurs"
        Me.ListBox_Joueurs.Size = New System.Drawing.Size(194, 160)
        Me.ListBox_Joueurs.TabIndex = 0
        '
        'ListBox_MeilleursTemps
        '
        Me.ListBox_MeilleursTemps.FormattingEnabled = True
        Me.ListBox_MeilleursTemps.Location = New System.Drawing.Point(235, 66)
        Me.ListBox_MeilleursTemps.Name = "ListBox_MeilleursTemps"
        Me.ListBox_MeilleursTemps.Size = New System.Drawing.Size(194, 160)
        Me.ListBox_MeilleursTemps.TabIndex = 1
        '
        'Button_FullStats
        '
        Me.Button_FullStats.Location = New System.Drawing.Point(235, 274)
        Me.Button_FullStats.Name = "Button_FullStats"
        Me.Button_FullStats.Size = New System.Drawing.Size(125, 43)
        Me.Button_FullStats.TabIndex = 2
        Me.Button_FullStats.Text = "Afficher les statistiques complètes"
        Me.Button_FullStats.UseVisualStyleBackColor = True
        '
        'Button_RetourAccueil
        '
        Me.Button_RetourAccueil.Location = New System.Drawing.Point(82, 274)
        Me.Button_RetourAccueil.Name = "Button_RetourAccueil"
        Me.Button_RetourAccueil.Size = New System.Drawing.Size(125, 43)
        Me.Button_RetourAccueil.TabIndex = 3
        Me.Button_RetourAccueil.Text = "Retour à l'accueil"
        Me.Button_RetourAccueil.UseVisualStyleBackColor = True
        '
        'Label_TitreStat
        '
        Me.Label_TitreStat.AutoSize = True
        Me.Label_TitreStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TitreStat.Location = New System.Drawing.Point(105, 9)
        Me.Label_TitreStat.Name = "Label_TitreStat"
        Me.Label_TitreStat.Size = New System.Drawing.Size(266, 39)
        Me.Label_TitreStat.TabIndex = 4
        Me.Label_TitreStat.Text = "STATISTIQUES"
        '
        'ComboBox_ChoixJoueur
        '
        Me.ComboBox_ChoixJoueur.FormattingEnabled = True
        Me.ComboBox_ChoixJoueur.Location = New System.Drawing.Point(13, 232)
        Me.ComboBox_ChoixJoueur.MaxLength = 20
        Me.ComboBox_ChoixJoueur.Name = "ComboBox_ChoixJoueur"
        Me.ComboBox_ChoixJoueur.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_ChoixJoueur.TabIndex = 5
        '
        'Button_TriAlpha
        '
        Me.Button_TriAlpha.Location = New System.Drawing.Point(140, 230)
        Me.Button_TriAlpha.Name = "Button_TriAlpha"
        Me.Button_TriAlpha.Size = New System.Drawing.Size(67, 23)
        Me.Button_TriAlpha.TabIndex = 6
        Me.Button_TriAlpha.Text = "Tri A à Z"
        Me.Button_TriAlpha.UseVisualStyleBackColor = True
        '
        'Button_TriScore
        '
        Me.Button_TriScore.Location = New System.Drawing.Point(235, 232)
        Me.Button_TriScore.Name = "Button_TriScore"
        Me.Button_TriScore.Size = New System.Drawing.Size(100, 23)
        Me.Button_TriScore.TabIndex = 7
        Me.Button_TriScore.Text = "Tri meilleur score"
        Me.Button_TriScore.UseVisualStyleBackColor = True
        '
        'Button_AucunTri
        '
        Me.Button_AucunTri.Location = New System.Drawing.Point(341, 232)
        Me.Button_AucunTri.Name = "Button_AucunTri"
        Me.Button_AucunTri.Size = New System.Drawing.Size(88, 23)
        Me.Button_AucunTri.TabIndex = 8
        Me.Button_AucunTri.Text = "Ordre original"
        Me.Button_AucunTri.UseVisualStyleBackColor = True
        '
        'Label_NomsJoueurs
        '
        Me.Label_NomsJoueurs.AutoSize = True
        Me.Label_NomsJoueurs.Location = New System.Drawing.Point(12, 50)
        Me.Label_NomsJoueurs.Name = "Label_NomsJoueurs"
        Me.Label_NomsJoueurs.Size = New System.Drawing.Size(50, 13)
        Me.Label_NomsJoueurs.TabIndex = 9
        Me.Label_NomsJoueurs.Text = "Joueur(s)"
        '
        'Label_MeilleurTemps
        '
        Me.Label_MeilleurTemps.AutoSize = True
        Me.Label_MeilleurTemps.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label_MeilleurTemps.Location = New System.Drawing.Point(334, 50)
        Me.Label_MeilleurTemps.Name = "Label_MeilleurTemps"
        Me.Label_MeilleurTemps.Size = New System.Drawing.Size(95, 13)
        Me.Label_MeilleurTemps.TabIndex = 10
        Me.Label_MeilleurTemps.Text = "Meilleur(s) Temp(s)"
        Me.Label_MeilleurTemps.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Statistiques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 329)
        Me.Controls.Add(Me.Label_MeilleurTemps)
        Me.Controls.Add(Me.Label_NomsJoueurs)
        Me.Controls.Add(Me.Button_AucunTri)
        Me.Controls.Add(Me.Button_TriScore)
        Me.Controls.Add(Me.Button_TriAlpha)
        Me.Controls.Add(Me.ComboBox_ChoixJoueur)
        Me.Controls.Add(Me.Label_TitreStat)
        Me.Controls.Add(Me.Button_RetourAccueil)
        Me.Controls.Add(Me.Button_FullStats)
        Me.Controls.Add(Me.ListBox_MeilleursTemps)
        Me.Controls.Add(Me.ListBox_Joueurs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Statistiques"
        Me.Text = "Statistiques"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox_Joueurs As ListBox
    Friend WithEvents ListBox_MeilleursTemps As ListBox
    Friend WithEvents Button_FullStats As Button
    Friend WithEvents Button_RetourAccueil As Button
    Friend WithEvents Label_TitreStat As Label
    Friend WithEvents ComboBox_ChoixJoueur As ComboBox
    Friend WithEvents Button_TriAlpha As Button
    Friend WithEvents Button_TriScore As Button
    Friend WithEvents Button_AucunTri As Button
    Friend WithEvents Label_NomsJoueurs As Label
    Friend WithEvents Label_MeilleurTemps As Label
End Class
