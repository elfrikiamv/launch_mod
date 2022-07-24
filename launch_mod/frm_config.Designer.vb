<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_config
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_config))
        Me.btn_update = New System.Windows.Forms.Button()
        Me.bw_update = New System.ComponentModel.BackgroundWorker()
        Me.btn_install = New System.Windows.Forms.Button()
        Me.bw_installmods = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox_config_graphic = New System.Windows.Forms.GroupBox()
        Me.Label_info_update_mods = New System.Windows.Forms.Label()
        Me.Label_info_graficos = New System.Windows.Forms.Label()
        Me.bnt_update_mod_pack = New System.Windows.Forms.Button()
        Me.ComboBox_perfil_graphic = New System.Windows.Forms.ComboBox()
        Me.Label_info_new_user = New System.Windows.Forms.Label()
        Me.btn_change_perfil_graphic = New System.Windows.Forms.Button()
        Me.btn_reinstall_mod_pack = New System.Windows.Forms.Button()
        Me.Label_info_change_perfil_graphic = New System.Windows.Forms.Label()
        Me.Label_info_reinstall_mod_pack = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox_config_graphic.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Italic)
        Me.btn_update.ForeColor = System.Drawing.Color.Black
        Me.btn_update.Location = New System.Drawing.Point(157, 526)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(185, 28)
        Me.btn_update.TabIndex = 0
        Me.btn_update.Text = "Actualizar Launcher."
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'bw_update
        '
        Me.bw_update.WorkerReportsProgress = True
        Me.bw_update.WorkerSupportsCancellation = True
        '
        'btn_install
        '
        Me.btn_install.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Italic)
        Me.btn_install.ForeColor = System.Drawing.Color.Black
        Me.btn_install.Location = New System.Drawing.Point(190, 165)
        Me.btn_install.Name = "btn_install"
        Me.btn_install.Size = New System.Drawing.Size(114, 28)
        Me.btn_install.TabIndex = 1
        Me.btn_install.Text = "install mods"
        Me.btn_install.UseVisualStyleBackColor = True
        '
        'bw_installmods
        '
        Me.bw_installmods.WorkerReportsProgress = True
        Me.bw_installmods.WorkerSupportsCancellation = True
        '
        'GroupBox_config_graphic
        '
        Me.GroupBox_config_graphic.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox_config_graphic.Controls.Add(Me.Label1)
        Me.GroupBox_config_graphic.Controls.Add(Me.Label_info_update_mods)
        Me.GroupBox_config_graphic.Controls.Add(Me.btn_install)
        Me.GroupBox_config_graphic.Controls.Add(Me.Label_info_graficos)
        Me.GroupBox_config_graphic.Controls.Add(Me.bnt_update_mod_pack)
        Me.GroupBox_config_graphic.Controls.Add(Me.btn_update)
        Me.GroupBox_config_graphic.Controls.Add(Me.ComboBox_perfil_graphic)
        Me.GroupBox_config_graphic.Controls.Add(Me.Label_info_new_user)
        Me.GroupBox_config_graphic.Controls.Add(Me.btn_change_perfil_graphic)
        Me.GroupBox_config_graphic.Controls.Add(Me.btn_reinstall_mod_pack)
        Me.GroupBox_config_graphic.Controls.Add(Me.Label_info_change_perfil_graphic)
        Me.GroupBox_config_graphic.Controls.Add(Me.Label_info_reinstall_mod_pack)
        Me.GroupBox_config_graphic.Font = New System.Drawing.Font("Consolas", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_config_graphic.ForeColor = System.Drawing.Color.White
        Me.GroupBox_config_graphic.Location = New System.Drawing.Point(21, 21)
        Me.GroupBox_config_graphic.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox_config_graphic.Name = "GroupBox_config_graphic"
        Me.GroupBox_config_graphic.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox_config_graphic.Size = New System.Drawing.Size(510, 568)
        Me.GroupBox_config_graphic.TabIndex = 4
        Me.GroupBox_config_graphic.TabStop = False
        Me.GroupBox_config_graphic.Text = "Instalación de Mods:"
        '
        'Label_info_update_mods
        '
        Me.Label_info_update_mods.AutoSize = True
        Me.Label_info_update_mods.BackColor = System.Drawing.Color.Transparent
        Me.Label_info_update_mods.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_info_update_mods.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label_info_update_mods.Location = New System.Drawing.Point(22, 416)
        Me.Label_info_update_mods.MaximumSize = New System.Drawing.Size(470, 0)
        Me.Label_info_update_mods.Name = "Label_info_update_mods"
        Me.Label_info_update_mods.Size = New System.Drawing.Size(464, 18)
        Me.Label_info_update_mods.TabIndex = 11
        Me.Label_info_update_mods.Text = "- Actualizar pack de mods, esto NO borrará tú .minecraft."
        '
        'Label_info_graficos
        '
        Me.Label_info_graficos.AutoSize = True
        Me.Label_info_graficos.BackColor = System.Drawing.Color.Transparent
        Me.Label_info_graficos.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_info_graficos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label_info_graficos.Location = New System.Drawing.Point(22, 33)
        Me.Label_info_graficos.MaximumSize = New System.Drawing.Size(470, 0)
        Me.Label_info_graficos.Name = "Label_info_graficos"
        Me.Label_info_graficos.Size = New System.Drawing.Size(464, 36)
        Me.Label_info_graficos.TabIndex = 10
        Me.Label_info_graficos.Text = "- Selecciona un perfil de configuración gráfica según tu PC:"
        '
        'bnt_update_mod_pack
        '
        Me.bnt_update_mod_pack.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_update_mod_pack.ForeColor = System.Drawing.Color.Black
        Me.bnt_update_mod_pack.Location = New System.Drawing.Point(190, 449)
        Me.bnt_update_mod_pack.Name = "bnt_update_mod_pack"
        Me.bnt_update_mod_pack.Size = New System.Drawing.Size(114, 30)
        Me.bnt_update_mod_pack.TabIndex = 9
        Me.bnt_update_mod_pack.Text = "Actualizar"
        Me.bnt_update_mod_pack.UseVisualStyleBackColor = True
        '
        'ComboBox_perfil_graphic
        '
        Me.ComboBox_perfil_graphic.DropDownHeight = 80
        Me.ComboBox_perfil_graphic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_perfil_graphic.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_perfil_graphic.FormattingEnabled = True
        Me.ComboBox_perfil_graphic.IntegralHeight = False
        Me.ComboBox_perfil_graphic.Items.AddRange(New Object() {"alto", "normal", "bajo"})
        Me.ComboBox_perfil_graphic.Location = New System.Drawing.Point(154, 70)
        Me.ComboBox_perfil_graphic.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ComboBox_perfil_graphic.Name = "ComboBox_perfil_graphic"
        Me.ComboBox_perfil_graphic.Size = New System.Drawing.Size(182, 26)
        Me.ComboBox_perfil_graphic.TabIndex = 0
        '
        'Label_info_new_user
        '
        Me.Label_info_new_user.AutoSize = True
        Me.Label_info_new_user.BackColor = System.Drawing.Color.Transparent
        Me.Label_info_new_user.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_info_new_user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label_info_new_user.Location = New System.Drawing.Point(22, 112)
        Me.Label_info_new_user.MaximumSize = New System.Drawing.Size(470, 0)
        Me.Label_info_new_user.Name = "Label_info_new_user"
        Me.Label_info_new_user.Size = New System.Drawing.Size(464, 36)
        Me.Label_info_new_user.TabIndex = 4
        Me.Label_info_new_user.Text = "- Para instalar por primera vez el pack de mods en tu PC, (Solo para usuarios NUE" &
    "VOS)."
        '
        'btn_change_perfil_graphic
        '
        Me.btn_change_perfil_graphic.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_change_perfil_graphic.ForeColor = System.Drawing.Color.Black
        Me.btn_change_perfil_graphic.Location = New System.Drawing.Point(190, 369)
        Me.btn_change_perfil_graphic.Name = "btn_change_perfil_graphic"
        Me.btn_change_perfil_graphic.Size = New System.Drawing.Size(114, 28)
        Me.btn_change_perfil_graphic.TabIndex = 8
        Me.btn_change_perfil_graphic.Text = "Cambiar"
        Me.btn_change_perfil_graphic.UseVisualStyleBackColor = True
        '
        'btn_reinstall_mod_pack
        '
        Me.btn_reinstall_mod_pack.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Italic)
        Me.btn_reinstall_mod_pack.ForeColor = System.Drawing.Color.Black
        Me.btn_reinstall_mod_pack.Location = New System.Drawing.Point(190, 275)
        Me.btn_reinstall_mod_pack.Name = "btn_reinstall_mod_pack"
        Me.btn_reinstall_mod_pack.Size = New System.Drawing.Size(114, 28)
        Me.btn_reinstall_mod_pack.TabIndex = 5
        Me.btn_reinstall_mod_pack.Text = "Reinstalar"
        Me.btn_reinstall_mod_pack.UseVisualStyleBackColor = True
        '
        'Label_info_change_perfil_graphic
        '
        Me.Label_info_change_perfil_graphic.AutoSize = True
        Me.Label_info_change_perfil_graphic.BackColor = System.Drawing.Color.Transparent
        Me.Label_info_change_perfil_graphic.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_info_change_perfil_graphic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label_info_change_perfil_graphic.Location = New System.Drawing.Point(22, 319)
        Me.Label_info_change_perfil_graphic.MaximumSize = New System.Drawing.Size(470, 0)
        Me.Label_info_change_perfil_graphic.Name = "Label_info_change_perfil_graphic"
        Me.Label_info_change_perfil_graphic.Size = New System.Drawing.Size(464, 36)
        Me.Label_info_change_perfil_graphic.TabIndex = 7
        Me.Label_info_change_perfil_graphic.Text = "- Si ya tienes el pack de mods instalado, puedes cambiar el perfil de configuraci" &
    "ón gráfica."
        '
        'Label_info_reinstall_mod_pack
        '
        Me.Label_info_reinstall_mod_pack.AutoSize = True
        Me.Label_info_reinstall_mod_pack.BackColor = System.Drawing.Color.Transparent
        Me.Label_info_reinstall_mod_pack.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_info_reinstall_mod_pack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label_info_reinstall_mod_pack.Location = New System.Drawing.Point(22, 208)
        Me.Label_info_reinstall_mod_pack.MaximumSize = New System.Drawing.Size(470, 0)
        Me.Label_info_reinstall_mod_pack.Name = "Label_info_reinstall_mod_pack"
        Me.Label_info_reinstall_mod_pack.Size = New System.Drawing.Size(464, 54)
        Me.Label_info_reinstall_mod_pack.TabIndex = 6
        Me.Label_info_reinstall_mod_pack.Text = "- Si tienes problemas con el juego, prueba reinstalar el pack de mods, (Esto BORR" &
    "ARÁ tú .minecraft y te pondrá una instalación limpia)."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(23, 496)
        Me.Label1.MaximumSize = New System.Drawing.Size(470, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "- Buscar actualizaciones de launch_mod."
        '
        'frm_config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(557, 614)
        Me.Controls.Add(Me.GroupBox_config_graphic)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_config"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración"
        Me.GroupBox_config_graphic.ResumeLayout(False)
        Me.GroupBox_config_graphic.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_update As Button
    Friend WithEvents bw_update As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_install As Button
    Friend WithEvents bw_installmods As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox_config_graphic As GroupBox
    Friend WithEvents Label_info_update_mods As Label
    Friend WithEvents Label_info_graficos As Label
    Friend WithEvents bnt_update_mod_pack As Button
    Friend WithEvents ComboBox_perfil_graphic As ComboBox
    Friend WithEvents Label_info_new_user As Label
    Friend WithEvents btn_change_perfil_graphic As Button
    Friend WithEvents btn_reinstall_mod_pack As Button
    Friend WithEvents Label_info_change_perfil_graphic As Label
    Friend WithEvents Label_info_reinstall_mod_pack As Label
    Friend WithEvents Label1 As Label
End Class
