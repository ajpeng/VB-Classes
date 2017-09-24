Public Class Line
    Private mstrLine As String

    Property Line() As String
        Get
            Return mstrLine
        End Get
        Set(value As String)
            mstrLine = value
        End Set
    End Property

    ReadOnly Property Length() As Integer
        Get
            Return mstrLine.Length
        End Get
    End Property

    Public Function getWord() As String
        Dim astrWords() As String

        astrWords = Split(mstrLine, " ")

        Return astrWords(0)
    End Function

End Class
