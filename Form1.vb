Imports System
Imports System.Drawing
Imports ComponentFactory.Krypton.Toolkit
Imports Isocline.View
Imports Isocline.Controller
Imports Isocline.Model

Namespace Isocline
    Public Partial Class Form1
        Inherits KryptonForm
        Private graphView As GraphView
        Private saveView As SaveView
        Private helpView As HelpView

        Private saveModel As SaveModel

        Private functionController As FunctionController
        Private graphController As GraphController
        Private saveController As SaveController

        Public Sub New()
            InitializeComponent()
            'Model
            saveModel = New SaveModel(picture)
            'Controller
            graphController = New GraphController()
            saveController = New SaveController(saveModel)
            functionController = New FunctionController(box_fxy)
            'View
            graphView = New GraphView(picture, panel, box_fxy, b_min, b_max, b_x, b_y, graphController, functionController)
            saveView = New SaveView(picture, saveController)
            helpView = New HelpView()

            graphView.PrintGraph(Nothing, Nothing)
            AddHandler Resize, AddressOf graphView.PrintGraph
            AddHandler button.Click, AddressOf graphView.PrintGraph
            AddHandler saveButton.Click, AddressOf saveView.SaveButtonClick
            AddHandler helpButton.Click, AddressOf helpView.HelpButton_Click
            AddHandler picture.MouseWheel, AddressOf graphView.Picture_MouseWheel
            AddHandler picture.MouseMove, AddressOf graphView.Picture_MouseMove
            AddHandler picture.MouseDown, AddressOf graphView.Picture_MouseDown
            AddHandler button1.Click, AddressOf ShowDirectionField
        End Sub
        Private Sub ShowDirectionField(ByVal sender As Object, ByVal e As EventArgs)
            ' Создайте объект графики для элемента PictureBox
            Dim graphics As Graphics = picture.CreateGraphics()
            Dim f = functionController.FuncParser(box_fxy.Text)
            Dim min = Double.Parse(b_min.Text)
            Dim max = Double.Parse(b_max.Text)
            ' Определите параметры сетки и шаг для создания поля направлений
            Dim xMin As Double = -5 ' Минимальное значение координаты X
            Dim xMax As Double = 5 ' Максимальное значение координаты X
            Dim yMin As Double = -5 ' Минимальное значение координаты Y
            Dim yMax As Double = 5 ' Максимальное значение координаты Y
            Dim stepX = 0.5 ' Шаг по координате X
            Dim stepY = 0.5 ' Шаг по координате Y
            Dim arrowLength = 0.4 ' Длина стрелки для отображения поля направлений

            ' Проходите по координатам каждой точки на графике
            Dim x = xMin

            While x <= xMax
                Dim y = yMin

                While y <= yMax
                    Dim gradient = FunctionExstensions.Grad(f)(x, y)

                    ' Нормализуйте вектор градиента
                    Dim norm = FunctionExstensions.Norm(gradient)

                    ' Умножьте нормализованный вектор градиента на длину стрелки
                    Dim arrowX = norm.Item1 * arrowLength
                    Dim arrowY = norm.Item2 * arrowLength

                    ' Определите координаты начала и конца стрелки
                    Dim startX = x + arrowX / 2
                    Dim startY = y + arrowY / 2
                    Dim endX = x - arrowX / 2
                    Dim endY = y - arrowY / 2

                    ' Нарисуйте линию или стрелку, представляющую поле направлений
                    graphics.DrawLine(Pens.Black, Transform(CSng(startX), CSng(startY)), Transform(CSng(endX), CSng(endY)))
                    y += stepY
                End While

                x += stepX
            End While
        End Sub
        Public Function Transform(ByVal x As Double, ByVal y As Double) As Point
            Dim min = Double.Parse(b_min.Text)
            Dim max = Double.Parse(b_max.Text)
            Return New Point((x + (max - min) / 2) / (max - min) * picture.Width, (-y + (max - min) / 2) / (max - min) * picture.Height)
        End Function
        Private Sub Form1_Load_1(ByVal sender As Object, ByVal e As EventArgs)

        End Sub


    End Class
End Namespace
