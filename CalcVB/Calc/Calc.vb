Public Class calc
    Public a As Double
    Public b As Double
    Public m As Double
    Public s As Double
    Public o As Double


    'Конвертация из градов в радианы
    Private Function GradToRad()
        Dim dop() As String = Split(TextBox1.Text, "'")
        Try

        Catch ex As Exception

        End Try
        Dim d1 = Val(dop(0))
        Dim d2, d3 As Double
        Try
            d2 = Val(dop(1))
            d3 = Val(dop(2))
        Catch ex As Exception

        End Try
        Dim rad = ((d1 * (Math.PI / 200) + (d2 * (Math.PI / (200 * 100))) + (d3 * (Math.PI / (200 * 10000)))) * Math.PI)
        Return rad
    End Function


    'Конвертация из градусов в радианы
    Private Function DegToRad()
        Dim dop() As String = Split(TextBox1.Text, "'")
        Dim d1 = Val(dop(0))
        Dim d2, d3 As Double
        Try
            d2 = Val(dop(1))
            d3 = Val(dop(2))
        Catch ex As Exception

        End Try
        Dim rad = ((d1 * (Math.PI / 180) + (d2 * (Math.PI / (180 * 60))) + (d3 * (Math.PI / (180 * 360))) * Math.PI))
        Return rad
    End Function


    'Конвертация из радиан в градусы с последуещем выводом результата в текстовое поле
    Private Function DegToStr(ByVal rad As Double)
        Dim deg = rad * 180 / Math.PI
        Dim degree = Int(deg)
        Dim minutes = (deg - Math.Truncate(deg)) * 60
        Dim min = Int(minutes)
        Dim seconds = (minutes - Math.Truncate(minutes)) * 60
        Dim sec = Int(seconds)
        TextBox2.Text = CStr(degree) + "°" + CStr(min) + "'" + CStr(sec) + "''"
        If TextBox2.Text.Contains("не") Then
            TextBox2.Text = "NaN"
        End If
        Return 0
    End Function


    'Конвертация из радиан в грады с последуещем выводом результата в текстовое поле
    Private Function GradToStr(ByVal rad As Double)
        Dim grad = rad * 200 / Math.PI
        Dim degree = Int(grad)
        Dim minutes = (grad - Math.Truncate(grad)) * 60
        Dim min = Int(minutes)
        Dim seconds = (minutes - Math.Truncate(minutes)) * 60
        Dim sec = Int(seconds)
        TextBox2.Text = CStr(degree) + "°" + CStr(min) + "'" + CStr(sec) + "''"
        If TextBox2.Text.Contains("не") Then
            TextBox2.Text = "NaN"
        End If
        Return 0
    End Function


    'Кнопка вычисления синуса
    Private Sub ButtonSin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            TextBox2.Text = Math.Round(Math.Sin(DegToRad), 3)
        ElseIf RadioButton2.Checked = True Then
            TextBox2.Text = Math.Round(Math.Sin(GradToRad), 3)
        ElseIf RadioButton3.Checked = True Then
            TextBox2.Text = Math.Round(Math.Sin(Val(TextBox1.Text)), 3)
        Else
            MessageBox.Show("Выберите систему вычисления")
        End If
    End Sub


    'Кнопка вычисления косинуса
    Private Sub ButtonCos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If RadioButton1.Checked = True Then
            TextBox2.Text = Math.Round(Math.Cos(DegToRad), 3)
        ElseIf RadioButton2.Checked = True Then
            TextBox2.Text = Math.Round(Math.Cos(GradToRad), 3)
        ElseIf RadioButton3.Checked = True Then
            TextBox2.Text = Math.Round(Math.Cos(Val(TextBox1.Text)), 3)
        Else
            MessageBox.Show("Выберите систему вычисления")
        End If
    End Sub


    'Кнопка вычисления тангенса
    Private Sub ButtonTan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If RadioButton1.Checked = True Then
            TextBox2.Text = Math.Round(Math.Tan(DegToRad), 3)
        ElseIf RadioButton2.Checked = True Then
            TextBox2.Text = Math.Round(Math.Tan(GradToRad), 3)
        ElseIf RadioButton3.Checked = True Then
            TextBox2.Text = Math.Round(Math.Tan(Val(TextBox1.Text)), 3)
        Else
            MessageBox.Show("Выберите систему вычисления")
        End If
    End Sub


    'Кнопка вычисления котангенса
    Private Sub ButtonCtg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If RadioButton1.Checked = True Then
            TextBox2.Text = Math.Round(Math.Cos(DegToRad) / Math.Sin(DegToRad), 3)
        ElseIf RadioButton2.Checked = True Then
            TextBox2.Text = Math.Round(Math.Cos(GradToRad) / Math.Sin(GradToRad()), 3)
        ElseIf RadioButton3.Checked = True Then
            TextBox2.Text = Math.Round(Math.Cos(Val(TextBox1.Text)) / Math.Sin(Val(TextBox1.Text)), 3)
        Else
            MessageBox.Show("Выберите систему вычисления")
        End If
    End Sub


    'Кнопка вычисления секонса
    Private Sub ButtonSec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If RadioButton1.Checked = True Then
            TextBox2.Text = Math.Round(1 / Math.Cos(DegToRad), 3)
        ElseIf RadioButton2.Checked = True Then
            TextBox2.Text = Math.Round(1 / Math.Cos(GradToRad), 3)
        ElseIf RadioButton3.Checked = True Then
            TextBox2.Text = Math.Round(1 / Math.Cos(Val(TextBox1.Text)), 3)
        Else
            MessageBox.Show("Выберите систему вычисления")
        End If
    End Sub


    'Кнопка вычисления косеканса
    Private Sub ButtonCosec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If RadioButton1.Checked = True Then
            TextBox2.Text = Math.Round(1 / Math.Sin(DegToRad), 3)
        ElseIf RadioButton2.Checked = True Then
            TextBox2.Text = Math.Round(1 / Math.Sin(GradToRad), 3)
        ElseIf RadioButton3.Checked = True Then
            TextBox2.Text = Math.Round(1 / Math.Cos(Val(TextBox1.Text)), 3)
        Else
            MessageBox.Show("Выберите систему вычисления")
        End If
    End Sub


    'Кнопка вычисления арксинуса
    Private Sub ButtonAsin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If RadioButton1.Checked = True Then
            DegToStr(CDbl(Math.Asin(TextBox1.Text)))
        ElseIf RadioButton2.Checked = True Then
            DegToStr(CDbl(Math.Asin(TextBox1.Text)))
        ElseIf RadioButton2.Checked = True Then
            TextBox2.Text = Math.Asin(Val(TextBox1.Text))
        Else
            MessageBox.Show("Выбирете систему вычисления")
        End If
    End Sub


    'Кнопка вычисления арккосинуса
    Private Sub ButtonAcos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If RadioButton1.Checked = True Then
            DegToStr(CDbl(Math.Acos(TextBox1.Text)))
        ElseIf RadioButton2.Checked = True Then
            DegToStr(CDbl(Math.Acos(TextBox1.Text)))
        ElseIf RadioButton2.Checked = True Then
            TextBox2.Text = Math.Acos(Val(TextBox1.Text))
        Else
            MessageBox.Show("Выбирете систему вычисления")
        End If
    End Sub


    'Кнопка вычисления арктангенса
    Private Sub ButtonAtan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If RadioButton1.Checked = True Then
            DegToStr(CDbl(Math.Atan(TextBox1.Text)))
        ElseIf RadioButton2.Checked = True Then
            DegToStr(CDbl(Math.Atan(TextBox1.Text)))
        ElseIf RadioButton2.Checked = True Then
            TextBox2.Text = Math.Atan(Val(TextBox1.Text))
        Else
            MessageBox.Show("Выбирете систему вычисления")
        End If
    End Sub


    'Кнопка вычисления арккотангенса
    Private Sub ButtonActg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        a = Val(TextBox1.Text)
        a = Math.Round(Math.PI / 2 - Math.Atan(a), 3)
        If RadioButton1.Checked = True Then
            DegToStr(CDbl(Math.PI / 2 - Math.Atan(TextBox1.Text)))
        ElseIf RadioButton2.Checked = True Then
            DegToStr(CDbl(Math.PI / 2 - Math.Atan(TextBox1.Text)))
        ElseIf RadioButton2.Checked = True Then
            TextBox2.Text = Val(Math.PI / 2 - Math.Atan(TextBox1.Text))
        Else
            MessageBox.Show("Выбирете систему вычисления")
        End If
    End Sub


    'Кнопка вычисления гиперболического синуса
    Private Sub ButtonSinh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button43.Click
        TextBox2.Text = Math.Round(Math.Sinh(Val(TextBox1.Text)), 3)
    End Sub


    'Кнопка вычисления гиперболического косинуса
    Private Sub ButtonCosh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button41.Click
        TextBox2.Text = Math.Round(Math.Cosh(Val(TextBox1.Text)), 3)
    End Sub


    'Кнопка вычисления гиперболического тангенса
    Private Sub ButtonTanh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button39.Click
        TextBox2.Text = Math.Round(Math.Tanh(Val(TextBox1.Text)), 3)
    End Sub


    'Кнопка вычисления гиперболического котангенса
    Private Sub ButtonCtgh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button37.Click
        TextBox2.Text = Math.Round(Math.PI / 2 - Math.Tanh(Val(TextBox1.Text)), 3)
    End Sub


    'Кнопка вычисления ареасинуса
    Private Sub ButtonArsh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button42.Click
        TextBox2.Text = Math.Log(Val(TextBox1.Text) + Math.Sqrt(Val(TextBox1.Text) * Val(TextBox1.Text) + 1))
    End Sub


    'Кнопка вычисления ареакосинуса
    Private Sub ButtonArch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button40.Click
        TextBox2.Text = Math.Log(Val(TextBox1.Text) + Math.Sqrt(Val(TextBox1.Text) * Val(TextBox1.Text) - 1))
    End Sub


    'Кнопка вычисления ареатангенса
    Private Sub ButtonArth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button38.Click
        TextBox2.Text = Math.Log((1 + Val(TextBox1.Text)) / (1 - Val(TextBox1.Text))) / 2
    End Sub


    'Кнопка вычисления ареакотангенса
    Private Sub ButtonArcth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        TextBox2.Text = Math.Log((Val(TextBox1.Text) + 1) / (Val(TextBox1.Text) - 1)) / 2
    End Sub

End Class