<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_configm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_configm))
        Me.pnl_containerbtn = New System.Windows.Forms.Panel()
        Me.pnl_containerfrm = New System.Windows.Forms.Panel()
        Me.btn_packmods = New System.Windows.Forms.Button()
        Me.btn_configgrafica = New System.Windows.Forms.Button()
        Me.btn_launchmc = New System.Windows.Forms.Button()
        Me.pnl_containerbtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_containerbtn
        '
        Me.pnl_containerbtn.BackColor = System.Drawing.Color.DimGray
        Me.pnl_containerbtn.Controls.Add(Me.btn_launchmc)
        Me.pnl_containerbtn.Controls.Add(Me.btn_configgrafica)
        Me.pnl_containerbtn.Controls.Add(Me.btn_packmods)
        Me.pnl_containerbtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_containerbtn.Location = New System.Drawing.Point(0, 0)
        Me.pnl_containerbtn.Name = "pnl_containerbtn"
        Me.pnl_containerbtn.Size = New System.Drawing.Size(142, 451)
        Me.pnl_containerbtn.TabIndex = 0
        '
        'pnl_containerfrm
        '
        Me.pnl_containerfrm.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnl_containerfrm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_containerfrm.Location = New System.Drawing.Point(142, 0)
        Me.pnl_containerfrm.Name = "pnl_containerfrm"
        Me.pnl_containerfrm.Size = New System.Drawing.Size(505, 451)
        Me.pnl_containerfrm.TabIndex = 1
        '
        'btn_packmods
        '
        Me.btn_packmods.Location = New System.Drawing.Point(-1, 183)
        Me.btn_packmods.Name = "btn_packmods"
        Me.btn_packmods.Size = New System.Drawing.Size(145, 48)
        Me.btn_packmods.TabIndex = 0
        Me.btn_packmods.Text = "Pack de mods"
        Me.btn_packmods.UseVisualStyleBackColor = True
        '
        'btn_configgrafica
        '
        Me.btn_configgrafica.Location = New System.Drawing.Point(-1, 132)
        Me.btn_configgrafica.Name = "btn_configgrafica"
        Me.btn_configgrafica.Size = New System.Drawing.Size(145, 48)
        Me.btn_configgrafica.TabIndex = 1
        Me.btn_configgrafica.Text = "Perfil grafico"
        Me.btn_configgrafica.UseVisualStyleBackColor = True
        '
        'btn_launchmc
        '
        Me.btn_launchmc.Location = New System.Drawing.Point(-1, 235)
        Me.btn_launchmc.Name = "btn_launchmc"
        Me.btn_launchmc.Size = New System.Drawing.Size(145, 48)
        Me.btn_launchmc.TabIndex = 2
        Me.btn_launchmc.Text = "Minecraft launcher"
        Me.btn_launchmc.UseVisualStyleBackColor = True
        '
        'frm_configm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(647, 451)
        Me.Controls.Add(Me.pnl_containerfrm)
        Me.Controls.Add(Me.pnl_containerbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_configm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración"
        Me.pnl_containerbtn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_containerbtn As Panel
    Friend WithEvents pnl_containerfrm As Panel
    Friend WithEvents btn_launchmc As Button
    Friend WithEvents btn_configgrafica As Button
    Friend WithEvents btn_packmods As Button
End Class
