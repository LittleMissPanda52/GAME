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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.ForestGreen
        Button1.Font = New Font("Mongolian Baiti", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button1.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button1.Location = New Point(179, 172)
        Button1.Name = "Button1"
        Button1.Size = New Size(139, 63)
        Button1.TabIndex = 0
        Button1.Text = "Start"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.ForestGreen
        Button2.Font = New Font("Mongolian Baiti", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button2.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button2.Location = New Point(179, 272)
        Button2.Name = "Button2"
        Button2.Size = New Size(139, 61)
        Button2.TabIndex = 1
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkMagenta
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(494, 542)
        Controls.Add(Button2)
        Controls.Add(Button1)
        DoubleBuffered = True
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
