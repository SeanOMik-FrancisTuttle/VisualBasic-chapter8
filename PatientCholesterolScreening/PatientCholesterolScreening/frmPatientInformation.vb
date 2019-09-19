Public Class frmPatientInformation
    ' Class Level Private variables
    Public Shared _intSizeOfArray As Integer = 16
    Private _strPatient(_intSizeOfArray) As String
    Private _intCholesterol(_intSizeOfArray) As Decimal

    Private Sub FrmPatientInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' The PatientCholesterolScreening load event reads the inventory text file and
        ' fills the combobox with the inventory items. Calculates the average cholesterol
        ' and displays it to the user.

        ' Initialize an instance of the StreamReader object and declare variables
        Dim objReader As IO.StreamReader
        Dim strLocationAndNameOfFile As String = "c:\patient.txt"
        Dim intCount As Integer = 0
        Dim strFileError As String = "The file is not available. Restart when the file is available."

        ' Verify the file exist
        If IO.File.Exists(strLocationAndNameOfFile) Then
            objReader = IO.File.OpenText(strLocationAndNameOfFile)
            ' Read the file line by line until the file is completed
            Do While objReader.Peek <> -1
                Dim tempStringMonth = objReader.ReadLine()
                If tempStringMonth <> Nothing Then
                    _strPatient(intCount) = tempStringMonth
                    _intCholesterol(intCount) = Convert.ToInt32(objReader.ReadLine())
                End If

                intCount += 1
            Loop
            objReader.Close()

            ' The ListBox object is filled with the Inventory IDs. Calculate average cholesterol
            Dim decAverageCholesterol As Decimal
            For intFill = 0 To (_strPatient.Length - 1)
                If _strPatient(intFill) <> Nothing Then
                    lstPatients.Items.Add(_strPatient(intFill))
                End If

                If _intCholesterol(intFill) <> Nothing Then
                    lstCholesterol.Items.Add(_intCholesterol(intFill))
                    decAverageCholesterol += _intCholesterol(intFill)
                End If

            Next
            decAverageCholesterol /= _intCholesterol.Length
            lblAverage.Text = "Average Cholesterol: " & Math.Round(decAverageCholesterol)
        Else
            MsgBox(strFileError, , "Error")
            Close()
        End If
    End Sub

    Private Sub MnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        ' This event is called when the menu back option is clicked. It
        ' tells the launch form that it doesn't need to show its
        ' splash screen on load and hides this form and loads the other.
        Dim frmPatientCholesterolScreening = New frmPatientCholesterolScreening
        frmPatientCholesterolScreening.isBeingOpenedFromInfo = True

        Hide()
        frmPatientCholesterolScreening.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnSaveConsult_Click(sender As Object, e As EventArgs) Handles btnSaveConsult.Click
        ' This event is called when the save consult button is clicked. It checks
        ' if a patients cholestrol is greater or equal to 200 and writes it into a file for
        ' later consultation; before writing to it, it clears the file. A lbl is shown when it finishes.

        Dim filePath As String = "\\FRANCISTUTTLE.EDU\Home\Student\IT\se1028304\My Documents\consult.txt"

        Dim file As System.IO.StreamWriter
        If IO.File.Exists(filePath) Then
            IO.File.WriteAllText(filePath, "")
        End If
        file = My.Computer.FileSystem.OpenTextFileWriter(filePath, True)

        For index As Integer = 0 To _intCholesterol.Length - 1
            If _intCholesterol(index) <> Nothing And _strPatient(index) <> Nothing Then
                If (_intCholesterol(index) >= 200) Then

                    file.WriteLine(_strPatient(index))
                    file.WriteLine(_intCholesterol(index))
                End If
            End If
        Next

        file.Close()

        'MsgBox("Patients with Cholesterol greater or equal to 200 were saved in consult.txt.", , "Done!")
        lblSaved.Visible = True
    End Sub
End Class
