Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim sayi As Integer
		Dim toplam As Integer
		Dim i As Integer

		sayi = TextBox1.Text


		For i = 1 To sayi
			If sayi Mod i = 0 Then
				toplam = toplam + i
			End If
		Next i

		If toplam / 2 = sayi Then
			MsgBox("Mükemmel")
		Else
			MsgBox("Mükemmel değil")
		End If
	End Sub
End Class
