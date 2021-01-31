Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim sayi, stepNumber, x As Integer


        stepNumber = 1


        sayi = UserInput.Text


        ListBox1.Items.Add(sayi)


        While sayi <> 1


            stepNumber = stepNumber + 1


            If sayi Mod 2 = 0 Then


                sayi = sayi / 2


                ListBox1.Items.Add(sayi)


            Else


                sayi = sayi * 3 + 1


                ListBox1.Items.Add(sayi)


            End If


        End While


        AdimSayisi.Text = stepNumber



        x = ListBox1.Items(0)


        For i = 1 To stepNumber - 1


            If x < ListBox1.Items(i) Then


                x = ListBox1.Items(i)


            End If


        Next


        MaksDeger.Text = x










    End Sub


End Class
