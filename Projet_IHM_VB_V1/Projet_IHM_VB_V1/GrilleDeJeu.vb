Public Class GrilleDeJeu
    Dim TimeOut As Integer = 0

    Dim LastEmptyBoxes As Integer = 0

    Dim FirstTry As Integer = 0

    Dim SecondTry As Integer = 0

    Dim var As New Dictionary(Of String, String)()

    Dim Occurances As Integer = 0

    Dim random1 As Integer = 0

    Dim random2 As Integer = 0

    Private Sub GrilleDeJeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim txtBox As New System.Windows.Forms.TextBox
        Dim xLen As Integer = 0
        Dim yLen As Integer = 0
        Dim BoxLen As Integer = 31
        Dim BoxPosGrille As Integer = 1
        For i1 = 1 To 9
            If i1 > 3 And i1 < 7 Then
                yLen = 10
            ElseIf i1 > 6 Then
                yLen = 20
            End If
            For i2 = 1 To 9
                txtBox.Name = "txt" & i1 & i2
                var("var" & i1 & i2) = ""
                var("var" & i1 & i2 & "tag") = ""
                If i2 > 3 And i2 < 7 Then
                    xLen = 10
                ElseIf i2 > 6 Then
                    xLen = 20
                End If
                txtBox.Location = New Point((BoxLen * i2) + xLen, (BoxLen * i1) + yLen)
                txtBox.Size = New Size(BoxLen, BoxLen)
                txtBox.Font = New Font("Microsoft Sans Serif", 15.75)
                txtBox.MaxLength = 1
                txtBox.TextAlign = HorizontalAlignment.Center
                txtBox.BorderStyle = BorderStyle.FixedSingle
                Me.Controls.Add(txtBox)

                'AddHandler txtBox.KeyPress, AddressOf txtBox_KeyPress
                'AddHandler txtBox.TextChanged, AddressOf txtBox_TextChanged

                txtBox = New System.Windows.Forms.TextBox
            Next
            xLen = 0
        Next
        Me.Width = BoxLen * 9 + 100


    End Sub

    Private Sub ClearAll() Handles Button_ViderGrille.Click

        For Each cntl In Me.Controls
            If TypeOf (cntl) Is System.Windows.Forms.TextBox Then
                cntl.clear()
                cntl.Tag = ""
                var(cntl.Name.ToString.Replace("txt", "var")) = ""
                var(cntl.Name.ToString.Replace("txt", "var") & "tag") = ""
            End If
        Next
    End Sub

    Private Sub ClearAll(sender As Object, e As EventArgs) Handles Button_ViderGrille.Click

    End Sub

    Private Sub Button_RetourAccueil_Click(sender As Object, e As EventArgs) Handles Button_RetourAccueil.Click
        Me.Hide()
        Accueil.Show()

    End Sub
End Class