
Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PictureBox1.Image = Image.FromFile(Application.StartupPath & "\main Folder\gaming.png")
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch

        mazeBtn.Image = Image.FromFile(Application.StartupPath & "\main Folder\mazeBtn.png")


        rpgBtn.Image = Image.FromFile(Application.StartupPath & "\main Folder\rpgBtn.png")


        chessBtn.Image = Image.FromFile(Application.StartupPath & "\main Folder\chessBtn.png")



    End Sub

    Private Sub mazeBtn_Click(sender As Object, e As EventArgs) Handles mazeBtn.Click


    End Sub

End Class