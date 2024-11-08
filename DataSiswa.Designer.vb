<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataSiswa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        B_SAVE = New Button()
        DTP_TGL_LAHIR = New DateTimePicker()
        CB_TPA = New CheckBox()
        CB_TOEFL = New CheckBox()
        RB_S2 = New RadioButton()
        RB_S1 = New RadioButton()
        RB_D3 = New RadioButton()
        TB_EMAIL = New TextBox()
        CB_JK = New ComboBox()
        TB_NAMA = New TextBox()
        GroupBox2 = New GroupBox()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        RTB_SERTIFIKAT = New RichTextBox()
        RTB_PENDIDIKAN = New RichTextBox()
        RTB_JK = New RichTextBox()
        RTB_EMAIL = New RichTextBox()
        RTB_TGL_LAHIR = New RichTextBox()
        RTB_NAME = New RichTextBox()
        B_EXIT = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(B_SAVE)
        GroupBox1.Controls.Add(DTP_TGL_LAHIR)
        GroupBox1.Controls.Add(CB_TPA)
        GroupBox1.Controls.Add(CB_TOEFL)
        GroupBox1.Controls.Add(RB_S2)
        GroupBox1.Controls.Add(RB_S1)
        GroupBox1.Controls.Add(RB_D3)
        GroupBox1.Controls.Add(TB_EMAIL)
        GroupBox1.Controls.Add(CB_JK)
        GroupBox1.Controls.Add(TB_NAMA)
        GroupBox1.Location = New Point(37, 40)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(702, 340)
        GroupBox1.TabIndex = 18
        GroupBox1.TabStop = False
        GroupBox1.Text = "Data Siswa"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(460, 67)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 15)
        Label6.TabIndex = 20
        Label6.Text = "Tanggal Lahir"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(289, 223)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 15)
        Label5.TabIndex = 19
        Label5.Text = "Sertifikat"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(31, 168)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 18
        Label4.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(31, 223)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 15)
        Label3.TabIndex = 17
        Label3.Text = "Pendidikan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 15)
        Label2.TabIndex = 16
        Label2.Text = "Jenis Kelamin"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(31, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 15
        Label1.Text = "Nama"
        ' 
        ' B_SAVE
        ' 
        B_SAVE.Location = New Point(585, 160)
        B_SAVE.Name = "B_SAVE"
        B_SAVE.Size = New Size(75, 23)
        B_SAVE.TabIndex = 14
        B_SAVE.Text = "Save"
        B_SAVE.UseVisualStyleBackColor = True
        ' 
        ' DTP_TGL_LAHIR
        ' 
        DTP_TGL_LAHIR.CustomFormat = "ddd, dd MMM yyyy"
        DTP_TGL_LAHIR.Format = DateTimePickerFormat.Custom
        DTP_TGL_LAHIR.Location = New Point(460, 97)
        DTP_TGL_LAHIR.Name = "DTP_TGL_LAHIR"
        DTP_TGL_LAHIR.Size = New Size(200, 23)
        DTP_TGL_LAHIR.TabIndex = 13
        ' 
        ' CB_TPA
        ' 
        CB_TPA.AutoSize = True
        CB_TPA.Location = New Point(364, 249)
        CB_TPA.Name = "CB_TPA"
        CB_TPA.Size = New Size(47, 19)
        CB_TPA.TabIndex = 12
        CB_TPA.Text = "TPA"
        CB_TPA.UseVisualStyleBackColor = True
        ' 
        ' CB_TOEFL
        ' 
        CB_TOEFL.AutoSize = True
        CB_TOEFL.Location = New Point(364, 225)
        CB_TOEFL.Name = "CB_TOEFL"
        CB_TOEFL.Size = New Size(59, 19)
        CB_TOEFL.TabIndex = 11
        CB_TOEFL.Text = "TOEFL"
        CB_TOEFL.UseVisualStyleBackColor = True
        ' 
        ' RB_S2
        ' 
        RB_S2.AutoSize = True
        RB_S2.Location = New Point(130, 273)
        RB_S2.Name = "RB_S2"
        RB_S2.Size = New Size(37, 19)
        RB_S2.TabIndex = 10
        RB_S2.TabStop = True
        RB_S2.Text = "S2"
        RB_S2.UseVisualStyleBackColor = True
        ' 
        ' RB_S1
        ' 
        RB_S1.AutoSize = True
        RB_S1.Location = New Point(130, 248)
        RB_S1.Name = "RB_S1"
        RB_S1.Size = New Size(37, 19)
        RB_S1.TabIndex = 9
        RB_S1.TabStop = True
        RB_S1.Text = "S1"
        RB_S1.UseVisualStyleBackColor = True
        ' 
        ' RB_D3
        ' 
        RB_D3.AutoSize = True
        RB_D3.Location = New Point(130, 223)
        RB_D3.Name = "RB_D3"
        RB_D3.Size = New Size(39, 19)
        RB_D3.TabIndex = 8
        RB_D3.TabStop = True
        RB_D3.Text = "D3"
        RB_D3.UseVisualStyleBackColor = True
        ' 
        ' TB_EMAIL
        ' 
        TB_EMAIL.Location = New Point(130, 160)
        TB_EMAIL.Name = "TB_EMAIL"
        TB_EMAIL.Size = New Size(195, 23)
        TB_EMAIL.TabIndex = 5
        ' 
        ' CB_JK
        ' 
        CB_JK.FormattingEnabled = True
        CB_JK.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        CB_JK.Location = New Point(130, 97)
        CB_JK.Name = "CB_JK"
        CB_JK.Size = New Size(195, 23)
        CB_JK.TabIndex = 4
        ' 
        ' TB_NAMA
        ' 
        TB_NAMA.Location = New Point(130, 34)
        TB_NAMA.Name = "TB_NAMA"
        TB_NAMA.Size = New Size(195, 23)
        TB_NAMA.TabIndex = 3
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.Control
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(RTB_SERTIFIKAT)
        GroupBox2.Controls.Add(RTB_PENDIDIKAN)
        GroupBox2.Controls.Add(RTB_JK)
        GroupBox2.Controls.Add(RTB_EMAIL)
        GroupBox2.Controls.Add(RTB_TGL_LAHIR)
        GroupBox2.Controls.Add(RTB_NAME)
        GroupBox2.Location = New Point(37, 402)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(702, 201)
        GroupBox2.TabIndex = 19
        GroupBox2.TabStop = False
        GroupBox2.Text = "Data Outpu Siswa"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(593, 60)
        Label12.Name = "Label12"
        Label12.Size = New Size(36, 15)
        Label12.TabIndex = 30
        Label12.Text = "Email"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(481, 60)
        Label11.Name = "Label11"
        Label11.Size = New Size(78, 15)
        Label11.TabIndex = 29
        Label11.Text = "Tanggal Lahir"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(367, 60)
        Label10.Name = "Label10"
        Label10.Size = New Size(53, 15)
        Label10.TabIndex = 28
        Label10.Text = "Sertifikat"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(255, 60)
        Label9.Name = "Label9"
        Label9.Size = New Size(66, 15)
        Label9.TabIndex = 27
        Label9.Text = "Pendidikan"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(143, 60)
        Label8.Name = "Label8"
        Label8.Size = New Size(78, 15)
        Label8.TabIndex = 26
        Label8.Text = "Jenis Kelamin"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(31, 60)
        Label7.Name = "Label7"
        Label7.Size = New Size(39, 15)
        Label7.TabIndex = 25
        Label7.Text = "Nama"
        ' 
        ' RTB_SERTIFIKAT
        ' 
        RTB_SERTIFIKAT.BackColor = SystemColors.Control
        RTB_SERTIFIKAT.BorderStyle = BorderStyle.FixedSingle
        RTB_SERTIFIKAT.ImeMode = ImeMode.NoControl
        RTB_SERTIFIKAT.Location = New Point(367, 82)
        RTB_SERTIFIKAT.Name = "RTB_SERTIFIKAT"
        RTB_SERTIFIKAT.Size = New Size(100, 100)
        RTB_SERTIFIKAT.TabIndex = 24
        RTB_SERTIFIKAT.Text = ""
        ' 
        ' RTB_PENDIDIKAN
        ' 
        RTB_PENDIDIKAN.BackColor = SystemColors.Control
        RTB_PENDIDIKAN.BorderStyle = BorderStyle.FixedSingle
        RTB_PENDIDIKAN.ImeMode = ImeMode.NoControl
        RTB_PENDIDIKAN.Location = New Point(255, 82)
        RTB_PENDIDIKAN.Name = "RTB_PENDIDIKAN"
        RTB_PENDIDIKAN.Size = New Size(100, 100)
        RTB_PENDIDIKAN.TabIndex = 23
        RTB_PENDIDIKAN.Text = ""
        ' 
        ' RTB_JK
        ' 
        RTB_JK.BackColor = SystemColors.Control
        RTB_JK.BorderStyle = BorderStyle.FixedSingle
        RTB_JK.ImeMode = ImeMode.NoControl
        RTB_JK.Location = New Point(143, 82)
        RTB_JK.Name = "RTB_JK"
        RTB_JK.Size = New Size(100, 100)
        RTB_JK.TabIndex = 22
        RTB_JK.Text = ""
        ' 
        ' RTB_EMAIL
        ' 
        RTB_EMAIL.BackColor = SystemColors.Control
        RTB_EMAIL.BorderStyle = BorderStyle.FixedSingle
        RTB_EMAIL.ImeMode = ImeMode.NoControl
        RTB_EMAIL.Location = New Point(593, 82)
        RTB_EMAIL.Name = "RTB_EMAIL"
        RTB_EMAIL.Size = New Size(100, 100)
        RTB_EMAIL.TabIndex = 21
        RTB_EMAIL.Text = ""
        ' 
        ' RTB_TGL_LAHIR
        ' 
        RTB_TGL_LAHIR.BackColor = SystemColors.Control
        RTB_TGL_LAHIR.BorderStyle = BorderStyle.FixedSingle
        RTB_TGL_LAHIR.ImeMode = ImeMode.NoControl
        RTB_TGL_LAHIR.Location = New Point(481, 82)
        RTB_TGL_LAHIR.Name = "RTB_TGL_LAHIR"
        RTB_TGL_LAHIR.Size = New Size(100, 100)
        RTB_TGL_LAHIR.TabIndex = 20
        RTB_TGL_LAHIR.Text = ""
        ' 
        ' RTB_NAME
        ' 
        RTB_NAME.BackColor = SystemColors.Control
        RTB_NAME.BorderStyle = BorderStyle.FixedSingle
        RTB_NAME.ImeMode = ImeMode.NoControl
        RTB_NAME.Location = New Point(31, 82)
        RTB_NAME.Name = "RTB_NAME"
        RTB_NAME.Size = New Size(100, 100)
        RTB_NAME.TabIndex = 16
        RTB_NAME.Text = ""
        ' 
        ' B_EXIT
        ' 
        B_EXIT.Location = New Point(664, 621)
        B_EXIT.Name = "B_EXIT"
        B_EXIT.Size = New Size(75, 23)
        B_EXIT.TabIndex = 20
        B_EXIT.Text = "Exit"
        B_EXIT.UseVisualStyleBackColor = True
        ' 
        ' DataSiswa
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(783, 656)
        Controls.Add(B_EXIT)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "DataSiswa"
        Text = "Data Siswa"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents B_SAVE As Button
    Friend WithEvents DTP_TGL_LAHIR As DateTimePicker
    Friend WithEvents CB_TPA As CheckBox
    Friend WithEvents CB_TOEFL As CheckBox
    Friend WithEvents RB_S2 As RadioButton
    Friend WithEvents RB_S1 As RadioButton
    Friend WithEvents RB_D3 As RadioButton
    Friend WithEvents TB_EMAIL As TextBox
    Friend WithEvents CB_JK As ComboBox
    Friend WithEvents TB_NAMA As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RichTextBox5 As RichTextBox
    Friend WithEvents RichTextBox4 As RichTextBox
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents RTB_NAME As RichTextBox
    Friend WithEvents RTB_EMAIL As RichTextBox
    Friend WithEvents RTB_TGL_LAHIR As RichTextBox
    Friend WithEvents RTB_JK As RichTextBox
    Friend WithEvents RTB_PENDIDIKAN As RichTextBox
    Friend WithEvents RTB_SERTIFIKAT As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents B_EXIT As Button

End Class
