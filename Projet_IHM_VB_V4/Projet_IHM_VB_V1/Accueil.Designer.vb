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
        Me.Button_SuppressionJoueur = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ComboBox_ChoixDifficulté = New System.Windows.Forms.ComboBox()
        Me.Label_Difficulté = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Quitter
        '
        Me.Button_Quitter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Quitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Quitter.Location = New System.Drawing.Point(173, 233)
        Me.Button_Quitter.Name = "Button_Quitter"
        Me.Button_Quitter.Size = New System.Drawing.Size(134, 23)
        Me.Button_Quitter.TabIndex = 4
        Me.Button_Quitter.Text = "Quitter"
        Me.Button_Quitter.UseVisualStyleBackColor = True
        '
        'Button_LancerPartie
        '
        Me.Button_LancerPartie.Location = New System.Drawing.Point(29, 68)
        Me.Button_LancerPartie.Name = "Button_LancerPartie"
        Me.Button_LancerPartie.Size = New System.Drawing.Size(160, 23)
        Me.Button_LancerPartie.TabIndex = 5
        Me.Button_LancerPartie.Text = "Lancer une partie"
        Me.Button_LancerPartie.UseVisualStyleBackColor = True
        '
        'ComboBox_ChoixJoueur
        '
        Me.ComboBox_ChoixJoueur.Cursor = System.Windows.Forms.Cursors.Default
        Me.ComboBox_ChoixJoueur.FormattingEnabled = True
        Me.ComboBox_ChoixJoueur.Location = New System.Drawing.Point(25, 24)
        Me.ComboBox_ChoixJoueur.MaxLength = 20
        Me.ComboBox_ChoixJoueur.Name = "ComboBox_ChoixJoueur"
        Me.ComboBox_ChoixJoueur.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_ChoixJoueur.TabIndex = 0
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
        Me.Label_ChoixJoueur.Location = New System.Drawing.Point(22, 8)
        Me.Label_ChoixJoueur.Name = "Label_ChoixJoueur"
        Me.Label_ChoixJoueur.Size = New System.Drawing.Size(80, 13)
        Me.Label_ChoixJoueur.TabIndex = 4
        Me.Label_ChoixJoueur.Text = "Choix du joueur"
        '
        'Button_StatistiquesJoueur
        '
        Me.Button_StatistiquesJoueur.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_StatistiquesJoueur.Location = New System.Drawing.Point(25, 82)
        Me.Button_StatistiquesJoueur.Name = "Button_StatistiquesJoueur"
        Me.Button_StatistiquesJoueur.Size = New System.Drawing.Size(160, 23)
        Me.Button_StatistiquesJoueur.TabIndex = 3
        Me.Button_StatistiquesJoueur.Text = "Statistiques du joueur"
        Me.Button_StatistiquesJoueur.UseVisualStyleBackColor = True
        '
        'Button_AjoutJoueur
        '
        Me.Button_AjoutJoueur.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_AjoutJoueur.Location = New System.Drawing.Point(25, 53)
        Me.Button_AjoutJoueur.Name = "Button_AjoutJoueur"
        Me.Button_AjoutJoueur.Size = New System.Drawing.Size(160, 23)
        Me.Button_AjoutJoueur.TabIndex = 2
        Me.Button_AjoutJoueur.Text = "Ajouter un joueur"
        Me.Button_AjoutJoueur.UseVisualStyleBackColor = True
        '
        'Button_SuppressionJoueur
        '
        Me.Button_SuppressionJoueur.BackColor = System.Drawing.Color.IndianRed
        Me.Button_SuppressionJoueur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_SuppressionJoueur.FlatAppearance.BorderSize = 0
        Me.Button_SuppressionJoueur.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_SuppressionJoueur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SuppressionJoueur.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button_SuppressionJoueur.Location = New System.Drawing.Point(152, 24)
        Me.Button_SuppressionJoueur.Name = "Button_SuppressionJoueur"
        Me.Button_SuppressionJoueur.Size = New System.Drawing.Size(33, 23)
        Me.Button_SuppressionJoueur.TabIndex = 1
        Me.Button_SuppressionJoueur.Text = "X"
        Me.Button_SuppressionJoueur.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button_AjoutJoueur)
        Me.Panel1.Controls.Add(Me.Button_SuppressionJoueur)
        Me.Panel1.Controls.Add(Me.ComboBox_ChoixJoueur)
        Me.Panel1.Controls.Add(Me.Label_ChoixJoueur)
        Me.Panel1.Controls.Add(Me.Button_StatistiquesJoueur)
        Me.Panel1.Location = New System.Drawing.Point(21, 93)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(209, 119)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label_Difficulté)
        Me.Panel2.Controls.Add(Me.ComboBox_ChoixDifficulté)
        Me.Panel2.Controls.Add(Me.Button_LancerPartie)
        Me.Panel2.Location = New System.Drawing.Point(244, 93)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(209, 119)
        Me.Panel2.TabIndex = 7
        '
        'ComboBox_ChoixDifficulté
        '
        Me.ComboBox_ChoixDifficulté.AutoCompleteCustomSource.AddRange(New String() {"Facile", "Moyen", "Difficile"})
        Me.ComboBox_ChoixDifficulté.Cursor = System.Windows.Forms.Cursors.Default
        Me.ComboBox_ChoixDifficulté.FormattingEnabled = True
        Me.ComboBox_ChoixDifficulté.Location = New System.Drawing.Point(29, 39)
        Me.ComboBox_ChoixDifficulté.MaxLength = 20
        Me.ComboBox_ChoixDifficulté.Name = "ComboBox_ChoixDifficulté"
        Me.ComboBox_ChoixDifficulté.Size = New System.Drawing.Size(160, 21)
        Me.ComboBox_ChoixDifficulté.TabIndex = 5
        '
        'Label_Difficulté
        '
        Me.Label_Difficulté.AutoSize = True
        Me.Label_Difficulté.Location = New System.Drawing.Point(26, 23)
        Me.Label_Difficulté.Name = "Label_Difficulté"
        Me.Label_Difficulté.Size = New System.Drawing.Size(101, 13)
        Me.Label_Difficulté.TabIndex = 5
        Me.Label_Difficulté.Text = "Choix de la difficulté"
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 268)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button_Quitter)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Accueil"
        Me.Text = "Sudoku VB.NET: Accueil"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_Quitter As Button
    Friend WithEvents Button_LancerPartie As Button
    Friend WithEvents ComboBox_ChoixJoueur As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label_ChoixJoueur As Label
    Friend WithEvents Button_StatistiquesJoueur As Button
    Friend WithEvents Button_AjoutJoueur As Button
    Friend WithEvents Button_SuppressionJoueur As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label_Difficulté As Label
    Friend WithEvents ComboBox_ChoixDifficulté As ComboBox
End Class
