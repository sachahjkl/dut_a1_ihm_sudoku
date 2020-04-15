<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GrilleDeJeu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GrilleDeJeu))
        Me.GroupBox_Contrôles = New System.Windows.Forms.GroupBox()
        Me.Label_Temps = New System.Windows.Forms.Label()
        Me.Button_Retour = New System.Windows.Forms.Button()
        Me.GroupBox_Contrôles.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_Contrôles
        '
        Me.GroupBox_Contrôles.Controls.Add(Me.Label_Temps)
        Me.GroupBox_Contrôles.Controls.Add(Me.Button_Retour)
        Me.GroupBox_Contrôles.Location = New System.Drawing.Point(5, 494)
        Me.GroupBox_Contrôles.Name = "GroupBox_Contrôles"
        Me.GroupBox_Contrôles.Size = New System.Drawing.Size(490, 40)
        Me.GroupBox_Contrôles.TabIndex = 0
        Me.GroupBox_Contrôles.TabStop = False
        Me.GroupBox_Contrôles.Text = "Commandes"
        '
        'Label_Temps
        '
        Me.Label_Temps.AutoSize = True
        Me.Label_Temps.Location = New System.Drawing.Point(76, 16)
        Me.Label_Temps.Name = "Label_Temps"
        Me.Label_Temps.Size = New System.Drawing.Size(39, 13)
        Me.Label_Temps.TabIndex = 1
        Me.Label_Temps.Text = "Temps"
        '
        'Button_Retour
        '
        Me.Button_Retour.Location = New System.Drawing.Point(367, 11)
        Me.Button_Retour.Name = "Button_Retour"
        Me.Button_Retour.Size = New System.Drawing.Size(117, 23)
        Me.Button_Retour.TabIndex = 0
        Me.Button_Retour.Text = "Retour/Abandonner"
        Me.Button_Retour.UseVisualStyleBackColor = True
        '
        'GrilleDeJeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 539)
        Me.Controls.Add(Me.GroupBox_Contrôles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GrilleDeJeu"
        Me.Text = "Sudoku VB.NET: Grille"
        Me.GroupBox_Contrôles.ResumeLayout(False)
        Me.GroupBox_Contrôles.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox_Contrôles As GroupBox
    Friend WithEvents Button_Retour As Button
    Friend WithEvents Label_Temps As Label
End Class
