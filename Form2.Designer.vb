<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), Image)
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), Image)
        PictureBox1.Location = New Point(33, 173)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(96, 86)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.ErrorImage = CType(resources.GetObject("PictureBox2.ErrorImage"), Image)
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), Image)
        PictureBox2.Location = New Point(419, 496)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(77, 79)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = My.Resources.Resources.giphy
        PictureBox3.Location = New Point(220, 291)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(91, 102)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        Timer2.Interval = 1
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Linen
        Label1.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = Color.OliveDrab
        Label1.Location = New Point(388, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 48)
        Label1.TabIndex = 3
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkOliveGreen
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(508, 627)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label1 As Label
End Class
