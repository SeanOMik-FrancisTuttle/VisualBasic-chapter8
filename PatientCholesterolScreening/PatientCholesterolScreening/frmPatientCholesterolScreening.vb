' Program Name: Patient Cholesterol Screening
' Author:       Sean Ervin
' Date:         September 19, 2019
' Purpose:      The patient cholesterol screening form opens and has a file menu.
'               the user can click "Display Patient Information" from the file menu
'               and another form opens to view the cholesterol levels of each patient
'               it also displays the average for all the patients and can save patients for
'               later consultation if their cholesteral is above 200
Public Class frmPatientCholesterolScreening

    Public isBeingOpenedFromInfo As Boolean = False
    Private Sub mnuDisplayPatientInformation_Click(sender As Object, e As EventArgs) Handles mnuDisplayPatientInformation.Click
        Dim frmPatientInformation = New frmPatientInformation

        Hide()
        frmPatientInformation.ShowDialog()
        Me.Close()
    End Sub

    Private Sub FrmPatientCholesterolScreening_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hold the splash screen for 3 seconds if it is not being opened from the PatientInformation form
        If Not isBeingOpenedFromInfo Then
            Threading.Thread.Sleep(3000)
        End If
    End Sub

    Private Sub MnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' When the exit menu option is clicked, the application is closed

        Close()
    End Sub
End Class
