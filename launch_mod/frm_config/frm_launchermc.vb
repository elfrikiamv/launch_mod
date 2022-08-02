Imports System.IO
Imports System.IO.Compression
Imports System.Text

Public Class frm_launchermc

    'path roaming 
    Dim appdata As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    'path program files
    Dim program_files As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)
    'link launcher_profiles.zip
    Dim host_launcher_profiles01 As String = "https://pastebin.com/raw/YrqFk36m"
    Dim host_launcher_profiles02 As String = "https://pastebin.com/raw/QrAnJVT7"

    Private Sub frm_launchermc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckForIllegalCrossThreadCalls = False

    End Sub

    Private Sub btn_savelaunchermc_Click(sender As Object, e As EventArgs) Handles btn_savelaunchermc.Click

        'comprobación de requerimientos para abrir el launcher mc
        If ComboBox_select_launcher.SelectedItem = Nothing Then
            MsgBox("Selecciona un tipo de Launcher!", MsgBoxStyle.Exclamation, "#")
            Return
        End If

        Dim dirminecraft As String = appdata & "\.minecraft"

        If Directory.Exists(dirminecraft) Then

            Dim launchermc_txt As String = program_files & "\AmvPrograms\launch-mod\launcher-mc.txt"

            If File.Exists(launchermc_txt) Then

                Dim launchermc_true As String
                launchermc_true = MsgBox("¡Ya cuentas con un tipo de launcher seleccionado!" & vbNewLine & "¿Quiere cambiarlo?", vbYesNo)

                If (launchermc_true = vbYes) Then

                    'delete launcher-mc.txt
                    File.Delete(program_files & "\AmvPrograms\launch-mod\launcher-mc.txt")

                    'delete perfil_graphic_files
                    Dim launcher_profiles_json As String = appdata & "\.minecraft\launcher_profiles.json"

                    If File.Exists(launcher_profiles_json) Then

                        File.Delete(appdata & "\.minecraft\launcher_profiles.json")

                        bw_savelaunchermc.RunWorkerAsync()
                    Else
                        bw_savelaunchermc.RunWorkerAsync()
                    End If

                End If
            Else

                'delete perfil_graphic_files
                Dim launcher_profiles_json As String = appdata & "\.minecraft\launcher_profiles.json"

                If File.Exists(launcher_profiles_json) Then

                    File.Delete(appdata & "\.minecraft\launcher_profiles.json")

                    bw_savelaunchermc.RunWorkerAsync()
                Else
                    bw_savelaunchermc.RunWorkerAsync()
                End If

            End If

        Else

            MsgBox("No se encontró tu .minecraft, prueba instalar el pack de mods primero :D", MsgBoxStyle.Exclamation, "#")
        End If
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

        'leé launcher-mc.txt y lo guarda en launcher_mc_read
        Dim launcher_mc_read As String
        launcher_mc_read = My.Computer.FileSystem.ReadAllText(raiz & "\launcher-mc.txt")

        'segun el launcher-mc.txt descargara el launcher_profiles.json
        If (launcher_mc_read = "Minecraft_(original).exe") Then

            'connection_host = launcher profiles link download
            My.Computer.Network.DownloadFile((host_launcher_profiles01), (raiz & "\host-launcher-profiles.txt"), "", "", False, 2000, True)
            Dim connection_host As String
            connection_host = My.Computer.FileSystem.ReadAllText(raiz & "\host-launcher-profiles.txt")

            'download perfil_graphic.zip
            My.Computer.Network.DownloadFile((connection_host), (program_files & "\AmvPrograms\launch-mod\mc\launcher-profiles.zip"), "", "", True, 2000, True)

            'unzip perfil_graphic.zip
            ZipFile.ExtractToDirectory(program_files & "\AmvPrograms\launch-mod\mc\launcher-profiles.zip", appdata & "\.minecraft")

            'delete restos
            File.Delete(raiz & "\host-launcher-profiles.txt")
            File.Delete(program_files & "\AmvPrograms\launch-mod\mc\launcher-profiles.zip")

            MsgBox("Listo, dale (ok) para continuar!", MsgBoxStyle.Information, "#")
        ElseIf (launcher_mc_read = "SKlauncher_3-beta.21.exe") Then

            'connection_host = launcher profiles link download
            My.Computer.Network.DownloadFile((host_launcher_profiles02), (raiz & "\host-launcher-profiles.txt"), "", "", False, 2000, True)
            Dim connection_host As String
            connection_host = My.Computer.FileSystem.ReadAllText(raiz & "\host-launcher-profiles.txt")

            'download launcher-profiles.zip
            My.Computer.Network.DownloadFile((connection_host), (program_files & "\AmvPrograms\launch-mod\mc\launcher-profiles.zip"), "", "", True, 2000, True)

            'unzip launcher-profiles.zip
            ZipFile.ExtractToDirectory(program_files & "\AmvPrograms\launch-mod\mc\launcher-profiles.zip", appdata & "\.minecraft")

            'delete restos
            File.Delete(raiz & "\host-launcher-profiles.txt")
            File.Delete(program_files & "\AmvPrograms\launch-mod\mc\launcher-profiles.zip")

            MsgBox("Listo, dale (ok) para continuar!", MsgBoxStyle.Information, "#")
        Else

            MsgBox("Ups!, algo no salió bien D:", MsgBoxStyle.Exclamation, "#")
        End If
    End Sub
End Class