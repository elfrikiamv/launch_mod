﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btn_savelaunchermc = New System.Windows.Forms.Button()
        Me.bw_savelaunchermc = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'ComboBox_select_launcher
        '
        Me.ComboBox_select_launcher.DropDownHeight = 80
        Me.ComboBox_select_launcher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_select_launcher.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_select_launcher.FormattingEnabled = True
        Me.ComboBox_select_launcher.IntegralHeight = False
        Me.ComboBox_select_launcher.Items.AddRange(New Object() {"Premium", "No_Premium"})
        Me.ComboBox_select_launcher.Location = New System.Drawing.Point(144, 239)
        Me.ComboBox_select_launcher.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ComboBox_select_launcher.Name = "ComboBox_select_launcher"
        Me.ComboBox_select_launcher.Size = New System.Drawing.Size(194, 26)
        Me.ComboBox_select_launcher.TabIndex = 13
        '
        'Label_info_launcher
        '
        Me.Label_info_launcher.AutoSize = True
        Me.Label_info_launcher.BackColor = System.Drawing.Color.Transparent
        Me.Label_info_launcher.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_info_launcher.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label_info_launcher.Location = New System.Drawing.Point(12, 198)
        Me.Label_info_launcher.MaximumSize = New System.Drawing.Size(470, 0)
        Me.Label_info_launcher.Name = "Label_info_launcher"
        Me.Label_info_launcher.Size = New System.Drawing.Size(432, 36)
        Me.Label_info_launcher.TabIndex = 14
        Me.Label_info_launcher.Text = "- Selecciona el tipo de launcher entre, premium o no premium."
        '
        'btn_savelaunchermc
        '
        Me.btn_savelaunchermc.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_savelaunchermc.ForeColor = System.Drawing.Color.Black
        Me.btn_savelaunchermc.Location = New System.Drawing.Point(168, 282)
        Me.btn_savelaunchermc.Name = "btn_savelaunchermc"
        Me.btn_savelaunchermc.Size = New System.Drawing.Size(114, 28)
        Me.btn_savelaunchermc.TabIndex = 16
        Me.btn_savelaunchermc.Text = "Guardar"
        Me.btn_savelaunchermc.UseVisualStyleBackColor = True
        '
        'bw_savelaunchermc
        '
        Me.bw_savelaunchermc.WorkerReportsProgress = True
        Me.bw_savelaunchermc.WorkerSupportsCancellation = True
        '
        'frm_launchermc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(451, 450)
        Me.Controls.Add(Me.btn_savelaunchermc)
        Me.Controls.Add(Me.ComboBox_select_launcher)
        Me.Controls.Add(Me.Label_info_launcher)
        Me.Name = "frm_launchermc"
        Me.Text = "frm_launchermc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox_select_launcher As ComboBox
    Friend WithEvents Label_info_launcher As Label
    Friend WithEvents btn_savelaunchermc As Button
    Friend WithEvents bw_savelaunchermc As System.ComponentModel.BackgroundWorker
End Class