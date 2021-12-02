Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub EquipmentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EquipmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SaloonDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SaloonDataSet.HairCuts' table. You can move, or remove it, as needed.
        Me.HairCutsTableAdapter.Fill(Me.SaloonDataSet.HairCuts)
        'TODO: This line of code loads data into the 'SaloonDataSet.HairDressing' table. You can move, or remove it, as needed.
        Me.HairDressingTableAdapter.Fill(Me.SaloonDataSet.HairDressing)
        'TODO: This line of code loads data into the 'SaloonDataSet.HairCuts' table. You can move, or remove it, as needed.
        Me.HairCutsTableAdapter.Fill(Me.SaloonDataSet.HairCuts)
        'TODO: This line of code loads data into the 'SaloonDataSet.HairDressing' table. You can move, or remove it, as needed.
        Me.HairDressingTableAdapter.Fill(Me.SaloonDataSet.HairDressing)
        'TODO: This line of code loads data into the 'SaloonDataSet.Equipment' table. You can move, or remove it, as needed.
        Me.EquipmentTableAdapter.Fill(Me.SaloonDataSet.Equipment)

    End Sub

    Private Sub HairDressingBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles HairDressingBindingSource.CurrentChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        HairCutsBindingSource.AddNew()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        HairCutsBindingSource.MoveNext()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        HairCutsBindingSource.MovePrevious()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        HairCutsBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        HairDressingBindingSource.EndEdit()
        HairCutsTableAdapter.Update(SaloonDataSet.HairCuts)
        MsgBox(" Successfully Saved")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        HairDressingBindingSource.MoveNext()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        HairDressingBindingSource.MovePrevious()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        HairDressingBindingSource.AddNew()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        HairDressingBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        HairDressingBindingSource.EndEdit()
        HairDressingTableAdapter.Update(SaloonDataSet.HairDressing)
        MsgBox(" Successfully Saved")
    End Sub
End Class
