Imports System

Namespace Isocline
    Public Class FunctionExstensions
        Private Shared delta As Double = Math.Pow(10, -5)

        Public Shared Function df_dx(ByVal f As Func(Of Double, Double)) As Func(Of Double, Double)
            Return Function(x) (f(x + delta / 2) - f(x - delta / 2)) / delta
        End Function

        Public Shared Function Grad(ByVal f As Func(Of Double, Double, Double)) As Func(Of Double, Double, Tuple(Of Double, Double))

            Return Function(x, y) Tuple.Create((f(x + delta / 2, y) - f(x - delta / 2, y)) / delta, (f(x, y + delta / 2) - f(x, y - delta / 2)) / delta)
        End Function



        Public Shared Function Norm(ByVal p As Tuple(Of Double, Double)) As Tuple(Of Double, Double)
            Dim length = Math.Sqrt(p.Item1 * p.Item1 + p.Item2 * p.Item2)
            Return Tuple.Create(p.Item1 / length, p.Item2 / length)
        End Function
    End Class
End Namespace
