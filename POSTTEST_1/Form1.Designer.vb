<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIPS = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblIPK = New System.Windows.Forms.Label()
        Me.lblPredikat = New System.Windows.Forms.Label()
        Me.txtIPK = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(246, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input IP Semester"
        '
        'txtIPS
        '
        Me.txtIPS.Location = New System.Drawing.Point(439, 188)
        Me.txtIPS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIPS.Name = "txtIPS"
        Me.txtIPS.Size = New System.Drawing.Size(174, 27)
        Me.txtIPS.TabIndex = 1
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(439, 223)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(84, 27)
        Me.btnTambah.TabIndex = 2
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(529, 223)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(84, 27)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblIPK
        '
        Me.lblIPK.AutoSize = True
        Me.lblIPK.Location = New System.Drawing.Point(246, 262)
        Me.lblIPK.Name = "lblIPK"
        Me.lblIPK.Size = New System.Drawing.Size(98, 19)
        Me.lblIPK.TabIndex = 4
        Me.lblIPK.Text = "IP Komulatif"
        '
        'lblPredikat
        '
        Me.lblPredikat.AutoSize = True
        Me.lblPredikat.Location = New System.Drawing.Point(504, 318)
        Me.lblPredikat.Name = "lblPredikat"
        Me.lblPredikat.Size = New System.Drawing.Size(19, 19)
        Me.lblPredikat.TabIndex = 5
        Me.lblPredikat.Text = " -"
        '
        'txtIPK
        '
        Me.txtIPK.Location = New System.Drawing.Point(439, 262)
        Me.txtIPK.Name = "txtIPK"
        Me.txtIPK.ReadOnly = True
        Me.txtIPK.Size = New System.Drawing.Size(174, 27)
        Me.txtIPK.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(900, 534)
        Me.Controls.Add(Me.txtIPK)
        Me.Controls.Add(Me.lblPredikat)
        Me.Controls.Add(Me.lblIPK)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.txtIPS)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Kalkulator Nayul"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIPS As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblIPK As Label
    Friend WithEvents lblPredikat As Label
    Friend WithEvents txtIPK As TextBox
End Class
