<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPesanan
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
        txtKode = New TextBox()
        txtNama = New TextBox()
        txtAlamat = New TextBox()
        txtHP = New TextBox()
        txtSearch = New TextBox()
        lblNama = New Label()
        lblAlamat = New Label()
        lblKode = New Label()
        lblHP = New Label()
        lblSearch = New Label()
        cbJasa = New ComboBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvPesanan = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        CType(dgvPesanan, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(188, 15)
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(150, 31)
        txtKode.TabIndex = 0
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(188, 74)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(150, 31)
        txtNama.TabIndex = 1
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(188, 134)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(150, 31)
        txtAlamat.TabIndex = 2
        ' 
        ' txtHP
        ' 
        txtHP.Location = New Point(574, 18)
        txtHP.Name = "txtHP"
        txtHP.Size = New Size(150, 31)
        txtHP.TabIndex = 3
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(574, 80)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(150, 31)
        txtSearch.TabIndex = 4
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(67, 74)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(65, 25)
        lblNama.TabIndex = 5
        lblNama.Text = "NAMA"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(67, 134)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(81, 25)
        lblAlamat.TabIndex = 6
        lblAlamat.Text = "ALAMAT"
        ' 
        ' lblKode
        ' 
        lblKode.AutoSize = True
        lblKode.Location = New Point(67, 15)
        lblKode.Name = "lblKode"
        lblKode.Size = New Size(57, 25)
        lblKode.TabIndex = 7
        lblKode.Text = "KODE"
        ' 
        ' lblHP
        ' 
        lblHP.AutoSize = True
        lblHP.Location = New Point(443, 18)
        lblHP.Name = "lblHP"
        lblHP.Size = New Size(67, 25)
        lblHP.TabIndex = 8
        lblHP.Text = "NO HP"
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Location = New Point(443, 80)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(78, 25)
        lblSearch.TabIndex = 9
        lblSearch.Text = "SEARCH"
        ' 
        ' cbJasa
        ' 
        cbJasa.FormattingEnabled = True
        cbJasa.Items.AddRange(New Object() {"- Bersih WC", "", "- Laundry", "", "- General Cleaning", "", "- Cuci Sofa", "", "- Cuci Karpet"})
        cbJasa.Location = New Point(443, 134)
        cbJasa.Name = "cbJasa"
        cbJasa.Size = New Size(281, 33)
        cbJasa.TabIndex = 10
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(42, 195)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(136, 34)
        btnSimpan.TabIndex = 11
        btnSimpan.Text = "SIMPAN 💖"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(243, 195)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(112, 34)
        btnUbah.TabIndex = 12
        btnUbah.Text = "UBAH 💕"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(426, 198)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(112, 34)
        btnHapus.TabIndex = 13
        btnHapus.Text = "HAPUS 💔"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(612, 198)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(112, 34)
        btnBatal.TabIndex = 14
        btnBatal.Text = "RESET ♻"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' dgvPesanan
        ' 
        dgvPesanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPesanan.Location = New Point(243, 258)
        dgvPesanan.Name = "dgvPesanan"
        dgvPesanan.RowHeadersWidth = 62
        dgvPesanan.Size = New Size(360, 225)
        dgvPesanan.TabIndex = 15
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' FormPesanan
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(800, 450)
        Controls.Add(dgvPesanan)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(cbJasa)
        Controls.Add(lblSearch)
        Controls.Add(lblHP)
        Controls.Add(lblKode)
        Controls.Add(lblAlamat)
        Controls.Add(lblNama)
        Controls.Add(txtSearch)
        Controls.Add(txtHP)
        Controls.Add(txtAlamat)
        Controls.Add(txtNama)
        Controls.Add(txtKode)
        Name = "FormPesanan"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DATA PEMESANAN 💖"
        CType(dgvPesanan, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtHP As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblKode As Label
    Friend WithEvents lblHP As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents cbJasa As ComboBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvPesanan As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
