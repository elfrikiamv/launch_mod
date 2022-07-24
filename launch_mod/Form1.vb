Imports System.IO

Public Class Form1

    Dim version_compare As String = "https://pastebin.com/raw/Bmqb5CQA"
    Dim downland_update_launcher As String = "https://pastebin.com/raw/wa9an0tu"
    Dim program_files As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckForIllegalCrossThreadCalls = False

        If My.Computer.Network.IsAvailable = False Then
            MsgBox("Necesitas conexión a Internet!", MsgBoxStyle.Critical, "#")
        Else
            bw_checkupdate.RunWorkerAsync()
        End If

    End Sub

    Private Sub btn_config_Click(sender As Object, e As EventArgs) Handles btn_config.Click
        frm_config.ShowDialog()
    End Sub

    Private Sub btn_play_Click(sender As Object, e As EventArgs) Handles btn_play.Click

    End Sub

    Private Sub btn_info_Click(sender As Object, e As EventArgs) Handles btn_info.Click
        frm_info.ShowDialog()
    End Sub

    Private Sub bw_checkupdate_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_checkupdate.DoWork

        Dim raiz As String = program_files & "\AmvPrograms\launch-mod"
        Dim VersionActual As String = My.Application.Info.Version.ToString

        My.Computer.Network.DownloadFile((version_compare), (raiz & "\version-validation.txt"), "", "", False, 2000, True)
        My.Computer.Network.DownloadFile((downland_update_launcher), (raiz & "\update-launcher.txt"), "", "", False, 2000, True)

        Dim version_validation As String
        version_validation = My.Computer.FileSystem.ReadAllText(raiz & "\version-validation.txt")

        Dim update_launcher As String
        update_launcher = My.Computer.FileSystem.ReadAllText(raiz & "\update-launcher.txt")

        If (version_validation > VersionActual) Then

            Dim update_true As String
            update_true = MsgBox("¡Hay una nueva versión del launcher (" & version_validation & ")!" & vbNewLine & "¿Ir a descargar ahora?", vbOKCancel)

            If (update_true = vbOK) Then
                Process.Start(update_launcher)
            End If

        End If

        File.Delete(raiz & "\version-validation.txt")
        File.Delete(raiz & "\update-launcher.txt")

    End Sub
End Class
