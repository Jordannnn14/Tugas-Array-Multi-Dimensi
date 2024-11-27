Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arr(3, 1) As String
        arr(0, 0) = "NPM"
        arr(0, 1) = "NAMA"
        arr(1, 0) = "JENIS KELAMIN"
        arr(1, 1) = "PRODI"
        arr(2, 0) = "LAKI-LAKI"
        arr(2, 1) = "PEREMPUAN"
        arr(3, 0) = "SISTEM INFORMASI"
        arr(3, 1) = "SISTEM INFORMATIKA"
        List1.GridLines = True
        List1.View = View.Details

        For baris = 0 To 1
            For kolom = 0 To 1
                List1.Columns.Add(arr(baris, kolom), 120)
            Next kolom
        Next baris
        For baris = 2 To 2
            For kolom = 0 To 1
                cbokelamin.Items.Add(arr(baris, kolom))
            Next kolom
        Next baris
        For baris = 3 To 3
            For kolom = 0 To 1
                cboprodi.Items.Add(arr(baris, kolom))
            Next kolom
        Next baris

    End Sub
    Private Sub btnproses_Click(sender As Object, e As EventArgs) Handles btnproses.Click
        Dim arr(3) As String
        arr(0) = NPM.Text
        arr(1) = txtnama.Text
        arr(2) = cbokelamin.Text
        arr(3) = cboprodi.Text

        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = List1.Items.Add(arr(0))
        listitem.SubItems.Add(arr(1))
        listitem.SubItems.Add(arr(2))
        listitem.SubItems.Add(arr(3))
        NPM.Text = NPM.Text + 1
        cbokelamin.Text = ""
        cboprodi.Text = ""
        txtnama.Focus()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If List1.SelectedItems.Count > 0 Then
            List1.SelectedItems(0).SubItems(0).Text = NPM.Text
            List1.SelectedItems(0).SubItems(1).Text = txtnama.Text
            List1.SelectedItems(0).SubItems(2).Text = cbokelamin.Text
            List1.SelectedItems(0).SubItems(3).Text = cboprodi.Text
        End If

    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If List1.SelectedItems.Count > 0 Then
            List1.Items.Remove(List1.SelectedItems(0))
        End If
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        End
    End Sub
End Class
