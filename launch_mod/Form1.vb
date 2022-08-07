Imports System.IO
Imports CmlLib.Core
Imports CmlLib.Core.Auth
Imports CmlLib.Core.Auth.Microsoft.UI.WinForm
Public Class Form1

    Dim version_compare As String = "https://pastebin.com/raw/Bmqb5CQA"
    Dim downland_update_launcher As String = "https://pastebin.com/raw/wa9an0tu"
    'path program files
    Dim program_files As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)
    'path roaming 
    Dim appdata As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    Public Property Session As MSession

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckForIllegalCrossThreadCalls = False

        'comprobación de requerimientos para abrir launch_mod
        If My.Computer.Network.IsAvailable = False Then
            MsgBox("Necesitas conexión a Internet!", MsgBoxStyle.Critical, "#")
        Else
            bw_checkupdate.RunWorkerAsync()
        End If
    End Sub
    Private Sub btnamv_play_MouseEnter(sender As Object, e As EventArgs) Handles btnamv_play.MouseEnter

        btnamv_play.BackColor = Color.FromArgb(139, 148, 158)
    End Sub

    Private Sub btnamv_play_MouseLeave(sender As Object, e As EventArgs) Handles btnamv_play.MouseLeave

        btnamv_play.BackColor = Color.Transparent
    End Sub

    Private Sub btnamv_play_Click(sender As Object, e As EventArgs) Handles btnamv_play.Click

        'comprobación de requerimientos para abrir el launcher mc
        Dim dirminecraftmods As String = appdata & "\.minecraft\mods"
        Dim launchermc_txt As String = program_files & "\AmvPrograms\launch-mod\launcher-mc.txt"
        Dim pg_txt As String = program_files & "\AmvPrograms\launch-mod\perfil-graphic.txt"

        If Directory.Exists(dirminecraftmods) Then

            If File.Exists(launchermc_txt) Then

                If File.Exists(pg_txt) Then

                    bw_openlaunchermc.RunWorkerAsync()
                Else

                    Dim launchermc_true As String
                    launchermc_true = MsgBox("¡No haz seleccionado un perfil gráfico!." & vbNewLine & "¿Quieres ir a seleccionar uno?", vbYesNo)

                    If (launchermc_true = vbYes) Then

                        'open form frm_configm
                        frm_configm.ShowDialog()
                    End If
                End If
            Else

                Dim launchermc_true As String
                launchermc_true = MsgBox("¡No haz seleccionado con qué tipo de launcher ejecutar el juego!." & vbNewLine & "¿Quieres ir a seleccionar uno?", vbYesNo)

                If (launchermc_true = vbYes) Then

                    'open form frm_configm
                    frm_configm.ShowDialog()
                End If

            End If
        Else

            'MsgBox("Ups!, no se encontraron mods instalados.", MsgBoxStyle.Critical, "#")
            Dim launchermc_true As String
            launchermc_true = MsgBox("Ups!, no se encontraron mods instalados." & vbNewLine & "¿Quieres ir a instalarlos?", vbYesNo)

            If (launchermc_true = vbYes) Then

                'open form frm_configm
                frm_configm.ShowDialog()

            End If
        End If

    End Sub
    Private Sub btnamv_info_MouseEnter(sender As Object, e As EventArgs) Handles btnamv_info.MouseEnter

        btnamv_info.BackColor = Color.FromArgb(139, 148, 158)
    End Sub

    Private Sub btnamv_info_MouseLeave(sender As Object, e As EventArgs) Handles btnamv_info.MouseLeave

        btnamv_info.BackColor = Color.Transparent
    End Sub
    Private Sub btnamv_info_Click(sender As Object, e As EventArgs) Handles btnamv_info.Click

        'open form frm_info
        frm_info.ShowDialog()

    End Sub
    Private Sub btnamv_config_MouseEnter(sender As Object, e As EventArgs) Handles btnamv_config.MouseEnter

        btnamv_config.BackColor = Color.FromArgb(139, 148, 158)
    End Sub

    Private Sub btnamv_config_MouseLeave(sender As Object, e As EventArgs) Handles btnamv_config.MouseLeave

        btnamv_config.BackColor = Color.Transparent
    End Sub
    Private Sub btnamv_config_Click(sender As Object, e As EventArgs) Handles btnamv_config.Click

        'open form frm_configm
        frm_configm.ShowDialog()

    End Sub

    Private Sub bw_checkupdate_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_checkupdate.DoWork

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
            update_true = MsgBox("¡Hay una nueva versión del launcher (" & version_validation & ")!" & vbNewLine & "¿Ir a descargar ahora?", vbOKCancel)

            If (update_true = vbOK) Then
                Process.Start(update_launcher)
            End If

        End If

        'delete restos
        File.Delete(raiz & "\version-validation.txt")
        File.Delete(raiz & "\update-launcher.txt")

    End Sub

    Private Sub bw_openlaunchermc_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_openlaunchermc.DoWork

        'path install launch-mod
        Dim raiz As String = program_files & "\AmvPrograms\launch-mod"

        'leé launcher-mc.txt y lo guarda en launcher-mc_read
        Dim launcher_mc_read As String
        launcher_mc_read = My.Computer.FileSystem.ReadAllText(raiz & "\launcher-mc.txt")

        'path of launcher mc
        Dim ruta_mc As String = program_files & "\AmvPrograms\launch-mod\mc\" & launcher_mc_read

        'run launcher mc
        Dim open_launcher_mc As New Process()
        open_launcher_mc.StartInfo.FileName = ruta_mc
        open_launcher_mc.Start()

    End Sub

    Private Async Sub btnamv_runmc_Click(sender As Object, e As EventArgs) Handles btnamv_runmc.Click

        Dim loginForm As MicrosoftLoginForm = New MicrosoftLoginForm()
        Dim session As MSession = Await loginForm.ShowLoginDialog()
        Me.Session = session
        'MessageBox.Show("Login success : " + session.Username);

        Dim path = New MinecraftPath() ' default game path
        Dim launcher = New CMLauncher(path)

        ' register event handlers
        'launcher.FileChanged += Launcher_FileChanged;
        'launcher.ProgressChanged += Launcher_ProgressChanged;

        '.ServerIp = "nebuland.net",
        ' check and download game files 1.12.2-forge1.12.2-14.23.5.2838
        Dim process = Await launcher.CreateProcessAsync("1.16.5-forge-36.2.34", New MLaunchOption With {
            .Session = Me.Session,
            .MaximumRamMb = 6144,
            .GameLauncherName = "launch_mod"
        })

        ' start game
        process.Start()

    End Sub
End Class
