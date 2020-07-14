Imports System.IO 'Import file I/O tools
Imports System.Security.Cryptography 'Import encryption functionality
Imports System.Text 'Import text based processing tools

Public Class LoginForm

    Private Function GenerateHash() As Byte()
        Dim ByteArray() As Byte 'byte array created to hold hash data
        Dim sha1Hash As New SHA1CryptoServiceProvider 'Sha1 declared to provide the crypto services
        'this uses the computehash method of the SHA1CryptoServiceProvider and accept accepts the password and username as bytes

        ByteArray = sha1Hash.ComputeHash(Encoding.ASCII.GetBytes(tbPassword.Text & tbUserName.Text))

        Return ByteArray

    End Function

    Private Function StringtoMD5(ByRef Content As String) As String
        'declare m5 as a md5
        Dim M5 As New System.Security.Cryptography.MD5CryptoServiceProvider
        'declare bytestring as a byte
        Dim ByteString() As Byte = System.Text.Encoding.ASCII.GetBytes(Content)
        'convert bytestring to m5 compute hash
        ByteString = M5.ComputeHash(ByteString)
        'change finalstring value to nothing
        Dim FinalString As String = Nothing

        'convert bytestring to string
        For Each bt As Byte In ByteString
            FinalString &= bt.ToString("x2")
        Next

        'return the encrypted password and convert it to uppercase
        Return FinalString.ToUpper()
    End Function

 
    Private Sub login()
        'declares username
        Dim username As String = tbUserName.Text

        'encrypt password and convert to string
        Dim password As String = StringtoMD5(tbPassword.Text)

        'array to find username and password
        Dim loginUser(1) As String
        'array to find username
        loginUser(0) = tbUserName.Text
        'array to find encrypted password
        loginUser(1) = password

        'join username and password array with . delimiter
        Dim result As String = String.Join(".", loginUser)


        'Dim test As String = result

        'default bool position
        Dim bool As Boolean = False

        'Check through each line on text file for matching username and password
        For Each Line As String In File.ReadLines("login.txt")
            'if username and password already exists
            If Line.Equals(result) = True Then
                bool = True
            End If
        Next

        'Outputs whether the login was succesful or not
        If bool = True Then
            MessageBox.Show("Welcome To Meeting Point " & " " & username)
            Form1.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username and/or Password, Please try again")
            tbPassword.Text = ""
        End If
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'login function
        login()
    End Sub
   

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        CreateUser.Show()
       Me.Hide()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
    '    'run the function in order t generate a hash for the entered credentials 
    '    Dim SHA1Hash() As Byte = GenerateHash()
    '    'to read the file in the current directory
    '    Dim fInfo As New FileInfo("..\..\Output.txt")
    '    'getting the file lenght and passng it to the long variable: numByte
    '    Dim numBytes As Long = fInfo.Length
    '    'creates a binary reader to read the credentials in the output.dat
    '    Dim binaryReader As New BinaryReader(New FileStream("..\..\Output.txt", FileMode.Open, FileAccess.Read))

    '    Dim HashFie() As Byte = binaryReader.ReadBytes(numBytes)


    '    'read the file information 

    '    binaryReader.Close()

    '    Dim Hash As String = Convert.ToBase64String(HashFie)
    '    Dim LoginHash As String = Convert.ToBase64String(SHA1Hash)

    '    If Hash = LoginHash Then
    '        MsgBox(" Access Granted") ' Display message or open form
    '    Else
    '        ' Access Denied. Invalid login. Display access denied message.
    '    End If
    '    Dim user As String() = {tbUserName.Text, tbPassword.Text}
    '    If tbUserName.Text = My.Settings.UserName And
    '      tbPassword.Text = My.Settings.Password Then

    '        Form1.Show()
    '        Me.Hide()
    '    ElseIf tbUserName.Text = "" And
    '        tbPassword.Text = "" Then
    '        MsgBox("Enter your Login details", MsgBoxStyle.Critical, "Error")

    '    ElseIf tbUserName.Text = "" Then
    '        MsgBox("Enter your Username", MsgBoxStyle.Critical, "Error")
    '    ElseIf tbPassword.Text = "" Then
    '        MsgBox("Enter your password", MsgBoxStyle.Critical, "Error")

    '    Else
    '        MsgBox("Incorrect UserName or Password", MsgBoxStyle.Critical, "Error")
    '    End If
    'End Sub


End Class