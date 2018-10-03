<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accueil))
        Me.Button_Quitter = New System.Windows.Forms.Button()
        Me.Button_LancerPartie = New System.Windows.Forms.Button()
        Me.ComboBox_ChoixJoueur = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label_ChoixJoueur = New System.Windows.Forms.Label()
        Me.Button_StatistiquesJoueur = New System.Windows.Forms.Button()
        Me.Button_AjoutJoueur = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Quitter
        '
        Me.Button_Quitter.Location = New System.Drawing.Point(87, 233)
        Me.Button_Quitter.Name = "Button_Quitter"
        Me.Button_Quitter.Size = New System.Drawing.Size(134, 23)
        Me.Button_Quitter.TabIndex = 0
        Me.Button_Quitter.Text = "Quitter"
        Me.Button_Quitter.UseVisualStyleBackColor = True
        '
        'Button_LancerPartie
        '
        Me.Button_LancerPartie.Location = New System.Drawing.Point(259, 233)
        Me.Button_LancerPartie.Name = "Button_LancerPartie"
        Me.Button_LancerPartie.Size = New System.Drawing.Size(134, 23)
        Me.Button_LancerPartie.TabIndex = 1
        Me.Button_LancerPartie.Text = "Lancer une partie"
        Me.Button_LancerPartie.UseVisualStyleBackColor = True
        '
        'ComboBox_ChoixJoueur
        '
        Me.ComboBox_ChoixJoueur.FormattingEnabled = True
        Me.ComboBox_ChoixJoueur.Location = New System.Drawing.Point(223, 112)
        Me.ComboBox_ChoixJoueur.Name = "ComboBox_ChoixJoueur"
        Me.ComboBox_ChoixJoueur.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_ChoixJoueur.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projet_IHM_VB_V1.My.Resources.Resources.Sudoku_Title
        Me.PictureBox1.Location = New System.Drawing.Point(114, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(243, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label_ChoixJoueur
        '
        Me.Label_ChoixJoueur.AutoSize = True
        Me.Label_ChoixJoueur.Location = New System.Drawing.Point(137, 115)
        Me.Label_ChoixJoueur.Name = "Label_ChoixJoueur"
        Me.Label_ChoixJoueur.Size = New System.Drawing.Size(80, 13)
        Me.Label_ChoixJoueur.TabIndex = 4
        Me.Label_ChoixJoueur.Text = "Choix du joueur"
        '
        'Button_StatistiquesJoueur
        '
        Me.Button_StatistiquesJoueur.Location = New System.Drawing.Point(259, 170)
        Me.Button_StatistiquesJoueur.Name = "Button_StatistiquesJoueur"
        Me.Button_StatistiquesJoueur.Size = New System.Drawing.Size(134, 23)
        Me.Button_StatistiquesJoueur.TabIndex = 5
        Me.Button_StatistiquesJoueur.Text = "Statistiques du joueur"
        Me.Button_StatistiquesJoueur.UseVisualStyleBackColor = True
        '
        'Button_AjoutJoueur
        '
        Me.Button_AjoutJoueur.Location = New System.Drawing.Point(87, 170)
        Me.Button_AjoutJoueur.Name = "Button_AjoutJoueur"
        Me.Button_AjoutJoueur.Size = New System.Drawing.Size(134, 23)
        Me.Button_AjoutJoueur.TabIndex = 6
        Me.Button_AjoutJoueur.Text = "Ajouter un joueur"
        Me.Button_AjoutJoueur.UseVisualStyleBackColor = True
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 268)
        Me.Controls.Add(Me.Button_AjoutJoueur)
        Me.Controls.Add(Me.Button_StatistiquesJoueur)
        Me.Controls.Add(Me.Label_ChoixJoueur)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ComboBox_ChoixJoueur)
        Me.Controls.Add(Me.Button_LancerPartie)
        Me.Controls.Add(Me.Button_Quitter)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Accueil"
        Me.Text = "Sudoku VB.NET: Accueil"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Quitter As Button
    Friend WithEvents Button_LancerPartie As Button
    Friend WithEvents ComboBox_ChoixJoueur As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label_ChoixJoueur As Label
    Friend WithEvents Button_StatistiquesJoueur As Button
    Friend WithEvents Button_AjoutJoueur As Button
End Class
