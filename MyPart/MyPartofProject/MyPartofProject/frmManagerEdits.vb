Public Class frmManagerEdits
    Private Sub frmManagerEdits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LoginsDataSet.tblUsers' table. You can move, or remove it, as needed.
        Me.TblUsersTableAdapter.Fill(Me.LoginsDataSet.tblUsers)

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Me.Validate()
            TblUsersBindingSource.EndEdit()
            TblUsersTableAdapter.Update(Me.LoginsDataSet.tblUsers)
            MessageBox.Show("Data Saved", "Status Update")
        Catch ex As Exception
            MessageBox.Show("Error Saving Data")
        End Try
    End Sub

End Class