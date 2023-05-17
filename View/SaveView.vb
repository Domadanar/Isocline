Imports Isocline.Controller
Imports System
Imports System.Windows.Forms

Namespace Isocline.View
    Friend Class SaveView
        Private picture As PictureBox
        Private saveController As SaveController
        Public Sub New(ByVal picture As PictureBox, ByVal saveController As SaveController)
            Me.picture = picture
            Me.saveController = saveController
        End Sub

        Public Sub SaveButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            If picture.Image IsNot Nothing Then
                Dim sfd As SaveFileDialog = New SaveFileDialog()
                sfd.Title = "Зберегти зображення як..."
                sfd.OverwritePrompt = True
                sfd.CheckPathExists = True
                sfd.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.PNG)|*.PNG|All files(*.*)|*.*"
                sfd.ShowHelp = True

                If sfd.ShowDialog() = DialogResult.OK Then
                    Try
                        saveController.SaveImage(sfd.FileName)
                    Catch
                        MessageBox.Show("Неможливо зберегти зображення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If

            End If
        End Sub
    End Class
End Namespace
