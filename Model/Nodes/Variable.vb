Imports System
Imports System.Collections.Generic

Namespace Isocline.Nodes
    Friend Class Variable
        Implements INode
        Private name As String

        Public Sub New(ByVal name As String)
            Me.name = name
        End Sub

        Public Function Value(ByVal variables As Dictionary(Of String, Double)) As Double Implements INode.Value
            If variables.ContainsKey(name) Then Return variables(name)

            Throw New Exception("Переданно недостаточно переменных")
        End Function
    End Class
End Namespace
