Public Class Form1
    Dim a As Integer
    Dim i As Integer
    Dim n As Integer
    Private Sub Form1_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        MessageBox.Show("There's nothing here!", "Error")
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("Pick where you are, and then click on your destination", "Welcome")
        a = 1
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            a = 1
        End If
        If RadioButton2.Checked = True Then
            a = 0
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton1.Checked = True Then
            a = 1
        End If
        If RadioButton2.Checked = True Then
            a = 0
        End If
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        For Each c As Control In Me.Controls
            If TypeOf c Is Label Then
                c.Hide()
            End If
        Next
        If a = 1 Then
            LineShape2.Show()
            LineShape3.Show()
            LineShape4.Show()
            LineShape20.Show()
            LineShape28.Show()
        Else
            LineShape27.Show()
            LineShape29.Show()
            LineShape6.Show()
            LineShape18.Show()
            LineShape20.Show()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Application.Restart()
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        For Each c As Control In Me.Controls
            If TypeOf c Is Label Then
                c.Hide()
            End If
        Next
        If a = 1 Then
            LineShape2.Show()
            LineShape3.Show()
        Else
            LineShape27.Show()
            LineShape29.Show()
            LineShape6.Show()
            LineShape18.Show()
            LineShape4.Show()
            LineShape28.Show()
        End If
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        For Each c As Control In Me.Controls
            If TypeOf c Is Label Then
                c.Hide()
            End If
        Next
        If a = 1 Then
            LineShape2.Show()
            LineShape3.Show()
            LineShape28.Show()
            LineShape4.Show()
            LineShape18.Show()
            LineShape6.Show()
        Else
            LineShape27.Show()
            LineShape29.Show()
        End If
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click
        For Each c As Control In Me.Controls
            If TypeOf c Is Label Then
                c.Hide()
            End If
        Next
        If a = 1 Then  
        LineShape2.Show()
        LineShape3.Show()
        LineShape28.Show()
        LineShape4.Show()
        LineShape18.Show()
        LineShape6.Show()
        LineShape29.Show()
        LineShape8.Show()
        Else
            LineShape27.Show()
            LineShape8.Show()
        End If
    End Sub

    Private Sub Label10_Click(sender As System.Object, e As System.EventArgs) Handles Label10.Click
        For Each c As Control In Me.Controls
            If TypeOf c Is Label Then
                c.Hide()
            End If
        Next
        If a = 1 Then
            LineShape2.Show()
            LineShape3.Show()
            LineShape28.Show()
            LineShape30.Show()
            LineShape5.Show()
        Else
            LineShape27.Show()
            LineShape8.Show()
            LineShape19.Show()
            LineShape21.Show()
        End If
    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click
        For Each c As Control In Me.Controls
            If TypeOf c Is Label Then
                c.Hide()
            End If
        Next
        If a = 1 Then
            LineShape1.Show()
        Else
            LineShape27.Show()
            LineShape29.Show()
            LineShape6.Show()
            LineShape7.Show()
            LineShape5.Show()
        End If
    End Sub

    Private Sub Label11_Click(sender As System.Object, e As System.EventArgs) Handles Label11.Click
        For Each c As Control In Me.Controls
            If TypeOf c Is Label Then
                c.Hide()
            End If
        Next
        If a = 1 Then
            LineShape1.Show()
            LineShape9.Show()
            LineShape10.Show()
            LineShape13.Show()
            LineShape11.Show()
        Else
            LineShape27.Show()
            LineShape8.Show()
            LineShape19.Show()
            LineShape22.Show()
            LineShape23.Show()
            LineShape15.Show()
            LineShape24.Show()
            LineShape25.Show()
        End If
    End Sub

    Private Sub Label8_Click(sender As System.Object, e As System.EventArgs) Handles Label8.Click
        For Each c As Control In Me.Controls
            If TypeOf c Is Label Then
                c.Hide()
            End If
        Next
        If a = 1 Then
            LineShape1.Show()
            LineShape9.Show()
            LineShape10.Show()
            LineShape13.Show()
            LineShape11.Show()
        Else
            LineShape27.Show()
            LineShape8.Show()
            LineShape19.Show()
            LineShape22.Show()
            LineShape23.Show()
            LineShape15.Show()
            LineShape24.Show()
            LineShape25.Show()
            LineShape26.Show()
        End If
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click
        For Each c As Control In Me.Controls
            If TypeOf c Is Label Then
                c.Hide()
            End If
        Next
        If a = 1 Then
            LineShape1.Show()
            LineShape9.Show()
            LineShape10.Show()
            LineShape13.Show()
            LineShape14.Show()
            LineShape15.Show()
            LineShape16.Show()
            LineShape17.Show()
        Else
            LineShape27.Show()
            LineShape8.Show()
            LineShape19.Show()
            LineShape22.Show()
            LineShape31.Show()
            LineShape32.Show()
            LineShape33.Show()
            LineShape17.Show()
        End If
    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click
        For Each c As Control In Me.Controls
            If TypeOf c Is Label Then
                c.Hide()
            End If
        Next
        If a = 1 Then
            LineShape1.Show()
            LineShape9.Show()
            LineShape10.Show()
            LineShape13.Show()
            LineShape11.Show()
            LineShape12.Show()
        Else
            LineShape27.Show()
            LineShape8.Show()
            LineShape19.Show()
            LineShape22.Show()
            LineShape31.Show()
            LineShape32.Show()
            LineShape33.Show()
            LineShape17.Show()
            LineShape34.Show()
            LineShape35.Show()
        End If
    End Sub
End Class

