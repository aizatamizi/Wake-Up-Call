﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.lstOut = New System.Windows.Forms.ListBox()
        Me.cboTimes = New System.Windows.Forms.ComboBox()
        Me.cmdWake = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(29, 75)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(224, 60)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "How many time do I have to tell you to wake up"
        '
        'lstOut
        '
        Me.lstOut.FormattingEnabled = True
        Me.lstOut.ItemHeight = 20
        Me.lstOut.Location = New System.Drawing.Point(29, 144)
        Me.lstOut.Name = "lstOut"
        Me.lstOut.Size = New System.Drawing.Size(150, 104)
        Me.lstOut.TabIndex = 1
        '
        'cboTimes
        '
        Me.cboTimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTimes.FormattingEnabled = True
        Me.cboTimes.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.cboTimes.Location = New System.Drawing.Point(314, 75)
        Me.cboTimes.Name = "cboTimes"
        Me.cboTimes.Size = New System.Drawing.Size(69, 28)
        Me.cboTimes.TabIndex = 2
        '
        'cmdWake
        '
        Me.cmdWake.Location = New System.Drawing.Point(256, 154)
        Me.cmdWake.Name = "cmdWake"
        Me.cmdWake.Size = New System.Drawing.Size(127, 29)
        Me.cmdWake.TabIndex = 3
        Me.cmdWake.Text = "Wake Me Up"
        Me.cmdWake.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 450)
        Me.Controls.Add(Me.cmdWake)
        Me.Controls.Add(Me.cboTimes)
        Me.Controls.Add(Me.lstOut)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents lstOut As ListBox
    Friend WithEvents cboTimes As ComboBox
    Friend WithEvents cmdWake As Button
End Class
