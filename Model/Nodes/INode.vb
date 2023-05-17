Imports System.Collections.Generic

Namespace Isocline.Nodes
    Public Interface INode
        Function Value(ByVal Optional variables As Dictionary(Of String, Double) = Nothing) As Double
    End Interface
End Namespace
