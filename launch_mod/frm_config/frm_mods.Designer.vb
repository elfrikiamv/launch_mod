<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_mods_beta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label_info_update_mods = New System.Windows.Forms.Label()
        Me.Label_info_new_user = New System.Windows.Forms.Label()
        Me.Label_info_reinstall_mod_pack = New System.Windows.Forms.Label()
        Me.bw_installmods = New System.ComponentModel.BackgroundWorker()
        Me.bw_updatemods = New System.ComponentModel.BackgroundWorker()
        Me.bw_reinstallmods = New System.ComponentModel.BackgroundWorker()
        Me.btnamv_install_mod_pack = New launch_mod.CustomControls.AmvControls.AmvButton()
        Me.btnamv_reinstall_mod_pack = New launch_mod.CustomControls.AmvControls.AmvButton()
        Me.btnamv_update_mod_pack = New launch_mod.CustomControls.AmvControls.AmvButton()
        Me.SuspendLayout()
        '
        'Label_info_update_mods
        '
        Me.Label_info_update_mods.AutoSize = True
        Me.Label_info_update_mods.BackColor = System.Drawing.Color.Transparent
        Me.Label_info_update_mods.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_info_update_mods.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label_info_update_mods.Location = New System.Drawing.Point(12, 226)
        Me.Label_info_update_mods.MaximumSize = New System.Drawing.Size(470, 0)
        Me.Label_info_update_mods.Name = "Label_info_update_mods"
        Me.Label_info_update_mods.Size = New System.Drawing.Size(464, 18)
        Me.Label_info_update_mods.TabIndex = 17
        Me.Label_info_update_mods.Text = "- Actualizar pack de mods, esto NO borrará tu .minecraft."
        '
        'Label_info_new_user
        '
        Me.Label_info_new_user.AutoSize = True
        Me.Label_info_new_user.BackColor = System.Drawing.Color.Transparent
        Me.Label_info_new_user.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_info_new_user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label_info_new_user.Location = New System.Drawing.Point(12, 17)
        Me.Label_info_new_user.MaximumSize = New System.Drawing.Size(470, 0)
        Me.Label_info_new_user.Name = "Label_info_new_user"
        Me.Label_info_new_user.Size = New System.Drawing.Size(464, 36)
        Me.Label_info_new_user.TabIndex = 13
        Me.Label_info_new_user.Text = "- Para instalar por primera vez el pack de mods en tu PC, (Solo para usuarios NUE" &
    "VOS)."
        '
        'Label_info_reinstall_mod_pack
        '
        Me.Label_info_reinstall_mod_pack.AutoSize = True
        Me.Label_info_reinstall_mod_pack.BackColor = System.Drawing.Color.Transparent
        Me.Label_info_reinstall_mod_pack.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_info_reinstall_mod_pack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label_info_reinstall_mod_pack.Location = New System.Drawing.Point(12, 114)
        Me.Label_info_reinstall_mod_pack.MaximumSize = New System.Drawing.Size(470, 0)
        Me.Label_info_reinstall_mod_pack.Name = "Label_info_reinstall_mod_pack"
        Me.Label_info_reinstall_mod_pack.Size = New System.Drawing.Size(464, 54)
        Me.Label_info_reinstall_mod_pack.TabIndex = 15
        Me.Label_info_reinstall_mod_pack.Text = "- Si tienes problemas con el juego, prueba reinstalar el pack de mods, (Esto BORR" &
    "ARÁ tu .minecraft y te pondrá una instalación limpia)."
        '
        'bw_installmods
        '
        Me.bw_installmods.WorkerReportsProgress = True
        Me.bw_installmods.WorkerSupportsCancellation = True
        '
        'bw_updatemods
        '
        Me.bw_updatemods.WorkerReportsProgress = True
        Me.bw_updatemods.WorkerSupportsCancellation = True
        '
        'bw_reinstallmods
        '
        Me.bw_reinstallmods.WorkerReportsProgress = True
        Me.bw_reinstallmods.WorkerSupportsCancellation = True
        '
        'btnamv_install_mod_pack
        '
        Me.btnamv_install_mod_pack.BackColor = System.Drawing.Color.Transparent
        Me.btnamv_install_mod_pack.BackgroundColor = System.Drawing.Color.Transparent
        Me.btnamv_install_mod_pack.BorderColor = System.Drawing.Color.White
        Me.btnamv_install_mod_pack.BorderRadius = 22
        Me.btnamv_install_mod_pack.BorderSize = 1
        Me.btnamv_install_mod_pack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnamv_install_mod_pack.FlatAppearance.BorderSize = 0
        Me.btnamv_install_mod_pack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnamv_install_mod_pack.Font = New System.Drawing.Font("Caviar Dreams", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnamv_install_mod_pack.ForeColor = System.Drawing.Color.White
        Me.btnamv_install_mod_pack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnamv_install_mod_pack.Location = New System.Drawing.Point(168, 61)
        Me.btnamv_install_mod_pack.Name = "btnamv_install_mod_pack"
        Me.btnamv_install_mod_pack.Size = New System.Drawing.Size(147, 42)
        Me.btnamv_install_mod_pack.TabIndex = 18
        Me.btnamv_install_mod_pack.Text = "instalar mods"
        Me.btnamv_install_mod_pack.TextColor = System.Drawing.Color.White
        Me.btnamv_install_mod_pack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnamv_install_mod_pack.UseVisualStyleBackColor = False
        '
        'btnamv_reinstall_mod_pack
        '
        Me.btnamv_reinstall_mod_pack.BackColor = System.Drawing.Color.Transparent
        Me.btnamv_reinstall_mod_pack.BackgroundColor = System.Drawing.Color.Transparent
        Me.btnamv_reinstall_mod_pack.BorderColor = System.Drawing.Color.White
        Me.btnamv_reinstall_mod_pack.BorderRadius = 22
        Me.btnamv_reinstall_mod_pack.BorderSize = 1
        Me.btnamv_reinstall_mod_pack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnamv_reinstall_mod_pack.FlatAppearance.BorderSize = 0
        Me.btnamv_reinstall_mod_pack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnamv_reinstall_mod_pack.Font = New System.Drawing.Font("Caviar Dreams", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnamv_reinstall_mod_pack.ForeColor = System.Drawing.Color.White
        Me.btnamv_reinstall_mod_pack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnamv_reinstall_mod_pack.Location = New System.Drawing.Point(168, 171)
        Me.btnamv_reinstall_mod_pack.Name = "btnamv_reinstall_mod_pack"
        Me.btnamv_reinstall_mod_pack.Size = New System.Drawing.Size(147, 42)
        Me.btnamv_reinstall_mod_pack.TabIndex = 19
        Me.btnamv_reinstall_mod_pack.Text = "Reinstalar"
        Me.btnamv_reinstall_mod_pack.TextColor = System.Drawing.Color.White
        Me.btnamv_reinstall_mod_pack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnamv_reinstall_mod_pack.UseVisualStyleBackColor = False
        '
        'btnamv_update_mod_pack
        '
        Me.btnamv_update_mod_pack.BackColor = System.Drawing.Color.Transparent
        Me.btnamv_update_mod_pack.BackgroundColor = System.Drawing.Color.Transparent
        Me.btnamv_update_mod_pack.BorderColor = System.Drawing.Color.White
        Me.btnamv_update_mod_pack.BorderRadius = 22
        Me.btnamv_update_mod_pack.BorderSize = 1
        Me.btnamv_update_mod_pack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnamv_update_mod_pack.FlatAppearance.BorderSize = 0
        Me.btnamv_update_mod_pack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnamv_update_mod_pack.Font = New System.Drawing.Font("Caviar Dreams", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnamv_update_mod_pack.ForeColor = System.Drawing.Color.White
        Me.btnamv_update_mod_pack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnamv_update_mod_pack.Location = New System.Drawing.Point(168, 254)
        Me.btnamv_update_mod_pack.Name = "btnamv_update_mod_pack"
        Me.btnamv_update_mod_pack.Size = New System.Drawing.Size(147, 42)
        Me.btnamv_update_mod_pack.TabIndex = 20
        Me.btnamv_update_mod_pack.Text = "Actualizar"
        Me.btnamv_update_mod_pack.TextColor = System.Drawing.Color.White
        Me.btnamv_update_mod_pack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnamv_update_mod_pack.UseVisualStyleBackColor = False
        '
        'frm_mods_beta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(487, 306)
        Me.Controls.Add(Me.btnamv_update_mod_pack)
        Me.Controls.Add(Me.btnamv_reinstall_mod_pack)
        Me.Controls.Add(Me.btnamv_install_mod_pack)
        Me.Controls.Add(Me.Label_info_update_mods)
        Me.Controls.Add(Me.Label_info_new_user)
        Me.Controls.Add(Me.Label_info_reinstall_mod_pack)
        Me.Name = "frm_mods_beta"
        Me.Text = "frm_mods"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_info_update_mods As Label
    Friend WithEvents Label_info_new_user As Label
    Friend WithEvents Label_info_reinstall_mod_pack As Label
    Friend WithEvents bw_installmods As System.ComponentModel.BackgroundWorker
    Friend WithEvents bw_updatemods As System.ComponentModel.BackgroundWorker
    Friend WithEvents bw_reinstallmods As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnamv_install_mod_pack As CustomControls.AmvControls.AmvButton
    Friend WithEvents btnamv_reinstall_mod_pack As CustomControls.AmvControls.AmvButton
    Friend WithEvents btnamv_update_mod_pack As CustomControls.AmvControls.AmvButton
End Class
