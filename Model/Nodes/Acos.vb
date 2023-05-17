Imports System
Imports System.Collections.Generic

Namespace Isocline.Nodes
    Friend Class Acos
        Implements INode
        Private valueField As INode

        Public Sub New(ByVal value As INode)
            valueField = value
        End Sub

        Public Function Value(ByVal variables As Dictionary(Of String, Double)) As Double Implements INode.Value
            If valueField.Value(variables) >= -1 AndAlso valueField.Value(variables) <= 1 Then Return Math.Acos(valueField.Value(variables))
            Throw New Exception("Вне зоны определения")
        End Function
    End Class
End Namespace
