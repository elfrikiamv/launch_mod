Imports System.IO
Imports System.IO.Compression

Public Class frm_mods

    'path roaming 
    Dim appdata As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    'path program files
    Dim program_files As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)
    'link perfil_grafico.zip
    Dim host_update As String = "https://pastebin.com/raw/8WkGED1G"
    'link sure.zip
    Dim host_sure As String = "https://pastebin.com/raw/vwFEsQSm"

    Private Sub frm_mods_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckForIllegalCrossThreadCalls = False

    End Sub

    Private Sub btn_install_mod_pack_Click(sender As Object, e As EventArgs) Handles btn_install_mod_pack.Click

        'comprobación de requerimientos para instalar los mods
        If My.Computer.Network.IsAvailable = False Then
            MsgBox("Necesitas conexión a Internet!", MsgBoxStyle.Critical, "#")
        End If

        Dim ruta As String = appdata & "\.minecraft"
        Dim raiz_txt As String = program_files & "\AmvPrograms\launch-mod\perfil-graphic.txt"

        If Directory.Exists(ruta) Then

            MsgBox("¡Ya tienes una carpeta .minecraft! Debes borrarla para continuar.", MsgBoxStyle.Exclamation, "#")
        ElseIf File.Exists(raiz_txt) Then

            bw_installmods.RunWorkerAsync()
        Else

            MsgBox("Selecciona un perfil gráfico!", MsgBoxStyle.Exclamation, "#")
        End If



    End Sub

    Private Sub btn_reinstall_mod_pack_Click(sender As Object, e As EventArgs) Handles btn_reinstall_mod_pack.Click

        'comprobación de requerimientos para reinstalar los mods
        If My.Computer.Network.IsAvailable = False Then

            MsgBox("Necesitas conexión a Internet!", MsgBoxStyle.Critical, "#")
        End If

        Dim ruta As String = appdata & "\.minecraft"
        Dim raiz_txt As String = program_files & "\AmvPrograms\launch-mod\perfil-graphic.txt"

        If Directory.Exists(ruta) Then

            If File.Exists(raiz_txt) Then
                bw_reinstallmods.RunWorkerAsync()
            Else
                MsgBox("Selecciona un perfil gráfico!", MsgBoxStyle.Exclamation, "#")
            End If
        Else

            MsgBox("Ups!, no se encontro tu .minecraft.", MsgBoxStyle.Critical, "#")
        End If

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

    Private Sub bw_installmods_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_installmods.DoWork

        'agarra que perfil grafico va a utilizar
        'Dim perfil_graphic As String = ComboBox_perfil_graphic.SelectedItem

        'path install launch-mod
        Dim raiz As String = program_files & "\AmvPrograms\launch-mod"

        'leé perfil-graphic.txt y lo guarda en perfil_graphic_read
        Dim perfil_graphic_read As String
        perfil_graphic_read = My.Computer.FileSystem.ReadAllText(raiz & "\perfil-graphic.txt")

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
        My.Computer.Network.DownloadFile((connection_host & "/" & perfil_graphic_read & ".zip"), (program_files & "\AmvPrograms\launch-mod\mc\" & perfil_graphic_read & ".zip"), "", "", True, 2000, True)

        'unzip sure.zip
        ZipFile.ExtractToDirectory(program_files & "\AmvPrograms\launch-mod\mc\sure.zip", appdata & "\")

        'unzip perfil_graphic.zip
        ZipFile.ExtractToDirectory(program_files & "\AmvPrograms\launch-mod\mc\" & perfil_graphic_read & ".zip", appdata & "\.minecraft")

        'delete restos
        File.Delete(raiz & "\connection-perfil-graphic.txt")
        File.Delete(raiz & "\connection-sure.txt")
        File.Delete(program_files & "\AmvPrograms\launch-mod\mc\sure.zip")
        File.Delete(program_files & "\AmvPrograms\launch-mod\mc\" & perfil_graphic_read & ".zip")

        MsgBox("Listo, dale (ok) para continuar!", MsgBoxStyle.Information, "#")

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

    Private Sub bw_reinstallmods_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_reinstallmods.DoWork

        'agarra que perfil grafico va a utilizar
        'Dim perfil_graphic As String = ComboBox_perfil_graphic.SelectedItem

        'path install launch-mod
        Dim raiz As String = program_files & "\AmvPrograms\launch-mod"

        'leé perfil-graphic.txt y lo guarda en perfil_graphic_read
        Dim perfil_graphic_read As String
        perfil_graphic_read = My.Computer.FileSystem.ReadAllText(raiz & "\perfil-graphic.txt")

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
        My.Computer.Network.DownloadFile((connection_host & "/" & perfil_graphic_read & ".zip"), (program_files & "\AmvPrograms\launch-mod\mc\" & perfil_graphic_read & ".zip"), "", "", True, 2000, True)

        'unzip sure.zip
        ZipFile.ExtractToDirectory(program_files & "\AmvPrograms\launch-mod\mc\sure.zip", appdata & "\")

        'unzip perfil_graphic.zip
        ZipFile.ExtractToDirectory(program_files & "\AmvPrograms\launch-mod\mc\" & perfil_graphic_read & ".zip", appdata & "\.minecraft")

        'delete restos
        File.Delete(raiz & "\connection-perfil-graphic.txt")
        File.Delete(raiz & "\connection-sure.txt")
        File.Delete(program_files & "\AmvPrograms\launch-mod\mc\sure.zip")
        File.Delete(program_files & "\AmvPrograms\launch-mod\mc\" & perfil_graphic_read & ".zip")

        MsgBox("Listo, dale (ok) para continuar!", MsgBoxStyle.Information, "#")

    End Sub
End Class