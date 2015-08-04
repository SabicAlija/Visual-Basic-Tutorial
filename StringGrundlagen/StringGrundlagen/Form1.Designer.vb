<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblHeaderTextBox = New System.Windows.Forms.Label()
        Me.txtEingabe = New System.Windows.Forms.TextBox()
        Me.cmdLänge = New System.Windows.Forms.Button()
        Me.lblAusgabe = New System.Windows.Forms.Label()
        Me.cmdZeichen = New System.Windows.Forms.Button()
        Me.cmdTrimmen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeaderTextBox
        '
        Me.lblHeaderTextBox.AutoSize = True
        Me.lblHeaderTextBox.Location = New System.Drawing.Point(10, 14)
        Me.lblHeaderTextBox.Name = "lblHeaderTextBox"
        Me.lblHeaderTextBox.Size = New System.Drawing.Size(49, 13)
        Me.lblHeaderTextBox.TabIndex = 0
        Me.lblHeaderTextBox.Text = "Eingabe:"
        '
        'txtEingabe
        '
        Me.txtEingabe.Location = New System.Drawing.Point(13, 30)
        Me.txtEingabe.Name = "txtEingabe"
        Me.txtEingabe.Size = New System.Drawing.Size(100, 20)
        Me.txtEingabe.TabIndex = 1
        '
        'cmdLänge
        '
        Me.cmdLänge.Location = New System.Drawing.Point(180, 27)
        Me.cmdLänge.Name = "cmdLänge"
        Me.cmdLänge.Size = New System.Drawing.Size(92, 23)
        Me.cmdLänge.TabIndex = 2
        Me.cmdLänge.Text = "Länge"
        Me.cmdLänge.UseVisualStyleBackColor = True
        '
        'lblAusgabe
        '
        Me.lblAusgabe.AutoSize = True
        Me.lblAusgabe.Location = New System.Drawing.Point(10, 92)
        Me.lblAusgabe.Name = "lblAusgabe"
        Me.lblAusgabe.Size = New System.Drawing.Size(0, 13)
        Me.lblAusgabe.TabIndex = 3
        '
        'cmdZeichen
        '
        Me.cmdZeichen.Location = New System.Drawing.Point(180, 57)
        Me.cmdZeichen.Name = "cmdZeichen"
        Me.cmdZeichen.Size = New System.Drawing.Size(92, 23)
        Me.cmdZeichen.TabIndex = 4
        Me.cmdZeichen.Text = "Zeichen"
        Me.cmdZeichen.UseVisualStyleBackColor = True
        '
        'cmdTrimmen
        '
        Me.cmdTrimmen.Location = New System.Drawing.Point(180, 87)
        Me.cmdTrimmen.Name = "cmdTrimmen"
        Me.cmdTrimmen.Size = New System.Drawing.Size(92, 23)
        Me.cmdTrimmen.TabIndex = 5
        Me.cmdTrimmen.Text = "Trimmen"
        Me.cmdTrimmen.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 144)
        Me.Controls.Add(Me.cmdTrimmen)
        Me.Controls.Add(Me.cmdZeichen)
        Me.Controls.Add(Me.lblAusgabe)
        Me.Controls.Add(Me.cmdLänge)
        Me.Controls.Add(Me.txtEingabe)
        Me.Controls.Add(Me.lblHeaderTextBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeaderTextBox As Label
    Friend WithEvents txtEingabe As TextBox
    Friend WithEvents cmdLänge As Button
    Friend WithEvents lblAusgabe As Label
    Friend WithEvents cmdZeichen As Button
    Friend WithEvents cmdTrimmen As Button
End Class
