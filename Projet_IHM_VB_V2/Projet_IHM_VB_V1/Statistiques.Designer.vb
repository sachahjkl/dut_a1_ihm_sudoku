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
        Me.SuspendLayout()
        '
        'ListBox_Joueurs
        '
        Me.ListBox_Joueurs.FormattingEnabled = True
        Me.ListBox_Joueurs.Location = New System.Drawing.Point(13, 40)
        Me.ListBox_Joueurs.Name = "ListBox_Joueurs"
        Me.ListBox_Joueurs.Size = New System.Drawing.Size(194, 225)
        Me.ListBox_Joueurs.TabIndex = 0
        '
        'ListBox_MeilleursTemps
        '
        Me.ListBox_MeilleursTemps.FormattingEnabled = True
        Me.ListBox_MeilleursTemps.Location = New System.Drawing.Point(235, 40)
        Me.ListBox_MeilleursTemps.Name = "ListBox_MeilleursTemps"
        Me.ListBox_MeilleursTemps.Size = New System.Drawing.Size(194, 225)
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
        'Statistiques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 329)
        Me.Controls.Add(Me.Button_RetourAccueil)
        Me.Controls.Add(Me.Button_FullStats)
        Me.Controls.Add(Me.ListBox_MeilleursTemps)
        Me.Controls.Add(Me.ListBox_Joueurs)
        Me.Name = "Statistiques"
        Me.Text = "Statistiques"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox_Joueurs As ListBox
    Friend WithEvents ListBox_MeilleursTemps As ListBox
    Friend WithEvents Button_FullStats As Button
    Friend WithEvents Button_RetourAccueil As Button
End Class
