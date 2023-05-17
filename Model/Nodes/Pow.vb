Imports System
Imports System.Collections.Generic

Namespace Isocline.Nodes
    Friend Class Pow
        Implements INode
        Private first As INode
        Private second As INode

        Public Sub New(ByVal first As INode, ByVal second As INode)
            Me.first = first
            Me.second = second
        End Sub

        Public Function Value(ByVal variables As Dictionary(Of String, Double)) As Double Implements INode.Value
            Dim newBase = first.Value(variables)
            Return Math.Pow(first.Value(variables), second.Value(variables))
        End Function
    End Class
End Namespace
