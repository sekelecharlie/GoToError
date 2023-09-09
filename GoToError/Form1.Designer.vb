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
        btnGoToError = New Button()
        txtUserInput = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnGoToError
        ' 
        btnGoToError.Location = New Point(343, 167)
        btnGoToError.Name = "btnGoToError"
        btnGoToError.Size = New Size(150, 59)
        btnGoToError.TabIndex = 0
        btnGoToError.Text = "Enter"
        btnGoToError.UseVisualStyleBackColor = True
        ' 
        ' txtUserInput
        ' 
        txtUserInput.Location = New Point(343, 107)
        txtUserInput.Name = "txtUserInput"
        txtUserInput.Size = New Size(150, 31)
        txtUserInput.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(167, 113)
        Label1.Name = "Label1"
        Label1.Size = New Size(139, 25)
        Label1.TabIndex = 2
        Label1.Text = "Enter your value"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(txtUserInput)
        Controls.Add(btnGoToError)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnGoToError As Button
    Friend WithEvents txtUserInput As TextBox
    Friend WithEvents Label1 As Label
End Class
