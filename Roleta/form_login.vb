Public Class form_login
    Public linha As Integer
    Function VerificarLogin(user As String, pass As String) As Integer
        'return "0"  :  user nao existe
        'return "1"  :  pass incorreta
        'return "2"  :  login aceite

        linha = ProcurarLinha(user, users__txt)
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
    Private Sub ActivateTabStop(Activate As Boolean)
        If Activate Then
            txt_signup_user.TabStop = True
            txt_signup_pass.TabStop = True
            txt_signup_pass2.TabStop = True
            txt_signup_Fname.TabStop = True
            txt_signup_Lname.TabStop = True
            but_signup_add.TabStop = True
        Else
            txt_signup_user.TabStop = False
            txt_signup_pass.TabStop = False
            txt_signup_pass2.TabStop = False
            txt_signup_Fname.TabStop = False
            txt_signup_Lname.TabStop = False
            but_signup_add.TabStop = False
        End If
    End Sub

    Private Sub login_kick()
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
                    Width = 300 'comprimento
                    Height = 686 'altura
                    txt_signup_user.Text = txt_user.Text
                    txt_signup_pass.Text = txt_pass.Text

                    txt_user.Text = String.Empty
                    txt_pass.Text = String.Empty

                    ActivateTabStop(True)

                    txt_signup_pass2.Focus()
                    Console.WriteLine("YES")
                    '---------------- teste
                    'Case DialogResult.No
                    '    Console.WriteLine("NO")
            End Select

        ElseIf login = 1 Then
            lbl_error_login.Visible = True
        Else
            Console.WriteLine("sucesso login")
            Console.WriteLine(Decrypt(LerLinha(linha, nomes__txt), Hash))
            'proximo_form.show()
            frmCasino.Show()
            Hide()
        End If
    End Sub

    Sub AddUser()
        Dim user As String
        Dim user2 As String = txt_signup_user.Text
        Dim pass As String
        Dim nome As String
        Dim apelido As String
        Dim nome_apelido As String

        user = UCase(txt_signup_user.Text)
        pass = txt_signup_pass.Text
        nome = Trim(txt_signup_Fname.Text)
        apelido = Trim(txt_signup_Lname.Text)
        'Verificar campos
        If user.Length = 0 Then
            MessageBox.Show(getRMValue("msg4_linha1"), getRMValue("meg4_title1"))
            txt_signup_user.Focus()
            Exit Sub
        End If
        If pass.Length = 0 Then
            MessageBox.Show(getRMValue("msg4_linha1"), getRMValue("meg4_title1"))
            txt_signup_pass.Focus()
            Exit Sub
        End If
        If nome.Length = 0 Then
            MessageBox.Show(getRMValue("msg4_linha1"), getRMValue("meg4_title1"))
            txt_signup_Fname.Focus()
            Exit Sub
        End If
        If apelido.Length = 0 Then
            MessageBox.Show(getRMValue("msg4_linha1"), getRMValue("meg4_title1"))
            txt_signup_Lname.Focus()
            Exit Sub
        End If

        If pass.Length < 3 Then
            Console.WriteLine("pass pequena")
            MessageBox.Show(getRMValue("msg3_linha1"), getRMValue("Informacao"), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_signup_pass.Focus()
            Exit Sub
        ElseIf pass <> txt_signup_pass2.Text Then
            Console.WriteLine("pass <> pass2")
            MessageBox.Show(getRMValue("msg5_linha1"), getRMValue("Informacao"), MessageBoxButtons.OK)
            txt_signup_pass2.Focus()
            Exit Sub
        End If
        'Existe o user?
        If ProcurarLinha(user, users__txt) <> -1 Then
            Console.WriteLine("ja existe")
            MessageBox.Show(getRMValue("msg6_linha1"), getRMValue("Informacao"), MessageBoxButtons.OK)
            Exit Sub
        End If
        Console.WriteLine("pass = pass2")
        Console.WriteLine(ProcurarLinha(user, users__txt))
        'Procurar espaços no nome
        If EncontarEspacos(nome) And EncontarEspacos(apelido) Then
            Console.WriteLine("nome nao pode ter espaços no meio")
            MessageBox.Show(getRMValue("msg7"), getRMValue("Informacao"), MessageBoxButtons.OK)
            'focus
            Exit Sub
        Else
            OrganizarNome(nome, apelido)
            nome_apelido = nome & " " & apelido
        End If

        txt_user.Text = user2
        txt_pass.Text = pass

        user = Encrypt(user, Hash)
        pass = Encrypt(pass, Hash)
        nome_apelido = Encrypt(nome_apelido, Hash)

        AppendText(user, users__txt)
        AppendText(pass, pass__txt)
        AppendText(nome_apelido, nomes__txt)

        Width = 300 'comprimento
        Height = 251 'altura

        ActivateTabStop(False)

        'mensagem utilizador aceite
        MessageBox.Show(getRMValue("msg8"), getRMValue("Sucesso"), MessageBoxButtons.OK)
    End Sub

    Private Sub form_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
        StartFiles()
        Width = 300 'comprimento
        Height = 251 'altura

        'Traduçao
        Text = getRMValue("me_title")
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
        lbl_signup_Lname.Text = getRMValue("lbl_signup_Lname")
        but_signup_add.Text = getRMValue("but_signup_add")
    End Sub

    Private Sub but_login_Click(sender As Object, e As EventArgs) Handles but_login.Click
        login_kick()
    End Sub

    Private Sub but_SignUp_Click(sender As Object, e As EventArgs) Handles but_SignUp.Click
        Width = 300 'comprimento
        Height = 686 'altura
        ActivateTabStop(True)
    End Sub

    Private Sub but_signup_add_Click(sender As Object, e As EventArgs) Handles but_signup_add.Click
        AddUser()
    End Sub

    '----- ação á tecla Enter
    Private Sub txt_pass_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_pass.KeyDown 'password <-> signup
        lbl_error_login.Visible = False
        If e.KeyCode = Keys.Enter Then
            login_kick()
        End If
    End Sub
    'signup panel <-> adduser()
    Private Sub txt_signup_user_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_signup_user.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddUser()
        End If
    End Sub
    Private Sub txt_signup_pass_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_signup_pass.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddUser()
        End If
    End Sub
    Private Sub txt_signup_pass2_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_signup_pass2.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddUser()
        End If
    End Sub
    Private Sub txt_signup_Fname_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_signup_Fname.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddUser()
        End If
    End Sub
    Private Sub txt_signup_Lname_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_signup_Lname.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddUser()
        End If
    End Sub
End Class