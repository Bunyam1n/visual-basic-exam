Public Class Form1


    Structure Ogrenci

        Dim isim As String
        Dim cinsiyet As String
        Dim mat As Integer
        Dim fizik As Integer
        Dim kimya As Integer


    End Structure
    Dim ogrenciListe(99) As Ogrenci
    Dim index As Integer = 0



    Public Function ortHesapla() As Array
        Dim matToplam As Integer
        Dim fizToplam As Integer
        Dim kimToplam As Integer
        Dim sayac As Integer = 0

        For Each i As Ogrenci In ogrenciListe


            matToplam = matToplam + i.mat
            fizToplam = fizToplam + i.fizik
            kimToplam = kimToplam + i.kimya


            sayac = sayac + 1

        Next

        Dim ort(2) As Integer
        ort(0) = matToplam / sayac
        ort(1) = fizToplam / sayac
        ort(2) = kimToplam / sayac

        Return ort



    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim ogr As Ogrenci

        ogr.isim = isimT.Text
        ogr.cinsiyet = ComboBox1.SelectedItem
        ogr.fizik = fizikT.Text
        ogr.mat = matT.Text
        ogr.kimya = kimyaT.Text

        ogrenciListe(index) = ogr
        index = index + 1

        isimT.Clear()
        matT.Clear()
        fizikT.Clear()
        kimyaT.Clear()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim matToplam As Integer
        Dim fizToplam As Integer
        Dim kimToplam As Integer
        Dim sayac As Integer = 0

        For Each i As Ogrenci In ogrenciListe


            matToplam = matToplam + i.mat
            fizToplam = fizToplam + i.fizik
            kimToplam = kimToplam + i.kimya


            sayac = sayac + 1

        Next



        MsgBox("Sınıfın Matematik Ortalaması : " & matToplam / sayac & vbLf &
        "Sınıfın Fizik Ortalaması : " & fizToplam / sayac & vbLf &
        "Sınıfın Kimya Ortalaması : " & kimToplam / sayac & vbLf &
        "Genel Ortalama : " & (fizToplam + matToplam + kimToplam) / (sayac * 3))



        For Each i As Ogrenci In ogrenciListe

            If (i.mat + i.fizik + i.kimya) / 3 > (fizToplam + matToplam + kimToplam) / (sayac * 3) And i.cinsiyet = "Erkek" Then
                ListBox1.Items.Add(i.isim)

            End If
            If (i.mat + i.fizik + i.kimya) / 3 > (fizToplam + matToplam + kimToplam) / (sayac * 3) And i.cinsiyet = "Kız" Then
                ListBox2.Items.Add(i.isim)

            End If
        Next




    End Sub


End Class
