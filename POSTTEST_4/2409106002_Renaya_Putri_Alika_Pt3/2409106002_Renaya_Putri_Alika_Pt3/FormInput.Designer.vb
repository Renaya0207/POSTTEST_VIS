<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInput
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        TabControl1 = New TabControl()
        tabData = New TabPage()
        txtID = New TextBox()
        txtNama = New TextBox()
        TabKontak = New TabPage()
        tabProfil = New TabPage()
        dtpTanggal = New DateTimePicker()
        rbLaki = New RadioButton()
        rbPerempuan = New RadioButton()
        cmbKomunitas = New ComboBox()
        mtbHP = New MaskedTextBox()
        txtEmail = New TextBox()
        txtAlamat = New TextBox()
        picFoto = New PictureBox()
        btnBrowse = New RadioButton()
        grpPeran = New GroupBox()
        cb8 = New CheckBox()
        cb7 = New CheckBox()
        cb6 = New CheckBox()
        cb5 = New CheckBox()
        cb4 = New CheckBox()
        cb3 = New CheckBox()
        cb2 = New CheckBox()
        cb1 = New CheckBox()
        rbAnggota = New RadioButton()
        rbAdmin = New RadioButton()
        rbKetua = New RadioButton()
        btnSimpan = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        TabControl1.SuspendLayout()
        tabData.SuspendLayout()
        TabKontak.SuspendLayout()
        tabProfil.SuspendLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        grpPeran.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tabData)
        TabControl1.Controls.Add(TabKontak)
        TabControl1.Controls.Add(tabProfil)
        TabControl1.Location = New Point(28, 21)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(300, 315)
        TabControl1.TabIndex = 0
        ' 
        ' tabData
        ' 
        tabData.Controls.Add(txtID)
        tabData.Controls.Add(txtNama)
        tabData.Controls.Add(dtpTanggal)
        tabData.Controls.Add(cmbKomunitas)
        tabData.Location = New Point(4, 34)
        tabData.Name = "tabData"
        tabData.Padding = New Padding(3)
        tabData.Size = New Size(292, 178)
        tabData.TabIndex = 0
        tabData.Text = "Data Utama"
        tabData.UseVisualStyleBackColor = True
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(13, 54)
        txtID.Name = "txtID"
        txtID.PlaceholderText = "Masukkan ID"
        txtID.Size = New Size(150, 31)
        txtID.TabIndex = 2
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(12, 17)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Masukkan Nama"
        txtNama.Size = New Size(150, 31)
        txtNama.TabIndex = 1
        ' 
        ' TabKontak
        ' 
        TabKontak.Controls.Add(mtbHP)
        TabKontak.Controls.Add(txtEmail)
        TabKontak.Controls.Add(txtAlamat)
        TabKontak.Location = New Point(4, 34)
        TabKontak.Name = "TabKontak"
        TabKontak.Padding = New Padding(3)
        TabKontak.Size = New Size(292, 178)
        TabKontak.TabIndex = 1
        TabKontak.Text = "Kontak"
        TabKontak.UseVisualStyleBackColor = True
        ' 
        ' tabProfil
        ' 
        tabProfil.Controls.Add(picFoto)
        tabProfil.Controls.Add(btnBrowse)
        tabProfil.Controls.Add(rbPerempuan)
        tabProfil.Controls.Add(rbLaki)
        tabProfil.Location = New Point(4, 34)
        tabProfil.Name = "tabProfil"
        tabProfil.Padding = New Padding(3)
        tabProfil.Size = New Size(292, 277)
        tabProfil.TabIndex = 2
        tabProfil.Text = "Profil"
        tabProfil.UseVisualStyleBackColor = True
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Format = DateTimePickerFormat.Short
        dtpTanggal.Location = New Point(3, 98)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(204, 31)
        dtpTanggal.TabIndex = 1
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(6, 242)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(114, 29)
        rbLaki.TabIndex = 2
        rbLaki.TabStop = True
        rbLaki.Text = "Laki - Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(160, 245)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(126, 29)
        rbPerempuan.TabIndex = 3
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' cmbKomunitas
        ' 
        cmbKomunitas.DropDownStyle = ComboBoxStyle.DropDownList
        cmbKomunitas.FormattingEnabled = True
        cmbKomunitas.Items.AddRange(New Object() {"Avengers", "", "Spider-Man", "", "Guardians", "", "X-Men"})
        cmbKomunitas.Location = New Point(3, 135)
        cmbKomunitas.Name = "cmbKomunitas"
        cmbKomunitas.Size = New Size(152, 33)
        cmbKomunitas.TabIndex = 4
        ' 
        ' mtbHP
        ' 
        mtbHP.Location = New Point(12, 33)
        mtbHP.Mask = "0000-0000-0000"
        mtbHP.Name = "mtbHP"
        mtbHP.Size = New Size(150, 31)
        mtbHP.TabIndex = 5
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(13, 87)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.Size = New Size(150, 31)
        txtEmail.TabIndex = 6
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(13, 142)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.PlaceholderText = "Alamat"
        txtAlamat.Size = New Size(150, 30)
        txtAlamat.TabIndex = 7
        ' 
        ' picFoto
        ' 
        picFoto.Location = New Point(37, 19)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(209, 175)
        picFoto.SizeMode = PictureBoxSizeMode.StretchImage
        picFoto.TabIndex = 8
        picFoto.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.AutoSize = True
        btnBrowse.ImageAlign = ContentAlignment.TopLeft
        btnBrowse.Location = New Point(93, 210)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(94, 29)
        btnBrowse.TabIndex = 9
        btnBrowse.TabStop = True
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' grpPeran
        ' 
        grpPeran.Controls.Add(cb8)
        grpPeran.Controls.Add(cb7)
        grpPeran.Controls.Add(cb6)
        grpPeran.Controls.Add(cb5)
        grpPeran.Controls.Add(cb4)
        grpPeran.Controls.Add(cb3)
        grpPeran.Controls.Add(cb2)
        grpPeran.Controls.Add(cb1)
        grpPeran.Controls.Add(rbAnggota)
        grpPeran.Controls.Add(rbAdmin)
        grpPeran.Controls.Add(rbKetua)
        grpPeran.ImeMode = ImeMode.Disable
        grpPeran.Location = New Point(420, 55)
        grpPeran.Name = "grpPeran"
        grpPeran.Size = New Size(300, 200)
        grpPeran.TabIndex = 10
        grpPeran.TabStop = False
        grpPeran.Text = "Pilih Peran"
        ' 
        ' cb8
        ' 
        cb8.AutoSize = True
        cb8.Location = New Point(168, 158)
        cb8.Name = "cb8"
        cb8.Size = New Size(71, 29)
        cb8.TabIndex = 10
        cb8.Text = "Film"
        cb8.UseVisualStyleBackColor = True
        ' 
        ' cb7
        ' 
        cb7.AutoSize = True
        cb7.Location = New Point(168, 123)
        cb7.Name = "cb7"
        cb7.Size = New Size(88, 29)
        cb7.TabIndex = 9
        cb7.Text = "Komik"
        cb7.UseVisualStyleBackColor = True
        ' 
        ' cb6
        ' 
        cb6.AutoSize = True
        cb6.Location = New Point(168, 88)
        cb6.Name = "cb6"
        cb6.Size = New Size(101, 29)
        cb6.TabIndex = 8
        cb6.Text = "Cosplay"
        cb6.UseVisualStyleBackColor = True
        ' 
        ' cb5
        ' 
        cb5.AutoSize = True
        cb5.Location = New Point(168, 53)
        cb5.Name = "cb5"
        cb5.Size = New Size(118, 29)
        cb5.TabIndex = 7
        cb5.Text = "Streaming"
        cb5.UseVisualStyleBackColor = True
        ' 
        ' cb4
        ' 
        cb4.AutoSize = True
        cb4.Location = New Point(6, 158)
        cb4.Name = "cb4"
        cb4.Size = New Size(93, 29)
        cb4.TabIndex = 6
        cb4.Text = "Editing"
        cb4.UseVisualStyleBackColor = True
        ' 
        ' cb3
        ' 
        cb3.AutoSize = True
        cb3.Location = New Point(6, 123)
        cb3.Name = "cb3"
        cb3.Size = New Size(100, 29)
        cb3.TabIndex = 5
        cb3.Text = "Gaming"
        cb3.UseVisualStyleBackColor = True
        ' 
        ' cb2
        ' 
        cb2.AutoSize = True
        cb2.Location = New Point(5, 88)
        cb2.Name = "cb2"
        cb2.Size = New Size(93, 29)
        cb2.TabIndex = 4
        cb2.Text = "Design"
        cb2.UseVisualStyleBackColor = True
        ' 
        ' cb1
        ' 
        cb1.AutoSize = True
        cb1.Location = New Point(6, 53)
        cb1.Name = "cb1"
        cb1.Size = New Size(96, 29)
        cb1.TabIndex = 3
        cb1.Text = "Coding"
        cb1.UseVisualStyleBackColor = True
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(187, 18)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(107, 29)
        rbAnggota.TabIndex = 2
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Location = New Point(93, 18)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(90, 29)
        rbAdmin.TabIndex = 1
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(6, 18)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(81, 29)
        rbKetua.TabIndex = 0
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(484, 292)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(175, 34)
        btnSimpan.TabIndex = 11
        btnSimpan.Text = "Simpan dan Cetak"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' FormInput
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkRed
        ClientSize = New Size(800, 450)
        Controls.Add(btnSimpan)
        Controls.Add(grpPeran)
        Controls.Add(TabControl1)
        Name = "FormInput"
        Text = "Input Data Anggota"
        TabControl1.ResumeLayout(False)
        tabData.ResumeLayout(False)
        tabData.PerformLayout()
        TabKontak.ResumeLayout(False)
        TabKontak.PerformLayout()
        tabProfil.ResumeLayout(False)
        tabProfil.PerformLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        grpPeran.ResumeLayout(False)
        grpPeran.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabData As TabPage
    Friend WithEvents TabKontak As TabPage
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents cmbKomunitas As ComboBox
    Friend WithEvents mtbHP As MaskedTextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents tabProfil As TabPage
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnBrowse As RadioButton
    Friend WithEvents grpPeran As GroupBox
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents cb1 As CheckBox
    Friend WithEvents cb8 As CheckBox
    Friend WithEvents cb7 As CheckBox
    Friend WithEvents cb6 As CheckBox
    Friend WithEvents cb5 As CheckBox
    Friend WithEvents cb4 As CheckBox
    Friend WithEvents cb3 As CheckBox
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
