Public Class Form1

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        If txtValue.Text.Trim <> "" And txtArz.Text.Trim <> "" And txtDolar.Text.Trim <> "" Then
            Dim _kol, _10, _static As Integer
            _kol = Val(txtValue.Text) * Val(txtArz.Text)
            L_Kol.Text = _kol.ToString("N0")

            _10 = (_kol * 10) / 100
            L_10.Text = _10.ToString("N0")

            _static = Val(_add.Text) * txtDolar.Text
            L_Static.Text = _static.ToString("N0")

            L_Result.Text = Val(_kol + _10 + _static).ToString("N0")
            L_Final.Text = Math.Round(Convert.ToDouble(L_Result.Text.Replace(",", "."))).ToString
            '3723
        End If
    End Sub
End Class
