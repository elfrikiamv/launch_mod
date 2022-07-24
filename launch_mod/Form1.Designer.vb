<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_play = New System.Windows.Forms.Button()
        Me.btn_config = New System.Windows.Forms.Button()
        Me.btn_info = New System.Windows.Forms.Button()
        Me.bw_checkupdate = New System.ComponentModel.BackgroundWorker()
        Me.bw_openlaunchermc = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'btn_play
        '
        Me.btn_play.Location = New System.Drawing.Point(445, 386)
        Me.btn_play.Name = "btn_play"
        Me.btn_play.Size = New System.Drawing.Size(87, 23)
        Me.btn_play.TabIndex = 1
        Me.btn_play.Text = "¡Jugar!"
        Me.btn_play.UseVisualStyleBackColor = True
        '
        'btn_config
        '
        Me.btn_config.Location = New System.Drawing.Point(664, 386)
        Me.btn_config.Name = "btn_config"
        Me.btn_config.Size = New System.Drawing.Size(97, 23)
        Me.btn_config.TabIndex = 2
        Me.btn_config.Text = "Configuración"
        Me.btn_config.UseVisualStyleBackColor = True
        '
        'btn_info
        '
        Me.btn_info.Location = New System.Drawing.Point(221, 386)
        Me.btn_info.Name = "btn_info"
        Me.btn_info.Size = New System.Drawing.Size(83, 23)
        Me.btn_info.TabIndex = 3
        Me.btn_info.Text = "Información"
        Me.btn_info.UseVisualStyleBackColor = True
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.launch_mod.My.Resources.Resources.bg_launcher
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(973, 470)
        Me.Controls.Add(Me.btn_info)
        Me.Controls.Add(Me.btn_config)
        Me.Controls.Add(Me.btn_play)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "launch_mod"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_play As Button
    Friend WithEvents btn_config As Button
    Friend WithEvents btn_info As Button
    Friend WithEvents bw_checkupdate As System.ComponentModel.BackgroundWorker
    Friend WithEvents bw_openlaunchermc As System.ComponentModel.BackgroundWorker
End Class
