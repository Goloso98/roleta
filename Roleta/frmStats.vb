Public Class frmStats

    Private Sub frmStats_Load(sender As Object, e As EventArgs) Handles Me.Load
        Console.WriteLine()
        Console.WriteLine("---frmStats_Load---")
        'traduçao
        lbl_title.Text = getRMValue("lbl_title")
        lblWl.Text = getRMValue("lblWl")
        lblBws.Text = getRMValue("lblBws")
        lblBls.Text = getRMValue("lblBls")

        If win_loses.Capacity <> 0 Then
            Dim total As Integer = win_loses.Capacity
            Dim wins As Integer = vitorias()
            Dim loses As Integer = total - wins
            Dim w_l As Single = wins / loses

            If Not w_l = "+Infinito" Then
                lblWlstat.Text = w_l
            End If
            If Not wins = 0 Then
                lblBwsstat.Text = streak("wins")
            End If
            If Not loses = 0 Then
                lblBlsstat.Text = streak("lose")
            End If

            Console.WriteLine(total)
                Console.WriteLine(wins)
                Console.WriteLine(loses)
                Console.WriteLine(w_l)
            End If
    End Sub
End Class