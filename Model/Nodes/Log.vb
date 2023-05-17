Imports System
Imports System.Collections.Generic

Namespace Isocline.Nodes
    Friend Class Log
        Implements INode
        Private first As INode
        Private second As INode

        Public Sub New(ByVal first As INode, ByVal second As INode)
            Me.first = first
            Me.second = second
        End Sub

        Public Function Value(ByVal variables As Dictionary(Of String, Double)) As Double Implements INode.Value
            Dim lValue = first.Value(variables)
            Dim newBase = second.Value(variables)
            If newBase < 0 Then Throw New Exception("Отрицательное основание")
            If newBase = 1 Then Throw New Exception("Основание равно единице")
            If lValue < 0 Then Throw New Exception("Логарифм от отрицательного числа")

            Return Math.Log(first.Value(variables), second.Value(variables))
        End Function
    End Class
End Namespace
