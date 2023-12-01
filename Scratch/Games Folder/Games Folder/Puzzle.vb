Public Class Puzzle


    Private Sub Puzzle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        [Select]()
        ActiveControl = Nothing
        PictureBox2.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\pzlimg.png")

        Button1.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img1.jpg")
        Button1.BackgroundImageLayout = ImageLayout.Stretch

        Button2.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img2.jpg")
        Button2.BackgroundImageLayout = ImageLayout.Stretch

        Button3.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img3.jpg")
        Button3.BackgroundImageLayout = ImageLayout.Stretch

        Button4.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img4.jpg")
        Button4.BackgroundImageLayout = ImageLayout.Stretch

        Button5.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img5.jpg")
        Button5.BackgroundImageLayout = ImageLayout.Stretch

        Button6.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img6.jpg")
        Button6.BackgroundImageLayout = ImageLayout.Stretch

        Button7.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img7.jpg")
        Button7.BackgroundImageLayout = ImageLayout.Stretch

        Button8.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img8.jpg")
        Button8.BackgroundImageLayout = ImageLayout.Stretch

        Button9.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img9.jpg")
        Button9.BackgroundImageLayout = ImageLayout.Stretch

        Button10.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img10.jpg")
        Button10.BackgroundImageLayout = ImageLayout.Stretch

        Button11.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img11.jpg")
        Button11.BackgroundImageLayout = ImageLayout.Stretch

        Button12.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img12.jpg")
        Button12.BackgroundImageLayout = ImageLayout.Stretch

        Button13.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img13.jpg")
        Button13.BackgroundImageLayout = ImageLayout.Stretch

        Button14.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img14.jpg")
        Button14.BackgroundImageLayout = ImageLayout.Stretch

        Button15.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img15.jpg")
        Button15.BackgroundImageLayout = ImageLayout.Stretch

        Button16.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img16.jpg")
        Button16.BackgroundImageLayout = ImageLayout.Stretch

        For Each btn As Button In Panel2.Controls.OfType(Of Button)
            btn.Enabled = False
        Next


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cbelev1(Button1, Button2)
        cbelev1(Button1, Button5)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cbelev1(Button2, Button1)
        cbelev1(Button2, Button3)
        cbelev1(Button2, Button6)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cbelev1(Button3, Button2)
        cbelev1(Button3, Button4)
        cbelev1(Button3, Button7)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cbelev1(Button4, Button3)
        cbelev1(Button4, Button8)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cbelev1(Button5, Button1)
        cbelev1(Button5, Button6)
        cbelev1(Button5, Button9)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        cbelev1(Button6, Button2)
        cbelev1(Button6, Button5)
        cbelev1(Button6, Button7)
        cbelev1(Button6, Button10)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        cbelev1(Button7, Button3)
        cbelev1(Button7, Button6)
        cbelev1(Button7, Button8)
        cbelev1(Button7, Button11)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        cbelev1(Button8, Button4)
        cbelev1(Button8, Button7)
        cbelev1(Button8, Button12)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        cbelev1(Button9, Button5)
        cbelev1(Button9, Button10)
        cbelev1(Button9, Button13)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        cbelev1(Button10, Button6)
        cbelev1(Button10, Button9)
        cbelev1(Button10, Button11)
        cbelev1(Button10, Button14)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        cbelev1(Button11, Button7)
        cbelev1(Button11, Button10)
        cbelev1(Button11, Button12)
        cbelev1(Button11, Button15)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        cbelev1(Button12, Button8)
        cbelev1(Button12, Button11)
        cbelev1(Button12, Button16)

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        cbelev1(Button13, Button9)
        cbelev1(Button13, Button14)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        cbelev1(Button14, Button10)
        cbelev1(Button14, Button13)
        cbelev1(Button14, Button15)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        cbelev1(Button15, Button11)
        cbelev1(Button15, Button14)
        cbelev1(Button15, Button16)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        cbelev1(Button16, Button12)
        cbelev1(Button16, Button15)
    End Sub

    Private Sub startBtn_Click(sender As Object, e As EventArgs) Handles startBtn.Click
        Button1.Text = String.Empty
        Button1.BackgroundImage = Nothing

        For Each btn As Button In Panel2.Controls.OfType(Of Button)
            btn.Enabled = True
            btn.ForeColor = Color.Red
        Next

        Button16.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img2.jpg")
        Button16.BackgroundImageLayout = ImageLayout.Stretch
        Button16.Text = "2"

        Button15.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img3.jpg")
        Button15.BackgroundImageLayout = ImageLayout.Stretch
        Button15.Text = "3"


        Button14.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img4.jpg")
        Button14.BackgroundImageLayout = ImageLayout.Stretch
        Button14.Text = "4"


        Button13.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img5.jpg")
        Button13.BackgroundImageLayout = ImageLayout.Stretch
        Button13.Text = "5"


        Button12.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img6.jpg")
        Button12.BackgroundImageLayout = ImageLayout.Stretch
        Button12.Text = "6"


        Button11.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img7.jpg")
        Button11.BackgroundImageLayout = ImageLayout.Stretch
        Button11.Text = "7"


        Button10.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img8.jpg")
        Button10.BackgroundImageLayout = ImageLayout.Stretch
        Button10.Text = "8"


        Button9.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img9.jpg")
        Button9.BackgroundImageLayout = ImageLayout.Stretch
        Button9.Text = "9"

        Button8.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img10.jpg")
        Button8.BackgroundImageLayout = ImageLayout.Stretch
        Button8.Text = "10"

        Button7.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img11.jpg")
        Button7.BackgroundImageLayout = ImageLayout.Stretch
        Button7.Text = "11"

        Button6.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img12.jpg")
        Button6.BackgroundImageLayout = ImageLayout.Stretch
        Button6.Text = "12"

        Button5.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img13.jpg")
        Button5.BackgroundImageLayout = ImageLayout.Stretch
        Button5.Text = "13"

        Button4.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img14.jpg")
        Button4.BackgroundImageLayout = ImageLayout.Stretch
        Button4.Text = "14"

        Button3.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img15.jpg")
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.Text = "15"

        Button2.BackgroundImage = Image.FromFile(Application.StartupPath & "\puzzle Folder\img16.jpg")
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Text = "16"


    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click

    End Sub

End Class