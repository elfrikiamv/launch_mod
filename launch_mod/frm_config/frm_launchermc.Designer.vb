<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_launchermc
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
        Me.ComboBox_select_launcher = New System.Windows.Forms.ComboBox()
        Me.Label_info_launcher = New System.Windows.Forms.Label()
        Me.bw_savelaunchermc = New System.ComponentModel.BackgroundWorker()
        Me.btnamv_savelaunchermc = New launch_mod.CustomControls.AmvControls.AmvButton()
        Me.SuspendLayout()
        '
        'ComboBox_select_launcher
        '
        Me.ComboBox_select_launcher.DropDownHeight = 80
        Me.ComboBox_select_launcher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_select_launcher.Font = New System.Drawing.Font("Bw Quinta Pro", 11.25!, System.Drawing.FontStyle.Italic)
        Me.ComboBox_select_launcher.FormattingEnabled = True
        Me.ComboBox_select_launcher.IntegralHeight = False
        Me.ComboBox_select_launcher.Items.AddRange(New Object() {"Minecraft_(original).exe", "SKlauncher_3-beta.21.exe"})
        Me.ComboBox_select_launcher.Location = New System.Drawing.Point(155, 141)
        Me.ComboBox_select_launcher.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ComboBox_select_launcher.Name = "ComboBox_select_launcher"
        Me.ComboBox_select_launcher.Size = New System.Drawing.Size(175, 26)
        Me.ComboBox_select_launcher.TabIndex = 13
        '
        'Label_info_launcher
        '
        Me.Label_info_launcher.AutoSize = True
        Me.Label_info_launcher.BackColor = System.Drawing.Color.Transparent
        Me.Label_info_launcher.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_info_launcher.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label_info_launcher.Location = New System.Drawing.Point(32, 97)
        Me.Label_info_launcher.MaximumSize = New System.Drawing.Size(470, 0)
        Me.Label_info_launcher.Name = "Label_info_launcher"
        Me.Label_info_launcher.Size = New System.Drawing.Size(432, 36)
        Me.Label_info_launcher.TabIndex = 14
        Me.Label_info_launcher.Text = "- Selecciona el tipo de launcher entre, premium o no premium."
        '
        'bw_savelaunchermc
        '
        Me.bw_savelaunchermc.WorkerReportsProgress = True
        Me.bw_savelaunchermc.WorkerSupportsCancellation = True
        '
        'btnamv_savelaunchermc
        '
        Me.btnamv_savelaunchermc.BackColor = System.Drawing.Color.Transparent
        Me.btnamv_savelaunchermc.BackgroundColor = System.Drawing.Color.Transparent
        Me.btnamv_savelaunchermc.BorderColor = System.Drawing.Color.White
        Me.btnamv_savelaunchermc.BorderRadius = 22
        Me.btnamv_savelaunchermc.BorderSize = 1
        Me.btnamv_savelaunchermc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnamv_savelaunchermc.FlatAppearance.BorderSize = 0
        Me.btnamv_savelaunchermc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnamv_savelaunchermc.Font = New System.Drawing.Font("Caviar Dreams", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnamv_savelaunchermc.ForeColor = System.Drawing.Color.White
        Me.btnamv_savelaunchermc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnamv_savelaunchermc.Location = New System.Drawing.Point(168, 190)
        Me.btnamv_savelaunchermc.Name = "btnamv_savelaunchermc"
        Me.btnamv_savelaunchermc.Size = New System.Drawing.Size(147, 42)
        Me.btnamv_savelaunchermc.TabIndex = 17
        Me.btnamv_savelaunchermc.Text = "Guardar"
        Me.btnamv_savelaunchermc.TextColor = System.Drawing.Color.White
        Me.btnamv_savelaunchermc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnamv_savelaunchermc.UseVisualStyleBackColor = False
        '
        'frm_launchermc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(487, 306)
        Me.Controls.Add(Me.btnamv_savelaunchermc)
        Me.Controls.Add(Me.ComboBox_select_launcher)
        Me.Controls.Add(Me.Label_info_launcher)
        Me.Name = "frm_launchermc"
        Me.Text = "frm_launchermc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox_select_launcher As ComboBox
    Friend WithEvents Label_info_launcher As Label
    Friend WithEvents bw_savelaunchermc As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnamv_savelaunchermc As CustomControls.AmvControls.AmvButton
End Class
