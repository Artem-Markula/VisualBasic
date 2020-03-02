Public Class Form1


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim N As Integer
        Dim Score As Integer

        

        If RadioButton1.Checked = True Then
            MessageBox.Show("Неправильно", "Неправильно!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button1.Focus()
        End If
        If RadioButton2.Checked = True Then
            MessageBox.Show("Но эта знает каждый", "Правильно!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button1.Focus()


            N = 1
            Score = N + N

            TextBox1.Text = Score
         

        End If
        If RadioButton3.Checked = True Then
            MessageBox.Show("Неправильно", "Неправильно!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button1.Focus()
        End If

        If RadioButton4.Checked = True Then
            MessageBox.Show("Неправильно", "Неправильно!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button1.Focus()
            
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim N As Integer
        Dim Score As Integer
    
        If RadioButton5.Checked = True Then
            MessageBox.Show("Неправильно", "Неправильно!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button2.Focus()
        End If
        If RadioButton7.Checked = True Then
            MessageBox.Show("Неправильно", "Неправильно!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button2.Focus()
        End If
        If RadioButton6.Checked = True Then
            MessageBox.Show("Да ты гений", "Правильно!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button2.Focus()
        
           

            N = TextBox1.Text
            Score = N + N

            TextBox1.Text = Score
        End If

        If RadioButton8.Checked = True Then
            MessageBox.Show("Неправильно", "Неправильно!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button2.Focus()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim N As Integer
        Dim Score As Integer


        If RadioButton9.Checked = True Then
            MessageBox.Show("Неправильно", "Неправильно!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button3.Focus()
        End If
        If RadioButton11.Checked = True Then
            MessageBox.Show("Неправильно", "Неправильно!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button3.Focus()
        End If
        If RadioButton10.Checked = True Then
            MessageBox.Show("Правильно", "Правильно!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button3.Focus()
            
            N = TextBox1.Text
            Score = N + N

            TextBox1.Text = Score
        End If

        If RadioButton12.Checked = True Then
            MessageBox.Show("Неправильно", "Неправильно!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button3.Focus()
        End If
    End Sub

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click


        Dim N As Integer
        Dim Score As Integer
      
        Label9.Text = Score
        If RadioButton13.Checked = True Then
            MessageBox.Show("Неправильно", "Неправильно!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button4.Focus()
        End If
        If RadioButton14.Checked = True Then
            MessageBox.Show("Неправильно", "Неправильно!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button4.Focus()
        End If
        If RadioButton16.Checked = True Then
            MessageBox.Show("Неправильно", "Неправильно!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button4.Focus()
        End If

        If RadioButton15.Checked = True Then
            MessageBox.Show("У тебя все хорошо с историей", "Правильно!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button4.Focus()
            N = TextBox1.Text
            Score = N + N

            TextBox1.Text = Score
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click


        Dim N As Integer
        Dim Score As Integer
        
        If RadioButton17.Checked = True Then
            MessageBox.Show("Неправильно", "Неправильно!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button5.Focus()
        End If
        If RadioButton18.Checked = True Then
            MessageBox.Show("Неправильно", "Неправильно!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button5.Focus()
        End If
        If RadioButton19.Checked = True Then
            MessageBox.Show("У тебя все хорошо с географией", "Правильно!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
         
            Button5.Focus()
            N = TextBox1.Text
            Score = N + N

            TextBox1.Text = Score
        End If

        If RadioButton20.Checked = True Then
            MessageBox.Show("Неправильно", "Неправильно!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button5.Focus()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click


        Dim N As Integer
        Dim Score As Integer
        

        If RadioButton21.Checked = True Then
            MessageBox.Show("Неправильно", "Неправильно!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button6.Focus()
        End If
        If RadioButton22.Checked = True Then
            MessageBox.Show("Неправильно", "Неправильно!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button6.Focus()
        End If
        If RadioButton23.Checked = True Then
            MessageBox.Show("Да ты гений", "Правильно!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
          
            Button6.Focus()
            N = TextBox1.Text
            Score = N + N

            TextBox1.Text = Score
        End If

        If RadioButton24.Checked = True Then
            MessageBox.Show("Неправильно", "Неправильно!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button6.Focus()
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        Button7.Focus()
        Dim N As Integer
        Dim Score As Integer
        

        If RadioButton25.Checked = True Then
            MessageBox.Show("Неправильно", "Неправильно!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button7.Focus()
        End If
        If RadioButton26.Checked = True Then
            MessageBox.Show("Неправильно", "Неправильно!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button7.Focus()
        End If
        If RadioButton27.Checked = True Then
            MessageBox.Show("Хорошая работа", "Правильно!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button7.Focus()
            

            N = TextBox1.Text
            Score = N + N

            TextBox1.Text = Score
        End If

        If RadioButton28.Checked = True Then
            MessageBox.Show("Неправильно", "Неправильно!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button7.Focus()
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim N As Integer
        N = 128

        If TextBox1.text = N Then
            MessageBox.Show("Ты отлично знаешь Геометрию и Алгебру", "Поздравляю!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button8.Focus()
        End If
        Dim С As Integer
        С = 32

        If TextBox1.Text = С Then
            MessageBox.Show("Ты знаешь Геометрию и Алгебру на троечку", "Не плохо!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button8.Focus()
        End If
        Dim K As Integer
        K = 16

        If TextBox1.Text = K Then
            MessageBox.Show("Ты Плохо знаешь алгебру и геометрию", "Фейл!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button8.Focus()
        End If
        Dim M As Integer
        M = 64

        If TextBox1.Text = M Then
            MessageBox.Show("Ты Хорошо знаешь Алгебру и Геометрию", "Молодец!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button8.Focus()
        End If
        Dim q, w, s As Integer
        s = 2
        q = 4
        w = 8

        If TextBox1.Text = s Then
            MessageBox.Show("Былов не достаточно тест после перезагрузки", "Не так быстро!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button8.Focus()
        End If
        If TextBox1.Text = q Then
            MessageBox.Show("Былов не достаточно продолжай тест после перезагрузки", "Не так быстро!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button8.Focus()
        End If
        If TextBox1.Text = w Then
            MessageBox.Show("Былов не достаточно продолжай тест после перезагрузки", "Не так быстро!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Button8.Focus()
        End If
        Me.Close()
    End Sub

    
    
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        

        If RadioButton30.Checked = True Then
            MessageBox.Show("Готовлю тесты...", "Отлично!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.TabControl1.Select()
        End If
        If RadioButton29.Checked = True Then
            MessageBox.Show("Встретимся позже", "Хорошо!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.Close()
        End If

    End Sub



End Class
