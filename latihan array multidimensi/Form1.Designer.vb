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
        NPM = New TextBox()
        label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtnama = New TextBox()
        btnproses = New Button()
        List1 = New ListView()
        cbokelamin = New ComboBox()
        cboprodi = New ComboBox()
        btnedit = New Button()
        btnhapus = New Button()
        btnkeluar = New Button()
        SuspendLayout()
        ' 
        ' NPM
        ' 
        NPM.CharacterCasing = CharacterCasing.Upper
        NPM.Location = New Point(151, 35)
        NPM.Name = "NPM"
        NPM.Size = New Size(121, 23)
        NPM.TabIndex = 0
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Location = New Point(12, 35)
        label1.Name = "label1"
        label1.Size = New Size(34, 15)
        label1.TabIndex = 1
        label1.Text = "NPM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 15)
        Label2.TabIndex = 2
        Label2.Text = "NAMA"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 107)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 15)
        Label3.TabIndex = 3
        Label3.Text = "JENIS KELAMIN"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 146)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 15)
        Label4.TabIndex = 4
        Label4.Text = "PROGRAM STUDI"
        ' 
        ' txtnama
        ' 
        txtnama.CharacterCasing = CharacterCasing.Upper
        txtnama.Location = New Point(151, 67)
        txtnama.Name = "txtnama"
        txtnama.Size = New Size(121, 23)
        txtnama.TabIndex = 2
        ' 
        ' btnproses
        ' 
        btnproses.Location = New Point(613, 184)
        btnproses.Name = "btnproses"
        btnproses.Size = New Size(111, 28)
        btnproses.TabIndex = 5
        btnproses.Text = "Proses"
        btnproses.UseVisualStyleBackColor = True
        ' 
        ' List1
        ' 
        List1.Location = New Point(27, 218)
        List1.Name = "List1"
        List1.Size = New Size(717, 161)
        List1.TabIndex = 6
        List1.UseCompatibleStateImageBehavior = False
        ' 
        ' cbokelamin
        ' 
        cbokelamin.DropDownStyle = ComboBoxStyle.DropDownList
        cbokelamin.FormattingEnabled = True
        cbokelamin.Location = New Point(151, 107)
        cbokelamin.Name = "cbokelamin"
        cbokelamin.Size = New Size(133, 23)
        cbokelamin.TabIndex = 3
        ' 
        ' cboprodi
        ' 
        cboprodi.DropDownStyle = ComboBoxStyle.DropDownList
        cboprodi.FormattingEnabled = True
        cboprodi.Location = New Point(151, 146)
        cboprodi.Name = "cboprodi"
        cboprodi.Size = New Size(133, 23)
        cboprodi.TabIndex = 4
        ' 
        ' btnedit
        ' 
        btnedit.Location = New Point(479, 184)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(111, 28)
        btnedit.TabIndex = 7
        btnedit.Text = "Edit"
        btnedit.UseVisualStyleBackColor = True
        ' 
        ' btnhapus
        ' 
        btnhapus.Location = New Point(346, 184)
        btnhapus.Name = "btnhapus"
        btnhapus.Size = New Size(113, 28)
        btnhapus.TabIndex = 8
        btnhapus.Text = "Hapus"
        btnhapus.UseVisualStyleBackColor = True
        ' 
        ' btnkeluar
        ' 
        btnkeluar.Location = New Point(613, 398)
        btnkeluar.Name = "btnkeluar"
        btnkeluar.Size = New Size(111, 23)
        btnkeluar.TabIndex = 9
        btnkeluar.Text = "Keluar"
        btnkeluar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnkeluar)
        Controls.Add(btnhapus)
        Controls.Add(btnedit)
        Controls.Add(cboprodi)
        Controls.Add(cbokelamin)
        Controls.Add(List1)
        Controls.Add(btnproses)
        Controls.Add(txtnama)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(label1)
        Controls.Add(NPM)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NPM As TextBox
    Friend WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnama As TextBox
    Friend WithEvents btnproses As Button
    Friend WithEvents List1 As ListView
    Friend WithEvents cbokelamin As ComboBox
    Friend WithEvents cboprodi As ComboBox
    Friend WithEvents btnedit As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnkeluar As Button

End Class
