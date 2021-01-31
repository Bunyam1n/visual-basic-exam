Public Class Form3


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

    Dim k As Integer = 0
    Dim mus1 As Musteri

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FileOpen(2, Application.StartupPath & "\\musteri_kaydi.plt", OpenMode.Random, OpenAccess.Read, , 100)

        Do While Not EOF(2)
            k = k + 1
            FileGet(2, mus1, k)

            Me.DataGridView1.Rows.Add(mus1.no, mus1.isim, mus1.urunler.bm, mus1.urunler.cm, mus1.urunler.tv, mus1.urunler.supurge, mus1.urunler.bm, mus1.urunler.firin)
            MsgBox("İstenilen kayıt ekrana gelmiştir")
        Loop


        FileClose(2)

    End Sub
End Class