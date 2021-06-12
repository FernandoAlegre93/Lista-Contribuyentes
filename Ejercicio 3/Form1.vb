Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        lstContribuyentes.Items.Clear()
        For i = 0 To 99
            lstContribuyentes.Items.Add(CInt((200 - 100) * Rnd() + 100))
        Next

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        lstPagos.Items.Clear()
        For i = 0 To 99
            lstPagos.Items.Add(CInt((99 - 10) * Rnd() + 10))
        Next

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Suma As Integer = 0
        For i = 0 To lstPagos.Items.Count - 1
            Suma = Suma + lstPagos.Items(i)
        Next
        txtboxSuma.Text = (Suma)

    End Sub

    
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        lstContribuyentes.Items.Clear()
        lstPagos.Items.Clear()
        txtboxSuma.Text = ""
    End Sub
End Class
