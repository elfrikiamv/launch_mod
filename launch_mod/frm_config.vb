Imports System.IO
Imports System.IO.Compression

Public Class frm_config
    'path roaming 
    Dim appdata As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    'path program files
    Dim program_files As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)
    'link perfil_grafico.zip
    Dim host_update As String = "https://pastebin.com/raw/8WkGED1G"
    'link sure.zip
    Dim host_sure As String = "https://pastebin.com/raw/vwFEsQSm"
    'link version comparation
    Dim version_compare As String = "https://pastebin.com/raw/Bmqb5CQA"
    'link download new version launch_mod
    Dim downland_update_launcher As String = "https://pastebin.com/raw/wa9an0tu"

    Private Sub frm_config_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckForIllegalCrossThreadCalls = False

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        'comprobación de requerimientos para checar actualización de lanch_mod
        If My.Computer.Network.IsAvailable = False Then
            MsgBox("Necesitas conexión a Internet!", MsgBoxStyle.Critical, "#")
            Return
        End If

        bw_update.RunWorkerAsync()
    End Sub

    Private Sub bw_update_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_update.DoWork

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

    Private Sub btn_install_mod_pack_Click(sender As Object, e As EventArgs) Handles btn_install_mod_pack.Click

        'comprobación de requerimientos para instalar los mods
        If My.Computer.Network.IsAvailable = False Then
            MsgBox("Necesitas conexión a Internet!", MsgBoxStyle.Critical, "#")
            Return
        End If

        If ComboBox_perfil_graphic.SelectedItem = Nothing Then
            MsgBox("Selecciona una configuración gráfica!", MsgBoxStyle.Exclamation, "#")
            Return
        End If

        Dim ruta As String = appdata & "\.minecraft"

        If Directory.Exists(ruta) Then
            MsgBox("¡Ya tienes una carpeta .minecraft! Debes borrarla para continuar.", MsgBoxStyle.Exclamation, "#")
            Return
        End If

        bw_installmods.RunWorkerAsync()

    End Sub

    Private Sub bw_installmods_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_installmods.DoWork

        'agarra que perfil grafico va a utilizar
        Dim perfil_graphic As String = ComboBox_perfil_graphic.SelectedItem

        'path install launch-mod
        Dim raiz As String = program_files & "\AmvPrograms\launch-mod"

        'connection_host = perfiles graficos link download
        My.Computer.Network.DownloadFile((host_update), (raiz & "\connection-perfil-graphic.txt"), "", "", False, 2000, True)
        Dim connection_host As String
        connection_host = My.Computer.FileSystem.ReadAllText(raiz & "\connection-perfil-graphic.txt")

        'connection_sure = sure.zip link download
        My.Computer.Network.DownloadFile((host_sure), (raiz & "\connection-sure.txt"), "", "", False, 2000, True)
        Dim connection_sure As String
        connection_sure = My.Computer.FileSystem.ReadAllText(raiz & "\connection-sure.txt")

        'download sure.zip
        My.Computer.Network.DownloadFile((connection_sure), (program_files & "\AmvPrograms\launch-mod\mc\sure.zip"), "", "", True, 2000, True)

        'download perfil_graphic.zip
        My.Computer.Network.DownloadFile((connection_host & "/" & perfil_graphic & ".zip"), (program_files & "\AmvPrograms\launch-mod\mc\" & perfil_graphic & ".zip"), "", "", True, 2000, True)

        'unzip sure.zip
        ZipFile.ExtractToDirectory(program_files & "\AmvPrograms\launch-mod\mc\sure.zip", appdata & "\")

        'unzip perfil_graphic.zip
        ZipFile.ExtractToDirectory(program_files & "\AmvPrograms\launch-mod\mc\" & perfil_graphic & ".zip", appdata & "\.minecraft")

        'delete restos
        File.Delete(raiz & "\connection-perfil-graphic.txt")
        File.Delete(raiz & "\connection-sure.txt")
        File.Delete(program_files & "\AmvPrograms\launch-mod\mc\sure.zip")
        File.Delete(program_files & "\AmvPrograms\launch-mod\mc\" & perfil_graphic & ".zip")

        MsgBox("Listo, dale (ok) para continuar!", MsgBoxStyle.Information, "#")

    End Sub

    Private Sub btn_reinstall_mod_pack_Click(sender As Object, e As EventArgs) Handles btn_reinstall_mod_pack.Click
        'comprobación de requerimientos para reinstalar los mods
        If My.Computer.Network.IsAvailable = False Then
            MsgBox("Necesitas conexión a Internet!", MsgBoxStyle.Critical, "#")
            Return
        End If

        If ComboBox_perfil_graphic.SelectedItem = Nothing Then
            MsgBox("Selecciona una configuración gráfica!", MsgBoxStyle.Exclamation, "#")
            Return
        End If

        Dim ruta As String = appdata & "\.minecraft"

        If Directory.Exists(ruta) Then
            bw_reinstallmods.RunWorkerAsync()
        Else
            MsgBox("Ups!, no se encontro tu .minecraft.", MsgBoxStyle.Critical, "#")
        End If

    End Sub

    Private Sub bw_reinstallmods_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_reinstallmods.DoWork

        'agarra que perfil grafico va a utilizar
        Dim perfil_graphic As String = ComboBox_perfil_graphic.SelectedItem

        'path install launch-mod
        Dim raiz As String = program_files & "\AmvPrograms\launch-mod"

        'connection_host = perfiles graficos link download
        My.Computer.Network.DownloadFile((host_update), (raiz & "\connection-perfil-graphic.txt"), "", "", False, 2000, True)
        Dim connection_host As String
        connection_host = My.Computer.FileSystem.ReadAllText(raiz & "\connection-perfil-graphic.txt")

        'connection_sure = sure.zip link download
        My.Computer.Network.DownloadFile((host_sure), (raiz & "\connection-sure.txt"), "", "", False, 2000, True)
        Dim connection_sure As String
        connection_sure = My.Computer.FileSystem.ReadAllText(raiz & "\connection-sure.txt")

        'delete /.minecraft
        Directory.Delete(appdata & "\.minecraft", True)

        'download sure.zip
        My.Computer.Network.DownloadFile((connection_sure), (program_files & "\AmvPrograms\launch-mod\mc\sure.zip"), "", "", True, 2000, True)

        'download perfil_graphic.zip
        My.Computer.Network.DownloadFile((connection_host & "/" & perfil_graphic & ".zip"), (program_files & "\AmvPrograms\launch-mod\mc\" & perfil_graphic & ".zip"), "", "", True, 2000, True)

        'unzip sure.zip
        ZipFile.ExtractToDirectory(program_files & "\AmvPrograms\launch-mod\mc\sure.zip", appdata & "\")

        'unzip perfil_graphic.zip
        ZipFile.ExtractToDirectory(program_files & "\AmvPrograms\launch-mod\mc\" & perfil_graphic & ".zip", appdata & "\.minecraft")

        'delete restos
        File.Delete(raiz & "\connection-perfil-graphic.txt")
        File.Delete(raiz & "\connection-sure.txt")
        File.Delete(program_files & "\AmvPrograms\launch-mod\mc\sure.zip")
        File.Delete(program_files & "\AmvPrograms\launch-mod\mc\" & perfil_graphic & ".zip")

        MsgBox("Listo, dale (ok) para continuar!", MsgBoxStyle.Information, "#")

    End Sub

    Private Sub btn_change_perfil_graphic_Click(sender As Object, e As EventArgs) Handles btn_change_perfil_graphic.Click

        'comprobación de requerimientos para cambiar el perfil grafico 
        If My.Computer.Network.IsAvailable = False Then
            MsgBox("Necesitas conexión a Internet!", MsgBoxStyle.Critical, "#")
            Return
        End If

        If ComboBox_perfil_graphic.SelectedItem = Nothing Then
            MsgBox("Selecciona una configuración gráfica!", MsgBoxStyle.Exclamation, "#")
            Return
        End If

        Dim ruta As String = appdata & "\.minecraft"

        If Directory.Exists(ruta) Then
            bw_changeperfilgraphic.RunWorkerAsync()
        Else
            MsgBox("Ups!, no se encontro tu .minecraft.", MsgBoxStyle.Critical, "#")
        End If

    End Sub

    Private Sub bw_changeperfilgraphic_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_changeperfilgraphic.DoWork

        'agarra que perfil grafico va a utilizar
        Dim perfil_graphic As String = ComboBox_perfil_graphic.SelectedItem

        'path install launch-mod
        Dim raiz As String = program_files & "\AmvPrograms\launch-mod"

        'connection_host = perfiles graficos link download
        My.Computer.Network.DownloadFile((host_update), (raiz & "\connection.txt"), "", "", False, 2000, True)
        Dim connection_host As String
        connection_host = My.Computer.FileSystem.ReadAllText(raiz & "\connection.txt")

        'delete perfil_graphic
        File.Delete(appdata & "\.minecraft\launcher_profiles.json")
        File.Delete(appdata & "\.minecraft\options.txt")
        File.Delete(appdata & "\.minecraft\perfil.txt")
        File.Delete(appdata & "\.minecraft\servers.dat")

        'download perfil_graphic.zip
        My.Computer.Network.DownloadFile((connection_host & "/" & perfil_graphic & ".zip"), (program_files & "\AmvPrograms\launch-mod\mc\" & perfil_graphic & ".zip"), "", "", True, 2000, True)

        'unzip perfil_graphic.zip
        ZipFile.ExtractToDirectory(program_files & "\AmvPrograms\launch-mod\mc\" & perfil_graphic & ".zip", appdata & "\.minecraft")

        'delete restos
        File.Delete(raiz & "\connection.txt")
        File.Delete(program_files & "\AmvPrograms\launch-mod\mc\" & perfil_graphic & ".zip")

        MsgBox("Listo, dale (ok) para continuar!", MsgBoxStyle.Information, "#")

    End Sub

    Private Sub btn_update_mod_pack_Click(sender As Object, e As EventArgs) Handles btn_update_mod_pack.Click

        'comprobación de requerimientos para actualizar los mods
        If My.Computer.Network.IsAvailable = False Then
            MsgBox("Necesitas conexión a Internet!", MsgBoxStyle.Critical, "#")
            Return
        End If

        Dim ruta As String = appdata & "\.minecraft\mods"

        If Directory.Exists(ruta) Then
            bw_updatemods.RunWorkerAsync()
        Else
            MsgBox("Ups!, no se encontraron mods instalados.", MsgBoxStyle.Critical, "#")
        End If

    End Sub

    Private Sub bw_updatemods_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_updatemods.DoWork

        'path install launch-mod
        Dim raiz As String = program_files & "\AmvPrograms\launch-mod"

        'connection_sure = sure.zip link download
        My.Computer.Network.DownloadFile((host_sure), (raiz & "\connection-sure.txt"), "", "", False, 2000, True)
        Dim connection_sure As String
        connection_sure = My.Computer.FileSystem.ReadAllText(raiz & "\connection-sure.txt")

        'download sure.zip
        My.Computer.Network.DownloadFile((connection_sure), (program_files & "\AmvPrograms\launch-mod\mc\sure.zip"), "", "", True, 2000, True)

        'delete /mods
        Directory.Delete(appdata & "\.minecraft\mods", True)

        'create /updatemods
        My.Computer.FileSystem.CreateDirectory(program_files & "\AmvPrograms\launch-mod\mc\updatemods")

        'unzip sure.zip in /updatemods
        ZipFile.ExtractToDirectory(program_files & "\AmvPrograms\launch-mod\mc\sure.zip", program_files & "\AmvPrograms\launch-mod\mc\updatemods")

        'copy updatemods\.minecraft\mods in roaming\.minecraft\mods
        My.Computer.FileSystem.CopyDirectory(program_files & "\AmvPrograms\launch-mod\mc\updatemods\.minecraft\mods", appdata & "\.minecraft\mods", True)

        'delete /updatemods
        Directory.Delete(program_files & "\AmvPrograms\launch-mod\mc\updatemods", True)

        'delete restos
        File.Delete(raiz & "\connection-sure.txt")
        File.Delete(program_files & "\AmvPrograms\launch-mod\mc\sure.zip")

        MsgBox("Listo, dale (ok) para continuar!", MsgBoxStyle.Information, "#")

    End Sub
End Class