Imports ComponentFactory.Krypton.Toolkit
Imports System

Namespace Isocline.Controller
    Friend Class FunctionController
        Private box_fxy As KryptonTextBox
        Public Sub New(ByVal box_fxy As KryptonTextBox)
            Me.box_fxy = box_fxy
        End Sub
        Public Function FuncParser(ByVal experssion As String) As Func(Of Double, Double, Double)
            Dim f = FunctionParser.CreateFXY(box_fxy.Text)
            Return f
        End Function
    End Class
End Namespace
