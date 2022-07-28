Imports System.IO
Imports System.IO.Compression
Imports System.Text

Public Class frm_perfilg

    'path roaming 
    Dim appdata As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    'path program files
    Dim program_files As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)
    'link perfil_grafico.zip
    Dim host_update As String = "https://pastebin.com/raw/8WkGED1G"

    Private Sub frm_perfilg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckForIllegalCrossThreadCalls = False

    End Sub

    Private Sub btn_savepg_Click(sender As Object, e As EventArgs) Handles btn_savepg.Click

        'comprobación de requerimientos para instalar los mods
        If My.Computer.Network.IsAvailable = False Then
            MsgBox("Necesitas conexión a Internet!", MsgBoxStyle.Critical, "#")
            Return
        End If

        If ComboBox_perfil_graphic.SelectedItem = Nothing Then
            MsgBox("Selecciona una configuración gráfica!", MsgBoxStyle.Exclamation, "#")
            Return
        End If

        bw_installpg.RunWorkerAsync()

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
            Return
        End If

    End Sub

    Private Sub bw_changeperfilgraphic_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_changeperfilgraphic.DoWork

        'delete perfil_graphic.txt
        File.Delete(program_files & "\AmvPrograms\launch-mod\perfil-graphic.txt")

        'agarra que perfil grafico va a utilizar
        Dim perfil_graphic As String = ComboBox_perfil_graphic.SelectedItem

        'path install launch-mod
        Dim raiz As String = program_files & "\AmvPrograms\launch-mod"
        Dim raiz_txt As String = program_files & "\AmvPrograms\launch-mod\perfil-graphic.txt"

        ' Create or overwrite the file.
        Dim create_txt As FileStream = File.Create(raiz_txt)

        ' Add text to the file.
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(perfil_graphic)
        create_txt.Write(info, 0, info.Length)
        create_txt.Close()

        'leé perfil-graphic.txt y lo guarda en perfil_graphic_read
        Dim perfil_graphic_read As String
        perfil_graphic_read = My.Computer.FileSystem.ReadAllText(raiz & "\perfil-graphic.txt")

        'delete perfil_graphic files
        File.Delete(appdata & "\.minecraft\launcher_profiles.json")
        File.Delete(appdata & "\.minecraft\options.txt")
        File.Delete(appdata & "\.minecraft\perfil.txt")
        File.Delete(appdata & "\.minecraft\servers.dat")

        'si perfil_graphic_read es  = a alto descarga y pone el alto.zip
        If (perfil_graphic_read = "alto") Then

            'connection_host = perfiles graficos link download
            My.Computer.Network.DownloadFile((host_update), (raiz & "\connection.txt"), "", "", False, 2000, True)
            Dim connection_host As String
            connection_host = My.Computer.FileSystem.ReadAllText(raiz & "\connection.txt")

            'download perfil_graphic.zip
            My.Computer.Network.DownloadFile((connection_host & "/alto.zip"), (program_files & "\AmvPrograms\launch-mod\mc\alto.zip"), "", "", True, 2000, True)

            'unzip perfil_graphic.zip
            ZipFile.ExtractToDirectory(program_files & "\AmvPrograms\launch-mod\mc\alto.zip", appdata & "\.minecraft")

            'delete restos
            File.Delete(raiz & "\connection.txt")
            File.Delete(program_files & "\AmvPrograms\launch-mod\mc\alto.zip")

            MsgBox("Listo, dale (ok) para continuar!", MsgBoxStyle.Information, "#")

            'si perfil_graphic_read es  = a normal descarga y pone el normal.zip
        ElseIf (perfil_graphic_read = "normal") Then

            'connection_host = perfiles graficos link download
            My.Computer.Network.DownloadFile((host_update), (raiz & "\connection.txt"), "", "", False, 2000, True)
            Dim connection_host As String
            connection_host = My.Computer.FileSystem.ReadAllText(raiz & "\connection.txt")

            'download perfil_graphic.zip
            My.Computer.Network.DownloadFile((connection_host & "/normal.zip"), (program_files & "\AmvPrograms\launch-mod\mc\normal.zip"), "", "", True, 2000, True)

            'unzip perfil_graphic.zip
            ZipFile.ExtractToDirectory(program_files & "\AmvPrograms\launch-mod\mc\normal.zip", appdata & "\.minecraft")

            'delete restos
            File.Delete(raiz & "\connection.txt")
            File.Delete(program_files & "\AmvPrograms\launch-mod\mc\normal.zip")

            MsgBox("Listo, dale (ok) para continuar!", MsgBoxStyle.Information, "#")

            'si perfil_graphic_read es  = a bajo descarga y pone el bajo.zip
        ElseIf (perfil_graphic_read = "bajo") Then

            'connection_host = perfiles graficos link download
            My.Computer.Network.DownloadFile((host_update), (raiz & "\connection.txt"), "", "", False, 2000, True)
            Dim connection_host As String
            connection_host = My.Computer.FileSystem.ReadAllText(raiz & "\connection.txt")

            'download perfil_graphic.zip
            My.Computer.Network.DownloadFile((connection_host & "/bajo.zip"), (program_files & "\AmvPrograms\launch-mod\mc\bajo.zip"), "", "", True, 2000, True)

            'unzip perfil_graphic.zip
            ZipFile.ExtractToDirectory(program_files & "\AmvPrograms\launch-mod\mc\bajo.zip", appdata & "\.minecraft")

            'delete restos
            File.Delete(raiz & "\connection.txt")
            File.Delete(program_files & "\AmvPrograms\launch-mod\mc\bajo.zip")

            MsgBox("Listo, dale (ok) para continuar!", MsgBoxStyle.Information, "#")

        Else
            MsgBox("Ups!, algo no salio bien D:", MsgBoxStyle.Critical, "#")
            Return
        End If

    End Sub

    Private Sub bw_installpg_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_installpg.DoWork

        'agarra que perfil grafico va a utilizar
        Dim perfil_graphic As String = ComboBox_perfil_graphic.SelectedItem

        'path install launch-mod
        Dim raiz As String = program_files & "\AmvPrograms\launch-mod"
        Dim raiz_txt As String = program_files & "\AmvPrograms\launch-mod\perfil-graphic.txt"

        ' Create or overwrite the file.
        Dim create_txt As FileStream = File.Create(raiz_txt)

        ' Add text to the file.
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(perfil_graphic)
        create_txt.Write(info, 0, info.Length)
        create_txt.Close()

        'leé perfil-graphic.txt y lo guarda en perfil_graphic_read
        Dim perfil_graphic_read As String
        perfil_graphic_read = My.Computer.FileSystem.ReadAllText(raiz & "\perfil-graphic.txt")


        'si perfil_graphic_read es  = a alto descarga y pone el alto.zip
        If (perfil_graphic_read = "alto") Then

            'connection_host = perfiles graficos link download
            My.Computer.Network.DownloadFile((host_update), (raiz & "\connection.txt"), "", "", False, 2000, True)
            Dim connection_host As String
            connection_host = My.Computer.FileSystem.ReadAllText(raiz & "\connection.txt")

            'download perfil_graphic.zip
            My.Computer.Network.DownloadFile((connection_host & "/alto.zip"), (program_files & "\AmvPrograms\launch-mod\mc\alto.zip"), "", "", True, 2000, True)

            'unzip perfil_graphic.zip
            ZipFile.ExtractToDirectory(program_files & "\AmvPrograms\launch-mod\mc\alto.zip", appdata & "\.minecraft")

            'delete restos
            File.Delete(raiz & "\connection.txt")
            File.Delete(program_files & "\AmvPrograms\launch-mod\mc\alto.zip")

            MsgBox("Listo, dale (ok) para continuar!", MsgBoxStyle.Information, "#")

            'si perfil_graphic_read es  = a normal descarga y pone el normal.zip
        ElseIf (perfil_graphic_read = "normal") Then

            'connection_host = perfiles graficos link download
            My.Computer.Network.DownloadFile((host_update), (raiz & "\connection.txt"), "", "", False, 2000, True)
            Dim connection_host As String
            connection_host = My.Computer.FileSystem.ReadAllText(raiz & "\connection.txt")

            'download perfil_graphic.zip
            My.Computer.Network.DownloadFile((connection_host & "/normal.zip"), (program_files & "\AmvPrograms\launch-mod\mc\normal.zip"), "", "", True, 2000, True)

            'unzip perfil_graphic.zip
            ZipFile.ExtractToDirectory(program_files & "\AmvPrograms\launch-mod\mc\normal.zip", appdata & "\.minecraft")

            'delete restos
            File.Delete(raiz & "\connection.txt")
            File.Delete(program_files & "\AmvPrograms\launch-mod\mc\normal.zip")

            MsgBox("Listo, dale (ok) para continuar!", MsgBoxStyle.Information, "#")

            'si perfil_graphic_read es  = a bajo descarga y pone el bajo.zip
        ElseIf (perfil_graphic_read = "bajo") Then

            'connection_host = perfiles graficos link download
            My.Computer.Network.DownloadFile((host_update), (raiz & "\connection.txt"), "", "", False, 2000, True)
            Dim connection_host As String
            connection_host = My.Computer.FileSystem.ReadAllText(raiz & "\connection.txt")

            'download perfil_graphic.zip
            My.Computer.Network.DownloadFile((connection_host & "/bajo.zip"), (program_files & "\AmvPrograms\launch-mod\mc\bajo.zip"), "", "", True, 2000, True)

            'unzip perfil_graphic.zip
            ZipFile.ExtractToDirectory(program_files & "\AmvPrograms\launch-mod\mc\bajo.zip", appdata & "\.minecraft")

            'delete restos
            File.Delete(raiz & "\connection.txt")
            File.Delete(program_files & "\AmvPrograms\launch-mod\mc\bajo.zip")

            MsgBox("Listo, dale (ok) para continuar!", MsgBoxStyle.Information, "#")

        Else
            MsgBox("Ups!, algo no salio bien D:", MsgBoxStyle.Critical, "#")
            Return
        End If

    End Sub
End Class