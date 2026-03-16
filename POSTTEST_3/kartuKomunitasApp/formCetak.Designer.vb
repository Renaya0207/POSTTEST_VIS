<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCetak
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formCetak))
        GroupBox1 = New GroupBox()
        Label7 = New Label()
        Label6 = New Label()
        lblHobi = New Label()
        lblGender = New Label()
        lblAlamat = New Label()
        lblTglLahir = New Label()
        lblNoTelp = New Label()
        lblUmur = New Label()
        lblNama = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        pictureBoxProfile = New PictureBox()
        Label8 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(pictureBoxProfile, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(lblHobi)
        GroupBox1.Controls.Add(lblGender)
        GroupBox1.Controls.Add(lblAlamat)
        GroupBox1.Controls.Add(lblTglLahir)
        GroupBox1.Controls.Add(lblNoTelp)
        GroupBox1.Controls.Add(lblUmur)
        GroupBox1.Controls.Add(lblNama)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(338, 113)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(450, 282)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Profile"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(23, 217)
        Label7.Name = "Label7"
        Label7.Size = New Size(33, 15)
        Label7.TabIndex = 13
        Label7.Text = "Hobi"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(23, 190)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 15)
        Label6.TabIndex = 12
        Label6.Text = "Jenis Kelamin"
        ' 
        ' lblHobi
        ' 
        lblHobi.AutoSize = True
        lblHobi.Location = New Point(153, 217)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(12, 15)
        lblHobi.TabIndex = 11
        lblHobi.Text = "-"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(153, 190)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(12, 15)
        lblGender.TabIndex = 10
        lblGender.Text = "-"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(153, 162)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(12, 15)
        lblAlamat.TabIndex = 9
        lblAlamat.Text = "-"
        ' 
        ' lblTglLahir
        ' 
        lblTglLahir.AutoSize = True
        lblTglLahir.Location = New Point(153, 129)
        lblTglLahir.Name = "lblTglLahir"
        lblTglLahir.Size = New Size(12, 15)
        lblTglLahir.TabIndex = 8
        lblTglLahir.Text = "-"
        ' 
        ' lblNoTelp
        ' 
        lblNoTelp.AutoSize = True
        lblNoTelp.Location = New Point(153, 96)
        lblNoTelp.Name = "lblNoTelp"
        lblNoTelp.Size = New Size(12, 15)
        lblNoTelp.TabIndex = 7
        lblNoTelp.Text = "-"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Location = New Point(153, 62)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(12, 15)
        lblUmur.TabIndex = 6
        lblUmur.Text = "-"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(153, 30)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(12, 15)
        lblNama.TabIndex = 5
        lblNama.Text = "-"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(23, 162)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 15)
        Label5.TabIndex = 4
        Label5.Text = "Alamat"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(23, 129)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 15)
        Label4.TabIndex = 3
        Label4.Text = "Tanggal Lahir"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 15)
        Label3.TabIndex = 2
        Label3.Text = "No Telepon"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(23, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 15)
        Label2.TabIndex = 1
        Label2.Text = "Umur"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(23, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' pictureBoxProfile
        ' 
        pictureBoxProfile.Location = New Point(26, 113)
        pictureBoxProfile.Name = "pictureBoxProfile"
        pictureBoxProfile.Size = New Size(290, 282)
        pictureBoxProfile.SizeMode = PictureBoxSizeMode.Zoom
        pictureBoxProfile.TabIndex = 5
        pictureBoxProfile.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Maroon
        Label8.Location = New Point(251, 26)
        Label8.Name = "Label8"
        Label8.Size = New Size(342, 45)
        Label8.TabIndex = 9
        Label8.Text = "MARVEL UNIVERSITY"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(145, 26)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(100, 50)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(590, 21)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 50)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' formCetak
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        Controls.Add(Label8)
        Controls.Add(GroupBox1)
        Controls.Add(pictureBoxProfile)
        Name = "formCetak"
        Text = "formCetak"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(pictureBoxProfile, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pictureBoxProfile As PictureBox
    Friend WithEvents lblHobi As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblTglLahir As Label
    Friend WithEvents lblNoTelp As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
