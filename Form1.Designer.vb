Namespace Isocline
    Partial Class Form1
        ''' <summary>
        ''' Обязательная переменная конструктора.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Освободить все используемые ресурсы.
        ''' </summary>
        ''' <paramname="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Код, автоматически созданный конструктором форм Windows"

        ''' <summary>
        ''' Требуемый метод для поддержки конструктора — не изменяйте 
        ''' содержимое этого метода с помощью редактора кода.
        ''' </summary>
        Private Sub InitializeComponent()
            components = New ComponentModel.Container()
            panel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
            picture = New Windows.Forms.PictureBox()
            box_fxy = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
            kryptonPalette1 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(components)
            button = New ComponentFactory.Krypton.Toolkit.KryptonButton()
            b_min = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
            b_max = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
            b_x = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
            b_y = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
            saveButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
            helpButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
            button1 = New Windows.Forms.Button()
            CType(panel, ComponentModel.ISupportInitialize).BeginInit()
            panel.SuspendLayout()
            CType(picture, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' panel
            ' 
            panel.AutoScroll = True
            panel.Controls.Add(picture)
            panel.Location = New Drawing.Point(223, 12)
            panel.Name = "panel"
            panel.Size = New Drawing.Size(699, 537)
            panel.TabIndex = 0
            ' 
            ' picture
            ' 
            picture.Location = New Drawing.Point(3, 3)
            picture.Name = "picture"
            picture.Size = New Drawing.Size(693, 531)
            picture.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            picture.TabIndex = 0
            picture.TabStop = False
            ' 
            ' box_fxy
            ' 
            box_fxy.Location = New Drawing.Point(12, 56)
            box_fxy.Name = "box_fxy"
            box_fxy.Size = New Drawing.Size(160, 36)
            box_fxy.StateCommon.Back.Color1 = Drawing.Color.White
            box_fxy.StateCommon.Border.Color1 = Drawing.Color.FromArgb(224, 224, 224)
            box_fxy.StateCommon.Border.Color2 = Drawing.Color.FromArgb(224, 224, 224)
            box_fxy.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right

            box_fxy.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
            box_fxy.StateCommon.Border.Rounding = 20
            box_fxy.StateCommon.Border.Width = 1
            box_fxy.StateCommon.Content.Color1 = Drawing.Color.FromArgb(64, 64, 64)
            box_fxy.StateCommon.Content.Font = New Drawing.Font("Poppins", 9F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 238)
            box_fxy.StateCommon.Content.Padding = New Windows.Forms.Padding(10, 0, 10, 0)
            box_fxy.TabIndex = 1
            box_fxy.Tag = ""
            box_fxy.Text = "Введіть фінкцію:"
            ' 
            ' kryptonPalette1
            ' 
            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = Drawing.Color.FromArgb(250, 252, 252)
            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = Drawing.Color.FromArgb(250, 252, 252)
            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right

            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0
            kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = Drawing.Color.FromArgb(250, 252, 252)
            kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = Drawing.Color.FromArgb(250, 252, 252)
            kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right

            kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = Drawing.Color.FromArgb(250, 252, 252)
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = Drawing.Color.FromArgb(250, 252, 252)
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right

            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0
            kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color1 = Drawing.Color.FromArgb(250, 252, 252)
            kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color2 = Drawing.Color.FromArgb(250, 252, 252)
            kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right

            kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Border.Width = 0
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = Drawing.Color.FromArgb(250, 252, 252)
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = Drawing.Color.FromArgb(250, 252, 252)
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = Drawing.Color.FromArgb(250, 252, 252)
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right

            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Drawing.Color.FromArgb(250, 252, 252)
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Drawing.Color.FromArgb(250, 252, 252)
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = New Windows.Forms.Padding(10, -1, -1, -1)
            ' 
            ' button
            ' 
            button.Location = New Drawing.Point(17, 182)
            button.Name = "button"
            button.OverrideDefault.Back.Color1 = Drawing.Color.FromArgb(6, 174, 244)
            button.OverrideDefault.Back.Color2 = Drawing.Color.FromArgb(8, 142, 254)
            button.OverrideDefault.Back.ColorAngle = 45F
            button.OverrideDefault.Border.Color1 = Drawing.Color.FromArgb(6, 174, 244)
            button.OverrideDefault.Border.Color2 = Drawing.Color.FromArgb(8, 142, 254)
            button.OverrideDefault.Border.ColorAngle = 45F
            button.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right

            button.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
            button.OverrideDefault.Border.Rounding = 20
            button.OverrideDefault.Border.Width = 1
            button.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem
            button.Size = New Drawing.Size(155, 43)
            button.StateCommon.Back.Color1 = Drawing.Color.FromArgb(6, 174, 244)
            button.StateCommon.Back.Color2 = Drawing.Color.FromArgb(8, 142, 254)
            button.StateCommon.Back.ColorAngle = 45F
            button.StateCommon.Border.Color1 = Drawing.Color.FromArgb(6, 174, 244)
            button.StateCommon.Border.Color2 = Drawing.Color.FromArgb(8, 142, 254)
            button.StateCommon.Border.ColorAngle = 45F
            button.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right

            button.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
            button.StateCommon.Border.Rounding = 20
            button.StateCommon.Border.Width = 1
            button.StateCommon.Content.ShortText.Color1 = Drawing.Color.White
            button.StateCommon.Content.ShortText.Color2 = Drawing.Color.White
            button.StateCommon.Content.ShortText.Font = New Drawing.Font("Poppins ExtraBold", 9.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            button.StatePressed.Back.Color1 = Drawing.Color.FromArgb(20, 145, 198)
            button.StatePressed.Back.Color2 = Drawing.Color.FromArgb(22, 121, 206)
            button.StatePressed.Back.ColorAngle = 135F
            button.StatePressed.Border.Color1 = Drawing.Color.FromArgb(20, 145, 198)
            button.StatePressed.Border.Color2 = Drawing.Color.FromArgb(22, 121, 206)
            button.StatePressed.Border.ColorAngle = 135F
            button.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right

            button.StatePressed.Border.Rounding = 20
            button.StatePressed.Border.Width = 1
            button.StateTracking.Back.Color1 = Drawing.Color.FromArgb(8, 142, 254)
            button.StateTracking.Back.Color2 = Drawing.Color.FromArgb(6, 174, 244)
            button.StateTracking.Back.ColorAngle = 45F
            button.StateTracking.Border.Color1 = Drawing.Color.FromArgb(6, 174, 244)
            button.StateTracking.Border.Color2 = Drawing.Color.FromArgb(8, 142, 254)
            button.StateTracking.Border.ColorAngle = 45F
            button.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right

            button.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
            button.StateTracking.Border.Rounding = 20
            button.StateTracking.Border.Width = 1
            button.TabIndex = 2
            button.Values.Text = "Відобразити"
            ' 
            ' b_min
            ' 
            b_min.Location = New Drawing.Point(10, 98)
            b_min.Name = "b_min"
            b_min.Size = New Drawing.Size(75, 36)
            b_min.StateCommon.Back.Color1 = Drawing.Color.White
            b_min.StateCommon.Border.Color1 = Drawing.Color.FromArgb(224, 224, 224)
            b_min.StateCommon.Border.Color2 = Drawing.Color.FromArgb(224, 224, 224)
            b_min.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right

            b_min.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
            b_min.StateCommon.Border.Rounding = 20
            b_min.StateCommon.Border.Width = 1
            b_min.StateCommon.Content.Color1 = Drawing.Color.FromArgb(64, 64, 64)
            b_min.StateCommon.Content.Font = New Drawing.Font("Poppins", 9F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            b_min.StateCommon.Content.Padding = New Windows.Forms.Padding(10, 0, 10, 0)
            b_min.TabIndex = 3
            b_min.Text = "Min:"
            ' 
            ' b_max
            ' 
            b_max.Location = New Drawing.Point(95, 98)
            b_max.Name = "b_max"
            b_max.Size = New Drawing.Size(75, 36)
            b_max.StateCommon.Back.Color1 = Drawing.Color.White
            b_max.StateCommon.Border.Color1 = Drawing.Color.FromArgb(224, 224, 224)
            b_max.StateCommon.Border.Color2 = Drawing.Color.FromArgb(224, 224, 224)
            b_max.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right

            b_max.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
            b_max.StateCommon.Border.Rounding = 20
            b_max.StateCommon.Border.Width = 1
            b_max.StateCommon.Content.Color1 = Drawing.Color.FromArgb(64, 64, 64)
            b_max.StateCommon.Content.Font = New Drawing.Font("Poppins", 9F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            b_max.StateCommon.Content.Padding = New Windows.Forms.Padding(10, 0, 10, 0)
            b_max.TabIndex = 4
            b_max.Text = "Max:"
            ' 
            ' b_x
            ' 
            b_x.Location = New Drawing.Point(10, 140)
            b_x.Name = "b_x"
            b_x.Size = New Drawing.Size(79, 36)
            b_x.StateCommon.Back.Color1 = Drawing.Color.White
            b_x.StateCommon.Border.Color1 = Drawing.Color.FromArgb(224, 224, 224)
            b_x.StateCommon.Border.Color2 = Drawing.Color.FromArgb(224, 224, 224)
            b_x.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right

            b_x.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
            b_x.StateCommon.Border.Rounding = 20
            b_x.StateCommon.Border.Width = 1
            b_x.StateCommon.Content.Color1 = Drawing.Color.FromArgb(64, 64, 64)
            b_x.StateCommon.Content.Font = New Drawing.Font("Poppins", 9F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            b_x.StateCommon.Content.Padding = New Windows.Forms.Padding(10, 0, 10, 0)
            b_x.TabIndex = 5
            b_x.Text = "X0"
            ' 
            ' b_y
            ' 
            b_y.Location = New Drawing.Point(95, 140)
            b_y.Name = "b_y"
            b_y.Size = New Drawing.Size(75, 36)
            b_y.StateCommon.Back.Color1 = Drawing.Color.White
            b_y.StateCommon.Border.Color1 = Drawing.Color.FromArgb(224, 224, 224)
            b_y.StateCommon.Border.Color2 = Drawing.Color.FromArgb(224, 224, 224)
            b_y.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right

            b_y.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
            b_y.StateCommon.Border.Rounding = 20
            b_y.StateCommon.Border.Width = 1
            b_y.StateCommon.Content.Color1 = Drawing.Color.FromArgb(64, 64, 64)
            b_y.StateCommon.Content.Font = New Drawing.Font("Poppins", 9F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            b_y.StateCommon.Content.Padding = New Windows.Forms.Padding(10, 0, 10, 0)
            b_y.TabIndex = 6
            b_y.Text = "Y0"
            ' 
            ' saveButton
            ' 
            saveButton.Location = New Drawing.Point(90, 1)
            saveButton.Name = "saveButton"
            saveButton.OverrideDefault.Back.Color1 = Drawing.Color.FromArgb(6, 174, 244)
            saveButton.OverrideDefault.Back.Color2 = Drawing.Color.FromArgb(8, 142, 254)
            saveButton.OverrideDefault.Back.ColorAngle = 45F
            saveButton.OverrideDefault.Border.Color1 = Drawing.Color.FromArgb(6, 174, 244)
            saveButton.OverrideDefault.Border.Color2 = Drawing.Color.FromArgb(8, 142, 254)
            saveButton.OverrideDefault.Border.ColorAngle = 45F
            saveButton.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right

            saveButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
            saveButton.OverrideDefault.Border.Rounding = 20
            saveButton.OverrideDefault.Border.Width = 1
            saveButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem
            saveButton.Size = New Drawing.Size(62, 31)
            saveButton.StateCommon.Back.Color1 = Drawing.Color.FromArgb(6, 174, 244)
            saveButton.StateCommon.Back.Color2 = Drawing.Color.FromArgb(8, 142, 254)
            saveButton.StateCommon.Back.ColorAngle = 45F
            saveButton.StateCommon.Border.Color1 = Drawing.Color.FromArgb(6, 174, 244)
            saveButton.StateCommon.Border.Color2 = Drawing.Color.FromArgb(8, 142, 254)
            saveButton.StateCommon.Border.ColorAngle = 45F
            saveButton.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right

            saveButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
            saveButton.StateCommon.Border.Rounding = 20
            saveButton.StateCommon.Border.Width = 1
            saveButton.StateCommon.Content.ShortText.Color1 = Drawing.Color.White
            saveButton.StateCommon.Content.ShortText.Color2 = Drawing.Color.White
            saveButton.StateCommon.Content.ShortText.Font = New Drawing.Font("Poppins ExtraBold", 9.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            saveButton.StatePressed.Back.Color1 = Drawing.Color.FromArgb(20, 145, 198)
            saveButton.StatePressed.Back.Color2 = Drawing.Color.FromArgb(22, 121, 206)
            saveButton.StatePressed.Back.ColorAngle = 135F
            saveButton.StatePressed.Border.Color1 = Drawing.Color.FromArgb(20, 145, 198)
            saveButton.StatePressed.Border.Color2 = Drawing.Color.FromArgb(22, 121, 206)
            saveButton.StatePressed.Border.ColorAngle = 135F
            saveButton.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right

            saveButton.StatePressed.Border.Rounding = 20
            saveButton.StatePressed.Border.Width = 1
            saveButton.StateTracking.Back.Color1 = Drawing.Color.FromArgb(8, 142, 254)
            saveButton.StateTracking.Back.Color2 = Drawing.Color.FromArgb(6, 174, 244)
            saveButton.StateTracking.Back.ColorAngle = 45F
            saveButton.StateTracking.Border.Color1 = Drawing.Color.FromArgb(6, 174, 244)
            saveButton.StateTracking.Border.Color2 = Drawing.Color.FromArgb(8, 142, 254)
            saveButton.StateTracking.Border.ColorAngle = 45F
            saveButton.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right

            saveButton.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
            saveButton.StateTracking.Border.Rounding = 20
            saveButton.StateTracking.Border.Width = 1
            saveButton.TabIndex = 7
            saveButton.Values.Text = "Зберегти графік"
            ' 
            ' helpButton
            ' 
            helpButton.Location = New Drawing.Point(10, 1)
            helpButton.Name = "helpButton"
            helpButton.Size = New Drawing.Size(74, 25)
            helpButton.TabIndex = 8
            helpButton.Values.Text = "Допомога"
            ' 
            ' button1
            ' 
            button1.Location = New Drawing.Point(50, 276)
            button1.Name = "button1"
            button1.Size = New Drawing.Size(75, 23)
            button1.TabIndex = 9
            button1.Text = "button1"
            button1.UseVisualStyleBackColor = True
            ' 
            ' Form1
            ' 
            BackColor = Drawing.Color.FromArgb(250, 252, 252)
            ClientSize = New Drawing.Size(934, 561)
            Controls.Add(button1)
            Controls.Add(helpButton)
            Controls.Add(saveButton)
            Controls.Add(b_y)
            Controls.Add(b_x)
            Controls.Add(b_max)
            Controls.Add(b_min)
            Controls.Add(button)
            Controls.Add(box_fxy)
            Controls.Add(panel)
            Name = "Form1"
            Palette = kryptonPalette1
            PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
            ShowIcon = False
            StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            Text = "Isocline"
            AddHandler Load, New EventHandler(AddressOf Form1_Load_1)
            CType(panel, ComponentModel.ISupportInitialize).EndInit()
            panel.ResumeLayout(False)
            CType(picture, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private panel As ComponentFactory.Krypton.Toolkit.KryptonPanel
        Private picture As Windows.Forms.PictureBox
        Private box_fxy As ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Private kryptonPalette1 As ComponentFactory.Krypton.Toolkit.KryptonPalette
        Private button As ComponentFactory.Krypton.Toolkit.KryptonButton
        Private b_min As ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Private b_max As ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Private b_x As ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Private b_y As ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Private saveButton As ComponentFactory.Krypton.Toolkit.KryptonButton
        Private helpButton As ComponentFactory.Krypton.Toolkit.KryptonButton
        Private button1 As Windows.Forms.Button
    End Class
End Namespace
