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
        txtSentence = New TextBox()
        lstResults = New ListBox()
        btnParse = New Button()
        Label1 = New Label()
        Label2 = New Label()
        btnParse2 = New Button()
        SuspendLayout()
        ' 
        ' txtSentence
        ' 
        txtSentence.Location = New Point(216, 65)
        txtSentence.Multiline = True
        txtSentence.Name = "txtSentence"
        txtSentence.Size = New Size(432, 75)
        txtSentence.TabIndex = 0
        ' 
        ' lstResults
        ' 
        lstResults.FormattingEnabled = True
        lstResults.Location = New Point(216, 192)
        lstResults.Name = "lstResults"
        lstResults.Size = New Size(432, 124)
        lstResults.TabIndex = 1
        ' 
        ' btnParse
        ' 
        btnParse.Location = New Point(216, 364)
        btnParse.Name = "btnParse"
        btnParse.Size = New Size(122, 38)
        btnParse.TabIndex = 2
        btnParse.Text = "Lexical Analysis"
        btnParse.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(52, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 20)
        Label1.TabIndex = 4
        Label1.Text = "Enter Expression"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(52, 192)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 20)
        Label2.TabIndex = 5
        Label2.Text = "Results"
        ' 
        ' btnParse2
        ' 
        btnParse2.Location = New Point(455, 364)
        btnParse2.Name = "btnParse2"
        btnParse2.Size = New Size(125, 38)
        btnParse2.TabIndex = 6
        btnParse2.Text = "Syntax Analysis"
        btnParse2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnParse2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnParse)
        Controls.Add(lstResults)
        Controls.Add(txtSentence)
        Name = "Form1"
        Text = "Mini Project"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtSentence As TextBox
    Friend WithEvents lstResults As ListBox
    Friend WithEvents btnParse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnParse2 As Button

End Class
