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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.kimyaT = New System.Windows.Forms.TextBox()
        Me.fizikT = New System.Windows.Forms.TextBox()
        Me.matT = New System.Windows.Forms.TextBox()
        Me.isimT = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ad Soyad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cinsiyet"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Matematik Notu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fizik Notu"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Kimya Notu"
        '
        'kimyaT
        '
        Me.kimyaT.Location = New System.Drawing.Point(152, 230)
        Me.kimyaT.Name = "kimyaT"
        Me.kimyaT.Size = New System.Drawing.Size(100, 20)
        Me.kimyaT.TabIndex = 5
        '
        'fizikT
        '
        Me.fizikT.Location = New System.Drawing.Point(152, 183)
        Me.fizikT.Name = "fizikT"
        Me.fizikT.Size = New System.Drawing.Size(100, 20)
        Me.fizikT.TabIndex = 6
        '
        'matT
        '
        Me.matT.Location = New System.Drawing.Point(152, 138)
        Me.matT.Name = "matT"
        Me.matT.Size = New System.Drawing.Size(100, 20)
        Me.matT.TabIndex = 7
        '
        'isimT
        '
        Me.isimT.Location = New System.Drawing.Point(152, 32)
        Me.isimT.Name = "isimT"
        Me.isimT.Size = New System.Drawing.Size(100, 20)
        Me.isimT.TabIndex = 9
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Erkek", "Kız"})
        Me.ComboBox1.Location = New System.Drawing.Point(152, 84)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 10
        Me.ComboBox1.Text = ","
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 312)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 70)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Öğrenci Ekle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(177, 312)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 70)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Ortalama Hesapla"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(336, 74)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(220, 342)
        Me.ListBox1.TabIndex = 13
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(571, 74)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(214, 342)
        Me.ListBox2.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(381, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Başarılı Erkek Öğrenciler"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(619, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Başarılı Kız Öğrenciler"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.isimT)
        Me.Controls.Add(Me.matT)
        Me.Controls.Add(Me.fizikT)
        Me.Controls.Add(Me.kimyaT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents kimyaT As TextBox
    Friend WithEvents fizikT As TextBox
    Friend WithEvents matT As TextBox
    Friend WithEvents isimT As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
