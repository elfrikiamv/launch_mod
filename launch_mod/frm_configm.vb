Public Class frm_configm
    Private Sub frm_configm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()

        'Busca el formulario en la coleccion
        Dim Formulario As Form
        Formulario = pnl_containerfrm.Controls.OfType(Of Miform)().FirstOrDefault()

        'Si form no fue econtrado/ no existe
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False

            'quita el borde a los frm
            Formulario.FormBorderStyle = FormBorderStyle.None

            'resize a todo el panel
            Formulario.Dock = DockStyle.Fill

            pnl_containerfrm.Controls.Add(Formulario)
            pnl_containerfrm.Tag = Formulario
            Formulario.Show()
            'coloco el frm siempre enfrente de otro
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If

    End Sub

    Private Sub btn_packmods_Click(sender As Object, e As EventArgs) Handles btn_packmods.Click

        'invocamos al metodo AbrirFormEnPanel
        AbrirFormEnPanel(Of frm_mods)()
    End Sub

    Private Sub btn_configgrafica_Click(sender As Object, e As EventArgs) Handles btn_configgrafica.Click

        'invocamos al metodo AbrirFormEnPanel
        AbrirFormEnPanel(Of frm_perfilg)()
    End Sub

    Private Sub btn_launchmc_Click(sender As Object, e As EventArgs) Handles btn_launchmc.Click

        'invocamos al metodo AbrirFormEnPanel
        AbrirFormEnPanel(Of frm_launchermc)()
    End Sub
End Class