<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_info
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_info))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bw_updatelauncher = New System.ComponentModel.BackgroundWorker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lnklb_github = New System.Windows.Forms.LinkLabel()
        Me.btnamv_update = New launch_mod.CustomControls.AmvControls.AmvButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(152, 221)
        Me.Label1.MaximumSize = New System.Drawing.Size(470, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 18)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "- Buscar actualizaciones de launch_mod."
        '
        'bw_updatelauncher
        '
        Me.bw_updatelauncher.WorkerReportsProgress = True
        Me.bw_updatelauncher.WorkerSupportsCancellation = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Brownhill Script", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(207, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 67)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "launch_mod"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Caviar Dreams", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(224, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 22)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Versión: beta 4.0.0"
        '
        'lnklb_github
        '
        Me.lnklb_github.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lnklb_github.AutoSize = True
        Me.lnklb_github.Font = New System.Drawing.Font("Caviar Dreams", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnklb_github.LinkColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lnklb_github.Location = New System.Drawing.Point(280, 171)
        Me.lnklb_github.Name = "lnklb_github"
        Me.lnklb_github.Size = New System.Drawing.Size(68, 22)
        Me.lnklb_github.TabIndex = 17
        Me.lnklb_github.TabStop = True
        Me.lnklb_github.Text = "Github"
        '
        'btnamv_update
        '
        Me.btnamv_update.BackColor = System.Drawing.Color.Transparent
        Me.btnamv_update.BackgroundColor = System.Drawing.Color.Transparent
        Me.btnamv_update.BorderColor = System.Drawing.Color.White
        Me.btnamv_update.BorderRadius = 22
        Me.btnamv_update.BorderSize = 1
        Me.btnamv_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnamv_update.FlatAppearance.BorderSize = 0
        Me.btnamv_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnamv_update.Font = New System.Drawing.Font("Caviar Dreams", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnamv_update.ForeColor = System.Drawing.Color.White
        Me.btnamv_update.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnamv_update.Location = New System.Drawing.Point(215, 247)
        Me.btnamv_update.Name = "btnamv_update"
        Me.btnamv_update.Size = New System.Drawing.Size(190, 42)
        Me.btnamv_update.TabIndex = 18
        Me.btnamv_update.Text = "Actualizar Launcher."
        Me.btnamv_update.TextColor = System.Drawing.Color.White
        Me.btnamv_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnamv_update.UseVisualStyleBackColor = False
        '
        'frm_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(626, 300)
        Me.Controls.Add(Me.btnamv_update)
        Me.Controls.Add(Me.lnklb_github)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_info"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Información"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents bw_updatelauncher As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lnklb_github As LinkLabel
    Friend WithEvents btnamv_update As CustomControls.AmvControls.AmvButton
End Class
