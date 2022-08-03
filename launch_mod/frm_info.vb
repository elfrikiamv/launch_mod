Imports System.IO

Public Class frm_info

    Dim version_compare As String = "https://pastebin.com/raw/Bmqb5CQA"
    Dim downland_update_launcher As String = "https://pastebin.com/raw/wa9an0tu"
    Dim program_files As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)
    Private Sub frm_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckForIllegalCrossThreadCalls = False

    End Sub

    Private Sub btnamv_update_MouseEnter(sender As Object, e As EventArgs) Handles btnamv_update.MouseEnter

        btnamv_update.BackColor = Color.FromArgb(139, 148, 158)
    End Sub

    Private Sub btnamv_update_MouseLeave(sender As Object, e As EventArgs) Handles btnamv_update.MouseLeave

        btnamv_update.BackColor = Color.Transparent
    End Sub

    Private Sub btnamv_update_Click(sender As Object, e As EventArgs) Handles btnamv_update.Click

        'comprobación de requerimientos para checar actualización de lanch_mod
        If My.Computer.Network.IsAvailable = False Then
            MsgBox("Necesitas conexión a Internet!", MsgBoxStyle.Critical, "#")
            Return
        End If

        bw_updatelauncher.RunWorkerAsync()
    End Sub

    Private Sub bw_updatelauncher_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_updatelauncher.DoWork

        'path install launch-mod
        Dim raiz As String = program_files & "\AmvPrograms\launch-mod"

        'saca la version actual
        Dim VersionActual As String = My.Application.Info.Version.ToString

        'version-validation
        My.Computer.Network.DownloadFile((version_compare), (raiz & "\version-validation.txt"), "", "", False, 2000, True)
        Dim version_validation As String
        version_validation = My.Computer.FileSystem.ReadAllText(raiz & "\version-validation.txt")

        'update-launcher = enlace de descarga de la nueva version
        My.Computer.Network.DownloadFile((downland_update_launcher), (raiz & "\update-launcher.txt"), "", "", False, 2000, True)
        Dim update_launcher As String
        update_launcher = My.Computer.FileSystem.ReadAllText(raiz & "\update-launcher.txt")

        'valida la version actual con la de version_validation
        If (version_validation > VersionActual) Then

            Dim update_true As String
            update_true = MsgBox("¡Hay una nueva versión del launcher (" & version_validation & ")!" & vbNewLine & "¿Descargar ahora?", vbOKCancel)

            If (update_true = vbOK) Then
                Process.Start(update_launcher)
            End If
        Else

            Dim update_false As String
            update_false = MsgBox("Estas al día con la versión del launcher :D", MsgBoxStyle.Information, "#")

        End If

        'delete restos
        File.Delete(raiz & "\version-validation.txt")
        File.Delete(raiz & "\update-launcher.txt")
    End Sub

    Private Sub lnklb_github_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklb_github.LinkClicked

        'lnklb_github.LinkVisited = True
        System.Diagnostics.Process.Start("https://github.com/elfrikiamv")
    End Sub
End Class