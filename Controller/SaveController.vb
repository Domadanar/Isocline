Imports Isocline.Model

Namespace Isocline.Controller
    Friend Class SaveController
        Private saveModel As SaveModel
        Public Sub New(ByVal saveModel As SaveModel)
            Me.saveModel = saveModel
        End Sub
        Public Sub SaveImage(ByVal filePath As String)
            saveModel.Save(filePath)
        End Sub
    End Class
End Namespace
