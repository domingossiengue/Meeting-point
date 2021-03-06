﻿Imports System.IO 'Import file I/O tools
Imports System.Security.Cryptography 'Import encryption functionality
Imports System.Text 'Import text based processing tools

Public Class CreateUser



    
    

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
    Private Sub createUser()
        If tbUsername.Text <> "" And tbpassword.Text <> "" Then

            'save firstname and second name
            FileOpen(1, "firstname.txt", OpenMode.Output)
            PrintLine(1, tbUsername.Text)

            'close firstname and second name
            FileClose(1)

            'encrypt password and convert to string
            Dim Userpassword As String = StringtoMD5(tbpassword.Text)


            'array to store username and password
            Dim createUser(1) As String
            'store username
            createUser(0) = tbUsername.Text
            'store encrypted password
            createUser(1) = Userpassword

            'join username and password using a . delimiter
            Dim result As String = String.Join(".", createUser)

            'function to write username and password to text file
            Using writer As StreamWriter =
            New StreamWriter("login.txt", True)
                'write username 
                writer.Write(result + vbNewLine)

            End Using

            'empty the firstname, secondname, username and password field when create user is clicked
            tbUsername.Text = ""
            tbpassword.Text = ""
            'hide current window and show login
            Me.Hide()
            LoginForm.Show()
        Else
            MessageBox.Show("Please fill in every input box!")
        End If


    End Sub
    Private Function GenerateHash() As Byte()
        Dim ByteArray() As Byte 'byte array created to hold hash data
        Dim sha1Hash As New SHA1CryptoServiceProvider 'Sha1 declared to provide the crypto services
        ByteArray = sha1Hash.ComputeHash(Encoding.ASCII.GetBytes(tbPassword.Text & tbUserName.Text))
        'this uses the computehash method of the SHA1CryptoServiceProvider and accept accepts the password and username as bytes
        '
        Return ByteArray

    End Function
    

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        createUser()
    End Sub


End Class