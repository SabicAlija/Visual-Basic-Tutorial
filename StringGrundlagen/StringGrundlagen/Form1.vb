Public Class Form1
    Private Sub cmdLänge_Click(sender As Object, e As EventArgs) Handles cmdLänge.Click
        Dim eingabe As String
        Dim anzeige As String

        eingabe = txtEingabe.Text
        anzeige = "Länge: " & eingabe.Length
        lblAusgabe.Text = anzeige

        'lblAnzeige.Text = "Länge" & _
        '   txtEingabe.Text.Length

    End Sub
End Class
