Public Class frmLineTest
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDisplay_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDisplay.Click
        Dim oLine As Line

        oLine = New Line(txtLine.Text)

        oLine.Line = txtLine.Text
        txtLength.Text = oLine.Length.ToString()
    End Sub

    Private Sub btnGetWord_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGetWord.Click
        Dim oLine As New Line(txtLine.Text)

        oLine.Line = txtLine.Text
        textWord.Text = oLine.getWord()
    End Sub
End Class
