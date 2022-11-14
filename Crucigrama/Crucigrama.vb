Public Class Form1
    Dim resultado1 As Integer = 0
    Dim resultado2 As Integer = 0
    Dim resultado3 As Integer = 0
    Dim resultado4 As Integer = 0
    Dim resultado5 As Integer = 0
    Dim resultado6 As Integer = 0
    Dim suma As Integer = 0
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox11.Enabled = True
            TextBox2.Enabled = True
            TextBox12.Enabled = True
            TextBox13.Enabled = True
            TextBox14.Enabled = True
        ElseIf CheckBox1.Checked = False Then
            TextBox11.Enabled = False
            TextBox2.Enabled = False
            TextBox12.Enabled = False
            TextBox13.Enabled = False
            TextBox14.Enabled = False
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TextBox15.Enabled = True
            TextBox16.Enabled = True
            TextBox4.Enabled = True
            TextBox17.Enabled = True
            TextBox18.Enabled = True
            TextBox19.Enabled = True
            TextBox20.Enabled = True
            TextBox21.Enabled = True
            TextBox22.Enabled = True
        ElseIf CheckBox2.Checked = False Then
            TextBox15.Enabled = False
            TextBox16.Enabled = False
            TextBox4.Enabled = False
            TextBox17.Enabled = False
            TextBox18.Enabled = False
            TextBox19.Enabled = False
            TextBox20.Enabled = False
            TextBox21.Enabled = False
            TextBox22.Enabled = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            TextBox32.Enabled = True
            TextBox7.Enabled = True
            TextBox33.Enabled = True
            TextBox34.Enabled = True
            TextBox35.Enabled = True
            TextBox36.Enabled = True
            TextBox37.Enabled = True
            TextBox38.Enabled = True
        ElseIf CheckBox3.Checked = False Then
            TextBox32.Enabled = False
            TextBox7.Enabled = False
            TextBox33.Enabled = False
            TextBox34.Enabled = False
            TextBox35.Enabled = False
            TextBox36.Enabled = False
            TextBox37.Enabled = False
            TextBox38.Enabled = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox7.Enabled = True
            TextBox8.Enabled = True
            TextBox9.Enabled = True
            TextBox10.Enabled = True
        ElseIf CheckBox4.Checked = False Then
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            TextBox5.Enabled = False
            TextBox6.Enabled = False
            TextBox7.Enabled = False
            TextBox8.Enabled = False
            TextBox9.Enabled = False
            TextBox10.Enabled = False
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            TextBox26.Enabled = True
            TextBox25.Enabled = True
            TextBox24.Enabled = True
            TextBox22.Enabled = True
        ElseIf CheckBox5.Checked = False Then
            TextBox26.Enabled = False
            TextBox25.Enabled = False
            TextBox24.Enabled = False
            TextBox22.Enabled = False
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            TextBox41.Enabled = True
            TextBox38.Enabled = True
            TextBox39.Enabled = True
            TextBox40.Enabled = True
        ElseIf CheckBox6.Checked = False Then
            TextBox41.Enabled = False
            TextBox38.Enabled = False
            TextBox39.Enabled = False
            TextBox40.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox11.Text = "B" And TextBox2.Text = "U" And TextBox12.Text = "R" And TextBox13.Text = "R" And TextBox14.Text = "O" Then
            TextBox11.Enabled = False
            TextBox2.Enabled = False
            TextBox12.Enabled = False
            TextBox13.Enabled = False
            TextBox14.Enabled = False
            CheckBox1.Enabled = False
            resultado1 = 1
        End If
        If TextBox15.Text = "C" And TextBox16.Text = "O" And TextBox4.Text = "C" And TextBox17.Text = "O" And TextBox18.Text = "D" And TextBox19.Text = "R" And TextBox20.Text = "I" And TextBox21.Text = "L" And TextBox22.Text = "O" Then
            TextBox15.Enabled = False
            TextBox16.Enabled = False
            TextBox4.Enabled = False
            TextBox17.Enabled = False
            TextBox18.Enabled = False
            TextBox19.Enabled = False
            TextBox20.Enabled = False
            TextBox21.Enabled = False
            TextBox22.Enabled = False
            CheckBox2.Enabled = False
            resultado2 = 1
        End If
        If TextBox32.Text = "E" And TextBox7.Text = "L" And TextBox33.Text = "E" And TextBox34.Text = "F" And TextBox35.Text = "A" And TextBox36.Text = "N" And TextBox37.Text = "T" And TextBox38.Text = "E" Then
            TextBox32.Enabled = False
            TextBox7.Enabled = False
            TextBox33.Enabled = False
            TextBox34.Enabled = False
            TextBox35.Enabled = False
            TextBox36.Enabled = False
            TextBox37.Enabled = False
            TextBox38.Enabled = False
            CheckBox3.Enabled = False
            resultado3 = 1
        End If
        If TextBox1.Text = "M" And TextBox2.Text = "U" And TextBox3.Text = "R" And TextBox4.Text = "C" And TextBox5.Text = "I" And TextBox6.Text = "E" And TextBox7.Text = "L" And TextBox8.Text = "A" And TextBox9.Text = "G" And TextBox10.Text = "O" Then
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            TextBox5.Enabled = False
            TextBox6.Enabled = False
            TextBox7.Enabled = False
            TextBox8.Enabled = False
            TextBox9.Enabled = False
            TextBox10.Enabled = False
            CheckBox4.Enabled = False
            resultado4 = 1
        End If
        If TextBox26.Text = "M" And TextBox25.Text = "O" And TextBox24.Text = "N" And TextBox22.Text = "O" Then
            TextBox26.Enabled = False
            TextBox25.Enabled = False
            TextBox24.Enabled = False
            TextBox22.Enabled = False
            CheckBox5.Enabled = False
            resultado5 = 1
        End If
        If TextBox41.Text = "L" And TextBox38.Text = "E" And TextBox39.Text = "O" And TextBox40.Text = "N" Then
            TextBox41.Enabled = False
            TextBox38.Enabled = False
            TextBox39.Enabled = False
            TextBox40.Enabled = False
            CheckBox6.Enabled = False
            resultado6 = 1
        End If

        suma = resultado1 + resultado2 + resultado3 + resultado4 + resultado5 + resultado6

        Label4.Text = $" {suma}  / 6"

        If resultado1 = 1 And resultado2 = 1 And resultado3 = 1 And resultado4 = 1 And resultado5 = 1 And resultado6 = 1 Then
            MsgBox("Usted ha completado con exito todo el cursograma")
            Me.Close()
        End If

    End Sub
End Class
