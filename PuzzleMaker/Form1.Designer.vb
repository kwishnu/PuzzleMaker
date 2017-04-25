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
        Me.components = New System.ComponentModel.Container()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.txtFrag = New System.Windows.Forms.TextBox()
        Me.txtClue = New System.Windows.Forms.TextBox()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbnTheme = New System.Windows.Forms.RadioButton()
        Me.rbnHard = New System.Windows.Forms.RadioButton()
        Me.rbnMedium = New System.Windows.Forms.RadioButton()
        Me.rbnEasy = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNumPuzzles = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.btnLoadWords = New System.Windows.Forms.Button()
        Me.lblHowMany = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblWords = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(736, 313)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(136, 71)
        Me.btnEnter.TabIndex = 3
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'txtFrag
        '
        Me.txtFrag.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrag.Location = New System.Drawing.Point(774, 37)
        Me.txtFrag.Name = "txtFrag"
        Me.txtFrag.Size = New System.Drawing.Size(100, 38)
        Me.txtFrag.TabIndex = 0
        '
        'txtClue
        '
        Me.txtClue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClue.Location = New System.Drawing.Point(232, 178)
        Me.txtClue.Multiline = True
        Me.txtClue.Name = "txtClue"
        Me.txtClue.Size = New System.Drawing.Size(648, 67)
        Me.txtClue.TabIndex = 2
        '
        'txtWord
        '
        Me.txtWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWord.Location = New System.Drawing.Point(37, 178)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(179, 35)
        Me.txtWord.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 300
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Word"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Clue"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(782, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "keyFrag"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(103, 381)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 25)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Puzzle Type"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbnTheme)
        Me.GroupBox1.Controls.Add(Me.rbnHard)
        Me.GroupBox1.Controls.Add(Me.rbnMedium)
        Me.GroupBox1.Controls.Add(Me.rbnEasy)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 323)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 54)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'rbnTheme
        '
        Me.rbnTheme.AutoSize = True
        Me.rbnTheme.Location = New System.Drawing.Point(196, 11)
        Me.rbnTheme.Name = "rbnTheme"
        Me.rbnTheme.Size = New System.Drawing.Size(56, 29)
        Me.rbnTheme.TabIndex = 0
        Me.rbnTheme.Text = "T"
        Me.rbnTheme.UseVisualStyleBackColor = True
        '
        'rbnHard
        '
        Me.rbnHard.AutoSize = True
        Me.rbnHard.Location = New System.Drawing.Point(133, 11)
        Me.rbnHard.Name = "rbnHard"
        Me.rbnHard.Size = New System.Drawing.Size(58, 29)
        Me.rbnHard.TabIndex = 0
        Me.rbnHard.Text = "H"
        Me.rbnHard.UseVisualStyleBackColor = True
        '
        'rbnMedium
        '
        Me.rbnMedium.AutoSize = True
        Me.rbnMedium.Location = New System.Drawing.Point(70, 11)
        Me.rbnMedium.Name = "rbnMedium"
        Me.rbnMedium.Size = New System.Drawing.Size(61, 29)
        Me.rbnMedium.TabIndex = 0
        Me.rbnMedium.Text = "M"
        Me.rbnMedium.UseVisualStyleBackColor = True
        '
        'rbnEasy
        '
        Me.rbnEasy.AutoSize = True
        Me.rbnEasy.Location = New System.Drawing.Point(7, 11)
        Me.rbnEasy.Name = "rbnEasy"
        Me.rbnEasy.Size = New System.Drawing.Size(57, 29)
        Me.rbnEasy.TabIndex = 0
        Me.rbnEasy.Text = "E"
        Me.rbnEasy.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(514, 377)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 25)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "puzzles"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(348, 377)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 25)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "letters"
        '
        'lblNumPuzzles
        '
        Me.lblNumPuzzles.AutoSize = True
        Me.lblNumPuzzles.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumPuzzles.Location = New System.Drawing.Point(535, 335)
        Me.lblNumPuzzles.Name = "lblNumPuzzles"
        Me.lblNumPuzzles.Size = New System.Drawing.Size(39, 42)
        Me.lblNumPuzzles.TabIndex = 26
        Me.lblNumPuzzles.Text = "0"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(363, 335)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(39, 42)
        Me.lblCount.TabIndex = 27
        Me.lblCount.Text = "0"
        '
        'btnLoadWords
        '
        Me.btnLoadWords.Location = New System.Drawing.Point(774, 123)
        Me.btnLoadWords.Name = "btnLoadWords"
        Me.btnLoadWords.Size = New System.Drawing.Size(100, 38)
        Me.btnLoadWords.TabIndex = 30
        Me.btnLoadWords.TabStop = False
        Me.btnLoadWords.Text = "Load"
        Me.btnLoadWords.UseVisualStyleBackColor = True
        '
        'lblHowMany
        '
        Me.lblHowMany.AutoSize = True
        Me.lblHowMany.Location = New System.Drawing.Point(820, 9)
        Me.lblHowMany.Name = "lblHowMany"
        Me.lblHowMany.Size = New System.Drawing.Size(0, 25)
        Me.lblHowMany.TabIndex = 31
        Me.lblHowMany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(434, 377)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 25)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "words"
        '
        'lblWords
        '
        Me.lblWords.AutoSize = True
        Me.lblWords.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWords.Location = New System.Drawing.Point(449, 335)
        Me.lblWords.Name = "lblWords"
        Me.lblWords.Size = New System.Drawing.Size(39, 42)
        Me.lblWords.TabIndex = 32
        Me.lblWords.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(479, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 25)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Max"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(400, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 25)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Min"
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMax.Location = New System.Drawing.Point(488, 31)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(39, 42)
        Me.lblMax.TabIndex = 40
        Me.lblMax.Text = "0"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.Location = New System.Drawing.Point(406, 31)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(39, 42)
        Me.lblMin.TabIndex = 41
        Me.lblMin.Text = "0"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 431)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblWords)
        Me.Controls.Add(Me.lblHowMany)
        Me.Controls.Add(Me.btnLoadWords)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblNumPuzzles)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtClue)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.txtFrag)
        Me.Controls.Add(Me.btnEnter)
        Me.Name = "Form1"
        Me.Text = "PuzzleMaker"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents txtFrag As TextBox
    Friend WithEvents txtClue As TextBox
    Friend WithEvents txtWord As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbnTheme As RadioButton
    Friend WithEvents rbnHard As RadioButton
    Friend WithEvents rbnMedium As RadioButton
    Friend WithEvents rbnEasy As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNumPuzzles As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents btnLoadWords As Button
    Friend WithEvents lblHowMany As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblWords As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblMax As Label
    Friend WithEvents lblMin As Label
End Class
