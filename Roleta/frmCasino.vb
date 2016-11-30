Public Class frmCasino
    Dim counter As Integer
    Dim lap As Integer
    Dim stoplap As Integer
    Dim bet As Double
    Dim cash As Double
    Dim countercards As Integer

    Sub audio(state As Boolean)
        If chb_audio.Checked Then
            If state Then
                My.Computer.Audio.Play(My.Resources.mlghappy, AudioPlayMode.Background)
            Else
                My.Computer.Audio.Play(My.Resources.mlgsad, AudioPlayMode.Background)
            End If
        End If
    End Sub
    Private Sub butRoll_Click(sender As Object, e As EventArgs) Handles butRoll.Click
        lblJackpot.Text = ("")

        My.Computer.Audio.Stop()

        Randomize()
        stoplap = CInt(Math.Floor((65 - 40 + 1) * Rnd())) + 40

        timer.Start()

        If rtbCores.Checked = True Then
            lbl10.Text = ("")
            lbl11.Text = ("")
            lbl12.Text = ("")
            lbl13.Text = ("")
            lbl14.Text = ("")
            lbl15.Text = ("")
            lbl16.Text = ("")
        End If


    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick


        If counter = 0 Then
            lbl13.BackColor = Color.Green
            lbl14.BackColor = Color.Red
            lbl15.BackColor = Color.Black
            lbl16.BackColor = Color.Red
            lbl10.BackColor = Color.Black
            lbl11.BackColor = Color.Red
            lbl12.BackColor = Color.Black
        Else
            If counter = 1 Then
                lbl13.BackColor = Color.Black
                lbl14.BackColor = Color.Green
                lbl15.BackColor = Color.Red
                lbl16.BackColor = Color.Black
                lbl10.BackColor = Color.Red
                lbl11.BackColor = Color.Black
                lbl12.BackColor = Color.Red
            Else
                If counter = 2 Then
                    lbl13.BackColor = Color.Red
                    lbl14.BackColor = Color.Black
                    lbl15.BackColor = Color.Green
                    lbl16.BackColor = Color.Red
                    lbl10.BackColor = Color.Black
                    lbl11.BackColor = Color.Red
                    lbl12.BackColor = Color.Black
                Else
                    If counter = 3 Then
                        lbl13.BackColor = Color.Black
                        lbl14.BackColor = Color.Red
                        lbl15.BackColor = Color.Black
                        lbl16.BackColor = Color.Green
                        lbl10.BackColor = Color.Red
                        lbl11.BackColor = Color.Black
                        lbl12.BackColor = Color.Red
                    Else
                        If counter = 18 Then
                            lbl13.BackColor = Color.Red
                            lbl14.BackColor = Color.Black
                            lbl15.BackColor = Color.Red
                            lbl16.BackColor = Color.Black
                            lbl10.BackColor = Color.Green
                            lbl11.BackColor = Color.Red
                            lbl12.BackColor = Color.Black
                        Else
                            If counter = 19 Then
                                lbl13.BackColor = Color.Black
                                lbl14.BackColor = Color.Red
                                lbl15.BackColor = Color.Black
                                lbl16.BackColor = Color.Red
                                lbl10.BackColor = Color.Black
                                lbl11.BackColor = Color.Green
                                lbl12.BackColor = Color.Red
                            Else
                                If counter = 20 Then
                                    lbl13.BackColor = Color.Red
                                    lbl14.BackColor = Color.Black
                                    lbl15.BackColor = Color.Red
                                    lbl16.BackColor = Color.Black
                                    lbl10.BackColor = Color.Red
                                    lbl11.BackColor = Color.Black
                                    lbl12.BackColor = Color.Green
                                Else
                                    If counter > 3 And counter < 18 Then
                                        If counter Mod 2 = 0 Then
                                            lbl13.BackColor = Color.Red
                                            lbl14.BackColor = Color.Black
                                            lbl15.BackColor = Color.Red
                                            lbl16.BackColor = Color.Black
                                            lbl10.BackColor = Color.Black
                                            lbl11.BackColor = Color.Red
                                            lbl12.BackColor = Color.Black
                                        Else
                                            lbl13.BackColor = Color.Black
                                            lbl14.BackColor = Color.Red
                                            lbl15.BackColor = Color.Black
                                            lbl16.BackColor = Color.Red
                                            lbl10.BackColor = Color.Red
                                            lbl11.BackColor = Color.Black
                                            lbl12.BackColor = Color.Red
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If rtbNumbers.Checked = True Then

            If counter <= 0 Then
                lbl13.Text = (0 - counter)
            Else
                lbl13.Text = (Math.Abs(counter - 21))
            End If
            If counter <= 1 Then
                lbl14.Text = (1 - counter)
            Else
                lbl14.Text = (Math.Abs(counter - 22))
            End If
            If counter <= 2 Then
                lbl15.Text = (2 - counter)
            Else
                lbl15.Text = (Math.Abs(counter - 23))
            End If
            If counter <= 3 Then
                lbl16.Text = (3 - counter)
            Else
                lbl16.Text = (Math.Abs(counter - 24))
            End If

            If counter <= 18 Then
                lbl10.Text = (18 - counter)
            Else
                lbl10.Text = (Math.Abs(counter - 39))
            End If
            If counter <= 19 Then
                lbl11.Text = (19 - counter)
            Else
                lbl11.Text = (Math.Abs(counter - 40))
            End If
            If counter <= 20 Then
                lbl12.Text = (20 - counter)
            End If
        End If
        lap = lap + 1
        counter = counter + 1
        If (counter = 21) Then
            counter = 0
        End If

        If lap = stoplap Then
            timer.Stop()
            lap = 0
            If rtbNumbers.Checked = True Then
                If lbl13.Text = cbxNumbers.Text Then
                    lblJackpot.Text = ("JACKPOT!!!")
                    audio(True)
                    cash = bet * 14 + cash
                Else
                    lblJackpot.Text = ("YOU LOSE!!!")
                    audio(False)
                End If
            End If
            If rtbCores.Checked = True Then
                If lbl13.BackColor = Color.Green And cbxColors.Text = ("Green") Then
                    lblJackpot.Text = ("JACKPOT!!!")
                    audio(True)
                    cash = bet * 14 + cash
                End If
                If lbl13.BackColor = Color.Black And cbxColors.Text = ("Black") Then
                    lblJackpot.Text = ("JACKPOT!!!")
                    audio(True)
                    cash = bet * 2 + cash
                Else
                        If lbl13.BackColor = Color.Red And cbxColors.Text = ("Red") Then
                        lblJackpot.Text = ("JACKPOT!!!")
                        audio(True)
                        cash = bet * 2 + cash
                    Else
                        lblJackpot.Text = ("YOU LOSE!!!")
                        audio(False)
                    End If
                End If
            End If
            lblAmcash.Text = (cash & " $")
            lblAmbet.Text = ("")
            bet = 0
            butBet.Enabled = True
            butRoll.Enabled = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        counter = 0
        lap = 0
        stoplap = 0
        cash = 1000
        lblAmcash.Text = (cash & " $")
        cartas.Start()
        countercards = 1
        chb_audio.Checked = True
        chb_audio.Text = "On"

    End Sub

    Private Sub butBet_Click(sender As Object, e As EventArgs) Handles butBet.Click
        Dim erro As String
        Do
            erro = ""
            Try
                bet = InputBox("How much shall you bet?", "Bet")
            Catch ex As Exception
                erro = ex.Message
            End Try
            Console.WriteLine(bet)
        Loop Until (erro.Length = 0 And bet >= 0 And bet <= cash)

        If bet > 0 Then
            butBet.Enabled = False
            cash = cash - bet
            lblAmcash.Text = (cash & " $")
            lblAmbet.Text = (bet & " $")
        End If


        If butBet.Enabled = False And ((cbxColors.Text <> ("")) Or (cbxNumbers.Text <> (""))) Then
            butRoll.Enabled = True
        End If
    End Sub

    Private Sub rtbCores_CheckedChanged(sender As Object, e As EventArgs) Handles rtbCores.CheckedChanged
        If rtbCores.Checked = True Then
            rtbNumbers.Checked = False
            cbxColors.Visible = True
            cbxNumbers.Visible = False
        End If
    End Sub

    Private Sub rtbNumbers_CheckedChanged(sender As Object, e As EventArgs) Handles rtbNumbers.CheckedChanged
        If rtbNumbers.Checked = True Then
            rtbCores.Checked = False
            cbxNumbers.Visible = True
            cbxColors.Visible = False
        End If
    End Sub

    Private Sub cbxColors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxColors.SelectedIndexChanged
        If butBet.Enabled = False And ((cbxColors.Text <> ("")) Or (cbxNumbers.Text <> (""))) Then
            butRoll.Enabled = True
        End If

        If cbxColors.Text = ("Green") Then
            lblMultiplier.Text = ("x14")
        End If
        If cbxColors.Text = ("Black") Or cbxColors.Text = ("Red") Then
            lblMultiplier.Text = ("x2")
        End If

    End Sub

    Private Sub cbxNumbers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxNumbers.SelectedIndexChanged
        If butBet.Enabled = False And ((cbxColors.Text <> ("")) Or (cbxNumbers.Text <> (""))) Then
            butRoll.Enabled = True
        End If

        If cbxNumbers.Text <> ("") Then
            lblMultiplier.Text = ("x14")
        End If
    End Sub

    Private Sub cartas_Tick(sender As Object, e As EventArgs) Handles cartas.Tick
        If countercards = 1 Then
            pic1.Visible = True
        End If
        If countercards = 2 Then
            pic2.Visible = True
        End If
        If countercards = 3 Then
            pic3.Visible = True
        End If
        If countercards = 4 Then
            pic4.Visible = True
        End If
        countercards = countercards + 1
        If countercards = 6 Then
            countercards = 1
            pic1.Visible = False
            pic2.Visible = False
            pic3.Visible = False
            pic4.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        form_login.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chb_audio.CheckedChanged
        If chb_audio.Checked Then
            chb_audio.Text = "On"
            'imagem on
        Else
            chb_audio.Text = "Off"
        End If
        My.Computer.Audio.Stop()
    End Sub
End Class
