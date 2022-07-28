Imports System.IO
Imports System.Text

Public Class frm_launchermc

    'path roaming 
    Dim appdata As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    'path program files
    Dim program_files As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)
    'link perfil_grafico.zip

    Private Sub frm_launchermc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckForIllegalCrossThreadCalls = False

    End Sub

    Private Sub btn_savelaunchermc_Click(sender As Object, e As EventArgs) Handles btn_savelaunchermc.Click

        'comprobación de requerimientos para abrir el launcher mc
        If ComboBox_select_launcher.SelectedItem = Nothing Then
            MsgBox("Selecciona un tipo de Launcher!", MsgBoxStyle.Exclamation, "#")
            Return
        End If

        bw_savelaunchermc.RunWorkerAsync()

    End Sub

    Private Sub bw_savelaunchermc_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_savelaunchermc.DoWork

        'agarra que perfil grafico va a utilizar
        Dim save_launchermc As String = ComboBox_select_launcher.SelectedItem

        'path install launch-mod
        Dim raiz As String = program_files & "\AmvPrograms\launch-mod"
        Dim launchermc_txt As String = program_files & "\AmvPrograms\launch-mod\launcher-mc.txt"

        ' Create or overwrite the file.
        Dim create_txt As FileStream = File.Create(launchermc_txt)

        ' Add text to the file.
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(save_launchermc)
        create_txt.Write(info, 0, info.Length)
        create_txt.Close()

    End Sub
End Class