Imports System.Windows.Forms

Namespace Isocline.Model
    Friend Class SaveModel
        Private picture As PictureBox
        Public Sub New(ByVal picture As PictureBox)
            Me.picture = picture
        End Sub

        Public Sub Save(ByVal filePath As String)
            picture.Image.Save(filePath)
        End Sub
    End Class
End Namespace
