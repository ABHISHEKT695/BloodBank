Public Class BloodBank

    Private Sub PATIENTBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PATIENTBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PATIENTBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub BloodBank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.BloodBankData' table. You can move, or remove it, as needed.
        Me.BloodBankDataTableAdapter.Fill(Me.Database1DataSet.BloodBankData)
        'TODO: This line of code loads data into the 'Database1DataSet.DOCTOR' table. You can move, or remove it, as needed.
        Me.DOCTORTableAdapter.Fill(Me.Database1DataSet.DOCTOR)
        'TODO: This line of code loads data into the 'Database1DataSet.BloodGroups' table. You can move, or remove it, as needed.
        Me.BloodGroupsTableAdapter.Fill(Me.Database1DataSet.BloodGroups)
        'TODO: This line of code loads data into the 'Database1DataSet.DONOR' table. You can move, or remove it, as needed.
        Me.DONORTableAdapter.Fill(Me.Database1DataSet.DONOR)
        'TODO: This line of code loads data into the 'Database1DataSet.PATIENT' table. You can move, or remove it, as needed.
        Me.PATIENTTableAdapter.Fill(Me.Database1DataSet.PATIENT)

    End Sub

    Private Sub PAgeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PAgeTextBox.TextChanged

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub
End Class
