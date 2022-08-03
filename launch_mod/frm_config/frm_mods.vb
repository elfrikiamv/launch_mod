Imports System.IO
Imports System.IO.Compression

Public Class frm_mods_beta

    'path roaming 
    Dim appdata As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    'path program files
    Dim program_files As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)
    'link perfil_grafico.zip
    Dim host_perfil_graphic As String = "https://pastebin.com/raw/SeYj4QG0"
    'link sure.zip
    Dim host_sure As String = "https://pastebin.com/raw/vwFEsQSm"
    'link launcher_profiles.zip
    Dim host_launcher_profiles01 As String = "https://pastebin.com/raw/YrqFk36m"
    Dim host_launcher_profiles02 As String = "https://pastebin.com/raw/QrAnJVT7"

    Private Sub frm_mods_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckForIllegalCrossThreadCalls = False

    End Sub

    Private Sub btnamv_install_mod_pack_MouseEnter(sender As Object, e As EventArgs) Handles btnamv_install_mod_pack.MouseEnter

        btnamv_install_mod_pack.BackColor = Color.FromArgb(139, 148, 158)
    End Sub

    Private Sub btnamv_install_mod_pack_MouseLeave(sender As Object, e As EventArgs) Handles btnamv_install_mod_pack.MouseLeave

        btnamv_install_mod_pack.BackColor = Color.Transparent
    End Sub

    Private Sub btnamv_install_mod_pack_Click(sender As Object, e As EventArgs) Handles btnamv_install_mod_pack.Click

        'comprobación de requerimientos para instalar los mods
        If My.Computer.Network.IsAvailable = False Then
            MsgBox("Necesitas conexión a Internet!", MsgBoxStyle.Critical, "#")
        End If
        bw_installmods.RunWorkerAsync()
        Dim dirminecraft As String = appdata & "\.minecraft"

        If Directory.Exists(dirminecraft) Then

            Dim dirminecraft_true As String
            dirminecraft_true = MsgBox("¡Ya tienes una carpeta .minecraft!" & vbNewLine & "¿Quieres borrarla para continuar?", vbYesNo)

            If (dirminecraft_true = vbYes) Then

                'delete .minecraft
                Directory.Delete(appdata & "\.minecraft", True)

                bw_installmods.RunWorkerAsync()
            End If
        Else

            bw_installmods.RunWorkerAsync()
        End If
    End Sub

    Private Sub btnamv_reinstall_mod_pack_MouseEnter(sender As Object, e As EventArgs) Handles btnamv_reinstall_mod_pack.MouseEnter

        btnamv_reinstall_mod_pack.BackColor = Color.FromArgb(139, 148, 158)
    End Sub

    Private Sub btnamv_reinstall_mod_pack_MouseLeave(sender As Object, e As EventArgs) Handles btnamv_reinstall_mod_pack.MouseLeave

        btnamv_reinstall_mod_pack.BackColor = Color.Transparent
    End Sub

    Private Sub btnamv_reinstall_mod_pack_Click(sender As Object, e As EventArgs) Handles btnamv_reinstall_mod_pack.Click

        'comprobación de requerimientos para reinstalar los mods
        If My.Computer.Network.IsAvailable = False Then

            MsgBox("Necesitas conexión a Internet!", MsgBoxStyle.Critical, "#")
        End If

        Dim dirminecraft As String = appdata & "\.minecraft"

        If Directory.Exists(dirminecraft) Then

            bw_reinstallmods.RunWorkerAsync()
        Else

            MsgBox("Ups!, no se encontro tu .minecraft.", MsgBoxStyle.Critical, "#")
        End If

    End Sub

    Private Sub btnamv_update_mod_pack_MouseEnter(sender As Object, e As EventArgs) Handles btnamv_update_mod_pack.MouseEnter

        btnamv_update_mod_pack.BackColor = Color.FromArgb(139, 148, 158)
    End Sub

    Private Sub btnamv_update_mod_pack_MouseLeave(sender As Object, e As EventArgs) Handles btnamv_update_mod_pack.MouseLeave

        btnamv_update_mod_pack.BackColor = Color.Transparent
    End Sub

    Private Sub btnamv_update_mod_pack_Click(sender As Object, e As EventArgs) Handles btnamv_update_mod_pack.Click

        'comprobación de requerimientos para actualizar los mods
        If My.Computer.Network.IsAvailable = False Then
            MsgBox("Necesitas conexión a Internet!", MsgBoxStyle.Critical, "#")
            Return
        End If

        Dim dirminecraftmods As String = appdata & "\.minecraft\mods"

        If Directory.Exists(dirminecraftmods) Then

            bw_updatemods.RunWorkerAsync()
        Else

            MsgBox("Ups!, no se encontro tu .minecraft.", MsgBoxStyle.Critical, "#")
        End If

    End Sub

    Private Sub bw_installmods_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_installmods.DoWork

        'download mod pack alternative 2, read line to line
        'Dim connection_mods_txt As System.IO.StreamReader
        'connection_mods_txt = File.OpenText("C:\Users\friki\Desktop\connection-mods\connection-mods.txt")

        'Do Until connection_mods_txt.EndOfStream

        '    'TextBox1.Text = TextBox1.Text & connection_mods_txt.ReadLine & vbCrLf
        '    'download sure.zip
        '    My.Computer.Network.DownloadFile((connection_mods_txt.ReadLine), (program_files & "\AmvPrograms\launch-mod\mc\asd.jar"), "", "", True, 2000, True)
        'Loop

        'connection_mods_txt.Close()

        'path install launch-mod
        Dim raiz As String = program_files & "\AmvPrograms\launch-mod"

        'connection_sure = sure.zip link download
        My.Computer.Network.DownloadFile((host_sure), (raiz & "\connection-sure.txt"), "", "", False, 2000, True)
        Dim connection_sure As String
        connection_sure = My.Computer.FileSystem.ReadAllText(raiz & "\connection-sure.txt")

        'download sure.zip
        My.Computer.Network.DownloadFile((connection_sure), (program_files & "\AmvPrograms\launch-mod\mc\sure.zip"), "", "", True, 2000, True)

        'unzip sure.zip
        ZipFile.ExtractToDirectory(program_files & "\AmvPrograms\launch-mod\mc\sure.zip", appdata & "\")

        'delete restos
        File.Delete(raiz & "\connection-sure.txt")
        File.Delete(program_files & "\AmvPrograms\launch-mod\mc\sure.zip")

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

        'path install launch-mod
        Dim raiz As String = program_files & "\AmvPrograms\launch-mod"

        'delete /.minecraft
        Directory.Delete(appdata & "\.minecraft", True)

        'connection_sure = sure.zip link download
        My.Computer.Network.DownloadFile((host_sure), (raiz & "\connection-sure.txt"), "", "", False, 2000, True)
        Dim connection_sure As String
        connection_sure = My.Computer.FileSystem.ReadAllText(raiz & "\connection-sure.txt")

        'download sure.zip
        My.Computer.Network.DownloadFile((connection_sure), (program_files & "\AmvPrograms\launch-mod\mc\sure.zip"), "", "", True, 2000, True)

        'unzip sure.zip
        ZipFile.ExtractToDirectory(program_files & "\AmvPrograms\launch-mod\mc\sure.zip", appdata & "\")

        'delete restos
        File.Delete(raiz & "\connection-sure.txt")
        File.Delete(program_files & "\AmvPrograms\launch-mod\mc\sure.zip")

        'si tiene un perfil graphic guadado te lo vuele a poner, si no, no
        Dim pg_txt As String = program_files & "\AmvPrograms\launch-mod\perfil-graphic.txt"

        If File.Exists(pg_txt) Then

            'leé perfil-graphic.txt y lo guarda en perfil_graphic_read
            Dim perfil_graphic_read As String
            perfil_graphic_read = My.Computer.FileSystem.ReadAllText(raiz & "\perfil-graphic.txt")

            'si perfil_graphic_read es  = a alto descarga y pone el alto.zip
            If (perfil_graphic_read = "alto") Then

                'connection_host = perfiles graficos link download
                My.Computer.Network.DownloadFile((host_perfil_graphic), (raiz & "\connection-perfil-graphic.txt"), "", "", False, 2000, True)
                Dim connection_host As String
                connection_host = My.Computer.FileSystem.ReadAllText(raiz & "\connection-perfil-graphic.txt")

                'download perfil_graphic.zip
                My.Computer.Network.DownloadFile((connection_host & "/alto.zip"), (program_files & "\AmvPrograms\launch-mod\mc\alto.zip"), "", "", True, 2000, True)

                'unzip perfil_graphic.zip
                ZipFile.ExtractToDirectory(program_files & "\AmvPrograms\launch-mod\mc\alto.zip", appdata & "\.minecraft")

                'delete restos
                File.Delete(raiz & "\connection-perfil-graphic.txt.txt")
                File.Delete(program_files & "\AmvPrograms\launch-mod\mc\alto.zip")

                MsgBox("Listo, dale (ok) para continuar!", MsgBoxStyle.Information, "#")

                'si perfil_graphic_read es  = a normal descarga y pone el normal.zip
            ElseIf (perfil_graphic_read = "normal") Then

                'connection_host = perfiles graficos link download
                My.Computer.Network.DownloadFile((host_perfil_graphic), (raiz & "\connection-perfil-graphic.txt"), "", "", False, 2000, True)
                Dim connection_host As String
                connection_host = My.Computer.FileSystem.ReadAllText(raiz & "\connection-perfil-graphic.txt")

                'download perfil_graphic.zip
                My.Computer.Network.DownloadFile((connection_host & "/normal.zip"), (program_files & "\AmvPrograms\launch-mod\mc\normal.zip"), "", "", True, 2000, True)

                'unzip perfil_graphic.zip
                ZipFile.ExtractToDirectory(program_files & "\AmvPrograms\launch-mod\mc\normal.zip", appdata & "\.minecraft")

                'delete restos
                File.Delete(raiz & "\connection-perfil-graphic.txt")
                File.Delete(program_files & "\AmvPrograms\launch-mod\mc\normal.zip")

                MsgBox("Listo, dale (ok) para continuar!", MsgBoxStyle.Information, "#")

                'si perfil_graphic_read es  = a bajo descarga y pone el bajo.zip
            ElseIf (perfil_graphic_read = "bajo") Then

                'connection_host = perfiles graficos link download
                My.Computer.Network.DownloadFile((host_perfil_graphic), (raiz & "\connection-perfil-graphic.txt"), "", "", False, 2000, True)
                Dim connection_host As String
                connection_host = My.Computer.FileSystem.ReadAllText(raiz & "\connection-perfil-graphic.txt")

                'download perfil_graphic.zip
                My.Computer.Network.DownloadFile((connection_host & "/bajo.zip"), (program_files & "\AmvPrograms\launch-mod\mc\bajo.zip"), "", "", True, 2000, True)

                'unzip perfil_graphic.zip
                ZipFile.ExtractToDirectory(program_files & "\AmvPrograms\launch-mod\mc\bajo.zip", appdata & "\.minecraft")

                'delete restos
                File.Delete(raiz & "\connection-perfil-graphic.txt")
                File.Delete(program_files & "\AmvPrograms\launch-mod\mc\bajo.zip")

                MsgBox("Listo, dale (ok) para continuar!", MsgBoxStyle.Information, "#")

            Else
                MsgBox("Ups!, algo no salió bien D:", MsgBoxStyle.Critical, "#")
                Return
            End If

        Else

            MsgBox("Listo, pack de mods instalado, recuerda volver a seleccionar tu perfil gráfico :D!", MsgBoxStyle.Information, "#")
        End If

        Dim launchermc_txt As String = program_files & "\AmvPrograms\launch-mod\launcher-mc.txt"

        If File.Exists(launchermc_txt) Then

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
        Else

            MsgBox("Listo, pack de mods instalado, recuerda volver a seleccionar con que tipo de launcher quieres jugar :D!", MsgBoxStyle.Information, "#")
        End If

    End Sub

End Class