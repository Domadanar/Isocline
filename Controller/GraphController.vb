Imports System
Imports System.Drawing

Namespace Isocline.Controller
    Friend Class GraphController
        Public Function CreateGraphImage(ByVal min As Double, ByVal max As Double, ByVal width As Integer, ByVal height As Integer, ByVal f As Func(Of Double, Double, Double), ByVal x0 As Double, ByVal y0 As Double) As Image
            Dim gm = New GraphMaster(min, max)
            Return gm.CreateGraph(width, height, Sub(g) gm.DrawSolution(g, f, x0, y0))
        End Function
    End Class
End Namespace
