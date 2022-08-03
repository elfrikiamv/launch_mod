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

    Private Sub btnamv_packmods_MouseEnter(sender As Object, e As EventArgs) Handles btnamv_packmods.MouseEnter

        btnamv_packmods.BackColor = Color.FromArgb(139, 148, 158)
    End Sub

    Private Sub btnamv_packmods_MouseLeave(sender As Object, e As EventArgs) Handles btnamv_packmods.MouseLeave

        btnamv_packmods.BackColor = Color.Transparent
    End Sub
    Private Sub btnamv_packmods_Click(sender As Object, e As EventArgs) Handles btnamv_packmods.Click

        'invocamos al metodo frm_mods_beta
        AbrirFormEnPanel(Of frm_mods_beta)()

        'change bgcolor of btn
        'btn_packmods.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub btnamv_perfilgraphic_MouseEnter(sender As Object, e As EventArgs) Handles btnamv_perfilgraphic.MouseEnter

        btnamv_perfilgraphic.BackColor = Color.FromArgb(139, 148, 158)
    End Sub

    Private Sub btnamv_perfilgraphic_MouseLeave(sender As Object, e As EventArgs) Handles btnamv_perfilgraphic.MouseLeave

        btnamv_perfilgraphic.BackColor = Color.Transparent
    End Sub
    Private Sub btnamv_perfilgraphic_Click(sender As Object, e As EventArgs) Handles btnamv_perfilgraphic.Click

        'invocamos al metodo frm_perfilg
        AbrirFormEnPanel(Of frm_perfilg)()
    End Sub

    Private Sub btnamv_launchmc_MouseEnter(sender As Object, e As EventArgs) Handles btnamv_launchmc.MouseEnter

        btnamv_launchmc.BackColor = Color.FromArgb(139, 148, 158)
    End Sub

    Private Sub btnamv_launchmc_MouseLeave(sender As Object, e As EventArgs) Handles btnamv_launchmc.MouseLeave

        btnamv_launchmc.BackColor = Color.Transparent
    End Sub
    Private Sub btnamv_launchmc_Click(sender As Object, e As EventArgs) Handles btnamv_launchmc.Click

        'invocamos al metodo frm_launchermc
        AbrirFormEnPanel(Of frm_launchermc)()
    End Sub
End Class