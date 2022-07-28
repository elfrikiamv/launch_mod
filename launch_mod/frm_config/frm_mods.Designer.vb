<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_mods
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
        Me.btn_install_mod_pack = New System.Windows.Forms.Button()
        Me.btn_update_mod_pack = New System.Windows.Forms.Button()
        Me.Label_info_new_user = New System.Windows.Forms.Label()
        Me.btn_reinstall_mod_pack = New System.Windows.Forms.Button()
        Me.Label_info_reinstall_mod_pack = New System.Windows.Forms.Label()
        Me.bw_installmods = New System.ComponentModel.BackgroundWorker()
        Me.bw_updatemods = New System.ComponentModel.BackgroundWorker()
        Me.bw_reinstallmods = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'Label_info_update_mods
        '
        Me.Label_info_update_mods.AutoSize = True
        Me.Label_info_update_mods.BackColor = System.Drawing.Color.Transparent
        Me.Label_info_update_mods.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_info_update_mods.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label_info_update_mods.Location = New System.Drawing.Point(12, 306)
        Me.Label_info_update_mods.MaximumSize = New System.Drawing.Size(470, 0)
        Me.Label_info_update_mods.Name = "Label_info_update_mods"
        Me.Label_info_update_mods.Size = New System.Drawing.Size(464, 18)
        Me.Label_info_update_mods.TabIndex = 17
        Me.Label_info_update_mods.Text = "- Actualizar pack de mods, esto NO borrará tú .minecraft."
        '
        'btn_install_mod_pack
        '
        Me.btn_install_mod_pack.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Italic)
        Me.btn_install_mod_pack.ForeColor = System.Drawing.Color.Black
        Me.btn_install_mod_pack.Location = New System.Drawing.Point(180, 151)
        Me.btn_install_mod_pack.Name = "btn_install_mod_pack"
        Me.btn_install_mod_pack.Size = New System.Drawing.Size(114, 28)
        Me.btn_install_mod_pack.TabIndex = 12
        Me.btn_install_mod_pack.Text = "install mods"
        Me.btn_install_mod_pack.UseVisualStyleBackColor = True
        '
        'btn_update_mod_pack
        '
        Me.btn_update_mod_pack.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update_mod_pack.ForeColor = System.Drawing.Color.Black
        Me.btn_update_mod_pack.Location = New System.Drawing.Point(180, 339)
        Me.btn_update_mod_pack.Name = "btn_update_mod_pack"
        Me.btn_update_mod_pack.Size = New System.Drawing.Size(114, 30)
        Me.btn_update_mod_pack.TabIndex = 16
        Me.btn_update_mod_pack.Text = "Actualizar"
        Me.btn_update_mod_pack.UseVisualStyleBackColor = True
        '
        'Label_info_new_user
        '
        Me.Label_info_new_user.AutoSize = True
        Me.Label_info_new_user.BackColor = System.Drawing.Color.Transparent
        Me.Label_info_new_user.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_info_new_user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label_info_new_user.Location = New System.Drawing.Point(12, 98)
        Me.Label_info_new_user.MaximumSize = New System.Drawing.Size(470, 0)
        Me.Label_info_new_user.Name = "Label_info_new_user"
        Me.Label_info_new_user.Size = New System.Drawing.Size(464, 36)
        Me.Label_info_new_user.TabIndex = 13
        Me.Label_info_new_user.Text = "- Para instalar por primera vez el pack de mods en tu PC, (Solo para usuarios NUE" &
    "VOS)."
        '
        'btn_reinstall_mod_pack
        '
        Me.btn_reinstall_mod_pack.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Italic)
        Me.btn_reinstall_mod_pack.ForeColor = System.Drawing.Color.Black
        Me.btn_reinstall_mod_pack.Location = New System.Drawing.Point(180, 261)
        Me.btn_reinstall_mod_pack.Name = "btn_reinstall_mod_pack"
        Me.btn_reinstall_mod_pack.Size = New System.Drawing.Size(114, 28)
        Me.btn_reinstall_mod_pack.TabIndex = 14
        Me.btn_reinstall_mod_pack.Text = "Reinstalar"
        Me.btn_reinstall_mod_pack.UseVisualStyleBackColor = True
        '
        'Label_info_reinstall_mod_pack
        '
        Me.Label_info_reinstall_mod_pack.AutoSize = True
        Me.Label_info_reinstall_mod_pack.BackColor = System.Drawing.Color.Transparent
        Me.Label_info_reinstall_mod_pack.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_info_reinstall_mod_pack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label_info_reinstall_mod_pack.Location = New System.Drawing.Point(12, 194)
        Me.Label_info_reinstall_mod_pack.MaximumSize = New System.Drawing.Size(470, 0)
        Me.Label_info_reinstall_mod_pack.Name = "Label_info_reinstall_mod_pack"
        Me.Label_info_reinstall_mod_pack.Size = New System.Drawing.Size(464, 54)
        Me.Label_info_reinstall_mod_pack.TabIndex = 15
        Me.Label_info_reinstall_mod_pack.Text = "- Si tienes problemas con el juego, prueba reinstalar el pack de mods, (Esto BORR" &
    "ARÁ tú .minecraft y te pondrá una instalación limpia)."
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
        'frm_mods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(487, 450)
        Me.Controls.Add(Me.Label_info_update_mods)
        Me.Controls.Add(Me.btn_install_mod_pack)
        Me.Controls.Add(Me.btn_update_mod_pack)
        Me.Controls.Add(Me.Label_info_new_user)
        Me.Controls.Add(Me.btn_reinstall_mod_pack)
        Me.Controls.Add(Me.Label_info_reinstall_mod_pack)
        Me.Name = "frm_mods"
        Me.Text = "frm_mods"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_info_update_mods As Label
    Friend WithEvents btn_install_mod_pack As Button
    Friend WithEvents btn_update_mod_pack As Button
    Friend WithEvents Label_info_new_user As Label
    Friend WithEvents btn_reinstall_mod_pack As Button
    Friend WithEvents Label_info_reinstall_mod_pack As Label
    Friend WithEvents bw_installmods As System.ComponentModel.BackgroundWorker
    Friend WithEvents bw_updatemods As System.ComponentModel.BackgroundWorker
    Friend WithEvents bw_reinstallmods As System.ComponentModel.BackgroundWorker
End Class
