Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Linq
Imports Isocline.Nodes

Namespace Isocline
    Public Class FunctionParser

        Public Shared Function CreateFX(ByVal experssion As String) As Func(Of Double, Double)
            Dim node = Parse(experssion)
            Return Function(ByVal x)
                       Dim dict = New Dictionary(Of String, Double)() From {
                                  {"x", x}
                              }
                       Return node.Value(dict)
                   End Function
        End Function

        Public Shared Function CreateFXY(ByVal experssion As String) As Func(Of Double, Double, Double)
            Dim node = Parse(experssion)
            Return Function(ByVal x, ByVal y)
                       Dim dict = New Dictionary(Of String, Double)() From {
                              {"x", x},
                              {"y", y}
                          }
                       Return node.Value(dict)
                   End Function
        End Function

        Public Shared Function Parse(ByVal expression As String) As INode
            Dim isUnaryMinus = True
            Dim statements = New Stack(Of INode)()
            Dim operations = New Stack(Of String)()

            Dim i = 0

            While i < expression.Length
                If IsOperation(expression, i) Then
                    Dim operation = GetOperation(expression, i)
                    If Equals(operation, "-") AndAlso isUnaryMinus Then
                        operations.Push("-?")
                        Continue While
                    End If
                    While operations.Any() AndAlso Priority(operations.Peek()) >= Priority(operation)
                        Dim operationName = operations.Pop()
                        statements.Push(CreateOperation(operationName, statements))
                    End While
                    operations.Push(operation)
                ElseIf Char.IsDigit(expression(i)) Then
                    statements.Push(GetNumber(expression, i))
                ElseIf Char.IsLetter(expression(i)) Then
                    If IsConstant(expression, i) Then
                        Dim constantName = GetConst(expression, i)
                        statements.Push(CreateConstant(constantName))
                    Else
                        statements.Push(GetVariable(expression, i))
                    End If
                ElseIf expression(i) = "("c Then
                    operations.Push("(")
                    isUnaryMinus = True
                    i += 1
                    Continue While
                ElseIf expression(i) = ")"c Then
                    While Not Equals(operations.Peek(), "(")
                        Dim operationName = operations.Pop()
                        statements.Push(CreateOperation(operationName, statements))
                    End While
                    operations.Pop()
                    i += 1
                ElseIf expression(i) = ","c Then
                    While Not Equals(operations.Peek(), "(")
                        Dim operationName = operations.Pop()
                        statements.Push(CreateOperation(operationName, statements))
                    End While
                    i += 1
                Else
                    i += 1
                End If

                isUnaryMinus = False
            End While



            Return DeployStack(statements, operations)
        End Function

        Private Shared Function DeployStack(ByVal statements As Stack(Of INode), ByVal operations As Stack(Of String)) As INode
            While operations.Any()
                Dim operationName = operations.Pop()
                statements.Push(CreateOperation(operationName, statements))
            End While

            If statements.Count() = 1 Then Return statements.Pop()

            Throw New Exception("Too few operators")
        End Function

        Private Shared Function CreateConstant(ByVal constantName As String) As INode
            Select Case constantName
                Case "e"
                    Return New Constant(Math.E)
                Case "pi"
                    Return New Constant(Math.PI)
            End Select
            Throw New Exception("Wrong constant")
        End Function

        Private Shared Function CreateOperation(ByVal operationName As String, ByVal statements As Stack(Of INode)) As INode
            Select Case operationName
                Case "+"
                    Return New Sum(statements.Pop(), statements.Pop())
                Case "*"
                    Return New Multiplication(statements.Pop(), statements.Pop())
                Case "/"
                    Dim divider = statements.Pop()
                    Return New Segmentation(statements.Pop(), divider)
                Case "-"
                    Dim subtrhend = statements.Pop()
                    Return New Subtraction(statements.Pop(), subtrhend)
                Case "-?"
                    Return New UnaryMinus(statements.Pop())
                Case "sin"
                    Return New Sin(statements.Pop())
                Case "cos"
                    Return New Cos(statements.Pop())
                Case "tg"
                    Return New Tg(statements.Pop())
                Case "asin"
                    Return New Asin(statements.Pop())
                Case "acos"
                    Return New Acos(statements.Pop())
                Case "atg"
                    Return New Atg(statements.Pop())
                Case "ctg"
                    Return New Ctg(statements.Pop())
                Case "actg"
                    Return New Actg(statements.Pop())
                Case "^"
                    Dim degree = statements.Pop()
                    Return New Pow(statements.Pop(), degree)
                Case "log"
                    Dim newBase = statements.Pop()
                    Return New Log(statements.Pop(), newBase)
            End Select

            Throw New Exception("Wrong operation")
        End Function

        Private Shared consts As String() = {"e", "pi"}

        Private Shared operators As String() = {"+", "-", "*", "/", "sin", "cos", "tg", "ctg", "asin", "acos", "atg", "actg", "^", "log"}


        Private Shared Function IsConstant(ByVal expression As String, ByVal i As Integer) As Boolean
            Return consts.Any(Function(cnst) i + cnst.Length <= expression.Length AndAlso String.Equals(expression.Substring(i, cnst.Length), cnst))
        End Function
        Private Shared Function IsOperation(ByVal expression As String, ByVal i As Integer) As Boolean
            Return operators.Any(Function(op) i + op.Length <= expression.Length AndAlso String.Equals(expression.Substring(i, op.Length), op))
        End Function

        Private Shared Function GetConst(ByVal expression As String, ByRef i As Integer) As String
            Dim position = i
            Dim result = consts.First(Function(cnst) position + cnst.Length <= expression.Length AndAlso String.Equals(expression.Substring(position, cnst.Length), cnst))

            i += result.Length

            Return result
        End Function

        Private Shared Function GetOperation(ByVal expression As String, ByRef i As Integer) As String
            Dim position = i
            Dim result = operators.First(Function(op) position + op.Length <= expression.Length AndAlso String.Equals(expression.Substring(position, op.Length), op))
            i += result.Length

            Return result
        End Function

        Private Shared Function GetNumber(ByVal expression As String, ByRef i As Integer) As Constant
            Dim position = i
            While i < expression.Length AndAlso (Char.IsDigit(expression(i)) OrElse expression(i) = "."c)
                i += 1
            End While

            Dim number = expression.Substring(position, i - position)

            Return New Constant(Double.Parse(number, CultureInfo.InvariantCulture))
        End Function

        Private Shared Function GetVariable(ByVal expression As String, ByRef i As Integer) As Variable
            Dim position = i
            While i < expression.Length AndAlso Char.IsLetter(expression(i))
                i += 1
            End While

            Dim variableName = expression.Substring(position, i - position)

            Return New Variable(variableName)
        End Function

        Private Shared Priority As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer) From {
{"+", 0},
{"*", 1},
{"-", 0},
{"/", 1},
                              {"(", -1},
{"-?", 3},
{"^", 2},
{"sin", 4},
                              {"cos", 4},
{"tg", 4},
{"ctg", 4},
{"asin", 4},
                              {"acos", 4},
{"atg", 4},
{"actg", 4},
{"log", 4}
}
    End Class
End Namespace
