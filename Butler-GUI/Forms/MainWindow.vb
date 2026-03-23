Public Class MainWindow
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub MainWindow_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        ' Run check to see if butler exists.
        If ButlerHandler.CheckIfExists() = False Then

            ' Create message box for error, assume no by default.
            Dim doesNotExistDiag As DialogResult
            doesNotExistDiag = MessageBox.Show("Butler does not exist. Did you want to download it now?", "Butler Check", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            ' Check if user has decided to download butler.
            If doesNotExistDiag = DialogResult.Yes Then
                ' If they have decided to download butler, launch downloader.


            End If

        End If


    End Sub
End Class
