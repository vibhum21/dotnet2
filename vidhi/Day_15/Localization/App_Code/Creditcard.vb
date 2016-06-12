Imports Microsoft.VisualBasic

Public Class Creditcard
    Public Shared Function IsValid(ByVal number As String) As Boolean
        Return (number.Length = 16)
    End Function
End Class
