<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblJudul = New Label()
        btnMasuk = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Showcard Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.ForeColor = Color.DeepPink
        lblJudul.Location = New Point(114, 47)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(560, 40)
        lblJudul.TabIndex = 0
        lblJudul.Text = "PEMESANAN JASA HOME CLEANING"
        ' 
        ' btnMasuk
        ' 
        btnMasuk.BackColor = Color.HotPink
        btnMasuk.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMasuk.ForeColor = Color.White
        btnMasuk.Location = New Point(300, 120)
        btnMasuk.Name = "btnMasuk"
        btnMasuk.Size = New Size(224, 34)
        btnMasuk.TabIndex = 1
        btnMasuk.Text = "PESAN SEKARANG 💕"
        btnMasuk.UseVisualStyleBackColor = False
        ' 
        ' btnKeluar
        ' 
        btnKeluar.BackColor = Color.PaleVioletRed
        btnKeluar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKeluar.ForeColor = Color.White
        btnKeluar.Location = New Point(347, 181)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(132, 34)
        btnKeluar.TabIndex = 2
        btnKeluar.Text = "KELUAR 💔"
        btnKeluar.UseVisualStyleBackColor = False
        ' 
        ' FormMenu
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightPink
        ClientSize = New Size(800, 450)
        Controls.Add(btnKeluar)
        Controls.Add(btnMasuk)
        Controls.Add(lblJudul)
        Name = "FormMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "HOME CLEANING 💖"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents btnMasuk As Button
    Friend WithEvents btnKeluar As Button

End Class
