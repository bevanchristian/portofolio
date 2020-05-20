Public Class Form1

    Dim tabel(9, 9) As String
    Dim random1(9) As Integer
    Dim random2(9) As Integer
    Dim cek As Integer
    Dim kurang As Integer
    Dim f As Integer = 1
    Dim c As Integer
    Dim x As Integer
    Dim y As Integer
    Dim a As Integer
    Dim b As Integer
    Dim NYAWA As Integer
    Dim r As Integer
    Dim hint2 As Integer
    Dim hint1 As Integer
    Dim angka As String = 123456789
    Dim G As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FormAWAL.RadioButtonEASY.Checked = True Then
            SISA.Text = 10

        End If
        If FormAWAL.RadioButtonMEDIUM.Checked = True Then
            SISA.Text = 5

        End If
        If FormAWAL.RadioButtonHARD.Checked = True Then
            SISA.Text = 3

        End If

        Randomize()
        For i = 1 To 5
            random1(i) = (Rnd() * 8) + 1
        Next
        For i = 1 To 5
            random2(i) = (Rnd() * 8) + 1
        Next
        For i = 1 To 5
            For j = 1 To 5
                If i <> j Then
                    If random1(i) = random1(j) Then
                        random1(j) = (Rnd() * 8) + 1
                        j = 1
                        i = 1
                    End If
                End If
            Next
        Next
        For i = 1 To 5
            For j = 1 To 5
                If i <> j Then
                    If random2(i) = random2(j) Then
                        random2(j) = (Rnd() * 8) + 1
                        j = 1
                        i = 1
                    End If
                End If
            Next
        Next
        For i = 1 To 9
            For j = 1 To 9
                tabel(random1(i), random2(j)) = Val(Rnd() * 8 + 1)
                tabel(random1(i), random2(j)) = tabel(random1(i), random2(j)).Substring(0, 1)
                c = 4
                While c > 3
                    c = 0
                    For k = 1 To 9
                        If tabel(random1(i), random2(j)) = tabel(k, random2(j)) Then
                            c += 1
                        End If
                        If tabel(random1(i), random2(j)) = tabel(random1(i), k) Then
                            c += 1
                        End If
                    Next
                    If random1(i) <= 3 And random2(j) <= 3 Then
                        x = 1
                        y = 3
                        a = 1
                        b = 3
                    ElseIf random1(i) <= 3 And (random2(j) >= 4 And random2(j) <= 6) Then
                        x = 1
                        y = 3
                        a = 4
                        b = 6
                    ElseIf random1(i) <= 3 And random2(j) >= 7 Then
                        x = 1
                        y = 3
                        a = 7
                        b = 9
                    ElseIf (random1(i) >= 4 And random1(i) <= 6) And random2(j) <= 3 Then
                        x = 4
                        y = 6
                        a = 1
                        b = 3
                    ElseIf (random1(i) >= 4 And random1(i) <= 6) And (random2(j) >= 4 And random2(j) <= 6) Then
                        x = 4
                        y = 6
                        a = 4
                        b = 6
                    ElseIf (random1(i) >= 4 And random1(i) <= 6) And random2(j) >= 7 Then
                        x = 4
                        y = 6
                        a = 7
                        b = 9
                    ElseIf random1(i) >= 7 And random2(j) <= 3 Then
                        x = 7
                        y = 9
                        a = 1
                        b = 3
                    ElseIf random1(i) >= 7 And (random2(j) >= 4 And random2(j) <= 6) Then
                        x = 7
                        y = 9
                        a = 4
                        b = 6
                    ElseIf random1(i) >= 7 And random2(j) >= 7 Then
                        x = 7
                        y = 9
                        a = 7
                        b = 9
                    End If

                    For l = x To y 'baris
                        For m = a To b 'kolom
                            If tabel(random1(i), random2(j)) = tabel(l, m) Then
                                c += 1
                            End If
                        Next
                    Next

                    If c > 3 Then
                        tabel(random1(i), random2(j)) = Rnd() * 8 + 1
                        tabel(random1(i), random2(j)) = tabel(random1(i), random2(j)).Substring(0, 1)
                    End If
                End While
            Next
        Next
        If tabel(1, 1) <> "" Then
            tb_11.Enabled = False
        End If
        If tabel(1, 2) <> "" Then
            tb_12.Enabled = False
        End If
        If tabel(1, 3) <> "" Then
            tb_13.Enabled = False
        End If

        If tabel(1, 4) <> "" Then
            tb_14.Enabled = False
        End If
        If tabel(1, 5) <> "" Then
            tb_15.Enabled = False
        End If
        If tabel(1, 6) <> "" Then
            tb_16.Enabled = False
        End If
        If tabel(1, 7) <> "" Then
            tb_17.Enabled = False
        End If
        If tabel(1, 8) <> "" Then
            tb_18.Enabled = False
        End If
        If tabel(1, 9) <> "" Then
            tb_19.Enabled = False
        End If
        If tabel(2, 1) <> "" Then
            tb_21.Enabled = False
        End If
        If tabel(2, 2) <> "" Then
            tb_22.Enabled = False
        End If
        If tabel(2, 3) <> "" Then
            tb_23.Enabled = False
        End If
        If tabel(2, 4) <> "" Then
            tb_24.Enabled = False
        End If

        If tabel(2, 5) <> "" Then
            tb_25.Enabled = False
        End If
        If tabel(2, 6) <> "" Then
            tb_26.Enabled = False
        End If
        If tabel(2, 7) <> "" Then
            tb_27.Enabled = False
        End If
        If tabel(2, 8) <> "" Then
            tb_28.Enabled = False
        End If
        If tabel(2, 9) <> "" Then
            tb_29.Enabled = False
        End If
        If tabel(3, 1) <> "" Then
            tb_31.Enabled = False
        End If
        If tabel(3, 2) <> "" Then
            tb_32.Enabled = False
        End If
        If tabel(3, 3) <> "" Then
            tb_33.Enabled = False
        End If
        If tabel(3, 4) <> "" Then
            tb_34.Enabled = False
        End If
        If tabel(3, 5) <> "" Then
            tb_35.Enabled = False
        End If
        If tabel(3, 6) <> "" Then
            tb_36.Enabled = False
        End If
        If tabel(3, 7) <> "" Then
            tb_37.Enabled = False
        End If
        If tabel(3, 8) <> "" Then
            tb_38.Enabled = False
        End If
        If tabel(3, 9) <> "" Then
            tb_39.Enabled = False
        End If
        If tabel(4, 1) <> "" Then
            tb_41.Enabled = False
        End If
        If tabel(4, 2) <> "" Then
            tb_42.Enabled = False
        End If
        If tabel(4, 3) <> "" Then
            tb_43.Enabled = False
        End If
        If tabel(4, 4) <> "" Then
            tb_44.Enabled = False
        End If
        If tabel(4, 5) <> "" Then
            tb_45.Enabled = False
        End If
        If tabel(4, 6) <> "" Then
            tb_46.Enabled = False
        End If
        If tabel(4, 7) <> "" Then
            tb_47.Enabled = False
        End If
        If tabel(4, 8) <> "" Then
            tb_48.Enabled = False
        End If
        If tabel(4, 9) <> "" Then
            tb_49.Enabled = False
        End If
        If tabel(5, 1) <> "" Then
            tb_51.Enabled = False
        End If
        If tabel(5, 2) <> "" Then
            tb_52.Enabled = False
        End If
        If tabel(5, 3) <> "" Then
            tb_53.Enabled = False
        End If
        If tabel(5, 4) <> "" Then
            tb_54.Enabled = False
        End If
        If tabel(5, 5) <> "" Then
            tb_55.Enabled = False
        End If
        If tabel(5, 6) <> "" Then
            tb_56.Enabled = False
        End If
        If tabel(5, 7) <> "" Then
            tb_57.Enabled = False
        End If
        If tabel(5, 8) <> "" Then
            tb_58.Enabled = False
        End If
        If tabel(5, 9) <> "" Then
            tb_59.Enabled = False
        End If
        If tabel(6, 1) <> "" Then
            tb_61.Enabled = False
        End If
        If tabel(6, 2) <> "" Then
            tb_62.Enabled = False
        End If
        If tabel(6, 3) <> "" Then
            tb_63.Enabled = False
        End If
        If tabel(6, 4) <> "" Then
            tb_64.Enabled = False
        End If
        If tabel(6, 5) <> "" Then
            tb_65.Enabled = False
        End If
        If tabel(6, 6) <> "" Then
            tb_66.Enabled = False
        End If
        If tabel(6, 7) <> "" Then
            tb_67.Enabled = False
        End If
        If tabel(6, 8) <> "" Then
            tb_68.Enabled = False
        End If
        If tabel(6, 9) <> "" Then
            tb_69.Enabled = False
        End If
        If tabel(7, 1) <> "" Then
            tb_71.Enabled = False
        End If
        If tabel(7, 2) <> "" Then
            tb_72.Enabled = False
        End If
        If tabel(7, 3) <> "" Then
            tb_73.Enabled = False
        End If
        If tabel(7, 4) <> "" Then
            tb_74.Enabled = False
        End If
        If tabel(7, 5) <> "" Then
            tb_75.Enabled = False
        End If
        If tabel(7, 6) <> "" Then
            tb_76.Enabled = False
        End If
        If tabel(7, 7) <> "" Then
            tb_77.Enabled = False
        End If
        If tabel(7, 8) <> "" Then
            tb_78.Enabled = False
        End If
        If tabel(7, 9) <> "" Then
            tb_79.Enabled = False
        End If
        If tabel(8, 1) <> "" Then
            tb_81.Enabled = False
        End If
        If tabel(8, 2) <> "" Then
            tb_82.Enabled = False
        End If
        If tabel(8, 3) <> "" Then
            tb_83.Enabled = False
        End If
        If tabel(8, 4) <> "" Then
            tb_84.Enabled = False
        End If
        If tabel(8, 5) <> "" Then
            tb_85.Enabled = False
        End If
        If tabel(8, 6) <> "" Then
            tb_86.Enabled = False
        End If
        If tabel(8, 7) <> "" Then
            tb_87.Enabled = False
        End If
        If tabel(8, 8) <> "" Then
            tb_88.Enabled = False
        End If
        If tabel(8, 9) <> "" Then
            tb_89.Enabled = False
        End If
        If tabel(9, 1) <> "" Then
            tb_91.Enabled = False
        End If
        If tabel(9, 2) <> "" Then
            tb_92.Enabled = False
        End If
        If tabel(9, 3) <> "" Then
            tb_93.Enabled = False
        End If
        If tabel(9, 4) <> "" Then
            tb_94.Enabled = False
        End If
        If tabel(9, 5) <> "" Then
            tb_95.Enabled = False
        End If
        If tabel(9, 6) <> "" Then
            tb_96.Enabled = False
        End If
        If tabel(9, 7) <> "" Then
            tb_97.Enabled = False
        End If
        If tabel(9, 8) <> "" Then
            tb_98.Enabled = False
        End If
        If tabel(9, 9) <> "" Then
            tb_99.Enabled = False
        End If
        
   
       


        'For i = 1 To 9
        '    For j = 1 To 9
        '        If tabel(random1(i), random2(j)) = tabel(random1(i - 1), random2(j - 1)) Then
        '            tabel(random1(i - 1), random2(j - 1)) = (Rnd() * 8) + 1
        '            tabel(random1(i - 1), random2(j - 1)) = tabel(random1(i - 1), random2(j - 1)).Substring(0, 1)

        '        End If

        '    Next
        'Next
        'For i = 1 To 9
        '    For j = 1 To 9
        '        If tabel(i, j) = 0 Then
        '            tabel(i, j) = " "
        '        End If
        '    Next
        'Next
        tb_11.Text = tabel(1, 1)
        tb_12.Text = tabel(1, 2)
        tb_13.Text = tabel(1, 3)
        tb_14.Text = tabel(1, 4)
        tb_15.Text = tabel(1, 5)
        tb_16.Text = tabel(1, 6)
        tb_17.Text = tabel(1, 7)
        tb_18.Text = tabel(1, 8)
        tb_19.Text = tabel(1, 9)
        tb_21.Text = tabel(2, 1)
        tb_22.Text = tabel(2, 2)
        tb_23.Text = tabel(2, 3)
        tb_24.Text = tabel(2, 4)
        tb_25.Text = tabel(2, 5)
        tb_26.Text = tabel(2, 6)
        tb_27.Text = tabel(2, 7)
        tb_28.Text = tabel(2, 8)
        tb_29.Text = tabel(2, 9)
        tb_31.Text = tabel(3, 1)
        tb_32.Text = tabel(3, 2)
        tb_33.Text = tabel(3, 3)
        tb_34.Text = tabel(3, 4)
        tb_35.Text = tabel(3, 5)
        tb_36.Text = tabel(3, 6)
        tb_37.Text = tabel(3, 7)
        tb_38.Text = tabel(3, 8)
        tb_39.Text = tabel(3, 9)
        tb_41.Text = tabel(4, 1)
        tb_42.Text = tabel(4, 2)
        tb_43.Text = tabel(4, 3)
        tb_44.Text = tabel(4, 4)
        tb_45.Text = tabel(4, 5)
        tb_46.Text = tabel(4, 6)
        tb_47.Text = tabel(4, 7)
        tb_48.Text = tabel(4, 8)
        tb_49.Text = tabel(4, 9)
        tb_51.Text = tabel(5, 1)
        tb_52.Text = tabel(5, 2)
        tb_53.Text = tabel(5, 3)
        tb_54.Text = tabel(5, 4)
        tb_55.Text = tabel(5, 5)
        tb_56.Text = tabel(5, 6)
        tb_57.Text = tabel(5, 7)
        tb_58.Text = tabel(5, 8)
        tb_59.Text = tabel(5, 9)
        tb_61.Text = tabel(6, 1)
        tb_62.Text = tabel(6, 2)
        tb_63.Text = tabel(6, 3)
        tb_64.Text = tabel(6, 4)
        tb_65.Text = tabel(6, 5)
        tb_66.Text = tabel(6, 6)
        tb_67.Text = tabel(6, 7)
        tb_68.Text = tabel(6, 8)
        tb_69.Text = tabel(6, 9)
        tb_71.Text = tabel(7, 1)
        tb_72.Text = tabel(7, 2)
        tb_73.Text = tabel(7, 3)
        tb_74.Text = tabel(7, 4)
        tb_75.Text = tabel(7, 5)
        tb_76.Text = tabel(7, 6)
        tb_77.Text = tabel(7, 7)
        tb_78.Text = tabel(7, 8)
        tb_79.Text = tabel(7, 9)
        tb_81.Text = tabel(8, 1)
        tb_82.Text = tabel(8, 2)
        tb_83.Text = tabel(8, 3)
        tb_84.Text = tabel(8, 4)
        tb_85.Text = tabel(8, 5)
        tb_86.Text = tabel(8, 6)
        tb_87.Text = tabel(8, 7)
        tb_88.Text = tabel(8, 8)
        tb_89.Text = tabel(8, 9)
        tb_91.Text = tabel(9, 1)
        tb_92.Text = tabel(9, 2)
        tb_93.Text = tabel(9, 3)
        tb_94.Text = tabel(9, 4)
        tb_95.Text = tabel(9, 5)
        tb_96.Text = tabel(9, 6)
        tb_97.Text = tabel(9, 7)
        tb_98.Text = tabel(9, 8)
        tb_99.Text = tabel(9, 9)
        'tabel(9, 9).ToString()

        'For n = 1 To 9
        '    For d = 1 To 9
        '        If tabel(n, d).forecolor = Color.Black Then

        '        End If
        '    Next
        'Next
    End Sub


    Private Sub tb_91_TextChanged(sender As Object, e As EventArgs) Handles tb_91.TextChanged
     
        If tb_91.TextLength = 1 Then
            c = 0
            tabel(9, 1) = tb_91.Text

            For j = 1 To 9
                If tabel(9, 1) = tabel(9, j) Then 'hori
                    c = c + 1
                End If
                If tabel(9, 1) = tabel(j, 1) Then 'vetikal
                    c = c + 1
                End If

            Next
            For i = 7 To 9 'baris 
                For j = 1 To 3 'kolom 
                    If tabel(9, 1) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next

            If c > 3 Then
                tb_91.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_91.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If


                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_91.ForeColor = Color.Black
            End If

        End If

        If tb_91.Text = "" Then
            tabel(9, 1) = 0
        End If
    End Sub

    Private Sub tb_92_TextChanged(sender As Object, e As EventArgs) Handles tb_92.TextChanged
        If tb_92.TextLength = 1 Then
            c = 0
            tabel(9, 2) = tb_92.Text

            For j = 1 To 9
                If tabel(9, 2) = tabel(9, j) Then
                    c = c + 1
                End If
                If tabel(9, 2) = tabel(j, 2) Then
                    c = c + 1
                End If

            Next
            For i = 7 To 9 'baris 
                For j = 1 To 3 'kolom 
                    If tabel(9, 2) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next

            If c > 3 Then
                tb_92.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_92.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_92.ForeColor = Color.Black
            End If

        End If

        If tb_92.Text = "" Then
            tabel(9, 2) = 0
        End If
    End Sub

    Private Sub tb_93_TextChanged(sender As Object, e As EventArgs) Handles tb_93.TextChanged
        If tb_93.TextLength = 1 Then
            c = 0
            tabel(9, 3) = tb_93.Text

            For j = 1 To 9
                If tabel(9, 3) = tabel(9, j) Then
                    c = c + 1
                End If
                If tabel(9, 3) = tabel(j, 3) Then
                    c = c + 1
                End If

            Next
            For i = 7 To 9 'baris 
                For j = 1 To 3 'kolom 
                    If tabel(9, 3) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next

            If c > 3 Then
                tb_93.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_93.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_93.ForeColor = Color.Black
            End If

        End If

        If tb_93.Text = "" Then
            tabel(9, 3) = 0
        End If
    End Sub

    Private Sub tb_94_TextChanged(sender As Object, e As EventArgs) Handles tb_94.TextChanged
        If tb_94.TextLength = 1 Then
            c = 0
            tabel(9, 4) = tb_94.Text

            For j = 1 To 9
                If tabel(9, 4) = tabel(9, j) Then
                    c = c + 1
                End If
                If tabel(9, 4) = tabel(j, 4) Then
                    c = c + 1
                End If

            Next
            For i = 7 To 9 'baris 
                For j = 4 To 6 'kolom 
                    If tabel(9, 4) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next

            If c > 3 Then
                tb_94.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_94.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_94.ForeColor = Color.Black
            End If

        End If

        If tb_94.Text = "" Then
            tabel(9, 4) = 0
        End If
    End Sub

    Private Sub tb_95_TextChanged(sender As Object, e As EventArgs) Handles tb_95.TextChanged
        If tb_95.TextLength = 1 Then
            c = 0
            tabel(9, 5) = tb_95.Text

            For j = 1 To 9
                If tabel(9, 5) = tabel(9, j) Then
                    c = c + 1
                End If
                If tabel(9, 5) = tabel(j, 5) Then
                    c = c + 1
                End If

            Next
            For i = 7 To 9 'baris 
                For j = 4 To 6 'kolom 
                    If tabel(9, 5) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next

            If c > 3 Then
                tb_95.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_95.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_95.ForeColor = Color.Black
            End If

        End If


        If tb_95.Text = "" Then
            tabel(9, 5) = 0
        End If
    End Sub

    Private Sub tb_96_TextChanged(sender As Object, e As EventArgs) Handles tb_96.TextChanged
        If tb_96.TextLength = 1 Then
            c = 0
            tabel(9, 6) = tb_96.Text

            For j = 1 To 9
                If tabel(9, 6) = tabel(9, j) Then
                    c = c + 1
                End If
                If tabel(9, 6) = tabel(j, 6) Then
                    c = c + 1
                End If

            Next
            For i = 7 To 9 'baris 
                For j = 4 To 6 'kolom 
                    If tabel(9, 6) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next

            If c > 3 Then
                tb_96.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_96.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_96.ForeColor = Color.Black
            End If

        End If

        If tb_96.Text = "" Then
            tabel(9, 6) = 0
        End If
    End Sub

    Private Sub tb_97_TextChanged(sender As Object, e As EventArgs) Handles tb_97.TextChanged
        If tb_97.TextLength = 1 Then
            c = 0
            tabel(9, 7) = tb_97.Text

            For j = 1 To 9
                If tabel(9, 7) = tabel(9, j) Then
                    c = c + 1
                End If
                If tabel(9, 7) = tabel(j, 7) Then
                    c = c + 1
                End If

            Next
            For i = 7 To 9 'baris 
                For j = 7 To 9 'kolom 
                    If tabel(9, 7) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next

            If c > 3 Then
                tb_97.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_97.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_97.ForeColor = Color.Black
            End If

        End If

        If tb_97.Text = "" Then
            tabel(9, 7) = 0
        End If
    End Sub

    Private Sub tb_98_TextChanged(sender As Object, e As EventArgs) Handles tb_98.TextChanged
        If tb_98.TextLength = 1 Then
            c = 0
            tabel(9, 8) = tb_98.Text

            For j = 1 To 9
                If tabel(9, 8) = tabel(9, j) Then
                    c = c + 1
                End If
                If tabel(9, 8) = tabel(j, 8) Then
                    c = c + 1
                End If

            Next
            For i = 7 To 9 'baris 
                For j = 7 To 9 'kolom 
                    If tabel(9, 8) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next

            If c > 3 Then
                tb_98.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_98.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_98.ForeColor = Color.Black
            End If

        End If

        If tb_98.Text = "" Then
            tabel(9, 8) = 0
        End If
    End Sub

    Private Sub tb_99_TextChanged(sender As Object, e As EventArgs) Handles tb_99.TextChanged
        If tb_99.TextLength = 1 Then
            c = 0
            tabel(9, 9) = tb_99.Text

            For j = 1 To 9
                If tabel(9, 9) = tabel(9, j) Then
                    c = c + 1
                End If
                If tabel(9, 9) = tabel(j, 9) Then
                    c = c + 1
                End If

            Next
            For i = 7 To 9 'baris 
                For j = 7 To 9 'kolom 
                    If tabel(9, 9) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next

            If c > 3 Then
                tb_99.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_99.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If
                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_99.ForeColor = Color.Black
            End If

        End If

        If tb_99.Text = "" Then
            tabel(9, 9) = 0
        End If
    End Sub
    Private Sub tb_81_TextChanged(sender As Object, e As EventArgs) Handles tb_81.TextChanged

        If tb_81.TextLength = 1 Then
            c = 0
            tabel(8, 1) = tb_81.Text

            For j = 1 To 9
                If tabel(8, 1) = tabel(8, j) Then
                    c = c + 1
                End If
                If tabel(8, 1) = tabel(j, 1) Then
                    c = c + 1
                End If

            Next
            For i = 7 To 9 'baris 
                For j = 1 To 3 'kolom 
                    If tabel(8, 1) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next

            If c > 3 Then
                tb_81.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_81.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_81.ForeColor = Color.Black
            End If

        End If

        If tb_81.Text = "" Then
            tabel(8, 1) = 0
        End If
    End Sub

    Private Sub tb_82_TextChanged(sender As Object, e As EventArgs) Handles tb_82.TextChanged

        If tb_82.TextLength = 1 Then
            c = 0
            tabel(8, 2) = tb_82.Text

            For j = 1 To 9
                If tabel(8, 2) = tabel(8, j) Then
                    c = c + 1
                End If
                If tabel(8, 2) = tabel(j, 2) Then
                    c = c + 1
                End If

            Next
            For i = 7 To 9 'baris 
                For j = 1 To 3 'kolom 
                    If tabel(8, 2) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next

            If c > 3 Then
                tb_82.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_82.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_82.ForeColor = Color.Black
            End If

        End If

        If tb_82.Text = "" Then
            tabel(8, 2) = 0
        End If
    End Sub

    Private Sub tb_83_TextChanged(sender As Object, e As EventArgs) Handles tb_83.TextChanged
        If tb_83.TextLength = 1 Then
            c = 0
            tabel(8, 3) = tb_83.Text

            For j = 1 To 9
                If tabel(8, 3) = tabel(8, j) Then
                    c = c + 1
                End If
                If tabel(8, 3) = tabel(j, 3) Then
                    c = c + 1
                End If

            Next
            For i = 7 To 9 'baris 
                For j = 1 To 3 'kolom 
                    If tabel(8, 3) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next

            If c > 3 Then
                tb_83.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_83.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_83.ForeColor = Color.Black
            End If

        End If

        If tb_83.Text = "" Then
            tabel(8, 3) = 0
        End If
    End Sub

    Private Sub tb_84_TextChanged(sender As Object, e As EventArgs) Handles tb_84.TextChanged

        If tb_84.TextLength = 1 Then
            c = 0
            tabel(8, 4) = tb_84.Text

            For j = 1 To 9
                If tabel(8, 4) = tabel(8, j) Then
                    c = c + 1
                End If
                If tabel(8, 4) = tabel(j, 4) Then
                    c = c + 1
                End If

            Next
            For i = 7 To 9 'baris 
                For j = 4 To 6 'kolom 
                    If tabel(8, 4) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next

            If c > 3 Then
                tb_84.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_84.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_84.ForeColor = Color.Black
            End If

        End If

        If tb_84.Text = "" Then
            tabel(8, 4) = 0
        End If
    End Sub

    Private Sub tb_85_TextChanged(sender As Object, e As EventArgs) Handles tb_85.TextChanged

        If tb_85.TextLength = 1 Then
            c = 0
            tabel(8, 5) = tb_85.Text

            For j = 1 To 9
                If tabel(8, 5) = tabel(8, j) Then
                    c = c + 1
                End If
                If tabel(8, 5) = tabel(j, 5) Then
                    c = c + 1
                End If

            Next
            For i = 7 To 9 'baris 
                For j = 4 To 6 'kolom 
                    If tabel(8, 5) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next

            If c > 3 Then
                tb_85.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_85.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_85.ForeColor = Color.Black
            End If

        End If

        If tb_85.Text = "" Then
            tabel(8, 5) = 0
        End If
    End Sub

    Private Sub tb_86_TextChanged(sender As Object, e As EventArgs) Handles tb_86.TextChanged

        If tb_86.TextLength = 1 Then
            c = 0
            tabel(8, 6) = tb_86.Text

            For j = 1 To 9
                If tabel(8, 6) = tabel(8, j) Then
                    c = c + 1
                End If
                If tabel(8, 6) = tabel(j, 6) Then
                    c = c + 1
                End If

            Next
            For i = 7 To 9 'baris 
                For j = 4 To 6 'kolom 
                    If tabel(8, 6) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next

            If c > 3 Then
                tb_86.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_86.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_86.ForeColor = Color.Black
            End If

        End If

        If tb_86.Text = "" Then
            tabel(8, 6) = 0
        End If
    End Sub

    Private Sub tb_87_TextChanged(sender As Object, e As EventArgs) Handles tb_87.TextChanged

        If tb_87.TextLength = 1 Then
            c = 0
            tabel(8, 7) = tb_87.Text

            For j = 1 To 9
                If tabel(8, 7) = tabel(8, j) Then
                    c = c + 1
                End If
                If tabel(8, 7) = tabel(j, 7) Then
                    c = c + 1
                End If

            Next
            For i = 7 To 9 'baris 
                For j = 7 To 9 'kolom 
                    If tabel(8, 7) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next

            If c > 3 Then
                tb_87.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_87.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_87.ForeColor = Color.Black
            End If

        End If

        If tb_87.Text = "" Then
            tabel(8, 7) = 0
        End If
    End Sub

    Private Sub tb_88_TextChanged(sender As Object, e As EventArgs) Handles tb_88.TextChanged

        If tb_88.TextLength = 1 Then
            c = 0
            tabel(8, 8) = tb_88.Text

            For j = 1 To 9
                If tabel(8, 8) = tabel(8, j) Then
                    c = c + 1
                End If
                If tabel(8, 8) = tabel(j, 8) Then
                    c = c + 1
                End If

            Next
            For i = 7 To 9 'baris 
                For j = 7 To 9 'kolom 
                    If tabel(8, 8) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next

            If c > 3 Then
                tb_88.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_88.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If
                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_88.ForeColor = Color.Black
            End If

        End If

        If tb_88.Text = "" Then
            tabel(8, 8) = 0
        End If
    End Sub

    Private Sub tb_89_TextChanged(sender As Object, e As EventArgs) Handles tb_89.TextChanged

        If tb_89.TextLength = 1 Then
            c = 0
            tabel(8, 9) = tb_89.Text

            For j = 1 To 9
                If tabel(8, 9) = tabel(8, j) Then
                    c = c + 1
                End If
                If tabel(8, 9) = tabel(j, 9) Then
                    c = c + 1
                End If

            Next
            For i = 7 To 9 'baris 
                For j = 7 To 9 'kolom 
                    If tabel(8, 9) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next

            If c > 3 Then
                tb_89.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_89.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_89.ForeColor = Color.Black
            End If

        End If

        If tb_89.Text = "" Then
            tabel(8, 9) = 0
        End If
    End Sub

    Private Sub RichTextBox11_TextChanged(sender As Object, e As EventArgs) Handles tb_11.TextChanged

        If tb_11.TextLength = 1 Then
            c = 0

            tabel(1, 1) = tb_11.Text

            For j = 1 To 9
                If tabel(1, 1) = tabel(1, j) Then
                    c = c + 1
                End If
                If tabel(1, 1) = tabel(j, 1) Then
                    c = c + 1
                End If
            Next
            For i = 1 To 3 'baris 
                For j = 1 To 3 'kolom 
                    If tabel(1, 1) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next

            If c > 3 Then
                tb_11.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_11.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_11.ForeColor = Color.Black
            End If



        End If

        If tb_11.Text = "" Then
            tabel(1, 1) = 0
        End If
    End Sub

    Private Sub tb_12_TextChanged(sender As Object, e As EventArgs) Handles tb_12.TextChanged
        If tb_12.TextLength = 1 Then
            c = 0

            tabel(1, 2) = tb_12.Text

            For j = 1 To 9
                If tabel(1, 2) = tabel(1, j) Then
                    c = c + 1
                End If
                If tabel(1, 2) = tabel(j, 2) Then
                    c = c + 1
                End If
            Next
            For i = 1 To 3 'kolom 
                For j = 1 To 3 'baris 
                    If tabel(1, 2) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next
            If c > 3 Then
                tb_12.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_12.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_12.ForeColor = Color.Black
            End If



        End If

        If tb_12.Text = "" Then
            tabel(1, 2) = 0
        End If
    End Sub

    Private Sub tb_13_TextChanged(sender As Object, e As EventArgs) Handles tb_13.TextChanged
        If tb_13.TextLength = 1 Then
            c = 0

            tabel(1, 3) = tb_13.Text

            For j = 1 To 9
                If tabel(1, 3) = tabel(1, j) Then
                    c = c + 1
                End If
                If tabel(1, 3) = tabel(j, 3) Then
                    c = c + 1
                End If
            Next
            For i = 1 To 3 'kolom 
                For j = 1 To 3 'baris 
                    If tabel(1, 3) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next
            If c > 3 Then
                tb_13.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_13.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_13.ForeColor = Color.Black
            End If



        End If

        If tb_13.Text = "" Then
            tabel(1, 3) = 0
        End If
    End Sub

    Private Sub tb_14_TextChanged(sender As Object, e As EventArgs) Handles tb_14.TextChanged
        If tb_14.TextLength = 1 Then
            c = 0

            tabel(1, 4) = tb_14.Text

            For j = 1 To 9
                If tabel(1, 4) = tabel(1, j) Then
                    c = c + 1
                End If
                If tabel(1, 4) = tabel(j, 4) Then
                    c = c + 1
                End If
            Next
            For i = 1 To 3 'baris 
                For j = 4 To 6 'kolom 
                    If tabel(1, 4) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next
            If c > 3 Then
                tb_14.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_14.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_14.ForeColor = Color.Black
            End If



        End If

        If tb_14.Text = "" Then
            tabel(1, 4) = 0
        End If
    End Sub

    Private Sub tb_15_TextChanged(sender As Object, e As EventArgs) Handles tb_15.TextChanged
        If tb_15.TextLength = 1 Then
            c = 0

            tabel(1, 5) = tb_15.Text

            For j = 1 To 9
                If tabel(1, 5) = tabel(1, j) Then
                    c = c + 1
                End If
                If tabel(1, 5) = tabel(j, 5) Then
                    c = c + 1
                End If
            Next
            For i = 1 To 3 'baris 
                For j = 4 To 6 'kolom 
                    If tabel(1, 5) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next
            If c > 3 Then
                tb_15.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_15.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_15.ForeColor = Color.Black
            End If



        End If

        If tb_15.Text = "" Then
            tabel(1, 5) = 0
        End If
    End Sub

    Private Sub tb_16_TextChanged(sender As Object, e As EventArgs) Handles tb_16.TextChanged
        If tb_16.TextLength = 1 Then
            c = 0

            tabel(1, 6) = tb_16.Text

            For j = 1 To 9
                If tabel(1, 6) = tabel(1, j) Then
                    c = c + 1
                End If
                If tabel(1, 6) = tabel(j, 6) Then
                    c = c + 1
                End If
            Next
            For i = 1 To 3 'baris 
                For j = 4 To 6 'kolom 
                    If tabel(1, 6) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next
            If c > 3 Then
                tb_16.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_16.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_16.ForeColor = Color.Black
            End If



        End If

        If tb_16.Text = "" Then
            tabel(1, 6) = 0
        End If
    End Sub

    Private Sub tb_17_TextChanged(sender As Object, e As EventArgs) Handles tb_17.TextChanged
        If tb_17.TextLength = 1 Then
            c = 0

            tabel(1, 7) = tb_17.Text

            For j = 1 To 9
                If tabel(1, 7) = tabel(1, j) Then
                    c = c + 1
                End If
                If tabel(1, 7) = tabel(j, 5) Then
                    c = c + 1
                End If
            Next
            For i = 1 To 3 'baris 
                For j = 7 To 9 'kolom 
                    If tabel(1, 7) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next
            If c > 3 Then
                tb_17.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_17.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_17.ForeColor = Color.Black
            End If


        End If

        If tb_17.Text = "" Then
            tabel(1, 7) = 0
        End If
    End Sub

    Private Sub tb_18_TextChanged(sender As Object, e As EventArgs) Handles tb_18.TextChanged
        If tb_18.TextLength = 1 Then
            c = 0

            tabel(1, 8) = tb_18.Text

            For j = 1 To 9
                If tabel(1, 8) = tabel(1, j) Then
                    c = c + 1
                End If
                If tabel(1, 8) = tabel(j, 8) Then
                    c = c + 1
                End If
            Next
            For i = 1 To 3 'baris 
                For j = 7 To 9 'kolom 
                    If tabel(1, 8) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next
            If c > 3 Then
                tb_18.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_18.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_18.ForeColor = Color.Black
            End If


        End If

        If tb_18.Text = "" Then
            tabel(1, 8) = 0
        End If
    End Sub

    Private Sub tb_19_TextChanged(sender As Object, e As EventArgs) Handles tb_19.TextChanged
        If tb_19.TextLength = 1 Then
            c = 0

            tabel(1, 9) = tb_19.Text

            For j = 1 To 9
                If tabel(1, 9) = tabel(1, j) Then
                    c = c + 1
                End If
                If tabel(1, 9) = tabel(j, 9) Then
                    c = c + 1
                End If
            Next
            For i = 1 To 3 'baris 
                For j = 7 To 9 'kolom 
                    If tabel(1, 9) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next
            If c > 3 Then
                tb_19.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_19.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_19.ForeColor = Color.Black
            End If



        End If

        If tb_19.Text = "" Then
            tabel(1, 9) = 0
        End If
    End Sub

    Private Sub tb_21_TextChanged(sender As Object, e As EventArgs) Handles tb_21.TextChanged

        If tb_21.TextLength = 1 Then
            c = 0
            tabel(2, 1) = tb_21.Text

            For j = 1 To 9
                If tabel(2, 1) = tabel(2, j) Then
                    c = c + 1
                End If
                If tabel(2, 1) = tabel(j, 1) Then
                    c = c + 1
                End If


            Next
            For i = 1 To 3 'baris 
                For j = 1 To 3 'kolom 
                    If tabel(2, 1) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next
            If c > 3 Then
                tb_21.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_21.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If

            Else
                tb_21.ForeColor = Color.Black

            End If

        End If

        If tb_21.Text = "" Then
            tabel(2, 1) = 0
        End If
    End Sub

    Private Sub tb_22_TextChanged(sender As Object, e As EventArgs) Handles tb_22.TextChanged
        If tb_22.TextLength = 1 Then
            c = 0
            tabel(2, 2) = tb_22.Text

            For j = 1 To 9
                If tabel(2, 2) = tabel(2, j) Then
                    c = c + 1
                End If
                If tabel(2, 2) = tabel(j, 2) Then
                    c = c + 1
                End If

            Next
            For i = 1 To 3 'baris 
                For j = 1 To 3 'kolom 
                    If tabel(2, 2) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next
            If c > 3 Then
                tb_22.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_22.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If

            Else
                tb_22.ForeColor = Color.Black

            End If

        End If
        If tb_22.Text = "" Then
            tabel(2, 2) = 0
        End If
    End Sub

    Private Sub tb_23_TextChanged(sender As Object, e As EventArgs) Handles tb_23.TextChanged
        If tb_23.TextLength = 1 Then
            c = 0
            tabel(2, 3) = tb_23.Text

            For j = 1 To 9
                If tabel(2, 3) = tabel(2, j) Then
                    c = c + 1
                End If
                If tabel(2, 3) = tabel(j, 3) Then
                    c = c + 1
                End If


            Next
            For i = 1 To 3 'baris 
                For j = 1 To 3 'kolom 
                    If tabel(2, 3) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next
            If c > 3 Then
                tb_23.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_23.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If
                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If

            Else
                tb_23.ForeColor = Color.Black

            End If

        End If
        If tb_23.Text = "" Then
            tabel(2, 3) = 0
        End If
    End Sub

    Private Sub tb_24_TextChanged(sender As Object, e As EventArgs) Handles tb_24.TextChanged
        If tb_24.TextLength = 1 Then
            c = 0
            tabel(2, 4) = tb_24.Text

            For j = 1 To 9
                If tabel(2, 4) = tabel(2, j) Then
                    c = c + 1
                End If
                If tabel(2, 4) = tabel(j, 4) Then
                    c = c + 1
                End If


            Next
            For i = 1 To 3 'baris 
                For j = 4 To 6 'kolom 
                    If tabel(2, 4) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next
            If c > 3 Then
                tb_24.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_24.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If

            Else
                tb_24.ForeColor = Color.Black

            End If

        End If
        If tb_24.Text = "" Then
            tabel(2, 4) = 0
        End If
    End Sub

    Private Sub tb_25_TextChanged(sender As Object, e As EventArgs) Handles tb_25.TextChanged
        If tb_25.TextLength = 1 Then
            c = 0
            tabel(2, 5) = tb_25.Text

            For j = 1 To 9
                If tabel(2, 5) = tabel(2, j) Then
                    c = c + 1
                End If
                If tabel(2, 5) = tabel(j, 5) Then
                    c = c + 1
                End If


            Next
            For i = 1 To 3 'baris 
                For j = 4 To 6 'kolom 
                    If tabel(2, 5) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next
            If c > 3 Then
                tb_25.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_25.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If

            Else
                tb_25.ForeColor = Color.Black

            End If

        End If
        If tb_25.Text = "" Then
            tabel(2, 5) = 0
        End If
    End Sub

    Private Sub tb_26_TextChanged(sender As Object, e As EventArgs) Handles tb_26.TextChanged
        If tb_26.TextLength = 1 Then
            c = 0
            tabel(2, 6) = tb_26.Text

            For j = 1 To 9
                If tabel(2, 6) = tabel(2, j) Then
                    c = c + 1
                End If
                If tabel(2, 6) = tabel(j, 6) Then
                    c = c + 1
                End If


            Next
            For i = 1 To 3 'baris 
                For j = 4 To 6 'kolom 
                    If tabel(2, 6) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next
            If c > 3 Then
                tb_26.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_26.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If

            Else
                tb_26.ForeColor = Color.Black

            End If

        End If
        If tb_26.Text = "" Then
            tabel(2, 6) = 0
        End If
    End Sub

    Private Sub tb_27_TextChanged(sender As Object, e As EventArgs) Handles tb_27.TextChanged
        If tb_27.TextLength = 1 Then
            c = 0
            tabel(2, 7) = tb_27.Text

            For j = 1 To 9
                If tabel(2, 7) = tabel(2, j) Then
                    c = c + 1
                End If
                If tabel(2, 7) = tabel(j, 7) Then
                    c = c + 1
                End If


            Next
            For i = 1 To 3 'baris 
                For j = 7 To 9 'kolom 
                    If tabel(2, 7) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next
            If c > 3 Then
                tb_27.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_27.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If

            Else
                tb_27.ForeColor = Color.Black

            End If

        End If
        If tb_27.Text = "" Then
            tabel(2, 7) = 0
        End If
    End Sub

    Private Sub tb_28_TextChanged(sender As Object, e As EventArgs) Handles tb_28.TextChanged
        If tb_28.TextLength = 1 Then
            c = 0
            tabel(2, 8) = tb_28.Text

            For j = 1 To 9
                If tabel(2, 8) = tabel(2, j) Then
                    c = c + 1
                End If
                If tabel(2, 8) = tabel(j, 8) Then
                    c = c + 1
                End If


            Next
            For i = 1 To 3 'baris 
                For j = 7 To 9 'kolom 
                    If tabel(2, 8) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next
            If c > 3 Then
                tb_28.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_28.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If

            Else
                tb_28.ForeColor = Color.Black

            End If

        End If
        If tb_28.Text = "" Then
            tabel(2, 8) = 0
        End If
    End Sub

    Private Sub tb_29_TextChanged(sender As Object, e As EventArgs) Handles tb_29.TextChanged
        If tb_29.TextLength = 1 Then
            c = 0
            tabel(2, 9) = tb_29.Text

            For j = 1 To 9
                If tabel(2, 9) = tabel(2, j) Then
                    c = c + 1
                End If
                If tabel(2, 9) = tabel(j, 9) Then
                    c = c + 1
                End If

            Next
            For i = 1 To 3 'baris 
                For j = 7 To 9 'kolom 
                    If tabel(2, 9) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next
            If c > 3 Then
                tb_29.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_29.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If

            Else
                tb_29.ForeColor = Color.Black

            End If

        End If
        If tb_29.Text = "" Then
            tabel(2, 9) = 0
        End If
    End Sub

    Private Sub tb_71_TextChanged(sender As Object, e As EventArgs) Handles tb_71.TextChanged

        If tb_71.TextLength = 1 Then
            c = 0
            tabel(7, 1) = tb_71.Text

            For j = 1 To 9
                If tabel(7, 1) = tabel(7, j) Then
                    c = c + 1
                End If
                If tabel(7, 1) = tabel(j, 1) Then
                    c = c + 1
                End If

            Next
            For i = 7 To 9 'baris 
                For j = 1 To 3 'kolom 
                    If tabel(7, 1) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next

            If c > 3 Then
                tb_71.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_71.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_71.ForeColor = Color.Black
            End If

        End If
        If tb_71.Text = "" Then
            tabel(7, 1) = 0
        End If
    End Sub

    Private Sub tb_72_TextChanged(sender As Object, e As EventArgs) Handles tb_72.TextChanged

        If tb_72.TextLength = 1 Then
            c = 0
            tabel(7, 2) = tb_72.Text

            For j = 1 To 9
                If tabel(7, 2) = tabel(7, j) Then
                    c = c + 1
                End If
                If tabel(7, 2) = tabel(j, 2) Then
                    c = c + 1
                End If

            Next
            For i = 7 To 9 'baris 
                For j = 1 To 3 'kolom 
                    If tabel(7, 2) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next

            If c > 3 Then
                tb_72.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_72.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_72.ForeColor = Color.Black
            End If

        End If
        If tb_72.Text = "" Then
            tabel(7, 2) = 0
        End If
    End Sub

    Private Sub tb_73_TextChanged(sender As Object, e As EventArgs) Handles tb_73.TextChanged

        If tb_73.TextLength = 1 Then
            c = 0
            tabel(7, 3) = tb_73.Text

            For j = 1 To 9
                If tabel(7, 3) = tabel(7, j) Then
                    c = c + 1
                End If
                If tabel(7, 3) = tabel(j, 3) Then
                    c = c + 1
                End If

            Next
            For i = 7 To 9 'baris 
                For j = 1 To 3 'kolom 
                    If tabel(7, 3) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next

            If c > 3 Then
                tb_73.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_73.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_73.ForeColor = Color.Black
            End If

        End If
        If tb_73.Text = "" Then
            tabel(7, 3) = 0
        End If
    End Sub

    Private Sub tb_74_TextChanged(sender As Object, e As EventArgs) Handles tb_74.TextChanged

        If tb_74.TextLength = 1 Then
            c = 0
            tabel(7, 4) = tb_74.Text

            For j = 1 To 9
                If tabel(7, 4) = tabel(7, j) Then
                    c = c + 1
                End If
                If tabel(7, 4) = tabel(j, 2) Then
                    c = c + 1
                End If

            Next
            For i = 7 To 9 'baris 
                For j = 4 To 6 'kolom 
                    If tabel(7, 4) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next

            If c > 3 Then
                tb_74.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_74.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_74.ForeColor = Color.Black
            End If

        End If
        If tb_74.Text = "" Then
            tabel(7, 4) = 0
        End If
    End Sub

    Private Sub tb_75_TextChanged(sender As Object, e As EventArgs) Handles tb_75.TextChanged

        If tb_75.TextLength = 1 Then
            c = 0
            tabel(7, 5) = tb_75.Text

            For j = 1 To 9
                If tabel(7, 5) = tabel(7, j) Then
                    c = c + 1
                End If
                If tabel(7, 5) = tabel(j, 5) Then
                    c = c + 1
                End If

            Next
            For i = 7 To 9 'baris 
                For j = 4 To 6 'kolom 
                    If tabel(7, 5) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next

            If c > 3 Then
                tb_75.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_75.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_75.ForeColor = Color.Black
            End If

        End If
        If tb_75.Text = "" Then
            tabel(7, 5) = 0
        End If
    End Sub

    Private Sub tb_76_TextChanged(sender As Object, e As EventArgs) Handles tb_76.TextChanged

        If tb_76.TextLength = 1 Then
            c = 0
            tabel(7, 6) = tb_76.Text

            For j = 1 To 9
                If tabel(7, 6) = tabel(7, j) Then
                    c = c + 1
                End If
                If tabel(7, 6) = tabel(j, 6) Then
                    c = c + 1
                End If

            Next
            For i = 7 To 9 'baris 
                For j = 4 To 6 'kolom 
                    If tabel(7, 6) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next

            If c > 3 Then
                tb_76.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_76.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_76.ForeColor = Color.Black
            End If

        End If
        If tb_76.Text = "" Then
            tabel(7, 6) = 0
        End If
    End Sub

    Private Sub tb_77_TextChanged(sender As Object, e As EventArgs) Handles tb_77.TextChanged

        If tb_77.TextLength = 1 Then
            c = 0
            tabel(7, 7) = tb_77.Text

            For j = 1 To 9
                If tabel(7, 7) = tabel(7, j) Then
                    c = c + 1
                End If
                If tabel(7, 7) = tabel(j, 7) Then
                    c = c + 1
                End If

            Next
            For i = 7 To 9 'baris 
                For j = 7 To 9 'kolom 
                    If tabel(7, 7) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next

            If c > 3 Then
                tb_77.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_77.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_77.ForeColor = Color.Black
            End If

        End If
        If tb_77.Text = "" Then
            tabel(7, 7) = 0
        End If
    End Sub

    Private Sub tb_78_TextChanged(sender As Object, e As EventArgs) Handles tb_78.TextChanged

        If tb_78.TextLength = 1 Then
            c = 0
            tabel(7, 8) = tb_78.Text

            For j = 1 To 9
                If tabel(7, 8) = tabel(7, j) Then
                    c = c + 1
                End If
                If tabel(7, 8) = tabel(j, 8) Then
                    c = c + 1
                End If

            Next
            For i = 7 To 9 'baris 
                For j = 7 To 9 'kolom 
                    If tabel(7, 8) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next

            If c > 3 Then
                tb_78.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_78.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If

                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_78.ForeColor = Color.Black
            End If

        End If
        If tb_78.Text = "" Then
            tabel(7, 8) = 0
        End If
    End Sub

    Private Sub tb_79_TextChanged(sender As Object, e As EventArgs) Handles tb_79.TextChanged

        If tb_79.TextLength = 1 Then
            c = 0
            tabel(7, 9) = tb_79.Text

            For j = 1 To 9
                If tabel(7, 9) = tabel(7, j) Then
                    c = c + 1
                End If
                If tabel(7, 9) = tabel(j, 9) Then
                    c = c + 1
                End If

            Next
            For i = 7 To 9 'baris 
                For j = 7 To 9 'kolom 
                    If tabel(7, 9) = tabel(i, j) Then
                        c += 1
                    End If
                Next
            Next

            If c > 3 Then
                tb_79.ForeColor = Color.Red
                NYAWA = NYAWA + 1
                If tb_79.Text <> "" Then
                    SISA.Text = SISA.Text - 1
                End If
                If SISA.Text = 0 Then
                    MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    FormAWAL.Close()
                End If
            Else
                tb_79.ForeColor = Color.Black
            End If

        End If
        If tb_79.Text = "" Then
            tabel(7, 9) = 0
        End If
    End Sub
    Private Sub tb_41_TextChanged(sender As Object, e As EventArgs) Handles tb_41.TextChanged
        c = 0
        tabel(4, 1) = tb_41.Text
        For j = 1 To 9
            If tabel(4, 1) = tabel(4, j) Then
                c = c + 1
            End If
            If tabel(4, 1) = tabel(j, 1) Then
                c = c + 1
            End If
        Next
        For i = 4 To 6 'baris 
            For j = 1 To 3 'kolom 
                If tabel(4, 1) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_41.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_41.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_41.ForeColor = Color.Black
        End If
        If tb_41.Text = "" Then
            tabel(4, 1) = 0
        End If
    End Sub

    Private Sub tb_42_TextChanged(sender As Object, e As EventArgs) Handles tb_42.TextChanged
        c = 0
        tabel(4, 2) = tb_42.Text
        For j = 1 To 9
            If tabel(4, 2) = tabel(4, j) Then
                c = c + 1
            End If
            If tabel(4, 2) = tabel(j, 2) Then
                c = c + 1
            End If
        Next
        For i = 4 To 6 'baris 
            For j = 1 To 3 'kolom 
                If tabel(4, 2) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_42.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_42.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()

            End If
        Else
            tb_42.ForeColor = Color.Black
        End If
        If tb_42.Text = "" Then
            tabel(4, 2) = 0
        End If
    End Sub

    Private Sub tb_43_TextChanged(sender As Object, e As EventArgs) Handles tb_43.TextChanged
        c = 0
        tabel(4, 3) = tb_43.Text
        For j = 1 To 9
            If tabel(4, 3) = tabel(4, j) Then
                c = c + 1
            End If
            If tabel(4, 3) = tabel(j, 3) Then
                c = c + 1
            End If
        Next
        For i = 4 To 6 'baris 
            For j = 1 To 3 'kolom 
                If tabel(4, 3) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_43.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_43.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_43.ForeColor = Color.Black
        End If
        If tb_43.Text = "" Then
            tabel(4, 3) = 0
        End If
    End Sub

    Private Sub tb_44_TextChanged(sender As Object, e As EventArgs) Handles tb_44.TextChanged
        c = 0
        tabel(4, 4) = tb_44.Text
        For j = 1 To 9
            If tabel(4, 4) = tabel(4, j) Then
                c = c + 1
            End If
            If tabel(4, 4) = tabel(j, 4) Then
                c = c + 1
            End If
        Next
        For i = 4 To 6 'baris 
            For j = 4 To 6 'kolom 
                If tabel(4, 4) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_44.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_44.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_44.ForeColor = Color.Black
        End If
        If tb_44.Text = "" Then
            tabel(4, 4) = 0
        End If
    End Sub

    Private Sub tb_45_TextChanged(sender As Object, e As EventArgs) Handles tb_45.TextChanged
        c = 0
        tabel(4, 5) = tb_45.Text
        For j = 1 To 9
            If tabel(4, 5) = tabel(4, j) Then
                c = c + 1
            End If
            If tabel(4, 5) = tabel(j, 5) Then
                c = c + 1
            End If
        Next
        For i = 4 To 6 'baris 
            For j = 4 To 6 'kolom 
                If tabel(4, 5) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_45.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_45.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_45.ForeColor = Color.Black
        End If
        If tb_45.Text = "" Then
            tabel(4, 5) = 0
        End If
    End Sub

    Private Sub tb_46_TextChanged(sender As Object, e As EventArgs) Handles tb_46.TextChanged
        c = 0
        tabel(4, 6) = tb_46.Text
        For j = 1 To 9
            If tabel(4, 6) = tabel(4, j) Then
                c = c + 1
            End If
            If tabel(4, 6) = tabel(j, 6) Then
                c = c + 1
            End If
        Next
        For i = 4 To 6 'baris 
            For j = 4 To 6 'kolom 
                If tabel(4, 6) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_46.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_46.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_46.ForeColor = Color.Black
        End If
        If tb_46.Text = "" Then
            tabel(4, 6) = 0
        End If
    End Sub

    Private Sub tb_47_TextChanged(sender As Object, e As EventArgs) Handles tb_47.TextChanged
        c = 0
        tabel(4, 7) = tb_47.Text
        For j = 1 To 9
            If tabel(4, 7) = tabel(4, j) Then
                c = c + 1
            End If
            If tabel(4, 7) = tabel(j, 7) Then
                c = c + 1
            End If
        Next
        For i = 4 To 6 'baris 
            For j = 7 To 9 'kolom 
                If tabel(4, 7) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_47.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_47.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_47.ForeColor = Color.Black
        End If
        If tb_47.Text = "" Then
            tabel(4, 7) = 0
        End If
    End Sub

    Private Sub tb_48_TextChanged(sender As Object, e As EventArgs) Handles tb_48.TextChanged
        c = 0
        tabel(4, 8) = tb_48.Text
        For j = 1 To 9
            If tabel(4, 8) = tabel(4, j) Then
                c = c + 1
            End If
            If tabel(4, 8) = tabel(j, 8) Then
                c = c + 1
            End If
        Next
        For i = 4 To 6 'baris 
            For j = 7 To 9 'kolom 
                If tabel(4, 8) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_48.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_48.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_48.ForeColor = Color.Black
        End If
        If tb_48.Text = "" Then
            tabel(4, 8) = 0
        End If
    End Sub

    Private Sub tb_49_TextChanged(sender As Object, e As EventArgs) Handles tb_49.TextChanged
        c = 0
        tabel(4, 9) = tb_49.Text
        For j = 1 To 9
            If tabel(4, 9) = tabel(4, j) Then
                c = c + 1
            End If
            If tabel(4, 9) = tabel(j, 9) Then
                c = c + 1
            End If
        Next
        For i = 4 To 6 'baris 
            For j = 7 To 9 'kolom 
                If tabel(4, 9) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_49.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_49.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_49.ForeColor = Color.Black
        End If
        If tb_49.Text = "" Then
            tabel(4, 9) = 0
        End If
    End Sub

    Private Sub tb_51_TextChanged(sender As Object, e As EventArgs) Handles tb_51.TextChanged
        c = 0
        tabel(5, 1) = tb_51.Text
        For j = 1 To 9
            If tabel(5, 1) = tabel(5, j) Then
                c = c + 1
            End If
            If tabel(5, 1) = tabel(j, 1) Then
                c = c + 1
            End If
        Next
        For i = 4 To 6 'baris 
            For j = 1 To 3 'kolom 
                If tabel(5, 1) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_51.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_51.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_51.ForeColor = Color.Black
        End If

        If tb_51.Text = "" Then
            tabel(5, 1) = 0
        End If
    End Sub

    Private Sub tb_52_TextChanged(sender As Object, e As EventArgs) Handles tb_52.TextChanged
        c = 0
        tabel(5, 2) = tb_52.Text
        For j = 1 To 9
            If tabel(5, 2) = tabel(5, j) Then
                c = c + 1
            End If
            If tabel(5, 2) = tabel(j, 2) Then
                c = c + 1
            End If
        Next
        For i = 4 To 6 'baris 
            For j = 1 To 3 'kolom 
                If tabel(5, 2) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_52.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_52.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_52.ForeColor = Color.Black
        End If

        If tb_52.Text = "" Then
            tabel(5, 2) = 0
        End If
    End Sub

    Private Sub tb_53_TextChanged(sender As Object, e As EventArgs) Handles tb_53.TextChanged
        c = 0
        tabel(5, 3) = tb_53.Text
        For j = 1 To 9
            If tabel(5, 3) = tabel(5, j) Then
                c = c + 1
            End If
            If tabel(5, 3) = tabel(j, 3) Then
                c = c + 1
            End If
        Next
        For i = 4 To 6 'baris 
            For j = 1 To 3 'kolom 
                If tabel(5, 3) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_53.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_53.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If

        Else
            tb_53.ForeColor = Color.Black
        End If

        If tb_53.Text = "" Then
            tabel(5, 3) = 0
        End If
    End Sub

    Private Sub tb_54_TextChanged(sender As Object, e As EventArgs) Handles tb_54.TextChanged
        c = 0
        tabel(5, 4) = tb_54.Text
        For j = 1 To 9
            If tabel(5, 4) = tabel(5, j) Then
                c = c + 1
            End If
            If tabel(5, 4) = tabel(j, 4) Then
                c = c + 1
            End If
        Next
        For i = 4 To 6 'baris 
            For j = 4 To 6 'kolom 
                If tabel(5, 4) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_54.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_54.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If
            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_54.ForeColor = Color.Black
        End If

        If tb_54.Text = "" Then
            tabel(5, 4) = 0
        End If
    End Sub

    Private Sub tb_55_TextChanged(sender As Object, e As EventArgs) Handles tb_55.TextChanged
        c = 0
        tabel(5, 5) = tb_55.Text
        For j = 1 To 9
            If tabel(5, 5) = tabel(5, j) Then
                c = c + 1
            End If
            If tabel(5, 5) = tabel(j, 5) Then
                c = c + 1
            End If
        Next
        For i = 4 To 6 'baris 
            For j = 4 To 6 'kolom 
                If tabel(5, 5) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_55.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_55.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_55.ForeColor = Color.Black
        End If

        If tb_55.Text = "" Then
            tabel(5, 5) = 0
        End If
    End Sub

    Private Sub tb_56_TextChanged(sender As Object, e As EventArgs) Handles tb_56.TextChanged
        c = 0
        tabel(5, 6) = tb_56.Text
        For j = 1 To 9
            If tabel(5, 6) = tabel(5, j) Then
                c = c + 1
            End If
            If tabel(5, 6) = tabel(j, 6) Then
                c = c + 1
            End If
        Next
        For i = 4 To 6 'baris 
            For j = 4 To 6 'kolom 
                If tabel(5, 6) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_56.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_56.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_56.ForeColor = Color.Black
        End If

        If tb_56.Text = "" Then
            tabel(5, 6) = 0
        End If
    End Sub

    Private Sub tb_57_TextChanged(sender As Object, e As EventArgs) Handles tb_57.TextChanged
        c = 0
        tabel(5, 7) = tb_57.Text
        For j = 1 To 9
            If tabel(5, 7) = tabel(5, j) Then
                c = c + 1
            End If
            If tabel(5, 7) = tabel(j, 7) Then
                c = c + 1
            End If
        Next
        For i = 4 To 6 'baris 
            For j = 7 To 9 'kolom 
                If tabel(5, 7) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_57.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_57.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_57.ForeColor = Color.Black
        End If
        If tb_57.Text = "" Then
            tabel(5, 7) = 0
        End If
    End Sub

    Private Sub tb_58_TextChanged(sender As Object, e As EventArgs) Handles tb_58.TextChanged
        c = 0
        tabel(5, 8) = tb_58.Text
        For j = 1 To 9
            If tabel(5, 8) = tabel(5, j) Then
                c = c + 1
            End If
            If tabel(5, 8) = tabel(j, 8) Then
                c = c + 1
            End If
        Next
        For i = 4 To 6 'baris 
            For j = 7 To 9 'kolom 
                If tabel(5, 8) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_58.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_58.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_58.ForeColor = Color.Black
        End If
        If tb_58.Text = "" Then
            tabel(5, 8) = 0
        End If

    
    End Sub

    Private Sub tb_59_TextChanged(sender As Object, e As EventArgs) Handles tb_59.TextChanged
        c = 0
        tabel(5, 9) = tb_59.Text
        For j = 1 To 9
            If tabel(5, 9) = tabel(5, j) Then
                c = c + 1
            End If
            If tabel(5, 9) = tabel(j, 9) Then
                c = c + 1
            End If
        Next
        For i = 4 To 6 'baris 
            For j = 7 To 9 'kolom 
                If tabel(5, 9) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_59.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_59.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_59.ForeColor = Color.Black
        End If
        If tb_59.Text = "" Then
            tabel(5, 9) = 0
        End If


    End Sub
    Private Sub tb_61_TextChanged(sender As Object, e As EventArgs) Handles tb_61.TextChanged
        c = 0
        tabel(6, 1) = tb_61.Text
        For j = 1 To 9
            If tabel(6, 1) = tabel(6, j) Then
                c = c + 1
            End If
            If tabel(6, 1) = tabel(j, 1) Then
                c = c + 1
            End If
        Next
        For i = 4 To 6 'baris 
            For j = 1 To 3 'kolom 
                If tabel(6, 1) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_61.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_61.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_61.ForeColor = Color.Black
        End If
        If tb_61.Text = "" Then
            tabel(6, 1) = 0
        End If

    End Sub

    Private Sub tb_62_TextChanged(sender As Object, e As EventArgs) Handles tb_62.TextChanged
        c = 0
        tabel(6, 2) = tb_62.Text
        For j = 1 To 9
            If tabel(6, 2) = tabel(6, j) Then
                c = c + 1
            End If
            If tabel(6, 2) = tabel(j, 2) Then
                c = c + 1
            End If
        Next
        For i = 4 To 6 'baris 
            For j = 1 To 3 'kolom 
                If tabel(6, 2) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_62.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_62.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_62.ForeColor = Color.Black
        End If
        If tb_62.Text = "" Then
            tabel(6, 2) = 0
        End If

    End Sub

    Private Sub tb_63_TextChanged(sender As Object, e As EventArgs) Handles tb_63.TextChanged
        c = 0
        tabel(6, 3) = tb_63.Text
        For j = 1 To 9
            If tabel(6, 3) = tabel(6, j) Then
                c = c + 1
            End If
            If tabel(6, 3) = tabel(j, 3) Then
                c = c + 1
            End If
        Next
        For i = 4 To 6 'baris 
            For j = 1 To 3 'kolom 
                If tabel(6, 3) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_63.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_63.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_63.ForeColor = Color.Black
        End If
        If tb_63.Text = "" Then
            tabel(6, 3) = 0
        End If

       
    End Sub

    Private Sub tb_64_TextChanged(sender As Object, e As EventArgs) Handles tb_64.TextChanged
        c = 0
        tabel(6, 4) = tb_64.Text
        For j = 1 To 9
            If tabel(6, 4) = tabel(6, j) Then
                c = c + 1
            End If
            If tabel(6, 4) = tabel(j, 4) Then
                c = c + 1
            End If
        Next
        For i = 4 To 6 'baris 
            For j = 4 To 6 'kolom 
                If tabel(6, 4) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next
        If c > 3 Then
            tb_64.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_64.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_64.ForeColor = Color.Black
        End If

        If tb_64.Text = "" Then
            tabel(6, 4) = 0
        End If
    End Sub

    Private Sub tb_65_TextChanged(sender As Object, e As EventArgs) Handles tb_65.TextChanged
        c = 0
        tabel(6, 5) = tb_65.Text
        For j = 1 To 9
            If tabel(6, 5) = tabel(6, j) Then
                c = c + 1
            End If
            If tabel(6, 5) = tabel(j, 5) Then
                c = c + 1
            End If
        Next
        For i = 4 To 6 'baris 
            For j = 4 To 6 'kolom 
                If tabel(6, 5) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_65.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_65.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_65.ForeColor = Color.Black
        End If

        If tb_65.Text = "" Then
            tabel(6, 5) = 0
        End If
    End Sub

    Private Sub tb_66_TextChanged(sender As Object, e As EventArgs) Handles tb_66.TextChanged
        c = 0
        tabel(6, 6) = tb_66.Text
        For j = 1 To 9
            If tabel(6, 6) = tabel(6, j) Then
                c = c + 1
            End If
            If tabel(6, 6) = tabel(j, 6) Then
                c = c + 1
            End If
        Next
        For i = 4 To 6 'baris 
            For j = 4 To 6 'kolom 
                If tabel(6, 6) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_66.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_66.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_66.ForeColor = Color.Black
        End If

        If tb_66.Text = "" Then
            tabel(6, 6) = 0
        End If
    End Sub

    Private Sub tb_67_TextChanged(sender As Object, e As EventArgs) Handles tb_67.TextChanged
        c = 0
        tabel(6, 7) = tb_67.Text
        For j = 1 To 9
            If tabel(6, 7) = tabel(6, j) Then
                c = c + 1
            End If
            If tabel(6, 7) = tabel(j, 7) Then
                c = c + 1
            End If
        Next
        For i = 4 To 6 'baris 
            For j = 7 To 9 'kolom 
                If tabel(6, 7) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_67.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_67.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()

            End If
        Else
            tb_67.ForeColor = Color.Black
        End If

        If tb_67.Text = "" Then
            tabel(6, 7) = 0
        End If
    End Sub

    Private Sub tb_68_TextChanged(sender As Object, e As EventArgs) Handles tb_68.TextChanged
        c = 0
        tabel(6, 8) = tb_68.Text
        For j = 1 To 9
            If tabel(6, 8) = tabel(6, j) Then
                c = c + 1
            End If
            If tabel(6, 8) = tabel(j, 8) Then
                c = c + 1
            End If
        Next
        For i = 4 To 6 'baris 
            For j = 7 To 9 'kolom 
                If tabel(6, 8) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_68.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_68.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_68.ForeColor = Color.Black
        End If

        If tb_68.Text = "" Then
            tabel(6, 8) = 0
        End If
    End Sub

    Private Sub tb_69_TextChanged(sender As Object, e As EventArgs) Handles tb_69.TextChanged
        c = 0
        tabel(6, 9) = tb_69.Text
        For j = 1 To 9
            If tabel(6, 9) = tabel(6, j) Then
                c = c + 1
            End If
            If tabel(6, 9) = tabel(j, 9) Then
                c = c + 1
            End If
        Next
        For i = 4 To 6 'baris 
            For j = 7 To 9 'kolom 
                If tabel(6, 9) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_69.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_69.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_69.ForeColor = Color.Black
        End If

        If tb_69.Text = "" Then
            tabel(6, 9) = 0
        End If
    End Sub

    Private Sub tb_31_TextChanged(sender As Object, e As EventArgs) Handles tb_31.TextChanged
        c = 0
        tabel(3, 1) = tb_31.Text
        For j = 1 To 9
            If tabel(3, 1) = tabel(3, j) Then
                c = c + 1
            End If
            If tabel(3, 1) = tabel(j, 1) Then
                c = c + 1
            End If
        Next
        For i = 1 To 3 'baris 
            For j = 1 To 3 'kolom 
                If tabel(3, 1) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_31.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_31.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If
            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_31.ForeColor = Color.Black
        End If


        If tb_31.Text = "" Then
            tabel(3, 1) = 0
        End If

    End Sub

    Private Sub tb_32_TextChanged(sender As Object, e As EventArgs) Handles tb_32.TextChanged
        c = 0
        tabel(3, 2) = tb_32.Text
        For j = 1 To 9
            If tabel(3, 2) = tabel(3, j) Then
                c = c + 1
            End If
            If tabel(3, 2) = tabel(j, 2) Then
                c = c + 1
            End If
        Next
        For i = 1 To 3 'baris 
            For j = 1 To 3 'kolom 
                If tabel(3, 2) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_32.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_32.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If
            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_32.ForeColor = Color.Black
        End If

        If tb_32.Text = "" Then
            tabel(3, 2) = 0
        End If
    End Sub

    Private Sub tb_33_TextChanged(sender As Object, e As EventArgs) Handles tb_33.TextChanged
        c = 0
        tabel(3, 3) = tb_33.Text
        For j = 1 To 9
            If tabel(3, 3) = tabel(3, j) Then
                c = c + 1
            End If
            If tabel(3, 3) = tabel(j, 3) Then
                c = c + 1
            End If
        Next
        For i = 1 To 3 'baris 
            For j = 1 To 3 'kolom 
                If tabel(3, 3) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next
        If c > 3 Then
            tb_33.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_33.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If
            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_33.ForeColor = Color.Black
        End If

        If tb_33.Text = "" Then
            tabel(3, 3) = 0
        End If
    End Sub

    Private Sub tb_34_TextChanged(sender As Object, e As EventArgs) Handles tb_34.TextChanged
        c = 0
        tabel(3, 4) = tb_34.Text
        For j = 1 To 9
            If tabel(3, 4) = tabel(3, j) Then
                c = c + 1
            End If
            If tabel(3, 4) = tabel(j, 4) Then
                c = c + 1
            End If
        Next
        For i = 1 To 3 'baris 
            For j = 4 To 6 'kolom 
                If tabel(3, 4) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_34.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_34.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If
            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_34.ForeColor = Color.Black
        End If

        If tb_34.Text = "" Then
            tabel(3, 4) = 0
        End If
    End Sub

    Private Sub tb_35_TextChanged(sender As Object, e As EventArgs) Handles tb_35.TextChanged
        c = 0
        tabel(3, 5) = tb_35.Text
        For j = 1 To 9
            If tabel(3, 5) = tabel(3, j) Then
                c = c + 1
            End If
            If tabel(3, 5) = tabel(j, 5) Then
                c = c + 1
            End If
        Next
        For i = 1 To 3 'baris 
            For j = 4 To 6 'kolom 
                If tabel(3, 5) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_35.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_35.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If
            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_35.ForeColor = Color.Black
        End If

        If tb_35.Text = "" Then
            tabel(3, 5) = 0
        End If
    End Sub

    Private Sub tb_36_TextChanged(sender As Object, e As EventArgs) Handles tb_36.TextChanged
        c = 0
        tabel(3, 6) = tb_36.Text
        For j = 1 To 9
            If tabel(3, 6) = tabel(3, j) Then
                c = c + 1
            End If
            If tabel(3, 6) = tabel(j, 6) Then
                c = c + 1
            End If
        Next
        For i = 1 To 3 'baris 
            For j = 4 To 6 'kolom 
                If tabel(3, 6) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_36.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_36.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If
            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_36.ForeColor = Color.Black
        End If

        If tb_36.Text = "" Then
            tabel(3, 6) = 0
        End If
    End Sub

    Private Sub tb_37_TextChanged(sender As Object, e As EventArgs) Handles tb_37.TextChanged
        c = 0
        tabel(3, 7) = tb_37.Text
        For j = 1 To 9
            If tabel(3, 7) = tabel(3, j) Then
                c = c + 1
            End If
            If tabel(3, 7) = tabel(j, 7) Then
                c = c + 1
            End If
        Next
        For i = 1 To 3 'baris 
            For j = 7 To 9 'kolom 
                If tabel(3, 7) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_37.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_37.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_37.ForeColor = Color.Black
        End If

        If tb_37.Text = "" Then
            tabel(3, 7) = 0
        End If
    End Sub

    Private Sub tb_38_TextChanged(sender As Object, e As EventArgs) Handles tb_38.TextChanged
        c = 0
        tabel(3, 8) = tb_38.Text
        For j = 1 To 9
            If tabel(3, 8) = tabel(3, j) Then
                c = c + 1
            End If
            If tabel(3, 8) = tabel(j, 8) Then
                c = c + 1
            End If
        Next
        For i = 1 To 3 'baris 
            For j = 7 To 9 'kolom 
                If tabel(3, 8) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next

        If c > 3 Then
            tb_38.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_38.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_38.ForeColor = Color.Black
        End If

        If tb_38.Text = "" Then
            tabel(3, 8) = 0
        End If
    End Sub

    Private Sub tb_39_TextChanged(sender As Object, e As EventArgs) Handles tb_39.TextChanged
        c = 0
        tabel(3, 9) = tb_39.Text
        For j = 1 To 9
            If tabel(3, 9) = tabel(3, j) Then
                c = c + 1
            End If
            If tabel(3, 9) = tabel(j, 9) Then
                c = c + 1
            End If
        Next
        For i = 1 To 3 'baris 
            For j = 7 To 9 'kolom 
                If tabel(3, 9) = tabel(i, j) Then
                    c += 1
                End If
            Next
        Next
        If c > 3 Then
            tb_39.ForeColor = Color.Red
            NYAWA = NYAWA + 1
            If tb_39.Text <> "" Then
                SISA.Text = SISA.Text - 1
            End If

            If SISA.Text = 0 Then
                MessageBox.Show("MAAF NYAWA ANDA HABIS", "KALAH", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                FormAWAL.Close()
            End If
        Else
            tb_39.ForeColor = Color.Black
        End If

        If tb_39.Text = "" Then
            tabel(3, 9) = 0
        End If
    End Sub


    Private Sub Buttoncek_Click(sender As Object, e As EventArgs) Handles Buttoncek.Click
        If tb_11.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_11.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_11.Text = "" Then
            kurang = 1
        End If

        If tb_12.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_12.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_12.Text = "" Then
            kurang = 1
        End If

        If tb_13.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_13.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_13.Text = "" Then
            kurang = 1
        End If
        If tb_14.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_14.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_15.Text = "" Then
            kurang = 1
        End If
        If tb_16.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_16.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_16.Text = "" Then
            kurang = 1
        End If

        If tb_17.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_17.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_17.Text = "" Then
            kurang = 1
        End If
        If tb_18.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_18.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_18.Text = "" Then
            kurang = 1
        End If
        If tb_19.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_19.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_19.Text = "" Then
            kurang = 1
        End If
        If tb_21.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_21.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_21.Text = "" Then
            kurang = 1
        End If
        If tb_22.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_22.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_22.Text = "" Then
            kurang = 1
        End If
        If tb_23.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_23.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_23.Text = "" Then
            kurang = 1
        End If
        If tb_24.ForeColor = Color.Black Then
            cek = 0
        ElseIf tb_24.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_25.Text = "" Then
            kurang = 1
        End If
        If tb_26.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_26.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_26.Text = "" Then
            kurang = 1
        End If
        If tb_27.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_27.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_27.Text = "" Then
            kurang = 1
        End If
        If tb_28.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_28.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_28.Text = "" Then
            kurang = 1
        End If
        If tb_29.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_29.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_29.Text = "" Then
            kurang = 1
        End If
        

        If tb_31.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_31.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_31.Text = "" Then
            kurang = 1
        End If

        If tb_32.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_32.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_32.Text = "" Then
            kurang = 1
        End If
        If tb_33.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_33.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_33.Text = "" Then
            kurang = 1
        End If
        If tb_34.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_34.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_34.Text = "" Then
            kurang = 1
        End If
        If tb_35.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_35.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_35.Text = "" Then
            kurang = 1
        End If
        If tb_36.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_36.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_36.Text = "" Then
            kurang = 1
        End If

        If tb_37.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_37.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_37.Text = "" Then
            kurang = 1
        End If
        If tb_38.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_38.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_38.Text = "" Then
            kurang = 1
        End If

        If tb_39.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_39.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_39.Text = "" Then
            kurang = 1
        End If
        If tb_41.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_41.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_41.Text = "" Then
            kurang = 1
        End If
        If tb_42.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_42.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_42.Text = "" Then
            kurang = 1
        End If
        If tb_43.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_43.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_43.Text = "" Then
            kurang = 1
        End If
        If tb_44.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_44.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_44.Text = "" Then
            kurang = 1
        End If

        If tb_45.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_45.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_45.Text = "" Then
            kurang = 1
        End If

        If tb_46.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_46.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_46.Text = "" Then
            kurang = 1
        End If
        If tb_47.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_47.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_47.Text = "" Then
            kurang = 1
        End If
        If tb_48.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_48.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_48.Text = "" Then
            kurang = 1
        End If
        If tb_49.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_49.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_49.Text = "" Then
            kurang = 1
        End If
        If tb_51.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_51.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_51.Text = "" Then
            kurang = 1
        End If
        If tb_52.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_52.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_52.Text = "" Then
            kurang = 1
        End If

        If tb_53.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_53.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_53.Text = "" Then
            kurang = 1
        End If


        If tb_54.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_54.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_54.Text = "" Then
            kurang = 1
        End If
        If tb_55.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_55.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_55.Text = "" Then
            kurang = 1
        End If
        If tb_56.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_56.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_56.Text = "" Then
            kurang = 1
        End If
        If tb_57.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_57.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_57.Text = "" Then
            kurang = 1
        End If
        If tb_58.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_58.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_58.Text = "" Then
            kurang = 1
        End If
        If tb_59.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_59.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_59.Text = "" Then
            kurang = 1
        End If
        If tb_61.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_61.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_61.Text = "" Then
            kurang = 1
        End If
        If tb_62.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_62.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_62.Text = "" Then
            kurang = 1
        End If
        If tb_63.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_63.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_64.Text = "" Then
            kurang = 1
        End If
        If tb_65.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_65.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_65.Text = "" Then
            kurang = 1
        End If

        If tb_66.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_66.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_66.Text = "" Then
            kurang = 1
        End If
        If tb_67.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_67.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_67.Text = "" Then
            kurang = 1
        End If

        If tb_68.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_68.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_68.Text = "" Then
            kurang = 1
        End If

        If tb_69.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_69.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_69.Text = "" Then
            kurang = 1
        End If
        If tb_71.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_71.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_71.Text = "" Then
            kurang = 1
        End If
        If tb_72.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_72.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_72.Text = "" Then
            kurang = 1
        End If
        If tb_73.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_73.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_73.Text = "" Then
            kurang = 1
        End If
        If tb_74.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_74.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_74.Text = "" Then
            kurang = 1
        End If
        If tb_75.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_75.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_75.Text = "" Then
            kurang = 1
        End If

        If tb_76.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_76.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_76.Text = "" Then
            kurang = 1
        End If

        If tb_77.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_77.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_77.Text = "" Then
            kurang = 1
        End If

        If tb_78.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_78.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_78.Text = "" Then
            kurang = 1
        End If

        If tb_79.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_79.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_79.Text = "" Then
            kurang = 1
        End If

        If tb_81.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_81.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_81.Text = "" Then
            kurang = 1
        End If

        If tb_82.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_82.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_82.Text = "" Then
            kurang = 1
        End If
        If tb_83.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_83.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_83.Text = "" Then
            kurang = 1
        End If
        If tb_84.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_84.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_84.Text = "" Then
            kurang = 1
        End If
        If tb_85.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_85.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_85.Text = "" Then
            kurang = 1
        End If
        If tb_86.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_86.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_86.Text = "" Then
            kurang = 1
        End If
        If tb_87.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_87.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_87.Text = "" Then
            kurang = 1
        End If
        If tb_88.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_88.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_88.Text = "" Then
            kurang = 1
        End If
        If tb_89.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_89.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_89.Text = "" Then
            kurang = 1
        End If

        If tb_91.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_91.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_91.Text = "" Then
            kurang = 1
        End If
        If tb_92.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_92.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_92.Text = "" Then
            kurang = 1
        End If
        If tb_93.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_93.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_93.Text = "" Then
            kurang = 1
        End If

        If tb_94.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_94.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_94.Text = "" Then
            kurang = 1
        End If

        If tb_95.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_95.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_95.Text = "" Then
            kurang = 1
        End If
        If tb_96.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_96.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_96.Text = "" Then
            kurang = 1
        End If
        If tb_97.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_97.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_97.Text = "" Then
            kurang = 1
        End If
        If tb_98.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_98.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_98.Text = "" Then
            kurang = 1
        End If
        If tb_99.ForeColor = Color.Black Then
            cek = cek
        ElseIf tb_99.ForeColor = Color.Red Then
            cek = cek + 1
        End If
        If tb_99.Text = "" Then
            kurang = 1
        End If








        If cek = 0 And kurang = 0 Then
            MessageBox.Show("SELAMAT ANDA MENANG!", "SELAMAT", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.Close()
            FormAWAL.Close()
        ElseIf cek > 0 And kurang = 0 Then
            MessageBox.Show("SELAMAT ANDA KALAH", "MAAF", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            FormAWAL.Close()

            End If
            If kurang = 1 Then
                MessageBox.Show("MASIH ADA YANG KOSONG!", "MAAF", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            'If tb_31.ForeColor = Color.Black Then
            '    cek = 0
            'ElseIf tb_31.ForeColor = Color.Red Then
            '    cek = 1
            'End If
            'If tb_31.Text = "" Then
            '    kurang = 1
            'End If
            'If tb_16.ForeColor = Color.Black Then
            '    cek = 0
            'ElseIf tb_16.ForeColor = Color.Red Then
            '    cek = 1
            'End If
            'If tb_16.Text = "" Then
            '    kurang = 1
            'End If

    End Sub

    Private Sub TUTUP_Click(sender As Object, e As EventArgs) Handles TUTUP.Click
        Me.Close()
        FormAWAL.Close()
    End Sub

  
    Private Sub hint_Click(sender As Object, e As EventArgs) Handles hint.Click
        r = r + 1
        If r >= 3 Then
            hint.Enabled = False


        End If

        'c = 4
        'While c > 3
        '    tb_99.Text = (Rnd() * 8) + 1
        '    c = 0
        '    For j = 1 To 9
        '        If tabel(9, 9) = tabel(9, j) Then
        '            c = c + 1
        '        End If
        '        If tabel(9, 9) = tabel(j, 9) Then
        '            c = c + 1
        '        End If
        '    Next
        '    For i = 7 To 9 'baris 
        '        For j = 7 To 9 'kolom 
        '            If tabel(9, 9) = tabel(i, j) Then
        '                c += 1
        '            End If
        '        Next
        '    Next
        'End While



        c = 4
        hint1 = Rnd() * 8 + 1
        hint2 = Rnd() * 8 + 1
        While tabel(hint1, hint2) <> 0
            hint1 = Rnd() * 8 + 1
            hint2 = Rnd() * 8 + 1
        End While
        While c > 3
            c = 0
            tabel(hint1, hint2) = Rnd() * 8 + 1
            tabel(hint1, hint2) = tabel(hint1, hint2).Substring(0, 1)
            For i = 1 To 9
                If tabel(hint1, hint2) = tabel(hint1, i) Then
                    c = c + 1
                End If
                If tabel(hint1, hint2) = tabel(i, hint2) Then
                    c = c + 1
                End If
            Next
            If hint1 <= 3 And hint2 <= 3 Then
                x = 1
                y = 3
                a = 1
                b = 3
            ElseIf hint1 <= 3 And (hint2 >= 4 And hint2 <= 6) Then
                x = 1
                y = 3
                a = 4
                b = 6
            ElseIf hint1 <= 3 And hint2 >= 7 Then
                x = 1
                y = 3
                a = 7
                b = 9
            ElseIf (hint1 >= 4 And hint1 <= 6) And hint2 <= 3 Then
                x = 4
                y = 6
                a = 1
                b = 3
            ElseIf (hint1 >= 4 And hint1 <= 6) And (hint2 >= 4 And hint2 <= 6) Then
                x = 4
                y = 6
                a = 4
                b = 6
            ElseIf (hint1 >= 4 And hint1 <= 6) And hint2 >= 7 Then
                x = 4
                y = 6
                a = 7
                b = 9
            ElseIf hint1 >= 7 And hint2 <= 3 Then
                x = 7
                y = 9
                a = 1
                b = 3
            ElseIf hint1 >= 7 And (hint2 >= 4 And hint2 <= 6) Then
                x = 7
                y = 9
                a = 4
                b = 6
            ElseIf hint1 >= 7 And hint2 >= 7 Then
                x = 7
                y = 9
                a = 7
                b = 9
            End If

            For l = x To y 'baris 
                For m = a To b 'kolom 
                    If tabel(hint1, hint2) = tabel(l, m) Then
                        c += 1
                    End If
                Next
            Next

        End While

        tb_11.Text = tabel(1, 1)
        tb_12.Text = tabel(1, 2)
        tb_13.Text = tabel(1, 3)
        tb_14.Text = tabel(1, 4)
        tb_15.Text = tabel(1, 5)
        tb_16.Text = tabel(1, 6)
        tb_17.Text = tabel(1, 7)
        tb_18.Text = tabel(1, 8)
        tb_19.Text = tabel(1, 9)
        tb_21.Text = tabel(2, 1)
        tb_22.Text = tabel(2, 2)
        tb_23.Text = tabel(2, 3)
        tb_24.Text = tabel(2, 4)
        tb_25.Text = tabel(2, 5)
        tb_26.Text = tabel(2, 6)
        tb_27.Text = tabel(2, 7)
        tb_28.Text = tabel(2, 8)
        tb_29.Text = tabel(2, 9)
        tb_31.Text = tabel(3, 1)
        tb_32.Text = tabel(3, 2)
        tb_33.Text = tabel(3, 3)
        tb_34.Text = tabel(3, 4)
        tb_35.Text = tabel(3, 5)
        tb_36.Text = tabel(3, 6)
        tb_37.Text = tabel(3, 7)
        tb_38.Text = tabel(3, 8)
        tb_39.Text = tabel(3, 9)
        tb_41.Text = tabel(4, 1)
        tb_42.Text = tabel(4, 2)
        tb_43.Text = tabel(4, 3)
        tb_44.Text = tabel(4, 4)
        tb_45.Text = tabel(4, 5)
        tb_46.Text = tabel(4, 6)
        tb_47.Text = tabel(4, 7)
        tb_48.Text = tabel(4, 8)
        tb_49.Text = tabel(4, 9)
        tb_51.Text = tabel(5, 1)
        tb_52.Text = tabel(5, 2)
        tb_53.Text = tabel(5, 3)
        tb_54.Text = tabel(5, 4)
        tb_55.Text = tabel(5, 5)
        tb_56.Text = tabel(5, 6)
        tb_57.Text = tabel(5, 7)
        tb_58.Text = tabel(5, 8)
        tb_59.Text = tabel(5, 9)
        tb_61.Text = tabel(6, 1)
        tb_62.Text = tabel(6, 2)
        tb_63.Text = tabel(6, 3)
        tb_64.Text = tabel(6, 4)
        tb_65.Text = tabel(6, 5)
        tb_66.Text = tabel(6, 6)
        tb_67.Text = tabel(6, 7)
        tb_68.Text = tabel(6, 8)
        tb_69.Text = tabel(6, 9)
        tb_71.Text = tabel(7, 1)
        tb_72.Text = tabel(7, 2)
        tb_73.Text = tabel(7, 3)
        tb_74.Text = tabel(7, 4)
        tb_75.Text = tabel(7, 5)
        tb_76.Text = tabel(7, 6)
        tb_77.Text = tabel(7, 7)
        tb_78.Text = tabel(7, 8)
        tb_79.Text = tabel(7, 9)
        tb_81.Text = tabel(8, 1)
        tb_82.Text = tabel(8, 2)
        tb_83.Text = tabel(8, 3)
        tb_84.Text = tabel(8, 4)
        tb_85.Text = tabel(8, 5)
        tb_86.Text = tabel(8, 6)
        tb_87.Text = tabel(8, 7)
        tb_88.Text = tabel(8, 8)
        tb_89.Text = tabel(8, 9)
        tb_91.Text = tabel(9, 1)
        tb_92.Text = tabel(9, 2)
        tb_93.Text = tabel(9, 3)
        tb_94.Text = tabel(9, 4)
        tb_95.Text = tabel(9, 5)
        tb_96.Text = tabel(9, 6)
        tb_97.Text = tabel(9, 7)
        tb_98.Text = tabel(9, 8)
        tb_99.Text = tabel(9, 9)





    End Sub

   

End Class
