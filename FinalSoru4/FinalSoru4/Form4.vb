Public Class Form4
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim k As Integer = 0
        Dim mus1 As Musteri
        Dim topBuzdolabi As Integer = 0
        Dim topCM As Integer = 0
        Dim topTV As Integer = 0
        Dim topSupurge As Integer = 0
        Dim topBM As Integer = 0
        Dim topFirin As Integer = 0
        Dim topCiro As Integer = 0
        Dim topUrun As Integer = 0



        FileOpen(2, Application.StartupPath & "\\musteri_kaydi.plt", OpenMode.Random, OpenAccess.Read, , 100)

        Do While Not EOF(2) = True
            k = k + 1
            FileGet(2, mus1, k)
            topBuzdolabi = topBuzdolabi + mus1.urunler.buzdolabi
            topCM = topCM + mus1.urunler.cm
            topTV = topTV + mus1.urunler.tv
            topSupurge = topSupurge + mus1.urunler.supurge
            topBM = topBM + mus1.urunler.bm
            topFirin = topFirin + mus1.urunler.firin
            topCiro = topCiro + mus1.urunler.fiyatToplam
            topUrun = topUrun + mus1.urunler.urunToplam

        Loop

        FileClose(2)


        TextBox1.Text = topUrun
        TextBox2.Text = topBuzdolabi
        TextBox3.Text = topCM
        TextBox4.Text = topTV

        TextBox5.Text = topSupurge
        TextBox6.Text = topBM
        TextBox7.Text = topFirin
        TextBox8.Text = topCiro





    End Sub
End Class