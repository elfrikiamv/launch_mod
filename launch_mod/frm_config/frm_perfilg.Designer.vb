<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_perfilg
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
        Me.Label_info_graficos = New System.Windows.Forms.Label()
        Me.ComboBox_perfil_graphic = New System.Windows.Forms.ComboBox()
        Me.bw_installpg = New System.ComponentModel.BackgroundWorker()
        Me.btnamv_savepg = New launch_mod.CustomControls.AmvControls.AmvButton()
        Me.SuspendLayout()
        '
        'Label_info_graficos
        '
        Me.Label_info_graficos.AutoSize = True
        Me.Label_info_graficos.BackColor = System.Drawing.Color.Transparent
        Me.Label_info_graficos.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_info_graficos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label_info_graficos.Location = New System.Drawing.Point(14, 97)
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
        Me.ComboBox_perfil_graphic.Font = New System.Drawing.Font("Bw Quinta Pro", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_perfil_graphic.FormattingEnabled = True
        Me.ComboBox_perfil_graphic.IntegralHeight = False
        Me.ComboBox_perfil_graphic.Items.AddRange(New Object() {"alto", "normal", "bajo"})
        Me.ComboBox_perfil_graphic.Location = New System.Drawing.Point(155, 141)
        Me.ComboBox_perfil_graphic.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ComboBox_perfil_graphic.Name = "ComboBox_perfil_graphic"
        Me.ComboBox_perfil_graphic.Size = New System.Drawing.Size(175, 26)
        Me.ComboBox_perfil_graphic.TabIndex = 11
        '
        'bw_installpg
        '
        Me.bw_installpg.WorkerReportsProgress = True
        Me.bw_installpg.WorkerSupportsCancellation = True
        '
        'btnamv_savepg
        '
        Me.btnamv_savepg.BackColor = System.Drawing.Color.Transparent
        Me.btnamv_savepg.BackgroundColor = System.Drawing.Color.Transparent
        Me.btnamv_savepg.BorderColor = System.Drawing.Color.White
        Me.btnamv_savepg.BorderRadius = 22
        Me.btnamv_savepg.BorderSize = 1
        Me.btnamv_savepg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnamv_savepg.FlatAppearance.BorderSize = 0
        Me.btnamv_savepg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnamv_savepg.Font = New System.Drawing.Font("Caviar Dreams", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnamv_savepg.ForeColor = System.Drawing.Color.White
        Me.btnamv_savepg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnamv_savepg.Location = New System.Drawing.Point(168, 190)
        Me.btnamv_savepg.Name = "btnamv_savepg"
        Me.btnamv_savepg.Size = New System.Drawing.Size(147, 42)
        Me.btnamv_savepg.TabIndex = 16
        Me.btnamv_savepg.Text = "Guardar"
        Me.btnamv_savepg.TextColor = System.Drawing.Color.White
        Me.btnamv_savepg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnamv_savepg.UseVisualStyleBackColor = False
        '
        'frm_perfilg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(487, 306)
        Me.Controls.Add(Me.btnamv_savepg)
        Me.Controls.Add(Me.Label_info_graficos)
        Me.Controls.Add(Me.ComboBox_perfil_graphic)
        Me.Name = "frm_perfilg"
        Me.Text = "frm_perfilg"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_info_graficos As Label
    Friend WithEvents ComboBox_perfil_graphic As ComboBox
    Friend WithEvents bw_installpg As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnamv_savepg As CustomControls.AmvControls.AmvButton
End Class
