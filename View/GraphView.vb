Imports Isocline.Controller
Imports System
Imports System.Windows.Forms
Imports ComponentFactory.Krypton.Toolkit
Imports System.Drawing

Namespace Isocline.View
    Friend Class GraphView
        Private graphController As GraphController
        Private functionController As FunctionController
        Private picture As PictureBox
        Private panel As KryptonPanel
        Private box_fxy As KryptonTextBox
        Private b_min As KryptonTextBox
        Private b_max As KryptonTextBox
        Private b_x As KryptonTextBox
        Private b_y As KryptonTextBox
        Public Sub New(ByVal picture As PictureBox, ByVal panel As KryptonPanel, ByVal box_fxy As KryptonTextBox, ByVal b_min As KryptonTextBox, ByVal b_max As KryptonTextBox, ByVal b_x As KryptonTextBox, ByVal b_y As KryptonTextBox, ByVal graphController As GraphController, ByVal functionController As FunctionController)
            Me.picture = picture
            Me.panel = panel
            Me.box_fxy = box_fxy
            Me.b_min = b_min
            Me.b_max = b_max
            Me.b_x = b_x
            Me.b_y = b_y
            Me.graphController = graphController
            Me.functionController = functionController
        End Sub

        Public Sub PrintGraph(ByVal sender As Object, ByVal args As EventArgs)
            Try
                picture.Width = panel.Width
                picture.Height = panel.Height
                Dim f = functionController.FuncParser(box_fxy.Text)
                Dim min = Double.Parse(b_min.Text)
                Dim max = Double.Parse(b_max.Text)
                Dim x0 = Double.Parse(b_x.Text)
                Dim y0 = Double.Parse(b_y.Text)

                picture.Image = graphController.CreateGraphImage(min, max, picture.Width, picture.Height, f, x0, y0)
            Catch __unusedException1__ As Exception
                '  Console.WriteLine(e.Message);
            End Try
        End Sub
        Public Sub Picture_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            prewmouspos = Cursor.Position
        End Sub

        Private prewmouspos As Point = New Point()

        Public Sub Picture_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            If e.Button = MouseButtons.Left Then
                picture.Location = New Point(picture.Location.X + (Cursor.Position.X - prewmouspos.X), picture.Location.Y + (Cursor.Position.Y - prewmouspos.Y))
                prewmouspos = Cursor.Position
            End If
        End Sub

        Public Sub Picture_MouseWheel(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim savedpicturepos = picture.Location
            If e.Delta > 0 Then
                If picture.Width + 50 <= 2000 AndAlso picture.Height + 50 <= 2000 Then
                    picture.Width = picture.Width + 50
                    picture.Height = picture.Height + 50
                    Dim x As Integer = panel.Width / 2 - picture.Width / 2
                    Dim y As Integer = panel.Height / 2 - picture.Height / 2

                    picture.Location = New Point(x, y)
                End If
            Else
                If picture.Width - 50 >= 950 AndAlso picture.Height - 50 >= 600 Then
                    picture.Width = picture.Width - 50
                    picture.Height = picture.Height - 50
                    Dim x As Integer = panel.Width / 2 - picture.Width / 2
                    Dim y As Integer = panel.Height / 2 - picture.Height / 2

                    picture.Location = New Point(x, y)
                End If
            End If
        End Sub

    End Class
End Namespace
