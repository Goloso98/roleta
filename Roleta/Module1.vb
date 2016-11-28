Imports System
Imports System.Globalization
Imports System.Security.Cryptography
Imports System.Text
Imports System.Environment
Imports System.IO
Imports System.IO.Directory
Imports System.IO.File
Imports System.Resources
Imports System.Reflection
Imports System.Threading
Imports System.Threading.Thread

Module Module1

    Public culture As String = System.Globalization.CultureInfo.CurrentCulture.ToString.ToUpper.Substring(0, 2)
    'Public culture As String = CultureInfo.CurrentCulture.TwoLetterISOLanguageName
    'Public culture As CultureInfo = CultureInfo.CurrentCulture
    Public appfolder As String = GetAppDataPath() & "\roleta"
    Public users__txt As String = appfolder & "\users.txt"
    Public pass__txt As String = appfolder & "\pass.txt"

    Public Function GetAppDataPath() As String ' pasta %appdata%
        Return Environment.GetFolderPath(SpecialFolder.ApplicationData)
    End Function


    Public rm As Resources.ResourceManager
    'Function definir linguagem
    Public Function getRMValue(ByVal strValue As String)
        Dim strLanguage As String

        If IsNothing(rm) Then
            'Get system language
            strLanguage = System.Globalization.CultureInfo.CurrentCulture.ToString.ToUpper.Substring(0, 2)

            'Set resource manager
            Select Case strLanguage
                Case "PT"
                    rm = My.Resources.pt.ResourceManager
                Case Else
                    rm = My.Resources.all.ResourceManager
            End Select
        End If

        getRMValue = rm.GetString(strValue)
    End Function


    Public Sub StartFiles()
        Try
            If Not Directory.Exists(appfolder) Then
                Directory.CreateDirectory(appfolder)
            End If
            If Not File.Exists(users__txt) Then
                File.Create(users__txt)
            End If
            If Not File.Exists(pass__txt) Then
                File.Create(pass__txt)
            End If

            Dim file_users_length As Integer = File.ReadAllLines(users__txt).Length
            Dim file_pass_length = File.ReadAllLines(pass__txt).Length

            If file_users_length <> file_pass_length Then
                File.Delete(users__txt)
                File.Delete(pass__txt)
                File.Create(users__txt)
                File.Create(pass__txt)

                MessageBox.Show(getRMValue("msg1_line1") & vbCrLf &
                                getRMValue("msg1_line2"),
                                getRMValue("msg1_title1"),
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)

            End If

        Catch exception1 As Exception
            Console.WriteLine(exception1.ToString)

        End Try
    End Sub

    Public Sub AppendText(text As String, path As String) 'escrever no ficheiro
        Using writer As StreamWriter = File.AppendText(path)
            writer.WriteLine(text)
        End Using
    End Sub

    Public Function ContarLinhas(path As String) As Integer 'contar linhas
        Dim lineCount As Integer = File.ReadAllLines(path).Length
        Return lineCount
    End Function

    Public Function LerLinha(linha As Integer, Path As String) As String 'ler linha especifica
        Dim line_read As String = ""
        Dim num As Integer = 1
        Using reader As StreamReader = File.OpenText(Path)
            Do While ((num <= linha) And (num <= ContarLinhas(Path)))
                reader.Peek()
                line_read = reader.ReadLine
                num += 1
            Loop
        End Using
        Return line_read
    End Function

    Public Function ProcurarLinha(texto As String, Path As String) As Integer 'comparar texto com linha a linha (0 ou 1)
        Dim num2 As Integer = 0
        Dim flag As Boolean = False
        Using reader As StreamReader = File.OpenText(Path)
            Do While ((reader.Peek >= 0) And Not flag)
                num2 += 1
                Dim str As String = reader.ReadLine
                If (str = texto) Then
                    flag = True
                End If
                Console.WriteLine((str & " 'funçao: ProcurarLinha'"))
            Loop
        End Using
        If flag Then
            Return num2
        Else
            Return -1
        End If
    End Function

    '------encriptacao......
    Dim DES As New TripleDESCryptoServiceProvider
    Dim MD5 As New MD5CryptoServiceProvider
    Public Hash As String = "Code is cool!"

    'hash function
    Public Function MD5Hash(value As String) As Byte()
        Return MD5.ComputeHash(Encoding.ASCII.GetBytes(value))
    End Function

    'Encryption
    Function Encrypt(input As String, Key As String) As String
        DES.Key = MD5Hash(Key)
        DES.Mode = CipherMode.ECB

        Dim buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(input)
        Return Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))
    End Function

    'Decrypt
    Function Decrypt(encryptedstring As String, Key As String) As String
        DES.Key = MD5Hash(Key)
        DES.Mode = CipherMode.ECB

        Dim buffer As Byte() = Convert.FromBase64String(encryptedstring)
        Return ASCIIEncoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length))
    End Function
End Module
