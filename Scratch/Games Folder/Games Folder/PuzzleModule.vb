Module PuzzleModule
    Sub cbelev1(ByRef btn1 As Button, ByRef btn2 As Button)
        If btn2.Text = "" Then
            btn2.Text = btn1.Text
            btn2.BackgroundImage = btn1.BackgroundImage
            btn1.Text = ""
            btn1.BackgroundImage = Nothing
        End If
    End Sub

End Module
