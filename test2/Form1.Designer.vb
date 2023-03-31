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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.output2 = New System.Windows.Forms.Label()
        Me.output1 = New System.Windows.Forms.Label()
        Me.alamatInput = New System.Windows.Forms.TextBox()
        Me.noDaftarInput = New System.Windows.Forms.TextBox()
        Me.namaInput = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.jenisKelamin = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.inputJumlah = New System.Windows.Forms.TextBox()
        Me.inputHarga = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(629, 126)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 36)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(629, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 36)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Hitung"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.output2)
        Me.GroupBox1.Controls.Add(Me.output1)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 381)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(559, 154)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kesimpulan"
        '
        'output2
        '
        Me.output2.AutoSize = True
        Me.output2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.output2.Location = New System.Drawing.Point(24, 104)
        Me.output2.Name = "output2"
        Me.output2.Size = New System.Drawing.Size(17, 20)
        Me.output2.TabIndex = 11
        Me.output2.Text = "  "
        '
        'output1
        '
        Me.output1.AutoSize = True
        Me.output1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.output1.Location = New System.Drawing.Point(24, 31)
        Me.output1.Name = "output1"
        Me.output1.Size = New System.Drawing.Size(17, 20)
        Me.output1.TabIndex = 10
        Me.output1.Text = "  "
        '
        'alamatInput
        '
        Me.alamatInput.Location = New System.Drawing.Point(240, 161)
        Me.alamatInput.Name = "alamatInput"
        Me.alamatInput.Size = New System.Drawing.Size(357, 26)
        Me.alamatInput.TabIndex = 23
        '
        'noDaftarInput
        '
        Me.noDaftarInput.Location = New System.Drawing.Point(240, 110)
        Me.noDaftarInput.Name = "noDaftarInput"
        Me.noDaftarInput.Size = New System.Drawing.Size(357, 26)
        Me.noDaftarInput.TabIndex = 22
        '
        'namaInput
        '
        Me.namaInput.Location = New System.Drawing.Point(240, 65)
        Me.namaInput.Name = "namaInput"
        Me.namaInput.Size = New System.Drawing.Size(357, 26)
        Me.namaInput.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 20)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "No Pendaftaran"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(201, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Form Data Pasien"
        '
        'jenisKelamin
        '
        Me.jenisKelamin.FormattingEnabled = True
        Me.jenisKelamin.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.jenisKelamin.Location = New System.Drawing.Point(240, 208)
        Me.jenisKelamin.Name = "jenisKelamin"
        Me.jenisKelamin.Size = New System.Drawing.Size(121, 28)
        Me.jenisKelamin.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 20)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Jumlah Obat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 306)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 20)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Harga Obat"
        '
        'inputJumlah
        '
        Me.inputJumlah.Location = New System.Drawing.Point(240, 255)
        Me.inputJumlah.Name = "inputJumlah"
        Me.inputJumlah.Size = New System.Drawing.Size(357, 26)
        Me.inputJumlah.TabIndex = 30
        '
        'inputHarga
        '
        Me.inputHarga.Location = New System.Drawing.Point(240, 306)
        Me.inputHarga.Name = "inputHarga"
        Me.inputHarga.Size = New System.Drawing.Size(357, 26)
        Me.inputHarga.TabIndex = 32
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(629, 192)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 36)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Ulang"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 699)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.inputHarga)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.inputJumlah)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.jenisKelamin)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.alamatInput)
        Me.Controls.Add(Me.noDaftarInput)
        Me.Controls.Add(Me.namaInput)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents output2 As System.Windows.Forms.Label
    Friend WithEvents output1 As System.Windows.Forms.Label
    Friend WithEvents alamatInput As System.Windows.Forms.TextBox
    Friend WithEvents noDaftarInput As System.Windows.Forms.TextBox
    Friend WithEvents namaInput As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents jenisKelamin As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents inputJumlah As System.Windows.Forms.TextBox
    Friend WithEvents inputHarga As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
