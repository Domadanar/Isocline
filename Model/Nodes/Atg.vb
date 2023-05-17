﻿Imports System
Imports System.Collections.Generic

Namespace Isocline.Nodes
    Friend Class Atg
        Implements INode
        Private valueField As INode

        Public Sub New(ByVal value As INode)
            valueField = value
        End Sub

        Public Function Value(ByVal variables As Dictionary(Of String, Double)) As Double Implements INode.Value
            Return Math.Atan(valueField.Value(variables))
        End Function
    End Class
End Namespace
