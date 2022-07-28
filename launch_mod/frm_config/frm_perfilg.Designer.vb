<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_perfilg
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
        Me.Label_info_graficos = New System.Windows.Forms.Label()
        Me.ComboBox_perfil_graphic = New System.Windows.Forms.ComboBox()
        Me.btn_change_perfil_graphic = New System.Windows.Forms.Button()
        Me.Label_info_change_perfil_graphic = New System.Windows.Forms.Label()
        Me.bw_changeperfilgraphic = New System.ComponentModel.BackgroundWorker()
        Me.btn_savepg = New System.Windows.Forms.Button()
        Me.bw_installpg = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'Label_info_graficos
        '
        Me.Label_info_graficos.AutoSize = True
        Me.Label_info_graficos.BackColor = System.Drawing.Color.Transparent
        Me.Label_info_graficos.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_info_graficos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label_info_graficos.Location = New System.Drawing.Point(12, 138)
        Me.Label_info_graficos.MaximumSize = New System.Drawing.Size(470, 0)
        Me.Label_info_graficos.Name = "Label_info_graficos"
        Me.Label_info_graficos.Size = New System.Drawing.Size(464, 36)
        Me.Label_info_graficos.TabIndex = 14
        Me.Label_info_graficos.Text = "- Selecciona un perfil de configuración gráfica según tu PC:"
        '
        'ComboBox_perfil_graphic
        '
        Me.ComboBox_perfil_graphic.DropDownHeight = 80
        Me.ComboBox_perfil_graphic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_perfil_graphic.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_perfil_graphic.FormattingEnabled = True
        Me.ComboBox_perfil_graphic.IntegralHeight = False
        Me.ComboBox_perfil_graphic.Items.AddRange(New Object() {"alto", "normal", "bajo"})
        Me.ComboBox_perfil_graphic.Location = New System.Drawing.Point(144, 175)
        Me.ComboBox_perfil_graphic.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ComboBox_perfil_graphic.Name = "ComboBox_perfil_graphic"
        Me.ComboBox_perfil_graphic.Size = New System.Drawing.Size(182, 26)
        Me.ComboBox_perfil_graphic.TabIndex = 11
        '
        'btn_change_perfil_graphic
        '
        Me.btn_change_perfil_graphic.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_change_perfil_graphic.ForeColor = System.Drawing.Color.Black
        Me.btn_change_perfil_graphic.Location = New System.Drawing.Point(180, 313)
        Me.btn_change_perfil_graphic.Name = "btn_change_perfil_graphic"
        Me.btn_change_perfil_graphic.Size = New System.Drawing.Size(114, 28)
        Me.btn_change_perfil_graphic.TabIndex = 13
        Me.btn_change_perfil_graphic.Text = "Cambiar"
        Me.btn_change_perfil_graphic.UseVisualStyleBackColor = True
        '
        'Label_info_change_perfil_graphic
        '
        Me.Label_info_change_perfil_graphic.AutoSize = True
        Me.Label_info_change_perfil_graphic.BackColor = System.Drawing.Color.Transparent
        Me.Label_info_change_perfil_graphic.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_info_change_perfil_graphic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label_info_change_perfil_graphic.Location = New System.Drawing.Point(12, 263)
        Me.Label_info_change_perfil_graphic.MaximumSize = New System.Drawing.Size(470, 0)
        Me.Label_info_change_perfil_graphic.Name = "Label_info_change_perfil_graphic"
        Me.Label_info_change_perfil_graphic.Size = New System.Drawing.Size(464, 36)
        Me.Label_info_change_perfil_graphic.TabIndex = 12
        Me.Label_info_change_perfil_graphic.Text = "- Si ya tienes el pack de mods instalado, puedes cambiar el perfil de configuraci" &
    "ón gráfica."
        '
        'bw_changeperfilgraphic
        '
        Me.bw_changeperfilgraphic.WorkerReportsProgress = True
        Me.bw_changeperfilgraphic.WorkerSupportsCancellation = True
        '
        'btn_savepg
        '
        Me.btn_savepg.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_savepg.ForeColor = System.Drawing.Color.Black
        Me.btn_savepg.Location = New System.Drawing.Point(185, 222)
        Me.btn_savepg.Name = "btn_savepg"
        Me.btn_savepg.Size = New System.Drawing.Size(114, 28)
        Me.btn_savepg.TabIndex = 15
        Me.btn_savepg.Text = "Guardar"
        Me.btn_savepg.UseVisualStyleBackColor = True
        '
        'bw_installpg
        '
        Me.bw_installpg.WorkerReportsProgress = True
        Me.bw_installpg.WorkerSupportsCancellation = True
        '
        'frm_perfilg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(484, 450)
        Me.Controls.Add(Me.btn_savepg)
        Me.Controls.Add(Me.Label_info_graficos)
        Me.Controls.Add(Me.ComboBox_perfil_graphic)
        Me.Controls.Add(Me.btn_change_perfil_graphic)
        Me.Controls.Add(Me.Label_info_change_perfil_graphic)
        Me.Name = "frm_perfilg"
        Me.Text = "frm_perfilg"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_info_graficos As Label
    Friend WithEvents ComboBox_perfil_graphic As ComboBox
    Friend WithEvents btn_change_perfil_graphic As Button
    Friend WithEvents Label_info_change_perfil_graphic As Label
    Friend WithEvents bw_changeperfilgraphic As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_savepg As Button
    Friend WithEvents bw_installpg As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
