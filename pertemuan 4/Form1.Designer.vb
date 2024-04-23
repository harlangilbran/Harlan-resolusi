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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.Btnclose = New System.Windows.Forms.Button()
        Me.TextNamaBarang = New System.Windows.Forms.TextBox()
        Me.TextHargaSatuan = New System.Windows.Forms.TextBox()
        Me.TextJumlah = New System.Windows.Forms.TextBox()
        Me.TextTotalHarga = New System.Windows.Forms.TextBox()
        Me.TextDiskon = New System.Windows.Forms.TextBox()
        Me.TextTotalBayar = New System.Windows.Forms.TextBox()
        Me.TextBonus = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Harga Satuan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jumlah Item"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(205, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(225, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Enter untuk menghitung belanjaan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 25)
        Me.Label5.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 25)
        Me.Label6.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 250)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Diskon"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(40, 287)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Total Bayar"
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(430, 137)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(83, 23)
        Me.btnreset.TabIndex = 8
        Me.btnreset.Text = "RESET"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'Btnclose
        '
        Me.Btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnclose.Location = New System.Drawing.Point(248, 366)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(80, 24)
        Me.Btnclose.TabIndex = 9
        Me.Btnclose.Text = "TUTUP"
        Me.Btnclose.UseVisualStyleBackColor = True
        '
        'TextNamaBarang
        '
        Me.TextNamaBarang.Location = New System.Drawing.Point(208, 65)
        Me.TextNamaBarang.Name = "TextNamaBarang"
        Me.TextNamaBarang.Size = New System.Drawing.Size(297, 22)
        Me.TextNamaBarang.TabIndex = 10
        '
        'TextHargaSatuan
        '
        Me.TextHargaSatuan.Location = New System.Drawing.Point(208, 100)
        Me.TextHargaSatuan.Name = "TextHargaSatuan"
        Me.TextHargaSatuan.Size = New System.Drawing.Size(222, 22)
        Me.TextHargaSatuan.TabIndex = 11
        '
        'TextJumlah
        '
        Me.TextJumlah.Location = New System.Drawing.Point(208, 137)
        Me.TextJumlah.Name = "TextJumlah"
        Me.TextJumlah.Size = New System.Drawing.Size(216, 22)
        Me.TextJumlah.TabIndex = 12
        '
        'TextTotalHarga
        '
        Me.TextTotalHarga.Location = New System.Drawing.Point(208, 213)
        Me.TextTotalHarga.Name = "TextTotalHarga"
        Me.TextTotalHarga.Size = New System.Drawing.Size(216, 22)
        Me.TextTotalHarga.TabIndex = 13
        '
        'TextDiskon
        '
        Me.TextDiskon.Location = New System.Drawing.Point(208, 250)
        Me.TextDiskon.Name = "TextDiskon"
        Me.TextDiskon.Size = New System.Drawing.Size(216, 22)
        Me.TextDiskon.TabIndex = 14
        '
        'TextTotalBayar
        '
        Me.TextTotalBayar.Location = New System.Drawing.Point(208, 287)
        Me.TextTotalBayar.Name = "TextTotalBayar"
        Me.TextTotalBayar.Size = New System.Drawing.Size(216, 22)
        Me.TextTotalBayar.TabIndex = 15
        '
        'TextBonus
        '
        Me.TextBonus.Location = New System.Drawing.Point(208, 322)
        Me.TextBonus.Name = "TextBonus"
        Me.TextBonus.Size = New System.Drawing.Size(216, 22)
        Me.TextBonus.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(40, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 25)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Total Harga"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(43, 322)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 25)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Bonus"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(599, 420)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBonus)
        Me.Controls.Add(Me.TextTotalBayar)
        Me.Controls.Add(Me.TextDiskon)
        Me.Controls.Add(Me.TextTotalHarga)
        Me.Controls.Add(Me.TextJumlah)
        Me.Controls.Add(Me.TextHargaSatuan)
        Me.Controls.Add(Me.TextNamaBarang)
        Me.Controls.Add(Me.Btnclose)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Program Belanja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnreset As Button
    Friend WithEvents Btnclose As Button
    Friend WithEvents TextNamaBarang As TextBox
    Friend WithEvents TextHargaSatuan As TextBox
    Friend WithEvents TextJumlah As TextBox
    Friend WithEvents TextTotalHarga As TextBox
    Friend WithEvents TextDiskon As TextBox
    Friend WithEvents TextTotalBayar As TextBox
    Friend WithEvents TextBonus As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
