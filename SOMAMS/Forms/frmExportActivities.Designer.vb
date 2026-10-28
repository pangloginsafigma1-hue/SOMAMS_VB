<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmExportActivities
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
        btnExport = New Button()
        pbBack = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        dtpFrom = New DateTimePicker()
        dtpTo = New DateTimePicker()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = Color.ForestGreen
        btnExport.BackgroundImageLayout = ImageLayout.None
        btnExport.Location = New Point(121, 330)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(232, 43)
        btnExport.TabIndex = 0
        btnExport.Text = "Export"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' pbBack
        ' 
        pbBack.BackColor = Color.Navy
        pbBack.BackgroundImageLayout = ImageLayout.None
        pbBack.FlatAppearance.BorderSize = 0
        pbBack.FlatStyle = FlatStyle.Flat
        pbBack.ForeColor = Color.Black
        pbBack.Image = My.Resources.Resources.back
        pbBack.Location = New Point(36, 12)
        pbBack.Name = "pbBack"
        pbBack.Size = New Size(36, 43)
        pbBack.TabIndex = 1
        pbBack.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(36, 76)
        Label1.Name = "Label1"
        Label1.Size = New Size(226, 25)
        Label1.TabIndex = 2
        Label1.Text = "Export List of Activities"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(36, 158)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 23)
        Label2.TabIndex = 3
        Label2.Text = "From: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(36, 244)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 23)
        Label3.TabIndex = 4
        Label3.Text = "To: "
        ' 
        ' dtpFrom
        ' 
        dtpFrom.Font = New Font("Segoe UI", 11F)
        dtpFrom.Location = New Point(36, 184)
        dtpFrom.Name = "dtpFrom"
        dtpFrom.Size = New Size(411, 32)
        dtpFrom.TabIndex = 5
        ' 
        ' dtpTo
        ' 
        dtpTo.Font = New Font("Segoe UI", 11F)
        dtpTo.Location = New Point(36, 270)
        dtpTo.Name = "dtpTo"
        dtpTo.Size = New Size(411, 32)
        dtpTo.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(36, 114)
        Label4.Name = "Label4"
        Label4.Size = New Size(411, 20)
        Label4.TabIndex = 7
        Label4.Text = "Pick the start and end date of the activity you want to export."
        ' 
        ' frmExportActivities
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Navy
        ClientSize = New Size(483, 414)
        Controls.Add(Label4)
        Controls.Add(dtpTo)
        Controls.Add(dtpFrom)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(pbBack)
        Controls.Add(btnExport)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Name = "frmExportActivities"
        StartPosition = FormStartPosition.CenterParent
        Text = "expFormAct"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnExport As Button
    Friend WithEvents pbBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents Label4 As Label
End Class
