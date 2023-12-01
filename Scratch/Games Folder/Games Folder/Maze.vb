Imports System.IO

Public Class Maze
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IconPictureBox1.Image = Image.FromFile(Application.StartupPath & "\maze Folder\maze2.png")
        [Select]()
        ActiveControl = Nothing
    End Sub

    Private Sub IconPictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles IconPictureBox2.MouseEnter
        If startBtn.Focused Then
            MessageBox.Show("Well Done")
            [Select]()
            ActiveControl = Nothing
            Panel1.Cursor = DefaultCursor
        Else

        End If


    End Sub

    Private Sub moveStart()
        Dim StartingPoint = Panel1.Location
        StartingPoint.Offset(30, 10)
        Cursor.Position = PointToScreen(StartingPoint)

    End Sub

    Private Sub Wall(sender As Object, e As EventArgs) Handles Label1.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter, Panel1.MouseEnter


        If startBtn.Focused Then
            moveStart()

        End If

    End Sub

    Private Sub startBtn_Click(sender As Object, e As EventArgs) Handles startBtn.Click
        moveStart()
    End Sub
End Class
