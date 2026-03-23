Imports System.IO

Public Class ButlerHandler


    Public Shared Function CheckIfExists(Optional path As String = "==TEMP==")

        ' Create doesExist dim. Assume false by default in case of
        ' error handling.
        Dim doesExist As Boolean = False

        ' Check if path is TEMP
        If path = "==TEMP==" Then
            ' Set the path to the actual temp directory for the user.
            ' I cannot set the path on the Optional for the function,
            ' so this is the next best thing.
            path = My.Computer.FileSystem.SpecialDirectories.Temp + "\butler"
        End If

        ' Check if path Exists.
        If My.Computer.FileSystem.DirectoryExists(path) = True Then
            doesExist = True
        Else
            doesExist = False
        End If

        Return doesExist
    End Function

End Class
