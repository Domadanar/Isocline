Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace Isocline.View
    Friend Class HelpView
        Public Sub HelpButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            CustomMessageBox.Show("+ " & Microsoft.VisualBasic.Constants.vbLf & " - " & Microsoft.VisualBasic.Constants.vbLf & " * " & Microsoft.VisualBasic.Constants.vbLf & " /  " & Microsoft.VisualBasic.Constants.vbLf & " -? " & Microsoft.VisualBasic.Constants.vbLf & " ^  " & Microsoft.VisualBasic.Constants.vbLf & " sin(х) " & Microsoft.VisualBasic.Constants.vbLf & " cos(х) " & Microsoft.VisualBasic.Constants.vbLf & " tg(x) " & Microsoft.VisualBasic.Constants.vbLf & "ctg(x) " & Microsoft.VisualBasic.Constants.vbLf & " asin(x) " & Microsoft.VisualBasic.Constants.vbLf & " acos(x) " & Microsoft.VisualBasic.Constants.vbLf & " atg(x) " & Microsoft.VisualBasic.Constants.vbLf & " actg(x) " & Microsoft.VisualBasic.Constants.vbLf & " log(x)", " додати" & Microsoft.VisualBasic.Constants.vbLf & " відняти" & Microsoft.VisualBasic.Constants.vbLf & " помножити" & Microsoft.VisualBasic.Constants.vbLf & " поділити " & Microsoft.VisualBasic.Constants.vbLf & " унарний мінус" & Microsoft.VisualBasic.Constants.vbLf & " піднести до степеня " & Microsoft.VisualBasic.Constants.vbLf & " синус" & Microsoft.VisualBasic.Constants.vbLf & " косинус" & Microsoft.VisualBasic.Constants.vbLf & " тангенс " & Microsoft.VisualBasic.Constants.vbLf & " котангенс" & Microsoft.VisualBasic.Constants.vbLf & " арксинус" & Microsoft.VisualBasic.Constants.vbLf & " арккосинус" & Microsoft.VisualBasic.Constants.vbLf & " арктангенс" & Microsoft.VisualBasic.Constants.vbLf & " арккотангенс" & Microsoft.VisualBasic.Constants.vbLf & " логарифм", "Пояснення", 12, FontStyle.Bold)

        End Sub
        Public Class CustomMessageBox
            Public Shared Sub Show(ByVal message As String, ByVal mеssage1 As String, ByVal caption As String, ByVal fontSize As Integer, ByVal fontStyle As FontStyle)
                Dim form As Form = New Form()
                form.Text = caption
                form.StartPosition = FormStartPosition.CenterScreen
                form.Width = 340
                form.Height = 400

                Dim tableLayoutPanel As TableLayoutPanel = New TableLayoutPanel()
                tableLayoutPanel.ColumnCount = 2
                tableLayoutPanel.Dock = DockStyle.Fill

                Dim label As Label = New Label()
                label.Text = message
                label.Font = New Font(label.Font.FontFamily, fontSize, fontStyle)
                label.Dock = DockStyle.Fill
                label.TextAlign = ContentAlignment.MiddleLeft

                Dim label2 As Label = New Label()
                label2.Text = mеssage1
                label2.Font = New Font(label2.Font.FontFamily, fontSize)
                label2.Dock = DockStyle.Fill
                label2.TextAlign = ContentAlignment.MiddleLeft

                tableLayoutPanel.Controls.Add(label, 0, 0)
                tableLayoutPanel.Controls.Add(label2, 1, 0)

                Dim buttonOK As Button = New Button()
                buttonOK.Text = "OK"
                buttonOK.DialogResult = DialogResult.OK
                buttonOK.Dock = DockStyle.Bottom

                form.Controls.Add(tableLayoutPanel)
                form.Controls.Add(buttonOK)

                form.ShowDialog()
            End Sub
        End Class
    End Class
End Namespace
