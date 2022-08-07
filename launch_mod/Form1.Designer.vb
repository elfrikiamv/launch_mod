<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.bw_checkupdate = New System.ComponentModel.BackgroundWorker()
        Me.bw_openlaunchermc = New System.ComponentModel.BackgroundWorker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gb_new_updates = New System.Windows.Forms.GroupBox()
        Me.btnamv_config = New launch_mod.CustomControls.AmvControls.AmvButton()
        Me.btnamv_info = New launch_mod.CustomControls.AmvControls.AmvButton()
        Me.btnamv_play = New launch_mod.CustomControls.AmvControls.AmvButton()
        Me.btnamv_runmc = New launch_mod.CustomControls.AmvControls.AmvButton()
        Me.SuspendLayout()
        '
        'bw_checkupdate
        '
        Me.bw_checkupdate.WorkerReportsProgress = True
        Me.bw_checkupdate.WorkerSupportsCancellation = True
        '
        'bw_openlaunchermc
        '
        Me.bw_openlaunchermc.WorkerReportsProgress = True
        Me.bw_openlaunchermc.WorkerSupportsCancellation = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Brownhill Script", 66.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(98, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(297, 92)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "launch_mod"
        '
        'gb_new_updates
        '
        Me.gb_new_updates.BackColor = System.Drawing.Color.Transparent
        Me.gb_new_updates.Font = New System.Drawing.Font("Caviar Dreams", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_new_updates.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gb_new_updates.Location = New System.Drawing.Point(432, 64)
        Me.gb_new_updates.Name = "gb_new_updates"
        Me.gb_new_updates.Size = New System.Drawing.Size(458, 270)
        Me.gb_new_updates.TabIndex = 17
        Me.gb_new_updates.TabStop = False
        Me.gb_new_updates.Text = "Noticias y actualizaciones!"
        '
        'btnamv_config
        '
        Me.btnamv_config.BackColor = System.Drawing.Color.Transparent
        Me.btnamv_config.BackgroundColor = System.Drawing.Color.Transparent
        Me.btnamv_config.BorderColor = System.Drawing.Color.White
        Me.btnamv_config.BorderRadius = 22
        Me.btnamv_config.BorderSize = 1
        Me.btnamv_config.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnamv_config.FlatAppearance.BorderSize = 0
        Me.btnamv_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnamv_config.Font = New System.Drawing.Font("Caviar Dreams", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnamv_config.ForeColor = System.Drawing.Color.White
        Me.btnamv_config.Location = New System.Drawing.Point(607, 388)
        Me.btnamv_config.Name = "btnamv_config"
        Me.btnamv_config.Size = New System.Drawing.Size(171, 45)
        Me.btnamv_config.TabIndex = 6
        Me.btnamv_config.Text = "Configuración"
        Me.btnamv_config.TextColor = System.Drawing.Color.White
        Me.btnamv_config.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnamv_config.UseVisualStyleBackColor = False
        '
        'btnamv_info
        '
        Me.btnamv_info.BackColor = System.Drawing.Color.Transparent
        Me.btnamv_info.BackgroundColor = System.Drawing.Color.Transparent
        Me.btnamv_info.BorderColor = System.Drawing.Color.White
        Me.btnamv_info.BorderRadius = 22
        Me.btnamv_info.BorderSize = 1
        Me.btnamv_info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnamv_info.FlatAppearance.BorderSize = 0
        Me.btnamv_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnamv_info.Font = New System.Drawing.Font("Caviar Dreams", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnamv_info.ForeColor = System.Drawing.Color.White
        Me.btnamv_info.Location = New System.Drawing.Point(213, 388)
        Me.btnamv_info.Name = "btnamv_info"
        Me.btnamv_info.Size = New System.Drawing.Size(171, 45)
        Me.btnamv_info.TabIndex = 5
        Me.btnamv_info.Text = "Información"
        Me.btnamv_info.TextColor = System.Drawing.Color.White
        Me.btnamv_info.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnamv_info.UseVisualStyleBackColor = False
        '
        'btnamv_play
        '
        Me.btnamv_play.BackColor = System.Drawing.Color.Transparent
        Me.btnamv_play.BackgroundColor = System.Drawing.Color.Transparent
        Me.btnamv_play.BorderColor = System.Drawing.Color.White
        Me.btnamv_play.BorderRadius = 22
        Me.btnamv_play.BorderSize = 1
        Me.btnamv_play.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnamv_play.FlatAppearance.BorderSize = 0
        Me.btnamv_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnamv_play.Font = New System.Drawing.Font("Caviar Dreams", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnamv_play.ForeColor = System.Drawing.Color.White
        Me.btnamv_play.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnamv_play.Location = New System.Drawing.Point(409, 388)
        Me.btnamv_play.Name = "btnamv_play"
        Me.btnamv_play.Size = New System.Drawing.Size(171, 45)
        Me.btnamv_play.TabIndex = 4
        Me.btnamv_play.Text = "Play"
        Me.btnamv_play.TextColor = System.Drawing.Color.White
        Me.btnamv_play.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnamv_play.UseVisualStyleBackColor = False
        '
        'btnamv_runmc
        '
        Me.btnamv_runmc.BackColor = System.Drawing.Color.Transparent
        Me.btnamv_runmc.BackgroundColor = System.Drawing.Color.Transparent
        Me.btnamv_runmc.BorderColor = System.Drawing.Color.White
        Me.btnamv_runmc.BorderRadius = 22
        Me.btnamv_runmc.BorderSize = 1
        Me.btnamv_runmc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnamv_runmc.FlatAppearance.BorderSize = 0
        Me.btnamv_runmc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnamv_runmc.Font = New System.Drawing.Font("Caviar Dreams", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnamv_runmc.ForeColor = System.Drawing.Color.White
        Me.btnamv_runmc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnamv_runmc.Location = New System.Drawing.Point(154, 109)
        Me.btnamv_runmc.Name = "btnamv_runmc"
        Me.btnamv_runmc.Size = New System.Drawing.Size(171, 45)
        Me.btnamv_runmc.TabIndex = 18
        Me.btnamv_runmc.Text = "Play"
        Me.btnamv_runmc.TextColor = System.Drawing.Color.White
        Me.btnamv_runmc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnamv_runmc.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.btnamv_runmc)
        Me.Controls.Add(Me.gb_new_updates)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnamv_config)
        Me.Controls.Add(Me.btnamv_info)
        Me.Controls.Add(Me.btnamv_play)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "launch_mod beta v4.0.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bw_checkupdate As System.ComponentModel.BackgroundWorker
    Friend WithEvents bw_openlaunchermc As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnamv_play As CustomControls.AmvControls.AmvButton
    Friend WithEvents btnamv_info As CustomControls.AmvControls.AmvButton
    Friend WithEvents btnamv_config As CustomControls.AmvControls.AmvButton
    Friend WithEvents Label2 As Label
    Friend WithEvents gb_new_updates As GroupBox
    Friend WithEvents btnamv_runmc As CustomControls.AmvControls.AmvButton
End Class
