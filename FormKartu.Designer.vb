<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKartu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKartu))
        PicKartu = New PictureBox()
        lblNama = New Label()
        lblID = New Label()
        lblKomunitas = New Label()
        lblKontak = New Label()
        lblHobby = New Label()
        panelHeader = New Panel()
        PictureBox3 = New PictureBox()
        lblJudul = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        CType(PicKartu, ComponentModel.ISupportInitialize).BeginInit()
        panelHeader.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PicKartu
        ' 
        PicKartu.Location = New Point(100, 111)
        PicKartu.Name = "PicKartu"
        PicKartu.Size = New Size(356, 274)
        PicKartu.SizeMode = PictureBoxSizeMode.StretchImage
        PicKartu.TabIndex = 0
        PicKartu.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.ForeColor = Color.White
        lblNama.Location = New Point(462, 159)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(63, 25)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama:"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.ForeColor = Color.White
        lblID.Location = New Point(462, 198)
        lblID.Name = "lblID"
        lblID.Size = New Size(34, 25)
        lblID.TabIndex = 3
        lblID.Text = "ID:"
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.AutoSize = True
        lblKomunitas.ForeColor = Color.White
        lblKomunitas.Location = New Point(462, 325)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(96, 25)
        lblKomunitas.TabIndex = 4
        lblKomunitas.Text = "Komunitas"
        ' 
        ' lblKontak
        ' 
        lblKontak.AutoSize = True
        lblKontak.ForeColor = Color.White
        lblKontak.Location = New Point(462, 240)
        lblKontak.Name = "lblKontak"
        lblKontak.Size = New Size(67, 25)
        lblKontak.TabIndex = 5
        lblKontak.Text = "Kontak"
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.ForeColor = Color.White
        lblHobby.Location = New Point(462, 281)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(67, 25)
        lblHobby.TabIndex = 6
        lblHobby.Text = "Hobby"
        ' 
        ' panelHeader
        ' 
        panelHeader.BackColor = Color.Maroon
        panelHeader.Controls.Add(PictureBox3)
        panelHeader.Controls.Add(lblJudul)
        panelHeader.Dock = DockStyle.Top
        panelHeader.Location = New Point(0, 0)
        panelHeader.Name = "panelHeader"
        panelHeader.Size = New Size(800, 78)
        panelHeader.TabIndex = 7
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(563, -9)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(234, 98)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 1
        PictureBox3.TabStop = False
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.ForeColor = Color.White
        lblJudul.Location = New Point(179, 9)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(362, 60)
        lblJudul.TabIndex = 0
        lblJudul.Text = "MARVEL GANK"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-14, 278)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(132, 219)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(673, 79)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(127, 186)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(-20, 3)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(126, 159)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 10
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(669, 267)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(128, 204)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 11
        PictureBox5.TabStop = False
        ' 
        ' FormKartu
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Navy
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(panelHeader)
        Controls.Add(lblHobby)
        Controls.Add(lblKontak)
        Controls.Add(lblKomunitas)
        Controls.Add(lblID)
        Controls.Add(lblNama)
        Controls.Add(PicKartu)
        Name = "FormKartu"
        Text = "Kartu Anggota"
        CType(PicKartu, ComponentModel.ISupportInitialize).EndInit()
        panelHeader.ResumeLayout(False)
        panelHeader.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PicKartu As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents lblKontak As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents panelHeader As Panel
    Friend WithEvents lblJudul As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
