' Program Name: Most Popular Mobile Game Sold
' Author:       Sean Ervin
' Date:         September 19, 2019
' Purpose:      The Most Popular Mobile Game Sold Windows Application displays
'               a list fo the top ten most downloaded mobile games and
'               displays the total downloads. If a user selected a game then it
'               displays the amount of downloads for that specific game.
Public Class frmMostPopularGames
    ' Class Level Private variables
    Public Shared _intSizeOfArray As Integer = 10
    Private _strGameTitle(_intSizeOfArray) As String
    Private _intGameDownloads(_intSizeOfArray) As Decimal
    Private _strRootPath As String = "\\FRANCISTUTTLE.EDU\Home\Student\IT\se1028304\My Documents\"

    Private Sub frmMostPopularGames_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' The frmMostPopularGames load event reads the inventory text file and
        ' fills the combobox with the inventory items. Calculates the average cholesterol
        ' and displays it to the user.

        ' Initialize an instance of the StreamReader object and declare variables
        Dim objReader As IO.StreamReader
        Dim strLocationAndNameOfFile As String = _strRootPath & "mobile.txt"
        Dim intCount As Integer = 0
        Dim strFileError As String = "The file is not available. Restart when the file is available."

        ' Verify the file exist
        If IO.File.Exists(strLocationAndNameOfFile) Then
            objReader = IO.File.OpenText(strLocationAndNameOfFile)
            ' Read the file line by line until the file is completed
            Do While objReader.Peek <> -1
                Dim tempStringTitle = objReader.ReadLine()
                If tempStringTitle <> Nothing Then
                    _strGameTitle(intCount) = tempStringTitle
                    _intGameDownloads(intCount) = Convert.ToInt32(objReader.ReadLine())
                End If

                intCount += 1
            Loop
            objReader.Close()

            ' The ListBox object is filled with the Inventory IDs. Calculate total downloads
            Dim intTotalDownloads As Integer
            For intFill = 0 To (_strGameTitle.Length - 1)
                If _strGameTitle(intFill) <> Nothing Then
                    lstGames.Items.Add(_strGameTitle(intFill))
                End If

                If _intGameDownloads(intFill) <> Nothing Then
                    intTotalDownloads += _intGameDownloads(intFill)
                End If
            Next

            lblTotal.Text = "Total Downloads: " & intTotalDownloads
        Else
            MsgBox(strFileError, , "Error")
            Close()
        End If
    End Sub
    Private Sub LstGames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGames.SelectedIndexChanged
        lblGameDownloads.Text = "Selected Game Downloads: " & _intGameDownloads(lstGames.SelectedIndex)
        lblGameDownloads.Visible = True
    End Sub
End Class
