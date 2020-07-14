<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbDestinationIpAddress = New System.Windows.Forms.Label()
        Me.txbDestinationIpAddress = New System.Windows.Forms.TextBox()
        Me.txbTextToSend = New System.Windows.Forms.TextBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.bntClear = New System.Windows.Forms.Button()
        Me.btnContact = New System.Windows.Forms.Button()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblHour = New System.Windows.Forms.Label()
        Me.lbconnection = New System.Windows.Forms.Label()
        Me.lbStatus1 = New System.Windows.Forms.Label()
        Me.lblGetIP = New System.Windows.Forms.Label()
        Me.lbxConversation = New System.Windows.Forms.ListBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbDestinationIpAddress
        '
        Me.lbDestinationIpAddress.AutoSize = True
        Me.lbDestinationIpAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.lbDestinationIpAddress.Location = New System.Drawing.Point(37, 148)
        Me.lbDestinationIpAddress.Name = "lbDestinationIpAddress"
        Me.lbDestinationIpAddress.Size = New System.Drawing.Size(181, 20)
        Me.lbDestinationIpAddress.TabIndex = 5
        Me.lbDestinationIpAddress.Text = "Destination IP Address"
        '
        'txbDestinationIpAddress
        '
        Me.txbDestinationIpAddress.Location = New System.Drawing.Point(31, 192)
        Me.txbDestinationIpAddress.Name = "txbDestinationIpAddress"
        Me.txbDestinationIpAddress.Size = New System.Drawing.Size(249, 20)
        Me.txbDestinationIpAddress.TabIndex = 6
        '
        'txbTextToSend
        '
        Me.txbTextToSend.Location = New System.Drawing.Point(18, 442)
        Me.txbTextToSend.Multiline = True
        Me.txbTextToSend.Name = "txbTextToSend"
        Me.txbTextToSend.Size = New System.Drawing.Size(388, 136)
        Me.txbTextToSend.TabIndex = 7
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(421, 662)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(68, 23)
        Me.btnQuit.TabIndex = 10
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(18, 622)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(99, 622)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 20
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'bntClear
        '
        Me.bntClear.Location = New System.Drawing.Point(180, 622)
        Me.bntClear.Name = "bntClear"
        Me.bntClear.Size = New System.Drawing.Size(75, 23)
        Me.bntClear.TabIndex = 21
        Me.bntClear.Text = "Clear"
        Me.bntClear.UseVisualStyleBackColor = True
        '
        'btnContact
        '
        Me.btnContact.Location = New System.Drawing.Point(261, 622)
        Me.btnContact.Name = "btnContact"
        Me.btnContact.Size = New System.Drawing.Size(75, 23)
        Me.btnContact.TabIndex = 22
        Me.btnContact.Text = "Contact "
        Me.btnContact.UseVisualStyleBackColor = True
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Location = New System.Drawing.Point(576, 375)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(0, 13)
        Me.lblTimer.TabIndex = 23
        '
        'lblHour
        '
        Me.lblHour.AutoSize = True
        Me.lblHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.lblHour.Location = New System.Drawing.Point(36, 104)
        Me.lblHour.Name = "lblHour"
        Me.lblHour.Size = New System.Drawing.Size(0, 25)
        Me.lblHour.TabIndex = 24
        '
        'lbconnection
        '
        Me.lbconnection.AutoSize = True
        Me.lbconnection.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.lbconnection.Location = New System.Drawing.Point(36, 54)
        Me.lbconnection.Name = "lbconnection"
        Me.lbconnection.Size = New System.Drawing.Size(117, 25)
        Me.lbconnection.TabIndex = 25
        Me.lbconnection.Text = "connection"
        '
        'lbStatus1
        '
        Me.lbStatus1.AutoSize = True
        Me.lbStatus1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.lbStatus1.Location = New System.Drawing.Point(200, 54)
        Me.lbStatus1.Name = "lbStatus1"
        Me.lbStatus1.Size = New System.Drawing.Size(0, 29)
        Me.lbStatus1.TabIndex = 26
        '
        'lblGetIP
        '
        Me.lblGetIP.AutoSize = True
        Me.lblGetIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.lblGetIP.Location = New System.Drawing.Point(35, 9)
        Me.lblGetIP.Name = "lblGetIP"
        Me.lblGetIP.Size = New System.Drawing.Size(0, 31)
        Me.lblGetIP.TabIndex = 27
        '
        'lbxConversation
        '
        Me.lbxConversation.FormattingEnabled = True
        Me.lbxConversation.Location = New System.Drawing.Point(18, 265)
        Me.lbxConversation.Name = "lbxConversation"
        Me.lbxConversation.Size = New System.Drawing.Size(388, 147)
        Me.lbxConversation.TabIndex = 12
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(421, 544)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(49, 23)
        Me.btnSend.TabIndex = 9
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.unnamed
        Me.ClientSize = New System.Drawing.Size(504, 719)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txbTextToSend)
        Me.Controls.Add(Me.lbxConversation)
        Me.Controls.Add(Me.lbDestinationIpAddress)
        Me.Controls.Add(Me.lblGetIP)
        Me.Controls.Add(Me.txbDestinationIpAddress)
        Me.Controls.Add(Me.lbStatus1)
        Me.Controls.Add(Me.lbconnection)
        Me.Controls.Add(Me.lblHour)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.btnContact)
        Me.Controls.Add(Me.bntClear)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnQuit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbDestinationIpAddress As System.Windows.Forms.Label
    Friend WithEvents txbDestinationIpAddress As System.Windows.Forms.TextBox
    Friend WithEvents txbTextToSend As System.Windows.Forms.TextBox
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents bntClear As Button
    Friend WithEvents btnContact As Button
    Friend WithEvents lblTimer As Label
    Friend WithEvents lblHour As Label
    Friend WithEvents lbconnection As Label
    Friend WithEvents lbStatus1 As Label
    Friend WithEvents lblGetIP As Label
    Friend WithEvents lbxConversation As ListBox
    Friend WithEvents btnSend As Button
End Class
