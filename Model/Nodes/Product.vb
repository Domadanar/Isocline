Imports System.Collections.Generic

Namespace Isocline.Nodes
    Friend Class Product
        Implements INode
        Private multipliers As List(Of INode)

        Public Sub New(ByVal multipliers As List(Of INode))
            Me.multipliers = multipliers
        End Sub

        Public Function Value(ByVal variables As Dictionary(Of String, Double)) As Double Implements INode.Value
            Dim result = 1.0

            For Each multiplier In multipliers
                result *= multiplier.Value(variables)
            Next

            Return result
        End Function
    End Class
End Namespace
