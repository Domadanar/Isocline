Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace Isocline
    Friend Class GraphMaster
        Private min As Double = -10
        Private max As Double = 10
        Private width As Integer
        Private height As Integer
        Private Shared font As Font = New Font("Times New Roman", 14)
        Private picture As PictureBox
        Public Sub New(ByVal _min As Double, ByVal _max As Double)
            min = _min
            max = _max
        End Sub

        Public Function CreateGraph(ByVal w As Integer, ByVal h As Integer, ByVal drawing As Action(Of Graphics)) As Image
            width = w
            height = h
            Dim bmp = New Bitmap(w, h)
            Using g = Graphics.FromImage(bmp)
                g.FillRectangle(Brushes.White, 0, 0, w, h)
                drawing(g)
                DrawCoord(g)
            End Using
            Return bmp
        End Function

        Private Sub DrawCoord(ByVal g As Graphics)
            g.DrawLine(Pens.Black, Transform(0, min), Transform(0, max))
            g.DrawLine(Pens.Black, Transform(min, 0), Transform(max, 0))
            Dim [step] = (max - min) / 20
            Dim i = min

            While i < max
                g.DrawString(String.Format("{0}", Math.Round(i, 2)), font, Brushes.Black, Transform(0, i))
                g.DrawString(String.Format("{0}", Math.Round(i, 2)), font, Brushes.Black, Transform(i, 0))
                i += [step]
            End While
        End Sub

        Public Function Transform(ByVal x As Double, ByVal y As Double) As Point

            Return New Point((x + (max - min) / 2) / (max - min) * width, (-y + (max - min) / 2) / (max - min) * height)
        End Function

        Public Sub DrawSolution(ByVal g As Graphics, ByVal dy As Func(Of Double, Double, Double), ByVal x0 As Double, ByVal y0 As Double)
            Dim x = x0, y = y0
            Dim [step] = 0.001 ' Adjust the step size as needed

            While x <= max
                Dim k1 = [step] * dy(x, y)
                Dim k2 = [step] * dy(x + 0.5 * [step], y + 0.5 * k1)
                Dim k3 = [step] * dy(x + 0.5 * [step], y + 0.5 * k2)
                Dim k4 = [step] * dy(x + [step], y + k3)

                Dim nx = x + [step]
                Dim ny = y + (k1 + 2 * k2 + 2 * k3 + k4) / 6

                Try
                    g.DrawLine(Pens.Black, Transform(x, y), Transform(nx, ny))
                Catch
                End Try

                x = nx
                y = ny
            End While

            x = x0
            y = y0

            While x >= min
                Dim k1 = [step] * dy(x, y)
                Dim k2 = [step] * dy(x - 0.5 * [step], y - 0.5 * k1)
                Dim k3 = [step] * dy(x - 0.5 * [step], y - 0.5 * k2)
                Dim k4 = [step] * dy(x - [step], y - k3)

                Dim nx = x - [step]
                Dim ny = y - (k1 + 2 * k2 + 2 * k3 + k4) / 6

                Try
                    g.DrawLine(Pens.Black, Transform(x, y), Transform(nx, ny))
                Catch
                End Try

                x = nx
                y = ny
            End While
        End Sub

    End Class
End Namespace
