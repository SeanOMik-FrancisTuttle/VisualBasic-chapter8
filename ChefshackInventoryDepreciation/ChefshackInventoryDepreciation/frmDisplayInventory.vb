' The frmDisplayInventory Class is opened by frmDepreciation
' and displays the inventory file in sorted order
Public Class frmDisplayInventory
    Private Sub FrmDisplayInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' The frmDisplayInvnetory load event is a second forms that
        ' displays the sorted invnetory items

        ' Sorts the _strInventoryItem array
        Array.Sort(frmDepreciation._strInventoryItem)

        ' Displays the _strInventoryItem array
        For Each strItem In frmDepreciation._strInventoryItem
            lstDisplay.Items.Add(strItem)
        Next
    End Sub

    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        ' This sub procedure opens the first form
        Dim frmFirst As New frmDepreciation

        Hide()
        frmFirst.ShowDialog()
    End Sub
End Class