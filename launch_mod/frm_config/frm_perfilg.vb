Imports System.IO
Imports System.IO.Compression
Imports System.Text

Public Class frm_perfilg

    'path roaming 
    Dim appdata As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    'path program files
    Dim program_files As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)
    'link perfil_grafico.zip
    Dim host_perfil_graphic As String = "https://pastebin.com/raw/SeYj4QG0"

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
            MsgBox("Selecciona un perfil gráfico!", MsgBoxStyle.Exclamation, "#")
            Return
        End If

        Dim dirminecraft As String = appdata & "\.minecraft"

        If Directory.Exists(dirminecraft) Then

            Dim pg_txt As String = program_files & "\AmvPrograms\launch-mod\perfil-graphic.txt"

            If File.Exists(pg_txt) Then

                Dim launchermc_true As String
                launchermc_true = MsgBox("¡Ya cuentas con un perfil gráfico seleccionado!" & vbNewLine & "¿Quiere cambiarlo?", vbYesNo)

                If (launchermc_true = vbYes) Then

                    'delete perfil_graphic_files
                    Dim options_txt As String = appdata & "\.minecraft\options.txt"
                    Dim perfil_txt As String = appdata & "\.minecraft\perfil.txt"
                    Dim servers_dat As String = appdata & "\.minecraft\servers.dat"

                    If File.Exists(options_txt) Then

                        File.Delete(appdata & "\.minecraft\options.txt")

                        If File.Exists(perfil_txt) Then

                            File.Delete(appdata & "\.minecraft\perfil.txt")

                            If File.Exists(servers_dat) Then

                                File.Delete(appdata & "\.minecraft\servers.dat")

                                bw_installpg.RunWorkerAsync()
                            Else

                                bw_installpg.RunWorkerAsync()
                            End If
                        Else

                            If File.Exists(servers_dat) Then

                                File.Delete(appdata & "\.minecraft\servers.dat")

                                bw_installpg.RunWorkerAsync()
                            Else

                                bw_installpg.RunWorkerAsync()
                            End If
                        End If
                    ElseIf File.Exists(perfil_txt) Then

                        File.Delete(appdata & "\.minecraft\perfil.txt")

                        If File.Exists(servers_dat) Then

                            File.Delete(appdata & "\.minecraft\servers.dat")

                            bw_installpg.RunWorkerAsync()
                        Else

                            bw_installpg.RunWorkerAsync()
                        End If
                    ElseIf File.Exists(servers_dat) Then

                        File.Delete(appdata & "\.minecraft\servers.dat")

                        bw_installpg.RunWorkerAsync()
                    Else
                        bw_installpg.RunWorkerAsync()
                    End If

                End If
            Else

                'delete perfil_graphic_files
                Dim options_txt As String = appdata & "\.minecraft\options.txt"
                Dim perfil_txt As String = appdata & "\.minecraft\perfil.txt"
                Dim servers_dat As String = appdata & "\.minecraft\servers.dat"

                If File.Exists(options_txt) Then

                    File.Delete(appdata & "\.minecraft\options.txt")

                    If File.Exists(perfil_txt) Then

                        File.Delete(appdata & "\.minecraft\perfil.txt")

                        If File.Exists(servers_dat) Then

                            File.Delete(appdata & "\.minecraft\servers.dat")

                            bw_installpg.RunWorkerAsync()
                        Else

                            bw_installpg.RunWorkerAsync()
                        End If
                    Else

                        If File.Exists(servers_dat) Then

                            File.Delete(appdata & "\.minecraft\servers.dat")

                            bw_installpg.RunWorkerAsync()
                        Else

                            bw_installpg.RunWorkerAsync()
                        End If
                    End If
                ElseIf File.Exists(perfil_txt) Then

                    File.Delete(appdata & "\.minecraft\perfil.txt")

                    If File.Exists(servers_dat) Then

                        File.Delete(appdata & "\.minecraft\servers.dat")

                        bw_installpg.RunWorkerAsync()
                    Else

                        bw_installpg.RunWorkerAsync()
                    End If
                ElseIf File.Exists(servers_dat) Then

                    File.Delete(appdata & "\.minecraft\servers.dat")

                    bw_installpg.RunWorkerAsync()
                Else
                    bw_installpg.RunWorkerAsync()
                End If

            End If
        Else

            MsgBox("No se encontró tu .minecraft, prueba instalar el pack de mods primero :D", MsgBoxStyle.Exclamation, "#")
        End If
    End Sub

    Private Sub bw_installpg_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_installpg.DoWork

        'agarra que perfil grafico va a utilizar
        Dim perfil_graphic As String = ComboBox_perfil_graphic.SelectedItem

        'path install launch-mod
        Dim raiz As String = program_files & "\AmvPrograms\launch-mod"
        Dim perfil_graphic_txt As String = program_files & "\AmvPrograms\launch-mod\perfil-graphic.txt"

        ' Create or overwrite the file.
        Dim create_txt As FileStream = File.Create(perfil_graphic_txt)

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

    End Sub
End Class