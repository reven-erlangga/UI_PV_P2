Imports System.Globalization
Imports System.Net.Mail
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class DataSiswa

    Dim Pendidikan As String
    Dim Sertifikat As String
    Dim EmailAddress As MailAddress

    Private Sub B_EXIT_Click(sender As Object, e As EventArgs) Handles B_EXIT.Click
        Me.Close()
    End Sub

    Private Sub B_SAVE_Click(sender As Object, e As EventArgs) Handles B_SAVE.Click
        Clear_Form()

        Validation_Form()

    End Sub

    Private Sub Clear_Form()
        Sertifikat = Nothing

        RTB_NAME.Text = ""
        RTB_JK.Text = ""
        RTB_PENDIDIKAN.Text = ""
        RTB_EMAIL.Text = ""
        RTB_TGL_LAHIR.Text = ""

    End Sub

    Private Sub Validation_Form()
        Dim allFields = New List(Of KeyValuePair(Of String, String)) From {
            New KeyValuePair(Of String, String)("nama", TB_NAMA.Text),
            New KeyValuePair(Of String, String)("jenis kelamin", CB_JK.Text),
            New KeyValuePair(Of String, String)("pendidikan", Pendidikan),
            New KeyValuePair(Of String, String)("email", TB_EMAIL.Text),
            New KeyValuePair(Of String, String)("tangal lahir", DTP_TGL_LAHIR.Text)
        }
        Dim invalids = From kv In allFields Where String.IsNullOrEmpty(kv.Value)

        For Each invalid In invalids
            MsgBox("Harap masukan " + invalid.Key)

            Return
        Next

        Save_Form()
    End Sub

    Private Sub Save_Form()

        RTB_NAME.Text = TB_NAMA.Text
        RTB_JK.Text = CB_JK.Text
        RTB_PENDIDIKAN.Text = Pendidikan
        RTB_EMAIL.Text = EmailAddress.ToString()
        RTB_TGL_LAHIR.Text = Date.Parse(DTP_TGL_LAHIR.Value)


        If CB_TOEFL.Checked = True Then
            Sertifikat &= "TOEFL"
            Sertifikat &= "+"
        End If
        If CB_TPA.Checked = True Then
            Sertifikat &= "TPA Bapennas"
            Sertifikat &= "+"
        End If

        If String.IsNullOrEmpty(Sertifikat) = False Then
            RTB_SERTIFIKAT.Text = Sertifikat.Substring(0, Sertifikat.Length - 1)
        End If
    End Sub

    Private Sub RB_D3_CheckedChanged(sender As Object, e As EventArgs) Handles RB_D3.CheckedChanged
        Pendidikan = "Diploma - D3"
    End Sub

    Private Sub RB_S1_CheckedChanged(sender As Object, e As EventArgs) Handles RB_S1.CheckedChanged
        Pendidikan = "Strata - S1"
    End Sub

    Private Sub RB_S2_CheckedChanged(sender As Object, e As EventArgs) Handles RB_S2.CheckedChanged
        Pendidikan = "Magister - S2"
    End Sub

    Private Sub TB_EMAIL_TextChanged(sender As Object, e As EventArgs) Handles TB_EMAIL.TextChanged
        TB_EMAIL.BackColor = Color.White
        Dim temp As String
        temp = TB_EMAIL.Text

        If MailAddress.TryCreate(TB_EMAIL.Text, EmailAddress) Then
            TB_EMAIL.BackColor = Color.White
            B_SAVE.Enabled = True
        Else
            TB_EMAIL.BackColor = Color.Red
            B_SAVE.Enabled = False
        End If

    End Sub
End Class
