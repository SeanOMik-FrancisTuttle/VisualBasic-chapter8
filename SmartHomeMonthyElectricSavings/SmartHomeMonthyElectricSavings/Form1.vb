Public Class frmSmartHomeMonthyElectricSavings
    ' Class Level Private variables
    Public Shared _intSizeOfArray As Integer = 12
    Private _strMonth(_intSizeOfArray) As String
    Private _decCost(_intSizeOfArray) As Decimal

    Private Sub FrmSmartHomeMonthyElectricSavings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' The FrmSmartHomeMonthyElectricSavings load event reads the inventory text file and
        ' fills the combobox with the inventory items

        ' Initialize an instance of the StreamReader object and declare variables
        Dim objReader As IO.StreamReader
        Dim strLocationAndNameOfFile As String = "c:\savings.txt"
        Dim intCount As Integer = 0
        Dim intFill As Integer
        Dim strFileError As String = "The file is not available. Restart when the file is available."

        ' Verify the file exist
        If IO.File.Exists(strLocationAndNameOfFile) Then
            objReader = IO.File.OpenText(strLocationAndNameOfFile)
            ' Read the file line by line until the file is completed
            Do While objReader.Peek <> -1

                'Console.WriteLine("INDEX: " & intCount)

                Dim tempStringMonth = objReader.ReadLine()
                If tempStringMonth <> Nothing Then
                    _strMonth(intCount) = tempStringMonth
                    _decCost(intCount) = Convert.ToDecimal(objReader.ReadLine())
                End If

                intCount += 1
            Loop
            objReader.Close()

            ' The ListBox object is filled with the Inventory IDs
            For intFill = 0 To (_strMonth.Length - 1)
                If _strMonth(intFill) <> Nothing Then
                    cboMonth.Items.Add(_strMonth(intFill))
                End If
            Next
        Else
            MsgBox(strFileError, , "Error")
            Close()
        End If
    End Sub

    Private Sub CboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonth.SelectedIndexChanged
        ' When an option is selected in the combo box it shows the savings for that month.
        lblSaving.Text = _decCost(cboMonth.SelectedIndex).ToString("C")

        lblSaving.Visible = True
        btnDisplayStatistics.Visible = True
    End Sub

    Private Sub BtnDisplayStatistics_Click(sender As Object, e As EventArgs) Handles btnDisplayStatistics.Click
        ' When the Display statistics button is clicked, this calculates the average
        ' and gets the most money saved for a month, then displays it.
        Dim decAverage As Decimal
        Dim decMost As Decimal
        For index As Integer = 0 To _decCost.Length - 1
            If _decCost(index) <> Nothing Then
                If _decCost(index) > decMost Then
                    decMost = _decCost(index)
                End If

                decAverage += _decCost(index)
            End If
        Next
        decAverage /= _decCost.Length

        lblAverageSavings.Text = "Average Savings: " & decAverage.ToString("C")
        lblMostSaving.Text = "Most Savings: " & decMost.ToString("C")

        lblAverageSavings.Visible = True
        lblMostSaving.Visible = True
    End Sub
End Class
