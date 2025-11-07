<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblPromt = New System.Windows.Forms.Label()
        Me.txtNumbers = New System.Windows.Forms.TextBox()
        Me.Sorted = New System.Windows.Forms.ListBox()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPromt
        '
        Me.lblPromt.AutoSize = True
        Me.lblPromt.Location = New System.Drawing.Point(93, 9)
        Me.lblPromt.Name = "lblPromt"
        Me.lblPromt.Size = New System.Drawing.Size(77, 13)
        Me.lblPromt.TabIndex = 0
        Me.lblPromt.Text = "Enter Numbers"
        '
        'txtNumbers
        '
        Me.txtNumbers.Location = New System.Drawing.Point(12, 25)
        Me.txtNumbers.Name = "txtNumbers"
        Me.txtNumbers.Size = New System.Drawing.Size(254, 20)
        Me.txtNumbers.TabIndex = 1
        '
        'Sorted
        '
        Me.Sorted.FormattingEnabled = True
        Me.Sorted.Location = New System.Drawing.Point(12, 51)
        Me.Sorted.Name = "Sorted"
        Me.Sorted.Size = New System.Drawing.Size(311, 95)
        Me.Sorted.TabIndex = 3
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(272, 25)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(75, 23)
        Me.btnWrite.TabIndex = 4
        Me.btnWrite.Text = "Add"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(106, 152)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(75, 23)
        Me.btnRead.TabIndex = 5
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 196)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnWrite)
        Me.Controls.Add(Me.Sorted)
        Me.Controls.Add(Me.txtNumbers)
        Me.Controls.Add(Me.lblPromt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPromt As Label
    Friend WithEvents txtNumbers As TextBox
    Friend WithEvents Sorted As ListBox
    Friend WithEvents btnWrite As Button
    Friend WithEvents btnRead As Button
End Class
