<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoggingOut
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
        tmrWait = New Timer(components)
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(93, 236)
        Label2.Name = "Label2"
        Label2.Size = New Size(193, 25)
        Label2.TabIndex = 5
        Label2.Text = "Please wait for a moment..."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(102, 202)
        Label1.Name = "Label1"
        Label1.Size = New Size(163, 25)
        Label1.TabIndex = 4
        Label1.Text = "Logging you out..."
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(121, 83)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 104)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' frmLoggingOut
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(362, 335)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmLoggingOut"
        StartPosition = FormStartPosition.CenterParent
        Text = "Loggingout"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents tmrWait As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
