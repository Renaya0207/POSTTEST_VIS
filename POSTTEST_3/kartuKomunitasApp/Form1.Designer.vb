<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        pictureBoxProfile = New PictureBox()
        btnUploadFoto = New Button()
        GroupBox1 = New GroupBox()
        datePickerTgllahir = New DateTimePicker()
        txtAlamat = New TextBox()
        txtnoTelp = New TextBox()
        txtUmur = New TextBox()
        txtNama = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        radioPerempuan = New RadioButton()
        radiolakiLaki = New RadioButton()
        GroupBox3 = New GroupBox()
        checkboxMenulis = New CheckBox()
        checkboxMenggambar = New CheckBox()
        checkboxFotographi = New CheckBox()
        checkboxTraveling = New CheckBox()
        checkboxmembaca = New CheckBox()
        checkboxBerenang = New CheckBox()
        checkboxMainMusic = New CheckBox()
        checkboxMainPiano = New CheckBox()
        checkboxMenari = New CheckBox()
        checkboxBernyanyi = New CheckBox()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        btnCetak = New Button()
        CType(pictureBoxProfile, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pictureBoxProfile
        ' 
        pictureBoxProfile.BorderStyle = BorderStyle.FixedSingle
        pictureBoxProfile.Location = New Point(13, 97)
        pictureBoxProfile.Name = "pictureBoxProfile"
        pictureBoxProfile.Size = New Size(308, 282)
        pictureBoxProfile.SizeMode = PictureBoxSizeMode.Zoom
        pictureBoxProfile.TabIndex = 0
        pictureBoxProfile.TabStop = False
        ' 
        ' btnUploadFoto
        ' 
        btnUploadFoto.Location = New Point(131, 388)
        btnUploadFoto.Name = "btnUploadFoto"
        btnUploadFoto.Size = New Size(75, 23)
        btnUploadFoto.TabIndex = 1
        btnUploadFoto.Text = "Browse"
        btnUploadFoto.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(datePickerTgllahir)
        GroupBox1.Controls.Add(txtAlamat)
        GroupBox1.Controls.Add(txtnoTelp)
        GroupBox1.Controls.Add(txtUmur)
        GroupBox1.Controls.Add(txtNama)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(340, 97)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(321, 210)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Profile"
        ' 
        ' datePickerTgllahir
        ' 
        datePickerTgllahir.Location = New Point(120, 125)
        datePickerTgllahir.Name = "datePickerTgllahir"
        datePickerTgllahir.Size = New Size(195, 23)
        datePickerTgllahir.TabIndex = 9
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(120, 159)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(195, 23)
        txtAlamat.TabIndex = 8
        ' 
        ' txtnoTelp
        ' 
        txtnoTelp.Location = New Point(120, 93)
        txtnoTelp.Name = "txtnoTelp"
        txtnoTelp.Size = New Size(195, 23)
        txtnoTelp.TabIndex = 7
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(120, 59)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(195, 23)
        txtUmur.TabIndex = 6
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(120, 27)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(195, 23)
        txtNama.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(23, 162)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 15)
        Label5.TabIndex = 4
        Label5.Text = "Alamat"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(23, 129)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 15)
        Label4.TabIndex = 3
        Label4.Text = "Tanggal Lahir"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(23, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 15)
        Label3.TabIndex = 2
        Label3.Text = "No Telepon"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(23, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 1
        Label2.Text = "Umur"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(23, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(radioPerempuan)
        GroupBox2.Controls.Add(radiolakiLaki)
        GroupBox2.Location = New Point(343, 313)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(318, 69)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Jenis Kelamin"
        ' 
        ' radioPerempuan
        ' 
        radioPerempuan.AutoSize = True
        radioPerempuan.Location = New Point(120, 35)
        radioPerempuan.Name = "radioPerempuan"
        radioPerempuan.Size = New Size(86, 19)
        radioPerempuan.TabIndex = 1
        radioPerempuan.TabStop = True
        radioPerempuan.Text = "Perempuan"
        radioPerempuan.UseVisualStyleBackColor = True
        ' 
        ' radiolakiLaki
        ' 
        radiolakiLaki.AutoSize = True
        radiolakiLaki.Location = New Point(23, 35)
        radiolakiLaki.Name = "radiolakiLaki"
        radiolakiLaki.Size = New Size(78, 19)
        radiolakiLaki.TabIndex = 0
        radiolakiLaki.TabStop = True
        radiolakiLaki.Text = "Laki - Laki"
        radiolakiLaki.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(checkboxMenulis)
        GroupBox3.Controls.Add(checkboxMenggambar)
        GroupBox3.Controls.Add(checkboxFotographi)
        GroupBox3.Controls.Add(checkboxTraveling)
        GroupBox3.Controls.Add(checkboxmembaca)
        GroupBox3.Controls.Add(checkboxBerenang)
        GroupBox3.Controls.Add(checkboxMainMusic)
        GroupBox3.Controls.Add(checkboxMainPiano)
        GroupBox3.Controls.Add(checkboxMenari)
        GroupBox3.Controls.Add(checkboxBernyanyi)
        GroupBox3.Location = New Point(687, 97)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(163, 285)
        GroupBox3.TabIndex = 4
        GroupBox3.TabStop = False
        GroupBox3.Text = "Hobi"
        ' 
        ' checkboxMenulis
        ' 
        checkboxMenulis.AutoSize = True
        checkboxMenulis.Location = New Point(18, 258)
        checkboxMenulis.Name = "checkboxMenulis"
        checkboxMenulis.Size = New Size(68, 19)
        checkboxMenulis.TabIndex = 9
        checkboxMenulis.Text = "Menulis"
        checkboxMenulis.UseVisualStyleBackColor = True
        ' 
        ' checkboxMenggambar
        ' 
        checkboxMenggambar.AutoSize = True
        checkboxMenggambar.Location = New Point(18, 233)
        checkboxMenggambar.Name = "checkboxMenggambar"
        checkboxMenggambar.Size = New Size(98, 19)
        checkboxMenggambar.TabIndex = 8
        checkboxMenggambar.Text = "Menggambar"
        checkboxMenggambar.UseVisualStyleBackColor = True
        ' 
        ' checkboxFotographi
        ' 
        checkboxFotographi.AutoSize = True
        checkboxFotographi.Location = New Point(18, 208)
        checkboxFotographi.Name = "checkboxFotographi"
        checkboxFotographi.Size = New Size(84, 19)
        checkboxFotographi.TabIndex = 7
        checkboxFotographi.Text = "Fotographi"
        checkboxFotographi.UseVisualStyleBackColor = True
        ' 
        ' checkboxTraveling
        ' 
        checkboxTraveling.AutoSize = True
        checkboxTraveling.Location = New Point(18, 183)
        checkboxTraveling.Name = "checkboxTraveling"
        checkboxTraveling.Size = New Size(73, 19)
        checkboxTraveling.TabIndex = 6
        checkboxTraveling.Text = "Traveling"
        checkboxTraveling.UseVisualStyleBackColor = True
        ' 
        ' checkboxmembaca
        ' 
        checkboxmembaca.AutoSize = True
        checkboxmembaca.Location = New Point(18, 158)
        checkboxmembaca.Name = "checkboxmembaca"
        checkboxmembaca.Size = New Size(79, 19)
        checkboxmembaca.TabIndex = 5
        checkboxmembaca.Text = "Membaca"
        checkboxmembaca.UseVisualStyleBackColor = True
        ' 
        ' checkboxBerenang
        ' 
        checkboxBerenang.AutoSize = True
        checkboxBerenang.Location = New Point(18, 130)
        checkboxBerenang.Name = "checkboxBerenang"
        checkboxBerenang.Size = New Size(76, 19)
        checkboxBerenang.TabIndex = 4
        checkboxBerenang.Text = "Berenang"
        checkboxBerenang.UseVisualStyleBackColor = True
        ' 
        ' checkboxMainMusic
        ' 
        checkboxMainMusic.AutoSize = True
        checkboxMainMusic.Location = New Point(18, 104)
        checkboxMainMusic.Name = "checkboxMainMusic"
        checkboxMainMusic.Size = New Size(88, 19)
        checkboxMainMusic.TabIndex = 3
        checkboxMainMusic.Text = "Main Musik"
        checkboxMainMusic.UseVisualStyleBackColor = True
        ' 
        ' checkboxMainPiano
        ' 
        checkboxMainPiano.AutoSize = True
        checkboxMainPiano.Location = New Point(18, 79)
        checkboxMainPiano.Name = "checkboxMainPiano"
        checkboxMainPiano.Size = New Size(86, 19)
        checkboxMainPiano.TabIndex = 2
        checkboxMainPiano.Text = "Main Piano"
        checkboxMainPiano.UseVisualStyleBackColor = True
        ' 
        ' checkboxMenari
        ' 
        checkboxMenari.AutoSize = True
        checkboxMenari.Location = New Point(18, 54)
        checkboxMenari.Name = "checkboxMenari"
        checkboxMenari.Size = New Size(63, 19)
        checkboxMenari.TabIndex = 1
        checkboxMenari.Text = "Menari"
        checkboxMenari.UseVisualStyleBackColor = True
        ' 
        ' checkboxBernyanyi
        ' 
        checkboxBernyanyi.AutoSize = True
        checkboxBernyanyi.Location = New Point(18, 29)
        checkboxBernyanyi.Name = "checkboxBernyanyi"
        checkboxBernyanyi.Size = New Size(78, 19)
        checkboxBernyanyi.TabIndex = 0
        checkboxBernyanyi.Text = "Bernyanyi"
        checkboxBernyanyi.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Maroon
        Label6.Location = New Point(262, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(342, 45)
        Label6.TabIndex = 6
        Label6.Text = "MARVEL UNIVERSITY"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(610, 14)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 50)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(156, 19)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(100, 50)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(340, 388)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(158, 23)
        btnCetak.TabIndex = 5
        btnCetak.Text = "Cetak"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(880, 450)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label6)
        Controls.Add(btnCetak)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(btnUploadFoto)
        Controls.Add(pictureBoxProfile)
        Name = "Form1"
        Text = "Form1"
        CType(pictureBoxProfile, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pictureBoxProfile As PictureBox
    Friend WithEvents btnUploadFoto As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents datePickerTgllahir As DateTimePicker
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtnoTelp As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents radioPerempuan As RadioButton
    Friend WithEvents radiolakiLaki As RadioButton
    Friend WithEvents checkboxMenulis As CheckBox
    Friend WithEvents checkboxMenggambar As CheckBox
    Friend WithEvents checkboxFotographi As CheckBox
    Friend WithEvents checkboxTraveling As CheckBox
    Friend WithEvents checkboxmembaca As CheckBox
    Friend WithEvents checkboxBerenang As CheckBox
    Friend WithEvents checkboxMainMusic As CheckBox
    Friend WithEvents checkboxMainPiano As CheckBox
    Friend WithEvents checkboxMenari As CheckBox
    Friend WithEvents checkboxBernyanyi As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnCetak As Button

End Class
