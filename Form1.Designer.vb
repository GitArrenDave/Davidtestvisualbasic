<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnupdatemissing = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnsendmail = New System.Windows.Forms.Button()
        Me.senderemailaddress = New System.Windows.Forms.TextBox()
        Me.ccmailadress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnupdatemissing
        '
        Me.btnupdatemissing.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnupdatemissing.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnupdatemissing.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnupdatemissing.Location = New System.Drawing.Point(200, 200)
        Me.btnupdatemissing.Name = "btnupdatemissing"
        Me.btnupdatemissing.Size = New System.Drawing.Size(220, 100)
        Me.btnupdatemissing.TabIndex = 1
        Me.btnupdatemissing.Text = "detect update problem"
        Me.btnupdatemissing.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(12, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1539, 39)
        Me.TextBox1.TabIndex = 3
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(1577, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 41)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "select group"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnsendmail
        '
        Me.btnsendmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsendmail.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnsendmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnsendmail.Location = New System.Drawing.Point(1355, 200)
        Me.btnsendmail.Name = "btnsendmail"
        Me.btnsendmail.Size = New System.Drawing.Size(220, 100)
        Me.btnsendmail.TabIndex = 5
        Me.btnsendmail.Text = "Help"
        Me.btnsendmail.UseVisualStyleBackColor = False
        '
        'senderemailaddress
        '
        Me.senderemailaddress.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.senderemailaddress.Location = New System.Drawing.Point(735, 173)
        Me.senderemailaddress.Name = "senderemailaddress"
        Me.senderemailaddress.Size = New System.Drawing.Size(320, 31)
        Me.senderemailaddress.TabIndex = 6
        Me.senderemailaddress.Text = "sender email address"
        '
        'ccmailadress
        '
        Me.ccmailadress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ccmailadress.Location = New System.Drawing.Point(735, 310)
        Me.ccmailadress.Name = "ccmailadress"
        Me.ccmailadress.Size = New System.Drawing.Size(320, 31)
        Me.ccmailadress.TabIndex = 7
        Me.ccmailadress.Text = "write mail address in cc"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(671, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "from:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(694, 310)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "cc:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1778, 514)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ccmailadress)
        Me.Controls.Add(Me.senderemailaddress)
        Me.Controls.Add(Me.btnsendmail)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnupdatemissing)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mailgenerater"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnupdatemissing As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents btnsendmail As Button
    Friend WithEvents senderemailaddress As TextBox
    Friend WithEvents ccmailadress As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
