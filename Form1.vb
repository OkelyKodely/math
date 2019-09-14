Public Class Form1

    Private rd As New Random
    Private num1 As Integer
    Private num2 As Integer
    Private ans As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Init()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            Return
        End If
        If CInt(TextBox1.Text) = ans Then
            Label2.ForeColor = Color.Green
            Label2.Text = "Correct"
        Else
            Label2.ForeColor = Color.Red
            Label2.Text = "Wrong"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Init()
    End Sub

    Private Sub Init()
        num1 = rd.Next(100)
        num2 = rd.Next(100)
        ans = num1 + num2
        Label1.Text = CStr(num1) & " + " & CStr(num2) & " = "
    End Sub
End Class