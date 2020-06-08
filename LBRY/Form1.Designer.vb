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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ffMPEGPath = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PathToVideos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FileNameBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Path to LBRY"
        '
        'ffMPEGPath
        '
        Me.ffMPEGPath.Location = New System.Drawing.Point(132, 15)
        Me.ffMPEGPath.Name = "ffMPEGPath"
        Me.ffMPEGPath.Size = New System.Drawing.Size(393, 20)
        Me.ffMPEGPath.TabIndex = 21
        Me.ffMPEGPath.Text = """c:\Program Files\LBRY\resources\static\daemon\lbrynet.exe"""
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(324, 126)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 40)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Upload"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PathToVideos
        '
        Me.PathToVideos.Location = New System.Drawing.Point(132, 46)
        Me.PathToVideos.Name = "PathToVideos"
        Me.PathToVideos.Size = New System.Drawing.Size(393, 20)
        Me.PathToVideos.TabIndex = 30
        Me.PathToVideos.Text = "F:\Video\JSNIP4\JSNIp4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Path of videos"
        '
        'FileNameBox
        '
        Me.FileNameBox.Location = New System.Drawing.Point(167, 152)
        Me.FileNameBox.Name = "FileNameBox"
        Me.FileNameBox.Size = New System.Drawing.Size(72, 20)
        Me.FileNameBox.TabIndex = 33
        Me.FileNameBox.Text = "TS.TXT"
        Me.FileNameBox.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(132, 74)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(393, 20)
        Me.TextBox1.TabIndex = 35
        Me.TextBox1.Text = "80c77fa72bf4dc000876543dae37aa3d2e2af227"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Channel_ID"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(132, 126)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(161, 20)
        Me.TextBox2.TabIndex = 37
        Me.TextBox2.Text = "0.01"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Bid"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(132, 100)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(393, 20)
        Me.TextBox3.TabIndex = 39
        Me.TextBox3.Text = "News"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Tags"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(132, 152)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(29, 20)
        Me.TextBox4.TabIndex = 40
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(429, 127)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 39)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Save CFG"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 177)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FileNameBox)
        Me.Controls.Add(Me.PathToVideos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ffMPEGPath)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "LBRY Importer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ffMPEGPath As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PathToVideos As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FileNameBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
