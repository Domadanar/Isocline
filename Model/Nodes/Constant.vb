Imports System.Collections.Generic

Namespace Isocline.Nodes
    Friend Class Constant
        Implements INode
        Private valueField As Double

        Public Sub New(ByVal value As Double)
            valueField = value
        End Sub

        Public Function Value(ByVal variables As Dictionary(Of String, Double)) As Double Implements INode.Value
            Return valueField
        End Function
    End Class
End Namespace
