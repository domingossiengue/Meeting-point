Public Class contact

    Private Sub contact_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub refress()
        lbxdisplayContacts.Items.Clear()
        For Each contacts As String In contactsList

            lbxdisplayContacts.Items.Add(contacts)
        Next
        lbxdisplayContacts.SelectedIndex = 0
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'check there 's text in both boxes
        If Not IPValidation(tbDestIPAdderss.Text) Then
            MsgBox("Invalid IP")
        Else
            contactsList.Add(tbname.Text & ":" & tbDestIPAdderss.Text)
            refress()


        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Dim remover As String() = lbxdisplayContacts.SelectedItem
        For Each remover As String In lbxdisplayContacts.SelectedItem
            lbxdisplayContacts.Items.Clear()

        Next

    End Sub

    Private Sub lbxdisplayContacts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxdisplayContacts.SelectedIndexChanged
        Dim line As String = lbxdisplayContacts.SelectedItem

        Dim parts As String() = line.split(":")


        tbname.Text = parts(0)
        tbDestIPAdderss.Text = parts(1)



    End Sub
End Class