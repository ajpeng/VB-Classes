<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLineTest
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLine = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.btnGetWord = New System.Windows.Forms.Button()
        Me.textWord = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Line of Text"
        '
        'txtLine
        '
        Me.txtLine.Location = New System.Drawing.Point(206, 20)
        Me.txtLine.Name = "txtLine"
        Me.txtLine.Size = New System.Drawing.Size(361, 22)
        Me.txtLine.TabIndex = 1
        Me.txtLine.Text = "The rain in Spain stays mainly in the plain"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(31, 63)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(118, 42)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "Display Length"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(206, 63)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.ReadOnly = True
        Me.txtLength.Size = New System.Drawing.Size(361, 22)
        Me.txtLength.TabIndex = 3
        '
        'btnGetWord
        '
        Me.btnGetWord.Location = New System.Drawing.Point(31, 121)
        Me.btnGetWord.Name = "btnGetWord"
        Me.btnGetWord.Size = New System.Drawing.Size(118, 40)
        Me.btnGetWord.TabIndex = 4
        Me.btnGetWord.Text = "Get Word"
        Me.btnGetWord.UseVisualStyleBackColor = True
        '
        'textWord
        '
        Me.textWord.Location = New System.Drawing.Point(206, 121)
        Me.textWord.Name = "textWord"
        Me.textWord.ReadOnly = True
        Me.textWord.Size = New System.Drawing.Size(365, 22)
        Me.textWord.TabIndex = 5
        '
        'frmLineTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 253)
        Me.Controls.Add(Me.textWord)
        Me.Controls.Add(Me.btnGetWord)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtLine)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLineTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtLine As TextBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents txtLength As TextBox
    Friend WithEvents btnGetWord As Button
    Friend WithEvents textWord As TextBox
End Class
