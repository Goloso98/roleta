Public Class form_login

    Function VerificarLogin(user As String, pass As String) As Integer
        'return "0"  :  user nao existe
        'return "1"  :  pass incorreta
        'return "2"  :  login aceite

        Dim linha As Integer = ProcurarLinha(user, users__txt)
        If linha = -1 Then
            Return 0
        Else
            If LerLinha(linha, pass__txt) = pass Then
                Return 2
            Else
                Return 1
            End If
        End If
    End Function

    Private Sub form_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartFiles()
        Me.Width = 300 'comprimento
        Me.Height = 251 'altura


        'Traduçao
        Me.Text = getRMValue("me_title")
        lbl_user.Text = getRMValue("lbl_user")
        lbl_pass.Text = getRMValue("lbl_pass")
        lbl_error_login.Text = getRMValue("lbl_error_login")
        but_login.Text = getRMValue("but_login")
        but_SignUp.Text = getRMValue("but_SignUp")
        lbl_signup.Text = getRMValue("lbl_signup")
        lbl_signup_user.Text = getRMValue("lbl_signup_user")
        lbl_signup_pass.Text = getRMValue("lbl_signup_pass")
        lbl_signup_pass2.Text = getRMValue("lbl_signup_pass2")
        lbl_signup_Fname.Text = getRMValue("lbl_signup_Fname")
        lbl_signup_Lname.Text = getRMValue("lbl_signup_Lname.Text")
        but_signup_add.Text = getRMValue("but_signup_add")
    End Sub

    Private Sub but_login_Click(sender As Object, e As EventArgs) Handles but_login.Click
        lbl_error_login.Visible = False

        Dim username As String
        Dim password As String
        Dim login As Integer

        username = UCase(txt_user.Text)
        password = txt_pass.Text

        username = Encrypt(username, Hash)
        password = Encrypt(password, Hash)

        login = VerificarLogin(username, password)

        If login = 0 Then
            Console.WriteLine("criar user prompt 'vbyesno'")

            Select Case MessageBox.Show(getRMValue("msg2_linha1") & vbCrLf &
                                                      getRMValue("msg2_linha2"),
                                                      getRMValue("msg2_title1"),
                                                      MessageBoxButtons.YesNo)
                Case DialogResult.Yes
                    Me.Width = 300 'comprimento
                    Me.Height = 686 'altura


                    Console.WriteLine("YES")
                    '---------------- teste
                    'Case DialogResult.No
                    '    Console.WriteLine("NO")
            End Select

        ElseIf login = 1 Then
            lbl_error_login.Visible = True
        Else
            Console.WriteLine("sucesso login")
            'proximo_form.show()
            'me.hide()
        End If
    End Sub

    Private Sub but_SignUp_Click(sender As Object, e As EventArgs) Handles but_SignUp.Click
        Me.Width = 300 'comprimento
        Me.Height = 686 'altura
    End Sub
End Class