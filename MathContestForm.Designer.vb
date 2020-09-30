<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathContestForm
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
        Me.StudentInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.ButtonGroupBox = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ProblemTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.DivideRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubtractRadioButton = New System.Windows.Forms.RadioButton()
        Me.AddRadioButton = New System.Windows.Forms.RadioButton()
        Me.MathProblemGroupBox = New System.Windows.Forms.GroupBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.FirstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.SecondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.AnswerTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNumberLabel = New System.Windows.Forms.Label()
        Me.SecondNumberLabel = New System.Windows.Forms.Label()
        Me.AnswerLabel = New System.Windows.Forms.Label()
        Me.StudentInfoGroupBox.SuspendLayout()
        Me.ButtonGroupBox.SuspendLayout()
        Me.ProblemTypeGroupBox.SuspendLayout()
        Me.MathProblemGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudentInfoGroupBox
        '
        Me.StudentInfoGroupBox.Controls.Add(Me.GradeLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.GradeTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.AgeLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.AgeTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.NameLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.NameTextBox)
        Me.StudentInfoGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.StudentInfoGroupBox.Name = "StudentInfoGroupBox"
        Me.StudentInfoGroupBox.Size = New System.Drawing.Size(517, 100)
        Me.StudentInfoGroupBox.TabIndex = 0
        Me.StudentInfoGroupBox.TabStop = False
        Me.StudentInfoGroupBox.Text = "Student Information"
        '
        'ButtonGroupBox
        '
        Me.ButtonGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonGroupBox.Controls.Add(Me.SummaryButton)
        Me.ButtonGroupBox.Controls.Add(Me.ClearButton)
        Me.ButtonGroupBox.Controls.Add(Me.SubmitButton)
        Me.ButtonGroupBox.Location = New System.Drawing.Point(535, 12)
        Me.ButtonGroupBox.Name = "ButtonGroupBox"
        Me.ButtonGroupBox.Size = New System.Drawing.Size(253, 418)
        Me.ButtonGroupBox.TabIndex = 1
        Me.ButtonGroupBox.TabStop = False
        Me.ButtonGroupBox.Text = " "
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(18, 276)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(229, 79)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Enabled = False
        Me.SummaryButton.Location = New System.Drawing.Point(18, 191)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(229, 79)
        Me.SummaryButton.TabIndex = 2
        Me.SummaryButton.Text = "Summary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(18, 106)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(229, 79)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Enabled = False
        Me.SubmitButton.Location = New System.Drawing.Point(18, 21)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(229, 79)
        Me.SubmitButton.TabIndex = 0
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ProblemTypeGroupBox
        '
        Me.ProblemTypeGroupBox.Controls.Add(Me.DivideRadioButton)
        Me.ProblemTypeGroupBox.Controls.Add(Me.MultiplyRadioButton)
        Me.ProblemTypeGroupBox.Controls.Add(Me.SubtractRadioButton)
        Me.ProblemTypeGroupBox.Controls.Add(Me.AddRadioButton)
        Me.ProblemTypeGroupBox.Location = New System.Drawing.Point(277, 118)
        Me.ProblemTypeGroupBox.Name = "ProblemTypeGroupBox"
        Me.ProblemTypeGroupBox.Size = New System.Drawing.Size(252, 312)
        Me.ProblemTypeGroupBox.TabIndex = 2
        Me.ProblemTypeGroupBox.TabStop = False
        Me.ProblemTypeGroupBox.Text = "Math Problem Type"
        '
        'DivideRadioButton
        '
        Me.DivideRadioButton.AutoSize = True
        Me.DivideRadioButton.Location = New System.Drawing.Point(15, 114)
        Me.DivideRadioButton.Name = "DivideRadioButton"
        Me.DivideRadioButton.Size = New System.Drawing.Size(68, 21)
        Me.DivideRadioButton.TabIndex = 3
        Me.DivideRadioButton.TabStop = True
        Me.DivideRadioButton.Text = "Divide"
        Me.DivideRadioButton.UseVisualStyleBackColor = True
        '
        'MultiplyRadioButton
        '
        Me.MultiplyRadioButton.AutoSize = True
        Me.MultiplyRadioButton.Location = New System.Drawing.Point(15, 87)
        Me.MultiplyRadioButton.Name = "MultiplyRadioButton"
        Me.MultiplyRadioButton.Size = New System.Drawing.Size(76, 21)
        Me.MultiplyRadioButton.TabIndex = 2
        Me.MultiplyRadioButton.TabStop = True
        Me.MultiplyRadioButton.Text = "Multiply"
        Me.MultiplyRadioButton.UseVisualStyleBackColor = True
        '
        'SubtractRadioButton
        '
        Me.SubtractRadioButton.AutoSize = True
        Me.SubtractRadioButton.Location = New System.Drawing.Point(15, 58)
        Me.SubtractRadioButton.Name = "SubtractRadioButton"
        Me.SubtractRadioButton.Size = New System.Drawing.Size(82, 21)
        Me.SubtractRadioButton.TabIndex = 1
        Me.SubtractRadioButton.TabStop = True
        Me.SubtractRadioButton.Text = "Subtract"
        Me.SubtractRadioButton.UseVisualStyleBackColor = True
        '
        'AddRadioButton
        '
        Me.AddRadioButton.AutoSize = True
        Me.AddRadioButton.Location = New System.Drawing.Point(15, 31)
        Me.AddRadioButton.Name = "AddRadioButton"
        Me.AddRadioButton.Size = New System.Drawing.Size(54, 21)
        Me.AddRadioButton.TabIndex = 0
        Me.AddRadioButton.TabStop = True
        Me.AddRadioButton.Text = "Add"
        Me.AddRadioButton.UseVisualStyleBackColor = True
        '
        'MathProblemGroupBox
        '
        Me.MathProblemGroupBox.Controls.Add(Me.AnswerLabel)
        Me.MathProblemGroupBox.Controls.Add(Me.SecondNumberLabel)
        Me.MathProblemGroupBox.Controls.Add(Me.FirstNumberLabel)
        Me.MathProblemGroupBox.Controls.Add(Me.AnswerTextBox)
        Me.MathProblemGroupBox.Controls.Add(Me.SecondNumberTextBox)
        Me.MathProblemGroupBox.Controls.Add(Me.FirstNumberTextBox)
        Me.MathProblemGroupBox.Location = New System.Drawing.Point(12, 118)
        Me.MathProblemGroupBox.Name = "MathProblemGroupBox"
        Me.MathProblemGroupBox.Size = New System.Drawing.Size(259, 312)
        Me.MathProblemGroupBox.TabIndex = 0
        Me.MathProblemGroupBox.TabStop = False
        Me.MathProblemGroupBox.Text = "Current Math Problem"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(16, 49)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(243, 22)
        Me.NameTextBox.TabIndex = 0
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(13, 29)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(45, 17)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "Name"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(280, 49)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(40, 22)
        Me.AgeTextBox.TabIndex = 2
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(277, 29)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(33, 17)
        Me.AgeLabel.TabIndex = 3
        Me.AgeLabel.Text = "Age"
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Location = New System.Drawing.Point(344, 49)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(40, 22)
        Me.GradeTextBox.TabIndex = 4
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(341, 29)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(48, 17)
        Me.GradeLabel.TabIndex = 5
        Me.GradeLabel.Text = "Grade"
        '
        'FirstNumberTextBox
        '
        Me.FirstNumberTextBox.Location = New System.Drawing.Point(6, 57)
        Me.FirstNumberTextBox.Name = "FirstNumberTextBox"
        Me.FirstNumberTextBox.Size = New System.Drawing.Size(187, 22)
        Me.FirstNumberTextBox.TabIndex = 0
        '
        'SecondNumberTextBox
        '
        Me.SecondNumberTextBox.Location = New System.Drawing.Point(6, 113)
        Me.SecondNumberTextBox.Name = "SecondNumberTextBox"
        Me.SecondNumberTextBox.Size = New System.Drawing.Size(187, 22)
        Me.SecondNumberTextBox.TabIndex = 1
        '
        'AnswerTextBox
        '
        Me.AnswerTextBox.Location = New System.Drawing.Point(6, 170)
        Me.AnswerTextBox.Name = "AnswerTextBox"
        Me.AnswerTextBox.Size = New System.Drawing.Size(187, 22)
        Me.AnswerTextBox.TabIndex = 2
        '
        'FirstNumberLabel
        '
        Me.FirstNumberLabel.AutoSize = True
        Me.FirstNumberLabel.Location = New System.Drawing.Point(3, 37)
        Me.FirstNumberLabel.Name = "FirstNumberLabel"
        Me.FirstNumberLabel.Size = New System.Drawing.Size(81, 17)
        Me.FirstNumberLabel.TabIndex = 4
        Me.FirstNumberLabel.Text = "1st Number"
        '
        'SecondNumberLabel
        '
        Me.SecondNumberLabel.AutoSize = True
        Me.SecondNumberLabel.Location = New System.Drawing.Point(3, 93)
        Me.SecondNumberLabel.Name = "SecondNumberLabel"
        Me.SecondNumberLabel.Size = New System.Drawing.Size(86, 17)
        Me.SecondNumberLabel.TabIndex = 4
        Me.SecondNumberLabel.Text = "2nd Number"
        '
        'AnswerLabel
        '
        Me.AnswerLabel.AutoSize = True
        Me.AnswerLabel.Location = New System.Drawing.Point(3, 150)
        Me.AnswerLabel.Name = "AnswerLabel"
        Me.AnswerLabel.Size = New System.Drawing.Size(107, 17)
        Me.AnswerLabel.TabIndex = 4
        Me.AnswerLabel.Text = "Student Answer"
        '
        'MathContestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MathProblemGroupBox)
        Me.Controls.Add(Me.ProblemTypeGroupBox)
        Me.Controls.Add(Me.ButtonGroupBox)
        Me.Controls.Add(Me.StudentInfoGroupBox)
        Me.Name = "MathContestForm"
        Me.Text = "Math Contest"
        Me.StudentInfoGroupBox.ResumeLayout(False)
        Me.StudentInfoGroupBox.PerformLayout()
        Me.ButtonGroupBox.ResumeLayout(False)
        Me.ProblemTypeGroupBox.ResumeLayout(False)
        Me.ProblemTypeGroupBox.PerformLayout()
        Me.MathProblemGroupBox.ResumeLayout(False)
        Me.MathProblemGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentInfoGroupBox As GroupBox
    Friend WithEvents ButtonGroupBox As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents ProblemTypeGroupBox As GroupBox
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents SubtractRadioButton As RadioButton
    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents MathProblemGroupBox As GroupBox
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents GradeLabel As Label
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents AgeLabel As Label
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AnswerLabel As Label
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents FirstNumberLabel As Label
    Friend WithEvents AnswerTextBox As TextBox
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents FirstNumberTextBox As TextBox
End Class
