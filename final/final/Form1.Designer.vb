<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UserInput = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AdimSayisi = New System.Windows.Forms.TextBox()
        Me.MaksDeger = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "İlk Sayıyı Giriniz :"
        '
        'UserInput
        '
        Me.UserInput.Location = New System.Drawing.Point(148, 98)
        Me.UserInput.Name = "UserInput"
        Me.UserInput.Size = New System.Drawing.Size(149, 20)
        Me.UserInput.TabIndex = 11
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(351, 98)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(130, 407)
        Me.ListBox1.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(170, 134)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 32)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "BAŞLAT!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Adım Sayısı"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 307)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "En Büyük Değer:"
        '
        'AdimSayisi
        '
        Me.AdimSayisi.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.AdimSayisi.Location = New System.Drawing.Point(148, 214)
        Me.AdimSayisi.Name = "AdimSayisi"
        Me.AdimSayisi.Size = New System.Drawing.Size(100, 20)
        Me.AdimSayisi.TabIndex = 18
        '
        'MaksDeger
        '
        Me.MaksDeger.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.MaksDeger.Enabled = False
        Me.MaksDeger.HideSelection = False
        Me.MaksDeger.Location = New System.Drawing.Point(148, 307)
        Me.MaksDeger.Name = "MaksDeger"
        Me.MaksDeger.Size = New System.Drawing.Size(100, 20)
        Me.MaksDeger.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 521)
        Me.Controls.Add(Me.MaksDeger)
        Me.Controls.Add(Me.AdimSayisi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.UserInput)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents UserInput As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AdimSayisi As TextBox
    Friend WithEvents MaksDeger As TextBox
End Class
