Imports System.Net
Imports System
Imports System.Net.Sockets
Imports System.Text.UTF8Encoding
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.Threading
Imports System.IO.Compression


Public Class Form1
    Dim openFileDialog1 As New OpenFileDialog()
    Private IncomingIPAddress As String 'function used privatley called IncomingIPAddress which has been declared as a string
    Private strReturnData As String   'used to determine the parameters of remote host connection

    Private thdUDPServer = New Thread(New ThreadStart(AddressOf ServerThread)) 'this is thread the code that makes it  thread starts at any subrountine that is assighned to (AddressOf ServerThread)

    Private strDataIn As String

    Private udpClient As New UdpClient(8080)
    ' connect to any IP address and any port
    Private RemoteIPEndPoint As New IPEndPoint(System.Net.IPAddress.Any, 0)
    'Public Property Timer1 As Object 


    Private Function GetNetworkStatus() As Boolean
        Dim blnStatus As Boolean
        ' get current network status from System.Net class
        blnStatus = NetworkInformation.NetworkInterface.GetIsNetworkAvailable

        Return blnStatus
    End Function

    'Private Sub btnCheckMyConnectivity_Click(sender As Object, e As EventArgs)
    '    ' call function to get current network status
    '    Dim blnStatus As Boolean = GetNetworkStatus()
    '    ' display result 
    '    lblCheckMyConnectivity.Text = blnStatus.ToString
    'End Sub

    Private Function GetMyIPAddress() As String
        Dim strIPAddress As String
        ' declare a container to store local IP information
        Dim ipHost As IPHostEntry
        ' populate ipHost with IP information and resolve host name
        ipHost = Dns.GetHostEntry(Dns.GetHostName)
        ' select first entry in AddressList assign to string 
        strIPAddress = ipHost.AddressList(0).ToString
        ' return IP address
        lblGetIP.Text = strIPAddress
        Return strIPAddress
    End Function

    'Private Sub btnGetMyIp_Click(sender As Object, e As EventArgs)
    '    'A container class for Internet host address information
    '    Dim strMyIPAddress As String = GetMyIPAddress()
    '    ' write IP address to the textbox 
    '    lblCheckMyConnectivity.Text = strMyIPAddress

    'End Sub

    Private Sub SendData()
        Dim strDesIP As String = txbDestinationIpAddress.Text
        ' connect via port 8080
        Dim intPort As Integer = 8080

        Dim SendingData As String = My.Settings.UserName & "^" & Now.ToString(" dd/MM/yy ") & "^" & Now.ToString("hh:mm:ss ") & "^" & txbTextToSend.Text
        'converting the string into an array of bytes using ascii encoding and storing the result in bytdata
        ' populate byte array with ASCII codes of message to send
        '   Dim bytASCIICodes() As Byte = System.Text.Encoding.ASCII.GetBytes(tbTypeMessage.Text)
        Dim byDataA() As Byte = System.Text.Encoding.ASCII.GetBytes(SendingData)
        Dim bytDataB() As Byte

        'Dim StrTo As String = "Me: " & tbDesIP.Text & " message: " & tbTypeMessage.Text 'declares strTo as a string in which the word to as well as the destination IP adress and the word message is added as well as the text that has been entered via the tbsend textbox
        ''lbxDisplayMessage.Items.Add(StrTo)
        If Not IPValidation(txbDestinationIpAddress.Text) Then
            MsgBox("Invalid IP")
        ElseIf txbTextToSend.Text = Nothing Then
            MsgBox("There is no message to send")


        Else
            'build a string by concatenating the username, date, time and message seperated by a carets
            'StrSendData = username & "^" & Now.ToString("dd/MM/yyyy") & "^" & Now.ToString("hh:mm:ss") & "^" & tbTypeMessage.Text
            ' lbxDisplayMessage.Items.Add("Me" & Now.ToString(" dd/MM/yy ") & Now.ToString("hh:mm:ss ") & tbTypeMessage.Text)
            lbxConversation.Items.Add(My.Settings.UserName & " says: " & txbTextToSend.Text)


            ' connect to selected IP address and port
            udpClient.Connect(strDesIP, intPort)


            ' send the message
            udpClient.Send(byDataA, byDataA.Length)
            txbTextToSend.Text = ""
        End If
        If byDataA.Length > 100 Then
            bytDataB = Compress(byDataA)
        Else
            bytDataB = byDataA

        End If
        MsgBox("compressed: " & vbCrLf & BitConverter.ToString(bytDataB)) ' the Visual Basic carriage return Line Feed returns the value of bydataB  converted into a string


        'MsgBox("Decompressed: " & vbCrLf & System.Text.Encoding.ASCII.GetString(bytDataB)) 'the Visual Basic carriage return Line Feed bydataB is the array recived  and converted in ASCII codes


    End Sub

    Private Sub ServerThread()

        While True
            ' create a dynamic byte array to store incoming ASCII codes
            Dim ByInBytes(), byDataD() As Byte
            ' read in incoming data from remote connection and store in the byte array
            ByInBytes = udpClient.Receive(RemoteIPEndPoint)

            strDataIn = System.Text.Encoding.ASCII.GetString(ByInBytes)
            MsgBox("This Message is compressed: " & vbCrLf & BitConverter.ToString(ByInBytes)) 'message that displays the message that was 

            'recived via the byte array ByInBytes

            '(this part of the code checks whateher or not the code is compressed)
            If iscompressed(ByInBytes) Then
                'MessageBox.Show("compressed")
                byDataD = Decompress(ByInBytes)
            Else

                byDataD = ByInBytes
            End If


            'MsgBox("Decompressed: " & vbCrLf & System.Text.Encoding.ASCII.GetString(byDataD)) 'bydataD is the array recived and is then converted into a string uscing ascII encoding which then displayed in the message preceded by the words decompressed 

            strReturnData = System.Text.Encoding.ASCII.GetString(byDataD) 'converts those bytes stores the result in a string

            AccessControl()
        End While
    End Sub
    Private Sub AccessControl()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf AccessControl)) 'this allows for an invoke for a call
        Else


            lbxConversation.Text = strDataIn
            IncomingIPAddress = RemoteIPEndPoint.Address.ToString 'check the ip adress of the machine that is conencted and stores the varibale of the Ipadress 

            MsgBox(strDataIn)

            Dim messageParts() As String
            messageParts = strDataIn.Split("^")
            Dim rerderedMessage As String = "At " & messageParts(2) & " on " & messageParts(1) & ", " & messageParts(0) & " said: " & messageParts(3)
            ' this is a dynamic array of strings becauase the number of feilds is unkown ie (), 
            'the fields of whcih will contian the elements of the caret split string
            'Dim Fields As String() = strReturnData.Split("^")

            'Name = tbName.Text

            'lbxDisplayMessage.Items.Add(Name & Now.ToString(" dd/mm/yy ") & Now.ToString("hh:mm:ss ") & strDataIn)
            lbxConversation.Items.Add(rerderedMessage)
        End If
    End Sub


    Private Function IPValidation(ByVal str As String) As Boolean 'this is a private function inwhich
        Dim octs As String() 'this line of code declares octs As a String array hic will hold the 4 parts of the ip address
        octs = str.Split(".") 'this splits the octets with the .character 
        If octs.Length <> 4 Then  'the Ip address in this case will be invalid if it is not in the format xxx.xxx.xxx.xxxx
            Return False

        Else
            Dim temp As Integer 'declears temp as integer

            For i = 0 To 3 'this for loop goes from 0 to 3 checking the octets 
                If Not Integer.TryParse(octs(i), temp) Then 'to check and test if a value is integer in the octet is and returns false
                    Return False
                ElseIf temp < 0 Or temp >= 255 Then 'validates the value of temp to be more than 0 or less
                    Return False
                End If
            Next

        End If
        Return True 'return values that that ars integers and between 0 to 255
    End Function

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        ' close udp connection
        udpClient.Close()
        ' remove from memory
        udpClient = Nothing
        ' exit application
        Application.Exit()
    End Sub
    ''Private Sub ReadData()
    '' create a dynamic byte array to store incoming ASCII codes
    'Dim bytDataIn() As Byte
    '    ' read in incoming data from remote connection and store in the byte array
    '    bytDataIn = udpClient.Receive(RemoteIPEndPoint)

    '    Dim strSendersIPAddress As String = RemoteIPEndPoint.Address.ToString

    '    ' convert ASCII codes byte array into a string 
    '    txbRead.Text = strSendersIPAddress & ": " & System.Text.Encoding.ASCII.GetString(bytDataIn)

    'End Sub


    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        SendData()
    End Sub

    'Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
    '    ReadData()
    'End Sub

    Sub saveHistory()
        Dim saveConversation As New StreamWriter(" conversation.txt")
        Dim i As Integer
        For i = 0 To lbxConversation.Items.Count - 1
            saveConversation.WriteLine(lbxConversation.Items(i))
        Next
        saveConversation.Close()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        saveHistory()
    End Sub

    Private Function Compress(ByVal Datain() As Byte) As Byte()
        'declares as memorystream which will be ulilised by the  GZipStream class in order to store the compressed data stream

        Dim ms As New MemoryStream
        'The first parameter details the stream which will be compressed or decompressed. 
        'The second parameter details the compression mode
        'The final parameter is a boolean value (True/False) that specifies whether the gZipStream will be left open or closed
        Dim gZipStream As New GZipStream(ms, CompressionMode.Compress, True)
        'the initial value if the datain should be pass onto in the parameter,start from 0 to the whole lenght
        gZipStream.Write(Datain, 0, Datain.Length)
        'dispose and close to release processor resources
        gZipStream.Dispose()
        gZipStream.Close()
        Return ms.ToArray

    End Function

    Private Function Decompress(ByVal Datain() As Byte) As Byte()

        Dim gZipStream As New GZipStream(New MemoryStream(Datain), CompressionMode.Decompress)
        Dim buffer(4095) As Byte
        Dim ms As New MemoryStream
        Dim count As Integer = 0

        Do
            count = gZipStream.Read(buffer, 0, buffer.Length)
            If count > 0 Then
                ms.Write(buffer, 0, count) 'Write to memorystream
            End If
        Loop While count > 0 'Loop while count integer is more than 0. 


        gZipStream.Dispose()
        gZipStream.Close()
        Return ms.ToArray
    End Function
    Private Function iscompressed(ByVal ba As Byte()) As Boolean
        Dim testbytes(3) As Byte
        'test the indivual charater to verify if they are compresses
        testbytes(0) = 0
        testbytes(1) = 120
        testbytes(2) = 5
        testbytes(3) = 10

        Dim i As Integer 'declared as integer
        For i = 0 To 3
            If ba(i) <> testbytes(i) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Timer = True
        'thdUDPServer.start()
        '' write IP address to the textbox 

        Dim IpHost As IPHostEntry = Dns.GetHostEntry(Dns.GetHostName())
        IpHost.AddressList = Array.FindAll(IpHost.AddressList, Function(n As IPAddress) n.AddressFamily = AddressFamily.InterNetwork)

        'CheckNetworkStatus() 'checks the network status to if if theres is any network connectivity
        Dim blnStatus As Boolean = NetworkInformation.NetworkInterface.GetIsNetworkAvailable
        'if statement to say if there is a connection and returns value based on the line of code (boolean chcek)
        If blnStatus = True Then
            lbStatus1.Text = "Online"
            lbStatus1.ForeColor = Color.Green 'changes the colour to green
        Else
            lbStatus1.Text = "Not Connection"
            lbStatus1.ForeColor = Color.Red ' changes the colour to red
        End If
        Dim strIPAddress As String


        IpHost.AddressList = Array.FindAll(IpHost.AddressList, Function(n As IPAddress) n.AddressFamily = AddressFamily.InterNetwork)

        strIPAddress = IpHost.AddressList(0).ToString

        lblGetIP.Text = "IP Address: " & strIPAddress
        lblHour.Text = Now.ToLongDateString

    End Sub



    Private Sub btnContact_Click(sender As Object, e As EventArgs) Handles btnContact.Click
        contact.Show()
        Me.Hide()
    End Sub

    Private Sub bntClear_Click(sender As Object, e As EventArgs) Handles bntClear.Click
        lbxConversation.Items.Clear() ' clears the listbox


        txbTextToSend.Text = "" 'removes anything in the send message
        txbDestinationIpAddress.Text = " " 'removes anything in the destination Ip address

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        OpenFileDialog1.ShowDialog()

        Dim r As New StreamReader(OpenFileDialog1.FileName)
        While (r.Peek() > -1)
            lbxConversation.Items.Add(r.ReadLine)

        End While
        r.Close()
    End Sub
End Class
