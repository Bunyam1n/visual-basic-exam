Public Class Form1


    'Alınan ürün sayısını belirlemek için ürün structure ı oluşuturuyoruz
    Structure Urun

        Dim buzdolabi As Integer
        Dim cm As Integer
        Dim tv As Integer
        Dim supurge As Integer
        Dim firin As Integer
        Dim bm As Integer
        Function urunToplam()
            Dim total = buzdolabi + cm + tv + supurge + firin + bm
            Return total
        End Function
        Function fiyatToplam()
            Dim tot = (buzdolabi * 2000) + (cm * 1750) + (tv * 1250) + (supurge * 750) + (bm * 1500) + (firin * 1250)
            Return tot
        End Function

    End Structure

    Structure Musteri
        Dim isim As String
        Dim no As Integer
        Dim urunler As Urun
    End Structure


    Dim ur1 As Urun
    Dim mus1 As Musteri

    ' Alınan ürün sayısını artıran butonlar

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ur1.buzdolabi += 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ur1.cm += 1
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ur1.tv += 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ur1.supurge += 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ur1.bm += 1
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ur1.firin += 1
    End Sub


    ' Simsalasimbamba saladu saladim
    Dim kayitno As Integer = 1
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        mus1.isim = TextBox1.Text
        mus1.no = TextBox2.Text
        mus1.urunler = ur1


        FileOpen(1, Application.StartupPath & "\\musteri_kaydi.plt", OpenMode.Random, OpenAccess.ReadWrite)

        FilePut(1, mus1, kayitno)
        kayitno += 1
        FileClose(1)

        TextBox1.Clear()
        TextBox2.Clear()
        MsgBox("Veri Kaydı Başarıyla Tamamlandı")





    End Sub
End Class
