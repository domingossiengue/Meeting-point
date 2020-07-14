<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class contact
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lbxdisplayContacts = New System.Windows.Forms.ListBox()
        Me.tbDestIPAdderss = New System.Windows.Forms.TextBox()
        Me.tbname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button2.Location = New System.Drawing.Point(142, 532)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 34)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button3.Location = New System.Drawing.Point(261, 532)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 34)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lbxdisplayContacts
        '
        Me.lbxdisplayContacts.FormattingEnabled = True
        Me.lbxdisplayContacts.Location = New System.Drawing.Point(12, 12)
        Me.lbxdisplayContacts.Name = "lbxdisplayContacts"
        Me.lbxdisplayContacts.Size = New System.Drawing.Size(120, 329)
        Me.lbxdisplayContacts.TabIndex = 1
        '
        'tbDestIPAdderss
        '
        Me.tbDestIPAdderss.Location = New System.Drawing.Point(142, 460)
        Me.tbDestIPAdderss.Name = "tbDestIPAdderss"
        Me.tbDestIPAdderss.Size = New System.Drawing.Size(211, 20)
        Me.tbDestIPAdderss.TabIndex = 2
        '
        'tbname
        '
        Me.tbname.Location = New System.Drawing.Point(125, 404)
        Me.tbname.Name = "tbname"
        Me.tbname.Size = New System.Drawing.Size(211, 20)
        Me.tbname.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label1.Location = New System.Drawing.Point(12, 460)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Destination Ip"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(12, 404)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name"
        '
        'contact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.unnamed
        Me.ClientSize = New System.Drawing.Size(396, 695)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbname)
        Me.Controls.Add(Me.tbDestIPAdderss)
        Me.Controls.Add(Me.lbxdisplayContacts)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Name = "contact"
        Me.Text = "contact"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents lbxdisplayContacts As ListBox
    Friend WithEvents tbDestIPAdderss As TextBox
    Friend WithEvents tbname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
