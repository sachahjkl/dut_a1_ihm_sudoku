<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GrilleDeJeu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GrilleDeJeu))
        Me.Button_ViderGrille = New System.Windows.Forms.Button()
        Me.Button_RetourAccueil = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_ViderGrille
        '
        Me.Button_ViderGrille.Location = New System.Drawing.Point(156, 382)
        Me.Button_ViderGrille.Name = "Button_ViderGrille"
        Me.Button_ViderGrille.Size = New System.Drawing.Size(75, 23)
        Me.Button_ViderGrille.TabIndex = 0
        Me.Button_ViderGrille.Text = "Vider la grille"
        Me.Button_ViderGrille.UseVisualStyleBackColor = True
        '
        'Button_RetourAccueil
        '
        Me.Button_RetourAccueil.Location = New System.Drawing.Point(237, 382)
        Me.Button_RetourAccueil.Name = "Button_RetourAccueil"
        Me.Button_RetourAccueil.Size = New System.Drawing.Size(113, 23)
        Me.Button_RetourAccueil.TabIndex = 1
        Me.Button_RetourAccueil.Text = "Retour à l'accueil"
        Me.Button_RetourAccueil.UseVisualStyleBackColor = True
        '
        'GrilleDeJeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 417)
        Me.Controls.Add(Me.Button_RetourAccueil)
        Me.Controls.Add(Me.Button_ViderGrille)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GrilleDeJeu"
        Me.Text = "Sudoku VB.NET: Grille"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_ViderGrille As Button
    Friend WithEvents Button_RetourAccueil As Button
End Class
